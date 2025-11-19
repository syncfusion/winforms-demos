#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Grid.Grouping;
using System.Drawing;
using Syncfusion.Windows.Forms.Grid;
using System.Windows.Forms;
namespace PMMLWFSampleBrowser
{
    partial class Form1
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
            Syncfusion.Windows.Forms.Tools.TreeNavigator.HeaderCollection headerCollection1 = new Syncfusion.Windows.Forms.Tools.TreeNavigator.HeaderCollection();
            Syncfusion.Windows.Forms.Edit.Implementation.Config.Config config1 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config();
            Syncfusion.Windows.Forms.Edit.Implementation.Config.Config config2 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config();
            Syncfusion.Windows.Forms.Edit.Implementation.Config.Config config3 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config();
            this.sampleName = new System.Windows.Forms.Label();
            this.tabPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.treeNavigator = new Syncfusion.Windows.Forms.Tools.TreeNavigator();
            this.treeMenuItem = new PMMLWFSampleBrowser.TreeMenuItemAdv();
            this.tabControl1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPage1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPage2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPage3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPage4 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.cSharpCode = new Syncfusion.Windows.Forms.Edit.EditControl();
            this.rCode = new Syncfusion.Windows.Forms.Edit.EditControl();
            this.pmmlCode = new Syncfusion.Windows.Forms.Edit.EditControl();
            this.PredictedResult = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PredictedResult)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cSharpCode)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rCode)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pmmlCode)).BeginInit();
            this.SuspendLayout();
            // 
            // treeNavigator
            // 
            this.treeNavigator.BackColor = System.Drawing.Color.White;
            this.treeNavigator.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeNavigator.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            headerCollection1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.treeNavigator.Header = headerCollection1;
            this.treeNavigator.ImeMode = System.Windows.Forms.ImeMode.On;
            this.treeNavigator.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeNavigator.Location = new System.Drawing.Point(0, 0);
            this.treeNavigator.Margin = new System.Windows.Forms.Padding(0);
            this.treeNavigator.MinimumSize = new System.Drawing.Size(302, 150);
            this.treeNavigator.Name = "treeNavigator";
            this.treeNavigator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.treeNavigator.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(302), (int)DpiAware.LogicalToDeviceUnits(479));
            this.treeNavigator.TabIndex = 0;
            this.treeNavigator.ShowHeader = false;
            this.treeNavigator.ItemBackColor = Color.White;
            this.treeNavigator.Resize += treeNavigator_Resize;
            //
            // tabPanel
            //
            this.tabPanel.Controls.Add(sampleName);
            this.tabPanel.Controls.Add(tabControl1);
            this.tabPanel.Location = new Point(302, 0);
            this.tabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanel.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            //
            // sampleName
            //
            this.sampleName.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.sampleName.Location = new Point(302, 0);
            this.sampleName.ForeColor = Color.DeepSkyBlue;
            this.sampleName.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.sampleName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampleName.Size = new Size((int)DpiAware.LogicalToDeviceUnits(SystemInformation.VirtualScreen.Width - 300), (int)DpiAware.LogicalToDeviceUnits(20));
            // 
            // tabControl1
            // 
            this.tabControl1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabControl1.BeforeTouchSize = new System.Drawing.Size(640, 479);
            this.tabControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.FixedSingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(161)))));
            this.tabControl1.FocusOnTabClick = false;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tabControl1.InactiveTabColor = System.Drawing.Color.White;
            this.tabControl1.Location = new System.Drawing.Point(302, 50);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(SystemInformation.VirtualScreen.Width - 300), (int)DpiAware.LogicalToDeviceUnits(SystemInformation.VirtualScreen.Height - 250)); ;
            this.tabControl1.TabIndex = 6;
            this.tabControl1.TabPanelBackColor = System.Drawing.Color.White;
            this.tabControl1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.PredictedResult);
            this.tabPage1.Image = null;
            this.tabPage1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPage1.Location = new System.Drawing.Point(1, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.ShowCloseButton = true;
            this.tabPage1.Size = new System.Drawing.Size(638, 450);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Predicted Result";
            this.tabPage1.ThemesEnabled = false;
            // 
            // PredictedResult
            // 
            this.PredictedResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PredictedResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PredictedResult.FreezeCaption = false;
            this.PredictedResult.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.PredictedResult.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.PredictedResult.Location = new System.Drawing.Point(0, 0);
            this.PredictedResult.Name = "PredictedResult";
            this.PredictedResult.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(320f), (int)DpiAware.LogicalToDeviceUnits(220f));
            this.PredictedResult.TabIndex = 13;
            this.PredictedResult.TableModel.ColWidths.ResizeToFitOptimized(GridRangeInfo.Table(), GridResizeToFitOptions.IncludeHeaders);
            this.PredictedResult.TableDescriptor.TableOptions.ColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(25f);
            this.PredictedResult.TableDescriptor.TableOptions.RecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(25f);
            this.PredictedResult.TopLevelGroupOptions.ShowCaption = false;
            this.PredictedResult.Appearance.AnyCell.TextColor = Color.Black;
            this.PredictedResult.TopLevelGroupOptions.ShowAddNewRecordAfterDetails = false;
            this.PredictedResult.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.PredictedResult.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.PredictedResult.TableOptions.GridLineBorder = new Syncfusion.Windows.Forms.Grid.GridBorder(GridBorderStyle.Solid, Color.FromArgb(173,185,209), GridBorderWeight.Thin);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.cSharpCode);
            this.tabPage2.Image = null;
            this.tabPage2.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPage2.Location = new System.Drawing.Point(1, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.tabPage2.ShowCloseButton = true;
            this.tabPage2.Size = new System.Drawing.Size(638, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "C#";
            this.tabPage2.ThemesEnabled = false;
            // 
            // cSharpCode
            // 
            this.cSharpCode.CodeSnipptSize = new System.Drawing.Size(100, 100);
            this.cSharpCode.Configurator = config1;
            this.cSharpCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cSharpCode.IndicatorMarginBackColor = System.Drawing.Color.Empty;
            this.cSharpCode.LineNumbersFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cSharpCode.Location = new System.Drawing.Point(0, 3);
            this.cSharpCode.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.cSharpCode.Name = "cSharpCode";
            this.cSharpCode.ReadOnly = true;
            this.cSharpCode.RenderRightToLeft = false;
            this.cSharpCode.SaveOnClose = false;
            this.cSharpCode.ScrollPosition = new System.Drawing.Point(0, 0);
            this.cSharpCode.ScrollVisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Metro;
            this.cSharpCode.Size = new System.Drawing.Size(638, 444);
            this.cSharpCode.StatusBarSettings.CoordsPanel.Width = 30;
            this.cSharpCode.StatusBarSettings.EncodingPanel.Width = 30;
            this.cSharpCode.StatusBarSettings.FileNamePanel.Width = 30;
            this.cSharpCode.StatusBarSettings.InsertPanel.Width = 20;
            this.cSharpCode.StatusBarSettings.Offcie2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Blue;
            this.cSharpCode.StatusBarSettings.Offcie2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Blue;
            this.cSharpCode.StatusBarSettings.StatusPanel.Width = 20;
            this.cSharpCode.StatusBarSettings.TextPanel.Width = 30;
            this.cSharpCode.StatusBarSettings.VisualStyle = Syncfusion.Windows.Forms.Tools.Controls.StatusBar.VisualStyle.Metro;
            this.cSharpCode.TabIndex = 1;
            this.cSharpCode.Text = "";
            this.cSharpCode.UseXPStyleBorder = true;
            this.cSharpCode.VisualColumn = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rCode);
            this.tabPage3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tabPage3.Image = null;
            this.tabPage3.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPage3.Location = new System.Drawing.Point(1, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.tabPage3.ShowCloseButton = true;
            this.tabPage3.Size = new System.Drawing.Size(638, 450);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "R";
            this.tabPage3.ThemesEnabled = false;
            // 
            // rCode
            // 
            this.rCode.CodeSnipptSize = new System.Drawing.Size(100, 100);
            this.rCode.Configurator = config2;
            this.rCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rCode.IndicatorMarginBackColor = System.Drawing.Color.Empty;
            this.rCode.LineNumbersFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rCode.Location = new System.Drawing.Point(0, 3);
            this.rCode.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.rCode.Name = "rCode";
            this.rCode.ReadOnly = true;
            this.rCode.RenderRightToLeft = false;
            this.rCode.SaveOnClose = false;
            this.rCode.ScrollPosition = new System.Drawing.Point(0, 0);
            this.rCode.ScrollVisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Metro;
            this.rCode.Size = new System.Drawing.Size(638, 444);
            this.rCode.StatusBarSettings.CoordsPanel.Width = 30;
            this.rCode.StatusBarSettings.EncodingPanel.Width = 30;
            this.rCode.StatusBarSettings.FileNamePanel.Width = 30;
            this.rCode.StatusBarSettings.InsertPanel.Width = 20;
            this.rCode.StatusBarSettings.Offcie2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Blue;
            this.rCode.StatusBarSettings.Offcie2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Blue;
            this.rCode.StatusBarSettings.StatusPanel.Width = 20;
            this.rCode.StatusBarSettings.TextPanel.Width = 30;
            this.rCode.StatusBarSettings.VisualStyle = Syncfusion.Windows.Forms.Tools.Controls.StatusBar.VisualStyle.Metro;
            this.rCode.TabIndex = 1;
            this.rCode.Text = "edtCode";
            this.rCode.UseXPStyleBorder = true;
            this.rCode.VisualColumn = 8;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pmmlCode);
            this.tabPage4.Image = null;
            this.tabPage4.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPage4.Location = new System.Drawing.Point(1, 28);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.tabPage4.ShowCloseButton = true;
            this.tabPage4.Size = new System.Drawing.Size(638, 450);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "PMML";
            this.tabPage4.ThemesEnabled = false;
            // 
            // pmmlCode
            // 
            this.pmmlCode.CodeSnipptSize = new System.Drawing.Size(100, 100);
            this.pmmlCode.Configurator = config3;
            this.pmmlCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pmmlCode.IndicatorMarginBackColor = System.Drawing.Color.Empty;
            this.pmmlCode.LineNumbersFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pmmlCode.Location = new System.Drawing.Point(0, 3);
            this.pmmlCode.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pmmlCode.Name = "pmmlCode";
            this.pmmlCode.ReadOnly = true;
            this.pmmlCode.RenderRightToLeft = false;
            this.pmmlCode.SaveOnClose = false;
            this.pmmlCode.ScrollPosition = new System.Drawing.Point(0, 0);
            this.pmmlCode.ScrollVisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Metro;
            this.pmmlCode.Size = new System.Drawing.Size(638, 444);
            this.pmmlCode.StatusBarSettings.CoordsPanel.Width = 30;
            this.pmmlCode.StatusBarSettings.EncodingPanel.Width = 30;
            this.pmmlCode.StatusBarSettings.FileNamePanel.Width = 30;
            this.pmmlCode.StatusBarSettings.InsertPanel.Width = 20;
            this.pmmlCode.StatusBarSettings.Offcie2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Blue;
            this.pmmlCode.StatusBarSettings.Offcie2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Blue;
            this.pmmlCode.StatusBarSettings.StatusPanel.Width = 20;
            this.pmmlCode.StatusBarSettings.TextPanel.Width = 30;
            this.pmmlCode.StatusBarSettings.VisualStyle = Syncfusion.Windows.Forms.Tools.Controls.StatusBar.VisualStyle.Metro;
            this.pmmlCode.TabIndex = 1;
            this.pmmlCode.Text = "edtCode";
            this.pmmlCode.UseXPStyleBorder = true;
            this.pmmlCode.VisualColumn = 8;
            // 
            // treeMenuItem
            // 
            this.treeMenuItem.IsModel = false;
            this.treeMenuItem.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem.Location = new System.Drawing.Point(0, 0);
            this.treeMenuItem.ModelName = null;
            this.treeMenuItem.Name = "treeMenuItem";
            this.treeMenuItem.SampleName = null;
            this.treeMenuItem.SamplePath = null;
            this.treeMenuItem.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem.Size = new System.Drawing.Size(0, 0);
            this.treeMenuItem.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BorderThickness = 2;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.DodgerBlue;
            this.CaptionBarHeight = 80;
            this.CaptionButtonColor = System.Drawing.Color.White;
            this.CaptionButtonHoverColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 25F);
            this.CaptionForeColor = System.Drawing.Color.White;
            captionImage1 = new CaptionImage();
            captionImage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            captionImage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            captionImage1.Location = new Point(30, 20);
            captionImage1.Name = "captionImage1";
            captionImage1.Size = new Size((int)DpiAware.LogicalToDeviceUnits(20), (int)DpiAware.LogicalToDeviceUnits(20));
            try
            {
                captionImage1.Image = Image.FromFile(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
            }
            catch
            {
            }
            captionImage2 = new CaptionImage();
            captionImage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            captionImage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            captionImage2.Location = new Point(0, 0);
            captionImage2.Name = "captionImage2";
            captionImage2.Size = new Size(30, 70);
#if NETCORE
                captionImage2.Image = Image.FromFile("Icon.png");
#else
            captionImage2.Image = Image.FromFile("../../Icon.png");
#endif
            captionLabel1 = new CaptionLabel();
            captionLabel1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            captionLabel1.ForeColor = System.Drawing.SystemColors.Window;
            captionLabel1.Location = new Point(76,20);
            captionLabel1.Name = "captionLabel1";
            captionLabel1.Size = new Size((int)DpiAware.LogicalToDeviceUnits(300),(int)DpiAware.LogicalToDeviceUnits(30));
            captionLabel1.Text = "Predictive Analytics";
            this.CaptionLabels.Add(captionLabel1);
            this.CaptionImages.Add(captionImage1);
            this.CaptionImages.Add(captionImage2);
            this.Dock = DockStyle.Fill;
            this.ClientSize = new System.Drawing.Size(942, 479);
            this.Controls.Add(this.tabPanel);
            this.Controls.Add(this.treeNavigator);
            this.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.ForeColor = System.Drawing.Color.Transparent;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            this.ShowIcon = true;
            this.KeyPreview = true;
            this.MetroColor = System.Drawing.Color.DodgerBlue;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PredictedResult)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cSharpCode)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rCode)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pmmlCode)).EndInit();
            this.ResumeLayout(false);

        }

        void Form1_Resize(object sender, System.EventArgs e)
        {
            this.tabControl1.Size = new System.Drawing.Size(this.Width - 316, this.Height - 141 );
        }

        void treeNavigator_Resize(object sender, System.EventArgs e)
        {
            this.tabControl1.Size = new System.Drawing.Size(SystemInformation.VirtualScreen.Width - 300, 
                (sender as TreeNavigator).Height - 55);
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


        #endregion

        private TreeNavigator treeNavigator;
        private TreeMenuItemAdv treeMenuItem;
        private System.Windows.Forms.FlowLayoutPanel tabPanel;
        private System.Windows.Forms.Label sampleName;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControl1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPage1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPage2;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPage3;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPage4;
        private Syncfusion.Windows.Forms.Edit.EditControl cSharpCode;
        private Syncfusion.Windows.Forms.Edit.EditControl rCode;
        private Syncfusion.Windows.Forms.Edit.EditControl pmmlCode;
        private GridGroupingControl PredictedResult;
        private CaptionImage captionImage1;
        private CaptionImage captionImage2;
        private CaptionLabel captionLabel1;

    }
}

