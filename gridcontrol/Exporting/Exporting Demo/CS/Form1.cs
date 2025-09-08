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
using System.IO;
using System.Drawing.Imaging;

using Syncfusion.Windows.Forms.Grid;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.Collections.Generic;
using Syncfusion.Windows.Forms;
using System.Collections.Specialized;
using System.Diagnostics;
using Syncfusion.Drawing;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf;
using Syncfusion.Diagnostics;
using Syncfusion.XlsIO;
using Syncfusion.GridExcelConverter;
using Syncfusion.GridHelperClasses;
using System.Text;
using DemoCommon.Grid;


namespace ExportingDemo
{
	public class Form1 : GridDemoForm
    {
        #region API Definition
        private Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
        private System.Windows.Forms.Panel panel1;
        private GroupBox groupBox11;
        private ButtonAdv buttonAdv7;
        public DomainUpDown domainUpDown1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
        private GroupBox groupBox1;
        private ButtonAdv buttonAdv1;
        private Syncfusion.Windows.Forms.Tools.XPTaskBar xpTaskBar1;
        private Syncfusion.Windows.Forms.Tools.XPTaskBarBox xpTaskBarBox1;
        private Syncfusion.Windows.Forms.Tools.XPTaskBarBox xpTaskBarBox2;
        private Syncfusion.Windows.Forms.Tools.XPTaskBarBox xpTaskBarBox4;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel4;
        private Syncfusion.Windows.Forms.Tools.XPTaskBarBox xpTaskBarBox3;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel5;
        private GroupBox groupBox9;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBox1;
        private ButtonAdv buttonAdv5;
        private ButtonAdv buttonAdv4;
        private ButtonAdv buttonAdv6;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private GroupBox groupBox2;
        private ButtonAdv buttonAdv8;
        private ButtonAdv buttonAdv3;
        private ButtonAdv buttonAdv2;
        private IContainer components;
        #endregion

        #region Constructor
        public Form1()
		{
			InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
           // this.gridControl1.AllowProportionalColumnSizing = true;
			GridModel model = gridControl1.Model;
			model.Options.FloatCellsMode = GridFloatCellsMode.OnDemandCalculation;            
			GridFontInfo boldFont = new GridFontInfo();
			boldFont.Bold = true;			
			boldFont.Size = 10;
			boldFont.Underline = true;
			gridControl1.Rows.DefaultSize += 2;
			int boldfontRowHeight = gridControl1.Rows.DefaultSize + 6;

            //String collections...
            StringCollection ar = new StringCollection();
            ar.Add("Range Export");
            ar.Add("Selected Export");
            ar.Add("Entire Export");
            comboBox1.DataSource = ar;

            StringCollection ar1 = new StringCollection();
            ar1.Add("SelectedRange");
            ar1.Add("Merged");
            ar1.Add("Entire");
            comboBoxAdv1.DataSource = ar1;


            for (int i = 0; i <= 90; i++)
            {
                this.domainUpDown1.Items.Add(i);
                if (i <= this.gridControl1.RowCount)
                {
                    this.domainUpDown1.Items.Add(i);
                }
            }
            domainUpDown1.SelectedIndex = 10;          
			model.Options.ControllerOptions = GridControllerOptions.All;
			model.Options.DataObjectConsumerOptions = GridDataObjectConsumerOptions.All;
			GridStyleInfo standard = model.BaseStylesMap["Standard"].StyleInfo;
			GridStyleInfo header = model.BaseStylesMap["Header"].StyleInfo;
			GridStyleInfo rowHeader = model.BaseStylesMap["Row Header"].StyleInfo;
			GridStyleInfo colHeader = model.BaseStylesMap["Column Header"].StyleInfo;
			header.Interior = new BrushInfo(SystemColors.Control);
			rowHeader.Interior = new BrushInfo(SystemColors.Control);			
			standard.Font.Facename = "Helvetica";
			standard.VerticalAlignment = GridVerticalAlignment.Middle;
            this.gridControl1.RowCount = 50;
            this.xpTaskBarBox1.Collapsed = true;
            this.xpTaskBarBox2.Collapsed = true;
            this.xpTaskBarBox3.Collapsed = true;
            this.xpTaskBarBox4.Collapsed = true;
            this.xpTaskBarBox4.AfterAnimation += new EventHandler(xpTaskBarBox4_AfterAnimation);
            this.xpTaskBarBox3.AfterAnimation += new EventHandler(xpTaskBarBox3_AfterAnimation);
            this.xpTaskBarBox2.AfterAnimation += new EventHandler(xpTaskBarBox2_AfterAnimation);
            this.xpTaskBarBox1.AfterAnimation += new EventHandler(xpTaskBarBox1_AfterAnimation);

            //tab key navigation set as false to move the next control
            this.gridControl1.WantTabKey = false;
            this.gridControl1.ColWidths[0] = (int)DpiAware.LogicalToDeviceUnits(35);

        }

        void xpTaskBarBox1_AfterAnimation(object sender, EventArgs e)
        {
            this.gridControl1.BeginInit();
            this.gridControl1.Model.ClearCells(GridRangeInfo.Table(), true);
            this.gridControl1.ResetColWidthEntries();
            this.gridControl1.ResetRowHeightEntries();
            this.xpTaskBarBox2.Collapsed = true;
            this.xpTaskBarBox3.Collapsed = true;
            this.xpTaskBarBox4.Collapsed = true;
            if (xpTaskBarBox1.Collapsed == false)
            {
                this.PopulateTheGridPdf();
            }
            //this.gridControl1.AllowProportionalColumnSizing = true;
            this.gridControl1.EndInit();
        }

        void xpTaskBarBox2_AfterAnimation(object sender, EventArgs e)
        {
            this.gridControl1.BeginInit();
            this.gridControl1.Model.ClearCells(GridRangeInfo.Table(), true);
            this.gridControl1.ResetColWidthEntries();
            this.gridControl1.ResetRowHeightEntries();
            this.xpTaskBarBox1.Collapsed = true;
            this.xpTaskBarBox3.Collapsed = true;
            this.xpTaskBarBox4.Collapsed = true;
            if (xpTaskBarBox2.Collapsed == false)
            {
                this.PopulateTheGridHtml();
            }
           // this.gridControl1.AllowProportionalColumnSizing = true;
            this.gridControl1.EndInit();
        }

        void xpTaskBarBox3_AfterAnimation(object sender, EventArgs e)
        {
            this.gridControl1.BeginInit();
            this.gridControl1.Model.ClearCells(GridRangeInfo.Table(), true);
            this.gridControl1.ResetColWidthEntries();
            this.gridControl1.ResetRowHeightEntries();
            this.xpTaskBarBox1.Collapsed = true;
            this.xpTaskBarBox2.Collapsed = true;
            this.xpTaskBarBox4.Collapsed = true;
            if (xpTaskBarBox3.Collapsed == false)
            {
                this.PopulateTheGridExcel();
            }
         //   this.gridControl1.AllowProportionalColumnSizing = true;
            this.gridControl1.EndInit();
        }
        void xpTaskBarBox4_AfterAnimation(object sender, EventArgs e)
        {
            this.gridControl1.BeginInit();
            this.gridControl1.Model.ClearCells(GridRangeInfo.Table(), true);
            this.gridControl1.ResetColWidthEntries();
            this.gridControl1.ResetRowHeightEntries();
            this.xpTaskBarBox1.Collapsed = true;
            this.xpTaskBarBox2.Collapsed = true;
            this.xpTaskBarBox3.Collapsed = true;
            if (xpTaskBarBox4.Collapsed == false)
            {
                this.populateTheGridWord();
            }
           // this.gridControl1.AllowProportionalColumnSizing = true;
            this.gridControl1.EndInit();
        }
        #endregion                      

