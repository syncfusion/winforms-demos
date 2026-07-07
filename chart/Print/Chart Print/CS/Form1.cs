#region Copyright Syncfusion Inc. 2001 - 2008
//
//  Copyright Syncfusion Inc. 2001 - 2008. All rights reserved.
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
using System.Drawing.Printing;

using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms;

namespace ChartPrintingSample
{
   public class Form1 : Syncfusion.Windows.Forms.MetroForm
    {
        #region Private Members
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private PrintDocument printPreviewDocument;
        private Syncfusion.Windows.Forms.ButtonAdv buttonPrint;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
        private Label label1;
        private Panel panel1;
       private CheckBox checkBox1;
       private Label label2;
       private ComboBox comboBox1;
        #endregion
       private Panel panel2;
       private ChartControl chartControl1;
       private FolderBrowserDialog folderBrowserDialog1;
       private ToolTip toolTip1;
       private IContainer components;
       
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.buttonPrint = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonPrint.BackColor = System.Drawing.Color.White;
            this.buttonPrint.BeforeTouchSize = new System.Drawing.Size(75, 75);
            this.buttonPrint.ComboEditBackColor = System.Drawing.Color.White;
            this.buttonPrint.CustomManagedColor = System.Drawing.Color.White;
            this.buttonPrint.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.ForeColor = System.Drawing.Color.White;
            this.buttonPrint.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrint.Image")));
            this.buttonPrint.IsBackStageButton = false;
            this.buttonPrint.KeepFocusRectangle = false;
            this.buttonPrint.Location = new System.Drawing.Point(155, 156);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 75);
            this.buttonPrint.TabIndex = 14;
            this.toolTip1.SetToolTip(this.buttonPrint, "Print the Chart");
            this.buttonPrint.UseVisualStyle = false;
            this.buttonPrint.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv1.BackColor = System.Drawing.Color.White;
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(75, 75);
            this.buttonAdv1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAdv1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonAdv1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonAdv1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdv1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdv1.Image")));
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.KeepFocusRectangle = false;
            this.buttonAdv1.Location = new System.Drawing.Point(44, 158);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(75, 75);
            this.buttonAdv1.TabIndex = 15;
            this.toolTip1.SetToolTip(this.buttonAdv1, "Genenates a preview before printing the Chart");
            this.buttonAdv1.UseVisualStyle = false;
            this.buttonAdv1.UseVisualStyleBackColor = false;
            this.buttonAdv1.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(958, 57);
            this.label1.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 527);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 57);
            this.panel1.TabIndex = 18;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.checkBox1.Location = new System.Drawing.Point(44, 117);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 25);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Print Toolbar";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(40, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Chart Print Color Mode";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CheckPrinter",
            "Color",
            "GrayScale"});
            this.comboBox1.Location = new System.Drawing.Point(44, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 29);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Dock = DockStyle.Right;
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.buttonAdv1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.buttonPrint);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Location = new System.Drawing.Point(689, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 584);
            this.panel2.TabIndex = 22;
            // 
            // chartControl1
            // 
            this.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Embed;
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
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
            this.chartControl1.Legend.Location = new System.Drawing.Point(70, 491);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom;
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.Size = new System.Drawing.Size(700, 580);
            this.chartControl1.TabIndex = 3;
            this.chartControl1.Text = "Essential Chart";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "Essential Chart";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ZoomOutIncrement = 0.20000000298023224D;
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipTitle = "Print";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 584);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(970, 620);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Printing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
       
        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            InitializeChartData();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            this.panel1.Visible = false;
            this.comboBox1.SelectedIndex = 1;
            this.chartControl1.ToolBar.AutoSize = false;
            this.chartControl1.ToolBar.Size = new Size(250, 30);
            this.chartControl1.Dock = DockStyle.Fill;
            this.buttonPrint.MouseMove += buttonPrint_MouseMove;
            this.buttonAdv1.MouseMove += buttonAdv1_MouseMove;
        }

        bool previewTitleSet = false;
        void buttonAdv1_MouseMove(object sender, MouseEventArgs e)
        {
            //Set tooltip title only once during mouse move
            if (!previewTitleSet)
            {
                this.toolTip1.ToolTipTitle = "Print preview";
                previewTitleSet = true;
            }
        }

        void buttonPrint_MouseMove(object sender, MouseEventArgs e)
        {
            //Set tooltip title only once during mouse move
            if (previewTitleSet)
            {
                this.toolTip1.ToolTipTitle = "Print";
                previewTitleSet = false;
            }
        }
        #endregion

        #region InitializeChartData
        protected void InitializeChartData()
        {
            ChartSeries series3 = new ChartSeries();
            series3.Name = "Server 3";
            series3.Points.Add(1, 540);
            series3.Points.Add(2, 340);
            series3.Points.Add(3, 240);
            series3.Points.Add(4, 200);

            series3.Type = ChartSeriesType.Spline;
            series3.Text = series3.Name;
           
            ChartSeries series = new ChartSeries();
            series.Name = "Server 1";
            series.Points.Add(1, 340);
            series.Points.Add(2, 240);
            series.Points.Add(3, 440);
            series.Points.Add(4, 500);

            series.Type = ChartSeriesType.Column;
            series.Text = series.Name;

            ChartSeries series2 = new ChartSeries();
            series2.Name = "Server 2";
            series2.Points.Add(1, 240);
            series2.Points.Add(2, 140);
            series2.Points.Add(3, 340);
            series2.Points.Add(4, 300);

            series2.Type = ChartSeriesType.Column;
            series2.Text = series2.Name;

            this.chartControl1.Series.Add(series);
            this.chartControl1.Series.Add(series2);            
			this.chartControl1.Series.Add(series3);

            this.chartControl1.Text = "Daily Server Network Load Comparison";
			this.chartControl1.PrimaryXAxis.Title = "Days";
            this.chartControl1.PrimaryYAxis.Title = "Server Load (MBytes)";
            this.chartControl1.PrimaryXAxis.Format = "Day 0";
            this.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.MultipleRows;
            this.chartControl1.Indexed = true;
        }
        #endregion

        #region Events
        private void button1_Click(object sender, System.EventArgs e)
        {
            printDialog1.Document = this.chartControl1.PrintDocument;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                //this.chartControl1.PrintColorMode = ChartPrintColorMode.Color;
                this.chartControl1.PrintDocument.Print();
            }
            this.panel1.Visible = false;
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            try
            {
                printPreviewDocument = this.chartControl1.PrintDocument;
                this.printPreviewDialog1.Document = printPreviewDocument;
                this.printPreviewDialog1.FormBorderStyle = FormBorderStyle.Fixed3D;
                this.printPreviewDialog1.ShowDialog();
            }
            catch (Exception exp)
            {
                this.Size = new Size(497, 509);
                this.panel1.Visible = true;
                this.label1.Text = exp.Message.ToString();
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrintDocument.PrintToolBar = this.checkBox1.Checked;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrintColorMode = (ChartPrintColorMode)Enum.Parse(typeof(ChartPrintColorMode), this.comboBox1.SelectedItem.ToString(), true);
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