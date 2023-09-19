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
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.Data;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.XlsIO;
using System.IO;
using Syncfusion.WinForms.DataGridConverter;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Tables;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms.Chart.Samples;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.GridCommon.Utility;
using System.Runtime.InteropServices;
using System.Globalization;
using Syncfusion.Windows.Forms;
using System.Diagnostics;

namespace ExpenseAnalysis
{
    public partial class MainForm : SfForm
    {
        DateTime clickStartTime = DateTime.Now.AddDays(-1);
        System.Windows.Forms.Timer clickTimer = new System.Windows.Forms.Timer();
        int pointIndex = -1;
        string imagepath = "Images\\";
        #region Constants
        private const string DEFAULTPATH = @"Images\\{0}";
        #endregion
        bool explode = true;
        bool drillDown = false;
        int currentDrilldownIndex = 0;
        ExpenseData expense = new ExpenseData();
        public MainForm()
        {
            InitializeComponent();

            Bitmap img = new Bitmap(Image.FromFile(imagepath + "ExpenseAnalysis.png"));
            this.Style.TitleBar.CaptionImage = img;
            this.Style.TitleBar.CaptionImageLocation = new Point(0, 15);
            Bitmap imge = new Bitmap(Image.FromFile(imagepath + "logo.png"));
            this.Icon = Icon.FromHandle(imge.GetHicon());
            this.IconSize = new Size(60, 60);

            #region [  Data source ]
            List<ExpenseData> list = new List<ExpenseData>();
            list = expense.GenerateExpenseData(new DateTime(2013, 1, 1), new DateTime(2013, 12, 31), 2);
            clickTimer.Tick += ClickTimer_Tick;
            clickTimer.Interval = 300;
            this.chartControl1.ChartRegionClick += chartcontrol1_ChartRegionClick;
            this.sfDataGrid1.DataSource = list;
            sfDataGrid1.View.Filter = FilterRecords;

            #endregion

            #region [SfDataGrid]

            this.sfDataGrid1.NavigationMode = Syncfusion.WinForms.DataGrid.Enums.NavigationMode.Row;
            this.sfDataGrid1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.sfDataGrid1.Style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sfDataGrid1.Columns[0].Format = "MMM dd yyyy";
            this.sfDataGrid1.Columns[0].HeaderText = "Date";
            this.sfDataGrid1.Columns[1].HeaderText = "Category";
            this.sfDataGrid1.Columns[2].HeaderText = "Sub Category";
            (this.sfDataGrid1.Columns[3] as GridNumericColumn).FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;

            this.sfDataGrid1.Columns["Amount"].CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.sfDataGrid1.Style.CellStyle.VerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.sfDataGrid1.Style.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.sfDataGrid1.Style.HeaderStyle.Font.Bold = true;
            this.sfDataGrid1.Style.HeaderStyle.Font.Size = 10f;
            this.sfDataGrid1.Columns.Move(5, 3);
            this.sfDataGrid1.Columns.Remove(this.sfDataGrid1.Columns["AccountType"]);
            this.sfDataGrid1.HeaderRowHeight =(int)DpiAware.LogicalToDeviceUnits(45);
            this.sfDataGrid1.RowHeight = (int)DpiAware.LogicalToDeviceUnits(40);
            GridTableSummaryRow tableSummaryRow1 = new GridTableSummaryRow();
            tableSummaryRow1.Name = "TableSummary";
            tableSummaryRow1.ShowSummaryInRow = true;
            tableSummaryRow1.Title = "Total Amount:  {TotalAmount}";
            tableSummaryRow1.Position = VerticalPosition.Bottom;
            GridSummaryColumn summaryColumn1 = new GridSummaryColumn();
            summaryColumn1.Name = "TotalAmount";
            summaryColumn1.SummaryType = SummaryType.DoubleAggregate;
            summaryColumn1.Format = "{Sum:c}";
            summaryColumn1.MappingName = "Amount";
            tableSummaryRow1.SummaryColumns.Add(summaryColumn1);
            this.sfDataGrid1.TableSummaryRows.Add(tableSummaryRow1);
            this.gridpanel.Paint += new PaintEventHandler(gridpanel_Paint);
           
            #endregion

            #region [  combobox ]
            List<string> months = new List<string>();
            months.Add("All");
            months.Add("January");
            months.Add("February");
            months.Add("March");
            months.Add("April");
            months.Add("May");
            months.Add("June");
            months.Add("July");
            months.Add("August");
            months.Add("September");
            months.Add("October");
            months.Add("November");
            months.Add("December");
            this.sfComboBox1.DataSource = months;
            this.sfComboBox1.SelectedIndex = 0;

            #endregion

            this.pictureBoxchart.Size = this.pictureBoxgrid.Size = new Size((int)DpiAware.LogicalToDeviceUnits(50),(int) DpiAware.LogicalToDeviceUnits(50));
            this.panelexport.Visible = true;
            this.pictureBoxexcel.MouseEnter += new EventHandler(pictureBoxexcel_MouseEnter);
            this.pictureBoxexcel.MouseLeave += new EventHandler(pictureBoxexcel_MouseLeave);
            this.pictureBoxpdf.MouseEnter += new EventHandler(pictureBoxpdf_MouseEnter);
            this.pictureBoxpdf.MouseLeave += new EventHandler(pictureBoxpdf_MouseLeave);
            this.pictureBoxgrid.MouseEnter += new EventHandler(pictureBoxgrid_MouseEnter);
            this.pictureBoxchart.MouseEnter += new EventHandler(pictureBoxchart_MouseEnter);
            this.pictureBoxgrid.MouseDown += new MouseEventHandler(pictureBoxgrid_MouseDown);
            this.pictureBoxchart.MouseDown += new MouseEventHandler(pictureBoxchart_MouseDown);
            this.pictureBoxgrid.MouseLeave += new EventHandler(pictureBoxgrid_MouseLeave);
            this.pictureBoxchart.MouseLeave += new EventHandler(pictureBoxchart_MouseLeave);
            this.pictureBoxback.MouseEnter += new EventHandler(pictureBoxback_MouseEnter);
            this.pictureBoxback.MouseLeave += new EventHandler(pictureBoxback_MouseLeave);
            this.pictureBoxexcel.MouseDown += new MouseEventHandler(pictureBoxexcel_MouseDown);
            this.pictureBoxpdf.MouseDown += new MouseEventHandler(pictureBoxpdf_MouseDown);
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.SizeChanged += MainForm_SizeChanged;
           

            ArrangeLocation();
        }

