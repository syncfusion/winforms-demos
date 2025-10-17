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
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Chart;

namespace Syncfusion.Windows.Forms.Chart.Samples
{
	public class FormMain : MetroForm
    {
        #region Private Members
        private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
        internal NumericUpDown NumericUpDown2;
        internal Label Label3;
        internal NumericUpDown NumericUpDown1;
        internal Label Label2;
		private System.ComponentModel.Container components = null;
        Color[] color1 = new Color[] { Color.FromArgb(136, 197, 242), Color.FromArgb(139, 202, 245), Color.FromArgb(115, 161, 194) };
        Color[] color2 = new Color[] { Color.FromArgb(187, 158, 212), Color.FromArgb(194, 165, 223), Color.FromArgb(165, 139, 186) };
        Color[] color3 = new Color[] { Color.FromArgb(189, 224, 94), Color.FromArgb(191, 227, 93), Color.FromArgb(160, 188, 77) };
        Color[] color4 = new Color[] { Color.FromArgb(241, 153, 103), Color.FromArgb(242, 154, 104), Color.FromArgb(206, 133, 90) };
        Color[] color5 = new Color[] { Color.FromArgb(139, 86, 49), Color.FromArgb(244, 188, 147), Color.FromArgb(139, 86, 49) };
        Color[] color6 = new Color[] { Color.FromArgb(169, 171, 149), Color.FromArgb(181, 183, 161), Color.FromArgb(154, 156, 135) };
        Color[] color7 = new Color[] { Color.FromArgb(204, 96, 134), Color.FromArgb(249, 174, 200), Color.FromArgb(204, 96, 134) };
        private ChartControl chartControl1;
        private Button button1;
        private Label label4;
        private CheckBox checkBox4;
        

        #endregion

        #region Main, Constructor and Dispose
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.EnableVisualStyles();
            Application.Run(new FormMain());
        }

        public FormMain()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.NumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.Label3 = new System.Windows.Forms.Label();
            this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = DockStyle.Right;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.NumericUpDown2);
            this.panel1.Controls.Add(this.Label3);
            this.panel1.Controls.Add(this.NumericUpDown1);
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Location = new System.Drawing.Point(701, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 581);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(-5, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 490);
            this.label4.TabIndex = 127;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(29, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 33);
            this.button1.TabIndex = 16;
            this.button1.Text = "ROTATE PIE BY 5 DEGREES";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox4.Location = new System.Drawing.Point(30, 300);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(83, 24);
            this.checkBox4.TabIndex = 15;
            this.checkBox4.Text = "3D View";
            this.checkBox4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // NumericUpDown2
            // 
            this.NumericUpDown2.DecimalPlaces = 1;
            this.NumericUpDown2.Enabled = false;
            this.NumericUpDown2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDown2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.NumericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDown2.Location = new System.Drawing.Point(29, 364);
            this.NumericUpDown2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.NumericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDown2.Name = "NumericUpDown2";
            this.NumericUpDown2.Size = new System.Drawing.Size(209, 27);
            this.NumericUpDown2.TabIndex = 14;
            this.NumericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDown2.ValueChanged += new System.EventHandler(this.NumericUpDown2_ValueChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Enabled = false;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Label3.Location = new System.Drawing.Point(25, 333);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(130, 20);
            this.Label3.TabIndex = 13;
            this.Label3.Text = "Height Coefficient";
            // 
            // NumericUpDown1
            // 
            this.NumericUpDown1.DecimalPlaces = 1;
            this.NumericUpDown1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.NumericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDown1.Location = new System.Drawing.Point(30, 260);
            this.NumericUpDown1.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            this.NumericUpDown1.Name = "NumericUpDown1";
            this.NumericUpDown1.Size = new System.Drawing.Size(208, 27);
            this.NumericUpDown1.TabIndex = 12;
            this.NumericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Label2.Location = new System.Drawing.Point(25, 231);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(149, 20);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "Doughnut coefficient";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox1.Location = new System.Drawing.Point(30, 190);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 28);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(26, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pie Style";
            // 
            // checkBox2
            // 
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox2.Location = new System.Drawing.Point(29, 73);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(118, 16);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Show Ticks";
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox1.Location = new System.Drawing.Point(30, 104);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(190, 45);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = " Optimize positions for \r\n small values";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.BackColor = System.Drawing.Color.White;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox3.Location = new System.Drawing.Point(30, 30);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(118, 26);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Explode All";
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = DockStyle.Fill;
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(193))))), System.Drawing.Color.White);
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.DataSourceName = "";
            this.chartControl1.ElementsSpacing = 0;
            this.chartControl1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.Legend.Border.ForeColor = System.Drawing.Color.Transparent;
            this.chartControl1.Legend.Location = new System.Drawing.Point(611, 45);
            this.chartControl1.Legend.FilterItems += new Syncfusion.Windows.Forms.Chart.LegendFilterItemsEventHandler(this.chartControl1_Legend_FilterItems);
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Pastel;
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.Size = new System.Drawing.Size(700, 569);
            this.chartControl1.TabIndex = 4;
            this.chartControl1.Text = "Project Cost Breakdown";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "Project Cost Breakdown";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            // 
            // FormMain
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 581);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(652, 427);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pie";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        #region Form Load
        private void FormMain_Load(object sender, System.EventArgs e)
		{
			InitializeChartData();
            FillcontrolPanel();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }
        #endregion

        #region Helper Methods
        #region InitializeChartData
        /// <summary>
		/// Initializes the ChartControl's data and sets the Chart type
		/// </summary>
		protected void InitializeChartData()
		{
			Random random = new Random();
			
			ChartSeries series1 = new ChartSeries("Market");
			series1.Points.Add(0, 20);
			series1.Points.Add(1, 28);
			series1.Points.Add(2, 23);
			series1.Points.Add(3, 10);
			series1.Points.Add(4, 12);
            series1.Points.Add(5, 3); 
		    series1.Points.Add(6, 2);          
            series1.Type = ChartSeriesType.Pie;			
			this.chartControl1.Series.Add(series1);
            series1.OptimizePiePointPositions = this.checkBox1.Checked;

            for (int i = 0; i < series1.Points.Count; i++)
                series1.Styles[i].Border.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            series1.Styles[0].Text = string.Format("Production {0}%", series1.Points[0].YValues[0]);
			series1.Styles[1].Text = string.Format("Labor {0}%", series1.Points[1].YValues[0]);
			series1.Styles[2].Text = string.Format("Facilities {0}%", series1.Points[2].YValues[0]);
			series1.Styles[3].Text = string.Format("Taxes {0}%", series1.Points[3].YValues[0]);
			series1.Styles[4].Text = string.Format("Insurance{0}%", series1.Points[4].YValues[0]);
			series1.Styles[5].Text = string.Format("Licenses {0}%", series1.Points[5].YValues[0]);
			series1.Styles[6].Text = string.Format("Legal {0}%", series1.Points[6].YValues[0]);
            series1.ConfigItems.PieItem.LabelStyle = ChartAccumulationLabelStyle.OutsideInColumn;
            series1.Style.DisplayText = true;
            series1.Style.Font.Size = 8.0f;
            series1.ConfigItems.PieItem.AngleOffset = 60;
        	
        }
        #endregion   

        #region FillControlPanel
        private void FillcontrolPanel()
        {
            foreach (string connect in Enum.GetNames(typeof(Syncfusion.Windows.Forms.Chart.ChartPieType)))
                this.comboBox1.Items.Add(connect);
            this.comboBox1.SelectedIndex = 0;
        }

        #endregion
