#region Copyright Syncfusion Inc. 2001 - 2015
//
//  Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Globalization;

using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Styles;
using System.IO;
using DemoCommon.Grid;
using Syncfusion.Windows.Forms;

namespace FormulaGrid
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : GridDemoForm
    {
        #region "API Definition"

        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem8;
        private Syncfusion.Windows.Forms.ButtonAdv button3;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox1;
        private Syncfusion.Windows.Forms.ButtonAdv button2;
        private Syncfusion.Windows.Forms.ButtonAdv button1;
        private Panel panel1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
        private GridAwareTextBox gridAwareTextBox1;
        private GridControl gridControl2;
        private Panel panel2;
        private GridAwareTextBox textBox1;
        private GridControl gridControl1;
        private IContainer components;
        #endregion

        #region "Constructor"
        /// <summary>
        /// Form Constructor
        /// </summary>
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            this.GridSettings();
            this.gridControl2.ColWidths[0] = (int)DpiAware.LogicalToDeviceUnits(40);
        }

        #endregion

        #region "Grid Settings"
        /// <summary>
        /// Grid Settings for better look and feel
        /// </summary>
        private void GridSettings()
        {
            //Used to set default row height
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);

            this.gridControl1.Model.Options.DisplayEmptyColumns = true;
            this.gridControl1.Model.Options.DisplayEmptyRows = true;

            //Navigate the tabkey to other control
            this.gridControl1.WantTabKey = false;
            this.gridControl2.WantTabKey = false;
        }
        #endregion

        #region "Designer Stuffs"

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo3 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo4 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.button3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.checkBox1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.button2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridAwareTextBox1 = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            this.gridControl2 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem3,
            this.menuItem4,
            this.menuItem5,
            this.menuItem8});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "No Formatting";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "0 places";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "1 place";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 3;
            this.menuItem4.Text = "2 places";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 4;
            this.menuItem5.Text = "3 places";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 5;
            this.menuItem8.Text = "6 places";
            this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button3.BeforeTouchSize = new System.Drawing.Size(160, 23);
            this.button3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.IsBackStageButton = false;
            this.button3.Location = new System.Drawing.Point(556, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Find Next Compare Failure";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBox1.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox1.DrawFocusRectangle = false;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(242, 4);
            this.checkBox1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(166, 32);
            this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox1.DrawFocusRectangle = true;
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Raw Values in Column A";
            this.checkBox1.ThemesEnabled = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button2.BeforeTouchSize = new System.Drawing.Size(97, 23);
            this.button2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.IsBackStageButton = false;
            this.button2.Location = new System.Drawing.Point(139, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Load Grid";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(96, 23);
            this.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.IsBackStageButton = false;
            this.button1.Location = new System.Drawing.Point(37, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save Grid";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.gridAwareTextBox1);
            this.panel1.Controls.Add(this.gridControl2);
            this.panel1.Controls.Add(this.comboBoxAdv1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(12, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 314);
            this.panel1.TabIndex = 8;
            // 
            // gridAwareTextBox1
            // 
            this.gridAwareTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAwareTextBox1.AutoSuggestFormula = false;
            this.gridAwareTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridAwareTextBox1.DisabledBackColor = System.Drawing.SystemColors.Window;
            this.gridAwareTextBox1.EnabledBackColor = System.Drawing.SystemColors.Window;
            this.gridAwareTextBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridAwareTextBox1.Location = new System.Drawing.Point(12, 42);
            this.gridAwareTextBox1.Name = "gridAwareTextBox1";
            this.gridAwareTextBox1.Size = new System.Drawing.Size(724, 27);
            this.gridAwareTextBox1.TabIndex = 11;
            // 
            // gridControl2
            // 
            this.gridControl2.DpiAware = true;
            this.gridControl2.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            this.gridControl2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gridControl2.BackColor = System.Drawing.Color.White;
            this.gridControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl2.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridControl2.Font = new System.Drawing.Font("Segoe UI", 9F);
            gridCellInfo3.Col = -1;
            gridCellInfo3.Row = -1;
            gridCellInfo3.StyleInfo.Font.Bold = false;
            gridCellInfo3.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo3.StyleInfo.Font.Italic = false;
            gridCellInfo3.StyleInfo.Font.Size = 9F;
            gridCellInfo3.StyleInfo.Font.Strikeout = false;
            gridCellInfo3.StyleInfo.Font.Underline = false;
            gridCellInfo3.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo4.Col = -1;
            gridCellInfo4.Row = -1;
            gridCellInfo4.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo4.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo4.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo4.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridCellInfo4.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridControl2.GridCells.AddRange(new Syncfusion.Windows.Forms.Grid.GridCellInfo[] {
            gridCellInfo3,
            gridCellInfo4});
            this.gridControl2.ThemesEnabled = true;
            //this.gridControl2.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            //this.gridControl2.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl2.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            this.gridControl2.Location = new System.Drawing.Point(12, 74);
            //this.gridControl2.MetroScrollBars = true;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Properties.ForceImmediateRepaint = false;
            this.gridControl2.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridControl2.Properties.MarkColHeader = false;
            this.gridControl2.Properties.MarkRowHeader = false;
            this.gridControl2.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 29)});
            this.gridControl2.Size = new System.Drawing.Size(724, 237);
            this.gridControl2.SmartSizeBox = false;
            this.gridControl2.TabIndex = 12;
            this.gridControl2.Text = "gridControl2";
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(121, 21);
            this.comboBoxAdv1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "0.001",
            "0.0001",
            "0.00001",
            "0.000001",
            "0.0000001",
            "0.00000001",
            "0.000000001",
            "0.0000000001",
            "0.00000000001"});
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "0.001"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "0.0001"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "0.00001"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "0.000001"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "0.0000001"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "0.00000001"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "0.000000001"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "0.0000000001"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "0.00000000001"));
            this.comboBoxAdv1.Location = new System.Drawing.Point(414, 9);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv1.TabIndex = 9;
            this.comboBoxAdv1.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 311);
            this.panel2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.AutoSuggestFormula = false;
            this.textBox1.DisabledBackColor = System.Drawing.SystemColors.Window;
            this.textBox1.EnabledBackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(13, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(724, 27);
            this.textBox1.TabIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.DpiAware = true;
            this.gridControl1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl1.ColCount = 15;
            this.gridControl1.ContextMenu = this.contextMenu1;
            this.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            //this.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            //this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            this.gridControl1.HorizontalThumbTrack = true;
            this.gridControl1.Location = new System.Drawing.Point(13, 47);
            //this.gridControl1.MetroScrollBars = true;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Properties.ForceImmediateRepaint = false;
            this.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridControl1.Properties.MarkColHeader = false;
            this.gridControl1.Properties.MarkRowHeader = false;
            this.gridControl1.RowCount = 135;
            this.gridControl1.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 29)});
            this.gridControl1.Size = new System.Drawing.Size(724, 262);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 5;
            this.gridControl1.Text = "gridControl1";
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.VerticalScrollTips = true;
            this.gridControl1.VerticalThumbTrack = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 655);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(650, 600);
            this.Name = "Form1";
            this.Text = "Formula Grid";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
