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
using System.Drawing;

namespace Serialization
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
            this.s_style = new System.Windows.Forms.CheckBox();
            this.s_columns = new System.Windows.Forms.CheckBox();
            this.s_grouping = new System.Windows.Forms.CheckBox();
            this.s_sorting = new System.Windows.Forms.CheckBox();
            this.s_filtering = new System.Windows.Forms.CheckBox();
            this.s_groupsummary = new System.Windows.Forms.CheckBox();
            this.s_captionsummary = new System.Windows.Forms.CheckBox();
            this.s_unboundrows = new System.Windows.Forms.CheckBox();
            this.s_tablesummary = new System.Windows.Forms.CheckBox();
            this.s_stackedheaders = new System.Windows.Forms.CheckBox();
            this.btn_serialize = new Syncfusion.WinForms.Controls.SfButton();
            this.de_styles = new System.Windows.Forms.CheckBox();
            this.de_columns = new System.Windows.Forms.CheckBox();
            this.de_grouping = new System.Windows.Forms.CheckBox();
            this.de_sorting = new System.Windows.Forms.CheckBox();
            this.de_filtering = new System.Windows.Forms.CheckBox();
            this.de_groupsummary = new System.Windows.Forms.CheckBox();
            this.de_captionsummary = new System.Windows.Forms.CheckBox();
            this.de_unboundrows = new System.Windows.Forms.CheckBox();
            this.de_tablesummaries = new System.Windows.Forms.CheckBox();
            this.de_stackedheaders = new System.Windows.Forms.CheckBox();
            this.btn_deserialize = new Syncfusion.WinForms.Controls.SfButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sfDataGrid2 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // s_style
            // 
            this.s_style.AutoSize = true;
            this.s_style.Checked = true;
            this.s_style.CheckState = System.Windows.Forms.CheckState.Checked;
            this.s_style.Location = new System.Drawing.Point(6, 20);
            this.s_style.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.s_style.Name = "s_style";
            this.s_style.Size = new System.Drawing.Size(142, 24);
            this.s_style.TabIndex = 21;
            this.s_style.Text = "Serialize Styles";
            this.s_style.UseVisualStyleBackColor = true;
            // 
            // s_columns
            // 
            this.s_columns.AutoSize = true;
            this.s_columns.Checked = true;
            this.s_columns.CheckState = System.Windows.Forms.CheckState.Checked;
            this.s_columns.Location = new System.Drawing.Point(6, 40);
            this.s_columns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.s_columns.Name = "s_columns";
            this.s_columns.Size = new System.Drawing.Size(161, 24);
            this.s_columns.TabIndex = 22;
            this.s_columns.Text = "Serialize Columns";
            this.s_columns.UseVisualStyleBackColor = true;
            // 
            // s_grouping
            // 
            this.s_grouping.AutoSize = true;
            this.s_grouping.Checked = true;
            this.s_grouping.CheckState = System.Windows.Forms.CheckState.Checked;
            this.s_grouping.Location = new System.Drawing.Point(6, 60);
            this.s_grouping.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.s_grouping.Name = "s_grouping";
            this.s_grouping.Size = new System.Drawing.Size(165, 24);
            this.s_grouping.TabIndex = 23;
            this.s_grouping.Text = "Serialize Grouping";
            this.s_grouping.UseVisualStyleBackColor = true;
            // 
            // s_sorting
            // 
            this.s_sorting.AutoSize = true;
            this.s_sorting.Checked = true;
            this.s_sorting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.s_sorting.Location = new System.Drawing.Point(6, 80);
            this.s_sorting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.s_sorting.Name = "s_sorting";
            this.s_sorting.Size = new System.Drawing.Size(150, 24);
            this.s_sorting.TabIndex = 24;
            this.s_sorting.Text = "Serialize Sorting";
            this.s_sorting.UseVisualStyleBackColor = true;
            // 
            // s_filtering
            // 
            this.s_filtering.AutoSize = true;
            this.s_filtering.Checked = true;
            this.s_filtering.CheckState = System.Windows.Forms.CheckState.Checked;
            this.s_filtering.Location = new System.Drawing.Point(6, 100);
            this.s_filtering.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.s_filtering.Name = "s_filtering";
            this.s_filtering.Size = new System.Drawing.Size(155, 24);
            this.s_filtering.TabIndex = 25;
            this.s_filtering.Text = "Serialize Filtering";
            this.s_filtering.UseVisualStyleBackColor = true;
            // 
            // s_groupsummary
            // 
            this.s_groupsummary.AutoSize = true;
            this.s_groupsummary.Checked = true;
            this.s_groupsummary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.s_groupsummary.Location = new System.Drawing.Point(6, 120);
            this.s_groupsummary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.s_groupsummary.Name = "s_groupsummary";
            this.s_groupsummary.Size = new System.Drawing.Size(228, 24);
            this.s_groupsummary.TabIndex = 26;
            this.s_groupsummary.Text = "Serialize Group Summaries";
            this.s_groupsummary.UseVisualStyleBackColor = true;
            // 
            // s_captionsummary
            // 
            this.s_captionsummary.AutoSize = true;
            this.s_captionsummary.Checked = true;
            this.s_captionsummary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.s_captionsummary.Location = new System.Drawing.Point(6, 140);
            this.s_captionsummary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.s_captionsummary.Name = "s_captionsummary";
            this.s_captionsummary.Size = new System.Drawing.Size(225, 24);
            this.s_captionsummary.TabIndex = 27;
            this.s_captionsummary.Text = "Serialize Caption Summary";
            this.s_captionsummary.UseVisualStyleBackColor = true;
            // 
            // s_unboundrows
            // 
            this.s_unboundrows.AutoSize = true;
            this.s_unboundrows.Checked = true;
            this.s_unboundrows.CheckState = System.Windows.Forms.CheckState.Checked;
            this.s_unboundrows.Location = new System.Drawing.Point(6, 160);
            this.s_unboundrows.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.s_unboundrows.Name = "s_unboundrows";
            this.s_unboundrows.Size = new System.Drawing.Size(209, 24);
            this.s_unboundrows.TabIndex = 28;
            this.s_unboundrows.Text = "Serialize Unbound Rows";
            this.s_unboundrows.UseVisualStyleBackColor = true;
            // 
            // s_tablesummary
            // 
            this.s_tablesummary.AutoSize = true;
            this.s_tablesummary.Checked = true;
            this.s_tablesummary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.s_tablesummary.Location = new System.Drawing.Point(6, 180);
            this.s_tablesummary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.s_tablesummary.Name = "s_tablesummary";
            this.s_tablesummary.Size = new System.Drawing.Size(222, 24);
            this.s_tablesummary.TabIndex = 29;
            this.s_tablesummary.Text = "Serialize Table Summaries";
            this.s_tablesummary.UseVisualStyleBackColor = true;
            // 
            // s_stackedheaders
            // 
            this.s_stackedheaders.AutoSize = true;
            this.s_stackedheaders.Checked = true;
            this.s_stackedheaders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.s_stackedheaders.Location = new System.Drawing.Point(6, 200);
            this.s_stackedheaders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.s_stackedheaders.Name = "s_stackedheaders";
            this.s_stackedheaders.Size = new System.Drawing.Size(215, 24);
            this.s_stackedheaders.TabIndex = 30;
            this.s_stackedheaders.Text = "Serialize Stacked Header";
            this.s_stackedheaders.UseVisualStyleBackColor = true;
            // 
            // btn_serialize
            // 
            this.btn_serialize.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn_serialize.Location = new System.Drawing.Point(35, 220);
            this.btn_serialize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_serialize.Name = "btn_serialize";
            this.btn_serialize.Size = new System.Drawing.Size(100, 20);
            this.btn_serialize.TabIndex = 31;
            this.btn_serialize.Text = "Serialize";
            this.btn_serialize.Style.Border = Pens.Black;
            this.btn_serialize.Click += new System.EventHandler(this.btn_serialize_Click);
            // 
            // de_styles
            // 
            this.de_styles.AutoSize = true;
            this.de_styles.Checked = true;
            this.de_styles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.de_styles.Location = new System.Drawing.Point(6, 25);
            this.de_styles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.de_styles.Name = "de_styles";
            this.de_styles.Size = new System.Drawing.Size(160, 24);
            this.de_styles.TabIndex = 22;
            this.de_styles.Text = "Deserialize Styles";
            this.de_styles.UseVisualStyleBackColor = true;
            // 
            // de_columns
            // 
            this.de_columns.AutoSize = true;
            this.de_columns.Checked = true;
            this.de_columns.CheckState = System.Windows.Forms.CheckState.Checked;
            this.de_columns.Location = new System.Drawing.Point(6, 45);
            this.de_columns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.de_columns.Name = "de_columns";
            this.de_columns.Size = new System.Drawing.Size(179, 24);
            this.de_columns.TabIndex = 23;
            this.de_columns.Text = "Deserialize Columns";
            this.de_columns.UseVisualStyleBackColor = true;
            // 
            // de_grouping
            // 
            this.de_grouping.AutoSize = true;
            this.de_grouping.Checked = true;
            this.de_grouping.CheckState = System.Windows.Forms.CheckState.Checked;
            this.de_grouping.Location = new System.Drawing.Point(6, 65);
            this.de_grouping.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.de_grouping.Name = "de_grouping";
            this.de_grouping.Size = new System.Drawing.Size(183, 24);
            this.de_grouping.TabIndex = 24;
            this.de_grouping.Text = "Deserialize Grouping";
            this.de_grouping.UseVisualStyleBackColor = true;
            // 
            // de_sorting
            // 
            this.de_sorting.AutoSize = true;
            this.de_sorting.Checked = true;
            this.de_sorting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.de_sorting.Location = new System.Drawing.Point(6, 85);
            this.de_sorting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.de_sorting.Name = "de_sorting";
            this.de_sorting.Size = new System.Drawing.Size(168, 24);
            this.de_sorting.TabIndex = 25;
            this.de_sorting.Text = "Deserialize Sorting";
            this.de_sorting.UseVisualStyleBackColor = true;
            // 
            // de_filtering
            // 
            this.de_filtering.AutoSize = true;
            this.de_filtering.Checked = true;
            this.de_filtering.CheckState = System.Windows.Forms.CheckState.Checked;
            this.de_filtering.Location = new System.Drawing.Point(6, 105);
            this.de_filtering.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.de_filtering.Name = "de_filtering";
            this.de_filtering.Size = new System.Drawing.Size(173, 24);
            this.de_filtering.TabIndex = 26;
            this.de_filtering.Text = "Deserialize Filtering";
            this.de_filtering.UseVisualStyleBackColor = true;
            // 
            // de_groupsummary
            // 
            this.de_groupsummary.AutoSize = true;
            this.de_groupsummary.Checked = true;
            this.de_groupsummary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.de_groupsummary.Location = new System.Drawing.Point(6, 125);
            this.de_groupsummary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.de_groupsummary.Name = "de_groupsummary";
            this.de_groupsummary.Size = new System.Drawing.Size(246, 24);
            this.de_groupsummary.TabIndex = 27;
            this.de_groupsummary.Text = "Deserialize Group Summaries";
            this.de_groupsummary.UseVisualStyleBackColor = true;
            // 
            // de_captionsummary
            // 
            this.de_captionsummary.AutoSize = true;
            this.de_captionsummary.Checked = true;
            this.de_captionsummary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.de_captionsummary.Location = new System.Drawing.Point(6, 145);
            this.de_captionsummary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.de_captionsummary.Name = "de_captionsummary";
            this.de_captionsummary.Size = new System.Drawing.Size(243, 24);
            this.de_captionsummary.TabIndex = 28;
            this.de_captionsummary.Text = "Deserialize Caption Summary";
            this.de_captionsummary.UseVisualStyleBackColor = true;
            // 
            // de_unboundrows
            // 
            this.de_unboundrows.AutoSize = true;
            this.de_unboundrows.Checked = true;
            this.de_unboundrows.CheckState = System.Windows.Forms.CheckState.Checked;
            this.de_unboundrows.Location = new System.Drawing.Point(6, 165);
            this.de_unboundrows.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.de_unboundrows.Name = "de_unboundrows";
            this.de_unboundrows.Size = new System.Drawing.Size(227, 24);
            this.de_unboundrows.TabIndex = 29;
            this.de_unboundrows.Text = "Deserialize Unbound Rows";
            this.de_unboundrows.UseVisualStyleBackColor = true;
            // 
            // de_tablesummaries
            // 
            this.de_tablesummaries.AutoSize = true;
            this.de_tablesummaries.Checked = true;
            this.de_tablesummaries.CheckState = System.Windows.Forms.CheckState.Checked;
            this.de_tablesummaries.Location = new System.Drawing.Point(6, 185);
            this.de_tablesummaries.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.de_tablesummaries.Name = "de_tablesummaries";
            this.de_tablesummaries.Size = new System.Drawing.Size(240, 24);
            this.de_tablesummaries.TabIndex = 30;
            this.de_tablesummaries.Text = "Deserialize Table Summaries";
            this.de_tablesummaries.UseVisualStyleBackColor = true;
            // 
            // de_stackedheaders
            // 
            this.de_stackedheaders.AutoSize = true;
            this.de_stackedheaders.Checked = true;
            this.de_stackedheaders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.de_stackedheaders.Location = new System.Drawing.Point(6, 205);
            this.de_stackedheaders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.de_stackedheaders.Name = "de_stackedheaders";
            this.de_stackedheaders.Size = new System.Drawing.Size(241, 24);
            this.de_stackedheaders.TabIndex = 31;
            this.de_stackedheaders.Text = "Deserialize Stacked Headers";
            this.de_stackedheaders.UseVisualStyleBackColor = true;
            // 
            // btn_deserialize
            // 
            this.btn_deserialize.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn_deserialize.Location = new System.Drawing.Point(35, 225);
            this.btn_deserialize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_deserialize.Name = "btn_deserialize";
            this.btn_deserialize.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.btn_deserialize.Size = new System.Drawing.Size(100, 20);
            this.btn_deserialize.TabIndex = 32;
            this.btn_deserialize.Text = "Deserialize";
            this.btn_deserialize.Style.Border = Pens.Black;
            this.btn_deserialize.Click += new System.EventHandler(this.btn_deserialize_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.s_style);
            this.groupBox1.Controls.Add(this.s_columns);
            this.groupBox1.Controls.Add(this.s_grouping);
            this.groupBox1.Controls.Add(this.btn_serialize);
            this.groupBox1.Controls.Add(this.s_sorting);
            this.groupBox1.Controls.Add(this.s_filtering);
            this.groupBox1.Controls.Add(this.s_groupsummary);
            this.groupBox1.Controls.Add(this.s_stackedheaders);
            this.groupBox1.Controls.Add(this.s_captionsummary);
            this.groupBox1.Controls.Add(this.s_unboundrows);
            this.groupBox1.Controls.Add(this.s_tablesummary);
            this.groupBox1.Location = new System.Drawing.Point(860, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 260);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serialization";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.de_styles);
            this.groupBox2.Controls.Add(this.de_columns);
            this.groupBox2.Controls.Add(this.btn_deserialize);
            this.groupBox2.Controls.Add(this.de_tablesummaries);
            this.groupBox2.Controls.Add(this.de_grouping);
            this.groupBox2.Controls.Add(this.de_stackedheaders);
            this.groupBox2.Controls.Add(this.de_sorting);
            this.groupBox2.Controls.Add(this.de_unboundrows);
            this.groupBox2.Controls.Add(this.de_filtering);
            this.groupBox2.Controls.Add(this.de_groupsummary);
            this.groupBox2.Controls.Add(this.de_captionsummary);
            this.groupBox2.Location = new System.Drawing.Point(860, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 270);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deserialization";
            // 
            // sfDataGrid2
            // 
            this.sfDataGrid2.AllowFiltering = true;
            this.sfDataGrid2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDataGrid2.AutoGenerateColumns = false;
            this.sfDataGrid2.AutoSizeColumnsMode = AutoSizeColumnsMode.Fill;
            this.sfDataGrid2.Location = new System.Drawing.Point(10, 5);
            this.sfDataGrid2.Name = "sfDataGrid2";
			this.sfDataGrid2.RowHeight = (int)DpiAware.LogicalToDeviceUnits(21.0f);
            this.sfDataGrid2.ShowGroupDropArea = true;
            this.sfDataGrid2.Size = new System.Drawing.Size(840, 566);
            this.sfDataGrid2.TabIndex = 35;
            this.sfDataGrid2.Text = "sfDataGrid2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 576);
            this.Controls.Add(this.sfDataGrid2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.BackColor = Color.White;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serialization";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
      
        private System.Windows.Forms.CheckBox s_style;
        private System.Windows.Forms.CheckBox s_columns;
        private System.Windows.Forms.CheckBox s_grouping;
        private System.Windows.Forms.CheckBox s_sorting;
        private System.Windows.Forms.CheckBox s_filtering;
        private System.Windows.Forms.CheckBox s_groupsummary;
        private System.Windows.Forms.CheckBox s_captionsummary;
        private System.Windows.Forms.CheckBox s_unboundrows;
        private System.Windows.Forms.CheckBox s_tablesummary;
        private System.Windows.Forms.CheckBox s_stackedheaders;
        private Syncfusion.WinForms.Controls.SfButton btn_serialize;
        private System.Windows.Forms.CheckBox de_styles;
        private System.Windows.Forms.CheckBox de_columns;
        private System.Windows.Forms.CheckBox de_grouping;
        private System.Windows.Forms.CheckBox de_sorting;
        private System.Windows.Forms.CheckBox de_filtering;
        private System.Windows.Forms.CheckBox de_groupsummary;
        private System.Windows.Forms.CheckBox de_captionsummary;
        private System.Windows.Forms.CheckBox de_unboundrows;
        private System.Windows.Forms.CheckBox de_tablesummaries;
        private System.Windows.Forms.CheckBox de_stackedheaders;
        private Syncfusion.WinForms.Controls.SfButton btn_deserialize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid2;
    }
}