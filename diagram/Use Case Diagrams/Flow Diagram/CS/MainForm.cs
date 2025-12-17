#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Diagram;
using System.IO;
using System.Drawing.Drawing2D;
using Syncfusion.Windows.Forms.Diagram.Controls;
using Syncfusion.Windows.Forms.Tools;
using System.Drawing.Printing;
using System.Diagnostics;
using System.Drawing.Imaging;
using Syncfusion.SVG.IO;
using Syncfusion.Windows.Forms;

namespace FlowDiagram_2005
{
    public partial class MainForm : Form
    {
        #region Members
        Syncfusion.Windows.Forms.Diagram.Label lbl;
        bool needSave = false;
        public string fileName;
        #endregion

        #region Form Initialize
        public MainForm()
        {
            InitializeComponent();

#if !(NETCORE || NET50 || NET80 || NET60 || NET70 || NET90)
            paletteGroupBar1.LoadPalette(@"..\..\..\..\..\..\common\Data\Diagram\xml\Flowchart Symbols.xml");
#else
            paletteGroupBar1.LoadPalette(@"..\..\..\..\..\..\..\common\Data\Diagram\xml\Flowchart Symbols.xml");
#endif

            this.diagram1.BeginUpdate();
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            this.diagram1.Model.BoundaryConstraintsEnabled = false;
            diagram1.Model.HistoryManager.Pause();
            InitailizeDiagram();
            diagram1.Model.HistoryManager.Resume();
            this.diagram1.View.SelectionList.Clear();
            GroupBarAppearance();
            this.diagram1.EndUpdate();

            // Wire up OnIdle processing
            Application.Idle += new EventHandler(Application_Idle);
        }
#endregion

#region Initailize Diagram with nodes
        /// <summary>
        /// Initialize the diagram
        /// </summary>
        protected void InitailizeDiagram()
        {           
            // Add a TextNode to highlight the Diagram Name
            Syncfusion.Windows.Forms.Diagram.TextNode txtnode = new TextNode("Simple Flow Diagram");
            txtnode.FontStyle.Size = 17;
            txtnode.FontStyle.Bold = true;
            txtnode.FontStyle.Family = "Arial";
            txtnode.FontColorStyle.Color = Color.Black;
            txtnode.LineStyle.LineColor = Color.Transparent;
            txtnode.SizeToText(Size.Empty);
            InsertNode(txtnode, new PointF(290, 15));

            if (this.paletteGroupBar1.CurrentSymbolPalette == null)
                return;
            //WF-63521 Off-page reference, Manual operation, Loop limit nodes handle mode is set to resize.
            else
            {
                foreach (Node node in this.paletteGroupBar1.CurrentSymbolPalette.Nodes as NodeCollection)
                {
                    if (node.FullName == "Off-page reference" || node.FullName == "Manual operation" || node.FullName == "Loop limit")
                    {
                        node.EditStyle.DefaultHandleEditMode = HandleEditMode.Resize;
                    }
                }
            }

            // Insert the Network Symbols.
            // Insert start  
            Node start = InsertNodeFromPallete("Start/End", new PointF(295, 37), "Start", new SizeF(120,45));
            //Insert process1  
            Node process1 = InsertNodeFromPallete("Process", new PointF(325, 102), "Answer Phone", new SizeF(120, 45));
            // Insert decision1
            Node decision1 = InsertNodeFromPallete("Decision", new PointF(325, 175), "How can we help?", new SizeF(120, 60));
            //Insert process2 
            Node process2 = InsertNodeFromPallete("Process", new PointF(70, 252), "Take name and company", new SizeF(120, 45));
            // Insert process3
            Node process3 = InsertNodeFromPallete("Process", new PointF(70, 327), "Transfer to sales", new SizeF(120, 45));
            //Insert end1 
            Node end1 = InsertNodeFromPallete("Start/End", new PointF(40, 402), "Finish", new SizeF(120, 45));
            //Insert decision2 
            Node decision2 = InsertNodeFromPallete("Decision", new PointF(325, 255), "What is problem?", new SizeF(120, 60));
            //Insert process4
            Node process4 = InsertNodeFromPallete("Process", new PointF(325, 330), "Take name and company", new SizeF(120, 45));
            //Insert process5
            Node process5 = InsertNodeFromPallete("Process", new PointF(325, 390), "Transfer to help", new SizeF(120, 45));
            //Insert end2
            Node end2 = InsertNodeFromPallete("Start/End", new PointF(295, 465), "Finish", new SizeF(120, 45));

            //	Add TextNodes to display Layer Names
            InsertTextNode("Product info, or help placing order", new PointF(130, 180), new SizeF(135,35));
            InsertTextNode("Other", new PointF(480, 200), new SizeF(90,30));
            InsertTextNode("Shipping", new PointF(235, 280), new SizeF(90,30));
            InsertTextNode("Billing", new PointF(480, 280), new SizeF(90,30));
            InsertTextNode("Problems with product?", new PointF(272, 316), new SizeF(90,30));


            // Create Links between the NetworkSymbols.
            ConnectNodes(start, process1);
            ConnectNodes(process1, decision1);           
            ConnectNodes(decision1, process2);
            ConnectNodes(process2, process3);            
            ConnectNodes(process3, end1);
            ConnectNodes(decision1, decision2);
            ConnectNodes(decision2, process4);
            ConnectNodes(process4, process5);
            ConnectNodes(process5, end2);

            ConnectNodes(decision1, "right");
            ConnectNodes(decision2,  "right");
            ConnectNodes(decision2,"left");
        }

