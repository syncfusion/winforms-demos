#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using SalesAnalysisDemo;
using System.Collections.ObjectModel;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Grid;
using System.Collections;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms.Maps;
using Syncfusion.XlsIO;
using Syncfusion.GridHelperClasses;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Parsing;
using System.IO;
using Syncfusion.Pdf.Tables;
using SalesAnalysis.Properties;
using System.Drawing.Imaging;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.DataGrid.Interactivity;
using Syncfusion.WinForms.DataGridConverter;
using System.Diagnostics;

namespace WindowsFormsApplication25
{
    public partial class MainForm : SfForm
    {
        #region [Declaration]
        ObservableCollection<SalesDetail> details = new ObservableCollection<SalesDetail>();
        SalesDetail sales = new SalesDetail();
        ObservableCollection<SalesByCountry> salesbycountry = new ObservableCollection<SalesByCountry>();
        SalesByCountry salesByCountries = new SalesByCountry();
        ObservableCollection<ProductVsCountry> productvscountry = new ObservableCollection<ProductVsCountry>();
        ProductVsCountry products = new ProductVsCountry();
        Timer openMenu = new Timer();
        Timer CloseMenu = new Timer();
        DateTime startdate, enddate;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        string fileName = null;
        string imagepath = "Resources\\";
        private const string DEFAULTPATH = @"Resources\\{0}";
        #endregion

        public MainForm()
        {
            #region[Initialization]
            InitializeComponent();
            this.panel3.Visible = true;
            this.panel4.Visible = false;
            this.rangeSlider1.TickColor = Color.White;
            details = new ObservableCollection<SalesDetail>();
            salesbycountry = new ObservableCollection<SalesByCountry>();
            SalesByCountry salesByCountrie = new SalesByCountry();
            DateTime SelectedStartDate, SelectedEndDate;
            SelectedStartDate = new DateTime(2011, 1, 7);
            SelectedEndDate = new DateTime(2011, 1, 31);
            details = SalesDetail.GenerateSalesDetails(SelectedStartDate, SelectedEndDate);
            salesbycountry = SalesDetail.GenerateTotalSalesVsTargetListByCountry(details);
            ObservableCollection<ProductVsCountry> product = new ObservableCollection<ProductVsCountry>();
            ProductVsCountry products = new ProductVsCountry();
            product = SalesDetail.GenerateProductVsCountry(details);

            #region[Grid-Initialization]
            this.sfDataGrid.DataSource = product;
            this.sfDataGrid.Columns["country"].HeaderText = "Country";
            this.sfDataGrid.Columns["continent"].HeaderText = "Continent";
            this.sfDataGrid.Columns["MarketingVsRevenue"].HeaderText = "Marketing Vs Revenue";
            this.sfDataGrid.SelectionMode = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.Single;
            this.sfDataGrid.ShowRowHeader = false;
            this.sfDataGrid.RowHeight = 30;
            this.sfDataGrid.HeaderRowHeight = 35;
            this.sfDataGrid.AllowFiltering = true;
            this.sfDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.sfDataGrid.Style.CellStyle.VerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.sfDataGrid.Style.CellStyle.HorizontalAlignment = HorizontalAlignment.Center;
            this.sfDataGrid.CellClick += sfDataGrid_CellClick;
            this.sfDataGrid.MouseWheel += SfDataGrid_MouseWheel;
            this.sfDataGrid.MouseLeave += sfDataGrid_MousLeave;
            this.sfDataGrid.SelectionChanged += sfDataGrid_SelectionChanged;
            var column = this.sfDataGrid.Columns["SalesPercent"];
            this.sfDataGrid.Columns.Remove(column);
            this.sfDataGrid.ThemeName = "Office2016Black";
            #endregion

            this.MouseClick += new MouseEventHandler(Form1_MouseClick);
            this.HelpButtonClicked += MainForm_HelpButtonClicked;
           
            this.pictureBox2.Image = Image.FromFile(imagepath + "Selected_Map.png");
            this.pictureBox1.Image = Image.FromFile(imagepath + "Normal_Grid.png");
            this.pictureBox3.Image = Image.FromFile(imagepath + "ExcelExportnormal.png");
            this.pictureBox4.Image = Image.FromFile(imagepath + "PdfExportNormal.png");
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
           
            this.pictureBox3.MouseHover += new EventHandler(pictureBox3_MouseHover);
            this.pictureBox3.MouseClick += new MouseEventHandler(pictureBox3_MouseClick);
            this.pictureBox3.MouseLeave += new EventHandler(pictureBox3_MouseLeave);
            this.pictureBox4.MouseHover += new EventHandler(pictureBox4_MouseHover);
            this.pictureBox4.MouseLeave += new EventHandler(pictureBox4_MouseLeave);
            this.pictureBox4.MouseClick += new MouseEventHandler(pictureBox4_MouseClick);
            this.rangeSlider1.ValueChanged += new EventHandler(rangeSlider1_ValueChanged);
            this.mapControl.ShapeSelected += new Maps.ShapeSelectedEventHandler(mapControl_ShapeSelected);
   
            InitializeChart();
            InitializeMap();
            this.Layout += new LayoutEventHandler(MainForm_Layout);
            #endregion
        }

