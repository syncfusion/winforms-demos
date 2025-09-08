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

namespace TopLevelGroupOptions
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : GridDemoForm
    {
        #region Private Members

        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private TopLevelGroupOptions.DataSet1 dataSet12;
        private IContainer components;
        private ToolTip tipDesc;
        private GridGroupingControl gridGroupingControl1;
        private Panel panel1;
        private Label label2;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv afterDetails;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv beforeDetails;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv showGroupHeader;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv showGroupFooter;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv showCaption;
        private Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
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
			this.oleDbDataAdapter1.Fill(this.dataSet12);
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
            this.gridGroupingControl1.TableControl.DpiAware = true;
            this.gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Verdana";
            this.gridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue;
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
            this.gridGroupingControl1.AllowProportionalColumnSizing = true;
            this.SetStyle(ControlStyles.UserPaint, true);
          
            // Header Text changes
            this.gridGroupingControl1.TableDescriptor.Columns["losses"].HeaderText = "Losses";
            this.gridGroupingControl1.TableDescriptor.Columns["ties"].HeaderText = "Ties";
            this.gridGroupingControl1.TableDescriptor.Columns["wins"].HeaderText = "Wins";
            this.gridGroupingControl1.TableDescriptor.Columns["year"].HeaderText = "Year";

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;
        }

        #endregion

        #region Sample Customization

        /// <summary>
        /// Required Method for sample level customization.
        /// </summary>
        void SampleCustomization()
        {
            this.gridGroupingControl1.TableDescriptor.AllowNew = true;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;  
            // To reduce the displayed records in the TopLevelTable
            this.gridGroupingControl1.TableDescriptor.RecordFilters.Add("[wins] > 30");
        }

        #region Event Handlers
        private void showCaption_CheckedChanged(object sender, System.EventArgs e)
        {
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = !this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption;
            AppendOutput("gridGroupingControl1.TopLevelGroupOptions.ShowCaption", gridGroupingControl1.TopLevelGroupOptions.ShowCaption.ToString());
        }

        private void showGroupFooter_CheckedChanged(object sender, System.EventArgs e)
        {
            this.gridGroupingControl1.TopLevelGroupOptions.ShowGroupFooter = !this.gridGroupingControl1.TopLevelGroupOptions.ShowGroupFooter;
            this.gridGroupingControl1.TableOptions.GroupFooterSectionHeight = 28;
            this.AppendOutput("gridGroupingControl1.TopLevelGroupOptions.ShowGroupFooter", gridGroupingControl1.TopLevelGroupOptions.ShowGroupFooter.ToString());
        }

        private void showGroupHeader_CheckedChanged(object sender, System.EventArgs e)
        {
            this.gridGroupingControl1.TopLevelGroupOptions.ShowGroupHeader = !this.gridGroupingControl1.TopLevelGroupOptions.ShowGroupHeader;
            this.gridGroupingControl1.TableOptions.GroupHeaderSectionHeight = 28;
            this.AppendOutput("gridGroupingControl1.TopLevelGroupOptions.ShowGroupHeader", gridGroupingControl1.TopLevelGroupOptions.ShowGroupHeader.ToString());
        }

        private void beforeDetails_CheckedChanged(object sender, System.EventArgs e)
        {
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = !this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails;
            this.AppendOutput("gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails", gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails.ToString());
        }

        private void afterDetails_CheckedChanged(object sender, System.EventArgs e)
        {
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordAfterDetails = !this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordAfterDetails;
            this.AppendOutput("gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordAfterDetails", gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordAfterDetails.ToString());
        }

        private void gridGroupingControl1_QueryCellStyleInfo(object sender, Syncfusion.Windows.Forms.Grid.Grouping.GridTableCellStyleInfoEventArgs e)
        {
            if (e.TableCellIdentity.TableCellType == GridTableCellType.GroupFooterSectionCell || e.TableCellIdentity.TableCellType == GridTableCellType.GroupHeaderSectionCell)
            {
                e.Style.BackColor = Color.LightSeaGreen;
                e.Style.Enabled = false;
                if (e.TableCellIdentity.TableCellType == GridTableCellType.GroupFooterSectionCell)
                    e.Style.Text = "The details in the footer can be placed by enabling ShowGroupFooter and handling QueryCellStyleInfo";
                if (e.TableCellIdentity.TableCellType == GridTableCellType.GroupHeaderSectionCell)
                    e.Style.Text = "The details in the header can be placed by enabling ShowGroupHeader and handling QueryCellStyleInfo";
            }
        }
        #endregion

        #endregion
        
        public void AppendOutput(string name, string e)
        {
            ListViewItem item;
            try
            {
                item = new ListViewItem(new string[] { name, e });
            }
            catch (Exception ex)
            {
                item = new ListViewItem(new string[] { "Record deleted:", ex.InnerException.Message });
            }
            this.listView1.Items.Add(item);
        }
        #region Designer Stuffs

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

        #region Form Settings
        /// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
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
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor2 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor3 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor4 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor5 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor6 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor7 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            this.dataSet12 = new TopLevelGroupOptions.DataSet1();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.tipDesc = new System.Windows.Forms.ToolTip(this.components);
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.afterDetails = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.beforeDetails = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.showGroupHeader = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.showGroupFooter = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.showCaption = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new ListView();
            this.columnHeader1 = new ColumnHeader();
            this.columnHeader2 = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.afterDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beforeDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showGroupHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showGroupFooter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showCaption)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet12
            // 
            this.dataSet12.DataSetName = "DataSet1";
            this.dataSet12.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = resources.GetString("oleDbConnection1.ConnectionString");
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
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.DataSource = this.dataSet12.Statistics;
            this.gridGroupingControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.Location = new System.Drawing.Point(12, 3);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.ShowGroupDropArea = true;
            this.gridGroupingControl1.Size = new System.Drawing.Size(778, 494);
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
            gridColumnDescriptor1.HeaderImage = null;
            gridColumnDescriptor1.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor1.MappingName = "ID";
            gridColumnDescriptor1.SerializedImageArray = "";
            gridColumnDescriptor2.HeaderImage = null;
            gridColumnDescriptor2.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor2.MappingName = "losses";
            gridColumnDescriptor2.SerializedImageArray = "";
            gridColumnDescriptor3.HeaderImage = null;
            gridColumnDescriptor3.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor3.MappingName = "School";
            gridColumnDescriptor3.SerializedImageArray = "";
            gridColumnDescriptor4.HeaderImage = null;
            gridColumnDescriptor4.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor4.MappingName = "Sport";
            gridColumnDescriptor4.SerializedImageArray = "";
            gridColumnDescriptor5.HeaderImage = null;
            gridColumnDescriptor5.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor5.MappingName = "ties";
            gridColumnDescriptor5.SerializedImageArray = "";
            gridColumnDescriptor6.HeaderImage = null;
            gridColumnDescriptor6.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor6.MappingName = "wins";
            gridColumnDescriptor6.SerializedImageArray = "";
            gridColumnDescriptor7.HeaderImage = null;
            gridColumnDescriptor7.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor7.MappingName = "year";
            gridColumnDescriptor7.SerializedImageArray = "";
            this.gridGroupingControl1.TableDescriptor.Columns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor[] {
            gridColumnDescriptor1,
            gridColumnDescriptor2,
            gridColumnDescriptor3,
            gridColumnDescriptor4,
            gridColumnDescriptor5,
            gridColumnDescriptor6,
            gridColumnDescriptor7});
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
            this.gridGroupingControl1.VersionInfo = "4.201.0.37";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.afterDetails);
            this.panel1.Controls.Add(this.beforeDetails);
            this.panel1.Controls.Add(this.showGroupHeader);
            this.panel1.Controls.Add(this.showGroupFooter);
            this.panel1.Controls.Add(this.showCaption);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(798, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 494);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "AddNewRecordField";
            // 
            // afterDetails
            // 
            this.afterDetails.BeforeTouchSize = new System.Drawing.Size(136, 24);
            this.afterDetails.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afterDetails.Location = new System.Drawing.Point(37, 248);
            this.afterDetails.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.afterDetails.Name = "afterDetails";
            this.afterDetails.Size = new System.Drawing.Size(136, 24);
            this.afterDetails.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.afterDetails.DrawFocusRectangle = true;
            this.afterDetails.TabIndex = 14;
            this.afterDetails.Text = "After Details";
            this.afterDetails.ThemesEnabled = false;
            this.afterDetails.CheckedChanged += new System.EventHandler(this.afterDetails_CheckedChanged);
            // 
            // beforeDetails
            // 
            this.beforeDetails.BeforeTouchSize = new System.Drawing.Size(136, 26);
            this.beforeDetails.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beforeDetails.Location = new System.Drawing.Point(37, 216);
            this.beforeDetails.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.beforeDetails.Name = "beforeDetails";
            this.beforeDetails.Size = new System.Drawing.Size(136, 26);
            this.beforeDetails.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.beforeDetails.DrawFocusRectangle = true;
            this.beforeDetails.TabIndex = 13;
            this.beforeDetails.Text = "Before Details";
            this.beforeDetails.ThemesEnabled = false;
            this.beforeDetails.CheckedChanged += new System.EventHandler(this.beforeDetails_CheckedChanged);
            // 
            // showGroupHeader
            // 
            this.showGroupHeader.BeforeTouchSize = new System.Drawing.Size(152, 22);
            this.showGroupHeader.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showGroupHeader.Location = new System.Drawing.Point(37, 136);
            this.showGroupHeader.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.showGroupHeader.Name = "showGroupHeader";
            this.showGroupHeader.Size = new System.Drawing.Size(152, 22);
            this.showGroupHeader.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.showGroupHeader.DrawFocusRectangle = true;
            this.showGroupHeader.TabIndex = 12;
            this.showGroupHeader.Text = "ShowGroupHeader";
            this.showGroupHeader.ThemesEnabled = false;
            this.showGroupHeader.CheckedChanged += new System.EventHandler(this.showGroupHeader_CheckedChanged);
            // 
            // showGroupFooter
            // 
            this.showGroupFooter.BeforeTouchSize = new System.Drawing.Size(152, 26);
            this.showGroupFooter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showGroupFooter.Location = new System.Drawing.Point(37, 104);
            this.showGroupFooter.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.showGroupFooter.Name = "showGroupFooter";
            this.showGroupFooter.Size = new System.Drawing.Size(152, 26);
            this.showGroupFooter.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.showGroupFooter.DrawFocusRectangle = true;
            this.showGroupFooter.TabIndex = 11;
            this.showGroupFooter.Text = "ShowGroupFooter";
            this.showGroupFooter.ThemesEnabled = false;
            this.showGroupFooter.CheckedChanged += new System.EventHandler(this.showGroupFooter_CheckedChanged);
            // 
            // showCaption
            // 
            this.showCaption.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.showCaption.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCaption.Location = new System.Drawing.Point(37, 72);
            this.showCaption.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.showCaption.Name = "showCaption";
            this.showCaption.Size = new System.Drawing.Size(136, 26);
            this.showCaption.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.showCaption.DrawFocusRectangle = true;
            this.showCaption.TabIndex = 10;
            this.showCaption.Text = "ShowCaption";
            this.showCaption.ThemesEnabled = false;
            this.showCaption.CheckedChanged += new System.EventHandler(this.showCaption_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "TopLevelGroupOptions";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.DimGray;
            this.listView1.Location = new System.Drawing.Point(10, 509);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(994, 142);
            this.listView1.TabIndex = 11;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Property";
            this.columnHeader1.Width = 497;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Details";
            this.columnHeader2.Width = 497;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 656);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.gridGroupingControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Top-Level-Group Options";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.afterDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beforeDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showGroupHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showGroupFooter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showCaption)).EndInit();
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

        #endregion

    }
}