        /// <summary>
        /// Insert the node
        /// </summary>
        /// <param name="strText">TextNode's text</param>
        /// <param name="ptPinPoint">Node's Location </param>
        /// <param name="nodeSize">Node's size</param>
        /// <returns>returns the node</returns>
        private TextNode InsertTextNode(string strText, PointF ptPinPoint, SizeF nodeSize)
        {
            Syncfusion.Windows.Forms.Diagram.TextNode txtnode = new TextNode(strText);

            txtnode.FontStyle.Size = 10;
            txtnode.FontStyle.Family = "Arial";
            txtnode.FontColorStyle.Color = Color.Black;
            txtnode.LineStyle.LineColor = Color.Transparent;
            txtnode.Size = nodeSize;
           
            InsertNode(txtnode, ptPinPoint);
            return txtnode;
        }
      
        /// <summary>
        /// Inserts the node
        /// </summary>
        /// <param name="node">Node</param>
        /// <param name="ptPinPoint">Node's Location</param>
        /// <returns>returns the node</returns>
        private Node InsertNode(Node node, PointF ptPinPoint)
        {
            MeasureUnits units = MeasureUnits.Pixel;
            SizeF szPinOffset = ((IUnitIndependent)node).GetPinPointOffset(units);
            ptPinPoint.X += szPinOffset.Width;
            ptPinPoint.Y += szPinOffset.Height;
            ((IUnitIndependent)node).SetPinPoint(ptPinPoint, units);
            node.EnableCentralPort = true;
            this.diagram1.Model.AppendChild(node);
            return node;
        }
      
        /// <summary>
        /// Insert the node from palette
        /// </summary>
        /// <param name="name">Node name</param>
        /// <param name="ptPinPoint">Node location</param>
        /// <param name="label">Label's text</param>
        /// <param name="nodeSize">Node size</param>
        /// <returns>returns the node</returns>
        private Node InsertNodeFromPallete(string name, PointF ptPinPoint, string label, SizeF nodeSize)
        {
            Node node = null;
            NodeCollection nodes = paletteGroupBar1.CurrentSymbolPalette.Nodes;

            if (name != null)
            {
                node = (Node)nodes[name].Clone();
                InsertNode(node, ptPinPoint);
            }

            //Set Node's size
            node.Size = nodeSize;
            //Add labels to node
            lbl = new Syncfusion.Windows.Forms.Diagram.Label(node, label);
            lbl.FontStyle.Family = "Arial";
            ((PathNode)node).Labels.Add(lbl);      

            return node;
        }
       
