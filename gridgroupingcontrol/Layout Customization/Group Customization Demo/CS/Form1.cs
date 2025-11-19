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
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace CustomSectionInGroup
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : GridDemoForm
    {
        #region Private Variables
        private CustomSectionInGroup.DataSet1 northwindDataSet1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapterOrders;
        private System.Data.SqlClient.SqlConnection sqlConnection2;
        private Panel panel1;
        private GridGroupingControl gridGroupingControl1;
        private System.ComponentModel.Container components = null;
        int extraSectionCoverCols = 3;
        string xmlName = "Orders.xml";
        bool msdeAvailable = false;
        #endregion

        #region Construstor
        public Form1()
        {
            // GroupingEngineFactory provides a modified GridChildTable that adds an extra section
            GridEngineFactory.Factory = new GroupingEngineFactory();
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
			if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
			}
            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            InitializeDataSet();
            GridSettings();
            SampleCustomization();
        }
        #endregion

        #region GridSettings
        void GridSettings()
        {
            this.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue;
            this.gridGroupingControl1.TableOptions.GridLineBorder = new Syncfusion.Windows.Forms.Grid.GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin);
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.TableControlCurrentCellActivated += new GridTableControlEventHandler(gridGroupingControl1_TableControlCurrentCellActivated);
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro;
            this.BackColor = Color.White;
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
            //change the column header text
            this.gridGroupingControl1.TableDescriptor.Columns["OrderID"].HeaderText = "Order ID";
            this.gridGroupingControl1.TableDescriptor.Columns["EmployeeID"].HeaderText = "Employee ID";
            this.gridGroupingControl1.TableDescriptor.Columns["CustomerID"].HeaderText = "Customer ID";
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
			this.gridGroupingControl1.TableControl.DpiAware = true;
            this.gridGroupingControl1.TableControl.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(25);
            this.gridGroupingControl1.TableOptions.SummaryRowHeight = (int)DpiAware.LogicalToDeviceUnits(25);
            this.gridGroupingControl1.TableOptions.CaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(25);


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
            GridTableDescriptor ordersDescriptor = this.gridGroupingControl1.TableDescriptor;
            // You can define a summary row and mark it hidden.
            // In that summary row you can add a column and set it's mapping name (and DisplayColumn) to be Freight

            GridSummaryColumnDescriptor summaryColumn1 = new GridSummaryColumnDescriptor("FreightAverage", SummaryType.DoubleAggregate, "Freight", "{Average:###.00}");
            GridSummaryRowDescriptor summaryRow1 = new GridSummaryRowDescriptor();
            summaryRow1.Name = "SummaryRow 1";
            summaryRow1.Visible = false;
            summaryRow1.SummaryColumns.Add(summaryColumn1);
            ordersDescriptor.SummaryRows.Add(summaryRow1);

            // This is a second row, not marked hidden and therefore shown at the end of the group.
            GridSummaryColumnDescriptor summaryColumn2 = new GridSummaryColumnDescriptor("FreightTotal", SummaryType.DoubleAggregate, "Freight", "{Sum:###.00}");
            GridSummaryRowDescriptor summaryRow2 = new GridSummaryRowDescriptor();
            summaryRow2.Name = "SummaryRow 2";
            summaryRow2.Title = "Total";
            summaryRow2.Visible = true;
            summaryRow2.SummaryColumns.Add(summaryColumn2);
            ordersDescriptor.SummaryRows.Add(summaryRow2);

            // Have Extra Section bar cover some cells.
            this.gridGroupingControl1.TableModel.QueryCoveredRange += new GridQueryCoveredRangeEventHandler(TableModel_QueryCoveredRange);

            // Provide contents to be displayed in cell
            this.gridGroupingControl1.QueryCellStyleInfo += new GridTableCellStyleInfoEventHandler(gridGroupingControl1_QueryCellStyleInfo);
            this.gridGroupingControl1.TableControlCellDrawn += new GridTableControlDrawCellEventHandler(gridGroupingControl1_TableControlCellDrawn);

            // Move Freight column a bit to the left 
            this.gridGroupingControl1.TableDescriptor.VisibleColumns.Move(this.gridGroupingControl1.TableDescriptor.VisibleColumns.IndexOf("Freight"), 4);


            this.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("EmployeeID");
            this.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("ShipCountry");
        }

        #region Events
        private void TableModel_QueryCoveredRange(object sender, GridQueryCoveredRangeEventArgs e)
        {
            GridTable thisTable = this.gridGroupingControl1.Table;
            if (e.RowIndex < thisTable.DisplayElements.Count)
            {
                Element el = thisTable.DisplayElements[e.RowIndex];

                if (el is ExtraSection)
                {
                    // Cover some cells of the extra section (specified with extraSectionCoverCols)
                    int startCol = el.GroupLevel + 1;  // Add +1 so we have place for column header
                    if (e.ColIndex >= startCol && e.ColIndex <= this.extraSectionCoverCols + el.ParentTableDescriptor.GroupedColumns.Count)
                    {
                        e.Range = GridRangeInfo.Cells(e.RowIndex, startCol, e.RowIndex, this.extraSectionCoverCols + el.ParentTableDescriptor.GroupedColumns.Count);
                        e.Handled = true;
                    }
                }
            }
        }

        private void gridGroupingControl1_QueryCellStyleInfo(object sender, GridTableCellStyleInfoEventArgs e)
        {
            GridGroupingControl groupingControl = (GridGroupingControl)sender;
            Element el = e.TableCellIdentity.DisplayElement;

            e.Style.CellTipText = el.GetType().Name + (el.ParentElement != null ? " (Parent: " + el.ParentElement.GetType().Name + ")" : "");

            if (el is ExtraSection)
            {
                if (e.Style.TableCellIdentity.ColIndex == 0)
                {
                    // Row Header
                    e.Style.CellType = ((GridTableDescriptor)el.ParentTableDescriptor).Appearance.RecordRowHeaderCell.CellType;

                    if (el == el.ParentTable.CurrentElement)
                        e.Style.Text = "#";
                }
                else if (e.Style.TableCellIdentity.ColIndex <= el.GroupLevel)
                {
                    // Group Indent 
                    e.Style.BackColor = Color.FromArgb(218, 229, 245);
                }
                else if (e.Style.TableCellIdentity.ColIndex <= extraSectionCoverCols + el.ParentTableDescriptor.GroupedColumns.Count)
                {
                    // Covered area (see TableModel_QueryCoveredRange above)
                    e.Style.BackColor = Color.FromArgb(192, 201, 219);
                    e.Style.CellValue = "ExtraSection (" + el.ParentGroup.Name + ")";
                }
                else if (e.Style.TableCellIdentity.ColIndex > 3)
                {
                    e.Style.BackColor = Color.FromArgb(252, 172, 38);
                    // you can get the column as follows:
                    GridTable table = (GridTable)el.ParentTable;
                    GridTableDescriptor td = e.TableCellIdentity.Table.TableDescriptor;
                    GridColumnDescriptor column = td.RecordRowColumns[0, e.Style.TableCellIdentity.ColIndex - el.ParentTableDescriptor.GroupedColumns.Count - 1];
                    e.Style.CellValue = column.Name;

                    // Using that column you could try and identify the summary that should be displayed in this cell.
                    if (column.MappingName == "Freight")
                    {
                        // Calling this method to demonstrate different alternatives to get to the summary text
                        e.Style.Text = GetSummaryText(el.ParentGroup, "SummaryRow 1", "FreightAverage");

                        // Easier is to simple call built-in routine:
                        e.Style.Text = GridEngine.GetSummaryText(el.ParentGroup, "SummaryRow 1", "FreightAverage");
                    }
                }
            }
        }


        private void gridGroupingControl1_TableControlCurrentCellActivated(object sender, GridTableControlEventArgs e)
        {
            // Navigate to ExtraSection when textbox inside ExtraSection has become CurrentCell.

            GridCurrentCell gcc = e.TableControl.CurrentCell;
            GridTableCellStyleInfo style = e.TableControl.Model[gcc.RowIndex, gcc.ColIndex];
            GridTableCellStyleInfoIdentity id = style.TableCellIdentity;

            if (id.DisplayElement is ExtraSection)
                id.Table.CurrentRecordManager.NavigateTo(id.DisplayElement);
        }

        private void gridGroupingControl1_TableControlCellDrawn(object sender, GridTableControlDrawCellEventArgs e)
        {
            GridTableCellStyleInfo style = e.TableControl.Model[e.Inner.RowIndex, e.Inner.ColIndex];
            GridTableCellStyleInfoIdentity id = style.TableCellIdentity;

            Element el = id.DisplayElement;

            if (el is ExtraSection)
            {
                if (id.ColIndex == 0)
                {
                    // Row Header and ExtraSection is CurrentElement
                    if (el == el.ParentTable.CurrentElement)
                    {
                        // Draw Record indicator 
                        try
                        {
                            Rectangle iconBounds = Rectangle.FromLTRB(e.Inner.Bounds.Right - 15, e.Inner.Bounds.Top, e.Inner.Bounds.Right, e.Inner.Bounds.Bottom);
                            iconBounds.Offset(-2, 0);
                            IconPainter.PaintIcon(e.Inner.Graphics, iconBounds, Point.Empty, "SFARROW.BMP", style.TextColor);
                        }
                        catch
                        { }
                    }
                }
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Demonstrates different alternatives to get to the summary text (strong typed vs GridSummaryColumnDescriptor.Format)
        /// </summary>
        public string GetSummaryText(Group group, string summaryRowName, string summaryColumnName)
        {
            GridTable table = (GridTable)group.ParentTable;
            GridTableDescriptor td = table.TableDescriptor;
            GridSummaryRowDescriptor srd = td.SummaryRows[summaryRowName];
            GridSummaryColumnDescriptor scd = srd.SummaryColumns[summaryColumnName];

            return GetSummaryText(group, scd);
        }

        /// <summary>
        /// Demonstrates different alternatives to get to the summary text (strong typed vs GridSummaryColumnDescriptor.Format)
        /// </summary>
        string GetSummaryText(Group group, GridSummaryColumnDescriptor scd)
        {
            GridTable table = (GridTable)group.ParentTable;
            GridTableDescriptor td = table.TableDescriptor;

            string summaryText = "";

            bool use31Code = true;
            if (use31Code)
            {
                if (scd != null)
                {
                    // Option 1: GetDisplayText - this is actually the code used when you simply would call 
                    // e.Style.Text = ((GridTable) table).GetSummaryText(group, "SummaryRow 1", "FreightAverage");
                    //
                    // Text is formatted as defined in GridSummaryColumnDescriptor.Format 
                    summaryText = scd.GetDisplayText(group);

                    // or Option 2: Strong typed access to DoubleAggregateSummary.
                    DoubleAggregateSummary summary1 = (DoubleAggregateSummary)group.GetSummary(scd.SummaryDescriptor);
                    summaryText = string.Format("{0:c}", summary1.Average);

                    // or Option 3: Use reflection to get "Average" property of summary
                    summaryText = string.Format("{0:c}", group.GetSummaryProperty(scd.SummaryDescriptor, "Average"));
                }

            }
            else
            {
                // This is the code you had to use in version 3.0 and earlier (still working but bit more complicate)
                if (scd != null)
                {
                    SummaryDescriptor sd1 = scd.SummaryDescriptor;
                    if (sd1 != null)
                    {
                        int indexOfSd1 = table.TableDescriptor.Summaries.IndexOf(sd1);

                        ISummary sum1 = group.GetSummaries(table)[indexOfSd1];
                        string text1 = scd.GetDisplayText(sum1);
                        summaryText = text1;

                        // - or - (access value directly)
                        // strong typed - you have to cast to Int32AggregateSummary.

                        DoubleAggregateSummary summary1 = (DoubleAggregateSummary)group.GetSummaries(table)[indexOfSd1];
                        summaryText = string.Format("{0:c}", summary1.Average);
                    }
                }
            }

            return summaryText;
        }

        /// <summary>
        /// This code works with base engine, no dependency on GridEngine / GridSummaryColumnDescriptor etc.
        /// </summary>
        string GetAverageSummary(SummaryDescriptor summaryDescriptor, Group group)
        {
            Table table = group.ParentTable;
            TableDescriptor td = table.TableDescriptor;
            string summaryText = "";

            bool use31Code = true;
            if (use31Code)
            {
                // Option 1: Strong typed access to DoubleAggregateSummary.
                DoubleAggregateSummary summary1 = (DoubleAggregateSummary)group.GetSummary(summaryDescriptor);
                summaryText = string.Format("{0:c}", summary1.Average);

                // or Option 2: Use reflection to get "Average" property of summary
                summaryText = string.Format("{0:c}", group.GetSummaryProperty(summaryDescriptor, "Average"));
            }

            else
            {
                // This is the code you had to use in version 3.0 and earlier (still working but bit more complicate)
                if (summaryDescriptor != null)
                {
                    int indexOfSd1 = table.TableDescriptor.Summaries.IndexOf(summaryDescriptor);

                    // strong typed - you have to cast to DoubleAggregateSummary.

                    DoubleAggregateSummary summary1 = (DoubleAggregateSummary)group.GetSummaries(table)[indexOfSd1];
                    summaryText = string.Format("{0:c}", summary1.Average);
                }
            }
            return summaryText;
        }

        #endregion

        #endregion

        #region Initialize DataSource

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
        #endregion

        #region Designer Stuff
        #region Icon File
        private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
        }
        #endregion

        #region ReadXml
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
        #endregion

        [ThreadStaticAttribute]
        static IconPaint iconPainter;

        internal static IconPaint IconPainter
        {
            get
            {
                string ns = "CustomSectionInGroup";  // Must be same as your project settings Root Namespace
                if (iconPainter == null)
                    iconPainter = new IconPaint(ns + ".", typeof(Form1).Assembly);
                return iconPainter;
            }
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.northwindDataSet1 = new CustomSectionInGroup.DataSet1();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection2 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapterOrders = new System.Data.SqlClient.SqlDataAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // northwindDataSet1
            // 
            this.northwindDataSet1.DataSetName = "DataSet1";
            this.northwindDataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.northwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.sqlConnection2;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"),
            new System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID"),
            new System.Data.SqlClient.SqlParameter("@OrderDate", System.Data.SqlDbType.DateTime, 8, "OrderDate"),
            new System.Data.SqlClient.SqlParameter("@RequiredDate", System.Data.SqlDbType.DateTime, 8, "RequiredDate"),
            new System.Data.SqlClient.SqlParameter("@ShippedDate", System.Data.SqlDbType.DateTime, 8, "ShippedDate"),
            new System.Data.SqlClient.SqlParameter("@ShipVia", System.Data.SqlDbType.Int, 4, "ShipVia"),
            new System.Data.SqlClient.SqlParameter("@Freight", System.Data.SqlDbType.Money, 8, "Freight"),
            new System.Data.SqlClient.SqlParameter("@ShipName", System.Data.SqlDbType.NVarChar, 40, "ShipName"),
            new System.Data.SqlClient.SqlParameter("@ShipAddress", System.Data.SqlDbType.NVarChar, 60, "ShipAddress"),
            new System.Data.SqlClient.SqlParameter("@ShipCity", System.Data.SqlDbType.NVarChar, 15, "ShipCity"),
            new System.Data.SqlClient.SqlParameter("@ShipRegion", System.Data.SqlDbType.NVarChar, 15, "ShipRegion"),
            new System.Data.SqlClient.SqlParameter("@ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, "ShipPostalCode"),
            new System.Data.SqlClient.SqlParameter("@ShipCountry", System.Data.SqlDbType.NVarChar, 15, "ShipCountry")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlConnection2;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"),
            new System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID"),
            new System.Data.SqlClient.SqlParameter("@OrderDate", System.Data.SqlDbType.DateTime, 8, "OrderDate"),
            new System.Data.SqlClient.SqlParameter("@RequiredDate", System.Data.SqlDbType.DateTime, 8, "RequiredDate"),
            new System.Data.SqlClient.SqlParameter("@ShippedDate", System.Data.SqlDbType.DateTime, 8, "ShippedDate"),
            new System.Data.SqlClient.SqlParameter("@ShipVia", System.Data.SqlDbType.Int, 4, "ShipVia"),
            new System.Data.SqlClient.SqlParameter("@Freight", System.Data.SqlDbType.Money, 8, "Freight"),
            new System.Data.SqlClient.SqlParameter("@ShipName", System.Data.SqlDbType.NVarChar, 40, "ShipName"),
            new System.Data.SqlClient.SqlParameter("@ShipAddress", System.Data.SqlDbType.NVarChar, 60, "ShipAddress"),
            new System.Data.SqlClient.SqlParameter("@ShipCity", System.Data.SqlDbType.NVarChar, 15, "ShipCity"),
            new System.Data.SqlClient.SqlParameter("@ShipRegion", System.Data.SqlDbType.NVarChar, 15, "ShipRegion"),
            new System.Data.SqlClient.SqlParameter("@ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, "ShipPostalCode"),
            new System.Data.SqlClient.SqlParameter("@ShipCountry", System.Data.SqlDbType.NVarChar, 15, "ShipCountry"),
            new System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OrderID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Freight", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Freight", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_OrderDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OrderDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_RequiredDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RequiredDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipAddress", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipCity", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipCity", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipCountry", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipCountry", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipPostalCode", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipRegion", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipRegion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipVia", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipVia", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShippedDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShippedDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@OrderID", System.Data.SqlDbType.Int, 4, "OrderID")});
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText");
            this.sqlDeleteCommand2.Connection = this.sqlConnection2;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OrderID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Freight", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Freight", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_OrderDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OrderDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_RequiredDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RequiredDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipAddress", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipCity", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipCity", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipCountry", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipCountry", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipPostalCode", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipRegion", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipRegion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipVia", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipVia", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShippedDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShippedDate", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapterOrders
            // 
            this.sqlDataAdapterOrders.DeleteCommand = this.sqlDeleteCommand2;
            this.sqlDataAdapterOrders.InsertCommand = this.sqlInsertCommand2;
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
            this.sqlDataAdapterOrders.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridGroupingControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 656);
            this.panel1.TabIndex = 0;
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.Appearance.AnySummaryCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(162))))));
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.DataSource = this.northwindDataSet1.Orders;
            this.gridGroupingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.Location = new System.Drawing.Point(0, 0);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.ShowGroupDropArea = true;
            this.gridGroupingControl1.Size = new System.Drawing.Size(1012, 656);
            this.gridGroupingControl1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1012, 656);
            this.MinimumSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Group Customization";
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
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
# if SyncfusionFramework1_1 || SyncfusionFramework2_0
            Application.EnableVisualStyles();
# endif
            Application.Run(new Form1());
        }
        #endregion

    }
}