#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms.Tools;

namespace SkinManagerDemo_2008
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
            var orderInfo = new OrderInfoCollection().OrdersListDetails;
            this.sfDataGrid1.DataSource = orderInfo;
            this.multiColumnComboBox1.DataSource = orderInfo;
            this.multiColumnComboBox1.Text = string.Empty;
            this.sfComboBox2.DataSource = orderInfo;
            this.sfComboBox2.DisplayMember = "ShipCountry";
            this.sfComboBox2.ValueMember = "ShipCountry";
            this.sfListView1.DataSource = orderInfo;
            this.sfListView1.DisplayMember = "ShipCountry";
            this.sfListView1.ValueMember = "ShipCountry";

            var themesList = new List<string>();
            themesList.Add("Office2019Colorful");
            themesList.Add("Office2016Colorful");
            themesList.Add("Office2016Black");
            themesList.Add("Office2016White");
            themesList.Add("Office2016DarkGray");
            themesList.Add("HighContrastBlack");
            this.sfComboBox1.DataSource = themesList;



            #region Axes Customization
            ChartSeries series = new ChartSeries();
            series.Name = "Sales";
            series.Points.Add(1999, 3);
            series.Points.Add(2000, 7);
            series.Points.Add(2001, 12);
            series.Points.Add(2002, 18);
            series.Points.Add(2003, 22);
            series.Points.Add(2004, 30);
            series.Points.Add(2005, 40);
            series.Points.Add(2006, 50);
            series.Points.Add(2007, 65);
            series.Points.Add(2008, 75);
            series.Type = ChartSeriesType.Column;
            series.Text = series.Name;
            this.chartControl1.Series.Add(series);
            chartControl1.PrimaryYAxis.Title = "Product sold (Millions)";
            chartControl1.PrimaryXAxis.Title = "Year";
            chartControl1.Title.Text = "Product Sales";

            #endregion

            #region Legend Customization

            chartControl1.Legend.Visible = false;

            #endregion


            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.sfComboBox1.SelectedIndex = 0;
            if (DpiAware.GetCurrentDpi() > 96)
            {
                int tabConstant = 6;
                int tabHeight = tabConstant * (int)(DpiAware.GetCurrentDpi() - 96) / 24;
                this.tabControlAdv1.Location = new Point(this.tabControlAdv1.Location.X, this.tabControlAdv1.Location.Y + tabHeight);
                this.label1.Location = new Point(this.label1.Location.X, this.label1.Location.Y + tabHeight / 2);
                this.sfComboBox1.Location = new Point(this.label1.Bounds.Right, this.label1.Location.Y);
                this.sfComboBox1.Size = new Size((int)DpiAware.LogicalToDeviceUnits(this.sfComboBox1.Width), this.sfComboBox1.Size.Height + tabHeight / 2);
            }
        }

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

        bool Clicked = false;

        private void colorPickerUIAdv1_Picked(object sender, Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            if (Clicked)
            {
                Office12ColorTable.ApplyManagedColors(this, this.colorPickerUIAdv1.SelectedColor);
            }
        }

        private void OnSfComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (sfComboBox1.SelectedItem.ToString())
            {
                case "Office2016Black":
                    SkinManager.SetVisualStyle(this, "Office2016Black");
                    this.BackColor = ColorTranslator.FromHtml("#363636");
                    this.CaptionBarColor = ColorTranslator.FromHtml("#363636");
                    this.xpTaskPane1.HeaderLabel.BackColor = ColorTranslator.FromHtml("#363636");
                    label1.ForeColor = Color.White;
                    label2.ForeColor = Color.White;
                    label3.ForeColor = Color.White;
                    label4.ForeColor = Color.White;
                    label5.ForeColor = Color.White;
                    this.CaptionForeColor = Color.White;
                    this.xpTaskPane1.HeaderLabel.ForeColor = Color.White;
                    break;
                case "Office2016White":
                    SkinManager.SetVisualStyle(this, "Office2016White");
                    this.BackColor = Color.White;
                    this.CaptionBarColor = Color.White;
                    this.xpTaskPane1.HeaderLabel.BackColor = Color.White;
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    label3.ForeColor = Color.Black;
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                    this.CaptionForeColor = Color.Black;
                    this.xpTaskPane1.HeaderLabel.ForeColor = Color.Black;
                    break;
                case "Office2016DarkGray":
                    SkinManager.SetVisualStyle(this, "Office2016DarkGray");
                    this.BackColor = ColorTranslator.FromHtml("#666666");
                    this.CaptionBarColor = ColorTranslator.FromHtml("#666666");
                    this.xpTaskPane1.HeaderLabel.BackColor = ColorTranslator.FromHtml("#666666");
                    label1.ForeColor = Color.White;
                    label2.ForeColor = Color.White;
                    label3.ForeColor = Color.White;
                    label4.ForeColor = Color.White;
                    label5.ForeColor = Color.White;
                    this.CaptionForeColor = Color.White;
                    this.xpTaskPane1.HeaderLabel.ForeColor = Color.White;

                    break;
                case "Office2016Colorful":
                    SkinManager.SetVisualStyle(this, "Office2016Colorful");
                    this.BackColor = Color.White;
                    this.CaptionBarColor = Color.White;
                    this.xpTaskPane1.HeaderLabel.BackColor = Color.White;
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    label3.ForeColor = Color.Black;
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                    this.CaptionForeColor = Color.Black;
                    this.xpTaskPane1.HeaderLabel.ForeColor = Color.Black;

                    break;
                case "Office2019Colorful":
                    SkinManager.SetVisualStyle(this, "Office2019Colorful");
                    this.BackColor = Color.White;
                    this.CaptionBarColor = Color.White;
                    this.xpTaskPane1.HeaderLabel.BackColor = Color.White;
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    label3.ForeColor = Color.Black;
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                    this.CaptionForeColor = Color.Black;
                    this.xpTaskPane1.HeaderLabel.ForeColor = Color.Black;
                    break;
                case "HighContrastBlack":
                    SkinManager.SetVisualStyle(this, "HighContrastBlack");
                    this.BackColor = Color.Black;
                    this.CaptionBarColor = Color.Black;
                    this.xpTaskPane1.HeaderLabel.BackColor = Color.Black;
                    label1.ForeColor = Color.White;
                    label2.ForeColor = Color.White;
                    label3.ForeColor = Color.White;
                    label4.ForeColor = Color.White;
                    label5.ForeColor = Color.White;
                    this.CaptionForeColor = Color.White;
                    this.xpTaskPane1.HeaderLabel.ForeColor = Color.White;
                    break;
            }
        }
    }
}