        #region Desginer Stuffs
        /// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo1 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo2 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo3 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo4 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo5 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo6 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo7 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo8 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.xpTaskBar1 = new Syncfusion.Windows.Forms.Tools.XPTaskBar();
            this.xpTaskBarBox3 = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.buttonAdv5 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv4 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv6 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.xpTaskBarBox1 = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.gradientPanel5 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.buttonAdv7 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.xpTaskBarBox2 = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAdv8 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.xpTaskBarBox4 = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar1)).BeginInit();
            this.xpTaskBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBarBox3)).BeginInit();
            this.xpTaskBarBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).BeginInit();
            this.gradientPanel3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBarBox1)).BeginInit();
            this.xpTaskBarBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel5)).BeginInit();
            this.gradientPanel5.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBarBox2)).BeginInit();
            this.xpTaskBarBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBarBox4)).BeginInit();
            this.xpTaskBarBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).BeginInit();
            this.gradientPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DpiAware = true;
            this.gridControl1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            //this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            //| System.Windows.Forms.AnchorStyles.Left) 
            //| System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Dock = DockStyle.Fill;
            this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl1.ColCount = 9;
            this.gridControl1.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(3, 179),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(4, 196)});
            this.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridControl1.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.gridControl1.ForeColor = System.Drawing.Color.MidnightBlue;
            gridCellInfo1.Col = -1;
            gridCellInfo1.Row = -1;
            gridCellInfo1.StyleInfo.Font.Bold = false;
            gridCellInfo1.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo1.StyleInfo.Font.Italic = false;
            gridCellInfo1.StyleInfo.Font.Size = 8.5F;
            gridCellInfo1.StyleInfo.Font.Strikeout = false;
            gridCellInfo1.StyleInfo.Font.Underline = false;
            gridCellInfo1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo2.Col = -1;
            gridCellInfo2.Row = -1;
            gridCellInfo2.StyleInfo.Font.Bold = false;
            gridCellInfo2.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo2.StyleInfo.Font.Italic = false;
            gridCellInfo2.StyleInfo.Font.Size = 8.5F;
            gridCellInfo2.StyleInfo.Font.Strikeout = false;
            gridCellInfo2.StyleInfo.Font.Underline = false;
            gridCellInfo2.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo3.Col = -1;
            gridCellInfo3.Row = -1;
            gridCellInfo3.StyleInfo.Font.Bold = false;
            gridCellInfo3.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo3.StyleInfo.Font.Italic = false;
            gridCellInfo3.StyleInfo.Font.Size = 8.5F;
            gridCellInfo3.StyleInfo.Font.Strikeout = false;
            gridCellInfo3.StyleInfo.Font.Underline = false;
            gridCellInfo3.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo4.Col = -1;
            gridCellInfo4.Row = -1;
            gridCellInfo4.StyleInfo.Font.Bold = false;
            gridCellInfo4.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo4.StyleInfo.Font.Italic = false;
            gridCellInfo4.StyleInfo.Font.Size = 8.5F;
            gridCellInfo4.StyleInfo.Font.Strikeout = false;
            gridCellInfo4.StyleInfo.Font.Underline = false;
            gridCellInfo4.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo5.Col = -1;
            gridCellInfo5.Row = -1;
            gridCellInfo5.StyleInfo.Font.Bold = false;
            gridCellInfo5.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo5.StyleInfo.Font.Italic = false;
            gridCellInfo5.StyleInfo.Font.Size = 8.5F;
            gridCellInfo5.StyleInfo.Font.Strikeout = false;
            gridCellInfo5.StyleInfo.Font.Underline = false;
            gridCellInfo5.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo6.Col = -1;
            gridCellInfo6.Row = -1;
            gridCellInfo6.StyleInfo.Font.Bold = false;
            gridCellInfo6.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo6.StyleInfo.Font.Italic = false;
            gridCellInfo6.StyleInfo.Font.Size = 8.5F;
            gridCellInfo6.StyleInfo.Font.Strikeout = false;
            gridCellInfo6.StyleInfo.Font.Underline = false;
            gridCellInfo6.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo7.Col = -1;
            gridCellInfo7.Row = -1;
            gridCellInfo7.StyleInfo.Font.Bold = false;
            gridCellInfo7.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo7.StyleInfo.Font.Italic = false;
            gridCellInfo7.StyleInfo.Font.Size = 8.5F;
            gridCellInfo7.StyleInfo.Font.Strikeout = false;
            gridCellInfo7.StyleInfo.Font.Underline = false;
            gridCellInfo7.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo8.Col = -1;
            gridCellInfo8.Row = -1;
            gridCellInfo8.StyleInfo.Font.Bold = false;
            gridCellInfo8.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo8.StyleInfo.Font.Italic = false;
            gridCellInfo8.StyleInfo.Font.Size = 8.5F;
            gridCellInfo8.StyleInfo.Font.Strikeout = false;
            gridCellInfo8.StyleInfo.Font.Underline = false;
            gridCellInfo8.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            this.gridControl1.GridCells.AddRange(new Syncfusion.Windows.Forms.Grid.GridCellInfo[] {
            gridCellInfo1,
            gridCellInfo2,
            gridCellInfo3,
            gridCellInfo4,
            gridCellInfo5,
            gridCellInfo6,
            gridCellInfo7,
            gridCellInfo8});
            this.gridControl1.ThemesEnabled = true;
            //this.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            //this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            this.gridControl1.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(70.0f);
            this.gridControl1.HorizontalThumbTrack = true;
            this.gridControl1.Location = new System.Drawing.Point(11, 7);
            //this.gridControl1.MetroScrollBars = true;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Properties.BackgroundColor = System.Drawing.Color.White;
            this.gridControl1.Properties.ForceImmediateRepaint = false;
            this.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridControl1.Properties.MarkColHeader = false;
            this.gridControl1.Properties.MarkRowHeader = false;
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridControl1.RowCount = 30;
            this.gridControl1.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)});
            this.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode;
            this.gridControl1.Size = new System.Drawing.Size(657, 442);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 0;
            this.gridControl1.VerticalThumbTrack = true;
            this.gridControl1.SaveCellText += new Syncfusion.Windows.Forms.Grid.GridCellTextEventHandler(this.gridControl1_SaveCellText);
            this.gridControl1.SaveCellFormattedText += new Syncfusion.Windows.Forms.Grid.GridCellTextEventHandler(this.gridControl1_SaveCellFormattedText);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Controls.Add(this.xpTaskBar1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 468);
            this.panel1.TabIndex = 4;
            // 
            // xpTaskBar1
            // 
            //this.xpTaskBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            //| System.Windows.Forms.AnchorStyles.Right)));
            this.xpTaskBar1.Dock = DockStyle.Right;
            this.xpTaskBar1.AutoSize = true;
            this.xpTaskBar1.BackColor = System.Drawing.Color.White;
            this.xpTaskBar1.BeforeTouchSize = new System.Drawing.Size(310, 1042);
            this.xpTaskBar1.BorderColor = System.Drawing.Color.Black;
            this.xpTaskBar1.Controls.Add(this.xpTaskBarBox3);
            this.xpTaskBar1.Controls.Add(this.xpTaskBarBox1);
            this.xpTaskBar1.Controls.Add(this.xpTaskBarBox2);
            this.xpTaskBar1.Controls.Add(this.xpTaskBarBox4);
            this.xpTaskBar1.Location = new System.Drawing.Point(685, 7);
            this.xpTaskBar1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.xpTaskBar1.MinimumSize = new System.Drawing.Size(0, 0);
            this.xpTaskBar1.Name = "xpTaskBar1";
            this.xpTaskBar1.Size = new System.Drawing.Size(450, 1042);
            this.xpTaskBar1.TabIndex = 20;
            // 
            // xpTaskBarBox3
            // 
            this.xpTaskBarBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.xpTaskBarBox3.BackColor = System.Drawing.Color.White;
            this.xpTaskBarBox3.Controls.Add(this.gradientPanel3);
            this.xpTaskBarBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xpTaskBarBox3.ForeColor = System.Drawing.Color.White;
            this.xpTaskBarBox3.HeaderBackColor = System.Drawing.Color.DarkGray;
            this.xpTaskBarBox3.HeaderForeColor = System.Drawing.Color.White;
            this.xpTaskBarBox3.HeaderImageIndex = -1;
            this.xpTaskBarBox3.HitTaskBoxArea = false;
            this.xpTaskBarBox3.HotTrackColor = System.Drawing.Color.White;
            this.xpTaskBarBox3.ItemBackColor = System.Drawing.Color.White;
            this.xpTaskBarBox3.Location = new System.Drawing.Point(0, 0);
            this.xpTaskBarBox3.Name = "xpTaskBarBox3";
            this.xpTaskBarBox3.PreferredChildPanelHeight = (int)DpiAware.LogicalToDeviceUnits(179.0f);
            this.xpTaskBarBox3.Size = new System.Drawing.Size(310, 210);
            this.xpTaskBarBox3.TabIndex = 1;
            this.xpTaskBarBox3.Text = "EXCEL";
            this.xpTaskBarBox3.ItemClick += new Syncfusion.Windows.Forms.Tools.XPTaskBarItemClickHandler(this.xpTaskBarBox3_ItemClick);
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.AutoSize = true;
            this.gradientPanel3.BackColor = System.Drawing.Color.White;
            this.gradientPanel3.BorderColor = System.Drawing.Color.White;
            this.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel3.Controls.Add(this.groupBox9);
            this.gradientPanel3.Location = new System.Drawing.Point(2, 29);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(306, 179);
            this.gradientPanel3.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.White;
            this.groupBox9.Controls.Add(this.comboBox1);
            this.groupBox9.Controls.Add(this.buttonAdv5);
            this.groupBox9.Controls.Add(this.buttonAdv4);
            this.groupBox9.Controls.Add(this.buttonAdv6);
            this.groupBox9.Location = new System.Drawing.Point(0, -2);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(300, 176);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.BeforeTouchSize = new System.Drawing.Size(121, 19);
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.Location = new System.Drawing.Point(88, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 19);
            this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox1.TabIndex = 2;
            // 
            // buttonAdv5
            // 
            this.buttonAdv5.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv5.FlatStyle = FlatStyle.Flat;
            this.buttonAdv5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonAdv5.BeforeTouchSize = new System.Drawing.Size(120, 30);
            this.buttonAdv5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAdv5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv5.ForeColor = System.Drawing.Color.White;
            this.buttonAdv5.IsBackStageButton = false;
            this.buttonAdv5.Location = new System.Drawing.Point(89, 128);
            this.buttonAdv5.Name = "buttonAdv5";
            this.buttonAdv5.Size = new System.Drawing.Size(120, 30);
            this.buttonAdv5.TabIndex = 5;
            this.buttonAdv5.Text = "Clear Grid";
            this.buttonAdv5.Click += new System.EventHandler(this.buttonAdv5_Click);
            // 
            // buttonAdv4
            // 
            this.buttonAdv4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv4.FlatStyle = FlatStyle.Flat;
            this.buttonAdv4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonAdv4.BeforeTouchSize = new System.Drawing.Size(120, 32);
            this.buttonAdv4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv4.ForeColor = System.Drawing.Color.White;
            this.buttonAdv4.IsBackStageButton = false;
            this.buttonAdv4.Location = new System.Drawing.Point(169, 71);
            this.buttonAdv4.Name = "buttonAdv4";
            this.buttonAdv4.Size = new System.Drawing.Size(120, 32);
            this.buttonAdv4.TabIndex = 4;
            this.buttonAdv4.Text = "Export";
            this.buttonAdv4.Click += new System.EventHandler(this.buttonAdv4_Click);
            // 
            // buttonAdv6
            // 
            this.buttonAdv6.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv6.FlatStyle = FlatStyle.Flat;
            this.buttonAdv6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonAdv6.BeforeTouchSize = new System.Drawing.Size(119, 32);
            this.buttonAdv6.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAdv6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv6.ForeColor = System.Drawing.Color.White;
            this.buttonAdv6.IsBackStageButton = false;
            this.buttonAdv6.Location = new System.Drawing.Point(12, 71);
            this.buttonAdv6.Name = "buttonAdv6";
            this.buttonAdv6.Size = new System.Drawing.Size(119, 32);
            this.buttonAdv6.TabIndex = 3;
            this.buttonAdv6.Text = "Import";
            this.buttonAdv6.Click += new System.EventHandler(this.buttonAdv6_Click);
            // 
            // xpTaskBarBox1
            // 
            this.xpTaskBarBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.xpTaskBarBox1.BackColor = System.Drawing.Color.White;
            this.xpTaskBarBox1.Controls.Add(this.gradientPanel5);
            this.xpTaskBarBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xpTaskBarBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.xpTaskBarBox1.HeaderBackColor = System.Drawing.Color.DarkGray;
            this.xpTaskBarBox1.HeaderForeColor = System.Drawing.Color.White;
            this.xpTaskBarBox1.HeaderImageIndex = -1;
            this.xpTaskBarBox1.HitTaskBoxArea = false;
            this.xpTaskBarBox1.HotTrackColor = System.Drawing.Color.Empty;
            this.xpTaskBarBox1.ItemBackColor = System.Drawing.Color.White;
            this.xpTaskBarBox1.Location = new System.Drawing.Point(0, 210);
            this.xpTaskBarBox1.Name = "xpTaskBarBox1";
            this.xpTaskBarBox1.PreferredChildPanelHeight = (int)DpiAware.LogicalToDeviceUnits(154.0f);
            this.xpTaskBarBox1.Size = new System.Drawing.Size(310, 185);
            this.xpTaskBarBox1.TabIndex = 6;
            this.xpTaskBarBox1.Text = "PDF";
            // 
            // gradientPanel5
            // 
            this.gradientPanel5.AutoSize = true;
            this.gradientPanel5.BackColor = System.Drawing.Color.White;
            this.gradientPanel5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel5.Controls.Add(this.groupBox11);
            this.gradientPanel5.Location = new System.Drawing.Point(2, 29);
            this.gradientPanel5.Name = "gradientPanel5";
            this.gradientPanel5.Size = new System.Drawing.Size(306, 154);
            this.gradientPanel5.TabIndex = 21;
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.Color.White;
            this.groupBox11.Controls.Add(this.comboBoxAdv1);
            this.groupBox11.Controls.Add(this.domainUpDown1);
            this.groupBox11.Controls.Add(this.buttonAdv7);
            this.groupBox11.ForeColor = System.Drawing.Color.White;
            this.groupBox11.Location = new System.Drawing.Point(1, -2);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(300, 149);
            this.groupBox11.TabIndex = 6;
            this.groupBox11.TabStop = false;
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(119, 21);
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.Location = new System.Drawing.Point(12, 29);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(119, 21);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv1.TabIndex = 7;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(158, 29);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(107, 22);
            this.domainUpDown1.TabIndex = 8;
            // 
            // buttonAdv7
            // 
            this.buttonAdv7.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv7.FlatStyle = FlatStyle.Flat;
            this.buttonAdv7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonAdv7.BeforeTouchSize = new System.Drawing.Size(120, 28);
            this.buttonAdv7.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAdv7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv7.ForeColor = System.Drawing.Color.White;
            this.buttonAdv7.IsBackStageButton = false;
            this.buttonAdv7.Location = new System.Drawing.Point(89, 81);
            this.buttonAdv7.Name = "buttonAdv7";
            this.buttonAdv7.Size = new System.Drawing.Size(120, 28);
            this.buttonAdv7.TabIndex = 9;
            this.buttonAdv7.Text = "Export";
            this.buttonAdv7.Click += new System.EventHandler(this.buttonAdv7_Click);
            // 
            // xpTaskBarBox2
            // 
            this.xpTaskBarBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xpTaskBarBox2.BackColor = System.Drawing.SystemColors.Window;
            this.xpTaskBarBox2.Controls.Add(this.gradientPanel1);
            this.xpTaskBarBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xpTaskBarBox2.HeaderBackColor = System.Drawing.Color.DarkGray;
            this.xpTaskBarBox2.HeaderForeColor = System.Drawing.Color.White;
            this.xpTaskBarBox2.HeaderImageIndex = -1;
            this.xpTaskBarBox2.HitTaskBoxArea = false;
            this.xpTaskBarBox2.HotTrackColor = System.Drawing.Color.White;
            this.xpTaskBarBox2.ItemBackColor = System.Drawing.Color.White;
            this.xpTaskBarBox2.Location = new System.Drawing.Point(0, 395);
            this.xpTaskBarBox2.Name = "xpTaskBarBox2";
            this.xpTaskBarBox2.PreferredChildPanelHeight = (int)DpiAware.LogicalToDeviceUnits(176.0f);
            this.xpTaskBarBox2.Size = new System.Drawing.Size(310, 207);
            this.xpTaskBarBox2.TabIndex = 9;
            this.xpTaskBarBox2.Text = "HTML";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.AutoSize = true;
            this.gradientPanel1.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel1.Controls.Add(this.groupBox2);
            this.gradientPanel1.Location = new System.Drawing.Point(2, 29);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(306, 176);
            this.gradientPanel1.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.buttonAdv8);
            this.groupBox2.Controls.Add(this.buttonAdv3);
            this.groupBox2.Controls.Add(this.buttonAdv2);
            this.groupBox2.Location = new System.Drawing.Point(4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 166);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // buttonAdv8
            // 
            this.buttonAdv8.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv8.FlatStyle = FlatStyle.Flat;
            this.buttonAdv8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonAdv8.BeforeTouchSize = new System.Drawing.Size(134, 30);
            this.buttonAdv8.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAdv8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv8.ForeColor = System.Drawing.Color.White;
            this.buttonAdv8.IsBackStageButton = false;
            this.buttonAdv8.Location = new System.Drawing.Point(12, 34);
            this.buttonAdv8.Name = "buttonAdv8";
            this.buttonAdv8.Size = new System.Drawing.Size(134, 30);
            this.buttonAdv8.TabIndex = 11;
            this.buttonAdv8.Text = "Copy To Clipboard";
            this.buttonAdv8.Click += new System.EventHandler(this.buttonAdv8_Click);
            // 
            // buttonAdv3
            // 
            this.buttonAdv3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv3.FlatStyle = FlatStyle.Flat;
            this.buttonAdv3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonAdv3.BeforeTouchSize = new System.Drawing.Size(120, 30);
            this.buttonAdv3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAdv3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv3.ForeColor = System.Drawing.Color.White;
            this.buttonAdv3.IsBackStageButton = false;
            this.buttonAdv3.Location = new System.Drawing.Point(169, 34);
            this.buttonAdv3.Name = "buttonAdv3";
            this.buttonAdv3.Size = new System.Drawing.Size(120, 30);
            this.buttonAdv3.TabIndex = 12;
            this.buttonAdv3.Text = "Select Table";
            this.buttonAdv3.Click += new System.EventHandler(this.buttonAdv3_Click);
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv2.FlatStyle = FlatStyle.Flat;
            this.buttonAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonAdv2.BeforeTouchSize = new System.Drawing.Size(112, 29);
            this.buttonAdv2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAdv2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv2.ForeColor = System.Drawing.Color.White;
            this.buttonAdv2.IsBackStageButton = false;
            this.buttonAdv2.Location = new System.Drawing.Point(97, 96);
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Size = new System.Drawing.Size(112, 29);
            this.buttonAdv2.TabIndex = 13;
            this.buttonAdv2.Text = "Export";
            this.buttonAdv2.Click += new System.EventHandler(this.buttonAdv2_Click);
            // 
            // xpTaskBarBox4
            // 
            this.xpTaskBarBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xpTaskBarBox4.BackColor = System.Drawing.Color.White;
            this.xpTaskBarBox4.Controls.Add(this.gradientPanel4);
            this.xpTaskBarBox4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xpTaskBarBox4.HeaderBackColor = System.Drawing.Color.DarkGray;
            this.xpTaskBarBox4.HeaderForeColor = System.Drawing.Color.White;
            this.xpTaskBarBox4.HeaderImageIndex = -1;
            this.xpTaskBarBox4.HitTaskBoxArea = false;
            this.xpTaskBarBox4.HotTrackColor = System.Drawing.Color.Empty;
            this.xpTaskBarBox4.ItemBackColor = System.Drawing.Color.White;
            this.xpTaskBarBox4.Location = new System.Drawing.Point(0, 602);
            this.xpTaskBarBox4.Name = "xpTaskBarBox4";
            this.xpTaskBarBox4.PreferredChildPanelHeight = (int)DpiAware.LogicalToDeviceUnits(109.0f);
            this.xpTaskBarBox4.Size = new System.Drawing.Size(310, 140);
            this.xpTaskBarBox4.TabIndex = 3;
            this.xpTaskBarBox4.Text = "WORD";
            // 
            // gradientPanel4
            // 
            this.gradientPanel4.AutoSize = true;
            this.gradientPanel4.BackColor = System.Drawing.Color.White;
            this.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel4.Controls.Add(this.groupBox1);
            this.gradientPanel4.Location = new System.Drawing.Point(2, 29);
            this.gradientPanel4.Name = "gradientPanel4";
            this.gradientPanel4.Size = new System.Drawing.Size(306, 109);
            this.gradientPanel4.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.buttonAdv1);
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 96);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.FlatStyle = FlatStyle.Flat;
            this.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(121, 32);
            this.buttonAdv1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.Location = new System.Drawing.Point(85, 48);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(121, 32);
            this.buttonAdv1.TabIndex = 14;
            this.buttonAdv1.Text = "    Word Export";
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 468);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.Text = "Exporting";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar1)).EndInit();
            this.xpTaskBar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBarBox3)).EndInit();
            this.xpTaskBarBox3.ResumeLayout(false);
            this.xpTaskBarBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).EndInit();
            this.gradientPanel3.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBarBox1)).EndInit();
            this.xpTaskBarBox1.ResumeLayout(false);
            this.xpTaskBarBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel5)).EndInit();
            this.gradientPanel5.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBarBox2)).EndInit();
            this.xpTaskBarBox2.ResumeLayout(false);
            this.xpTaskBarBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBarBox4)).EndInit();
            this.xpTaskBarBox4.ResumeLayout(false);
            this.xpTaskBarBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).EndInit();
            this.gradientPanel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
        private void Form1_Load(object sender, System.EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.buttonAdv8, "click Select table and copy to clipboard");
            this.PopulateTheGridExcel();
            this.xpTaskBarBox3.Collapsed = false;
            this.gridControl1.TableStyle.TextColor = Color.DimGray;
        }
        #region Dispose
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
        #endregion
		#endregion

        #region Main
        /// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
            # if SyncfusionFramework1_1 || SyncfusionFramework2_0  
			Application.EnableVisualStyles();			
              # endif
			Application.Run(new Form1());
		}
        #endregion

        #region Methods

        private string RandomString(Random r)
        {
            int len = r.Next(12) + 1;
            System.Text.StringBuilder sb = new System.Text.StringBuilder(len);

            for (int i = 0; i < len; ++i)
                sb.Append((char)(r.Next(26) + 65));

            return sb.ToString();
        }
        private void populateTheGridWord()
        {
            this.gridControl1.SuspendLayout();
            Random rand = new Random();
            for (int i = 1; i <= gridControl1.RowCount; i++)
                for (int j = 1; j <= gridControl1.ColCount; j++)
                {
                    this.gridControl1[i, j].Text = (10 * (i * j)).ToString();
                    this.gridControl1[0, j].Text = "C" + j.ToString();
                    this.gridControl1[i, 0].Text = "R" + i.ToString();
                }
            this.gridControl1.ColWidths[0] = (int)DpiAware.LogicalToDeviceUnits(35);
            //this.gridControl1.AllowProportionalColumnSizing = true;
            this.gridControl1.ResumeLayout();
        }
        private void PopulateTheGridHtml()
        {
            this.gridControl1.SuspendLayout();
           // gridControl1.Model.ColStyles[1].TextColor = Color.MidnightBlue;
            gridControl1.Model.ColStyles[1].Font.Size = 30;
            gridControl1.Model.ColStyles[3].VerticalAlignment = GridVerticalAlignment.Middle;
            gridControl1.Model.ColStyles[3].HorizontalAlignment = GridHorizontalAlignment.Right;
            gridControl1.Model.ColStyles[3].TextColor = Color.Red;
            gridControl1.Model.ColStyles[3].Font.Bold = true;
            gridControl1.Model.ColStyles[4].CellType = GridCellTypeName.CheckBox;

            gridControl1.Model.ColStyles[5].Borders.All = new GridBorder(GridBorderStyle.Solid);
            gridControl1.Model.ColStyles[5].CellType = GridCellTypeName.RadioButton;
            gridControl1.Model.ColStyles[5].ChoiceList = new System.Collections.Specialized.StringCollection();
            gridControl1.Model.ColStyles[5].ChoiceList.AddRange(new string[] { "one", "two" });

            gridControl1.Model.ColWidths[1]  =(int)DpiAware.LogicalToDeviceUnits(180);
            gridControl1.Model.ColWidths[5]  =(int)DpiAware.LogicalToDeviceUnits(110);

            gridControl1[1, 1].Text = "Size";
            gridControl1[1, 3].Text = "Align";

            gridControl1.Model.ColStyles[7].CellType = GridCellTypeName.ComboBox;
            gridControl1.Model.ColStyles[7].ChoiceList = this.gridControl1.Model.ColStyles[5].ChoiceList;
            this.gridControl1.ColWidths[0] = (int)DpiAware.LogicalToDeviceUnits(35);
           // this.gridControl1.AllowProportionalColumnSizing = true;
            this.gridControl1.ResumeLayout();
        }
        private void PopulateTheGridPdf()
        {
            this.gridControl1.SuspendLayout();
            Random r = new Random();
            this.gridControl1.CommandStack.Enabled = false;
            for (int row = 1; row <= this.gridControl1.RowCount; ++row)
            {
                for (int col = 1; col <= this.gridControl1.ColCount; ++col)
                {
                    if (col == 2) //datetime col
                    {
                        DateTime dt = new DateTime(r.Next(50) + 1960, r.Next(11) + 1, r.Next(27) + 1);
                        this.gridControl1[row, col].CellValue = dt;
                    }
                    else if (col == 4 || col == 5) //formula col and text col
                    {
                        if (col == 5)
                            this.gridControl1[row, col].CellValue = RandomString(r);
                    }
                    else if (col == 6) //float
                    {
                        this.gridControl1[row, col].CellValue = ((r.Next(2) == 0) ? 1 : -1) * ((float)r.Next(100000)) / 200;
                    }
                    else if (col == 3) //int count col
                        this.gridControl1[row, col].CellValue = row;
                    else //int
                        this.gridControl1[row, col].CellValue = ((r.Next(2) == 0) ? 1 : -1) * r.Next(1000);
                }
            }
            this.gridControl1.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(50.0f);

            if (gridControl1.ColCount >= 1)
            {
                this.gridControl1.ColStyles[1].BackColor = Color.White;
            }
            //column 2 is a date column
            if (gridControl1.ColCount >= 2)
            {
                this.gridControl1.ColStyles[2].CellValueType = typeof(DateTime);
                this.gridControl1.ColStyles[2].Format = "dd MMM yyyy";
                this.gridControl1.ColWidths[2] = (int)DpiAware.LogicalToDeviceUnits(100.0f);
                this.gridControl1[0, 2].Text = "Date";
                this.gridControl1.ColStyles[2].BackColor = Color.FromArgb(237, 240, 246);
                this.gridControl1.ColStyles[3].BackColor = Color.FromArgb(218, 229, 245);
            }
            //column 4 is formula col which used relative notation (row = 0)
            //to enter the formulas as a simgle string as the default value
            //in the column
            if (gridControl1.ColCount >= 4)
            {
                this.gridControl1.ColWidths[4] = (int)DpiAware.LogicalToDeviceUnits(100.0f);
                this.gridControl1[0, 4].Text = "FormulaCell";
                this.gridControl1.ColStyles[4].CellType = "FormulaCell";
                this.gridControl1.ColStyles[4].Text = "= A0 + C0";
                this.gridControl1.ColStyles[4].BackColor = Color.FromArgb(218, 229, 245);//row = 0 means use current row
            }

            //col 6 is a text column
            if (gridControl1.ColCount >= 5)
            {
                this.gridControl1.ColWidths[5] = (int)DpiAware.LogicalToDeviceUnits(100.0f);
                this.gridControl1[0, 5].Text = "Text";
                this.gridControl1.ColStyles[5].BackColor = Color.FromArgb(102, 110, 152);
                this.gridControl1.ColStyles[5].TextColor = Color.White;
            }

            //column 6 is a float column
            if (gridControl1.ColCount >= 6)
            {
                this.gridControl1.ColStyles[6].CellValueType = typeof(float);
                this.gridControl1.ColStyles[6].Format = "####.##";
                this.gridControl1.ColWidths[6] = (int)DpiAware.LogicalToDeviceUnits(100.0f);
                this.gridControl1[0, 6].Text = "floats";
                this.gridControl1.ColStyles[6].BackColor = Color.FromArgb(252, 172, 38);
            }
            //force the entire column to be computed, not just the visible cells
            //so if sort is done on formula column, all cells will have been computed.
            GridFormulaEngine engine = ((GridFormulaCellModel)this.gridControl1.CellModels["FormulaCell"]).Engine;
            engine.RecalculateRange(GridRangeInfo.Col(4), true, true);

            if (gridControl1.ColCount >= 10)
            {
                this.gridControl1.ColStyles[7].BackColor = Color.FromArgb(255, 153, 51);
                this.gridControl1.ColStyles[8].BackColor = Color.FromArgb(238, 122, 3);
                this.gridControl1.ColStyles[9].BackColor = Color.FromArgb(238, 122, 3);
                this.gridControl1.ColStyles[10].BackColor = Color.FromArgb(0xde, 0x64, 0x13);
                this.gridControl1.ColStyles[10].TextColor = Color.White;
            }

            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(18.0f);
            this.gridControl1.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(70.0f);
            this.gridControl1.Properties.GridLineColor = System.Drawing.Color.Silver;
            this.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridControl1.ColWidths[0] = (int)DpiAware.LogicalToDeviceUnits(35);
            // this.gridControl1.AllowProportionalColumnSizing = true;
            this.gridControl1.ResumeLayout();

        }
        private void PopulateTheGridExcel()
        {
            this.gridControl1.SuspendLayout();
            GridFontInfo boldFont = new GridFontInfo();
            boldFont.Bold = true;
            boldFont.Size = 11;
            boldFont.Underline = true;

            int rowIndex = 2;
            int colIndex = 1;

            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2));
            gridControl1[rowIndex, 1].Text = "TextColor";
            gridControl1[rowIndex, 1].Font = boldFont;
            rowIndex++;

            colIndex = 1;
            foreach (Color color in new Color[] {
													Color.Black,
													Color.Red,
													Color.Blue,
													Color.Green,
													Color.Yellow,
													Color.DimGray})
            {
                gridControl1[rowIndex, colIndex].TextColor = color;
                gridControl1[rowIndex, colIndex].Text = ColorConvert.ColorToString(color, true);
                colIndex++;
            }
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Rows(rowIndex - 1, rowIndex));
            rowIndex++;

            rowIndex++;
            colIndex = 1;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2));
            gridControl1[rowIndex, 1].Text = "BackColor";
            gridControl1[rowIndex, 1].Font = boldFont;
            rowIndex++;

            colIndex = 1;
            foreach (Color color in new Color[] {
													SystemColors.ActiveCaptionText,
													Color.Red,
													Color.Blue,
													Color.Green,
													Color.Yellow,
													Color.Black})
            {
                gridControl1[rowIndex, colIndex].TextColor = Color.White;
                gridControl1[rowIndex, colIndex].BackColor = color;
                gridControl1[rowIndex, colIndex].Text = ColorConvert.ColorToString(color, true);
                colIndex++;
            }
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Rows(rowIndex - 1, rowIndex));
            rowIndex++;

            rowIndex++;
            colIndex = 1;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2));
            gridControl1[rowIndex, 1].Text = "Font";
            gridControl1[rowIndex, 1].Font = boldFont;
            rowIndex++;

            foreach (int size in new int[]{
											  6,
											  7,
											  8,
											  10,
											  12,
											  14})
            {
                gridControl1[rowIndex, colIndex].Font.Size = size;
                gridControl1[rowIndex, colIndex].Text = size.ToString();
                colIndex++;
            }
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Rows(rowIndex - 1, rowIndex));

            rowIndex++;
            colIndex = 1;
            foreach (FontStyle fontStyle in new FontStyle[]
			{
				FontStyle.Bold,
				FontStyle.Italic,
				FontStyle.Regular,
				FontStyle.Strikeout,
				FontStyle.Underline,
				FontStyle.Bold|FontStyle.Italic|FontStyle.Regular})
            {
                gridControl1[rowIndex, colIndex].Font.FontStyle = fontStyle;
                gridControl1[rowIndex, colIndex].Text = System.Enum.Format(typeof(FontStyle), fontStyle, "G");
                colIndex++;
            }

            rowIndex++;
            colIndex = 1;
            foreach (String facename in new String[]
			{
				"Comic Sans MS",
				"Arial",
				"Century",
				"Courier New",
				"Times New Roman",
				"Verdana"})
            {
                gridControl1[rowIndex, colIndex].Font.Facename = facename;
                gridControl1[rowIndex, colIndex].Text = facename;
                colIndex++;
            }
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex));
            rowIndex++;

            rowIndex++;
            colIndex = 1;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2));
            gridControl1[rowIndex, 1].Text = "Alignment";
            gridControl1[rowIndex, 1].Font = boldFont;
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex));
            rowIndex++;

            gridControl1[rowIndex, colIndex].HorizontalAlignment = GridHorizontalAlignment.Left;
            gridControl1[rowIndex, colIndex].VerticalAlignment = GridVerticalAlignment.Top;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex, colIndex + 1));
            gridControl1[rowIndex, colIndex].Text = "Top Left";
            gridControl1.RowHeights[rowIndex] = 30;
            colIndex += 2;

            gridControl1[rowIndex, colIndex].HorizontalAlignment = GridHorizontalAlignment.Center;
            gridControl1[rowIndex, colIndex].VerticalAlignment = GridVerticalAlignment.Middle;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex, colIndex + 1));
            gridControl1[rowIndex, colIndex].Text = "Center";
            colIndex += 2;

            gridControl1[rowIndex, colIndex].HorizontalAlignment = GridHorizontalAlignment.Right;
            gridControl1[rowIndex, colIndex].VerticalAlignment = GridVerticalAlignment.Bottom;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex, colIndex + 1));
            gridControl1[rowIndex, colIndex].Text = "Bottom Right";
            rowIndex++;

            rowIndex++;
            colIndex = 1;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2));
            gridControl1[rowIndex, 1].Text = "Orientation";
            gridControl1[rowIndex, 1].Font = boldFont;
            rowIndex++;

            foreach (int orientation in new int[]
			{
				0,
				30,
				45,
				60,
				90,
				270})
            {
                GridStyleInfo style1 = gridControl1[rowIndex, colIndex];
                style1.HorizontalAlignment = GridHorizontalAlignment.Center;
                style1.VerticalAlignment = GridVerticalAlignment.Middle;
                GridFontInfo font = style1.Font;
                font.Orientation = orientation;
                font.Bold = true;
                style1.Text = "Angle = " + font.Orientation.ToString();
                colIndex++;
            }
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex));
            rowIndex++;

            rowIndex++;
            colIndex = 1;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2));
            gridControl1[rowIndex, 1].Text = "Formula Cell";
            gridControl1[rowIndex, 1].Font = boldFont;
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex));
            rowIndex++;

            Random r = new Random();
            for (; colIndex <= 5; colIndex++)
                gridControl1[rowIndex, colIndex].CellValue = r.Next(500);
            gridControl1[rowIndex, colIndex].CellType = "FormulaCell";
            gridControl1[rowIndex, colIndex].Text = "=SUM(A" + rowIndex + ":" + "E" + rowIndex + ")";

            gridControl1[rowIndex, colIndex].Borders.All = new GridBorder(GridBorderStyle.Solid, Color.Red, GridBorderWeight.ExtraExtraThick);
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex));
            rowIndex++;

            rowIndex++;
            colIndex = 1;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2));
            gridControl1[rowIndex, 1].Text = "Currency Cell";
            gridControl1[rowIndex, 1].Font = boldFont;
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex));
            rowIndex++;

            for (; colIndex <= 6; colIndex++)
            {
                gridControl1[rowIndex, colIndex].CellType = "Currency";
                gridControl1[rowIndex, colIndex].CurrencyEdit.NegativeColor = Color.Black;
                gridControl1[rowIndex, colIndex].CurrencyEdit.CurrencyNegativePattern = 2;
                gridControl1[rowIndex, colIndex].CellValue = r.Next(-100, 100);
            }
            this.gridControl1.Properties.GridLineColor = Color.FromArgb(208, 215, 229);
            GridStyleInfo style = gridControl1.BaseStylesMap["Header"].StyleInfo;
                      style.Font.Facename = "Verdana";
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.gridControl1.ColWidths[0] = (int)DpiAware.LogicalToDeviceUnits(35);

            //this.gridControl1.AllowProportionalColumnSizing = true;
            this.gridControl1.ResumeLayout();
        }

       
        private void gridControl1_SaveCellText(object sender, Syncfusion.Windows.Forms.Grid.GridCellTextEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfo(e);
			ParseText(e);
		}

		private void gridControl1_SaveCellFormattedText(object sender, GridCellTextEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfo(e);
			ParseText(e);
		}

		void ParseText(GridCellTextEventArgs e)
		{
			// By default, the grid will display a warning message box informing the user
			// the entered value is not valid and the user will have to change the value.
			//
			// In this event handler we change the grid defaults behavior such that
			// when the user enters a value that does not fit the cells CellValueType,
			// the input text is accepted and no warning message is shown.
			if (e.Handled || e.Style.Tag == null || !e.Style.Tag.Equals("Custom"))
				return;

			System.Globalization.CultureInfo ci = e.Style.CultureInfo;
			System.Globalization.NumberFormatInfo nfi = ci != null ? ci.NumberFormat : null; 
			try
			{
				e.Style.CellValue = GridCellValueConvert.Parse(e.Text, e.Style.CellValueType, nfi, e.Style.Format);
			}
			catch (Exception ex)
			{
				if (ex is FormatException || ex.InnerException is FormatException)
				{
					e.Style.CellValue = e.Text;
					// possibly could also change CellValueType here 
					e.Style.CellValueType = typeof(string);
					Console.WriteLine("Changed e.Style.CellValueType = typeof(string) for " + e.Style.Identity.ToString());
					// - or -
					// you could also further analyze the input text and assign a type
					// that fits the input text, e.g.
					// e.Style.CellValueType = typeof(datetime);
					// - or - 
					// e.Style.CellValueType = typeof(decimal);
					// etc.
				}
				else
					throw;
			}
			e.Handled = true;
		}
        #endregion
              
        #region Word
        private void buttonAdv1_Click(object sender, EventArgs e)
        {
                GridWordConverter converter = new GridWordConverter(true, true);
                converter.DrawHeader += new GridWordConverterBase.DrawDocHeaderFooterEventHandler(converter_DrawHeader);
                converter.DrawFooter += new GridWordConverterBase.DrawDocHeaderFooterEventHandler(converter_DrawFooter);
                converter.GridToWord("Sample.doc", gridControl1);
#if !NETCORE
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo("Sample.doc");
            info.UseShellExecute = true;
            System.Diagnostics.Process.Start(info);
#else
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "cmd",
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = false,
                CreateNoWindow = true,
                Arguments = "/c start Sample.doc"
            };
            Process.Start(psi);
