#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using System.Drawing;
namespace HideRowCols
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
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle82 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle83 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle84 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle85 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle86 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle87 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle88 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle89 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle90 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.btnHide = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridRecordNavigationControl1 = new Syncfusion.Windows.Forms.Grid.GridRecordNavigationControl();
            this.upDownRow = new System.Windows.Forms.NumericUpDown();
            this.upDownCol = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.gridRecordNavigationControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownCol)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DpiAware = true;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridControl1.FillSplitterPane = true;
            this.gridControl1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            this.gridControl1.ColWidths[0] = (int)DpiAware.LogicalToDeviceUnits(30.0f);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MetroScrollBars = true;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridControl1.Properties.MarkColHeader = false;
            this.gridControl1.Properties.MarkRowHeader = false;
            gridRangeStyle82.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle82.StyleInfo.Font.Bold = false;
            gridRangeStyle82.StyleInfo.Font.Facename = "Verdana";
            gridRangeStyle82.StyleInfo.Font.Italic = false;
            gridRangeStyle82.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle82.StyleInfo.Font.Strikeout = false;
            gridRangeStyle82.StyleInfo.Font.Underline = false;
            gridRangeStyle82.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle83.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle83.StyleInfo.Font.Bold = false;
            gridRangeStyle83.StyleInfo.Font.Facename = "Verdana";
            gridRangeStyle83.StyleInfo.Font.Italic = false;
            gridRangeStyle83.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle83.StyleInfo.Font.Strikeout = false;
            gridRangeStyle83.StyleInfo.Font.Underline = false;
            gridRangeStyle83.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle84.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle84.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle84.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle84.StyleInfo.Font.Bold = false;
            gridRangeStyle84.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle84.StyleInfo.Font.Italic = false;
            gridRangeStyle84.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle84.StyleInfo.Font.Strikeout = false;
            gridRangeStyle84.StyleInfo.Font.Underline = false;
            gridRangeStyle84.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle84.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridRangeStyle84.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            gridRangeStyle85.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle85.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle85.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle85.StyleInfo.Font.Bold = false;
            gridRangeStyle85.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle85.StyleInfo.Font.Italic = false;
            gridRangeStyle85.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle85.StyleInfo.Font.Strikeout = false;
            gridRangeStyle85.StyleInfo.Font.Underline = false;
            gridRangeStyle85.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle85.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridRangeStyle85.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            gridRangeStyle86.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle86.StyleInfo.Font.Bold = false;
            gridRangeStyle86.StyleInfo.Font.Facename = "Verdana";
            gridRangeStyle86.StyleInfo.Font.Italic = false;
            gridRangeStyle86.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle86.StyleInfo.Font.Strikeout = false;
            gridRangeStyle86.StyleInfo.Font.Underline = false;
            gridRangeStyle86.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle87.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle87.StyleInfo.Font.Bold = false;
            gridRangeStyle87.StyleInfo.Font.Facename = "Verdana";
            gridRangeStyle87.StyleInfo.Font.Italic = false;
            gridRangeStyle87.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle87.StyleInfo.Font.Strikeout = false;
            gridRangeStyle87.StyleInfo.Font.Underline = false;
            gridRangeStyle87.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle88.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle88.StyleInfo.Font.Bold = false;
            gridRangeStyle88.StyleInfo.Font.Facename = "Verdana";
            gridRangeStyle88.StyleInfo.Font.Italic = false;
            gridRangeStyle88.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle88.StyleInfo.Font.Strikeout = false;
            gridRangeStyle88.StyleInfo.Font.Underline = false;
            gridRangeStyle88.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle89.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle89.StyleInfo.Font.Bold = false;
            gridRangeStyle89.StyleInfo.Font.Facename = "Verdana";
            gridRangeStyle89.StyleInfo.Font.Italic = false;
            gridRangeStyle89.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle89.StyleInfo.Font.Strikeout = false;
            gridRangeStyle89.StyleInfo.Font.Underline = false;
            gridRangeStyle89.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle90.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle90.StyleInfo.Font.Bold = false;
            gridRangeStyle90.StyleInfo.Font.Facename = "Verdana";
            gridRangeStyle90.StyleInfo.Font.Italic = false;
            gridRangeStyle90.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle90.StyleInfo.Font.Strikeout = false;
            gridRangeStyle90.StyleInfo.Font.Underline = false;
            gridRangeStyle90.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            this.gridControl1.RangeStyles.AddRange(new Syncfusion.Windows.Forms.Grid.GridRangeStyle[] {
            gridRangeStyle82,
            gridRangeStyle83,
            gridRangeStyle84,
            gridRangeStyle85,
            gridRangeStyle86,
            gridRangeStyle87,
            gridRangeStyle88,
            gridRangeStyle89,
            gridRangeStyle90});
            this.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode;
            this.gridControl1.Size = new System.Drawing.Size(590, 392);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.Text = "gridControl1";
            this.gridControl1.ThemesEnabled = true;
            // 
            // btnHide
            // 
            this.btnHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHide.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            //this.btnHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.btnHide.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.btnHide.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHide.ForeColor = System.Drawing.Color.White;
            this.btnHide.Location = new System.Drawing.Point(18, 225);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(144, 41);
            this.btnHide.TabIndex = 4;
            this.btnHide.Text = "Hide Rows and Columns";
            this.btnHide.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(641, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 107);
            this.label1.TabIndex = 2;
            this.label1.Text = "Output";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(604, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "A Sample to Hide/Show Thousands of Rows and Columns ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // gridRecordNavigationControl1
            // 
            this.gridRecordNavigationControl1.AllowAddNew = false;
            this.gridRecordNavigationControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridRecordNavigationControl1.ButtonLook = Syncfusion.Windows.Forms.ButtonLook.Normal;
            this.gridRecordNavigationControl1.Controls.Add(this.gridControl1);
            this.gridRecordNavigationControl1.DisabledArrowColor = System.Drawing.SystemColors.GrayText;
            this.gridRecordNavigationControl1.EnabledArrowColor = System.Drawing.SystemColors.WindowText;
            this.gridRecordNavigationControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gridRecordNavigationControl1.Location = new System.Drawing.Point(12, 39);
            this.gridRecordNavigationControl1.MaxRecord = 10;
            this.gridRecordNavigationControl1.MinRecord = 1;
            this.gridRecordNavigationControl1.Name = "gridRecordNavigationControl1";
            this.gridRecordNavigationControl1.NavigationBarBackColor = System.Drawing.SystemColors.Window;
            this.gridRecordNavigationControl1.ShowToolTips = true;
            this.gridRecordNavigationControl1.Size = new System.Drawing.Size(611, 413);
            this.gridRecordNavigationControl1.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.gridRecordNavigationControl1.TabIndex = 4;
            this.gridRecordNavigationControl1.Text = "gridRecordNavigationControl1";
            this.gridRecordNavigationControl1.ThemesEnabled = true;
            // 
            // upDownRow
            // 
            this.upDownRow.Location = new System.Drawing.Point(95, 30);
            this.upDownRow.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.upDownRow.Name = "upDownRow";
            this.upDownRow.Size = new System.Drawing.Size(67, 21);
            this.upDownRow.TabIndex = 2;
            // 
            // upDownCol
            // 
            this.upDownCol.Location = new System.Drawing.Point(95, 62);
            this.upDownCol.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.upDownCol.Name = "upDownCol";
            this.upDownCol.Size = new System.Drawing.Size(67, 21);
            this.upDownCol.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnHide);
            this.groupBox1.Controls.Add(this.upDownCol);
            this.groupBox1.Controls.Add(this.upDownRow);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(644, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 284);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Columns";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rows";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 451);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridRecordNavigationControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(540, 440);
            this.Name = "Form1";
            this.Text = "Hide Rows and Columns";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.gridRecordNavigationControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.upDownRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownCol)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
        private Syncfusion.Windows.Forms.ButtonAdv btnHide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Grid.GridRecordNavigationControl gridRecordNavigationControl1;
        private System.Windows.Forms.NumericUpDown upDownRow;
        private System.Windows.Forms.NumericUpDown upDownCol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