        void MainForm_Layout(object sender, LayoutEventArgs e)
        {
            if (e.AffectedProperty == "Bounds")
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    using (Graphics g = this.CreateGraphics())
                    {
                        if (g.DpiX >= 120)
                        {
                            this.label1.Font = new Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
                            this.label2.Font = new Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
                            this.label3.Font = new Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
                            this.label4.Font = new Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
                            this.label5.Font = new Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
                            this.autoLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
                            this.autoLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
                            this.autoLabel3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular);
                            this.autoLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
                            this.autoLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
                            this.autoLabel6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular);
                            this.autoLabel7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular);
                            this.autoLabel8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
                            this.autoLabel9.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular);
                            this.autoLabel10.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular);
                        }
                            int padding = this.Bounds.Width / 70;
                            this.Padding = new Padding(padding, padding/4, padding, padding/4);
                            this.panel11.Dock = DockStyle.Fill;
                            this.radialGauge1.Size = new System.Drawing.Size(237, 158);
                            this.radialGauge2.Size = new System.Drawing.Size(237, 158);
                            this.radialGauge3.Size = new System.Drawing.Size(237, 158);
                            this.radialGauge4.Size = new System.Drawing.Size(237, 158);
                            this.radialGauge5.Size = new System.Drawing.Size(237, 158);
                            int Panelwidth = ((this.Bounds.Width -50) - (2 *padding)) / 5;
                            this.panel6.Size = new Size(Panelwidth , 199);
                            this.panel10.Size = new Size(Panelwidth, 199);
                            this.panel7.Size = new Size(Panelwidth , 199);
                            this.panel8.Size = new Size(Panelwidth  , 199);
                            this.panel9.Size = new Size(Panelwidth , 199);
                            this.panel6.Location = new System.Drawing.Point(6, 6);
                            this.panel7.Location = new System.Drawing.Point(panel6.Location.X + Panelwidth + 6, 6);
                            this.panel8.Location = new System.Drawing.Point(panel7.Location.X + Panelwidth + 6, 6);
                            this.panel9.Location = new System.Drawing.Point(panel8.Location.X + Panelwidth + 6, 6);
                            this.panel10.Location = new System.Drawing.Point(panel9.Location.X + Panelwidth +6, 6);
                            this.radialGauge1.Location = new Point(((this.panel6.Location.X + this.panel6.Width) - this.radialGauge1.Width) / 2, this.radialGauge1.Location.Y);
                            this.radialGauge2.Location = new Point(((this.panel6.Location.X + this.panel6.Width) - this.radialGauge1.Width) / 2, this.radialGauge2.Location.Y);
                            this.radialGauge4.Location = new Point(((this.panel6.Location.X + this.panel6.Width) - this.radialGauge1.Width) / 2, this.radialGauge4.Location.Y);
                            this.radialGauge5.Location = new Point(((this.panel6.Location.X + this.panel6.Width) - this.radialGauge1.Width) / 2, this.radialGauge5.Location.Y);
                            this.radialGauge3.Location = new Point(((this.panel6.Location.X + this.panel6.Width) - this.radialGauge1.Width) / 2, this.radialGauge3.Location.Y);
                            this.panel5.Size = new Size(this.panel10.Bounds.Right - this.panel9.Bounds.X, this.panel12.Height - this.panel5.Location.Y ); 
                            this.chartControl1.Size = new Size(this.panel5.Width - 12, this.panel5.Height - 50);
                            this.panel1.Size = new System.Drawing.Size(3 * Panelwidth + 12, this.panel12.Height - this.panel5.Location.Y -20);
                            this.panel3.Size = new System.Drawing.Size(3 * Panelwidth -18, this.panel1.Height - this.panel3.Location.Y - 18);
                            this.panel3.Location = new Point(15, this.panel3.Location.Y);
                            this.panel11.Size = this.Size;
                            this.panel12.Location = new Point(6, this.panel9.Location.Y + this.panel9.Height + 6);
                            this.rangeSlider1.Location = new Point(this.panel12.Location.X , this.Bounds.Height - 160);
                            this.rangeSlider1.BringToFront();
                            this.panel12.Size = new Size(5 * Panelwidth + 36 + 2 * padding, (this.Bounds.Height - 160) - this.panel12.Bounds.Y );
                            this.panel1.Height = this.panel5.Height =this.panel3.Height= this.panel12.Height;
                            this.panel3.Height = this.panel12.Height-this.panel3.Location.Y - padding;
                            this.chartControl1.Height = this.panel12.Height - this.chartControl1.Location.Y ;
                            this.pictureBox1.Location = new Point((panel1.Location.X + panel1.Width - 16) - (2 * pictureBox1.Width), this.panel1.Location.Y + 5);
                            this.pictureBox2.Location = new Point((panel1.Location.X + panel1.Width - 16) - ( pictureBox2.Width), this.panel1.Location.Y + 5);
                            this.panel1.Location = new System.Drawing.Point(1, 0);
                            this.panel5.Location = new System.Drawing.Point(this.panel9.Location.X -6, 0);
                            this.triangle12.Size = new Size(17, 22);
                            this.triangle13.Size = new Size(17, 22);
                            this.triangle14.Size = new Size(17, 22);
                            this.triangle15.Size = new Size(17, 22);
                            this.triangle16.Size = new Size(17, 22);
                            this.pictureBox4.Location = new Point(this.pictureBox4.Location.X, this.pictureBox3.Location.Y);
                            this.label8.Location = new Point(this.pictureBox3.Location.X + 2, this.pictureBox3.Location.Y + this.pictureBox3.Width);
                            this.label9.Location = new Point(this.pictureBox4.Location.X + 2, this.pictureBox4.Location.Y + this.pictureBox4.Width);
                            this.label1.Location = new System.Drawing.Point(((this.panel6.Location.X + this.panel6.Width) - this.label1.Width )/2, 165);
                            this.label2.Location = new System.Drawing.Point(((this.panel6.Location.X + this.panel6.Width) - this.label2.Width) / 2, 165);
                            this.label3.Location = new System.Drawing.Point(((this.panel6.Location.X + this.panel6.Width) - this.label3.Width) / 2, 165);
                            this.label4.Location = new System.Drawing.Point(((this.panel6.Location.X + this.panel6.Width) - this.label4.Width) / 2, 165);
                            this.label5.Location = new System.Drawing.Point(((this.panel6.Location.X + this.panel6.Width) - this.label5.Width) / 2, 165);
                            this.triangle12.Location = new System.Drawing.Point(this.label1.Location.X-this.triangle12.Width, 169);
                            this.triangle13.Location = new System.Drawing.Point(this.label2.Location.X - this.triangle13.Width, 169);
                            this.triangle14.Location = new System.Drawing.Point(this.label3.Location.X - this.triangle14.Width, 169);
                            this.triangle15.Location = new System.Drawing.Point(this.label4.Location.X - this.triangle15.Width, 169);
                            this.triangle16.Location = new System.Drawing.Point(this.label5.Location.X - this.triangle16.Width, 169);
                            int location = this.panel11.Bounds.Width / 12;
                            this.rangeSlider1.Size = new System.Drawing.Size(12 * location - 50, 22);
                            this.MinimumSize = this.Size;
                            int locationY = this.rangeSlider1.Location.Y + this.rangeSlider1.Height+5 ;
                            this.label11.Location = new Point(21, locationY);
                            this.label12.Location = new Point(21 + location, locationY);
                            this.label13.Location = new Point(label12.Location.X + location, locationY);
                            this.label14.Location = new Point(label13.Location.X + location, locationY);
                            this.label15.Location = new Point(label14.Location.X + location, locationY);
                            this.label16.Location = new Point(label15.Location.X + location, locationY);
                            this.label17.Location = new Point(label16.Location.X + location, locationY);
                            this.label18.Location = new Point(label17.Location.X + location, locationY);
                            this.label19.Location = new Point(label18.Location.X + location, locationY);
                            this.label20.Location = new Point(label19.Location.X + location, locationY);
                            this.label21.Location = new Point(label20.Location.X + location, locationY);
                            this.label22.Location = new Point(label21.Location.X + location, locationY);
                            this.autoLabel10.Location = new Point(this.autoLabel4.Right+5, this.autoLabel4.Bottom-this.autoLabel10.Height);
                            this.autoLabel9.Location = new Point(this.autoLabel1.Right +5, this.autoLabel1.Bottom - this.autoLabel9.Height);
                            this.autoLabel7.Location = new Point(this.autoLabel2.Right +5, this.autoLabel2.Bottom - this.autoLabel7.Height);
                            this.autoLabel6.Location = new Point(this.autoLabel8.Right +5, this.autoLabel8.Bottom - this.autoLabel6.Height);
                            this.autoLabel3.Location = new Point(this.autoLabel5.Right +5, this.autoLabel5.Bottom - this.autoLabel3.Height);
                        
                    }
                }
            }
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

        # region [ range slider ]
        void rangeSlider1_ValueChanged(object sender, EventArgs e)
        {
            InitializeChart();
            enddate = new DateTime(2014, 12, 1);
            startdate = new DateTime(2014, 11, 1);
            details = SalesDetail.GenerateSalesDetails(startdate, enddate);
            Random ran = new Random();
            float product = 0;
            float sales = 0;
            var q = (from d in details where d.ProductName == "Laptop" select new { Quantity = d.Quantity, SalesPercent = d.SalesPercent }).ToList();
            if (q.Count == 0)
            {
                product = ran.Next(10, 95);
                sales = ran.Next(100, 300);
                this.radialGauge1.Value = product;
                this.label1.Text = "$" + sales.ToString() + " ( " + product.ToString() + "" + "% )";
            }
            else
            {
                float temp = q[ran.Next(10, q.Count)].Quantity;
                product = temp / 100;
                sales = q[ran.Next(10, q.Count)].SalesPercent;
                if (product > 120)
                    product = temp % 100;
                this.radialGauge1.Value = product;
                this.label1.Text = "$" + sales.ToString() + "(" + (product.ToString()) + "% )";
            }
            var q1 = (from d in details where d.ProductName == "Desktop" select new { Quantity = d.Quantity, SalesPercent = d.SalesPercent }).ToList();
            if (q1.Count == 0)
            {
                product = ran.Next(10, 95);
                sales = ran.Next(100, 300);
                this.radialGauge2.Value = product;
                this.label2.Text = "$" + sales.ToString() + " ( " + product.ToString() + "" + "% )";
            }
            else
            {
                float temp = q1[ran.Next(10, q.Count)].Quantity;
                product = temp / 100;
                sales = q1[ran.Next(10, q.Count)].SalesPercent;
                if (product > 120)
                    product = temp % 100;

                this.radialGauge2.Value = product;
                this.label2.Text = "$" + sales.ToString() + "(" + (product.ToString()) + "% )";
            }

            var q2 = (from d in details where d.ProductName == "Smartphone" select new { Quantity = d.Quantity, SalesPercent = d.SalesPercent }).ToList();
            if (q2.Count == 0)
            {
                product = 0;
                sales = ran.Next(100, 300);
                this.radialGauge3.Value = product;
                this.label5.Text = "$" + sales.ToString() + " ( " + product.ToString() + "" + "% )";
            }
            else
            {
                float temp = q1[ran.Next(10, q.Count)].Quantity;
                product = temp / 100;
                sales = q1[ran.Next(10, q.Count)].SalesPercent;
                if (product > 120)
                    product = temp % 100;

                this.radialGauge3.Value = product;
                this.label5.Text = "$" + sales.ToString() + "(" + (product.ToString()) + "% )";
            }
            var q3 = (from d in details where d.ProductName == "Tablet" select new { Quantity = d.Quantity, SalesPercent = d.SalesPercent }).ToList();
            if (q3.Count == 0)
            {
                product = ran.Next(10, 95);
                sales = ran.Next(100, 300);
                this.radialGauge4.Value = product;
                this.label3.Text = "$" + sales.ToString() + " ( " + product.ToString() + "" + "% )";
            }
            else
            {
                float temp = q3[ran.Next(10, q.Count)].Quantity;
                product = temp / 100;
                if (product > 120)
                    product = temp % 100;
                sales = q3[ran.Next(10, q.Count)].SalesPercent;
                this.radialGauge4.Value = product;
                this.label3.Text = "$" + sales.ToString() + "(" + (product.ToString()) + "% )";
            }
            var q4 = (from d in details where d.ProductName == "Hybrid" select new { Quantity = d.Quantity, SalesPercent = d.SalesPercent }).ToList();
            if (q4.Count == 0)
            {
                product = ran.Next(10, 95);
                sales = ran.Next(100, 300);
                this.radialGauge5.Value = product;
                this.label4.Text = "$" + sales.ToString() + " ( " + product.ToString() + "" + "% )";
            }
            else
            {
                float temp = q4[ran.Next(10, q.Count)].Quantity;
                product = temp / 100;
                sales = q4[ran.Next(10, q.Count)].SalesPercent;
                if (product > 120)
                    product = temp % 100;
                this.radialGauge5.Value = product;
                this.label4.Text = "$" + sales.ToString() + "(" + (product.ToString()) + "% )";
            }

        }

        #endregion

        #region[Bar Chart]
        private void InitializeChart()
        {
            string[] labels = { "Tablet", "Desktop", "Hybrid", "Laptop", "Smartphone" };
            Color[] colors = new Color[] { Color.FromArgb(12, 128, 64), Color.FromArgb(237, 31, 36), Color.FromArgb(243, 236, 25), Color.FromArgb(126, 40, 126), Color.FromArgb(56, 83, 164) };
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

            this.chartControl1.PrimaryXAxis.ForeColor = Color.White;
            this.chartControl1.PrimaryYAxis.ForeColor = Color.White;
            this.chartControl1.PrimaryXAxis.TickLabelsDrawingMode = ChartAxisTickLabelDrawingMode.UserMode;
            ChartDataBindAxisLabelModel labelModel = new ChartDataBindAxisLabelModel(data);
            labelModel.LabelName = "Product";
            this.chartControl1.PrimaryXAxis.LabelsImpl = labelModel;
            series.PointsToolTipFormat = "Quantity:{4}";
            series.FancyToolTip.Visible = false;
            series.FancyToolTip.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.chartControl1.PrimaryXAxis.LabelRotate = false;
            this.chartControl1.PrimaryXAxis.LabelRotateAngle = 45;
            this.chartControl1.ChartInterior = new BrushInfo(Color.FromArgb(15, 15, 16));
            this.chartControl1.ShowLegend = false;
            this.chartControl1.TextAlignment = StringAlignment.Near;
            this.chartControl1.ForeColor = Color.White;
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
        #endregion

        #region [ Mousehover selection events for Grid]
        Hashtable selectionColl = new Hashtable();

        private void sfDataGrid_MousLeave(object sender, EventArgs e)
        {
            if (selectionColl != null)
            {
                selectionColl.Clear();
                this.sfDataGrid.TableControl.Refresh();
            }
        }

        private void SfDataGrid_MouseWheel(object sender, MouseEventArgs e)
        {
            if (selectionColl != null)
            {
                selectionColl.Clear();
                this.sfDataGrid.TableControl.Refresh();
            }
        }

        private void sfDataGrid_CellClick(object sender, CellClickEventArgs e)
        {
            if (e.DataRow != null && e.DataRow.RowData != null)
            {
                string country = ((SalesAnalysisDemo.ProductVsCountry)(e.DataRow.RowData)).country;
                GridMapSelected(country);
            }
            this.rangeSlider1.Visible = true;
            this.label11.Visible = true;
            this.label12.Visible = true;
            this.label13.Visible = true;
            this.label14.Visible = true;
            this.label15.Visible = true;
            this.label16.Visible = true;
            this.label17.Visible = true;
            this.label18.Visible = true;
            this.label19.Visible = true;
            this.label20.Visible = true;
            this.label21.Visible = true;
            this.label22.Visible = true;
            this.panel4.Visible = false;
        }

        private void sfDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems != null)
            {
                string country = ((SalesAnalysisDemo.ProductVsCountry)(e.AddedItems[0])).country;
                GridMapSelected(country);
            }
            this.rangeSlider1.Visible = true;
            this.label11.Visible = true;
            this.label12.Visible = true;
            this.label13.Visible = true;
            this.label14.Visible = true;
            this.label15.Visible = true;
            this.label16.Visible = true;
            this.label17.Visible = true;
            this.label18.Visible = true;
            this.label19.Visible = true;
            this.label20.Visible = true;
            this.label21.Visible = true;
            this.label22.Visible = true;
            this.panel4.Visible = false;
            
        }

        #endregion

        #region[PictureBox Hover events]
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            if (this.sfDataGrid.Visible!= true)
            {

                this.pictureBox1.Image = Image.FromFile(imagepath + "Hover grid.png");
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (this.sfDataGrid.Visible != true)
            {
                this.pictureBox1.Image = Image.FromFile(imagepath + "Normal_grid.png");
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.pictureBox2.Image = Image.FromFile(imagepath + "Normal_Map.png");
            this.pictureBox1.Image = Image.FromFile(imagepath + "Selected_Grid.png");
            this.mapControl.Visible = false;
            this.sfDataGrid.Visible = true;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            this.pictureBox2.Image = Image.FromFile(imagepath + "Selected_Map.png");
            this.pictureBox1.Image = Image.FromFile(imagepath + "Normal_Grid.png");
            this.mapControl.Visible = true;
            this.sfDataGrid.Visible = false;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            if (this.mapControl.Visible != true)
            {
                this.pictureBox2.Image = Image.FromFile(imagepath + "Hover map.png");
            }
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            if (this.mapControl.Visible != true)
            {
                this.pictureBox2.Image = Image.FromFile(imagepath + "Normal_Map.png");
            }
        }
        #endregion

        #region[Map]
        private void InitializeMap()
        {
            mapControl.MapBackgroundBrush = new SolidBrush(Color.FromArgb(15, 15, 16));
            mapControl.BackColor = Color.Black;
            mapControl.ShapeSelected += mapControl_ShapeSelected;
            ShapeFileLayer shapeLayer = new ShapeFileLayer();
            shapeLayer.ShowToolTip = true;
            shapeLayer.EnableSelection = true;
            shapeLayer.ShapeSetting.FillSetting.AutoFillColors = false;
            shapeLayer.ShapeSetting.ShapeStrokeThickness = 0;
            shapeLayer.ShapeSetting.ShapeDisplayValuePath = "Country";
            shapeLayer.ShapeSetting.ShapeFill = "#515151";
            shapeLayer.BubbleSetting.MinSize = 10;
            shapeLayer.BubbleSetting.MaxSize = 30;
            shapeLayer.BubbleSetting.Fill = "#379F64";
            shapeLayer.BubbleSetting.ValuePath = "Sales";
            shapeLayer.ShapeSetting.ShapeValuePath = "Sales";
            shapeLayer.ShapeSetting.SelectedShapeColor = "transparent";
            shapeLayer.ShapeIDPath = "Country";
            shapeLayer.ShapeIDTableField = "NAME";
            shapeLayer.ShowMapItem = false;

            shapeLayer.ItemSource = GetMapsData();
            shapeLayer.Uri = "world1.shp";
            this.mapControl.Layers.Add(shapeLayer);
        }
        private object GetMapsData()
        {
            salesbycountry = SalesDetail.GenerateTotalSalesVsTargetListByCountry(details);
            return salesbycountry.Where(x => x.Country == "Russia" || x.Country == "India" || x.Country == "Canada" || x.Country == "Brazil" || x.Country == "Japan").ToList();
        }


        void mapControl_ShapeSelected(object sender, ShapeSelectedEventArgs e)
        {
            if (e.Data.Count >0)
            {
                if (e.Data[0] is SalesByCountry)
                {
                    var country = (e.Data[0] as SalesByCountry).Country;
                    GridMapSelected(country);
                }
            }
        }
        #endregion[Map]

        #region[Grid]
        private void GridMapSelected(string country1)
        {
            float product = 0;
            float sales = 0;
            DateTime SelectedStartDate, SelectedEndDate;
            SelectedStartDate = new DateTime(2011, 1, 7);
            SelectedEndDate = new DateTime(2011, 1, 31);
            details = SalesDetail.GenerateSalesDetails(SelectedStartDate, SelectedEndDate);
            productvscountry = SalesDetail.GenerateProductVsCountry(details);
            this.InitializeChart();
            Random ran = new Random();
            var q = (from d in details where d.Country == country1 && d.ProductName == "Laptop" select new { Quantity = d.Quantity, SalesPercent = d.SalesPercent, Total = d.OrderTotal }).ToList();
            if (q.Count == 0)
            {
                product = ran.Next(10, 95);
                sales = ran.Next(100, 300);
                this.radialGauge1.Value = product;
                this.label1.Text = "$" + sales.ToString() + " ( " + product.ToString() + "" + "% )";
               
            }
            else
            {
                float temp = q[0].Quantity;
                product = temp / 100;
                sales = q[0].SalesPercent;
                this.radialGauge1.Value = product;
                this.label1.Text = "$" + sales.ToString() + " ( " + product.ToString() + "" + "% )";
               
            }

            var q1 = (from d in details where d.Country == country1 && d.ProductName == "Desktop" select new { Quantity = d.Quantity, SalesPercent = d.SalesPercent }).ToList();
            if (q1.Count == 0)
            {
                product = ran.Next(10, 95);
                sales = ran.Next(100, 300);
                this.radialGauge2.Value = product;
                this.label2.Text = "$" + sales.ToString() + " ( " + product.ToString() + "" + "% )";
            }
            else
            {
                float temp = q1[0].Quantity;
                product = temp / 100;
                sales = q1[0].SalesPercent;
                this.radialGauge2.Value = product;
                this.label2.Text = "$" + sales.ToString() + " ( " + product.ToString() + "" + "% )";
            }

            var q2 = (from d in details where d.Country == country1 && d.ProductName == "Smartphone" select new { Quantity = d.Quantity, SalesPercent = d.SalesPercent }).ToList();
            if (q2.Count == 0)
            {
                product = ran.Next(10, 95);
                sales = ran.Next(100, 300);
                this.radialGauge3.Value = product;
                this.label5.Text = "$" + sales.ToString() + " ( " + product.ToString() + "" + "% )";
            }
            else
            {
                float temp = q2[0].Quantity;
                product = temp / 100;
                sales = q2[0].SalesPercent;
                this.radialGauge2.Value = product;
                this.label2.Text = "$" + sales.ToString() + " ( " + product.ToString() + "" + "% )";
            }
            var q3 = (from d in details where d.Country == country1 && d.ProductName == "Tablet" select new { Quantity = d.Quantity, SalesPercent = d.SalesPercent }).ToList();
            if (q3.Count == 0)
            {
                product = ran.Next(10, 95);
                sales = ran.Next(100, 300);
                this.radialGauge4.Value = product;
                this.label3.Text = "$" + sales.ToString() + " ( " + product.ToString() + "" + "% )";
            }
            else
            {
                float temp = q3[0].Quantity;
                product = temp / 100;
                sales = q3[0].SalesPercent;
                this.radialGauge4.Value = product;
                this.label3.Text = "$" + sales.ToString() + " ( " + product.ToString() + "" + "% )";
            }
            var q4 = (from d in details where d.Country == country1 && d.ProductName == "Hybrid" select new { Quantity = d.Quantity, SalesPercent = d.SalesPercent }).ToList();
            if (q4.Count == 0)
            {
                product = ran.Next(10, 95);
                sales = ran.Next(100, 300);
                this.radialGauge5.Value = product;
                this.label4.Text = "$" + sales.ToString() + " ( " + product.ToString() + "" + "% )";
            }
            else
            {
                float temp = q4[0].Quantity;
                product = temp / 100;
                sales = q4[0].SalesPercent;
                this.radialGauge5.Value = product;
                this.label4.Text = "$" + sales.ToString() + " ( " + product.ToString() + "" + "% )";
            }

        }

        #endregion

        #region[Export]
        void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            #region[Pdf Export]
            PdfDocument doc = new PdfDocument();
            //Adds a page to the document.
            PdfPage page = doc.Pages.Add();
            PdfBrush brush = new PdfSolidBrush(Color.FromArgb(39, 40, 39));
            page.Graphics.DrawRectangle(brush, new RectangleF(0, 0, page.Size.Width, 40));

            //Creates Pdf graphics for the page
            PdfGraphics g = page.Graphics;

            // //Create an gauge export
            PdfBitmap image = new PdfBitmap(this.imagepath + "header text.png");


            //Laptop gauge
            Bitmap b1 = DrawPanel(panel6);
            PdfImage image1 = new PdfBitmap(b1);
            doc.Pages[0].Graphics.DrawImage(image1, new PointF(0, 50));

            //Desktop gauge
            Bitmap b2 = DrawPanel(panel7);
            PdfImage image2 = new PdfBitmap(b2);
            doc.Pages[0].Graphics.DrawImage(image2, new PointF(180, 50));

            //Tablet gauge
            Bitmap b3 = DrawPanel(panel8);
            PdfImage image3 = new PdfBitmap(b3);
            doc.Pages[0].Graphics.DrawImage(image3, new PointF(355, 50));

            //Hybrid gauge
            Bitmap b4 = DrawPanel(panel9);
            PdfImage image4 = new PdfBitmap(b4);
            doc.Pages[0].Graphics.DrawImage(image4, new PointF(0, 210));
            
            //Smartphone gauge
            Bitmap b5 = DrawPanel(panel10);
            PdfImage image5 = new PdfBitmap(b5);
            doc.Pages[0].Graphics.DrawImage(image5, new PointF(180, 210));

            ////Grid to pdf export
            GridPDFConverter pdfConvertor = new GridPDFConverter();
            pdfConvertor.ShowHeader = true;
            pdfConvertor.ShowFooter = false;
            pdfConvertor.Margins.Bottom = pdfConvertor.Margins.Top = pdfConvertor.Margins.Right = pdfConvertor.Margins.Left = 30;
            //Temp file location
            PdfDocument gridDoc = new PdfDocument();
            MemoryStream ms = new MemoryStream();
            gridDoc = this.sfDataGrid.ExportToPdf();
            gridDoc.Save(ms);
            gridDoc.Close(true);

            PdfLoadedDocument ldoc = new PdfLoadedDocument(ms);

            //Code for adding chart in PDF
            MemoryStream stream = new MemoryStream();
            var sz = this.chartControl1.Size;
            this.chartControl1.Size = new Size(600, this.chartControl1.Height);
            this.chartControl1.SaveImage(Application.StartupPath + "\\Chart.png");
            doc.Pages[0].Graphics.DrawImage(PdfImage.FromFile(Application.StartupPath + "\\Chart.png"), new PointF(0, 360));
            g.DrawImage(image, 1, 2);

           
            int i = 1;
            foreach (PdfLoadedPage lpage in ldoc.Pages)
            {                
                PdfTemplate template = lpage.CreateTemplate();
                doc.Pages.Add();
                doc.Pages[i].Graphics.DrawPdfTemplate(template, PointF.Empty);
                i++;
            }
            doc.Save("SalesAnalysis.pdf");
            if (MessageBox.Show("Do you want to view the PDF file?", "PDF File Created",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                //Launching the PDF file using the default Application.[Acrobat Reader]
#if NETCORE
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "cmd",
                    WindowStyle = ProcessWindowStyle.Hidden,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    Arguments = "/c start SalesAnalysis.pdf"
                };
                Process.Start(psi);
#else
                System.Diagnostics.Process.Start("SalesAnalysis.pdf");
#endif
            }
            else
            {
                this.rangeSlider1.Visible = true;
                this.label11.Visible = true;
                this.label12.Visible = true;
                this.label13.Visible = true;
                this.label14.Visible = true;
                this.label15.Visible = true;
                this.label16.Visible = true;
                this.label17.Visible = true;
                this.label18.Visible = true;
                this.label19.Visible = true;
                this.label20.Visible = true;
                this.label21.Visible = true;
                this.label22.Visible = true;
                this.panel4.Visible = false;
            }
            ldoc.Close(true);
            ms.Dispose();
            doc.Close(true);
            #endregion
        }
        protected void OpenFile(string filetype, string exportFileName)
        {
            try
            {
                System.Diagnostics.Process.Start(exportFileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {

            #region [Excel Export]
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Files(*.XLSX)|*.XLSX";
                saveFileDialog1.AddExtension = true;
                saveFileDialog1.DefaultExt = ".XLSX";
                
            
                if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.CheckPathExists)
                {
                    ExcelEngine engine = new ExcelEngine();
                    IApplication app = engine.Excel;
                    app.DefaultVersion = ExcelVersion.Excel2010;
                    string exportFileName = fileName + "Sales.xlsx";

                    //A new workbook with a worksheet is created.
                    IWorkbook chartBook = ExcelUtils.CreateWorkbook(1);
                  //  IWorksheet sheet = chartBook.Worksheets[0];
                   
                    Syncfusion.WinForms.DataGridConverter.ExcelExportingOptions excelExportingOptions = new Syncfusion.WinForms.DataGridConverter.ExcelExportingOptions();
                    excelExportingOptions.StartRowIndex = 2;
                    var excelEngine = sfDataGrid.ExportToExcel(sfDataGrid.View, excelExportingOptions);
                    chartBook = excelEngine.Excel.Workbooks[0];
                    // IWorksheet sheet = workBook.Worksheets[0];
                    IWorksheet sheet = chartBook.Worksheets[0];
                    sheet.InsertRow(1, 16);//(1, 6);
                    sheet.InsertColumn(1, 1);
                  
                    sheet.IsGridLinesVisible = false;
                    sheet.Range["A1"].ColumnWidth = 1;
                    sheet.Range["A2:A100"].ColumnWidth = 2;
                    sheet.Range["A14:Z14"].RowHeight = 25;

                    #region Insert Image
                    //Get the Path of the Image
                    string imagePath = @"Resources\\header text.png";
                    sheet.Pictures.AddPicture(1, 2, imagePath);
                    int row = 16 + this.sfDataGrid.RowCount;
                    sheet.Range["A1:P17"].CellStyle.Color = Color.FromArgb(39, 40, 39);
                    sheet.Range["A1:A" + row].CellStyle.Color = Color.FromArgb(39, 40, 39);
                    sheet.Range["E17:P" + row].CellStyle.Color = Color.FromArgb(39, 40, 39);
                    sheet.Range["B1:B900"].ColumnWidth = 35;
                    sheet.Range["C1:C900"].ColumnWidth = 35;
                    sheet.Range["D1:D900"].ColumnWidth = 35;
                    sheet.Range["E1:J900"].ColumnWidth = 11.66;

                    #endregion
                    int index = 17;
                    string[] labels = { "Tablet", "Desktop", "Hybrid", "Laptop", "Smartphone" };
                    for (int i = 0; i < labels.Length; i++)
                    {
                        sheet.Range[index, 10].Text = labels[i];
                        sheet.Range[index, 10].CellStyle.Font.Color = ExcelKnownColors.White;
                        index++;
                    }
                    index = 17;
                    for (int i = 1; i <= this.chartControl1.Series[0].Points.Count; i++)
                    {
                        sheet.Range[index, 12].Number = this.chartControl1.Series[0].Points[i - 1].YValues[0];
                        sheet.Range[index, 12].CellStyle.Font.Color = ExcelKnownColors.White;
                        index++;
                    }
                    IChartShape chart = sheet.Charts.Add();
                    chart.ChartTitle = "Sales By Product Category";
                    chart.ChartTitleArea.Color = ExcelKnownColors.White;

                    chart.ChartArea.Fill.ForeColor = Color.FromArgb(16, 16, 16);
                    chart.PlotArea.Fill.ForeColor = Color.FromArgb(16, 16, 16);
                    chart.HasLegend = false;
                    IChartSerie series1 = chart.Series.Add();
                    series1.SerieType = ExcelChartType.Column_Clustered;
                    series1.Values = sheet.Range["L17:L22"];
                    series1.CategoryLabels = sheet.Range["k17:K22"];
                    sheet.Charts[0].PrimaryCategoryAxis.Font.Color = ExcelKnownColors.White;
                    sheet.Charts[0].PrimaryValueAxis.Font.Color = ExcelKnownColors.White;

                    Color[] colors = new Color[] { Color.FromArgb(12, 128, 64), Color.FromArgb(237, 31, 36), Color.FromArgb(243, 236, 25), Color.FromArgb(126, 40, 126), Color.FromArgb(56, 83, 164) };

                    for (int i = 0; i < colors.Length; i++)
                        series1.DataPoints[i].DataFormat.Fill.ForeColor = colors[i];

                    chart.TopRow = 23;
                    chart.LeftColumn = 6;
                    chart.BottomRow = 36;
                    chart.RightColumn = 15;
                   //Gauge
                     Bitmap b=   DrawPanel(panel6);
                     sheet.Pictures.AddPicture(7, 2, b);
                   
                    Bitmap b1 = DrawPanel(panel7);
                    sheet.Pictures.AddPicture(7, 3, b1);
                   
                    Bitmap b2 = DrawPanel(panel8);
                    sheet.Pictures.AddPicture(7, 4, b2);

                    Bitmap b3 = DrawPanel(panel9);
                    sheet.Pictures.AddPicture(7, 5, b3);

                    Bitmap b4 = DrawPanel(panel10);
                    sheet.Pictures.AddPicture(7, 8, b4);
                   
                    //Map
                    Bitmap b5 = new Bitmap(this.mapControl.Width, this.mapControl.Height);
                    this.mapControl.DrawToBitmap(b5, new Rectangle(0, 0, b5.Width, b5.Height));
                    sheet.Pictures.AddPicture(37, 6, b5);

                    chartBook.Version = ExcelVersion.Excel2010;
                    chartBook.SaveAs(exportFileName);
                    chartBook.Close();
                    OpenFile("XLsIO", exportFileName);
#if NETCORE
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = "cmd",
                        WindowStyle = ProcessWindowStyle.Hidden,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        Arguments = "/c start "+exportFileName
                    };
                    Process.Start(psi);
#else
                    System.Diagnostics.Process.Start(exportFileName);
#endif
                }
                else
                {
                    this.rangeSlider1.Visible = true;
                    this.label11.Visible = true;
                    this.label12.Visible = true;
                    this.label13.Visible = true;
                    this.label14.Visible = true;
                    this.label15.Visible = true;
                    this.label16.Visible = true;
                    this.label17.Visible = true;
                    this.label18.Visible = true;
                    this.label19.Visible = true;
                    this.label20.Visible = true;
                    this.label21.Visible = true;
                    this.label22.Visible = true;
                    this.panel4.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            #endregion

        }

        public static Bitmap DrawPanel(Control control)
        {
            control.Update(); 
            Bitmap bmp = new Bitmap(control.Width, control.Height);
            using (Graphics gr = Graphics.FromImage(bmp))
            {
                gr.CopyFromScreen(control.PointToScreen(Point.Empty), Point.Empty, control.Size);
            }
            return bmp;
        }
        void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            this.rangeSlider1.Visible = true;
            this.label11.Visible = true;
            this.label12.Visible = true;
            this.label13.Visible = true;
            this.label14.Visible = true;
            this.label15.Visible = true;
            this.label16.Visible = true;
            this.label17.Visible = true;
            this.label18.Visible = true;
            this.label19.Visible = true;
            this.label20.Visible = true;
            this.label21.Visible = true;
            this.label22.Visible = true;
            this.panel4.Visible = false;
        }
        
        private void MainForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.rangeSlider1.Visible = false;
            this.label11.Visible = false;
            this.label12.Visible = false;
            this.label13.Visible = false;
            this.label14.Visible = false;
            this.label15.Visible = false;
            this.label16.Visible = false;
            this.label17.Visible = false;
            this.label18.Visible = false;
            this.label19.Visible = false;
            this.label20.Visible = false;
            this.label21.Visible = false;
            this.label22.Visible = false;
            this.panel11.SendToBack();
            this.panel4.Visible = true;
            this.panel4.BringToFront();
            this.panel4.Location = new Point(3, this.panel12.Location.Y + this.panel12.Height);
            this.panel4.Size = new Size(this.ClientRectangle.Width-5, this.panel4.Height);
            this.panel4.Dock = DockStyle.Bottom;
            this.openMenu.Start();
            this.Cursor = Cursors.Arrow;
        }
        
        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox3.Image = Image.FromFile(imagepath + "ExcelExporthover1.png");
        }
        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox4.Image = Image.FromFile(imagepath + "PdfExportHover1.png");
        }
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox3.Image = Image.FromFile(imagepath + "ExcelExportnormal.png");
        }
        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox4.Image = Image.FromFile(imagepath + "PdfExportNormal.png");
        }
       
        private void panel11_Click(object sender, EventArgs e)
        {
            this.rangeSlider1.Visible = true;
            this.label11.Visible = true;
            this.label12.Visible = true;
            this.label13.Visible = true;
            this.label14.Visible = true;
            this.label15.Visible = true;
            this.label16.Visible = true;
            this.label17.Visible = true;
            this.label18.Visible = true;
            this.label19.Visible = true;
            this.label20.Visible = true;
            this.label21.Visible = true;
            this.label22.Visible = true;
            this.panel4.Visible = false;

        }

        #endregion

        #region[Form Load]
        private void MainForm_Load(object sender, EventArgs e)
          {

            int screenwidth = Screen.PrimaryScreen.Bounds.Width;
            int screenheight = Screen.PrimaryScreen.Bounds.Height;
            this.panel11.Location = new Point(((screenwidth - this.panel11.Width) / 2), ((screenheight - this.panel11.Height) / 8));
         }

        #endregion
    }
}




