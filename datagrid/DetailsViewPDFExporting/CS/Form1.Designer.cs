#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;

namespace DetailsViewPDFExporting
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
            this.exportToPDF = new System.Windows.Forms.Button();
            this.exportSelectedRecords = new System.Windows.Forms.RadioButton();
            this.exportWholeGrid = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.shouldCustomizeSelectedItems = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.shouldCustomizeStyle = new System.Windows.Forms.CheckBox();
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.exportToPDF);
            this.groupBox1.Controls.Add(this.exportSelectedRecords);
            this.groupBox1.Controls.Add(this.exportWholeGrid);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.shouldCustomizeSelectedItems);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.shouldCustomizeStyle);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(775, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 273);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // exportToPDF
            // 
            this.exportToPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportToPDF.Location = new System.Drawing.Point(32, 228);
            this.exportToPDF.Name = "exportToPDF";
            this.exportToPDF.Size = new System.Drawing.Size(132, 30);
            this.exportToPDF.TabIndex = 11;
            this.exportToPDF.Text = "Export To PDF";
            this.exportToPDF.UseVisualStyleBackColor = true;
            this.exportToPDF.Click += new System.EventHandler(this.exportToPDF_Click);
            // 
            // exportSelectedRecords
            // 
            this.exportSelectedRecords.AutoSize = true;
            this.exportSelectedRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportSelectedRecords.Location = new System.Drawing.Point(17, 68);
            this.exportSelectedRecords.Name = "exportSelectedRecords";
            this.exportSelectedRecords.Size = new System.Drawing.Size(160, 19);
            this.exportSelectedRecords.TabIndex = 10;
            this.exportSelectedRecords.Text = "Export Selected Records";
            this.exportSelectedRecords.UseVisualStyleBackColor = true;
            this.exportSelectedRecords.CheckedChanged += new System.EventHandler(this.exportSelectedRecords_CheckedChanged);
            // 
            // exportWholeGrid
            // 
            this.exportWholeGrid.AutoSize = true;
            this.exportWholeGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportWholeGrid.Location = new System.Drawing.Point(17, 32);
            this.exportWholeGrid.Name = "exportWholeGrid";
            this.exportWholeGrid.Size = new System.Drawing.Size(125, 19);
            this.exportWholeGrid.TabIndex = 9;
            this.exportWholeGrid.Text = "Export All Records";
            this.exportWholeGrid.UseVisualStyleBackColor = true;
            this.exportWholeGrid.CheckedChanged += new System.EventHandler(this.exportWholeGrid_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 45);
            this.label4.TabIndex = 6;
            this.label4.Text = "Customize style for \r\nSelected Records\r\n in PDF";
            // 
            // shouldCustomizeSelectedItems
            // 
            this.shouldCustomizeSelectedItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shouldCustomizeSelectedItems.Location = new System.Drawing.Point(18, 169);
            this.shouldCustomizeSelectedItems.Name = "shouldCustomizeSelectedItems";
            this.shouldCustomizeSelectedItems.Size = new System.Drawing.Size(17, 40);
            this.shouldCustomizeSelectedItems.TabIndex = 5;
            this.shouldCustomizeSelectedItems.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 52);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customize style for \r\nDetailsView Discount \r\nColumn in PDF";
            // 
            // shouldCustomizeStyle
            // 
            this.shouldCustomizeStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shouldCustomizeStyle.Location = new System.Drawing.Point(18, 108);
            this.shouldCustomizeStyle.Name = "shouldCustomizeStyle";
            this.shouldCustomizeStyle.Size = new System.Drawing.Size(17, 40);
            this.shouldCustomizeStyle.TabIndex = 2;
            this.shouldCustomizeStyle.UseVisualStyleBackColor = true;
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AccessibleName = "Table";
            this.sfDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDataGrid1.Location = new System.Drawing.Point(0, 0);
            this.sfDataGrid1.Name = "sfDataGrid1";
			this.sfDataGrid1.RowHeight = (int)DpiAware.LogicalToDeviceUnits(21.0f);
            this.sfDataGrid1.Size = new System.Drawing.Size(750, 527);
            this.sfDataGrid1.TabIndex = 0;
            this.sfDataGrid1.Text = "sfDataGrid1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 527);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sfDataGrid1);
            this.Name = "Form1";
            this.Text = "MasterDetails PDF Exporting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox shouldCustomizeStyle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox shouldCustomizeSelectedItems;
        private System.Windows.Forms.RadioButton exportWholeGrid;
        private System.Windows.Forms.RadioButton exportSelectedRecords;
        private System.Windows.Forms.Button exportToPDF;
    }
}

