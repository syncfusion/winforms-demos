#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Excel_Exporting_Demo
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
            this.components = new System.ComponentModel.Container();
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.customizeStylesInEvent = new System.Windows.Forms.CheckBox();
            this.exportToExcelBtn = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.canExportColumnWidth = new System.Windows.Forms.CheckBox();
            this.canExportRowHeight = new System.Windows.Forms.CheckBox();
            this.exportNestedTableCaption = new System.Windows.Forms.CheckBox();
            this.showGridLines = new System.Windows.Forms.CheckBox();
            this.exportNestedTableWithIndent = new System.Windows.Forms.CheckBox();
            this.enableOptimization = new System.Windows.Forms.CheckBox();
            this.applyExcelFilter = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.exportGroupSummary = new System.Windows.Forms.CheckBox();
            this.exportTableSummary = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exportStyle = new System.Windows.Forms.CheckBox();
            this.exportBorders = new System.Windows.Forms.CheckBox();
            this.outliningGroupBox = new System.Windows.Forms.GroupBox();
            this.allowGroupOutlining = new System.Windows.Forms.CheckBox();
            this.allowNestedTableOutlining = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.outliningGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.Location = new System.Drawing.Point(12, 3);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.Size = new System.Drawing.Size(672, 582);
            this.gridGroupingControl1.TabIndex = 0;
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.VersionInfo = "13.2400.0.29";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.exportToExcelBtn);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.outliningGroupBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(690, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 582);
            this.panel1.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.customizeStylesInEvent);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(21, 418);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(326, 52);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Event customization";
            // 
            // customizeStylesInEvent
            // 
            this.customizeStylesInEvent.Checked = true;
            this.customizeStylesInEvent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.customizeStylesInEvent.Location = new System.Drawing.Point(9, 22);
            this.customizeStylesInEvent.Name = "customizeStylesInEvent";
            this.customizeStylesInEvent.Size = new System.Drawing.Size(236, 24);
            this.customizeStylesInEvent.TabIndex = 14;
            this.customizeStylesInEvent.Text = "Customize styles in event";
            this.customizeStylesInEvent.UseVisualStyleBackColor = true;            
            // 
            // exportToExcelBtn
            // 
            this.exportToExcelBtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.exportToExcelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.exportToExcelBtn.BeforeTouchSize = new System.Drawing.Size(105, 43);
            this.exportToExcelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportToExcelBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportToExcelBtn.ForeColor = System.Drawing.Color.White;
            this.exportToExcelBtn.IsBackStageButton = false;
            this.exportToExcelBtn.Location = new System.Drawing.Point(125, 479);
            this.exportToExcelBtn.Name = "exportToExcelBtn";
            this.exportToExcelBtn.Size = new System.Drawing.Size(105, 43);
            this.exportToExcelBtn.TabIndex = 15;
            this.exportToExcelBtn.Text = "Export To Excel";
            this.exportToExcelBtn.Click += new System.EventHandler(this.exportToExcelBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.canExportColumnWidth);
            this.groupBox4.Controls.Add(this.canExportRowHeight);
            this.groupBox4.Controls.Add(this.exportNestedTableCaption);
            this.groupBox4.Controls.Add(this.showGridLines);
            this.groupBox4.Controls.Add(this.exportNestedTableWithIndent);
            this.groupBox4.Controls.Add(this.enableOptimization);
            this.groupBox4.Controls.Add(this.applyExcelFilter);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(21, 213);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(326, 199);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Others";
            // 
            // canExportColumnWidth
            // 
            this.canExportColumnWidth.AutoSize = true;
            this.canExportColumnWidth.Checked = true;
            this.canExportColumnWidth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.canExportColumnWidth.Location = new System.Drawing.Point(9, 99);
            this.canExportColumnWidth.Name = "canExportColumnWidth";
            this.canExportColumnWidth.Size = new System.Drawing.Size(155, 19);
            this.canExportColumnWidth.TabIndex = 10;
            this.canExportColumnWidth.Text = "CanExportColumnWidth";
            this.canExportColumnWidth.UseVisualStyleBackColor = true;
            // 
            // canExportRowHeight
            // 
            this.canExportRowHeight.AutoSize = true;
            this.canExportRowHeight.Location = new System.Drawing.Point(9, 74);
            this.canExportRowHeight.Name = "canExportRowHeight";
            this.canExportRowHeight.Size = new System.Drawing.Size(139, 19);
            this.canExportRowHeight.TabIndex = 9;
            this.canExportRowHeight.Text = "CanExportRowHeight";
            this.canExportRowHeight.UseVisualStyleBackColor = true;
            // 
            // exportNestedTableCaption
            // 
            this.exportNestedTableCaption.AutoSize = true;
            this.exportNestedTableCaption.Checked = true;
            this.exportNestedTableCaption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.exportNestedTableCaption.Location = new System.Drawing.Point(9, 149);
            this.exportNestedTableCaption.Name = "exportNestedTableCaption";
            this.exportNestedTableCaption.Size = new System.Drawing.Size(167, 19);
            this.exportNestedTableCaption.TabIndex = 12;
            this.exportNestedTableCaption.Text = "ExportNestedTableCaption";
            this.exportNestedTableCaption.UseVisualStyleBackColor = true;
            // 
            // showGridLines
            // 
            this.showGridLines.AutoSize = true;
            this.showGridLines.Checked = true;
            this.showGridLines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showGridLines.Location = new System.Drawing.Point(9, 124);
            this.showGridLines.Name = "showGridLines";
            this.showGridLines.Size = new System.Drawing.Size(104, 19);
            this.showGridLines.TabIndex = 11;
            this.showGridLines.Text = "ShowGridLines";
            this.showGridLines.UseVisualStyleBackColor = true;
            // 
            // exportNestedTableWithIndent
            // 
            this.exportNestedTableWithIndent.AutoSize = true;
            this.exportNestedTableWithIndent.Checked = true;
            this.exportNestedTableWithIndent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.exportNestedTableWithIndent.Location = new System.Drawing.Point(9, 174);
            this.exportNestedTableWithIndent.Name = "exportNestedTableWithIndent";
            this.exportNestedTableWithIndent.Size = new System.Drawing.Size(184, 19);
            this.exportNestedTableWithIndent.TabIndex = 13;
            this.exportNestedTableWithIndent.Text = "ExportNestedTableWithIndent";
            this.exportNestedTableWithIndent.UseVisualStyleBackColor = true;
            // 
            // enableOptimization
            // 
            this.enableOptimization.AutoSize = true;
            this.enableOptimization.Checked = true;
            this.enableOptimization.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableOptimization.Location = new System.Drawing.Point(9, 24);
            this.enableOptimization.Name = "enableOptimization";
            this.enableOptimization.Size = new System.Drawing.Size(130, 19);
            this.enableOptimization.TabIndex = 7;
            this.enableOptimization.Text = "EnableOptimization";
            this.enableOptimization.UseVisualStyleBackColor = true;
            // 
            // applyExcelFilter
            // 
            this.applyExcelFilter.AutoSize = true;
            this.applyExcelFilter.Location = new System.Drawing.Point(9, 49);
            this.applyExcelFilter.Name = "applyExcelFilter";
            this.applyExcelFilter.Size = new System.Drawing.Size(109, 19);
            this.applyExcelFilter.TabIndex = 8;
            this.applyExcelFilter.Text = "ApplyExcelFilter";
            this.applyExcelFilter.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.exportGroupSummary);
            this.groupBox2.Controls.Add(this.exportTableSummary);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 49);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Summaries";
            // 
            // exportGroupSummary
            // 
            this.exportGroupSummary.AutoSize = true;
            this.exportGroupSummary.Checked = true;
            this.exportGroupSummary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.exportGroupSummary.Location = new System.Drawing.Point(150, 22);
            this.exportGroupSummary.Name = "exportGroupSummary";
            this.exportGroupSummary.Size = new System.Drawing.Size(143, 19);
            this.exportGroupSummary.TabIndex = 1;
            this.exportGroupSummary.Text = "ExportGroupSummary";
            this.exportGroupSummary.UseVisualStyleBackColor = true;
            // 
            // exportTableSummary
            // 
            this.exportTableSummary.AutoSize = true;
            this.exportTableSummary.Checked = true;
            this.exportTableSummary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.exportTableSummary.Location = new System.Drawing.Point(10, 22);
            this.exportTableSummary.Name = "exportTableSummary";
            this.exportTableSummary.Size = new System.Drawing.Size(139, 19);
            this.exportTableSummary.TabIndex = 6;
            this.exportTableSummary.Text = "ExportTableSummary";
            this.exportTableSummary.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exportStyle);
            this.groupBox1.Controls.Add(this.exportBorders);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 48);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Styles";
            // 
            // exportStyle
            // 
            this.exportStyle.AutoSize = true;
            this.exportStyle.Location = new System.Drawing.Point(10, 19);
            this.exportStyle.Name = "exportStyle";
            this.exportStyle.Size = new System.Drawing.Size(84, 19);
            this.exportStyle.TabIndex = 5;
            this.exportStyle.Text = "ExportStyle";
            this.exportStyle.UseVisualStyleBackColor = true;
            // 
            // exportBorders
            // 
            this.exportBorders.AutoSize = true;
            this.exportBorders.Location = new System.Drawing.Point(149, 19);
            this.exportBorders.Name = "exportBorders";
            this.exportBorders.Size = new System.Drawing.Size(99, 19);
            this.exportBorders.TabIndex = 2;
            this.exportBorders.Text = "ExportBorders";
            this.exportBorders.UseVisualStyleBackColor = true;
            // 
            // outliningGroupBox
            // 
            this.outliningGroupBox.Controls.Add(this.allowGroupOutlining);
            this.outliningGroupBox.Controls.Add(this.allowNestedTableOutlining);
            this.outliningGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outliningGroupBox.Location = new System.Drawing.Point(21, 30);
            this.outliningGroupBox.Name = "outliningGroupBox";
            this.outliningGroupBox.Size = new System.Drawing.Size(327, 68);
            this.outliningGroupBox.TabIndex = 1;
            this.outliningGroupBox.TabStop = false;
            this.outliningGroupBox.Text = "Outlining";
            // 
            // allowGroupOutlining
            // 
            this.allowGroupOutlining.AutoSize = true;
            this.allowGroupOutlining.Checked = true;
            this.allowGroupOutlining.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allowGroupOutlining.Location = new System.Drawing.Point(14, 31);
            this.allowGroupOutlining.Name = "allowGroupOutlining";
            this.allowGroupOutlining.Size = new System.Drawing.Size(139, 19);
            this.allowGroupOutlining.TabIndex = 3;
            this.allowGroupOutlining.Text = "AllowGroupOutlining";
            this.allowGroupOutlining.UseVisualStyleBackColor = true;
            // 
            // allowNestedTableOutlining
            // 
            this.allowNestedTableOutlining.AutoSize = true;
            this.allowNestedTableOutlining.Checked = true;
            this.allowNestedTableOutlining.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allowNestedTableOutlining.Location = new System.Drawing.Point(154, 31);
            this.allowNestedTableOutlining.Name = "allowNestedTableOutlining";
            this.allowNestedTableOutlining.Size = new System.Drawing.Size(172, 19);
            this.allowNestedTableOutlining.TabIndex = 4;
            this.allowNestedTableOutlining.Text = "AllowNestedTableOutlining";
            this.allowNestedTableOutlining.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exporting Options";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 597);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridGroupingControl1);
            this.Name = "Form1";
            this.Text = "Excel Exporting";
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.outliningGroupBox.ResumeLayout(false);
            this.outliningGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox applyExcelFilter;
        private System.Windows.Forms.CheckBox enableOptimization;
        private System.Windows.Forms.CheckBox allowNestedTableOutlining;
        private System.Windows.Forms.CheckBox allowGroupOutlining;
        private System.Windows.Forms.CheckBox exportBorders;
        private System.Windows.Forms.CheckBox exportStyle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox outliningGroupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox exportGroupSummary;
        private System.Windows.Forms.CheckBox exportTableSummary;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox exportNestedTableWithIndent;
        private System.Windows.Forms.CheckBox showGridLines;
        private System.Windows.Forms.CheckBox exportNestedTableCaption;
        private System.Windows.Forms.CheckBox canExportRowHeight;
        private System.Windows.Forms.CheckBox canExportColumnWidth;
        private Syncfusion.Windows.Forms.ButtonAdv exportToExcelBtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox customizeStylesInEvent;
    }
}

