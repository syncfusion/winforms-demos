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
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Syncfusion.Windows.Forms;
using System.Threading;
using Queries = PortfolioManager.LINQqueries;
#endregion

namespace PortfolioManager
{
    /// <summary>
    /// Portfolio Manager Form
    /// </summary>
    public partial class PortfolioManager : MetroForm
    {
        # region Variable Declaration
        DashBoard dashBoard;
        Analyzer.Contribution contributionAnalyzer;
        Analyzer.Performance performanceAnalyzer;        
        SynchronizationContext context;
        #endregion

        # region Event Handler
        public PortfolioManager()
        {
            //Start a back ground thread to get Chart data
            context = new SynchronizationContext();
            BackgroundWorker loadChartDataWorker = new BackgroundWorker();
            loadChartDataWorker.DoWork += new DoWorkEventHandler(loadChartDataWorker_DoWork);
            loadChartDataWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(loadChartDataWorker_RunWorkerCompleted);
            loadChartDataWorker.RunWorkerAsync();           

            InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }

            InitializeDashBoard();
           // SkinManager.SetVisualStyle(this, "Office2007Blue");
        }
        
        /// <summary>
        /// Creates and initialized a new DashBoard
        /// </summary>
        void InitializeDashBoard()
        {
            dashBoard = new DashBoard();
            dashBoard.Dock = DockStyle.Fill;
            this.dashboardTabPage.Controls.Add(dashBoard);
            this.PortfolioTabControl.SelectedIndexChanged += new EventHandler(PortfolioTabControl_SelectedIndexChanged);            
        }

        void InitializeAnalyzer()
        {
            performanceAnalyzer = new Analyzer.Performance();
            performanceAnalyzer.Dock = DockStyle.Fill;            
            performanceAnalyzerTabPage.Controls.Add(performanceAnalyzer);                        
        }
            
        /// <summary>
        /// Handle TabPage changed and create ContributionAnalyzer on demand
        /// </summary>        
        void PortfolioTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.PortfolioTabControl.SelectedTab == this.contributionAnalyzerTabPage)
            {
                if (!this.contributionAnalyzerTabPage.Controls.Contains(this.contributionAnalyzer))
                {
                    this.contributionAnalyzer = new Analyzer.Contribution();
                    this.contributionAnalyzer.Dock = DockStyle.Fill;
                    this.contributionAnalyzerTabPage.Controls.Add(this.contributionAnalyzer);
                }
            }
        }

        //Worker thread loads Chart data on background
        void loadChartDataWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            context.Send(new SendOrPostCallback(Analyzer.PerformanceChart.LoadData), null);
            this.BeginInvoke(new Action(delegate() { this.loadingProgressBar.Show(); }));
        }

        //Initialize Analyzer when the WorkerThread is completed
        void loadChartDataWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.BeginInvoke(new Action(delegate()
            {
                this.loadingProgressBar.Hide();
                InitializeAnalyzer();
            }));
        }
        #endregion
    }
        
}