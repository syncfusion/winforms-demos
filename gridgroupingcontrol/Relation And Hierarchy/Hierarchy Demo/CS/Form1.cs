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

using Syncfusion.Grouping;

using Syncfusion.Collections;
using Syncfusion.Drawing;
using Syncfusion.ComponentModel;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using DemoCommon.Grid;

namespace HierarchySample
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : GridDemoForm
	{
        #region "API definition"

        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl groupingGrid1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private HierarchySample.DataSet1 dataSet21;
        private Syncfusion.Windows.Forms.ButtonAdv expandAllButton;
        private Syncfusion.Windows.Forms.ButtonAdv CollapseAllbutton;
        private PropertyGrid propertyGrid1;
        private IContainer components;

        #endregion

        #region "Constructor"

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
            this.SampleCustomization();
            this.GridSettings();

		}

        #endregion

        #region "SampleCustomization"

       /// <summary>
       /// Setting Maual relation to the GridGroupingControl.
       /// </summary>

        private void SampleCustomization()
        {
            #region DataTable

            DataSet ds = new DataSet();
            ReadXml(ds, @"Expand.xml");

            ds.Tables[1].TableName = "Products";
            ds.Tables[2].TableName = "OrderDetails";
            ds.Tables[3].TableName = "Suppliers";

            ds.Relations.Add(
                ds.Tables[0].Columns["CategoryID"],
                ds.Tables[1].Columns["CategoryID"]);
            ds.Relations[0].RelationName = "Category_Products";

            ds.Relations.Add(
                ds.Tables[1].Columns["ProductID"],
                ds.Tables[2].Columns["ProductID"]);
            ds.Relations[1].RelationName = "Products_OrderDetails";

            #endregion

            this.groupingGrid1.DataSource = ds.Tables[0];

            GridEngine engine = this.groupingGrid1.Engine;

            engine.TopLevelGroupOptions.ShowCaption = true;

            // Record summary for Categories Tables

            GridTableDescriptor categoriesTableDescriptor = (GridTableDescriptor)engine.TableDescriptor;

            categoriesTableDescriptor.Columns.Clear();
            categoriesTableDescriptor.Columns.Add("CategoryID");
            categoriesTableDescriptor.Columns.Add("CategoryName");
            categoriesTableDescriptor.Columns.Add("Description");

            categoriesTableDescriptor.Columns["CategoryName"].Width = 200;
            //Creating a new SummaryColumnDescriptor.
            GridSummaryColumnDescriptor countCat = new GridSummaryColumnDescriptor("RecordCount");
            //Setting it's properties.
            countCat.SummaryType = SummaryType.Count;
            countCat.Style = GridSummaryStyle.FillRow;
            //Initializing it to the Column it is associated with.
            countCat.DataMember = "CategoryID";
            //Mentioning the format of display.
            countCat.Format = "      {Count} Records.";

            //Adding the SummaryColumnDescriptor to the SummaryRowDescriptor.
            GridSummaryRowDescriptor categoriesSummaryRow = new GridSummaryRowDescriptor("RecordCountRow");
            categoriesSummaryRow.SummaryColumns.Add(countCat);
            //Adding the SummaryRowDescriptor to the  TableDesriptor.
            categoriesTableDescriptor.SummaryRows.Add(categoriesSummaryRow);

            // Group Products table by "SupplierID"
            RelationDescriptor productsRelationDescriptor = categoriesTableDescriptor.Relations["Products"];
            GridTableDescriptor productsTableDescriptor = (GridTableDescriptor)productsRelationDescriptor.ChildTableDescriptor;
            productsTableDescriptor.GroupedColumns.Add("SupplierID");

            // Group OrderDetails table by "Discount"
            // Add Total = "[UnitPrice]*[Quantity]" expression field
            // Add Summaries for Total and Average for UnitPrice.

            RelationDescriptor orderDetailsRelationDescriptor = productsTableDescriptor.Relations["OrderDetails"];
            GridTableDescriptor orderDetailsTableDescriptor = (GridTableDescriptor)orderDetailsRelationDescriptor.ChildTableDescriptor;

            ExpressionFieldDescriptor ed = new ExpressionFieldDescriptor("Total", "[UnitPrice]*[Quantity]");
            ed.DefaultValue = "";
            orderDetailsTableDescriptor.ExpressionFields.Add(ed);
            orderDetailsTableDescriptor.GroupedColumns.Add("Discount");
            //Adding the SummaryColumnDescriptor to the SummaryRowDescriptor.
            GridSummaryRowDescriptor orderDetailsSummaryRow = new GridSummaryRowDescriptor("Total");
            orderDetailsTableDescriptor.SummaryRows.Add(orderDetailsSummaryRow);
            //Creating a new SummaryColumnDescriptor.
            GridSummaryColumnDescriptor totalSum = new GridSummaryColumnDescriptor("Total");
            //Setting it's properties.
            totalSum.SummaryType = SummaryType.DoubleAggregate;
            totalSum.Style = GridSummaryStyle.Column;
            //Initializing it to the Column it is associated with.
            totalSum.DataMember = "Total";
            totalSum.DisplayColumn = "Total";
            totalSum.Format = "Sum={Sum}";
            orderDetailsSummaryRow.SummaryColumns.Add(totalSum);


            orderDetailsTableDescriptor.Columns["Total"].Width = 70;

            //Creating a new SummaryColumnDescriptor.
            GridSummaryColumnDescriptor avgUnitPrice = new GridSummaryColumnDescriptor("AvgUnitPrice");
            //Setting it's properties.
            avgUnitPrice.SummaryType = SummaryType.DoubleAggregate;
            avgUnitPrice.Style = GridSummaryStyle.Column;
            avgUnitPrice.DataMember = "UnitPrice";
            avgUnitPrice.DisplayColumn = "UnitPrice";
            avgUnitPrice.Format = "Avg={Average:#.0}";
            orderDetailsSummaryRow.SummaryColumns.Add(avgUnitPrice);

            // expand a specific record, search for groups etc.
            Table categoriesTable = engine.Table;//.RelatedTables["Categories"];
            Console.WriteLine(categoriesTable.ToString());

            Table productsTable = categoriesTable.RelatedTables["Products"];
            Console.WriteLine(productsTable.ToString());

            // Get the child table in the products table that is assocuated with category "1"
            ChildTable product1 = (ChildTable)productsTable.TopLevelGroup.Groups["1"];
            Console.WriteLine(product1.ToString());
            Console.WriteLine(product1.Groups[0].ToString());

            // Get the child table in the products table that is assocuated with category "1"
            ChildTable product21 = (ChildTable)productsTable.TopLevelGroup.Groups["8"];
            Console.WriteLine(product21.ToString());
            Console.WriteLine(product21.Groups[0].Records[0].ToString());

            // Show me the associated "NestedTable" element of the categories table (the NestedTable 
            // element established the link between parent table and a nested child table)
            Console.WriteLine(product21.Groups[0].Records[0].ParentChildTable.ParentNestedTable);

            // Expand the product for category 8
            product21.IsExpanded = true;
            product21.ParentNestedTable.IsExpanded = true;
            product21.ParentNestedTable.ParentRecord.IsExpanded = true;

            // When you assign a "DataSet" as a datasource, the DataSet is a list with one record (not allowing AddNew) with nested tables.
            // Expand the first record so that tables are shown.
            engine.Table.TopLevelGroup.Records[0].IsExpanded = true;

            // Sort  product table by ProductName 
            product21.ParentTable.TableDescriptor.SortedColumns.Add("ProductName");

            // Find group for supplier id 21
            Group supplier21Group = product21.Groups["21"];

            // Find productname Spegesild in that group
            int index = supplier21Group.Records.FindRecord("Spegesild");

            // Print out the row index and record index
            Record r = supplier21Group.Records[index];
            Console.WriteLine("Found: " + r.ToString());
            Console.WriteLine("RowIndex " + engine.Table.NestedDisplayElements.IndexOf(r).ToString());
            Console.WriteLine("Record Index " + engine.Table.Records.IndexOf(r).ToString());

            // Dump out nested display elements to console



            this.groupingGrid1.Table.Records[0].IsExpanded = true;
            this.groupingGrid1.Table.TopLevelGroup.IsExpanded = true;


            engine.ChildGroupOptions.ShowCaption = true;
            engine.NestedTableGroupOptions.ShowCaption = true;



            // Adding GroupDropAreas for nested tables.
            groupingGrid1.AddGroupDropArea((GridTable)productsTable);
            groupingGrid1.AddGroupDropArea((GridTable)productsTable.RelatedTables[0]);
            groupingGrid1.ShowGroupDropArea = true;
			
			//Navigate to other control using tabkey navigation
            groupingGrid1.WantTabKey = false;

            // Make Spegesild current record
            if (r != null)
            {
                r.SetCurrent();

                // Expand record and nested tables
                r.IsExpanded = true;
                r.NestedTables[0].IsExpanded = true;

                Record orderDetailsRecords = r.NestedTables[0].ChildTable.GetFirstRecord();
                // Expand Group record belongs to
                orderDetailsRecords.ParentGroup.IsExpanded = true;

                // Scroll this record in view.
                groupingGrid1.TableControl.ScrollInView(orderDetailsRecords);
                groupingGrid1.TableControl.LeftColIndex = 1;
            }

        }

        #region "Events"

        private void menuItemExitApp_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void menuItemDsChoose_Click(object sender, System.EventArgs e)
        {
            _ShowGridColumnsDialog(this.groupingGrid1.Engine.TableDescriptor, "Columns", null, typeof(GridColumnDescriptorCollection));
        }

        internal DialogResult _ShowGridColumnsDialog(object instance, string propertyName, IServiceProvider provider, Type type)
        {
            GroupingCollectionEditor ce = new GroupingCollectionEditor(type);
            Syncfusion.ComponentModel.WindowsFormsEditorServiceContainer esc = new Syncfusion.ComponentModel.WindowsFormsEditorServiceContainer(provider);
            PropertyDescriptor pd = TypeDescriptor.GetProperties(instance)[propertyName];
            Syncfusion.ComponentModel.TypeDescriptorContext tdc = new Syncfusion.ComponentModel.TypeDescriptorContext(instance, pd);
            tdc.ServiceProvider = esc;

            ce.EditValue(tdc, esc, pd.GetValue(instance));

            Control control = instance as Control;
            if (control != null)
                control.Invalidate();
            this.groupingGrid1.Refresh();

            return esc.DialogResult;
        }


        private void menuItemXPThemes_Click(object sender, System.EventArgs e)
        {
            GridStyleInfo standard = this.groupingGrid1.Engine.Appearance.AnyCell;
            standard.Themed = !standard.Themed;
            this.groupingGrid1.ThemesEnabled = standard.Themed;
            this.groupingGrid1.Refresh();
        }

        private void expandAllButton_Click(object sender, System.EventArgs e)
        {
            // Set focus back to grid
            this.ActiveControl = groupingGrid1;

            // Scroll to top
            groupingGrid1.TableControl.VScrollBar.Value = groupingGrid1.TableControl.VScrollBar.Minimum;

            // Determine current element. If it is a nested table, get the current element of the child table.
            Element el = this.groupingGrid1.Table.CurrentElement;
            while (el is NestedTable)
                el = ((NestedTable)el).ChildTable.ParentTable.CurrentElement;

            // Expand all records
            this.groupingGrid1.Table.ExpandAllRecords();

            // Scroll current record into view.
            if (el != null)
            {
                // Restore Current Field 
                el.ParentTable.CurrentRecordManager.NavigateTo(el);

                // Scroll element into view
                groupingGrid1.TableControl.ScrollInView(el);
            }

            // Synchronize grid display with engine changes.
            this.groupingGrid1.Update();

            Console.WriteLine(this.groupingGrid1.Table.GetCounter());
        }

        private void CollapseAllbutton_Click(object sender, System.EventArgs e)
        {
            // Set focus back to grid
            this.ActiveControl = groupingGrid1;

            // Scroll to top
            groupingGrid1.TableControl.VScrollBar.Value = groupingGrid1.TableControl.VScrollBar.Minimum;

            // Determine current element. If it is a nested table, get the parent record.
            Element el = this.groupingGrid1.Table.CurrentElement;
            while (el is NestedTable)
                el = el.ParentRecord;

            // Collapse all records.
            this.groupingGrid1.Table.CollapseAllRecords();
            this.groupingGrid1.Table.CollapseAllGroups();

            // Scroll current record into view.
            if (el != null)
            {
                // Restore Current Field 
                el.ParentTable.CurrentRecordManager.NavigateTo(el);

                // Scroll element into view
                groupingGrid1.TableControl.ScrollInView(el);
            }

            // Synchronize grid display with engine changes.
            this.groupingGrid1.Update();
        }

        private void menuItem1_Click(object sender, System.EventArgs e)
        {
            DemoCommon.AboutForm abtForm = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
            abtForm.ShowDialog();
        }
        #endregion

        #endregion

        #region "Sample Grid Settings"

        /// <summary>
        /// GridGrouping control getting started customization.
        /// </summary>
        private void GridSettings()
        {
           this.groupingGrid1.TableControl.DpiAware = true;
		   // used for disable the showaddnewrecord and show caption.
            this.groupingGrid1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.groupingGrid1.TopLevelGroupOptions.ShowCaption = false;
            //used for setting GridVisualStyle and ScrollBar style.
            this.groupingGrid1.GridVisualStyles = GridVisualStyles.Metro;
            this.groupingGrid1.GridOfficeScrollBars = OfficeScrollBars.Metro;
            this.MetroColor = System.Drawing.Color.Transparent;

            //Used for enableing navigationbar and filter run time properties.
            this.groupingGrid1.ShowNavigationBar = true;
            this.groupingGrid1.TableControl.HorizontalScrollTips = false;
            this.groupingGrid1.BorderStyle = BorderStyle.FixedSingle;
            this.groupingGrid1.FilterRuntimeProperties = true;
            this.propertyGrid1.SelectedObject = this.groupingGrid1;

            //used to set multiextended selection mode in gridgrouping control. 
            this.groupingGrid1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;

            //used to set GridCaptionRowHeight.
            this.groupingGrid1.Table.DefaultCaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(25);
            this.groupingGrid1.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30);
            this.groupingGrid1.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22);
            this.groupingGrid1.AllowProportionalColumnSizing = true;

            this.groupingGrid1.TableDescriptor.Columns["CategoryID"].HeaderText = "Category ID";
            this.groupingGrid1.TableDescriptor.Columns["CategoryName"].HeaderText = "Category Name";
            
            foreach (GridTableDescriptor td in this.groupingGrid1.Engine.EnumerateTableDescriptor())
            {
                if (td.Name == "Products")
                {
                    td.Columns["ProductID"].HeaderText = "Product ID";
                    td.Columns["ProductName"].HeaderText = "Product Name";
                    td.Columns["SupplierID"].HeaderText = "Supplier ID";
                    td.Columns["QuantityPerUnit"].HeaderText = "Quantity Per Unit";
                    td.Columns["UnitPrice"].HeaderText = "Unit Price";
                    td.Columns["UnitsInStock"].HeaderText = "Units InStock";
                    td.Columns["UnitsOnOrder"].HeaderText = "Units OnOrder";
                    td.Columns["ReorderLevel"].HeaderText = "Reorder Level";
                }
            }

            foreach (GridTableDescriptor td in this.groupingGrid1.Engine.EnumerateTableDescriptor())
            {
                if (td.Name == "OrderDetails")
                {
                    td.Columns["OrderID"].HeaderText = "Order ID";
                    td.Columns["UnitPrice"].HeaderText = "Unit Price";
                }
            }

            this.groupingGrid1.GetTable("Products").DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22);
            this.groupingGrid1.GetTable("OrderDetails").DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22);
            this.groupingGrid1.GetTable("Products").DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30);
            this.groupingGrid1.GetTable("OrderDetails").DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30);
        }

        #endregion

        #region "Designer Stuffs"


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

        #region "Reading xml file"

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

        #region "Dispose"
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
        #endregion

        #region "Windows Form Designer generated code"
        /// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.groupingGrid1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.dataSet21 = new HierarchySample.DataSet1();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.expandAllButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.CollapseAllbutton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.groupingGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).BeginInit();
            this.SuspendLayout();
            // 
            // groupingGrid1
            // 
            this.groupingGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupingGrid1.BackColor = System.Drawing.SystemColors.Window;
            this.groupingGrid1.FreezeCaption = false;
            this.groupingGrid1.Location = new System.Drawing.Point(0, 0);
            this.groupingGrid1.Name = "groupingGrid1";
            this.groupingGrid1.Size = new System.Drawing.Size(730, 597);
            this.groupingGrid1.TabIndex = 1;
            this.groupingGrid1.Text = "groupingGrid1";
            // 
            // dataSet21
            // 
            this.dataSet21.DataSetName = "DataSet1";
            this.dataSet21.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice" +
                ", UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Network Address=66.135.59.108,49489;initial catalog=NORTHWIND;password=Sync_sampl" +
                "es;persist security info=True;user id=sa;packet size=4096;Pooling=true";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Products", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ProductID", "ProductID"),
                        new System.Data.Common.DataColumnMapping("ProductName", "ProductName"),
                        new System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"),
                        new System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"),
                        new System.Data.Common.DataColumnMapping("QuantityPerUnit", "QuantityPerUnit"),
                        new System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"),
                        new System.Data.Common.DataColumnMapping("UnitsInStock", "UnitsInStock"),
                        new System.Data.Common.DataColumnMapping("UnitsOnOrder", "UnitsOnOrder"),
                        new System.Data.Common.DataColumnMapping("ReorderLevel", "ReorderLevel"),
                        new System.Data.Common.DataColumnMapping("Discontinued", "Discontinued")})});
            // 
            // expandAllButton
            // 
            this.expandAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.expandAllButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.expandAllButton.FlatStyle = FlatStyle.Flat;
            this.expandAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.expandAllButton.BeforeTouchSize = new System.Drawing.Size(121, 24);
            this.expandAllButton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.expandAllButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandAllButton.ForeColor = System.Drawing.Color.White;
            this.expandAllButton.IsBackStageButton = false;
            this.expandAllButton.Location = new System.Drawing.Point(745, 612);
            this.expandAllButton.Name = "expandAllButton";
            this.expandAllButton.Size = new System.Drawing.Size(121, 24);
            this.expandAllButton.TabIndex = 2;
            this.expandAllButton.Text = "Expand All";
            this.expandAllButton.Click += new System.EventHandler(this.expandAllButton_Click);
            // 
            // CollapseAllbutton
            // 
            this.CollapseAllbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CollapseAllbutton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.CollapseAllbutton.FlatStyle = FlatStyle.Flat;
            this.CollapseAllbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.CollapseAllbutton.BeforeTouchSize = new System.Drawing.Size(120, 24);
            this.CollapseAllbutton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.CollapseAllbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollapseAllbutton.ForeColor = System.Drawing.Color.White;
            this.CollapseAllbutton.IsBackStageButton = false;
            this.CollapseAllbutton.Location = new System.Drawing.Point(880, 612);
            this.CollapseAllbutton.Name = "CollapseAllbutton";
            this.CollapseAllbutton.Size = new System.Drawing.Size(120, 24);
            this.CollapseAllbutton.TabIndex = 2;
            this.CollapseAllbutton.Text = "Collapse All";
            this.CollapseAllbutton.Click += new System.EventHandler(this.CollapseAllbutton_Click);
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
            this.propertyGrid1.Location = new System.Drawing.Point(745, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(255, 597);
            this.propertyGrid1.TabIndex = 13;
            // 
            // Form1
            // 
			this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1012, 653);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.expandAllButton);
            this.Controls.Add(this.groupingGrid1);
            this.Controls.Add(this.CollapseAllbutton);
			this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Hierarchy ";
            ((System.ComponentModel.ISupportInitialize)(this.groupingGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        #endregion

    }
}