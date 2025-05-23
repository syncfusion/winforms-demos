#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid.Enums;
using System.Windows.Forms;

namespace AdvancedFiltering
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFilterPopupModeOrderDate = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkAllowBlankFilterOrderDate = new System.Windows.Forms.CheckBox();
            this.chkImmediateUpdateColumnFilterOrderDate = new System.Windows.Forms.CheckBox();
            this.chkAllowFilterOrderDate = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbFilterPopupModeCustomerID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkAllowBlankFilterCustomerID = new System.Windows.Forms.CheckBox();
            this.chkImmediateUpdateColumnFilterCustomerID = new System.Windows.Forms.CheckBox();
            this.chkAllowFilterCustomerID = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkAllowBlankFilterOrderID = new System.Windows.Forms.CheckBox();
            this.chkImmediateUpdateColumnFilterOrderID = new System.Windows.Forms.CheckBox();
            this.chkAllowFilterOrderID = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkAllowFilters = new System.Windows.Forms.CheckBox();
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cmbFilterPopupModeOrderDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.chkAllowBlankFilterOrderDate);
            this.groupBox1.Controls.Add(this.chkImmediateUpdateColumnFilterOrderDate);
            this.groupBox1.Controls.Add(this.chkAllowFilterOrderDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbFilterPopupModeCustomerID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.chkAllowBlankFilterCustomerID);
            this.groupBox1.Controls.Add(this.chkImmediateUpdateColumnFilterCustomerID);
            this.groupBox1.Controls.Add(this.chkAllowFilterCustomerID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chkAllowBlankFilterOrderID);
            this.groupBox1.Controls.Add(this.chkImmediateUpdateColumnFilterOrderID);
            this.groupBox1.Controls.Add(this.chkAllowFilterOrderID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkAllowFilters);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(730, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(270, 500);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // cmbFilterPopupModeOrderDate
            // 
            this.cmbFilterPopupModeOrderDate.FormattingEnabled = true;
            this.cmbFilterPopupModeOrderDate.Location = new System.Drawing.Point(130, 553);
            this.cmbFilterPopupModeOrderDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFilterPopupModeOrderDate.Name = "cmbFilterPopupModeOrderDate";
            this.cmbFilterPopupModeOrderDate.Size = new System.Drawing.Size(130, 29);
            this.cmbFilterPopupModeOrderDate.TabIndex = 18;
            this.cmbFilterPopupModeOrderDate.SelectedIndexChanged += new System.EventHandler(this.cmbFilterPopupModeOrderDate_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 552);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Filter Popup Mode";
            // 
            // chkAllowBlankFilterOrderDate
            // 
            this.chkAllowBlankFilterOrderDate.AutoSize = true;
            this.chkAllowBlankFilterOrderDate.Checked = true;
            this.chkAllowBlankFilterOrderDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllowBlankFilterOrderDate.Location = new System.Drawing.Point(36, 465);
            this.chkAllowBlankFilterOrderDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAllowBlankFilterOrderDate.Name = "chkAllowBlankFilterOrderDate";
            this.chkAllowBlankFilterOrderDate.Size = new System.Drawing.Size(161, 27);
            this.chkAllowBlankFilterOrderDate.TabIndex = 16;
            this.chkAllowBlankFilterOrderDate.Text = "Allow Blank Filter";
            this.chkAllowBlankFilterOrderDate.UseVisualStyleBackColor = true;
            this.chkAllowBlankFilterOrderDate.CheckedChanged += new System.EventHandler(this.chkAllowBlankFilterOrderDate_CheckedChanged);
            // 
            // chkImmediateUpdateColumnFilterOrderDate
            // 
            this.chkImmediateUpdateColumnFilterOrderDate.AutoSize = true;
            this.chkImmediateUpdateColumnFilterOrderDate.Location = new System.Drawing.Point(36, 440);
            this.chkImmediateUpdateColumnFilterOrderDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkImmediateUpdateColumnFilterOrderDate.Name = "chkImmediateUpdateColumnFilterOrderDate";
            this.chkImmediateUpdateColumnFilterOrderDate.Size = new System.Drawing.Size(282, 27);
            this.chkImmediateUpdateColumnFilterOrderDate.TabIndex = 15;
            this.chkImmediateUpdateColumnFilterOrderDate.Text = "Immediate Update Column Filter";
            this.chkImmediateUpdateColumnFilterOrderDate.UseVisualStyleBackColor = true;
            this.chkImmediateUpdateColumnFilterOrderDate.CheckedChanged += new System.EventHandler(this.chkImmediateUpdateColumnFilterOrderDate_CheckedChanged);
            // 
            // chkAllowFilterOrderDate
            // 
            this.chkAllowFilterOrderDate.AutoSize = true;
            this.chkAllowFilterOrderDate.Checked = true;
            this.chkAllowFilterOrderDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllowFilterOrderDate.Location = new System.Drawing.Point(36, 415);
            this.chkAllowFilterOrderDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAllowFilterOrderDate.Name = "chkAllowFilterOrderDate";
            this.chkAllowFilterOrderDate.Size = new System.Drawing.Size(115, 27);
            this.chkAllowFilterOrderDate.TabIndex = 14;
            this.chkAllowFilterOrderDate.Text = "Allow Filter";
            this.chkAllowFilterOrderDate.UseVisualStyleBackColor = true;
            this.chkAllowFilterOrderDate.CheckedChanged += new System.EventHandler(this.chkAllowFilterOrderDate_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 385);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Options for OrderDate Column";
            // 
            // cmbFilterPopupModeCustomerID
            // 
            this.cmbFilterPopupModeCustomerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterPopupModeCustomerID.FormattingEnabled = true;
            this.cmbFilterPopupModeCustomerID.Location = new System.Drawing.Point(130, 345);
            this.cmbFilterPopupModeCustomerID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFilterPopupModeCustomerID.Name = "cmbFilterPopupModeCustomerID";
            this.cmbFilterPopupModeCustomerID.Size = new System.Drawing.Size(130, 29);
            this.cmbFilterPopupModeCustomerID.TabIndex = 12;
            this.cmbFilterPopupModeCustomerID.SelectedIndexChanged += new System.EventHandler(this.cmbFilterPopupModeCustomerID_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 350);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Filter Popup Mode";
            // 
            // chkAllowBlankFilterCustomerID
            // 
            this.chkAllowBlankFilterCustomerID.AutoSize = true;
            this.chkAllowBlankFilterCustomerID.Checked = true;
            this.chkAllowBlankFilterCustomerID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllowBlankFilterCustomerID.Location = new System.Drawing.Point(36, 320);
            this.chkAllowBlankFilterCustomerID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAllowBlankFilterCustomerID.Name = "chkAllowBlankFilterCustomerID";
            this.chkAllowBlankFilterCustomerID.Size = new System.Drawing.Size(161, 27);
            this.chkAllowBlankFilterCustomerID.TabIndex = 10;
            this.chkAllowBlankFilterCustomerID.Text = "Allow Blank Filter";
            this.chkAllowBlankFilterCustomerID.UseVisualStyleBackColor = true;
            this.chkAllowBlankFilterCustomerID.CheckedChanged += new System.EventHandler(this.chkAllowBlankFilterCustomerID_CheckedChanged);
            // 
            // chkImmediateUpdateColumnFilterCustomerID
            // 
            this.chkImmediateUpdateColumnFilterCustomerID.AutoSize = true;
            this.chkImmediateUpdateColumnFilterCustomerID.Location = new System.Drawing.Point(36, 290);
            this.chkImmediateUpdateColumnFilterCustomerID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkImmediateUpdateColumnFilterCustomerID.Name = "chkImmediateUpdateColumnFilterCustomerID";
            this.chkImmediateUpdateColumnFilterCustomerID.Size = new System.Drawing.Size(282, 27);
            this.chkImmediateUpdateColumnFilterCustomerID.TabIndex = 9;
            this.chkImmediateUpdateColumnFilterCustomerID.Text = "Immediate Update Column Filter";
            this.chkImmediateUpdateColumnFilterCustomerID.UseVisualStyleBackColor = true;
            this.chkImmediateUpdateColumnFilterCustomerID.CheckedChanged += new System.EventHandler(this.chkImmediateUpdateColumnFilterCustomerID_CheckedChanged);
            // 
            // chkAllowFilterCustomerID
            // 
            this.chkAllowFilterCustomerID.AutoSize = true;
            this.chkAllowFilterCustomerID.Checked = true;
            this.chkAllowFilterCustomerID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllowFilterCustomerID.Location = new System.Drawing.Point(36, 260);
            this.chkAllowFilterCustomerID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAllowFilterCustomerID.Name = "chkAllowFilterCustomerID";
            this.chkAllowFilterCustomerID.Size = new System.Drawing.Size(115, 27);
            this.chkAllowFilterCustomerID.TabIndex = 8;
            this.chkAllowFilterCustomerID.Text = "Allow Filter";
            this.chkAllowFilterCustomerID.UseVisualStyleBackColor = true;
            this.chkAllowFilterCustomerID.CheckedChanged += new System.EventHandler(this.chkAllowFilterColumnID_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Options for CustomerID Column";
            // 
            // chkAllowBlankFilterOrderID
            // 
            this.chkAllowBlankFilterOrderID.AutoSize = true;
            this.chkAllowBlankFilterOrderID.Location = new System.Drawing.Point(36, 200);
            this.chkAllowBlankFilterOrderID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAllowBlankFilterOrderID.Name = "chkAllowBlankFilterOrderID";
            this.chkAllowBlankFilterOrderID.Size = new System.Drawing.Size(161, 27);
            this.chkAllowBlankFilterOrderID.TabIndex = 6;
            this.chkAllowBlankFilterOrderID.Text = "Allow Blank Filter";
            this.chkAllowBlankFilterOrderID.UseVisualStyleBackColor = true;
            this.chkAllowBlankFilterOrderID.CheckedChanged += new System.EventHandler(this.chkAllowBlankFilterOrderID_CheckedChanged);
            // 
            // chkImmediateUpdateColumnFilterOrderID
            // 
            this.chkImmediateUpdateColumnFilterOrderID.AutoSize = true;
            this.chkImmediateUpdateColumnFilterOrderID.Checked = true;
            this.chkImmediateUpdateColumnFilterOrderID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkImmediateUpdateColumnFilterOrderID.Location = new System.Drawing.Point(36, 170);
            this.chkImmediateUpdateColumnFilterOrderID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkImmediateUpdateColumnFilterOrderID.Name = "chkImmediateUpdateColumnFilterOrderID";
            this.chkImmediateUpdateColumnFilterOrderID.Size = new System.Drawing.Size(282, 27);
            this.chkImmediateUpdateColumnFilterOrderID.TabIndex = 5;
            this.chkImmediateUpdateColumnFilterOrderID.Text = "Immediate Update Column Filter";
            this.chkImmediateUpdateColumnFilterOrderID.UseVisualStyleBackColor = true;
            this.chkImmediateUpdateColumnFilterOrderID.CheckedChanged += new System.EventHandler(this.chkImmediateUpdateColumnFilterOrderID_CheckedChanged);
            // 
            // chkAllowFilterOrderID
            // 
            this.chkAllowFilterOrderID.AutoSize = true;
            this.chkAllowFilterOrderID.Checked = true;
            this.chkAllowFilterOrderID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllowFilterOrderID.Location = new System.Drawing.Point(36, 140);
            this.chkAllowFilterOrderID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAllowFilterOrderID.Name = "chkAllowFilterOrderID";
            this.chkAllowFilterOrderID.Size = new System.Drawing.Size(115, 27);
            this.chkAllowFilterOrderID.TabIndex = 4;
            this.chkAllowFilterOrderID.Text = "Allow Filter";
            this.chkAllowFilterOrderID.UseVisualStyleBackColor = true;
            this.chkAllowFilterOrderID.CheckedChanged += new System.EventHandler(this.chkAllowFilterOrderID_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Options for Order ID Column";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Column Options:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enable or Disable Filters for Grid";
            // 
            // chkAllowFilters
            // 
            this.chkAllowFilters.AutoSize = true;
            this.chkAllowFilters.Checked = true;
            this.chkAllowFilters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllowFilters.Location = new System.Drawing.Point(36, 50);
            this.chkAllowFilters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAllowFilters.Name = "chkAllowFilters";
            this.chkAllowFilters.Size = new System.Drawing.Size(122, 27);
            this.chkAllowFilters.TabIndex = 0;
            this.chkAllowFilters.Text = "Allow Filters";
            this.chkAllowFilters.UseVisualStyleBackColor = true;
            this.chkAllowFilters.CheckedChanged += new System.EventHandler(this.chkAllowFilters_CheckedChanged);
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AccessibleName = "Table";
            this.sfDataGrid1.AllowFiltering = true;
            this.sfDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDataGrid1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.ColumnHeader;
            this.sfDataGrid1.Location = new System.Drawing.Point(5, 5);
            this.sfDataGrid1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sfDataGrid1.Name = "sfDataGrid1";
			this.sfDataGrid1.RowHeight = (int)DpiAware.LogicalToDeviceUnits(21.0f);
            this.sfDataGrid1.ShowGroupDropArea = true;
            this.sfDataGrid1.Size = new System.Drawing.Size(715, 540);
            this.sfDataGrid1.TabIndex = 1;
            this.sfDataGrid1.Text = "sfDataGrid1";
            // 
            // Form1
            // 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 553);
            this.Controls.Add(this.sfDataGrid1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced Filtering";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkAllowFilters;
        private System.Windows.Forms.CheckBox chkAllowBlankFilterCustomerID;
        private System.Windows.Forms.CheckBox chkImmediateUpdateColumnFilterCustomerID;
        private System.Windows.Forms.CheckBox chkAllowFilterCustomerID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkAllowBlankFilterOrderID;
        private System.Windows.Forms.CheckBox chkImmediateUpdateColumnFilterOrderID;
        private System.Windows.Forms.CheckBox chkAllowFilterOrderID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFilterPopupModeOrderDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkAllowBlankFilterOrderDate;
        private System.Windows.Forms.CheckBox chkImmediateUpdateColumnFilterOrderDate;
        private System.Windows.Forms.CheckBox chkAllowFilterOrderDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbFilterPopupModeCustomerID;
        private System.Windows.Forms.Label label5;
    }
}

