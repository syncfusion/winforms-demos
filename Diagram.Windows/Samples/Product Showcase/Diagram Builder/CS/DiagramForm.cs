#region Copyright Syncfusion Inc. 2001 - 2019
//
//  Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using Syncfusion.Windows.Forms.Diagram.Controls;
using Syncfusion.Windows.Forms.Diagram;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Xml;

namespace Syncfusion.Windows.Forms.Diagram.Samples.DiagramTool
{
    /// <summary>
    /// Summary description for DiagramForm.
    /// </summary>
    public partial class DiagramForm
        : Form
    {
        bool needSave = false;

        AssociatedSymbolPaletteInfoCollection symbolPaletteInfo;
        public DiagramForm(Form mdiParent)
        {
            InitializeComponent();
            this.MdiParent = mdiParent;
            this.diagramComponent.Model = this.document;
            symbolPaletteInfo = new AssociatedSymbolPaletteInfoCollection();
            //
            // Wire up event handlers to canvas
            //
            ((DiagramViewerEventSink)diagramComponent.EventSink).ToolActivated += new ToolEventHandler(DiagramForm_ToolActivated);
            
            // Load up names of fonts that can be selected
            this.LoadFontSelections();

            // Feedback with TextFormatting toolbar
            this.diagramComponent.Controller.TextEditor.FormatChanged += new EventHandler(FormatChanged);
            Application.Idle += new EventHandler(Application_Idle);

            this.Diagram.DragOver += delegate(object msender2, DragEventArgs dArgs)
            {
                dArgs.Effect = DragDropEffects.All;
            };

            this.Diagram.DragDrop += new DragEventHandler(Diagram_DragDrop);
        }

        void Diagram_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("Syncfusion.Windows.Forms.Diagram.Samples.DiagramTool.SymbolPaletteInfo"))
            {
                object obj = e.Data.GetData("Syncfusion.Windows.Forms.Diagram.Samples.DiagramTool.SymbolPaletteInfo");
                if (obj != null)
                {
                    SymbolPaletteInfo sInfo = obj as SymbolPaletteInfo;
                    if (!CheckAssociatedSymbolPaletteInfo(sInfo))
                    {
                        //prompt dialog to add the symbol palette to the associated list
                        DialogResult dr = MessageBoxAdv.Show("The SymbolPalette " + sInfo.SymbolPaletteName + " is not present in your Associated lists of Palette's. Click OK to add it", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (dr == DialogResult.OK)
                        {
                            AssociatedSymbolPaletteInfo aInfo = GetAssociatedSymbolPaletteInfo();
                            if (aInfo == null)
                            {
                                aInfo = new AssociatedSymbolPaletteInfo();
                                aInfo.EDDFileName = this.fileName;
                                symbolPaletteInfo.Add(aInfo);
                            }
                            aInfo.SymbolPaletteInfo.Add(sInfo);
                            this.MDIParentForm.UpdateAssociatedSymbolsList();
                        }
                    }
                }
            }
        }

        private bool CheckAssociatedSymbolPaletteInfo(SymbolPaletteInfo infoItem)
        {
            foreach (AssociatedSymbolPaletteInfo aInfo in symbolPaletteInfo)
            {
                for (int i = 0; i < aInfo.SymbolPaletteInfo.Count; i++)
                {
                    if (aInfo.SymbolPaletteInfo[i].SymbolPaletteName == infoItem.SymbolPaletteName)
                        return true;
                }
            }
            return false;
        }

        private AssociatedSymbolPaletteInfo GetAssociatedSymbolPaletteInfo()
        {
            AssociatedSymbolPaletteInfo aInfo = null;
            foreach (AssociatedSymbolPaletteInfo info in this.symbolPaletteInfo)
                if (info.EDDFileName == this.FileName)
                {
                    aInfo = info;
                    break;
                }
            return aInfo;
        }

        public void OpenFile(string strFileName)
        {
            if (File.Exists(strFileName))
            {
                diagramComponent.LoadBinary(strFileName);
                this.FileName = strFileName;
            }
        }

        public void SaveFile()
        {
            if (!this.HasFileName)
            {
                throw new InvalidOperationException();
            }
            this.SaveAsFile(this.fileName);
        }


