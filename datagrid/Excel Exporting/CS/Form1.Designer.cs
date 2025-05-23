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
using Syncfusion.XlsIO;
using Syncfusion.WinForms.Controls;
using Syncfusion.Windows.Forms;

namespace ExcelExporting
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
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.exportDataGridlabel = new System.Windows.Forms.Label();
            this.allowGroupOutlining = new System.Windows.Forms.CheckBox();
            this.customStyleColumn = new System.Windows.Forms.CheckBox();
            this.gridExportButton = new Syncfusion.WinForms.Controls.SfButton();
            this.exportSelectedItemsDataGridlabel = new System.Windows.Forms.Label();
            this.gridSelectedItemsExportButton = new Syncfusion.WinForms.Controls.SfButton();
            this.customSelectedItemsStyle = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.sfDataGrid1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.sfDataGrid1.Location = new System.Drawing.Point(10, 5);
            this.sfDataGrid1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sfDataGrid1.Name = "sfDataGrid1";
			this.sfDataGrid1.RowHeight = (int)DpiAware.LogicalToDeviceUnits(21.0f);
            this.sfDataGrid1.SelectionMode = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.Extended;
            this.sfDataGrid1.ShowGroupDropArea = true;
            this.sfDataGrid1.Size = new System.Drawing.Size(781, 540);
            this.sfDataGrid1.TabIndex = 0;
            this.sfDataGrid1.Text = "sfDataGrid1";
            // 
            // exportDataGridlabel
            // 
            this.exportDataGridlabel.AutoSize = true;
            this.exportDataGridlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.exportDataGridlabel.Location = new System.Drawing.Point(7, 40);
            this.exportDataGridlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exportDataGridlabel.Name = "exportDataGridlabel";
            this.exportDataGridlabel.Size = new System.Drawing.Size(191, 17);
            this.exportDataGridlabel.TabIndex = 2;
            this.exportDataGridlabel.Text = "Export DataGrid To Excel";
            // 
            // allowGroupOutlining
            // 
            this.allowGroupOutlining.Checked = true;
            this.allowGroupOutlining.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allowGroupOutlining.Location = new System.Drawing.Point(7, 60);
            this.allowGroupOutlining.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.allowGroupOutlining.Name = "allowGroupOutlining";
            this.allowGroupOutlining.Size = new System.Drawing.Size(171, 30);
            this.allowGroupOutlining.TabIndex = 3;
            this.allowGroupOutlining.Text = "Allow Group Outlining";
            // 
            // customStyleColumn
            // 
            this.customStyleColumn.Location = new System.Drawing.Point(7, 90);
            this.customStyleColumn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customStyleColumn.Name = "customStyleColumn";
            this.customStyleColumn.Size = new System.Drawing.Size(171, 44);
            this.customStyleColumn.TabIndex = 4;
            this.customStyleColumn.Text = "Customize style for\r\nProductName Column";
            // 
            // gridExportButton
            // 
            this.gridExportButton.AccessibleName = "Button";
            this.gridExportButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.gridExportButton.Location = new System.Drawing.Point(40, 139);
            this.gridExportButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridExportButton.Name = "gridExportButton";
            this.gridExportButton.Size = new System.Drawing.Size(120, 30);
            this.gridExportButton.TabIndex = 5;
            this.gridExportButton.Text = "Export To Excel";
            // 
            // exportSelectedItemsDataGridlabel
            // 
            this.exportSelectedItemsDataGridlabel.AutoSize = true;
            this.exportSelectedItemsDataGridlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.exportSelectedItemsDataGridlabel.Location = new System.Drawing.Point(7, 186);
            this.exportSelectedItemsDataGridlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exportSelectedItemsDataGridlabel.Name = "exportSelectedItemsDataGridlabel";
            this.exportSelectedItemsDataGridlabel.Size = new System.Drawing.Size(165, 34);
            this.exportSelectedItemsDataGridlabel.TabIndex = 2;
            this.exportSelectedItemsDataGridlabel.Text = "Export Selected Items\r\nTo Excel";
            // 
            // gridSelectedItemsExportButton
            // 
            this.gridSelectedItemsExportButton.AccessibleName = "Button";
            this.gridSelectedItemsExportButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.gridSelectedItemsExportButton.Location = new System.Drawing.Point(40, 264);
            this.gridSelectedItemsExportButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridSelectedItemsExportButton.Name = "gridSelectedItemsExportButton";
            this.gridSelectedItemsExportButton.Size = new System.Drawing.Size(120, 30);
            this.gridSelectedItemsExportButton.TabIndex = 7;
            this.gridSelectedItemsExportButton.Text = "Export To Excel";
            // 
            // customSelectedItemsStyle
            // 
            this.customSelectedItemsStyle.Location = new System.Drawing.Point(12, 222);
            this.customSelectedItemsStyle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customSelectedItemsStyle.Name = "customSelectedItemsStyle";
            this.customSelectedItemsStyle.Size = new System.Drawing.Size(181, 40);
            this.customSelectedItemsStyle.TabIndex = 6;
            this.customSelectedItemsStyle.Text = "Customize style for Selected Items in Excel";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.exportDataGridlabel);
            this.groupBox1.Controls.Add(this.allowGroupOutlining);
            this.groupBox1.Controls.Add(this.customStyleColumn);
            this.groupBox1.Controls.Add(this.gridSelectedItemsExportButton);
            this.groupBox1.Controls.Add(this.customSelectedItemsStyle);
            this.groupBox1.Controls.Add(this.exportSelectedItemsDataGridlabel);
            this.groupBox1.Controls.Add(this.gridExportButton);
            this.groupBox1.Location = new System.Drawing.Point(798, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 300);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sfDataGrid1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel Exporting";
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        
       

       

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
        private System.Windows.Forms.Label exportDataGridlabel;
        //
        //Button gridExportButton;
        SfButton gridExportButton;
        CheckBox allowGroupOutlining;
        CheckBox customStyleColumn;
        private System.Windows.Forms.Label exportSelectedItemsDataGridlabel;
        CheckBox customSelectedItemsStyle;
        SfButton gridSelectedItemsExportButton;
        private GroupBox groupBox1;
    }
}

