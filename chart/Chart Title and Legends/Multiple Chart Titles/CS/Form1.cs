#region Copyright Syncfusion Inc. 2001 - 2007
//
//  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
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
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;


namespace ChartTitle
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : MetroForm
    {
        #region Private Members
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private TextBox txtChartTitle;
        private ComboBox cmbAlignment;
        private ComboBox cmbChartTitle;
        private ComboBox comboBox_TitlesDocking;
        private Button button_Addtitle;
        Syncfusion.Windows.Forms.Chart.ChartTitle title;

        private CheckBox chkVisible;
        private Button btnDeleteTitle;
        private ToolTip toolTip1;
        private Label label13;
        private Label label2;
        private Label label1;
        private Label label4;
        private Syncfusion.Windows.Forms.Chart.ChartTitle chartTitle1;
        private Syncfusion.Windows.Forms.Chart.ChartTitle chartTitle2;
        private DesignerPanel designerPanel1;
        private Syncfusion.Windows.Forms.Tools.ImageListAdv imageListAdv1;
        private BannerTextProvider bannerTextProvider1;
        private Label label3;
        private Label label5;
        private IContainer components;
        #endregion

        #region Form Constructor, Main and Dispose
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
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo1 = new Syncfusion.Windows.Forms.BannerTextInfo();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.chartTitle1 = new Syncfusion.Windows.Forms.Chart.ChartTitle();
            this.chartTitle2 = new Syncfusion.Windows.Forms.Chart.ChartTitle();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnDeleteTitle = new System.Windows.Forms.Button();
            this.button_Addtitle = new System.Windows.Forms.Button();
            this.imageListAdv1 = new Syncfusion.Windows.Forms.Tools.ImageListAdv(this.components);
            this.bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(this.components);
            this.txtChartTitle = new System.Windows.Forms.TextBox();
            this.designerPanel1 = new DesignerPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_TitlesDocking = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkVisible = new System.Windows.Forms.CheckBox();
            this.cmbAlignment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChartTitle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.chartControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.designerPanel1)).BeginInit();
            this.designerPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, new System.Drawing.Color[] {
            System.Drawing.Color.White,
            System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(97)))), ((int)(((byte)(159))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(119)))), ((int)(((byte)(174))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(140)))), ((int)(((byte)(189))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(150)))), ((int)(((byte)(194))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(80)))), ((int)(((byte)(149)))))});
            this.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Embed;
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(1, 5, 3, 1);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.chartControl1.DataSourceName = "";
            this.chartControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.Legend.ForeColor = System.Drawing.Color.Black;
            this.chartControl1.Legend.Location = new System.Drawing.Point(66, 437);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom;
            this.chartControl1.Legend.RepresentationType = Syncfusion.Windows.Forms.Chart.ChartLegendRepresentationType.None;
            this.chartControl1.Legend.ShowBorder = true;
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            
            this.chartControl1.PrimaryXAxis.Title = "Days";
            this.chartControl1.PrimaryXAxis.LabelAlignment = StringAlignment.Center;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Title = "Efficiency";
            this.chartControl1.Size = new System.Drawing.Size(700, 547);
            this.chartControl1.TabIndex = 1;
            this.chartControl1.Text = "Efficeincy of oil-fired power production";
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl1.Title.ForeColor = System.Drawing.Color.Black;
            this.chartControl1.Title.Margin = 1;
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "Efficeincy of oil-fired power production";
            this.chartControl1.Titles.Add(this.chartTitle1);
            this.chartControl1.Titles.Add(this.chartTitle2);
            this.chartControl1.ChartFormatAxisLabel += new Syncfusion.Windows.Forms.Chart.ChartFormatAxisLabelEventHandler(this.chartControl1_ChartFormatAxisLabel);
            // 
            // chartTitle1
            // 
            this.chartTitle1.Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(78)))), ((int)(((byte)(148)))));
            this.chartTitle1.Border.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.chartTitle1.Border.PenType = System.Drawing.Drawing2D.PenType.PathGradient;
            this.chartTitle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartTitle1.ForeColor = System.Drawing.Color.Black;
            this.chartTitle1.Margin = 1;
            this.chartTitle1.Name = "chartTitle1";
            this.chartTitle1.Text = "India";
            // 
            // chartTitle2
            // 
            this.chartTitle2.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Center;
            this.chartTitle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartTitle2.ForeColor = System.Drawing.Color.Black;
            this.chartTitle2.Margin = 1;
            this.chartTitle2.Name = "chartTitle2";
            this.chartTitle2.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom;
            this.chartTitle2.Text = "Germany";
            // 
            // btnDeleteTitle
            // 
            this.btnDeleteTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnDeleteTitle.Location = new System.Drawing.Point(199, 340);
            this.btnDeleteTitle.Name = "btnDeleteTitle";
            this.btnDeleteTitle.Size = new System.Drawing.Size(29, 29);
            this.btnDeleteTitle.TabIndex = 72;
            this.btnDeleteTitle.Text = "-";
            this.toolTip1.SetToolTip(this.btnDeleteTitle, "Remove Title");
            this.btnDeleteTitle.UseVisualStyleBackColor = true;
            this.btnDeleteTitle.Click += new System.EventHandler(this.btnDeleteTitle_Click);
            // 
            // button_Addtitle
            // 
            this.button_Addtitle.Enabled = false;
            this.button_Addtitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Addtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button_Addtitle.Location = new System.Drawing.Point(199, 131);
            this.button_Addtitle.Name = "button_Addtitle";
            this.button_Addtitle.Size = new System.Drawing.Size(29, 29);
            this.button_Addtitle.TabIndex = 51;
            this.button_Addtitle.Text = "+";
            this.toolTip1.SetToolTip(this.button_Addtitle, "Add Title");
            this.button_Addtitle.UseVisualStyleBackColor = true;
            this.button_Addtitle.Click += new System.EventHandler(this.button_Addtitle_Click);
            // 
            // imageListAdv1
            // 
            this.imageListAdv1.Images.AddRange(new System.Drawing.Image[] {
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images1")))});
            // 
            // txtChartTitle
            // 
            bannerTextInfo1.Text = "Enter the text and press + button";
            bannerTextInfo1.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.txtChartTitle, bannerTextInfo1);
            this.txtChartTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChartTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.txtChartTitle.Location = new System.Drawing.Point(33, 132);
            this.txtChartTitle.Name = "txtChartTitle";
            this.txtChartTitle.Size = new System.Drawing.Size(157, 27);
            this.txtChartTitle.TabIndex = 50;
            this.txtChartTitle.TextChanged += new System.EventHandler(this.txtChartTitle_TextChanged);
            // 
            // designerPanel1
            // 
            this.designerPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.designerPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.None, new System.Drawing.Color[] {
            System.Drawing.Color.Transparent,
            System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(230)))), ((int)(((byte)(242))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(236)))), ((int)(((byte)(243))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(239)))), ((int)(((byte)(245))))),
            System.Drawing.Color.Transparent});
            this.designerPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.designerPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.designerPanel1.Controls.Add(this.label5);
            this.designerPanel1.Controls.Add(this.comboBox_TitlesDocking);
            this.designerPanel1.Controls.Add(this.label4);
            this.designerPanel1.Controls.Add(this.chkVisible);
            this.designerPanel1.Controls.Add(this.cmbAlignment);
            this.designerPanel1.Controls.Add(this.label1);
            this.designerPanel1.Controls.Add(this.btnDeleteTitle);
            this.designerPanel1.Controls.Add(this.cmbChartTitle);
            this.designerPanel1.Controls.Add(this.label2);
            this.designerPanel1.Controls.Add(this.txtChartTitle);
            this.designerPanel1.Controls.Add(this.label3);
            this.designerPanel1.Controls.Add(this.label13);
            this.designerPanel1.Controls.Add(this.button_Addtitle);
            this.designerPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.designerPanel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designerPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.designerPanel1.HeaderImage = null;
            this.designerPanel1.HeaderText = "";
            this.designerPanel1.Location = new System.Drawing.Point(706, 0);
            this.designerPanel1.Name = "designerPanel1";
            this.designerPanel1.Size = new System.Drawing.Size(248, 581);
            this.designerPanel1.TabIndex = 145;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label5.Location = new System.Drawing.Point(28, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 25);
            this.label5.TabIndex = 131;
            this.label5.Text = "Title Customization";
            // 
            // comboBox_TitlesDocking
            // 
            this.comboBox_TitlesDocking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TitlesDocking.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_TitlesDocking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox_TitlesDocking.FormattingEnabled = true;
            this.comboBox_TitlesDocking.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Top",
            "Bottom",
            "Floating"});
            this.comboBox_TitlesDocking.Location = new System.Drawing.Point(35, 267);
            this.comboBox_TitlesDocking.Name = "comboBox_TitlesDocking";
            this.comboBox_TitlesDocking.Size = new System.Drawing.Size(156, 28);
            this.comboBox_TitlesDocking.TabIndex = 52;
            this.comboBox_TitlesDocking.SelectedIndexChanged += new System.EventHandler(this.comboBox_TitlesDocking_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(32, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 129;
            this.label4.Text = "Position";
            // 
            // chkVisible
            // 
            this.chkVisible.AutoSize = true;
            this.chkVisible.Checked = true;
            this.chkVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVisible.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVisible.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.chkVisible.Location = new System.Drawing.Point(35, 70);
            this.chkVisible.Name = "chkVisible";
            this.chkVisible.Size = new System.Drawing.Size(97, 24);
            this.chkVisible.TabIndex = 59;
            this.chkVisible.Text = "Show Title";
            this.chkVisible.UseVisualStyleBackColor = true;
            this.chkVisible.CheckedChanged += new System.EventHandler(this.chkVisible_CheckedChanged);
            // 
            // cmbAlignment
            // 
            this.cmbAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlignment.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAlignment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.cmbAlignment.FormattingEnabled = true;
            this.cmbAlignment.Items.AddRange(new object[] {
            "Center",
            "Far",
            "Near"});
            this.cmbAlignment.Location = new System.Drawing.Point(34, 199);
            this.cmbAlignment.Name = "cmbAlignment";
            this.cmbAlignment.Size = new System.Drawing.Size(157, 28);
            this.cmbAlignment.TabIndex = 56;
            this.cmbAlignment.SelectedIndexChanged += new System.EventHandler(this.cmbAlignment_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(31, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 128;
            this.label1.Text = "Alignment";
            // 
            // cmbChartTitle
            // 
            this.cmbChartTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChartTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChartTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.cmbChartTitle.FormattingEnabled = true;
            this.cmbChartTitle.Location = new System.Drawing.Point(34, 341);
            this.cmbChartTitle.Name = "cmbChartTitle";
            this.cmbChartTitle.Size = new System.Drawing.Size(157, 28);
            this.cmbChartTitle.TabIndex = 53;
            this.cmbChartTitle.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(32, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 127;
            this.label2.Text = "Select Title";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(-37, -213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 781);
            this.label3.TabIndex = 130;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label13.Location = new System.Drawing.Point(31, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 20);
            this.label13.TabIndex = 126;
            this.label13.Text = "Add Title";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 581);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.designerPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(556, 543);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Title Customization";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.chartControl1.ResumeLayout(false);
            this.chartControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.designerPanel1)).EndInit();
            this.designerPanel1.ResumeLayout(false);
            this.designerPanel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            InitializeChartData();
            InitializeControlSettings();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            ResetControls();
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
        }
        #endregion

        #region Helper Methods

        #region InitializeChartData
        protected void InitializeChartData()
        {
            ChartSeries series = new ChartSeries();
            series.Name = "Series 0";
            series.Type = ChartSeriesType.Column;
            series.Text = "India";
            series.SortPoints = false;

            series.Points.Add("Monday", 70);
            series.Points.Add("Tuesday", 60);
            series.Points.Add("Wednesday", 40);
            series.Points.Add("Thursday", 40);
            series.Points.Add("Friday", 70);
            series.Points.Add("Saturday", 50);
            series.Points.Add("Sunday", 45);
            
            this.chartControl1.Series.Add(series);

            ChartSeries series1 = new ChartSeries();
            series1.Name = "Series 1";
            series1.Type = ChartSeriesType.Column;
            series1.Text = "Germany";
            series1.SortPoints = false;
            series1.Points.Add("Monday", 80);
            series1.Points.Add("Tuesday", 70);
            series1.Points.Add("Wednesday", 50);
            series1.Points.Add("Thursday", 60);
            series1.Points.Add("Friday", 60);
            series1.Points.Add("Saturday", 80);
            series1.Points.Add("Sunday", 65);
            
            this.chartControl1.Series.Add(series1);
        }
        #endregion

        #region InitializeControlSettings
        private void InitializeControlSettings()
        {
            this.chartControl1.Series[0].Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            this.chartControl1.Series[0].Style.ImageIndex = 1;
            this.chartControl1.Series[1].Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            this.chartControl1.Series[1].Style.ImageIndex = 0;

            foreach (Syncfusion.Windows.Forms.Chart.ChartTitle cTitle in this.chartControl1.Titles)
                this.cmbChartTitle.Items.Add(cTitle.Text);
            this.cmbChartTitle.SelectedIndex = 0;
        }
        #endregion

        #region ResetControls
        private void ResetControls()
        {
            this.chkVisible.Checked = this.chartControl1.Titles[this.cmbChartTitle.SelectedIndex].Visible;
            this.cmbAlignment.SelectedItem = (this.chartControl1.Titles[this.cmbChartTitle.SelectedIndex].Alignment.ToString());
            this.comboBox_TitlesDocking.SelectedItem = this.chartControl1.Titles[this.cmbChartTitle.SelectedIndex].Position.ToString();
        }
        #endregion
        #endregion

        #region Events

        # region Titles
        private void button_Addtitle_Click(object sender, EventArgs e)
        {
            if (this.comboBox_TitlesDocking.SelectedItem != null)
            {
                // Add the title to the Chart control's Titles collection.                
                title = new Syncfusion.Windows.Forms.Chart.ChartTitle();
                title.Text = this.txtChartTitle.Text;
                this.cmbChartTitle.Items.Add(this.txtChartTitle.Text);
                title.Position = (ChartDock)Enum.Parse(typeof(ChartDock), this.comboBox_TitlesDocking.SelectedItem.ToString());


                this.chartControl1.Titles.Add(title);
                this.cmbChartTitle.SelectedItem = this.txtChartTitle.Text;
                this.chartControl1.Redraw(true);
                this.txtChartTitle.Text = "";
                this.button_Addtitle.Enabled = false;
            }
            else
                MessageBox.Show("Provide full valid data...");
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Perform customization to the selected Title
            if (this.cmbAlignment.SelectedItem != null)
            {
                ResetControls();
            }
        }
        private void chkVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cmbChartTitle.SelectedIndex > 0)
            {
                this.chartControl1.Titles[this.cmbChartTitle.SelectedIndex].Visible = this.chkVisible.Checked;
            }
        }
        private void cmbAlignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbChartTitle.SelectedIndex > 0)
            {
                this.chartControl1.Titles[this.cmbChartTitle.SelectedIndex].Alignment = (ChartAlignment)Enum.Parse(typeof(ChartAlignment), this.cmbAlignment.SelectedItem.ToString());
            }
        }
        private void comboBox_TitlesDocking_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbChartTitle.SelectedIndex > 0)
            {
                this.chartControl1.Titles[this.cmbChartTitle.SelectedIndex].Position = (ChartDock)Enum.Parse(typeof(ChartDock), this.comboBox_TitlesDocking.SelectedItem.ToString());
            }
            if (this.comboBox_TitlesDocking.SelectedIndex == 4)

                this.cmbAlignment.Enabled = false;
            else
                this.cmbAlignment.Enabled = true;
        }
        private void txtChartTitle_TextChanged(object sender, EventArgs e)
        {
            if (this.txtChartTitle.Text != "")
                this.button_Addtitle.Enabled = true;
            else
                this.button_Addtitle.Enabled = false;
        }
        private void btnDeleteTitle_Click(object sender, EventArgs e)
        {
            if (this.cmbChartTitle.SelectedItem != null)
            {
                title = new Syncfusion.Windows.Forms.Chart.ChartTitle();
                title.Text = this.cmbChartTitle.SelectedItem.ToString();
                this.chartControl1.Titles.RemoveAt(this.cmbChartTitle.SelectedIndex);
                this.cmbChartTitle.Items.Remove(this.cmbChartTitle.SelectedItem.ToString());

                if (this.chartControl1.Titles.Count.ToString() != "0")
                    this.cmbChartTitle.SelectedIndex = 0;
                this.chartControl1.Refresh();
            }
        }
        # endregion

        private void chartControl1_ChartFormatAxisLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            e.Handled = true;

            if (e.AxisOrientation == ChartOrientation.Vertical)
            {
                e.Label = e.Label + "%";
            }           
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
