#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
# region Directives
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Drawing;
#endregion

namespace PortfolioManager.Analyzer
{ 
    public partial class Performance : UserControl
    {
        # region Variable Declaration
        Analyzer.PerformanceChart chart;
        List<string> accountNames = new List<string>();
        #endregion

        # region Method
        public Performance()
        {
            InitializeComponent();         

            this.UpdateAccountNames();

            chart = new PerformanceChart(this.performanceChart, ChartPeriod.Last3Months);
            
            //TopThree Big asset funds
            chart.AddAccount("AmericanFunds");
            UpdateToolStripButtons(this.last3Months, true);
            this.AmericanFundsCheckBox.Checked = true;
        }

        void AddAccountToChart(string AccountName)
        {
            //Add to chart
            chart.AddAccount(AccountName);

            //Update the ToolBars
            switch (chart.Period)
            {
                case ChartPeriod.Last3Months:
                    UpdateToolStripButtons(this.last3Months, true);
                    break;
                case ChartPeriod.Last6Months:
                    UpdateToolStripButtons(this.last6Months, true);
                    break;
                case ChartPeriod.LastYear:
                    UpdateToolStripButtons(this.lastYear, true);
                    break;
                default:
                    break;
            }

        }        

        //Update accoutNames
        void UpdateAccountNames()        
        {  
            this.accountNames = LINQqueries.GetAccounts().ToList<string>();
        }

        void AddRemoveAccount(string Name, bool Add)
        {
            if (Add)
                chart.AddAccount(Name);
            else
                chart.RemoveAccount(Name);
        }

        private void UpdateToolStripButtons(ToolStripButton toolStripButton, bool Enable)
        {
            foreach (ToolStripButton button in this.chartPeriodTollStrip.Items)
            {
                if (button == toolStripButton)
                    button.Enabled = !Enable;
                else
                    button.Enabled = Enable;
            }
        }
        #endregion

        # region Event Handler
        private void last3Months_Click(object sender, EventArgs e)
        {
            chart.Period = ChartPeriod.Last3Months;
            UpdateToolStripButtons(sender as ToolStripButton, true);            
        }

        private void last6Months_Click(object sender, EventArgs e)
        {
            chart.Period = ChartPeriod.Last6Months;
            UpdateToolStripButtons(sender as ToolStripButton, true);
        }

        private void lastYear_Click(object sender, EventArgs e)
        {
            chart.Period = ChartPeriod.LastYear;
            UpdateToolStripButtons(sender as ToolStripButton, true);
        }

        private void AmericanFundsCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBoxAdv checkBox = sender as CheckBoxAdv;
            AddRemoveAccount(checkBox.Text, checkBox.Checked);           
        }

        private void SchwabFundsCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBoxAdv checkBox = sender as CheckBoxAdv;
            AddRemoveAccount(checkBox.Text, checkBox.Checked);           
        }

        private void vanguardFundsCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBoxAdv checkBox = sender as CheckBoxAdv;
            AddRemoveAccount(checkBox.Text, checkBox.Checked);
        }
        #endregion
    }
}