        /// <summary>
        /// Connects the node
        /// </summary>
        /// <param name="parentNode">parent node</param>
        /// <param name="subNode">child node</param>
        private void ConnectNodes(Node parentNode, Node subNode)
        {
            if (parentNode.CentralPort == null || subNode.CentralPort == null)
                return;

            this.diagram1.Model.BeginUpdate();
            // Create directed link
            PointF[] pts = new PointF[] { PointF.Empty, new PointF(0, 1) };
            OrthogonalConnector line = new OrthogonalConnector(pts[0], pts[1]);
            line.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
            line.HeadDecorator.FillStyle.Color = Color.Black;           
            line.LineStyle.LineColor = Color.Black;
            this.diagram1.Model.AppendChild(line);
            //Connect connectors's end points to the node ports. 
            parentNode.CentralPort.TryConnect(line.TailEndPoint);
            subNode.CentralPort.TryConnect(line.HeadEndPoint);
            this.diagram1.Model.SendToBack(line);
            this.diagram1.Model.EndUpdate();
        }

        /// <summary>
        /// Connect the nodes
        /// </summary>
        /// <param name="parentNode">parent node</param>
        /// <param name="position">node's position</param>
        private void ConnectNodes(Node parentNode, string position)
        {
            if (parentNode.CentralPort == null )
                return;
            PointF[] pts;
            OrthogonalConnector line;
            this.diagram1.Model.BeginUpdate();

            // Create directed link
            if (position == "right")
            {
                pts = new PointF[] { parentNode.PinPoint, new PointF(parentNode.PinPoint.X + 200, parentNode.PinPoint.Y) };
                line = new OrthogonalConnector(pts[0], pts[1]);
            }
            else
            {
                pts = new PointF[] { parentNode.PinPoint, new PointF(parentNode.PinPoint.X - 150, parentNode.PinPoint.Y + 220) };
                line = new OrthogonalConnector(pts[0], pts[1],true);
            }
            line.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
            line.HeadDecorator.FillStyle.Color = Color.Black;            
            line.LineStyle.LineColor = Color.Black;

            this.diagram1.Model.AppendChild(line);

            parentNode.CentralPort.TryConnect(line.TailEndPoint);            
            this.diagram1.Model.SendToBack(line);

            this.diagram1.Model.EndUpdate();
        }
#endregion

#region ChangeApperance of controls
        /// <summary>
        /// Change's the appearance of GroupBar
        /// </summary>
        private void GroupBarAppearance()
        {
            this.paletteGroupBar1.BorderColor = System.Drawing.ColorTranslator.FromHtml("#119EDA");
            foreach (GroupBarItem item in paletteGroupBar1.GroupBarItems)
            {
                //palette view settings
                if (item.Client is PaletteGroupView)
                {
                    PaletteGroupView view = item.Client as PaletteGroupView;
                    view.Font = new Font("Segoe UI", 9, System.Drawing.FontStyle.Regular);
                    view.ForeColor = Color.Black;
                    view.FlowView = true;
                    view.ShowToolTips = true;
                    view.ShowFlowViewItemText = true;
                    view.SelectedItemColor = Color.FromArgb(255, 219, 118);
                    view.HighlightItemColor = Color.FromArgb(255, 227, 149);
                    view.SelectingItemColor = Color.FromArgb(255, 238, 184);
                    view.SelectedHighlightItemColor = Color.FromArgb(255, 218, 115);
                    view.FlowViewItemTextLength = (int)DpiAware.LogicalToDeviceUnits(80);
                    view.BackColor = Color.White;
                    view.TextWrap = true;
                    view.FlatLook = true;
                    view.BorderStyle = BorderStyle.FixedSingle;
                }
            }
        }

        /// <summary>
        /// Sets the Appearance of Diagram
        /// </summary>
        private void DiagramAppearance()
        {
            this.diagram1.HorizontalRuler.BackgroundColor = Color.White;
            this.diagram1.VerticalRuler.BackgroundColor = Color.White;  
            this.diagram1.View.Grid.GridStyle = GridStyle.Line;
            this.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.diagram1.View.Grid.Color = Color.LightGray;
            this.diagram1.View.Grid.VerticalSpacing = 15;
            this.diagram1.View.Grid.HorizontalSpacing = 15;
            this.diagram1.Model.BackgroundStyle.GradientCenter = 0.5f;
            this.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue;
            this.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue;
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            this.diagram1.View.Grid.Visible = false;
            this.diagram1.View.BackgroundColor = Color.White;
            this.diagram1.Model.DocumentSize = new PageSize(500, 500);
            this.diagram1.View.SelectionList.Clear();
        }