#endif
        }

        void converter_DrawFooter(object sender, DocHeaderFooterEventArgs e)
        {
            e.Footer.AddParagraph().AppendText("Copyright 2001-2008");
        }

        void converter_DrawHeader(object sender, DocHeaderFooterEventArgs e)
        {
            e.Header.AddParagraph().AppendText("Syncfusion Inc.");
        }

#endregion

#region Excel


        private void buttonAdv4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                ExcelEngine engine = new ExcelEngine();
                IApplication app = engine.Excel.Application;
                IWorkbook book = app.Workbooks.Create(1);

                Syncfusion.GridExcelConverter.GridExcelConverterControl gecc = new Syncfusion.GridExcelConverter.GridExcelConverterControl();

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Files(*.xlsx)|*.xlsx|Files(*.xls)|*.xls";
                saveFileDialog.DefaultExt = ".xlsx";
                saveFileDialog.FileName = "Untitled";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    gecc.ExportRange(GridRangeInfo.Rows(5, 8), this.gridControl1.Model, book.Worksheets[0], ConverterOptions.Default);
                    book.SaveAs(saveFileDialog.FileName);
                    if (MessageBox.Show("Do you wish to open the xls file now?", "Export to Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
#if !NETCORE
                        System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo(saveFileDialog.FileName);
                        info.UseShellExecute = true;
                        System.Diagnostics.Process.Start(info);
#else
                        ProcessStartInfo psi = new ProcessStartInfo
                        {
                            FileName = "cmd",
                            WindowStyle = ProcessWindowStyle.Hidden,
                            UseShellExecute = false,
                            CreateNoWindow = true,
                            Arguments = "/c start " + saveFileDialog.FileName
                        };
                        Process.Start(psi);
#endif
                    }
                }
            }

            if (comboBox1.SelectedIndex == 1)
            {
                if (gridControl1.Selections.Ranges.Count < 1)
                {
                    MessageBox.Show("Please select ranges for export");
                }
                else
                {
                    GridExcelConverterControl ExcelAdv = new GridExcelConverterControl();
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Files(*.xlsx)|*.xlsx|Files(*.xls)|*.xls";
                    saveFileDialog.DefaultExt = ".xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        ExcelAdv.SelectedExport(this.gridControl1.Model, saveFileDialog.FileName, ConverterOptions.Default);

                        if (MessageBox.Show("Do you wish to open the xls file now?", "Export to Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
#if !NETCORE
                            Process proc = new Process();
                            proc.StartInfo.FileName = saveFileDialog.FileName;
                            proc.Start();

#else
                            ProcessStartInfo psi = new ProcessStartInfo
                            {
                                FileName = "cmd",
                                WindowStyle = ProcessWindowStyle.Hidden,
                                UseShellExecute = false,
                                CreateNoWindow = true,
                                Arguments = "/c start " + saveFileDialog.FileName
                            };
                            Process.Start(psi);
#endif
                        }
                    }
                }
            }
            if (comboBox1.SelectedIndex == 2)
            {
                Syncfusion.GridExcelConverter.GridExcelConverterControl gecc = new Syncfusion.GridExcelConverter.GridExcelConverterControl();

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Files(*.xlsx)|*.xlsx|Files(*.xls)|*.xls";
                saveFileDialog.DefaultExt = ".xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    gecc.GridToExcel(this.gridControl1.Model, saveFileDialog.FileName);

                    if (MessageBox.Show("Do you wish to open the xls file now?", "Export to Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
#if !NETCORE
                        Process proc = new Process();
                        proc.StartInfo.FileName = saveFileDialog.FileName;
                        proc.Start();
#else
                        ProcessStartInfo psi = new ProcessStartInfo
                        {
                            FileName = "cmd",
                            WindowStyle = ProcessWindowStyle.Hidden,
                            UseShellExecute = false,
                            CreateNoWindow = true,
                            Arguments = "/c start " + saveFileDialog.FileName
                        };
                        Process.Start(psi);
#endif
                    }
                }
            }
        }

        private void buttonAdv5_Click(object sender, EventArgs e)
        {
            this.gridControl1.Model.ClearCells(GridRangeInfo.Table(), true);
			this.gridControl1.ResetColWidthEntries();
			this.gridControl1.ResetRowHeightEntries();
        }
