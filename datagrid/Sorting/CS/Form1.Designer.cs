#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using System.Collections.Specialized;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace Sorting
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
                sortCheckBox.CheckedChanged -= OnCheckBoxChanged;
                triStateCheckBox.CheckedChanged -= OnTriStateCheckBoxChanged;
                sortNumberCheckBox.CheckedChanged -= OnSortNumberCheckBoxChanged;
                orderIdCheckBox.CheckedChanged -= OnOrderIdCheckBoxChanged;
                customerIdCheckBox.CheckedChanged -= OnCustomerIdCheckBoxChanged;
                comboBoxAdv1.SelectedIndexChanged -= OnComboBoxSelectedIndexChanged;
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.sortNumberCheckBox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.orderIdCheckBox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.customerIdCheckBox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.sfDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.sortCheckBox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.triStateCheckBox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.Options = new System.Windows.Forms.GroupBox();
            this.comboBoxAdv1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.sortNumberCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderIdCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerIdCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triStateCheckBox)).BeginInit();
            this.Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // sortNumberCheckBox
            // 
            this.sortNumberCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sortNumberCheckBox.BeforeTouchSize = new System.Drawing.Size(183, 20);
            this.sortNumberCheckBox.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.sortNumberCheckBox.Location = new System.Drawing.Point(5, 70);
            this.sortNumberCheckBox.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.sortNumberCheckBox.Name = "sortNumberCheckBox";
            this.sortNumberCheckBox.Size = new System.Drawing.Size(183, 20);
            this.sortNumberCheckBox.TabIndex = 4;
            this.sortNumberCheckBox.Text = "Show Sort Numbers";
            this.sortNumberCheckBox.ThemesEnabled = false;
            this.sortNumberCheckBox.CheckStateChanged += new System.EventHandler(this.OnSortNumberCheckBoxChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Allow Sort for Columns";
            // 
            // orderIdCheckBox
            // 
            this.orderIdCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.orderIdCheckBox.BeforeTouchSize = new System.Drawing.Size(160, 35);
            this.orderIdCheckBox.Checked = true;
            this.orderIdCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.orderIdCheckBox.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.orderIdCheckBox.Location = new System.Drawing.Point(5, 181);
            this.orderIdCheckBox.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.orderIdCheckBox.Name = "orderIdCheckBox";
            this.orderIdCheckBox.Size = new System.Drawing.Size(160, 35);
            this.orderIdCheckBox.TabIndex = 7;
            this.orderIdCheckBox.Text = "Allow Sort OrderID Column";
            this.orderIdCheckBox.ThemesEnabled = false;
            this.orderIdCheckBox.CheckStateChanged += new System.EventHandler(this.OnOrderIdCheckBoxChanged);
            // 
            // customerIdCheckBox
            // 
            this.customerIdCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customerIdCheckBox.BeforeTouchSize = new System.Drawing.Size(179, 35);
            this.customerIdCheckBox.Checked = true;
            this.customerIdCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.customerIdCheckBox.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.customerIdCheckBox.Location = new System.Drawing.Point(6, 215);
            this.customerIdCheckBox.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.customerIdCheckBox.Name = "customerIdCheckBox";
            this.customerIdCheckBox.Size = new System.Drawing.Size(179, 35);
            this.customerIdCheckBox.TabIndex = 8;
            this.customerIdCheckBox.Text = "Allow Sort CustomerID Column";
            this.customerIdCheckBox.ThemesEnabled = false;
            this.customerIdCheckBox.CheckStateChanged += new System.EventHandler(this.OnCustomerIdCheckBoxChanged);
            // 
            // sfDataGrid
            // 
            this.sfDataGrid.AccessibleName = "Table";
            this.sfDataGrid.AllowFiltering = true;
            this.sfDataGrid.AllowResizingColumns = true;
            this.sfDataGrid.AllowTriStateSorting = true;
            this.sfDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.ColumnHeader;
            this.sfDataGrid.BackColor = System.Drawing.SystemColors.Window;
            this.sfDataGrid.Location = new System.Drawing.Point(10, 5);
            this.sfDataGrid.Name = "sfDataGrid";
            this.sfDataGrid.SortColumnDescriptions.Add(new SortColumnDescription() { ColumnName = "CustomerID", SortDirection = System.ComponentModel.ListSortDirection.Descending });
            this.sfDataGrid.ShowGroupDropArea = true;
            this.sfDataGrid.Size = new System.Drawing.Size(766, 540);
            this.sfDataGrid.TabIndex = 0;
            // 
            // sortCheckBox
            // 
            this.sortCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sortCheckBox.BeforeTouchSize = new System.Drawing.Size(160, 20);
            this.sortCheckBox.Checked = true;
            this.sortCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sortCheckBox.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.sortCheckBox.Location = new System.Drawing.Point(5, 21);
            this.sortCheckBox.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.sortCheckBox.Name = "sortCheckBox";
            this.sortCheckBox.Size = new System.Drawing.Size(160, 20);
            this.sortCheckBox.TabIndex = 2;
            this.sortCheckBox.Text = "Allow Sorting";
            this.sortCheckBox.ThemesEnabled = false;
            this.sortCheckBox.CheckStateChanged += new System.EventHandler(this.OnCheckBoxChanged);
            // 
            // triStateCheckBox
            // 
            this.triStateCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.triStateCheckBox.BeforeTouchSize = new System.Drawing.Size(180, 20);
            this.triStateCheckBox.Checked = true;
            this.triStateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.triStateCheckBox.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.triStateCheckBox.Location = new System.Drawing.Point(5, 45);
            this.triStateCheckBox.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.triStateCheckBox.Name = "triStateCheckBox";
            this.triStateCheckBox.Size = new System.Drawing.Size(180, 20);
            this.triStateCheckBox.TabIndex = 3;
            this.triStateCheckBox.Text = "Allow TriState Sorting";
            this.triStateCheckBox.ThemesEnabled = false;
            this.triStateCheckBox.CheckStateChanged += new System.EventHandler(this.OnTriStateCheckBoxChanged);
            // 
            // Options
            // 
            this.Options.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Options.Controls.Add(this.comboBoxAdv1);
            this.Options.Controls.Add(this.sortCheckBox);
            this.Options.Controls.Add(this.triStateCheckBox);
            this.Options.Controls.Add(this.customerIdCheckBox);
            this.Options.Controls.Add(this.orderIdCheckBox);
            this.Options.Controls.Add(this.label2);
            this.Options.Controls.Add(this.sortNumberCheckBox);
            this.Options.Location = new System.Drawing.Point(794, 10);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(200, 291);
            this.Options.TabIndex = 1;
            this.Options.TabStop = false;
            this.Options.Text = "Options";
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.FormattingEnabled = true;
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "SingleClick",
            "DoubleClick"});
            this.comboBoxAdv1.Location = new System.Drawing.Point(9, 117);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(176, 24);
            this.comboBoxAdv1.TabIndex = 5;
            // 
            // Form1
            // 
		    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1006, 553);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.sfDataGrid);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorting";
            ((System.ComponentModel.ISupportInitialize)(this.sortNumberCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderIdCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerIdCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triStateCheckBox)).EndInit();
            this.Options.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #region API Definitions
        private SfDataGrid sfDataGrid;
        private OrderInfoCollection data;
        private CheckBoxAdv sortNumberCheckBox;
        private Label label2;
        private CheckBoxAdv orderIdCheckBox;
        private CheckBoxAdv triStateCheckBox;
        private CheckBoxAdv sortCheckBox;
        private CheckBoxAdv customerIdCheckBox;

        #endregion

        private GroupBox Options;
        private ComboBox comboBoxAdv1;
    }
}

