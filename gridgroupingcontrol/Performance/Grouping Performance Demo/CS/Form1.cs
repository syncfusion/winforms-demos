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

using System;
using System.Drawing;
using System.Diagnostics;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;

using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace GroupingPerf
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : GridDemoForm
    {
        #region API Definition
        private IContainer components;
        private System.Windows.Forms.Panel gridPanel;
        private GridGroupingControl grid;
        private Syncfusion.Windows.Forms.ButtonAdv btnInitGrid;
        private DataTable table;

        int randomKey = 100;
        int zipCount = 100;
        int recordCount = 20000;
        bool calculateMaxColumnWidth = true;
        bool useGroupingSortList = false;
        bool sortandCategorize = true;
        bool optimizeScrolling = true;
        int batchSize = 50;
        int repeatCount = 300;
        string[] states = new string[] { "North Carolina", "South Carolina", "Washington", "Nevada", "Ohio" };
        private Syncfusion.Windows.Forms.ButtonAdv btnResetGrid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelRecordCount;
        private System.Windows.Forms.Label labelZipCount;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxCalculateMaximumWidth;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxUseDataViewSort;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxMultiThreading;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxRecordCount;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxZipCount;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxRepeatCount;
        private Syncfusion.Windows.Forms.ButtonAdv buttonInsertRecords;
        private Syncfusion.Windows.Forms.ButtonAdv buttonRemoveRecords;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxSortandCategorize;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxUseScrollWindow;
        private GroupBox grpInitializeTable;
        private GroupBox grpgroupBox1;
        private System.Windows.Forms.Label lbllabel2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBatchSize;
        private Syncfusion.Windows.Forms.ButtonAdv buttonChangeRecords;
        private Syncfusion.Windows.Forms.ButtonAdv btnCollapseAll;
        private Syncfusion.Windows.Forms.ButtonAdv btnExpandAll;
        private Syncfusion.Windows.Forms.ButtonAdv btnChangeNames;
        bool allowMultiThreading = false;
        #endregion

        #region Constructor
        public Form1()
        {
            // GroupingEngineFactory provides a trimmed down GridGroup
            // which eliminates overhead of not needed preview rows, header and footer cells.
            GridEngineFactory.Factory = new GroupingEngineFactory();

            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            this.textBoxRepeatCount.Text = repeatCount.ToString();
            this.textBoxRecordCount.Text = recordCount.ToString();
            this.textBoxZipCount.Text = zipCount.ToString();
            this.checkBoxMultiThreading.Checked = this.allowMultiThreading;
            this.checkBoxUseDataViewSort.Checked = this.useGroupingSortList;
            this.checkBoxCalculateMaximumWidth.Checked = this.calculateMaxColumnWidth;
            checkBoxSortandCategorize.Checked = this.sortandCategorize;
            this.txtBatchSize.Text = this.batchSize.ToString();
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            checkBoxUseScrollWindow.Checked = optimizeScrolling;

            InitializeDataTable();
        }
        #endregion

        #region Datasource
        private void InitializeDataTable()
        {
            #region DataTable
            Random random = new Random(randomKey++);
            int numStates = states.GetLength(0);
            string nameFormat = "Name{0:00000}";

            this.table = new DataTable("Test");

            DataColumn col = table.Columns.Add();
            col.DataType = typeof(string);
            col.ColumnName = "Name";

            col = table.Columns.Add();
            col.DataType = typeof(string);
            col.ColumnName = "State";

            col = table.Columns.Add();
            col.DataType = typeof(int);
            col.ColumnName = "Zip";

            for (int i = 0; i < recordCount; i++)
            {
                DataRow row = this.table.NewRow();
                row["Name"] = string.Format(nameFormat, i);
                row["State"] = states[random.Next(numStates - 1)];
                row["Zip"] = random.Next(zipCount);
                this.table.Rows.Add(row);
            }
            #endregion
            this.table.DefaultView.RowStateFilter = DataViewRowState.CurrentRows;
        }
        #endregion

        #region Reset Grid
        /// <summary>
        /// Resetting the grid
        /// </summary>
        void ResetGroupingGrid()
        {
            if (this.grid != null)
            {
                this.gridPanel.Controls.Remove(this.grid);
                this.grid.Dispose();
                this.grid = null;
                this.table.Dispose();
                this.table = null;
                this.LogMemoryUsage();
            }
        }
        #endregion

        #region Memory Usage
        void LogMemoryUsage()
        {
            if (grid != null)
            {
                this.textBox1.Text += String.Format("Table Record Count {0}, Grid Record Count {1}/{3}, Display Element Count {2}, Element Count{4}\r\n", table.Rows.Count, grid.Table.Records.Count, grid.Table.DisplayElements.Count, grid.Table.UnsortedRecords.Count, grid.Table.Elements.Count);
            }
            // Force garbage collection and get used memory size
            GC.Collect();
            System.Threading.Thread.Sleep(randomKey++);
            Process myProcess = Process.GetCurrentProcess();
            double workingSetSizeinKiloBytes = myProcess.WorkingSet64 / 1000;
            string s = "Process's physical memory usage: " + workingSetSizeinKiloBytes.ToString() + " kb \r\n";
            this.textBox1.Text += s;
            ScrollTextBox();
        }
        #endregion

        #region TextBox Scroll
        void ScrollTextBox()
        {
            this.textBox1.SelectionStart = this.textBox1.Text.Length;
            this.textBox1.ScrollBars = ScrollBars.Vertical;
            this.textBox1.ScrollToCaret();
            this.textBox1.Focus();
        }
        #endregion

        #region Optimize Grid Settings
        /// <summary>
        /// Optimizing the grid for better performance
        /// </summary>
        /// <param name="grid"></param>
        void OptimizeGridSettings(GridGroupingControl grid)
        {
            grid.TableControl.DpiAware = true;
            grid.CounterLogic = EngineCounters.YAmount;
            grid.AllowedOptimizations = EngineOptimizations.DisableCounters | EngineOptimizations.RecordsAsDisplayElements;
            grid.UseDefaultsForFasterDrawing = true; // GDI interop drawing, FirstNRecords Summaries
            grid.InvalidateAllWhenListChanged = false; // only paint modified cells 
            grid.InsertRemoveBehavior = GridListChangedInsertRemoveBehavior.InvalidateAll;
            grid.UpdateDisplayFrequency = 100; // update every number of ms (speciy 0 if Update should be called manually)
            


         
            // Instruct grouping control not to access datasource through
            // CurrencyManager API and instead access list diretly. When set to
            // false you wil howver loose support for built-in CurrencyManager 
            // synchronization.
            grid.BindToCurrencyManager = false;

            if (typeof(object).AssemblyQualifiedName.IndexOf("Version=1") == -1)
            {
                // .NET 2.0 gets very slow when subscribing to ListChanged event on the 
                // DataTable.DefaultView. The following setting allows the engine to wrap 
                // datatable with a Syncfusion.Collections.DataTableList to work around 
                // this bottleneck.
                //
                // .NET 1.0 and 1.1 are just fine with using DataTable.DefaultView
                //
                grid.AllowSwapDataViewWithDataTableList = true;
            }
        }
        #endregion

        #region Grid Settings
        /// <summary>
        /// Grid Setting for better Look and Feel
        /// </summary>
        private void InitializeGroupingGrid()
        {
            if (this.grid != null)
                this.grid.Dispose();

            DateTime dtStart = DateTime.Now;

            Cursor.Current = Cursors.WaitCursor;

            // Fill DataTable
            InitializeDataTable();

            DateTime dtFill = DateTime.Now;

            // Show an empty grid - triggers JIT compilation when run first time
            this.grid = new GridGroupingControl();
            this.grid.TableDescriptor.AllowCalculateMaxColumnWidth = calculateMaxColumnWidth;
            this.grid.Dock = DockStyle.Fill;
            this.grid.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.grid.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.grid.TopLevelGroupOptions.ShowCaption = false;
            this.grid.Appearance.AnyCell.Font.Facename = "Segoe UI";
            this.BackColor = Color.White;
            //Used to set Selection mode in grid
            this.grid.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
            this.grid.AllowProportionalColumnSizing = true;
            // only set this on true multiprocessor machines - otherwise it slows down a bit
            // because of synchronization overhead.
            this.grid.Table.AllowThreading = this.allowMultiThreading;

            OptimizeGridSettings(grid);

            // Assign data source
            if (useGroupingSortList)
            {
                GroupingSortList gs = new GroupingSortList(this.table);
                this.grid.DataSource = gs;
            }
            else
                this.grid.DataSource = this.table;

            // Assign grouping and sort order
            if (this.sortandCategorize)
            {
                this.grid.TableDescriptor.GroupedColumns.Add("State");
                this.grid.TableDescriptor.GroupedColumns.Add("Zip");
            }

            // Force filling and intialization of engine and drawing of grid.
            int count = this.grid.Table.DisplayElements.Count;

            DateTime dtCount = DateTime.Now;

            // paint the grid.
            this.gridPanel.Controls.Add((Control)this.grid);

            this.grid.TableDescriptor.Appearance.AnyHeaderCell.Font.Bold = true;

            this.grid.Update();

            Cursor.Current = Cursors.Default;

            DateTime dtPaint = DateTime.Now;

            string time1 = String.Format("Fill Datatable: {0}\r\n", dtFill - dtStart);
            string time3 = String.Format("Set data source and categorize: {0}\r\n", dtCount - dtFill);
            string time4 = String.Format("Repaint: {0}\r\n", dtPaint - dtCount);
            string time6 = String.Format("Total time: {0}\r\n", dtPaint - dtStart);

            this.textBox1.Text += "\r\n\r\n" + time1 + time3 + time4 + time6;
            this.LogMemoryUsage();
            this.DropShadow = true;
            this.grid.GridVisualStyles = GridVisualStyles.Metro;
            this.grid.GridOfficeScrollBars = OfficeScrollBars.Metro;
            this.BackColor = Color.White;
            
            //Move to next control while pressing the tabkey
            this.grid.WantTabKey = false;
        }
        #endregion

        #region Designer Stuffs
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.btnInitGrid = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnResetGrid = new Syncfusion.Windows.Forms.ButtonAdv();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelRecordCount = new System.Windows.Forms.Label();
            this.labelZipCount = new System.Windows.Forms.Label();
            this.checkBoxCalculateMaximumWidth = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxUseDataViewSort = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxMultiThreading = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.textBoxRecordCount = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.textBoxZipCount = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRepeatCount = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.buttonInsertRecords = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonRemoveRecords = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonChangeRecords = new Syncfusion.Windows.Forms.ButtonAdv();
            this.checkBoxSortandCategorize = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxUseScrollWindow = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.grpInitializeTable = new System.Windows.Forms.GroupBox();
            this.grpgroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChangeNames = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnExpandAll = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnCollapseAll = new Syncfusion.Windows.Forms.ButtonAdv();
            this.txtBatchSize = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lbllabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxCalculateMaximumWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxUseDataViewSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxMultiThreading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxRecordCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxZipCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxRepeatCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxSortandCategorize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxUseScrollWindow)).BeginInit();
            this.grpInitializeTable.SuspendLayout();
            this.grpgroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBatchSize)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPanel
            // 
            this.gridPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPanel.Location = new System.Drawing.Point(28, 12);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(716, 432);
            this.gridPanel.TabIndex = 0;
            // 
            // btnInitGrid
            // 
            this.btnInitGrid.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnInitGrid.FlatStyle = FlatStyle.Flat;
            this.btnInitGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnInitGrid.BeforeTouchSize = new System.Drawing.Size(78, 24);
            this.btnInitGrid.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.btnInitGrid.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInitGrid.ForeColor = System.Drawing.Color.White;
            this.btnInitGrid.IsBackStageButton = false;
            this.btnInitGrid.Location = new System.Drawing.Point(17, 259);
            this.btnInitGrid.Name = "btnInitGrid";
            this.btnInitGrid.Size = new System.Drawing.Size(78, 24);
            this.btnInitGrid.TabIndex = 6;
            this.btnInitGrid.Text = "Load Grid";
            this.btnInitGrid.Click += new System.EventHandler(this.btnInitGrid_Click);
            // 
            // btnResetGrid
            // 
            this.btnResetGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetGrid.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnResetGrid.FlatStyle = FlatStyle.Flat;
            this.btnResetGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnResetGrid.BeforeTouchSize = new System.Drawing.Size(90, 24);
            this.btnResetGrid.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.btnResetGrid.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetGrid.ForeColor = System.Drawing.Color.White;
            this.btnResetGrid.IsBackStageButton = false;
            this.btnResetGrid.Location = new System.Drawing.Point(118, 259);
            this.btnResetGrid.Name = "btnResetGrid";
            this.btnResetGrid.Size = new System.Drawing.Size(90, 24);
            this.btnResetGrid.TabIndex = 7;
            this.btnResetGrid.Text = "Reset Grid";
            this.btnResetGrid.Click += new System.EventHandler(this.btnResetGrid_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(28, 468);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(716, 172);
            this.textBox1.TabIndex = 3;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Results:\r\n-----------";
            // 
            // labelRecordCount
            // 
            this.labelRecordCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            //this.labelRecordCount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecordCount.ForeColor = System.Drawing.Color.DimGray;
            this.labelRecordCount.Location = new System.Drawing.Point(35, 44);
            this.labelRecordCount.Name = "labelRecordCount";
            this.labelRecordCount.Size = new System.Drawing.Size(82, 14);
            this.labelRecordCount.TabIndex = 4;
            this.labelRecordCount.Text = "RecordCount";
            // 
            // labelZipCount
            // 
            this.labelZipCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelZipCount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZipCount.ForeColor = System.Drawing.Color.DimGray;
            this.labelZipCount.Location = new System.Drawing.Point(35, 73);
            this.labelZipCount.Name = "labelZipCount";
            this.labelZipCount.Size = new System.Drawing.Size(64, 19);
            this.labelZipCount.TabIndex = 5;
            this.labelZipCount.Text = "Zip Count";
            // 
            // checkBoxCalculateMaximumWidth
            // 
            this.checkBoxCalculateMaximumWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCalculateMaximumWidth.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxCalculateMaximumWidth.Checked = true;
            this.checkBoxCalculateMaximumWidth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCalculateMaximumWidth.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCalculateMaximumWidth.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxCalculateMaximumWidth.Location = new System.Drawing.Point(38, 148);
            this.checkBoxCalculateMaximumWidth.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxCalculateMaximumWidth.Name = "checkBoxCalculateMaximumWidth";
            this.checkBoxCalculateMaximumWidth.Size = new System.Drawing.Size(156, 24);
            this.checkBoxCalculateMaximumWidth.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxCalculateMaximumWidth.DrawFocusRectangle = true;
            this.checkBoxCalculateMaximumWidth.TabIndex = 3;
            this.checkBoxCalculateMaximumWidth.Text = "Calculate Column Width";
            this.checkBoxCalculateMaximumWidth.ThemesEnabled = false;
            // 
            // checkBoxUseDataViewSort
            // 
            this.checkBoxUseDataViewSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxUseDataViewSort.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxUseDataViewSort.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUseDataViewSort.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxUseDataViewSort.Location = new System.Drawing.Point(38, 178);
            this.checkBoxUseDataViewSort.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxUseDataViewSort.Name = "checkBoxUseDataViewSort";
            this.checkBoxUseDataViewSort.Size = new System.Drawing.Size(156, 24);
            this.checkBoxUseDataViewSort.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxUseDataViewSort.DrawFocusRectangle = true;
            this.checkBoxUseDataViewSort.TabIndex = 4;
            this.checkBoxUseDataViewSort.Text = "Use DataView Sort ";
            this.checkBoxUseDataViewSort.ThemesEnabled = false;
            // 
            // checkBoxMultiThreading
            // 
            this.checkBoxMultiThreading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxMultiThreading.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxMultiThreading.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMultiThreading.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxMultiThreading.Location = new System.Drawing.Point(38, 208);
            this.checkBoxMultiThreading.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxMultiThreading.Name = "checkBoxMultiThreading";
            this.checkBoxMultiThreading.Size = new System.Drawing.Size(124, 24);
            this.checkBoxMultiThreading.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxMultiThreading.DrawFocusRectangle = true;
            this.checkBoxMultiThreading.TabIndex = 5;
            this.checkBoxMultiThreading.Text = "MultiThreading";
            this.checkBoxMultiThreading.ThemesEnabled = false;
            // 
            // textBoxRecordCount
            // 
            this.textBoxRecordCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRecordCount.BeforeTouchSize = new System.Drawing.Size(64, 22);
            this.textBoxRecordCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxRecordCount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRecordCount.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxRecordCount.Location = new System.Drawing.Point(118, 36);
            this.textBoxRecordCount.Metrocolor = System.Drawing.Color.Empty;
            this.textBoxRecordCount.Name = "textBoxRecordCount";
            this.textBoxRecordCount.Size = new System.Drawing.Size(64, 22);
            this.textBoxRecordCount.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBoxRecordCount.TabIndex = 0;
            this.textBoxRecordCount.Text = "50000";
            // 
            // textBoxZipCount
            // 
            this.textBoxZipCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxZipCount.BeforeTouchSize = new System.Drawing.Size(64, 22);
            this.textBoxZipCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxZipCount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxZipCount.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxZipCount.Location = new System.Drawing.Point(118, 70);
            this.textBoxZipCount.Metrocolor = System.Drawing.Color.Empty;
            this.textBoxZipCount.Name = "textBoxZipCount";
            this.textBoxZipCount.Size = new System.Drawing.Size(64, 22);
            this.textBoxZipCount.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBoxZipCount.TabIndex = 1;
            this.textBoxZipCount.Text = "1000";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(30, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Repeat Count";
            // 
            // textBoxRepeatCount
            // 
            this.textBoxRepeatCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxRepeatCount.BeforeTouchSize = new System.Drawing.Size(64, 22);
            this.textBoxRepeatCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxRepeatCount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRepeatCount.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxRepeatCount.Location = new System.Drawing.Point(112, 39);
            this.textBoxRepeatCount.Metrocolor = System.Drawing.Color.Empty;
            this.textBoxRepeatCount.Name = "textBoxRepeatCount";
            this.textBoxRepeatCount.Size = new System.Drawing.Size(64, 22);
            this.textBoxRepeatCount.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBoxRepeatCount.TabIndex = 6;
            this.textBoxRepeatCount.Text = "100";
            // 
            // buttonInsertRecords
            // 
            this.buttonInsertRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInsertRecords.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonInsertRecords.FlatStyle = FlatStyle.Flat;
            this.buttonInsertRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.buttonInsertRecords.BeforeTouchSize = new System.Drawing.Size(94, 23);
            this.buttonInsertRecords.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.buttonInsertRecords.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertRecords.ForeColor = System.Drawing.Color.White;
            this.buttonInsertRecords.IsBackStageButton = false;
            this.buttonInsertRecords.Location = new System.Drawing.Point(114, 143);
            this.buttonInsertRecords.Name = "buttonInsertRecords";
            this.buttonInsertRecords.Size = new System.Drawing.Size(94, 23);
            this.buttonInsertRecords.TabIndex = 13;
            this.buttonInsertRecords.Text = "Insert Records";
            this.buttonInsertRecords.Click += new System.EventHandler(this.buttonInsertRecords_Click);
            // 
            // buttonRemoveRecords
            // 
            this.buttonRemoveRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveRecords.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonRemoveRecords.FlatStyle = FlatStyle.Flat;
            this.buttonRemoveRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.buttonRemoveRecords.BeforeTouchSize = new System.Drawing.Size(104, 23);
            this.buttonRemoveRecords.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.buttonRemoveRecords.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveRecords.ForeColor = System.Drawing.Color.White;
            this.buttonRemoveRecords.IsBackStageButton = false;
            this.buttonRemoveRecords.Location = new System.Drawing.Point(6, 143);
            this.buttonRemoveRecords.Name = "buttonRemoveRecords";
            this.buttonRemoveRecords.Size = new System.Drawing.Size(104, 23);
            this.buttonRemoveRecords.TabIndex = 12;
            this.buttonRemoveRecords.Text = "Remove Records";
            this.buttonRemoveRecords.Click += new System.EventHandler(this.buttonRemoveRecords_Click);
            // 
            // buttonChangeRecords
            // 
            this.buttonChangeRecords.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonChangeRecords.FlatStyle = FlatStyle.Flat;
            this.buttonChangeRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.buttonChangeRecords.BeforeTouchSize = new System.Drawing.Size(202, 23);
            this.buttonChangeRecords.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.buttonChangeRecords.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeRecords.ForeColor = System.Drawing.Color.White;
            this.buttonChangeRecords.IsBackStageButton = false;
            this.buttonChangeRecords.Location = new System.Drawing.Point(6, 172);
            this.buttonChangeRecords.Name = "buttonChangeRecords";
            this.buttonChangeRecords.Size = new System.Drawing.Size(202, 23);
            this.buttonChangeRecords.TabIndex = 16;
            this.buttonChangeRecords.Text = "Change Records";
            this.buttonChangeRecords.Click += new System.EventHandler(this.buttonChangeRecords_Click);
            // 
            // checkBoxSortandCategorize
            // 
            this.checkBoxSortandCategorize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSortandCategorize.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxSortandCategorize.Checked = true;
            this.checkBoxSortandCategorize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSortandCategorize.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSortandCategorize.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxSortandCategorize.Location = new System.Drawing.Point(38, 118);
            this.checkBoxSortandCategorize.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxSortandCategorize.Name = "checkBoxSortandCategorize";
            this.checkBoxSortandCategorize.Size = new System.Drawing.Size(156, 24);
            this.checkBoxSortandCategorize.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxSortandCategorize.DrawFocusRectangle = true;
            this.checkBoxSortandCategorize.TabIndex = 2;
            this.checkBoxSortandCategorize.Text = "Sort and Categorize";
            this.checkBoxSortandCategorize.ThemesEnabled = false;
            // 
            // checkBoxUseScrollWindow
            // 
            this.checkBoxUseScrollWindow.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxUseScrollWindow.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUseScrollWindow.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxUseScrollWindow.Location = new System.Drawing.Point(28, 102);
            this.checkBoxUseScrollWindow.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxUseScrollWindow.Name = "checkBoxUseScrollWindow";
            this.checkBoxUseScrollWindow.Size = new System.Drawing.Size(152, 16);
            this.checkBoxUseScrollWindow.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxUseScrollWindow.DrawFocusRectangle = true;
            this.checkBoxUseScrollWindow.TabIndex = 8;
            this.checkBoxUseScrollWindow.Text = "Use ScrollWindow";
            this.checkBoxUseScrollWindow.ThemesEnabled = false;
            // 
            // grpInitializeTable
            // 
            this.grpInitializeTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInitializeTable.Controls.Add(this.checkBoxCalculateMaximumWidth);
            this.grpInitializeTable.Controls.Add(this.textBoxZipCount);
            this.grpInitializeTable.Controls.Add(this.textBoxRecordCount);
            this.grpInitializeTable.Controls.Add(this.checkBoxSortandCategorize);
            this.grpInitializeTable.Controls.Add(this.btnResetGrid);
            this.grpInitializeTable.Controls.Add(this.btnInitGrid);
            this.grpInitializeTable.Controls.Add(this.labelRecordCount);
            this.grpInitializeTable.Controls.Add(this.checkBoxUseDataViewSort);
            this.grpInitializeTable.Controls.Add(this.checkBoxMultiThreading);
            this.grpInitializeTable.Controls.Add(this.labelZipCount);
            this.grpInitializeTable.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInitializeTable.ForeColor = System.Drawing.Color.DimGray;
            this.grpInitializeTable.Location = new System.Drawing.Point(770, 3);
            this.grpInitializeTable.Name = "grpInitializeTable";
            this.grpInitializeTable.Size = new System.Drawing.Size(214, 314);
            this.grpInitializeTable.TabIndex = 14;
            this.grpInitializeTable.TabStop = false;
            this.grpInitializeTable.Text = "Initialize Table";
            // 
            // grpgroupBox1
            // 
            this.grpgroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpgroupBox1.Controls.Add(this.textBoxRepeatCount);
            this.grpgroupBox1.Controls.Add(this.btnChangeNames);
            this.grpgroupBox1.Controls.Add(this.btnExpandAll);
            this.grpgroupBox1.Controls.Add(this.btnCollapseAll);
            this.grpgroupBox1.Controls.Add(this.txtBatchSize);
            this.grpgroupBox1.Controls.Add(this.lbllabel2);
            this.grpgroupBox1.Controls.Add(this.checkBoxUseScrollWindow);
            this.grpgroupBox1.Controls.Add(this.label1);
            this.grpgroupBox1.Controls.Add(this.buttonRemoveRecords);
            this.grpgroupBox1.Controls.Add(this.buttonChangeRecords);
            this.grpgroupBox1.Controls.Add(this.buttonInsertRecords);
            this.grpgroupBox1.Enabled = false;
            this.grpgroupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpgroupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.grpgroupBox1.Location = new System.Drawing.Point(770, 353);
            this.grpgroupBox1.Name = "grpgroupBox1";
            this.grpgroupBox1.Size = new System.Drawing.Size(214, 286);
            this.grpgroupBox1.TabIndex = 15;
            this.grpgroupBox1.TabStop = false;
            this.grpgroupBox1.Text = "Manipulate Grid";
            // 
            // btnChangeNames
            // 
            this.btnChangeNames.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnChangeNames.FlatStyle = FlatStyle.Flat;
            this.btnChangeNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnChangeNames.BeforeTouchSize = new System.Drawing.Size(202, 23);
            this.btnChangeNames.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.btnChangeNames.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeNames.ForeColor = System.Drawing.Color.White;
            this.btnChangeNames.IsBackStageButton = false;
            this.btnChangeNames.Location = new System.Drawing.Point(6, 201);
            this.btnChangeNames.Name = "btnChangeNames";
            this.btnChangeNames.Size = new System.Drawing.Size(202, 23);
            this.btnChangeNames.TabIndex = 17;
            this.btnChangeNames.Text = "Change Names";
            this.btnChangeNames.Click += new System.EventHandler(this.btnChangeNames_Click);
            // 
            // btnExpandAll
            // 
            this.btnExpandAll.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnExpandAll.FlatStyle = FlatStyle.Flat;
            this.btnExpandAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnExpandAll.BeforeTouchSize = new System.Drawing.Size(94, 23);
            this.btnExpandAll.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.btnExpandAll.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpandAll.ForeColor = System.Drawing.Color.White;
            this.btnExpandAll.IsBackStageButton = false;
            this.btnExpandAll.Location = new System.Drawing.Point(114, 230);
            this.btnExpandAll.Name = "btnExpandAll";
            this.btnExpandAll.Size = new System.Drawing.Size(94, 23);
            this.btnExpandAll.TabIndex = 19;
            this.btnExpandAll.Text = "Expand All";
            this.btnExpandAll.Click += new System.EventHandler(this.btnExpandAll_Click);
            // 
            // btnCollapseAll
            // 
            this.btnCollapseAll.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnCollapseAll.FlatStyle = FlatStyle.Flat;
            this.btnCollapseAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnCollapseAll.BeforeTouchSize = new System.Drawing.Size(104, 23);
            this.btnCollapseAll.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.btnCollapseAll.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollapseAll.ForeColor = System.Drawing.Color.White;
            this.btnCollapseAll.IsBackStageButton = false;
            this.btnCollapseAll.Location = new System.Drawing.Point(6, 230);
            this.btnCollapseAll.Name = "btnCollapseAll";
            this.btnCollapseAll.Size = new System.Drawing.Size(104, 23);
            this.btnCollapseAll.TabIndex = 18;
            this.btnCollapseAll.Text = "Collapse All";
            this.btnCollapseAll.Click += new System.EventHandler(this.btnCollapseAll_Click);
            // 
            // txtBatchSize
            // 
            this.txtBatchSize.BeforeTouchSize = new System.Drawing.Size(64, 22);
            this.txtBatchSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBatchSize.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchSize.ForeColor = System.Drawing.Color.DimGray;
            this.txtBatchSize.Location = new System.Drawing.Point(112, 67);
            this.txtBatchSize.Metrocolor = System.Drawing.Color.Empty;
            this.txtBatchSize.Name = "txtBatchSize";
            this.txtBatchSize.Size = new System.Drawing.Size(64, 22);
            this.txtBatchSize.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtBatchSize.TabIndex = 7;
            this.txtBatchSize.Text = "1";
            // 
            // lbllabel2
            // 
            this.lbllabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllabel2.ForeColor = System.Drawing.Color.DimGray;
            this.lbllabel2.Location = new System.Drawing.Point(30, 73);
            this.lbllabel2.Name = "lbllabel2";
            this.lbllabel2.Size = new System.Drawing.Size(72, 16);
            this.lbllabel2.TabIndex = 0;
            this.lbllabel2.Text = "Batch Size";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font; 
            this.ClientSize = new System.Drawing.Size(1012, 659);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gridPanel);
            this.Controls.Add(this.grpInitializeTable);
            this.Controls.Add(this.grpgroupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 690);
            this.Name = "Form1";
            this.Text = "Grouping Performance";
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxCalculateMaximumWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxUseDataViewSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxMultiThreading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxRecordCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxZipCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxRepeatCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxSortandCategorize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxUseScrollWindow)).EndInit();
            this.grpInitializeTable.ResumeLayout(false);
            this.grpInitializeTable.PerformLayout();
            this.grpgroupBox1.ResumeLayout(false);
            this.grpgroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBatchSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