#endregion
        
#region PDF


        private void buttonAdv7_Click(object sender, EventArgs e)
        {
            
            if (comboBoxAdv1.SelectedIndex == 0)
            {
                if (gridControl1.Selections.Ranges.Count < 1)
                {
                    MessageBox.Show("Please select ranges for export");
                }
                else
                {
                    GridPDFConverter pdfConvertor = new GridPDFConverter();

                    pdfConvertor.ShowHeader = true;
                    pdfConvertor.ShowFooter = true;
                    pdfConvertor.Margins.All = 40;

                    pdfConvertor.DrawPDFHeader += new GridPDFConverter.DrawPDFHeaderFooterEventHandler(pdfConvertor_DrawPDFHeader);

                    pdfConvertor.DrawPDFFooter += new GridPDFConverter.DrawPDFHeaderFooterEventHandler(pdfConvertor_DrawPDFFooter);

                    pdfConvertor.Exporting += new GridPDFConverter.PDFExportingEventHandler(pdfConvertor_Exporting);

                    pdfConvertor.Exported += new GridPDFConverter.PDFExportedEventHandler(pdfConvertor_Exported);

                    GridRangeInfoList range;
                    if (gridControl1.Selections.GetSelectedRanges(out range, false))
                    {
                        try
                        {
                            pdfConvertor.ExportToPdf("Sample1.pdf", this.gridControl1, range.ActiveRange);
                        }
                        catch(Exception ex)
                        {
                            if (ex is IOException)
                            {
                                MessageBox.Show("File is being used by another process. Close the used pdf file and try again");
                            }
                        }
                    }
                    else
                    {
                        //Export only the range passed as argument
                        pdfConvertor.ExportToPdf("Sample1.pdf", this.gridControl1, GridRangeInfo.Rows(5, 10));
                    }
#if !NETCORE
                    //Launching the PDF file using the default Application.[Acrobat Reader]
                    System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo("Sample1.pdf");
                    info.UseShellExecute = true;
                    System.Diagnostics.Process.Start(info);
#else   
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = "cmd",
                        WindowStyle = ProcessWindowStyle.Hidden,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        Arguments = "/c start Sample1.pdf"
                    };
                    Process.Start(psi);
#endif
                }
            }

            if (comboBoxAdv1.SelectedIndex == 1)
            {
                GridPDFConverter pdfConvertor = new GridPDFConverter();

                pdfConvertor.ShowHeader = true;
                pdfConvertor.ShowFooter = true;
                pdfConvertor.Margins.All = 40;

                pdfConvertor.DrawPDFHeader += new GridPDFConverter.DrawPDFHeaderFooterEventHandler(pdfConvertor_DrawPDFHeader);

                pdfConvertor.DrawPDFFooter += new GridPDFConverter.DrawPDFHeaderFooterEventHandler(pdfConvertor_DrawPDFFooter);

                pdfConvertor.Exporting += new GridPDFConverter.PDFExportingEventHandler(pdfConvertor_Exporting);

                pdfConvertor.Exported += new GridPDFConverter.PDFExportedEventHandler(pdfConvertor_Exported);

                //Range of rows to be exported in a PDF file
                pdfConvertor.ExportRange = int.Parse(domainUpDown1.Text);

                if (pdfConvertor.ExportRange > 0 && pdfConvertor.ExportRange <= gridControl1.RowCount)
                {
                    //Merged Export
                    pdfConvertor.ExportToPdfWithMerge("Sample1.pdf", this.gridControl1);
#if !NETCORE
                    //Launching the PDF file using the default Application.[Acrobat Reader]
                    System.Diagnostics.Process.Start("Sample1.pdf");

#else
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = "cmd",
                        WindowStyle = ProcessWindowStyle.Hidden,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        Arguments = "/c start Sample1.pdf"
                    };
                    Process.Start(psi);
#endif
                }
                else
                {
                    pdfConvertor.ExportRange = 60000;
                    MessageBox.Show("Invalid Export Range!");
                }
            }

            if (comboBoxAdv1 .SelectedIndex == 2)
            {
                GridPDFConverter pdfConvertor = new GridPDFConverter();

                pdfConvertor.ShowHeader = true;
                pdfConvertor.ShowFooter = true;
                pdfConvertor.Margins.All = 40;

                pdfConvertor.DrawPDFHeader += new GridPDFConverter.DrawPDFHeaderFooterEventHandler(pdfConvertor_DrawPDFHeader);

                pdfConvertor.DrawPDFFooter += new GridPDFConverter.DrawPDFHeaderFooterEventHandler(pdfConvertor_DrawPDFFooter);

                pdfConvertor.Exporting += new GridPDFConverter.PDFExportingEventHandler(pdfConvertor_Exporting);

                pdfConvertor.Exported += new GridPDFConverter.PDFExportedEventHandler(pdfConvertor_Exported);

                pdfConvertor.ExportToPdf("Sample1.pdf", this.gridControl1);
#if !NETCORE
                //Launching the PDF file using the default Application.[Acrobat Reader]
                System.Diagnostics.Process.Start("Sample1.pdf");
#else
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "cmd",
                    WindowStyle = ProcessWindowStyle.Hidden,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    Arguments = "/c start Sample1.pdf"
                };
                Process.Start(psi);
