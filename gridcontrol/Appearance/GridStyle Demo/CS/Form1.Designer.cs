#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;

namespace GridStyle
{
    partial class Form1
    {
        #region "API Definition"
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
        private Syncfusion.Windows.Forms.Grid.GridControl gridControl2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Syncfusion.Windows.Forms.ColorPickerButton BaseStyleColor;
        private System.Windows.Forms.CheckBox BaseStyleCheck;
        private Syncfusion.Windows.Forms.ColorPickerButton Cell32Color;
        private System.Windows.Forms.CheckBox Cell32Check;
        private Syncfusion.Windows.Forms.ColorPickerButton Column2Color;
        private System.Windows.Forms.CheckBox Column2Check;
        private Syncfusion.Windows.Forms.ColorPickerButton Row3Color;
        private System.Windows.Forms.CheckBox Row3Check;
        private Syncfusion.Windows.Forms.ColorPickerButton TableColor;
        private System.Windows.Forms.CheckBox TableCheck;
        private Syncfusion.Windows.Forms.ColorPickerButton StandardColor;
        private System.Windows.Forms.CheckBox StandardCheck;
        private Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        #endregion

        #region "Dispose"

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

        #endregion

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.gridControl2 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BaseStyleColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.BaseStyleCheck = new System.Windows.Forms.CheckBox();
            this.Cell32Color = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.Cell32Check = new System.Windows.Forms.CheckBox();
            this.Column2Color = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.Column2Check = new System.Windows.Forms.CheckBox();
            this.Row3Color = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.Row3Check = new System.Windows.Forms.CheckBox();
            this.TableColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.TableCheck = new System.Windows.Forms.CheckBox();
            this.StandardColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.StandardCheck = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.gridControl1.ColCount = 7;
            this.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridControl1.Font = new System.Drawing.Font("Segoe UI", 9F);
            //this.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            //this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            this.gridControl1.Location = new System.Drawing.Point(10, 111);
            //this.gridControl1.MetroScrollBars = true;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Properties.ForceImmediateRepaint = false;
            this.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridControl1.Properties.MarkColHeader = false;
            this.gridControl1.Properties.MarkRowHeader = false;
            gridRangeStyle1.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle1.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle1.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle1.StyleInfo.Font.Bold = false;
            gridRangeStyle1.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle1.StyleInfo.Font.Italic = false;
            gridRangeStyle1.StyleInfo.Font.Size = 9F;
            gridRangeStyle1.StyleInfo.Font.Strikeout = false;
            gridRangeStyle1.StyleInfo.Font.Underline = false;
            gridRangeStyle1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle1.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridRangeStyle1.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridControl1.RangeStyles.AddRange(new Syncfusion.Windows.Forms.Grid.GridRangeStyle[] {
            gridRangeStyle1});
            this.gridControl1.RowCount = 20;
            this.gridControl1.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 29)});
            this.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode;
            this.gridControl1.Size = new System.Drawing.Size(490, 443);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 0;
            this.gridControl1.Text = "gridControl1";
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.UseRightToLeftCompatibleTextBox = true;
            // 
            // gridControl2
            // 
            this.gridControl2.DpiAware = true;
            this.gridControl2.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl2.ColCount = 10;
            this.gridControl2.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridControl2.Font = new System.Drawing.Font("Segoe UI", 9F);
            //this.gridControl2.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            //this.gridControl2.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl2.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            this.gridControl2.Location = new System.Drawing.Point(0, 100);
            //this.gridControl2.MetroScrollBars = true;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Properties.ForceImmediateRepaint = false;
            this.gridControl2.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridControl2.Properties.MarkColHeader = false;
            this.gridControl2.Properties.MarkRowHeader = false;
            gridRangeStyle2.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle2.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle2.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle2.StyleInfo.Font.Bold = false;
            gridRangeStyle2.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle2.StyleInfo.Font.Italic = false;
            gridRangeStyle2.StyleInfo.Font.Size = 9F;
            gridRangeStyle2.StyleInfo.Font.Strikeout = false;
            gridRangeStyle2.StyleInfo.Font.Underline = false;
            gridRangeStyle2.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle2.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridRangeStyle2.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridControl2.RangeStyles.AddRange(new Syncfusion.Windows.Forms.Grid.GridRangeStyle[] {
            gridRangeStyle2});
            this.gridControl2.RowCount = 9;
            this.gridControl2.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 29)});
            this.gridControl2.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode;
            this.gridControl2.Size = new System.Drawing.Size(300, 200);
            this.gridControl2.SmartSizeBox = false;
            this.gridControl2.TabIndex = 1;
            this.gridControl2.Text = "gridControl2";
            this.gridControl2.ThemesEnabled = true;
            this.gridControl2.UseRightToLeftCompatibleTextBox = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            //this.groupBox1.Controls.Add(this.BaseStyleColor);
            //this.groupBox1.Controls.Add(this.BaseStyleCheck);
            //this.groupBox1.Controls.Add(this.Cell32Color);
            //this.groupBox1.Controls.Add(this.Cell32Check);
            //this.groupBox1.Controls.Add(this.Column2Color);
            //this.groupBox1.Controls.Add(this.Column2Check);
            //this.groupBox1.Controls.Add(this.Row3Color);
            //this.groupBox1.Controls.Add(this.Row3Check);
            //this.groupBox1.Controls.Add(this.TableColor);
            //this.groupBox1.Controls.Add(this.TableCheck);
            //this.groupBox1.Controls.Add(this.StandardColor);
            //this.groupBox1.Controls.Add(this.StandardCheck);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(540, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 567);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Styles via StyleObjects";
            //
            // panel1
            //
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(15, 22);
            this.panel1.Size = new System.Drawing.Size(300, 300);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gridControl2);
            //
            // panel2
            //
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(15, 360);
            this.panel2.Size = new System.Drawing.Size(300, 230);
            this.panel2.Controls.Add(this.StandardColor);
            this.panel2.Controls.Add(this.StandardCheck);
            this.panel2.Controls.Add(this.BaseStyleColor);
            this.panel2.Controls.Add(this.BaseStyleCheck);
            this.panel2.Controls.Add(this.TableColor);
            this.panel2.Controls.Add(this.TableCheck);
            this.panel2.Controls.Add(this.Column2Color);
            this.panel2.Controls.Add(this.Column2Check);
            this.panel2.Controls.Add(this.Row3Color);
            this.panel2.Controls.Add(this.Row3Check);
            this.panel2.Controls.Add(this.Cell32Color);
            this.panel2.Controls.Add(this.Cell32Check);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(0, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // BaseStyleColor
            // 
            this.BaseStyleColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(231)))), ((int)(((byte)(242)))));
            this.BaseStyleColor.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.BaseStyleColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.BaseStyleColor.IsBackStageButton = false;
            this.BaseStyleColor.Location = new System.Drawing.Point(45, 47);
            this.BaseStyleColor.Name = "BaseStyleColor";
            this.BaseStyleColor.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(231)))), ((int)(((byte)(242)))));
            this.BaseStyleColor.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.CustomColors;
            this.BaseStyleColor.Size = new System.Drawing.Size(75, 23);
            this.BaseStyleColor.TabIndex = 17;
            this.BaseStyleColor.UseVisualStyleBackColor = false;
            // 
            // BaseStyleCheck
            // 
            this.BaseStyleCheck.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BaseStyleCheck.Location = new System.Drawing.Point(140, 47);
            this.BaseStyleCheck.Name = "BaseStyleCheck";
            this.BaseStyleCheck.Size = new System.Drawing.Size(135, 24);
            this.BaseStyleCheck.TabIndex = 16;
            this.BaseStyleCheck.Text = "GridBaseStyle";
            this.BaseStyleCheck.CheckedChanged += new System.EventHandler(this.ApplySettings);
            // 
            // Cell32Color
            // 
            this.Cell32Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(67)))), ((int)(((byte)(142)))));
            this.Cell32Color.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.Cell32Color.ColorUISize = new System.Drawing.Size(208, 230);
            this.Cell32Color.IsBackStageButton = false;
            this.Cell32Color.Location = new System.Drawing.Point(45, 195);
            this.Cell32Color.Name = "Cell32Color";
            this.Cell32Color.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(67)))), ((int)(((byte)(142)))));
            this.Cell32Color.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.CustomColors;
            this.Cell32Color.Size = new System.Drawing.Size(75, 23);
            this.Cell32Color.TabIndex = 25;
            this.Cell32Color.UseVisualStyleBackColor = false;
            // 
            // Cell32Check
            // 
            this.Cell32Check.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Cell32Check.Location = new System.Drawing.Point(140, 195);
            this.Cell32Check.Name = "Cell32Check";
            this.Cell32Check.Size = new System.Drawing.Size(160, 24);
            this.Cell32Check.TabIndex = 24;
            this.Cell32Check.Text = "Cell 3,2 GridStyleInfo";
            this.Cell32Check.CheckedChanged += new System.EventHandler(this.ApplySettings);
            // 
            // Column2Color
            // 
            this.Column2Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(191)))), ((int)(((byte)(117)))));
            this.Column2Color.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.Column2Color.ColorUISize = new System.Drawing.Size(208, 230);
            this.Column2Color.IsBackStageButton = false;
            this.Column2Color.Location = new System.Drawing.Point(45, 121);
            this.Column2Color.Name = "Column2Color";
            this.Column2Color.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(191)))), ((int)(((byte)(117)))));
            this.Column2Color.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.CustomColors;
            this.Column2Color.Size = new System.Drawing.Size(75, 23);
            this.Column2Color.TabIndex = 21;
            this.Column2Color.UseVisualStyleBackColor = false;
            // 
            // Column2Check
            // 
            this.Column2Check.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Column2Check.Location = new System.Drawing.Point(140, 121);
            this.Column2Check.Name = "Column2Check";
            this.Column2Check.Size = new System.Drawing.Size(160, 24);
            this.Column2Check.TabIndex = 20;
            this.Column2Check.Text = "Column2 GridStyleInfo";
            this.Column2Check.CheckedChanged += new System.EventHandler(this.ApplySettings);
            // 
            // Row3Color
            // 
            this.Row3Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(100)))), ((int)(((byte)(19)))));
            this.Row3Color.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.Row3Color.ColorUISize = new System.Drawing.Size(208, 20);
            this.Row3Color.IsBackStageButton = false;
            this.Row3Color.Location = new System.Drawing.Point(45, 155);
            this.Row3Color.Name = "Row3Color";
            this.Row3Color.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(100)))), ((int)(((byte)(19)))));
            this.Row3Color.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.CustomColors;
            this.Row3Color.Size = new System.Drawing.Size(75, 23);
            this.Row3Color.TabIndex = 23;
            this.Row3Color.UseVisualStyleBackColor = false;
            // 
            // Row3Check
            // 
            this.Row3Check.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Row3Check.Location = new System.Drawing.Point(140, 155);
            this.Row3Check.Name = "Row3Check";
            this.Row3Check.Size = new System.Drawing.Size(160, 24);
            this.Row3Check.TabIndex = 22;
            this.Row3Check.Text = "Row3 GridStyleInfo";
            this.Row3Check.CheckedChanged += new System.EventHandler(this.ApplySettings);
            // 
            // TableColor
            // 
            this.TableColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(214)))), ((int)(((byte)(233)))));
            this.TableColor.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.TableColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.TableColor.IsBackStageButton = false;
            this.TableColor.Location = new System.Drawing.Point(45, 84);
            this.TableColor.Name = "TableColor";
            this.TableColor.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(214)))), ((int)(((byte)(233)))));
            this.TableColor.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.CustomColors;
            this.TableColor.Size = new System.Drawing.Size(75, 23);
            this.TableColor.TabIndex = 19;
            this.TableColor.UseVisualStyleBackColor = false;
            // 
            // TableCheck
            // 
            this.TableCheck.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TableCheck.Location = new System.Drawing.Point(140, 84);
            this.TableCheck.Name = "TableCheck";
            this.TableCheck.Size = new System.Drawing.Size(135, 24);
            this.TableCheck.TabIndex = 18;
            this.TableCheck.Text = "Table GridStyleInfo";
            this.TableCheck.CheckedChanged += new System.EventHandler(this.ApplySettings);
            // 
            // StandardColor
            // 
            this.StandardColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(242)))));
            this.StandardColor.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.StandardColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.StandardColor.IsBackStageButton = false;
            this.StandardColor.Location = new System.Drawing.Point(45, 10);
            this.StandardColor.Name = "StandardColor";
            this.StandardColor.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(242)))));
            this.StandardColor.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.CustomColors;
            this.StandardColor.Size = new System.Drawing.Size(75, 23);
            this.StandardColor.TabIndex = 15;
            this.StandardColor.UseVisualStyleBackColor = false;
            // 
            // StandardCheck
            // 
            this.StandardCheck.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StandardCheck.Location = new System.Drawing.Point(140, 10);
            this.StandardCheck.Name = "StandardCheck";
            this.StandardCheck.Size = new System.Drawing.Size(152, 24);
            this.StandardCheck.TabIndex = 14;
            this.StandardCheck.Text = "Standard GridStyleInfo";
            this.StandardCheck.CheckedChanged += new System.EventHandler(this.ApplySettings);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.gridControl1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox2.Location = new System.Drawing.Point(12, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 567);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CellStyles ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(10, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(493, 74);
            this.label2.TabIndex = 27;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 595);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MinimumSize = new System.Drawing.Size(670, 622);
            this.Name = "Form1";
            this.Text = "Grid Style ";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

    }
}

