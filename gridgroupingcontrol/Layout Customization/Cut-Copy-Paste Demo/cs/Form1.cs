#region Copyright Syncfusion Inc. 2001 - 2015
//
//  Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

# region Directives
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Specialized;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Grouping;
using Syncfusion.Drawing;
using Syncfusion.Styles;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

# endregion

namespace GGC_CutCopyPaste
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : GridDemoForm
    {
        # region Variable Declaration

        private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx contextMenuStripEx1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
        private GridGroupingControl gridGroupingControl1;
        private Panel panel1;
        private PropertyGrid propertyGrid1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        # endregion

        #region Constructor

        /// <summary>
        ///  Form Constructor.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            GridSettings();
            SampleCustomization();
        }

        #endregion

        #region GridSettings

        /// <summary>
        /// Required Method for Grid Settings
        /// </summary>
        void GridSettings()
        {
            //Initial Settings
            this.gridGroupingControl1.TableControl.DpiAware = true;
			this.gridGroupingControl1.ShowGroupDropArea = true;
            this.gridGroupingControl1.TableModel.Options.SelectCellsMouseButtonsMask = MouseButtons.Left;
            this.gridGroupingControl1.TableDescriptor.AllowNew = false;

            //Selection Settings
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
            this.gridGroupingControl1.TableOptions.AllowSelection = GridSelectionFlags.None;

            //Assign DataSource
            this.gridGroupingControl1.DataSource = CreateDataSource();
            this.gridGroupingControl1.DataMember = "Students";

            this.gridGroupingControl1.GridGroupDropArea.DragColumnHeaderText = "Drag here to Group";
            this.gridGroupingControl1.AllowProportionalColumnSizing = true;
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
        }

        #endregion

        #region SampleCustomization
        /// <summary>
        /// Required Method for sample level customization.
        /// </summary>
        void SampleCustomization()
        {  
            //Subscribe to the events as required
            this.gridGroupingControl1.TableModel.ClipboardCopy += new GridCutPasteEventHandler(TableModel_ClipboardCopy);
            this.gridGroupingControl1.TableModel.ClipboardCut += new GridCutPasteEventHandler(TableModel_ClipboardCut);
            this.gridGroupingControl1.GetTableModel("MarkSheet").ClipboardCopy += new GridCutPasteEventHandler(Form1_ClipboardCopy);
            this.gridGroupingControl1.GetTableModel("MarkSheet").ClipboardCut += new GridCutPasteEventHandler(Form1_ClipboardCut);
        }

        #region Event Handlers

        //Cut in Child Table
        void Form1_ClipboardCut(object sender, GridCutPasteEventArgs e)
        {
            CopySelectedRecords(true);
            e.Handled = true;
        }

        //Copy in Child Table
        void Form1_ClipboardCopy(object sender, GridCutPasteEventArgs e)
        {
            CopySelectedRecords(false);
            e.Handled = true;
        }

        //Cut in Parent Table
        void TableModel_ClipboardCut(object sender, GridCutPasteEventArgs e)
        {
            CopySelectedRecords(true);
            e.Handled = true;
        }
        
        void TableModel_ClipboardCopy(object sender, GridCutPasteEventArgs e)
        {
            CopySelectedRecords(false);
            e.Handled = true;
        }

        #region Context Menu Handlers
        //Cut
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.gridGroupingControl1.TableModel.CutPaste.Cut();
        }
        //Copy
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.gridGroupingControl1.TableModel.CutPaste.Copy();
        }
        //Paste
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.gridGroupingControl1.TableModel.CutPaste.Paste();
            this.gridGroupingControl1.GetTableModel("MarkSheet").CutPaste.Paste();
        }
        #endregion

        #endregion

        #region Methods

        private void CopySelectedRecords(bool cut)
        {
            string s = "";

            //Copying visible column names to the string buffer.
            foreach (GridVisibleColumnDescriptor cd in this.gridGroupingControl1.TableDescriptor.VisibleColumns)
            {
                int index = this.gridGroupingControl1.TableDescriptor.VisibleColumns.IndexOf(cd);
                if (index != 0)
                    s += '\t';
                s += cd.Name;
            }
            s += Environment.NewLine;

            //Copying the selected records.
            if (this.gridGroupingControl1.Table.SelectedRecords.Count > 0)
            {
                //Selection is made in the parent table
                foreach (SelectedRecord selRec in this.gridGroupingControl1.Table.SelectedRecords)
                    s = CopySelectedRecordsToBuffer(s, selRec.Record, gridGroupingControl1.TableDescriptor, cut);
            }
            else
            {
                //Selection is made in the child table.
                s = "";
                GridTable child = gridGroupingControl1.GetTable("MarkSheet");
                if (child.SelectedRecords.Count > 0)
                {
                    //Copying visible column names of the child table into the string buffer.
                    foreach (GridVisibleColumnDescriptor cd in child.TableDescriptor.VisibleColumns)
                    {
                        int index = child.TableDescriptor.VisibleColumns.IndexOf(cd);
                        if (index != 0)
                            s += '\t';
                        s += cd.Name;
                    }
                    s += Environment.NewLine;
                    foreach (SelectedRecord r in child.SelectedRecords)
                        s = CopySelectedRecordsToBuffer(s, r.Record, child.TableDescriptor, cut);
                }
            }
            Clipboard.SetDataObject(new DataObject(s), true);
        }

        private string CopySelectedRecordsToBuffer(string buffer, Record rec, GridTableDescriptor tableDesc, bool cut)
        {
            //Since a 'Cut' operation in parent record eliminates the child records too, it is prohibited.
            if (cut && tableDesc.Name.Equals("Students"))
            {
                MessageBox.Show("Parent record cannot be null");
                return "";
            }

            //Copying the data records into the string buffer.
            for (int i = 0; i < tableDesc.VisibleColumns.Count; i++)
            {
                GridVisibleColumnDescriptor vcd = tableDesc.VisibleColumns[i];
                if (i != 0)
                    buffer += '\t';
                buffer += rec.GetValue(vcd.Name).ToString();
                if (cut)
                    rec.SetValue(vcd.Name, "");
            }
            buffer += Environment.NewLine;

            //If the selection is made in a parent record, its child records are also get copied.
            if (rec.HasNestedTables)
            {
                buffer += Environment.NewLine;
                buffer += '\t';
                NestedTable child = rec.NestedTables[0];
                GridTableDescriptor childDesc = gridGroupingControl1.GetTableDescriptor(child.ChildTable.Name);

                //Copying visible column names of the child table.
                foreach (GridVisibleColumnDescriptor cd in childDesc.VisibleColumns)
                {
                    int index = childDesc.VisibleColumns.IndexOf(cd);
                    if (index != 0)
                        buffer += "\t";
                    buffer += cd.Name;
                }
                buffer += Environment.NewLine;

                //Copying child records.
                foreach (Record r in child.FilteredRecords)
                {
                    buffer += "\t";
                    for (int i = 0; i < childDesc.VisibleColumns.Count; ++i)
                    {
                        GridVisibleColumnDescriptor vcd = childDesc.VisibleColumns[i];
                        if (i != 0)
                            buffer += '\t';
                        buffer += r.GetValue(vcd.Name).ToString();
                    }
                    buffer += Environment.NewLine;
                }

                //Repeat the above process for every nested table associated with the record.
                foreach (Record r in child.FilteredRecords)
                {
                    CopySelectedRecordsToBuffer(buffer, r, childDesc, cut);
                }
            }
            return buffer;
        }

        #endregion

        #endregion

        #region Designer Stuffs

        #region Get Data 

        DataSet CreateDataSource()
        {
            DataTable dt1 = new DataTable("Students");
            dt1.Columns.Add("RollNo");
            dt1.PrimaryKey = new DataColumn[] { dt1.Columns["RollNo"] };
            dt1.Columns.Add("Name");
            dt1.Columns.Add("Address");
            dt1.Rows.Add(new object[] { "1002", "Catherine", "144, Matrix Square" });
            dt1.Rows.Add(new object[] { "1003", "Greg", "425, 5th Ave" });
            dt1.Rows.Add(new object[] { "1004", "Harry", "256, Eldams" });
            dt1.Rows.Add(new object[] { "1005", "James", "565, Bogh Road" });
            dt1.Rows.Add(new object[] { "1006", "Ken", "252, N G K Winch" });
            dt1.Rows.Add(new object[] { "1007", "Nancy", "628, Blue Star" });
            dt1.Rows.Add(new object[] { "1008", "Ronald", "325, Anna Square" });

            DataTable dt2 = new DataTable("MarkSheet");
            dt2.Columns.Add("RollNo");
            dt2.Columns.Add("Mark1");
            dt2.Columns.Add("Mark2");
            dt2.Columns.Add("Mark3");
            dt2.Rows.Add(new object[] { "1002", "64.6", "80.5", "53.8" });
            dt2.Rows.Add(new object[] { "1002", "58.7", "78.5", "67.4" });
            dt2.Rows.Add(new object[] { "1003", "62.6", "65.0", "69.7" });
            dt2.Rows.Add(new object[] { "1003", "55.0", "75.0", "73.2" });
            dt2.Rows.Add(new object[] { "1003", "79.0", "70.0", "83.3" });
            dt2.Rows.Add(new object[] { "1004", "80.4", "75.6", "67.1" });
            dt2.Rows.Add(new object[] { "1004", "54.4", "72.5", "75.5" });
            dt2.Rows.Add(new object[] { "1004", "48.8", "71.2", "67.6" });
            dt2.Rows.Add(new object[] { "1005", "73.5", "77.4", "83.8" });
            dt2.Rows.Add(new object[] { "1005", "59.6", "70.1", "56.8" });
            dt2.Rows.Add(new object[] { "1006", "95.3", "93.6", "85.0" });
            dt2.Rows.Add(new object[] { "1007", "63.5", "69.3", "72.0" });
            dt2.Rows.Add(new object[] { "1007", "51.4", "65.5", "64.4" });
            dt2.Rows.Add(new object[] { "1007", "82.8", "87.2", "88.5" });
            dt2.Rows.Add(new object[] { "1008", "67.3", "72.4", "68.5" });

            DataSet ds = new DataSet();
            ds.Tables.Add(dt1);
            ds.Tables.Add(dt2);

            ds.Relations.Add(new DataRelation("StudMarks", ds.Tables[0].Columns[0], ds.Tables[1].Columns[0]));

            return ds;
        }

        #endregion
                
        #region Windows Form Designer generated code    

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.contextMenuStripEx1 = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.contextMenuStripEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripEx1
            // 
            this.contextMenuStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.contextMenuStripEx1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.contextMenuStripEx1.Name = "contextMenuStripEx1";
            this.contextMenuStripEx1.Size = new System.Drawing.Size(103, 70);
            this.contextMenuStripEx1.Style = Syncfusion.Windows.Forms.Tools.ContextMenuStripEx.ContextMenuStyle.Default;
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.BarName = "parentBarItem1";
            this.parentBarItem1.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.WrapLength = 20;
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.ContextMenuStrip = this.contextMenuStripEx1;
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridGroupingControl1.Location = new System.Drawing.Point(3, 4);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.Size = new System.Drawing.Size(678, 640);
            this.gridGroupingControl1.TabIndex = 2;
            this.gridGroupingControl1.TableDescriptor.AllowNew = false;
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI";
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235))))));
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))));
            this.gridGroupingControl1.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = true;
            this.gridGroupingControl1.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader";
            this.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25;
            this.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20;
            this.gridGroupingControl1.TableOptions.GridLineBorder = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255))))));
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.VersionInfo = "5.102.0.51";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.propertyGrid1);
            this.panel1.Controls.Add(this.gridGroupingControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 656);
            this.panel1.TabIndex = 5;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.BackColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsBackColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White;
            this.propertyGrid1.HelpBackColor = System.Drawing.Color.White;
            this.propertyGrid1.LineColor = System.Drawing.Color.White;
            this.propertyGrid1.Location = new System.Drawing.Point(687, 7);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.gridGroupingControl1;
            this.propertyGrid1.Size = new System.Drawing.Size(321, 637);
            this.propertyGrid1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 656);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Cut-Copy-Paste ";
            this.contextMenuStripEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        // <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        #endregion

        #endregion
    }
}