        protected override void OnLoad(EventArgs args)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            base.OnLoad(args);
        }

        #region Window Updates
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        internal static extern bool LockWindowUpdate(IntPtr hWndLock);
        #endregion
        void MainForm_SizeChanged(object sender, System.EventArgs e)
        {
            LockWindowUpdate(this.Handle);

            this.tableLayoutPanel1.Size = this.ClientRectangle.Size;
            panelexport.Width = this.ClientRectangle.Width;
            this.panel3.Width = this.ClientRectangle.Width;

            int remainingspace = this.tableLayoutPanel1.Height - panel2.Height - panel4.Height - panelexport.Height;
            this.panel3.Height = remainingspace > CharttableLayoutPanel.Height ? remainingspace : CharttableLayoutPanel.Height;
            chartControl1.Height = this.panel3.Height;
            
            if (this.tableLayoutPanel1.Width >= this.Width||this.tableLayoutPanel1.Height >=this.Height)
            {
                this.tableLayoutPanel1.AutoScroll = true;
            }
            
            LockWindowUpdate(IntPtr.Zero);
        }

        /// <summary>
        /// Rearrange the controls size and location
        /// </summary>
        private void ArrangeLocation()
        {
            this.pictureBox1.Size = new Size((int)DpiAware.LogicalToDeviceUnits(130), (int)DpiAware.LogicalToDeviceUnits(130));
            this.pictureBoxchart.Size = this.pictureBoxgrid.Size = new Size((int)DpiAware.LogicalToDeviceUnits(40), (int)DpiAware.LogicalToDeviceUnits(40));
            this.pictureBoxexcel.Size = this.pictureBoxpdf.Size = new Size((int)DpiAware.LogicalToDeviceUnits(50), (int)DpiAware.LogicalToDeviceUnits(50));
            this.sfComboBox1.Height = (int)DpiAware.LogicalToDeviceUnits(35);
            this.pictureBoxexcel.Location = new Point(pictureBoxexcel.Margin.Left, 2);
            this.pictureBoxpdf.Location = new Point(pictureBoxexcel.Location.X + pictureBoxexcel.Width + pictureBoxexcel.Margin.Right + this.pictureBoxpdf.Margin.Left, pictureBoxexcel.Location.Y);
            this.panel2.Height = labelpanel.Height > pictureBox1.Height ? labelpanel.Height : pictureBox1.Height;
            this.tableLayoutPanel1.RowStyles[0].Height = panel2.Height;
            this.tableLayoutPanel1.RowStyles[1].Height = pictureBoxchart.Height + pictureBoxchart.Margin.Top + pictureBoxchart.Margin.Bottom;
            this.panelexport.Height = pictureBoxexcel.Height + pictureBoxexcel.Margin.Top + pictureBoxexcel.Margin.Bottom;
            this.tableLayoutPanel1.RowStyles[3].Height = this.panelexport.Height;

            this.chartpanel.Height = this.gridpanel.Height = this.panel3.Height;
            
            this.tableLayoutPanel1.RowStyles[2].Height = this.panel3.Height;

            this.gridpanel.BringToFront();
            this.chartpanel.Visible = this.CharttableLayoutPanel.Visible = false;

            this.sfDataGrid1.Size = new Size(gridpanel.Width - sfDataGrid1.Margin.Right, gridpanel.Height - sfDataGrid1.Margin.Bottom);
            this.panel2.MinimumSize = new Size(labelpanel.Width + tableLayoutPanel2.Width + pictureBox1.Width, labelpanel.Height);
            this.panel3.MinimumSize = new Size(pictureBoxback.Width + chartControl1.Width + CharttableLayoutPanel.Width, CharttableLayoutPanel.Height);
            int minimumWidth = panel2.MinimumSize.Width > panel3.MinimumSize.Width ? panel2.MinimumSize.Width : panel3.MinimumSize.Width;
            this.MinimumSize = new Size(minimumWidth + 100, labelpanel.Height + panel3.Height + panel4.Height + panelexport.Height + this.Style.TitleBar.Height + 30);
            this.tableLayoutPanel1.Height = panel3.Height + panel2.Height + panel4.Height + panelexport.Height;

            this.tableLayoutPanel2.Location = new Point(pictureBox1.Location.X + pictureBox1.Width + pictureBox1.Margin.Right, CharttableLayoutPanel.Margin.Top);
            this.pictureBoxchart.Location = new Point(this.ClientRectangle.Width - pictureBoxchart.Width - pictureBoxchart.Margin.Right, pictureBoxchart.Margin.Top);
            this.pictureBoxgrid.Location = new Point(this.pictureBoxchart.Location.X - pictureBoxgrid.Width - pictureBoxchart.Margin.Left - pictureBoxgrid.Margin.Right, pictureBoxgrid.Margin.Top);
            this.sfComboBox1.Location = new Point(this.pictureBoxgrid.Location.X - sfComboBox1.Width - pictureBoxgrid.Margin.Left - sfComboBox1.Margin.Right, sfComboBox1.Margin.Top);
            this.chartControl1.Dock = DockStyle.Fill;
        }

