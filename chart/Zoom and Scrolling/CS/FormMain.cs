#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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

using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Data.OleDb;
using System.Globalization;
using Syncfusion.Windows.Forms;

namespace KeyAndMouseZoomingSample
{
    public class Form1 : Syncfusion.Windows.Forms.MetroForm
    {
        #region Private Members
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private System.Windows.Forms.ComboBox ComboScrollDown;
        private System.Windows.Forms.ComboBox ComboScrollRight;
        private System.Windows.Forms.ComboBox ComboScrollUp;
        private System.Windows.Forms.ComboBox ComboScrollLeft;
        private System.Windows.Forms.ComboBox ComboZoomIn;
        private System.Windows.Forms.ComboBox ComboZoomOut;
        private CheckBox checkBox1;
        private ComboBox comboBox1;
        private Label label9;
        private Label label10;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private ComboBox comboBox2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel8;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel7;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel6;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel9;
        private IContainer components;
        Color forecolor = Color.Red;
        private CheckBox checkBox2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private CheckBox checkBox3;
        private Label label22;
        private Label label15;
        private Label label11;
        private Label label3;
        private Label label4;
        private Label label17;
        private Label label18;
        private Label label20;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton1;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton4;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Syncfusion.Windows.Forms.Tools.ImageListAdv imageListAdv1;
        private Label label8;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private Panel panel3;
        private Label label2;
        private CheckBox checkBox4;
        private ComboBox comboBox7;
        private Label label13;
        private ComboBox comboBox8;
        private Label label16;
        private Label label12;
        private CheckBox checkBox5;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox8;
        Color backcolor = Color.Black;
        #endregion

