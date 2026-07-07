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
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.IO;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace NestedTableGroupOptions
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : GridDemoForm
    {
        #region API Definitions

        private NestedTableGroupOptions.DataSet1 dataSet11;
        private IContainer components;
        private ToolTip tipDesc;
        private GridGroupingControl gridGroupingControl1;
        private Panel panel3;
        private Label lblProp;
        private Label lblProperty;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private Label label2;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv afterDetails;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv beforeDetails;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv captionText;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv showCaption;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv ShowCaptionPlus;
        private Label label1;
        public readonly static string connString = @"Data Source=" + FindFile("NorthwindwithImage.sdf");
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


            String commandstring1 = "select * from Customers";
            String commandstring2 = "select * from Orders";

            SqlCeDataAdapter da1 = new SqlCeDataAdapter(commandstring1, connString);
            SqlCeDataAdapter da2 = new SqlCeDataAdapter(commandstring2, connString);
            try
            {
                da1.Fill(dataSet11, "Customers");
                da2.Fill(dataSet11, "Orders");
            }
            catch (SqlException ex)
            {
                ShowErrorMessage(ex);
            }
            GridSettings();
        }
        #endregion

        #region Grid Settins

        void GridSettings()
        {
            this.gridGroupingControl1.TableControl.DpiAware = true;
			this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Segoe UI";
            oldStyle = this.gridGroupingControl1.NestedTableGroupOptions.CaptionText;
            this.gridGroupingControl1.Table.Records[2].IsExpanded = true;
            this.gridGroupingControl1.Table.Records[1].IsExpanded = true;
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            // Header Text name changes.
            this.gridGroupingControl1.TableDescriptor.Columns["CompanyName"].HeaderText = "Company Name";
            this.gridGroupingControl1.TableDescriptor.Columns["ContactName"].HeaderText = "Contact Name";
            this.gridGroupingControl1.TableDescriptor.Columns["ContactTitle"].HeaderText = "Contact Tilte";
            this.gridGroupingControl1.TableDescriptor.Columns["CustomerID"].HeaderText = "Customer ID";
            this.gridGroupingControl1.TableDescriptor.Columns["PostalCode"].HeaderText = "Postal Code";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["EmployeeID"].HeaderText = "Employee ID";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["ShipRegion"].HeaderText = "Ship Region";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["ShipPostalCode"].HeaderText = "Ship Postal Code";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["ShippedDate"].HeaderText = "Shipped Date";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["ShipName"].HeaderText = "Shipped Name";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["ShipCountry"].HeaderText = "Ship Country";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["ShipCity"].HeaderText = "ShipCity";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["OrderDate"].HeaderText = "Order Date";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["OrderID"].HeaderText = "Order ID";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["RequiredDate"].HeaderText = "Required Date";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["ShipAddress"].HeaderText = "Ship Address";
            this.gridGroupingControl1.GetTableDescriptor("Orders").Columns["ShipCity"].HeaderText = "Ship City";

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;
        }

        #endregion

        #region Sample Customization

        #region Event Handlers
        private void ShowCaptionPlus_CheckedChanged(object sender, System.EventArgs e)
        {
            this.gridGroupingControl1.NestedTableGroupOptions.ShowCaptionPlusMinus = !this.gridGroupingControl1.NestedTableGroupOptions.ShowCaptionPlusMinus;
            this.lblProperty.Text = "";
            this.lblProperty.Text = "gridGroupingControl1.NestedTableGroupOptions.ShowCaptionPlusMinus = " + this.gridGroupingControl1.NestedTableGroupOptions.ShowCaptionPlusMinus;
            this.gridGroupingControl1.Refresh();
        }

        private void showCaption_CheckedChanged(object sender, System.EventArgs e)
        {
            this.gridGroupingControl1.NestedTableGroupOptions.ShowCaption = !this.gridGroupingControl1.NestedTableGroupOptions.ShowCaption;
            this.lblProperty.Text = "";
            this.lblProperty.Text = "gridGroupingControl1.NestedTableGroupOptions.ShowCaption = " + this.gridGroupingControl1.NestedTableGroupOptions.ShowCaption;
            this.gridGroupingControl1.Refresh();
        }

        string oldStyle = "";
        private void captionText_CheckedChanged(object sender, System.EventArgs e)
        {
            this.lblProperty.Text = "";
            if (this.captionText.Checked)
            {
                this.gridGroupingControl1.NestedTableGroupOptions.CaptionText = "There are {RecordCount} items under {CategoryName} : {Category}";
                this.lblProperty.Text = "gridGroupingControl1.NestedTableGroupOptions.CaptionText = \"There are {RecordCount} items under {CategoryName} : {Category}\"";
            }
            else if (!this.captionText.Checked)
            {
                this.gridGroupingControl1.NestedTableGroupOptions.CaptionText = oldStyle;
                this.lblProperty.Text = "gridGroupingControl1.NestedTableGroupOptions.CaptionText = \"" + oldStyle + "\"";
            }
        }

        private void beforeDetails_CheckedChanged(object sender, System.EventArgs e)
        {
            this.lblProp.Text = "";
            this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = !this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails;
            this.lblProp.Text = "gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = " + this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails;
        }

        private void afterDetails_CheckedChanged(object sender, System.EventArgs e)
        {
            this.lblProp.Text = "";
            this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordAfterDetails = !this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordAfterDetails;
            this.lblProp.Text = "gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordAfterDetails = " + this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordAfterDetails;
        }

        #endregion

        #endregion

        #region Designer Stuffs

        #region Data Files
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

        private static void ShowErrorMessage(SqlException ex)
        {
            if (ex.Number == 11001)
                MessageBox.Show("Host server is down or internet connection is lost.", "Error: Unable To Locate Host", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ex.Number == 208)
                MessageBox.Show("Queried table is invalid.", "Error: Unable To Locate Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ex.Number == 156 || ex.Number == 102)
                MessageBox.Show("Check query syntax and try again.", "Error: Invalid Command", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.components = new System.ComponentModel.Container();
            this.dataSet11 = new NestedTableGroupOptions.DataSet1();
            this.tipDesc = new System.Windows.Forms.ToolTip(this.components);
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblProp = new System.Windows.Forms.Label();
            this.lblProperty = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.afterDetails = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.beforeDetails = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.captionText = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.showCaption = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.ShowCaptionPlus = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.afterDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beforeDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captionText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showCaption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowCaptionPlus)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.gridGroupingControl1.DataSource = this.dataSet11.Customers;
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.Location = new System.Drawing.Point(10, 16);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.Size = new System.Drawing.Size(784, 498);
            this.gridGroupingControl1.TabIndex = 6;
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
            this.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.VersionInfo = "4.201.0.37";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblProp);
            this.panel3.Controls.Add(this.lblProperty);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.ForeColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(12, 521);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(991, 128);
            this.panel3.TabIndex = 7;
            // 
            // lblProp
            // 
            this.lblProp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProp.Location = new System.Drawing.Point(231, 72);
            this.lblProp.Name = "lblProp";
            this.lblProp.Size = new System.Drawing.Size(730, 40);
            this.lblProp.TabIndex = 3;
            // 
            // lblProperty
            // 
            this.lblProperty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProperty.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProperty.Location = new System.Drawing.Point(231, 16);
            this.lblProperty.Name = "lblProperty";
            this.lblProperty.Size = new System.Drawing.Size(730, 32);
            this.lblProperty.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Changed Property :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Changed NestedTableGroupOptions Property :";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.afterDetails);
            this.panel1.Controls.Add(this.beforeDetails);
            this.panel1.Controls.Add(this.captionText);
            this.panel1.Controls.Add(this.showCaption);
            this.panel1.Controls.Add(this.ShowCaptionPlus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(803, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 499);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Add New Record Field";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // afterDetails
            // 
            this.afterDetails.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.afterDetails.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afterDetails.Location = new System.Drawing.Point(40, 216);
            this.afterDetails.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.afterDetails.Name = "afterDetails";
            this.afterDetails.Size = new System.Drawing.Size(104, 24);
            this.afterDetails.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.afterDetails.DrawFocusRectangle = true;
            this.afterDetails.TabIndex = 14;
            this.afterDetails.Text = "After Details";
            this.afterDetails.ThemesEnabled = false;
            this.afterDetails.CheckedChanged += new System.EventHandler(this.afterDetails_CheckedChanged);
            // 
            // beforeDetails
            // 
            this.beforeDetails.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.beforeDetails.Checked = true;
            this.beforeDetails.CheckState = System.Windows.Forms.CheckState.Checked;
            this.beforeDetails.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beforeDetails.Location = new System.Drawing.Point(40, 186);
            this.beforeDetails.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.beforeDetails.Name = "beforeDetails";
            this.beforeDetails.Size = new System.Drawing.Size(104, 24);
            this.beforeDetails.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.beforeDetails.DrawFocusRectangle = true;
            this.beforeDetails.TabIndex = 13;
            this.beforeDetails.Text = "Before Details";
            this.beforeDetails.ThemesEnabled = false;
            this.beforeDetails.CheckedChanged += new System.EventHandler(this.beforeDetails_CheckedChanged);
            // 
            // captionText
            // 
            this.captionText.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.captionText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captionText.Location = new System.Drawing.Point(40, 104);
            this.captionText.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.captionText.Name = "captionText";
            this.captionText.Size = new System.Drawing.Size(136, 32);
            this.captionText.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.captionText.DrawFocusRectangle = true;
            this.captionText.TabIndex = 12;
            this.captionText.Text = "Modify Caption Text";
            this.captionText.ThemesEnabled = false;
            this.captionText.CheckedChanged += new System.EventHandler(this.captionText_CheckedChanged);
            // 
            // showCaption
            // 
            this.showCaption.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.showCaption.Checked = true;
            this.showCaption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showCaption.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCaption.Location = new System.Drawing.Point(40, 72);
            this.showCaption.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.showCaption.Name = "showCaption";
            this.showCaption.Size = new System.Drawing.Size(136, 24);
            this.showCaption.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.showCaption.DrawFocusRectangle = true;
            this.showCaption.TabIndex = 11;
            this.showCaption.Text = "Show Caption";
            this.showCaption.ThemesEnabled = false;
            this.showCaption.CheckedChanged += new System.EventHandler(this.showCaption_CheckedChanged);
            // 
            // ShowCaptionPlus
            // 
            this.ShowCaptionPlus.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.ShowCaptionPlus.Checked = true;
            this.ShowCaptionPlus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowCaptionPlus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCaptionPlus.Location = new System.Drawing.Point(40, 40);
            this.ShowCaptionPlus.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ShowCaptionPlus.Name = "ShowCaptionPlus";
            this.ShowCaptionPlus.Size = new System.Drawing.Size(136, 24);
            this.ShowCaptionPlus.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.ShowCaptionPlus.DrawFocusRectangle = true;
            this.ShowCaptionPlus.TabIndex = 10;
            this.ShowCaptionPlus.Text = "Show Caption +/-";
            this.ShowCaptionPlus.ThemesEnabled = false;
            this.ShowCaptionPlus.CheckedChanged += new System.EventHandler(this.ShowCaptionPlus_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nested Table Group Options";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 656);
            this.Controls.Add(this.gridGroupingControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "Form1";
            this.Text = "Nested-Table Group Options";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.afterDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beforeDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captionText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showCaption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowCaptionPlus)).EndInit();
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
