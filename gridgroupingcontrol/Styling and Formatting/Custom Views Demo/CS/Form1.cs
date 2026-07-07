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
using System.Data.OleDb;
using System.IO;
using System.Text;
using System.Diagnostics;
using Syncfusion.Collections.BinaryTree;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using DemoCommon.Grid;

namespace CustomViews
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : GridDemoForm
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }

        #region "API Definition"

        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem50;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private CustomViews.DataSet1 dataSet11;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl groupingGrid1;
        private Syncfusion.Windows.Forms.Tools.GroupBar groupBar1;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem Columns;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem2;
        private Syncfusion.Windows.Forms.Tools.GroupView groupView1;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem3;
        private GroupView groupView2;
        private GroupView groupView3;
        private GroupView groupView4;
        private CheckBoxAdv checkBoxAdv1;
        private Panel panel1;
        private Panel panel2;
        private IContainer components;

        #endregion

        #region "DataSource"

        void ReadXml(DataSet ds, string xmlFileName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (File.Exists(xmlFileName))
                {
                    ds.ReadXml(xmlFileName);
                    break;
                }
                xmlFileName = @"..\" + xmlFileName;
            }
        }

        #endregion

        #region "Constructor"

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            this.GridSettings();
      
        }

        #endregion

        #region "Sample Grid Settings"

        /// <summary>
        /// GridGrouping control getting started customization.
        /// </summary>
        private void GridSettings()
        {
            //used to set multiextended selection mode in gridgrouping control. 
            this.groupingGrid1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
			this.groupingGrid1.TableControl.DpiAware = true;

            //used to set GridCaptionRowHeight.
            this.groupingGrid1.Table.DefaultCaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.groupingGrid1.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30.0f);
            this.groupingGrid1.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            this.MetroColor = System.Drawing.Color.Transparent;

            this.groupingGrid1.DataMember = "";
            this.groupingGrid1.DataSource = this.dataSet11.Customers;
            this.groupingGrid1.ShowGroupDropArea = true;
            this.groupingGrid1.FilterRuntimeProperties = true; // don't show all properties in PropertyGrid

            this.groupingGrid1.QueryCellStyleInfo += new GridTableCellStyleInfoEventHandler(groupingGrid1_QueryCellStyleInfo);
            ReadXml(this.dataSet11, @"GDBDdata.XML");

            this.groupingGrid1.TableDescriptor.Columns["City"].AllowFilter = true;
            this.groupingGrid1.TableDescriptor.Columns["Country"].AllowFilter = true;
            this.groupingGrid1.TableDescriptor.Columns["Region"].AllowFilter = true;
            this.groupingGrid1.TableDescriptor.Columns["ContactTitle"].AllowFilter = true;
            this.groupingGrid1.TableDescriptor.Columns["CompanyName"].AllowFilter = true;
            this.groupingGrid1.TopLevelGroupOptions.ShowFilterBar = true;

            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.BackColor = Color.White;
            this.groupingGrid1.TableOptions.GridLineBorder = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin);
            this.groupingGrid1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.groupingGrid1.TopLevelGroupOptions.ShowCaption = false;
            this.groupingGrid1.Appearance.AnyCell.Font.Facename = "Verdana";
            this.groupingGrid1.Appearance.AnyCell.TextColor = Color.MidnightBlue;

            this.groupView3.GroupViewItemSelected += new System.EventHandler(this.groupView3_GroupViewItemSelected);
            this.groupView1.GroupViewItemSelected += new System.EventHandler(this.groupView1_GroupViewItemSelected);
            this.groupView4.GroupViewItemSelected += new System.EventHandler(this.groupView4_GroupViewItemSelected);
            this.checkBoxAdv1.CheckStateChanged += new System.EventHandler(this.checkBoxAdv1_CheckStateChanged);

            this.groupingGrid1.GridVisualStyles = GridVisualStyles.Metro;
            this.groupingGrid1.TableDescriptor.Columns["CompanyName"].HeaderText = "Company Name";
            this.groupingGrid1.TableDescriptor.Columns["CustomerID"].HeaderText = "Customer ID";
            this.groupingGrid1.TableDescriptor.Columns["ContactName"].HeaderText = "Contact Name";
            this.groupingGrid1.TableDescriptor.Columns["ContactTitle"].HeaderText = "Contact Title";
            this.groupingGrid1.TableDescriptor.Columns["PostalCode"].HeaderText = "Postal Code";

            //Navigate to other control using tabkey navigation
            this.groupingGrid1.WantTabKey = false;

        }

        #endregion

        #region "Sample Customized"

        #region "Events"

        /// <summary>
        /// Set the Data source in specified option
        /// </summary>
        private void groupView1_GroupViewItemSelected(object sender, EventArgs e)
        {
            switch (this.groupView1.GroupViewItems[(sender as GroupView).SelectedItem].Text)
            {
                case "CustomersDataTable (from Xml)":
                    this.groupingGrid1.ResetTableDescriptor();
                    this.groupingGrid1.DataSource = this.dataSet11.Customers;
                    this.groupingGrid1.DataMember = "";
                    break;
                case "Browse Table":
                    SelectTableForm f = new SelectTableForm();
                    f.Table = this.groupingGrid1.Engine.DataMember;
                    if (fileName != "")
                    {
                        f.FileName = fileName;
                        f.Table = this.groupingGrid1.Engine.DataMember;
                    }
                    if (f.ShowDialog() == DialogResult.OK && f.Table != "")
                    {
                        fileName = f.FileName;
                        OleDbDataAdapter dataAdapter = null;
                        DataSet _dataSet = null;
                        string tableName = f.Table;

                        try
                        {
                            // Connection object
                            if (connection == null)
                                connection = new OleDbConnection(f.ConnectionString);

                            // Create data adapter object
                            dataAdapter = new OleDbDataAdapter("SELECT * FROM [" + tableName + "]", connection);

                            // Create a dataset object and fill with data using data adapter's Fill method
                            _dataSet = new DataSet();
                            dataAdapter.Fill(_dataSet, tableName);
                            connection.Close();

                            this.groupingGrid1.CancelEdit();
                            if (f.ResetColumnChecked || f.Table != this.groupingGrid1.Engine.DataMember)
                            {
                                this.groupingGrid1.ResetTableDescriptor();
                            }

                            this.groupingGrid1.Engine.DataMember = "";
                            this.groupingGrid1.Engine.DataSource = _dataSet.Tables[tableName];

                            this.Text = tableName;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Problem with DB access-\n\n   connection: "
                                + f.ConnectionString + "\n\n" + ex.ToString());
                            return;
                        }
                    }
                    break;
                case "Reset Filters, Summaries and Grouping":
                    this.groupingGrid1.ResetTableDescriptor();
                    break;
            }
        }

        /// <summary>
        /// Set the view for columns
        /// </summary>
        private void groupView3_GroupViewItemSelected(object sender, EventArgs e)
        {
            switch (this.groupView3.GroupViewItems[(sender as GroupView).SelectedItem].Text)
            {
                case "Choose Columns ..":
                    _ShowGridColumnsDialog(this.groupingGrid1.Engine.TableDescriptor, "Columns", null, typeof(GridColumnDescriptorCollection));
                    break;
                case "Reset Columns":
                    this.groupingGrid1.Engine.TableDescriptor.ResetColumns();
                    break;
                case "Choose Column Sets..":
                    _ShowGridColumnsDialog(this.groupingGrid1.Engine.TableDescriptor, "ColumnSets", null, typeof(GridColumnSetDescriptorCollection));
                    break;
                case "Reset ColumnSets":
                    this.groupingGrid1.Engine.TableDescriptor.ResetColumnSets();
                    break;
                case "Choose Column Order ..":
                    _ShowGridColumnsDialog(this.groupingGrid1.Engine.TableDescriptor, "VisibleColumns", null, typeof(GridVisibleColumnDescriptorCollection));
                    break;
                case "Reset Columns Order":
                    this.groupingGrid1.Engine.TableDescriptor.VisibleColumns.Reset();
                    break;
                case "Choose ExpressionFields":
                    _ShowGridColumnsDialog(this.groupingGrid1.Engine.TableDescriptor, "ExpressionFields", null, typeof(ExpressionFieldDescriptorCollection));
                    break;
            }

        }

        /// <summary>
        /// GridGroupingControl view based on Specify option
        /// </summary>
        private void groupView4_GroupViewItemSelected(object sender, EventArgs e)
        {
            switch (this.groupView4.GroupViewItems[(sender as GroupView).SelectedItem].Text)
            {
                case "Choose Filters ..":
                    _ShowGridColumnsDialog(this.groupingGrid1.Engine.TableDescriptor, "RecordFilters", null, typeof(RecordFilterDescriptorCollection));
                    break;
                case "Clear Filters":
                    this.groupingGrid1.Engine.TableDescriptor.ResetRecordFilters();
                    break;
                case "Choose Grouping ..":
                    _ShowGridColumnsDialog(this.groupingGrid1.Engine.TableDescriptor, "GroupedColumns", null, typeof(SortColumnDescriptorCollection));
                    break;
                case "Clear Grouping":
                    this.groupingGrid1.Engine.TableDescriptor.ResetGroupedColumns();
                    break;
                case "Choose Summaries..":
                    _ShowGridColumnsDialog(this.groupingGrid1.Engine.TableDescriptor, "SummaryRows", null, typeof(GridSummaryRowDescriptorCollection));
                    break;
                case "Clear Summaries":
                    this.groupingGrid1.Engine.TableDescriptor.ResetSummaryRows();
                    break;
                case "Choose Sorting..":
                    _ShowGridColumnsDialog(this.groupingGrid1.Engine.TableDescriptor, "SortedColumns", null, typeof(SortColumnDescriptorCollection));
                    break;
                case "Clear Sorting":
                    this.groupingGrid1.Engine.TableDescriptor.ResetSortedColumns();
                    break;
            }
        }

        /// <summary>
        /// Set the theme for GridGrouping Control
        /// </summary>
        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            GridStyleInfo standard = this.groupingGrid1.Engine.Appearance.AnyCell;
            standard.Themed = !standard.Themed;
            this.groupingGrid1.ThemesEnabled = standard.Themed;
            this.groupingGrid1.Office2007ScrollBars = true;
            if (standard.Themed)
            {
                this.groupingGrid1.GridVisualStyles = GridVisualStyles.Metro;
            }
            else
                this.groupingGrid1.TableOptions.GridVisualStyles = GridVisualStyles.SystemTheme;
            this.groupingGrid1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Blue;
        }

        /// <summary>
        /// Set the texr in CellTip
        /// </summary>
        private void groupingGrid1_QueryCellStyleInfo(object sender, GridTableCellStyleInfoEventArgs e)
        {
            e.Style.CellTipText = e.TableCellIdentity.Info;
        }
        #endregion

        #endregion

        #region "Designer Stuff"
        
        #region "Dispose"

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

        #region "Windows Form Designer generated code"

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.components = new Container();
            this.dataSet11 = new CustomViews.DataSet1();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem50 = new System.Windows.Forms.MenuItem();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.groupingGrid1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.groupBar1 = new Syncfusion.Windows.Forms.Tools.GroupBar();
            this.groupView3 = new Syncfusion.Windows.Forms.Tools.GroupView();
            this.groupView4 = new Syncfusion.Windows.Forms.Tools.GroupView();
            this.groupView1 = new Syncfusion.Windows.Forms.Tools.GroupView();
            this.Columns = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem2 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem3 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupView2 = new Syncfusion.Windows.Forms.Tools.GroupView();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupingGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).BeginInit();
            this.groupBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuItem3
            // 
            this.menuItem3.Index = -1;
            this.menuItem3.Text = "";
            // 
            // menuItem50
            // 
            this.menuItem50.Index = -1;
            this.menuItem50.Text = "";
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region," +
                " PostalCode, Country, Phone, Fax FROM Customers";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Network Address=66.135.59.108,49489;initial catalog=NORTHWIND;password=Sync_sampl" +
                "es;persist security info=True;user id=sa;packet size=4096;Pooling=true";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"),
            new System.Data.SqlClient.SqlParameter("@CompanyName", System.Data.SqlDbType.NVarChar, 40, "CompanyName"),
            new System.Data.SqlClient.SqlParameter("@ContactName", System.Data.SqlDbType.NVarChar, 30, "ContactName"),
            new System.Data.SqlClient.SqlParameter("@ContactTitle", System.Data.SqlDbType.NVarChar, 30, "ContactTitle"),
            new System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 60, "Address"),
            new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City"),
            new System.Data.SqlClient.SqlParameter("@Region", System.Data.SqlDbType.NVarChar, 15, "Region"),
            new System.Data.SqlClient.SqlParameter("@PostalCode", System.Data.SqlDbType.NVarChar, 10, "PostalCode"),
            new System.Data.SqlClient.SqlParameter("@Country", System.Data.SqlDbType.NVarChar, 15, "Country"),
            new System.Data.SqlClient.SqlParameter("@Phone", System.Data.SqlDbType.NVarChar, 24, "Phone"),
            new System.Data.SqlClient.SqlParameter("@Fax", System.Data.SqlDbType.NVarChar, 24, "Fax")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"),
            new System.Data.SqlClient.SqlParameter("@CompanyName", System.Data.SqlDbType.NVarChar, 40, "CompanyName"),
            new System.Data.SqlClient.SqlParameter("@ContactName", System.Data.SqlDbType.NVarChar, 30, "ContactName"),
            new System.Data.SqlClient.SqlParameter("@ContactTitle", System.Data.SqlDbType.NVarChar, 30, "ContactTitle"),
            new System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 60, "Address"),
            new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City"),
            new System.Data.SqlClient.SqlParameter("@Region", System.Data.SqlDbType.NVarChar, 15, "Region"),
            new System.Data.SqlClient.SqlParameter("@PostalCode", System.Data.SqlDbType.NVarChar, 10, "PostalCode"),
            new System.Data.SqlClient.SqlParameter("@Country", System.Data.SqlDbType.NVarChar, 15, "Country"),
            new System.Data.SqlClient.SqlParameter("@Phone", System.Data.SqlDbType.NVarChar, 24, "Phone"),
            new System.Data.SqlClient.SqlParameter("@Fax", System.Data.SqlDbType.NVarChar, 24, "Fax"),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CompanyName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CompanyName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ContactName", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ContactName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ContactTitle", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ContactTitle", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Country", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Country", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Fax", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fax", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Phone", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Phone", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_PostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Region", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Region", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CompanyName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CompanyName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ContactName", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ContactName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ContactTitle", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ContactTitle", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Country", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Country", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Fax", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fax", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Phone", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Phone", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_PostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Region", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Region", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Customers", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"),
                        new System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"),
                        new System.Data.Common.DataColumnMapping("ContactName", "ContactName"),
                        new System.Data.Common.DataColumnMapping("ContactTitle", "ContactTitle"),
                        new System.Data.Common.DataColumnMapping("Address", "Address"),
                        new System.Data.Common.DataColumnMapping("City", "City"),
                        new System.Data.Common.DataColumnMapping("Region", "Region"),
                        new System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"),
                        new System.Data.Common.DataColumnMapping("Country", "Country"),
                        new System.Data.Common.DataColumnMapping("Phone", "Phone"),
                        new System.Data.Common.DataColumnMapping("Fax", "Fax")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // groupingGrid1
            // 
            this.groupingGrid1.Dock = DockStyle.Fill;
            this.groupingGrid1.BackColor = System.Drawing.SystemColors.Window;
            this.groupingGrid1.FreezeCaption = false;
            this.groupingGrid1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.groupingGrid1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.groupingGrid1.Location = new System.Drawing.Point(12, 12);
            this.groupingGrid1.Name = "groupingGrid1";
            this.groupingGrid1.ShowNavigationBar = true;
            this.groupingGrid1.ShowNavigationBarToolTips = true;
            this.groupingGrid1.Size = new System.Drawing.Size(780, 587);
            this.groupingGrid1.TabIndex = 1;
            this.groupingGrid1.TableDescriptor.AllowNew = false;
            this.groupingGrid1.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI";
            this.groupingGrid1.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.groupingGrid1.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.groupingGrid1.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.groupingGrid1.TableDescriptor.Appearance.AnyGroupCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235))))));
            this.groupingGrid1.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.groupingGrid1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.groupingGrid1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.groupingGrid1.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.groupingGrid1.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.groupingGrid1.TableDescriptor.Appearance.AnySummaryCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))));
            this.groupingGrid1.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = true;
            this.groupingGrid1.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader";
            this.groupingGrid1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25;
            this.groupingGrid1.TableDescriptor.TableOptions.RecordRowHeight = 20;
            this.groupingGrid1.Text = "groupingGrid1";
            // 
            // groupView3
            // 
            this.groupView3.BackColor = System.Drawing.Color.White;
            this.groupView3.BeforeTouchSize = new System.Drawing.Size(176, 0);
            this.groupView3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupView3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupView3.ForeColor = System.Drawing.Color.DimGray;
            this.groupView3.GroupViewItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupViewItem[] {
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Choose Columns ..", -1, true, null, "Choose Columns .."),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Reset Columns", -1, true, null, "Reset Columns"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Choose Column Sets..", -1, true, null, "Choose Column Sets.."),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Reset ColumnSets", -1, true, null, "Reset ColumnSets"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Choose Column Order ..", -1, true, null, "Choose Column Order .."),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Reset Columns Order", -1, true, null, "Reset Columns Order"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Choose ExpressionFields", -1, true, null, "Choose ExpressionFields")});
            this.groupView3.HighlightItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.groupView3.Location = new System.Drawing.Point(0, 44);
            this.groupView3.Name = "groupView3";
            this.groupView3.SelectedHighlightItemColor = System.Drawing.SystemColors.Highlight;
            this.groupView3.SelectedItemColor = System.Drawing.SystemColors.Highlight;
            this.groupView3.Size = new System.Drawing.Size(176, 0);
            this.groupView3.TabIndex = 28;
            this.groupView3.Text = "groupView3";
            this.groupView3.TextWrap = true;
            // 
            // groupView4
            // 
            this.groupView4.BackColor = System.Drawing.Color.White;
            this.groupView4.BeforeTouchSize = new System.Drawing.Size(176, 226);
            this.groupView4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupView4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupView4.ForeColor = System.Drawing.Color.DimGray;
            this.groupView4.GroupViewItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupViewItem[] {
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Choose Filters ..", -1, true, null, "Choose Filters .."),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Clear Filters", -1, true, null, "Clear Filters"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Choose Grouping ..", -1, true, null, "Choose Grouping .."),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Clear Grouping", -1, true, null, "Clear Grouping"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Choose Sorting..", -1, true, null, "Choose Sorting.."),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Clear Sorting", -1, true, null, "Clear Sorting"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Choose Summaries..", -1, true, null, "Choose Summaries.."),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Clear Summaries", -1, true, null, "Clear Summaries")});
            this.groupView4.HighlightItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.groupView4.Location = new System.Drawing.Point(0, 66);
            this.groupView4.Name = "groupView4";
            this.groupView4.Size = new System.Drawing.Size(176, 226);
            this.groupView4.TabIndex = 29;
            this.groupView4.Text = "groupView4";
            this.groupView4.TextWrap = true;
            // 
            // groupView1
            // 
            this.groupView1.BackColor = System.Drawing.Color.White;
            this.groupView1.BeforeTouchSize = new System.Drawing.Size(176, 0);
            this.groupView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupView1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupView1.ForeColor = System.Drawing.Color.DimGray;
            this.groupView1.GroupViewItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupViewItem[] {
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("CustomersDataTable (from Xml)", -1, true, null, "CustomersDataTable (from Xml)"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Browse Table", -1, true, null, "Browse Table"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Reset Filters, Summaries and Grouping", -1, true, null, "Reset Filters, Summaries and Grouping")});
            this.groupView1.HighlightItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.groupView1.Location = new System.Drawing.Point(0, 22);
            this.groupView1.Name = "groupView1";
            this.groupView1.Size = new System.Drawing.Size(176, 0);
            this.groupView1.TabIndex = 27;
            this.groupView1.Text = "groupView1";
            this.groupView1.TextWrap = true;
            // 
            // Columns
            // 
            this.Columns.BackColor = System.Drawing.Color.White;
            this.Columns.Client = this.groupView1;
            this.Columns.Text = "Table Option";
            // 
            // groupBarItem2
            // 
            this.groupBarItem2.BackColor = System.Drawing.Color.White;
            this.groupBarItem2.Client = this.groupView3;
            this.groupBarItem2.Text = "Column";
            // 
            // groupBarItem3
            // 
            this.groupBarItem3.BackColor = System.Drawing.Color.White;
            this.groupBarItem3.Client = this.groupView4;
            this.groupBarItem3.Text = "Option";
            // 
            // groupView2
            // 
            this.groupView2.BeforeTouchSize = new System.Drawing.Size(176, 104);
            this.groupView2.Location = new System.Drawing.Point(0, 44);
            this.groupView2.Name = "groupView2";
            this.groupView2.Size = new System.Drawing.Size(176, 104);
            this.groupView2.TabIndex = 28;
            this.groupView2.Text = "groupView2";
            // 
            // groupBar1
            // 
            this.groupBar1.AllowDrop = true;
            this.groupBar1.Dock = DockStyle.Fill;
            this.groupBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBar1.BeforeTouchSize = new System.Drawing.Size(176, 292);
            this.groupBar1.BorderColor = System.Drawing.Color.White;
            this.groupBar1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupBar1.Controls.Add(this.groupView3);
            this.groupBar1.Controls.Add(this.groupView4);
            this.groupBar1.Controls.Add(this.groupView1);
            this.groupBar1.ExpandButtonToolTip = null;
            this.groupBar1.FlatLook = true;
            this.groupBar1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBar1.ForeColor = System.Drawing.Color.White;
            this.groupBar1.GroupBarDropDownToolTip = null;
            this.groupBar1.GroupBarItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupBarItem[] {
            this.Columns,
            this.groupBarItem2,
            this.groupBarItem3});
            this.groupBar1.IndexOnVisibleItems = true;
            this.groupBar1.Location = new System.Drawing.Point(14, 3);
            this.groupBar1.MinimizeButtonToolTip = null;
            this.groupBar1.Name = "groupBar1";
            this.groupBar1.NavigationPaneTooltip = null;
            this.groupBar1.PopupClientSize = new System.Drawing.Size(0, 0);
            this.groupBar1.SelectedItem = 2;
            this.groupBar1.Size = new System.Drawing.Size(176, 292);
            this.groupBar1.Splittercolor = System.Drawing.SystemColors.ControlDark;
            this.groupBar1.TabIndex = 22;
            this.groupBar1.Text = "groupBar1";
            this.groupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // checkBoxAdv1
            // 
            //this.checkBoxAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAdv1.Dock = DockStyle.Bottom;
            this.checkBoxAdv1.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv1.Location = new System.Drawing.Point(14, 301);
            this.checkBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(176, 30);
            this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv1.DrawFocusRectangle = true;
            this.checkBoxAdv1.TabIndex = 30;
            this.checkBoxAdv1.Text = "Enable\\Disable XP Themes";
            this.checkBoxAdv1.ThemesEnabled = false;
            // 
            // panel1
            // 
            //this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Dock = DockStyle.Right;
            this.panel1.Controls.Add(this.groupBar1);
            this.panel1.Controls.Add(this.checkBoxAdv1);
            this.panel1.Location = new System.Drawing.Point(798, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 338);
            this.panel1.TabIndex = 31;
            //
            //Panel2
            //
            this.panel2.Location = new Point(28, 23);
            this.panel2.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(this.groupingGrid1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 603);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Custom Views";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupingGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).EndInit();
            this.groupBar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// Display the Grid Base Style dialog
        /// </summary>
        internal DialogResult _ShowGridBaseStylesDialog(object instance, string propertyName, IServiceProvider provider, Type type)
        {
            System.ComponentModel.Design.CollectionEditor ce = new System.ComponentModel.Design.CollectionEditor(type);
            Syncfusion.ComponentModel.WindowsFormsEditorServiceContainer esc = new Syncfusion.ComponentModel.WindowsFormsEditorServiceContainer(provider);
            PropertyDescriptor pd = TypeDescriptor.GetProperties(instance)[propertyName];
            Syncfusion.ComponentModel.TypeDescriptorContext tdc = new Syncfusion.ComponentModel.TypeDescriptorContext(instance, pd);
            tdc.ServiceProvider = esc;

            ce.EditValue(tdc, esc, pd.GetValue(instance));

            return esc.DialogResult;
        }

        /// <summary>
        /// Displa the GridColumn dialog
        /// </summary>
        internal DialogResult _ShowGridColumnsDialog(object instance, string propertyName, IServiceProvider provider, Type type)
        {
            GroupingCollectionEditor ce = new GroupingCollectionEditor(type);
            Syncfusion.ComponentModel.WindowsFormsEditorServiceContainer esc = new Syncfusion.ComponentModel.WindowsFormsEditorServiceContainer(provider);
            PropertyDescriptor pd = TypeDescriptor.GetProperties(instance)[propertyName];
            Syncfusion.ComponentModel.TypeDescriptorContext tdc = new Syncfusion.ComponentModel.TypeDescriptorContext(instance, pd);
            tdc.ServiceProvider = esc;

            ce.EditValue(tdc, esc, pd.GetValue(instance));

            return esc.DialogResult;
        }

        /// <summary>
        /// Find the data file in specified location
        /// </summary>
        void ReadXml(string xmlFileName)
        {
            string fileName = xmlFileName;
            for (int n = 0; n < 10; n++)
            {
                if (File.Exists(xmlFileName))
                {
                    this.dataSet11.ReadXml(xmlFileName);
                    return;
                }
                xmlFileName = @".\" + xmlFileName;
            }
            MessageBox.Show(fileName + " not found. \n\nPlease make sure the Grid\\Samples\\Data folder can be found in a parent directory!", "GroupingPreview - Data folder not found");
            Close();
        }

        bool IsCustomersTableShown()
        {
            return this.groupingGrid1.Engine.DataMember == "Customers" || this.groupingGrid1.Engine.DataMember == "";
        }

        bool IsCustomersTableShown(bool showMessage)
        {
            bool b = IsCustomersTableShown();
            if (!b && showMessage)
                MessageBox.Show("This menu entry only works with the Customers table. \nUse the 'Choose ..' entry below instead.");
            return b;
        }

        OleDbConnection connection;
        string fileName = "";


        #endregion
    }
}