        public void SaveAsFile(string strFileName)
        {
            FileStream oStream = null;
            try
            {
                oStream = new FileStream(strFileName, FileMode.Create);
            }
            catch (Exception ex)
            {
                oStream = null;  // just to be sure
                MessageBoxAdv.Show("Error opening " + strFileName + " - " + ex.Message);
            }

            if (oStream != null)
            {
                try
                {
                    diagramComponent.SaveBinary(oStream);
                    // Save the DiagramScript object to the serialization stream along with the diagram document
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Binder = Syncfusion.Runtime.Serialization.AppStateSerializer.CustomBinder;
                    formatter.AssemblyFormat = FormatterAssemblyStyle.Simple;
                    foreach (AssociatedSymbolPaletteInfo aInfo in symbolPaletteInfo)
                        aInfo.EDDFileName = Path.GetFileNameWithoutExtension(this.fileName);
                    Hashtable nameValuePair = new Hashtable();
                    nameValuePair.Add("PaletteAssociationList", symbolPaletteInfo);
                    formatter.Serialize(oStream, nameValuePair);
                    this.FileName = strFileName;
                }
                catch (Exception ex)
                {
                    MessageBoxAdv.Show("Serialization error - " + ex.Message);
                }
                finally
                {
                    oStream.Close();
                }
            }
        }

        #region Class events

        #region DiagramForm
        /// <summary>
        /// Handles the Load event of the DiagramForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void DiagramForm_Load(object sender, EventArgs e)
        {
            this.diagramComponent.View.Grid.Visible = true;
            this.barItemShowGrid.Checked = this.diagramComponent.View.Grid.Visible;
            this.barItemSnapToGrid.Checked = this.diagramComponent.View.Grid.SnapToGrid;
            UpdateMagnificationComboBox();

            // Set Active SelectTool
            this.ActiveToolBarItem = this.barItemSelect;

            // Populate Tools Hashtable
            this.Tools.Add("SelectTool", this.barItemSelect);
            this.Tools.Add("RectangleTool", this.barItemRectangle);
            this.Tools.Add("ConnectionPointTool", this.barItemPort);
            this.Tools.Add("PencilTool", this.barItemPenciltool);
            this.Tools.Add("BezierTool", this.barItemBezier);
            this.Tools.Add("SplineTool", this.barItemSpline);
            this.Tools.Add("BitmapTool", this.barItemImage);
            this.Tools.Add("InsertNodeTool", this.barItemCircularArc);
            this.Tools.Add("SemiCircleTool", this.barItemSemiCircle);
            this.Tools.Add("ClosedCurveTool", this.barItemClosedCurve);
            this.Tools.Add("CurveTool", this.barItemCurve);
            this.Tools.Add("EllipseTool", this.barItemEllipse);
            this.Tools.Add("RoundRectTool", this.barItemRoundRect);
            this.Tools.Add("LineTool", this.barItemLine);
            this.Tools.Add("RichTextTool", this.barItemRichText);
            this.Tools.Add("TextTool", this.barItemText);
            this.Tools.Add("ZoomTool", this.barItemZoom);
            this.Tools.Add("PanTool", this.barItemPan);
            this.Tools.Add("PolygonTool", this.barItemPolygon);
            this.Tools.Add("PolyLineTool", this.barItemPolyline);
            this.Tools.Add("LineLinkTool", this.barItemLink);
            this.Tools.Add("OrthogonalLinkTool", this.barItemOrthogonalLink);
            this.Tools.Add("OrgLineConnectorTool", this.barItemOrgLineLink);
            this.Tools.Add("DirectedLineLinkTool", this.barItemDirectedLink);
            this.Tools.Add("PolylineLinkTool", this.barItemPolylineLink);
            SetActiveTool((Tool)null);

            diagramComponent.EventSink.SelectionListChanged += new CollectionExEventHandler(OnSelectionChanged);
            diagramComponent.EventSink.PropertyChanged += new PropertyChangedEventHandler(View_PropertyChanged);

            // Set focus to the diagram control
            diagramComponent.Focus();

            // To add a toolTip through code
            toolTipInfo = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            // Customize SuperToolTip values..
            toolTipInfo.BackColor = SystemColors.Control;
            toolTipInfo.Body.Text = "Set EnableCentralPort property of the Node to True,\r\nto establish connection between nodes";
            toolTipInfo.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo.Header.Text = "Need To Enable Node's CentralPort !!!";
            toolTipInfo.Header.TextAlign = ContentAlignment.MiddleCenter;
            DiagramAppearance();
        }

