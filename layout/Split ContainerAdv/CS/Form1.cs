#region Copyright Syncfusion Inc. 2001 - 2019
//
//  Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
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
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Licensing;
using System.IO;
using Syncfusion.Windows.Forms.Tools.Enums;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.ListView;
using System.Collections.Generic;
using Syncfusion.Windows.Forms.Grid;

namespace SplitContainerAdv
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : Form
    {
        #region Variables

        private Syncfusion.Windows.Forms.Tools.SplitContainerAdv splitContainerAdv1;
        private ToolTip toolTip1;
        private ImageList imageList1;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge1;
        private Syncfusion.Windows.Forms.Gauge.LinearGauge linearGauge1;
        private CheckBoxAdv checkBox1;
        private AutoLabel label1;
        private SfComboBox sfComboBox1;
        private AutoLabel label2;
        private SfComboBox sfComboBox2;
        private Syncfusion.Windows.Forms.Tools.SplitContainerAdv splitContainerAdv2;
        private CheckBoxAdv checkBoxAdv1;
        private AutoLabel autoLabel1;
        private CheckBoxAdv checkBoxAdv2;
        private TableLayoutPanel tableLayoutPanel2;
        private IContainer components;

        #endregion

        #region Constructor

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            List<string> style = new List<string>();

            style.Add("Office2019Colorful");
            style.Add("HighContrastBlack");
            style.Add("Office2016Colorful");
            style.Add("Office2016White");
            style.Add("Office2016DarkGray");
            style.Add("Office2016Black");

            this.sfComboBox1.DataSource = style;
            this.sfComboBox1.AllowDropDownResize = false;

            List<string> collapsePanelOn = new List<string>();

            collapsePanelOn.Add("Single click");
            collapsePanelOn.Add("Double click");

            this.sfComboBox2.DataSource = collapsePanelOn;

            this.sfComboBox1.SelectedIndexChanged += new EventHandler(SfComboBox1_SelectedIndexChanged);
            this.sfComboBox1.SelectedIndex = 0;
            this.sfComboBox2.SelectedIndex = 0;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
            
            this.splitContainerAdv1.BorderStyle = BorderStyle.None;
            this.splitContainerAdv1.PanelToBeCollapsed = CollapsedPanel.Panel2;
            this.splitContainerAdv2.BorderStyle = BorderStyle.None;
            this.splitContainerAdv2.PanelToBeCollapsed = CollapsedPanel.Panel2;
            this.MaximizeBox = false;
            
            //this.ShowMaximizeBox = false;
        }

        #endregion

        #region methods

        private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
        }

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

        //Get and Load the images
#if NET9_0_OR_GREATER
        private static Image GetImage(string path)
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            if (asm != null && !string.IsNullOrEmpty(path))
                return Image.FromStream(asm.GetManifestResourceStream(path));
            return null;
        }
