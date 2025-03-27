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
using Syncfusion.Windows.Forms.Chart;
using DemoCommon.Grid;

namespace SummaryInCaption
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : GridDemoForm
    {
        #region API Definition
        private SummaryInCaption.DataSet1 northwindDataSet1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapterOrders;
        private System.Data.SqlClient.SqlConnection sqlConnection2;
        private Panel panel1;
        private ButtonAdv startTimerButton;
        private GridGroupingControl gridGroupingControl1;
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox1;
        private IContainer components;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv1;
        private Panel panel2;
        Random rnd = new Random();
        Syncfusion.GridHelperClasses.GroupingChartHelper charthelp = new Syncfusion.GridHelperClasses.GroupingChartHelper();
        #endregion

        #region Optimize Grid Settings
        /// <summary>
        /// Optimizing the Grid performance to redue its memory usage.
        /// </summary>
        /// <param name="grid"></param>
        void OptimizeGridSettings(GridGroupingControl grid)
        {
			grid.TableControl.DpiAware = true;
            grid.CounterLogic = EngineCounters.YAmount;
            grid.AllowedOptimizations = EngineOptimizations.DisableCounters | EngineOptimizations.RecordsAsDisplayElements;
            grid.UseDefaultsForFasterDrawing = true; // GDI interop drawing, FirstNRecords Summaries
            grid.InvalidateAllWhenListChanged = false; // only paint modified cells 
            //grid.InsertRemoveBehavior = GridListChangedInsertRemoveBehavior.ScrollWithImmediateUpdate;
            grid.UpdateDisplayFrequency = 50; // update every number of ms (speciy 0 if Update should occur manually, 1 if immediately)
            //grid.TableControl.EnableDoubleBufferSurface(); // reduce flickering
            grid.BlinkTime = 700;

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

        #region Constructor
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();           

            InitializeDataSet();

            OptimizeGridSettings(this.gridGroupingControl1);

            GridSettings();

            ChartControlSettings();

            EnableSelection();

            this.gridGroupingControl1.TableControlQueryAllowGroupByColumn += new GridQueryAllowGroupByColumnEventHandler(gridGroupingControl1_TableControlQueryAllowGroupByColumn);
        }
        #endregion

        #region Events
        void gridGroupingControl1_TableControlQueryAllowGroupByColumn(object sender, GridQueryAllowGroupByColumnEventArgs e)
        {
            if (e.Reason == GridQueryAllowDragColumnReason.MouseUp
                && this.gridGroupingControl1.TableDescriptor.GroupedColumns.Contains("ShipVia_CompanyName"))
            {
                MessageBox.Show("Please remove the unbounded column after then you can group some others", "Alert");
                e.AllowGroupByColumn = false;
            }
        }
        void startTimerButton_Click(object sender, EventArgs e)
        {
            // Start timer that updates datasource 
            Timer t = new Timer();
            t.Interval = 10;
            t.Tick += new EventHandler(t_Tick);

            if (this.startTimerButton.Text == "Start Timer")
            {
                t.Start();
                this.startTimerButton.Text = "Stop Timer";
                this.checkBox1.Checked = true;
                checkBoxAdv1.Checked = false;
                checkBoxAdv1.Enabled = false;
            }
            else
            {
                this.checkBox1.Checked = false;
                this.startTimerButton.Text = "Start Timer";
            }

            this.gridGroupingControl1.TableModel.SelectedRanges.Clear();
            this.gridGroupingControl1.TableOptions.AllowSelection = GridSelectionFlags.None;
        }

        void t_Tick(object sender, EventArgs e)
        {
            if (this.startTimerButton.Text != "Start Timer")
            {

                for (int n = 0; n < 10; n++)
                {
                    int i = rnd.Next(this.northwindDataSet1.Orders.Rows.Count);
                    northwindDataSet1.Orders[i].Freight += 3 - Math.Round((decimal)rnd.NextDouble() * 6);
                }
            }
        }
        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                charthelp.RealTimeUpdate = true;
                checkBoxAdv1.Enabled = false;
            }
            else
            {
                charthelp.RealTimeUpdate = false;
                checkBoxAdv1.Enabled = true;
                checkBoxAdv1.Checked = false;
            }

        }

        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxAdv1.Checked)
            {
                EnableSelection();
                this.checkBox1.Enabled = false;
                this.startTimerButton.Text = "Start Timer";
            }
            else
            {
                this.checkBox1.Enabled = true;
                this.gridGroupingControl1.TableModel.Options.AllowSelection = GridSelectionFlags.None;
                this.gridGroupingControl1.TableModel.Options.ListBoxSelectionMode = SelectionMode.None;
                charthelp.ViewType = ViewType.ActualView;
            }
        }
        #endregion                     

        #region Initialize DataSet

        string xmlName = "ChartOrders.xml";
        bool msdeAvailable = false;

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
            string xmlDataFileName = xmlFileName;
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
            this.northwindDataSet1 = new SummaryInCaption.DataSet1();
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection2 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapterOrders = new System.Data.SqlClient.SqlDataAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.startTimerButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.checkBox1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // northwindDataSet1
            // 
            this.northwindDataSet1.DataSetName = "DataSet1";
            this.northwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.DataSource = this.northwindDataSet1.Orders;
            this.gridGroupingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridGroupingControl1.Location = new System.Drawing.Point(0, 0);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.Size = new System.Drawing.Size(545, 445);
            this.gridGroupingControl1.TabIndex = 0;
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
            this.panel1.Controls.Add(this.gridGroupingControl1);
            this.panel1.Location = new System.Drawing.Point(22, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 445);
            this.panel1.TabIndex = 4;
            // 
            // startTimerButton
            // 
            this.startTimerButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.startTimerButton.FlatStyle = FlatStyle.Flat;
            this.startTimerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.startTimerButton.BeforeTouchSize = new System.Drawing.Size(75, 19);
            this.startTimerButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimerButton.ForeColor = System.Drawing.Color.White;
            this.startTimerButton.IsBackStageButton = false;
            this.startTimerButton.Location = new System.Drawing.Point(20, 10);
            this.startTimerButton.Name = "startTimerButton";
            this.startTimerButton.Size = new System.Drawing.Size(75, 19);
            this.startTimerButton.TabIndex = 3;
            this.startTimerButton.Text = "Start Timer";
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.DataSourceName = "";
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Location = new System.Drawing.Point(423, 75);
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(590, 60);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.Size = new System.Drawing.Size(532, 407);
            this.chartControl1.Skins = Syncfusion.Windows.Forms.Chart.Skins.Metro;
            this.chartControl1.SpacingBetweenPoints = 15F;
            this.chartControl1.TabIndex = 5;
            this.chartControl1.Text = "Real Time Update";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.BeforeTouchSize = new System.Drawing.Size(151, 38);
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.DrawFocusRectangle = false;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(112, 4);
            this.checkBox1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(151, 38);
            this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox1.DrawFocusRectangle = true;
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Enable RealTime Update";
            this.checkBox1.ThemesEnabled = false;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAdv1.BeforeTouchSize = new System.Drawing.Size(133, 35);
            this.checkBoxAdv1.Checked = true;
            this.checkBoxAdv1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv1.DrawFocusRectangle = false;
            this.checkBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv1.Location = new System.Drawing.Point(291, 4);
            this.checkBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(133, 35);
            this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv1.DrawFocusRectangle = true;
            this.checkBoxAdv1.TabIndex = 7;
            this.checkBoxAdv1.Text = "Selection/Actual View";
            this.checkBoxAdv1.ThemesEnabled = false;
            this.checkBoxAdv1.CheckStateChanged += new System.EventHandler(this.checkBoxAdv1_CheckStateChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.checkBoxAdv1);
            this.panel2.Controls.Add(this.startTimerButton);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Location = new System.Drawing.Point(590, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 50);
            this.panel2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1134, 496);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1000, 553);
            this.Name = "Form1";
            this.Text = "Grid Vs Chart";
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

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
        #region OnLoad
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            startTimerButton.Text = "Start Timer";
            startTimerButton.Visible = true;
            startTimerButton.Click += new EventHandler(startTimerButton_Click);
            startTimerButton.BringToFront();
            this.BackColor = Color.White;
            this.DropShadow = true;
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.gridGroupingControl1.TableModel.Options.AllowSelection = GridSelectionFlags.Any;
            //this.gridGroupingControl1.TableModel.Options.ListBoxSelectionMode = SelectionMode.MultiExtended;
            this.gridGroupingControl1.Table.ExpandAllGroups();
            this.gridGroupingControl1.Table.ExpandAllRecords();
            this.gridGroupingControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        #endregion 
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
                        e.Value = "null";
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
                                if (e.ColIndex >= startCol && e.ColIndex <= startCol + this.captionCoverCols)
                                {
                                    e.Range = GridRangeInfo.Cells(e.RowIndex, startCol, e.RowIndex, startCol + this.captionCoverCols);
                                    e.Handled = true;
                                }
                            }
                            break;

                        }
                }
            }

        }

        #endregion

        #region Grid Selection Settings
        private void EnableSelection()
        {
            this.gridGroupingControl1.TableModel.Options.AllowSelection = GridSelectionFlags.Any;
            this.gridGroupingControl1.TableModel.Options.ListBoxSelectionMode = SelectionMode.MultiExtended;
            charthelp.ViewType = ViewType.SelectionView;
            this.checkBox1.Checked = false;
        }
        #endregion

        #region Grid Settings
        /// <summary>
        /// Grid Settings for better Look and Feel
        /// </summary>
        private void GridSettings()
        {
            GridTableDescriptor ordersDescriptor = this.gridGroupingControl1.TableDescriptor;

            // Add Unbound 
            ordersDescriptor.UnboundFields.Add("ShipVia_CompanyName");

            // Callback for conversion
            ordersDescriptor.QueryValue += new FieldValueEventHandler(ordersDescriptor_QueryValue);

            // Hide it.
            ordersDescriptor.VisibleColumns.Remove("ShipVia_CompanyName");

            // Use it for grouping.
            ordersDescriptor.GroupedColumns.Add("CustomerID");

            ordersDescriptor.TopLevelGroupOptions.ShowCaptionSummaryCells = false;

            // not neeeded.
            ordersDescriptor.PrimaryKeyColumns.Clear();

            // Here you define the summary row that should be used for displaying summaries in caption bar.
            ordersDescriptor.ChildGroupOptions.ShowCaptionSummaryCells = true;
            ordersDescriptor.ChildGroupOptions.ShowSummaries = true;
            ordersDescriptor.ChildGroupOptions.CaptionSummaryRow = "Caption";

            // Let's you hide/show the second row in child groups.
            ordersDescriptor.ChildGroupOptions.ShowSummaries = false;

            // Move Freight column ahead 
            ordersDescriptor.VisibleColumns.LoadDefault();
            //int count = ordersDescriptor.VisibleColumns.Count; // force populating VisibleColumns
            //ordersDescriptor.VisibleColumns.Remove("Freight");
            //ordersDescriptor.VisibleColumns.Insert(3, new GridVisibleColumnDescriptor("Freight"));

            // Minor customization: Have Caption bar cover some cells.
            this.gridGroupingControl1.TableModel.QueryCoveredRange += new GridQueryCoveredRangeEventHandler(TableModel_QueryCoveredRange);
            captionCoverCols = 2;

            //Styling GroupCaption Cell.
            this.gridGroupingControl1.Appearance.GroupCaptionCell.BackColor = this.gridGroupingControl1.Appearance.RecordFieldCell.BackColor;
            this.gridGroupingControl1.Appearance.GroupCaptionCell.Borders.Top = new GridBorder(GridBorderStyle.Standard);
            this.gridGroupingControl1.Appearance.GroupCaptionCell.CellType = "Static";

            this.gridGroupingControl1.TableOptions.CaptionRowHeight = this.gridGroupingControl1.TableOptions.RecordRowHeight;

            this.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = false;

            gridGroupingControl1.Table.CurrentRecord = gridGroupingControl1.Table.Records[0];
            this.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue;
            this.gridGroupingControl1.TableOptions.GridLineBorder = new Syncfusion.Windows.Forms.Grid.GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin);
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.ShowGroupDropArea = true;
            this.BackColor = Color.FromArgb(223, 227, 239);
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            String[] header = { "Order Id", "Customer ID", "Employee ID", "Order Date", "Required Date", "Shipped Date", "Ship Via", "Freight", "Ship Name", "Ship Address","Ship City", "Ship Region", "Ship Postal Code", "Ship Country", "ShipVia CompanyName"};
            for (int i = 0; i < 15; i++)
                this.gridGroupingControl1.TableDescriptor.Columns[i].HeaderText = header[i];

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;

        }
        #endregion

        #region Chart Control Settings
        /// <summary>
        /// Chart Control settings for better Look and Feel
        /// </summary>
        private void ChartControlSettings()
        {
            this.chartControl1.CustomPalette = new Color[] { (System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))))),
                (System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(62)))), ((int)(((byte)(108)))))), 
                (System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(218)))), ((int)(((byte)(33)))))),
             Color.Cyan,Color.BlueViolet,Color.Brown ,Color.Chocolate,Color.RoyalBlue};


            //charthelp.ViewType = ViewType.ActualView;

            charthelp.Wire(this.gridGroupingControl1, this.chartControl1, "CustomerID", new ArrayList { "Freight" });



            this.chartControl1.Palette = ChartColorPalette.Custom;

            this.chartControl1.PrimaryYAxis.Title = "Total";
            this.chartControl1.PrimaryYAxis.TitleColor = Color.DarkBlue;
            this.chartControl1.PrimaryYAxis.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
            this.chartControl1.PrimaryXAxis.Title = "Company" + "- " + "Items";
            this.chartControl1.PrimaryXAxis.TitleColor = Color.DarkBlue;
            this.chartControl1.PrimaryXAxis.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
            chartControl1.ColumnWidthMode = ChartColumnWidthMode.RelativeWidthMode;
            //This property is enabled when setting the ColumnWidthMode as RelativeWidthMode
            this.chartControl1.PrimaryXAxis.DesiredIntervals = 4;
        }
        #endregion


    }

}