        public void DiagramAppearance()
        {
            diagramComponent.Controller.Guides.LineStyle.LineColor = Color.FromArgb(255, 153, 51);
            diagramComponent.View.Grid.GridStyle = GridStyle.Line;
            diagramComponent.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            diagramComponent.View.Grid.Color = Color.LightGray;
            diagramComponent.View.Grid.VerticalSpacing = 15;
            diagramComponent.View.Grid.HorizontalSpacing = 15;
            diagramComponent.Model.BackgroundStyle.GradientCenter = 0.5f;
            diagramComponent.View.HandleRenderer.HandleColor = Color.BlanchedAlmond;
            diagramComponent.View.HandleRenderer.HandleOutlineColor = Color.Orange;
            diagramComponent.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            diagramComponent.View.SelectionList.Clear();
        }

        [EventHandlerPriorityAttribute(true)]
        private void DiagramForm_ToolActivated(ToolEventArgs evtArgs)
        {
            if (evtArgs.Tool.Name != null)
            {
                string strTool = evtArgs.Tool.Name;

                if (strTool != null && this.Tools.Contains(strTool))
                {
                    this.ActiveToolBarItem = this.Tools[strTool] as BarItem;
                }
                if (strTool.Equals("LineLinkTool") || strTool.Equals("DirectedLineLinkTool") || (strTool.Equals("OrthogonalLinkTool")))
                {
                    this.superToolTip1.Show(this.toolTipInfo, new Point(MousePosition.X, MousePosition.Y), 3000);
                }
            }
        }
        /// <summary>
        /// Handles the Closing event of the DiagramForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.ComponentModel.CancelEventArgs"/> instance containing the event data.</param>
        private void DiagramForm_Closing(object sender, CancelEventArgs e)
        {
            if (this.diagramComponent.Model.Modified)
            {
                needSave = true;
                PropertyEditor propEditor = this.PropertyEditor;
                if (propEditor != null)
                {
                    propEditor.Diagram = null;
                }
            }
        }

        [EventHandlerPriorityAttribute(true)]
        protected void OnSelectionChanged(CollectionExEventArgs evtArgs)
        {
            DiagramController controller = this.diagramComponent.Controller;

            if (controller != null)
            {
                if (controller.SelectionList != null)
                {
                    // Check for grouping and ungrouping tools available.
                    bool bGroupAvailable = false;
                    bool bGroupPresent = false;

                    if (controller.View.SelectionList.Count >= 2)
                        bGroupAvailable = true;

                    foreach (Node curNode in controller.View.SelectionList)
                    {
                        // Check for groups.
                        if (curNode is Group)
                        {
                            bGroupPresent = true;
                            break;
                        }
                    }

                    // Update group and ungroup tools.
                    this.barItemGroup.Enabled = bGroupAvailable;
                    this.barItemUngroup.Enabled = bGroupPresent;

                    SelectionFormat fmtSelection = controller.TextEditor.GetSelectionFormat(false);

                    if (fmtSelection.Valid)
                    {
                        // 1 - FontStyles
                        // Bold
                        barItemBoldText.Checked =
                            ((fmtSelection.FontStyle & System.Drawing.FontStyle.Bold) == System.Drawing.FontStyle.Bold) ? true : false;
                        // Underline
                        barItemUnderlineText.Checked =
                            ((fmtSelection.FontStyle & System.Drawing.FontStyle.Underline) == System.Drawing.FontStyle.Underline) ? true : false;
                        // Italic
                        barItemItalicText.Checked =
                            ((fmtSelection.FontStyle & System.Drawing.FontStyle.Italic) == System.Drawing.FontStyle.Italic) ? true : false;
                        // Strikeout
                        barItemStrikeoutText.Checked =
                            ((fmtSelection.FontStyle & System.Drawing.FontStyle.Strikeout) == System.Drawing.FontStyle.Strikeout) ? true : false;

                        // 2 - Alignment
                        switch (fmtSelection.Alignment)
                        {
                            case StringAlignment.Near:
                                this.CurrentAlignment = this.barItemAlignTextLeft;
                                break;
                            case StringAlignment.Center:
                                this.CurrentAlignment = this.barItemCenterText;
                                break;
                            case StringAlignment.Far:
                                this.CurrentAlignment = this.barItemAlignTextRight;
                                break;
                        }

                        // 3 - FamilyName
                        this.comboBoxBarItemFontFamily.TextBoxValue = fmtSelection.FontFamily;

                        // 4 - FontHeight
                        if (fmtSelection.FontHeight == 0)
                            this.comboBoxBarItemPointSize.TextBoxValue = string.Empty;
                        else
                            this.comboBoxBarItemPointSize.TextBoxValue = fmtSelection.FontHeight.ToString();
                    }
                    else
                    {
                        barItemBoldText.Checked = false;
                        barItemItalicText.Checked = false;
                        barItemUnderlineText.Checked = false;
                        barItemStrikeoutText.Checked = false;
                    }
                }
            }
        }

