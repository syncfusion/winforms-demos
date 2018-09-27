#region Copyright Syncfusion Inc. 2001 - 2014
// Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace LinearGaugeDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Syncfusion.Windows.Forms.Gauge.LinearRange linearRange1 = new Syncfusion.Windows.Forms.Gauge.LinearRange();
            Syncfusion.Windows.Forms.Gauge.LinearRange linearRange2 = new Syncfusion.Windows.Forms.Gauge.LinearRange();
            Syncfusion.Windows.Forms.Gauge.LinearRange linearRange3 = new Syncfusion.Windows.Forms.Gauge.LinearRange();
            Syncfusion.Windows.Forms.Gauge.LinearRange linearRange4 = new Syncfusion.Windows.Forms.Gauge.LinearRange();
            Syncfusion.Windows.Forms.Gauge.LinearRange linearRange5 = new Syncfusion.Windows.Forms.Gauge.LinearRange();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBar1 = new Syncfusion.Windows.Forms.Tools.GroupBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox5 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBox3 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.colorPickerUIAdv1 = new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel7 = new System.Windows.Forms.GroupBox();
            this.colorPickerButton1 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonAdv6 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv5 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAdv4 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBarItem1 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem4 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.linearGauge1 = new Syncfusion.Windows.Forms.Gauge.LinearGauge();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).BeginInit();
            this.groupBar1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(150)))), ((int)(((byte)(205)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sample describes the LinearGauge control with its basic features and options to c" +
                "ustomize its layout and appearance";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBar1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(409, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 453);
            this.panel1.TabIndex = 2;
            // 
            // groupBar1
            // 
            this.groupBar1.AllowDrop = true;
            this.groupBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBar1.BeforeTouchSize = new System.Drawing.Size(220, 409);
            this.groupBar1.BorderColor = System.Drawing.Color.White;
            this.groupBar1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupBar1.CollapseImage = ((System.Drawing.Image)(resources.GetObject("groupBar1.CollapseImage")));
            this.groupBar1.Controls.Add(this.panel3);
            this.groupBar1.Controls.Add(this.panel6);
            this.groupBar1.Controls.Add(this.panel5);
            this.groupBar1.Controls.Add(this.panel4);
            this.groupBar1.ExpandButtonToolTip = null;
            this.groupBar1.ExpandImage = ((System.Drawing.Image)(resources.GetObject("groupBar1.ExpandImage")));
            this.groupBar1.FlatLook = true;
            this.groupBar1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBar1.ForeColor = System.Drawing.Color.White;
            this.groupBar1.GroupBarDropDownToolTip = null;
            this.groupBar1.GroupBarItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupBarItem[] {
            this.groupBarItem1,
            this.groupBarItem4});
            this.groupBar1.IndexOnVisibleItems = true;
            this.groupBar1.Location = new System.Drawing.Point(32, 30);
            this.groupBar1.MinimizeButtonToolTip = null;
            this.groupBar1.Name = "groupBar1";
            this.groupBar1.NavigationPaneTooltip = null;
            this.groupBar1.PopupClientSize = new System.Drawing.Size(0, 0);
            this.groupBar1.SelectedItem = 0;
            this.groupBar1.Size = new System.Drawing.Size(220, 409);
            this.groupBar1.TabIndex = 0;
            this.groupBar1.Text = "Appearance";
            this.groupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.comboBox5);
            this.panel3.Controls.Add(this.comboBox3);
            this.panel3.Controls.Add(this.colorPickerUIAdv1);
            this.panel3.Location = new System.Drawing.Point(0, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 365);
            this.panel3.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical"});
            this.comboBox1.Location = new System.Drawing.Point(97, 333);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 23);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.Text = "Horizontal";
            this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "FrameType";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Visual Style";
            // 
            // comboBox5
            // 
            this.comboBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.Items.AddRange(new object[] {
            "GaugeBaseColor",
            "MajorTicksLineColor",
            "MinorTicksLineColor",
            "NeedleColor",
            "BackGroundStartColor",
            "BackGroundEndColor",
            "OuterFrameStartColor",
            "OuterFrameEndColor",
            "FrameBorderStartColor",
            "FrameBorderEndColor"});
            this.comboBox5.Location = new System.Drawing.Point(30, 13);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(155, 23);
            this.comboBox5.TabIndex = 14;
            this.comboBox5.Text = "Selecte Item";
            this.comboBox5.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.Items.AddRange(new object[] {
            "Blue",
            "Black",
            "Silver",
            "Metro",
            "Managed"});
            this.comboBox3.Location = new System.Drawing.Point(97, 291);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(97, 23);
            this.comboBox3.TabIndex = 17;
            this.comboBox3.Text = "Silver";
			this.comboBox3.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // colorPickerUIAdv1.RecentGroup
            // 
            this.colorPickerUIAdv1.RecentGroup.Name = "Recent Colors";
            this.colorPickerUIAdv1.RecentGroup.Visible = false;
            // 
            // colorPickerUIAdv1.StandardGroup
            // 
            this.colorPickerUIAdv1.StandardGroup.Name = "Standard Colors";
            // 
            // colorPickerUIAdv1.ThemeGroup
            // 
            this.colorPickerUIAdv1.ThemeGroup.IsSubItemsVisible = true;
            this.colorPickerUIAdv1.ThemeGroup.Name = "Theme Colors";
            // 
            // colorPickerUIAdv1
            // 
            this.colorPickerUIAdv1.BeforeTouchSize = new System.Drawing.Size(13, 13);
            this.colorPickerUIAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPickerUIAdv1.ColorItemSize = new System.Drawing.Size(13, 13);
            this.colorPickerUIAdv1.Location = new System.Drawing.Point(23, 50);
            this.colorPickerUIAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.colorPickerUIAdv1.MinimumSize = new System.Drawing.Size(136, 195);
            this.colorPickerUIAdv1.Name = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.colorPickerUIAdv1.Size = new System.Drawing.Size(172, 195);
            this.colorPickerUIAdv1.Style = Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.visualstyle.Metro;
            this.colorPickerUIAdv1.TabIndex = 1;
            this.colorPickerUIAdv1.Text = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.UseOffice2007Style = false;
            this.colorPickerUIAdv1.Picked += new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventHandler(this.colorPickerUIAdv1_Picked);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox3);
            this.panel6.Controls.Add(this.groupBox5);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.buttonAdv4);
            this.panel6.Controls.Add(this.buttonAdv3);
            this.panel6.Location = new System.Drawing.Point(0, 300);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(220, 0);
            this.panel6.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.trackBar1);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(17, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 70);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gauge Values";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(21, 21);
            this.trackBar1.Maximum = 120;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(150, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Value = 40;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.flowLayoutPanel1);
            this.groupBox5.Location = new System.Drawing.Point(11, 125);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.groupBox5.Size = new System.Drawing.Size(200, 211);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Select Range to modify";
            this.groupBox5.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(194, 183);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.colorPickerButton1);
            this.panel7.Controls.Add(this.textBox3);
            this.panel7.Controls.Add(this.textBox2);
            this.panel7.Controls.Add(this.buttonAdv6);
            this.panel7.Controls.Add(this.buttonAdv5);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.ForeColor = System.Drawing.Color.DimGray;
            this.panel7.Location = new System.Drawing.Point(17, 138);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(185, 180);
            this.panel7.TabIndex = 2;
            this.panel7.TabStop = false;
            this.panel7.Text = "Add Range";
            this.panel7.Visible = false;
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.colorPickerButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(150)))), ((int)(((byte)(205)))));
            this.colorPickerButton1.BeforeTouchSize = new System.Drawing.Size(128, 23);
            this.colorPickerButton1.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton1.ForeColor = System.Drawing.Color.White;
            this.colorPickerButton1.IsBackStageButton = false;
            this.colorPickerButton1.Location = new System.Drawing.Point(104, 105);
            this.colorPickerButton1.Name = "colorPickerButton1";
            this.colorPickerButton1.SelectedAsText = true;
            this.colorPickerButton1.Size = new System.Drawing.Size(51, 23);
            this.colorPickerButton1.TabIndex = 8;
            this.colorPickerButton1.Text = "Empty";
            this.colorPickerButton1.EnableTouchMode = false;
            this.colorPickerButton1.UseVisualStyle = true;
            this.colorPickerButton1.ColorSelected += new System.EventHandler(this.colorPickerButton1_ColorSelected);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(104, 52);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(51, 23);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(51, 23);
            this.textBox2.TabIndex = 5;
            // 
            // buttonAdv6
            // 
            this.buttonAdv6.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv6.BackColor = System.Drawing.Color.Gray;
            this.buttonAdv6.BeforeTouchSize = new System.Drawing.Size(128, 23);
            this.buttonAdv6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv6.ForeColor = System.Drawing.Color.White;
            this.buttonAdv6.IsBackStageButton = false;
            this.buttonAdv6.Location = new System.Drawing.Point(104, 143);
            this.buttonAdv6.Name = "buttonAdv6";
            this.buttonAdv6.Size = new System.Drawing.Size(51, 23);
            this.buttonAdv6.TabIndex = 4;
            this.buttonAdv6.Text = "Cancel";
            this.buttonAdv6.UseVisualStyle = true;
            this.buttonAdv6.Click += new System.EventHandler(this.buttonAdv6_Click);
            // 
            // buttonAdv5
            // 
            this.buttonAdv5.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv5.BackColor = System.Drawing.Color.Gray;
            this.buttonAdv5.BeforeTouchSize = new System.Drawing.Size(128, 23);
            this.buttonAdv5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv5.ForeColor = System.Drawing.Color.White;
            this.buttonAdv5.IsBackStageButton = false;
            this.buttonAdv5.Location = new System.Drawing.Point(32, 144);
            this.buttonAdv5.Name = "buttonAdv5";
            this.buttonAdv5.Size = new System.Drawing.Size(51, 23);
            this.buttonAdv5.TabIndex = 2;
            this.buttonAdv5.Text = "Add";
            this.buttonAdv5.UseVisualStyle = true;
            this.buttonAdv5.Click += new System.EventHandler(this.buttonAdv5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(20, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(20, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "End Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(20, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Start Value";
            // 
            // buttonAdv4
            // 
            this.buttonAdv4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv4.BackColor = System.Drawing.Color.Gray;
            this.buttonAdv4.BeforeTouchSize = new System.Drawing.Size(128, 23);
            this.buttonAdv4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv4.ForeColor = System.Drawing.Color.White;
            this.buttonAdv4.IsBackStageButton = false;
            this.buttonAdv4.Location = new System.Drawing.Point(48, 193);
            this.buttonAdv4.Name = "buttonAdv4";
            this.buttonAdv4.Size = new System.Drawing.Size(128, 23);
            this.buttonAdv4.TabIndex = 1;
            this.buttonAdv4.Text = "Clear Ranges";
            this.buttonAdv4.UseVisualStyle = true;
            this.buttonAdv4.Click += new System.EventHandler(this.buttonAdv4_Click);
            // 
            // buttonAdv3
            // 
            this.buttonAdv3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv3.BackColor = System.Drawing.Color.Gray;
            this.buttonAdv3.BeforeTouchSize = new System.Drawing.Size(128, 23);
            this.buttonAdv3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv3.ForeColor = System.Drawing.Color.White;
            this.buttonAdv3.IsBackStageButton = false;
            this.buttonAdv3.Location = new System.Drawing.Point(48, 154);
            this.buttonAdv3.Name = "buttonAdv3";
            this.buttonAdv3.Size = new System.Drawing.Size(128, 23);
            this.buttonAdv3.TabIndex = 0;
            this.buttonAdv3.Text = "New Range";
            this.buttonAdv3.UseVisualStyle = true;
            this.buttonAdv3.Click += new System.EventHandler(this.buttonAdv3_Click);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 66);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(220, 321);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 0);
            this.panel4.TabIndex = 1;
            // 
            // groupBarItem1
            // 
            this.groupBarItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBarItem1.Client = this.panel3;
            this.groupBarItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBarItem1.Text = "Appearance";
            // 
            // groupBarItem4
            // 
            this.groupBarItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBarItem4.Client = this.panel6;
            this.groupBarItem4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBarItem4.Text = "Ranges";
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 451);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Properties";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(104, 78);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(51, 20);
            this.textBox4.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 453);
            this.panel2.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.linearGauge1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(407, 451);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Linear Gauge";
            // 
            // linearGauge1
            // 
            this.linearGauge1.ForeColor = System.Drawing.Color.Gray;
            this.linearGauge1.GaugelabelFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linearGauge1.LinearFrameType = Syncfusion.Windows.Forms.Gauge.LinearFrameType.Horizontal;
            this.linearGauge1.Location = new System.Drawing.Point(65, 109);
            this.linearGauge1.MajorTicksHeight = 15;
            this.linearGauge1.MinimumSize = new System.Drawing.Size(300, 125);
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
            this.linearGauge1.Size = new System.Drawing.Size(300, 128);
            this.linearGauge1.TabIndex = 0;
            this.linearGauge1.Text = "linearGauge1";
            this.linearGauge1.Value = 40F;
            this.linearGauge1.ValueIndicatorColor = System.Drawing.Color.Gray;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.White;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.ClientSize = new System.Drawing.Size(682, 484);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(694, 520);
            this.Name = "Form1";
            this.Text = "LinearGauge Demo";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).EndInit();
            this.groupBar1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Syncfusion.Windows.Forms.Tools.GroupBar groupBar1;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBox3;
        private System.Windows.Forms.Panel panel3;
        private Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv colorPickerUIAdv1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox4;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem4;
        private System.Windows.Forms.Panel panel6;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv4;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv3;
        private System.Windows.Forms.GroupBox panel7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv6;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBox5;
        private Syncfusion.Windows.Forms.Gauge.LinearGauge linearGauge1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBox1;
        private System.Windows.Forms.Label label2;
    }
}

