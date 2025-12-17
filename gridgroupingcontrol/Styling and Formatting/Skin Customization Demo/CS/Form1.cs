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
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.GridHelperClasses;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.IO;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace EnhancedVisualStyleInGGC_Demo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : GridDemoForm
    {
        #region "API Definition"

        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
        private EnhancedVisualStyleInGGCDemo_2005.DataSet1 dataSet11;
        private IContainer components;
        private ImageList imageList1;
        GridDynamicFilter filter = new GridDynamicFilter();
        private Label label5;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBox2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBox3;
        private Panel panel1;
        private Panel panel2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
        private Label label8;
        private Label label7;
        private Label label6;
        private GroupBox groupBox3;
        private Label label9;
        private Panel panel3;
        private PictureBox pictureBox5;
        private Panel panel4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox7;
        private PictureBox pictureBox2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        public readonly static string connString = @"Data Source=" + FindFile("NorthwindwithImage.sdf");

        #endregion

        #region "DataSource"

       

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
            this.GridSettings();

        }

        #endregion

        #region "Sample Grid Settings"

        /// <summary>
        /// GridGrouping control getting started customization.
        /// </summary>
        private void GridSettings()
        {
            #region "Data Source"

            String commandstring1 = "select * from Customers";
            String commandstring2 = "select * from Orders";
            this.dataSet11 = new EnhancedVisualStyleInGGCDemo_2005.DataSet1();
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            SqlCeDataAdapter da1 = new SqlCeDataAdapter(commandstring1, connString);
            SqlCeDataAdapter da2 = new SqlCeDataAdapter(commandstring2, connString);
            da1.Fill(dataSet11, "Customers");
            da1.Fill(dataSet11, "Orders");

            //used to set multiextended selection mode in gridgrouping control. 
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
			this.gridGroupingControl1.TableControl.DpiAware = true;

            //used to set GridCaptionRowHeight.
            this.gridGroupingControl1.Table.DefaultCaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridGroupingControl1.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30.0f);
            this.gridGroupingControl1.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            this.MetroColor = System.Drawing.Color.Transparent;

            this.gridGroupingControl1.DataSource = this.dataSet11.Customers;
            this.gridGroupingControl1.DataSource = this.dataSet11.Tables["Customers"];
            this.gridGroupingControl1.AddGroupDropArea("Orders");
            
            #endregion
            //Enable the filter for each columns 
            for (int i = 0; i < gridGroupingControl1.TableDescriptor.Columns.Count; i++)
                gridGroupingControl1.TableDescriptor.Columns[i].AllowFilter = true;

            GridTableDescriptor childDesc = gridGroupingControl1.GetTableDescriptor("Orders");
            for (int j = 0; j < childDesc.Columns.Count; j++)
                childDesc.Columns[j].AllowFilter = true;
            this.gridGroupingControl1.TableModel.EnableLegacyStyle = false;
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            //Enable dynamic filter.
            filter.WireGrid(gridGroupingControl1);

            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = false;


            this.gridGroupingControl1.TopLevelGroupOptions.ShowFilterBar = true;
            this.gridGroupingControl1.NestedTableGroupOptions.ShowFilterBar = true;
            this.gridGroupingControl1.ChildGroupOptions.ShowFilterBar = true;

            this.gridGroupingControl1.TableDescriptor.Columns["CompanyName"].HeaderText = "Company Name";
            this.gridGroupingControl1.TableDescriptor.Columns["ContactName"].HeaderText = "Contact Name";
            this.gridGroupingControl1.TableDescriptor.Columns["ContactTitle"].HeaderText = "Contact Title";
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
        }

        #endregion

        #region "Sample Customized"

        #region "Form Handlers"

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

        #region "Icon"

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

        #region "Windows Form Designer generated code"

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBox3 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.Location = new System.Drawing.Point(12, 7);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.ShowGroupDropArea = true;
            this.gridGroupingControl1.Size = new System.Drawing.Size(697, 635);
            this.gridGroupingControl1.TabIndex = 0;
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.VersionInfo = "4.201.0.37";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "filter_delete.png");
            this.imageList1.Images.SetKeyName(1, "filter.png");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(33, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 9;
            this.label5.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.BeforeTouchSize = new System.Drawing.Size(186, 21);
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.comboBox2.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox2.Location = new System.Drawing.Point(23, 16);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(186, 21);
            this.comboBox2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox2.TabIndex = 13;
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(186, 21);
            this.comboBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.comboBoxAdv1.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxAdv1.Location = new System.Drawing.Point(23, 112);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(186, 21);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv1.TabIndex = 16;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.White;
            this.comboBox3.BeforeTouchSize = new System.Drawing.Size(186, 21);
            this.comboBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.comboBox3.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox3.Location = new System.Drawing.Point(23, 65);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(186, 21);
            this.comboBox3.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox3.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(726, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 635);
            this.panel1.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "\"Grid.TableModel.EnableLegacyStyle = false\"";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(261, 90);
            this.label7.TabIndex = 22;
            this.label7.Text = "\r\nThe existing ColorStyles property is marked as deprecated, \r\n\r\nSo the colorsche" +
    "me used by ColorStyles will be applied to the Grid just by disabling its LegacyS" +
    "tyles.";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 41);
            this.label6.TabIndex = 21;
            this.label6.Text = "This sample features the GridGroupingControl with the new colorscheme used for th" +
    "e ColorStyles. ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox8);
            this.groupBox3.Controls.Add(this.pictureBox9);
            this.groupBox3.Controls.Add(this.pictureBox10);
            this.groupBox3.Controls.Add(this.pictureBox11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.pictureBox5);
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.pictureBox4);
            this.groupBox3.Controls.Add(this.pictureBox7);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.pictureBox6);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(7, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 141);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Styles";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(45, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "GridVisualStyles.Metro";
            this.label9.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(14, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(26, 6);
            this.panel3.TabIndex = 12;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(151, 24);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox5.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Orange;
            this.panel4.Location = new System.Drawing.Point(13, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(26, 4);
            this.panel4.TabIndex = 7;
            this.panel4.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(81, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(116, 24);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox4.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(221, 24);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 30);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 4;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox7.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox7.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(46, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(186, 24);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox6.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox6.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(7, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 89);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Applied Changes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(133, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Metro";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(23, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "Active Style          :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(132, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "Metro";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(23, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 15);
            this.label13.TabIndex = 7;
            this.label13.Text = "Active Scrollbars :";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(716, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 609);
            this.panel2.TabIndex = 16;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(12, 69);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(30, 30);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 16;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox8.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox8.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(48, 70);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(30, 30);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 17;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox9.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox9.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(80, 69);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(30, 30);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 15;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox10.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox10.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(116, 69);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(30, 30);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 14;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox11.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox11.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // Form1
            // 
			this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 654);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridGroupingControl1);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.Text = "Visual Style";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

        #region "Event Hanlders"
        private void Form1_Load(object sender, EventArgs e)
        {
            // Loads the saved compareoperator states in dynamicfilter' button in respective columns
            if (filter != null)
                filter.LoadCompareOperator();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Saves the compareoperator states in dynamicfilter' button of respective columns
            if (filter != null)
            {
                DateTime start = DateTime.Now;
                if (DateTime.Now.Subtract(start).TotalSeconds > 5)
                {
                    Application.DoEvents();
                    start = DateTime.Now;
                    filter.SaveCompareOperator();
                }
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox pBox = (PictureBox)sender;
            switch (pBox.Name)
            {
                case "pictureBox1":
                    this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
                    break;
                case "pictureBox2":
                    this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Office2007Blue;
                    gridGroupingControl1.Office2007ScrollBars = true;
                    gridGroupingControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Blue;
                    break;
                case "pictureBox3":
                    this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Office2007Black;
                    gridGroupingControl1.Office2007ScrollBars = true;
                    gridGroupingControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Black;
                    break;
                case "pictureBox4":
                    this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Office2007Silver;
                    gridGroupingControl1.Office2007ScrollBars = true;
                    gridGroupingControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Silver;
                    break;
                case "pictureBox5":
                    this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Office2010Blue;
                    gridGroupingControl1.Office2007ScrollBars = true;
                    gridGroupingControl1.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Blue;
                    break;
                case "pictureBox6":
                    this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Office2010Black;
                    gridGroupingControl1.Office2007ScrollBars = true;
                    gridGroupingControl1.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Black;
                    break;
                case "pictureBox7":
                    this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Office2010Silver;
                    gridGroupingControl1.Office2007ScrollBars = true;
                    gridGroupingControl1.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Silver;
                    break;
                case "pictureBox8":
                    this.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Interior = new Syncfusion.Drawing.BrushInfo(SystemColors.Window);
                    this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Office2016Black;
                    this.gridGroupingControl1.Office2016ScrollBarsColorScheme = ScrollBarOffice2016ColorScheme.Black;
                    break;
                case "pictureBox9":
                    this.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Interior = new Syncfusion.Drawing.BrushInfo(SystemColors.Window);
                    this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Office2016White;
                    this.gridGroupingControl1.Office2016ScrollBarsColorScheme = ScrollBarOffice2016ColorScheme.White;
                    break;
                case "pictureBox10":
                    this.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Interior = new Syncfusion.Drawing.BrushInfo(SystemColors.Window);
                    this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Office2016DarkGray;
                    this.gridGroupingControl1.Office2016ScrollBarsColorScheme = ScrollBarOffice2016ColorScheme.DarkGray;
                    break;
                case "pictureBox11":
                    this.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Interior = new Syncfusion.Drawing.BrushInfo(SystemColors.Window);
                    this.gridGroupingControl1.BackColor = SystemColors.Window;
                    this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Office2016Colorful;
                    this.gridGroupingControl1.Office2016ScrollBarsColorScheme = ScrollBarOffice2016ColorScheme.Colorful;
                    break;
            }
            this.gridGroupingControl1.TableControl.Refresh();
            this.gridGroupingControl1.GetTableControl("Orders").Refresh();
            label10.Text = gridGroupingControl1.GridVisualStyles.ToString();
            label12.Text = label10.Text;

            panel3.Location = new Point(pBox.Location.X + 3, pBox.Location.Y + pBox.Height + 6);
            panel3.Visible = true;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            this.SuspendLayout();
            PictureBox pBox = (PictureBox)sender;
            panel4.Location = new Point(pBox.Location.X + 3, pBox.Location.Y + pBox.Height + 6);
            panel4.Visible = true;
            WriteStyles(pBox);
            this.ResumeLayout(true);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            panel4.Visible = false;
            label9.Visible = false;
        }

        private void WriteStyles(PictureBox pBox)
        {
            switch (pBox.Name)
            {
                case "pictureBox1":
                    label9.Text = "GridVisualStyles : Metro";
                    break;
                case "pictureBox2":
                    label9.Text = "GridVisualStyles : Office2007Blue";
                    break;
                case "pictureBox3":
                    label9.Text = "GridVisualStyles : Office2007Black";
                    break;
                case "pictureBox4":
                    label9.Text = "GridVisualStyles : Office2007Silver";
                    break;
                case "pictureBox5":
                    label9.Text = "GridVisualStyles : Office2010Blue";
                    break;
                case "pictureBox6":
                    label9.Text = "GridVisualStyles : Office2010Black";
                    break;
                case "pictureBox7":
                    label9.Text = "GridVisualStyles : Office2010Silver";
                    break;
                case "pictureBox8":
                    label9.Text = "GridVisualStyles : Office2016Black";
                    break;
                case "pictureBox9":
                    label9.Text = "GridVisualStyles : Office2016White";
                    break;
                case "pictureBox10":
                    label9.Text = "GridVisualStyles : Office2016DarkGray";
                    break;
                case "pictureBox11":
                    label9.Text = "GridVisualStyles : Office2016Colorful";
                    break;
            }
            label9.Visible = true;
        }
        #endregion

        #endregion

    }
}
