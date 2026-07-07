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
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Grouping;
using ISummary = Syncfusion.Collections.BinaryTree.ITreeTableSummary;
using Syncfusion.GridHelperClasses;
using DemoCommon.Grid;

namespace CustomSectionInGroup
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : GridDemoForm
    {
        #region Privat Variables
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
        private StackedHeaders.DataSet1 northwindDataSet1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapterOrders;
        private System.Data.SqlClient.SqlConnection sqlConnection2;
        private PropertyGrid propertyGrid1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv1;
        FieldChooser fchooser = null;
        string xmlName = "Common\\Data\\Orders.xml";
        bool msdeAvailable = false;
        private System.ComponentModel.Container components = null;
        #endregion

        #region Constructor
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            InitializeDataSet();
            GridSettings();
        }
        #endregion

        #region GridSettings
        /// <summary>
        /// Required Method for Grid Settings
        /// </summary>
        void GridSettings()
        {
            this.gridGroupingControl1.DataSource = this.northwindDataSet1.Orders;
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
            fchooser = new FieldChooser(this.gridGroupingControl1);
            this.checkBoxAdv1.Checked = true;
            this.checkBoxAdv1.EnableTouchMode = true;
            this.gridGroupingControl1.TableDescriptor.Columns["OrderID"].HeaderText = "Order ID";
            this.gridGroupingControl1.TableDescriptor.Columns["CustomerID"].HeaderText = "Customer ID";
            this.gridGroupingControl1.TableDescriptor.Columns["EmployeeID"].HeaderText = "Employee ID";
            this.gridGroupingControl1.TableDescriptor.Columns["OrderDate"].HeaderText = "Order Date";
            this.gridGroupingControl1.TableDescriptor.Columns["RequiredDate"].HeaderText = "Require Date";
            this.gridGroupingControl1.TableDescriptor.Columns["ShippedDate"].HeaderText = "Shipped Date";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipVia"].HeaderText = "Ship Via";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipName"].HeaderText = "Ship Name";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipAddress"].HeaderText = "Ship Address";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipCity"].HeaderText = "Ship City";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipRegion"].HeaderText = "Ship Region";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipAddress"].HeaderText = "Ship Address";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipCountry"].HeaderText = "Ship Country";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipPostalCode"].HeaderText = "Ship Postal Code";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipPostalCode"].Width = 160;
            this.gridGroupingControl1.Table.DefaultColumnHeaderRowHeight = 30;
			this.gridGroupingControl1.TableControl.DpiAware = true;

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;
        }
        #endregion

        #region Sample Customization

        #region Events
        void gridGroupingControl1_QueryCellStyleInfo(object sender, GridTableCellStyleInfoEventArgs e)
        {
            if (e.Style.CellValueType == typeof(DateTime))
            {
                e.Style.Format = "MM/dd/yyyy";
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            for (int j = 0; j < this.gridGroupingControl1.TableDescriptor.StackedHeaderRows["Row1"].Headers.Count; j++)
            {
                Console.WriteLine(this.gridGroupingControl1.TableDescriptor.StackedHeaderRows["Row1"].Headers[j].Name);

            }
        }

        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.checkBoxAdv1.Checked)
            {
                this.gridGroupingControl1.EnableTouchMode = true;
            }
            else
            {
                this.gridGroupingControl1.EnableTouchMode = false;
            }
        }
        #endregion

        #endregion

        #region Designer Stuffs
        
        #region Initialize DataSet
        void InitializeDataSet()
        {
            if (msdeAvailable)
            {
                // Initialize the data set

                this.northwindDataSet1.BeginInit();

                // Order is important here - first fill tables that are referenced with 
                // foreign keys, then tables that have references to others.

                this.sqlDataAdapterOrders.Fill(this.northwindDataSet1);

                this.northwindDataSet1.EndInit();

                this.northwindDataSet1.WriteXml(xmlName);
            }
            else
            {
                // Read from a xml file instead. 
                if (!ReadXml(this.northwindDataSet1, xmlName))
                {
                    // If no xml found, try again with MSDE
                    msdeAvailable = true;
                    InitializeDataSet();
                }
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.gridGroupingControl1.QueryCellStyleInfo += new GridTableCellStyleInfoEventHandler(gridGroupingControl1_QueryCellStyleInfo);
        }
        #endregion

        /// <summary>
        /// Find the Data file
        /// </summary>
        bool ReadXml(DataSet ds, string xmlFileName)
        {
            // Check both in parent folder and Parent\Data folders.
            string xmlDataFileName = @"Common\Data\" + xmlFileName;
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(xmlFileName))
                {
                    ds.ReadXml(xmlFileName);
                    return true;
                }
                if (System.IO.File.Exists(xmlDataFileName))
                {
                    ds.ReadXml(xmlDataFileName);
                    return true;
                }
                xmlFileName = @"..\" + xmlFileName;
                xmlDataFileName = @"..\" + xmlDataFileName;
            }

            return false;
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

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor43 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor44 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor45 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor46 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor47 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor48 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor49 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor50 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor51 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor52 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor53 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor54 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor55 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor56 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderRowDescriptor gridStackedHeaderRowDescriptor4 = new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderRowDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor gridStackedHeaderDescriptor13 = new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor gridStackedHeaderDescriptor14 = new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor gridStackedHeaderDescriptor15 = new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor gridStackedHeaderDescriptor16 = new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection2 = new System.Data.SqlClient.SqlConnection();
            this.sqlDataAdapterOrders = new System.Data.SqlClient.SqlDataAdapter();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.northwindDataSet1 = new StackedHeaders.DataSet1();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, Shi" +
    "pVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, Ship" +
    "Country FROM Orders";
            this.sqlSelectCommand2.Connection = this.sqlConnection2;
            // 
            // sqlConnection2
            // 
            this.sqlConnection2.ConnectionString = "Network Address=66.135.59.108,49489;initial catalog=NORTHWIND;password=Sync_sampl" +
    "es;persist security info=True;user id=sa;packet size=4096;Pooling=true";
            this.sqlConnection2.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDataAdapterOrders
            // 
            this.sqlDataAdapterOrders.SelectCommand = this.sqlSelectCommand2;
            this.sqlDataAdapterOrders.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Orders", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("OrderID", "OrderID"),
                        new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"),
                        new System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"),
                        new System.Data.Common.DataColumnMapping("OrderDate", "OrderDate"),
                        new System.Data.Common.DataColumnMapping("RequiredDate", "RequiredDate"),
                        new System.Data.Common.DataColumnMapping("ShippedDate", "ShippedDate"),
                        new System.Data.Common.DataColumnMapping("ShipVia", "ShipVia"),
                        new System.Data.Common.DataColumnMapping("Freight", "Freight"),
                        new System.Data.Common.DataColumnMapping("ShipName", "ShipName"),
                        new System.Data.Common.DataColumnMapping("ShipAddress", "ShipAddress"),
                        new System.Data.Common.DataColumnMapping("ShipCity", "ShipCity"),
                        new System.Data.Common.DataColumnMapping("ShipRegion", "ShipRegion"),
                        new System.Data.Common.DataColumnMapping("ShipPostalCode", "ShipPostalCode"),
                        new System.Data.Common.DataColumnMapping("ShipCountry", "ShipCountry")})});
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.BackColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsBackColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White;
            this.propertyGrid1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyGrid1.HelpBackColor = System.Drawing.Color.White;
            this.propertyGrid1.LineColor = System.Drawing.Color.White;
            this.propertyGrid1.Location = new System.Drawing.Point(670, 61);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.gridGroupingControl1;
            this.propertyGrid1.Size = new System.Drawing.Size(331, 590);
            this.propertyGrid1.TabIndex = 11;
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGroupingControl1.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.gridGroupingControl1.Appearance.StackedHeaderCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))));
            this.gridGroupingControl1.Appearance.StackedHeaderCell.Themed = false;
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.ChildGroupOptions.ShowColumnHeaders = true;
            this.gridGroupingControl1.ChildGroupOptions.ShowStackedHeaders = true;
            this.gridGroupingControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridGroupingControl1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.TableOptions.DefaultColumnWidth = 40;
            this.gridGroupingControl1.Location = new System.Drawing.Point(9, 2);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.ShowGroupDropArea = true;
            this.gridGroupingControl1.Size = new System.Drawing.Size(655, 649);
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
            gridColumnDescriptor43.HeaderImage = null;
            gridColumnDescriptor43.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor43.MappingName = "OrderID";
            gridColumnDescriptor43.SerializedImageArray = "";
            gridColumnDescriptor44.HeaderImage = null;
            gridColumnDescriptor44.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor44.MappingName = "CustomerID";
            gridColumnDescriptor44.SerializedImageArray = "";
            gridColumnDescriptor45.HeaderImage = null;
            gridColumnDescriptor45.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor45.MappingName = "EmployeeID";
            gridColumnDescriptor45.SerializedImageArray = "";
            gridColumnDescriptor46.HeaderImage = null;
            gridColumnDescriptor46.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor46.MappingName = "OrderDate";
            gridColumnDescriptor46.SerializedImageArray = "";
            gridColumnDescriptor47.HeaderImage = null;
            gridColumnDescriptor47.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor47.MappingName = "RequiredDate";
            gridColumnDescriptor47.SerializedImageArray = "";
            gridColumnDescriptor48.HeaderImage = null;
            gridColumnDescriptor48.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor48.MappingName = "ShippedDate";
            gridColumnDescriptor48.SerializedImageArray = "";
            gridColumnDescriptor49.HeaderImage = null;
            gridColumnDescriptor49.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor49.MappingName = "ShipVia";
            gridColumnDescriptor49.SerializedImageArray = "";
            gridColumnDescriptor50.HeaderImage = null;
            gridColumnDescriptor50.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor50.MappingName = "Freight";
            gridColumnDescriptor50.SerializedImageArray = "";
            gridColumnDescriptor51.HeaderImage = null;
            gridColumnDescriptor51.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor51.MappingName = "ShipName";
            gridColumnDescriptor51.SerializedImageArray = "";
            gridColumnDescriptor52.HeaderImage = null;
            gridColumnDescriptor52.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor52.MappingName = "ShipAddress";
            gridColumnDescriptor52.SerializedImageArray = "";
            gridColumnDescriptor53.HeaderImage = null;
            gridColumnDescriptor53.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor53.MappingName = "ShipCity";
            gridColumnDescriptor53.SerializedImageArray = "";
            gridColumnDescriptor54.HeaderImage = null;
            gridColumnDescriptor54.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor54.MappingName = "ShipRegion";
            gridColumnDescriptor54.SerializedImageArray = "";
            gridColumnDescriptor55.HeaderImage = null;
            gridColumnDescriptor55.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor55.MappingName = "ShipPostalCode";
            gridColumnDescriptor55.SerializedImageArray = "";
            gridColumnDescriptor56.HeaderImage = null;
            gridColumnDescriptor56.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor56.MappingName = "ShipCountry";
            gridColumnDescriptor56.SerializedImageArray = "";
            this.gridGroupingControl1.TableDescriptor.Columns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor[] {
            gridColumnDescriptor43,
            gridColumnDescriptor44,
            gridColumnDescriptor45,
            gridColumnDescriptor46,
            gridColumnDescriptor47,
            gridColumnDescriptor48,
            gridColumnDescriptor49,
            gridColumnDescriptor50,
            gridColumnDescriptor51,
            gridColumnDescriptor52,
            gridColumnDescriptor53,
            gridColumnDescriptor54,
            gridColumnDescriptor55,
            gridColumnDescriptor56});
            this.gridGroupingControl1.TableDescriptor.PrimaryKeyColumns.AddRange(new Syncfusion.Grouping.SortColumnDescriptor[] {
            new Syncfusion.Grouping.SortColumnDescriptor("OrderID", System.ComponentModel.ListSortDirection.Ascending)});
            gridStackedHeaderRowDescriptor4.Appearance.StackedHeaderCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))));
            gridStackedHeaderDescriptor13.Appearance.StackedHeaderCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128))))));
            gridStackedHeaderDescriptor13.Appearance.StackedHeaderCell.TextColor = System.Drawing.Color.Black;
            gridStackedHeaderDescriptor13.HeaderText = "Header One";
            gridStackedHeaderDescriptor13.Name = "StackedHeader 1";
            gridStackedHeaderDescriptor13.VisibleColumns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("OrderID"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("CustomerID"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("EmployeeID")});
            gridStackedHeaderDescriptor14.Appearance.StackedHeaderCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255))))));
            gridStackedHeaderDescriptor14.HeaderText = "Header Two";
            gridStackedHeaderDescriptor14.Name = "StackedHeader 2";
            gridStackedHeaderDescriptor14.VisibleColumns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("OrderDate"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("Freight"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("RequiredDate")});
            gridStackedHeaderDescriptor15.Appearance.StackedHeaderCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))));
            gridStackedHeaderDescriptor15.HeaderText = "Header Three";
            gridStackedHeaderDescriptor15.Name = "StackedHeader 3";
            gridStackedHeaderDescriptor15.VisibleColumns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("ShippedDate"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("ShipVia"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("ShipName")});
            gridStackedHeaderDescriptor16.Appearance.StackedHeaderCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))));
            gridStackedHeaderDescriptor16.HeaderText = "Header Four";
            gridStackedHeaderDescriptor16.Name = "StackedHeader 4";
            gridStackedHeaderDescriptor16.VisibleColumns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("ShipAddress"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("ShipCity"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("ShipRegion"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("ShipPostalCode"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("ShipCountry")});
            gridStackedHeaderRowDescriptor4.Headers.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor[] {
            gridStackedHeaderDescriptor13,
            gridStackedHeaderDescriptor14,
            gridStackedHeaderDescriptor15,
            gridStackedHeaderDescriptor16});
            gridStackedHeaderRowDescriptor4.Name = "Row 1";
            this.gridGroupingControl1.TableDescriptor.StackedHeaderRows.Add(gridStackedHeaderRowDescriptor4);
            this.gridGroupingControl1.TableDescriptor.SummaryRows.Add(new Syncfusion.Windows.Forms.Grid.Grouping.GridSummaryRowDescriptor("SummaryRow 1", new Syncfusion.Windows.Forms.Grid.Grouping.GridSummaryColumnDescriptor[] {
                new Syncfusion.Windows.Forms.Grid.Grouping.GridSummaryColumnDescriptor("FreightAverage", Syncfusion.Grouping.SummaryType.DoubleAggregate, "Freight", "{Average:###.00}")}));
            this.gridGroupingControl1.TableDescriptor.SummaryRows.Add(new Syncfusion.Windows.Forms.Grid.Grouping.GridSummaryRowDescriptor("SummaryRow 2", "Total", new Syncfusion.Windows.Forms.Grid.Grouping.GridSummaryColumnDescriptor[] {
                new Syncfusion.Windows.Forms.Grid.Grouping.GridSummaryColumnDescriptor("FreightTotal", Syncfusion.Grouping.SummaryType.DoubleAggregate, "Freight", "{Sum:###.00}")}));
            this.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25;
            this.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20;
            this.gridGroupingControl1.TableDescriptor.VisibleColumns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("OrderID"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("CustomerID"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("EmployeeID"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("OrderDate"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("Freight"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("RequiredDate"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ShippedDate"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ShipVia"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ShipName"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ShipAddress"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ShipCity"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ShipRegion"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ShipPostalCode"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ShipCountry")});
            this.gridGroupingControl1.TableOptions.GridLineBorder = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229))))));
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            // 
            // northwindDataSet1
            // 
            this.northwindDataSet1.DataSetName = "DataSet1";
            this.northwindDataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.northwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAdv1.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxAdv1.DrawFocusRectangle = false;
            this.checkBoxAdv1.Location = new System.Drawing.Point(679, 13);
            this.checkBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(150, 21);
            this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv1.TabIndex = 12;
            this.checkBoxAdv1.Text = "Enable Touch mode";
            this.checkBoxAdv1.ThemesEnabled = false;
            this.checkBoxAdv1.CheckStateChanged += new System.EventHandler(this.checkBoxAdv1_CheckStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 659);
            this.Controls.Add(this.checkBoxAdv1);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.gridGroupingControl1);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "Form1";
            this.Text = "Stacked Headers";
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
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
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }

        #endregion
        
    }
}