# if SyncfusionFramework1_1 || SyncfusionFramework2_0
            Application.EnableVisualStyles();
# endif

            Application.Run(new Form1());
        }
        #region Dispose
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
        #endregion
        #endregion

        #region Events

        private void btnInitGrid_Click(object sender, System.EventArgs e)
        {
            this.grpgroupBox1.Enabled = true;
            int value1, value2;
            if ((int.TryParse(this.textBoxRecordCount.Text, out value1)) &&
                (int.TryParse(this.textBoxZipCount.Text, out value2)))
            {

                this.allowMultiThreading = this.checkBoxMultiThreading.Checked;
                this.useGroupingSortList = this.checkBoxUseDataViewSort.Checked;
                this.calculateMaxColumnWidth = this.checkBoxCalculateMaximumWidth.Checked;
                this.recordCount = Convert.ToInt32(this.textBoxRecordCount.Text);
                this.zipCount = Convert.ToInt32(this.textBoxZipCount.Text);
                this.sortandCategorize = checkBoxSortandCategorize.Checked;
                this.InitializeGroupingGrid();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer number", "Info");
            }
        }

        private void btnResetGrid_Click(object sender, System.EventArgs e)
        {
            this.grpgroupBox1.Enabled = false;
            this.textBoxRecordCount.Clear();
            this.textBoxZipCount.Clear();
            this.ResetGroupingGrid();
        }

        private void buttonInsertRecords_Click(object sender, System.EventArgs e)
        {
            DateTime dtStart = DateTime.Now;
            if (grid == null)
                return;
            int value1, value2;
            if (int.TryParse(this.textBoxRepeatCount.Text, out value1) && (int.TryParse(this.txtBatchSize.Text, out value2)))
            {
                repeatCount = Convert.ToInt32(this.textBoxRepeatCount.Text);
                batchSize = Convert.ToInt32(this.txtBatchSize.Text);
                optimizeScrolling = checkBoxUseScrollWindow.Checked;

                Cursor.Current = Cursors.WaitCursor;



                Random random = new Random(randomKey++);
                int numStates = states.GetLength(0);
                string nameFormat = "Ins{0:00000}";

                // Use ScrollWindow operations instead of invalidating whole grid when
                // inserting or removing records.
                this.grid.TableControl.OptimizeInsertRemoveCells = optimizeScrolling;

                for (int i = 0; i < repeatCount; i++)
                {
                    DataRow row = this.table.NewRow();
                    row["Name"] = string.Format(nameFormat, this.table.Rows.Count);
                    row["State"] = states[random.Next(numStates - 1)];
                    row["Zip"] = random.Next(zipCount);
                    this.table.Rows.Add(row);

                    // Force immediate update of visible area and scrollbars after each operation
                    // when grouped, record will automatically be inserted in the correct group
                    // and sort order.
                    if ((i + 1) % batchSize == 0)
                        grid.Update();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer number", "Info");
            }
            this.grid.Update();

            DateTime dtEnd = DateTime.Now;

            Cursor.Current = Cursors.Default;

            string time1 = String.Format("Inserted {0} Records: {1}\r\n", repeatCount, dtEnd - dtStart);
            this.textBox1.Text += "\r\n\r\n" + time1;
            this.LogMemoryUsage();
        }

        private void buttonRemoveRecords_Click(object sender, System.EventArgs e)
        {
            if (grid == null)
                return;

            repeatCount = Convert.ToInt32(this.textBoxRepeatCount.Text);
            batchSize = Convert.ToInt32(this.txtBatchSize.Text);
            optimizeScrolling = checkBoxUseScrollWindow.Checked;

            Cursor.Current = Cursors.WaitCursor;

            DateTime dtStart = DateTime.Now;

            Random random = new Random(randomKey++);

            // Use ScrollWindow operations instead of invalidating whole grid when
            // inserting or removing records.
            this.grid.TableControl.OptimizeInsertRemoveCells = optimizeScrolling;

            for (int i = 0; i < repeatCount; i++)
            {
                int record = (int)Math.Min(table.Rows.Count - 1, random.Next(0, table.Rows.Count));
                if (record < 0)
                    break;

                this.table.Rows.RemoveAt(record);

                // Force immediate update of visible area and scrollbars after each operation
                //Trace.WriteLine(String.Format("Table Record Count {0}, Grid Record Count {1}/{3}, Display Element Count {2}\r\n", table.Rows.Count, grid.Table.Records.Count, grid.Table.DisplayElements.Count, grid.Table.UnsortedRecords.Count));
                if ((i + 1) % batchSize == 0)
                    grid.Update();
            }
            this.grid.Update();

            DateTime dtEnd = DateTime.Now;

            Cursor.Current = Cursors.Default;

            string time1 = String.Format("Removed {0} Records: {1}\r\n", repeatCount, dtEnd - dtStart);
            this.textBox1.Text += "\r\n\r\n" + time1;
            this.LogMemoryUsage();
        }

        private void btnChangeNames_Click(object sender, System.EventArgs e)
        {
            if (grid == null)
                return;

            repeatCount = Convert.ToInt32(this.textBoxRepeatCount.Text);
            batchSize = Convert.ToInt32(this.txtBatchSize.Text);
            optimizeScrolling = checkBoxUseScrollWindow.Checked;

            Cursor.Current = Cursors.WaitCursor;

            DateTime dtStart = DateTime.Now;

            Random random = new Random(randomKey++);
            string nameFormat = "Chg{0:00000}";
            int numStates = states.GetLength(0);


            // Use ScrollWindow operations instead of invalidating whole grid when
            // inserting or removing records.
            this.grid.TableControl.OptimizeInsertRemoveCells = optimizeScrolling;

            for (int i = 0; i < repeatCount; i++)
            {
                int record = (int)Math.Min(table.Rows.Count - 1, random.Next(table.Rows.Count));
                if (record >= 0)
                {
                    DataRow row = this.table.Rows[record];
                    row["Name"] = string.Format(nameFormat, i);
                }

                // Force immediate update of visible area and scrollbars after each operation
                // If grid is sorted by name, the record will be removed and reinserted at correct
                // sort position.
                if ((i + 1) % batchSize == 0)
                    grid.Update();
            }
            this.grid.Update();

            DateTime dtEnd = DateTime.Now;

            Cursor.Current = Cursors.Default;

            string time1 = String.Format("Changed {0} Records: {1}\r\n", repeatCount, dtEnd - dtStart);
            this.textBox1.Text += "\r\n\r\n" + time1;
            this.LogMemoryUsage();
        }

        private void btnCollapseAll_Click(object sender, System.EventArgs e)
        {
            if (grid == null)
                return;

            DateTime dtStart = DateTime.Now;

            Cursor.Current = Cursors.WaitCursor;

            this.grid.Table.CollapseAllGroups();

            DateTime dtEnd = DateTime.Now;

            Cursor.Current = Cursors.Default;

            string time1 = String.Format("Collapse all groups: {0}\r\n", dtEnd - dtStart);
            this.textBox1.Text += "\r\n\r\n" + time1;
            this.LogMemoryUsage();
        }

        private void btnExpandAll_Click(object sender, System.EventArgs e)
        {
            if (grid == null)
                return;

            DateTime dtStart = DateTime.Now;

            Cursor.Current = Cursors.WaitCursor;

            this.grid.Table.ExpandAllGroups();

            DateTime dtEnd = DateTime.Now;

            Cursor.Current = Cursors.Default;

            string time1 = String.Format("Expanded all groups: {0}\r\n", dtEnd - dtStart);
            this.textBox1.Text += "\r\n\r\n" + time1;
            this.LogMemoryUsage();
        }

        private void buttonChangeRecords_Click(object sender, System.EventArgs e)
        {
            if (grid == null)
                return;

            repeatCount = Convert.ToInt32(this.textBoxRepeatCount.Text);
            batchSize = Convert.ToInt32(this.txtBatchSize.Text);
            optimizeScrolling = checkBoxUseScrollWindow.Checked;

            Cursor.Current = Cursors.WaitCursor;

            DateTime dtStart = DateTime.Now;

            Random random = new Random(randomKey++);
            string nameFormat = "Chg{0:00000}";
            int numStates = states.GetLength(0);


            // Use ScrollWindow operations instead of invalidating whole grid when
            // inserting or removing records.
            this.grid.TableControl.OptimizeInsertRemoveCells = optimizeScrolling;

            for (int i = 0; i < repeatCount; i++)
            {
                int record = (int)Math.Min(table.Rows.Count - 1, random.Next(table.Rows.Count));
                if (record >= 0)
                {
                    DataRow row = this.table.Rows[record];
                    row.BeginEdit();
                    row["Name"] = string.Format(nameFormat, i);
                    row["State"] = states[random.Next(numStates - 1)];
                    row["Zip"] = random.Next(zipCount);
                    row.EndEdit();
                }

                // Force immediate update of visible area and scrollbars after each operation
                // If grid is sorted by name, the record will be removed and reinserted at correct
                // sort position.
                if ((i + 1) % batchSize == 0)
                    grid.Update();
            }
            this.grid.Update();

            DateTime dtEnd = DateTime.Now;

            Cursor.Current = Cursors.Default;

            string time1 = String.Format("Changed {0} Records: {1}\r\n", repeatCount, dtEnd - dtStart);
            this.textBox1.Text += "\r\n\r\n" + time1;
            this.LogMemoryUsage();
        }

        #endregion
    }

	/// <summary>
	/// GroupingSortList wraps a DataView with a IBindingList and implements the IGroupingList
	/// interface and its Sort method. This allows performing the sort on the dataview directly
	/// instead of letting the grouping engine perform the sorting.
	/// </summary>
	public class GroupingSortList : IGroupingList, IBindingList
	{
		DataTable dt;
		DataView dv;
		IBindingList bindingList;

		public GroupingSortList(DataTable dt)
		{
			this.dt = dt;
			this.dv = dt.DefaultView;
			bindingList = (IBindingList) dv;
			bindingList.ListChanged += new ListChangedEventHandler(bindingList_ListChanged);
		}

		#region IGroupingList Members

		public void ApplySort(RelationChildColumnDescriptorCollection relationChildColumns, SortColumnDescriptorCollection groupColumns, SortColumnDescriptorCollection sortColumns)
		{
			bool first = true;
			StringBuilder sb = new StringBuilder();
			foreach (SortColumnDescriptor sd in relationChildColumns)
			{
				if (first)
					first = false;
				else
					sb.Append(", ");

				sb.Append(sd.FieldDescriptor.MappingName);
				if (sd.SortDirection == ListSortDirection.Descending)
					sb.Append(" DESC");
			}
			string sort = sb.ToString();
			if (sort != dv.Sort)
			{
				dv.Sort = sort;
			}
		}

		public bool AllowItemReference
		{
			get
			{
				return false;
			}
		}

		public bool SupportsGroupSorting
		{
			get
			{
				return true;
			}
		}

		public Syncfusion.Grouping.GroupingSortBehavior GroupingSortBehavior
		{
			get
			{
				return Syncfusion.Grouping.GroupingSortBehavior.GroupByGroup;
			}
		}

		#endregion

		#region IBindingList Members

		public void AddIndex(PropertyDescriptor property)
		{
			bindingList.AddIndex(property);
		}

		public bool AllowNew
		{
			get
			{
				return bindingList.AllowNew;
			}
		}

		void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, System.ComponentModel.ListSortDirection direction)
		{
			bindingList.ApplySort(property, direction);
		}

		public PropertyDescriptor SortProperty
		{
			get
			{
				return bindingList.SortProperty;
			}
		}

		public int Find(PropertyDescriptor property, object key)
		{
			return bindingList.Find(property, key);
		}

		public bool SupportsSorting
		{
			get
			{
				return bindingList.SupportsSorting;
			}
		}

		public bool IsSorted
		{
			get
			{
				return bindingList.IsSorted;
			}
		}

		public bool AllowRemove
		{
			get
			{
				return bindingList.AllowRemove;
			}
		}

		public bool SupportsSearching
		{
			get
			{
				return bindingList.SupportsSearching;
			}
		}

		public System.ComponentModel.ListSortDirection SortDirection
		{
			get
			{
				return bindingList.SortDirection;
			}
		}

		public event System.ComponentModel.ListChangedEventHandler ListChanged;

		public bool SupportsChangeNotification
		{
			get
			{
				return bindingList.SupportsChangeNotification;
			}
		}

		public void RemoveSort()
		{
			bindingList.RemoveSort();
		}

		public object AddNew()
		{
			return bindingList.AddNew();
		}

		public bool AllowEdit
		{
			get
			{
				return bindingList.AllowEdit;
			}
		}

		public void RemoveIndex(PropertyDescriptor property)
		{
			bindingList.RemoveIndex(property);
		}

		#endregion

		#region IList Members

		public bool IsReadOnly
		{
			get
			{
				return bindingList.IsReadOnly;
			}
		}

		public object this[int index]
		{
			get
			{
				return bindingList[index];
			}
			set
			{
				bindingList[index] = value;
			}
		}

		public void RemoveAt(int index)
		{
			bindingList.RemoveAt(index);
		}

		public void Insert(int index, object value)
		{
			bindingList.Insert(index, value);
		}

		public void Remove(object value)
		{
			bindingList.Remove(value);
		}

		public bool Contains(object value)
		{

			return bindingList.Contains(value);
		}

		public void Clear()
		{
			bindingList.Clear();
		}

		public int IndexOf(object value)
		{
			return bindingList.IndexOf(value);
		}

		public int Add(object value)
		{
			return bindingList.Add(value);
		}

		public bool IsFixedSize
		{
			get
			{
				return bindingList.IsFixedSize;
			}
		}

		#endregion

		#region ICollection Members

		public bool IsSynchronized
		{
			get
			{
				return bindingList.IsSynchronized;
			}
		}

		public int Count
		{
			get
			{
				return bindingList.Count;
			}
		}

		public void CopyTo(Array array, int index)
		{
			bindingList.CopyTo(array, index);
		}

		public object SyncRoot
		{
			get
			{
				return bindingList.SyncRoot;
			}
		}

		#endregion

		#region IEnumerable Members

		public IEnumerator GetEnumerator()
		{
			return bindingList.GetEnumerator();
		}

		#endregion

		private void bindingList_ListChanged(object sender, ListChangedEventArgs e)
		{
			if (ListChanged != null)
				ListChanged(this, e);
		}
	}

	/// <summary>
	/// GroupingEngineFactory provides a trimmed down GridGroup
	/// which eliminates overhead of not needed preview rows, header and footer cells.
	/// </summary>
	public class GroupingEngineFactory : GridEngineFactoryBase
	{
		public override GridEngine CreateEngine()
		{
			return new GroupingEngine();
		}
	}

	public class GroupingEngine : GridEngine
	{
		public override Group CreateGroup(Section parent)
		{
			return new GroupingGroup(parent);
		}

	}

	public class GroupingGroup : Group
	{
		public GroupingGroup(Section parent)
			: base(parent)
		{
		}

		protected override void OnInitializeSections(bool hasRecords, SortColumnDescriptorCollection fields)
		{
			this.Sections.Add(this.ParentTableDescriptor.CreateCaptionSection(this));
			if (hasRecords)
				this.Sections.Add(this.ParentTableDescriptor.CreateRecordsDetails(this, fields));
			else
				this.Sections.Add(this.ParentTableDescriptor.CreateGroupsDetails(this, fields));
			this.Sections.Add(this.ParentTableDescriptor.CreateSummarySection(this));
		}

		public override bool IsChildVisible(Element el)
		{
			if (el is CaptionSection)
			{
				return true;
			}
			else if (el is DetailsSection)
			{
				return this.IsExpanded;
			}
			else if (el is GridSummarySection)
			{
				return this.IsExpanded;
			}
			return true;
		}
	}

}
