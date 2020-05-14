#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataPager;
using System.Windows.Forms;

namespace OnDemandPaging
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

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
            Syncfusion.WinForms.Controls.Styles.ButtonVisualStyle buttonVisualStyle2 = new Syncfusion.WinForms.Controls.Styles.ButtonVisualStyle();
            this.sfDataPager1 = new Syncfusion.WinForms.DataPager.SfDataPager();
            this.sfDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // sfDataPager1
            // 
            this.sfDataPager1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDataPager1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.sfDataPager1.Location = new System.Drawing.Point(350, 590);
            this.sfDataPager1.Name = "sfDataPager1";			
            this.sfDataPager1.Size = new System.Drawing.Size(327, 50);
            this.sfDataPager1.TabIndex = 2;
            this.sfDataPager1.Text = "sfDataPager1";
            // 
            // sfDataGrid
            // 
            this.sfDataGrid.AccessibleName = "Table";
            this.sfDataGrid.AllowDraggingColumns = true;
            this.sfDataGrid.AllowResizingColumns = true;
            this.sfDataGrid.AllowResizingHiddenColumns = true;
            this.sfDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDataGrid.AutoSizeColumnsMode = AutoSizeColumnsMode.Fill;
            this.sfDataGrid.BackColor = System.Drawing.SystemColors.Window;
            this.sfDataGrid.Location = new System.Drawing.Point(0, 0);
            this.sfDataGrid.Name = "sfDataGrid";
			this.sfDataGrid.RowHeight = 21;
            this.sfDataGrid.RowHeight = 21;
            this.sfDataGrid.Size = new System.Drawing.Size(1084, 560);
            this.sfDataGrid.TabIndex = 1;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.sfDataPager1);
            this.Controls.Add(this.sfDataGrid);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1102, 708);
            this.MinimumSize = new System.Drawing.Size(1102, 708);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "On-demand Paging";
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        #region API Definition

        private SfDataGrid sfDataGrid;
        private SfDataPager sfDataPager1;

        #endregion
    }
}