        #endregion

        #region Properties

        
         bool SaveChanges
        {
            get
            {
                if (diagram1.Model.Modified || needSave)
                    return true;
                else
                    return false;
            }
            set
            {
                needSave = value;
            }
        }

        public bool HasFileName
        {
            get
            {
                return (this.fileName != null && this.fileName.Length > 0);
            }
        }

#endregion

#region Event Handlers
        
        
        
        void Application_Idle(object sender, EventArgs e)
        {
            if (this.diagram1 != null && this.diagram1.Model != null)
            {
                this.saveToolStripButton.Enabled = true;
                this.saveAsToolStripButton.Enabled = true;
                this.cutToolStripButton.Enabled = diagram1.CanCut;
                this.copyToolStripButton.Enabled = diagram1.CanCopy;
                if (this.WindowState != FormWindowState.Minimized)
                    this.pasteToolStripButton.Enabled = diagram1.CanPaste;
                this.undoToolStripButton.Enabled = diagram1.Model.HistoryManager.CanUndo;
                this.redoToolStripButton.Enabled = diagram1.Model.HistoryManager.CanRedo;
                this.deleteToolStripButton.Enabled = (this.diagram1.View.SelectionList.Count > 0);

            }
            else
            {
                this.saveToolStripButton.Enabled = false;
                this.saveAsToolStripButton.Enabled = false;
                this.cutToolStripButton.Enabled = false;
                this.copyToolStripButton.Enabled = false;
                if (this.WindowState != FormWindowState.Minimized)
                    this.pasteToolStripButton.Enabled = false;
                this.undoToolStripButton.Enabled = false;
                this.redoToolStripButton.Enabled = false;
                this.deleteToolStripButton.Enabled = false;
            }
        }

#region MenuTools

