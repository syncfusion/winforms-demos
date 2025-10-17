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
using System.Windows.Forms;

namespace Editing
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
            this.label2 = new System.Windows.Forms.Label();
            this.editModeComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectionBehaviorComBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.allowEditingCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.verticalScrollBarCheckBox = new System.Windows.Forms.CheckBox();
            this.wordWrapCheckBox = new System.Windows.Forms.CheckBox();
            this.allowMultilineCheckBox = new System.Windows.Forms.CheckBox();
            this.selectedColumnComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.colAllowEditingCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AccessibleName = "Table";
            this.sfDataGrid1.AllowFiltering = true;
            this.sfDataGrid1.AllowSorting = false;
            this.sfDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDataGrid1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.ColumnHeader;
            this.sfDataGrid1.Location = new System.Drawing.Point(7, 5);
            this.sfDataGrid1.Name = "sfDataGrid1";
			this.sfDataGrid1.RowHeight = (int)DpiAware.LogicalToDeviceUnits(21.0f);
            this.sfDataGrid1.ShowGroupDropArea = true;
            this.sfDataGrid1.Size = new System.Drawing.Size(760, 540);
            this.sfDataGrid1.TabIndex = 0;
            this.sfDataGrid1.Text = "sfDataGrid1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(20, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Edit Mode :";
            // 
            // editModeComboBox
            // 
            this.editModeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editModeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.editModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editModeComboBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editModeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.editModeComboBox.FormattingEnabled = true;
            this.editModeComboBox.Items.AddRange(new object[] {
            "SingleClick",
            "DoubleClick"});
            this.editModeComboBox.Location = new System.Drawing.Point(20, 77);
            this.editModeComboBox.Name = "editModeComboBox";
            this.editModeComboBox.Size = new System.Drawing.Size(152, 28);
            this.editModeComboBox.TabIndex = 4;
            this.editModeComboBox.SelectedIndexChanged += new System.EventHandler(this.editModeComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.selectionBehaviorComBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.allowEditingCheckBox);
            this.groupBox1.Controls.Add(this.editModeComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBox1.Location = new System.Drawing.Point(777, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 184);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // selectionBehaviorComBox
            // 
            this.selectionBehaviorComBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectionBehaviorComBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.selectionBehaviorComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectionBehaviorComBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.selectionBehaviorComBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.selectionBehaviorComBox.FormattingEnabled = true;
            this.selectionBehaviorComBox.Items.AddRange(new object[] {
            "Default",
            "SelectAll",
            "MoveLast"});
            this.selectionBehaviorComBox.Location = new System.Drawing.Point(20, 136);
            this.selectionBehaviorComBox.Name = "selectionBehaviorComBox";
            this.selectionBehaviorComBox.Size = new System.Drawing.Size(152, 28);
            this.selectionBehaviorComBox.TabIndex = 6;
            this.selectionBehaviorComBox.SelectedIndexChanged += new System.EventHandler(this.selectionBehaviorComBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(20, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Editor Selection Behavior :";
            // 
            // allowEditingCheckBox
            // 
            this.allowEditingCheckBox.AutoSize = true;
            this.allowEditingCheckBox.Location = new System.Drawing.Point(20, 23);
            this.allowEditingCheckBox.Name = "allowEditingCheckBox";
            this.allowEditingCheckBox.Size = new System.Drawing.Size(124, 24);
            this.allowEditingCheckBox.TabIndex = 2;
            this.allowEditingCheckBox.Text = "Allow Editing";
            this.allowEditingCheckBox.UseVisualStyleBackColor = true;
          
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.verticalScrollBarCheckBox);
            this.groupBox2.Controls.Add(this.wordWrapCheckBox);
            this.groupBox2.Controls.Add(this.allowMultilineCheckBox);
            this.groupBox2.Controls.Add(this.selectedColumnComboBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.colAllowEditingCheckBox);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBox2.Location = new System.Drawing.Point(777, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 204);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GridTextColumn Options";
            // 
            // verticalScrollBarCheckBox
            // 
            this.verticalScrollBarCheckBox.AutoSize = true;
            this.verticalScrollBarCheckBox.Location = new System.Drawing.Point(20, 167);
            this.verticalScrollBarCheckBox.Name = "verticalScrollBarCheckBox";
            this.verticalScrollBarCheckBox.Size = new System.Drawing.Size(195, 24);
            this.verticalScrollBarCheckBox.TabIndex = 13;
            this.verticalScrollBarCheckBox.Text = "Enable VerticalScrollBar";
            this.verticalScrollBarCheckBox.UseVisualStyleBackColor = true;
            this.verticalScrollBarCheckBox.CheckedChanged += new System.EventHandler(this.verticalScrollBarCheckBox_CheckedChanged);
            // 
            // wordWrapCheckBox
            // 
            this.wordWrapCheckBox.AutoSize = true;
            this.wordWrapCheckBox.Location = new System.Drawing.Point(20, 142);
            this.wordWrapCheckBox.Name = "wordWrapCheckBox";
            this.wordWrapCheckBox.Size = new System.Drawing.Size(155, 24);
            this.wordWrapCheckBox.TabIndex = 12;
            this.wordWrapCheckBox.Text = "Enable Wordwrap";
            this.wordWrapCheckBox.UseVisualStyleBackColor = true;
            this.wordWrapCheckBox.CheckedChanged += new System.EventHandler(this.wordWrapCheckBox_CheckedChanged);
            // 
            // allowMultilineCheckBox
            // 
            this.allowMultilineCheckBox.AutoSize = true;
            this.allowMultilineCheckBox.Location = new System.Drawing.Point(20, 117);
            this.allowMultilineCheckBox.Name = "allowMultilineCheckBox";
            this.allowMultilineCheckBox.Size = new System.Drawing.Size(137, 24);
            this.allowMultilineCheckBox.TabIndex = 11;
            this.allowMultilineCheckBox.Text = "Allow Multiline";
            this.allowMultilineCheckBox.UseVisualStyleBackColor = true;
            this.allowMultilineCheckBox.CheckedChanged += new System.EventHandler(this.allowMultilineCheckBox_CheckedChanged);
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
            "SingleClick",
            "DoubleClick"});
            this.selectedColumnComboBox.Location = new System.Drawing.Point(20, 47);
            this.selectedColumnComboBox.Name = "selectedColumnComboBox";
            this.selectedColumnComboBox.Size = new System.Drawing.Size(152, 28);
            this.selectedColumnComboBox.TabIndex = 9;
            this.selectedColumnComboBox.SelectedIndexChanged += new System.EventHandler(this.selectedColumnComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(20, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Selected Column :";
            // 
            // colAllowEditingCheckBox
            // 
            this.colAllowEditingCheckBox.AutoSize = true;
            this.colAllowEditingCheckBox.Location = new System.Drawing.Point(20, 92);
            this.colAllowEditingCheckBox.Name = "colAllowEditingCheckBox";
            this.colAllowEditingCheckBox.Size = new System.Drawing.Size(124, 24);
            this.colAllowEditingCheckBox.TabIndex = 10;
            this.colAllowEditingCheckBox.Text = "Allow Editing";
            this.colAllowEditingCheckBox.UseVisualStyleBackColor = true;

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
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editing";
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox editModeComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox allowEditingCheckBox;
        private System.Windows.Forms.ComboBox selectionBehaviorComBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox colAllowEditingCheckBox;
        private System.Windows.Forms.ComboBox selectedColumnComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox allowMultilineCheckBox;
        private System.Windows.Forms.CheckBox wordWrapCheckBox;
        private System.Windows.Forms.CheckBox verticalScrollBarCheckBox;
    }
}