#endif
            }
        }
        void pdfConvertor_DrawPDFFooter(object sender, PDFHeaderFooterEventArgs e)
        {
            PdfPageTemplateElement footer = e.HeaderFooterTemplate;

            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 8);

            PdfSolidBrush brush = new PdfSolidBrush(Color.Gray);

            PdfPen pen = new PdfPen(Color.DarkBlue, 3f);
            font = new PdfStandardFont(PdfFontFamily.Helvetica, 6, PdfFontStyle.Bold);
            PdfStringFormat format = new PdfStringFormat();
            format.Alignment = PdfTextAlignment.Center;
            format.LineAlignment = PdfVerticalAlignment.Middle;
            footer.Graphics.DrawString("@Copyright 2008", font, brush, new RectangleF(0, footer.Height - 40, footer.Width, footer.Height), format);

            format = new PdfStringFormat();
            format.Alignment = PdfTextAlignment.Right;
            format.LineAlignment = PdfVerticalAlignment.Bottom;

            //Create page number field
            PdfPageNumberField pageNumber = new PdfPageNumberField(font, brush);

            //Create page count field
            PdfPageCountField count = new PdfPageCountField(font, brush);

            PdfCompositeField compositeField = new PdfCompositeField(font, brush, "Page {0} of {1}", pageNumber, count);
            compositeField.Bounds = footer.Bounds;
            compositeField.Draw(footer.Graphics, new PointF(470, footer.Height - 10));

        }

        void pdfConvertor_DrawPDFHeader(object sender, PDFHeaderFooterEventArgs e)
        {
            PdfPageTemplateElement header = e.HeaderFooterTemplate;

            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 24);
            float doubleHeight = font.Height * 2;
            Color activeColor = Color.FromArgb(44, 71, 120);
            SizeF imageSize = new SizeF(110f, 35f);
            //Locating the logo on the right corner of the Drawing Surface
            PointF imageLocation = new PointF(e.HeaderFooterTemplate.Width - imageSize.Width - 20, 5);

            PdfImage img = new PdfBitmap(FindImageFile(@"Common\Images\Grid\PDF_logo\logo.png"));

            //Draw the image in the Header.
            header.Graphics.DrawImage(img, imageLocation, imageSize);

            PdfSolidBrush brush = new PdfSolidBrush(activeColor);

            PdfPen pen = new PdfPen(Color.DarkBlue, 3f);
            font = new PdfStandardFont(PdfFontFamily.Helvetica, 16, PdfFontStyle.Bold);

            //Set formattings for the text
            PdfStringFormat format = new PdfStringFormat();
            format.Alignment = PdfTextAlignment.Center;
            format.LineAlignment = PdfVerticalAlignment.Middle;

            //Draw title
            header.Graphics.DrawString("Syncfusion Essential PDF", font, brush, new RectangleF(0, 0, header.Width, header.Height), format);
            brush = new PdfSolidBrush(Color.Gray);
            font = new PdfStandardFont(PdfFontFamily.Helvetica, 6, PdfFontStyle.Bold);

            format = new PdfStringFormat();
            format.Alignment = PdfTextAlignment.Left;
            format.LineAlignment = PdfVerticalAlignment.Bottom;

            //Draw description
            header.Graphics.DrawString("Header and Footer Demo", font, brush, new RectangleF(0, 0, header.Width, header.Height - 8), format);

            //Draw some lines in the header
            pen = new PdfPen(Color.DarkBlue, 0.7f);
            header.Graphics.DrawLine(pen, 0, 0, header.Width, 0);
            pen = new PdfPen(Color.DarkBlue, 2f);
            header.Graphics.DrawLine(pen, 0, 03, header.Width + 3, 03);
            pen = new PdfPen(Color.DarkBlue, 2f);
            header.Graphics.DrawLine(pen, 0, header.Height - 3, header.Width, header.Height - 3);
            header.Graphics.DrawLine(pen, 0, header.Height, header.Width, header.Height);
        }

        private string FindImageFile(string bitmapName)
        {
            string bitmappath = "";
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    bitmappath = bitmapName;

                bitmapName = @"..\" + bitmapName;
            }
            return bitmappath;
        }

        void pdfConvertor_Exported(object sender, PDFExportedEventArgs e)
        {
            if (comboBoxAdv1.SelectedIndex != 1)
                MessageBox.Show("Export Completed");
        }

        void pdfConvertor_Exporting(object sender, PDFExportingEventArgs e)
        {
            if (comboBoxAdv1.SelectedIndex != 1)
                MessageBox.Show("Export Begins");
        }