#endregion
     
        #region Events
       
		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.chartControl1.Series[0].OptimizePiePointPositions = this.checkBox1.Checked;
		}
		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.checkBox2.Checked)
            {
                 this.chartControl1.Series[0].ShowTicks=true;
                 this.chartControl1.Series[0].Styles[0].Border.Color = Color.Black;
                 this.chartControl1.Series[0].Styles[1].Border.Color = Color.Black;
                 this.chartControl1.Series[0].Styles[2].Border.Color = Color.Black;
                 this.chartControl1.Series[0].Styles[3].Border.Color = Color.Black;
                 this.chartControl1.Series[0].Styles[4].Border.Color = Color.Black;
                 this.chartControl1.Series[0].Styles[5].Border.Color = Color.Black;
                 this.chartControl1.Series[0].Styles[6].Border.Color = Color.Black;
            }
			else
            {
                this.chartControl1.Series[0].ShowTicks = false;
                this.chartControl1.Series[0].Styles[0].Border.Color = Color.Transparent;
                this.chartControl1.Series[0].Styles[1].Border.Color = Color.Transparent;
                this.chartControl1.Series[0].Styles[2].Border.Color = Color.Transparent;
                this.chartControl1.Series[0].Styles[3].Border.Color = Color.Transparent;
                this.chartControl1.Series[0].Styles[4].Border.Color = Color.Transparent;
                this.chartControl1.Series[0].Styles[5].Border.Color = Color.Transparent;
                this.chartControl1.Series[0].Styles[6].Border.Color = Color.Transparent;
            }
				
			this.chartControl1.Redraw(true);
		}
		private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.checkBox3.Checked)
			{
				this.chartControl1.Series[0].ExplodedAll = true;
				this.chartControl1.Series[0].ExplosionOffset = 8f;
			}
			else
			{
				this.chartControl1.Series[0].ExplodedAll = false;
				this.chartControl1.Series[0].ExplosionOffset = 20f;
			}
		}      

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		this.chartControl1.Series[0].ConfigItems.PieItem.PieType = (ChartPieType) Enum.Parse(typeof(ChartPieType ),this.comboBox1.SelectedItem.ToString(),true);
        
		}

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series[0].ConfigItems.PieItem.DoughnutCoeficient = (float)NumericUpDown1.Value;
        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series[0].ConfigItems.PieItem.HeightCoeficient= (float)NumericUpDown2.Value;

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series3D = this.checkBox4.Checked;
            this.Label3.Enabled = this.checkBox4.Checked;
            this.NumericUpDown2.Enabled = this.checkBox4.Checked;
        }
              
        private void button1_Click(object sender, EventArgs e)
        {
            this.chartControl1.Series[0].ConfigItems.PieItem.AngleOffset += 5;

        }
        private void chartControl1_Legend_FilterItems(object sender, ChartLegendFilterItemsEventArgs e)
        {
            ChartSeries series = this.chartControl1.Series[0];
            for (int i = 0; i < series.Points.Count; i++)
                e.Items[i].Text = series.Points[i].YValues[0].ToString() + "%";
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