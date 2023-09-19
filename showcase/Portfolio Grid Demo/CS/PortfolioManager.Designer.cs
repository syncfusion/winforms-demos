#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace PortfolioManager
{
    partial class PortfolioManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortfolioManager));
            this.PortfolioTabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.dashboardTabPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.performanceAnalyzerTabPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.loadingProgressBar = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.contributionAnalyzerTabPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.formLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.titleBarPanel = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PortfolioTabControl)).BeginInit();
            this.PortfolioTabControl.SuspendLayout();
            this.performanceAnalyzerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingProgressBar)).BeginInit();
            this.formLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleBarPanel)).BeginInit();
            this.titleBarPanel.SuspendLayout();
            this.SuspendLayout();
           
            // 
            // PortfolioTabControl
            // 
            this.PortfolioTabControl.AccessibleDescription = "";
            this.PortfolioTabControl.AccessibleName = "";
            this.PortfolioTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PortfolioTabControl.BackColor = System.Drawing.Color.White;
            this.PortfolioTabControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PortfolioTabControl.Controls.Add(this.dashboardTabPage);
            this.PortfolioTabControl.Controls.Add(this.performanceAnalyzerTabPage);
            this.PortfolioTabControl.Controls.Add(this.contributionAnalyzerTabPage);
            this.PortfolioTabControl.FixedSingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.PortfolioTabControl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PortfolioTabControl.ImageList = this.imageList1;
            this.PortfolioTabControl.ImageOffset = 4;
            this.PortfolioTabControl.Location = new System.Drawing.Point(3, 43);
            this.PortfolioTabControl.Name = "PortfolioTabControl";
            this.PortfolioTabControl.Size = new System.Drawing.Size(932, 527);
            this.PortfolioTabControl.TabIndex = 1;
            this.PortfolioTabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRenderer2D);
            // 
            // dashboardTabPage
            // 
            this.dashboardTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dashboardTabPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.dashboardTabPage.Image = null;
            this.dashboardTabPage.ImageIndex = 0;
            this.dashboardTabPage.ImageSize = new System.Drawing.Size(16, 16);
            this.dashboardTabPage.Location = new System.Drawing.Point(0, 28);
            this.dashboardTabPage.Name = "dashboardTabPage";
            this.dashboardTabPage.ShowCloseButton = true;
            this.dashboardTabPage.Size = new System.Drawing.Size(932, 499);
            this.dashboardTabPage.TabForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.dashboardTabPage.TabIndex = 1;
            this.dashboardTabPage.Text = "Dashboard";
            this.dashboardTabPage.ThemesEnabled = false;
            // 
            // performanceAnalyzerTabPage
            // 
            this.performanceAnalyzerTabPage.BackColor = System.Drawing.Color.White;
            this.performanceAnalyzerTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.performanceAnalyzerTabPage.Controls.Add(this.loadingProgressBar);
            this.performanceAnalyzerTabPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.performanceAnalyzerTabPage.Image = null;
            this.performanceAnalyzerTabPage.ImageIndex = 2;
            this.performanceAnalyzerTabPage.ImageSize = new System.Drawing.Size(16, 16);
            this.performanceAnalyzerTabPage.Location = new System.Drawing.Point(0, 28);
            this.performanceAnalyzerTabPage.Name = "performanceAnalyzerTabPage";
            this.performanceAnalyzerTabPage.ShowCloseButton = true;
            this.performanceAnalyzerTabPage.Size = new System.Drawing.Size(932, 499);
            this.performanceAnalyzerTabPage.TabForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.performanceAnalyzerTabPage.TabIndex = 3;
            this.performanceAnalyzerTabPage.Text = "Performance Analyzer";
            this.performanceAnalyzerTabPage.ThemesEnabled = false;
            // 
            // loadingProgressBar
            // 
            this.loadingProgressBar.BackGradientEndColor = System.Drawing.Color.White;
            this.loadingProgressBar.BackGradientStartColor = System.Drawing.Color.LightGray;
            this.loadingProgressBar.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Tube;
            this.loadingProgressBar.BackMultipleColors = new System.Drawing.Color[0];
            this.loadingProgressBar.BackSegments = false;
            this.loadingProgressBar.BackTubeEndColor = System.Drawing.Color.White;
            this.loadingProgressBar.BackTubeStartColor = System.Drawing.Color.LightGray;
            this.loadingProgressBar.Border3DStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.loadingProgressBar.BorderColor = System.Drawing.Color.Black;
            this.loadingProgressBar.CustomText = null;
            this.loadingProgressBar.CustomWaitingRender = false;
            this.loadingProgressBar.FontColor = System.Drawing.Color.OrangeRed;
            this.loadingProgressBar.ForegroundImage = null;
            this.loadingProgressBar.ForeSegments = false;
            this.loadingProgressBar.GradientEndColor = System.Drawing.Color.LightSteelBlue;
            this.loadingProgressBar.GradientStartColor = System.Drawing.Color.WhiteSmoke;
            this.loadingProgressBar.Location = new System.Drawing.Point(200, 213);
            this.loadingProgressBar.MultipleColors = new System.Drawing.Color[0];
            this.loadingProgressBar.Name = "loadingProgressBar";
            this.loadingProgressBar.ProgressFallbackStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.WaitingGradient;
            this.loadingProgressBar.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.WaitingGradient;
            this.loadingProgressBar.SegmentWidth = 35;
            this.loadingProgressBar.Size = new System.Drawing.Size(400, 23);
            this.loadingProgressBar.TabIndex = 1;
            this.loadingProgressBar.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Custom;
            this.loadingProgressBar.ThemesEnabled = false;
            this.loadingProgressBar.TubeEndColor = System.Drawing.Color.Black;
            this.loadingProgressBar.TubeStartColor = System.Drawing.Color.Red;
            this.loadingProgressBar.UseWaitCursor = true;
            this.loadingProgressBar.WaitingGradientEnabled = true;
            this.loadingProgressBar.WaitingGradientInterval = 20;
            this.loadingProgressBar.WaitingGradientWidth = 200;
            // 
            // contributionAnalyzerTabPage
            // 
            this.contributionAnalyzerTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contributionAnalyzerTabPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.contributionAnalyzerTabPage.Image = null;
            this.contributionAnalyzerTabPage.ImageIndex = 1;
            this.contributionAnalyzerTabPage.ImageSize = new System.Drawing.Size(16, 16);
            this.contributionAnalyzerTabPage.Location = new System.Drawing.Point(0, 28);
            this.contributionAnalyzerTabPage.Name = "contributionAnalyzerTabPage";
            this.contributionAnalyzerTabPage.ShowCloseButton = true;
            this.contributionAnalyzerTabPage.Size = new System.Drawing.Size(932, 499);
            this.contributionAnalyzerTabPage.TabForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.contributionAnalyzerTabPage.TabIndex = 2;
            this.contributionAnalyzerTabPage.Text = "Contribution Analyzer";
            this.contributionAnalyzerTabPage.ThemesEnabled = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Dashboard.png");
            this.imageList1.Images.SetKeyName(1, "Contribution-Analyzer.png");
            this.imageList1.Images.SetKeyName(2, "Performance-Analyzer.png");
            // 
            // formLayoutPanel
            // 
            this.formLayoutPanel.BackColor = System.Drawing.Color.White;
            this.formLayoutPanel.ColumnCount = 1;
            this.formLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.formLayoutPanel.Controls.Add(this.PortfolioTabControl, 0, 1);
            this.formLayoutPanel.Controls.Add(this.titleBarPanel, 0, 0);
            this.formLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.formLayoutPanel.Name = "formLayoutPanel";
            this.formLayoutPanel.RowCount = 2;
            this.formLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.113543F));
            this.formLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.88646F));
            this.formLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.formLayoutPanel.Size = new System.Drawing.Size(938, 573);
            this.formLayoutPanel.TabIndex = 0;
            // 
            // titleBarPanel
            // 
            this.titleBarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleBarPanel.BackColor = System.Drawing.Color.White;
            this.titleBarPanel.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None;
            this.titleBarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleBarPanel.Controls.Add(this.titleLabel);
            this.titleBarPanel.Location = new System.Drawing.Point(3, 3);
            this.titleBarPanel.Name = "titleBarPanel";
            this.titleBarPanel.Size = new System.Drawing.Size(932, 34);
            this.titleBarPanel.TabIndex = 2;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.titleLabel.Location = new System.Drawing.Point(8, 5);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(150, 21);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Portfolio Manager";
            // 
            // PortfolioManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.BorderThickness = 2;
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(938, 573);
            this.Controls.Add(this.formLayoutPanel);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimizeBox = false;
            this.Name = "PortfolioManager";
            this.Text = " Portfolio Grid Demo";
            ((System.ComponentModel.ISupportInitialize)(this.PortfolioTabControl)).EndInit();
            this.PortfolioTabControl.ResumeLayout(false);
            this.performanceAnalyzerTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loadingProgressBar)).EndInit();
            this.formLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.titleBarPanel)).EndInit();
            this.titleBarPanel.ResumeLayout(false);
            this.titleBarPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

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
        private Syncfusion.Windows.Forms.Tools.TabControlAdv PortfolioTabControl;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv dashboardTabPage;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv contributionAnalyzerTabPage;
        private System.Windows.Forms.TableLayoutPanel formLayoutPanel;
        private Syncfusion.Windows.Forms.Tools.GradientPanel titleBarPanel;        
        private System.Windows.Forms.Label titleLabel;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv performanceAnalyzerTabPage;
        private System.Windows.Forms.ImageList imageList1;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv loadingProgressBar;        
    }
}