#endregion

#region HTML
        private void buttonAdv6_Click(object sender, EventArgs e)
        {
            Syncfusion.GridExcelConverter.GridExcelConverterControl gecc = new Syncfusion.GridExcelConverter.GridExcelConverterControl();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Files(*.xls)|*.xls";
            openFileDialog.DefaultExt = ".xls";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                gecc.ExcelToGrid(openFileDialog.FileName, this.gridControl1.Model);

            this.gridControl1.Refresh();
        }

        private void buttonAdv3_Click(object sender, EventArgs e)
        {
            this.gridControl1.Selections.Add(GridRangeInfo.Table());
        }
        private void buttonAdv8_Click(object sender, EventArgs e)
        {
            CopyHtmlToClipBoard(ExportAsHTML(this.gridControl1.Selections.Ranges).ToString(), false);
        }

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            GridRangeInfoList rL = new GridRangeInfoList();
            rL.Add(GridRangeInfo.Table());
#if !NETCORE
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo(CopyHtmlToClipBoard(ExportAsHTML(rL).ToString(), true));
            info.UseShellExecute = true;
            System.Diagnostics.Process.Start(info);
#else
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "cmd",
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = false,
                CreateNoWindow = true,
                Arguments = "/c start "+ CopyHtmlToClipBoard(ExportAsHTML(rL).ToString(), true)
            };
            Process.Start(psi);