#endif

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Gauge.Range range1 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range2 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range3 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.LinearRange linearRange1 = new Syncfusion.Windows.Forms.Gauge.LinearRange();
            Syncfusion.Windows.Forms.Gauge.LinearRange linearRange2 = new Syncfusion.Windows.Forms.Gauge.LinearRange();
            Syncfusion.Windows.Forms.Gauge.LinearRange linearRange3 = new Syncfusion.Windows.Forms.Gauge.LinearRange();
            Syncfusion.Windows.Forms.Gauge.LinearRange linearRange4 = new Syncfusion.Windows.Forms.Gauge.LinearRange();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.radialGauge1 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.linearGauge1 = new Syncfusion.Windows.Forms.Gauge.LinearGauge();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.sfComboBox2 = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.sfComboBox1 = new Syncfusion.WinForms.ListView.SfComboBox();
            this.checkBox1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.splitContainerAdv2 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.checkBoxAdv2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv2)).BeginInit();
            this.splitContainerAdv2.Panel1.SuspendLayout();
            this.splitContainerAdv2.Panel2.SuspendLayout();
            this.splitContainerAdv2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.BackColor = System.Drawing.Color.White;
            this.splitContainerAdv1.BeforeTouchSize = 13;
            this.splitContainerAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAdv1.FixedPanel = Syncfusion.Windows.Forms.Tools.Enums.FixedPanel.Panel1;
            this.splitContainerAdv1.HotExpandLine = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.splitContainerAdv1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            this.splitContainerAdv1.Orientation = System.Windows.Forms.Orientation.Vertical;
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainerAdv1.Panel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            this.splitContainerAdv1.Panel1.Controls.Add(this.radialGauge1);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            this.splitContainerAdv1.Panel2.Controls.Add(this.linearGauge1);
            this.splitContainerAdv1.PanelToBeCollapsed = Syncfusion.Windows.Forms.Tools.Enums.CollapsedPanel.Panel1;
            this.splitContainerAdv1.Size = new System.Drawing.Size(598, 596);
            this.splitContainerAdv1.SplitterDistance = 400;
            this.splitContainerAdv1.SplitterWidth = 13;
            this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016Colorful;
            this.splitContainerAdv1.TabIndex = 0;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            this.splitContainerAdv1.ThemeName = "Office2016Colorful";
            // 
            // radialGauge1
            // 
            this.radialGauge1.ArcThickness = 2F;
            this.radialGauge1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radialGauge1.EnableCustomNeedles = false;
            this.radialGauge1.FillColor = System.Drawing.Color.DarkGray;
            this.radialGauge1.FrameThickness = 12;
            this.radialGauge1.FrameType = Syncfusion.Windows.Forms.Gauge.FrameType.HalfCircle;
            this.radialGauge1.GaugeArcColor = System.Drawing.Color.Black;
            this.radialGauge1.GaugeLabel = "Gauge";
            this.radialGauge1.GaugeLableFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge1.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge1.InterLinesColor = System.Drawing.Color.Black;
            this.radialGauge1.LabelPlacement = Syncfusion.Windows.Forms.Gauge.LabelPlacement.Outside;
            this.radialGauge1.Location = new System.Drawing.Point(0, 0);
            this.radialGauge1.MajorDifference = 10F;
            this.radialGauge1.MajorTickMarkColor = System.Drawing.Color.Black;
            this.radialGauge1.MaximumValue = 100F;
            this.radialGauge1.MinimumSize = new System.Drawing.Size(130, 52);
            this.radialGauge1.MinorDifference = 3F;
            this.radialGauge1.MinorTickMarkColor = System.Drawing.Color.Black;
            this.radialGauge1.Name = "radialGauge1";
            this.radialGauge1.NeedleColor = System.Drawing.Color.Black;
            this.radialGauge1.Padding = new System.Windows.Forms.Padding(10);
            range1.Color = System.Drawing.Color.Lime;
            range1.EndValue = 40F;
            range1.Height = 10;
            range1.InRange = false;
            range1.Name = "Normal range";
            range1.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            range1.StartValue = 0F;
            range2.Color = System.Drawing.Color.Yellow;
            range2.EndValue = 80F;
            range2.Height = 10;
            range2.InRange = false;
            range2.Name = "Check Range";
            range2.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            range2.StartValue = 40F;
            range3.Color = System.Drawing.Color.Red;
            range3.EndValue = 100F;
            range3.Height = 10;
            range3.InRange = false;
            range3.Name = "Alert Range";
            range3.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            range3.StartValue = 80F;
            this.radialGauge1.Ranges.Add(range1);
            this.radialGauge1.Ranges.Add(range2);
            this.radialGauge1.Ranges.Add(range3);
            this.radialGauge1.ReadOnly = false;
            this.radialGauge1.ScaleLabelColor = System.Drawing.Color.Black;
            this.radialGauge1.ShowTicks = true;
            this.radialGauge1.Size = new System.Drawing.Size(598, 398);
            this.radialGauge1.StartAngle = 180;
            this.radialGauge1.SweepAngle = 180;
            this.radialGauge1.TabIndex = 1;
            this.radialGauge1.ValueChanged += new System.EventHandler(this.radialGauge1_ValueChanged);
            // 
            // linearGauge1
            // 
            this.linearGauge1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linearGauge1.ForeColor = System.Drawing.Color.Gray;
            this.linearGauge1.GaugelabelFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linearGauge1.LinearFrameType = Syncfusion.Windows.Forms.Gauge.LinearFrameType.Horizontal;
            this.linearGauge1.Location = new System.Drawing.Point(0, 0);
            this.linearGauge1.MajorTicksHeight = 15;
            this.linearGauge1.MaximumSize = new System.Drawing.Size(598, 304);
            this.linearGauge1.MaximumValue = 100F;
            this.linearGauge1.MinimumSize = new System.Drawing.Size(100, 50);
            this.linearGauge1.MinorTickCount = 5;
            this.linearGauge1.MinorTickHeight = 10;
            this.linearGauge1.Name = "linearGauge1";
            this.linearGauge1.Padding = new System.Windows.Forms.Padding(10);
            this.linearGauge1.PointerPlacement = Syncfusion.Windows.Forms.Gauge.Placement.Center;
            linearRange1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            linearRange1.EndValue = 15F;
            linearRange1.Height = 5;
            linearRange1.InRange = false;
            linearRange1.Name = "GaugeRange1";
            linearRange1.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            linearRange1.StartValue = 0F;
            linearRange2.Color = System.Drawing.Color.Yellow;
            linearRange2.EndValue = 30F;
            linearRange2.Height = 5;
            linearRange2.InRange = false;
            linearRange2.Name = "GaugeRange2";
            linearRange2.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            linearRange2.StartValue = 15F;
            linearRange3.Color = System.Drawing.Color.Red;
            linearRange3.EndValue = 40F;
            linearRange3.Height = 5;
            linearRange3.InRange = true;
            linearRange3.Name = "GaugeRange3";
            linearRange3.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            linearRange3.StartValue = 30F;
            linearRange4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            linearRange4.EndValue = 0F;
            linearRange4.Height = 5;
            linearRange4.InRange = false;
            linearRange4.Name = "GaugeRange4";
            linearRange4.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            linearRange4.StartValue = 0F;
            this.linearGauge1.Ranges.Add(linearRange1);
            this.linearGauge1.Ranges.Add(linearRange2);
            this.linearGauge1.Ranges.Add(linearRange3);
            this.linearGauge1.Ranges.Add(linearRange4);
            this.linearGauge1.ReadOnly = false;
            this.linearGauge1.ScaleColor = System.Drawing.Color.Gray;
            this.linearGauge1.Size = new System.Drawing.Size(598, 183);
            this.linearGauge1.TabIndex = 1;
            this.linearGauge1.Text = "linearGauge1";
            this.linearGauge1.Value = 40F;
            this.linearGauge1.ValueIndicatorColor = System.Drawing.Color.Gray;
            this.linearGauge1.ValueChanged += new System.EventHandler(this.linearGauge1_ValueChanged);
            // 
            // imageList1
            // 
