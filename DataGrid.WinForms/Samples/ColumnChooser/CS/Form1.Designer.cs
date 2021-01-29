#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
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
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowColumnChooserPopup
            // 
            this.btnShowColumnChooserPopup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowColumnChooserPopup.Location = new System.Drawing.Point(785, 42);
            this.btnShowColumnChooserPopup.Name = "btnShowColumnChooserPopup";
            this.btnShowColumnChooserPopup.Size = new System.Drawing.Size(171, 23);
            this.btnShowColumnChooserPopup.TabIndex = 2;
            this.btnShowColumnChooserPopup.Text = "Show Column Chooser Popup";
            this.btnShowColumnChooserPopup.UseVisualStyleBackColor = true;
            this.btnShowColumnChooserPopup.Click += new System.EventHandler(this.OnShowColumnChooserPopupClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(782, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Options";
            // 
            // chkShowColumnChooser
            // 
            this.chkShowColumnChooser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowColumnChooser.AutoSize = true;
            this.chkShowColumnChooser.Checked = true;
            this.chkShowColumnChooser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowColumnChooser.Location = new System.Drawing.Point(785, 85);
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
            this.sfDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDataGrid.BackColor = System.Drawing.SystemColors.Window;
            this.sfDataGrid.Location = new System.Drawing.Point(12, 12);
            this.sfDataGrid.Name = "sfDataGrid";
			this.sfDataGrid.RowHeight = 21;
            this.sfDataGrid.Size = new System.Drawing.Size(745, 550);
            this.sfDataGrid.TabIndex = 1;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1069, 573);
            this.Controls.Add(this.chkShowColumnChooser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowColumnChooserPopup);
            this.Controls.Add(this.sfDataGrid);
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
    }
}

