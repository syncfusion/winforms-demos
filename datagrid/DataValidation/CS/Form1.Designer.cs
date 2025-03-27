#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using System.ComponentModel;

namespace DataValidationDemo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showErrorIcon = new System.Windows.Forms.CheckBox();
            this.showRowError = new System.Windows.Forms.CheckBox();
            this.toolTipCheckBox = new System.Windows.Forms.CheckBox();
            this.validationModeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.selectedColumnComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.colValidationModeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDataGrid1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.sfDataGrid1.Location = new System.Drawing.Point(20, 5);
            this.sfDataGrid1.Name = "sfDataGrid1";
			this.sfDataGrid1.RowHeight = (int)DpiAware.LogicalToDeviceUnits(21.0f);
            this.sfDataGrid1.ShowRowHeader = true;
            this.sfDataGrid1.Size = new System.Drawing.Size(736, 538);
            this.sfDataGrid1.TabIndex = 0;
            this.sfDataGrid1.Text = "sfDataGrid1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.showErrorIcon);
            this.groupBox1.Controls.Add(this.showRowError);
            this.groupBox1.Controls.Add(this.toolTipCheckBox);
            this.groupBox1.Controls.Add(this.validationModeComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBox1.Location = new System.Drawing.Point(776, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 173);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // showErrorIcon
            // 
            this.showErrorIcon.AutoSize = true;
            this.showErrorIcon.Checked = true;
            this.showErrorIcon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showErrorIcon.Location = new System.Drawing.Point(10, 139);
            this.showErrorIcon.Name = "showErrorIcon";
            this.showErrorIcon.Size = new System.Drawing.Size(115, 19);
            this.showErrorIcon.TabIndex = 12;
            this.showErrorIcon.Text = "Show Error Icon";
            this.showErrorIcon.UseVisualStyleBackColor = true;
            this.showErrorIcon.CheckedChanged += new System.EventHandler(this.showErrorIcon_CheckedChanged);
            // 
            // showRowError
            // 
            this.showRowError.AutoSize = true;
            this.showRowError.Checked = true;
            this.showRowError.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showRowError.Location = new System.Drawing.Point(10, 115);
            this.showRowError.Name = "showRowError";
            this.showRowError.Size = new System.Drawing.Size(187, 19);
            this.showRowError.TabIndex = 11;
            this.showRowError.Text = "Show Row Header Error Icon";
            this.showRowError.UseVisualStyleBackColor = true;
            this.showRowError.CheckedChanged += new System.EventHandler(this.showRowError_CheckedChanged);
            // 
            // toolTipCheckBox
            // 
            this.toolTipCheckBox.AutoSize = true;
            this.toolTipCheckBox.Checked = true;
            this.toolTipCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolTipCheckBox.Location = new System.Drawing.Point(10, 89);
            this.toolTipCheckBox.Name = "toolTipCheckBox";
            this.toolTipCheckBox.Size = new System.Drawing.Size(160, 19);
            this.toolTipCheckBox.TabIndex = 9;
            this.toolTipCheckBox.Text = "Show Validation Tool Tip";
            this.toolTipCheckBox.UseVisualStyleBackColor = true;
            this.toolTipCheckBox.CheckedChanged += new System.EventHandler(this.toolTipCheckBox_CheckedChanged);
            // 
            // validationModeComboBox
            // 
            this.validationModeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.validationModeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.validationModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.validationModeComboBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.validationModeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.validationModeComboBox.FormattingEnabled = true;
            this.validationModeComboBox.Items.AddRange(new object[] {
            "None",
            "InView",
            "InEdit"});
            this.validationModeComboBox.Location = new System.Drawing.Point(10, 49);
            this.validationModeComboBox.Name = "validationModeComboBox";
            this.validationModeComboBox.Size = new System.Drawing.Size(170, 23);
            this.validationModeComboBox.TabIndex = 8;
            this.validationModeComboBox.SelectedIndexChanged += new System.EventHandler(this.validationModeComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(10, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Grid Validation Mode:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(10, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Selected Column :";
            // 
            // selectedColumnComboBox
            // 
            this.selectedColumnComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedColumnComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.selectedColumnComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedColumnComboBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.selectedColumnComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.selectedColumnComboBox.FormattingEnabled = true;
            this.selectedColumnComboBox.Items.AddRange(new object[] {
            "Quantity",
            "ContactNumber"});
            this.selectedColumnComboBox.Location = new System.Drawing.Point(10, 50);
            this.selectedColumnComboBox.Name = "selectedColumnComboBox";
            this.selectedColumnComboBox.Size = new System.Drawing.Size(170, 23);
            this.selectedColumnComboBox.TabIndex = 8;
            this.selectedColumnComboBox.SelectedIndexChanged += new System.EventHandler(this.selectedColumnComboBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.colValidationModeComboBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.selectedColumnComboBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBox2.Location = new System.Drawing.Point(776, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 156);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Column Validation Options";
            // 
            // colValidationModeComboBox
            // 
            this.colValidationModeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colValidationModeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.colValidationModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colValidationModeComboBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.colValidationModeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.colValidationModeComboBox.FormattingEnabled = true;
            this.colValidationModeComboBox.Items.AddRange(new object[] {
            "None",
            "InView",
            "InEdit"});
            this.colValidationModeComboBox.Location = new System.Drawing.Point(10, 114);
            this.colValidationModeComboBox.Name = "colValidationModeComboBox";
            this.colValidationModeComboBox.Size = new System.Drawing.Size(170, 23);
            this.colValidationModeComboBox.TabIndex = 10;
            this.colValidationModeComboBox.SelectedIndexChanged += new System.EventHandler(this.colValidationModeComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(10, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Grid Validation Mode:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 553);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sfDataGrid1);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Validation";
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox validationModeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox selectedColumnComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox colValidationModeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox toolTipCheckBox;
        private System.Windows.Forms.CheckBox showErrorIcon;
        private System.Windows.Forms.CheckBox showRowError;
    }
}