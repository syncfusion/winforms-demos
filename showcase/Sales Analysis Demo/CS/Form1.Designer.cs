#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using System.Drawing;
using System.Windows.Forms;
namespace WindowsFormsApplication25
{
    partial class MainForm

    {
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Syncfusion.Windows.Forms.Gauge.Range range76 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range77 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range78 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range79 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range80 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range81 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range82 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range83 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range84 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range85 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range86 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range87 = new Syncfusion.Windows.Forms.Gauge.Range();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries3 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo3 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartLineInfo chartLineInfo2 = new Syncfusion.Windows.Forms.Chart.ChartLineInfo();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries4 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo4 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem chartToolBarSaveItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem chartToolBarCopyItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem chartToolBarPrintItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem chartToolBarPrintPreviewItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3DItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
            Syncfusion.Windows.Forms.Gauge.Range range88 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range89 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range90 = new Syncfusion.Windows.Forms.Gauge.Range();
            this.radialGauge1 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.radialGauge2 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.radialGauge4 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.radialGauge5 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.triangle12 = new WindowsFormsApplication25.Triangle();
            this.autoLabel10 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.triangle13 = new WindowsFormsApplication25.Triangle();
            this.autoLabel9 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rangeSlider1 = new Syncfusion.Windows.Forms.Tools.RangeSlider();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.triangle14 = new WindowsFormsApplication25.Triangle();
            this.autoLabel7 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.triangle16 = new WindowsFormsApplication25.Triangle();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.radialGauge3 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.panel9 = new System.Windows.Forms.Panel();
            this.triangle15 = new WindowsFormsApplication25.Triangle();
            this.autoLabel6 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel8 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.label22 = new System.Windows.Forms.Label();
            this.triangle4 = new WindowsFormsApplication25.Triangle();
            this.triangle5 = new WindowsFormsApplication25.Triangle();
            this.triangle11 = new WindowsFormsApplication25.Triangle();
            this.triangle10 = new WindowsFormsApplication25.Triangle();
            this.triangle9 = new WindowsFormsApplication25.Triangle();
            this.triangle3 = new WindowsFormsApplication25.Triangle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.sfDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.mapControl = new Syncfusion.Windows.Forms.Maps.Maps();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel11.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // radialGauge1
            // 
            this.radialGauge1.ArcThickness = 2F;
            this.radialGauge1.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.radialGauge1.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.radialGauge1.EnableCustomNeedles = false;
            this.radialGauge1.FillColor = System.Drawing.Color.DarkGray;
            this.radialGauge1.FrameThickness = 12;
            this.radialGauge1.FrameType = Syncfusion.Windows.Forms.Gauge.FrameType.HalfCircle;
            this.radialGauge1.GaugeArcColor = System.Drawing.Color.Transparent;
            this.radialGauge1.GaugeLabel = "";
            this.radialGauge1.GaugeLableFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge1.GaugeValueColor = System.Drawing.Color.Purple;
            this.radialGauge1.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge1.InnerFrameGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.radialGauge1.InnerFrameGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.radialGauge1.Location = new System.Drawing.Point(13, 15);
            this.radialGauge1.MajorDifference = 40F;
            this.radialGauge1.MajorTickMarkColor = System.Drawing.Color.Transparent;
            this.radialGauge1.MajorTickMarkHeight = 0;
            this.radialGauge1.Margin = new System.Windows.Forms.Padding(5);
            this.radialGauge1.MinimumSize = new System.Drawing.Size(130, 52);
            this.radialGauge1.MinorInnerLinesHeight = 0;
            this.radialGauge1.MinorTickMarkColor = System.Drawing.Color.Transparent;
            this.radialGauge1.Name = "radialGauge1";
            this.radialGauge1.NeedleColor = System.Drawing.Color.White;
            this.radialGauge1.OuterFrameGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.radialGauge1.OuterFrameGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            range76.Color = System.Drawing.Color.Purple;
            range76.EndValue = 40F;
            range76.Height = 5;
            range76.InRange = false;
            range76.Name = "GaugeRange1";
            range76.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range76.StartValue = 0F;
            range77.Color = System.Drawing.Color.Purple;
            range77.EndValue = 80F;
            range77.Height = 5;
            range77.InRange = true;
            range77.Name = "GaugeRange2";
            range77.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range77.StartValue = 42F;
            range78.Color = System.Drawing.Color.Purple;
            range78.EndValue = 120F;
            range78.Height = 5;
            range78.InRange = false;
            range78.Name = "GaugeRange3";
            range78.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range78.StartValue = 83F;
            this.radialGauge1.Ranges.Add(range76);
            this.radialGauge1.Ranges.Add(range77);
            this.radialGauge1.Ranges.Add(range78);
            this.radialGauge1.ShowTicks = true;
            this.radialGauge1.Size = new System.Drawing.Size(379, 252);
            this.radialGauge1.StartAngle = 180;
            this.radialGauge1.SweepAngle = 180;
            this.radialGauge1.TabIndex = 1;
            this.radialGauge1.Value = 45.4F;
            this.radialGauge1.Click += new System.EventHandler(this.panel11_Click);
            // 
            // radialGauge2
            // 
            this.radialGauge2.ArcThickness = 2F;
            this.radialGauge2.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.radialGauge2.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.radialGauge2.EnableCustomNeedles = false;
            this.radialGauge2.FillColor = System.Drawing.Color.DarkGray;
            this.radialGauge2.FrameThickness = 12;
            this.radialGauge2.FrameType = Syncfusion.Windows.Forms.Gauge.FrameType.HalfCircle;
            this.radialGauge2.GaugeArcColor = System.Drawing.Color.Transparent;
            this.radialGauge2.GaugeLabel = "";
            this.radialGauge2.GaugeLableFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge2.GaugeValueColor = System.Drawing.Color.Maroon;
            this.radialGauge2.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge2.InnerFrameGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.radialGauge2.InnerFrameGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.radialGauge2.Location = new System.Drawing.Point(11, 15);
            this.radialGauge2.MajorDifference = 40F;
            this.radialGauge2.MajorTickMarkColor = System.Drawing.Color.Transparent;
            this.radialGauge2.MajorTickMarkHeight = 0;
            this.radialGauge2.Margin = new System.Windows.Forms.Padding(5);
            this.radialGauge2.MinimumSize = new System.Drawing.Size(130, 52);
            this.radialGauge2.MinorInnerLinesHeight = 0;
            this.radialGauge2.MinorTickMarkColor = System.Drawing.Color.Transparent;
            this.radialGauge2.MinorTickMarkHeight = 0;
            this.radialGauge2.Name = "radialGauge2";
            this.radialGauge2.NeedleColor = System.Drawing.Color.White;
            this.radialGauge2.OuterFrameGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.radialGauge2.OuterFrameGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            range79.Color = System.Drawing.Color.Red;
            range79.EndValue = 40F;
            range79.Height = 5;
            range79.InRange = false;
            range79.Name = "GaugeRange1";
            range79.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range79.StartValue = 0F;
            range80.Color = System.Drawing.Color.Red;
            range80.EndValue = 80F;
            range80.Height = 5;
            range80.InRange = true;
            range80.Name = "GaugeRange2";
            range80.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range80.StartValue = 42F;
            range81.Color = System.Drawing.Color.Red;
            range81.EndValue = 120F;
            range81.Height = 5;
            range81.InRange = false;
            range81.Name = "GaugeRange3";
            range81.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range81.StartValue = 82F;
            this.radialGauge2.Ranges.Add(range79);
            this.radialGauge2.Ranges.Add(range80);
            this.radialGauge2.Ranges.Add(range81);
            this.radialGauge2.ShowTicks = true;
            this.radialGauge2.Size = new System.Drawing.Size(379, 252);
            this.radialGauge2.StartAngle = 180;
            this.radialGauge2.SweepAngle = 180;
            this.radialGauge2.TabIndex = 2;
            this.radialGauge2.Value = 60.2F;
            this.radialGauge2.Click += new System.EventHandler(this.panel11_Click);
            // 
            // radialGauge4
            // 
            this.radialGauge4.ArcThickness = 2F;
            this.radialGauge4.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.radialGauge4.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.radialGauge4.EnableCustomNeedles = false;
            this.radialGauge4.FillColor = System.Drawing.Color.DarkGray;
            this.radialGauge4.FrameThickness = 12;
            this.radialGauge4.FrameType = Syncfusion.Windows.Forms.Gauge.FrameType.HalfCircle;
            this.radialGauge4.GaugeArcColor = System.Drawing.Color.Transparent;
            this.radialGauge4.GaugeLabel = "";
            this.radialGauge4.GaugeLableFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge4.GaugeValueColor = System.Drawing.Color.Green;
            this.radialGauge4.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge4.InnerFrameGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.radialGauge4.InnerFrameGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.radialGauge4.Location = new System.Drawing.Point(11, 15);
            this.radialGauge4.MajorDifference = 40F;
            this.radialGauge4.MajorTickMarkColor = System.Drawing.Color.Transparent;
            this.radialGauge4.MajorTickMarkHeight = 0;
            this.radialGauge4.Margin = new System.Windows.Forms.Padding(5);
            this.radialGauge4.MinimumSize = new System.Drawing.Size(130, 52);
            this.radialGauge4.MinorInnerLinesHeight = 0;
            this.radialGauge4.Name = "radialGauge4";
            this.radialGauge4.NeedleColor = System.Drawing.Color.White;
            this.radialGauge4.OuterFrameGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.radialGauge4.OuterFrameGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            range82.Color = System.Drawing.Color.Green;
            range82.EndValue = 40F;
            range82.Height = 5;
            range82.InRange = false;
            range82.Name = "GaugeRange1";
            range82.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range82.StartValue = 0F;
            range83.Color = System.Drawing.Color.Green;
            range83.EndValue = 80F;
            range83.Height = 5;
            range83.InRange = true;
            range83.Name = "GaugeRange2";
            range83.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range83.StartValue = 42F;
            range84.Color = System.Drawing.Color.Green;
            range84.EndValue = 120F;
            range84.Height = 5;
            range84.InRange = false;
            range84.Name = "GaugeRange3";
            range84.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range84.StartValue = 82F;
            this.radialGauge4.Ranges.Add(range82);
            this.radialGauge4.Ranges.Add(range83);
            this.radialGauge4.Ranges.Add(range84);
            this.radialGauge4.ShowTicks = true;
            this.radialGauge4.Size = new System.Drawing.Size(382, 254);
            this.radialGauge4.StartAngle = 180;
            this.radialGauge4.SweepAngle = 180;
            this.radialGauge4.TabIndex = 4;
            this.radialGauge4.Value = 77.9F;
            this.radialGauge4.Click += new System.EventHandler(this.panel11_Click);
            // 
            // radialGauge5
            // 
            this.radialGauge5.ArcThickness = 2F;
            this.radialGauge5.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.radialGauge5.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.radialGauge5.EnableCustomNeedles = false;
            this.radialGauge5.FillColor = System.Drawing.Color.DarkGray;
            this.radialGauge5.FrameThickness = 12;
            this.radialGauge5.FrameType = Syncfusion.Windows.Forms.Gauge.FrameType.HalfCircle;
            this.radialGauge5.GaugeArcColor = System.Drawing.Color.Transparent;
            this.radialGauge5.GaugeLabel = "";
            this.radialGauge5.GaugeLableFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge5.GaugeValueColor = System.Drawing.Color.Yellow;
            this.radialGauge5.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge5.InnerFrameGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.radialGauge5.InnerFrameGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.radialGauge5.InterLinesColor = System.Drawing.Color.WhiteSmoke;
            this.radialGauge5.Location = new System.Drawing.Point(11, 15);
            this.radialGauge5.MajorDifference = 40F;
            this.radialGauge5.MajorTickMarkColor = System.Drawing.Color.Transparent;
            this.radialGauge5.MajorTickMarkHeight = 0;
            this.radialGauge5.Margin = new System.Windows.Forms.Padding(5);
            this.radialGauge5.MinimumSize = new System.Drawing.Size(130, 52);
            this.radialGauge5.MinorInnerLinesHeight = 0;
            this.radialGauge5.Name = "radialGauge5";
            this.radialGauge5.NeedleColor = System.Drawing.Color.White;
            this.radialGauge5.OuterFrameGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.radialGauge5.OuterFrameGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            range85.Color = System.Drawing.Color.Yellow;
            range85.EndValue = 40F;
            range85.Height = 5;
            range85.InRange = true;
            range85.Name = "GaugeRange1";
            range85.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range85.StartValue = 0F;
            range86.Color = System.Drawing.Color.Yellow;
            range86.EndValue = 80F;
            range86.Height = 5;
            range86.InRange = false;
            range86.Name = "GaugeRange2";
            range86.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range86.StartValue = 42F;
            range87.Color = System.Drawing.Color.Yellow;
            range87.EndValue = 120F;
            range87.Height = 5;
            range87.InRange = false;
            range87.Name = "GaugeRange3";
            range87.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range87.StartValue = 82F;
            this.radialGauge5.Ranges.Add(range85);
            this.radialGauge5.Ranges.Add(range86);
            this.radialGauge5.Ranges.Add(range87);
            this.radialGauge5.ShowTicks = true;
            this.radialGauge5.Size = new System.Drawing.Size(382, 254);
            this.radialGauge5.StartAngle = 180;
            this.radialGauge5.SweepAngle = 180;
            this.radialGauge5.TabIndex = 6;
            this.radialGauge5.Value = 20.5F;
            this.radialGauge5.Click += new System.EventHandler(this.panel11_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(22)))));
            this.tableLayoutPanel2.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Location = new System.Drawing.Point(5, 178);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 373);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.panel11_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(5, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Sales By Country";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(702, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(625, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // chartControl1
            // 
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Black);
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.chartControl1.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(144)))), ((int)(((byte)(34))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(190)))), ((int)(((byte)(82))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(222)))), ((int)(((byte)(37))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(66)))), ((int)(((byte)(153))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(90)))), ((int)(((byte)(36))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(38)))))};
            this.chartControl1.DataSourceName = "[none]";
            this.chartControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Location = new System.Drawing.Point(754, 46);
            this.chartControl1.Legend.Margin = new System.Windows.Forms.Padding(5);
            this.chartControl1.Legend.Visible = false;
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(5, 67);
            this.chartControl1.Margin = new System.Windows.Forms.Padding(5);
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
            chartSeries3.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries3.Name = "Default0";
            chartSeries3.Points.Add(1D, ((double)(55D)));
            chartSeries3.Points.Add(2D, ((double)(70D)));
            chartSeries3.Points.Add(3D, ((double)(80D)));
            chartSeries3.Points.Add(4D, ((double)(65D)));
            chartSeries3.Points.Add(5D, ((double)(75D)));
            chartSeries3.Resolution = 0D;
            chartSeries3.StackingGroup = "Default Group";
            chartSeries3.Style.AltTagFormat = "";
            chartSeries3.Style.Callout.Font.Facename = "Microsoft Sans Serif";
            chartSeries3.Style.DrawTextShape = false;
            chartSeries3.Style.Font.Facename = "Microsoft Sans Serif";
            chartLineInfo2.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
            chartLineInfo2.Color = System.Drawing.SystemColors.ControlText;
            chartLineInfo2.DashPattern = null;
            chartLineInfo2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartLineInfo2.Width = 1F;
            chartCustomShapeInfo3.Border = chartLineInfo2;
            chartCustomShapeInfo3.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo3.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries3.Style.TextShape = chartCustomShapeInfo3;
            chartSeries3.Text = "Default0";
            chartSeries4.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries4.Name = "Default1";
            chartSeries4.Points.Add(1D, ((double)(70D)));
            chartSeries4.Points.Add(2D, ((double)(35D)));
            chartSeries4.Points.Add(3D, ((double)(65D)));
            chartSeries4.Points.Add(4D, ((double)(25D)));
            chartSeries4.Points.Add(5D, ((double)(50D)));
            chartSeries4.Resolution = 0D;
            chartSeries4.StackingGroup = "Default Group";
            chartSeries4.Style.AltTagFormat = "";
            chartSeries4.Style.Callout.Font.Facename = "Microsoft Sans Serif";
            chartSeries4.Style.DrawTextShape = false;
            chartSeries4.Style.Font.Facename = "Microsoft Sans Serif";
            chartCustomShapeInfo4.Border = chartLineInfo2;
            chartCustomShapeInfo4.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo4.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries4.Style.TextShape = chartCustomShapeInfo4;
            chartSeries4.Text = "Default1";
            this.chartControl1.Series.Add(chartSeries3);
            this.chartControl1.Series.Add(chartSeries4);
            this.chartControl1.ShowToolbarInImage = false;
            this.chartControl1.ShowToolTips = true;
            this.chartControl1.Size = new System.Drawing.Size(508, 301);
            this.chartControl1.StyleDialogOptions.ShowInteriorTab = false;
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Tilt = 10F;
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.ToolBar.EnableDefaultItems = false;
            this.chartControl1.ToolBar.Items.Add(chartToolBarSaveItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarCopyItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPrintItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPrintPreviewItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarSplitter2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPaletteItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarStyleItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarTypeItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarSeries3DItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarShowLegendItem2);
            this.chartControl1.VisualTheme = "";
            this.chartControl1.Click += new System.EventHandler(this.panel11_Click);
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.White;
            this.autoLabel1.Location = new System.Drawing.Point(2, 6);
            this.autoLabel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.autoLabel1.Size = new System.Drawing.Size(67, 20);
            this.autoLabel1.TabIndex = 7;
            this.autoLabel1.Text = "Desktop";
            this.autoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // autoLabel2
            // 
            this.autoLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.autoLabel2.ForeColor = System.Drawing.Color.White;
            this.autoLabel2.Location = new System.Drawing.Point(14, 6);
            this.autoLabel2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.autoLabel2.Size = new System.Drawing.Size(52, 20);
            this.autoLabel2.TabIndex = 8;
            this.autoLabel2.Text = "Tablet";
            this.autoLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // autoLabel4
            // 
            this.autoLabel4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel4.ForeColor = System.Drawing.Color.White;
            this.autoLabel4.Location = new System.Drawing.Point(13, 6);
            this.autoLabel4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.autoLabel4.Size = new System.Drawing.Size(62, 20);
            this.autoLabel4.TabIndex = 10;
            this.autoLabel4.Text = "Laptop ";
            this.autoLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // autoLabel5
            // 
            this.autoLabel5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.autoLabel5.ForeColor = System.Drawing.Color.White;
            this.autoLabel5.Location = new System.Drawing.Point(5, 6);
            this.autoLabel5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.autoLabel5.Name = "autoLabel5";
            this.autoLabel5.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.autoLabel5.Size = new System.Drawing.Size(95, 20);
            this.autoLabel5.TabIndex = 11;
            this.autoLabel5.Text = "SmartPhone";
            this.autoLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(145, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = " $ 110( 42.2% )";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(126, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = " $ 140( 69.2% )";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(154, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "$ 239( 76.2% )";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(134, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "$ 182( 20.2% )";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Location = new System.Drawing.Point(0, 725);
            this.panel4.Margin = new System.Windows.Forms.Padding(5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1667, 80);
            this.panel4.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(158, 86);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "PDF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(34, 86);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Excel";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(120, 10);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(25, 10);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(22)))));
            this.tableLayoutPanel2.SetColumnSpan(this.panel5, 2);
            this.panel5.Controls.Add(this.tableLayoutPanel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(791, 178);
            this.panel5.Margin = new System.Windows.Forms.Padding(5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(518, 373);
            this.panel5.TabIndex = 33;
            this.panel5.Click += new System.EventHandler(this.panel11_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.chartControl1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(518, 373);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(5, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Sales By Product Category";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel6.Controls.Add(this.triangle12);
            this.panel6.Controls.Add(this.autoLabel10);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.autoLabel4);
            this.panel6.Controls.Add(this.radialGauge1);
            this.panel6.Location = new System.Drawing.Point(5, 5);
            this.panel6.Margin = new System.Windows.Forms.Padding(5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(252, 163);
            this.panel6.TabIndex = 34;
            this.panel6.Click += new System.EventHandler(this.panel11_Click);
            // 
            // triangle12
            // 
            this.triangle12.Location = new System.Drawing.Point(115, 192);
            this.triangle12.Margin = new System.Windows.Forms.Padding(6);
            this.triangle12.Name = "triangle12";
            this.triangle12.Size = new System.Drawing.Size(19, 26);
            this.triangle12.TabIndex = 50;
            // 
            // autoLabel10
            // 
            this.autoLabel10.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.autoLabel10.ForeColor = System.Drawing.Color.White;
            this.autoLabel10.Location = new System.Drawing.Point(92, 11);
            this.autoLabel10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.autoLabel10.Name = "autoLabel10";
            this.autoLabel10.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.autoLabel10.Size = new System.Drawing.Size(155, 20);
            this.autoLabel10.TabIndex = 40;
            this.autoLabel10.Text = "Marketing Vs Revenue";
            this.autoLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel7.Controls.Add(this.triangle13);
            this.panel7.Controls.Add(this.autoLabel1);
            this.panel7.Controls.Add(this.autoLabel9);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.radialGauge2);
            this.panel7.Location = new System.Drawing.Point(267, 5);
            this.panel7.Margin = new System.Windows.Forms.Padding(5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(252, 163);
            this.panel7.TabIndex = 35;
            this.panel7.Click += new System.EventHandler(this.panel11_Click);
            // 
            // triangle13
            // 
            this.triangle13.Location = new System.Drawing.Point(101, 192);
            this.triangle13.Margin = new System.Windows.Forms.Padding(6);
            this.triangle13.Name = "triangle13";
            this.triangle13.Size = new System.Drawing.Size(22, 25);
            this.triangle13.TabIndex = 51;
            // 
            // autoLabel9
            // 
            this.autoLabel9.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.autoLabel9.ForeColor = System.Drawing.Color.White;
            this.autoLabel9.Location = new System.Drawing.Point(96, 11);
            this.autoLabel9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.autoLabel9.Name = "autoLabel9";
            this.autoLabel9.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.autoLabel9.Size = new System.Drawing.Size(155, 20);
            this.autoLabel9.TabIndex = 39;
            this.autoLabel9.Text = "Marketing Vs Revenue";
            this.autoLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.tableLayoutPanel2);
            this.panel11.Controls.Add(this.label22);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(2, 2);
            this.panel11.Margin = new System.Windows.Forms.Padding(5);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.panel11.Size = new System.Drawing.Size(1328, 619);
            this.panel11.TabIndex = 43;
            this.panel11.Click += new System.EventHandler(this.panel11_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.panel5, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel7, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel10, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel9, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1314, 619);
            this.tableLayoutPanel2.TabIndex = 51;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 12;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel1, 5);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel1.Controls.Add(this.rangeSlider1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label12, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label13, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label14, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label15, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label16, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label17, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.label18, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.label19, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.label20, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.label21, 10, 1);
            this.tableLayoutPanel1.Controls.Add(this.label22, 11, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 559);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1308, 57);
            this.tableLayoutPanel1.TabIndex = 50;
            // 
            // rangeSlider1
            // 
            this.rangeSlider1.BeforeTouchSize = new System.Drawing.Size(1093, 22);
            this.rangeSlider1.ChannelColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.tableLayoutPanel1.SetColumnSpan(this.rangeSlider1, 12);
            this.rangeSlider1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.rangeSlider1.ForeColor = System.Drawing.Color.Black;
            this.rangeSlider1.Location = new System.Drawing.Point(5, 5);
            this.rangeSlider1.Margin = new System.Windows.Forms.Padding(5);
            this.rangeSlider1.Maximum = 12;
            this.rangeSlider1.Minimum = 1;
            this.rangeSlider1.Name = "rangeSlider1";
            this.rangeSlider1.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.rangeSlider1.Size = new System.Drawing.Size(1093, 22);
            this.rangeSlider1.SliderMin = 2;
            this.rangeSlider1.SliderSize = new System.Drawing.Size(7, 17);
            this.rangeSlider1.TabIndex = 32;
            this.rangeSlider1.Text = "rangeSlider1";
            this.rangeSlider1.ThemeName = "Metro";
            this.rangeSlider1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.rangeSlider1.VisualStyle = Syncfusion.Windows.Forms.Tools.RangeSlider.RangeSliderStyle.Metro;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(5, 28);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Jan";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(113, 28);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Feb";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(221, 28);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Mar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(329, 28);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "Apr";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(437, 28);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "May";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Location = new System.Drawing.Point(545, 28);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "Jun";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Location = new System.Drawing.Point(653, 28);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 13);
            this.label17.TabIndex = 44;
            this.label17.Text = "Jul";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.Location = new System.Drawing.Point(761, 28);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "Aug";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label19.Location = new System.Drawing.Point(869, 28);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(26, 13);
            this.label19.TabIndex = 46;
            this.label19.Text = "Sep";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label20.Location = new System.Drawing.Point(977, 28);
            this.label20.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(25, 13);
            this.label20.TabIndex = 47;
            this.label20.Text = "Oct";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label21.Location = new System.Drawing.Point(1085, 28);
            this.label21.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(27, 13);
            this.label21.TabIndex = 48;
            this.label21.Text = "Nov";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label22.Location = new System.Drawing.Point(2035, 935);
            this.label22.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(26, 13);
            this.label22.TabIndex = 49;
            this.label22.Text = "Dec";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel8.Controls.Add(this.triangle14);
            this.panel8.Controls.Add(this.autoLabel7);
            this.panel8.Controls.Add(this.autoLabel2);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.radialGauge4);
            this.panel8.Location = new System.Drawing.Point(529, 5);
            this.panel8.Margin = new System.Windows.Forms.Padding(5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(252, 163);
            this.panel8.TabIndex = 0;
            this.panel8.Click += new System.EventHandler(this.panel11_Click);
            // 
            // triangle14
            // 
            this.triangle14.Location = new System.Drawing.Point(119, 192);
            this.triangle14.Margin = new System.Windows.Forms.Padding(6);
            this.triangle14.Name = "triangle14";
            this.triangle14.Size = new System.Drawing.Size(22, 25);
            this.triangle14.TabIndex = 52;
            // 
            // autoLabel7
            // 
            this.autoLabel7.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.autoLabel7.ForeColor = System.Drawing.Color.White;
            this.autoLabel7.Location = new System.Drawing.Point(92, 11);
            this.autoLabel7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.autoLabel7.Name = "autoLabel7";
            this.autoLabel7.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.autoLabel7.Size = new System.Drawing.Size(155, 20);
            this.autoLabel7.TabIndex = 38;
            this.autoLabel7.Text = "Marketing Vs Revenue";
            this.autoLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel10.Controls.Add(this.triangle16);
            this.panel10.Controls.Add(this.autoLabel3);
            this.panel10.Controls.Add(this.label5);
            this.panel10.Controls.Add(this.autoLabel5);
            this.panel10.Controls.Add(this.radialGauge3);
            this.panel10.Location = new System.Drawing.Point(1053, 5);
            this.panel10.Margin = new System.Windows.Forms.Padding(5);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(256, 144);
            this.panel10.TabIndex = 38;
            this.panel10.Click += new System.EventHandler(this.panel11_Click);
            // 
            // triangle16
            // 
            this.triangle16.Location = new System.Drawing.Point(98, 192);
            this.triangle16.Margin = new System.Windows.Forms.Padding(6);
            this.triangle16.Name = "triangle16";
            this.triangle16.Size = new System.Drawing.Size(34, 26);
            this.triangle16.TabIndex = 54;
            // 
            // autoLabel3
            // 
            this.autoLabel3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.autoLabel3.ForeColor = System.Drawing.Color.White;
            this.autoLabel3.Location = new System.Drawing.Point(140, 13);
            this.autoLabel3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.autoLabel3.Size = new System.Drawing.Size(155, 20);
            this.autoLabel3.TabIndex = 37;
            this.autoLabel3.Text = "Marketing Vs Revenue";
            this.autoLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(131, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "$ 222( 78.2% )";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radialGauge3
            // 
            this.radialGauge3.ArcThickness = 2F;
            this.radialGauge3.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.radialGauge3.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.radialGauge3.EnableCustomNeedles = false;
            this.radialGauge3.FillColor = System.Drawing.Color.DarkGray;
            this.radialGauge3.FrameThickness = 12;
            this.radialGauge3.FrameType = Syncfusion.Windows.Forms.Gauge.FrameType.HalfCircle;
            this.radialGauge3.GaugeArcColor = System.Drawing.Color.Transparent;
            this.radialGauge3.GaugeLabel = "";
            this.radialGauge3.GaugeLableFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge3.GaugeValueColor = System.Drawing.Color.Blue;
            this.radialGauge3.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge3.InnerFrameGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.radialGauge3.InnerFrameGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.radialGauge3.InterLinesColor = System.Drawing.Color.Transparent;
            this.radialGauge3.Location = new System.Drawing.Point(11, 15);
            this.radialGauge3.MajorDifference = 40F;
            this.radialGauge3.MajorTickMarkColor = System.Drawing.Color.Transparent;
            this.radialGauge3.MajorTickMarkHeight = 0;
            this.radialGauge3.Margin = new System.Windows.Forms.Padding(5);
            this.radialGauge3.MinimumSize = new System.Drawing.Size(130, 52);
            this.radialGauge3.MinorInnerLinesHeight = 0;
            this.radialGauge3.MinorTickMarkColor = System.Drawing.Color.Transparent;
            this.radialGauge3.Name = "radialGauge3";
            this.radialGauge3.NeedleColor = System.Drawing.Color.White;
            this.radialGauge3.OuterFrameGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.radialGauge3.OuterFrameGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            range88.Color = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(43)))), ((int)(((byte)(180)))));
            range88.EndValue = 40F;
            range88.Height = 5;
            range88.InRange = false;
            range88.Name = "GaugeRange1";
            range88.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range88.StartValue = 0F;
            range89.Color = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(43)))), ((int)(((byte)(180)))));
            range89.EndValue = 80F;
            range89.Height = 5;
            range89.InRange = true;
            range89.Name = "GaugeRange2";
            range89.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range89.StartValue = 42F;
            range90.Color = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(43)))), ((int)(((byte)(180)))));
            range90.EndValue = 120F;
            range90.Height = 5;
            range90.InRange = false;
            range90.Name = "GaugeRange3";
            range90.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range90.StartValue = 82F;
            this.radialGauge3.Ranges.Add(range88);
            this.radialGauge3.Ranges.Add(range89);
            this.radialGauge3.Ranges.Add(range90);
            this.radialGauge3.ShowTicks = true;
            this.radialGauge3.Size = new System.Drawing.Size(382, 254);
            this.radialGauge3.StartAngle = 180;
            this.radialGauge3.SweepAngle = 180;
            this.radialGauge3.TabIndex = 6;
            this.radialGauge3.Value = 78.2F;
            this.radialGauge3.Click += new System.EventHandler(this.panel11_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel9.Controls.Add(this.triangle15);
            this.panel9.Controls.Add(this.autoLabel6);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Controls.Add(this.autoLabel8);
            this.panel9.Controls.Add(this.radialGauge5);
            this.panel9.Location = new System.Drawing.Point(791, 5);
            this.panel9.Margin = new System.Windows.Forms.Padding(5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(252, 163);
            this.panel9.TabIndex = 36;
            this.panel9.Click += new System.EventHandler(this.panel11_Click);
            // 
            // triangle15
            // 
            this.triangle15.Location = new System.Drawing.Point(106, 192);
            this.triangle15.Margin = new System.Windows.Forms.Padding(6);
            this.triangle15.Name = "triangle15";
            this.triangle15.Size = new System.Drawing.Size(22, 26);
            this.triangle15.TabIndex = 53;
            // 
            // autoLabel6
            // 
            this.autoLabel6.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.autoLabel6.ForeColor = System.Drawing.Color.White;
            this.autoLabel6.Location = new System.Drawing.Point(80, 11);
            this.autoLabel6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.autoLabel6.Name = "autoLabel6";
            this.autoLabel6.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.autoLabel6.Size = new System.Drawing.Size(155, 20);
            this.autoLabel6.TabIndex = 37;
            this.autoLabel6.Text = "Marketing Vs Revenue";
            this.autoLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // autoLabel8
            // 
            this.autoLabel8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.autoLabel8.ForeColor = System.Drawing.Color.White;
            this.autoLabel8.Location = new System.Drawing.Point(5, 6);
            this.autoLabel8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.autoLabel8.Name = "autoLabel8";
            this.autoLabel8.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.autoLabel8.Size = new System.Drawing.Size(56, 20);
            this.autoLabel8.TabIndex = 10;
            this.autoLabel8.Text = "Hybrid";
            this.autoLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // triangle4
            // 
            this.triangle4.Location = new System.Drawing.Point(92, 120);
            this.triangle4.Margin = new System.Windows.Forms.Padding(4);
            this.triangle4.Name = "triangle4";
            this.triangle4.Size = new System.Drawing.Size(18, 17);
            this.triangle4.TabIndex = 41;
            // 
            // triangle5
            // 
            this.triangle5.Location = new System.Drawing.Point(96, 120);
            this.triangle5.Margin = new System.Windows.Forms.Padding(4);
            this.triangle5.Name = "triangle5";
            this.triangle5.Size = new System.Drawing.Size(18, 17);
            this.triangle5.TabIndex = 42;
            // 
            // triangle11
            // 
            this.triangle11.Location = new System.Drawing.Point(91, 123);
            this.triangle11.Margin = new System.Windows.Forms.Padding(4);
            this.triangle11.Name = "triangle11";
            this.triangle11.Size = new System.Drawing.Size(18, 17);
            this.triangle11.TabIndex = 45;
            // 
            // triangle10
            // 
            this.triangle10.Location = new System.Drawing.Point(96, 123);
            this.triangle10.Margin = new System.Windows.Forms.Padding(4);
            this.triangle10.Name = "triangle10";
            this.triangle10.Size = new System.Drawing.Size(18, 17);
            this.triangle10.TabIndex = 44;
            // 
            // triangle9
            // 
            this.triangle9.Location = new System.Drawing.Point(99, 120);
            this.triangle9.Margin = new System.Windows.Forms.Padding(4);
            this.triangle9.Name = "triangle9";
            this.triangle9.Size = new System.Drawing.Size(18, 17);
            this.triangle9.TabIndex = 43;
            // 
            // triangle3
            // 
            this.triangle3.Location = new System.Drawing.Point(97, 120);
            this.triangle3.Margin = new System.Windows.Forms.Padding(4);
            this.triangle3.Name = "triangle3";
            this.triangle3.Size = new System.Drawing.Size(18, 16);
            this.triangle3.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Location = new System.Drawing.Point(-58, -114);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2113, 578);
            this.panel2.TabIndex = 2;
            this.panel2.Click += new System.EventHandler(this.panel11_Click);
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.Location = new System.Drawing.Point(460, 565);
            this.panel12.Margin = new System.Windows.Forms.Padding(5);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(90, 365);
            this.panel12.TabIndex = 5;
            this.panel12.Click += new System.EventHandler(this.panel11_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 143);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "label6";
            // 
            // sfDataGrid
            // 
            this.sfDataGrid.AccessibleName = "Table";
            this.sfDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfDataGrid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sfDataGrid.HeaderRowHeight = 25;
            this.sfDataGrid.Location = new System.Drawing.Point(0, 0);
            this.sfDataGrid.Margin = new System.Windows.Forms.Padding(5);
            this.sfDataGrid.Name = "sfDataGrid";
            this.sfDataGrid.NavigationMode = Syncfusion.WinForms.DataGrid.Enums.NavigationMode.Row;
            this.sfDataGrid.RowHeight = 25;
            this.sfDataGrid.SerializationController = null;
            this.sfDataGrid.Size = new System.Drawing.Size(764, 324);
            this.sfDataGrid.TabIndex = 1;
            this.sfDataGrid.Text = "sfDataGrid";
            // 
            // mapControl
            // 
            this.mapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl.EnableZoomOnSelection = false;
            this.mapControl.Location = new System.Drawing.Point(0, 0);
            this.mapControl.MapItemFont = null;
            this.mapControl.MapItemsShape = Syncfusion.Windows.Forms.Maps.MapItemShapes.Ellipse;
            this.mapControl.Margin = new System.Windows.Forms.Padding(0);
            this.mapControl.Name = "mapControl";
            this.mapControl.OnSelectionChanged = null;
            this.mapControl.Size = new System.Drawing.Size(764, 324);
            this.mapControl.TabIndex = 0;
            this.mapControl.Click += new System.EventHandler(this.panel11_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel4.SetColumnSpan(this.panel3, 3);
            this.panel3.Controls.Add(this.mapControl);
            this.panel3.Controls.Add(this.sfDataGrid);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(5, 42);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(766, 326);
            this.panel3.TabIndex = 4;
            this.panel3.Click += new System.EventHandler(this.panel11_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.pictureBox2, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(776, 373);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1332, 623);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel4);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.ShowToolTip = false;
            this.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Style.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.Style.TitleBar.CaptionImage = global::SalesAnalysis.Properties.Resources.header_text;
            this.Style.TitleBar.CaptionImageLocation = new System.Drawing.Point(10, 14);
            this.Style.TitleBar.CloseButtonForeColor = System.Drawing.Color.White;
            this.Style.TitleBar.CloseButtonHoverBackColor = System.Drawing.Color.Red;
            this.Style.TitleBar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Style.TitleBar.ForeColor = System.Drawing.Color.White;
            this.Style.TitleBar.Height = 75;
            this.Style.TitleBar.HelpButtonHoverBackColor = System.Drawing.Color.Transparent;
            this.Style.TitleBar.HelpButtonHoverImage = ((System.Drawing.Image)(resources.GetObject("resource.HelpButtonHoverImage")));
            this.Style.TitleBar.HelpButtonImage = ((System.Drawing.Image)(resources.GetObject("resource.HelpButtonImage")));
            this.Style.TitleBar.HelpButtonPressedBackColor = System.Drawing.Color.Transparent;
            this.Style.TitleBar.HelpButtonSize = new System.Drawing.Size(65, 65);
            this.Style.TitleBar.MaximizeButtonForeColor = System.Drawing.Color.White;
            this.Style.TitleBar.MinimizeButtonForeColor = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected override void OnSizeChanged(System.EventArgs e)
        {
            base.OnSizeChanged(e);
           
        }
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge1;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge2;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge4;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge5;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel7;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel6;
        private System.Windows.Forms.Panel panel10;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private System.Windows.Forms.Label label5;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel8;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel10;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel9;
        private Syncfusion.Windows.Forms.Tools.RangeSlider rangeSlider1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private Triangle triangle3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private Triangle triangle4;
        private Triangle triangle5;
        private Triangle triangle9;
        private Triangle triangle10;
        private Triangle triangle11;
        private System.Windows.Forms.Panel panel11;
        private Triangle triangle12;
        private Triangle triangle13;
        private Triangle triangle16;
        private Triangle triangle15;
        private Triangle triangle14;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel3;
        private Syncfusion.Windows.Forms.Maps.Maps mapControl;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid;
        private Panel panel2;
        private Label label6;
        private Panel panel12;
        private TableLayoutPanel tableLayoutPanel4;
    }
}