        private void CoonectorToolStripDropDownButton_DropDownItemClicked(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripMenuItem item in CoonectorToolStripDropDownButton.DropDownItems)
            {
                if (item.Checked)
                {
                    item.Checked = false;
                }
            }
            (e.ClickedItem as ToolStripMenuItem).Checked = true;
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FilterIndex = 0;
            if (this.SaveChanges)
            {
                DialogResult res = MessageBoxAdv.Show(this, "The diagram or its association has been modified. Save changes?", "Save changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    this.saveFileDialog1.FileName = "Diagram";
                    saveFileDialog1.Filter = @"XML file(*.xml)|*.xml|EDD file(*.edd)|*.edd|All files|*.*";
                    saveFileDialog1.Title = "Save File As:";

                    if (this.HasFileName)
                    {
                        this.saveFileDialog1.FileName = this.fileName;
                    }
                    if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
                    {
                        this.fileName = this.saveFileDialog1.FileName;
                        SaveDiagramAs(saveFileDialog1.FileName, saveFileDialog1.FilterIndex);
                        diagram1.Model.Clear();
                        Model model = new Model();
                        model.RenderingStyle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                        model.LineStyle.LineColor = Color.LightGray;
                        diagram1.Model = model;
                    }
                }
                else if (res == DialogResult.No)
                {
                    diagram1.Model.Clear();
                    Model model = new Model();
                    model.RenderingStyle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    model.LineStyle.LineColor = Color.LightGray;
                    diagram1.Model = model;
                }
            }
            else
            {
                diagram1.Model.Clear();
                Model model = new Model();
                model.RenderingStyle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                model.LineStyle.LineColor = Color.LightGray;
                diagram1.Model = model;
            }
            this.fileName = "";
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FilterIndex = 0;
            openFileDialog1.FilterIndex = 0;
            if (this.SaveChanges)
            {
                DialogResult res = MessageBoxAdv.Show(this, "The diagram or its association has been modified. Save changes?", "Save changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    this.saveFileDialog1.FileName = "Diagram";
                    saveFileDialog1.Filter = @"XML file(*.xml)|*.xml|EDD file(*.edd)|*.edd|All files|*.*";
                    saveFileDialog1.Title = "Save File As:";

                    if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
                    {
                        this.fileName = this.saveFileDialog1.FileName;
                        SaveDiagramAs(saveFileDialog1.FileName, saveFileDialog1.FilterIndex);
                    }

                    this.openFileDialog1.Filter = @"XML file(*.xml)|*.xml|EDD file(*.edd)|*.edd|All files|*.*";
                    this.openFileDialog1.Title = "Open Diagram";
                    this.openFileDialog1.FileName = "";
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(openFileDialog1.FileName))
                        {
                            OpenDiagramAs(openFileDialog1.FileName, openFileDialog1.FilterIndex);
                        }
                    }
                }
                else if (res == DialogResult.No)
                {
                    this.openFileDialog1.Filter = @"XML file(*.xml)|*.xml|EDD file(*.edd)|*.edd|All files|*.*";
                    this.openFileDialog1.Title = "Open Diagram";
                    this.openFileDialog1.FileName = "";
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(openFileDialog1.FileName))
                        {
                            OpenDiagramAs(openFileDialog1.FileName, openFileDialog1.FilterIndex);
                        }
                    }
                }
            }
            else
            {
                this.openFileDialog1.Filter = @"XML file(*.xml)|*.xml|EDD file(*.edd)|*.edd|All files|*.*";
                this.openFileDialog1.Title = "Open Diagram";
                this.openFileDialog1.FileName = "";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(openFileDialog1.FileName))
                    {
                        OpenDiagramAs(openFileDialog1.FileName, openFileDialog1.FilterIndex);
                    }
                }
            }
            this.fileName = openFileDialog1.FileName;
        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FilterIndex = 0;
            if (string.IsNullOrEmpty(fileName) || !File.Exists(fileName))
            {
                saveFileDialog1.Filter = @"XML file(*.xml)|*.xml|EDD file(*.edd)|*.edd";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    switch (saveFileDialog1.FilterIndex)
                    {
                        case 1:
#if NETCORE || NET50 || NET80 || NET60 || NET70 || NET90 || SyncfusionFramework4_6_2 || SyncfusionFramework4_6 || SyncfusionFramework4_5_1 || SyncfusionFramework4_5

                            diagram1.SaveXml(saveFileDialog1.FileName);
                            this.diagram1.Refresh();
#else
                        this.diagram1.SaveSoap(saveFileDialog1.FileName);
#endif
                           
                            break;
                        case 2:
                            diagram1.SaveBinary(saveFileDialog1.FileName);
                            break;
                    }
                    this.fileName = saveFileDialog1.FileName;
                }
            }
            else
            {
                FileInfo fi = new FileInfo(fileName);
                if (fi.Extension == ".edd")
                {
                    diagram1.SaveBinary(fi.FullName);
                }
                else if (fi.Extension == ".xml")
                {
#if NETCORE || NET50 || NET80 || NET60 || NET70 || NET90 || SyncfusionFramework4_6_2 || SyncfusionFramework4_6 || SyncfusionFramework4_5_1 || SyncfusionFramework4_5

                    diagram1.SaveXml(fi.FullName);
                    this.diagram1.Refresh();
#else
                        this.diagram1.SaveSoap(fi.FullName);
#endif
                }
            }
        }

        private void undoToolStripButton_Click(object sender, EventArgs e)
        {
            this.diagram1.Model.HistoryManager.Undo();
        }

        private void redoToolStripButton_Click(object sender, EventArgs e)
        {
            this.diagram1.Model.HistoryManager.Redo();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            diagram1.Controller.Cut();
            this.pasteToolStripButton.Enabled = true;
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            diagram1.Controller.Copy();
            this.pasteToolStripButton.Enabled = true;
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            diagram1.Controller.Paste();
            this.pasteToolStripButton.Enabled = false;
        }

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
            diagram1.Model.BeginUpdate();
            diagram1.Controller.Delete();
            diagram1.Model.EndUpdate();
        } 
        

        private void resetToolStripButton_Click(object sender, EventArgs e)
        {
            diagram1.View.ZoomToActual();
        }

        private void pageSettingsToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.diagram1 != null && this.diagram1.Model != null)
            {
                Syncfusion.Windows.Forms.Diagram.PageSetupDialog dlgPrintSetup = new Syncfusion.Windows.Forms.Diagram.PageSetupDialog(this.diagram1.View);

                // Made to make values more user friendly 
                dlgPrintSetup.PrintSettings = this.diagram1.View.PageSettings;
                dlgPrintSetup.PrintZoom = this.diagram1.View.PrintZoom;

                if (dlgPrintSetup.ShowDialog() == DialogResult.OK)
                {
                    this.diagram1.View.PageSettings = dlgPrintSetup.PrintSettings;
                    this.diagram1.View.PrintZoom = dlgPrintSetup.PrintZoom;
                    this.diagram1.View.RefreshPageSettings();
                }
            }
        }

        private void previewToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.diagram1 != null)
            {
                PrintDocument printDoc = this.diagram1.CreatePrintDocument();
                PrintPreviewDialog printPreviewDlg = new PrintPreviewDialog();

                printDoc.PrinterSettings.FromPage = 0;
                printDoc.PrinterSettings.ToPage = 0;
                printDoc.PrinterSettings.PrintRange = PrintRange.AllPages;

                printPreviewDlg.Document = printDoc;
                printPreviewDlg.ShowDialog(this);
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.diagram1 != null)
            {
                PrintDocument printDoc = this.diagram1.CreatePrintDocument();
                PrintDialog printDlg = new PrintDialog();
                printDlg.Document = printDoc;
                printDlg.UseEXDialog = true;
                printDlg.AllowSomePages = true;

                if (printDlg.ShowDialog(this) == DialogResult.OK)
                {
                    printDoc.PrinterSettings = printDlg.PrinterSettings;
                    printDoc.Print();
                }
            }
        }

        private void showGridToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (this.diagram1.View.Grid.Visible)
                this.diagram1.View.Grid.Visible = false;
            else
                this.diagram1.View.Grid.Visible = true;
        }

        private void snapToGridToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (diagram1.View.Grid.SnapToGrid)
                diagram1.View.Grid.SnapToGrid = false;
            else
                diagram1.View.Grid.SnapToGrid = true;
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            string targetURL = @"http://help.syncfusion.com/";
            System.Diagnostics.Process.Start(targetURL);
        }
       
        private void saveAsToolStripButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FilterIndex = 0;
            this.saveFileDialog1.FileName = "Diagram";
            saveFileDialog1.Filter = @"XML file(*.xml)|*.xml|EDD file(*.edd)|*.edd";
            saveFileDialog1.Title = "Save File As:";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
