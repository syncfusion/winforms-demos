//#define TESTSPEED
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
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using Syncfusion.Diagnostics;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;

using Syncfusion.Grouping.ManualSummaries;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;
using System.Text.RegularExpressions;

namespace ManualTotalSummaries
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : GridDemoForm
    {
        #region API Definition
        private SampleGridGroupingControl gridGroupingControl1;
        private ManualTotalSummaries.DataSet1 northwindDataSet1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapterOrders;
        private System.Data.SqlClient.SqlConnection sqlConnection2;
        private Panel panel1;        
        private Panel panel2;
        private PropertyGrid propertyGrid1;
        private ButtonAdv startTimerButton;
        private IContainer components;
        string xmlName = "Orders.xml";
        bool msdeAvailable = false;
        #endregion

        #region Constructor
        static Form1()
        {
            GridEngineFactory.Factory = new ManualTotalSummaryEngineFactory();
        }

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
            this.gridGroupingControl1 = new ManualTotalSummaries.SampleGridGroupingControl();
            GridOptimizationSettings();

            ////////////////////////////////////////////////////////////
            // DataSource
            ////////////////////////////////////////////////////////////
            
            InitializeDataSet();

            this.gridGroupingControl1.DataSource = this.northwindDataSet1.Orders;

            ////////////////////////////////////////////////////////////

            GridSettings();
            
            // Be notified about changes to SortedColumns collection.
            this.gridGroupingControl1.PropertyChanged += new DescriptorPropertyChangedEventHandler(gridGroupingControl1_PropertyChanged);
        }
        #endregion       

        #region Grid Settings
        /// <summary>
        /// Grid settings for better Look and Feel
        /// </summary>
        private void GridSettings()
        {
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
			this.gridGroupingControl1.TableControl.DpiAware = true;

            GridTableDescriptor ordersDescriptor = this.gridGroupingControl1.TableDescriptor;
            this.gridGroupingControl1.TableDescriptor.PrimaryKeyColumns.Clear();

            ////////////////////////////////////////////////////////////
            // Add Unbound field 'ShipVia_CompanyName'
            ////////////////////////////////////////////////////////////

            ordersDescriptor.UnboundFields.Add("ShipVia_CompanyName");

            // Inform the engine about depency on ShipVia of this field.
            ordersDescriptor.UnboundFields["ShipVia_CompanyName"].ReferencedFields = "ShipVia";
            // When ReferencedFields is set and the engine detects changes to the ShipVia field
            // it will then automatically also mark the ShipVia_CompanyName field as changed. This
            // subsequently can affect sort order, group attachment etc.

            // Callback for calculation of ShipVia_CompanyName field.
            ordersDescriptor.QueryValue += new FieldValueEventHandler(ordersDescriptor_QueryValue);

            // Hide the field.
            ordersDescriptor.VisibleColumns.Remove("ShipVia_CompanyName");

            // But use it for grouping.
            ordersDescriptor.GroupedColumns.Add("ShipVia_CompanyName");

            ////////////////////////////////////////////////////////////
            // Visible Columns
            ////////////////////////////////////////////////////////////

            // Rearrange visible columns so that "Freight" remains in view.
            ordersDescriptor.VisibleColumns.LoadDefault();
            ordersDescriptor.VisibleColumns.Remove("Freight");
            ordersDescriptor.VisibleColumns.Insert(3, new GridVisibleColumnDescriptor("Freight"));

            // Change format of freight
            ordersDescriptor.Columns["Freight"].Appearance.AnyRecordFieldCell.Format = "F2";
            ordersDescriptor.Columns["Freight"].MaxLength = 15;

            ordersDescriptor.Columns["CustomerID"].MaxLength = 22;

            ////////////////////////////////////////////////////////////
            // Blinking - highlight cells when value increased or 
            // decreased for a short time
            ////////////////////////////////////////////////////////////

            this.gridGroupingControl1.BlinkTime = 0; // optional blinking here (in milliseconde)
            ordersDescriptor.Columns["Freight"].AllowBlink = true;
            ordersDescriptor.Columns["EmployeeID"].AllowBlink = true;

            ////////////////////////////////////////////////////////////
            // Customized caption row
            ////////////////////////////////////////////////////////////

            // Here you define the summary row that should be used for displaying summaries in caption bar.
            ordersDescriptor.ChildGroupOptions.ShowCaptionSummaryCells = true;
            ordersDescriptor.ChildGroupOptions.ShowSummaries = true;
            ordersDescriptor.ChildGroupOptions.CaptionSummaryRow = "Caption";

            // Let's you hide/show the second row in child groups.
            ordersDescriptor.ChildGroupOptions.ShowSummaries = true;

            this.gridGroupingControl1.TableDescriptor.Columns["EmployeeID"].HeaderText = "Employee ID";
            this.gridGroupingControl1.TableDescriptor.Columns["CustomerID"].HeaderText = "Customer ID";
            this.gridGroupingControl1.TableDescriptor.Columns["OrderID"].HeaderText = "Order ID";
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyHeaderCell.Font.Bold = true;

            ordersDescriptor.TopLevelGroupOptions.ShowCaptionSummaryCells = false;
            ordersDescriptor.ChildGroupOptions.ShowAddNewRecordBeforeDetails = false;

            // Minor customization: Have Caption bar cover some cells.
            this.gridGroupingControl1.TableModel.QueryCoveredRange += new GridQueryCoveredRangeEventHandler(TableModel_QueryCoveredRange);
            captionCoverCols = 2;

            // Make the caption look like a regular cell
            ordersDescriptor.Appearance.GroupCaptionCell.BackColor = this.gridGroupingControl1.Appearance.RecordFieldCell.BackColor;
            ordersDescriptor.Appearance.GroupCaptionCell.Borders.Top = new GridBorder(GridBorderStyle.Standard);
            ordersDescriptor.Appearance.GroupCaptionCell.CellType = "Static";
            ordersDescriptor.TableOptions.CaptionRowHeight = this.gridGroupingControl1.TableOptions.RecordRowHeight;

            /////////////////////////////////////////////////////////////////////////
            // ManualTotalSummary example code
            /////////////////////////////////////////////////////////////////////////

            // Totals with delta support for ListChanged events - replacement for built-in summaries of grouping engine.
            this.gridGroupingControl1.QueryCellStyleInfo += new GridTableCellStyleInfoEventHandler(gridGroupingControl1_QueryCellStyleInfo);

            ManualTotalSummaryTable tb = (ManualTotalSummaryTable)this.gridGroupingControl1.Table;
            tb.TotalSummaries.Add("Freight");
            tb.TotalSummaries.Add("EmployeeID");
            tb.TableDirty = true; // needed after changing TotalSummaries ...


            // Checking the results of initial total calculations for "Freight"

            int cc = tb.Records.Count; // force initializion
            int freightTotalIndex = tb.TableDescriptor.Fields.IndexOf("Freight");
            IManualTotalSummaryArraySource tsa = this.gridGroupingControl1.Table.TopLevelGroup as IManualTotalSummaryArraySource;
            ManualTotalSummary tm = tsa.GetManualTotalSummaryArray()[freightTotalIndex];
            Console.WriteLine("FreightTotal = " + tm.Total.ToString());

            foreach (Syncfusion.Grouping.Group g in this.gridGroupingControl1.Table.TopLevelGroup.Groups)
            {
                tsa = g as IManualTotalSummaryArraySource;
                tm = tsa.GetManualTotalSummaryArray()[freightTotalIndex];
                Console.WriteLine(g.ToString() + " FreightTotal = " + tm.Total.ToString());
            }
            this.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue;
            this.gridGroupingControl1.TableOptions.GridLineBorder = new Syncfusion.Windows.Forms.Grid.GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin);
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Segoe UI";
            this.gridGroupingControl1.TableDescriptor.Columns["OrderDate"].HeaderText = "Order Date";
            this.BackColor = Color.White;

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;

            foreach (GridColumnDescriptor col in this.gridGroupingControl1.TableDescriptor.Columns)
            {
                Regex rex = new Regex(@"\p{Lu}");
                int index = rex.Match(col.MappingName.Substring(1)).Index;
                string name = "";
                while (index > 0)
                {
                    name += col.MappingName.Substring(0, index + 1) + " ";
                    string secondName = col.MappingName.Substring(index + 1);
                    index = rex.Match(secondName.Substring(1)).Index;
                    while (index > 0)
                    {
                        name += secondName.Substring(0, index + 1) + " ";
                        index = rex.Match(col.MappingName.Substring(name.Replace(" ", "").Length).Substring(1)).Index;
                    }
                }
                name += col.MappingName.Substring(name.Replace(" ", "").Length);
                col.HeaderText = name;
            }
        }
        #endregion

        #region Grid Optimization
        /// <summary>
        /// Grid Optimization Settings for better performance
        /// </summary>
        private void GridOptimizationSettings()
        {
            // ----------- Plug in Optimization here -----------------
            // Use this code after the InitializeComponent call in your Form ctor
            // to plugin new optimized ListChanged event handler code

            this.gridGroupingControl1.UpdateDisplayFrequency = 0; // 0 if manual updates only from timer_tick

            this.gridGroupingControl1.UseDefaultsForFasterDrawing = true;
            this.gridGroupingControl1.CounterLogic = EngineCounters.YAmount;
            this.gridGroupingControl1.AllowedOptimizations = EngineOptimizations.DisableCounters | EngineOptimizations.RecordsAsDisplayElements;
            this.gridGroupingControl1.CacheRecordValues = false;

            // Use InvalidateAll if many records change sort position during a short time 
            // Will also help to increase UpdateDisplayFrequency then!
            //this.gridGroupingControl1.InsertRemoveBehavior = GridListChangedInsertRemoveBehavior.InvalidateAll;
            //this.gridGroupingControl1.SortPositionChangedBehavior = GridListChangedInsertRemoveBehavior.InvalidateAll;

            // Use ScrollWithImmediateUpdate if ScrollWindow should be called to minimize painting when sort position of
            // limited number of records is changed (see also timer_tick method, the count setting)
            this.gridGroupingControl1.InsertRemoveBehavior = GridListChangedInsertRemoveBehavior.ScrollWithImmediateUpdate;
            this.gridGroupingControl1.SortPositionChangedBehavior = GridListChangedInsertRemoveBehavior.ScrollWithImmediateUpdate;


            // Instruct grouping control not to access datasource through
            // CurrencyManager API and instead access list diretly. When set to
            // false you wil howver loose support for built-in CurrencyManager 
            // synchronization.
            this.gridGroupingControl1.BindToCurrencyManager = false;


            if (typeof(object).Assembly.CodeBase.IndexOf("v1") == -1)
            {
                // .NET 2.0 gets a bit slow when subscribing to ListChanged event on the 
                // DataTable.DefaultView. The following setting allows the engine to wrap 
                // datatable with a Syncfusion.Collections.DataTableList to work around 
                // this bottleneck. It avoids a DefaultView being created for the DataTable.
                // However, the moment you use a DefaultView yourself for the same DataTable, then
                // this optimization will have not much effect any more. So only use this
                // optimization if also no DefaultView is created for the DataTable outside the
                // grid.
                //
                // .NET 1.0 and 1.1 are just fine with using DataTable.DefaultView
                //
                this.gridGroupingControl1.AllowSwapDataViewWithDataTableList = true;
                this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;

            }
            // ----------- End of Optimization code -----------------
        }
        #endregion

        #region OnLoad
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Add a button in caption area - clicking this button will start the timer.

            startTimerButton.Text = "Start Timer";
            startTimerButton.Visible = true;
            this.Controls.Add(startTimerButton);
            startTimerButton.Click += new EventHandler(startTimerButton_Click);
            startTimerButton.BringToFront();

			ToolTip t = new ToolTip();
			t.SetToolTip(startTimerButton, "Click this button to start continous updates. \nTip: You can also sort by EmployeeID or Freight to check out sort position updates of records.");
            this.propertyGrid1.SelectedObject = this.gridGroupingControl1;
            this.BackColor = Color.White;
            // Show schema in property grid.
            //new GridGroupingControlSchemaBrowser(this.gridGroupingControl1).Show();
            this.DropShadow = true;
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro;
            this.propertyGrid1.BackColor = Color.White;
            this.gridGroupingControl1.Table.ExpandAllRecords();
            // 
            // gridGroupingControl1
            // 

            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.Location = new System.Drawing.Point(0, 0);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.ShowGroupDropArea = true;
            this.gridGroupingControl1.Size = new System.Drawing.Size(558, 516);
            this.gridGroupingControl1.TabIndex = 0;
            this.gridGroupingControl1.TestChangeGroup = false;
            this.gridGroupingControl1.TestDeleteRecords = false;
            this.gridGroupingControl1.TestInsertRecords = false;

            this.panel1.Controls.Add(this.gridGroupingControl1);
        }
        #endregion

        #region Events
        void startTimerButton_Click(object sender, EventArgs e)
        {
#if TESTSPEED
            int timer = Environment.TickCount;
            int testCount = 100;
            //using (MeasureTime.Measure("Form1.startTimerButton_Click"))
            {
                for (int n = 0; n < testCount; n++)
				{
                    timer_tick(this, null);
					Application.DoEvents();
					this.gridGroupingControl1.UpdateThrottled();
				}
            }

            String s = MeasureTime.DumpTimes();
            s += Environment.NewLine;
            int tc = (Environment.TickCount - timer);
            //s += "TickCount: " + tc.ToString();
            s += "Average Ticks per timer_tick call: " + (tc / testCount).ToString();
            s += Environment.NewLine;

            this.gridGroupingControl1.Update();
            MessageBox.Show(s);
#else
            // Start timer that updates datasource 

            // Start timer that updates datasource 
            if (this.startTimerButton.Text == "Start Timer")
            {
                timer = new System.Windows.Forms.Timer();
                timer.Interval = 100; // push in updates every 100 ms. Update 1000 records each time.
                timer.Tick += new EventHandler(timer_tick);
                timer.Start();
                this.startTimerButton.Text = "Stop Timer";
            }
            else
            {
                this.startTimerButton.Text = "Start Timer";
                timer.Tick += new EventHandler(timer_tick);
                timer.Stop();
            }
#endif
        }

        Random rnd = new Random(0);
        int j;
        bool sortedByFreight = false;
        bool sortedByEmployeeID = false;
        System.Windows.Forms.Timer timer;

        void timer_tick(object sender, EventArgs e)
        {
            GridTableDescriptor td = this.gridGroupingControl1.TableDescriptor;
            ManualTotalSummaryTable tb = ((ManualTotalSummaryTable)this.gridGroupingControl1.Table);
            int i = 0;
            using (MeasureTime.Measure("Form1.timer_tick"))
            {
                int count = 1000;

				if (this.gridGroupingControl1.SortPositionChangedBehavior == GridListChangedInsertRemoveBehavior.ScrollWithImmediateUpdate)
                {
                if (sortedByFreight || gridGroupingControl1.TestDeleteRecords || gridGroupingControl1.TestInsertRecords || gridGroupingControl1.TestChangeGroup)
                        count = 200; // when sort position is changed this is much more demanding, let's do less records then.

                if (sortedByEmployeeID)
                        count = 50; // each update will cause records being shifted around so let's do even less records. You could also check out InvalidateAll option instead above ...
                }

                for (i = 0; i < count; i++)
                {
					ManualTotalSummaries.DataSet1.OrdersRow dr;

                    // Insert Records
                    if (gridGroupingControl1.TestInsertRecords)
                    {
						if (i % 10 == 0)
                        {
                            dr = northwindDataSet1.Orders.NewOrdersRow();
                            dr.CustomerID = i.ToString() + (j++).ToString();
                            dr.EmployeeID = i;
                            dr.Freight = i / 10;
                            dr.ShipVia = 0;
                            dr.Table.Rows.Add(dr);
                            continue;
                        }
                    }

                    if (northwindDataSet1.Orders.Rows.Count == 0)
                    {
                        this.gridGroupingControl1.Update();
                        return;
                    }

					int newIndex = rnd.Next(northwindDataSet1.Orders.Rows.Count);
					dr = northwindDataSet1.Orders[newIndex];

					
					// Delete records

					if (gridGroupingControl1.TestDeleteRecords)
					{
						if (i % 12 == 0)
						{
							dr.Delete();
                            continue;
                        }
                    }

                    // Change records

                    // Freight
                    decimal freight = (decimal)dr.Freight + Math.Round((decimal)rnd.Next(-100, 100) / 10000, 2);
                    int employeeID = (int)(rnd.NextDouble() * 1000);

                    //if (!tb.HasColumnChangeListener)
                    //{
                    //    // Engine listens to the DataTable.ColumnChanging event, so this code
                    //    // is not needed. If you do however have a custom list you can manually
                    //    // pass in values as follows or you could also implement the IGroupingColumnChanging
                    //    // and raise a ColumnChanging event from within your datasource. 
                    //    tb.AddChangedField(new ChangedFieldInfo(td, "Freight", dr.Freight, freight));
                    //    tb.AddChangedField(new ChangedFieldInfo(td, "EmployeeID", dr.EmployeeID, employeeID));
                    //    Or you could also simply set groupingGrid.AllowCacheRecords = true; // but that is a bit slower
                    //}

                    dr.BeginEdit();

                    decimal oldFreight = dr.Freight;
                    dr.Freight = freight;
                    dr.EmployeeID = employeeID;

                    if (gridGroupingControl1.TestChangeGroup)
                    {
                        // Change Group Category
                        if (i == 10)
                        {
                            tb.AddChangedField(new ChangedFieldInfo(td, "ShipVia", dr.ShipVia, 0));
                            dr.ShipVia = 0;
                        }
                    }

                    // fires ListChanged event
                    dr.EndEdit();
                }

                // Optionally manually flush changes
                if (this.gridGroupingControl1.UpdateDisplayFrequency == 0)
                    this.gridGroupingControl1.Update();
            }

        }
        #endregion

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

        #region Designer Stuffs
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.northwindDataSet1 = new ManualTotalSummaries.DataSet1();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection2 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapterOrders = new System.Data.SqlClient.SqlDataAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.startTimerButton = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(24, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 637);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.propertyGrid1);
            this.panel2.Location = new System.Drawing.Point(732, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 592);
            this.panel2.TabIndex = 3;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White;
            this.propertyGrid1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyGrid1.HelpBackColor = System.Drawing.Color.White;
            this.propertyGrid1.LineColor = System.Drawing.Color.White;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(251, 592);
            this.propertyGrid1.TabIndex = 3;
            // 
            // startTimerButton
            // 
            this.startTimerButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.startTimerButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.startTimerButton.FlatStyle = FlatStyle.Flat;
            this.startTimerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.startTimerButton.BeforeTouchSize = new System.Drawing.Size(96, 28);
            this.startTimerButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimerButton.ForeColor = System.Drawing.Color.White;
            this.startTimerButton.IsBackStageButton = false;
            this.startTimerButton.Location = new System.Drawing.Point(732, 12);
            this.startTimerButton.Name = "startTimerButton";
            this.startTimerButton.Size = new System.Drawing.Size(96, 28);
            this.startTimerButton.TabIndex = 1;
            this.startTimerButton.Text = "buttonAdv1";
        
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1012, 661);
            this.Controls.Add(this.startTimerButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Manual Total Summary";
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

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
        
        #region Unbound Fields and Covered Ranges

        private void ordersDescriptor_QueryValue(object sender, FieldValueEventArgs e)
        {
            // This methods maps from the underlying value to a related value

            object obj = e.Record.GetValue("ShipVia");
            if (obj != null && !(obj is DBNull))
            {
                int shipVia = (int)obj;
                switch (shipVia)
                {
                    case 0:
                        e.Value = "Zero";
                        break;
                    case 1:
                        e.Value = "One";
                        break;
                    case 2:
                        e.Value = "Two";
                        break;
                    case 3:
                        e.Value = "Three";
                        break;
                }
            }
        }

        int captionCoverCols;

        private void TableModel_QueryCoveredRange(object sender, GridQueryCoveredRangeEventArgs e)
        {
            //using (MeasureTime.Measure("TableModel_QueryCoveredRange"))
            {
                GridTable thisTable = this.gridGroupingControl1.Table;
                if (e.RowIndex < thisTable.DisplayElements.Count)
                {
                    Element el = thisTable.DisplayElements[e.RowIndex];

                    switch (el.Kind)
                    {
                        case DisplayElementKind.Caption:
                            {
                                // Cover some cells of the caption bar (specified with captionCover)
                                IGridGroupOptionsSource gs = el.ParentGroup as IGridGroupOptionsSource;
                                if (gs != null && gs.GroupOptions.ShowCaptionSummaryCells)
                                {
                                    int startCol = el.GroupLevel + 1;
                                    if (!gs.GroupOptions.ShowCaptionPlusMinus)
                                        startCol--;
                                    if (e.ColIndex >= startCol && e.ColIndex < startCol + this.captionCoverCols)
                                    {
                                        e.Range = GridRangeInfo.Cells(e.RowIndex, startCol, e.RowIndex, startCol + this.captionCoverCols -1);
                                        e.Handled = true;
                                    }
                                }
                                break;

                            }
                    }
                }
            }
        }

        #endregion

        #region Manual Total Summary Customization
        /// <summary>
        /// Manually fill the summary cells with values from ManualTotalSummaries.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridGroupingControl1_QueryCellStyleInfo(object sender, GridTableCellStyleInfoEventArgs e)
        {
            Element el = e.TableCellIdentity.DisplayElement;
            ManualTotalSummaryTable table = el.ParentTable as ManualTotalSummaryTable;

            if (table == null)
                return;

            //using (MeasureTime.Measure("gridGroupingControl1_QueryCellStyleInfo"))
            {
                if (Element.IsCaption(el))
                {
                    if (e.Style.TableCellIdentity.ColIndex > 3)
                    {
                        //e.Style.CellValue = e.Style.TableCellIdentity.ColIndex;

                        // You need to provide here manually the code to lookup the summaries you want to display here.
                        // e.TableCellIdentity.Column and e.TableCellIdentity.SummaryColumn will be null

                        // you can get the column as follows:
                        GridColumnDescriptor column = this.gridGroupingControl1.TableModel.GetHeaderColumnDescriptorAt(e.TableCellIdentity.ColIndex);

                        if (column != null && table.TotalSummaries.IndexOf(column.MappingName) != -1)
                        {
                            int index = column.TableDescriptor.Fields.IndexOf(column.FieldDescriptor);
                            IManualTotalSummaryArraySource tsa = (el is Syncfusion.Grouping.Group ? el : el.ParentGroup) as IManualTotalSummaryArraySource;
                            ManualTotalSummary tm = tsa.GetManualTotalSummaryArray()[index];
                            e.Style.CellValue = tm.Total;
                            e.Style.CellValueType = typeof(double);
                            e.Style.Format = "0.00";
                        }
                        // Using that column you could try and identify the summary that should be displayed in this cell.
                    }
                }
                else if (el is GridSummaryRow)
                {
                    // you can get the column as follows:
                    GridColumnDescriptor column = this.gridGroupingControl1.TableModel.GetHeaderColumnDescriptorAt(e.TableCellIdentity.ColIndex);
                    if (column != null && table.TotalSummaries.IndexOf(column.MappingName) != -1)
                    {
                        int index = column.TableDescriptor.Fields.IndexOf(column.FieldDescriptor);
                        IManualTotalSummaryArraySource tsa = (el is Syncfusion.Grouping.Group ? el : el.ParentGroup) as IManualTotalSummaryArraySource;
                        ManualTotalSummary tm = tsa.GetManualTotalSummaryArray()[index];
                        e.Style.CellValue = tm.Total;
                        e.Style.CellValueType = typeof(double);
                        e.Style.Format = "0.00";
                    }
                    // Using that column you could try and identify the summary that should be displayed in this cell.
                }
            }
        }

        private void gridGroupingControl1_PropertyChanged(object sender, DescriptorPropertyChangedEventArgs e)
        {
            GridGroupingControl gcc = (GridGroupingControl)sender;
            if (e.PropertyName == "TableDescriptor")
            {
                TableDescriptor tableDescriptor = gcc.TableDescriptor;
                e = (DescriptorPropertyChangedEventArgs)e.Inner;

                if (e.PropertyName == "Relations")
                    e = e.GetNestedChildTableDescriptorEvent(ref tableDescriptor);

                switch (e.PropertyName)
                {
                    case "SortedColumns":
                        {
                            sortedByFreight = tableDescriptor.SortedColumns.Contains("Freight");
                            sortedByEmployeeID = tableDescriptor.SortedColumns.Contains("EmployeeID");
                            break;
                        }
                }
            }
        }
        #endregion

    }

    public class SampleGridGroupingControl : GridGroupingControl
    {
        public SampleGridGroupingControl()
        {
        }

        bool testDeleteRecords = false;
        bool testInsertRecords = false;
        bool testChangeGroup = false;

        [Category("Tests")]
        public bool TestDeleteRecords
        {
            get { return testDeleteRecords; }
            set { testDeleteRecords = value; }
        }

        [Category("Tests")]
        public bool TestInsertRecords
        {
            get { return testInsertRecords; }
            set { testInsertRecords = value; }
        }

        [Category("Tests")]
        public bool TestChangeGroup
        {
            get { return testChangeGroup; }
            set { testChangeGroup = value; }
        }
    }
}