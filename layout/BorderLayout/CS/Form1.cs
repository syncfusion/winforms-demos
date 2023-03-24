#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorderLayout_Example
{
    public partial class Form1 : SfForm
    {
        float countryProduct = 0;
        float countrySales = 0;
        float monthProduct = 0;
        float monthSales = 0;
        float oldMonth = 0;
        float oldCountry = 0;
        int i = 0;
        int j = 0;
        Timer timer;
        public Form1()
        {
            InitializeComponent();
            InitializeChart();
          
            
            timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += new System.EventHandler(OnTimerEvent);
            timer.Start();
            i = 0;
            j = 0;
            timer.Enabled = true;
           
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
            this.MinimumSize = new Size((int)DpiAware.LogicalToDeviceUnits(900), (int)DpiAware.LogicalToDeviceUnits(700));

            this.Size = new Size((int)DpiAware.LogicalToDeviceUnits(900), (int)DpiAware.LogicalToDeviceUnits(700));

            

            this.SizeChanged += Form1_SizeChanged;
            InitializeLayout();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            InitializeLayout();
        }

        private void InitializeLayout()
        {
            int clientRatio = this.ClientRectangle.Height / 5;
            this.panelCentre.Height = this.panelEast.Height = this.panelWest.Height = clientRatio;
            this.panelChart.Height = (clientRatio * 2) - this.borderLayout1.TopMargin - this.borderLayout1.VGap;
            this.panelGauge.Height = (clientRatio * 2)-this.borderLayout1.BottomMargin-this.borderLayout1.VGap;

            this.panelGauge.Width = this.ClientRectangle.Width;
            this.panelEast.Width = this.panelWest.Width = this.panelCentre.Width = this.ClientRectangle.Width / 3;
           
            this.laptoppanel.Width = this.desktoppanel.Width = this.tabletpanel.Width = this.smartphonepanel.Width = this.panelGauge.Width / 4;
            this.laptoppanel.Height = this.desktoppanel.Height = this.tabletpanel.Height = this.smartphonepanel.Height = this.panelGauge.Height;

            this.radialGauge1.Width = this.radialGauge2.Width = this.radialGauge3.Width = this.radialGauge4.Width = this.laptoppanel.Width;

            this.radialGauge1.Height = this.laptoppanel.Height - this.lbllaptop.Height;
            this.radialGauge2.Height = this.desktoppanel.Height - this.lbldesktop.Height;
            this.radialGauge3.Height = this.smartphonepanel.Height - this.lblSmartphone.Height;
            this.radialGauge4.Height = this.tabletpanel.Height - this.lbltablet.Height;

            int gaugeCentre = radialGauge1.Width / 2;
            this.lbllaptop.Location = new Point(gaugeCentre - lbllaptop.Width/2, this.radialGauge1.Location.Y+this.radialGauge1.Height);
            this.lbldesktop.Location = new Point(gaugeCentre - lbldesktop.Width / 2, this.radialGauge2.Location.Y + this.radialGauge2.Height);
            this.lbltablet.Location = new Point(gaugeCentre - lbltablet.Width / 2, this.radialGauge4.Location.Y + this.radialGauge4.Height);
            this.lblSmartphone.Location = new Point(gaugeCentre - lblSmartphone.Width / 2, this.radialGauge3.Location.Y + this.radialGauge3.Height );

            this.laptoppanel.Location = new Point(10, 10);
            this.desktoppanel.Location = new Point(laptoppanel.Location.X+laptoppanel.Width, 10);
            this.tabletpanel.Location = new Point(desktoppanel.Location.X + desktoppanel.Width, 10);
            this.smartphonepanel.Location = new Point(tabletpanel.Location.X + tabletpanel.Width, 10);

            int panelhalf = this.panelCentre.Width / 2;
            int labelcentre = this.autoLblcountryvalue.Width / 2;
            this.autoLblcountryvalue.Location = new Point( panelhalf - labelcentre,this.autoLblcountryvalue.Location.Y);
            this.autoLblmonthvalue.Location = new Point(panelhalf - labelcentre, this.autoLblmonthvalue.Location.Y);
            this.triangle1.Location = new Point(this.autoLblmonthvalue.Location.X - 40, this.autoLblmonthvalue.Location.Y + 5);
            this.reverseTriangle1.Location = new Point(this.autoLblmonthvalue.Location.X - 40, this.autoLblmonthvalue.Location.Y + 5);
            this.triangle2.Location = new Point(this.autoLblcountryvalue.Location.X - 40, this.autoLblmonthvalue.Location.Y + 5);
            this.reverseTriangle2.Location = new Point(this.autoLblcountryvalue.Location.X - 40, this.autoLblmonthvalue.Location.Y + 5);
        }

        private void OnTimerEvent(object sender, EventArgs e)
        {
            if (i >= 12)
            {
                i = 0;
            }
            if (j >= 4)
            {
                j = 0;
            }
            string[] products = new string[]
            {
                "Laptop",
                "Desktop",
                "Tablet",
                "Smart Phone"
            };
            string[] month = new string[] {"January",
"February",
"March",
"April",
"May",
"June",
"July",
"August",
"September",
"October",
"November",
"December" };
            string[] countries = new string[] {"Argentina",
"Australia",
"Belgium",
"Canada",
"Switzerland",
"China",
"Germany",
"Spain",
"United Kingdom",
"India",
"Japan",
"Mexico" };
            Random ran = new Random();
            this.InitializeChart();
            countryProduct = ran.Next(10, 95);
            countrySales = ran.Next(100, 300);
            monthProduct = ran.Next(5, 85);
            monthSales = ran.Next(50, 280);
            if (oldMonth<monthSales)
            {
                this.panelEast.Controls.Add(this.triangle1);
                this.triangle1.Location = new Point(this.autoLblmonthvalue.Location.X - 40, this.autoLblmonthvalue.Location.Y+5);
                this.triangle1.Visible = true;
                this.reverseTriangle1.Visible = false;
            }
            else
            {
                this.panelEast.Controls.Add(this.reverseTriangle1);
                this.reverseTriangle1.Location = new Point(this.autoLblmonthvalue.Location.X - 40, this.autoLblmonthvalue.Location.Y+5);
                this.reverseTriangle1.Visible = true;
                this.triangle1.Visible = false;
            }
            if (oldCountry < countrySales)
            {
                this.panelCentre.Controls.Add(this.triangle2);
                this.triangle2.Location = new Point(this.autoLblcountryvalue.Location.X - 40, this.autoLblmonthvalue.Location.Y+5);
                this.triangle2.Visible = true;
                this.reverseTriangle2.Visible = false;
            }
            else
            {
                this.panelCentre.Controls.Add(this.reverseTriangle2);
                this.reverseTriangle2.Location = new Point(this.autoLblcountryvalue.Location.X - 40, this.autoLblmonthvalue.Location.Y+5);
                this.reverseTriangle2.Visible = true;
                this.triangle2.Visible = false;
            }
            oldMonth = monthSales;
            oldCountry = countrySales;
            this.radialGauge1.Value = ran.Next(5, 95);
            this.radialGauge2.Value = ran.Next(20, 80);
            this.radialGauge4.Value = ran.Next(10, 90);
            this.radialGauge3.Value = ran.Next(40, 120);
            autoLabelproduct.Text = products[j];
            autoLabelcountryname.Text = countries[i];
            this.autoLblcountryvalue.Text = "$" + (countrySales).ToString() + " ( " + (countryProduct).ToString() + "" + "% )";
            autoLabelmonthname.Text = month[i];
            this.autoLblmonthvalue.Text = "$" + monthSales.ToString() + " ( " + monthProduct.ToString() + "" + "% )";
            i++;
            j++;
        }

        #region Form Icon
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

        private void InitializeChart()
        {
            string[] labels = { "Laptop", "Desktop", "Tablet", "Smartphone" };
            Color[] colors = new Color[] { Color.FromArgb(252, 68, 15), Color.FromArgb(84, 199, 128), Color.FromArgb(6, 186, 248), Color.FromArgb(6, 112, 248) };
            List<Points> data = new List<Points>();
            Random r = new Random();
            for (int i = 0; i < labels.Length; i++)
                data.Add(new Points(labels[i], r.Next(1000, 10000)));


            this.chartControl1.Series.Clear();
            ChartSeries series = new ChartSeries("Series", ChartSeriesType.Column);

            ChartDataBindModel model = new ChartDataBindModel(data);
            model.YNames = new string[] { "Quantity" };
            series.SeriesModel = model;
            this.chartControl1.Series.Add(series);

            for (int i = 0; i < colors.Length; i++)
                series.Styles[i].Interior = new BrushInfo(colors[i]);
            this.chartControl1.BackColor = Color.White;
            this.chartControl1.PrimaryXAxis.ForeColor = Color.Black;
            this.chartControl1.PrimaryYAxis.ForeColor = Color.Black;
            this.chartControl1.PrimaryXAxis.TickLabelsDrawingMode = ChartAxisTickLabelDrawingMode.UserMode;
            ChartDataBindAxisLabelModel labelModel = new ChartDataBindAxisLabelModel(data);
            labelModel.LabelName = "Product";
            this.chartControl1.PrimaryXAxis.LabelsImpl = labelModel;
            series.PointsToolTipFormat = "Quantity:{4}";
            series.FancyToolTip.Visible = false;
            series.FancyToolTip.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.chartControl1.PrimaryXAxis.LabelRotate = false;
            this.chartControl1.PrimaryXAxis.LabelRotateAngle = 45;
            this.chartControl1.ChartInterior = new BrushInfo(Color.White);
            this.chartControl1.ShowLegend = false;
            this.chartControl1.TextAlignment = StringAlignment.Near;
            this.chartControl1.ForeColor = Color.Black;
            this.chartControl1.ChartToolTip = "Quantity";
        }
        

        public class Points
        {
            public string Product
            {
                get;
                set;
            }
            public double Quantity
            {
                get;
                set;
            }

            public Points(string x, double y)
            {
                this.Product = x;
                this.Quantity = y;
            }
        }

        private void lbltablet_Click(object sender, EventArgs e)
        {

        }
    }
}
