#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;

namespace ClipBoardsOperations
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.selectionModeComboBox = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.ListBox();
            this.checkListBox2 = new System.Windows.Forms.ListBox();
            this.editTrigger = new System.Windows.Forms.ComboBox();
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.editTrigger);
            this.groupBox1.Controls.Add(this.checkListBox2);
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Controls.Add(this.selectionModeComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(870, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 400);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selection Mode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Copy Options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Paste Options";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edit Mode";
            // 
            // selectionModeComboBox
            // 
            this.selectionModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectionModeComboBox.FormattingEnabled = true;
            this.selectionModeComboBox.Items.AddRange(new object[] {
            "None",
            "Single",
            "Single Deselect",
            "Multiple",
            "Extended"});
            this.selectionModeComboBox.Location = new System.Drawing.Point(13, 62);
            this.selectionModeComboBox.Name = "selectionModeComboBox";
            this.selectionModeComboBox.Size = new System.Drawing.Size(121, 24);
            this.selectionModeComboBox.TabIndex = 4;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.ItemHeight = 16;
            this.checkedListBox1.Items.AddRange(new object[] {
            "None",
            "Copy Data",
            "Cut Data",
            "Include Hidden Column",
            "Include Headers",
            "Include Format"});
            this.checkedListBox1.Location = new System.Drawing.Point(21, 130);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.checkedListBox1.Size = new System.Drawing.Size(150, 84);
            this.checkedListBox1.TabIndex = 5;
            // 
            // checkListBox2
            // 
            this.checkListBox2.FormattingEnabled = true;
            this.checkListBox2.ItemHeight = 16;
            this.checkListBox2.Items.AddRange(new object[] {
            "None",
            "Paste Data",
            "Include Hidden Column",
            "Exclude First Line"});
            this.checkListBox2.Location = new System.Drawing.Point(19, 258);
            this.checkListBox2.Name = "checkListBox2";
            this.checkListBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.checkListBox2.Size = new System.Drawing.Size(150, 68);
            this.checkListBox2.TabIndex = 6;
            // 
            // editTrigger
            // 
            this.editTrigger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editTrigger.FormattingEnabled = true;
            this.editTrigger.Items.AddRange(new object[] {
            "SingleClick",
            "DoubleClick"});
            this.editTrigger.Location = new System.Drawing.Point(21, 370);
            this.editTrigger.Name = "editTrigger";
            this.editTrigger.Size = new System.Drawing.Size(121, 24);
            this.editTrigger.TabIndex = 7;
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AccessibleName = "Table";
            this.sfDataGrid1.AllowResizingColumns = true;
            this.sfDataGrid1.AllowResizingHiddenColumns = true;
            this.sfDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDataGrid1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.sfDataGrid1.Location = new System.Drawing.Point(10, 5);
            this.sfDataGrid1.Name = "sfDataGrid1";
			this.sfDataGrid1.RowHeight = (int)DpiAware.LogicalToDeviceUnits(21.0f);
            this.sfDataGrid1.Size = new System.Drawing.Size(840, 540);
            this.sfDataGrid1.TabIndex = 0;
            this.sfDataGrid1.Text = "sfDataGrid1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sfDataGrid1);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clipboard Operations";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox selectionModeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox checkedListBox1;
        private System.Windows.Forms.ListBox checkListBox2;
        private System.Windows.Forms.ComboBox editTrigger;
    }
}

