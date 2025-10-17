#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;

namespace Filtering
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
            this.lblFilterValue = new System.Windows.Forms.Label();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.lblFilterColumn = new System.Windows.Forms.Label();
            this.cmbFilterColumn = new System.Windows.Forms.ComboBox();
            this.cmbFilterCondition = new System.Windows.Forms.ComboBox();
            this.lblFilterCondition = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AccessibleName = "Table";
            this.sfDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGrid1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.sfDataGrid1.Location = new System.Drawing.Point(5, 49);
            this.sfDataGrid1.Margin = new System.Windows.Forms.Padding(5);
            this.sfDataGrid1.Name = "sfDataGrid1";
            this.sfDataGrid1.Size = new System.Drawing.Size(995, 540);
            this.sfDataGrid1.TabIndex = 0;
            this.sfDataGrid1.Text = "sfDataGrid1";
            // 
            // lblFilterValue
            // 
            this.lblFilterValue.AutoSize = true;
            this.lblFilterValue.Location = new System.Drawing.Point(30, 14);
            this.lblFilterValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilterValue.Name = "lblFilterValue";
            this.lblFilterValue.Size = new System.Drawing.Size(79, 17);
            this.lblFilterValue.TabIndex = 1;
            this.lblFilterValue.Text = "Filter Value";
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Location = new System.Drawing.Point(140, 9);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(195, 22);
            this.txtFilterValue.TabIndex = 2;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // lblFilterColumn
            // 
            this.lblFilterColumn.AutoSize = true;
            this.lblFilterColumn.Location = new System.Drawing.Point(349, 12);
            this.lblFilterColumn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilterColumn.Name = "lblFilterColumn";
            this.lblFilterColumn.Size = new System.Drawing.Size(86, 17);
            this.lblFilterColumn.TabIndex = 3;
            this.lblFilterColumn.Text = "FilterColumn";
            // 
            // cmbFilterColumn
            // 
            this.cmbFilterColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterColumn.FormattingEnabled = true;
            this.cmbFilterColumn.Location = new System.Drawing.Point(465, 6);
            this.cmbFilterColumn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFilterColumn.Name = "cmbFilterColumn";
            this.cmbFilterColumn.Size = new System.Drawing.Size(229, 24);
            this.cmbFilterColumn.TabIndex = 4;
            this.cmbFilterColumn.SelectedIndexChanged += new System.EventHandler(this.cmbFilterColumn_SelectedIndexChanged);
            // 
            // cmbFilterCondition
            // 
            this.cmbFilterCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterCondition.FormattingEnabled = true;
            this.cmbFilterCondition.Location = new System.Drawing.Point(838, 4);
            this.cmbFilterCondition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFilterCondition.Name = "cmbFilterCondition";
            this.cmbFilterCondition.Size = new System.Drawing.Size(163, 24);
            this.cmbFilterCondition.TabIndex = 6;
            this.cmbFilterCondition.SelectedIndexChanged += new System.EventHandler(this.cmbFilterCondition_SelectedIndexChanged);
            // 
            // lblFilterCondition
            // 
            this.lblFilterCondition.AutoSize = true;
            this.lblFilterCondition.Location = new System.Drawing.Point(715, 9);
            this.lblFilterCondition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilterCondition.Name = "lblFilterCondition";
            this.lblFilterCondition.Size = new System.Drawing.Size(98, 17);
            this.lblFilterCondition.TabIndex = 5;
            this.lblFilterCondition.Text = "FilterCondition";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 50);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 593);
            this.Controls.Add(this.sfDataGrid1);
            this.Controls.Add(this.panel1);
            this.panel1.Controls.Add(this.cmbFilterCondition);
            this.panel1.Controls.Add(this.lblFilterCondition);
            this.panel1.Controls.Add(this.cmbFilterColumn);
            this.panel1.Controls.Add(this.lblFilterColumn);
            this.panel1.Controls.Add(this.txtFilterValue);
            this.panel1.Controls.Add(this.lblFilterValue);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtering";
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SfDataGrid sfDataGrid1;
        private System.Windows.Forms.Label lblFilterValue;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label lblFilterColumn;
        private System.Windows.Forms.ComboBox cmbFilterColumn;
        private System.Windows.Forms.ComboBox cmbFilterCondition;
        private System.Windows.Forms.Label lblFilterCondition;
        private System.Windows.Forms.Panel panel1;
    }
}

