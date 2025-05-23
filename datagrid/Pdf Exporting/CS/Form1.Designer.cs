#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.DataGridConverter;

namespace PdfExporting
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        ///// <summary>
        ///// Clean up any resources being used.
        ///// </summary>
        ///// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    //DataGrid exporting custamization
        //    ExportOptions.Exporting -= Grid_Exporting;
        //    ExportOptions.CellExporting -= Grid_CellExporting;
        //    ExportOptions.HeaderFooterExporting -= Grid_HeaderFooterExporting;

        //    //Selected Items of DataGrid exporting custamization
        //    selectedItemsOptions.Exporting -= SelectedItems_Exporting;
        //    selectedItemsOptions.CellExporting -= SelectedItems_CellExporting;
        //    selectedItemsOptions.HeaderFooterExporting -= SelectedItems_HeaderFooterExporting;
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sfButton2 = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButton1 = new Syncfusion.WinForms.Controls.SfButton();
            this.fitAllColumnsInPage = new System.Windows.Forms.CheckBox();
            this.repeatHeaders = new System.Windows.Forms.CheckBox();
            this.exportTableSummaries = new System.Windows.Forms.CheckBox();
            this.exportGroupSummaries = new System.Windows.Forms.CheckBox();
            this.exportGroups = new System.Windows.Forms.CheckBox();
            this.autoRowHeight = new System.Windows.Forms.CheckBox();
            this.autoColumnWidth = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDataGrid1.AutoExpandGroups = true;
            this.sfDataGrid1.AutoGenerateColumns = false;
            this.sfDataGrid1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.sfDataGrid1.Location = new System.Drawing.Point(13, 10);
            this.sfDataGrid1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sfDataGrid1.Name = "sfDataGrid1";
			this.sfDataGrid1.RowHeight = (int)DpiAware.LogicalToDeviceUnits(21.0f);
            this.sfDataGrid1.SelectionMode = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.Extended;
            this.sfDataGrid1.ShowGroupDropArea = true;
            this.sfDataGrid1.Size = new System.Drawing.Size(800, 576);
            this.sfDataGrid1.TabIndex = 0;
            this.sfDataGrid1.Text = "se";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.sfButton2);
            this.groupBox1.Controls.Add(this.sfButton1);
            this.groupBox1.Controls.Add(this.fitAllColumnsInPage);
            this.groupBox1.Controls.Add(this.repeatHeaders);
            this.groupBox1.Controls.Add(this.exportTableSummaries);
            this.groupBox1.Controls.Add(this.exportGroupSummaries);
            this.groupBox1.Controls.Add(this.exportGroups);
            this.groupBox1.Controls.Add(this.autoRowHeight);
            this.groupBox1.Controls.Add(this.autoColumnWidth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(820, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 340);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // sfButton2
            // 
            this.sfButton2.AccessibleName = "Button";
            this.sfButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButton2.Location = new System.Drawing.Point(10, 302);
            this.sfButton2.Name = "sfButton2";
            this.sfButton2.Size = new System.Drawing.Size(180, 28);
            this.sfButton2.TabIndex = 9;
            this.sfButton2.Text = "Export Selected Items To PDF";
            // 
            // sfButton1
            // 
            this.sfButton1.AccessibleName = "Button";
            this.sfButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButton1.Location = new System.Drawing.Point(10, 264);
            this.sfButton1.Name = "sfButton1";
            this.sfButton1.Size = new System.Drawing.Size(180, 28);
            this.sfButton1.TabIndex = 8;
            this.sfButton1.Text = "Export To PDF";
            // 
            // fitAllColumnsInPage
            // 
            this.fitAllColumnsInPage.AutoSize = true;
            this.fitAllColumnsInPage.Checked = true;
            this.fitAllColumnsInPage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fitAllColumnsInPage.Location = new System.Drawing.Point(20, 225);
            this.fitAllColumnsInPage.Name = "fitAllColumnsInPage";
            this.fitAllColumnsInPage.Size = new System.Drawing.Size(205, 21);
            this.fitAllColumnsInPage.TabIndex = 7;
            this.fitAllColumnsInPage.Text = "Fit All Columns In One Page";
            this.fitAllColumnsInPage.UseVisualStyleBackColor = true;
            // 
            // repeatHeaders
            // 
            this.repeatHeaders.Checked = true;
            this.repeatHeaders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.repeatHeaders.Location = new System.Drawing.Point(20, 195);
            this.repeatHeaders.Name = "repeatHeaders";
            this.repeatHeaders.Size = new System.Drawing.Size(153, 24);
            this.repeatHeaders.TabIndex = 6;
            this.repeatHeaders.Text = "Repeat Headers";
            // 
            // exportTableSummaries
            // 
            this.exportTableSummaries.AutoSize = true;
            this.exportTableSummaries.Checked = true;
            this.exportTableSummaries.CheckState = System.Windows.Forms.CheckState.Checked;
            this.exportTableSummaries.Location = new System.Drawing.Point(20, 170);
            this.exportTableSummaries.Name = "exportTableSummaries";
            this.exportTableSummaries.Size = new System.Drawing.Size(184, 21);
            this.exportTableSummaries.TabIndex = 5;
            this.exportTableSummaries.Text = "Export Table Summaries";
            this.exportTableSummaries.UseVisualStyleBackColor = true;
            // 
            // exportGroupSummaries
            // 
            this.exportGroupSummaries.Checked = true;
            this.exportGroupSummaries.CheckState = System.Windows.Forms.CheckState.Checked;
            this.exportGroupSummaries.Location = new System.Drawing.Point(20, 140);
            this.exportGroupSummaries.Name = "exportGroupSummaries";
            this.exportGroupSummaries.Size = new System.Drawing.Size(170, 24);
            this.exportGroupSummaries.TabIndex = 4;
            this.exportGroupSummaries.Text = "Export Group Summaries";
            this.exportGroupSummaries.UseVisualStyleBackColor = true;
            // 
            // exportGroups
            // 
            this.exportGroups.AutoSize = true;
            this.exportGroups.Checked = true;
            this.exportGroups.CheckState = System.Windows.Forms.CheckState.Checked;
            this.exportGroups.Location = new System.Drawing.Point(20, 120);
            this.exportGroups.Name = "exportGroups";
            this.exportGroups.Size = new System.Drawing.Size(121, 21);
            this.exportGroups.TabIndex = 3;
            this.exportGroups.Text = "Export Groups";
            this.exportGroups.UseVisualStyleBackColor = true;
            // 
            // autoRowHeight
            // 
            this.autoRowHeight.Checked = true;
            this.autoRowHeight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoRowHeight.Location = new System.Drawing.Point(20, 90);
            this.autoRowHeight.Name = "autoRowHeight";
            this.autoRowHeight.Size = new System.Drawing.Size(156, 24);
            this.autoRowHeight.TabIndex = 2;
            this.autoRowHeight.Text = "Auto Row Height";
            this.autoRowHeight.UseVisualStyleBackColor = true;
            // 
            // autoColumnWidth
            // 
            this.autoColumnWidth.AutoSize = true;
            this.autoColumnWidth.Checked = true;
            this.autoColumnWidth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoColumnWidth.Location = new System.Drawing.Point(20, 70);
            this.autoColumnWidth.Name = "autoColumnWidth";
            this.autoColumnWidth.Size = new System.Drawing.Size(150, 21);
            this.autoColumnWidth.TabIndex = 1;
            this.autoColumnWidth.Text = "Auto Column Width";
            this.autoColumnWidth.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PDF Exporting Options";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sfDataGrid1);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pdf Exporting";
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
        private GroupBox groupBox1;
        private Syncfusion.WinForms.Controls.SfButton sfButton2;
        private Syncfusion.WinForms.Controls.SfButton sfButton1;
        private CheckBox fitAllColumnsInPage;
        private CheckBox repeatHeaders;
        private CheckBox exportTableSummaries;
        private CheckBox exportGroupSummaries;
        private CheckBox exportGroups;
        private CheckBox autoRowHeight;
        private CheckBox autoColumnWidth;
        private Label label1;
    }
}

