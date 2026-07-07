#region Copyright Syncfusion Inc. 2001 - 2015
// Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.GridHelperClasses;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.IO;
using Syncfusion.Windows.Forms;
using System.Runtime.InteropServices;
using DemoCommon.Grid;
using Syncfusion.Grouping;

namespace DynamicFilter
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : GridDemoForm
    {
        #region "API Definition"

        private DynamicFilter.DataSet1 dataSet11;
        ToolTip toolTip = new ToolTip();
        private IContainer components;
        private ImageList imageList1;
        GridDynamicFilter filter = new GridDynamicFilter();
        private GridGroupingControl gridGroupingControl1;
        private PropertyGrid propertyGrid1;
        private Panel panel1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox8;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox7;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox6;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox5;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox4;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox3;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox2;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox1;
        public readonly static string connString = @"Data Source=" + FindFile("NorthwindwithImage.sdf");
        GridTableFilterBarExtCellRenderer rend;
        #endregion
        
        #region "Constructor"

        public Form1()
        {
            LocalizationProvider.Provider = new Localizer();
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            GridSettings();
            toolTip.InitialDelay = 10;
            toolTip.AutoPopDelay = 1500;
        }

        #endregion

        #region "Sample Grid Settings"

        /// <summary>
        /// GridGrouping control getting started customization.
        /// </summary>
        private void GridSettings()
        {
            //used to set multiextended selection mode in gridgrouping control. 
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
			this.gridGroupingControl1.TableControl.DpiAware = true;

            //used to set GridCaptionRowHeight.
            //this.gridGroupingControl1.Table.DefaultCaptionRowHeight = 25;
            this.gridGroupingControl1.Table.DefaultColumnHeaderRowHeight = 25;
            this.gridGroupingControl1.Table.DefaultRecordRowHeight = 22;
            this.MetroColor = System.Drawing.Color.Transparent;
            
            //Grid column name Changed
            this.gridGroupingControl1.TableDescriptor.Columns["CompanyName"].HeaderText = "Company Name";
            this.gridGroupingControl1.TableDescriptor.Columns["ContactName"].HeaderText = "Contact Name";
            this.gridGroupingControl1.TableDescriptor.Columns["ContactTitle"].HeaderText = "Contact Tilte";
            this.gridGroupingControl1.TableDescriptor.Columns["CustomerID"].HeaderText = "Customer ID";
            this.gridGroupingControl1.TableDescriptor.Columns["PostalCode"].HeaderText = "Postal Code";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["ShipVia"].HeaderText = "Ship Via";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["ShipRegion"].HeaderText = "Ship Region";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["ShipPostalCode"].HeaderText = "Ship Postal Code";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["ShippedDate"].HeaderText = "Shipped Date";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["ShipName"].HeaderText = "Ship Name";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["ShipCountry"].HeaderText = "Ship Country";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["ShipCity"].HeaderText = "Ship City";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["ShipAddress"].HeaderText = "Ship Address";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["RequiredDate"].HeaderText = "Required Date";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["OrderID"].HeaderText = "Order ID";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["OrderDate"].HeaderText = "Order Date";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["EmployeeID"].HeaderText = "Employee ID";

            this.gridGroupingControl1.GetTable("Orders").DefaultColumnHeaderRowHeight = this.gridGroupingControl1.Table.DefaultColumnHeaderRowHeight;
            this.gridGroupingControl1.GetTable("Orders").DefaultRecordRowHeight = this.gridGroupingControl1.Table.DefaultRecordRowHeight;

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;

            this.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TableControlCellMouseHover += new GridTableControlCellMouseEventHandler(gridGroupingControl1_TableControlCellMouseHover);
            this.gridGroupingControl1.TableControlCellMouseHoverLeave += new GridTableControlCellMouseEventHandler(gridGroupingControl1_TableControlCellMouseHoverLeave);
        }

        void gridGroupingControl1_TableControlCellMouseHoverLeave(object sender, GridTableControlCellMouseEventArgs e)
        {
            if (this.toolTip != null && this.toolTip.Active)
                this.toolTip.Active = false;
        }
              
        void gridGroupingControl1_TableControlCellMouseHover(object sender, GridTableControlCellMouseEventArgs e)
        {
            GridTableCellStyleInfo style = e.TableControl.GetTableViewStyleInfo(e.Inner.RowIndex, e.Inner.ColIndex);
            Element el = e.TableControl.PointToNestedDisplayElement(e.Inner.MouseEventArgs.Location);
            if (el != null && el.Kind == DisplayElementKind.FilterBar)
            {
                int row = el.ParentTable.Elements.IndexOf(el);
                GridCellLayout cellLayout;
                       
                cellLayout = e.TableControl.GetCellRenderer(row, e.Inner.ColIndex).GetCellLayout(row, e.Inner.ColIndex, style);

                Rectangle rect = new Rectangle(e.Inner.MouseEventArgs.Location, new Size(1, 1));

                rect.X += 1;
                rect.Y -= 1;

                if (cellLayout.Buttons.Length > 1)
                {
                    if (cellLayout.Buttons[0].IntersectsWith(rect))
                    {
                        toolTip.SetToolTip(e.TableControl, "The collection of unique items which are available in this column.");
                        toolTip.Active = true;
                    }
                    else if (cellLayout.Buttons[1].IntersectsWith(rect))
                    {
                        toolTip.SetToolTip(e.TableControl, "The collection of compare operators to filter the column.");
                        toolTip.Active = true;
                    }
                }
            }
        }        

        #endregion

        #region "Sample Customization"

        #region Events

        /// <summary>
        /// Handling the Dynamic Filter
        /// </summary>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            gridGroupingControl1.TopLevelGroupOptions.ShowFilterBar = checkBox1.Checked;
        }

        /// <summary>
        /// Add the Filter bar to child table
        /// </summary>
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            gridGroupingControl1.NestedTableGroupOptions.ShowFilterBar = checkBox2.Checked;
        }

        /// <summary>
        /// Add the Filter bar to parent table
        /// </summary>
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            gridGroupingControl1.ChildGroupOptions.ShowFilterBar = checkBox3.Checked;
        }

        /// <summary>
        /// Add the filter bar to child Groups
        /// </summary>
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
                filter.WireGrid(gridGroupingControl1);
            else
                filter.UnWireGrid(gridGroupingControl1);
        }

       /// <summary>
       /// Load the form filter comparator
       /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Loads the saved compareoperator states in dynamicfilter' button in respective columns
            if (filter != null)
                filter.LoadCompareOperator();

            GridGroupingSettings();
        }

        /// <summary>
        /// Save the filer comparator
        /// </summary>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Saves the compareoperator states in dynamicfilter' button of respective columns
            if (filter != null && !this.checkBox5.Checked)
                filter.SaveCompareOperator();
        }

        /// <summary>
        /// localization 2007 filter has been handled
        /// </summary>
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            LockWindowUpdate(this.Handle);
            Localizer loc = new Localizer();
            loc.getstring(checkBox5.Checked, checkBox8.Checked, checkBox6.Checked, checkBox7.Checked);
            LocalizationProvider.Provider = loc;
            GridGroupingSettings();
            LockWindowUpdate(IntPtr.Zero);
        }

        /// <summary>
        /// Localization Filter Comparator has been handled
        /// </summary>
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            LockWindowUpdate(this.Handle);
            Localizer loc = new Localizer();
            loc.getstring(checkBox5.Checked, checkBox8.Checked, checkBox6.Checked, checkBox7.Checked);
            LocalizationProvider.Provider = loc;
            GridGroupingSettings();
            LockWindowUpdate(IntPtr.Zero);
        }

        /// <summary>
        /// Enable Localization in field chooser
        /// </summary>
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            LockWindowUpdate(this.Handle);
            GridExcelFilter filter = new GridExcelFilter();

            Localizer loc = new Localizer();
            loc.getstring(checkBox5.Checked, checkBox8.Checked, checkBox6.Checked, checkBox7.Checked);
            LocalizationProvider.Provider = loc;
            if (checkBox6.Checked)
                //To wire grid with filter
                filter.WireGrid(this.gridGroupingControl1);
            else
                filter.UnWireGrid(this.gridGroupingControl1);

            GridGroupingSettings();
            LockWindowUpdate(IntPtr.Zero);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        internal static extern bool LockWindowUpdate(IntPtr hWndLock);

        /// <summary>
        /// Enable Localiztion in Record Navigation Bar handled
        /// </summary>
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            LockWindowUpdate(this.Handle);
            Localizer loc = new Localizer();
            loc.getstring(checkBox5.Checked, checkBox8.Checked, checkBox6.Checked, checkBox7.Checked);
            LocalizationProvider.Provider = loc;
            FieldChooser fieldChooserObj = new FieldChooser(this.gridGroupingControl1);
            GridGroupingSettings();
            LockWindowUpdate(IntPtr.Zero);
        }

        #endregion

        #endregion

        #region "Designer Stuff"

        #region "Grid Group Settings"

        public void GridGroupingSettings()
        {
            #region "Data Source"
            
            String commandstring1 = "select * from Customers";
            String commandstring2 = "select * from Orders";

            SqlCeDataAdapter da1 = new SqlCeDataAdapter(commandstring1, connString);
            SqlCeDataAdapter da2 = new SqlCeDataAdapter(commandstring2, connString);
            da1.Fill(dataSet11, "Customers");
            da1.Fill(dataSet11, "Orders");			
            
			this.gridGroupingControl1.DataSource = this.dataSet11.Tables["Customers"];

            #endregion

            if (this.gridGroupingControl1.GetTableControl("Orders").GroupDropArea == null)
                this.gridGroupingControl1.AddGroupDropArea("Orders");

            
            //Enable the filter for each columns 
            for (int i = 0; i < gridGroupingControl1.TableDescriptor.Columns.Count; i++)
                gridGroupingControl1.TableDescriptor.Columns[i].AllowFilter = true;

            GridTableDescriptor childDesc = gridGroupingControl1.GetTableDescriptor("Orders");
            for (int j = 0; j < childDesc.Columns.Count; j++)
                childDesc.Columns[j].AllowFilter = true;

            //Enable dynamic filter.
            filter.WireGrid(gridGroupingControl1);
            this.gridGroupingControl1.ShowNavigationBar = true;
            this.gridGroupingControl1.ShowNavigationBarToolTips = true;
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro ;
			this.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro;
            rend = this.gridGroupingControl1.TableControl.CellRenderers["FilterBarCell"] as GridTableFilterBarExtCellRenderer;
           
        }

        #endregion

        #region "Find Utility"

        /// <summary>
        /// Find the Data file from specified location
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
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

        #region Windows Form Designer generated code
        /// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataSet11 = new DynamicFilter.DataSet1();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox8 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox7 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox6 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox5 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox4 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox3 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "filter_delete.png");
            this.imageList1.Images.SetKeyName(1, "filter.png");
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.DataSource = this.dataSet11.Customers;
            this.gridGroupingControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.Location = new System.Drawing.Point(9, 2);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.ShowGroupDropArea = true;
            this.gridGroupingControl1.Size = new System.Drawing.Size(725, 639);
            this.gridGroupingControl1.TabIndex = 14;
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.TopLevelGroupOptions.ShowFilterBar = true;
            this.gridGroupingControl1.VersionInfo = "4.201.0.37";
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
            this.propertyGrid1.Location = new System.Drawing.Point(739, 187);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.gridGroupingControl1;
            this.propertyGrid1.Size = new System.Drawing.Size(262, 454);
            this.propertyGrid1.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBox8);
            this.panel1.Controls.Add(this.checkBox7);
            this.panel1.Controls.Add(this.checkBox6);
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(740, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 178);
            this.panel1.TabIndex = 17;
            // 
            // checkBox8
            // 
            this.checkBox8.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox8.Location = new System.Drawing.Point(10, 128);
            this.checkBox8.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(247, 17);
            this.checkBox8.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox8.DrawFocusRectangle = true;
            this.checkBox8.TabIndex = 23;
            this.checkBox8.Text = "Enable Localization in RecordNavigationBar";
            this.checkBox8.ThemesEnabled = false;
            this.checkBox8.CheckStateChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox7.Location = new System.Drawing.Point(10, 108);
            this.checkBox7.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(206, 17);
            this.checkBox7.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox7.DrawFocusRectangle = true;
            this.checkBox7.TabIndex = 22;
            this.checkBox7.Text = "Enable Localization in FieldChooser";
            this.checkBox7.ThemesEnabled = false;
            this.checkBox7.CheckStateChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox6.Location = new System.Drawing.Point(10, 88);
            this.checkBox6.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(222, 17);
            this.checkBox6.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox6.DrawFocusRectangle = true;
            this.checkBox6.TabIndex = 20;
            this.checkBox6.Text = "Enable Localization in Office2007 Filter";
            this.checkBox6.ThemesEnabled = false;
            this.checkBox6.CheckStateChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox5.Location = new System.Drawing.Point(10, 148);
            this.checkBox5.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(217, 17);
            this.checkBox5.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox5.DrawFocusRectangle = true;
            this.checkBox5.TabIndex = 24;
            this.checkBox5.Text = "Enable Localization in Filter Comparer";
            this.checkBox5.ThemesEnabled = false;
            this.checkBox5.CheckStateChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox4.Location = new System.Drawing.Point(10, 8);
            this.checkBox4.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(95, 17);
            this.checkBox4.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox4.DrawFocusRectangle = true;
            this.checkBox4.TabIndex = 16;
            this.checkBox4.Text = "Dynamic Filter";
            this.checkBox4.ThemesEnabled = false;
            this.checkBox4.CheckStateChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox3.Location = new System.Drawing.Point(10, 69);
            this.checkBox3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(172, 17);
            this.checkBox3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox3.DrawFocusRectangle = true;
            this.checkBox3.TabIndex = 19;
            this.checkBox3.Text = "Add FilterBar to ChildGroups";
            this.checkBox3.ThemesEnabled = false;
            this.checkBox3.CheckStateChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox2.Checked = false;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox2.Location = new System.Drawing.Point(10, 29);
            this.checkBox2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(161, 17);
            this.checkBox2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox2.DrawFocusRectangle = true;
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Add FilterBar to ChildTable";
            this.checkBox2.ThemesEnabled = false;
            this.checkBox2.CheckStateChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox1.Location = new System.Drawing.Point(10, 49);
            this.checkBox1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(167, 17);
            this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox1.DrawFocusRectangle = true;
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Add FilterBar to ParentTable";
            this.checkBox1.ThemesEnabled = false;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1012, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.gridGroupingControl1);
            this.MinimumSize = new System.Drawing.Size(860, 335);
            this.Name = "Form1";
            this.Text = "Localization";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).EndInit();
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
