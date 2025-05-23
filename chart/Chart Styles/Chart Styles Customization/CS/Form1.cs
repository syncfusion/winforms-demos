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
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;

namespace ChartStyles
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
	{
		private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox chkSeries1;
        private System.Windows.Forms.Label label2;
		private Syncfusion.Windows.Forms.Chart.EnumEditComboBox enumEditComboBoxTextOrientation;
		private System.Windows.Forms.CheckBox chkSeries2;
        private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ComboBox cmbSymbolStyle;
		private System.Windows.Forms.RadioButton rbSymbolSeries1;
        private System.Windows.Forms.RadioButton rbSymbolSeries2;
        private Label label9;
        private Label label3;
        private CheckBox chkItalics;
        private Button btnApplySymbol;
        bool flag = false;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private Label label10;
        private NumericUpDown numericUpDown2;
        private Label label8;
		
		private System.ComponentModel.IContainer components;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkItalics = new System.Windows.Forms.CheckBox();
            this.btnApplySymbol = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chkSeries2 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSymbolStyle = new System.Windows.Forms.ComboBox();
            this.enumEditComboBoxTextOrientation = new Syncfusion.Windows.Forms.Chart.EnumEditComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbSymbolSeries2 = new System.Windows.Forms.RadioButton();
            this.chkSeries1 = new System.Windows.Forms.CheckBox();
            this.rbSymbolSeries1 = new System.Windows.Forms.RadioButton();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartArea.Watermark.TextColor = System.Drawing.SystemColors.ControlText;
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(226))))), System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(232)))), ((int)(((byte)(243))))));
            this.chartControl1.DataSourceName = "";
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 10F);
            this.chartControl1.Legend.Location = new System.Drawing.Point(58, 75);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top;
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.Size = new System.Drawing.Size(700, 578);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "chartControl1";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            // 
            // panel1
            // 
            this.panel1.Dock = DockStyle.Right;
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.chkItalics);
            this.panel1.Controls.Add(this.btnApplySymbol);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.chkSeries2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbSymbolStyle);
            this.panel1.Controls.Add(this.enumEditComboBoxTextOrientation);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rbSymbolSeries2);
            this.panel1.Controls.Add(this.chkSeries1);
            this.panel1.Controls.Add(this.rbSymbolSeries1);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(699, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 581);
            this.panel1.TabIndex = 1;
            // 
            // chkItalics
            // 
            this.chkItalics.AutoSize = true;
            this.chkItalics.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkItalics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.chkItalics.Location = new System.Drawing.Point(45, 602);
            this.chkItalics.Name = "chkItalics";
            this.chkItalics.Size = new System.Drawing.Size(94, 24);
            this.chkItalics.TabIndex = 7;
            this.chkItalics.Text = "Use Italics";
            this.chkItalics.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // btnApplySymbol
            // 
            this.btnApplySymbol.BackColor = System.Drawing.Color.Gray;
            this.btnApplySymbol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplySymbol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplySymbol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplySymbol.ForeColor = System.Drawing.Color.White;
            this.btnApplySymbol.Location = new System.Drawing.Point(43, 358);
            this.btnApplySymbol.Name = "btnApplySymbol";
            this.btnApplySymbol.Size = new System.Drawing.Size(98, 32);
            this.btnApplySymbol.TabIndex = 22;
            this.btnApplySymbol.Text = "CHANGE";
            this.btnApplySymbol.UseVisualStyleBackColor = false;
            this.btnApplySymbol.Click += new System.EventHandler(this.Symbol_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(39, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Point Text Style";
            // 
            // chkSeries2
            // 
            this.chkSeries2.Checked = true;
            this.chkSeries2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSeries2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSeries2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.chkSeries2.Location = new System.Drawing.Point(45, 504);
            this.chkSeries2.Name = "chkSeries2";
            this.chkSeries2.Size = new System.Drawing.Size(98, 24);
            this.chkSeries2.TabIndex = 4;
            this.chkSeries2.Text = "Series 2";
            this.chkSeries2.CheckedChanged += new System.EventHandler(this.Showtext_CheckedChanged);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label10.Location = new System.Drawing.Point(40, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 22);
            this.label10.TabIndex = 17;
            this.label10.Text = "Spacing Between Series";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(40, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Show Text";
            // 
            // cmbSymbolStyle
            // 
            this.cmbSymbolStyle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSymbolStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSymbolStyle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbSymbolStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSymbolStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.cmbSymbolStyle.Location = new System.Drawing.Point(44, 313);
            this.cmbSymbolStyle.Name = "cmbSymbolStyle";
            this.cmbSymbolStyle.Size = new System.Drawing.Size(172, 28);
            this.cmbSymbolStyle.TabIndex = 12;
            // 
            // enumEditComboBoxTextOrientation
            // 
            this.enumEditComboBoxTextOrientation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enumEditComboBoxTextOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enumEditComboBoxTextOrientation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.enumEditComboBoxTextOrientation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enumEditComboBoxTextOrientation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.enumEditComboBoxTextOrientation.Location = new System.Drawing.Point(44, 562);
            this.enumEditComboBoxTextOrientation.Name = "enumEditComboBoxTextOrientation";
            this.enumEditComboBoxTextOrientation.Size = new System.Drawing.Size(173, 28);
            this.enumEditComboBoxTextOrientation.TabIndex = 3;
            this.enumEditComboBoxTextOrientation.SelectedIndexChanged += new System.EventHandler(this.enumEditComboBoxTextOrientation_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label9.Location = new System.Drawing.Point(40, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Symbol";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(41, 534);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Text Orientation";
            // 
            // rbSymbolSeries2
            // 
            this.rbSymbolSeries2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rbSymbolSeries2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSymbolSeries2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.rbSymbolSeries2.Location = new System.Drawing.Point(45, 279);
            this.rbSymbolSeries2.Name = "rbSymbolSeries2";
            this.rbSymbolSeries2.Size = new System.Drawing.Size(104, 24);
            this.rbSymbolSeries2.TabIndex = 1;
            this.rbSymbolSeries2.Text = "Series 2";
            this.rbSymbolSeries2.UseVisualStyleBackColor = false;
            this.rbSymbolSeries2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // chkSeries1
            // 
            this.chkSeries1.Checked = true;
            this.chkSeries1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSeries1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSeries1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.chkSeries1.Location = new System.Drawing.Point(45, 474);
            this.chkSeries1.Name = "chkSeries1";
            this.chkSeries1.Size = new System.Drawing.Size(106, 24);
            this.chkSeries1.TabIndex = 1;
            this.chkSeries1.Text = "Series 1";
            this.chkSeries1.CheckedChanged += new System.EventHandler(this.Showtext_CheckedChanged);
            // 
            // rbSymbolSeries1
            // 
            this.rbSymbolSeries1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSymbolSeries1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.rbSymbolSeries1.Location = new System.Drawing.Point(45, 249);
            this.rbSymbolSeries1.Name = "rbSymbolSeries1";
            this.rbSymbolSeries1.Size = new System.Drawing.Size(104, 24);
            this.rbSymbolSeries1.TabIndex = 0;
            this.rbSymbolSeries1.Text = "Series 1";
            this.rbSymbolSeries1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown2.Location = new System.Drawing.Point(43, 165);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(173, 27);
            this.numericUpDown2.TabIndex = 16;
            this.numericUpDown2.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label8.Location = new System.Drawing.Point(40, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Spacing Between Points";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown1.Location = new System.Drawing.Point(43, 97);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(177, 27);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label6.Location = new System.Drawing.Point(39, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Spacing";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 581);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(705, 444);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Styles Customization";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

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
        protected void InitializeChartData()
		{
			this.chartControl1.Indexed = true;
			ChartSeries series1 = new ChartSeries(" Volvo", ChartSeriesType.Column);
			series1.Text = series1.Name;
			series1.Points.Add(2001,451);
			series1.Points.Add(2002,437);
			series1.Points.Add(2003,234);
		    series1.Style.Images = new ChartImageCollection(this.imageList1.Images);
			series1.Style.DisplayText = this.chkSeries1.Checked;
            series1.Style.Images = new ChartImageCollection(this.imageList1.Images);
            series1.PrepareStyle += new ChartPrepareStyleInfoHandler(ChartControlSeries_PrepareStyle);
            

			ChartSeries series2 = new ChartSeries(" Saab",ChartSeriesType.Column);
			series2.Text = series2.Name;
			series2.Points.Add(2001,491);
			series2.Points.Add(2002,366);
			series2.Points.Add(2003,361);		
            series2.Style.Images = new ChartImageCollection(this.imageList1.Images);                                    
			this.chartControl1.Series.Add(series1);
			this.chartControl1.Series.Add(series2);
            series1.Style.Symbol.Color = Color.Red;
			this.chartControl1.Series[0].Style.DisplayText = this.chkSeries1.Checked;
			this.chartControl1.Series[1].Style.DisplayText = this.chkSeries1.Checked;
            series1.Style.TextFormat = "{0:C}";
            series2.Style.TextFormat = "{0:C}";      
		}
	
		protected void FillControlPanel()
		{
			foreach(string symbol in Enum.GetNames(typeof(Syncfusion.Windows.Forms.Chart.ChartSymbolShape)))
				this.cmbSymbolStyle.Items.Add(symbol);
			this.cmbSymbolStyle.SelectedIndex = 6;
		}

		protected void ChangeSymbol()
		{
			if(this.rbSymbolSeries1.Checked)
			{
				if(this.cmbSymbolStyle.SelectedItem.ToString() == "Image")
				{
					this.chartControl1.Series[0].Style.Symbol.Shape = (ChartSymbolShape) Enum.Parse(typeof(ChartSymbolShape ),this.cmbSymbolStyle.SelectedItem.ToString(),true);
					this.chartControl1.Series[0].Style.Symbol.Color=Color.Red;
					this.chartControl1.Series[0].Style.Symbol.ImageIndex = 0;
				}
				else
					this.chartControl1.Series[0].Style.Symbol.Shape = (ChartSymbolShape) Enum.Parse(typeof(ChartSymbolShape ),this.cmbSymbolStyle.SelectedItem.ToString(),true);
				this.chartControl1.Series[0].Style.Symbol.Color=Color.Red;
			}
			else
			{
                if (this.cmbSymbolStyle.SelectedItem.ToString() == "Image")
                {
                    this.chartControl1.Series[1].Style.Symbol.Shape = (ChartSymbolShape)Enum.Parse(typeof(ChartSymbolShape), this.cmbSymbolStyle.SelectedItem.ToString(), true);
                    this.chartControl1.Series[1].Style.Symbol.ImageIndex = 0;
                    this.chartControl1.Series[1].Style.Symbol.Color = Color.Gray;
                }
                else                    
                    this.chartControl1.Series[1].Style.Symbol.Shape = (ChartSymbolShape) Enum.Parse(typeof(ChartSymbolShape ),this.cmbSymbolStyle.SelectedItem.ToString(),true);
				this.chartControl1.Series[1].Style.Symbol.Color=Color.Gray;
			}
		}
        		
		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.enumEditComboBoxTextOrientation.EnumType = typeof(ChartTextOrientation);
			InitializeChartData();		
            FillControlPanel();
            flag = true;
			this.rbSymbolSeries1.Checked = true;
            this.enumEditComboBoxTextOrientation.SelectedIndex = 9;
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            this.chartControl1.Dock = DockStyle.Fill;
		}

        private void enumEditComboBoxTextOrientation_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (flag)
            {
                this.chartControl1.Series[1].Style.TextOrientation = (ChartTextOrientation)enumEditComboBoxTextOrientation.SelectedEnumValue;
                this.chartControl1.Series[0].Style.TextOrientation = (ChartTextOrientation)enumEditComboBoxTextOrientation.SelectedEnumValue;
                this.chartControl1.Redraw(true);
            }
        }

        private void Showtext_CheckedChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Series[0].Style.DisplayText = chkSeries1.Checked;
            this.chartControl1.Series[1].Style.DisplayText = chkSeries2.Checked;
            this.chartControl1.Redraw(true);
        }

        protected void ChartControlSeries_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
        {
            // Style formatting using a callback. You can apply the same settings directly on the series style on the
            // point styles.
            ChartSeries series = sender as ChartSeries;
            Random rand = new Random();
            if (series != null)
            {
                if (rbSymbolSeries1.Checked)
                {
                    args.Style.Symbol.Shape = (ChartSymbolShape)Enum.Parse(typeof(ChartSymbolShape), this.cmbSymbolStyle.SelectedItem.ToString(), true);
                    args.Style.Symbol.Size = new Size(10, 10);
                }
            }
        }

		private void Symbol_CheckedChanged(object sender, System.EventArgs e)
		{
            ChangeSymbol();
            this.chartControl1.Redraw(true);
		}

		private void radioButton_CheckedChanged(object sender, System.EventArgs e)
		{            
			this.chartControl1.Redraw(true);
		}
		
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series[0].Style.Font.Italic = this.chkItalics.Checked;
            this.chartControl1.Series[1].Style.Font.Italic = this.chkItalics.Checked;            
            this.chartControl1.Redraw(true);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.SpacingBetweenPoints = Convert.ToSingle(this.numericUpDown1.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.Spacing = Convert.ToSingle(this.numericUpDown2.Value);
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
