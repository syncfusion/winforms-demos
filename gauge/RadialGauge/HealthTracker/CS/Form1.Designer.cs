#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

namespace GaugeInterctionSample
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
            Syncfusion.Windows.Forms.Gauge.LinearRange linearRange1 = new Syncfusion.Windows.Forms.Gauge.LinearRange();
            Syncfusion.Windows.Forms.Gauge.Range range2 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range3 = new Syncfusion.Windows.Forms.Gauge.Range();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radialGauge1 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.linearGauge1 = new Syncfusion.Windows.Forms.Gauge.LinearGauge();
            this.radialGauge2 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.radialGauge3 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "BMI";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 137);
            this.panel1.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1247, 146);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(876, 4);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(222, 88);
            this.flowLayoutPanel4.TabIndex = 14;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(103, 80);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::GaugeInterctionSample.Properties.Resources.Icon_1;
            this.pictureBox2.Location = new System.Drawing.Point(4, 23);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.pictureBox3);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(115, 4);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(103, 80);
            this.flowLayoutPanel3.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Weight";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::GaugeInterctionSample.Properties.Resources.Icon_2;
            this.pictureBox3.Location = new System.Drawing.Point(4, 23);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(95, 53);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox4);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(128, 4);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(174, 86);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Andrew Fuller";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GaugeInterctionSample.Properties.Resources.Blue_Icon;
            this.pictureBox4.Location = new System.Drawing.Point(4, 32);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "34 years / 175 cm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GaugeInterctionSample.Properties.Resources.person;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Location = new System.Drawing.Point(3, 149);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1236, 757);
            this.panel2.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.radialGauge1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.radialGauge2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.radialGauge3, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.14531F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.85469F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1236, 757);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // radialGauge1
            // 
            this.radialGauge1.Anchor = ((System.Windows.Forms.AnchorStyles)(((( System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radialGauge1.ArcThickness = 2F;
            this.radialGauge1.BackgroundGradientEndColor = System.Drawing.Color.Transparent;
            this.radialGauge1.BackgroundGradientStartColor = System.Drawing.Color.Transparent;
            this.radialGauge1.EnableCustomNeedles = false;
            this.radialGauge1.FillColor = System.Drawing.Color.DarkGray;
            this.radialGauge1.FrameThickness = 12;
            this.radialGauge1.GaugeArcColor = System.Drawing.Color.DarkGray;
            this.radialGauge1.GaugeLabel = "Food";
            this.radialGauge1.GaugeLableFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge1.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge1.InnerFrameGradientEndColor = System.Drawing.Color.Transparent;
            this.radialGauge1.InnerFrameGradientStartColor = System.Drawing.Color.Transparent;
            this.radialGauge1.Location = new System.Drawing.Point(4, 4);
            this.radialGauge1.MajorDifference = 120F;
            this.radialGauge1.MajorTickMarkHeight = 0;
            this.radialGauge1.Margin = new System.Windows.Forms.Padding(4);
            this.radialGauge1.MaximumValue = 3000F;
            this.radialGauge1.MinimumSize = new System.Drawing.Size(125, 125);
            this.radialGauge1.MinorInnerLinesHeight = 0;
            this.radialGauge1.MinorTickMarkHeight = 0;
            this.radialGauge1.Name = "radialGauge1";
            this.radialGauge1.OuterFrameGradientEndColor = System.Drawing.Color.Transparent;
            this.radialGauge1.OuterFrameGradientStartColor = System.Drawing.Color.Transparent;
            range1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            range1.EndValue = 1100F;
            range1.Height = 7;
            range1.InRange = false;
            range1.Name = "GaugeRange1";
            range1.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range1.StartValue = 0F;
            this.radialGauge1.Ranges.Add(range1);
            this.radialGauge1.ShowGaugeValue = true;
            this.radialGauge1.ShowNeedle = false;
            this.radialGauge1.ShowScaleLabel = false;
            this.radialGauge1.ShowTicks = true;
            this.radialGauge1.Size = new System.Drawing.Size(403, 403);
            this.radialGauge1.TabIndex = 7;
            this.radialGauge1.Value = 2500F;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.flowLayoutPanel5, 3);
            this.flowLayoutPanel5.Controls.Add(this.label2);
            this.flowLayoutPanel5.Controls.Add(this.linearGauge1);
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(4, 534);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(1228, 158);
            this.flowLayoutPanel5.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1224, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Calories Burnt";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linearGauge1
            // 
            this.linearGauge1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linearGauge1.BackgroundGradientEndColor = System.Drawing.Color.Transparent;
            this.linearGauge1.BackgroundGradientStartColor = System.Drawing.Color.Transparent;
            this.linearGauge1.ForeColor = System.Drawing.Color.Gray;
            this.linearGauge1.GaugelabelFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linearGauge1.InnerFrameGradientEndColor = System.Drawing.Color.Transparent;
            this.linearGauge1.InnerFrameGradientStartColor = System.Drawing.Color.Transparent;
            this.linearGauge1.LinearFrameType = Syncfusion.Windows.Forms.Gauge.LinearFrameType.Horizontal;
            this.linearGauge1.Location = new System.Drawing.Point(3, 20);
            this.linearGauge1.MajorDifference = 100;
            this.linearGauge1.MajorTicksHeight = 0;
            this.linearGauge1.MaximumValue = 30000F;
            this.linearGauge1.MinimumSize = new System.Drawing.Size(100, 50);
            this.linearGauge1.MinorTickCount = 50;
            this.linearGauge1.MinorTickHeight = 0;
            this.linearGauge1.Name = "linearGauge1";
            this.linearGauge1.OuterFrameGradientEndColor = System.Drawing.Color.Transparent;
            this.linearGauge1.OuterFrameGradientStartColor = System.Drawing.Color.Transparent;
            this.linearGauge1.PointerPlacement = Syncfusion.Windows.Forms.Gauge.Placement.Center;
            linearRange1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            linearRange1.EndValue = 650F;
            linearRange1.Height = 5;
            linearRange1.InRange = false;
            linearRange1.Name = "GaugeRange1";
            linearRange1.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            linearRange1.StartValue = 0F;
            this.linearGauge1.Ranges.Add(linearRange1);
            this.linearGauge1.ScaleColor = System.Drawing.Color.Black;
            this.linearGauge1.ShowScaleLabel = false;
            this.linearGauge1.Size = new System.Drawing.Size(1224, 127);
            this.linearGauge1.TabIndex = 6;
            this.linearGauge1.Text = "linearGauge1";
            this.linearGauge1.Value = 25000F;
            this.linearGauge1.ValueIndicatorColor = System.Drawing.Color.Gray;
            // 
            // radialGauge2
            // 
            this.radialGauge2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radialGauge2.ArcThickness = 2F;
            this.radialGauge2.BackgroundGradientEndColor = System.Drawing.Color.Transparent;
            this.radialGauge2.BackgroundGradientStartColor = System.Drawing.Color.Transparent;
            this.radialGauge2.EnableCustomNeedles = false;
            this.radialGauge2.FillColor = System.Drawing.Color.DarkGray;
            this.radialGauge2.FrameThickness = 12;
            this.radialGauge2.GaugeLabel = "Steps";
            this.radialGauge2.GaugeLableFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge2.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge2.InnerFrameGradientEndColor = System.Drawing.Color.Transparent;
            this.radialGauge2.InnerFrameGradientStartColor = System.Drawing.Color.Transparent;
            this.radialGauge2.Location = new System.Drawing.Point(415, 4);
            this.radialGauge2.MajorTickMarkHeight = 0;
            this.radialGauge2.Margin = new System.Windows.Forms.Padding(4);
            this.radialGauge2.MaximumValue = 100F;
            this.radialGauge2.MinimumSize = new System.Drawing.Size(125, 125);
            this.radialGauge2.MinorInnerLinesHeight = 0;
            this.radialGauge2.MinorTickMarkHeight = 0;
            this.radialGauge2.Name = "radialGauge2";
            this.radialGauge2.OuterFrameGradientEndColor = System.Drawing.Color.Transparent;
            this.radialGauge2.OuterFrameGradientStartColor = System.Drawing.Color.Transparent;
            range2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            range2.EndValue = 50F;
            range2.Height = 7;
            range2.InRange = true;
            range2.Name = "GaugeRange1";
            range2.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range2.StartValue = 0F;
            this.radialGauge2.Ranges.Add(range2);
            this.radialGauge2.ShowBackgroundFrame = false;
            this.radialGauge2.ShowGaugeValue = true;
            this.radialGauge2.ShowNeedle = false;
            this.radialGauge2.ShowScaleLabel = false;
            this.radialGauge2.ShowTicks = true;
            this.radialGauge2.Size = new System.Drawing.Size(404, 404);
            this.radialGauge2.TabIndex = 8;
            this.radialGauge2.Value = 15F;
            // 
            // radialGauge3
            // 
            this.radialGauge3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radialGauge3.ArcThickness = 2F;
            this.radialGauge3.BackgroundGradientEndColor = System.Drawing.Color.Transparent;
            this.radialGauge3.BackgroundGradientStartColor = System.Drawing.Color.Transparent;
            this.radialGauge3.EnableCustomNeedles = false;
            this.radialGauge3.FillColor = System.Drawing.Color.DarkGray;
            this.radialGauge3.FrameThickness = 12;
            this.radialGauge3.GaugeLabel = "Floor";
            this.radialGauge3.GaugeLableFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge3.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge3.InnerFrameGradientEndColor = System.Drawing.Color.Transparent;
            this.radialGauge3.InnerFrameGradientStartColor = System.Drawing.Color.Transparent;
            this.radialGauge3.Location = new System.Drawing.Point(827, 4);
            this.radialGauge3.MajorDifference = 1F;
            this.radialGauge3.MajorTickMarkHeight = 0;
            this.radialGauge3.Margin = new System.Windows.Forms.Padding(4);
            this.radialGauge3.MaximumValue = 100F;
            this.radialGauge3.MinimumSize = new System.Drawing.Size(125, 125);
            this.radialGauge3.MinorInnerLinesHeight = 0;
            this.radialGauge3.MinorTickMarkHeight = 0;
            this.radialGauge3.Name = "radialGauge3";
            this.radialGauge3.OuterFrameGradientEndColor = System.Drawing.Color.Transparent;
            this.radialGauge3.OuterFrameGradientStartColor = System.Drawing.Color.Transparent;
            range3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            range3.EndValue = 5F;
            range3.Height = 7;
            range3.InRange = true;
            range3.Name = "GaugeRange1";
            range3.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range3.StartValue = 0F;
            this.radialGauge3.Ranges.Add(range3);
            this.radialGauge3.ShowBackgroundFrame = false;
            this.radialGauge3.ShowGaugeValue = true;
            this.radialGauge3.ShowNeedle = false;
            this.radialGauge3.ShowScaleLabel = false;
            this.radialGauge3.ShowTicks = true;
            this.radialGauge3.Size = new System.Drawing.Size(405, 405);
            this.radialGauge3.TabIndex = 9;
            this.radialGauge3.Value = 5F;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 976);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1261, 928);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Health Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Syncfusion.Windows.Forms.Gauge.LinearGauge linearGauge1;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge3;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge2;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

