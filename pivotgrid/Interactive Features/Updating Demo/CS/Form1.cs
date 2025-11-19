#region Copyright Syncfusion Inc. 2001 - 2015
// Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Windows.Forms;
#if !NETCORE
using System.Windows.Threading;
#endif
using Syncfusion.PivotAnalysis.Base;
using Syncfusion.Windows.Forms;

namespace UpdatingDemo
{
    public partial class Form1 : MetroForm
    {
        #region Fields

        private ProductSalesCollection productSalesData = ProductSalesData.GetSalesData();
#if !NETCORE
        DispatcherTimer timer;
#else
        Timer timer;
#endif
        private int updateRate = 500;
        int updateCount = 20; //updates per tick event
        private Random rand = new Random(123123);

        #endregion;

        #region Constructor

        public Form1()
        {
            InitializeComponent();
            comboBoxAdv1.SelectedIndex = 2;
            PivotGridSettings();
            SampleCustomization();
        }

        #endregion

        #region Pivot Grid Settings
        /// <summary>
        /// Pivot Grid Settings for populating the Pivot Rows and Columns
        /// </summary>
        private void PivotGridSettings()
        {
            pivotGridControl1.ItemSource = productSalesData;// ProductSales.GetSalesData();

            pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Product", TotalHeader = "Total" });

            pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Date", TotalHeader = "Total" });

            pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "Country", TotalHeader = "Total" });

            pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "State", TotalHeader = "Total" });

            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Amount", Format = "C", SummaryType = SummaryType.DoubleTotalSum });

            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Quantity", Format = "#,##0" });

            //tab key navigation set as false to move the next control
            pivotGridControl1.TableControl.WantTabKey = false;
        }

        #endregion

        #region Sample Customization

        /// <summary>
        /// The Grid Settings can be Customized
        /// </summary>        
        private void SampleCustomization()
        {
            pivotGridControl1.EnableUpdating = true;
            pivotGridControl1.ShowGroupBar = true;
        }

        #endregion

        #region Helper Methods

        /// <summary>
        ///Set the timer to activate the PivotGrid update
        /// </summary>
        private void DoTimerActivate(bool yes)
        {
            if (yes)
            {
#if !NETCORE
                timer = new DispatcherTimer();
                timer.Interval = TimeSpan.FromMilliseconds(updateRate);
#else
                timer = new Timer();                
                timer.Interval = updateRate;
#endif
                pivotGridControl1.UpdateManager.ThrottleUpdateRate = updateRate;
                timer.Tick += timer_Tick;
                timer.Start();
            }
            else
            {
                DisposeTimer();
            }
        }

        /// <summary>
        /// To stop the timer with efficient manner
        /// </summary>
        private void DisposeTimer()
        {
            timer.Stop();
            Invoke((MethodInvoker)delegate
            {
                timer = null;

            });
        }

        /// <summary>
        ///Update the items source from the ProductSalesCollection
        /// </summary>
        /// <param name="loc"></param>
        private void UpdateItemsSource(string loc)
        {
            ProductSales dr = null;
            switch (loc)
            {
                case "Add at Top":
                    dr = new ProductSales
                    {
                        Country = "Canada",
                        State = "Brunswick",
                        Product = "Bike",
                        Date = "FY 2003",
                        Quantity = 1,
                        Amount = 100d
                    };
                    break;
                case "Add at Middle":
                    dr = new ProductSales
                    {
                        Country = "Canada",
                        State = "Brunswick",
                        Product = "Bike",
                        Date = "FY 2007",
                        Quantity = 1,
                        Amount = 200d
                    };
                    break;
                case "Add at Bottom":
                    dr = new ProductSales
                    {
                        Country = "Canada",
                        State = "Brunswick",
                        Product = "Bike",
                        Date = "FY 2010",
                        Quantity = 1,
                        Amount = 300d
                    };
                    break;
            }
            productSalesData.Add(dr);
            pivotGridControl1.Refresh(true);
        }

        #endregion

        #region Event Handlers

        // enables and disables the check boxes 
        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            pivotGridControl1.EnableUpdating = checkBoxAdv1.Checked;
            checkBoxAdv2.Enabled = checkBoxAdv1.Checked;
            comboBoxAdv1.Enabled = checkBoxAdv1.Checked;
            button1.Enabled = checkBoxAdv1.Checked;
            button2.Enabled = checkBoxAdv1.Checked;
            button3.Enabled = checkBoxAdv1.Checked;
            pivotGridControl1.TableControl.Refresh();
        }

        /// <summary>
        /// Set the timer value
        /// </summary>
        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < updateCount; ++i)
            {
                productSalesData[1].Amount = rand.Next(1000);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateItemsSource("Add at Top");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateItemsSource("Add at Middle");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateItemsSource("Add at Bottom");
        }

        private void checkBoxAdv2_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxAdv2.Checked)
            {
                if (pivotGridControl1.EnableUpdating)
                    DoTimerActivate(true);
            }
            else
            {
                DoTimerActivate(false);
            }
        }

        private void comboBoxAdv1_SelectedValueChanged(object sender, EventArgs e)
        {
            updateRate = int.Parse(comboBoxAdv1.SelectedItem.ToString());
        }

        #endregion
    }
}