#endif
        }
        #region Borders to HTML STYLE
        string BorderAsStyle(GridBorder border, HeaderInfo header)
        {
            string borderInfo = "";
            if ((header & HeaderInfo.NotHeader) != HeaderInfo.NotHeader)
            {
                switch (header)
                {
                    case HeaderInfo.LightShade:
                        borderInfo += "Solid #F1EFE2";
                        break;
                    case HeaderInfo.DarkShade:
                        borderInfo += "Solid #A9A9A9";
                        break;
                }

            }
            else
                borderInfo += (border.Style == GridBorderStyle.Standard ? gridControl1.DefaultGridBorderStyle.ToString() : border.Style.ToString()) +
                    " " + ColorTranslator.ToHtml(Color.FromArgb(border.Color.A, border.Color.R, border.Color.G, border.Color.B));


            return border.Width.ToString() + "px " + borderInfo;
        }

        string BordersAsStyle(GridBordersInfo borders)
        {
            HeaderInfo header = new HeaderInfo();
            if (borders.GetGridStyleInfo().CellType != GridCellTypeName.Header)
                header = HeaderInfo.NotHeader;

            return "border-top:" + BorderAsStyle(borders.Top, header | HeaderInfo.LightShade) +
                ";border-right:" + BorderAsStyle(borders.Right, header | HeaderInfo.DarkShade) +
                ";border-bottom:" + BorderAsStyle(borders.Bottom, header | HeaderInfo.DarkShade) +
                ";border-left:" + BorderAsStyle(borders.Left, header | HeaderInfo.LightShade) +
                ";";
        }

        [Flags]
        public enum HeaderInfo
        {
            NotHeader = 4,
            LightShade = 2,
            DarkShade = 1
        }