        /// <summary>
        /// Updates the magnification combo box to view zoom factor.
        /// </summary>
        private void UpdateMagnificationComboBox()
        {
            this.comboBoxBarItemMagnification.TextBoxValue = this.diagramComponent.Magnification + "%";
        }
        /// <summary>
        /// Updates the text formatting for selected node.
        /// </summary>
        private void UpdateUITextFormatting()
        {
            DiagramController controller = this.diagramComponent.Controller;

            if (controller == null || controller.TextEditor == null)
                return;

            // Update FamilyName
            this.comboBoxBarItemFontFamily.TextBoxValue = controller.TextEditor.FamilyName;

            this.barItemBoldText.Checked = controller.TextEditor.Bold;
            this.barItemItalicText.Checked = controller.TextEditor.Italic;
            this.barItemUnderlineText.Checked = controller.TextEditor.Underline;

            // Update point size bar item
            float ptSize = controller.TextEditor.PointSize;

            if (ptSize == 0)
                this.comboBoxBarItemPointSize.TextBoxValue = string.Empty;
            else
                this.comboBoxBarItemPointSize.TextBoxValue = ptSize.ToString();

            // Update strikeout, superscript, subscript
            this.barItemStrikeoutText.Checked = controller.TextEditor.Strikeout;
            this.barItemSubscript.Checked = controller.TextEditor.Subscript;
            this.barItemSuperscript.Checked = controller.TextEditor.Superscript;

            // Update text alignment bar items
            StringAlignment horzAlign = controller.TextEditor.HorizontalAlignment;

            switch (horzAlign)
            {
                case StringAlignment.Near:
                    this.CurrentAlignment = this.barItemAlignTextLeft;
                    break;
                case StringAlignment.Center:
                    this.CurrentAlignment = this.barItemCenterText;
                    break;
                case StringAlignment.Far:
                    this.CurrentAlignment = this.barItemAlignTextRight;
                    break;
            }
        }

        /// <summary>
        /// Loads the font for selection nodes.
        /// </summary>
        private void LoadFontSelections()
        {
            // Create ListBox containing names of font families and attach it to the
            // font family combo box bar item
            this.comboBoxBarItemFontFamily.ListBox = new ListBox();
            foreach (FontFamily curFontFamily in FontFamily.Families)
            {
                this.comboBoxBarItemFontFamily.ListBox.Items.Add(curFontFamily.Name);
            }
            this.comboBoxBarItemFontFamily.ListBox.SelectedIndexChanged += new EventHandler(this.FontFamily_SelectedIndexChanged);

            // Create ListBox containing point sizes and attach to the point size combo
            // box bar item
            ListBox pointSizeListBox = new ListBox();
            int[] ptSizes = new int[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int ptSize in ptSizes)
            {
                pointSizeListBox.Items.Add(ptSize);
            }
            this.comboBoxBarItemPointSize.ListBox = pointSizeListBox;
            this.comboBoxBarItemPointSize.ListBox.SelectedIndexChanged += new EventHandler(this.PointSize_SelectedIndexChanged);
        }

        /// <summary>
        /// Get on current selecton list has textBoxNodes.
        /// </summary>
        /// <returns>true - one or more text nodes; false - none</returns>
        private bool CheckTextSelecionNode()
        {
            bool bResult = false;

            if (diagramComponent.Controller == null)
                return bResult;

            if (diagramComponent.Controller.TextEditor.IsEditing)
                bResult = true;
            else
            {
                NodeCollection selectionNodes = this.diagramComponent.Controller.SelectionList;

                if (selectionNodes != null)
                {
                    foreach (INode node in selectionNodes)
                    {
                        if (node is TextNode)
                        {
                            bResult = true;
                            break;
                        }
                    }
                }
            }

            return bResult;
        }
        #endregion

        #region View Tools
        private void barItemPan_Click(object sender, EventArgs e)
        {
            SetActiveTool("PanTool");
        }

        private void barItemShowGrid_Click(object sender, EventArgs e)
        {
            this.barItemShowGrid.Checked = !this.barItemShowGrid.Checked;
            this.diagramComponent.View.Grid.Visible = this.barItemShowGrid.Checked;
            this.diagramComponent.Invalidate(true);
        }

