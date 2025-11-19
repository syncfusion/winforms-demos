#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Grouping;
using Syncfusion.Drawing;

namespace OutlookDemo
{
    /// <summary>
    /// Summary description for ContactsPaneForm.
    /// </summary>
    public class ContactsPaneForm : System.Windows.Forms.UserControl
    {
        internal GridGroupingControl gridGroupingControl1;
        #region Declaration

        DataSet ds;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu popupMenu1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem2;
        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.IContainer components;
        public Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem3;
        public Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenusManager popupMenusManager1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem5;
        public Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem6;
        public Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem7;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem8;
        string[] visibleCols;

        #endregion

        public ContactsPaneForm()
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();

            #region Settings

            ds = new DataSet();
            ReadXml(ds, "data.xml");
            this.gridGroupingControl1.DataSource = ds.Tables[0];
            this.gridGroupingControl1.TableModel.Properties.Buttons3D = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TableModel.Properties.RowHeaders = false;
            this.gridGroupingControl1.TableModel.TableStyle.BackColor = SystemColors.HighlightText;
            this.gridGroupingControl1.Appearance.GroupCaptionPlusMinusCell.BorderMargins.Top = 12;
            this.gridGroupingControl1.Appearance.GroupCaptionPlusMinusCell.CellType = "Image";
            this.gridGroupingControl1.Appearance.GroupCaptionPlusMinusCell.CellValue = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "minus.png"));
            this.gridGroupingControl1.DefaultAppearance.AnyRecordFieldCell.Borders.Bottom = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(227, 239, 255), GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.DefaultAppearance.AnyRecordFieldCell.Borders.Right = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(227, 239, 255), GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.Appearance.GroupIndentCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, Color.FromArgb(227, 239, 255), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableOptions.CaptionRowHeight = 30;
            this.gridGroupingControl1.TableOptions.ColumnHeaderRowHeight = 22;
            this.gridGroupingControl1.TableOptions.IndentWidth = 20;
            this.gridGroupingControl1.TableModel.TableStyle.Trimming = StringTrimming.EllipsisCharacter;
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.One;
            this.gridGroupingControl1.TableOptions.RecordRowHeight = 20;

            GridColumnDescriptor unboundCol = new GridColumnDescriptor("ImageCol", "", "", true, 30);
            unboundCol.Appearance.AnyRecordFieldCell.CellType = "Image";
            unboundCol.Appearance.AnyRecordFieldCell.CellValue = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "contact.gif"));
            this.gridGroupingControl1.TableDescriptor.Columns.Add(unboundCol);

            this.gridGroupingControl1.TableDescriptor.VisibleColumns.Clear();
            this.gridGroupingControl1.TableDescriptor.VisibleColumns.Add("ImageCol");
            this.gridGroupingControl1.TableDescriptor.VisibleColumns.Add("ContactID");
            this.gridGroupingControl1.TableDescriptor.VisibleColumns.Add("CompanyName");
            this.gridGroupingControl1.TableDescriptor.VisibleColumns.Add("ContactTitle");
            this.gridGroupingControl1.TableDescriptor.VisibleColumns.Add("Address");
            this.gridGroupingControl1.TableDescriptor.VisibleColumns.Add("City");
            this.gridGroupingControl1.TableDescriptor.VisibleColumns.Add("Phone");
            this.gridGroupingControl1.QueryCellStyleInfo += new GridTableCellStyleInfoEventHandler(gridGroupingControl1_QueryCellStyleInfo);
            this.gridGroupingControl1.TableControl.MouseDown += new MouseEventHandler(TableControl_MouseDown);
            this.gridGroupingControl1.GroupCollapsed += new GroupEventHandler(gridGroupingControl1_GroupCollapsed);
            this.gridGroupingControl1.GroupExpanded += new GroupEventHandler(gridGroupingControl1_GroupExpanded);
            this.gridGroupingControl1.TableControlCellClick += new GridTableControlCellClickEventHandler(gridGroupingControl1_TableControlCellClick);
            this.gridGroupingControl1.TableDescriptor.GroupedColumns.Changed += new Syncfusion.Collections.ListPropertyChangedEventHandler(GroupedColumns_Changed);

            visibleCols = new string[this.gridGroupingControl1.TableDescriptor.VisibleColumns.Count];
            for (int i = 0; i < visibleCols.Length; i++)
                visibleCols[i] = this.gridGroupingControl1.TableDescriptor.VisibleColumns[i].Name;

            this.gridGroupingControl1.GridGroupDropArea.BackColor = Color.FromArgb(227, 239, 255);
            this.gridGroupingControl1.GridGroupDropArea.ThemesEnabled = false;
            this.gridGroupingControl1.GroupDropPanel.BackColor = Color.FromArgb(227, 239, 255);
            this.gridGroupingControl1.Splitter.BackColor = Color.FromArgb(227, 239, 255);
            #endregion

            #region Events Subscribed
            this.gridGroupingControl1.TableDescriptor.VisibleColumns.Changed += new Syncfusion.Collections.ListPropertyChangedEventHandler(VisibleColumns_Changed);
            this.gridGroupingControl1.GridGroupDropArea.PrepareViewStyleInfo += new GridPrepareViewStyleInfoEventHandler(GridGroupDropArea_PrepareViewStyleInfo);
            this.gridGroupingControl1.TableControlCellDrawn += new GridTableControlDrawCellEventHandler(gridGroupingControl1_TableControlCellDrawn);
            #endregion
        }



        public GridGroupingControl Grid
        {
            get { return this.gridGroupingControl1; }
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        void ReadXml(DataSet ds, string xmlFileName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(xmlFileName))
                {
                    ds.ReadXml(xmlFileName);
                    break;
                }
                xmlFileName = @"..\" + xmlFileName;
            }
        }

        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactsPaneForm));
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.popupMenu1 = new Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(this.components);
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.popupMenusManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenusManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridGroupingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGroupingControl1.Location = new System.Drawing.Point(0, 0);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.Size = new System.Drawing.Size(392, 256);
            this.gridGroupingControl1.TabIndex = 0;
            this.gridGroupingControl1.TableOptions.ListBoxSelectionCurrentCellOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionCurrentCellOptions.HideCurrentCell;
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.VersionInfo = "4.401.0.50";
            this.popupMenusManager1.SetXPContextMenu(this.gridGroupingControl1, this.popupMenu1);
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.CategoryIndex = -1;
            this.parentBarItem1.ID = "";
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem3,
            this.barItem5,
            this.barItem6,
            this.barItem7,
            this.barItem4,
            this.barItem2,
            this.barItem8});
            this.parentBarItem1.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Blue;
            this.parentBarItem1.SeparatorIndices.AddRange(new int[] {
            1,
            6,
            7});
            this.parentBarItem1.ShowMnemonicUnderlinesAlways = true;
            this.parentBarItem1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook;
            // 
            // barItem1
            // 
            this.barItem1.CategoryIndex = -1;
            this.barItem1.ID = "New Contact";
            this.barItem1.ImageIndex = 0;
            this.barItem1.ImageList = this.imageList1;
            this.barItem1.ShowMnemonicUnderlinesAlways = true;
            this.barItem1.Text = "New Contact";
            this.barItem1.Click += new System.EventHandler(this.barItem1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            // 
            // barItem3
            // 
            this.barItem3.CategoryIndex = -1;
            this.barItem3.ID = "Group By";
            this.barItem3.Text = "Group By";
            this.barItem3.Click += new System.EventHandler(this.barItem3_Click);
            // 
            // barItem5
            // 
            this.barItem5.CategoryIndex = -1;
            this.barItem5.ID = "Group By Box";
            this.barItem5.ImageIndex = 3;
            this.barItem5.ImageList = this.imageList1;
            this.barItem5.Text = "Group By Box";
            this.barItem5.Click += new System.EventHandler(this.barItem5_Click);
            // 
            // barItem6
            // 
            this.barItem6.CategoryIndex = -1;
            this.barItem6.ID = "Sort";
            this.barItem6.ImageIndex = 4;
            this.barItem6.ImageList = this.imageList1;
            this.barItem6.Text = "Sort";
            this.barItem6.Click += new System.EventHandler(this.barItem6_Click);
            // 
            // barItem7
            // 
            this.barItem7.CategoryIndex = -1;
            this.barItem7.ID = "Filter";
            this.barItem7.ImageIndex = 5;
            this.barItem7.ImageList = this.imageList1;
            this.barItem7.Text = "Filter";
            this.barItem7.Click += new System.EventHandler(this.barItem7_Click);
            // 
            // barItem4
            // 
            this.barItem4.CategoryIndex = -1;
            this.barItem4.ID = "Field Chooser";
            this.barItem4.ImageIndex = 2;
            this.barItem4.ImageList = this.imageList1;
            this.barItem4.Text = "Field Chooser";
            this.barItem4.Click += new System.EventHandler(this.barItem4_Click);
            // 
            // barItem2
            // 
            this.barItem2.CategoryIndex = -1;
            this.barItem2.ID = "Delete";
            this.barItem2.ImageIndex = 1;
            this.barItem2.ImageList = this.imageList1;
            this.barItem2.ShowMnemonicUnderlinesAlways = true;
            this.barItem2.Text = "Delete";
            this.barItem2.Click += new System.EventHandler(this.barItem2_Click);
            // 
            // barItem8
            // 
            this.barItem8.CategoryIndex = -1;
            this.barItem8.ID = "Customize Current View...";
            this.barItem8.Text = "Customize Current View...";
            this.barItem8.Click += new System.EventHandler(this.barItem8_Click);
            // 
            // popupMenu1
            // 
            this.popupMenu1.ParentBarItem = this.parentBarItem1;
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.CategoryIndex = -1;
            this.parentBarItem2.ID = "";
            this.parentBarItem2.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Blue;
            // 
            // ContactsPaneForm
            // 
            this.Controls.Add(this.gridGroupingControl1);
            this.Name = "ContactsPaneForm";
            this.Size = new System.Drawing.Size(392, 256);
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region EventHandlers

        void gridGroupingControl1_TableControlCellDrawn(object sender, GridTableControlDrawCellEventArgs e)
        {
            if (e.Inner.RowIndex == 1)
            {
                Rectangle rect1 = e.Inner.Bounds;
                rect1.X = (rect1.X + rect1.Width) - 10;
                rect1.Width = 10;
                rect1.Y = (rect1.Y + rect1.Height) - 16;
                rect1.Height = 10;
                e.Inner.Graphics.DrawLine(new Pen(Color.FromArgb(154, 198, 255)), new Point(rect1.X + 9, rect1.Y - 2), new Point(rect1.X + 9, rect1.Y + 12));
                e.Inner.Graphics.DrawLine(Pens.AliceBlue, new Point(rect1.X + 10, rect1.Y - 2), new Point(rect1.X + 10, rect1.Y + 12));
            }
        }


        void GridGroupDropArea_PrepareViewStyleInfo(object sender, GridPrepareViewStyleInfoEventArgs e)
        {
			e.Style.Font.Facename = "Segoe UI";
            e.Style.Font.Size = 8.25f;
            if (e.Style.Text.StartsWith("Drag a"))
                e.Style.TextColor = Color.FromArgb(22, 74, 167);
            else
                e.Style.TextColor = Color.FromArgb(141, 141, 141);
            e.Style.BackColor = Color.FromArgb(227, 239, 255);
            e.Style.Borders.All = new GridBorder(GridBorderStyle.None);
        }

        private void gridGroupingControl1_QueryCellStyleInfo(object sender, GridTableCellStyleInfoEventArgs e)
        {
			e.Style.Font.Facename = "Segoe UI";
            e.Style.Font.Size = 8.25f;

            int lastRecIndex = this.gridGroupingControl1.Table.Records.Count;
            if (e.TableCellIdentity.RowIndex == lastRecIndex + 1)
                e.Style.Borders.Bottom = new GridBorder(GridBorderStyle.Solid, Color.Black);

            if (e.TableCellIdentity.TableCellType == GridTableCellType.GroupCaptionCell)
            {
                e.Style.Themed = false;
                e.Style.BackColor = Color.White;
                e.Style.Borders.Top = new GridBorder(GridBorderStyle.None);
                e.Style.Borders.Bottom = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(Form1.r, Form1.g, Form1.b), GridBorderWeight.Thick);
                e.Style.TextColor = Color.FromArgb(Form1.r1, Form1.g1, Form1.b1);
                e.Style.Text = e.TableCellIdentity.DisplayElement.ParentGroup.Category.ToString();
                e.Style.TextMargins.Bottom = 8 - 3;

                e.Style.VerticalAlignment = GridVerticalAlignment.Bottom;
            }
            if (e.TableCellIdentity.TableCellType == GridTableCellType.GroupCaptionPlusMinusCell)
            {
                e.Style.Borders.Top = new GridBorder(GridBorderStyle.None);
                e.Style.Borders.Bottom = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(Form1.r, Form1.g, Form1.b), GridBorderWeight.Thick);
            }
            if (e.TableCellIdentity.TableCellType == GridTableCellType.GroupIndentCell)
            {
                e.Style.Borders.Top = new GridBorder(GridBorderStyle.None);
                e.Style.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, Color.FromArgb(Form1.r1, Form1.g1, Form1.b1), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            }
            if (e.Style.CellType == "ColumnHeaderCell")
            {
                e.Style.Borders.All = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(Form1.r, Form1.g, Form1.b), GridBorderWeight.Thin);
                e.Style.CellTipText = e.Style.Text;
                e.Style.HorizontalAlignment = GridHorizontalAlignment.Left;
                e.Style.Interior = new BrushInfo(GradientStyle.Vertical, Color.White, Color.FromArgb(Form1.r, Form1.g, Form1.b));
            }
        }

        private void TableControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int row, col;
                this.gridGroupingControl1.TableControl.PointToRowCol(new Point(e.X, e.Y), out row, out col);
                Element el = this.gridGroupingControl1.TableModel.GetDisplayElementAt(row);
                if (el != null)
                    this.barItem2.Enabled = true;
                else
                    this.barItem2.Enabled = false;

            }
        }

        private void gridGroupingControl1_GroupCollapsed(object sender, GroupEventArgs e)
        {
            GridCaptionRow gcr = (GridCaptionRow)e.Group.Caption.CaptionRows[0];
            gcr.Appearance.GroupCaptionPlusMinusCell.CellValue = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "plus.png"));
        }

        private void gridGroupingControl1_GroupExpanded(object sender, GroupEventArgs e)
        {
            GridCaptionRow gcr = (GridCaptionRow)e.Group.Caption.CaptionRows[0];
            gcr.Appearance.GroupCaptionPlusMinusCell.CellValue = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "minus.png"));
        }

        private void VisibleColumns_Changed(object sender, Syncfusion.Collections.ListPropertyChangedEventArgs e)
        {
            visibleCols = new string[this.gridGroupingControl1.TableDescriptor.VisibleColumns.Count];
            for (int i = 0; i < visibleCols.Length; i++)
                visibleCols[i] = this.gridGroupingControl1.TableDescriptor.VisibleColumns[i].Name;
        }

        private void barItem1_Click(object sender, EventArgs e)
        {
            NewContactDialog dlg = new NewContactDialog();
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                DataRow rw = ds.Tables[0].NewRow();
                rw["ContactID"] = dlg.ContactID;
                rw["CompanyName"] = dlg.CompName;
                rw["ContactTitle"] = dlg.ContactTitle;
                rw["Address"] = dlg.Address;
                rw["City"] = dlg.City;
                rw["Phone"] = dlg.Phone;
                ds.Tables[0].Rows.Add(rw);
            }
        }

        private void barItem3_Click(object sender, EventArgs e)
        {
            GroupByDialog dlg = new GroupByDialog(visibleCols);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < 3; i++)
                    if (dlg.GroupByCols[i].CompareTo("(none)") != 0)
                        this.gridGroupingControl1.TableDescriptor.GroupedColumns.Add(dlg.GroupByCols[i], dlg.Direction[i]);
                if (dlg.View == "All expanded")
                    this.gridGroupingControl1.Table.ExpandAllGroups();
                else if (dlg.View == "All collapsed")
                {
                    this.gridGroupingControl1.Table.CollapseAllGroups();
                }
            }
        }

        private void barItem4_Click(object sender, EventArgs e)
        {
            string[] hiddenCols = new string[this.gridGroupingControl1.TableDescriptor.Columns.Count];
            bool flag = false;
            int hiddenIndex = 0;
            string temp;
            for (int i = 0; i < hiddenCols.Length; i++)
            {
                temp = this.gridGroupingControl1.TableDescriptor.Columns[i].Name;
                for (int j = 0; j < visibleCols.Length; j++)
                {
                    if (visibleCols[j].CompareTo(temp) == 0)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    hiddenCols[hiddenIndex] = temp;
                    hiddenIndex++;
                }
                else
                    flag = false;
            }
            FieldChooserDialog dlg = new FieldChooserDialog(hiddenCols, visibleCols);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.gridGroupingControl1.TableDescriptor.VisibleColumns.Clear();
                this.gridGroupingControl1.TableDescriptor.VisibleColumns.Add("ImageCol");
                foreach (string str in dlg.SelectedFields)
                    this.gridGroupingControl1.TableDescriptor.VisibleColumns.Add(str);
            }
        }

        private void barItem2_Click(object sender, EventArgs e)
        {
            Record rec = this.gridGroupingControl1.Table.CurrentRecord;
            rec.Delete();
        }

        private void barItem5_Click(object sender, EventArgs e)
        {
            this.gridGroupingControl1.ShowGroupDropArea = !this.gridGroupingControl1.ShowGroupDropArea;
        }

        private void barItem6_Click(object sender, EventArgs e)
        {
            SortDialog dlg = new SortDialog(visibleCols);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < 3; i++)
                    if (dlg.SortByCols[i].CompareTo("(none)") != 0)
                        this.gridGroupingControl1.TableDescriptor.SortedColumns.Add(dlg.SortByCols[i], dlg.Direction[i]);
            }
        }

        private void barItem8_Click(object sender, EventArgs e)
        {
            CurrentView curView = new CurrentView(this);
            curView.ShowDialog();
        }

        private void barItem7_Click(object sender, EventArgs e)
        {
            FilterDialog dlg = new FilterDialog(this.gridGroupingControl1);
            dlg.ShowDialog();
        }

        private void gridGroupingControl1_TableControlCellClick(object sender, GridTableControlCellClickEventArgs e)
        {
            if (e.Inner.MouseEventArgs.Button == MouseButtons.Left)
            {
                if (e.Inner.RowIndex > 1)
                {
                    GridTableCellStyleInfo style = e.TableControl.GetTableViewStyleInfo(e.Inner.RowIndex, e.Inner.ColIndex);
                    if (style.TableCellIdentity.TableCellType == GridTableCellType.GroupCaptionPlusMinusCell)
                    {
                        GridCaptionRow curGrp = e.TableControl.Table.NestedDisplayElements[e.Inner.RowIndex] as GridCaptionRow;
                        curGrp.ParentGroup.IsExpanded = !curGrp.ParentGroup.IsExpanded;
                    }
                }
            }
        }

        private void GroupedColumns_Changed(object sender, Syncfusion.Collections.ListPropertyChangedEventArgs e)
        {
            if (this.gridGroupingControl1.TableDescriptor.GroupedColumns.Count >= 1)
            {
                foreach (Element el in this.gridGroupingControl1.Table.DisplayElements)
                {
                    if (!(el is GridRecordRow))
                    {
                        int row = this.gridGroupingControl1.Table.NestedDisplayElements.IndexOf(el);
                        if (this.gridGroupingControl1.Table.NestedDisplayElements[row].IsCaption())
                        {
                            GridCaptionRow crow = (GridCaptionRow)el;
                            Group gp = crow.ParentGroup;
                            if (gp.IsExpanded)
                                crow.Appearance.GroupCaptionPlusMinusCell.CellValue = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "minus.png"));
                            else
                                crow.Appearance.GroupCaptionPlusMinusCell.CellValue = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "plus.png"));
                        }
                    }
                }
            }
        }
        #endregion
    }
}
