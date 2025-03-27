#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.DataGrid;
using System.Drawing;
using System.Windows.Forms;

namespace Grouping
{
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
                groupingCheckBox.CheckedChanged -= OnCheckBoxChanged;
                allowColumnCheckBox.CheckedChanged -= OnTriStateCheckBoxChanged;

            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.sfDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.groupingCheckBox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.allowColumnCheckBox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupingCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowColumnCheckBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sfDataGrid
            // 
            this.sfDataGrid.AccessibleName = "Table";
            this.sfDataGrid.AllowEditing = false;
            this.sfDataGrid.AllowFiltering = true;
            this.sfDataGrid.AutoExpandGroups = true;
            this.sfDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.ColumnHeader;
            this.sfDataGrid.BackColor = System.Drawing.SystemColors.Window;
            this.sfDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGrid.Location = new System.Drawing.Point(10, 5);
            this.sfDataGrid.Name = "sfDataGrid";
			this.sfDataGrid.RowHeight = (int)DpiAware.LogicalToDeviceUnits(21.0f);
            this.sfDataGrid.ShowGroupDropArea = true;
            this.sfDataGrid.Size = new System.Drawing.Size(778, 580);
            this.sfDataGrid.TabIndex = 2;
            // 
            // groupingCheckBox
            // 
            this.groupingCheckBox.BeforeTouchSize = new System.Drawing.Size(151, 25);
            this.groupingCheckBox.Checked = true;
            this.groupingCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.groupingCheckBox.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.groupingCheckBox.Location = new System.Drawing.Point(6, 21);
            this.groupingCheckBox.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.groupingCheckBox.Name = "groupingCheckBox";
            this.groupingCheckBox.Size = new System.Drawing.Size(151, 25);
            this.groupingCheckBox.TabIndex = 5;
            this.groupingCheckBox.Text = "Allow Grouping ";
            this.groupingCheckBox.ThemesEnabled = false;
            this.groupingCheckBox.CheckStateChanged += new System.EventHandler(this.groupingCheckBox_CheckStateChanged);
            // 
            // allowColumnCheckBox
            // 
            this.allowColumnCheckBox.BeforeTouchSize = new System.Drawing.Size(151, 35);
            this.allowColumnCheckBox.Checked = true;
            this.allowColumnCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allowColumnCheckBox.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.allowColumnCheckBox.Location = new System.Drawing.Point(6, 54);
            this.allowColumnCheckBox.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.allowColumnCheckBox.Name = "allowColumnCheckBox";
            this.allowColumnCheckBox.Size = new System.Drawing.Size(151, 35);
            this.allowColumnCheckBox.TabIndex = 6;
            this.allowColumnCheckBox.Text = "Allow Group by Order ID column";
            this.allowColumnCheckBox.ThemesEnabled = false;
            this.allowColumnCheckBox.CheckStateChanged += new System.EventHandler(this.allowColumnCheckBox_CheckStateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupingCheckBox);
            this.groupBox1.Controls.Add(this.allowColumnCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(10, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // panel1
            // 
            this.panel1.Dock = DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 150);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.TabIndex = 8;
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
            this.Text = "Grouping";
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupingCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowColumnCheckBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #region API Definition
        private SfDataGrid sfDataGrid;
        private CheckBoxAdv allowColumnCheckBox;
        private CheckBoxAdv groupingCheckBox;

        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
    }
}