#if NET9_0_OR_GREATER
            this.imageList1.Images.Add(GetImage("SplitContainerAdv.Images.ImageList1.Image_1.png"));
            this.imageList1.Images.Add(GetImage("SplitContainerAdv.Images.ImageList1.Image_2.png"));
#else
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
#endif
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Location = new System.Drawing.Point(3, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Toggle Panel On";
            // 
            // sfComboBox2
            // 
            this.sfComboBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sfComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfComboBox2.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.sfComboBox2.Location = new System.Drawing.Point(3, 161);
            this.sfComboBox2.Name = "sfComboBox2";
            this.sfComboBox2.Size = new System.Drawing.Size(187, 28);
            this.sfComboBox2.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfComboBox2.TabIndex = 3;
            this.sfComboBox2.SelectedIndexChanged += new System.EventHandler(this.sfComboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Location = new System.Drawing.Point(3, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Style";
            // 
            // sfComboBox1
            // 
            this.sfComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sfComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfComboBox1.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.sfComboBox1.Location = new System.Drawing.Point(3, 83);
            this.sfComboBox1.Name = "sfComboBox1";
            this.sfComboBox1.Size = new System.Drawing.Size(187, 28);
            this.sfComboBox1.Style.EditorStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfComboBox1.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfComboBox1.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfComboBox1.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox1.AutoSize = false;
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.checkBox1.BeforeTouchSize = new System.Drawing.Size(89, 16);
            this.checkBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.checkBox1.DrawFocusRectangle = false;
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.checkBox1.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.checkBox1.Location = new System.Drawing.Point(3, 206);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 16);
            this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Freeze panes";
            this.checkBox1.ThemeName = "Office2016Colorful";
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // splitContainerAdv2
            // 
            this.splitContainerAdv2.BackColor = System.Drawing.Color.White;
            this.splitContainerAdv2.BeforeTouchSize = 13;
            this.splitContainerAdv2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerAdv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAdv2.FixedPanel = Syncfusion.Windows.Forms.Tools.Enums.FixedPanel.Panel1;
            this.splitContainerAdv2.HotExpandLine = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.splitContainerAdv2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAdv2.Name = "splitContainerAdv2";
            // 
            // splitContainerAdv2.Panel1
            // 
            this.splitContainerAdv2.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainerAdv2.Panel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            this.splitContainerAdv2.Panel1.Controls.Add(this.splitContainerAdv1);
            // 
            // splitContainerAdv2.Panel2
            // 
            this.splitContainerAdv2.Panel2.AutoSize = true;
            this.splitContainerAdv2.Panel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            this.splitContainerAdv2.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainerAdv2.Panel2.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.splitContainerAdv2.PanelToBeCollapsed = Syncfusion.Windows.Forms.Tools.Enums.CollapsedPanel.Panel1;
            this.splitContainerAdv2.Size = new System.Drawing.Size(877, 598);
            this.splitContainerAdv2.SplitterDistance = 600;
            this.splitContainerAdv2.SplitterWidth = 13;
            this.splitContainerAdv2.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016Colorful;
            this.splitContainerAdv2.TabIndex = 2;
            this.splitContainerAdv2.Text = "splitContainerAdv2";
            this.splitContainerAdv2.ThemeName = "Office2016Colorful";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.BackColor = Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.checkBoxAdv2, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxAdv1, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.autoLabel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBox1, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.sfComboBox2, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.sfComboBox1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(21, 57);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 317);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // autoLabel1
            // 
            this.autoLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.autoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.Location = new System.Drawing.Point(3, 9);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(91, 20);
            this.autoLabel1.TabIndex = 7;
            this.autoLabel1.Text = "Properties";
            // 
            // checkBoxAdv2
            // 
            this.checkBoxAdv2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxAdv2.AutoSize = false;
            this.checkBoxAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.checkBoxAdv2.BeforeTouchSize = new System.Drawing.Size(134, 16);
            this.checkBoxAdv2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.checkBoxAdv2.DrawFocusRectangle = false;
            this.checkBoxAdv2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.checkBoxAdv2.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.checkBoxAdv2.Location = new System.Drawing.Point(3, 245);
            this.checkBoxAdv2.Name = "checkBoxAdv2";
            this.checkBoxAdv2.Size = new System.Drawing.Size(134, 16);
            this.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.checkBoxAdv2.TabIndex = 6;
            this.checkBoxAdv2.Text = "Collapse LinearGauge";
            this.checkBoxAdv2.ThemeName = "Office2016Colorful";
            this.checkBoxAdv2.CheckStateChanged += new System.EventHandler(this.checkBoxAdv2_CheckStateChanged);
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxAdv1.AutoSize = false;
            this.checkBoxAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.checkBoxAdv1.BeforeTouchSize = new System.Drawing.Size(135, 16);
            this.checkBoxAdv1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.checkBoxAdv1.DrawFocusRectangle = false;
            this.checkBoxAdv1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.checkBoxAdv1.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.checkBoxAdv1.Location = new System.Drawing.Point(3, 287);
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(135, 16);
            this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.checkBoxAdv1.TabIndex = 5;
            this.checkBoxAdv1.Text = "Collapse RadialGauge";
            this.checkBoxAdv1.ThemeName = "Office2016Colorful";
            this.checkBoxAdv1.CheckStateChanged += new System.EventHandler(this.checkBoxAdv1_CheckStateChanged);
            // 
            // Form1
            // 
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 598);
            this.Controls.Add(this.splitContainerAdv2);
            this.MaximumSize = new System.Drawing.Size(893, 662);
            this.MinimumSize = new System.Drawing.Size(893, 615);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplitContainer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).EndInit();
            this.splitContainerAdv2.Panel1.ResumeLayout(false);
            this.splitContainerAdv2.Panel2.ResumeLayout(false);
            this.splitContainerAdv2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv2)).EndInit();
            this.splitContainerAdv2.ResumeLayout(false);
            this.splitContainerAdv2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Syncfusion.WinForms.Controls.SfSkinManager.LoadAssembly((typeof(Syncfusion.WinForms.Themes.Office2016Theme).Assembly));
            Syncfusion.WinForms.Controls.SfSkinManager.LoadAssembly((typeof(Syncfusion.WinForms.Themes.Office2019Theme).Assembly));
            Syncfusion.WinForms.Controls.SfSkinManager.LoadAssembly((typeof(Syncfusion.HighContrastTheme.WinForms.HighContrastTheme).Assembly));
            Application.Run(new Form1());
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.sfComboBox1.Padding = new Padding(10);
            this.splitContainerAdv1.SplitterDistance = Convert.ToInt32(this.ClientSize.Height * 0.65);
            this.splitContainerAdv2.SplitterDistance = Convert.ToInt32(this.ClientSize.Width * 0.65);
        }

        #region Events 

        void SfComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.sfComboBox1.SelectedItem.ToString() == "Office2016Colorful")
            {
                this.BackColor = Color.White;

                this.splitContainerAdv1.ThemeName = "Office2016Colorful";
                this.splitContainerAdv2.ThemeName = "Office2016Colorful";

                this.radialGauge1.ShowBackgroundFrame = false;
                this.radialGauge1.ThemeName = "Office2016Colorful";

                this.linearGauge1.ThemeName = "Office2016Colorful";
                this.linearGauge1.ValueIndicatorColor = Color.Transparent;
                this.linearGauge1.OuterFrameGradientStartColor = Color.Transparent;
                this.linearGauge1.OuterFrameGradientEndColor = Color.Transparent;
                this.linearGauge1.ForeColor = radialGauge1.ScaleLabelColor;

                this.label1.ThemeName = "Office2016Colorful";
                this.label2.ThemeName = "Office2016Colorful";
                this.autoLabel1.ThemeName = "Office2016Colorful";

                this.sfComboBox1.ThemeName = "Office2016Colorful";
                this.sfComboBox2.ThemeName = "Office2016Colorful";

                this.checkBox1.ThemeName = "Office2016Colorful";
                this.checkBoxAdv1.ThemeName = "Office2016Colorful";
                this.checkBoxAdv2.ThemeName = "Office2016Colorful";
            }
            else if (this.sfComboBox1.SelectedItem.ToString() == "Office2016DarkGray")
            {
                this.BackColor = ColorTranslator.FromHtml("#727272");

                this.splitContainerAdv1.ThemeName ="Office2016DarkGray";
                this.splitContainerAdv2.ThemeName = "Office2016DarkGray";

                this.radialGauge1.ShowBackgroundFrame = false;
                this.radialGauge1.ThemeName = "Office2016DarkGray";
                this.radialGauge1.ScaleLabelColor = Color.White;
                this.radialGauge1.MajorTickMarkColor = Color.White;
                this.radialGauge1.MinorTickMarkColor = Color.White;
                this.radialGauge1.InterLinesColor = Color.White;
                this.radialGauge1.GaugeArcColor = Color.White;
                this.radialGauge1.GaugeLableColor = Color.White;
                this.radialGauge1.NeedleColor = ColorTranslator.FromHtml("#00EFFF");

                this.linearGauge1.ThemeName = "Office2016DarkGray";
                this.linearGauge1.ValueIndicatorColor = Color.Transparent;
                this.linearGauge1.InnerFrameGradientStartColor = Color.Transparent;
                this.linearGauge1.InnerFrameGradientEndColor = Color.Transparent;
                this.linearGauge1.BackgroundGradientStartColor = Color.Transparent;
                this.linearGauge1.BackgroundGradientEndColor = Color.Transparent;
                this.linearGauge1.BackColor = Color.Transparent;                
                this.linearGauge1.OuterFrameGradientStartColor = Color.Transparent;
                this.linearGauge1.OuterFrameGradientEndColor = Color.Transparent;
                this.linearGauge1.ForeColor = Color.White;
                this.linearGauge1.ScaleColor = Color.White;
                this.linearGauge1.MajorTickMarkColor = Color.White;
                this.linearGauge1.MinorTickMarkColor = Color.White;
                this.linearGauge1.NeedleColor = ColorTranslator.FromHtml("#00EFFF");
                
                this.label1.ThemeName = "Office2016DarkGray";
                this.label2.ThemeName = "Office2016DarkGray";
                this.autoLabel1.ThemeName = "Office2016DarkGray";
                this.label2.BackColor = Color.Transparent;
                this.label1.BackColor = Color.Transparent;
                this.autoLabel1.BackColor = Color.Transparent;

                this.sfComboBox1.ThemeName = "Office2016DarkGray";
                this.sfComboBox2.ThemeName = "Office2016DarkGray";

                this.checkBox1.ThemeName = "Office2016DarkGray";
                this.checkBoxAdv1.ThemeName = "Office2016DarkGray";
                this.checkBoxAdv2.ThemeName = "Office2016DarkGray";
                this.checkBox1.BackColor = Color.Transparent;
                this.checkBoxAdv1.BackColor = Color.Transparent;
                this.checkBoxAdv2.BackColor = Color.Transparent;
            }
            else if (this.sfComboBox1.SelectedItem.ToString() == "Office2016White")
            {
                this.BackColor = Color.White;

                this.splitContainerAdv1.ThemeName = "Office2016White";
                this.splitContainerAdv2.ThemeName = "Office2016White";

                this.radialGauge1.ShowBackgroundFrame = false;
                this.radialGauge1.ThemeName = "Office2016White";

                this.linearGauge1.ThemeName = "Office2016White";
                this.linearGauge1.ValueIndicatorColor = Color.Transparent;
                this.linearGauge1.OuterFrameGradientStartColor = Color.Transparent;
                this.linearGauge1.OuterFrameGradientEndColor = Color.Transparent;
                this.linearGauge1.ForeColor = radialGauge1.ScaleLabelColor;

                this.label1.ThemeName = "Office2016White";
                this.label2.ThemeName = "Office2016White";
                this.autoLabel1.ThemeName = "Office2016White";

                this.sfComboBox1.ThemeName = "Office2016White";
                this.sfComboBox2.ThemeName = "Office2016White";

                this.checkBox1.ThemeName = "Office2016White";
                this.checkBoxAdv1.ThemeName = "Office2016White";
                this.checkBoxAdv2.ThemeName = "Office2016White";
            }
            else if (this.sfComboBox1.SelectedItem.ToString() == "Office2016Black")
            {
                this.BackColor = ColorTranslator.FromHtml("#262626");

                this.splitContainerAdv1.ThemeName = "Office2016Black";
                this.splitContainerAdv2.ThemeName = "Office2016Black";

                this.radialGauge1.ShowBackgroundFrame = false;
                this.radialGauge1.ThemeName = "Office2016Black";
                this.radialGauge1.ScaleLabelColor = Color.White;
                this.radialGauge1.MajorTickMarkColor = Color.White;
                this.radialGauge1.MinorTickMarkColor = Color.White;
                this.radialGauge1.InterLinesColor = Color.White;
                this.radialGauge1.GaugeArcColor = Color.White;
                this.radialGauge1.NeedleColor = ColorTranslator.FromHtml("#00EFFF");

                this.linearGauge1.ThemeName = "Office2016Black";
                this.linearGauge1.ValueIndicatorColor = Color.Transparent;
                this.linearGauge1.OuterFrameGradientStartColor = Color.Transparent;
                this.linearGauge1.OuterFrameGradientEndColor = Color.Transparent;
                this.linearGauge1.ForeColor = Color.White;
                this.linearGauge1.ScaleColor = Color.White;
                this.linearGauge1.MajorTickMarkColor = Color.White;
                this.linearGauge1.MinorTickMarkColor = Color.White;
                this.linearGauge1.NeedleColor = ColorTranslator.FromHtml("#00EFFF");

                this.label1.ThemeName = "Office2016Black";
                this.label2.ThemeName = "Office2016Black";
                this.autoLabel1.ThemeName = "Office2016Black";

                this.sfComboBox1.ThemeName = "Office2016Black";
                this.sfComboBox2.ThemeName = "Office2016Black";

                this.checkBox1.ThemeName = "Office2016Black";
                this.checkBoxAdv1.ThemeName = "Office2016Black";
                this.checkBoxAdv2.ThemeName = "Office2016Black";
            }
            else if (this.sfComboBox1.SelectedItem.ToString() == "Office2019Colorful")
            {
                this.splitContainerAdv1.ThemeName = "Office2019Colorful";
                this.splitContainerAdv2.ThemeName = "Office2019Colorful";

                this.radialGauge1.ThemeName = "Office2019Colorful";
                this.linearGauge1.ThemeName = "Office2019Colorful";
                this.linearGauge1.ThemeStyle.ValueIndicatorColor = Color.Transparent;  
                
                this.sfComboBox1.ThemeName = "Office2019Colorful";
                this.sfComboBox2.ThemeName = "Office2019Colorful";

                this.checkBox1.ThemeName = "Office2019Colorful";
                this.checkBoxAdv1.ThemeName = "Office2019Colorful";
                this.checkBoxAdv2.ThemeName = "Office2019Colorful";

                this.label1.BackColor = Color.Transparent;
                this.label2.BackColor = Color.Transparent;
                this.autoLabel1.BackColor = Color.Transparent;

                this.BackColor = splitContainerAdv2.ThemeStyle.BackColor;
            }
            else if (this.sfComboBox1.SelectedItem.ToString() == "HighContrastBlack")
            {
                this.splitContainerAdv1.ThemeName = "HighContrastBlack";
                this.splitContainerAdv2.ThemeName = "HighContrastBlack";

                this.radialGauge1.ThemeName = "HighContrastBlack";

                this.linearGauge1.ThemeName = "HighContrastBlack";
                this.linearGauge1.ThemeStyle.ValueIndicatorColor = Color.Transparent;

                this.sfComboBox1.ThemeName = "HighContrastBlack";
                this.sfComboBox2.ThemeName = "HighContrastBlack";

                this.checkBox1.ThemeName = "HighContrastBlack";
                this.checkBoxAdv1.ThemeName = "HighContrastBlack";
                this.checkBoxAdv2.ThemeName = "HighContrastBlack";

                this.label1.BackColor = Color.Transparent;
                this.label2.BackColor = Color.Transparent;
                this.autoLabel1.BackColor = Color.Transparent;

                this.BackColor = splitContainerAdv2.ThemeStyle.BackColor;
            }
        }

        private void linearGauge1_ValueChanged(object sender, EventArgs e)
        {
            if (this.radialGauge1.Value != this.linearGauge1.Value)
                this.radialGauge1.Value = this.linearGauge1.Value;
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            this.splitContainerAdv1.IsSplitterFixed = !this.splitContainerAdv1.IsSplitterFixed;
            this.splitContainerAdv2.IsSplitterFixed = !this.splitContainerAdv2.IsSplitterFixed;
            if (this.checkBox1.Checked)
            {
                this.splitContainerAdv1.PanelToBeCollapsed = CollapsedPanel.None;
                this.splitContainerAdv2.PanelToBeCollapsed = CollapsedPanel.None;
            }
            else
            {
                this.splitContainerAdv1.PanelToBeCollapsed = CollapsedPanel.Panel2;
                this.splitContainerAdv2.PanelToBeCollapsed = CollapsedPanel.Panel2;
            }
        }

        private void sfComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.sfComboBox2.SelectedIndex == 0)
            {
                this.splitContainerAdv1.TogglePanelOn = TogglePanelOn.Click;
            }
            else if (this.sfComboBox2.SelectedIndex == 1)
            {
                this.splitContainerAdv1.TogglePanelOn = TogglePanelOn.DoubleClick;
            }
        }

        private void checkBoxAdv2_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.checkBoxAdv2.Checked)
            {
                this.splitContainerAdv1.Panel2Collapsed = true;
                this.checkBoxAdv1.Checked = false;
            }
            else
                this.splitContainerAdv1.Panel2Collapsed = false;
            
        }

        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.checkBoxAdv1.Checked)
            {
                this.splitContainerAdv1.Panel1Collapsed = true;
                this.checkBoxAdv2.Checked = false;
            }
            else
                this.splitContainerAdv1.Panel1Collapsed = false;
        }

        private void radialGauge1_ValueChanged(object sender, EventArgs e)
        {
            if (this.linearGauge1.Value != this.radialGauge1.Value)
                this.linearGauge1.Value = this.radialGauge1.Value;
        }

        #endregion

    }

    /// <summary>
    /// Represents a class that is used to find the licensing file for Syncfusion controls.
    /// </summary>
    public class DemoCommon
    {

        /// <summary>
        /// Finds the license key from the Common folder.
        /// </summary>
        /// <returns>Returns the license key.</returns>
        public static string FindLicenseKey()
        {
            string licenseKeyFile = "..\\Common\\SyncfusionLicense.txt";
            for (int n = 0; n < 20; n++)
            {
                if (!System.IO.File.Exists(licenseKeyFile))
                {
                    licenseKeyFile = @"..\" + licenseKeyFile;
                    continue;
                }
                return File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }

}
