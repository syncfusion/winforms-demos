#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms;
using Syncfusion.Drawing;

namespace ChartPointCollectionMethods_2005
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

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeChartData();       
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }

        #region Helper Methods

        #region InitializeChartData

        /// <summary>
        /// In this method chart data has been Initialized.
        /// </summary>
        public void InitializeChartData()
        {
            ChartSeries SyncSeries1 = new ChartSeries();
            SyncSeries1.Name = "ser1";
            this.chartControl1.Series.Clear();

            SyncSeries1.Points.Add(1, 600, 300, 500, 200);
            SyncSeries1.Points.Add(2, 400, 500, 600, 100);
            SyncSeries1.Points.Add(3, 300, 200, 900, 600);
            SyncSeries1.Points.Add(4, 500, 350);
            SyncSeries1.Points.Add(5, 550, 210, 100);
            SyncSeries1.Points.Add(6, 200, 450, 900);
            SyncSeries1.Points.Add(7, 400, 350, 800);
            this.chartControl1.Series.Add(SyncSeries1);
            this.chartControl1.Series[0].Type = ChartSeriesType.Column;
            this.rdBtnFindValue.Checked = true;

        }
        #endregion

        #region Calulate

        public void Calculate()
        {
            cbBxFindMaxValue.SelectedIndex = 0;
            cbBxFindMinValue.SelectedIndex = 0;
            cbBxFindValue.SelectedIndex = 3;


            if (rdBtnFindMinValue.Checked)
            {
                cbBxFindMaxValue.Visible = false;
                cbBxFindMinValue.Visible = true;
                cbBxFindValue.Visible = false;
                switch (cbBxFindMinValue.SelectedIndex)
                {

                    case 0:
                        txBxValue.Enabled = false;
                        txBxString.Enabled = false;
                        txBxIndex.Enabled = false;
                        label1.Enabled = false;
                        label2.Enabled = false;
                        label3.Enabled = false;
                        label4.Enabled = false;
                        textBox1.Enabled = false;
                        break;

                    case 1:
                        txBxValue.Enabled = false;
                        txBxString.Enabled = true;
                        txBxIndex.Enabled = false;
                        label1.Enabled = false;
                        label2.Enabled = true;
                        label3.Enabled = false;
                        label4.Enabled = false;
                        textBox1.Enabled = false;
                        break;

                    default:
                        txBxValue.Enabled = false;
                        txBxString.Enabled = true;
                        txBxIndex.Enabled = true;
                        label1.Enabled = false;
                        label2.Enabled = true;
                        label3.Enabled = true;
                        break;
                }

            }
            else if (rdBtnFindMaxValue.Checked)
            {
                cbBxFindMaxValue.Visible = true;
                cbBxFindMinValue.Visible = false;
                cbBxFindValue.Visible = false;
                switch (cbBxFindMaxValue.SelectedIndex)
                {

                    case 0:
                        txBxValue.Enabled = false;
                        txBxString.Enabled = false;
                        txBxIndex.Enabled = false;
                        label1.Enabled = false;
                        label2.Enabled = false;
                        label3.Enabled = false;
                        break;

                    case 1:
                        txBxValue.Enabled = false;
                        txBxString.Enabled = true;
                        txBxIndex.Enabled = false;
                        label1.Enabled = false;
                        label2.Enabled = true;
                        label3.Enabled = false;
                        break;

                    default:
                        txBxValue.Enabled = false;
                        txBxString.Enabled = true;
                        txBxIndex.Enabled = true;
                        label1.Enabled = false;
                        label2.Enabled = true;
                        label3.Enabled = true;
                        break;
                }
            }
            else
            {
                cbBxFindMaxValue.Visible = false;
                cbBxFindMinValue.Visible = false;
                cbBxFindValue.Visible = true;
                switch (cbBxFindValue.SelectedIndex)
                {

                    case 0:
                        txBxValue.Enabled = true;
                        txBxString.Enabled = false;
                        txBxIndex.Enabled = false;
                        label1.Enabled = true;
                        label2.Enabled = false;
                        label3.Enabled = false;
                        break;

                    case 1:
                        txBxValue.Enabled = true;
                        txBxString.Enabled = true;
                        txBxIndex.Enabled = false;
                        label1.Enabled = true;
                        label2.Enabled = true;
                        label3.Enabled = false;
                        break;

                    default:
                        txBxValue.Enabled = true;
                        txBxString.Enabled = true;
                        txBxIndex.Enabled = true;
                        label1.Enabled = true;
                        label2.Enabled = true;
                        label3.Enabled = true;
                        break;
                }
            }
        }
        #endregion

        #endregion

        #region Events

        private void rdBtnFindValue_CheckedChanged(object sender, EventArgs e)
        {
            this.Calculate();
        }

        private void rdBtnFindMaxValue_CheckedChanged(object sender, EventArgs e)
        {
            this.Calculate();
        }

        private void rdBtnFindMinValue_CheckedChanged(object sender, EventArgs e)
        {
            this.Calculate();
        }

        private void cbBxFindValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbBxFindValue.SelectedIndex)
            {

                case 0:
                    txBxValue.Enabled = true;
                    txBxString.Enabled = false;
                    txBxIndex.Enabled = false;
                    label1.Enabled = true;
                    label2.Enabled = false;
                    label3.Enabled = false;
                    label4.Enabled = false;
                    textBox1.Enabled = false;
                    break;

                case 1:
                    txBxValue.Enabled = true;
                    txBxString.Enabled = true;
                    txBxIndex.Enabled = false;
                    label1.Enabled = true;
                    label2.Enabled = true;
                    label3.Enabled = false;
                    label4.Enabled = false;
                    textBox1.Enabled = false;
                    break;
                case 2:
                    txBxValue.Enabled = true;
                    txBxString.Enabled = true;
                    txBxIndex.Enabled = true;
                    label1.Enabled = true;
                    label2.Enabled = true;
                    label3.Enabled = true;
                    label4.Enabled = false;
                    textBox1.Enabled = false;
                    break;

                default:
                    txBxValue.Enabled = true;
                    txBxString.Enabled = true;
                    txBxIndex.Enabled = true;
                    label1.Enabled = true;
                    label2.Enabled = true;
                    label3.Enabled = true;
                    label4.Enabled = true;
                    textBox1.Enabled = true;
                    break;
            }
        }

        private void cbBxFindMaxValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbBxFindMaxValue.SelectedIndex)
            {

                case 0:
                    txBxValue.Enabled = false;
                    txBxString.Enabled = false;
                    txBxIndex.Enabled = false;
                    label1.Enabled = false;
                    label2.Enabled = false;
                    label3.Enabled = false;
                    label4.Enabled = false;
                    textBox1.Enabled = false;

                    break;

                case 1:
                    txBxValue.Enabled = false;
                    txBxString.Enabled = true;
                    txBxIndex.Enabled = false;
                    label1.Enabled = false;
                    label2.Enabled = true;
                    label3.Enabled = false;
                    label4.Enabled = false;
                    textBox1.Enabled = false;
                    break;
                case 2:
                    txBxValue.Enabled = false;
                    txBxString.Enabled = true;
                    txBxIndex.Enabled = true;
                    label1.Enabled = false;
                    label2.Enabled = true;
                    label3.Enabled = true;
                    label4.Enabled = false;
                    textBox1.Enabled = false;
                    break;

                default:
                    txBxValue.Enabled = false;
                    txBxString.Enabled = true;
                    txBxIndex.Enabled = true;
                    label1.Enabled = false;
                    label2.Enabled = true;
                    label3.Enabled = true;
                    label4.Enabled = true;
                    textBox1.Enabled = true;
                    break;

            }
        }

        private void cbBxFindMinValue_SelectedIndexChanged(object sender, EventArgs e)
        {


            switch (cbBxFindMinValue.SelectedIndex)
            {

                case 0:
                    txBxValue.Enabled = false;
                    txBxString.Enabled = false;
                    txBxIndex.Enabled = false;
                    label1.Enabled = false;
                    label2.Enabled = false;
                    label3.Enabled = false;
                    label4.Enabled = false;
                    textBox1.Enabled = false;

                    break;

                case 1:
                    txBxValue.Enabled = false;
                    txBxString.Enabled = true;
                    txBxIndex.Enabled = false;
                    label1.Enabled = false;
                    label2.Enabled = true;
                    label3.Enabled = false;
                    label4.Enabled = false;
                    textBox1.Enabled = false;
                    break;
                case 2:
                    txBxValue.Enabled = false;
                    txBxString.Enabled = true;
                    txBxIndex.Enabled = true;
                    label1.Enabled = false;
                    label2.Enabled = true;
                    label3.Enabled = true;
                    label4.Enabled = false;
                    textBox1.Enabled = false;
                    break;

                default:
                    txBxValue.Enabled = false;
                    txBxString.Enabled = true;
                    txBxIndex.Enabled = true;
                    label1.Enabled = false;
                    label2.Enabled = true;
                    label3.Enabled = true;
                    label4.Enabled = true;
                    textBox1.Enabled = true;
                    break;
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            String resultstr = "";
            double dbl = 0;// Int64.Parse(txBxValue.Text);
            string str = "";// txBxString.Text;
            string end = "";
            int staIndx = 0;// Int32.Parse(txBxIndex.Text); 
            int endIndx = 0;
            try
            {
                if (rdBtnFindMinValue.Checked)
                {

                    switch (cbBxFindMinValue.SelectedIndex)
                    {

                        case 0:
                            ChartPoint dp1 = this.chartControl1.Series[0].Summary.FindMinValue();
                            resultstr = dp1.ToString();
                            break;

                        case 1:
                            str = txBxString.Text;
                            ChartPoint dp2 = this.chartControl1.Series[0].Summary.FindMinValue(str);
                            resultstr = dp2.ToString();
                            break;
                        case 2:
                            str = txBxString.Text;
                            staIndx = Int32.Parse(txBxIndex.Text);
                            ChartPoint dp3 = this.chartControl1.Series[0].Summary.FindMinValue(str, ref staIndx);
                            resultstr = dp3.ToString();
                            break;
                        default:
                            str = txBxString.Text;
                            end = textBox1.Text;
                            staIndx = Int32.Parse(txBxIndex.Text);
                            endIndx = Int32.Parse(textBox1.Text);
                            ChartPoint dp4 = this.chartControl1.Series[0].Summary.FindMinValue(str, ref staIndx, endIndx);
                            resultstr = dp4.ToString();
                            break;
                    }

                }
                else if (rdBtnFindMaxValue.Checked)
                {
                    switch (cbBxFindMaxValue.SelectedIndex)
                    {

                        case 0:
                            ChartPoint dp1 = this.chartControl1.Series[0].Summary.FindMaxValue();
                            resultstr = dp1.ToString();
                            break;

                        case 1:
                            str = txBxString.Text;
                            ChartPoint dp2 = this.chartControl1.Series[0].Summary.FindMaxValue(str);
                            resultstr = dp2.ToString();
                            break;
                        case 2:
                            str = txBxString.Text;
                            staIndx = Int32.Parse(txBxIndex.Text);
                            ChartPoint dp3 = this.chartControl1.Series[0].Summary.FindMaxValue(str, ref staIndx);
                            resultstr = dp3.ToString();
                            break;

                        default:
                            str = txBxString.Text;
                            end = textBox1.Text;
                            staIndx = Int32.Parse(txBxIndex.Text);
                            endIndx = Int32.Parse(textBox1.Text);
                            ChartPoint dp4 = this.chartControl1.Series[0].Summary.FindMaxValue(str, ref staIndx, endIndx);
                            resultstr = dp4.ToString();
                            break;
                    }
                }
                else
                {
                    switch (cbBxFindValue.SelectedIndex)
                    {

                        case 0:
                            dbl = Int64.Parse(txBxValue.Text);
                            ChartPoint dp1 = this.chartControl1.Series[0].Summary.FindValue(dbl);
                            resultstr = dp1.ToString();
                            break;

                        case 1:
                            dbl = Int64.Parse(txBxValue.Text);
                            str = txBxString.Text;
                            ChartPoint dp2 = this.chartControl1.Series[0].Summary.FindValue(dbl, str);
                            resultstr = dp2.ToString();
                            break;

                        case 2:
                            dbl = Int64.Parse(txBxValue.Text);
                            str = txBxString.Text;
                            staIndx = Int32.Parse(txBxIndex.Text);
                            ChartPoint dp3 = this.chartControl1.Series[0].Summary.FindValue(dbl, str, ref staIndx);
                            resultstr = dp3.ToString();
                            break;
                        default:
                            dbl = Int64.Parse(txBxValue.Text);
                            str = txBxString.Text;
                            end = textBox1.Text;
                            staIndx = Int32.Parse(txBxIndex.Text);
                            endIndx = Int32.Parse(textBox1.Text);
                            ChartPoint dp4 = this.chartControl1.Series[0].Summary.FindValue(dbl, str, ref staIndx, endIndx);
                            resultstr = dp4.ToString();
                            break;
                    }

                }


                txBxResult.Text = "Chart Point = " + resultstr;
            }
            catch (Exception ex)
            {
                txBxResult.Text = "Invalid values entered to find chart point!!";
            }

        }

        private void chartControl1_ChartFormatAxisLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            if (e.AxisOrientation == ChartOrientation.Horizontal)
            {
                if (e.Value == 1)
                    e.Label = "Science Fiction";
                else if (e.Value == 2)
                    e.Label = "Mystery";
                else if (e.Value == 3)
                    e.Label = "Geology";
                else if (e.Value == 4)
                    e.Label = "History";
                else if (e.Value == 5)
                    e.Label = "Travel";
                else if (e.Value == 6)
                    e.Label = "Gardening";
                else if (e.Value == 7)
                    e.Label = "Computers";
                else
                    e.Label = "";

                e.Handled = true;
            }
        }
        #endregion
     
    }
}