        private void barItemSnapToGrid_Click(object sender, EventArgs e)
        {
            this.barItemSnapToGrid.Checked = !this.barItemSnapToGrid.Checked;
            this.diagramComponent.View.Grid.SnapToGrid = this.barItemSnapToGrid.Checked;
        }

        private void comboBoxBarItemMagnification_Click(object sender, EventArgs e)
        {
            string strMagValue = this.comboBoxBarItemMagnification.TextBoxValue;
            int idxPctSign = strMagValue.IndexOf('%');
            if (idxPctSign >= 0)
            {
                strMagValue = strMagValue.Remove(idxPctSign, 1);
            }
            int magVal = Convert.ToInt32(strMagValue);
            this.diagramComponent.View.Magnification = magVal;
        }
        #endregion

        #region Order

        private void barItemBringToFront_Click(object sender, EventArgs e)
        {
            this.diagramComponent.Controller.BringToFront();
        }

        private void barItemSendToBack_Click(object sender, EventArgs e)
        {
            this.diagramComponent.Controller.SendToBack();
        }

        private void barItemBringForward_Click(object sender, EventArgs e)
        {
            this.diagramComponent.Controller.BringForward();
        }

        private void barItemSendBackward_Click(object sender, EventArgs e)
        {
            this.diagramComponent.Controller.SendBackward();
        }
        #endregion

        #region Nudge
        private void barItemNudgeUp_Click(object sender, EventArgs e)
        {
            this.diagramComponent.NudgeUp();
        }

        private void barItemNudgeDown_Click(object sender, EventArgs e)
        {
            this.diagramComponent.NudgeDown();
        }

        private void barItemNudgeLeft_Click(object sender, EventArgs e)
        {
            this.diagramComponent.NudgeLeft();
        }

        private void barItemNudgeRight_Click(object sender, EventArgs e)
        {
            this.diagramComponent.NudgeRight();
        }

        #endregion

        #region Rotate
        private void barItemRotateLeft_Click(object sender, EventArgs e)
        {
            this.diagramComponent.Rotate(-90);
        }

        private void barItemRotateRight_Click(object sender, EventArgs e)
        {
            this.diagramComponent.Rotate(90);
        }
        #endregion

        #region Flip
        private void barItemFlipVertical_Click(object sender, EventArgs e)
        {
            this.diagramComponent.FlipVertical();
        }
        private void barItemFlipHorizontal_Click(object sender, EventArgs e)
        {
            this.diagramComponent.FlipHorizontal();
        }

        private void mnuFlipBoth_Click(object sender, EventArgs e)
        {
            this.Diagram.FlipHorizontal();
            this.Diagram.FlipVertical();
        }
        #endregion

        private void mnuLayout_Click(object sender, EventArgs e)
        {
            LayoutDialog dialog = new LayoutDialog(this.Diagram);
            dialog.ShowDialog();
        }

        #region TextEditor

        private void FontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strFamilyName = this.comboBoxBarItemFontFamily.ListBox.SelectedItem.ToString();

