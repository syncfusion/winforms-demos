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
            this.saAutoLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.saNumericTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.usAutoLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.usNumericTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.britianAutoLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.brNumericTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.germanAutoLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.germanNumericTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.turkeyTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.japanAutoLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.japanNumericTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.chNumericTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.indiaAutoLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.indNumericTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.chineseAutoLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.turkeyLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
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
            this.basePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.currencyPanel.SuspendLayout();
            this.temperaturePanel.SuspendLayout();
            this.labelpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // basePanel
            // 
            this.basePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.basePanel.Controls.Add(this.splitContainer1);
            this.basePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basePanel.Location = new System.Drawing.Point(0, 85);
            this.basePanel.Margin = new System.Windows.Forms.Padding(0);
            this.basePanel.Name = "basePanel";
            this.basePanel.Size = new System.Drawing.Size(1092, 601);
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
            this.splitContainer1.Size = new System.Drawing.Size(1090, 599);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 2;
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
            this.currencyPanel.Controls.Add(this.saAutoLabel);
            this.currencyPanel.Controls.Add(this.usAutoLabel);
            this.currencyPanel.Controls.Add(this.britianAutoLabel);
            this.currencyPanel.Controls.Add(this.usNumericTextBox);
            this.currencyPanel.Controls.Add(this.germanAutoLabel);
            this.currencyPanel.Controls.Add(this.turkeyTextBox);
            this.currencyPanel.Controls.Add(this.japanAutoLabel);
            this.currencyPanel.Controls.Add(this.chNumericTextBox);
            this.currencyPanel.Controls.Add(this.indiaAutoLabel);
            this.currencyPanel.Controls.Add(this.indNumericTextBox);
            this.currencyPanel.Controls.Add(this.chineseAutoLabel);
            this.currencyPanel.Controls.Add(this.japanNumericTextBox);
            this.currencyPanel.Controls.Add(this.turkeyLabel);
            this.currencyPanel.Controls.Add(this.germanNumericTextBox);
            this.currencyPanel.Controls.Add(this.brNumericTextBox);
            this.currencyPanel.Controls.Add(this.saNumericTextBox);
            this.currencyPanel.Location = new System.Drawing.Point(4, 5);
            this.currencyPanel.Name = "currencyPanel";
            this.currencyPanel.Size = new System.Drawing.Size(808, 578);
            this.currencyPanel.TabIndex = 22;
            // 
            // saAutoLabel
            // 
            this.saAutoLabel.DX = -5;
            this.saAutoLabel.DY = -35;
            this.saAutoLabel.LabeledControl = this.saNumericTextBox;
            this.saAutoLabel.Location = new System.Drawing.Point(469, 387);
            this.saAutoLabel.Name = "saAutoLabel";
            this.saAutoLabel.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.saAutoLabel.Size = new System.Drawing.Size(136, 20);
            this.saAutoLabel.TabIndex = 31;
            this.saAutoLabel.Text = "South African Rand";
            // 
            // saNumericTextBox
            // 
            this.saNumericTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saNumericTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saNumericTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.saNumericTextBox.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            this.saNumericTextBox.Location = new System.Drawing.Point(474, 422);
            this.saNumericTextBox.MinValue = 0D;
            this.saNumericTextBox.Name = "saNumericTextBox";
            this.saNumericTextBox.Size = new System.Drawing.Size(296, 32);
            this.saNumericTextBox.TabIndex = 23;
            this.saNumericTextBox.Text = "$0.00";
            this.saNumericTextBox.ValidationMode = Syncfusion.WinForms.Input.Enums.ValidationMode.KeyPress;
            this.saNumericTextBox.ValueChangeMode = Syncfusion.WinForms.Input.Enums.ValueChangeMode.KeyPress;
            // 
            // usAutoLabel
            // 
            this.usAutoLabel.DX = -5;
            this.usAutoLabel.DY = -35;
            this.usAutoLabel.LabeledControl = this.usNumericTextBox;
            this.usAutoLabel.Location = new System.Drawing.Point(49, 48);
            this.usAutoLabel.Name = "usAutoLabel";
            this.usAutoLabel.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.usAutoLabel.Size = new System.Drawing.Size(72, 20);
            this.usAutoLabel.TabIndex = 24;
            this.usAutoLabel.Text = "US Dollar";
            // 
            // usNumericTextBox
            // 
            this.usNumericTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usNumericTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usNumericTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.usNumericTextBox.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            this.usNumericTextBox.Location = new System.Drawing.Point(54, 83);
            this.usNumericTextBox.MinValue = 0D;
            this.usNumericTextBox.Name = "usNumericTextBox";
            this.usNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usNumericTextBox.Size = new System.Drawing.Size(296, 32);
            this.usNumericTextBox.TabIndex = 16;
            this.usNumericTextBox.Text = "$0.00";
            this.usNumericTextBox.ValidationMode = Syncfusion.WinForms.Input.Enums.ValidationMode.KeyPress;
            this.usNumericTextBox.ValueChangeMode = Syncfusion.WinForms.Input.Enums.ValueChangeMode.KeyPress;
            this.usNumericTextBox.WatermarkText = "";
            this.usNumericTextBox.ValueChanged += new Syncfusion.WinForms.Input.ValueChangedEventHandler(this.CurrencyValueChanged);
            // 
            // britianAutoLabel
            // 
            this.britianAutoLabel.DX = -5;
            this.britianAutoLabel.DY = -35;
            this.britianAutoLabel.LabeledControl = this.brNumericTextBox;
            this.britianAutoLabel.Location = new System.Drawing.Point(469, 273);
            this.britianAutoLabel.Name = "britianAutoLabel";
            this.britianAutoLabel.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.britianAutoLabel.Size = new System.Drawing.Size(105, 20);
            this.britianAutoLabel.TabIndex = 30;
            this.britianAutoLabel.Text = "Britian pounds";
            // 
            // brNumericTextBox
            // 
            this.brNumericTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.brNumericTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brNumericTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.brNumericTextBox.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            this.brNumericTextBox.Location = new System.Drawing.Point(474, 308);
            this.brNumericTextBox.MinValue = 0D;
            this.brNumericTextBox.Name = "brNumericTextBox";
            this.brNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.brNumericTextBox.Size = new System.Drawing.Size(296, 32);
            this.brNumericTextBox.TabIndex = 22;
            this.brNumericTextBox.Text = "$0.00";
            this.brNumericTextBox.ValidationMode = Syncfusion.WinForms.Input.Enums.ValidationMode.KeyPress;
            this.brNumericTextBox.ValueChangeMode = Syncfusion.WinForms.Input.Enums.ValueChangeMode.KeyPress;
            this.brNumericTextBox.ValueChanged += new Syncfusion.WinForms.Input.ValueChangedEventHandler(this.CurrencyValueChanged);
            // 
            // germanAutoLabel
            // 
            this.germanAutoLabel.DX = -5;
            this.germanAutoLabel.DY = -35;
            this.germanAutoLabel.LabeledControl = this.germanNumericTextBox;
            this.germanAutoLabel.Location = new System.Drawing.Point(469, 156);
            this.germanAutoLabel.Name = "germanAutoLabel";
            this.germanAutoLabel.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.germanAutoLabel.Size = new System.Drawing.Size(95, 20);
            this.germanAutoLabel.TabIndex = 29;
            this.germanAutoLabel.Text = "German Euro";
            // 
            // germanNumericTextBox
            // 
            this.germanNumericTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.germanNumericTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.germanNumericTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.germanNumericTextBox.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            this.germanNumericTextBox.Location = new System.Drawing.Point(474, 191);
            this.germanNumericTextBox.MinValue = 0D;
            this.germanNumericTextBox.Name = "germanNumericTextBox";
            this.germanNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.germanNumericTextBox.Size = new System.Drawing.Size(296, 32);
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
            this.turkeyTextBox.Location = new System.Drawing.Point(54, 191);
            this.turkeyTextBox.MinValue = 0D;
            this.turkeyTextBox.Name = "turkeyTextBox";
            this.turkeyTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.turkeyTextBox.Size = new System.Drawing.Size(296, 32);
            this.turkeyTextBox.TabIndex = 17;
            this.turkeyTextBox.Text = "$0.00";
            this.turkeyTextBox.ValidationMode = Syncfusion.WinForms.Input.Enums.ValidationMode.KeyPress;
            this.turkeyTextBox.ValueChangeMode = Syncfusion.WinForms.Input.Enums.ValueChangeMode.KeyPress;
            this.turkeyTextBox.ValueChanged += new Syncfusion.WinForms.Input.ValueChangedEventHandler(this.CurrencyValueChanged);
            // 
            // japanAutoLabel
            // 
            this.japanAutoLabel.DX = -5;
            this.japanAutoLabel.DY = -35;
            this.japanAutoLabel.LabeledControl = this.japanNumericTextBox;
            this.japanAutoLabel.Location = new System.Drawing.Point(469, 47);
            this.japanAutoLabel.Name = "japanAutoLabel";
            this.japanAutoLabel.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.japanAutoLabel.Size = new System.Drawing.Size(96, 20);
            this.japanAutoLabel.TabIndex = 28;
            this.japanAutoLabel.Text = "Japanese Yen";
            // 
            // japanNumericTextBox
            // 
            this.japanNumericTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.japanNumericTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.japanNumericTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.japanNumericTextBox.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            this.japanNumericTextBox.Location = new System.Drawing.Point(474, 82);
            this.japanNumericTextBox.MinValue = 0D;
            this.japanNumericTextBox.Name = "japanNumericTextBox";
            this.japanNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.japanNumericTextBox.Size = new System.Drawing.Size(296, 32);
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
            this.chNumericTextBox.Location = new System.Drawing.Point(54, 308);
            this.chNumericTextBox.MinValue = 0D;
            this.chNumericTextBox.Name = "chNumericTextBox";
            this.chNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chNumericTextBox.Size = new System.Drawing.Size(296, 32);
            this.chNumericTextBox.TabIndex = 18;
            this.chNumericTextBox.Text = "$0.00";
            this.chNumericTextBox.ValidationMode = Syncfusion.WinForms.Input.Enums.ValidationMode.KeyPress;
            this.chNumericTextBox.ValueChangeMode = Syncfusion.WinForms.Input.Enums.ValueChangeMode.KeyPress;
            this.chNumericTextBox.ValueChanged += new Syncfusion.WinForms.Input.ValueChangedEventHandler(this.CurrencyValueChanged);
            // 
            // indiaAutoLabel
            // 
            this.indiaAutoLabel.DX = -5;
            this.indiaAutoLabel.DY = -35;
            this.indiaAutoLabel.LabeledControl = this.indNumericTextBox;
            this.indiaAutoLabel.Location = new System.Drawing.Point(49, 387);
            this.indiaAutoLabel.Name = "indiaAutoLabel";
            this.indiaAutoLabel.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.indiaAutoLabel.Size = new System.Drawing.Size(96, 20);
            this.indiaAutoLabel.TabIndex = 27;
            this.indiaAutoLabel.Text = "Indian Rupee";
            // 
            // indNumericTextBox
            // 
            this.indNumericTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.indNumericTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indNumericTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.indNumericTextBox.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            this.indNumericTextBox.Location = new System.Drawing.Point(54, 422);
            this.indNumericTextBox.MinValue = 0D;
            this.indNumericTextBox.Name = "indNumericTextBox";
            this.indNumericTextBox.Size = new System.Drawing.Size(296, 32);
            this.indNumericTextBox.TabIndex = 19;
            this.indNumericTextBox.Text = "$0.00";
            this.indNumericTextBox.ValidationMode = Syncfusion.WinForms.Input.Enums.ValidationMode.KeyPress;
            this.indNumericTextBox.ValueChangeMode = Syncfusion.WinForms.Input.Enums.ValueChangeMode.KeyPress;
            this.indNumericTextBox.ValueChanged += new Syncfusion.WinForms.Input.ValueChangedEventHandler(this.CurrencyValueChanged);
            // 
            // chineseAutoLabel
            // 
            this.chineseAutoLabel.DX = -5;
            this.chineseAutoLabel.DY = -35;
            this.chineseAutoLabel.LabeledControl = this.chNumericTextBox;
            this.chineseAutoLabel.Location = new System.Drawing.Point(49, 273);
            this.chineseAutoLabel.Name = "chineseAutoLabel";
            this.chineseAutoLabel.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.chineseAutoLabel.Size = new System.Drawing.Size(96, 20);
            this.chineseAutoLabel.TabIndex = 26;
            this.chineseAutoLabel.Text = "Chinese Yuan";
            // 
            // turkeyLabel
            // 
            this.turkeyLabel.DX = -5;
            this.turkeyLabel.DY = -35;
            this.turkeyLabel.LabeledControl = this.turkeyTextBox;
            this.turkeyLabel.Location = new System.Drawing.Point(49, 156);
            this.turkeyLabel.Name = "turkeyLabel";
            this.turkeyLabel.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.turkeyLabel.Size = new System.Drawing.Size(80, 20);
            this.turkeyLabel.TabIndex = 25;
            this.turkeyLabel.Text = "Turkey Lira";
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
            this.celNumericTextBox.Size = new System.Drawing.Size(296, 32);
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
            this.celsiusAutoLabel.Size = new System.Drawing.Size(83, 20);
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
            this.kelNumericTextBox.Size = new System.Drawing.Size(296, 32);
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
            this.rankineAutoLabel.Size = new System.Drawing.Size(86, 20);
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
            this.ranNumericTextBox.Size = new System.Drawing.Size(296, 32);
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
            this.farNumericTextBox.Size = new System.Drawing.Size(296, 32);
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
            this.fahrenheitAutoLabel.Size = new System.Drawing.Size(106, 20);
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
            this.kelvinAutoLabel.Size = new System.Drawing.Size(72, 20);
            this.kelvinAutoLabel.TabIndex = 17;
            this.kelvinAutoLabel.Text = "Kelvin (K)";
            // 
            // labelpanel
            // 
            this.labelpanel.AutoSize = true;
            this.labelpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.labelpanel.Controls.Add(this.unitLabel);
            this.labelpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelpanel.Location = new System.Drawing.Point(0, 0);
            this.labelpanel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.labelpanel.Name = "labelpanel";
            this.labelpanel.Size = new System.Drawing.Size(1092, 55);
            this.labelpanel.TabIndex = 2;
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitLabel.ForeColor = System.Drawing.Color.White;
            this.unitLabel.Location = new System.Drawing.Point(4, 2);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(227, 45);
            this.unitLabel.TabIndex = 0;
            this.unitLabel.Text = "Unit Converter";
            this.unitLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // imagePanel
            // 
            this.imagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.imagePanel.BackgroundImage = global::UnitConverterDemo.Properties.Resources.unit;
            this.imagePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.imagePanel.Location = new System.Drawing.Point(0, 55);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(1092, 30);
            this.imagePanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 686);
            this.Controls.Add(this.basePanel);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.labelpanel);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.basePanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.currencyPanel.ResumeLayout(false);
            this.currencyPanel.PerformLayout();
            this.temperaturePanel.ResumeLayout(false);
            this.temperaturePanel.PerformLayout();
            this.labelpanel.ResumeLayout(false);
            this.labelpanel.PerformLayout();
            this.ResumeLayout(false);

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
        private Syncfusion.Windows.Forms.Tools.AutoLabel saAutoLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox saNumericTextBox;
        private Syncfusion.Windows.Forms.Tools.AutoLabel usAutoLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox usNumericTextBox;
        private Syncfusion.Windows.Forms.Tools.AutoLabel britianAutoLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox brNumericTextBox;
        private Syncfusion.Windows.Forms.Tools.AutoLabel germanAutoLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox germanNumericTextBox;
        private Syncfusion.WinForms.Input.SfNumericTextBox turkeyTextBox;
        private Syncfusion.Windows.Forms.Tools.AutoLabel japanAutoLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox japanNumericTextBox;
        private Syncfusion.WinForms.Input.SfNumericTextBox chNumericTextBox;
        private Syncfusion.Windows.Forms.Tools.AutoLabel indiaAutoLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox indNumericTextBox;
        private Syncfusion.Windows.Forms.Tools.AutoLabel chineseAutoLabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel turkeyLabel;
        private System.Windows.Forms.Panel temperaturePanel;
        private Syncfusion.WinForms.Controls.SfButton temperatureButton;
        private Syncfusion.WinForms.Controls.SfButton currencyButton;
    }
}

