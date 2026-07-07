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
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Drawing;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Syncfusion.Windows.Forms;
using Syncfusion.Diagnostics;
using Syncfusion.Styles;
using DemoCommon.Grid;
namespace GridControl
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : GridDemoForm
	{
		#region API Definition
        private Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
        private ButtonAdv button1;
        private ButtonAdv buttonAdv1;
        private ButtonAdv buttonAdv2;
        private ButtonAdv buttonAdv3;
        private ButtonAdv buttonAdv4;
        private ButtonAdv buttonAdv5;
        private ButtonAdv buttonAdv6;
        private Panel panel1;
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
            GridSettings();
        }
        #endregion    

        #region GridSettings
        /// <summary>
        /// Grid settings for better look and feel. 
        /// </summary>
        private void GridSettings()
        {
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            this.gridControl1.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(100.0f);
            this.gridControl1.ColCount = 20;
            this.gridControl1.BackColor = Color.White;
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.GridVisualStyles = GridVisualStyles.Metro;        

            //tab key navigation set as false to move the next control
            this.gridControl1.WantTabKey = false;
        }
        #endregion

		#region Designer Stuffs
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
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv4 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv5 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv6 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.gridControl1.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)});
            this.gridControl1.CoveredRanges.AddRange(new Syncfusion.Windows.Forms.Grid.GridRangeInfo[] {
            Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(6, 2, 8, 8)});
           
            this.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridControl1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridControl1.ThemesEnabled = true;           
            this.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;                       
            this.gridControl1.Location = new System.Drawing.Point(23, 12);
            this.gridControl1.MetroScrollBars = true;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Properties.BackgroundColor = System.Drawing.Color.White;
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
            gridRangeStyle2.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(6, 2);
            gridRangeStyle2.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick);
            gridRangeStyle2.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick);
            gridRangeStyle2.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick);
            gridRangeStyle2.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick);
            gridRangeStyle2.StyleInfo.Font.Bold = true;
            gridRangeStyle2.StyleInfo.Font.Facename = "Tahoma";
            gridRangeStyle2.StyleInfo.Font.Italic = false;
            gridRangeStyle2.StyleInfo.Font.Size = 15.75F;
            gridRangeStyle2.StyleInfo.Font.Strikeout = false;
            gridRangeStyle2.StyleInfo.Font.Underline = false;
            gridRangeStyle2.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle2.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridRangeStyle2.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220))))), System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(124)))), ((int)(((byte)(130))))));
            gridRangeStyle2.StyleInfo.Text = "Syncfusion - Essential Grid";
            gridRangeStyle2.StyleInfo.TextColor = System.Drawing.Color.White;
            gridRangeStyle2.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            gridRangeStyle3.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(6, 3, 8, 6);
            gridRangeStyle3.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.Orange, Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick);
            gridRangeStyle3.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.Orange, Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick);
            gridRangeStyle3.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.Orange, Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick);
            gridRangeStyle3.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.Orange, Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick);
            gridRangeStyle3.StyleInfo.Font.Bold = true;
            gridRangeStyle3.StyleInfo.Font.Facename = "Tahoma";
            gridRangeStyle3.StyleInfo.Font.Italic = false;
            gridRangeStyle3.StyleInfo.Font.Size = 15.75F;
            gridRangeStyle3.StyleInfo.Font.Strikeout = false;
            gridRangeStyle3.StyleInfo.Font.Underline = false;
            gridRangeStyle3.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle3.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridRangeStyle3.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(221))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(109))))));
            gridRangeStyle3.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(65)))), ((int)(((byte)(125)))));
            gridRangeStyle3.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            gridRangeStyle4.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(7, 2, 8, 6);
            gridRangeStyle4.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.Orange, Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick);
            gridRangeStyle4.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.Orange, Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick);
            gridRangeStyle4.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.Orange, Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick);
            gridRangeStyle4.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.Orange, Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick);
            gridRangeStyle4.StyleInfo.Font.Bold = true;
            gridRangeStyle4.StyleInfo.Font.Facename = "Tahoma";
            gridRangeStyle4.StyleInfo.Font.Italic = false;
            gridRangeStyle4.StyleInfo.Font.Size = 15.75F;
            gridRangeStyle4.StyleInfo.Font.Strikeout = false;
            gridRangeStyle4.StyleInfo.Font.Underline = false;
            gridRangeStyle4.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle4.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridRangeStyle4.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(221))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(109))))));
            gridRangeStyle4.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(65)))), ((int)(((byte)(125)))));
            gridRangeStyle4.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            this.gridControl1.RangeStyles.AddRange(new Syncfusion.Windows.Forms.Grid.GridRangeStyle[] {
            gridRangeStyle1,
            gridRangeStyle2,
            gridRangeStyle3,
            gridRangeStyle4});
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridControl1.RowCount = 35;
            this.gridControl1.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)});
            this.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode;
            this.gridControl1.Size = new System.Drawing.Size(869, 425);
            this.gridControl1.SmartSizeBox = false;            
            this.gridControl1.TabIndex = 0;
            this.gridControl1.Tag = "SaveXmlSchema";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(106, 34);
            this.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.IsBackStageButton = false;
            this.button1.Location = new System.Drawing.Point(11, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Soap Serialize";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.FlatStyle = FlatStyle.Flat;
            this.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(101, 34);
            this.buttonAdv1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.buttonAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.Location = new System.Drawing.Point(132, 6);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(101, 34);
            this.buttonAdv1.TabIndex = 13;
            this.buttonAdv1.Text = "Soap Deserialize";
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv2.FlatStyle = FlatStyle.Flat;
            this.buttonAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonAdv2.BeforeTouchSize = new System.Drawing.Size(107, 34);
            this.buttonAdv2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.buttonAdv2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv2.ForeColor = System.Drawing.Color.White;
            this.buttonAdv2.IsBackStageButton = false;
            this.buttonAdv2.Location = new System.Drawing.Point(254, 6);
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Size = new System.Drawing.Size(107, 34);
            this.buttonAdv2.TabIndex = 14;
            this.buttonAdv2.Text = "Binary Serialize";
            this.buttonAdv2.Click += new System.EventHandler(this.buttonAdv2_Click);
            // 
            // buttonAdv3
            // 
            this.buttonAdv3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdv3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv3.FlatStyle = FlatStyle.Flat;
            this.buttonAdv3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonAdv3.BeforeTouchSize = new System.Drawing.Size(116, 34);
            this.buttonAdv3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.buttonAdv3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv3.ForeColor = System.Drawing.Color.White;
            this.buttonAdv3.IsBackStageButton = false;
            this.buttonAdv3.Location = new System.Drawing.Point(379, 6);
            this.buttonAdv3.Name = "buttonAdv3";
            this.buttonAdv3.Size = new System.Drawing.Size(116, 34);
            this.buttonAdv3.TabIndex = 15;
            this.buttonAdv3.Text = "Binary Deserialize";
            this.buttonAdv3.Click += new System.EventHandler(this.buttonAdv3_Click);
            // 
            // buttonAdv4
            // 
            this.buttonAdv4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdv4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv4.FlatStyle = FlatStyle.Flat;
            this.buttonAdv4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonAdv4.BeforeTouchSize = new System.Drawing.Size(118, 34);
            this.buttonAdv4.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.buttonAdv4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv4.ForeColor = System.Drawing.Color.White;
            this.buttonAdv4.IsBackStageButton = false;
            this.buttonAdv4.Location = new System.Drawing.Point(513, 6);
            this.buttonAdv4.Name = "buttonAdv4";
            this.buttonAdv4.Size = new System.Drawing.Size(118, 34);
            this.buttonAdv4.TabIndex = 16;
            this.buttonAdv4.Text = "Save XML Schema";
            this.buttonAdv4.Click += new System.EventHandler(this.buttonAdv4_Click);
            // 
            // buttonAdv5
            // 
            this.buttonAdv5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdv5.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv5.FlatStyle = FlatStyle.Flat;
            this.buttonAdv5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonAdv5.BeforeTouchSize = new System.Drawing.Size(114, 34);
            this.buttonAdv5.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.buttonAdv5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv5.ForeColor = System.Drawing.Color.White;
            this.buttonAdv5.IsBackStageButton = false;
            this.buttonAdv5.Location = new System.Drawing.Point(649, 6);
            this.buttonAdv5.Name = "buttonAdv5";
            this.buttonAdv5.Size = new System.Drawing.Size(114, 34);
            this.buttonAdv5.TabIndex = 17;
            this.buttonAdv5.Text = "Load XML Schema";
            this.buttonAdv5.Click += new System.EventHandler(this.buttonAdv5_Click);
            // 
            // buttonAdv6
            // 
            this.buttonAdv6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdv6.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv6.FlatStyle = FlatStyle.Flat;
            this.buttonAdv6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonAdv6.BeforeTouchSize = new System.Drawing.Size(87, 34);
            this.buttonAdv6.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.buttonAdv6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv6.ForeColor = System.Drawing.Color.White;
            this.buttonAdv6.IsBackStageButton = false;
            this.buttonAdv6.Location = new System.Drawing.Point(782, 6);
            this.buttonAdv6.Name = "buttonAdv6";
            this.buttonAdv6.Size = new System.Drawing.Size(87, 34);
            this.buttonAdv6.TabIndex = 18;
            this.buttonAdv6.Text = "Reset Grid";
            this.buttonAdv6.Click += new System.EventHandler(this.buttonAdv6_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buttonAdv4);
            this.panel1.Controls.Add(this.buttonAdv6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonAdv5);
            this.panel1.Controls.Add(this.buttonAdv1);
            this.panel1.Controls.Add(this.buttonAdv2);
            this.panel1.Controls.Add(this.buttonAdv3);
            this.panel1.Location = new System.Drawing.Point(23, 443);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 51);
            this.panel1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 495);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridControl1);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "Form1";            
            this.Text = "Serialize Grid Control";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
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
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
            Application.Run(new Form1());
        }
		#endregion
 
        #region Button Click Event handlers
        /// <summary>
        /// Serializing the grid to SOAP format. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //Serialization using Soap Formatter
            FileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Soap files (*.soap)|*.soap|All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    //Save the grid model object to a stream in SOAP format
                    this.gridControl1.Model.SaveSoap(dlg.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            }
		

        }
        /// <summary>
        /// Deserializing the SOAP format to grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            //Deserialization using Soap Formatter
            FileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Soap files (*.soap)|*.soap|All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    //Recreates a grid model object from a strem with data in SOAP format
                    this.gridControl1.Model = GridModel.LoadSoap(dlg.FileName);
                    this.gridControl1.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            }
        }
        /// <summary>
        /// Serializing the grid to Binary format
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            //Serialization using Binary Formatter
            FileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Binary files (*.egt)|*.egt|All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    //Save the grid model object to a stream in Binary format
                    this.gridControl1.Model.SaveBinary(dlg.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            }
        }    

        /// <summary>
        /// Deserializing the binary format to Grid. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdv3_Click(object sender, EventArgs e)
        {
            //Deserialization using Binary Formatter
            FileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Binary files (*.egt)|*.egt|All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    //Recreates a grid model object from a strem with data in Binary format
                    this.gridControl1.Model = GridModel.LoadBinary(dlg.FileName);
                    this.gridControl1.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            }
        }

        /// <summary>
        /// Serializing the grid to XML format. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdv4_Click(object sender, EventArgs e)
        {
            //Xml Serialization
            FileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Xml files (*.xml)|*.xml|All files (*.*)|*.*";
            dlg.FileName = "Untitled";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Stream s = null;

                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    this.gridControl1.SaveXml(dlg.FileName);
                }
                catch (Exception ex)
                {
                    s.Close();
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            }
        }

        /// <summary>
        /// Deserializing the XML format to grid. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdv5_Click(object sender, EventArgs e)
        {
            //Xml Deserialization
            FileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Xml files (*.xml)|*.xml";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Stream s = null;
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    this.gridControl1.InitializeFromXml(dlg.FileName);
                    this.gridControl1.Refresh();
                }
                catch (Exception ex)
                {
                    s.Close();
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void buttonAdv6_Click(object sender, EventArgs e)
        {
            this.gridControl1.ResetRangeStyles();
            this.gridControl1.GridVisualStyles = GridVisualStyles.SystemTheme;
        }
#endregion
	}
}