        void panel3_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Rectangle rect = this.panel3.ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;
            using (Pen pen1 = new Pen(Color.Transparent))
            {
                e.Graphics.DrawRectangle(pen1, rect);
            }
        }

        void pictureBoxback_Click(object sender, System.EventArgs e)
        {
            this.InitializeChart();
            this.pictureBoxback.Visible = false;
        }


        void pictureBoxgrid_MouseLeave(object sender, EventArgs e)
        {
            if (this.gridpanel.Visible)
            {
                this.pictureBoxgrid.Image = Image.FromFile(imagepath + "Grid_Clicked.png");
            }
            else
            {
                this.pictureBoxgrid.Image = Image.FromFile(imagepath + "Grid_Normal.png");
            }
        }
        void pictureBoxback_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBoxback.Image = Image.FromFile(imagepath + "Previous_Normal.png");
        }

        void pictureBoxback_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBoxback.Image = Image.FromFile(imagepath + "Previous_MouseHover.png");
        }
       
        void pictureBoxchart_MouseDown(object sender, MouseEventArgs e)
        {
            this.Refresh();
            this.pictureBoxgrid.Image = Image.FromFile(imagepath + "Grid_Normal.png");
            this.gridpanel.Visible = false;

            this.chartpanel.Show();
            this.CharttableLayoutPanel.Show();
            this.chartpanel.Visible = this.CharttableLayoutPanel.Visible = true;
        }


        void pictureBoxgrid_MouseDown(object sender, MouseEventArgs e)
        {
            this.pictureBoxgrid.Image = Image.FromFile(imagepath + "Grid_Clicked.png");
            this.pictureBoxchart.Image = Image.FromFile(imagepath + "Chart_Noraml.png");
            this.gridpanel.Visible = true;
            this.sfDataGrid1.Show();

            this.chartpanel.Visible = this.CharttableLayoutPanel.Visible = false;
            this.sfDataGrid1.BeginUpdate();
            this.sfDataGrid1.Location = new Point(0, 1);
            this.sfDataGrid1.EndUpdate();
        }

        void pictureBoxchart_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBoxchart.Image = Image.FromFile(imagepath + "Chart_Hover.png");
        }

        void pictureBoxchart_MouseLeave(object sender, EventArgs e)
        {
            if (this.chartpanel.Visible)
            {
                this.pictureBoxchart.Image = Image.FromFile(imagepath + "Chart_Clicked.png");
            }
            else
            {
                this.pictureBoxchart.Image = Image.FromFile(imagepath + "Chart_Noraml.png");
            }
        }

        void pictureBoxgrid_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBoxgrid.Image = Image.FromFile(imagepath + "Grid_Hover.png");
        }

        private void gridpanel_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = this.gridpanel.ClientRectangle;
            rect.Height -= 1;
            rect.Width -= 1;
            using (Pen pen1 = new Pen(Color.Transparent))
            {
                e.Graphics.DrawRectangle(pen1, rect);
            }
        }

        public bool FilterRecords(object o)
        {
            string filterText = sfComboBox1.SelectedValue.ToString();
            if (filterText == "All")
            {
                return true;
            }
            var item = o as ExpenseData;
            if (item != null)
            {

                string filterValue = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(item.DateTime.Month);
                if (filterValue.Equals(filterText))

                    return true;
            }
            return false;
        }

        private void sfComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.sfComboBox1.SelectedValue == null)
                return;

            if (this.sfComboBox1.SelectedValue.Equals("All"))
            {
                this.sfDataGrid1.ClearFilters();
                sfDataGrid1.View.RefreshFilter();
            }
            else
            {
                sfDataGrid1.View.RefreshFilter();
            }
            if (!drillDown)
            {
                InitializeChart();
            }
            else
            {
                InitializeDrillDownChart(currentDrilldownIndex);
            }
            ProcessedExpenseData expensedata = new ProcessedExpenseData(this.sfComboBox1.SelectedValue.ToString());
            this.label1.Text = expensedata.PositiveAmount.ToString("C");
            this.label2.Text = "Positive\n";
            this.label4.Text = expensedata.NegativeAmount.ToString("C");
            this.label5.Text = "Negative\n";
            this.label7.Text = expensedata.BalanceAmount.ToString("C");
            this.label8.Text = "Balance";
            this.label3.Text = expensedata.NoPositiveTransactions + " Transactions";
            this.label6.Text = expensedata.NoNegativeTransactions + " Transactions";
            this.label9.Text = "\n  Most Spent";
            this.label11.Text = " \n  Least Spent";
            this.label13.Text = "\n  Average Spent";
            this.label10.Text = "\n " + expensedata.MostSpent;
            this.label12.Text = "\n " + expensedata.LeastSpent;
            this.label14.Text = "\n " + expensedata.AverageSpent;
        }


        public void InitializeChart()
        {
            drillDown = false;
            List<ExpenseData> data = (List<ExpenseData>)this.sfDataGrid1.DataSource;
            double home = 0, health = 0, transportation = 0, entertainment = 0, dailyliving = 0;
            int index = this.sfComboBox1.SelectedIndex;
            for (int i = 0; i < data.Count; i++)
            {
                if (index == 0)
                {
                    if (data[i].CategoryName.Equals("Home"))
                        home += data[i].Amount;
                    if (data[i].CategoryName.Equals("Daily Living"))
                        dailyliving += data[i].Amount;
                    if (data[i].CategoryName.Equals("Health"))
                        health += data[i].Amount;
                    if (data[i].CategoryName.Equals("Transportation"))
                        transportation += data[i].Amount;
                    if (data[i].CategoryName.Equals("Entertainment"))
                        entertainment += data[i].Amount;
                }
                else
                {
                    if (data[i].CategoryName.Equals("Home") && index == data[i].DateTime.Month)
                        home += data[i].Amount;
                    if (data[i].CategoryName.Equals("Daily Living") && index == data[i].DateTime.Month)
                        dailyliving += data[i].Amount;
                    if (data[i].CategoryName.Equals("Health") && index == data[i].DateTime.Month)
                        health += data[i].Amount;
                    if (data[i].CategoryName.Equals("Transportation") && index == data[i].DateTime.Month)
                        transportation += data[i].Amount;
                    if (data[i].CategoryName.Equals("Entertainment") && index == data[i].DateTime.Month)
                        entertainment += data[i].Amount;
                }
            }
            explode = true;

            ChartSeries series1 = new ChartSeries("", ChartSeriesType.Pie);
            series1.Points.Add(1, transportation);
            series1.Points.Add(2, health);
            series1.Points.Add(3, entertainment);
            series1.Points.Add(4, dailyliving);
            series1.Points.Add(5, home);

            series1.OptimizePiePointPositions = true;

            for (int i = 0; i < series1.Points.Count; i++)
            {
                series1.Styles[i].Border.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                series1.Styles[i].Border.Color = Color.Gray;
            }

            series1.Styles[0].Text = string.Format("Transportation- ${0}", series1.Points[0].YValues[0]);
            series1.Styles[1].Text = string.Format("Health- ${0}", series1.Points[1].YValues[0]);
            series1.Styles[2].Text = string.Format("Entertainment- ${0}", series1.Points[2].YValues[0]);
            series1.Styles[3].Text = string.Format("Daily Living- ${0}", series1.Points[3].YValues[0]);
            series1.Styles[4].Text = string.Format("Home- ${0}", series1.Points[4].YValues[0]);
            series1.ConfigItems.PieItem.LabelStyle = ChartAccumulationLabelStyle.OutsideInArea;
            series1.Style.DisplayText = true;
            series1.Style.Font.Size = 8.0f;
            series1.ConfigItems.PieItem.PieRadius = 100+DpiAware.LogicalToDeviceUnits(55);
            series1.ConfigItems.PieItem.AngleOffset += 35;
            series1.ExplosionOffset = 10;
            series1.Style.TextColor = Color.Gray;
            series1.Style.Border.Width = 0;
            series1.Style.Border.Color = Color.Transparent;
            this.chartControl1.Series[0].ShowTicks = true;
            this.chartControl1.Series[0].OptimizePiePointPositions = true;
            series1.ExplodedIndex = 0;
            this.chartControl1.Series.Clear();

            this.chartControl1.Series.Add(series1);

            this.chartControl1.ShowLegend = false;
            this.chartControl1.Refresh();
            this.pictureBoxback.Visible = false;
            ChartAppearance.ApplyChartStyles(this.chartControl1);


        }


        protected void InitializeDrillDownChart(int index)
        {
            explode = false;
            drillDown = true;
            currentDrilldownIndex = index;
            List<ExpenseData> data = (List<ExpenseData>)this.sfDataGrid1.DataSource;
            this.pictureBoxback.Visible = true;
            ChartSeries series1 = new ChartSeries("Market Breakdown");
            series1.Name = "Market";
            series1.Text = series1.Name;
            int selection = this.sfComboBox1.SelectedIndex;
            switch (index)
            {
                case 0:
                    double repairs = 0, parking = 0, gas = 0;
                    for (int i = 0; i < data.Count; i++)
                    {
                        if (selection == 0)
                        {
                            if (data[i].SubCategory.Contains("Repairs"))
                                repairs += data[i].Amount;
                            if (data[i].SubCategory.Contains("Parking"))
                                parking += data[i].Amount;
                            if (data[i].SubCategory.Contains("Gas"))
                                gas += data[i].Amount;
                        }
                        else
                        {
                            if (data[i].SubCategory.Contains("Repairs") && selection == data[i].DateTime.Month)
                                repairs += data[i].Amount;
                            if (data[i].SubCategory.Contains("Parking") && selection == data[i].DateTime.Month)
                                parking += data[i].Amount;
                            if (data[i].SubCategory.Contains("Gas") && selection == data[i].DateTime.Month)
                                gas += data[i].Amount;

                        }
                    }
                    series1.Points.Add(1, repairs);
                    series1.Points.Add(2, parking);
                    series1.Points.Add(3, gas);

                    series1.Styles[0].Text = string.Format("Repairs- ${0}", series1.Points[0].YValues[0]);
                    series1.Styles[1].Text = string.Format("Parking- ${0}", series1.Points[1].YValues[0]);
                    series1.Styles[2].Text = string.Format("Gas/fuel- ${0}", series1.Points[2].YValues[0]);
                    break;
                case 1:
                    double perscriptions = 0, insurance = 0;
                    for (int i = 0; i < data.Count; i++)
                    {
                        if (selection == 0)
                        {
                            if (data[i].SubCategory.Contains("Prescriptions"))
                                perscriptions += data[i].Amount;
                            if (data[i].SubCategory.Contains("Insurance"))
                                insurance += data[i].Amount;
                        }
                        else
                        {
                            if (data[i].SubCategory.Contains("Prescriptions") && selection == data[i].DateTime.Month)
                                perscriptions += data[i].Amount;
                            if (data[i].SubCategory.Contains("Insurance") && selection == data[i].DateTime.Month)
                                insurance += data[i].Amount;
                        }
                    }
                    series1.Points.Add(1, perscriptions);
                    series1.Points.Add(2, insurance);

                    series1.Styles[0].Text = string.Format("Prescriptions- ${0}", series1.Points[0].YValues[0]);
                    series1.Styles[1].Text = string.Format("Insurance(H)- ${0}", series1.Points[1].YValues[0]);
                    break;
                case 2:
                    double concerts = 0, movies = 0;
                    for (int i = 0; i < data.Count; i++)
                    {
                        if (selection == 0)
                        {
                            if (data[i].SubCategory.Contains("Concerts"))
                                concerts += data[i].Amount;
                            if (data[i].SubCategory.Contains("Movies"))
                                movies += data[i].Amount;
                        }
                        else
                        {
                            if (data[i].SubCategory.Contains("Concerts") && selection == data[i].DateTime.Month)
                                concerts += data[i].Amount;
                            if (data[i].SubCategory.Contains("Movies") && selection == data[i].DateTime.Month)
                                movies += data[i].Amount;
                        }
                    }
                    series1.Points.Add(1, concerts);
                    series1.Points.Add(2, movies);

                    series1.Styles[0].Text = string.Format("Concerts/clubs- ${0}", series1.Points[0].YValues[0]);
                    series1.Styles[1].Text = string.Format("Movies/plays- ${0}", series1.Points[1].YValues[0]);
                    break;
                case 3:
                    double groceries = 0, dining = 0, cleaning = 0;
                    for (int i = 0; i < data.Count; i++)
                    {
                        if (selection == 0)
                        {
                            if (data[i].SubCategory.Contains("Groceries"))
                                groceries += data[i].Amount;
                            if (data[i].SubCategory.Contains("Dining"))
                                dining += data[i].Amount;
                            if (data[i].SubCategory.Contains("cleaning"))
                                cleaning += data[i].Amount;
                        }
                        else
                        {
                            if (data[i].SubCategory.Contains("Groceries") && selection == data[i].DateTime.Month)
                                groceries += data[i].Amount;
                            if (data[i].SubCategory.Contains("Dining"))
                                dining += data[i].Amount;
                            if (data[i].SubCategory.Contains("cleaning") && selection == data[i].DateTime.Month)
                                cleaning += data[i].Amount;
                        }
                    }
                    series1.Points.Add(1, groceries);
                    series1.Points.Add(2, dining);
                    series1.Points.Add(3, cleaning);

                    series1.Styles[0].Text = string.Format("Groceries- ${0}", series1.Points[0].YValues[0]);
                    series1.Styles[1].Text = string.Format("Dining out- ${0}", series1.Points[1].YValues[0]);
                    series1.Styles[2].Text = string.Format("Dry cleaning- ${0}", series1.Points[2].YValues[0]);
                    break;
                case 4:
                    double mobile = 0, improvement = 0, utilities = 0, repair = 0, rent = 0;
                    for (int i = 0; i < data.Count; i++)
                    {
                        if (selection == 0)
                        {
                            if (data[i].SubCategory.Contains("Mobile"))
                                mobile += data[i].Amount;
                            if (data[i].SubCategory.Contains("improvement"))
                                improvement += data[i].Amount;
                            if (data[i].SubCategory.Contains("Utilities"))
                                utilities += data[i].Amount;
                            if (data[i].SubCategory.Contains("Home repairs"))
                                repair += data[i].Amount;
                            if (data[i].SubCategory.Contains("Mortgage"))
                                rent += data[i].Amount;
                        }
                        else
                        {
                            if (data[i].SubCategory.Contains("Mobile") && selection == data[i].DateTime.Month)
                                mobile += data[i].Amount;
                            if (data[i].SubCategory.Contains("improvement"))
                                improvement += data[i].Amount;
                            if (data[i].SubCategory.Contains("Utilities") && selection == data[i].DateTime.Month)
                                utilities += data[i].Amount;
                            if (data[i].SubCategory.Contains("Home repairs"))
                                repair += data[i].Amount;
                            if (data[i].SubCategory.Contains("Mortgage"))
                                rent += data[i].Amount;
                        }
                    }
                    series1.Points.Add(1, mobile);
                    series1.Points.Add(2, improvement);
                    series1.Points.Add(3, utilities);
                    series1.Points.Add(2, repair);
                    series1.Points.Add(3, rent);

                    series1.Styles[0].Text = string.Format("Mobile telephone- ${0}", series1.Points[0].YValues[0]);
                    series1.Styles[1].Text = string.Format("Home improvement- ${0}", series1.Points[1].YValues[0]);
                    series1.Styles[2].Text = string.Format("Utilities- ${0}", series1.Points[2].YValues[0]);
                    series1.Styles[3].Text = string.Format("Home repairs- ${0}", series1.Points[3].YValues[0]);
                    series1.Styles[4].Text = string.Format("Mortgage/rent- ${0}", series1.Points[4].YValues[0]);
                    break;
                default:
                    InitializeChart();
                    break;
            }

            series1.Type = ChartSeriesType.Pie;
            series1.OptimizePiePointPositions = true;
            for (int i = 0; i < series1.Points.Count; i++)
            {
                series1.Styles[i].Border.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                series1.Styles[i].Border.Color = Color.Gray;
            }

            series1.ConfigItems.PieItem.LabelStyle = ChartAccumulationLabelStyle.OutsideInArea;
            series1.Style.DisplayText = true;
            series1.Style.Font.Size = 10f;
            series1.ConfigItems.PieItem.AngleOffset += 35;
            series1.ConfigItems.PieItem.PieRadius = 100+DpiAware.LogicalToDeviceUnits(55);
            series1.Style.TextColor = Color.Gray;
            series1.Style.Font.Facename = "Sego UI";
            series1.Style.Border.Width = 0;
            series1.Style.Border.Color = Color.Transparent;
            this.chartControl1.Series[0].OptimizePiePointPositions = true;
            this.chartControl1.Series[0].ShowTicks = true;
            this.chartControl1.Series.Clear();
            this.chartControl1.Series.Add(series1);
            this.chartControl1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.pictureBoxback.Visible = true;
            this.chartControl1.Refresh();


        }

        private void ClickTimer_Tick(object sender, EventArgs e)
        {
            clickTimer.Stop();
            if ((DateTime.Now - clickStartTime).Milliseconds > 300)
            {
                int explodeIndex = this.chartControl1.Series[0].ExplodedIndex;
                if (explode)
                {
                    if (pointIndex != -1 && explodeIndex != pointIndex)
                    {
                        if (explodeIndex != pointIndex)
                        {
                            this.chartControl1.Series[0].ExplodedIndex = pointIndex;
                            if (this.pictureBoxback.Visible)
                                this.chartControl1.Series[0].ExplodedAll = false;
                            else
                                this.chartControl1.Refresh();
                        }
                    }
                    else if ((pointIndex == -1 && explodeIndex != -1) || pointIndex == explodeIndex)
                    {
                        this.chartControl1.Series[0].ExplodedIndex = -1;
                    }
                }
            }
        }
        void chartcontrol1_ChartRegionClick(object sender, ChartRegionMouseEventArgs e)
        {
            if (!pictureBoxback.Visible)
            {
                TimeSpan span = DateTime.Now.Subtract(clickStartTime);
                if (clickStartTime.Day != DateTime.Now.Day)
                {
                    pointIndex = e.Region.PointIndex;
                    clickStartTime = DateTime.Now;
                    clickTimer.Start();
                }
                //300 milliseconds is the delay to identify double click event
                else if (span.TotalMilliseconds <= 300)
                {
                    clickTimer.Stop();
                    clickStartTime = DateTime.Now;
                    if (e.Region.PointIndex >= 0)
                    {
                        InitializeDrillDownChart(e.Region.PointIndex);
                    }
                }
                else
                {
                    pointIndex = e.Region.PointIndex;
                    clickStartTime = DateTime.Now;
                    clickTimer.Start();
                }
            }
        }

        void pictureBoxpdf_MouseDown(object sender, MouseEventArgs e)
        {
            exportButton = true;
            //Creates a new PDF document.
            PdfDocument doc = new PdfDocument();
            //Adds a page to the document.
            PdfPage page = doc.Pages.Add();
            page.Graphics.DrawRectangle(PdfBrushes.Black, new RectangleF(0, 0, page.Size.Width, 40));

            // //Creates Pdf graphics for the page
            PdfGraphics g = page.Graphics;

            // //Create an image object
            PdfBitmap image = new PdfBitmap(this.imagepath + "\\1-.png");
            PdfBitmap image1 = new PdfBitmap(this.imagepath + "\\left-image.png");

            PdfDocument gridDoc = new PdfDocument();
            MemoryStream ms = new MemoryStream();
            gridDoc = this.sfDataGrid1.ExportToPdf();
            gridDoc.Save(ms);
            gridDoc.Close(true);

            //Code for adding chart in PDF
            MemoryStream stream = new MemoryStream();
            var sz = new Size(600, 500);
            this.chartControl1.SaveImage(Application.StartupPath + "Chart.png");
            //Draw chart image in the first page
            doc.Pages[0].Graphics.DrawImage(PdfImage.FromFile(Application.StartupPath + "Chart.png"), new PointF(10, 240));
            //Draw the image
            g.DrawImage(image, 1, 2);
            g.DrawImage(image1, 1, 45);
            g.DrawRectangle(new PdfPen(Color.WhiteSmoke), 110, 50, 160, 80);
            Font font = new Font("Calibri", 11, FontStyle.Regular);
            PdfFont pdfFont = new PdfTrueTypeFont(font, false);
            PdfBrush brush = new PdfSolidBrush(Color.Gray);
            page.Graphics.DrawString("David Carter \nPhone : +1 919.494.1947\t\n email : davidc@abst.com", pdfFont, brush, new RectangleF(120, 70, 150, 120));
            PdfLightTable pdfLightTable = new PdfLightTable();
            // Setting the DataSourceType as Direct
            pdfLightTable.DataSourceType = PdfLightTableDataSourceType.TableDirect;

            // Creating Columns
            pdfLightTable.Columns.Add(new PdfColumn("Positive"));
            pdfLightTable.Columns.Add(new PdfColumn("Negative"));
            pdfLightTable.Columns.Add(new PdfColumn("Balance"));

            // Adding Rows
            pdfLightTable.Rows.Add(new object[] { "\n\t" + label1.Text + "\n\n\t" + label2.Text + "\n\t" + label3.Text, "\n\t" + label4.Text + "\n\n\t" + label5.Text + "\n\t" + label6.Text, "\n\t" + label7.Text + "\n\n\t" + label8.Text });

            // Drawing the PdfLightTable
            pdfLightTable.Draw(page, 280, 60, 230);
            // Save and close the document.
            doc.Save(stream);

            Stream[] streams = { stream, ms };

            //Create New document for merge the streams

            PdfDocument document = new PdfDocument();

            // Merges PDFDocument.

            PdfDocumentBase.Merge(document, streams);

            //Saves the document

            document.Save("ExpenseAnalysis.pdf");

          

            if (MessageBox.Show("Do you want to view the PDF file?", "PDF File Created",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                //Launching the PDF file using the default Application.[Acrobat Reader]
                Open("ExpenseAnalysis.pdf");
            }
            stream.Dispose();
            ms.Dispose();
            doc.Close(true);
            document.Close(true);
            exportButton = false;
        }

        private void Open(string fileName)
        {
#if !NETCORE
                System.Diagnostics.Process.Start(fileName);
#else
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "cmd",
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = false,
                CreateNoWindow = true,
                Arguments = "/c start " + fileName
            };
            Process.Start(psi);
#endif
        }

