#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Drawing;

namespace BorderLayout_Example
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
            Syncfusion.Windows.Forms.Gauge.Range range1 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range2 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range3 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range4 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries1 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo1 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartLineInfo chartLineInfo1 = new Syncfusion.Windows.Forms.Chart.ChartLineInfo();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries2 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo2 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem chartToolBarSaveItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem chartToolBarCopyItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem chartToolBarPrintItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem chartToolBarPrintPreviewItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3DItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelCentre = new System.Windows.Forms.Panel();
            this.reverseTriangle2 = new BorderLayout_Example.ReverseTriangle();
            this.triangle1 = new BorderLayout_Example.Triangle();
            this.autoLblcountryvalue = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabelcountry = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabelcountryname = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.panelEast = new System.Windows.Forms.Panel();
            this.triangle2 = new BorderLayout_Example.Triangle();
            this.reverseTriangle1 = new BorderLayout_Example.ReverseTriangle();
            this.autoLblmonthvalue = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabelmonthname = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabelMonth = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.panelWest = new System.Windows.Forms.Panel();
            this.autoLabelproduct = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabelproductName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.panelGauge = new System.Windows.Forms.Panel();
            this.smartphonepanel = new System.Windows.Forms.Panel();
            this.lblSmartphone = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.radialGauge3 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.tabletpanel = new System.Windows.Forms.Panel();
            this.lbltablet = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.radialGauge4 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.desktoppanel = new System.Windows.Forms.Panel();
            this.lbldesktop = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.radialGauge2 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.laptoppanel = new System.Windows.Forms.Panel();
            this.lbllaptop = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.radialGauge1 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.panelChart = new System.Windows.Forms.Panel();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.label5 = new System.Windows.Forms.Label();
            this.borderLayout1 = new Syncfusion.Windows.Forms.Tools.BorderLayout(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMain.SuspendLayout();
            this.panelCentre.SuspendLayout();
            this.panelEast.SuspendLayout();
            this.panelWest.SuspendLayout();
            this.panelGauge.SuspendLayout();
            this.smartphonepanel.SuspendLayout();
            this.tabletpanel.SuspendLayout();
            this.desktoppanel.SuspendLayout();
            this.laptoppanel.SuspendLayout();
            this.panelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borderLayout1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMain.Controls.Add(this.panelCentre);
            this.panelMain.Controls.Add(this.panelEast);
            this.panelMain.Controls.Add(this.panelWest);
            this.panelMain.Controls.Add(this.panelGauge);
            this.panelMain.Controls.Add(this.panelChart);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(2, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1712, 730);
            this.panelMain.TabIndex = 0;
            // 
            // panelCentre
            // 
            this.panelCentre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelCentre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCentre.Controls.Add(this.reverseTriangle2);
            this.panelCentre.Controls.Add(this.triangle1);
            this.panelCentre.Controls.Add(this.autoLblcountryvalue);
            this.panelCentre.Controls.Add(this.autoLabelcountry);
            this.panelCentre.Controls.Add(this.autoLabelcountryname);
            this.panelCentre.Location = new System.Drawing.Point(524, 427);
            this.borderLayout1.SetMinimumSize(this.panelCentre, new System.Drawing.Size(601, 279));
            this.panelCentre.Name = "panelCentre";
            this.borderLayout1.SetPosition(this.panelCentre, Syncfusion.Windows.Forms.Tools.BorderPosition.Center);
            this.borderLayout1.SetPreferredSize(this.panelCentre, new System.Drawing.Size(200, 100));
            this.panelCentre.Size = new System.Drawing.Size(560, 112);
            this.panelCentre.TabIndex = 4;
            // 
            // reverseTriangle2
            // 
            this.reverseTriangle2.Location = new System.Drawing.Point(88, 145);
            this.reverseTriangle2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.reverseTriangle2.Name = "reverseTriangle2";
            this.reverseTriangle2.Size = new System.Drawing.Size(28, 25);
            this.reverseTriangle2.TabIndex = 4;
            this.reverseTriangle2.Visible = false;
            // 
            // triangle1
            // 
            this.triangle1.AutoSize = true;
            this.triangle1.Location = new System.Drawing.Point(129, 143);
            this.triangle1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.triangle1.Name = "triangle1";
            this.triangle1.Size = new System.Drawing.Size(36, 26);
            this.triangle1.TabIndex = 3;
            this.triangle1.Visible = false;
            // 
            // autoLblcountryvalue
            // 
            this.autoLblcountryvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLblcountryvalue.ForeColor = System.Drawing.Color.Green;
            this.autoLblcountryvalue.Location = new System.Drawing.Point(171, 143);
            this.autoLblcountryvalue.Name = "autoLblcountryvalue";
            this.autoLblcountryvalue.Size = new System.Drawing.Size(187, 32);
            this.autoLblcountryvalue.TabIndex = 2;
            this.autoLblcountryvalue.Text = "$220 ( 15% )";
            // 
            // autoLabelcountry
            // 
            this.autoLabelcountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabelcountry.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.autoLabelcountry.Location = new System.Drawing.Point(18, 22);
            this.autoLabelcountry.Name = "autoLabelcountry";
            this.autoLabelcountry.Size = new System.Drawing.Size(219, 26);
            this.autoLabelcountry.TabIndex = 1;
            this.autoLabelcountry.Text = "Product Vs Country";
            // 
            // autoLabelcountryname
            // 
            this.autoLabelcountryname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabelcountryname.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.autoLabelcountryname.Location = new System.Drawing.Point(21, 71);
            this.autoLabelcountryname.Name = "autoLabelcountryname";
            this.autoLabelcountryname.Size = new System.Drawing.Size(88, 25);
            this.autoLabelcountryname.TabIndex = 0;
            this.autoLabelcountryname.Text = "Country";
            // 
            // panelEast
            // 
            this.panelEast.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelEast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEast.Controls.Add(this.triangle2);
            this.panelEast.Controls.Add(this.reverseTriangle1);
            this.panelEast.Controls.Add(this.autoLblmonthvalue);
            this.panelEast.Controls.Add(this.autoLabelmonthname);
            this.panelEast.Controls.Add(this.autoLabelMonth);
            this.panelEast.Location = new System.Drawing.Point(1104, 427);
            this.borderLayout1.SetMinimumSize(this.panelEast, new System.Drawing.Size(499, 279));
            this.panelEast.Name = "panelEast";
            this.borderLayout1.SetPosition(this.panelEast, Syncfusion.Windows.Forms.Tools.BorderPosition.East);
            this.borderLayout1.SetPreferredSize(this.panelEast, new System.Drawing.Size(588, 100));
            this.panelEast.Size = new System.Drawing.Size(588, 112);
            this.panelEast.TabIndex = 3;
            // 
            // triangle2
            // 
            this.triangle2.Location = new System.Drawing.Point(40, 143);
            this.triangle2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.triangle2.Name = "triangle2";
            this.triangle2.Size = new System.Drawing.Size(33, 31);
            this.triangle2.TabIndex = 5;
            this.triangle2.Visible = false;
            // 
            // reverseTriangle1
            // 
            this.reverseTriangle1.Location = new System.Drawing.Point(86, 145);
            this.reverseTriangle1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.reverseTriangle1.Name = "reverseTriangle1";
            this.reverseTriangle1.Size = new System.Drawing.Size(24, 22);
            this.reverseTriangle1.TabIndex = 4;
            this.reverseTriangle1.Visible = false;
            // 
            // autoLblmonthvalue
            // 
            this.autoLblmonthvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLblmonthvalue.ForeColor = System.Drawing.Color.Green;
            this.autoLblmonthvalue.Location = new System.Drawing.Point(135, 145);
            this.autoLblmonthvalue.Name = "autoLblmonthvalue";
            this.autoLblmonthvalue.Size = new System.Drawing.Size(187, 32);
            this.autoLblmonthvalue.TabIndex = 2;
            this.autoLblmonthvalue.Text = "$126 ( 20% )";
            // 
            // autoLabelmonthname
            // 
            this.autoLabelmonthname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabelmonthname.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.autoLabelmonthname.Location = new System.Drawing.Point(22, 71);
            this.autoLabelmonthname.Name = "autoLabelmonthname";
            this.autoLabelmonthname.Size = new System.Drawing.Size(72, 25);
            this.autoLabelmonthname.TabIndex = 1;
            this.autoLabelmonthname.Text = "Month";
            // 
            // autoLabelMonth
            // 
            this.autoLabelMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabelMonth.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.autoLabelMonth.Location = new System.Drawing.Point(22, 22);
            this.autoLabelMonth.Name = "autoLabelMonth";
            this.autoLabelMonth.Size = new System.Drawing.Size(201, 26);
            this.autoLabelMonth.TabIndex = 0;
            this.autoLabelMonth.Text = "Product Vs Month";
            // 
            // panelWest
            // 
            this.panelWest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelWest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWest.Controls.Add(this.autoLabelproduct);
            this.panelWest.Controls.Add(this.autoLabelproductName);
            this.panelWest.Location = new System.Drawing.Point(20, 427);
            this.borderLayout1.SetMinimumSize(this.panelWest, new System.Drawing.Size(484, 279));
            this.panelWest.Name = "panelWest";
            this.borderLayout1.SetPosition(this.panelWest, Syncfusion.Windows.Forms.Tools.BorderPosition.West);
            this.borderLayout1.SetPreferredSize(this.panelWest, new System.Drawing.Size(484, 100));
            this.panelWest.Size = new System.Drawing.Size(484, 112);
            this.panelWest.TabIndex = 2;
            // 
            // autoLabelproduct
            // 
            this.autoLabelproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabelproduct.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.autoLabelproduct.Location = new System.Drawing.Point(27, 85);
            this.autoLabelproduct.Name = "autoLabelproduct";
            this.autoLabelproduct.Size = new System.Drawing.Size(86, 25);
            this.autoLabelproduct.TabIndex = 1;
            this.autoLabelproduct.Text = "Product";
            // 
            // autoLabelproductName
            // 
            this.autoLabelproductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabelproductName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.autoLabelproductName.Location = new System.Drawing.Point(27, 22);
            this.autoLabelproductName.Name = "autoLabelproductName";
            this.autoLabelproductName.Size = new System.Drawing.Size(164, 26);
            this.autoLabelproductName.TabIndex = 0;
            this.autoLabelproductName.Text = "Product Name";
            // 
            // panelGauge
            // 
            this.panelGauge.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelGauge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGauge.Controls.Add(this.smartphonepanel);
            this.panelGauge.Controls.Add(this.tabletpanel);
            this.panelGauge.Controls.Add(this.desktoppanel);
            this.panelGauge.Controls.Add(this.laptoppanel);
            this.panelGauge.Location = new System.Drawing.Point(20, 559);
            this.panelGauge.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.borderLayout1.SetMinimumSize(this.panelGauge, new System.Drawing.Size(1584, 284));
            this.panelGauge.Name = "panelGauge";
            this.borderLayout1.SetPosition(this.panelGauge, Syncfusion.Windows.Forms.Tools.BorderPosition.South);
            this.borderLayout1.SetPreferredSize(this.panelGauge, new System.Drawing.Size(200, 151));
            this.panelGauge.Size = new System.Drawing.Size(1672, 151);
            this.panelGauge.TabIndex = 1;
            // 
            // smartphonepanel
            // 
            this.smartphonepanel.BackColor = System.Drawing.Color.White;
            this.smartphonepanel.Controls.Add(this.lblSmartphone);
            this.smartphonepanel.Controls.Add(this.radialGauge3);
            this.smartphonepanel.Location = new System.Drawing.Point(1226, 8);
            this.smartphonepanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.smartphonepanel.Name = "smartphonepanel";
            this.smartphonepanel.Size = new System.Drawing.Size(380, 269);
            this.smartphonepanel.TabIndex = 39;
            // 
            // lblSmartphone
            // 
            this.lblSmartphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmartphone.ForeColor = System.Drawing.Color.Navy;
            this.lblSmartphone.Location = new System.Drawing.Point(128, 237);
            this.lblSmartphone.Name = "lblSmartphone";
            this.lblSmartphone.Size = new System.Drawing.Size(121, 25);
            this.lblSmartphone.TabIndex = 7;
            this.lblSmartphone.Text = "SmartPhone";
            // 
            // radialGauge3
            // 
            this.radialGauge3.BackgroundGradientEndColor = System.Drawing.Color.White;
            this.radialGauge3.BackgroundGradientStartColor = System.Drawing.Color.White;
            this.radialGauge3.EnableCustomNeedles = false;
            this.radialGauge3.FrameType = Syncfusion.Windows.Forms.Gauge.FrameType.HalfCircle;
            this.radialGauge3.GaugeArcColor = System.Drawing.Color.Transparent;
            this.radialGauge3.GaugeLabel = "";
            this.radialGauge3.GaugeLableFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge3.GaugeValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(164)))));
            this.radialGauge3.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge3.InnerFrameGradientEndColor = System.Drawing.Color.White;
            this.radialGauge3.InnerFrameGradientStartColor = System.Drawing.Color.White;
            this.radialGauge3.InterLinesColor = System.Drawing.Color.WhiteSmoke;
            this.radialGauge3.Location = new System.Drawing.Point(-10, -25);
            this.radialGauge3.MajorDifference = 40F;
            this.radialGauge3.MajorTickMarkColor = System.Drawing.Color.White;
            this.radialGauge3.MajorTickMarkHeight = 0;
            this.radialGauge3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radialGauge3.MinimumSize = new System.Drawing.Size(130, 52);
            this.radialGauge3.MinorInnerLinesHeight = 0;
            this.radialGauge3.MinorTickMarkColor = System.Drawing.Color.Navy;
            this.radialGauge3.MinorTickMarkHeight = 0;
            this.radialGauge3.Name = "radialGauge3";
            this.radialGauge3.NeedleColor = System.Drawing.Color.Navy;
            this.radialGauge3.OuterFrameGradientEndColor = System.Drawing.Color.White;
            this.radialGauge3.OuterFrameGradientStartColor = System.Drawing.Color.White;
            range1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(112)))), ((int)(((byte)(248)))));
            range1.EndValue = 120F;
            range1.Height = 5;
            range1.InRange = true;
            range1.Name = "GaugeRange1";
            range1.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            range1.StartValue = 0F;
            this.radialGauge3.Ranges.Add(range1);
            this.radialGauge3.ScaleLabelColor = System.Drawing.Color.Navy;
            this.radialGauge3.Size = new System.Drawing.Size(382, 254);
            this.radialGauge3.StartAngle = 180;
            this.radialGauge3.SweepAngle = 180;
            this.radialGauge3.TabIndex = 6;
            this.radialGauge3.Value = 78.2F;
            // 
            // tabletpanel
            // 
            this.tabletpanel.BackColor = System.Drawing.Color.White;
            this.tabletpanel.Controls.Add(this.lbltablet);
            this.tabletpanel.Controls.Add(this.radialGauge4);
            this.tabletpanel.Location = new System.Drawing.Point(810, 6);
            this.tabletpanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabletpanel.Name = "tabletpanel";
            this.tabletpanel.Size = new System.Drawing.Size(394, 271);
            this.tabletpanel.TabIndex = 37;
            // 
            // lbltablet
            // 
            this.lbltablet.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbltablet.ForeColor = System.Drawing.Color.Navy;
            this.lbltablet.Location = new System.Drawing.Point(178, 238);
            this.lbltablet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltablet.Name = "lbltablet";
            this.lbltablet.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.lbltablet.Size = new System.Drawing.Size(71, 30);
            this.lbltablet.TabIndex = 8;
            this.lbltablet.Text = "Tablet";
            this.lbltablet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbltablet.Click += new System.EventHandler(this.lbltablet_Click);
            // 
            // radialGauge4
            // 
            this.radialGauge4.BackgroundGradientEndColor = System.Drawing.Color.White;
            this.radialGauge4.BackgroundGradientStartColor = System.Drawing.Color.White;
            this.radialGauge4.EnableCustomNeedles = false;
            this.radialGauge4.FrameType = Syncfusion.Windows.Forms.Gauge.FrameType.HalfCircle;
            this.radialGauge4.GaugeArcColor = System.Drawing.Color.Transparent;
            this.radialGauge4.GaugeLabel = "";
            this.radialGauge4.GaugeLableColor = System.Drawing.Color.Navy;
            this.radialGauge4.GaugeLableFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge4.GaugeValueColor = System.Drawing.Color.Green;
            this.radialGauge4.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge4.InnerFrameGradientEndColor = System.Drawing.Color.White;
            this.radialGauge4.InnerFrameGradientStartColor = System.Drawing.Color.White;
            this.radialGauge4.InterLinesColor = System.Drawing.Color.Navy;
            this.radialGauge4.Location = new System.Drawing.Point(10, -25);
            this.radialGauge4.MajorDifference = 40F;
            this.radialGauge4.MajorTickMarkColor = System.Drawing.Color.Navy;
            this.radialGauge4.MajorTickMarkHeight = 0;
            this.radialGauge4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radialGauge4.MinimumSize = new System.Drawing.Size(130, 52);
            this.radialGauge4.MinorInnerLinesHeight = 0;
            this.radialGauge4.MinorTickMarkColor = System.Drawing.Color.Navy;
            this.radialGauge4.MinorTickMarkHeight = 0;
            this.radialGauge4.Name = "radialGauge4";
            this.radialGauge4.NeedleColor = System.Drawing.Color.Navy;
            this.radialGauge4.OuterFrameGradientEndColor = System.Drawing.Color.White;
            this.radialGauge4.OuterFrameGradientStartColor = System.Drawing.Color.White;
            range2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(186)))), ((int)(((byte)(248)))));
            range2.EndValue = 120F;
            range2.Height = 5;
            range2.InRange = true;
            range2.Name = "GaugeRange1";
            range2.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            range2.StartValue = 0F;
            this.radialGauge4.Ranges.Add(range2);
            this.radialGauge4.ScaleLabelColor = System.Drawing.Color.Navy;
            this.radialGauge4.Size = new System.Drawing.Size(382, 254);
            this.radialGauge4.StartAngle = 180;
            this.radialGauge4.SweepAngle = 180;
            this.radialGauge4.TabIndex = 4;
            this.radialGauge4.Value = 77.9F;
            // 
            // desktoppanel
            // 
            this.desktoppanel.BackColor = System.Drawing.Color.White;
            this.desktoppanel.Controls.Add(this.lbldesktop);
            this.desktoppanel.Controls.Add(this.radialGauge2);
            this.desktoppanel.Location = new System.Drawing.Point(410, 8);
            this.desktoppanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.desktoppanel.Name = "desktoppanel";
            this.desktoppanel.Size = new System.Drawing.Size(394, 269);
            this.desktoppanel.TabIndex = 36;
            // 
            // lbldesktop
            // 
            this.lbldesktop.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesktop.ForeColor = System.Drawing.Color.Navy;
            this.lbldesktop.Location = new System.Drawing.Point(164, 237);
            this.lbldesktop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldesktop.Name = "lbldesktop";
            this.lbldesktop.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.lbldesktop.Size = new System.Drawing.Size(93, 30);
            this.lbldesktop.TabIndex = 7;
            this.lbldesktop.Text = "Desktop";
            this.lbldesktop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radialGauge2
            // 
            this.radialGauge2.BackgroundGradientEndColor = System.Drawing.Color.White;
            this.radialGauge2.BackgroundGradientStartColor = System.Drawing.Color.White;
            this.radialGauge2.EnableCustomNeedles = false;
            this.radialGauge2.ForeColor = System.Drawing.Color.Navy;
            this.radialGauge2.FrameType = Syncfusion.Windows.Forms.Gauge.FrameType.HalfCircle;
            this.radialGauge2.GaugeArcColor = System.Drawing.Color.Transparent;
            this.radialGauge2.GaugeLabel = "";
            this.radialGauge2.GaugeLableColor = System.Drawing.Color.Navy;
            this.radialGauge2.GaugeLableFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge2.GaugeValueColor = System.Drawing.Color.Maroon;
            this.radialGauge2.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge2.InnerFrameGradientEndColor = System.Drawing.Color.White;
            this.radialGauge2.InnerFrameGradientStartColor = System.Drawing.Color.White;
            this.radialGauge2.InterLinesColor = System.Drawing.Color.Navy;
            this.radialGauge2.Location = new System.Drawing.Point(10, -25);
            this.radialGauge2.MajorDifference = 40F;
            this.radialGauge2.MajorTickMarkColor = System.Drawing.Color.Transparent;
            this.radialGauge2.MajorTickMarkHeight = 0;
            this.radialGauge2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radialGauge2.MinimumSize = new System.Drawing.Size(130, 52);
            this.radialGauge2.MinorInnerLinesHeight = 0;
            this.radialGauge2.MinorTickMarkColor = System.Drawing.Color.Navy;
            this.radialGauge2.MinorTickMarkHeight = 0;
            this.radialGauge2.Name = "radialGauge2";
            this.radialGauge2.NeedleColor = System.Drawing.Color.Navy;
            this.radialGauge2.OuterFrameGradientEndColor = System.Drawing.Color.White;
            this.radialGauge2.OuterFrameGradientStartColor = System.Drawing.Color.White;
            range3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(199)))), ((int)(((byte)(128)))));
            range3.EndValue = 120F;
            range3.Height = 5;
            range3.InRange = true;
            range3.Name = "GaugeRange1";
            range3.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            range3.StartValue = 0F;
            this.radialGauge2.Ranges.Add(range3);
            this.radialGauge2.ScaleLabelColor = System.Drawing.Color.Navy;
            this.radialGauge2.Size = new System.Drawing.Size(380, 252);
            this.radialGauge2.StartAngle = 180;
            this.radialGauge2.SweepAngle = 180;
            this.radialGauge2.TabIndex = 2;
            this.radialGauge2.Value = 60.2F;
            // 
            // laptoppanel
            // 
            this.laptoppanel.BackColor = System.Drawing.Color.White;
            this.laptoppanel.Controls.Add(this.lbllaptop);
            this.laptoppanel.Controls.Add(this.radialGauge1);
            this.laptoppanel.Location = new System.Drawing.Point(16, 8);
            this.laptoppanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.laptoppanel.Name = "laptoppanel";
            this.laptoppanel.Size = new System.Drawing.Size(394, 271);
            this.laptoppanel.TabIndex = 35;
            // 
            // lbllaptop
            // 
            this.lbllaptop.BackColor = System.Drawing.Color.White;
            this.lbllaptop.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllaptop.ForeColor = System.Drawing.Color.Navy;
            this.lbllaptop.Location = new System.Drawing.Point(142, 237);
            this.lbllaptop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllaptop.Name = "lbllaptop";
            this.lbllaptop.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.lbllaptop.Size = new System.Drawing.Size(86, 30);
            this.lbllaptop.TabIndex = 10;
            this.lbllaptop.Text = "Laptop ";
            this.lbllaptop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radialGauge1
            // 
            this.radialGauge1.BackgroundGradientEndColor = System.Drawing.Color.White;
            this.radialGauge1.BackgroundGradientStartColor = System.Drawing.Color.White;
            this.radialGauge1.EnableCustomNeedles = false;
            this.radialGauge1.FrameType = Syncfusion.Windows.Forms.Gauge.FrameType.HalfCircle;
            this.radialGauge1.GaugeArcColor = System.Drawing.Color.Transparent;
            this.radialGauge1.GaugeLabel = "";
            this.radialGauge1.GaugeLableColor = System.Drawing.Color.Navy;
            this.radialGauge1.GaugeLableFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge1.GaugeValueColor = System.Drawing.Color.Purple;
            this.radialGauge1.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge1.InnerFrameGradientEndColor = System.Drawing.Color.White;
            this.radialGauge1.InnerFrameGradientStartColor = System.Drawing.Color.White;
            this.radialGauge1.InterLinesColor = System.Drawing.Color.Navy;
            this.radialGauge1.Location = new System.Drawing.Point(10, -25);
            this.radialGauge1.MajorDifference = 40F;
            this.radialGauge1.MajorTickMarkColor = System.Drawing.Color.Navy;
            this.radialGauge1.MajorTickMarkHeight = 0;
            this.radialGauge1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radialGauge1.MinimumSize = new System.Drawing.Size(130, 52);
            this.radialGauge1.MinorInnerLinesHeight = 0;
            this.radialGauge1.MinorTickMarkColor = System.Drawing.Color.Navy;
            this.radialGauge1.MinorTickMarkHeight = 0;
            this.radialGauge1.Name = "radialGauge1";
            this.radialGauge1.NeedleColor = System.Drawing.Color.Navy;
            this.radialGauge1.OuterFrameGradientEndColor = System.Drawing.Color.White;
            this.radialGauge1.OuterFrameGradientStartColor = System.Drawing.Color.White;
            range4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(68)))), ((int)(((byte)(15)))));
            range4.EndValue = 120F;
            range4.Height = 5;
            range4.InRange = true;
            range4.Name = "GaugeRange1";
            range4.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            range4.StartValue = 0F;
            this.radialGauge1.Ranges.Add(range4);
            this.radialGauge1.ScaleLabelColor = System.Drawing.Color.Navy;
            this.radialGauge1.Size = new System.Drawing.Size(380, 252);
            this.radialGauge1.StartAngle = 180;
            this.radialGauge1.SweepAngle = 180;
            this.radialGauge1.TabIndex = 1;
            this.radialGauge1.Value = 45.4F;
            // 
            // panelChart
            // 
            this.panelChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChart.Controls.Add(this.chartControl1);
            this.panelChart.Location = new System.Drawing.Point(20, 20);
            this.borderLayout1.SetMinimumSize(this.panelChart, new System.Drawing.Size(1584, 387));
            this.panelChart.Name = "panelChart";
            this.borderLayout1.SetPosition(this.panelChart, Syncfusion.Windows.Forms.Tools.BorderPosition.North);
            this.borderLayout1.SetPreferredSize(this.panelChart, new System.Drawing.Size(200, 387));
            this.panelChart.Size = new System.Drawing.Size(1672, 387);
            this.panelChart.TabIndex = 0;
            // 
            // chartControl1
            // 
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.WhiteSmoke);
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Snow);
            this.chartControl1.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(144)))), ((int)(((byte)(34))))),
        System.Drawing.Color.LimeGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(222)))), ((int)(((byte)(37))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(66)))), ((int)(((byte)(153))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(90)))), ((int)(((byte)(36))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(38)))))};
            this.chartControl1.DataSourceName = "[none]";
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Location = new System.Drawing.Point(754, 46);
            this.chartControl1.Legend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartControl1.Legend.Visible = false;
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.chartControl1.PrimaryXAxis.DrawGrid = false;
            this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.chartControl1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.chartControl1.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.chartControl1.PrimaryXAxis.TitleColor = System.Drawing.SystemColors.ControlText;
            this.chartControl1.PrimaryYAxis.DrawGrid = false;
            this.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.chartControl1.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.chartControl1.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.chartControl1.PrimaryYAxis.TitleColor = System.Drawing.SystemColors.ControlText;
            chartSeries1.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries1.Name = "Default0";
            chartSeries1.Points.Add(1D, ((double)(55D)));
            chartSeries1.Points.Add(2D, ((double)(70D)));
            chartSeries1.Points.Add(3D, ((double)(80D)));
            chartSeries1.Points.Add(4D, ((double)(65D)));
            chartSeries1.Points.Add(5D, ((double)(75D)));
            chartSeries1.Resolution = 0D;
            chartSeries1.StackingGroup = "Default Group";
            chartSeries1.Style.AltTagFormat = "";
            chartSeries1.Style.Callout.Font.Facename = "Microsoft Sans Serif";
            chartSeries1.Style.DrawTextShape = false;
            chartSeries1.Style.Font.Facename = "Microsoft Sans Serif";
            chartLineInfo1.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
            chartLineInfo1.Color = System.Drawing.SystemColors.ControlText;
            chartLineInfo1.DashPattern = null;
            chartLineInfo1.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartLineInfo1.Width = 1F;
            chartCustomShapeInfo1.Border = chartLineInfo1;
            chartCustomShapeInfo1.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo1.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries1.Style.TextShape = chartCustomShapeInfo1;
            chartSeries1.Text = "Default0";
            chartSeries2.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries2.Name = "Default1";
            chartSeries2.Points.Add(1D, ((double)(70D)));
            chartSeries2.Points.Add(2D, ((double)(35D)));
            chartSeries2.Points.Add(3D, ((double)(65D)));
            chartSeries2.Points.Add(4D, ((double)(25D)));
            chartSeries2.Points.Add(5D, ((double)(50D)));
            chartSeries2.Resolution = 0D;
            chartSeries2.StackingGroup = "Default Group";
            chartSeries2.Style.AltTagFormat = "";
            chartSeries2.Style.Callout.Font.Facename = "Microsoft Sans Serif";
            chartSeries2.Style.DrawTextShape = false;
            chartSeries2.Style.Font.Facename = "Microsoft Sans Serif";
            chartCustomShapeInfo2.Border = chartLineInfo1;
            chartCustomShapeInfo2.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo2.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries2.Style.TextShape = chartCustomShapeInfo2;
            chartSeries2.Text = "Default1";
            this.chartControl1.Series.Add(chartSeries1);
            this.chartControl1.Series.Add(chartSeries2);
            this.chartControl1.ShowToolbarInImage = false;
            this.chartControl1.ShowToolTips = true;
            this.chartControl1.Size = new System.Drawing.Size(1670, 385);
            this.chartControl1.StyleDialogOptions.ShowInteriorTab = false;
            this.chartControl1.TabIndex = 1;
            this.chartControl1.Tilt = 10F;
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.ToolBar.EnableDefaultItems = false;
            this.chartControl1.ToolBar.Items.Add(chartToolBarSaveItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarCopyItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPrintItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPrintPreviewItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarSplitter1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPaletteItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarStyleItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarTypeItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarSeries3DItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarShowLegendItem1);
            this.chartControl1.VisualTheme = "";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            // 
            // borderLayout1
            // 
            this.borderLayout1.BottomMargin = 20;
            this.borderLayout1.ContainerControl = this.panelMain;
            this.borderLayout1.HGap = 20;
            this.borderLayout1.HorzFarMargin = 20;
            this.borderLayout1.HorzNearMargin = 20;
            this.borderLayout1.TopMargin = 20;
            this.borderLayout1.VGap = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1716, 734);
            this.Controls.Add(this.panelMain);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorderLayout";
            this.panelMain.ResumeLayout(false);
            this.panelCentre.ResumeLayout(false);
            this.panelCentre.PerformLayout();
            this.panelEast.ResumeLayout(false);
            this.panelEast.PerformLayout();
            this.panelWest.ResumeLayout(false);
            this.panelWest.PerformLayout();
            this.panelGauge.ResumeLayout(false);
            this.smartphonepanel.ResumeLayout(false);
            this.smartphonepanel.PerformLayout();
            this.tabletpanel.ResumeLayout(false);
            this.tabletpanel.PerformLayout();
            this.desktoppanel.ResumeLayout(false);
            this.desktoppanel.PerformLayout();
            this.laptoppanel.ResumeLayout(false);
            this.laptoppanel.PerformLayout();
            this.panelChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.borderLayout1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelCentre;
        private Syncfusion.Windows.Forms.Tools.BorderLayout borderLayout1;
        private System.Windows.Forms.Panel panelEast;
        private System.Windows.Forms.Panel panelWest;
        private System.Windows.Forms.Panel panelGauge;
        private System.Windows.Forms.Panel panelChart;
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private System.Windows.Forms.Panel tabletpanel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lbltablet;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge4;
        private System.Windows.Forms.Panel desktoppanel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lbldesktop;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge2;
        private System.Windows.Forms.Panel laptoppanel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lbllaptop;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel smartphonepanel;
        private System.Windows.Forms.Label label5;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabelcountry;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabelcountryname;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabelproduct;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabelproductName;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabelMonth;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLblcountryvalue;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLblmonthvalue;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabelmonthname;
        private Triangle triangle1;
        private ReverseTriangle reverseTriangle1;
        private ReverseTriangle reverseTriangle2;
        private Triangle triangle2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblSmartphone;
    }
}