#if NETCORE || NET50 || NET80 || NET60 || NET70 || NET90 || SyncfusionFramework4_6_2 || SyncfusionFramework4_6 || SyncfusionFramework4_5_1 || SyncfusionFramework4_5

                        diagram1.SaveXml(saveFileDialog1.FileName);
                        this.diagram1.Refresh();
#else
                        this.diagram1.SaveSoap(saveFileDialog1.FileName);
#endif
                        break;
                    case 2:
                        diagram1.SaveBinary(saveFileDialog1.FileName);
                       
                        break;
                    default:
                        diagram1.SaveBinary(saveFileDialog1.FileName);
                        break;
                }
            }
        }

        private void pNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = @"W3C Portable Network Graphics(*.png)|*.png";
            saveFileDialog1.Title = "Export Diagram As:";
            this.saveFileDialog1.FileName = "Diagram";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImageFormat imgformat = ImageFormat.Png;
                SaveImage(saveFileDialog1.FileName, imgformat);
            }
            else
            {
                return;
            }
        }

        private void jPEGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = @"Joint Photographic Experts Group(*.jpeg)|*.jpeg";
            saveFileDialog1.Title = "Export Diagram As:";
            this.saveFileDialog1.FileName = "Diagram";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImageFormat imgformat = ImageFormat.Jpeg;
                SaveImage(saveFileDialog1.FileName, imgformat);
            }
            else
            {
                return;
            }
        }

        private void gIFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = @"Graphics Interchange Format(*.gif)|*.gif";
            saveFileDialog1.Title = "Export Diagram As:";
            this.saveFileDialog1.FileName = "Diagram";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImageFormat imgformat = ImageFormat.Gif;
                SaveImage(saveFileDialog1.FileName, imgformat);

            }
            else
            {
                return;
            }
        }

        private void sVGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = @"Scalable Vector Graphics Format(*.svg)|*.svg";
            saveFileDialog1.Title = "Export Diagram As:";
            saveFileDialog1.FileName = "Diagram";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                ToSvg tosvg = new ToSvg();
                // Get Diagram Nodes Bounding Rectangle.
                RectangleF rectBounding = this.diagram1.Model.GetBoundingRect();
                Graphics gfx = tosvg.GetRealGraphics(new Size((int)rectBounding.Width, (int)rectBounding.Height));
                this.diagram1.ExportDiagramToGraphics(gfx);
                tosvg.Save(saveFileDialog1.FileName);

            }
            else
            {
                return;
            }
        }

        private void lineConnectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveTool(new LineConnectorTool(this.diagram1.Controller));
        }

        private void orthogonalConnectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveTool(new OrthogonalConnectorTool(this.diagram1.Controller));
        }

        private void polylineConnectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PolyLineConnectorTool polyTool = new PolyLineConnectorTool(this.diagram1.Controller);
            polyTool.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
            polyTool.HeadDecorator.Size = new SizeF(6, 6);
            diagram1.Controller.ActivateTool(polyTool);
        }

        private void bezierConnectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveTool("BezierTool");
        }

        private void splineConnectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveTool("SplineTool");
        }

        private void panToolStripButton_Click(object sender, EventArgs e)
        {
            SetActiveTool("PanTool");
        }
        

        private void FillStyleToolStripButton_Click(object sender, EventArgs e)
        {
            if (diagram1.View.SelectionList != null && diagram1.View.SelectionList.Count > 0)
            {
                FillStyleDialog fsd = new FillStyleDialog();
                FillStyle fs = null;
                if (DialogResult.OK == fsd.ShowDialog())
                {
                    diagram1.BeginUpdate();

                    foreach (Node node in this.diagram1.View.SelectionList)
                    {
                        if (node is FilledPath)
                        {
                            fs = (FillStyle)TypeDescriptor.GetProperties(node, false)["FillStyle"].GetValue(node);
                            if (fs != null)
                            {
                                fs.Color = fsd.FillStyle.Color;
                                fs.ForeColor = fsd.FillStyle.ForeColor;
                                fs.ColorAlphaFactor = fsd.FillStyle.ColorAlphaFactor;
                                fs.ForeColorAlphaFactor = fsd.FillStyle.ForeColorAlphaFactor;
                                fs.Type = fsd.FillStyle.Type;
                                fs.GradientAngle = fsd.FillStyle.GradientAngle;
                                fs.GradientCenter = fsd.FillStyle.GradientCenter;
                                fs.PathBrushStyle = fsd.FillStyle.PathBrushStyle;
                                fs.HatchBrushStyle = fsd.FillStyle.HatchBrushStyle;
                                fs.Texture = fsd.FillStyle.Texture;
                                fs.TextureWrapMode = fsd.FillStyle.TextureWrapMode;
                            }
                        }
                        else if (node is ConnectorBase)
                        {
                            ((ConnectorBase)node).LineStyle.LineColor = fsd.FillStyle.Color;
                            ((ConnectorBase)node).HeadDecorator.FillStyle.Color = fsd.FillStyle.Color;
                            ((ConnectorBase)node).HeadDecorator.LineStyle.LineColor = fsd.FillStyle.Color;
                        }
                    }
                    diagram1.EndUpdate();
                }
            }
        }

        private void LineStyleToolStripButton_Click(object sender, EventArgs e)
        {
            if (diagram1.View.SelectionList != null && diagram1.View.SelectionList.Count > 0)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.diagram1.BeginUpdate();
                    foreach (Node node in diagram1.View.SelectionList)
                    {
                        node.LineStyle.LineColor = colorDialog1.Color;
                    }
                    diagram1.EndUpdate();
                }
            }
        }

        private void shadowToolStripButton_Click(object sender, EventArgs e)
        {
            if (diagram1.View.SelectionList != null && diagram1.View.SelectionList.Count > 0)
            {
                ShadowStyleDialog ssd = new ShadowStyleDialog();
                ShadowStyle fs = null;
                if (DialogResult.OK == ssd.ShowDialog())
                {
                    diagram1.BeginUpdate();
                    foreach (Node node in this.diagram1.View.SelectionList)
                    {
                        if (!(node is ConnectorBase) && !(node is TextNode))
                        {
                            fs = (ShadowStyle)TypeDescriptor.GetProperties(node, false)["ShadowStyle"].GetValue(node);
                            if (fs != null)
                            {
                                fs.Color = ssd.ShadowStyle.Color;
                                fs.ForeColor = ssd.ShadowStyle.ForeColor;
                                fs.ColorAlphaFactor = ssd.ShadowStyle.ColorAlphaFactor;
                                fs.ForeColorAlphaFactor = ssd.ShadowStyle.ForeColorAlphaFactor;
                                fs.PathBrushStyle = ssd.ShadowStyle.PathBrushStyle;
                                fs.OffsetX = ssd.ShadowStyle.OffsetX;
                                fs.OffsetY = ssd.ShadowStyle.OffsetY;
                                fs.Visible = ssd.ShadowStyle.Visible;
                            }
                        }
                    }
                    diagram1.EndUpdate();
                }
            }

        }

        private void shadingToolStripButton_Click(object sender, EventArgs e)
        {
            if (diagram1.View.SelectionList != null && diagram1.View.SelectionList.Count > 0)
            {
                diagram1.BeginUpdate();
                foreach (Node node in diagram1.View.SelectionList)
                {
                    if (node is FilledPath)
                    {
                        FilledPath filledPath = (FilledPath)node;
                        filledPath.EnableShading = !filledPath.EnableShading;
                    }
                }
                diagram1.EndUpdate();
            }
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diagram1.View.ZoomOut();
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diagram1.View.ZoomIn();
        }

        private void resetZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diagram1.View.ZoomToActual();
        }

