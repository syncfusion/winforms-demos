#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using System.Windows.Forms;

namespace ComboBoxColumn
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
            this.sfDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // sfDataGrid
            // 
            this.sfDataGrid.AccessibleName = "Table";
            this.sfDataGrid.AllowDraggingColumns = true;
            this.sfDataGrid.AllowFiltering = true;
            this.sfDataGrid.AllowResizingColumns = true;
            this.sfDataGrid.AllowResizingHiddenColumns = true;
            this.sfDataGrid.Dock = DockStyle.Fill;
            this.sfDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.sfDataGrid.BackColor = System.Drawing.SystemColors.Window;
            this.sfDataGrid.Location = new System.Drawing.Point(12, 12);
            this.sfDataGrid.Name = "sfDataGrid";
			this.sfDataGrid.RowHeight = (int)DpiAware.LogicalToDeviceUnits(21.0f);
            this.sfDataGrid.ShowGroupDropArea = true;
            this.sfDataGrid.Size = new System.Drawing.Size(822, 569);
            this.sfDataGrid.TabIndex = 1;
            this.sfDataGrid.ThemeName = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "ShipCity Column";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 52);
            this.label2.TabIndex = 3;
            this.label2.Text = "ShipCity column loads the \r\nDataSource for ComboBox\r\n based on ShipCountry\r\n colu" +
    "mn.\r\n";
            //
            // panel1
            //
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 60);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1006, 593);
            this.Controls.Add(this.sfDataGrid);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBox Column";
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region API Definition

        private SfDataGrid sfDataGrid;

        #endregion

        private Label label1;
        private Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}

