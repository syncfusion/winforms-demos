#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace UnitConverterDemo
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.basePanel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.temperatureButton = new Syncfusion.WinForms.Controls.SfButton();
            this.currencyButton = new Syncfusion.WinForms.Controls.SfButton();
            this.currencyPanel = new System.Windows.Forms.Panel();
            this.saNumericTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.usNumericTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.brNumericTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.germanNumericTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.turkeyTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.japanNumericTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.chNumericTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.indNumericTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.temperaturePanel = new System.Windows.Forms.Panel();
            this.celNumericTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.celsiusAutoLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.kelNumericTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.rankineAutoLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.ranNumericTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.farNumericTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.fahrenheitAutoLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.kelvinAutoLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.labelpanel = new System.Windows.Forms.Panel();
            this.unitLabel = new System.Windows.Forms.Label();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.basePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.currencyPanel.SuspendLayout();
            this.temperaturePanel.SuspendLayout();
            this.labelpanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // basePanel
            // 
            this.basePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.basePanel.Controls.Add(this.splitContainer1);
            this.basePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basePanel.Location = new System.Drawing.Point(2, 118);
            this.basePanel.Margin = new System.Windows.Forms.Padding(0);
            this.basePanel.Name = "basePanel";
            this.basePanel.Size = new System.Drawing.Size(1131, 641);
            this.basePanel.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(158)))), ((int)(((byte)(67)))));
            this.splitContainer1.BeforeTouchSize = 2;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = Syncfusion.Windows.Forms.Tools.Enums.FixedPanel.Panel1;
            this.splitContainer1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.temperatureButton);
            this.splitContainer1.Panel1.Controls.Add(this.currencyButton);
            this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.splitContainer1.Panel2.Controls.Add(this.currencyPanel);
            this.splitContainer1.Panel2.Controls.Add(this.temperaturePanel);
            this.splitContainer1.Size = new System.Drawing.Size(1129, 639);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 2;
            this.splitContainer1.ThemeName = "None";
            // 
            // temperatureButton
            // 
            this.temperatureButton.AccessibleName = "Button";
            this.temperatureButton.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.temperatureButton.Location = new System.Drawing.Point(-1, 57);
            this.temperatureButton.Name = "temperatureButton";
            this.temperatureButton.Size = new System.Drawing.Size(221, 57);
            this.temperatureButton.Style.BackColor = System.Drawing.Color.White;
            this.temperatureButton.Style.ForeColor = System.Drawing.Color.Black;
            this.temperatureButton.Style.HoverBackColor = System.Drawing.Color.White;
            this.temperatureButton.Style.HoverForeColor = System.Drawing.Color.Black;
            this.temperatureButton.Style.PressedBackColor = System.Drawing.Color.White;
            this.temperatureButton.TabIndex = 3;
            this.temperatureButton.TabStop = false;
            this.temperatureButton.Text = "Temperature";
            this.temperatureButton.Click += new System.EventHandler(this.UnitButton_Click);
            // 
            // currencyButton
            // 
            this.currencyButton.AccessibleName = "Button";
            this.currencyButton.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.currencyButton.Location = new System.Drawing.Point(-1, 0);
            this.currencyButton.Name = "currencyButton";
            this.currencyButton.Size = new System.Drawing.Size(221, 57);
            this.currencyButton.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.currencyButton.Style.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.currencyButton.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.currencyButton.Style.ForeColor = System.Drawing.Color.White;
            this.currencyButton.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.currencyButton.Style.HoverForeColor = System.Drawing.Color.White;
            this.currencyButton.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.currencyButton.Style.PressedForeColor = System.Drawing.Color.White;
            this.currencyButton.TabIndex = 2;
            this.currencyButton.TabStop = false;
            this.currencyButton.Text = "Currency";
            this.currencyButton.Click += new System.EventHandler(this.UnitButton_Click);
            // 
            // currencyPanel
            // 
            this.currencyPanel.Controls.Add(this.tableLayoutPanel1);
            this.currencyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currencyPanel.Location = new System.Drawing.Point(0, 0);
            this.currencyPanel.Name = "currencyPanel";
            this.currencyPanel.Size = new System.Drawing.Size(907, 639);
            this.currencyPanel.TabIndex = 22;
            // 
            // saNumericTextBox
            // 
            this.saNumericTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saNumericTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saNumericTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.saNumericTextBox.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            this.saNumericTextBox.Location = new System.Drawing.Point(3, 39);
            this.saNumericTextBox.MinValue = 0D;
            this.saNumericTextBox.Name = "saNumericTextBox";
            this.saNumericTextBox.Size = new System.Drawing.Size(296, 50);
            this.saNumericTextBox.TabIndex = 23;
            this.saNumericTextBox.Text = "$0.00";
            this.saNumericTextBox.ValidationMode = Syncfusion.WinForms.Input.Enums.ValidationMode.KeyPress;
            this.saNumericTextBox.ValueChangeMode = Syncfusion.WinForms.Input.Enums.ValueChangeMode.KeyPress;
            // 
            // usNumericTextBox
            // 
            this.usNumericTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usNumericTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usNumericTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.usNumericTextBox.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            this.usNumericTextBox.Location = new System.Drawing.Point(3, 39);
            this.usNumericTextBox.MinValue = 0D;
            this.usNumericTextBox.Name = "usNumericTextBox";
            this.usNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usNumericTextBox.Size = new System.Drawing.Size(296, 50);
            this.usNumericTextBox.TabIndex = 16;
            this.usNumericTextBox.Text = "$0.00";
            this.usNumericTextBox.ValidationMode = Syncfusion.WinForms.Input.Enums.ValidationMode.KeyPress;
            this.usNumericTextBox.ValueChangeMode = Syncfusion.WinForms.Input.Enums.ValueChangeMode.KeyPress;
            this.usNumericTextBox.WatermarkText = "";
            this.usNumericTextBox.ValueChanged += new Syncfusion.WinForms.Input.ValueChangedEventHandler(this.CurrencyValueChanged);
            // 
            // brNumericTextBox
            // 
            this.brNumericTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.brNumericTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brNumericTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.brNumericTextBox.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            this.brNumericTextBox.Location = new System.Drawing.Point(3, 39);
            this.brNumericTextBox.MinValue = 0D;
            this.brNumericTextBox.Name = "brNumericTextBox";
            this.brNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.brNumericTextBox.Size = new System.Drawing.Size(296, 50);
            this.brNumericTextBox.TabIndex = 22;
            this.brNumericTextBox.Text = "$0.00";
            this.brNumericTextBox.ValidationMode = Syncfusion.WinForms.Input.Enums.ValidationMode.KeyPress;
            this.brNumericTextBox.ValueChangeMode = Syncfusion.WinForms.Input.Enums.ValueChangeMode.KeyPress;
            this.brNumericTextBox.ValueChanged += new Syncfusion.WinForms.Input.ValueChangedEventHandler(this.CurrencyValueChanged);
            // 
            // germanNumericTextBox
            // 
            this.germanNumericTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.germanNumericTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.germanNumericTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.germanNumericTextBox.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            this.germanNumericTextBox.Location = new System.Drawing.Point(3, 39);
            this.germanNumericTextBox.MinValue = 0D;
            this.germanNumericTextBox.Name = "germanNumericTextBox";
            this.germanNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.germanNumericTextBox.Size = new System.Drawing.Size(296, 50);
            this.germanNumericTextBox.TabIndex = 21;
            this.germanNumericTextBox.Text = "$0.00";
            this.germanNumericTextBox.ValidationMode = Syncfusion.WinForms.Input.Enums.ValidationMode.KeyPress;
            this.germanNumericTextBox.ValueChangeMode = Syncfusion.WinForms.Input.Enums.ValueChangeMode.KeyPress;
            this.germanNumericTextBox.ValueChanged += new Syncfusion.WinForms.Input.ValueChangedEventHandler(this.CurrencyValueChanged);
            // 
            // turkeyTextBox
            // 
            this.turkeyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.turkeyTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turkeyTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.turkeyTextBox.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            this.turkeyTextBox.Location = new System.Drawing.Point(3, 39);
            this.turkeyTextBox.MinValue = 0D;
            this.turkeyTextBox.Name = "turkeyTextBox";
            this.turkeyTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.turkeyTextBox.Size = new System.Drawing.Size(296, 50);
            this.turkeyTextBox.TabIndex = 17;
            this.turkeyTextBox.Text = "$0.00";
            this.turkeyTextBox.ValidationMode = Syncfusion.WinForms.Input.Enums.ValidationMode.KeyPress;
            this.turkeyTextBox.ValueChangeMode = Syncfusion.WinForms.Input.Enums.ValueChangeMode.KeyPress;
            this.turkeyTextBox.ValueChanged += new Syncfusion.WinForms.Input.ValueChangedEventHandler(this.CurrencyValueChanged);
            // 
            // japanNumericTextBox
            // 
            this.japanNumericTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.japanNumericTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.japanNumericTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.japanNumericTextBox.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            this.japanNumericTextBox.Location = new System.Drawing.Point(3, 39);
            this.japanNumericTextBox.MinValue = 0D;
            this.japanNumericTextBox.Name = "japanNumericTextBox";
            this.japanNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.japanNumericTextBox.Size = new System.Drawing.Size(296, 50);
            this.japanNumericTextBox.TabIndex = 20;
            this.japanNumericTextBox.Text = "$0.00";
            this.japanNumericTextBox.ValidationMode = Syncfusion.WinForms.Input.Enums.ValidationMode.KeyPress;
            this.japanNumericTextBox.ValueChangeMode = Syncfusion.WinForms.Input.Enums.ValueChangeMode.KeyPress;
            this.japanNumericTextBox.ValueChanged += new Syncfusion.WinForms.Input.ValueChangedEventHandler(this.CurrencyValueChanged);
            // 
            // chNumericTextBox
            // 
            this.chNumericTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chNumericTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chNumericTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.chNumericTextBox.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            this.chNumericTextBox.Location = new System.Drawing.Point(3, 39);
            this.chNumericTextBox.MinValue = 0D;
            this.chNumericTextBox.Name = "chNumericTextBox";
            this.chNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chNumericTextBox.Size = new System.Drawing.Size(296, 50);
            this.chNumericTextBox.TabIndex = 18;
            this.chNumericTextBox.Text = "$0.00";
            this.chNumericTextBox.ValidationMode = Syncfusion.WinForms.Input.Enums.ValidationMode.KeyPress;
            this.chNumericTextBox.ValueChangeMode = Syncfusion.WinForms.Input.Enums.ValueChangeMode.KeyPress;
            this.chNumericTextBox.ValueChanged += new Syncfusion.WinForms.Input.ValueChangedEventHandler(this.CurrencyValueChanged);
            // 
            // indNumericTextBox
            // 
            this.indNumericTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.indNumericTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indNumericTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.indNumericTextBox.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            this.indNumericTextBox.Location = new System.Drawing.Point(5, 68);
            this.indNumericTextBox.MinValue = 0D;
            this.indNumericTextBox.Name = "indNumericTextBox";
            this.indNumericTextBox.Size = new System.Drawing.Size(296, 50);
            this.indNumericTextBox.TabIndex = 19;
            this.indNumericTextBox.Text = "$0.00";
            this.indNumericTextBox.ValidationMode = Syncfusion.WinForms.Input.Enums.ValidationMode.KeyPress;
            this.indNumericTextBox.ValueChangeMode = Syncfusion.WinForms.Input.Enums.ValueChangeMode.KeyPress;
            this.indNumericTextBox.ValueChanged += new Syncfusion.WinForms.Input.ValueChangedEventHandler(this.CurrencyValueChanged);
            // 
            // temperaturePanel
            // 
            this.temperaturePanel.Controls.Add(this.celNumericTextBox);
            this.temperaturePanel.Controls.Add(this.celsiusAutoLabel);
            this.temperaturePanel.Controls.Add(this.kelNumericTextBox);
            this.temperaturePanel.Controls.Add(this.rankineAutoLabel);
            this.temperaturePanel.Controls.Add(this.farNumericTextBox);
            this.temperaturePanel.Controls.Add(this.fahrenheitAutoLabel);
            this.temperaturePanel.Controls.Add(this.ranNumericTextBox);
            this.temperaturePanel.Controls.Add(this.kelvinAutoLabel);
            this.temperaturePanel.Location = new System.Drawing.Point(4, 5);
            this.temperaturePanel.Name = "temperaturePanel";
            this.temperaturePanel.Size = new System.Drawing.Size(840, 365);
            this.temperaturePanel.TabIndex = 21;
            this.temperaturePanel.Visible = false;
            // 
            // celNumericTextBox
            // 
            this.celNumericTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.celNumericTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celNumericTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.celNumericTextBox.Location = new System.Drawing.Point(54, 83);
            this.celNumericTextBox.Name = "celNumericTextBox";
            this.celNumericTextBox.Size = new System.Drawing.Size(296, 50);
            this.celNumericTextBox.Suffix = "ºC";
            this.celNumericTextBox.TabIndex = 13;
            this.celNumericTextBox.Text = "0.00 ºC";
            this.celNumericTextBox.ValidationMode = Syncfusion.WinForms.Input.Enums.ValidationMode.KeyPress;
            this.celNumericTextBox.ValueChangeMode = Syncfusion.WinForms.Input.Enums.ValueChangeMode.KeyPress;
            this.celNumericTextBox.ValueChanged += new Syncfusion.WinForms.Input.ValueChangedEventHandler(this.TemperatureValueChanged);
            // 
            // celsiusAutoLabel
            // 
            this.celsiusAutoLabel.DX = -5;
            this.celsiusAutoLabel.DY = -35;
            this.celsiusAutoLabel.LabeledControl = this.celNumericTextBox;
            this.celsiusAutoLabel.Location = new System.Drawing.Point(49, 48);
            this.celsiusAutoLabel.Name = "celsiusAutoLabel";
            this.celsiusAutoLabel.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.celsiusAutoLabel.Size = new System.Drawing.Size(144, 36);
            this.celsiusAutoLabel.TabIndex = 18;
            this.celsiusAutoLabel.Text = "Celsius (ºC)";
            // 
            // kelNumericTextBox
            // 
            this.kelNumericTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kelNumericTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kelNumericTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.kelNumericTextBox.Location = new System.Drawing.Point(474, 82);
            this.kelNumericTextBox.Name = "kelNumericTextBox";
            this.kelNumericTextBox.Size = new System.Drawing.Size(296, 50);
            this.kelNumericTextBox.Suffix = "K";
            this.kelNumericTextBox.TabIndex = 15;
            this.kelNumericTextBox.Text = "0.00 K";
            this.kelNumericTextBox.ValidationMode = Syncfusion.WinForms.Input.Enums.ValidationMode.KeyPress;
            this.kelNumericTextBox.ValueChangeMode = Syncfusion.WinForms.Input.Enums.ValueChangeMode.KeyPress;
            this.kelNumericTextBox.ValueChanged += new Syncfusion.WinForms.Input.ValueChangedEventHandler(this.TemperatureValueChanged);
            // 
            // rankineAutoLabel
            // 
            this.rankineAutoLabel.DX = -5;
            this.rankineAutoLabel.DY = -35;
            this.rankineAutoLabel.LabeledControl = this.ranNumericTextBox;
            this.rankineAutoLabel.Location = new System.Drawing.Point(469, 156);
            this.rankineAutoLabel.Name = "rankineAutoLabel";
            this.rankineAutoLabel.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.rankineAutoLabel.Size = new System.Drawing.Size(150, 36);
            this.rankineAutoLabel.TabIndex = 20;
            this.rankineAutoLabel.Text = "Rankine(ºR)";
            // 
            // ranNumericTextBox
            // 
            this.ranNumericTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ranNumericTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ranNumericTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ranNumericTextBox.Location = new System.Drawing.Point(474, 191);
            this.ranNumericTextBox.Name = "ranNumericTextBox";
            this.ranNumericTextBox.Size = new System.Drawing.Size(296, 50);
            this.ranNumericTextBox.Suffix = "ºR";
            this.ranNumericTextBox.TabIndex = 16;
            this.ranNumericTextBox.Text = "0.00 ºR";
            this.ranNumericTextBox.ValidationMode = Syncfusion.WinForms.Input.Enums.ValidationMode.KeyPress;
            this.ranNumericTextBox.ValueChangeMode = Syncfusion.WinForms.Input.Enums.ValueChangeMode.KeyPress;
            this.ranNumericTextBox.ValueChanged += new Syncfusion.WinForms.Input.ValueChangedEventHandler(this.TemperatureValueChanged);
            // 
            // farNumericTextBox
            // 
            this.farNumericTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.farNumericTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.farNumericTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.farNumericTextBox.Location = new System.Drawing.Point(54, 191);
            this.farNumericTextBox.Name = "farNumericTextBox";
            this.farNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.farNumericTextBox.Size = new System.Drawing.Size(296, 50);
            this.farNumericTextBox.Suffix = "ºF";
            this.farNumericTextBox.TabIndex = 14;
            this.farNumericTextBox.Text = "0.00 ºF";
            this.farNumericTextBox.ValidationMode = Syncfusion.WinForms.Input.Enums.ValidationMode.KeyPress;
            this.farNumericTextBox.ValueChangeMode = Syncfusion.WinForms.Input.Enums.ValueChangeMode.KeyPress;
            this.farNumericTextBox.ValueChanged += new Syncfusion.WinForms.Input.ValueChangedEventHandler(this.TemperatureValueChanged);
            // 
            // fahrenheitAutoLabel
            // 
            this.fahrenheitAutoLabel.DX = -5;
            this.fahrenheitAutoLabel.DY = -35;
            this.fahrenheitAutoLabel.LabeledControl = this.farNumericTextBox;
            this.fahrenheitAutoLabel.Location = new System.Drawing.Point(49, 156);
            this.fahrenheitAutoLabel.Name = "fahrenheitAutoLabel";
            this.fahrenheitAutoLabel.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.fahrenheitAutoLabel.Size = new System.Drawing.Size(187, 36);
            this.fahrenheitAutoLabel.TabIndex = 19;
            this.fahrenheitAutoLabel.Text = "Fahrenheit (ºC)";
            // 
            // kelvinAutoLabel
            // 
            this.kelvinAutoLabel.DX = -5;
            this.kelvinAutoLabel.DY = -35;
            this.kelvinAutoLabel.LabeledControl = this.kelNumericTextBox;
            this.kelvinAutoLabel.Location = new System.Drawing.Point(469, 47);
            this.kelvinAutoLabel.Name = "kelvinAutoLabel";
            this.kelvinAutoLabel.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.kelvinAutoLabel.Size = new System.Drawing.Size(121, 36);
            this.kelvinAutoLabel.TabIndex = 17;
            this.kelvinAutoLabel.Text = "Kelvin (K)";
            // 
            // labelpanel
            // 
            this.labelpanel.AutoSize = true;
            this.labelpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.labelpanel.Controls.Add(this.unitLabel);
            this.labelpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelpanel.Location = new System.Drawing.Point(2, 2);
            this.labelpanel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.labelpanel.Name = "labelpanel";
            this.labelpanel.Padding = new System.Windows.Forms.Padding(5);
            this.labelpanel.Size = new System.Drawing.Size(1131, 86);
            this.labelpanel.TabIndex = 2;
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitLabel.ForeColor = System.Drawing.Color.White;
            this.unitLabel.Location = new System.Drawing.Point(9, 7);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(392, 74);
            this.unitLabel.TabIndex = 0;
            this.unitLabel.Text = "Unit Converter";
            this.unitLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // imagePanel
            // 
            this.imagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.imagePanel.BackgroundImage = global::UnitConverterDemo.Properties.Resources.unit;
            this.imagePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.imagePanel.Location = new System.Drawing.Point(2, 88);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(1131, 30);
            this.imagePanel.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(907, 639);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.usNumericTextBox);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(28, 33);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(435, 92);
            this.flowLayoutPanel1.TabIndex = 33;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.turkeyTextBox);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(28, 192);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(435, 92);
            this.flowLayoutPanel2.TabIndex = 34;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Controls.Add(this.label7);
            this.flowLayoutPanel4.Controls.Add(this.indNumericTextBox);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(28, 512);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(435, 92);
            this.flowLayoutPanel4.TabIndex = 36;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.Controls.Add(this.label8);
            this.flowLayoutPanel5.Controls.Add(this.saNumericTextBox);
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(469, 512);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(435, 92);
            this.flowLayoutPanel5.TabIndex = 37;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.Controls.Add(this.label6);
            this.flowLayoutPanel6.Controls.Add(this.brNumericTextBox);
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(469, 351);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(435, 92);
            this.flowLayoutPanel6.TabIndex = 38;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel7.AutoSize = true;
            this.flowLayoutPanel7.Controls.Add(this.label5);
            this.flowLayoutPanel7.Controls.Add(this.germanNumericTextBox);
            this.flowLayoutPanel7.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(469, 192);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(435, 92);
            this.flowLayoutPanel7.TabIndex = 39;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel8.AutoSize = true;
            this.flowLayoutPanel8.Controls.Add(this.label4);
            this.flowLayoutPanel8.Controls.Add(this.japanNumericTextBox);
            this.flowLayoutPanel8.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel8.Location = new System.Drawing.Point(469, 33);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(435, 92);
            this.flowLayoutPanel8.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "US Dollar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Turkey Lira";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chinese Yuan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Japanese Yen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "German Euro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 36);
            this.label6.TabIndex = 4;
            this.label6.Text = "Britian pounds";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 36);
            this.label7.TabIndex = 4;
            this.label7.Text = "Indian Rupee";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 36);
            this.label8.TabIndex = 4;
            this.label8.Text = "South African Rand";
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel9.AutoSize = true;
            this.flowLayoutPanel9.Controls.Add(this.label3);
            this.flowLayoutPanel9.Controls.Add(this.chNumericTextBox);
            this.flowLayoutPanel9.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel9.Location = new System.Drawing.Point(28, 351);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(435, 92);
            this.flowLayoutPanel9.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 761);
            this.Controls.Add(this.basePanel);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.labelpanel);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.basePanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.currencyPanel.ResumeLayout(false);
            this.temperaturePanel.ResumeLayout(false);
            this.temperaturePanel.PerformLayout();
            this.labelpanel.ResumeLayout(false);
            this.labelpanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion
        private System.Windows.Forms.Panel basePanel;
        private System.Windows.Forms.Panel labelpanel;
        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.Label unitLabel;
        private Syncfusion.Windows.Forms.Tools.SplitContainerAdv splitContainer1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel rankineAutoLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox ranNumericTextBox;
        private Syncfusion.Windows.Forms.Tools.AutoLabel fahrenheitAutoLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox farNumericTextBox;
        private Syncfusion.Windows.Forms.Tools.AutoLabel celsiusAutoLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox celNumericTextBox;
        private Syncfusion.Windows.Forms.Tools.AutoLabel kelvinAutoLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox kelNumericTextBox;
        private System.Windows.Forms.Panel currencyPanel;
        private Syncfusion.WinForms.Input.SfNumericTextBox saNumericTextBox;
        private Syncfusion.WinForms.Input.SfNumericTextBox usNumericTextBox;
        private Syncfusion.WinForms.Input.SfNumericTextBox brNumericTextBox;
        private Syncfusion.WinForms.Input.SfNumericTextBox germanNumericTextBox;
        private Syncfusion.WinForms.Input.SfNumericTextBox turkeyTextBox;
        private Syncfusion.WinForms.Input.SfNumericTextBox japanNumericTextBox;
        private Syncfusion.WinForms.Input.SfNumericTextBox chNumericTextBox;
        private Syncfusion.WinForms.Input.SfNumericTextBox indNumericTextBox;
        private System.Windows.Forms.Panel temperaturePanel;
        private Syncfusion.WinForms.Controls.SfButton temperatureButton;
        private Syncfusion.WinForms.Controls.SfButton currencyButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
    }
}