#endregion
#region Font to HTML STYLE
        string FontAsStyle(GridFontInfo font, Color color, GridHorizontalAlignment halign)
        {

            return "font: " + (font.Italic ? "italic " : "") + (font.Bold ? "bold " : "") +
                +font.Size + "px " + font.Facename +
                ";text-decoration:" + (font.Strikeout ? " line-through" : "") + (font.Underline ? " underline" : "") + (!(font.Underline || font.Strikeout) ? " none" : "") +
                ";text-align: " + halign.ToString() +
                ";color:" + ColorTranslator.ToHtml(Color.FromArgb(color.A, color.R, color.G, color.B)) +
                ";";
        }
#endregion
#region enrich HTML
        StringBuilder ExportAsHTML(GridRangeInfoList rangeList)
        {

            GridRangeInfoList expandedRange = rangeList.ExpandRanges(0, 0, this.gridControl1.RowCount, this.gridControl1.ColCount);
            StringBuilder html = new StringBuilder();
            foreach (GridRangeInfo r in expandedRange)
            {
                html.Append("<table border=\"0\">");
                for (int i = r.Top; i <= r.Bottom; i++)
                {
                    html.Append("<tr>");
                    for (int j = r.Left; j <= r.Right; j++)
                    {
                        GridStyleInfo style = this.gridControl1.Model[i, j];

                        string align = style.VerticalAlignment.ToString();
                        string bcolor = ColorTranslator.ToHtml(Color.FromArgb(style.BackColor.A, style.BackColor.R, style.BackColor.G, style.BackColor.B));
                        string fcolor = ColorTranslator.ToHtml(Color.FromArgb(style.TextColor.A, style.TextColor.R, style.TextColor.G, style.TextColor.B));
                        string htmlStyle = BordersAsStyle(style.Borders);
                        htmlStyle += " " + FontAsStyle(style.Font, style.TextColor, style.HorizontalAlignment);

                        object o = (object)style.FormattedText;
                        string tag = "td";

                        //add a non-breaking space (&nbsp;) to empty cells, to make the borders visible:
                        if (!style.HasText)
                            o = (object)"&nbsp;";

                        if (style.CellType == GridCellTypeName.Header)
                        {
                            if (j > this.gridControl1.Cols.HeaderCount && i == 0 && !style.HasText)
                                o = (object)GridRangeInfo.GetAlphaLabel(j);
                            else
                                if (j == 0 && i > this.gridControl1.Rows.HeaderCount && !style.HasText)
                                    o = (object)i;
                            tag = "th";
                        }

                        html.AppendFormat("<" + tag + " width=\"{0}\" height = \"{1}\" valign =\"{2}\" bgcolor=\"{3}\" style=\"{4}\">",
                            this.gridControl1.ColWidths[j], this.gridControl1.RowHeights[i], align, bcolor, htmlStyle);

                        if (style.CellType == GridCellTypeName.CheckBox || style.CellType == GridCellTypeName.PushButton ||
                            style.CellType == GridCellTypeName.RadioButton || style.CellType == GridCellTypeName.Image ||
                            style.CellType == GridCellTypeName.ComboBox)
                        {
                            switch (style.CellType)
                            {
                                case "CheckBox":
                                    html.AppendFormat("<input type=\"checkbox\" id=\"checkboxR{0}C{1}\" name=\"checkbox1\" {2}>", i, j, (style.CheckBoxOptions.HasCheckedValue ? (style.CheckBoxOptions.CheckedValue == style.CellValue.ToString() ? "checked" : "") : (style.CellValue.ToString() == "1") ? "checked" : ""));
                                    html.AppendFormat(style.HasDescription ? style.Description : "");
                                    break;
                                case "Image":
                                    if (style.ImageIndex != -1 && style.ImageList != null && style.ImageList.Images.Count > style.ImageIndex)
                                    {
                                        string srcFile = System.IO.Path.Combine(System.IO.Path.GetTempPath(), System.IO.Path.GetTempFileName() + ".jpg");
                                        style.ImageList.Images[style.ImageIndex].Save(srcFile, System.Drawing.Imaging.ImageFormat.Jpeg);
                                        html.AppendFormat("<img src=\"{0}\">", srcFile);
                                    }
                                    break;
                                case "PushButton":
                                    //To show button uncomment below
                                    //html.AppendFormat("<input type=\"button\" value=\"{0}\">",style.Description);
                                    html.Append(style.Description);
                                    break;
                                case "RadioButton":
                                    for (int rc = 0; rc < style.ChoiceList.Count; rc++)
                                        html.AppendFormat("{0}<input type=\"radio\" id=\"radio{1}R{2}C{3}\" value=\"radio{1}\" name=\"RadioGroup{4}\" {5}>", style.ChoiceList[rc], rc, i, j, i * this.gridControl1.ColCount + j, rc.ToString() == style.CellValue.ToString() ? "checked" : "");
                                    break;
                                case "ComboBox":
                                    if (style.ChoiceList != null)
                                    {
                                        html.Append("<select>");
                                        html.Append("<OPTION></OPTION>");
                                        for (int lc = 0; lc < style.ChoiceList.Count; lc++)
                                            html.AppendFormat("<option value=\"{0}\" {1}>{0}</option>", style.ChoiceList[lc], style.ChoiceList[lc] == style.CellValue.ToString() ? "selected" : "");
                                        html.Append("</select>");
                                    }
                                    else
                                        html.Append(style.FormattedText);
                                    break;
                            }
                        }
                        else
                            html.AppendFormat("{0}", o);

                        html.AppendFormat("</" + tag + ">");
                    }
                    html.Append("</tr>");
                }
                html.Append("</table>");
            }
            return html;
        }
#endregion
#region revamp HTML and place on Clipboard
        public static string CopyHtmlToClipBoard(string html, bool ie)
        {
            if (html != "")
            {

                Encoding enc = Encoding.UTF8;
                string begin = ie ? "<!--Syncfusion Essential Grid-->" : "Version:0.9\r\nStartHTML:{0:000000}\r\nEndHTML:{1:000000}"
                    + "\r\nStartFragment:{2:000000}\r\nEndFragment:{3:000000}\r\n";
                string html_begin = "<html>\r\n<head>\r\n"
                    + "<meta http-equiv=\"Content-Type\""
                    + " content=\"text/html; charset=" + enc.WebName + "\">\r\n"
                    + "<title>Syncfusion Essential Grid</title>\r\n</head>\r\n<body>\r\n"
                    + "<!--StartFragment-->";

                string html_end = "<!--EndFragment-->\r\n</body>\r\n</html>\r\n";

                string begin_sample = String.Format(begin, 0, 0, 0, 0);

                int count_begin = enc.GetByteCount(begin_sample);
                int count_html_begin = enc.GetByteCount(html_begin);
                int count_html = enc.GetByteCount(html);
                int count_html_end = enc.GetByteCount(html_end);

                string html_total = String.Format(
                    begin
                    , count_begin
                    , count_begin + count_html_begin + count_html + count_html_end
                    , count_begin + count_html_begin
                    , count_begin + count_html_begin + count_html
                    ) + html_begin + html + html_end;

                DataObject obj = new DataObject();
                obj.SetData(DataFormats.Html, new System.IO.MemoryStream(
                    enc.GetBytes(html_total)));
                obj.SetData(DataFormats.Text, true, html_total);
                Clipboard.SetDataObject(obj, true);
                string htmlFile = System.IO.Path.Combine(System.IO.Path.GetTempPath(), System.IO.Path.GetTempFileName() + ".html");
                System.IO.StreamWriter sw = System.IO.File.CreateText(htmlFile);
                sw.Write(html_total);
                sw.Close();
                return htmlFile;
            }
            return "";
        }
#endregion

        private void xpTaskBarBox3_ItemClick(object sender, Syncfusion.Windows.Forms.Tools.XPTaskBarItemClickArgs e)
        {

        }

        
#endregion

        
    }
}
