#region Copyright Syncfusion Inc. 2001 - 2011
// Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
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
using Syncfusion.Windows.Forms.Chart;


namespace SparklinesWithGrid_2008
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            BorderColor = Color.FromArgb(0xFF, 0xCD, 0xCD, 0xCD);
            BorderThickness = 3;
            CaptionBarHeight = 75;
            CaptionBarColor = Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2);
            CaptionFont = new Font("Segoe UI", 22.0f);
            CaptionForeColor = Color.White;
            CaptionAlign = HorizontalAlignment.Left;
            ShowIcon = false;
            CaptionButtonColor = Color.White;
            CaptionButtonHoverColor = Color.White;
            InitializeComponent();
        }
        private double[,] intArray;
        SparkLine[,] sparkline = new SparkLine[10, 3];
       
       void SparkLineSource()
        {
            Random r = new Random();

            this.intArray = new double[10, 7];

            for (int i = 0; i < 10; ++i)
                for (int j = 0; j < 7; ++j)
                    this.intArray[i, j] = r.Next(-50, 90);

            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 7; ++j)
                    this.gridControl1[i + 1, j + 1].CellValue = this.intArray[i, j];
            }

            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 3; ++j)
                    sparkline[i, j] = new SparkLine();
            }


            this.gridControl1.PrepareViewStyleInfo += new Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventHandler(gridControl1_PrepareViewStyleInfo);
            this.gridControl1.Refresh();
        }
        void gridControl1_PrepareViewStyleInfo(object sender, Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventArgs e)
        {
            double[] sourceItem = new double[7];
            if (e.ColIndex > 7 && e.RowIndex > 0 && e.RowIndex <= 10)
            {
                for (int j = 0; j < 7; ++j)
                {
                    if (this.gridControl1[e.RowIndex, j + 1].CellValue.ToString() != "")
                        sourceItem[j] = Convert.ToDouble(this.gridControl1[e.RowIndex, j + 1].CellValue);
                }
                if (e.ColIndex == 9)
                {
                    this.sparkline[e.RowIndex - 1, e.ColIndex - 8].Type = SparkLineType.Column;
                }
                if (e.ColIndex == 10)
                {
                    this.sparkline[e.RowIndex - 1, e.ColIndex - 8].Type = SparkLineType.WinLoss;
                    this.sparkline[e.RowIndex - 1, e.ColIndex - 8].Markers.ShowNegativePoint = true;
                }
                this.sparkline[e.RowIndex - 1, e.ColIndex - 8].Source = sourceItem;
                e.Style.CellType = "Control";
                e.Style.Control = this.sparkline[e.RowIndex - 1, e.ColIndex - 8];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.gridControl1.Rows.DefaultSize = 35;
    
            this.gridControl1[0, 8].Text = "Line";
            this.gridControl1[0, 9].Text = "Column";
            this.gridControl1[0, 10].Text = "WinLoss";
           
            SparkLineSource();
        }

        private void btnRandomData_Click(object sender, EventArgs e)
        {
            SparkLineSource();
        }

       
    }
}
