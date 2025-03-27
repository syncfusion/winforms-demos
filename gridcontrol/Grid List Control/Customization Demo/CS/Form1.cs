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
using Syncfusion.Drawing;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.IO;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using DemoCommon.Grid;

namespace CustomizedListControl
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : GridDemoForm
    {
        #region "API Definiton"

        private GridListControl.Dataset1 dataset11;
        private Syncfusion.Windows.Forms.Grid.GridListControl gridListControl1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv2;
        private System.Windows.Forms.Button button1;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton2;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton3;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv5;
        private System.Windows.Forms.FontDialog fontDialog1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv4;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv3;
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private Label label2;
        private Label label3;
        private const string connection = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""{0}"";Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";

        # endregion

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

        #region "Grid Settings"
        /// <summary>
        /// The Grid settings can be customized
        /// </summary>
        private void GridSettings()
        {
            String commandstring = "select * from Products";
            String connection = @"Data Source=" + FindFile("NorthwindwithImage.sdf");
            SqlCeDataAdapter da = new SqlCeDataAdapter(commandstring, connection);
            try
            {
                da.Fill(dataset11, "Products");
            }
            catch (SqlException ex)
            {
                ShowErrorMessage(ex);
            }

            this.gridListControl1.TransparentBackground = true;
            this.gridListControl1.BackgroundImage = Image.FromFile(FindImageFile(@"..\..\abstract.jpg"));
            this.gridListControl1.ThemesEnabled = true;
            this.gridListControl1.BackColor = Color.White;
            this.colorPickerButton1.ColorSelected += new EventHandler(colorPickerButton1_ColorSelected);
            this.colorPickerButton2.ColorSelected += new EventHandler(colorPickerButton2_ColorSelected);
            this.colorPickerButton3.ColorSelected += new EventHandler(colorPickerButton3_ColorSelected);
            this.gridListControl1.Grid.PrepareViewStyleInfo += new GridPrepareViewStyleInfoEventHandler(Grid_PrepareViewStyleInfo);
            this.gridListControl1.Grid.QueryColWidth += new GridRowColSizeEventHandler(Grid_QueryColWidth);
        }

        void Grid_QueryColWidth(object sender, GridRowColSizeEventArgs e)
        {
            e.Size = 100;
            e.Handled = true;
        }

        #region Set HeaderText
        void Grid_PrepareViewStyleInfo(object sender, GridPrepareViewStyleInfoEventArgs e)
        {
            if (e.ColIndex > 0 && e.RowIndex == 0)
            {
                switch (e.ColIndex)
                {
                    case 1:
                        e.Style.Text = "Product ID";
                        break;
                    case 2:
                        e.Style.Text = "Product Name";
                        break;
                    case 3:
                        e.Style.Text = "Unit Price";
                        break;
                    case 4:
                        e.Style.Text = "Units In Stock";
                        break;
                    case 5:
                        e.Style.Text = "Units On Order";
                        break;
                    case 6:
                        e.Style.Text = "Reorder Level";
                        break;
                    case 7:
                        e.Style.Text = "Units In Stock";
                        break;
                    case 8:
                        e.Style.Text = "Units On Order";
                        break;
                    case 9:
                        e.Style.Text = "Reorder Level";
                        break;
                    default:
                        break;
                }
            } 

        }
        #endregion 

        #endregion

        #region "Sample Customization"

        /// <summary>
        /// Find the image file
        /// </summary>
        private void checkBoxAdv1_CheckStateChanged(object sender, System.EventArgs e)
        {
            if (this.checkBoxAdv1.Checked)
            {
                this.checkBoxAdv2.Enabled = true;

                //Make the grid background transparent
                this.gridListControl1.TransparentBackground = true;
                if (!checkBoxAdv2.Checked)
                {
                    //Add background image
                    if (imageFileName == null)
                    {
                        imageFileName = FindImageFile(@"..\..\abstract.jpg");
                        this.gridListControl1.BackgroundImage = Image.FromFile(imageFileName);
                    }
                    else
                        this.gridListControl1.BackgroundImage = Image.FromFile(imageFileName);
                }
                this.colorPickerButton2.Enabled = false;
                this.button1.Enabled = true;

            }
            else
            {
                //Remove transparent background
                this.colorPickerButton2.Enabled = true;
                this.button1.Enabled = false;
                this.gridListControl1.TransparentBackground = false;
                this.checkBoxAdv2.Enabled = false;
            }
        }

        #region Setting BackgroundImage
        /// <summary>
        /// Used to set the Background image for GridListControl
        /// </summary>
        private void checkBoxAdv2_CheckStateChanged(object sender, System.EventArgs e)
        {
            if (this.checkBoxAdv2.Checked)
            {
                //Remove Backround Image
                this.gridListControl1.BackgroundImage = null;
            }
            else
            {
                if (imageFileName == null)
                    this.gridListControl1.BackgroundImage = Image.FromFile(FindImageFile(@"Common\Images\Grid\CustomizedListControl\Cloud.jpg"));
                else
                    this.gridListControl1.BackgroundImage = Image.FromFile(imageFileName);
            }
        }
        #endregion

        string imageFileName = null;
        private void button1_Click(object sender, System.EventArgs e)
        {
            FileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Bitmap files (*.bmp)|*.bmp|JPEG Files (*.jpg)|*.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.checkBoxAdv1.Enabled = true;
                this.imageFileName = dlg.FileName;
                //Apply the selected image to grid's background
                this.gridListControl1.BackgroundImage = Image.FromFile(this.imageFileName);
            }
        }



        #region Set Color properties for GridListControl

        private void colorPickerButton2_ColorSelected(object sender, EventArgs e)
        {
            //Change Header BackColor
            this.gridListControl1.HeaderBackColor = colorPickerButton2.SelectedColor;
        }

        private void colorPickerButton3_ColorSelected(object sender, EventArgs e)
        {
            //Change Header TextColor
            this.gridListControl1.HeaderTextColor = colorPickerButton3.SelectedColor;
        }

        #endregion

        /// <summary>
        /// Set DisplayHorizontalLines Property
        /// </summary>
        private void checkBoxAdv3_CheckStateChanged(object sender, System.EventArgs e)
        {
            //Enable or Disable the display of horizontal grid lines
            if (this.checkBoxAdv3.Checked)
                this.gridListControl1.Properties.DisplayHorzLines = true;
            else
                this.gridListControl1.Properties.DisplayHorzLines = false;

        }

        /// <summary>
        /// Set DisplayVerticalLines Properties 
        /// </summary>
        private void checkBoxAdv4_CheckStateChanged(object sender, System.EventArgs e)
        {
            //Enable or Disable the display of vertical grid lines
            if (this.checkBoxAdv4.Checked)
                this.gridListControl1.Properties.DisplayVertLines = true;
            else
                this.gridListControl1.Properties.DisplayVertLines = false;

        }

        /// <summary>
        /// Enable/Disable 3D Buttons
        /// </summary>
        private void checkBoxAdv5_CheckStateChanged(object sender, System.EventArgs e)
        {
            //Specify if row/column headers should appear raised or flat
            if (this.checkBoxAdv5.Checked)
            {
                this.gridListControl1.Properties.Buttons3D = true;
            }
            else
            {
                this.gridListControl1.Properties.Buttons3D = false;
            }
        }

        /// <summary>
        /// Select the GridLineColor
        /// </summary>
        private void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            //Change grid lines color
            this.gridListControl1.Grid.Properties.GridLineColor = this.colorPickerButton1.SelectedColor;
            this.gridListControl1.Grid.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
        }

        #endregion

        #region "Designer Stuffs"

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

        #region "FindFile"

        private string FindFile(string connstring)
        {
            connstring = @"Common\Data\" + connstring;
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(connstring))
                    return new FileInfo(connstring).FullName;
                connstring = @"..\" + connstring;
            }

            return connstring;
        }

        #endregion

        #region "Show Error Message"

        /// <summary>
        /// Show the error message
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

        #region "FindImageFile"

        /// <summary>
        /// Find the image file from the specified location
        /// </summary>
        private string FindImageFile(string bitmapName)
        {
            string bitmappath = "";
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    bitmappath = bitmapName;

                bitmapName = @"..\" + bitmapName;
            }
            return bitmappath;
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
            this.dataset11 = new GridListControl.Dataset1();
            this.gridListControl1 = new Syncfusion.Windows.Forms.Grid.GridListControl();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.button1 = new System.Windows.Forms.Button();
            this.colorPickerButton2 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.colorPickerButton3 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.colorPickerButton1 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.checkBoxAdv5 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.checkBoxAdv4 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv3 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataset11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataset11
            // 
            this.dataset11.DataSetName = "Dataset1";
            this.dataset11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataset11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridListControl1
            // 
            this.gridListControl1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            this.gridListControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridListControl1.BackColor = System.Drawing.SystemColors.Control;
            this.gridListControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gridListControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridListControl1.DataSource = this.dataset11;
            this.gridListControl1.DisplayMember = "Products.ProductID";
            this.gridListControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridListControl1.ItemHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            this.gridListControl1.Location = new System.Drawing.Point(18, 21);
            this.gridListControl1.MultiColumn = true;
            this.gridListControl1.Name = "gridListControl1";
            this.gridListControl1.Properties.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridListControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridListControl1.SelectedIndex = -1;
            this.gridListControl1.Size = new System.Drawing.Size(753, 529);
            this.gridListControl1.TabIndex = 0;
            this.gridListControl1.ThemeName = "Metro";
            this.gridListControl1.ThemesEnabled = true;
            this.gridListControl1.TopIndex = 0;
            this.gridListControl1.Grid.DpiAware = true;
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAdv1.BeforeTouchSize = new System.Drawing.Size(162, 23);
            this.checkBoxAdv1.BorderColor = System.Drawing.Color.DimGray;
            this.checkBoxAdv1.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None;
            this.checkBoxAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkBoxAdv1.Checked = true;
            this.checkBoxAdv1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv1.Location = new System.Drawing.Point(795, 234);
            this.checkBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(162, 23);
            this.checkBoxAdv1.StretchImage = false;
            this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv1.TabIndex = 6;
            this.checkBoxAdv1.Text = "Transparent Background";
            this.checkBoxAdv1.ThemeName = "Metro";
            this.checkBoxAdv1.ThemesEnabled = false;
            this.checkBoxAdv1.CheckStateChanged += new System.EventHandler(this.checkBoxAdv1_CheckStateChanged);
            // 
            // checkBoxAdv2
            // 
            this.checkBoxAdv2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAdv2.BeforeTouchSize = new System.Drawing.Size(162, 22);
            this.checkBoxAdv2.BorderColor = System.Drawing.Color.DimGray;
            this.checkBoxAdv2.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None;
            this.checkBoxAdv2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkBoxAdv2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv2.Location = new System.Drawing.Point(795, 272);
            this.checkBoxAdv2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv2.Name = "checkBoxAdv2";
            this.checkBoxAdv2.Size = new System.Drawing.Size(162, 22);
            this.checkBoxAdv2.StretchImage = false;
            this.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv2.TabIndex = 5;
            this.checkBoxAdv2.Text = "Remove Background Image";
            this.checkBoxAdv2.ThemeName = "Metro";
            this.checkBoxAdv2.ThemesEnabled = false;
            this.checkBoxAdv2.CheckStateChanged += new System.EventHandler(this.checkBoxAdv2_CheckStateChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(795, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Browse Background Image";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // colorPickerButton2
            // 
            this.colorPickerButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPickerButton2.BeforeTouchSize = new System.Drawing.Size(162, 24);
            this.colorPickerButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton2.IsBackStageButton = false;
            this.colorPickerButton2.Location = new System.Drawing.Point(795, 431);
            this.colorPickerButton2.Name = "colorPickerButton2";
            this.colorPickerButton2.SelectedAsBackcolor = true;
            this.colorPickerButton2.Size = new System.Drawing.Size(162, 24);
            this.colorPickerButton2.TabIndex = 7;
            this.colorPickerButton2.Text = "Header Back Color";
            this.colorPickerButton2.UseVisualStyleBackColor = false;
            // 
            // colorPickerButton3
            // 
            this.colorPickerButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPickerButton3.BeforeTouchSize = new System.Drawing.Size(162, 24);
            this.colorPickerButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton3.IsBackStageButton = false;
            this.colorPickerButton3.Location = new System.Drawing.Point(795, 472);
            this.colorPickerButton3.Name = "colorPickerButton3";
            this.colorPickerButton3.SelectedAsBackcolor = true;
            this.colorPickerButton3.Size = new System.Drawing.Size(162, 24);
            this.colorPickerButton3.TabIndex = 8;
            this.colorPickerButton3.Text = "Header Text Color";
            this.colorPickerButton3.UseVisualStyleBackColor = false;
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPickerButton1.BeforeTouchSize = new System.Drawing.Size(162, 24);
            this.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton1.IsBackStageButton = false;
            this.colorPickerButton1.Location = new System.Drawing.Point(795, 140);
            this.colorPickerButton1.Name = "colorPickerButton1";
            this.colorPickerButton1.SelectedAsBackcolor = true;
            this.colorPickerButton1.Size = new System.Drawing.Size(162, 24);
            this.colorPickerButton1.TabIndex = 9;
            this.colorPickerButton1.Text = "Gridline Color";
            this.colorPickerButton1.UseVisualStyleBackColor = false;
            // 
            // checkBoxAdv5
            // 
            this.checkBoxAdv5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAdv5.BeforeTouchSize = new System.Drawing.Size(162, 21);
            this.checkBoxAdv5.BorderColor = System.Drawing.Color.DimGray;
            this.checkBoxAdv5.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None;
            this.checkBoxAdv5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkBoxAdv5.Checked = true;
            this.checkBoxAdv5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv5.Location = new System.Drawing.Point(795, 394);
            this.checkBoxAdv5.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv5.Name = "checkBoxAdv5";
            this.checkBoxAdv5.Size = new System.Drawing.Size(162, 21);
            this.checkBoxAdv5.StretchImage = false;
            this.checkBoxAdv5.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv5.TabIndex = 3;
            this.checkBoxAdv5.Text = "Buttons3D";
            this.checkBoxAdv5.ThemeName = "Metro";
            this.checkBoxAdv5.ThemesEnabled = false;
            this.checkBoxAdv5.CheckStateChanged += new System.EventHandler(this.checkBoxAdv5_CheckStateChanged);
            // 
            // checkBoxAdv4
            // 
            this.checkBoxAdv4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAdv4.BeforeTouchSize = new System.Drawing.Size(162, 22);
            this.checkBoxAdv4.BorderColor = System.Drawing.Color.DimGray;
            this.checkBoxAdv4.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None;
            this.checkBoxAdv4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkBoxAdv4.Checked = true;
            this.checkBoxAdv4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv4.Location = new System.Drawing.Point(795, 102);
            this.checkBoxAdv4.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv4.Name = "checkBoxAdv4";
            this.checkBoxAdv4.Size = new System.Drawing.Size(162, 22);
            this.checkBoxAdv4.StretchImage = false;
            this.checkBoxAdv4.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv4.TabIndex = 2;
            this.checkBoxAdv4.Text = "Vertical Lines";
            this.checkBoxAdv4.ThemeName = "Metro";
            this.checkBoxAdv4.ThemesEnabled = false;
            this.checkBoxAdv4.CheckStateChanged += new System.EventHandler(this.checkBoxAdv4_CheckStateChanged);
            // 
            // checkBoxAdv3
            // 
            this.checkBoxAdv3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAdv3.BeforeTouchSize = new System.Drawing.Size(162, 22);
            this.checkBoxAdv3.BorderColor = System.Drawing.Color.DimGray;
            this.checkBoxAdv3.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None;
            this.checkBoxAdv3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkBoxAdv3.Checked = true;
            this.checkBoxAdv3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv3.Location = new System.Drawing.Point(795, 65);
            this.checkBoxAdv3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv3.Name = "checkBoxAdv3";
            this.checkBoxAdv3.Size = new System.Drawing.Size(162, 22);
            this.checkBoxAdv3.StretchImage = false;
            this.checkBoxAdv3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv3.TabIndex = 1;
            this.checkBoxAdv3.Text = "Horizontal Lines";
            this.checkBoxAdv3.ThemeName = "Metro";
            this.checkBoxAdv3.ThemesEnabled = false;
            this.checkBoxAdv3.CheckStateChanged += new System.EventHandler(this.checkBoxAdv3_CheckStateChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(792, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gridlines";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(792, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Background Image";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(792, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Header";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 562);
            this.Controls.Add(this.checkBoxAdv5);
            this.Controls.Add(this.checkBoxAdv2);
            this.Controls.Add(this.colorPickerButton3);
            this.Controls.Add(this.colorPickerButton2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxAdv3);
            this.Controls.Add(this.checkBoxAdv1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxAdv4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.colorPickerButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridListControl1);
            this.MinimumSize = new System.Drawing.Size(635, 600);
            this.Name = "Form1";
            this.Text = "Customization";
            ((System.ComponentModel.ISupportInitialize)(this.dataset11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Entry Point
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

        #endregion
    }
}
