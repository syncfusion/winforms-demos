#region Copyright Syncfusion Inc. 2001 - 2013
// Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using System.Drawing;
namespace GridFindReplace
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
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle1 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle2 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle3 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle4 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle5 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle6 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle7 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle8 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle9 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle10 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle11 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle12 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle13 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle14 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle15 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle16 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle17 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle18 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.colorPickerButton3 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.cmbReplace = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cmbSearch = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cmbOptions = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.btnFindAll = new Syncfusion.Windows.Forms.ButtonAdv();
            this.chkSearchUp = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.chkMatchWholeCell = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.chkMatchCase = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.btnReplaceAll = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnReplace = new Syncfusion.Windows.Forms.ButtonAdv();
            this.lblReplaceWith = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFindNext = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbReplace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSearchUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMatchWholeCell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMatchCase)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DpiAware = true;
            this.gridControl1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            //this.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            //this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            this.gridControl1.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(70.0f);
            this.gridControl1.ColWidths[0] = (int)DpiAware.LogicalToDeviceUnits(30.0f);
            this.gridControl1.Location = new System.Drawing.Point(12, 5);
            //this.gridControl1.MetroScrollBars = true;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Properties.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridControl1.Properties.ForceImmediateRepaint = false;
            this.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.gridControl1.Properties.MarkColHeader = false;
            this.gridControl1.Properties.MarkRowHeader = false;
            gridRangeStyle1.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle1.StyleInfo.Font.Bold = false;
            gridRangeStyle1.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle1.StyleInfo.Font.Italic = false;
            gridRangeStyle1.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle1.StyleInfo.Font.Strikeout = false;
            gridRangeStyle1.StyleInfo.Font.Underline = false;
            gridRangeStyle1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle2.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle2.StyleInfo.Font.Bold = false;
            gridRangeStyle2.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle2.StyleInfo.Font.Italic = false;
            gridRangeStyle2.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle2.StyleInfo.Font.Strikeout = false;
            gridRangeStyle2.StyleInfo.Font.Underline = false;
            gridRangeStyle2.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle3.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle3.StyleInfo.Font.Bold = false;
            gridRangeStyle3.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle3.StyleInfo.Font.Italic = false;
            gridRangeStyle3.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle3.StyleInfo.Font.Strikeout = false;
            gridRangeStyle3.StyleInfo.Font.Underline = false;
            gridRangeStyle3.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle4.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle4.StyleInfo.Font.Bold = false;
            gridRangeStyle4.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle4.StyleInfo.Font.Italic = false;
            gridRangeStyle4.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle4.StyleInfo.Font.Strikeout = false;
            gridRangeStyle4.StyleInfo.Font.Underline = false;
            gridRangeStyle4.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle5.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle5.StyleInfo.Font.Bold = false;
            gridRangeStyle5.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle5.StyleInfo.Font.Italic = false;
            gridRangeStyle5.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle5.StyleInfo.Font.Strikeout = false;
            gridRangeStyle5.StyleInfo.Font.Underline = false;
            gridRangeStyle5.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle6.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle6.StyleInfo.Font.Bold = false;
            gridRangeStyle6.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle6.StyleInfo.Font.Italic = false;
            gridRangeStyle6.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle6.StyleInfo.Font.Strikeout = false;
            gridRangeStyle6.StyleInfo.Font.Underline = false;
            gridRangeStyle6.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle7.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle7.StyleInfo.Font.Bold = false;
            gridRangeStyle7.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle7.StyleInfo.Font.Italic = false;
            gridRangeStyle7.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle7.StyleInfo.Font.Strikeout = false;
            gridRangeStyle7.StyleInfo.Font.Underline = false;
            gridRangeStyle7.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle8.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle8.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle8.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle8.StyleInfo.Font.Bold = false;
            gridRangeStyle8.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle8.StyleInfo.Font.Italic = false;
            gridRangeStyle8.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle8.StyleInfo.Font.Strikeout = false;
            gridRangeStyle8.StyleInfo.Font.Underline = false;
            gridRangeStyle8.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle8.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridRangeStyle8.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            gridRangeStyle9.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle9.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle9.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle9.StyleInfo.Font.Bold = false;
            gridRangeStyle9.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle9.StyleInfo.Font.Italic = false;
            gridRangeStyle9.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle9.StyleInfo.Font.Strikeout = false;
            gridRangeStyle9.StyleInfo.Font.Underline = false;
            gridRangeStyle9.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle9.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridRangeStyle9.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            gridRangeStyle10.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle10.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle10.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle10.StyleInfo.Font.Bold = false;
            gridRangeStyle10.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle10.StyleInfo.Font.Italic = false;
            gridRangeStyle10.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle10.StyleInfo.Font.Strikeout = false;
            gridRangeStyle10.StyleInfo.Font.Underline = false;
            gridRangeStyle10.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle10.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridRangeStyle10.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            gridRangeStyle11.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle11.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle11.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle11.StyleInfo.Font.Bold = false;
            gridRangeStyle11.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle11.StyleInfo.Font.Italic = false;
            gridRangeStyle11.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle11.StyleInfo.Font.Strikeout = false;
            gridRangeStyle11.StyleInfo.Font.Underline = false;
            gridRangeStyle11.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle11.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridRangeStyle11.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            gridRangeStyle12.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle12.StyleInfo.Font.Bold = false;
            gridRangeStyle12.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle12.StyleInfo.Font.Italic = false;
            gridRangeStyle12.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle12.StyleInfo.Font.Strikeout = false;
            gridRangeStyle12.StyleInfo.Font.Underline = false;
            gridRangeStyle12.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle13.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle13.StyleInfo.Font.Bold = false;
            gridRangeStyle13.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle13.StyleInfo.Font.Italic = false;
            gridRangeStyle13.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle13.StyleInfo.Font.Strikeout = false;
            gridRangeStyle13.StyleInfo.Font.Underline = false;
            gridRangeStyle13.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle14.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle14.StyleInfo.Font.Bold = false;
            gridRangeStyle14.StyleInfo.Font.Facename = "Verdana";
            gridRangeStyle14.StyleInfo.Font.Italic = false;
            gridRangeStyle14.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle14.StyleInfo.Font.Strikeout = false;
            gridRangeStyle14.StyleInfo.Font.Underline = false;
            gridRangeStyle14.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle15.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle15.StyleInfo.Font.Bold = false;
            gridRangeStyle15.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle15.StyleInfo.Font.Italic = false;
            gridRangeStyle15.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle15.StyleInfo.Font.Strikeout = false;
            gridRangeStyle15.StyleInfo.Font.Underline = false;
            gridRangeStyle15.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle16.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle16.StyleInfo.Font.Bold = false;
            gridRangeStyle16.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle16.StyleInfo.Font.Italic = false;
            gridRangeStyle16.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle16.StyleInfo.Font.Strikeout = false;
            gridRangeStyle16.StyleInfo.Font.Underline = false;
            gridRangeStyle16.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle17.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle17.StyleInfo.Font.Bold = false;
            gridRangeStyle17.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle17.StyleInfo.Font.Italic = false;
            gridRangeStyle17.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle17.StyleInfo.Font.Strikeout = false;
            gridRangeStyle17.StyleInfo.Font.Underline = false;
            gridRangeStyle17.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle18.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle18.StyleInfo.Font.Bold = false;
            gridRangeStyle18.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle18.StyleInfo.Font.Italic = false;
            gridRangeStyle18.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle18.StyleInfo.Font.Strikeout = false;
            gridRangeStyle18.StyleInfo.Font.Underline = false;
            gridRangeStyle18.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            this.gridControl1.RangeStyles.AddRange(new Syncfusion.Windows.Forms.Grid.GridRangeStyle[] {
            gridRangeStyle1,
            gridRangeStyle2,
            gridRangeStyle3,
            gridRangeStyle4,
            gridRangeStyle5,
            gridRangeStyle6,
            gridRangeStyle7,
            gridRangeStyle8,
            gridRangeStyle9,
            gridRangeStyle10,
            gridRangeStyle11,
            gridRangeStyle12,
            gridRangeStyle13,
            gridRangeStyle14,
            gridRangeStyle15,
            gridRangeStyle16,
            gridRangeStyle17,
            gridRangeStyle18});
            this.gridControl1.RowCount = 25;
            this.gridControl1.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 29)});
            this.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode;
            this.gridControl1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.AlwaysVisible;
            this.gridControl1.Size = new System.Drawing.Size(698, 318);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 0;
            this.gridControl1.Text = "gridControl1";
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.UseRightToLeftCompatibleTextBox = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainer1.Size = new System.Drawing.Size(722, 471);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.colorPickerButton3);
            this.groupBox1.Controls.Add(this.cmbReplace);
            this.groupBox1.Controls.Add(this.cmbSearch);
            this.groupBox1.Controls.Add(this.cmbOptions);
            this.groupBox1.Controls.Add(this.btnFindAll);
            this.groupBox1.Controls.Add(this.chkSearchUp);
            this.groupBox1.Controls.Add(this.chkMatchWholeCell);
            this.groupBox1.Controls.Add(this.chkMatchCase);
            this.groupBox1.Controls.Add(this.btnReplaceAll);
            this.groupBox1.Controls.Add(this.btnReplace);
            this.groupBox1.Controls.Add(this.lblReplaceWith);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFindNext);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 130);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(591, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 18);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Highlight Text";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // colorPickerButton3
            // 
            this.colorPickerButton3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.colorPickerButton3.BeforeTouchSize = new System.Drawing.Size(119, 24);
            this.colorPickerButton3.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.colorPickerButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton3.ForeColor = System.Drawing.Color.Black;
            this.colorPickerButton3.IsBackStageButton = false;
            this.colorPickerButton3.Location = new System.Drawing.Point(574, 50);
            this.colorPickerButton3.Name = "colorPickerButton3";
            this.colorPickerButton3.SelectedAsBackcolor = true;
            this.colorPickerButton3.Size = new System.Drawing.Size(119, 24);
            this.colorPickerButton3.TabIndex = 8;
            this.colorPickerButton3.Text = "Highlight Color";
            // 
            // cmbReplace
            // 
            this.cmbReplace.BackColor = System.Drawing.Color.White;
            this.cmbReplace.BeforeTouchSize = new System.Drawing.Size(229, 22);
            this.cmbReplace.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReplace.Location = new System.Drawing.Point(90, 47);
            this.cmbReplace.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.cmbReplace.Name = "cmbReplace";
            this.cmbReplace.Size = new System.Drawing.Size(229, 22);
            this.cmbReplace.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmbReplace.TabIndex = 5;
            // 
            // cmbSearch
            // 
            this.cmbSearch.BackColor = System.Drawing.Color.White;
            this.cmbSearch.BeforeTouchSize = new System.Drawing.Size(229, 22);
            this.cmbSearch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearch.Location = new System.Drawing.Point(90, 19);
            this.cmbSearch.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(229, 22);
            this.cmbSearch.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmbSearch.TabIndex = 1;
            this.cmbSearch.TextBox.TextChanged += new System.EventHandler(this.cmbSearch_TextChanged);
            // 
            // cmbOptions
            // 
            this.cmbOptions.BackColor = System.Drawing.Color.White;
            this.cmbOptions.BeforeTouchSize = new System.Drawing.Size(121, 22);
            this.cmbOptions.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOptions.Items.AddRange(new object[] {
            "ColumnOnly",
            "SelectionOnly",
            "WholeTable"});
            this.cmbOptions.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.cmbOptions, "ColumnOnly"));
            this.cmbOptions.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.cmbOptions, "SelectionOnly"));
            this.cmbOptions.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.cmbOptions, "WholeTable"));
            this.cmbOptions.Location = new System.Drawing.Point(325, 88);
            this.cmbOptions.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.cmbOptions.Name = "cmbOptions";
            this.cmbOptions.Size = new System.Drawing.Size(121, 22);
            this.cmbOptions.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmbOptions.TabIndex = 12;
            // 
            // btnFindAll
            // 
            this.btnFindAll.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnFindAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnFindAll.BeforeTouchSize = new System.Drawing.Size(109, 23);
            this.btnFindAll.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.btnFindAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindAll.ForeColor = System.Drawing.Color.White;
            this.btnFindAll.IsBackStageButton = false;
            this.btnFindAll.Location = new System.Drawing.Point(459, 18);
            this.btnFindAll.Name = "btnFindAll";
            this.btnFindAll.Size = new System.Drawing.Size(109, 23);
            this.btnFindAll.TabIndex = 3;
            this.btnFindAll.Text = "Find All";
            this.btnFindAll.Click += new System.EventHandler(this.btnFindAll_Click);
            // 
            // chkSearchUp
            // 
            this.chkSearchUp.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.chkSearchUp.Location = new System.Drawing.Point(238, 90);
            this.chkSearchUp.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.chkSearchUp.Name = "chkSearchUp";
            this.chkSearchUp.Size = new System.Drawing.Size(87, 19);
            this.chkSearchUp.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.chkSearchUp.DrawFocusRectangle = true;
            this.chkSearchUp.TabIndex = 11;
            this.chkSearchUp.Text = "Search Up";
            this.chkSearchUp.ThemesEnabled = false;
            // 
            // chkMatchWholeCell
            // 
            this.chkMatchWholeCell.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.chkMatchWholeCell.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.chkMatchWholeCell.Name = "chkMatchWholeCell";
            this.chkMatchWholeCell.Size = new System.Drawing.Size(126, 19);
            this.chkMatchWholeCell.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.chkMatchWholeCell.DrawFocusRectangle = true;
            this.chkMatchWholeCell.TabIndex = 10;
            this.chkMatchWholeCell.Text = "Match Whole Cell";
            this.chkMatchWholeCell.Location = new System.Drawing.Point(100, 90);
            this.chkMatchWholeCell.ThemesEnabled = false;
            // 
            // chkMatchCase
            // 
            this.chkMatchCase.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.chkMatchCase.Location = new System.Drawing.Point(9, 90);
            this.chkMatchCase.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.chkMatchCase.Name = "chkMatchCase";
            this.chkMatchCase.Size = new System.Drawing.Size(96, 19);
            this.chkMatchCase.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.chkMatchCase.DrawFocusRectangle = true;
            this.chkMatchCase.TabIndex = 9;
            this.chkMatchCase.Text = "Match Case";
            this.chkMatchCase.ThemesEnabled = false;
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnReplaceAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplaceAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnReplaceAll.BeforeTouchSize = new System.Drawing.Size(106, 23);
            this.btnReplaceAll.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.btnReplaceAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplaceAll.ForeColor = System.Drawing.Color.White;
            this.btnReplaceAll.IsBackStageButton = false;
            this.btnReplaceAll.Location = new System.Drawing.Point(462, 50);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(106, 23);
            this.btnReplaceAll.TabIndex = 7;
            this.btnReplaceAll.Text = "Replace All";
            this.btnReplaceAll.Click += new System.EventHandler(this.btnReplaceAll_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnReplace.BeforeTouchSize = new System.Drawing.Size(106, 23);
            this.btnReplace.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.btnReplace.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplace.ForeColor = System.Drawing.Color.White;
            this.btnReplace.IsBackStageButton = false;
            this.btnReplace.Location = new System.Drawing.Point(334, 50);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(106, 23);
            this.btnReplace.TabIndex = 6;
            this.btnReplace.Text = "Replace";
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // lblReplaceWith
            // 
            this.lblReplaceWith.AutoSize = true;
            this.lblReplaceWith.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblReplaceWith.Location = new System.Drawing.Point(6, 50);
            this.lblReplaceWith.Name = "lblReplaceWith";
            this.lblReplaceWith.Size = new System.Drawing.Size(77, 14);
            this.lblReplaceWith.TabIndex = 3;
            this.lblReplaceWith.Text = "Replace With";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search For";
            // 
            // btnFindNext
            // 
            this.btnFindNext.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnFindNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnFindNext.BeforeTouchSize = new System.Drawing.Size(106, 23);
            this.btnFindNext.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.btnFindNext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindNext.ForeColor = System.Drawing.Color.White;
            this.btnFindNext.IsBackStageButton = false;
            this.btnFindNext.Location = new System.Drawing.Point(334, 18);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(106, 23);
            this.btnFindNext.TabIndex = 2;
            this.btnFindNext.Text = "Find Next";
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 471);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "Form1";
            this.Text = "Find-Replace";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbReplace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSearchUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMatchWholeCell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMatchCase)).EndInit();
            this.ResumeLayout(false);

        }
        

        #endregion

        private Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Syncfusion.Windows.Forms.ButtonAdv btnFindNext;
        private Syncfusion.Windows.Forms.ButtonAdv btnReplace;
        private System.Windows.Forms.Label lblReplaceWith;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.ButtonAdv btnReplaceAll;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkSearchUp;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkMatchWholeCell;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkMatchCase;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbOptions;
        private Syncfusion.Windows.Forms.ButtonAdv btnFindAll;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbReplace;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbSearch;
        private System.Windows.Forms.CheckBox checkBox1;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton3;
    }
}