        #region Form's Constructor, Main and Dispose
        public Form1()
        {
            BorderColor = Color.FromArgb(0xFF, 0xCD, 0xCD, 0xCD);
            BorderThickness = 3;
            CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(75.0f);
            CaptionBarColor = Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2);
            CaptionFont = new Font("Segoe UI", 22.0f);
            CaptionForeColor = Color.White;
            CaptionAlign = HorizontalAlignment.Left;
            ShowIcon = false;
            CaptionButtonColor = Color.White;
            CaptionButtonHoverColor = Color.White;
            InitializeComponent();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.EnableVisualStyles();
            Application.Run(new Form1());
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
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.ComboScrollDown = new System.Windows.Forms.ComboBox();
            this.ComboScrollRight = new System.Windows.Forms.ComboBox();
            this.ComboScrollUp = new System.Windows.Forms.ComboBox();
            this.ComboScrollLeft = new System.Windows.Forms.ComboBox();
            this.ComboZoomIn = new System.Windows.Forms.ComboBox();
            this.ComboZoomOut = new System.Windows.Forms.ComboBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.autoLabel9 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel8 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel7 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel6 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.colorPickerButton = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.colorPickerButton1 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.colorPickerButton4 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.imageListAdv1 = new Syncfusion.Windows.Forms.Tools.ImageListAdv(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = DockStyle.Fill;
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.White, System.Drawing.Color.White);
            this.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Etched;
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.DataSourceName = "";
            this.chartControl1.EnableXZooming = true;
            this.chartControl1.EnableYZooming = true;
            this.chartControl1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Location = new System.Drawing.Point(62, 494);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom;
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.BreakInfo.LineSpacing = 3D;
            this.chartControl1.PrimaryXAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight;
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryXAxis.Range = new Syncfusion.Windows.Forms.Chart.MinMaxInfo(1850D, 2007D, 10D);
            this.chartControl1.PrimaryXAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.Set;
            this.chartControl1.PrimaryYAxis.BreakInfo.LineSpacing = 3D;
            this.chartControl1.PrimaryYAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.Size = new System.Drawing.Size(700, 580);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "Temperature Anomaly";
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            // 
            // autoLabel2
            // 
            this.autoLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autoLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.autoLabel2.Location = new System.Drawing.Point(43, 973);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(127, 20);
            this.autoLabel2.TabIndex = 21;
            this.autoLabel2.Text = "Zooming Factor Y";
            // 
            // autoLabel1
            // 
            this.autoLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autoLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.autoLabel1.Location = new System.Drawing.Point(40, 914);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(128, 20);
            this.autoLabel1.TabIndex = 20;
            this.autoLabel1.Text = "Zooming Factor X";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox2.Location = new System.Drawing.Point(40, 1208);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(134, 24);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Show Scroll Bars";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // ComboScrollDown
            // 
            this.ComboScrollDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboScrollDown.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboScrollDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ComboScrollDown.Location = new System.Drawing.Point(35, 1519);
            this.ComboScrollDown.Name = "ComboScrollDown";
            this.ComboScrollDown.Size = new System.Drawing.Size(173, 28);
            this.ComboScrollDown.TabIndex = 10;
            this.ComboScrollDown.SelectedIndexChanged += new System.EventHandler(this.ComboScrollDown_SelectedIndexChanged);
            // 
            // ComboScrollRight
            // 
            this.ComboScrollRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboScrollRight.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboScrollRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ComboScrollRight.Location = new System.Drawing.Point(35, 1313);
            this.ComboScrollRight.Name = "ComboScrollRight";
            this.ComboScrollRight.Size = new System.Drawing.Size(173, 28);
            this.ComboScrollRight.TabIndex = 9;
            this.ComboScrollRight.SelectedIndexChanged += new System.EventHandler(this.ComboScrollRight_SelectedIndexChanged);
            // 
            // ComboScrollUp
            // 
            this.ComboScrollUp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboScrollUp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboScrollUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ComboScrollUp.Location = new System.Drawing.Point(35, 1444);
            this.ComboScrollUp.Name = "ComboScrollUp";
            this.ComboScrollUp.Size = new System.Drawing.Size(173, 28);
            this.ComboScrollUp.TabIndex = 8;
            this.ComboScrollUp.SelectedIndexChanged += new System.EventHandler(this.ComboScrollUp_SelectedIndexChanged);
            // 
            // ComboScrollLeft
            // 
            this.ComboScrollLeft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboScrollLeft.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboScrollLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ComboScrollLeft.Location = new System.Drawing.Point(34, 1376);
            this.ComboScrollLeft.Name = "ComboScrollLeft";
            this.ComboScrollLeft.Size = new System.Drawing.Size(173, 28);
            this.ComboScrollLeft.TabIndex = 7;
            this.ComboScrollLeft.SelectedIndexChanged += new System.EventHandler(this.ComboScrollLeft_SelectedIndexChanged);
            // 
            // ComboZoomIn
            // 
            this.ComboZoomIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboZoomIn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboZoomIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ComboZoomIn.Location = new System.Drawing.Point(43, 759);
            this.ComboZoomIn.Name = "ComboZoomIn";
            this.ComboZoomIn.Size = new System.Drawing.Size(173, 28);
            this.ComboZoomIn.TabIndex = 1;
            this.ComboZoomIn.SelectedIndexChanged += new System.EventHandler(this.ComboZoomIn_SelectedIndexChanged);
            // 
            // ComboZoomOut
            // 
            this.ComboZoomOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboZoomOut.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboZoomOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ComboZoomOut.Location = new System.Drawing.Point(43, 827);
            this.ComboZoomOut.Name = "ComboZoomOut";
            this.ComboZoomOut.Size = new System.Drawing.Size(173, 28);
            this.ComboZoomOut.TabIndex = 2;
            this.ComboZoomOut.SelectedIndexChanged += new System.EventHandler(this.ComboZoomOut_SelectedIndexChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox3.Location = new System.Drawing.Point(39, 68);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(153, 24);
            this.checkBox3.TabIndex = 20;
            this.checkBox3.Text = "Show Zoom Button";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "0.1",
            "0.2",
            "0.3 ",
            "0.4 ",
            "0.5 ",
            "0.6 ",
            "0.7 ",
            "0.8 ",
            "0.9 ",
            "1.0 "});
            this.comboBox4.Location = new System.Drawing.Point(39, 441);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(173, 28);
            this.comboBox4.TabIndex = 16;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(40, 640);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(173, 28);
            this.comboBox3.TabIndex = 13;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // autoLabel9
            // 
            this.autoLabel9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autoLabel9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.autoLabel9.Location = new System.Drawing.Point(36, 415);
            this.autoLabel9.Name = "autoLabel9";
            this.autoLabel9.Size = new System.Drawing.Size(60, 20);
            this.autoLabel9.TabIndex = 12;
            this.autoLabel9.Text = "Opacity";
            // 
            // autoLabel8
            // 
            this.autoLabel8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autoLabel8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.autoLabel8.Location = new System.Drawing.Point(36, 546);
            this.autoLabel8.Name = "autoLabel8";
            this.autoLabel8.Size = new System.Drawing.Size(76, 20);
            this.autoLabel8.TabIndex = 11;
            this.autoLabel8.Text = "BackColor";
            // 
            // autoLabel7
            // 
            this.autoLabel7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autoLabel7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.autoLabel7.Location = new System.Drawing.Point(35, 479);
            this.autoLabel7.Name = "autoLabel7";
            this.autoLabel7.Size = new System.Drawing.Size(74, 20);
            this.autoLabel7.TabIndex = 10;
            this.autoLabel7.Text = "ForeColor";
            // 
            // autoLabel6
            // 
            this.autoLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autoLabel6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.autoLabel6.Location = new System.Drawing.Point(36, 612);
            this.autoLabel6.Name = "autoLabel6";
            this.autoLabel6.Size = new System.Drawing.Size(102, 20);
            this.autoLabel6.TabIndex = 9;
            this.autoLabel6.Text = "Gradient Style";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(39, 331);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(173, 28);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // autoLabel4
            // 
            this.autoLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autoLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.autoLabel4.Location = new System.Drawing.Point(35, 303);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Size = new System.Drawing.Size(78, 20);
            this.autoLabel4.TabIndex = 6;
            this.autoLabel4.Text = "Dash Style";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label10.Location = new System.Drawing.Point(35, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Color";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1.0",
            "2.0",
            "3.0",
            "4.0",
            "5.0",
            "6.0",
            "7.0",
            "8.0",
            "9.0"});
            this.comboBox1.Location = new System.Drawing.Point(40, 205);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 28);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label9.Location = new System.Drawing.Point(35, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Width";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox1.Location = new System.Drawing.Point(39, 153);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Show Border";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label22.Location = new System.Drawing.Point(32, 30);
            this.label22.Name = "label22";
            this.label22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label22.Size = new System.Drawing.Size(96, 30);
            this.label22.TabIndex = 115;
            this.label22.Text = "Zooming";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label15.Location = new System.Drawing.Point(35, 1175);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 30);
            this.label15.TabIndex = 117;
            this.label15.Text = "Scrolling";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label11.Location = new System.Drawing.Point(40, 732);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 20);
            this.label11.TabIndex = 119;
            this.label11.Text = "ZoomIn Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(41, 799);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 120;
            this.label3.Text = "ZoomOut Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(33, 1276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 121;
            this.label4.Text = "Scrolling Right Key";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label17.Location = new System.Drawing.Point(31, 1344);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 20);
            this.label17.TabIndex = 122;
            this.label17.Text = "Scrolling Left Key";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label18.Location = new System.Drawing.Point(31, 1407);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(118, 20);
            this.label18.TabIndex = 123;
            this.label18.Text = "Scrolling Up Key";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label20.Location = new System.Drawing.Point(33, 1486);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(138, 20);
            this.label20.TabIndex = 124;
            this.label20.Text = "Scrolling Down Key";
            // 
            // colorPickerButton
            // 
            this.colorPickerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colorPickerButton.BeforeTouchSize = new System.Drawing.Size(100, 30);
            this.colorPickerButton.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.colorPickerButton.IsBackStageButton = false;
            this.colorPickerButton.Location = new System.Drawing.Point(39, 261);
            this.colorPickerButton.Name = "colorPickerButton";
            this.colorPickerButton.SelectedAsBackcolor = true;
            this.colorPickerButton.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colorPickerButton.Size = new System.Drawing.Size(100, 30);
            this.colorPickerButton.TabIndex = 14;
            this.colorPickerButton.UseVisualStyleBackColor = false;
            this.colorPickerButton.ColorSelected += new System.EventHandler(this.colorPickerButton_ColorSelected);
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.BackColor = System.Drawing.Color.Red;
            this.colorPickerButton1.BeforeTouchSize = new System.Drawing.Size(100, 30);
            this.colorPickerButton1.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.colorPickerButton1.IsBackStageButton = false;
            this.colorPickerButton1.Location = new System.Drawing.Point(39, 506);
            this.colorPickerButton1.Name = "colorPickerButton1";
            this.colorPickerButton1.SelectedAsBackcolor = true;
            this.colorPickerButton1.SelectedColor = System.Drawing.Color.Red;
            this.colorPickerButton1.Size = new System.Drawing.Size(100, 30);
            this.colorPickerButton1.TabIndex = 14;
            this.colorPickerButton1.UseVisualStyleBackColor = false;
            this.colorPickerButton1.ColorSelected += new System.EventHandler(this.colorPickerButton1_ColorSelected);
            // 
            // colorPickerButton4
            // 
            this.colorPickerButton4.BackColor = System.Drawing.Color.Yellow;
            this.colorPickerButton4.BeforeTouchSize = new System.Drawing.Size(100, 30);
            this.colorPickerButton4.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.colorPickerButton4.IsBackStageButton = false;
            this.colorPickerButton4.Location = new System.Drawing.Point(39, 572);
            this.colorPickerButton4.Name = "colorPickerButton4";
            this.colorPickerButton4.SelectedAsBackcolor = true;
            this.colorPickerButton4.SelectedColor = System.Drawing.Color.Yellow;
            this.colorPickerButton4.Size = new System.Drawing.Size(100, 30);
            this.colorPickerButton4.TabIndex = 14;
            this.colorPickerButton4.UseVisualStyleBackColor = false;
            this.colorPickerButton4.ColorSelected += new System.EventHandler(this.colorPickerButton4_ColorSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(34, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 130;
            this.label1.Text = "Zoom Area Border";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(30, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 25);
            this.label5.TabIndex = 131;
            this.label5.Text = "Zoom Area Interior";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(33, 692);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 132;
            this.label6.Text = "Zooming Keys";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(34, 879);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 25);
            this.label7.TabIndex = 133;
            this.label7.Text = "Zooming Factor";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // imageListAdv1
            // 
            this.imageListAdv1.Images.AddRange(new System.Drawing.Image[] {
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images1")))});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(35, 1239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 25);
            this.label8.TabIndex = 135;
            this.label8.Text = "Scrolling Keys";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox5.Items.AddRange(new object[] {
            "0.1",
            "0.2",
            "0.3",
            "0.4",
            "0.5",
            "0.6",
            "0.7",
            "0.8",
            "0.9",
            "1"});
            this.comboBox5.Location = new System.Drawing.Point(43, 942);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(174, 28);
            this.comboBox5.TabIndex = 136;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox6.Items.AddRange(new object[] {
            "0.1",
            "0.2",
            "0.3",
            "0.4",
            "0.5",
            "0.6",
            "0.7",
            "0.8",
            "0.9",
            "1"});
            this.comboBox6.Location = new System.Drawing.Point(43, 1006);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(174, 28);
            this.comboBox6.TabIndex = 137;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Dock = DockStyle.Right;
            this.panel3.AutoScroll = true;
            this.panel3.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.checkBox8);
            this.panel3.Controls.Add(this.checkBox7);
            this.panel3.Controls.Add(this.checkBox6);
            this.panel3.Controls.Add(this.checkBox5);
            this.panel3.Controls.Add(this.autoLabel2);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.comboBox8);
            this.panel3.Controls.Add(this.comboBox3);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.comboBox7);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.colorPickerButton4);
            this.panel3.Controls.Add(this.checkBox4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.autoLabel6);
            this.panel3.Controls.Add(this.colorPickerButton1);
            this.panel3.Controls.Add(this.autoLabel1);
            this.panel3.Controls.Add(this.ComboScrollDown);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.ComboScrollUp);
            this.panel3.Controls.Add(this.autoLabel7);
            this.panel3.Controls.Add(this.autoLabel8);
            this.panel3.Controls.Add(this.ComboScrollLeft);
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Controls.Add(this.colorPickerButton);
            this.panel3.Controls.Add(this.ComboScrollRight);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.checkBox3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.comboBox4);
            this.panel3.Controls.Add(this.autoLabel9);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.comboBox6);
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.autoLabel4);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.ComboZoomOut);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.comboBox5);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.ComboZoomIn);
            this.panel3.Location = new System.Drawing.Point(701, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(257, 584);
            this.panel3.TabIndex = 138;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Checked = true;
            this.checkBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox8.Location = new System.Drawing.Point(40, 98);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(172, 24);
            this.checkBox8.TabIndex = 139;
            this.checkBox8.Text = "Reset  On DoubleClick";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += checkBox8_CheckedChanged;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox7.Location = new System.Drawing.Point(37, 1148);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(180, 24);
            this.checkBox7.TabIndex = 149;
            this.checkBox7.Tag = Syncfusion.Windows.Forms.Chart.ZoomType.MouseWheelZooming;
            this.checkBox7.Text = "Mouse Wheel Zooming";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkbox_changed);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = true;
            this.checkBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox6.Location = new System.Drawing.Point(37, 1118);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(125, 24);
            this.checkBox6.TabIndex = 148;
            this.checkBox6.Tag = Syncfusion.Windows.Forms.Chart.ZoomType.PinchZooming;
            this.checkBox6.Text = "Pinch Zooming";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkbox_changed);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox5.Location = new System.Drawing.Point(37, 1088);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(86, 24);
            this.checkBox5.TabIndex = 147;
            this.checkBox5.Tag = Syncfusion.Windows.Forms.Chart.ZoomType.Selection;
            this.checkBox5.Text = "Selection";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkbox_changed);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label12.Location = new System.Drawing.Point(32, 1048);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 25);
            this.label12.TabIndex = 146;
            this.label12.Text = "Zoom Type";
            // 
            // comboBox8
            // 
            this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "Panning",
            "None"});
            this.comboBox8.Location = new System.Drawing.Point(35, 1699);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(173, 28);
            this.comboBox8.TabIndex = 144;
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label16.Location = new System.Drawing.Point(36, 1676);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 20);
            this.label16.TabIndex = 143;
            this.label16.Text = "Y-Zoom Action";
            // 
            // comboBox7
            // 
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "Panning",
            "None"});
            this.comboBox7.Location = new System.Drawing.Point(35, 1645);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(173, 28);
            this.comboBox7.TabIndex = 142;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label13.Location = new System.Drawing.Point(36, 1610);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 20);
            this.label13.TabIndex = 141;
            this.label13.Text = "X-Zoom Action";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox4.Location = new System.Drawing.Point(37, 1583);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(127, 24);
            this.checkBox4.TabIndex = 138;
            this.checkBox4.Text = "Enable Panning";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(35, 1550);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 30);
            this.label2.TabIndex = 139;
            this.label2.Text = "Panning";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 584);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(619, 620);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zooming and Scrolling";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
                this.chartControl1.ResetOnDoubleClick = true;
            else
                this.chartControl1.ResetOnDoubleClick = false;
        }
        #endregion

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.SetBoxItems();
            InitializeChartData();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            this.chartControl1.Dock = DockStyle.Fill;

        }
        #endregion

        #region Helper Methods
        #region InitializeChartData
        private ChartDataBindModel model;
        private ChartDataBindModel model1;
        protected void InitializeChartData()
        {

            string fileName = WinFormsUtils.FindFile(@"..\..\..\..\Common\Data\Chart", "ChartTemperatureAnomaly.xls");

            //The Oledbconnection.
			OleDbConnection excelConn;
#if NETCORE
            excelConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties=\"Excel 12.0;HDR=Yes;\"");
