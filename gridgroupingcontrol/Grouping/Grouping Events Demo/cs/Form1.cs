#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;
using System.Drawing;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Grouping;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.IO;
using Syncfusion.Windows.Forms;
using Syncfusion.GridHelperClasses;
using DemoCommon.Grid;

namespace GroupingEvents
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : GridDemoForm
    {
        #region "API Definition"

        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
        private IContainer components;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private GroupingEvents.Dataset1 dataset11;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.ButtonAdv button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private EngineEventTracer eventTracer;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv freezeCaptioncheckBoxAdv;
        public readonly static string connString = @"Data Source=" + FindFile("NorthwindwithImage.sdf");

        #endregion

        #region Constructor

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
            this.GridSettings();
            this.SampleCustomization();
        }

        #endregion

        #region "Sample Grid Settings"

        /// <summary>
        /// GridGrouping control Grouping Events customization.
        /// </summary>
        private void GridSettings()
        {
            String commandstring1 = "select * from Employees";
            String commandstring2 = "select * from Orders";

            SqlCeDataAdapter da1 = new SqlCeDataAdapter(commandstring1, connString);
            SqlCeDataAdapter da2 = new SqlCeDataAdapter(commandstring2, connString);
            try
            {
                da1.Fill(dataset11, "Employees");
                da2.Fill(dataset11, "Orders");
            }
            catch (SqlException ex)
            {
                ShowErrorMessage(ex);
            }

            //Setting Grid properties
			this.gridGroupingControl1.TableControl.DpiAware = true;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TableOptions.GridLineBorder = new GridBorder(GridBorderStyle.Solid, System.Drawing.Color.FromArgb(208, 215, 229), GridBorderWeight.Thin);
            this.BackColor = Color.White;
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro;
            FieldChooser fc = new FieldChooser(this.gridGroupingControl1);
            //used to set multiextended selection mode in gridgrouping control. 
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
            this.gridGroupingControl1.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30.0f);
            //this.gridGroupingControl1.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            this.gridGroupingControl1.Table.DefaultRecordRowHeight = this.gridGroupingControl1.GetTable("Orders").DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);            

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;
        }

        #endregion

        #region "Sample Customizations"

        /// <summary>
        /// Grouping sample Customizations are done here.
        /// </summary>
        private void SampleCustomization()
        {
            //Create Instance for GridEngine 
            GridEngine eng = this.gridGroupingControl1.Engine;

            //Instantiate the eventTracer
            eventTracer = new EngineEventTracer(eng, this.listView1);

            //Set the GroupDropPanel Height
            this.gridGroupingControl1.GroupDropPanel.Height += 10;

            //Hook the Mouse_Down event of the Listview
            this.listView1.MouseDown += new MouseEventHandler(listView1_MouseDown);
            
        }

        #region "Event Handlers"

        private void menuItem1_Click(object sender, System.EventArgs e)
        {
            //Cleare the items in ListView
            this.listView1.Items.Clear();
        }

        private void button1_Click_1(object sender, System.EventArgs e)
        {
            if (this.button1.Text == "Trace Events")
            {
                //Hook-up the events on demand 
                this.eventTracer.HookEvents();
                this.button1.Text = "Disable Tracing";
            }
            else
            {
                //Unhook the events when they are not traced. 
                this.eventTracer.UnhookEvents();
                this.button1.Text = "Trace Events";
            }
        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            //Enable or Disable Menuitem
            if (e.Button == MouseButtons.Right)
                if (this.listView1.Items.Count == 0)
                {
                    this.menuItem1.Enabled = false;
                }
                else
                {
                    this.menuItem1.Enabled = true;
                }
        }

        private void freezeCaptioncheckBoxAdv_CheckStateChanged(object sender, EventArgs e)
        {
            //Freeze or UnFreeze the Caption
            if (this.freezeCaptioncheckBoxAdv.CheckState == CheckState.Checked)
                this.gridGroupingControl1.FreezeCaption = true;
            else
                this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.Refresh();
        }

        #endregion

        #endregion

        #region "Designer Stuffs"

        #region FindFile
        /// <summary>
        /// Find the files to load the datasource
        /// </summary>
        private static string FindFile(string fileName)
        {
            // Check both in parent folder and Parent\Data folders.
            string dataFileName = @"Common\Data\" + fileName;
            for (int n = 0; n < 12; n++)
            {
                if (System.IO.File.Exists(fileName))
                {
                    return new FileInfo(fileName).FullName;
                }
                if (System.IO.File.Exists(dataFileName))
                {
                    return new FileInfo(dataFileName).FullName;
                }
                fileName = @"..\" + fileName;
                dataFileName = @"..\" + dataFileName;
            }

            return fileName;
        }

        #endregion

        #region ShowErrorMessage
        /// <summary>
        /// Display the Error message
        /// </summary>
        private static void ShowErrorMessage(SqlException ex)
        {
            if (ex.Number == 11001)
                MessageBox.Show("Host server is down or internet connection is lost.", "Error: Unable To Locate Host", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ex.Number == 208)
                MessageBox.Show("Queried table is invalid.", "Error: Unable To Locate Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ex.Number == 156 || ex.Number == 102)
                MessageBox.Show("Check query syntax and try again.", "Error: Invalid Command", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        #endregion

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

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor2 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor3 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor4 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor5 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor6 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor7 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridRelationDescriptor gridRelationDescriptor1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridRelationDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor8 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor9 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor10 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor11 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor12 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor13 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderRowDescriptor gridStackedHeaderRowDescriptor1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderRowDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor gridStackedHeaderDescriptor1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor gridStackedHeaderDescriptor2 = new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor gridStackedHeaderDescriptor3 = new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor gridStackedHeaderDescriptor4 = new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor gridStackedHeaderDescriptor5 = new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor();
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.dataset11 = new GroupingEvents.Dataset1();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.freezeCaptioncheckBoxAdv = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset11)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freezeCaptioncheckBoxAdv)).BeginInit();
            this.SuspendLayout();
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.DataMember = "Employees";
            this.gridGroupingControl1.DataSource = this.dataset11;
            this.gridGroupingControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.Location = new System.Drawing.Point(2, 0);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.ShowGroupDropArea = true;
            this.gridGroupingControl1.Size = new System.Drawing.Size(883, 355);
            this.gridGroupingControl1.TabIndex = 0;
            gridColumnDescriptor1.HeaderImage = null;
            gridColumnDescriptor1.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor1.HeaderText = "Employee ID";
            gridColumnDescriptor1.MappingName = "EmployeeID";
            gridColumnDescriptor1.SerializedImageArray = "";
            gridColumnDescriptor2.HeaderImage = null;
            gridColumnDescriptor2.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor2.HeaderText = "First Name";
            gridColumnDescriptor2.MappingName = "FirstName";
            gridColumnDescriptor2.SerializedImageArray = "";
            gridColumnDescriptor3.HeaderImage = null;
            gridColumnDescriptor3.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor3.HeaderText = "Last Name";
            gridColumnDescriptor3.MappingName = "LastName";
            gridColumnDescriptor3.SerializedImageArray = "";
            gridColumnDescriptor4.HeaderImage = null;
            gridColumnDescriptor4.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor4.MappingName = "Title";
            gridColumnDescriptor4.SerializedImageArray = "";
            gridColumnDescriptor5.HeaderImage = null;
            gridColumnDescriptor5.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor5.MappingName = "Address";
            gridColumnDescriptor5.SerializedImageArray = "";
            gridColumnDescriptor6.HeaderImage = null;
            gridColumnDescriptor6.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor6.MappingName = "City";
            gridColumnDescriptor6.SerializedImageArray = "";
            gridColumnDescriptor7.HeaderImage = null;
            gridColumnDescriptor7.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor7.MappingName = "Country";
            gridColumnDescriptor7.SerializedImageArray = "";
            this.gridGroupingControl1.TableDescriptor.Columns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor[] {
            gridColumnDescriptor1,
            gridColumnDescriptor2,
            gridColumnDescriptor3,
            gridColumnDescriptor4,
            gridColumnDescriptor5,
            gridColumnDescriptor6,
            gridColumnDescriptor7});
            gridColumnDescriptor8.HeaderImage = null;
            gridColumnDescriptor8.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor8.HeaderText = "Customer ID";
            gridColumnDescriptor8.MappingName = "CustomerID";
            gridColumnDescriptor8.SerializedImageArray = "";
            gridColumnDescriptor9.HeaderImage = null;
            gridColumnDescriptor9.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor9.HeaderText = "Order Date";
            gridColumnDescriptor9.MappingName = "OrderDate";
            gridColumnDescriptor9.SerializedImageArray = "";
            gridColumnDescriptor10.HeaderImage = null;
            gridColumnDescriptor10.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor10.HeaderText = "Order ID";
            gridColumnDescriptor10.MappingName = "OrderID";
            gridColumnDescriptor10.SerializedImageArray = "";
            gridColumnDescriptor11.HeaderImage = null;
            gridColumnDescriptor11.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor11.HeaderText = "Ship Address";
            gridColumnDescriptor11.MappingName = "ShipAddress";
            gridColumnDescriptor11.SerializedImageArray = "";
            gridColumnDescriptor12.HeaderImage = null;
            gridColumnDescriptor12.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor12.HeaderText = "Ship Name";
            gridColumnDescriptor12.MappingName = "ShipName";
            gridColumnDescriptor12.SerializedImageArray = "";
            gridColumnDescriptor13.HeaderImage = null;
            gridColumnDescriptor13.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left;
            gridColumnDescriptor13.HeaderText = "Shipped Date";
            gridColumnDescriptor13.MappingName = "ShippedDate";
            gridColumnDescriptor13.SerializedImageArray = "";
            gridRelationDescriptor1.ChildTableDescriptor.Columns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor[] {
            gridColumnDescriptor8,
            gridColumnDescriptor9,
            gridColumnDescriptor10,
            gridColumnDescriptor11,
            gridColumnDescriptor12,
            gridColumnDescriptor13});
            gridRelationDescriptor1.ChildTableDescriptor.StackedHeaderRows.Add(new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderRowDescriptor("Row 1", new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor[] {
                new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor("Header 1", new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor[] {
                            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("CustomerID"),
                            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("OrderDate"),
                            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("OrderID"),
                            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("ShipAddress"),
                            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("ShipName"),
                            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("ShippedDate")})}));
            gridRelationDescriptor1.MappingName = "EmployeesOrders";
            this.gridGroupingControl1.TableDescriptor.Relations.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridRelationDescriptor[] {
            gridRelationDescriptor1});
            gridStackedHeaderRowDescriptor1.Appearance.StackedHeaderCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridStackedHeaderDescriptor1.Appearance.StackedHeaderCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))));
            gridStackedHeaderDescriptor1.Name = "Header 1";
            gridStackedHeaderDescriptor1.VisibleColumns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("EmployeeID"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("FirstName"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("LastName")});
            gridStackedHeaderDescriptor2.Appearance.StackedHeaderCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))));
            gridStackedHeaderDescriptor2.Name = "Header 2";
            gridStackedHeaderDescriptor2.VisibleColumns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("Title"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("Address")});
            gridStackedHeaderDescriptor3.Appearance.StackedHeaderCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Blue);
            gridStackedHeaderDescriptor3.Name = "Header 3";
            gridStackedHeaderDescriptor3.VisibleColumns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("City"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("Country"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("TitleOfCourtesy"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("BirthDate"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("HireDate")});
            gridStackedHeaderDescriptor4.Appearance.StackedHeaderCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))));
            gridStackedHeaderDescriptor4.Name = "Header 4";
            gridStackedHeaderDescriptor4.VisibleColumns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("Region"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("PostalCode"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("HomePhone")});
            gridStackedHeaderDescriptor5.Appearance.StackedHeaderCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255))))));
            gridStackedHeaderDescriptor5.Name = "Header 5";
            gridStackedHeaderDescriptor5.VisibleColumns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("Extension"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("Photo"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("SmallPhoto"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("Notes"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("ReportsTo")});
            gridStackedHeaderRowDescriptor1.Headers.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor[] {
            gridStackedHeaderDescriptor1,
            gridStackedHeaderDescriptor2,
            gridStackedHeaderDescriptor3,
            gridStackedHeaderDescriptor4,
            gridStackedHeaderDescriptor5});
            gridStackedHeaderRowDescriptor1.Name = "Row 1";
            this.gridGroupingControl1.TableDescriptor.StackedHeaderRows.Add(gridStackedHeaderRowDescriptor1);
            this.gridGroupingControl1.TableDescriptor.TableOptions.CaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30.0f);
            this.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            this.gridGroupingControl1.TableDescriptor.VisibleColumns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("EmployeeID"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("FirstName"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("LastName"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("Title"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("Address"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("City"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("Country"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("TitleOfCourtesy"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("BirthDate"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("HireDate"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("Region"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("PostalCode"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("HomePhone"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("Extension"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("Photo"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("SmallPhoto"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("Notes"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ReportsTo")});
            this.gridGroupingControl1.Text = "y";
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.VersionInfo = "4.301.0.0";
            // 
            // dataset11
            // 
            this.dataset11.DataSetName = "Dataset1";
            this.dataset11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataset11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Enabled = false;
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Clear Window";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.gridGroupingControl1);
            this.panel1.Location = new System.Drawing.Point(28, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 355);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(128, 24);
            this.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.IsBackStageButton = false;
            this.button1.Location = new System.Drawing.Point(790, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 24);
            this.button1.TabIndex = 12;
            this.button1.Text = "Trace Events";
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(25, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Event Tracer:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(93, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "(Right click to clear the output window)";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.ContextMenu = this.contextMenu1;
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.DimGray;
            this.listView1.Location = new System.Drawing.Point(25, 428);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(893, 201);
            this.listView1.TabIndex = 9;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Event";
            this.columnHeader1.Width = 186;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Details";
            this.columnHeader2.Width = 759;
            // 
            // freezeCaptioncheckBoxAdv
            // 
            this.freezeCaptioncheckBoxAdv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.freezeCaptioncheckBoxAdv.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.freezeCaptioncheckBoxAdv.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.freezeCaptioncheckBoxAdv.Location = new System.Drawing.Point(618, 396);
            this.freezeCaptioncheckBoxAdv.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.freezeCaptioncheckBoxAdv.Name = "freezeCaptioncheckBoxAdv";
            this.freezeCaptioncheckBoxAdv.Size = new System.Drawing.Size(150, 21);
            this.freezeCaptioncheckBoxAdv.TabIndex = 11;
            this.freezeCaptioncheckBoxAdv.Text = "Freeze Caption";
            this.freezeCaptioncheckBoxAdv.ThemesEnabled = true;
            this.freezeCaptioncheckBoxAdv.CheckStateChanged += new System.EventHandler(this.freezeCaptioncheckBoxAdv_CheckStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 656);
            this.Controls.Add(this.freezeCaptioncheckBoxAdv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Grouping Events";
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset11)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.freezeCaptioncheckBoxAdv)).EndInit();
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