            if (this.diagramComponent.Controller.TextEditor.FamilyName != strFamilyName)
                this.diagramComponent.Controller.TextEditor.FamilyName = strFamilyName;
        }
        private void PointSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIdx = this.comboBoxBarItemPointSize.ListBox.SelectedIndex;
            if (selectedIdx >= 0)
            {
                int ptSize = (int)this.comboBoxBarItemPointSize.ListBox.Items[selectedIdx];
                this.diagramComponent.Controller.TextEditor.PointSize = ptSize;
            }
        }

        private void barItemBoldText_Click(object sender, EventArgs e)
        {
            if (!CheckTextSelecionNode())
                return;

            bool newValue = !(this.diagramComponent.Controller.TextEditor.Bold);
            this.diagramComponent.Controller.TextEditor.Bold = newValue;
            this.barItemBoldText.Checked = newValue;
        }
        private void barItemItalicText_Click(object sender, EventArgs e)
        {
            if (!CheckTextSelecionNode())
                return;

            bool newValue = !(this.diagramComponent.Controller.TextEditor.Italic);
            this.diagramComponent.Controller.TextEditor.Italic = newValue;
            this.barItemItalicText.Checked = newValue;
        }
        private void barItemUnderlineText_Click(object sender, EventArgs e)
        {
            if (!CheckTextSelecionNode())
                return;

            bool newValue = !(this.diagramComponent.Controller.TextEditor.Underline);
            this.diagramComponent.Controller.TextEditor.Underline = newValue;
            this.barItemUnderlineText.Checked = newValue;
        }
        private void barItemStrikeoutText_Click(object sender, EventArgs e)
        {
            if (!CheckTextSelecionNode())
                return;

            bool newValue = !(this.diagramComponent.Controller.TextEditor.Strikeout);
            this.diagramComponent.Controller.TextEditor.Strikeout = newValue;
            this.barItemStrikeoutText.Checked = newValue;
        }
        private void barItemTextColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = this.diagramComponent.Controller.TextEditor.TextColor;
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                this.diagramComponent.Controller.TextEditor.TextColor = dlg.Color;
            }
        }
        private void barItemAlignTextLeft_Click(object sender, EventArgs e)
        {
            this.diagramComponent.Controller.TextEditor.HorizontalAlignment = StringAlignment.Near;
            this.barItemAlignTextLeft.Checked = true;
            this.barItemCenterText.Checked = false;
            this.barItemAlignTextRight.Checked = false;
        }
        private void barItemCenterText_Click(object sender, EventArgs e)
        {
            this.diagramComponent.Controller.TextEditor.HorizontalAlignment = StringAlignment.Center;
            this.barItemCenterText.Checked = true;
            this.barItemAlignTextLeft.Checked = false;
            this.barItemAlignTextRight.Checked = false;
        }
        private void barItemAlignTextRight_Click(object sender, EventArgs e)
        {
            this.diagramComponent.Controller.TextEditor.HorizontalAlignment = StringAlignment.Far;
            this.barItemAlignTextRight.Checked = true;
            this.barItemAlignTextLeft.Checked = false;
            this.barItemCenterText.Checked = false;
        }
        private void barItemSubscript_Click(object sender, EventArgs e)
        {
            bool newValue = !(this.diagramComponent.Controller.TextEditor.Subscript);
            this.diagramComponent.Controller.TextEditor.Subscript = newValue;
        }
        private void barItemSuperscript_Click(object sender, EventArgs e)
        {
            bool newValue = !(this.diagramComponent.Controller.TextEditor.Superscript);
            this.diagramComponent.Controller.TextEditor.Superscript = newValue;
        }
        private void barItemLower_Click(object sender, EventArgs e)
        {
            int nCurrentOffset = this.diagramComponent.Controller.TextEditor.CharOffset;
            nCurrentOffset--;
            this.diagramComponent.Controller.TextEditor.CharOffset = nCurrentOffset;
        }
        private void barItemUpper_Click(object sender, EventArgs e)
        {
            int nCurrentOffset = this.diagramComponent.Controller.TextEditor.CharOffset;
            nCurrentOffset++;
            this.diagramComponent.Controller.TextEditor.CharOffset = nCurrentOffset;
        }

        #endregion

        #region Group
        private void barItemGroup_Click(object sender, EventArgs e)
        {
            diagramComponent.Controller.Group();
        }

        private void barItemUngroup_Click(object sender, EventArgs e)
        {
            diagramComponent.Controller.UnGroup();
        }
        #endregion

        #region Drawing Tools

        private void barItemLinkSymbols_Click(object sender, EventArgs e)
        {
            SetActiveTool("LineLinkTool");

            BarItem barItemToSelect = sender as BarItem;

            if (barItemToSelect != null)
                this.ActiveToolBarItem = barItemToSelect;
        }

        private void BezierToolActivate(object sender, EventArgs e)
        {
            SetActiveTool("BezierTool");
        }
        private void LineToolActivate(object sender, EventArgs e)
        {
            SetActiveTool("LineTool");
        }

        private void RectangleToolActivate(object sender, EventArgs e)
        {
            SetActiveTool("RectangleTool");
        }

        private void barItemImage_Click(object sender, EventArgs e)
        {
            SetActiveTool("BitmapTool");
        }

        private void barItemOrthogonalLink_Click(object sender, EventArgs e)
        {
            SetActiveTool("OrthogonalLinkTool");

            BarItem barItemToSelect = sender as BarItem;

            if (barItemToSelect != null)
                this.ActiveToolBarItem = barItemToSelect;
        }

        private void barItemOrgLineLink_Click(object sender, EventArgs e)
        {
            SetActiveTool("OrgLineConnectorTool");

            BarItem barItemToSelect = sender as BarItem;

            if (barItemToSelect != null)
                this.ActiveToolBarItem = barItemToSelect;
        }

        private void barItemDirectedLink_Click(object sender, EventArgs e)
        {
            SetActiveTool("DirectedLineLinkTool");

            BarItem barItemToSelect = sender as BarItem;

            if (barItemToSelect != null)
                this.ActiveToolBarItem = barItemToSelect;
        }

        private void barItemPolylineLink_Click(object sender, EventArgs e)
        {
            SetActiveTool("PolylineLinkTool");

            BarItem barItemToSelect = sender as BarItem;

            if (barItemToSelect != null)
                this.ActiveToolBarItem = barItemToSelect;
        }

        private void EllipseToolActivate(object sender, EventArgs e)
        {
            SetActiveTool("EllipseTool");
        }

        private void SelectToolActivate(object sender, EventArgs e)
        {
            SetActiveTool("SelectTool");
        }

        private void ConnectionPointToolActivate(object sender, EventArgs e)
        {
            SetActiveTool("ConnectionPointTool");
        }

        private void PolygonToolActivate(object sender, EventArgs e)
        {
            SetActiveTool("PolygonTool");
        }

        private void PolylineToolActivate(object sender, EventArgs e)
        {
            SetActiveTool("PolyLineTool");
        }

        private void TextToolActivate(object sender, EventArgs e)
        {
            SetActiveTool("TextTool");
        }

        private void ArcToolActivate(object sender, EventArgs e)
        {
            SetActiveTool("SplineTool");
        }

        private void RoundedRectangleToolActivate(object sender, EventArgs e)
        {
            SetActiveTool("RoundRectTool");
        }

        private void CurveToolActivate(object sender, EventArgs e)
        {
            SetActiveTool("CurveTool");
        }

        private void ClosedCurveToolActivate(object sender, EventArgs e)
        {
            SetActiveTool("ClosedCurveTool");
        }
        private void CircularArcToolActivate(object sender, EventArgs e)
        {
            CircularArc arc = new CircularArc(new RectangleF(0, 0, 50, 50));
            diagramComponent.Controller.NodeToInsert = arc;
            SetActiveTool("InsertNodeTool");
        }

        private void SemiCircleToolActivate(object sender, EventArgs e)
        {
            SetActiveTool("SemiCircleTool");
        }
        private void RichTextToolActivate(object sender, EventArgs e)
        {
            SetActiveTool("RichTextTool");
        }

        private void ZoomToolActivate(object sender, EventArgs e)
        {
            SetActiveTool("ZoomTool");
        }

        private void SetActiveTool(Tool toolActive)
        {
            this.diagramComponent.Controller.ActiveTool = toolActive;
        }

        private void SetActiveTool(string toolName)
        {
            diagramComponent.Controller.ActivateTool(toolName);
        }

        #endregion

        private void FormatChanged(object sender, EventArgs e)
        {
            UpdateUITextFormatting();
        }

        [EventHandlerPriority(true)]
        private void View_PropertyChanged(PropertyChangedEventArgs evtArgs)
        {
            if (evtArgs.PropertyName == DPN.Magnification)
            {
                this.comboBoxBarItemMagnification.TextBoxValue = this.Diagram.View.Magnification.ToString() + "%";
            }
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            if (this.Diagram.Controller != null)
            {
                int count = this.Diagram.Controller.SelectionList.Count;
                // update context menu
                mnuAlgnLeft.Enabled = (count >= 2);
                mnuAlgnCenter.Enabled = (count >= 2);
                mnuAlgnRight.Enabled = (count >= 2);
                mnuAlgnTop.Enabled = (count >= 2);
                mnuAlgnMiddle.Enabled = (count >= 2);
                mnuAlgnBottom.Enabled = (count >= 2);
                mnuFlipHoriz.Enabled = (count > 0);
                mnuFlipVert.Enabled = (count > 0);
                mnuFlipBoth.Enabled = (count > 0);
                mnuGGroup.Enabled = (count > 1);
                mnuGUngroup.Enabled = true;
                mnuOrdBTF.Enabled = (count > 0);
                mnuOrdBF.Enabled = (count > 0);
                mnuOrdSB.Enabled = (count > 0);
                mnuOrdSTB.Enabled = (count > 0);
                mnuRtClockwise.Enabled = (count > 0);
                mnuRtCClockwise.Enabled = (count > 0);
                mnuRsSameWidth.Enabled = (count > 1);
                mnuRsSameHeight.Enabled = (count > 1);
                mnuRsSameSize.Enabled = (count > 1);
                mnuRsSpaseAcross.Enabled = (count > 1);
                mnuRsSpaceDown.Enabled = (count > 1);
            }
        }


        #region Layout bar
        private void barItemSpaceAcross_Click(object sender, EventArgs e)
        {
            this.diagramComponent.SpaceAcross();
        }
        private void barItemSpaceDown_Click(object sender, EventArgs e)
        {
            this.diagramComponent.SpaceDown();
        }
        private void barItemSameWidth_Click(object sender, EventArgs e)
        {
            this.diagramComponent.SameWidth();
        }
        private void barItemSameHeight_Click(object sender, EventArgs e)
        {
            this.diagramComponent.SameHeight();
        }
        private void barItemSameSize_Click(object sender, EventArgs e)
        {
            this.diagramComponent.SameSize();
        }
        #endregion

        #region Align bar
        private void barItemAlignLeft_Click(object sender, EventArgs e)
        {
            this.diagramComponent.AlignLeft();
        }
        private void barItemAlignCenter_Click(object sender, EventArgs e)
        {
            this.diagramComponent.AlignCenter();
        }
        private void barItemAlignRight_Click(object sender, EventArgs e)
        {
            this.diagramComponent.AlignRight();
        }
        private void barItemAlignTop_Click(object sender, EventArgs e)
        {
            this.diagramComponent.AlignTop();
        }
        private void barItemAlignMiddle_Click(object sender, EventArgs e)
        {
            this.diagramComponent.AlignMiddle();
        }
        private void barItemAlignBottom_Click(object sender, EventArgs e)
        {
            this.diagramComponent.AlignBottom();
        }
        #endregion

        #endregion

        #region fields
        private Hashtable m_hashControllerTools;
        private BarItem m_BaritemActiveTool;
        #endregion

        #region properties

        public Controls.Diagram Diagram
        {
            get
            {
                return this.diagramComponent;
            }
        }

        private BarItem CurrentAlignment
        {
            get
            {
                return m_biSelectedAlignment;
            }
            set
            {
                if (m_biSelectedAlignment != value)
                {
                    // Uncheck current.
                    if (m_biSelectedAlignment != null)
                        m_biSelectedAlignment.Checked = false;

                    // Set new value
                    m_biSelectedAlignment = value;

                    // Check new.
                    if (m_biSelectedAlignment != null)
                        m_biSelectedAlignment.Checked = true;
                }
            }
        }

        private MainForm MDIParentForm
        {
            get
            {
                return (MainForm)this.ParentForm;
            }
        }

        public AssociatedSymbolPaletteInfoCollection AssociatedSymbolPalettes
        {
            get
            {
                return this.symbolPaletteInfo;
            }
            set
            {
                this.symbolPaletteInfo = value;
            }
        }

        public bool SaveChanges
        {
            get
            {
                if (diagramComponent.Model.Modified || needSave)
                    return true;
                else
                    return false;
            }
            set
            {
                needSave = value;
            }
        }

        public string FileName
        {
            get
            {
                return this.fileName;
            }
            set
            {
                this.fileName = value;
                this.Text = Path.GetFileName(this.fileName);
            }
        }

        public bool HasFileName
        {
            get
            {
                return (this.fileName != null && this.fileName.Length > 0);
            }
        }

        protected PropertyEditor PropertyEditor
        {
            get
            {
                if (this.MdiParent != null)
                {
                    MainForm mainForm = this.MdiParent as MainForm;
                    if (mainForm != null)
                    {
                        return mainForm.PropertyEditor;
                    }
                }
                return null;
            }
        }
        private Hashtable Tools
        {
            get
            {
                if (m_hashControllerTools == null)
                    m_hashControllerTools = new Hashtable();

                return m_hashControllerTools;
            }
            set
            {
                if (m_hashControllerTools != value)
                    m_hashControllerTools = value;
            }
        }
        private BarItem ActiveToolBarItem
        {
            get
            {
                return m_BaritemActiveTool;
            }
            set
            {
                if (m_BaritemActiveTool != value)
                {
                    if (m_BaritemActiveTool != null)
                        // Uncheck
                        m_BaritemActiveTool.Checked = false;

                    // Update baritem
                    m_BaritemActiveTool = value;

                    diagramComponent.Focus();

                    if (m_BaritemActiveTool != null)
                        // Check new baritem
                        m_BaritemActiveTool.Checked = true;
                }
            }
        }
        #endregion
    }
}
