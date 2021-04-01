#region Copyright Syncfusion Inc. 2001 - 2015
//
//  Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Tools;
using DemoCommon.Grid;
namespace VirtualMergeCell
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : GridDemoForm
    {
        #region Private Members
        private CustomGridControl gridControl1 = null;
        private CheckBoxAdv centerText;
        private System.Windows.Forms.Panel panel1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        #endregion

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            this.Load += new EventHandler(Form1_Load);
            //
            // TODO: Add any constructor code after InitializeComponent call

            #region Initial Settings

            this.gridControl1.Initialize();

            for (int row = 2; row != 13; row++)
                this.gridControl1.Model[row, 5].Text = "Test";

            this.gridControl1.Refresh();
            gridControl1.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.Model.RowHeights[0] = 30;
            #endregion
        }

        void Form1_Load(object sender, EventArgs e)
        {
            this.gridControl1.Refresh();
        }

        #region Form Handlers
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


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.centerText = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new VirtualMergeCell.CustomGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.centerText)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // centerText
            // 
            this.centerText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.centerText.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.centerText.Checked = true;
            this.centerText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.centerText.DrawFocusRectangle = false;
            this.centerText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centerText.Location = new System.Drawing.Point(29, 508);
            this.centerText.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.centerText.Name = "centerText";
            this.centerText.Size = new System.Drawing.Size(480, 20);
            this.centerText.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.centerText.TabIndex = 2;
            this.centerText.Text = "Center text in first 3 columns of visible parts of partially visible cells";
            this.centerText.ThemesEnabled = false;
            this.centerText.CheckStateChanged += new System.EventHandler(this.centerText_CheckStateChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.centerText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 556);
            this.panel1.TabIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.DpiAware = true;
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl1.CenterTextInVisibleCellPart = false;
            this.gridControl1.Model.Options.GridVisualStyles = GridVisualStyles.Metro;
            this.gridControl1.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(100.0f);
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(18.0f);
            this.gridControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.HorizontalThumbTrack = true;
            this.gridControl1.Location = new System.Drawing.Point(29, 12);
            this.gridControl1.MetroScrollBars = true;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(854, 480);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 0;
            this.gridControl1.Text = "gridControl1";
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.VerticalThumbTrack = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 556);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Virtual Merge Cell";
            ((System.ComponentModel.ISupportInitialize)(this.centerText)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
# if SyncfusionFramework1_1 || SyncfusionFramework2_0
            Application.EnableVisualStyles();
# endif
            Application.Run(new Form1());
        }
        #endregion

        #region Event Hanlders
        private void centerText_CheckStateChanged(object sender, EventArgs e)
        {
            this.gridControl1.CenterTextInVisibleCellPart = this.centerText.Checked;
        }

        void gridControl1_CurrentCellMoved(object sender, GridCurrentCellMovedEventArgs e)
        {
            gridControl1.EndUpdate();
            gridControl1.Refresh();
        }
        #endregion

    }
}