#endregion

#endregion

#region Helper Methods
        //Save diagram as Image
        private void SaveImage(string filename, ImageFormat imageformat)
        {
            Image img = this.diagram1.View.ExportDiagramAsImage(false);
            img.Save(filename, imageformat);
        }

        //Save diagram
        private void SaveDiagramAs(string filename, int index)
        {
            switch (index)
            {
                case 1:
#if NETCORE || NET50 || NET80 || NET60 || NET70 || NET90 || SyncfusionFramework4_6_2 || SyncfusionFramework4_6 || SyncfusionFramework4_5_1 || SyncfusionFramework4_5

                    diagram1.SaveXml(filename);
                    this.diagram1.Refresh();
#else
                        this.diagram1.SaveSoap(filename);
#endif
                    
                    break;
                case 2:
                    diagram1.SaveBinary(filename);
                    break;
                default:
                    diagram1.SaveBinary(filename);
                    break;
            }
        }

        //Open Diagram
        private void OpenDiagramAs(string filename, int index)
        {
            switch (index)
            {
                case 1:
#if NETCORE || NET50 || NET80 || NET60 || NET70 || NET90 || SyncfusionFramework4_6_2 || SyncfusionFramework4_6 || SyncfusionFramework4_5_1 || SyncfusionFramework4_5

                    diagram1.LoadXml(filename);
                    this.diagram1.Refresh();
#else
                        this.diagram1.LoadSoap(filename);
#endif
                    break;
                case 2:
                    diagram1.LoadBinary(filename);
                    break;
                default:
                    diagram1.LoadBinary(filename);
                    break;
            }
        }

        private void SetActiveTool(string toolName)
        {
            this.diagram1.Controller.ActivateTool(toolName);
        }
        private void SetActiveTool(LineBaseTool tool)
        {
            tool.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
            tool.HeadDecorator.Size = new SizeF(6, 6);
            this.diagram1.Controller.ActivateTool(tool);
        }
#endregion

    }
}