#else
            excelConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended Properties=\"Excel 8.0;HDR=Yes;\"");
#endif
			
            excelConn.Open();
            //Query for retriving the data from the excel sheet.
            string query = "Select * From [Sheet1$A1:C159]";
            OleDbCommand excelCommand = new OleDbCommand(query, excelConn);
            OleDbDataReader excelReader = excelCommand.ExecuteReader(CommandBehavior.CloseConnection);

            //Load the contents to a dataset.
            DataSet excelDataSet = ConvertToDataSet(excelReader, "ExcelTable");

            //Initializes new chart series. 
            ChartSeries series1 = new ChartSeries();
            series1.Name = "Anomaly";
            series1.Text = "Anomaly";
            series1.Type = ChartSeriesType.Spline;
            model1 = new ChartDataBindModel(excelDataSet, "ExcelTable");
            model1.XName = "X Value";
            model1.YNames = new string[] { "Y Value" };
            series1.SeriesModel = model1;
            this.chartControl1.Series.Add(series1);

            //Initializes new chart series.
            ChartSeries series2 = new ChartSeries();
            series2.Name = "Smoothed";
            series2.Text = "Smoothed";
            series2.Type = ChartSeriesType.SplineArea;
            model = new ChartDataBindModel(excelDataSet, "ExcelTable");
            model.XName = "X Value";
            model.YNames = new string[] { "Z Value" };
            series2.SeriesModel = model;
            this.chartControl1.Series.Add(series2);

            //Close the connection.
            excelReader.Close();
            excelConn.Close();

            this.comboBox7.SelectedIndex = 0;
            this.comboBox8.SelectedIndex = 0;
            this.comboBox7.Enabled = false;
            this.comboBox8.Enabled = false;
        }
        #endregion

        #region ConvertToDataSet
        /// <summary>
        /// Converts DataReader to DataSet.
        /// </summary>
        /// <param name="myReader"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        protected DataSet ConvertToDataSet(OleDbDataReader dataReader, string tableName)
        {
            DataSet dataSet = new DataSet();
            do
            {
                // Create new data table

                DataTable schemaTable = dataReader.GetSchemaTable();
                DataTable dataTable = new DataTable(tableName);

                if (schemaTable != null)
                {
                    // A query returning records was executed

                    for (int i = 0; i < schemaTable.Rows.Count; i++)
                    {
                        DataRow dataRow = schemaTable.Rows[i];
                        // Create a column name that is unique in the data table
                        string columnName = (string)dataRow["ColumnName"];
                        // Add the column definition to the data table
                        DataColumn column = new DataColumn(columnName, (Type)dataRow["DataType"]);
                        dataTable.Columns.Add(column);
                    }

                    //Add the data table to the dataset.
                    dataSet.Tables.Add(dataTable);

                    // Fill the data table.
                    while (dataReader.Read())
                    {
                        DataRow dataRow = dataTable.NewRow();

                        for (int i = 0; i < dataReader.FieldCount; i++)
                            dataRow[i] = dataReader.GetValue(i);

                        dataTable.Rows.Add(dataRow);
                    }
                }
                else
                {
                    // No records were returned.

                    DataColumn column = new DataColumn("RowsAffected");
                    dataTable.Columns.Add(column);
                    dataSet.Tables.Add(dataTable);
                    DataRow dataRow = dataTable.NewRow();
                    dataRow[0] = dataReader.RecordsAffected;
                    dataTable.Rows.Add(dataRow);
                }
            }
            while (dataReader.NextResult());
            return dataSet;
        }
        #endregion

        #region SetBoxItems
        private void SetBoxItems()
        {
            this.ComboZoomIn.Items.Add("+");
            this.ComboZoomIn.Items.Add(Keys.A);
            this.ComboZoomIn.Items.Add(Keys.P);
            this.ComboZoomOut.Items.Add("-");
            this.ComboZoomOut.Items.Add(Keys.B);
            this.ComboZoomOut.Items.Add(Keys.O);
            this.ComboScrollRight.Items.Add(Keys.Right);
            this.ComboScrollRight.Items.Add(Keys.NumPad6);
            this.ComboScrollRight.Items.Add(Keys.R);
            this.ComboScrollLeft.Items.Add(Keys.Left);
            this.ComboScrollLeft.Items.Add(Keys.NumPad4);
            this.ComboScrollLeft.Items.Add(Keys.L);
            this.ComboScrollUp.Items.Add(Keys.Up);
            this.ComboScrollUp.Items.Add(Keys.NumPad8);
            this.ComboScrollUp.Items.Add(Keys.F10);
            this.ComboScrollDown.Items.Add(Keys.Down);
            this.ComboScrollDown.Items.Add(Keys.NumPad2);
            this.ComboScrollDown.Items.Add(Keys.F4);
            this.chartControl1.ZoomCancel = Keys.Escape;

            foreach (string dashtype in Enum.GetNames(typeof(System.Drawing.Drawing2D.DashStyle)))
                this.comboBox2.Items.Add(dashtype);
            this.comboBox2.SelectedIndex = 0;

            foreach (string gradient in Enum.GetNames(typeof(Syncfusion.Drawing.GradientStyle)))
                this.comboBox3.Items.Add(gradient);

            this.comboBox3.SelectedIndex = 1;
            this.comboBox4.SelectedIndex = 6;
            this.comboBox1.SelectedIndex = 0;
            this.ComboZoomIn.SelectedIndex = 0;
            this.ComboZoomOut.SelectedIndex = 0;
            this.ComboScrollRight.SelectedIndex = 0;
            this.ComboScrollLeft.SelectedIndex = 0;
            this.ComboScrollUp.SelectedIndex = 0;
            this.ComboScrollDown.SelectedIndex = 0;
            this.comboBox5.SelectedIndex = 9;
            this.comboBox6.SelectedIndex = 9;
        }
        #endregion
        #endregion

        #region Events

        private void ComboZoomIn_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Focus();
            string select1 = this.ComboZoomIn.SelectedItem.ToString();
            switch (select1)
            {
                case "+":
                    this.chartControl1.ZoomIn = Keys.Oemplus;
                    break;

                case "A":
                    this.chartControl1.ZoomIn = Keys.A;
                    break;

                case "P":
                    this.chartControl1.ZoomIn = Keys.P;
                    break;

                default:
                    this.chartControl1.ZoomIn = Keys.Oemplus;
                    break;
            }
            this.chartControl1.Redraw(true);
        }

        private void ComboZoomOut_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Focus();
            string select1 = this.ComboZoomOut.SelectedItem.ToString();

            switch (select1)
            {
                case "-":
                    this.chartControl1.ZoomOut = Keys.OemMinus;
                    break;

                case "B":
                    this.chartControl1.ZoomOut = Keys.B;
                    break;

                case "O":
                    this.chartControl1.ZoomOut = Keys.O;
                    break;

                default:
                    this.chartControl1.ZoomOut = Keys.OemMinus;
                    break;
            }

            this.chartControl1.Redraw(true);
        }

        private void ComboScrollRight_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Focus();
            string select1 = this.ComboScrollRight.SelectedItem.ToString();

            switch (select1)
            {
                case "Right":
                    this.chartControl1.ZoomRight = Keys.Right;
                    break;

                case "NumPad6":
                    this.chartControl1.ZoomRight = Keys.NumPad6;
                    break;

                case "R":
                    this.chartControl1.ZoomRight = Keys.R;
                    break;

                default:
                    this.chartControl1.ZoomRight = Keys.Right;
                    break;
            }
            this.chartControl1.Redraw(true);
        }

        private void ComboScrollLeft_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Focus();
            string select1 = this.ComboScrollLeft.SelectedItem.ToString();

            switch (select1)
            {
                case "Left":
                    this.chartControl1.ZoomLeft = Keys.Left;
                    break;

                case "NumPad4":
                    this.chartControl1.ZoomLeft = Keys.NumPad4;
                    break;

                case "L":
                    this.chartControl1.ZoomLeft = Keys.L;
                    break;

                default:
                    this.chartControl1.ZoomLeft = Keys.Left;
                    break;
            }
            this.chartControl1.Redraw(true);
        }

        private void ComboScrollUp_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Focus();
            string select1 = this.ComboScrollUp.SelectedItem.ToString();

            switch (select1)
            {
                case "Up":
                    this.chartControl1.ZoomUp = Keys.Up;
                    break;

                case "NumPad8":
                    this.chartControl1.ZoomUp = Keys.NumPad8;
                    break;

                case "F10":
                    this.chartControl1.ZoomUp = Keys.F10;
                    break;

                default:
                    this.chartControl1.ZoomUp = Keys.Up;
                    break;
            }
            this.chartControl1.Redraw(true);
        }

        private void ComboScrollDown_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Focus();
            string select1 = this.ComboScrollDown.SelectedItem.ToString();

            switch (select1)
            {
                case "Down":
                    this.chartControl1.ZoomDown = Keys.Down;
                    break;

                case "NumPad2":
                    this.chartControl1.ZoomDown = Keys.NumPad2;
                    break;

                case "F4":
                    this.chartControl1.ZoomDown = Keys.F4;
                    break;

                default:
                    this.chartControl1.ZoomDown = Keys.Down;
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.Zooming.Border.Width = (float)Convert.ToDouble(comboBox1.SelectedItem,CultureInfo.InvariantCulture);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.Zooming.Border.DashStyle = (System.Drawing.Drawing2D.DashStyle)Enum.Parse(typeof(System.Drawing.Drawing2D.DashStyle), this.comboBox2.SelectedItem.ToString(), true);
        }




        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            forecolor = this.colorPickerButton1.SelectedColor;
            backcolor = this.colorPickerButton4.SelectedColor;
            this.chartControl1.Zooming.Interior = new BrushInfo((GradientStyle)Enum.Parse(typeof(GradientStyle), this.comboBox3.SelectedItem.ToString(), true), forecolor, backcolor);
        }



        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.Zooming.Opacity = (float)Convert.ToDouble(comboBox4.SelectedItem,CultureInfo.InvariantCulture);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                this.chartControl1.Zooming.ShowBorder = true;
                this.comboBox1.Enabled = true;
                this.comboBox2.Enabled = true;
                this.colorPickerButton1.Enabled = true;
            }
            else if (checkBox1.Checked == false)
            {
                this.chartControl1.Zooming.ShowBorder = false;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = false;
                this.colorPickerButton1.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                this.chartControl1.ShowScrollBars = false;
            }
            else
            {
                this.chartControl1.ShowScrollBars = true;
            }
        }




        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.chartControl1.ShowScrollBars = true;
            }
            else
            {
                this.chartControl1.ShowScrollBars = false;
            }

            this.chartControl1.ZoomFactorX = Convert.ToDouble(this.comboBox5.SelectedItem,CultureInfo.InvariantCulture);

        }
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.chartControl1.ShowScrollBars = true;
            }
            else
            {
                this.chartControl1.ShowScrollBars = false;
            }

            this.chartControl1.ZoomFactorY = Convert.ToDouble(this.comboBox6.SelectedItem,CultureInfo.InvariantCulture);
        }


        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                this.chartControl1.ShowScrollBars = false;
            }
            else
            {
                this.chartControl1.ShowScrollBars = true;
            }
        }
        #region Show/Hide Zoom Button
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked)
            {
                this.chartControl1.GetVScrollBar(this.chartControl1.PrimaryYAxis).ZoomButton.Size = new Size(14, 14);
                this.chartControl1.GetHScrollBar(this.chartControl1.PrimaryXAxis).ZoomButton.Size = new Size(14, 14);
                this.chartControl1.Redraw(true);
            }
            else
            {
                this.chartControl1.GetVScrollBar(this.chartControl1.PrimaryYAxis).ZoomButton.Size = new Size(0, 0);
                this.chartControl1.GetHScrollBar(this.chartControl1.PrimaryXAxis).ZoomButton.Size = new Size(0, 0);
                this.chartControl1.Redraw(true);
            }

        }
        #endregion

        private void colorPickerButton_ColorSelected(object sender, EventArgs e)
        {
            this.chartControl1.Zooming.Border.ForeColor = this.colorPickerButton.SelectedColor;
           
        }

        private void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            forecolor = this.colorPickerButton1.SelectedColor;
            this.chartControl1.Zooming.Interior = new BrushInfo((GradientStyle)Enum.Parse(typeof(GradientStyle), this.comboBox3.SelectedItem.ToString(), true), forecolor, backcolor);
           
        }

        private void colorPickerButton4_ColorSelected(object sender, EventArgs e)
        {
            backcolor = this.colorPickerButton4.SelectedColor;
            this.chartControl1.Zooming.Interior = new BrushInfo((GradientStyle)Enum.Parse(typeof(GradientStyle), this.comboBox3.SelectedItem.ToString(), true), forecolor, backcolor);
           
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                this.chartControl1.MouseAction = ChartMouseAction.Panning;
                this.comboBox7.Enabled = true;
                this.comboBox8.Enabled = true;
            }
            else
            {
                this.chartControl1.MouseAction = ChartMouseAction.Zooming;
                this.comboBox7.Enabled = false;
                this.comboBox8.Enabled = false;
            }

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryXAxis.ZoomActions = (ChartZoomingAction)Enum.Parse(typeof(ChartZoomingAction), this.comboBox7.SelectedItem.ToString(), true);

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryYAxis.ZoomActions = (ChartZoomingAction)Enum.Parse(typeof(ChartZoomingAction), this.comboBox8.SelectedItem.ToString(), true);
        }
        #endregion


        private void checkbox_changed(object sender, EventArgs e)
        {

            bool flag = false;
            CheckBox[] box = new CheckBox[3];
            box[0] = checkBox5;
            box[1] = checkBox6;
            box[2] = checkBox7;
            if (box[0].Checked)
            {
                if (flag)
                    this.chartControl1.ZoomType = this.chartControl1.ZoomType | ZoomType.Selection;
                else
                {
                    flag = true;
                    this.chartControl1.ZoomType = ZoomType.Selection;
                }
            }
            if (box[1].Checked)
            {
                if (flag)
                    this.chartControl1.ZoomType = this.chartControl1.ZoomType | ZoomType.PinchZooming;
                else
                {
                    flag = true;
                    this.chartControl1.ZoomType = ZoomType.PinchZooming;
                }
            }


            if (box[2].Checked)
            {
                if (flag)
                    this.chartControl1.ZoomType = this.chartControl1.ZoomType | ZoomType.MouseWheelZooming;
                else
                {
                    flag = true;
                    this.chartControl1.ZoomType = ZoomType.MouseWheelZooming;
                }
            }

        }

        
    }
	/// <summary>
	/// Represents a class that is used to find the licensing file for Syncfusion controls.
	/// </summary>
	internal class DemoCommon
	{

		/// <summary>
		/// Finds the license key from the Common folder.
		/// </summary>
		/// <returns>Returns the license key.</returns>
		public static string FindLicenseKey()
		{
			string licenseKeyFile = "..\\Common\\SyncfusionLicense.txt";
			for (int n = 0; n < 20; n++)
			{
				if (!System.IO.File.Exists(licenseKeyFile))
				{
					licenseKeyFile = @"..\" + licenseKeyFile;
					continue;
				}
				return System.IO.File.ReadAllText(licenseKeyFile);
			}
			return string.Empty;
		}
	}
}