#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using System.Windows.Forms;

namespace ColumnChooser
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
            this.btnShowColumnChooserPopup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkShowColumnChooser = new System.Windows.Forms.CheckBox();
            this.sfDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowColumnChooserPopup
            // 
            this.btnShowColumnChooserPopup.Location = new System.Drawing.Point(40, 42);
            this.btnShowColumnChooserPopup.Name = "btnShowColumnChooserPopup";
            this.btnShowColumnChooserPopup.Size = new System.Drawing.Size(171, 23);
            this.btnShowColumnChooserPopup.TabIndex = 2;
            this.btnShowColumnChooserPopup.Text = "Show Column Chooser Popup";
            this.btnShowColumnChooserPopup.UseVisualStyleBackColor = true;
            this.btnShowColumnChooserPopup.Click += new System.EventHandler(this.OnShowColumnChooserPopupClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Options";
            // 
            // chkShowColumnChooser
            // 
            this.chkShowColumnChooser.AutoSize = true;
            this.chkShowColumnChooser.Checked = true;
            this.chkShowColumnChooser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowColumnChooser.Location = new System.Drawing.Point(39, 85);
            this.chkShowColumnChooser.Name = "chkShowColumnChooser";
            this.chkShowColumnChooser.Size = new System.Drawing.Size(183, 17);
            this.chkShowColumnChooser.TabIndex = 4;
            this.chkShowColumnChooser.Text = "Show Column Chooser as Control";
            this.chkShowColumnChooser.UseVisualStyleBackColor = true;
            this.chkShowColumnChooser.CheckedChanged += new System.EventHandler(this.OnShowColumnChooserCheckedChanged);
            // 
            // sfDataGrid
            // 
            this.sfDataGrid.AccessibleName = "Table";
            this.sfDataGrid.AllowDraggingColumns = true;
            this.sfDataGrid.AllowResizingColumns = true;
            this.sfDataGrid.AllowResizingHiddenColumns = true;
            this.sfDataGrid.Dock = DockStyle.Fill;
            this.sfDataGrid.BackColor = System.Drawing.SystemColors.Window;
            this.sfDataGrid.Location = new System.Drawing.Point(12, 12);
            this.sfDataGrid.Name = "sfDataGrid";
			this.sfDataGrid.RowHeight = (int)DpiAware.LogicalToDeviceUnits(21.0f);
            this.sfDataGrid.Size = new System.Drawing.Size(745, 550);
            this.sfDataGrid.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1047, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 661);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1069, 573);
            this.Controls.Add(this.sfDataGrid);
            this.Controls.Add(this.panel1);
            this.panel1.Controls.Add(this.chkShowColumnChooser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnShowColumnChooserPopup);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(700, 520);
            this.Name = "Form1";
            this.ShowIcon = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Column Chooser";
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region API Definition

        private SfDataGrid sfDataGrid;
        
        #endregion
        private Button btnShowColumnChooserPopup;
        private Label label1;
        private CheckBox chkShowColumnChooser;
        private Panel panel1;
    }
}