#region OpenFile
        protected void OpenFile(string filetype, string exportFileName)
        {
            try
            {
                if (MessageBox.Show("Export Success! Do you want to open the exported file?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Open(exportFileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
#endregion
#region HelperMethods
        /// <summary>
        /// Get the file path of input file and return the same
        /// </summary>
        /// <param name="inputPath">Input file</param>
        /// <returns>path of the input file</returns>
        private string GetFullImagePath(string inputFile)
        {
            return string.Format(DEFAULTPATH, inputFile);
        }
#endregion
        bool exportButton = false;
        void pictureBoxexcel_MouseDown(object sender, MouseEventArgs e)
        {
            exportButton = true;
            Syncfusion.WinForms.DataGridConverter.ExcelExportingOptions excelExportingOptions = new Syncfusion.WinForms.DataGridConverter.ExcelExportingOptions();
            var excelEngine = sfDataGrid1.ExportToExcel(sfDataGrid1.View, excelExportingOptions);
            var workBook = excelEngine.Excel.Workbooks[0];
            IWorksheet sheet = workBook.Worksheets[0];

            sheet.InsertRow(1, 14);
            sheet.InsertColumn(1, 1);

            sheet.IsGridLinesVisible = false;
            sheet.Range["A1:A100"].ColumnWidth = 5;
            sheet.Range["A14:Z14"].RowHeight = 25;

#region Insert Image
            //Get the Path of the Image
            string imagePath = GetFullImagePath("1-.png");
            IPictureShape pic = sheet.Pictures.AddPicture(3, 2, imagePath);




            imagePath = GetFullImagePath("left-image.png");
            IPictureShape leftPic = sheet.Pictures.AddPicture(6, 2, imagePath);
            leftPic.Left = 50;
            leftPic.Top = 90;
            //sheet.Pictures.
            //ShapeImpl picShape = leftPic as ShapeImpl;
            //picShape.LeftColumnOffset =    1250;
#endregion

            sheet.Range["A1:Z1"].RowHeight = 30;
            sheet.Range["A13:Z13"].RowHeight = 25;
            sheet.Range["B2:S5"].CellStyle.Color = Color.FromArgb(0, 0, 0);
            sheet.Range["B6:S13"].CellStyle.Color = Color.FromArgb(249, 249, 249);
            sheet.Range["B1:B800"].ColumnWidth = 10;
            sheet.Range["C1:C800"].ColumnWidth = 10;
            sheet.Range["E1:E800"].ColumnWidth = 10;
            sheet.Range["E1:E800"].ColumnWidth = 15;
            sheet.Range["F1:F800"].ColumnWidth = 8;
            sheet.Range["G1:G800"].ColumnWidth = 2;
            sheet.Range["H1:H800"].ColumnWidth = 2;

            SaveFileDialog sfd = new SaveFileDialog
            {
                FilterIndex = 2,
                Filter = "Excel 97 to 2003 Files(*.xls)|*.xls|Excel 2007 to 2010 Files(*.xlsx)|*.xlsx",
                FileName = "Book1"
            };
            if (sfd.FilterIndex == 1)
            {
                sheet.Range["B6:C13"].Merge();
                sheet.Range["E6:L13"].Merge();
                        IBorders dataRangeBorder = sheet.Range["M7:Q12"].CellStyle.Borders;                       
                dataRangeBorder.LineStyle = ExcelLineStyle.None;

                sheet.Range["M8:M12"].Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Medium;
                        sheet.Range["M8:M12"].Borders[ExcelBordersIndex.EdgeLeft].Color = ExcelKnownColors.Black;                        
                sheet.Range["M8:M12"].Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Medium;
                sheet.Range["M8:M12"].Borders[ExcelBordersIndex.EdgeRight].Color = ExcelKnownColors.Black;
                sheet.Range["M8:M12"].HorizontalAlignment = ExcelHAlign.HAlignCenter;
                sheet.Range["M8:M12"].VerticalAlignment = ExcelVAlign.VAlignCenter;


                sheet.Range["O8:O12"].Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Medium;
                        sheet.Range["O8:O12"].Borders[ExcelBordersIndex.EdgeLeft].Color = ExcelKnownColors.Black;                       
                sheet.Range["O8:O12"].Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Medium;
                sheet.Range["O8:O12"].Borders[ExcelBordersIndex.EdgeRight].Color = ExcelKnownColors.Black;
                sheet.Range["O8:O12"].HorizontalAlignment = ExcelHAlign.HAlignCenter;
                sheet.Range["O8:O12"].VerticalAlignment = ExcelVAlign.VAlignCenter;
                        
                sheet.Range["Q8:Q12"].Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Medium;
                        sheet.Range["Q8:Q12"].Borders[ExcelBordersIndex.EdgeLeft].Color = ExcelKnownColors.Black;                        
                sheet.Range["Q8:Q12"].Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Medium;
                sheet.Range["Q8:Q12"].Borders[ExcelBordersIndex.EdgeRight].Color = ExcelKnownColors.Black;
                sheet.Range["Q8:Q12"].HorizontalAlignment = ExcelHAlign.HAlignCenter;
                sheet.Range["Q8:Q12"].VerticalAlignment = ExcelVAlign.VAlignCenter;

                sheet.Range[8, 13].HorizontalAlignment = ExcelHAlign.HAlignCenter;
                sheet.Range[8, 13].Value = this.label1.Text;
                        sheet.Range[8, 13].NumberFormat = "\\$#,##0.00";                        
                sheet.Range[8, 13].AutofitColumns();
                sheet.Range[8, 13].Borders[ExcelBordersIndex.EdgeLeft].Color = ExcelKnownColors.Black; ;
                sheet.Range[8, 13].Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Medium;
                sheet.Range[8, 15].HorizontalAlignment = ExcelHAlign.HAlignCenter;
                sheet.Range[8, 15].Value = label4.Text;
                sheet.Range[8, 15].NumberFormat = "\\$#,##0.00";
                sheet.Range[8, 15].AutofitColumns();
                sheet.Range[8, 15].Borders[ExcelBordersIndex.EdgeTop].Color = ExcelKnownColors.Black; ;
                sheet.Range[8, 15].Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Medium;
                sheet.Range[8, 17].HorizontalAlignment = ExcelHAlign.HAlignCenter;
                sheet.Range[8, 17].Value = label7.Text;
                sheet.Range[8, 17].NumberFormat = "\\$#,##0.00";
                sheet.Range[8, 17].AutofitColumns();
                sheet.Range[8, 17].Borders[ExcelBordersIndex.EdgeTop].Color = ExcelKnownColors.Black; ;
                sheet.Range[8, 17].Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Medium;

                sheet.Range[10, 13].Text = this.label2.Text;
                sheet.Range[10, 13].HorizontalAlignment = ExcelHAlign.HAlignCenter;
                sheet.Range[10, 15].Text = label5.Text;
                sheet.Range[10, 15].HorizontalAlignment = ExcelHAlign.HAlignCenter;
                sheet.Range[10, 17].Text = label8.Text;
                sheet.Range[10, 17].HorizontalAlignment = ExcelHAlign.HAlignCenter;

                sheet.Range[12, 13].Text = this.label3.Text;
                sheet.Range[12, 13].HorizontalAlignment = ExcelHAlign.HAlignCenter;
                sheet.Range[12, 13].AutofitColumns();
                sheet.Range[12, 13].Borders[ExcelBordersIndex.EdgeLeft].Color = ExcelKnownColors.Black; ;
                sheet.Range[12, 13].Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Medium;
                sheet.Range[12, 15].Text = label6.Text;
                sheet.Range[12, 15].HorizontalAlignment = ExcelHAlign.HAlignCenter;
                sheet.Range[12, 15].AutofitColumns();
                sheet.Range[12, 15].Borders[ExcelBordersIndex.EdgeLeft].Color = ExcelKnownColors.Black;
                sheet.Range[12, 15].Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Medium;
                sheet.Range[12, 17].Borders[ExcelBordersIndex.EdgeLeft].Color = ExcelKnownColors.Black;
                sheet.Range[12, 17].Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Medium;

                sheet.Range[9, 4].Text = "David Carter";
                sheet.Range[9, 4].VerticalAlignment = ExcelVAlign.VAlignCenter;
                sheet.Range[10, 4].Text = "Phone : +1 919.494.1947";
                sheet.Range[10, 4].VerticalAlignment = ExcelVAlign.VAlignCenter;
                sheet.Range[11, 4].Text = "email : davidc@abst.com";
                sheet.Range[11, 4].VerticalAlignment = ExcelVAlign.VAlignCenter;

            }
            else
            {
                sheet.Range["B6:S13"].Merge();
                IBorders rangeBorder = sheet.Range["B6:S13"].CellStyle.Borders;
                rangeBorder[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                rangeBorder[ExcelBordersIndex.EdgeLeft].ColorRGB = Color.Black;
                rangeBorder[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                rangeBorder[ExcelBordersIndex.EdgeRight].ColorRGB = Color.Black;
                rangeBorder[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                rangeBorder[ExcelBordersIndex.EdgeTop].ColorRGB = Color.Black;
                rangeBorder[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                rangeBorder[ExcelBordersIndex.EdgeBottom].ColorRGB = Color.Black;
            }
                    
            sheet.Range["F1:F800"].NumberFormat = "$#,##0.00";
            int end = 15 + this.sfDataGrid1.RowCount;
            IBorders rangeBorder1 = sheet.Range["B15:F" + end].CellStyle.Borders;
            rangeBorder1[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
            rangeBorder1[ExcelBordersIndex.EdgeLeft].ColorRGB = Color.Black;
            rangeBorder1[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
            rangeBorder1[ExcelBordersIndex.EdgeRight].ColorRGB = Color.Black;
            rangeBorder1[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
            rangeBorder1[ExcelBordersIndex.EdgeTop].ColorRGB = Color.Black;
            rangeBorder1[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
            rangeBorder1[ExcelBordersIndex.EdgeBottom].ColorRGB = Color.Black;
            IShape shape1, shape2, shape3, shape4;

            shape1 = sheet.Shapes.AddAutoShapes(Syncfusion.XlsIO.AutoShapeType.RoundedRectangle, 7, 13, 100, 150);

            shape2 = sheet.Shapes.AddAutoShapes(Syncfusion.XlsIO.AutoShapeType.RoundedRectangle, 7, 17, 100, 150);
            shape3 = sheet.Shapes.AddAutoShapes(Syncfusion.XlsIO.AutoShapeType.Rectangle, 7, 15, 100, 150);
            shape4 = sheet.Shapes.AddAutoShapes(Syncfusion.XlsIO.AutoShapeType.RoundedRectangle, 7, 4, 100, 200);
            shape4.TextFrame.TextRange.Text = "David Carter\nPhone : +1 919.494.1947\nemail : davidc@abst.com";
            shape1.TextFrame.TextRange.Text = this.label1.Text + "\t\n\n" + label2.Text + "\n" + label3.Text;

            shape4.Line.Visible = true;
            shape4.Line.ForeColor = Color.Gray;
            shape4.TextFrame.VerticalAlignment = ExcelVerticalAlignment.Middle;
            shape4.Fill.ForeColorIndex = ExcelKnownColors.WhiteCustom;

            shape1.Line.Visible = true;
            shape1.Line.ForeColor = Color.Gray;
            shape1.TextFrame.VerticalAlignment = ExcelVerticalAlignment.MiddleCentered;
            shape1.Fill.ForeColorIndex = ExcelKnownColors.WhiteCustom;

            shape2.Line.Visible = true;
            shape2.Line.ForeColor = Color.Gray;
                    shape2.TextFrame.VerticalAlignment = ExcelVerticalAlignment.MiddleCentered;                    
            shape2.Fill.ForeColorIndex = ExcelKnownColors.White;
            shape2.TextFrame.TextRange.Text = "    " + this.label7.Text + "\t\t\t\t\n" + "    " + label8.Text;

            shape3.Line.Visible = true;
            shape3.Line.ForeColor = Color.Gray;
            shape3.TextFrame.VerticalAlignment = ExcelVerticalAlignment.MiddleCentered;
            shape3.Fill.ForeColorIndex = ExcelKnownColors.White;
            shape3.TextFrame.TextRange.Text = this.label4.Text + "\t\n\n" + label5.Text + "\n" + label6.Text;
            //Fill the worksheet by chart data.
            int index = 15;
                    for (int i = 0; i < this.chartControl1.Series[0].Points.Count; i++)
            {
                        string styleText = this.chartControl1.Series[0].Styles[i].Text.Split('-')[0];
                if (styleText != string.Empty)
                    sheet.Range[index, 9].Text = styleText;
                index++;
            }
            index = 15;
            for (int i = 0; i <= this.chartControl1.Series[0].Points.Count - 1; i++)
            {
                sheet.Range[index, 10].Number = this.chartControl1.Series[0].Points[i].YValues[0];

                index++;
            }
            ////Create a chart worksheet.
            IChartShape chart = sheet.Charts.Add();
            //Specifies the title of the Chart.
            chart.ChartTitle = "Expense Analysis Chart";
            //Initializes a new series instance and adds it to the series collection of the chart.
            IChartSerie series1 = chart.Series.Add();
            //Specify the chart type of the series.
            series1.SerieType = ExcelChartType.Pie;
            //Specify the name of the series. This will be displayed as the text of the legend.
            series1.Name = "Sample Series";

            int valuesEndIndex = 15 + this.chartControl1.Series[0].Points.Count - 1;
            //Specify the value ranges for the series.
            series1.Values = sheet.Range["J15:J" + valuesEndIndex.ToString()];
            //Specify the Category labels for the series.
            series1.CategoryLabels = sheet.Range["I15:I19"];
            //Makes the chart as active sheet.

            (((series1.DataPoints).DefaultDataPoint).DataLabels).IsValue = true;

            chart.TopRow = 15;
            chart.LeftColumn = 9;
            chart.BottomRow = 25;
            chart.RightColumn = 20;
            
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = sfd.OpenFile())
                {
                    if (sfd.FilterIndex == 1)
                        workBook.Version = ExcelVersion.Excel97to2003;
                    else
                        workBook.Version = ExcelVersion.Excel2010;
                    workBook.SaveAs(stream);
                }

                //Message box confirmation to view the created spreadsheet.
                if (MessageBox.Show("Do you want to view the workbook?", "Workbook has been created", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                    Open(sfd.FileName);
                }
            }

            exportButton = false;
        }

        void pictureBoxpdf_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBoxpdf.Image = Image.FromFile(imagepath + "PdfExportNormal.png");
        }

        void pictureBoxpdf_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBoxpdf.Image = Image.FromFile(imagepath + "PdfExportHover.png");
        }

        void pictureBoxexcel_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBoxexcel.Image = Image.FromFile(imagepath + "ExcelExportnormal.png");
        }

        void pictureBoxexcel_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBoxexcel.Image = Image.FromFile(imagepath + "ExcelExporthover.png");
        }

      
    }
        }

