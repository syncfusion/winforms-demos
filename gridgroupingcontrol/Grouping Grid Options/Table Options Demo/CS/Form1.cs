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
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;
using Syncfusion.Windows.Forms.Tools;

namespace TableOptions
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : GridDemoForm
    {
        #region Private Members

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox CodeDisplay;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private TableOptions.DataSet1 dataSet11;
        private System.Windows.Forms.Label label3;
        private IContainer components;
        private ToolTip tipDesc;
        private Panel panel5;
        private Panel panel4;
        private Panel panel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButton1;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv _multiSimple;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv _One;
        private ButtonAdv button1;
        private Label label2;
        private Label label1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv _rowheader;
        private Panel panel2;
        private GridGroupingControl gridGroupingControl1;
        private RadioButtonAdv _recordBased;
        private RadioButtonAdv _modelBased;
        private const string connection = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""{0}"";Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
        #endregion

        #region Constructor

        /// <summary>
        ///  Form Constructor.
        /// </summary>
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
			if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
			}
            // 
            // oleDbConnection1
            // 
            string mdbFileName = FindDatabase(@"Common\Data\ACC.mdb");
            this.oleDbConnection1.ConnectionString = String.Format(Form1.connection, mdbFileName);
            this.oleDbDataAdapter1.Fill(this.dataSet11.Statistics);
            
            GridSettings();
        }

        #endregion

        #region GridSettings

        /// <summary>
        /// Required Method for Grid Settings
        /// </summary>
        void GridSettings()
        {
            this.gridGroupingControl1.TableControl.DpiAware = true;
			this.gridGroupingControl1.AllowProportionalColumnSizing = true;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
            // Header Text changes
            this.gridGroupingControl1.TableDescriptor.Columns["losses"].HeaderText = "Losses";
            this.gridGroupingControl1.TableDescriptor.Columns["ties"].HeaderText = "Ties";
            this.gridGroupingControl1.TableDescriptor.Columns["wins"].HeaderText = "Wins";
            this.gridGroupingControl1.TableDescriptor.Columns["year"].HeaderText = "Year";
            this.SetStyle(ControlStyles.UserPaint, true);

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;
        }

        #endregion

        #region Sample Customization

        #region Event Handlers
        private void _rowheader_CheckedChanged(object sender, System.EventArgs e)
        {
            this.gridGroupingControl1.TableOptions.ShowRowHeader = !this.gridGroupingControl1.TableOptions.ShowRowHeader;
            this.CodeDisplay.Items.Clear();
            this.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.ShowRowHeader = " + this.gridGroupingControl1.TableOptions.ShowRowHeader);
        }

        void _modelBased_CheckedChanged(object sender, EventArgs e)
        {
            // To Clear any selected records in any tables
            foreach (Table t in this.gridGroupingControl1.Engine.EnumerateTables())
                this.gridGroupingControl1.GetTable(t.TableDescriptor.Name).SelectedRecords.Clear();
            // Table Model based selection
            this.label3.Text = "Model Based Selection lets you select across cells not record based";
            this.gridGroupingControl1.TableModel.Options.ShowCurrentCellBorderBehavior = GridShowCurrentCellBorder.AlwaysVisible;
            this.gridGroupingControl1.TableModel.Options.AlphaBlendSelectionColor = Color.Red;
            this.gridGroupingControl1.TableOptions.AllowSelection = GridSelectionFlags.Any;
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.None;
            this.CodeDisplay.Items.Clear();
            this.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.AllowSelection = GridSelectionFlags.Any;");
            this.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.None;");
            this.CodeDisplay.Items.Add("this.gridGroupingControl1.TableModel.Options.AlphaBlendSelectionColor = Color.Red;");
        }

        void _recordBased_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBox2.Enabled = this._recordBased.Checked;
            // To clear modelbased selections in all TableModel
            foreach (Table t in this.gridGroupingControl1.Engine.EnumerateTables())
                this.gridGroupingControl1.GetTableModel(t.TableDescriptor.Name).Selections.Clear();
            // Record Based Selection
            this.gridGroupingControl1.TableOptions.AllowSelection = GridSelectionFlags.None;
            if (_One.Checked)
                this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.One;
            else if (_multiSimple.Checked)
                this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiSimple;
            else if (radioButton1.Checked)
                this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
            this.label3.Text = "Record based selection allows selection in terms of records not cell based";
            this.gridGroupingControl1.TableOptions.ListBoxSelectionCurrentCellOptions = GridListBoxSelectionCurrentCellOptions.None;
            this.gridGroupingControl1.TableModel.Options.ShowCurrentCellBorderBehavior = GridShowCurrentCellBorder.HideAlways;
            this.gridGroupingControl1.TableOptions.AllowSelection = GridSelectionFlags.None;
            this.gridGroupingControl1.TableOptions.SelectionBackColor = Color.LightSteelBlue;
            this.gridGroupingControl1.TableOptions.SelectionTextColor = Color.RoyalBlue;
            this.CodeDisplay.Items.Clear();
        }

        private void _One_CheckedChanged(object sender, System.EventArgs e)
        {
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.One;
            this.CodeDisplay.Items.Clear();
            this.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.AllowSelection = GridSelectionFlags.None;");
            this.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.One;");
            this.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.SelectionBackColor = Color.LightSteelBlue;");
            this.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.SelectionTextColor = Color.RoyalBlue;");
        }

        private void _multiSimple_CheckedChanged_1(object sender, System.EventArgs e)
        {
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiSimple;
            this.CodeDisplay.Items.Clear();
            this.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.AllowSelection = GridSelectionFlags.None;");
            this.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiSimple;");
            this.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.SelectionBackColor = Color.LightSteelBlue;");
            this.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.SelectionTextColor = Color.RoyalBlue;");
        }

        private void radioButton1_CheckedChanged_1(object sender, System.EventArgs e)
        {
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
            this.CodeDisplay.Items.Clear();
            this.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.AllowSelection = GridSelectionFlags.None;");
            this.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;");
            this.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.SelectionBackColor = Color.LightSteelBlue;");
            this.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.SelectionTextColor = Color.RoyalBlue;");
        }

        bool flag = false;

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (!flag)
            {
                flag = true;
                this.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear();
                this.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("Sport");
                this.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("wins", ListSortDirection.Descending);
                this.gridGroupingControl1.TableOptions.ShowTreeLines = true;
                this.gridGroupingControl1.TableOptions.TreeLineBorder = new GridBorder(GridBorderStyle.Solid, Color.Red, GridBorderWeight.Thick);
                this.CodeDisplay.Items.Clear();
                this.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.ShowTreeLines = true;");
                this.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.TreeLineBorder = new GridBorder(GridBorderStyle.Solid, Color.Red, GridBorderWeight.Thick);");
                this.gridGroupingControl1.Table.ExpandAllGroups();
                this.gridGroupingControl1.Table.TopLevelGroup.Groups[0].IsExpanded = false;
                this.button1.Text = "Disable TreeLines";
            }
            else
            {
                flag = false;
                this.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear();
                this.gridGroupingControl1.TableOptions.ShowTreeLines = false;
                this.CodeDisplay.Items.Clear();
                this.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.ShowTreeLines = false;");
                this.button1.Text = "Show TreeLines";
            }
        }

        #endregion

        #endregion

        #region Data Files
        string FindDatabase(string mdbFileName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(mdbFileName))
                {
                    return mdbFileName;
                }
                mdbFileName = @"..\" + mdbFileName;
            }
            return "";
        }
        #endregion

        #region Form Handlers
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

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor8 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor9 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor10 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor11 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor12 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor13 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor14 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CodeDisplay = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.tipDesc = new System.Windows.Forms.ToolTip(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._recordBased = new RadioButtonAdv();
            this._modelBased = new RadioButtonAdv();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this._multiSimple = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this._One = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._rowheader = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.dataSet11 = new TableOptions.DataSet1();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._multiSimple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._One)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._rowheader)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.CodeDisplay);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(1, 534);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(998, 133);
            this.panel3.TabIndex = 4;
            // 
            // CodeDisplay
            // 
            this.CodeDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CodeDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CodeDisplay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeDisplay.ItemHeight = 15;
            this.CodeDisplay.Location = new System.Drawing.Point(3, 30);
            this.CodeDisplay.Name = "CodeDisplay";
            this.CodeDisplay.Size = new System.Drawing.Size(983, 77);
            this.CodeDisplay.TabIndex = 0;
            this.CodeDisplay.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(696, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Model based selection lets you select across cells not record based";
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Statistics", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("losses", "losses"),
                        new System.Data.Common.DataColumnMapping("School", "School"),
                        new System.Data.Common.DataColumnMapping("Sport", "Sport"),
                        new System.Data.Common.DataColumnMapping("ties", "ties"),
                        new System.Data.Common.DataColumnMapping("wins", "wins"),
                        new System.Data.Common.DataColumnMapping("year", "year")})});
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_School", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "School", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_School1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "School", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Sport", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Sport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Sport1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Sport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_losses", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "losses", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_losses1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "losses", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ties", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ties", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ties1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ties", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_wins", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "wins", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_wins1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "wins", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_year", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "year", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_year1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "year", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO Statistics(losses, School, Sport, ties, wins, year) VALUES (?, ?, ?, " +
    "?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("losses", System.Data.OleDb.OleDbType.Integer, 0, "losses"),
            new System.Data.OleDb.OleDbParameter("School", System.Data.OleDb.OleDbType.VarWChar, 255, "School"),
            new System.Data.OleDb.OleDbParameter("Sport", System.Data.OleDb.OleDbType.VarWChar, 255, "Sport"),
            new System.Data.OleDb.OleDbParameter("ties", System.Data.OleDb.OleDbType.Integer, 0, "ties"),
            new System.Data.OleDb.OleDbParameter("wins", System.Data.OleDb.OleDbType.Integer, 0, "wins"),
            new System.Data.OleDb.OleDbParameter("year", System.Data.OleDb.OleDbType.Integer, 0, "year")});
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT ID, losses, School, Sport, ties, wins, year FROM Statistics";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("losses", System.Data.OleDb.OleDbType.Integer, 0, "losses"),
            new System.Data.OleDb.OleDbParameter("School", System.Data.OleDb.OleDbType.VarWChar, 255, "School"),
            new System.Data.OleDb.OleDbParameter("Sport", System.Data.OleDb.OleDbType.VarWChar, 255, "Sport"),
            new System.Data.OleDb.OleDbParameter("ties", System.Data.OleDb.OleDbType.Integer, 0, "ties"),
            new System.Data.OleDb.OleDbParameter("wins", System.Data.OleDb.OleDbType.Integer, 0, "wins"),
            new System.Data.OleDb.OleDbParameter("year", System.Data.OleDb.OleDbType.Integer, 0, "year"),
            new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_School", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "School", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_School1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "School", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Sport", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Sport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Sport1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Sport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_losses", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "losses", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_losses1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "losses", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ties", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ties", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ties1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ties", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_wins", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "wins", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_wins1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "wins", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_year", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "year", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_year1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "year", System.Data.DataRowVersion.Original, null)});
            // 
            // tipDesc
            // 
            this.tipDesc.BackColor = System.Drawing.Color.White;
            this.tipDesc.ForeColor = System.Drawing.Color.Black;
            this.tipDesc.IsBalloon = true;
            this.tipDesc.ShowAlways = true;
            this.tipDesc.UseFading = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1000, 644);
            this.panel5.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1000, 644);
            this.panel4.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this._rowheader);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(829, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 396);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._recordBased);
            this.groupBox1.Controls.Add(this._modelBased);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(6, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 232);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // _recordBased
            // 
            this._recordBased.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this._recordBased.AutoSize = true;
            this._recordBased.Location = new System.Drawing.Point(12, 53);
            this._recordBased.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._recordBased.Location = new System.Drawing.Point(12, 54);
            this._recordBased.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this._recordBased.Name = "_recordBased";
            this._recordBased.Size = new System.Drawing.Size(105, 24);
            this._recordBased.TabIndex = 13;
            this._recordBased.Text = "Record Based";
            this._recordBased.DrawFocusRectangle = true;
            this._recordBased.Style = RadioButtonAdvStyle.Metro;
            this._recordBased.ThemesEnabled = false;
            this._recordBased.CheckChanged += _recordBased_CheckedChanged;
            // 
            // _modelBased
            // 
            this._modelBased.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this._modelBased.AutoSize = true;
            this._modelBased.Checked = true;
            this._modelBased.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._modelBased.Location = new System.Drawing.Point(12, 21);
            this._modelBased.Name = "_modelBased";
            this._modelBased.Size = new System.Drawing.Size(105, 24);
            this._modelBased.TabIndex = 12;
            this._modelBased.TabStop = true;
            this._modelBased.Text = "Model Based";
            this._modelBased.DrawFocusRectangle = true;
            this._modelBased.Style = RadioButtonAdvStyle.Metro;
            this._modelBased.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this._modelBased.CheckChanged += _modelBased_CheckedChanged;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this._multiSimple);
            this.groupBox2.Controls.Add(this._One);
            this.groupBox2.Enabled = false;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 128);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SelectionMode";
            // 
            // radioButton1
            // 
            this.radioButton1.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(16, 88);
            this.radioButton1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(105, 24);
            this.radioButton1.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton1.DrawFocusRectangle = true;
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = false;
            this.radioButton1.Text = "MultiExtended";
            this.radioButton1.ThemesEnabled = false;
            this.radioButton1.CheckChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // _multiSimple
            // 
            this._multiSimple.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this._multiSimple.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._multiSimple.Location = new System.Drawing.Point(16, 56);
            this._multiSimple.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this._multiSimple.Name = "_multiSimple";
            this._multiSimple.Size = new System.Drawing.Size(100, 24);
            this._multiSimple.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this._multiSimple.DrawFocusRectangle = true;
            this._multiSimple.TabIndex = 13;
            this._multiSimple.TabStop = false;
            this._multiSimple.Text = "MultiSimple";
            this._multiSimple.ThemesEnabled = false;
            this._multiSimple.CheckChanged += new System.EventHandler(this._multiSimple_CheckedChanged_1);
            // 
            // _One
            // 
            this._One.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this._One.Checked = true;
            this._One.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._One.Location = new System.Drawing.Point(16, 24);
            this._One.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this._One.Name = "_One";
            this._One.Size = new System.Drawing.Size(100, 24);
            this._One.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this._One.DrawFocusRectangle = true;
            this._One.TabIndex = 12;
            this._One.Text = "One";
            this._One.ThemesEnabled = false;
            this._One.CheckChanged += new System.EventHandler(this._One_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(136, 27);
            this.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.IsBackStageButton = false;
            this.button1.Location = new System.Drawing.Point(12, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 27);
            this.button1.TabIndex = 15;
            this.button1.Text = "ShowTreeLines";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Selection Types";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Table Options";
            // 
            // _rowheader
            // 
            this._rowheader.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this._rowheader.Checked = true;
            this._rowheader.CheckState = System.Windows.Forms.CheckState.Checked;
            this._rowheader.Location = new System.Drawing.Point(14, 50);
            this._rowheader.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this._rowheader.Name = "_rowheader";
            this._rowheader.Size = new System.Drawing.Size(144, 24);
            this._rowheader.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this._rowheader.DrawFocusRectangle = true;
            this._rowheader.TabIndex = 8;
            this._rowheader.Text = "RowHeader";
            this._rowheader.ThemesEnabled = false;
            this._rowheader.CheckStateChanged += new System.EventHandler(this._rowheader_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.gridGroupingControl1);
            this.panel2.Location = new System.Drawing.Point(3, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(809, 512);
            this.panel2.TabIndex = 2;
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.DataSource = this.dataSet11.Statistics;
            this.gridGroupingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGroupingControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.Location = new System.Drawing.Point(0, 0);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.ShowGroupDropArea = true;
            this.gridGroupingControl1.Size = new System.Drawing.Size(809, 512);
            this.gridGroupingControl1.TabIndex = 0;
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
            gridColumnDescriptor8.HeaderImage = null;
            gridColumnDescriptor8.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor8.MappingName = "ID";
            gridColumnDescriptor8.SerializedImageArray = "";
            gridColumnDescriptor9.HeaderImage = null;
            gridColumnDescriptor9.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor9.MappingName = "losses";
            gridColumnDescriptor9.SerializedImageArray = "";
            gridColumnDescriptor10.HeaderImage = null;
            gridColumnDescriptor10.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor10.MappingName = "School";
            gridColumnDescriptor10.SerializedImageArray = "";
            gridColumnDescriptor11.HeaderImage = null;
            gridColumnDescriptor11.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor11.MappingName = "Sport";
            gridColumnDescriptor11.SerializedImageArray = "";
            gridColumnDescriptor12.HeaderImage = null;
            gridColumnDescriptor12.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor12.MappingName = "ties";
            gridColumnDescriptor12.SerializedImageArray = "";
            gridColumnDescriptor13.HeaderImage = null;
            gridColumnDescriptor13.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor13.MappingName = "wins";
            gridColumnDescriptor13.SerializedImageArray = "";
            gridColumnDescriptor14.HeaderImage = null;
            gridColumnDescriptor14.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor14.MappingName = "year";
            gridColumnDescriptor14.SerializedImageArray = "";
            this.gridGroupingControl1.TableDescriptor.Columns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor[] {
            gridColumnDescriptor8,
            gridColumnDescriptor9,
            gridColumnDescriptor10,
            gridColumnDescriptor11,
            gridColumnDescriptor12,
            gridColumnDescriptor13,
            gridColumnDescriptor14});
            this.gridGroupingControl1.TableDescriptor.PrimaryKeyColumns.AddRange(new Syncfusion.Grouping.SortColumnDescriptor[] {
            new Syncfusion.Grouping.SortColumnDescriptor("ID", System.ComponentModel.ListSortDirection.Ascending)});
            this.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            this.gridGroupingControl1.TableDescriptor.VisibleColumns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ID"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("losses"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("School"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("Sport"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ties"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("wins"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("year")});
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 656);
            this.Controls.Add(this.panel5);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Table Options";
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._multiSimple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._One)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._rowheader)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
            Application.Run(new Form1());
        }
        #endregion

    }
}
