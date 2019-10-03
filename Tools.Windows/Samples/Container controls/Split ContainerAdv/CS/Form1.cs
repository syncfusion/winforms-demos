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
    public class Form1 : SfForm
    {
        #region Variables

        private Syncfusion.Windows.Forms.Tools.SplitContainerAdv splitContainerAdv1;
        private ToolTip toolTip1;
        private ImageList imageList1;
        private AutoLabel label3;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge1;
        private Syncfusion.Windows.Forms.Gauge.LinearGauge linearGauge1;
        private CheckBoxAdv checkBox1;
        private AutoLabel label1;
        private SfComboBox sfComboBox1;
        private AutoLabel label2;
        private SfComboBox sfComboBox2;
        private Syncfusion.Windows.Forms.Tools.SplitContainerAdv splitContainerAdv2;
        private CheckBoxAdv checkBoxAdv2;
        private CheckBoxAdv checkBoxAdv1;
        private AutoLabel autoLabel1;
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

            style.Add("Office2016Colorful");
            style.Add("Office2016White");
            style.Add("Office2016DarkGray");
            style.Add("Office2016Black");

            this.sfComboBox1.DataSource = style;

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
            Syncfusion.Windows.Forms.Gauge.LinearRange linearRange5 = new Syncfusion.Windows.Forms.Gauge.LinearRange();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.radialGauge1 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.linearGauge1 = new Syncfusion.Windows.Forms.Gauge.LinearGauge();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.label2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.sfComboBox2 = new SfComboBox();
            this.label1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.sfComboBox1 = new SfComboBox();
            this.checkBox1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.splitContainerAdv2 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
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
            this.splitContainerAdv1.Size = new System.Drawing.Size(598, 573);
            this.splitContainerAdv1.SplitterDistance = 275;
            this.splitContainerAdv1.SplitterWidth = 13;
            this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016Colorful;
            this.splitContainerAdv1.TabIndex = 0;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            // 
            // radialGauge1
            // 
            this.radialGauge1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radialGauge1.EnableCustomNeedles = false;
            this.radialGauge1.FrameType = Syncfusion.Windows.Forms.Gauge.FrameType.HalfCircle;
            this.radialGauge1.GaugeArcColor = System.Drawing.Color.Black;
            this.radialGauge1.GaugeLabel = "Gauge";
            this.radialGauge1.GaugeLableFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge1.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge1.InterLinesColor = System.Drawing.Color.Black;
            this.radialGauge1.LabelPlacement = Syncfusion.Windows.Forms.Gauge.LabelPlacement.Outside;
            this.radialGauge1.Location = new System.Drawing.Point(140, 25);
            this.radialGauge1.MajorDifference = 10F;
            this.radialGauge1.MajorTickMarkColor = System.Drawing.Color.Black;
            this.radialGauge1.MaximumValue = 100F;
            this.radialGauge1.MinimumSize = new System.Drawing.Size(130, 52);
            this.radialGauge1.MinorDifference = 3F;
            this.radialGauge1.MinorTickMarkColor = System.Drawing.Color.Black;
            this.radialGauge1.Name = "radialGauge1";
            this.radialGauge1.NeedleColor = System.Drawing.Color.Black;
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
            this.radialGauge1.Size = new System.Drawing.Size(316, 210);
            this.radialGauge1.StartAngle = 180;
            this.radialGauge1.SweepAngle = 180;
            this.radialGauge1.TabIndex = 1;
            this.radialGauge1.ValueChanged += new System.EventHandler(this.radialGauge1_ValueChanged);
            // 
            // linearGauge1
            // 
            this.linearGauge1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linearGauge1.ForeColor = System.Drawing.Color.Gray;
            this.linearGauge1.GaugelabelFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linearGauge1.LinearFrameType = Syncfusion.Windows.Forms.Gauge.LinearFrameType.Horizontal;
            this.linearGauge1.Location = new System.Drawing.Point(141, 81);
            this.linearGauge1.MajorTicksHeight = 15;
            this.linearGauge1.MaximumValue = 100F;
            this.linearGauge1.MinimumSize = new System.Drawing.Size(100, 50);
            this.linearGauge1.MinorTickCount = 5;
            this.linearGauge1.MinorTickHeight = 10;
            this.linearGauge1.Name = "linearGauge1";
            this.linearGauge1.PointerPlacement = Syncfusion.Windows.Forms.Gauge.Placement.Center;
            linearRange1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            linearRange1.EndValue = 67F;
            linearRange1.Height = 5;
            linearRange1.InRange = false;
            linearRange1.Name = "GaugeRange1";
            linearRange1.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            linearRange1.StartValue = 45F;
            linearRange2.Color = System.Drawing.Color.Red;
            linearRange2.EndValue = 15F;
            linearRange2.Height = 5;
            linearRange2.InRange = false;
            linearRange2.Name = "GaugeRange2";
            linearRange2.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            linearRange2.StartValue = 5F;
            linearRange3.Color = System.Drawing.Color.Yellow;
            linearRange3.EndValue = 38F;
            linearRange3.Height = 5;
            linearRange3.InRange = false;
            linearRange3.Name = "GaugeRange3";
            linearRange3.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            linearRange3.StartValue = 23F;
            linearRange4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            linearRange4.EndValue = 0F;
            linearRange4.Height = 5;
            linearRange4.InRange = false;
            linearRange4.Name = "GaugeRange4";
            linearRange4.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            linearRange4.StartValue = 0F;
            linearRange5.Color = System.Drawing.Color.Blue;
            linearRange5.EndValue = 100F;
            linearRange5.Height = 5;
            linearRange5.InRange = false;
            linearRange5.Name = "GaugeRange5";
            linearRange5.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            linearRange5.StartValue = 80F;
            this.linearGauge1.Ranges.Add(linearRange1);
            this.linearGauge1.Ranges.Add(linearRange2);
            this.linearGauge1.Ranges.Add(linearRange3);
            this.linearGauge1.Ranges.Add(linearRange4);
            this.linearGauge1.Ranges.Add(linearRange5);
            this.linearGauge1.ReadOnly = false;
            this.linearGauge1.ScaleColor = System.Drawing.Color.Gray;
            this.linearGauge1.Size = new System.Drawing.Size(316, 125);
            this.linearGauge1.TabIndex = 1;
            this.linearGauge1.Text = "linearGauge1";
            this.linearGauge1.Value = 40F;
            this.linearGauge1.ValueIndicatorColor = System.Drawing.Color.Gray;
            this.linearGauge1.ValueChanged += new System.EventHandler(this.linearGauge1_ValueChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            // 
            // label3
            // 
            this.label3.AutoSize = false;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(861, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "This sample showcases the collapsible features and different styles of the SplitContainerAdv control.";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Toggle Panel On";
            // 
            // comboBoxAdv1
            // 
            this.sfComboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sfComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           
            this.sfComboBox2.Location = new System.Drawing.Point(30, 248);
            this.sfComboBox2.Name = "comboBoxAdv1";
            this.sfComboBox2.Size = new System.Drawing.Size(167, 28);
            this.sfComboBox2.TabIndex = 3;
            this.sfComboBox2.SelectedIndexChanged += new System.EventHandler(this.sfComboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Style";
            // 
            // comboBox1
            // 
            this.sfComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sfComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfComboBox1.Location = new System.Drawing.Point(30, 155);
            this.sfComboBox1.Name = "comboBox1";
            this.sfComboBox1.Size = new System.Drawing.Size(167, 28);
            this.sfComboBox1.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.checkBox1.BeforeTouchSize = new System.Drawing.Size(122, 23);
            this.checkBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.checkBox1.DrawFocusRectangle = false;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.checkBox1.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.checkBox1.Location = new System.Drawing.Point(27, 314);
            this.checkBox1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(122, 23);
            this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Freeze panes";
            this.checkBox1.ThemesEnabled = false;
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
            this.splitContainerAdv2.Location = new System.Drawing.Point(10, 35);
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
            this.splitContainerAdv2.Panel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            this.splitContainerAdv2.Panel2.Controls.Add(this.autoLabel1);
            this.splitContainerAdv2.Panel2.Controls.Add(this.checkBoxAdv2);
            this.splitContainerAdv2.Panel2.Controls.Add(this.checkBoxAdv1);
            this.splitContainerAdv2.Panel2.Controls.Add(this.label2);
            this.splitContainerAdv2.Panel2.Controls.Add(this.checkBox1);
            this.splitContainerAdv2.Panel2.Controls.Add(this.sfComboBox2);
            this.splitContainerAdv2.Panel2.Controls.Add(this.sfComboBox1);
            this.splitContainerAdv2.Panel2.Controls.Add(this.label1);
            this.splitContainerAdv2.PanelToBeCollapsed = Syncfusion.Windows.Forms.Tools.Enums.CollapsedPanel.Panel1;
            this.splitContainerAdv2.Size = new System.Drawing.Size(861, 575);
            this.splitContainerAdv2.SplitterDistance = 600;
            this.splitContainerAdv2.SplitterWidth = 13;
            this.splitContainerAdv2.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016Colorful;
            this.splitContainerAdv2.TabIndex = 2;
            this.splitContainerAdv2.Text = "splitContainerAdv2";
            // 
            // autoLabel1
            // 
            this.autoLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.autoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.Location = new System.Drawing.Point(30, 70);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(91, 20);
            this.autoLabel1.TabIndex = 7;
            this.autoLabel1.Text = "Properties";
            // 
            // checkBoxAdv2
            // 
            this.checkBoxAdv2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxAdv2.AutoSize = true;
            this.checkBoxAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.checkBoxAdv2.BeforeTouchSize = new System.Drawing.Size(182, 23);
            this.checkBoxAdv2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.checkBoxAdv2.DrawFocusRectangle = false;
            this.checkBoxAdv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.checkBoxAdv2.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.checkBoxAdv2.Location = new System.Drawing.Point(27, 422);
            this.checkBoxAdv2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.checkBoxAdv2.Name = "checkBoxAdv2";
            this.checkBoxAdv2.Size = new System.Drawing.Size(182, 23);
            this.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.checkBoxAdv2.TabIndex = 6;
            this.checkBoxAdv2.Text = "Collapse LinearGauge";
            this.checkBoxAdv2.ThemesEnabled = false;
            this.checkBoxAdv2.CheckStateChanged += new System.EventHandler(this.checkBoxAdv2_CheckStateChanged);
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxAdv1.AutoSize = true;
            this.checkBoxAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.checkBoxAdv1.BeforeTouchSize = new System.Drawing.Size(183, 23);
            this.checkBoxAdv1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.checkBoxAdv1.DrawFocusRectangle = false;
            this.checkBoxAdv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.checkBoxAdv1.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.checkBoxAdv1.Location = new System.Drawing.Point(27, 369);
            this.checkBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(183, 23);
            this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.checkBoxAdv1.TabIndex = 5;
            this.checkBoxAdv1.Text = "Collapse RadialGauge";
            this.checkBoxAdv1.ThemesEnabled = false;
            this.checkBoxAdv1.CheckStateChanged += new System.EventHandler(this.checkBoxAdv1_CheckStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 620);
            this.Controls.Add(this.splitContainerAdv2);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(893, 662);
            this.MinimumSize = new System.Drawing.Size(893, 662);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
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
            Application.Run(new Form1());
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.sfComboBox1.Padding = new Padding(10);
        }

        #region Events 

        void SfComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.sfComboBox1.SelectedItem.ToString() == "Office2016Colorful")
            {
                this.BackColor = Color.White;
                this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016Colorful;
                this.splitContainerAdv2.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016Colorful;
                this.radialGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Office2016Colorful;
                this.linearGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Office2016Colorful;
                SkinManager.SetVisualStyle(this.splitContainerAdv2.Panel2, VisualTheme.Office2016Colorful);
                this.label3.Style = AutoLabelStyle.Office2016Colorful;
                this.label1.Style = AutoLabelStyle.Office2016Colorful;
                this.label2.Style = AutoLabelStyle.Office2016Colorful;
                this.autoLabel1.Style = AutoLabelStyle.Office2016Colorful;
                this.sfComboBox1.ThemeName = "Office2016Colorful";
                this.sfComboBox2.ThemeName = "Office2016Colorful";
                this.sfComboBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.sfComboBox2.BackColor = ColorTranslator.FromHtml("#ffffff");
                
            }
            else if (this.sfComboBox1.SelectedItem.ToString() == "Office2016DarkGray")
            {
                this.BackColor = ColorTranslator.FromHtml("#727272");
                this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016DarkGray;
                this.splitContainerAdv2.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016DarkGray;
                this.radialGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Office2016DarkGray;
                this.linearGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Office2016DarkGray;
                SkinManager.SetVisualStyle(this.splitContainerAdv2.Panel2, VisualTheme.Office2016DarkGray);
                this.label3.Style = AutoLabelStyle.Office2016DarkGray;
                this.checkBox1.BackColor = Color.Transparent;
                this.checkBoxAdv1.BackColor = Color.Transparent;
                this.checkBoxAdv2.BackColor = Color.Transparent;
                this.autoLabel1.BackColor = Color.Transparent;
                this.label2.BackColor = Color.Transparent;
                this.label1.BackColor = Color.Transparent;
                this.label3.BackColor = Color.Transparent;
                this.sfComboBox1.ThemeName = "Office2016DarkGray";
                this.sfComboBox2.ThemeName = "Office2016DarkGray";
                this.sfComboBox1.BackColor = ColorTranslator.FromHtml("#727272");
                this.sfComboBox2.BackColor = ColorTranslator.FromHtml("#727272");
            }
            else if (this.sfComboBox1.SelectedItem.ToString() == "Office2016White")
            {
                this.BackColor = Color.White;
                this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016White;
                this.splitContainerAdv2.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016White;
                this.radialGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Office2016White;
                this.linearGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Office2016White;
                SkinManager.SetVisualStyle(this.splitContainerAdv2.Panel2, VisualTheme.Office2016White);
                this.label3.Style = AutoLabelStyle.Office2016White;
                this.sfComboBox1.ThemeName = "Office2016White";
                this.sfComboBox2.ThemeName = "Office2016White";
                this.sfComboBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.sfComboBox2.BackColor = ColorTranslator.FromHtml("#ffffff");
            }
            else if (this.sfComboBox1.SelectedItem.ToString() == "Office2016Black")
            {
                this.BackColor = ColorTranslator.FromHtml("#262626");
                this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016Black;
                this.splitContainerAdv2.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016Black;
                this.radialGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Office2016Black;
                this.linearGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Office2016Black;
                SkinManager.SetVisualStyle(this.splitContainerAdv2.Panel2, VisualTheme.Office2016Black);
                this.label3.Style = AutoLabelStyle.Office2016Black;
                this.sfComboBox1.ThemeName = "Office2016Black";
                this.sfComboBox2.ThemeName = "Office2016Black";
                this.sfComboBox1.BackColor = ColorTranslator.FromHtml("#262626");
                this.sfComboBox2.BackColor = ColorTranslator.FromHtml("#262626");
                
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