# if SyncfusionFramework1_1 || SyncfusionFramework2_0
            Application.EnableVisualStyles();
# endif
            Application.Run(new Form1());
        }
        #endregion

        #region Event Handlers

        private Hashtable formulas;
        private double epsilon = 0.00001;
        private string format = "0.00000";
        private Color badCompareColor = Color.FromArgb(0x85, 0xbf, 0x75);
        private Color foundColor = Color.FromArgb(0xff, 0xbf, 0x34);
        private int foundRow = -2;
        private bool messageBoxShown = false;

        private void Form1_Load(object sender, System.EventArgs e)
        {

            this.gridControl1.RowCount = 150;

            #region Adding a formula to the formula library - step 2
            //adding formula to the Formula Engine Library
            //step2: call the AddFunction member of the Engine
            GridFormulaCellModel model = this.gridControl1.CellModels["FormulaCell"]
                            as GridFormulaCellModel;

            //add formula name Min to the Library
            model.Engine.AddFunction("Min", new GridFormulaEngine.LibraryFunction(ComputeMin));
            #endregion

            #region Initialize grid properties and set formulas & data

            //set entire grid to allow formulas
            this.gridControl1.BaseStylesMap["Standard"].StyleInfo.CellType = "FormulaCell";
            this.gridControl1.BaseStylesMap["Standard"].StyleInfo.Format = "F2"; //two decimal places
            this.gridControl1.BaseStylesMap["Standard"].StyleInfo.BackColor = Color.FromArgb(0xda, 0xe5, 0xf5); //light blue background

            this.gridControl1.ColWidths[0] = (int)DpiAware.LogicalToDeviceUnits(35);
            this.gridControl1.ColWidths[1] = (int)DpiAware.LogicalToDeviceUnits(180);

            this.gridControl1.FloatCellsMode = GridFloatCellsMode.BeforeDisplayCalculation;

            //dynamically create a basestyle for each formula title row
            GridStyleInfo titleRowStyle = this.gridControl1.BaseStylesMap["TitleRow"].StyleInfo;
            titleRowStyle.Font.Bold = true;
            titleRowStyle.Font.Size = 10;
            titleRowStyle.Enabled = false;
            titleRowStyle.BackColor = Color.FromArgb(0xfc, 0xac, 0x26);
            int titleRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);

            GridStyleInfo introRowStyle = this.gridControl1.BaseStylesMap["IntroRow"].StyleInfo;
            introRowStyle.Font.Bold = true;
            introRowStyle.Font.Size = 10;
            introRowStyle.Font.Facename = "Verdana";
            introRowStyle.Enabled = false;
            introRowStyle.BackColor = Color.FromArgb(0xc0, 0xc9, 0xdb);
            introRowStyle.TextColor = Color.FromArgb(0xde, 0x64, 0x13);
            introRowStyle.Borders.Bottom = new GridBorder(GridBorderStyle.None);

            int introRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);


            int row = 1;
            int col = 1;
            int blocksize = 4;

            //enter the text for the intro
            this.gridControl1[row, col].Text = "     Essential Grid has a formula cell type that allows a cell to host a formula. The included formula engine lets you add functions.You have the option of using a formula cell for the whole grid, or just for some grid cells, say a Sum row or Average column. Below are samples using library functions with random data. In the cells below, check things out by entering equals followed by an algebraic expression using +-/* and cell references. Some examples:";
            this.gridControl1.RowStyles[row].BaseStyle = "IntroRow";
            this.gridControl1.RowHeights[row] = (int)DpiAware.LogicalToDeviceUnits(50.0f);
            this.gridControl1[row, col].WrapText = true;
            this.gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(row, 1, row, this.gridControl1.ColCount));

            row += 1;

            //enter the text for the intro
            this.gridControl1[row, col].Text = "        =(E16+E17)/F16";
            this.gridControl1.RowStyles[row].BaseStyle = "IntroRow";
            this.gridControl1.RowHeights[row] = introRowHeight;
            this.gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(row, 1, row, this.gridControl1.ColCount));

            row += 1;

            //enter the text for the intro
            this.gridControl1[row, col].Text = "        =COS((E16+E17)/F16)";
            this.gridControl1.RowStyles[row].BaseStyle = "IntroRow";
            this.gridControl1.RowHeights[row] = introRowHeight;
            this.gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(row, 1, row, this.gridControl1.ColCount));

            this.gridControl1[1, 0].Text = " ";
            this.gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(1, 0, row, 0));

            //this.gridControl1.Rows.FrozenCount = 8;

            int row0 = 5;
            row = row0;


            //loop through & get name of all library formulas...
            ArrayList al = new ArrayList();
            foreach (object o in model.Engine.LibraryFunctions.Keys)
            {
                al.Add(o);
            }

            al.Sort();

            //set up a sam[ple block for each library formula
            Random r = new Random();
            foreach (object o in al)
            {
                string s = o as string;
                if (s != null)
                {
                    this.gridControl1.RowStyles[row].BaseStyle = "TitleRow";
                    this.gridControl1.RowHeights[row] = titleRowHeight;
                    this.gridControl1[row, 0].Text = " ";
                    this.gridControl1[row, 0].BackColor = Color.FromArgb(238, 122, 3);
                    this.gridControl1[row, 0].CellAppearance = GridCellAppearance.Flat;
                    this.gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(row, 1, row, this.gridControl1.ColCount));

                    //sample data
                    for (int i = row + 1; i < row + blocksize; ++i)
                        for (int j = col + 4; j < col + 8; ++j)
                            this.gridControl1[i, j].CellValue = r.Next(10000);

                    if (s == "AVERAGEA" || s == "AVERAGE" || s == "SUM" || s == "AVG" || s == "MAX" || s == "MIN" || s == "MAXA" || s == "MINA"
                        || s == "AVEDEV" || s == "HARMEAN" || s == "GEOMEAN" || s == "STDEV" || s == "STDEVA" || s == "STDEVP" || s == "STDEVPA") //functions need cell arguments only
                    {
                        this.gridControl1[row, col].Text = s;
                        //col 1 & col 2 of first row
                        string f = string.Format(s + "(E{0}:H{0})", row + 1);
                        this.gridControl1[row + 1, col].Text = f;
                        this.gridControl1[row + 1, col + 1].Text = '=' + f;

                        //col 1 & col 2 of second row
                        f = string.Format(s + "(E{0}:H{0}, E{1}, F{1}, G{1}, H{1})", row + 2, row + 3);
                        this.gridControl1[row + 2, col].Text = f;
                        this.gridControl1[row + 2, col + 1].Text = '=' + f;

                        //col 1 & col 2 of third row
                        f = string.Format(s + "(E{0}:H{0}, E{1}:H{1})", row + 2, row + 3);
                        this.gridControl1[row + 3, col].Text = f;
                        this.gridControl1[row + 3, col + 1].Text = '=' + f;
                    }
                    else if (s == "IF") //functions need three arguments only
                    {
                        this.gridControl1[row, col].Text = s;
                        //col 1 & col 2 of first row
                        string f = string.Format(s + "(E{0},1,0)", row + 1);
                        this.gridControl1[row + 1, col].Text = f;
                        this.gridControl1[row + 1, col + 1].Text = '=' + f;

                        //col 1 & col 2 of second row
                        f = string.Format(s + "(ABS(E{0}-H{0}),1,0)", row + 2);
                        this.gridControl1[row + 2, col].Text = f;
                        this.gridControl1[row + 2, col + 1].Text = '=' + f;

                        //col 1 & col 2 of third row
                        f = string.Format(s + "(SQRT(E{0}),1,0)", row + 3);
                        this.gridControl1[row + 3, col].Text = f;
                        this.gridControl1[row + 3, col + 1].Text = '=' + f;
                    }
                    else if (s == "POW") //functions need two arguments only
                    {
                        this.gridControl1[row, col].Text = s;

                        //col 1 & col 2 of first row
                        string f = string.Format(s + "(E{0},2)", row + 1);
                        this.gridControl1[row + 1, col].Text = f;
                        this.gridControl1[row + 1, col + 1].Text = '=' + f;

                        //col 1 & col 2 of second row
                        f = string.Format(s + "(ABS(E{0}-H{0}), 3)", row + 2);
                        this.gridControl1[row + 2, col].Text = f;
                        this.gridControl1[row + 2, col + 1].Text = '=' + f;

                        //col 1 & col 2 of third row
                        f = string.Format(s + "(SQRT(E{0}),2)", row + 3);
                        this.gridControl1[row + 3, col].Text = f;
                        this.gridControl1[row + 3, col + 1].Text = '=' + f;
                    }
                    else if (s == "PI") //functions need two arguments only
                    {
                        this.gridControl1[row, col].Text = s;

                        //col 1 & col 2 of first row
                        string f = string.Format(s + "()");
                        this.gridControl1[row + 1, col].Text = f;
                        this.gridControl1[row + 1, col + 1].Text = '=' + f;

                        //col 1 & col 2 of second row
                        f = string.Format(s + "()/2");
                        this.gridControl1[row + 2, col].Text = f;
                        this.gridControl1[row + 2, col + 1].Text = '=' + f;

                        //col 1 & col 2 of third row
                        f = string.Format("2 * " + s + "()");
                        this.gridControl1[row + 3, col].Text = f;
                        this.gridControl1[row + 3, col + 1].Text = '=' + f;
                    }

                    else if (s == "ABS" || s == "ACOS" || s == "ACOSH" || s == "ASIN" || s == "ASINH" || s == "ATAN" || s == "ATANH" || s == "COS"
                        || s == "EXP" || s == "LN" || s == "LOG10" || s == "SIN" || s == "SINH" || s == "SQRT")
                    {
                        this.gridControl1[row, col].Text = s;

                        //sample data
                        for (int i = row + 1; i < row + blocksize; ++i)
                            for (int j = col + 4; j < col + 8; ++j)
                                this.gridControl1[i, j].CellValue = r.Next(10000);

                        //col 1 & col 2 of first row
                        string f = string.Format(s + "((E{0}-F{0}) / (G{0} + H{0}))", row + 1);
                        this.gridControl1[row + 1, col].Text = f;
                        this.gridControl1[row + 1, col + 1].Text = '=' + f;

                        //col 1 & col 2 of second row
                        f = string.Format(s + "(ABS(E{0}-F{0}))", row + 2);
                        this.gridControl1[row + 2, col].Text = f;
                        this.gridControl1[row + 2, col + 1].Text = '=' + f;

                        //col 1 & col 2 of third row
                        f = string.Format(s + "(E{0})", row + 3);
                        this.gridControl1[row + 3, col].Text = f;
                        this.gridControl1[row + 3, col + 1].Text = '=' + f;
                    }
                    else
                        row -= blocksize;

                }

                row += blocksize;
            }

            //set up some summary items:
            string f1 = string.Format("=SUM(E{0}:E{1})", row0, row);
            this.gridControl1[row + 1, col + 4].Text = f1;
            this.gridControl1[row + 1, col + 4].Borders.Top = new GridBorder(GridBorderStyle.Solid, Color.Black, GridBorderWeight.Medium);

            f1 = string.Format("=AVG(F{0}:F{1})", row0, row);
            this.gridControl1[row + 1, col + 5].Text = f1;
            this.gridControl1[row + 1, col + 5].Borders.Top = new GridBorder(GridBorderStyle.Solid, Color.Black, GridBorderWeight.Medium);

            f1 = string.Format("=MAX(G{0}:G{1})", row0, row);
            this.gridControl1[row + 1, col + 6].Text = f1;
            this.gridControl1[row + 1, col + 6].Borders.Top = new GridBorder(GridBorderStyle.Solid, Color.Black, GridBorderWeight.Medium);

            f1 = string.Format("=Min(H{0}:H{1})", row0, row);
            this.gridControl1[row + 1, col + 7].Text = f1;
            this.gridControl1[row + 1, col + 7].Borders.Top = new GridBorder(GridBorderStyle.Solid, Color.Black, GridBorderWeight.Medium);
            #endregion

            //hook the GridAwareTextBox so the EditBar is available
            this.textBox1.WireGrid(this.gridControl1);

            this.gridControl1.Focus();
            this.gridControl1.CurrentCell.MoveTo(9, 1);
            this.gridControl1.CommandStack.Enabled = true;
            this.gridControl1.Model.Options.SelectCellsMouseButtonsMask = MouseButtons.Left;

            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(18.0f);
            this.gridControl1.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(70.0f);
            this.gridControl1.TopRowIndex = 15;
            this.gridControl1.ColStyles[1].Font.Bold = true;
            //Gridcontrol2

            this.gridAwareTextBox1.BackColor = Color.White;
            this.gridAwareTextBox1.WireGrid(this.gridControl2);
            this.gridControl2.TableStyle.CellType = "FormulaCell";
            this.gridControl2.RowCount = 1100;
            SetFormatFirstRow();

            GridFormulaEngine engine = ((GridFormulaCellModel)this.gridControl2.CellModels["FormulaCell"]).Engine;
            engine.FormulaCopyFlags |= GridFormulaCopyFlags.ClipBoardFormula; //copy formulas and not values
            this.formulas = engine.LibraryFunctions.Clone() as Hashtable;

            this.formulas.Add("+ OPERATOR", "");
            this.formulas.Add("- OPERATOR", "");
            this.formulas.Add("* OPERATOR", "");
            this.formulas.Add("/ OPERATOR", "");
            this.formulas.Add("> OPERATOR", "");
            this.formulas.Add("< OPERATOR", "");
            this.formulas.Add(" = OPERATOR", "");
            this.formulas.Add(">= OPERATOR", "");
            this.formulas.Add("<= OPERATOR", "");
            this.formulas.Add("<> OPERATOR", "");
            this.formulas.Add("^ EXPONENT", "");
            this.formulas.Add("- UNARY MINUS", "");

            this.gridControl2.PrepareViewStyleInfo += new GridPrepareViewStyleInfoEventHandler(gridControl2_PrepareViewStyleInfo);

            //this.domainUpDown1.SelectedIndex = 3;

            this.gridControl2.Rows.FrozenCount = 1;

            LoadTsvFile(FindFullPath("good.tsv"));

            if (Environment.CommandLine.EndsWith("automatedtest"))
            {
                Timer t = new Timer();
                t.Interval = 100;
                t.Tick += new EventHandler(t_Tick);
                t.Enabled = true;
            }
            this.comboBoxAdv1.SelectedIndex = 2;
            this.gridControl2.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(18.0f);
            this.gridControl2.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(70.0f);
            this.gridControl1.TopRowIndex = 16;

        }

        void gridControl2_PrepareViewStyleInfo(object sender, GridPrepareViewStyleInfoEventArgs e)
        {
            if (e.RowIndex == 1 && e.ColIndex > 0)
            {
                e.Style.TextColor = Color.White;
            }
            if (e.RowIndex > 1 && e.ColIndex > 0)
            {
                string s2 = this.gridControl2[e.RowIndex, 2].Text.Trim();
                if (this.formulas.ContainsKey(s2.ToUpper()))
                {
                    e.Style.Font.Bold = true;
                    e.Style.BackColor = Color.FromArgb(0xc4, 0xd6, 0xe9);

                }
                else
                {
                    s2 = this.gridControl2[e.RowIndex, 1].Text;
                    if (s2.Length > 0)
                    {
                        e.Style.BackColor = Color.FromArgb(0xed, 0xf0, 0xf6);
                    }
                }
            }

            if (!this.checkBox1.Checked)
            {
                if (e.ColIndex == 1 && e.RowIndex > 1 && e.Style.Text.Length > 0)
                {
                    double d;
                    if (double.TryParse(e.Style.FormattedText, NumberStyles.Any, null, out d))
                    {
                        e.Style.Format = this.format;
                        if (Math.Abs(d) > this.epsilon)
                        {
                            e.Style.BackColor = badCompareColor; ;

                        }
                    }
                    else
                    {
                        e.Style.BackColor = Color.LightGoldenrodYellow;
                    }
                }
            }

            if (e.RowIndex == foundRow && e.ColIndex > 0)
            {
                e.Style.BackColor = this.foundColor;
            }
        }

        #region Helper methods
        private void LoadGrdFile(string s)
        {
            try
            {
                this.gridControl2.BeginUpdate();
                this.gridControl2.Model = GridModel.LoadBinary(s);
                this.gridControl2.Anchor = AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                SetFormatFirstRow();
                this.gridControl2.ColWidths.ResizeToFit(GridRangeInfo.Cells(1, 1, 100, 6));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.gridControl2.EndUpdate();
            }
        }

        private void LoadTsvFile(string fileName)
        {
            string save = this.gridControl2.Model.TextDataExchange.ExportTabDelim;
            try
            {
                this.gridControl2.Model.TextDataExchange.ImportTabDelim = "\t";
                StreamReader reader = new StreamReader(fileName);
                string s = reader.ReadToEnd();
                reader.Close();
                this.gridControl2.BeginUpdate();
                //reset grid
                this.gridControl2.RowCount = 1;
                this.gridControl2.ColCount = 1;
                this.gridControl2.Model.TextDataExchange.PasteTextFromBuffer(s, GridRangeInfo.Cell(1, 1), 0);
                this.gridControl2.EndUpdate();

                this.gridControl2.Anchor = AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                SetFormatFirstRow();
                this.gridControl2.ColWidths.ResizeToFit(GridRangeInfo.Cells(1, 1, 100, 6));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.gridControl2.EndUpdate();
                this.gridControl2.Model.TextDataExchange.ExportTabDelim = save;
            }
        }

        private void WriteGrdFile(string saveFile)
        {
            try
            {
                this.gridControl2.Model.SaveBinary(saveFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void WriteTsvFile(string s)
        {
            this.Cursor = Cursors.WaitCursor;
            string save = this.gridControl2.Model.TextDataExchange.ExportTabDelim;
            this.gridControl2.Model.TextDataExchange.ExportTabDelim = "\t";
            string outPut = "";
            GridRangeInfoList rangeInfoList = new GridRangeInfoList();
            rangeInfoList.Add(GridRangeInfo.Cells(1, 1, this.gridControl2.RowCount, this.gridControl2.ColCount));
            for (int row = 1; row <= this.gridControl1.RowCount; ++row)
            {
                for (int col = 1; col <= this.gridControl2.ColCount; ++col)
                {
                    string text = "";
                    if (this.gridControl2.Data[row, col] != null)
                        text = (new GridStyleInfo(this.gridControl2.Data[row, col])).Text;
                    if (col > 1)
                        outPut += this.gridControl2.Model.TextDataExchange.ExportTabDelim;
                    outPut += text;
                }
                outPut += Environment.NewLine;
            }
            StreamWriter writer = new StreamWriter(s);
            writer.Write(outPut);
            writer.Close();
            this.gridControl2.Model.TextDataExchange.ExportTabDelim = save;
            this.Cursor = Cursors.Default;
        }
        private void t_Tick(object sender, EventArgs e)
        {
            Timer t = sender as Timer;
            t.Enabled = false;
            t.Dispose();
            this.button3.PerformClick();
        }

        string FindFullPath(string tsvFileName)
        {
            // Check both in parent folder and Parent\Data folders.
            string tsvDataFileName = @"Data\" + tsvFileName;
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(tsvFileName))
                {
                    return Path.GetFullPath(tsvFileName);
                }
                if (System.IO.File.Exists(tsvDataFileName))
                {
                    return Path.GetFullPath(tsvDataFileName);
                }
                tsvFileName = @"..\" + tsvFileName;
                tsvDataFileName = @"..\" + tsvDataFileName;
            }

            return "";
        }


        private void SetFormatFirstRow()
        {
            GridStyleInfo style = this.gridControl2.RowStyles[1];
            style.Font.Size = 10f;
            style.Font.Bold = true;
            style.BackColor = Color.FromArgb(0xee, 0x7a, 0x03);
            this.gridControl2.RowHeights[1] = (int)DpiAware.LogicalToDeviceUnits(30.0f);
            this.gridControl2.HScrollPixel = true;
        }
        #endregion

        #region Adding a formula to the formula library - step 1

        //adding formula to the Formula Engine Library
        //step1: code it with this signature
        //			public string MyLibraryFormula(string args)
        //   return the computed value as a string...
        //   use the Engines public members as needed in your code.
        //   This sample computes the minimum of are arbitary range
        //     egs:		=Min(A1:C3)
        //				=min(a1,c2,a4,b2)
        public string ComputeMin(string args)
        {
            GridFormulaCellModel model1 = this.gridControl2.CellModels["FormulaCell"]
                                    as GridFormulaCellModel;

            if (model1 != null)
            {
                GridFormulaEngine engine = model1.Engine;
                double min = double.MaxValue;
                double d;
                string s1;

                foreach (string r in args.Split(new char[] { ',' }))
                {
                    if (r.IndexOf(':') > -1) //cell range
                    {
                        foreach (string s in engine.GetCellsFromArgs(r))
                        {
                            //s is a cell line a21 or c3...
                            try
                            {
                                s1 = engine.GetValueFromArg(s);
                            }
                            catch (Exception ex)
                            {
                                return ex.Message;
                            }
                            if (s1 != "")
                            {
                                if (double.TryParse(s1, NumberStyles.Number, null, out d))
                                {
                                    min = Math.Min(min, d);
                                }
                            }
                        }
                    }
                    else
                    {
                        try
                        {
                            s1 = engine.GetValueFromArg(r);
                        }
                        catch (Exception ex)
                        {
                            return ex.Message;
                        }
                        if (s1 != "")
                        {
                            if (double.TryParse(s1, NumberStyles.Number, null, out d))
                            {
                                min = Math.Min(min, d);
                            }
                        }

                    }
                }
                if (min != double.MaxValue)
                    return min.ToString();
            }
            return "";
        }


        #endregion

        #region handle format places context menu

        private void menuItem1_Click(object sender, System.EventArgs e)
        {
            SetPlaces(-1);
        }

        private void menuItem2_Click(object sender, System.EventArgs e)
        {
            SetPlaces(0);
        }

        private void menuItem3_Click(object sender, System.EventArgs e)
        {
            SetPlaces(1);
        }

        private void menuItem4_Click(object sender, System.EventArgs e)
        {
            SetPlaces(2);
        }

        private void menuItem5_Click(object sender, System.EventArgs e)
        {
            SetPlaces(3);
        }

        private void menuItem8_Click(object sender, System.EventArgs e)
        {
            SetPlaces(6);
        }

        private void SetPlaces(int places)
        {
            GridRangeInfoList rangeList;
            if (this.gridControl1.Selections.GetSelectedRanges(out rangeList, false))
            {
                GridStyleInfo style = new GridStyleInfo();
                if (places == -1)
                    style.Format = "g";
                else
                    style.Format = string.Format("F{0}", places);

                GridRangeInfo range = rangeList.ActiveRange.ExpandRange(1, 1, gridControl1.RowCount, gridControl1.ColCount);
                this.gridControl1.ChangeCells(range, style, StyleModifyType.Override);

                this.gridControl1.RefreshRange(range, GridRangeOptions.None);
            }
        }

        #endregion

        private void splitterControl1_PaneClosing(object sender, Syncfusion.Windows.Forms.SplitterPaneEventArgs e)
        {
            if (e.Control is GridControlBase)
            {
                GridControlBase grid = (GridControlBase)e.Control;
                this.textBox1.UnwireGrid(grid);
            }
        }

        private void splitterControl1_PaneCreated(object sender, Syncfusion.Windows.Forms.SplitterPaneEventArgs e)
        {
            if (e.Control is GridControlBase)
            {
                GridControlBase grid = (GridControlBase)e.Control;
                this.textBox1.WireGrid(grid);
            }
        }

        #region button Click Events
        private void button1_Click(object sender, EventArgs e)
        {
            //save grid
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "*.tsv";
            saveFile.FileName = "Untitled";
            saveFile.InitialDirectory = Application.ExecutablePath;
            saveFile.Filter = "tsv Files|*.tsv|grd Files|*.grd";

            // get a file name from the user
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                if (saveFile.FileName.ToUpper().EndsWith(".GRD"))
                    WriteGrdFile(saveFile.FileName);
                else if (saveFile.FileName.ToUpper().EndsWith(".TSV"))
                    WriteTsvFile(saveFile.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //load grid

            OpenFileDialog dlgOpenFile = new OpenFileDialog();
            dlgOpenFile.Title = "Open grid file";
            dlgOpenFile.InitialDirectory = Application.ExecutablePath;
            dlgOpenFile.Filter = "tsv Files(*.tsv)|*.tsv|grd files (*.grd)|*.grd";

            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                if (dlgOpenFile.FileName.ToUpper().EndsWith(".GRD"))
                    LoadGrdFile(dlgOpenFile.FileName);
                else if (dlgOpenFile.FileName.ToUpper().EndsWith(".TSV"))
                    LoadTsvFile(dlgOpenFile.FileName);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.gridControl2.Focus();
            if (!this.gridControl2.CurrentCell.HasCurrentCell || messageBoxShown)
            {
                this.gridControl2.CurrentCell.MoveTo(1, 0);
                messageBoxShown = false;
            }
            bool found = false;
            int row = this.gridControl2.CurrentCell.RowIndex;
            while (!found && row < this.gridControl2.RowCount)
            {
                row += 1;
                string s = this.gridControl2[row, 1].FormattedText;
                if (s.Length > 0)
                {
                    double d;
                    if (double.TryParse(s, NumberStyles.Any, null, out d))
                    {
                        if (Math.Abs(d) > this.epsilon)
                        {
                            found = true;
                        }
                    }
                }
            }
            this.Cursor = Cursors.Default;
            if (found)
            {
                if (foundRow > 0)
                {
                    int i = foundRow;
                    foundRow = -2;
                    this.gridControl2.RefreshRange(GridRangeInfo.Row(i));
                }
                foundRow = row;
                this.gridControl2.CurrentCell.MoveTo(row, 0, GridSetCurrentCellOptions.ScrollInView);
                this.gridControl2.RefreshRange(GridRangeInfo.Row(foundRow));
            }
            else
            {
                if (foundRow > 0)
                {
                    int i = foundRow;
                    foundRow = -2;
                    this.gridControl2.RefreshRange(GridRangeInfo.Row(i));
                }
                messageBoxShown = true;
                MessageBox.Show("Search Completed", "Info");
            }
        }
        #endregion

        private void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxAdv1.SelectedIndex == -1)
            {
                return;
            }
            string s = this.comboBoxAdv1.Items[this.comboBoxAdv1.SelectedIndex].ToString().Trim();
            if (double.TryParse(s, NumberStyles.Any, null, out epsilon))
            {
                try
                {
                    this.format = epsilon.ToString("#.###############");
                    int i = this.format.IndexOf('1');
                    if (i > -1)
                        this.format = this.format.Substring(0, i + 1);
                    this.format = this.format.Replace('1', '0');
                    this.gridControl1.Refresh();
                }
                catch { }
            }
        }
        #endregion

    }

}
