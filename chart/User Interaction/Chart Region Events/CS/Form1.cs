#region Copyright Syncfusion Inc. 2001 - 2006
//
//  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
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

using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;

namespace Syncfusion.Windows.Forms.Chart.Samples
{
    public class Form1 : Syncfusion.Windows.Forms.MetroForm
    {
        #region Private Members
        private TextBox textBox1;
        private CheckBox chkRegionClick;
        private CheckBox chkMouseDown;
        private CheckBox chkMouseUp;
        private CheckBox chkMouseHover;
        private CheckBox chkMouseLeave;
        private CheckBox chkMouseEnter;
        private CheckBox chkMouseMove;
        private ChartControl chartControl1;
        private Label label1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        Color[] color1 = new Color[] { Color.FromArgb(132, 101, 173), Color.FromArgb(46, 238, 255), Color.FromArgb(132, 101, 173) };
        private CheckBox chkRegionDoubleClick;
        private Label label2;
        private Button button1;
        private Panel panel1;
        private ChartControl chartControl2;
        private IContainer components = null;
        #endregion

        #region Form's Constructor, Main And Dispose
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
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
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chkRegionClick = new System.Windows.Forms.CheckBox();
            this.chkMouseDown = new System.Windows.Forms.CheckBox();
            this.chkMouseUp = new System.Windows.Forms.CheckBox();
            this.chkMouseEnter = new System.Windows.Forms.CheckBox();
            this.chkMouseMove = new System.Windows.Forms.CheckBox();
            this.chkMouseLeave = new System.Windows.Forms.CheckBox();
            this.chkMouseHover = new System.Windows.Forms.CheckBox();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartControl2 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chkRegionDoubleClick = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(41, 309);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 110;
            this.label1.Text = "Log Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.textBox1.Location = new System.Drawing.Point(41, 346);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 144);
            this.textBox1.TabIndex = 2;
            // 
            // chkRegionClick
            // 
            this.chkRegionClick.AutoSize = true;
            this.chkRegionClick.Checked = true;
            this.chkRegionClick.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRegionClick.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkRegionClick.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRegionClick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.chkRegionClick.Location = new System.Drawing.Point(41, 67);
            this.chkRegionClick.Name = "chkRegionClick";
            this.chkRegionClick.Size = new System.Drawing.Size(159, 26);
            this.chkRegionClick.TabIndex = 6;
            this.chkRegionClick.Text = "ChartRegion Click";
            // 
            // chkMouseDown
            // 
            this.chkMouseDown.AutoSize = true;
            this.chkMouseDown.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkMouseDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMouseDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.chkMouseDown.Location = new System.Drawing.Point(41, 211);
            this.chkMouseDown.Name = "chkMouseDown";
            this.chkMouseDown.Size = new System.Drawing.Size(214, 26);
            this.chkMouseDown.TabIndex = 0;
            this.chkMouseDown.Text = "ChartRegion MouseDown";
            // 
            // chkMouseUp
            // 
            this.chkMouseUp.AutoSize = true;
            this.chkMouseUp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkMouseUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMouseUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.chkMouseUp.Location = new System.Drawing.Point(41, 182);
            this.chkMouseUp.Name = "chkMouseUp";
            this.chkMouseUp.Size = new System.Drawing.Size(193, 26);
            this.chkMouseUp.TabIndex = 5;
            this.chkMouseUp.Text = "ChartRegion MouseUp";
            // 
            // chkMouseEnter
            // 
            this.chkMouseEnter.AutoSize = true;
            this.chkMouseEnter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkMouseEnter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMouseEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.chkMouseEnter.Location = new System.Drawing.Point(41, 153);
            this.chkMouseEnter.Name = "chkMouseEnter";
            this.chkMouseEnter.Size = new System.Drawing.Size(209, 26);
            this.chkMouseEnter.TabIndex = 1;
            this.chkMouseEnter.Text = "ChartRegion MouseEnter";
            // 
            // chkMouseMove
            // 
            this.chkMouseMove.AutoSize = true;
            this.chkMouseMove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkMouseMove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMouseMove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.chkMouseMove.Location = new System.Drawing.Point(41, 242);
            this.chkMouseMove.Name = "chkMouseMove";
            this.chkMouseMove.Size = new System.Drawing.Size(212, 26);
            this.chkMouseMove.TabIndex = 4;
            this.chkMouseMove.Text = "ChartRegion MouseMove";
            // 
            // chkMouseLeave
            // 
            this.chkMouseLeave.AutoSize = true;
            this.chkMouseLeave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkMouseLeave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMouseLeave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.chkMouseLeave.Location = new System.Drawing.Point(41, 124);
            this.chkMouseLeave.Name = "chkMouseLeave";
            this.chkMouseLeave.Size = new System.Drawing.Size(213, 26);
            this.chkMouseLeave.TabIndex = 3;
            this.chkMouseLeave.Text = "ChartRegion MouseLeave";
            // 
            // chkMouseHover
            // 
            this.chkMouseHover.AutoSize = true;
            this.chkMouseHover.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkMouseHover.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMouseHover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.chkMouseHover.Location = new System.Drawing.Point(41, 273);
            this.chkMouseHover.Name = "chkMouseHover";
            this.chkMouseHover.Size = new System.Drawing.Size(215, 26);
            this.chkMouseHover.TabIndex = 2;
            this.chkMouseHover.Text = "ChartRegion MouseHover";
            // 
            // chartControl1
            // 
            this.chartControl1.Legend.Visible = false;
            this.chartControl1.AcceptFocus = false;
            this.chartControl1.BorderAppearance.BaseColor = System.Drawing.Color.Transparent;
            this.chartControl1.BorderAppearance.Interior.ForeColor = System.Drawing.Color.Transparent;
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.None, System.Drawing.Color.White, System.Drawing.Color.White);
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.DataSourceName = "";
            this.chartControl1.Indexed = true;
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.MinZoomFactorX = 1E-05D;
            this.chartControl1.MinZoomFactorY = 1E-05D;
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.Size = new System.Drawing.Size(700, 580);
            this.chartControl1.TabIndex = 8;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "chartControl1";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(199)))), ((int)(((byte)(165)))));
            this.chartControl1.ToolBar.ButtonBackColor = System.Drawing.SystemColors.ControlLight;
            this.chartControl1.ToolBar.ButtonForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.chartControl1.ToolBar.ButtonSize = new System.Drawing.Size(26, 26);
            this.chartControl1.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.ToolBar.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Floating;
            this.chartControl1.ZoomOutIncrement = 1.5D;
            this.chartControl1.ChartRegionClick += new Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventHandler(this.chartControl1_ChartRegionClick);
            this.chartControl1.ChartRegionDoubleClick += new Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventHandler(this.chartControl1_ChartRegionDoubleClick);
            this.chartControl1.ChartRegionMouseDown += new Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventHandler(this.chartControl1_ChartRegionMouseDown);
            this.chartControl1.ChartRegionMouseEnter += new Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventHandler(this.chartControl1_ChartRegionMouseEnter);
            this.chartControl1.ChartRegionMouseHover += new Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventHandler(this.chartControl1_ChartRegionMouseHover);
            this.chartControl1.ChartRegionMouseLeave += new Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventHandler(this.chartControl1_ChartRegionMouseLeave);
            this.chartControl1.ChartRegionMouseMove += new Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventHandler(this.chartControl1_ChartRegionMouseMove);
            this.chartControl1.ChartRegionMouseUp += new Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventHandler(this.chartControl1_ChartRegionMouseUp);
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Dock = DockStyle.Right;
            this.gradientPanel2.AutoScroll = true;
            this.gradientPanel2.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.gradientPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gradientPanel2.BorderColor = System.Drawing.Color.White;
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel2.Controls.Add(this.panel1);
            this.gradientPanel2.Controls.Add(this.button1);
            this.gradientPanel2.Controls.Add(this.label1);
            this.gradientPanel2.Controls.Add(this.label2);
            this.gradientPanel2.Controls.Add(this.textBox1);
            this.gradientPanel2.Controls.Add(this.chkRegionDoubleClick);
            this.gradientPanel2.Controls.Add(this.chkRegionClick);
            this.gradientPanel2.Controls.Add(this.chkMouseLeave);
            this.gradientPanel2.Controls.Add(this.chkMouseMove);
            this.gradientPanel2.Controls.Add(this.chkMouseHover);
            this.gradientPanel2.Controls.Add(this.chkMouseUp);
            this.gradientPanel2.Controls.Add(this.chkMouseDown);
            this.gradientPanel2.Controls.Add(this.chkMouseEnter);
            this.gradientPanel2.Location = new System.Drawing.Point(696, 0);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(264, 592);
            this.gradientPanel2.TabIndex = 114;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.chartControl2);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(52, 568);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 128);
            this.panel1.TabIndex = 113;
            // 
            // chartControl2
            // 
            this.chartControl2.AcceptFocus = false;
            this.chartControl2.Dock = DockStyle.Fill;
            this.chartControl2.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.WhiteSmoke);
            this.chartControl2.BorderAppearance.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.chartControl2.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl2.ChartArea.CursorReDraw = false;
            this.chartControl2.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl2.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl2.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(5, 1, 1, 5);
            this.chartControl2.DataSourceName = "";
            this.chartControl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.chartControl2.Indexed = true;
            this.chartControl2.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl2.Localize = null;
            this.chartControl2.Location = new System.Drawing.Point(-2, 0);
            this.chartControl2.MinZoomFactorX = 1E-05D;
            this.chartControl2.MinZoomFactorY = 1E-05D;
            this.chartControl2.Name = "chartControl2";
            this.chartControl2.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl2.PrimaryXAxis.Margin = true;
            this.chartControl2.PrimaryXAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            this.chartControl2.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl2.PrimaryYAxis.Margin = true;
            this.chartControl2.PrimaryYAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            this.chartControl2.Series3D = true;
            this.chartControl2.Size = new System.Drawing.Size(130, 128);
            this.chartControl2.Style3D = true;
            this.chartControl2.TabIndex = 111;
            // 
            // 
            // 
            this.chartControl2.Title.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl2.Title.Margin = 1;
            this.chartControl2.Title.Name = "Def_title";
            this.chartControl2.Title.Text = "";
            this.chartControl2.Titles.Add(this.chartControl2.Title);
            this.chartControl2.ToolBar.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Near;
            this.chartControl2.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.chartControl2.ToolBar.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Floating;
            this.chartControl2.ZoomOutIncrement = 1.5D;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(41, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 36);
            this.button1.TabIndex = 114;
            this.button1.Text = "CLEAR LOG";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(37, 30);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(163, 30);
            this.label2.TabIndex = 115;
            this.label2.Text = "Event";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkRegionDoubleClick
            // 
            this.chkRegionDoubleClick.AutoSize = true;
            this.chkRegionDoubleClick.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkRegionDoubleClick.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRegionDoubleClick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.chkRegionDoubleClick.Location = new System.Drawing.Point(41, 94);
            this.chkRegionDoubleClick.Name = "chkRegionDoubleClick";
            this.chkRegionDoubleClick.Size = new System.Drawing.Size(213, 26);
            this.chkRegionDoubleClick.TabIndex = 114;
            this.chkRegionDoubleClick.Text = "ChartRegion Double Click";
            this.chkRegionDoubleClick.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 584);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.gradientPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(588, 620);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Region Events";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
       
        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            InitializeChartData();            
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            ChartAppearance.ApplyChartStyles1(this.chartControl2);

            this.chartControl1.Dock = DockStyle.Fill;

        }
        #endregion

        #region Helper Methods
        
        #region InitializeChartData
        private void InitializeChartData()
        {
            ChartSeries c1series1 = new ChartSeries();
            c1series1.Type = ChartSeriesType.Column;
            c1series1.Points.Add(1, 256);
            c1series1.Points.Add(2, 491);
            c1series1.Points.Add(3, 382);
            c1series1.Points.Add(4, 437);
            this.chartControl1.Series.Add(c1series1);
            
            ChartSeries c2series1 = new ChartSeries();
            c2series1.Type = ChartSeriesType.Column;
            c2series1.Points.Add(1, 2);
            c2series1.Points.Add(2, 5);
            c2series1.Points.Add(3, 3);
            c2series1.Points.Add(4, 4);
            this.chartControl2.Series.Add(c2series1);
            this.panel1.Visible = false;
        }
        #endregion

        #region OutputText
        private void OutputText(string output)
        {
            this.textBox1.Text += output + "\r\n";
            this.textBox1.SelectionStart = this.textBox1.Text.Length - 1;
            this.textBox1.SelectionLength = 0;
            this.textBox1.ScrollToCaret();
        }
        #endregion

        #region ShowChartRegion
        protected void ShowChartRegion(string regionName)
        {
            chartControl2.Visible = true;
            this.panel1.Visible = true;
            if (regionName == "ChartArea region")
            {
                this.chartControl2.Titles[0].Text = "Chart Area";
                this.chartControl2.Series[0].Visible = false;
                this.chartControl2.ChartArea.RequireAxes = true;
                this.chartControl2.PrimaryXAxis.ValueType = ChartValueType.Custom;
                this.chartControl2.PrimaryYAxis.ValueType = ChartValueType.Custom;
                this.chartControl2.BackInterior = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.chartControl2.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.chartControl2.ChartInterior = new Syncfusion.Drawing.BrushInfo(Color.White);

            }
            else if (regionName == "Axes region")
            {
                this.chartControl2.Titles[0].Text = "Chart Axes";
                this.chartControl2.Series[0].Visible = false;
                this.chartControl2.ChartArea.RequireAxes = true;
                this.chartControl2.PrimaryXAxis.ValueType = ChartValueType.Double;
                this.chartControl2.PrimaryYAxis.ValueType = ChartValueType.Double;
                this.chartControl2.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
                this.chartControl2.PrimaryYAxis.Range = new MinMaxInfo(0, 6, 2);
                this.chartControl2.BackInterior = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.chartControl2.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.chartControl2.ChartInterior = new Syncfusion.Drawing.BrushInfo(Color.White);

            }
            else if (regionName == "ChartSeries")
            {
                this.chartControl2.Titles[0].Text = "Chart Series";
                this.chartControl2.Series[0].Visible = true;
                this.chartControl2.ChartArea.RequireAxes = false;
                this.chartControl2.BackInterior = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.chartControl2.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.chartControl2.ChartInterior = new Syncfusion.Drawing.BrushInfo(Color.White);
            }
            else
            {
                this.chartControl2.Titles[0].Text = "Chart Control";
                this.chartControl2.Series[0].Visible = false;
                this.chartControl2.ChartArea.RequireAxes = false;
                this.chartControl2.BackInterior = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.chartControl2.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.chartControl2.ChartInterior = new Syncfusion.Drawing.BrushInfo(Color.White);
            }
        }
        #endregion

        #endregion

        #region Events
        #region ChartRegionMouseDown
        private void chartControl1_ChartRegionMouseDown(object sender, Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs e)
        {
            if (this.chkMouseDown.Checked)
            {
                if (e.Region.SeriesIndex == 0)
                {
                    OutputText(String.Format("MouseDown over Series 1 Column {0} Point : {1}", e.Region.PointIndex, e.Point));
                    ShowChartRegion("ChartSeries");
                }
                else
                {
                    OutputText(String.Format("MouseDown over {0}", e.Region.Description.ToString()));
                    ShowChartRegion(e.Region.Description.ToString());
                }
            }
        }
        #endregion
        
        #region ChartRegionMouseEnter
        private void chartControl1_ChartRegionMouseEnter(object sender, Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs e)
        {
            if (this.chkMouseEnter.Checked)
            {
                if (e.Region.SeriesIndex == 0)
                {
                    OutputText(String.Format("MouseEnter over Series 1 Column {0} Point : {1}", e.Region.PointIndex, e.Point));
                    ShowChartRegion("ChartSeries");
                }
                else
                {
                    OutputText(String.Format("MouseEnter over  {0}", e.Region.Description.ToString()));
                    ShowChartRegion(e.Region.Description.ToString());
                }
            }
        }
        #endregion

        #region ChartRegionMouseHover
        private void chartControl1_ChartRegionMouseHover(object sender, Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs e)
        {
            if (this.chkMouseHover.Checked)
            {
                if (e.Region.SeriesIndex == 0)
                {
                    OutputText(String.Format("MouseHover over Series 1 Column {0} Point : {1}", e.Region.PointIndex, e.Point));
                    ShowChartRegion("ChartSeries");
                }
                else
                {
                    OutputText(String.Format("MouseHover over {0}", e.Region.Description.ToString()));
                    ShowChartRegion(e.Region.Description.ToString());
                }
            }
        }
        #endregion

        #region ChartRegionMouseLeave
        private void chartControl1_ChartRegionMouseLeave(object sender, Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs e)
        {
            if (this.chkMouseLeave.Checked)
            {
                if (e.Region.SeriesIndex == 0)
                {
                    OutputText(String.Format("MouseLeave over Series 1 Column {0} Point : {1}", e.Region.PointIndex, e.Point));
                    ShowChartRegion("ChartSeries");
                }
                else
                {
                    OutputText(String.Format("MouseLeave over {0}", e.Region.Description.ToString()));
                    ShowChartRegion(e.Region.Description.ToString());
                }
            }
        }
        #endregion

        #region ChartRegionMouseMove
        private void chartControl1_ChartRegionMouseMove(object sender, Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs e)
        {
            if (this.chkMouseMove.Checked)
            {
                if (e.Region.SeriesIndex == 0)
                {
                    OutputText(String.Format("MouseMove over Series 1 Column {0} Point : {1}", e.Region.PointIndex, e.Point));
                    ShowChartRegion("ChartSeries");
                }
                else
                {
                    OutputText(String.Format("MouseMove over {0}", e.Region.Description.ToString()));
                    ShowChartRegion(e.Region.Description.ToString());
                }
            }
        }
        #endregion

        #region ChartRegionMouseUp
        private void chartControl1_ChartRegionMouseUp(object sender, Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs e)
        {
            if (this.chkMouseUp.Checked)
            {
                if (e.Region.SeriesIndex == 0)
                {
                    OutputText(String.Format("MouseUp over Series 1 Column {0} Point : {1}", e.Region.PointIndex, e.Point));
                    ShowChartRegion("ChartSeries");
                }
                else
                {
                    OutputText(String.Format("MouseUp over {0}", e.Region.Description.ToString()));
                    ShowChartRegion(e.Region.Description.ToString());
                }
            }
        }
        #endregion

        #region ChartRegionClick
        private void chartControl1_ChartRegionClick(object sender, Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs e)
        {
            if (this.chkRegionClick.Checked)
            {
                if (e.Region.SeriesIndex == 0)
                {
                    OutputText(String.Format("Click over Series 1 Column {0} Point : {1}", e.Region.PointIndex, e.Point));
                    ShowChartRegion("ChartSeries");
                }
                else
                {
                    OutputText(String.Format("Click over {0}", e.Region.Description.ToString()));
                    ShowChartRegion(e.Region.Description.ToString());
                }

            }
        }
        #endregion

        #region ChartRegionDoubleClick
        private void chartControl1_ChartRegionDoubleClick(object sender, ChartRegionMouseEventArgs e)
        {
            if (this.chkRegionDoubleClick.Checked)
            {
                if (e.Region.SeriesIndex == 0)
                {
                    OutputText(String.Format("Double Click over Series 1 Column {0} Point : {1}", e.Region.PointIndex, e.Point));
                    ShowChartRegion("ChartSeries");
                }
                else
                {
                    OutputText(String.Format("Double Click over {0}", e.Region.Description.ToString()));
                    ShowChartRegion(e.Region.Description.ToString());
                }

            }
        }
         #endregion

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            chartControl2.Visible = false;
        }
       

        #endregion
         

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