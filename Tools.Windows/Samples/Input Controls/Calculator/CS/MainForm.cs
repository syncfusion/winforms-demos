#region Copyright Syncfusion Inc. 2001 - 2014
//
//  Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Re-distribution in any form is strictly
//  prohibited. Any infringement will be prosecuted under applicable laws. 
//
#endregion

namespace CalculatorControlDemo
{
    using System;
    using System.Drawing;
    using System.Collections;
    using System.ComponentModel;
    using System.Windows.Forms;
    using System.Data;

    using Syncfusion.Windows.Forms.Tools;
    using Syncfusion.Windows.Forms.Tools.XPMenus;
    using Syncfusion.Windows.Forms;

    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class MainForm : MetroForm
    {
        public Syncfusion.Windows.Forms.Tools.CalculatorControl calculatorControl1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBox1;
        private Syncfusion.Windows.Forms.Tools.PopupCalculator popupCalculator1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBox2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem5;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem7;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem visualStyleParentBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem office2007ParentBarItem;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv2;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDownExt2;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDownExt1;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv3;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv2;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv1;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv5;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem blueBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem blackBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem silverBarItem;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel4;
        private BarItem barItem6;
        private BarItem barItem8;
        private BarItem barItem9;
        private BarItem barItem10;
        private BarItem barItem11;
        private System.ComponentModel.IContainer components;

        public MainForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
          
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            this.popupCalculator1 = new PopupCalculator();
            this.popupCalculator1.ParentControl = this.buttonAdv1;
            this.popupCalculator1.UseVisualStyle = true;
            this.popupCalculator1.ButtonStyle = ButtonAppearance.Metro;
            this.popupCalculator1.PopupCalculatorAlignment = CalculatorPopupAlignment.Right;
            this.popupCalculator1.Closing += new PopupCalculatorClosingEventHandler(this.HandlePopupCalculatorClosingEvent);
            this.popupCalculator1.BeforeCalculatorPopupDisplay += new CancelEventHandler(this.HandleBeforePopupCalculatorDisplayEvent);
            this.Load += new EventHandler(MainForm_Load);
        }

        void MainForm_Load(object sender, EventArgs e)
        {
            this.Padding = new Padding(10, 0, 10, 10);
            this.MetroColor = Color.White;
        }
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

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.calculatorControl1 = new Syncfusion.Windows.Forms.Tools.CalculatorControl();
            this.textBox1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.numericUpDownExt2 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.numericUpDownExt1 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.checkBoxAdv3 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.radioButtonAdv4 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonAdv5 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.label8 = new System.Windows.Forms.Label();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.radioButtonAdv3 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonAdv2 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButtonAdv1 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.checkBoxAdv2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "MainMenu");
            this.visualStyleParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.office2007ParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.blueBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.blackBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.silverBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem8= new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem9=new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem10= new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem11= new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).BeginInit();
            this.gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).BeginInit();
            this.gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // calculatorControl1
            // 
            this.calculatorControl1.AccessibleDescription = "Calculator control";
            this.calculatorControl1.AccessibleName = "Calculator Control";
            this.calculatorControl1.AutoScroll = true;
            this.calculatorControl1.BorderStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.calculatorControl1.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.calculatorControl1.Culture = new System.Globalization.CultureInfo("en-US");
            this.calculatorControl1.DoubleValue = 0;
            this.calculatorControl1.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.calculatorControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calculatorControl1.HorizontalSpacing = 7;
            this.calculatorControl1.Location = new System.Drawing.Point(141, 108);
            this.calculatorControl1.MetroColor = System.Drawing.SystemColors.Control;
            this.calculatorControl1.Name = "calculatorControl1";
            this.calculatorControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.calculatorControl1.Size = new System.Drawing.Size(292, 250);
            this.calculatorControl1.TabIndex = 0;
            this.calculatorControl1.ThemesEnabled = false;
            this.calculatorControl1.UseVerticalAndHorizontalSpacing = true;
            this.calculatorControl1.UseVisualStyle = true;
            this.calculatorControl1.VerticalSpacing = 7;
            this.calculatorControl1.ValueCalculated += new Syncfusion.Windows.Forms.Tools.CalculatorValueCalculatedEventHandler(this.calculatorControl1_ValueCalculated);
            // 
            // textBox1
            // 
            this.textBox1.BorderColor = System.Drawing.Color.Gray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Location = new System.Drawing.Point(165, 56);
            this.textBox1.Metrocolor = System.Drawing.Color.Gray;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 22);
            this.textBox1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // textBox2
            // 
            this.textBox2.BorderColor = System.Drawing.Color.Gray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox2.Location = new System.Drawing.Point(0, 515);
            this.textBox2.Metrocolor = System.Drawing.Color.Gray;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(811, 129);
            this.textBox2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textBox2.TabIndex = 4;
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.buttonAdv1.Location = new System.Drawing.Point(345, 393);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(88, 23);
            this.buttonAdv1.TabIndex = 17;
            this.buttonAdv1.Text = "Show Popup";
            this.buttonAdv1.UseVisualStyle = true;
            this.buttonAdv1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderColor = System.Drawing.Color.Silver;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.gradientPanel4);
            this.gradientPanel1.Controls.Add(this.gradientPanel3);
            this.gradientPanel1.Controls.Add(this.gradientPanel2);
            this.gradientPanel1.Controls.Add(this.textBox2);
            this.gradientPanel1.Controls.Add(this.textBox1);
            this.gradientPanel1.Controls.Add(this.checkBoxAdv2);
            this.gradientPanel1.Controls.Add(this.calculatorControl1);
            this.gradientPanel1.Controls.Add(this.buttonAdv1);
            this.gradientPanel1.Controls.Add(this.checkBoxAdv1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(10, 42);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(813, 649);
            this.gradientPanel1.TabIndex = 18;
            // 
            // gradientPanel4
            // 
            this.gradientPanel4.BorderColor = System.Drawing.Color.Silver;
            this.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel4.Controls.Add(this.numericUpDownExt2);
            this.gradientPanel4.Controls.Add(this.numericUpDownExt1);
            this.gradientPanel4.Controls.Add(this.checkBoxAdv3);
            this.gradientPanel4.Controls.Add(this.label6);
            this.gradientPanel4.Controls.Add(this.label3);
            this.gradientPanel4.Controls.Add(this.label2);
            this.gradientPanel4.Location = new System.Drawing.Point(448, 230);
            this.gradientPanel4.Name = "gradientPanel4";
            this.gradientPanel4.Size = new System.Drawing.Size(288, 128);
            this.gradientPanel4.TabIndex = 31;
            // 
            // numericUpDownExt2
            // 
            this.numericUpDownExt2.BackColor = System.Drawing.Color.White;
            this.numericUpDownExt2.BorderColor = System.Drawing.Color.Gray;
            this.numericUpDownExt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt2.Location = new System.Drawing.Point(139, 96);
            this.numericUpDownExt2.MetroColor = System.Drawing.Color.Gray;
            this.numericUpDownExt2.Name = "numericUpDownExt2";
            this.numericUpDownExt2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownExt2.TabIndex = 11;
            this.numericUpDownExt2.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownExt2.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.numericUpDownExt2.ValueChanged += new System.EventHandler(this.numericUpDownExt2_ValueChanged);
            // 
            // numericUpDownExt1
            // 
            this.numericUpDownExt1.BackColor = System.Drawing.Color.White;
            this.numericUpDownExt1.BorderColor = System.Drawing.Color.Gray;
            this.numericUpDownExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt1.Location = new System.Drawing.Point(139, 68);
            this.numericUpDownExt1.MetroColor = System.Drawing.Color.Gray;
            this.numericUpDownExt1.Name = "numericUpDownExt1";
            this.numericUpDownExt1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownExt1.TabIndex = 10;
            this.numericUpDownExt1.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownExt1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.numericUpDownExt1.ValueChanged += new System.EventHandler(this.numericUpDownExt1_ValueChanged);
            // 
            // checkBoxAdv3
            // 
            this.checkBoxAdv3.AutoHeight = true;
            this.checkBoxAdv3.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv3.DrawFocusRectangle = false;
            this.checkBoxAdv3.Location = new System.Drawing.Point(32, 34);
            this.checkBoxAdv3.MetroColor = System.Drawing.Color.Gray;
            this.checkBoxAdv3.Name = "checkBoxAdv3";
            this.checkBoxAdv3.Size = new System.Drawing.Size(200, 20);
            this.checkBoxAdv3.StretchImage = false;
            this.checkBoxAdv3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv3.TabIndex = 14;
            this.checkBoxAdv3.Text = "UseHorizontalAndVerticalSpacing";
            this.checkBoxAdv3.ThemesEnabled = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Spacing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(32, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Vertical Spacing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(30, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Horizontal Spacing";
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.BorderColor = System.Drawing.Color.Silver;
            this.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel3.Controls.Add(this.radioButtonAdv4);
            this.gradientPanel3.Controls.Add(this.radioButtonAdv5);
            this.gradientPanel3.Controls.Add(this.label8);
            this.gradientPanel3.Location = new System.Drawing.Point(448, 168);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(288, 48);
            this.gradientPanel3.TabIndex = 30;
            // 
            // radioButtonAdv4
            // 
            this.radioButtonAdv4.AutoHeight = true;
            this.radioButtonAdv4.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonAdv4.Checked = true;
            this.radioButtonAdv4.DrawFocusRectangle = false;
            this.radioButtonAdv4.Location = new System.Drawing.Point(119, 26);
            this.radioButtonAdv4.MetroColor = System.Drawing.Color.Gray;
            this.radioButtonAdv4.Name = "radioButtonAdv4";
            this.radioButtonAdv4.Size = new System.Drawing.Size(120, 20);
            this.radioButtonAdv4.StretchImage = false;
            this.radioButtonAdv4.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv4.TabIndex = 2;
            this.radioButtonAdv4.Text = "WindowsStandard";
            this.radioButtonAdv4.ThemesEnabled = false;
            this.radioButtonAdv4.CheckChanged += new System.EventHandler(this.OnRadioLayoutTypeCheckedChange);
            // 
            // radioButtonAdv5
            // 
            this.radioButtonAdv5.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonAdv5.DrawFocusRectangle = false;
            this.radioButtonAdv5.Location = new System.Drawing.Point(24, 26);
            this.radioButtonAdv5.MetroColor = System.Drawing.Color.Gray;
            this.radioButtonAdv5.Name = "radioButtonAdv5";
            this.radioButtonAdv5.Size = new System.Drawing.Size(72, 21);
            this.radioButtonAdv5.StretchImage = false;
            this.radioButtonAdv5.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv5.TabIndex = 3;
            this.radioButtonAdv5.TabStop = false;
            this.radioButtonAdv5.Text = "Financial";
            this.radioButtonAdv5.ThemesEnabled = false;
            this.radioButtonAdv5.CheckChanged += new System.EventHandler(this.OnRadioLayoutTypeCheckedChange);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Layout Type";
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BorderColor = System.Drawing.Color.Silver;
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel2.Controls.Add(this.radioButtonAdv3);
            this.gradientPanel2.Controls.Add(this.radioButtonAdv2);
            this.gradientPanel2.Controls.Add(this.label7);
            this.gradientPanel2.Controls.Add(this.radioButtonAdv1);
            this.gradientPanel2.Location = new System.Drawing.Point(448, 108);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(288, 48);
            this.gradientPanel2.TabIndex = 29;
            // 
            // radioButtonAdv3
            // 
            this.radioButtonAdv3.AutoHeight = true;
            this.radioButtonAdv3.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonAdv3.DrawFocusRectangle = false;
            this.radioButtonAdv3.Location = new System.Drawing.Point(175, 23);
            this.radioButtonAdv3.MetroColor = System.Drawing.Color.Gray;
            this.radioButtonAdv3.Name = "radioButtonAdv3";
            this.radioButtonAdv3.Size = new System.Drawing.Size(64, 20);
            this.radioButtonAdv3.StretchImage = false;
            this.radioButtonAdv3.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv3.TabIndex = 3;
            this.radioButtonAdv3.TabStop = false;
            this.radioButtonAdv3.Text = "Center";
            this.radioButtonAdv3.ThemesEnabled = false;
            this.radioButtonAdv3.CheckChanged += new System.EventHandler(this.OnRadioDisplayCheckedChange);
            // 
            // radioButtonAdv2
            // 
            this.radioButtonAdv2.AutoHeight = true;
            this.radioButtonAdv2.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonAdv2.Checked = true;
            this.radioButtonAdv2.DrawFocusRectangle = false;
            this.radioButtonAdv2.Location = new System.Drawing.Point(24, 23);
            this.radioButtonAdv2.MetroColor = System.Drawing.Color.Gray;
            this.radioButtonAdv2.Name = "radioButtonAdv2";
            this.radioButtonAdv2.Size = new System.Drawing.Size(56, 20);
            this.radioButtonAdv2.StretchImage = false;
            this.radioButtonAdv2.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv2.TabIndex = 2;
            this.radioButtonAdv2.Text = "Right";
            this.radioButtonAdv2.ThemesEnabled = false;
            this.radioButtonAdv2.CheckChanged += new System.EventHandler(this.OnRadioDisplayCheckedChange);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Display Text Alignment";
            // 
            // radioButtonAdv1
            // 
            this.radioButtonAdv1.AutoHeight = true;
            this.radioButtonAdv1.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonAdv1.DrawFocusRectangle = false;
            this.radioButtonAdv1.Location = new System.Drawing.Point(104, 23);
            this.radioButtonAdv1.MetroColor = System.Drawing.Color.Gray;
            this.radioButtonAdv1.Name = "radioButtonAdv1";
            this.radioButtonAdv1.Size = new System.Drawing.Size(48, 20);
            this.radioButtonAdv1.StretchImage = false;
            this.radioButtonAdv1.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv1.TabIndex = 1;
            this.radioButtonAdv1.Text = "Left";
            this.radioButtonAdv1.ThemesEnabled = false;
            this.radioButtonAdv1.CheckChanged += new System.EventHandler(this.OnRadioDisplayCheckedChange);
            // 
            // checkBoxAdv2
            // 
            this.checkBoxAdv2.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv2.DrawFocusRectangle = false;
            this.checkBoxAdv2.Location = new System.Drawing.Point(72, 56);
            this.checkBoxAdv2.MetroColor = System.Drawing.Color.Gray;
            this.checkBoxAdv2.Name = "checkBoxAdv2";
            this.checkBoxAdv2.Size = new System.Drawing.Size(96, 21);
            this.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv2.TabIndex = 19;
            this.checkBoxAdv2.Text = "Show Display";
            this.checkBoxAdv2.ThemesEnabled = false;
            this.checkBoxAdv2.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.AutoHeight = true;
            this.checkBoxAdv1.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv1.DrawFocusRectangle = false;
            this.checkBoxAdv1.Location = new System.Drawing.Point(72, 393);
            this.checkBoxAdv1.MetroColor = System.Drawing.Color.Gray;
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(218, 20);
            this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv1.TabIndex = 18;
            this.checkBoxAdv1.Text = "Close Popup when \"=\" Button Clicked";
            this.checkBoxAdv1.ThemesEnabled = false;
            // 
            // mainFrameBarManager1
            // 
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
            this.mainFrameBarManager1.Bars.Add(this.bar1);
            this.mainFrameBarManager1.Categories.Add("VisualStyles");
            this.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.MetroForm";
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.barItem4,
            this.visualStyleParentBarItem,
            this.parentBarItem2,
            this.barItem7,
            this.office2007ParentBarItem,
            this.blueBarItem,
            this.blackBarItem,
            this.silverBarItem,
            this.barItem6});
            this.mainFrameBarManager1.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.mainFrameBarManager1.ResetCustomization = false;
            this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // bar1
            // 
            this.bar1.BarName = "MainMenu";
            this.bar1.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu) 
            | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) 
            | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.UseWholeRow)));
            this.bar1.Caption = "MainMenu";
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.visualStyleParentBarItem,
            this.parentBarItem2});
            this.bar1.Manager = this.mainFrameBarManager1;
            // 
            // visualStyleParentBarItem
            // 
            this.visualStyleParentBarItem.BarName = "visualStyleParentBarItem";
            this.visualStyleParentBarItem.CategoryIndex = 0;
            this.visualStyleParentBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualStyleParentBarItem.ID = "&Visual Styles";
            this.visualStyleParentBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.barItem4,
            this.office2007ParentBarItem,
            this.barItem6,
            this.barItem8,
            this.barItem9,
            this.barItem10,
            this.barItem11});
            this.visualStyleParentBarItem.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.visualStyleParentBarItem.OverlapCheckBoxImageBounds = true;
            this.visualStyleParentBarItem.ShowToolTipInPopUp = false;
            this.visualStyleParentBarItem.SizeToFit = true;
            this.visualStyleParentBarItem.Text = "&Visual Styles";
            // 
            // barItem1
            // 
            this.barItem1.BarName = "barItem1";
            this.barItem1.CategoryIndex = 0;
            this.barItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem1.ID = "Classic";
            this.barItem1.ShowToolTipInPopUp = false;
            this.barItem1.SizeToFit = true;
            this.barItem1.Text = "Classic";
            this.barItem1.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem2
            // 
            this.barItem2.BarName = "barItem2";
            this.barItem2.CategoryIndex = 0;
            this.barItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem2.ID = "Office2000";
            this.barItem2.ShowToolTipInPopUp = false;
            this.barItem2.SizeToFit = true;
            this.barItem2.Text = "Office2000";
            this.barItem2.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem3
            // 
            this.barItem3.BarName = "barItem3";
            this.barItem3.CategoryIndex = 0;
            this.barItem3.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem3.ID = "WindowsXP";
            this.barItem3.ShowToolTipInPopUp = false;
            this.barItem3.SizeToFit = true;
            this.barItem3.Text = "WindowsXP";
            this.barItem3.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem4
            // 
            this.barItem4.BarName = "barItem4";
            this.barItem4.CategoryIndex = 0;
            this.barItem4.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem4.ID = "OfficeXP";
            this.barItem4.ShowToolTipInPopUp = false;
            this.barItem4.SizeToFit = true;
            this.barItem4.Text = "OfficeXP";
            this.barItem4.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem5
            // 
            this.barItem5.BarName = "barItem5";
            this.barItem5.CategoryIndex = 0;
            this.barItem5.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem5.ID = "Office2003";
            this.barItem5.ShowToolTipInPopUp = false;
            this.barItem5.SizeToFit = true;
            this.barItem5.Text = "Office2003";
            this.barItem5.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // office2007ParentBarItem
            // 
            this.office2007ParentBarItem.BarName = "office2007ParentBarItem";
            this.office2007ParentBarItem.CategoryIndex = 0;
            this.office2007ParentBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.office2007ParentBarItem.ID = "Office2007";
            this.office2007ParentBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.blueBarItem,
            this.blackBarItem,
            this.silverBarItem});
            this.office2007ParentBarItem.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.office2007ParentBarItem.ShowToolTipInPopUp = false;
            this.office2007ParentBarItem.SizeToFit = true;
            this.office2007ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.office2007ParentBarItem.Text = "Office2007";
            // 
            // blueBarItem
            // 
            this.blueBarItem.BarName = "blueBarItem";
            this.blueBarItem.CategoryIndex = 0;
            this.blueBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueBarItem.ID = "Blue";
            this.blueBarItem.ShowToolTipInPopUp = false;
            this.blueBarItem.SizeToFit = true;
            this.blueBarItem.Text = "Blue";
            this.blueBarItem.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // blackBarItem
            // 
            this.blackBarItem.BarName = "blackBarItem";
            this.blackBarItem.CategoryIndex = 0;
            this.blackBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackBarItem.ID = "Black";
            this.blackBarItem.ShowToolTipInPopUp = false;
            this.blackBarItem.SizeToFit = true;
            this.blackBarItem.Text = "Black";
            this.blackBarItem.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // silverBarItem
            // 
            this.silverBarItem.BarName = "silverBarItem";
            this.silverBarItem.CategoryIndex = 0;
            this.silverBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.silverBarItem.ID = "Silver";
            this.silverBarItem.ShowToolTipInPopUp = false;
            this.silverBarItem.SizeToFit = true;
            this.silverBarItem.Text = "Silver";
            this.silverBarItem.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.BarName = "parentBarItem2";
            this.parentBarItem2.CategoryIndex = 0;
            this.parentBarItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem2.ID = "&Help";
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem7});
            this.parentBarItem2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem2.ShowToolTipInPopUp = false;
            this.parentBarItem2.SizeToFit = true;
            this.parentBarItem2.Text = "&Help";
            this.parentBarItem2.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem7
            // 
            this.barItem7.BarName = "barItem7";
            this.barItem7.CategoryIndex = 0;
            this.barItem7.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem7.ID = "AboutSyncfusion";
            this.barItem7.ShowToolTipInPopUp = false;
            this.barItem7.SizeToFit = true;
            this.barItem7.Text = "About Syncfusion";
            this.barItem7.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem6
            // 
            this.barItem6.BarName = "barItem6";
            this.barItem6.CategoryIndex = 0;
            this.barItem6.ID = "Metro";
            this.barItem6.Checked = true;
            this.barItem6.ShowToolTipInPopUp = false;
            this.barItem6.SizeToFit = true;
            this.barItem6.Text = "Metro";
            this.barItem6.Click += new System.EventHandler(this.OnBarItemClick);
            //
            //barItem8
            //
            this.barItem8.BarName = "barItem8";
            this.barItem8.CategoryIndex = 0;
            this.barItem8.ID = "Office2016White";
            this.barItem8.ShowToolTipInPopUp = false;
            this.barItem8.SizeToFit = true;
            this.barItem8.Text = "Office2016White";
            this.barItem8.Click+= new System.EventHandler(this.OnBarItemClick);
            //
            //barItem9
            //
            this.barItem9.BarName = "barItem9";
            this.barItem9.CategoryIndex = 0;
            this.barItem9.ID = "Office2016Colorful";
            this.barItem9.ShowToolTipInPopUp = false;
            this.barItem9.SizeToFit = true;
            this.barItem9.Text = "Office2016Colorful";
            this.barItem9.Click+= new System.EventHandler(this.OnBarItemClick);
            //
            //barItem10
            //
            this.barItem10.BarName = "barItem10";
            this.barItem10.CategoryIndex = 0;
            this.barItem10.ID = "Office2016Black";
            this.barItem10.ShowToolTipInPopUp = false;
            this.barItem10.SizeToFit = true;
            this.barItem10.Text = "Office2016Black";
            this.barItem10.Click += new System.EventHandler(this.OnBarItemClick);
            //
            //barItem11
            //
            this.barItem11.BarName = "barItem9";
            this.barItem11.CategoryIndex = 0;
            this.barItem11.ID = "Office2016DarkGray";
            this.barItem11.ShowToolTipInPopUp = false;
            this.barItem11.SizeToFit = true;
            this.barItem11.Text = "Office2016DarkGray";
            this.barItem11.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.ClientSize = new System.Drawing.Size(833, 698);
            this.Controls.Add(this.gradientPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(845, 726);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).EndInit();
            this.gradientPanel4.ResumeLayout(false);
            this.gradientPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).EndInit();
            this.gradientPanel3.ResumeLayout(false);
            this.gradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
            Application.Run(new MainForm());
        }
        #region ShowDisplayArea
        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            this.calculatorControl1.ShowDisplayArea = this.checkBoxAdv2.Checked;
            if (this.checkBoxAdv2.Checked)
                this.gradientPanel2.Enabled = true;
            else
                this.gradientPanel2.Enabled = false;
        }
        #endregion

        #region HandlePopupCalculatorClosingEvent

        public void HandlePopupCalculatorClosingEvent(object sender, CalculatorClosingEventArgs args)
        {
            //Event logging
            string item = args.FinalValue.ToString();
            string eventlogmessage = String.Format("Event: {0} FinalValue: {1}\r\n", "CalculatorClosing", item);
            textBox2.Text = textBox2.Text + eventlogmessage;
        }
        #endregion

        #region HandleBeforePopupCalculatorDisplayEvent

        public void HandleBeforePopupCalculatorDisplayEvent(object sender, CancelEventArgs args)
        {
            //Event logging
            string item = args.Cancel.ToString();
            string eventlogmessage = String.Format("Event: {0} Cancel: {1}\r\n", "CalculatorClosing", item);
            textBox2.Text = textBox2.Text + eventlogmessage;

            if (this.checkBoxAdv1.CheckState == CheckState.Checked)
                this.popupCalculator1.CloseAction = CalcActions.CalcOperatorEquals;
            else
                this.popupCalculator1.CloseAction = CalcActions.CalcOperatorNone;
            this.popupCalculator1.Office2007ColorTheme = this.calculatorControl1.Office2007Theme;
            this.popupCalculator1.MetroColor = this.calculatorControl1.MetroColor;
        }
        #endregion

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.checkBoxAdv2.Checked = this.calculatorControl1.ShowDisplayArea;
        }

        /// <summary>
        /// Restrict the characters.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = !char.IsNumber(e.KeyChar);
            }
        }

        #region InitializeComponent
        protected void CodeGen_InitializeComponent()
        {
            //<samplecodeblock name="CalcuatorControl InitializeComponent">

            //InitializeComponent
            // Create the Calculator Control
            this.calculatorControl1 = new CalculatorControl();
            this.textBox1 = new TextBoxExt();

            // Set the value of the calculator control
            this.calculatorControl1.DoubleValue = 0;

            // Set the border style for the control
            this.calculatorControl1.BorderStyle = Border3DStyle.Raised;

            // The flat style for the buttons
            this.calculatorControl1.FlatStyle = FlatStyle.Standard;

            // Set the size of the calculator
            this.calculatorControl1.Size = new System.Drawing.Size(288, 232);

            // Add a event handler for the ValueCalculated event of the child button
            this.calculatorControl1.ValueCalculated += new Syncfusion.Windows.Forms.Tools.CalculatorValueCalculatedEventHandler(this.CodeGen_calculatorControl1_ValueCalculated);

            // Add the CalculatorControl control to the form
            this.Controls.Add(this.calculatorControl1);
            //</samplecodeblock>
        }
        #endregion

        #region ValueCalculated
        /// <summary>
        /// The value has changed for the CalculatorControl.
        /// </summary>
        /// <param name="sender">The CalculatorControl raising the event.</param>
        /// <param name="arg">The event data.</param>

        private void CodeGen_calculatorControl1_ValueCalculated(object sender, CalculatorValueCalculatedEventArgs arg)
        {
            //<samplecodeblock name="CalcuatorControl ValueCalculated event">
            this.calculatorControl1.ValueCalculated += new Syncfusion.Windows.Forms.Tools.CalculatorValueCalculatedEventHandler(this.CodeGen_calculatorControl1_ValueCalculated);

            //calculatorControl1_ValueCalculated
            if (arg.ErrorCondition == false)
                this.textBox1.Text = arg.Value.ToString();
            else
                this.textBox1.Text = arg.Message;
            //</samplecodeblock>
        }
        #endregion

        #region CalculatorAboutForm
        private void menuItem4_Click(object sender, System.EventArgs e)
        {
            DemoCommon.AboutForm ab = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());

            ab.ShowDialog();

        }
        #endregion

        #region popupCalculator
        private void button1_Click(object sender, System.EventArgs e)
        {
            this.popupCalculator1.Size = this.calculatorControl1.Size;
            this.popupCalculator1.FlatStyle = FlatStyle.Flat;
            this.popupCalculator1.DisplayCalculator();
            foreach (Control but in this.popupCalculator1.Calculator.Controls)
            {
                if (but is ButtonAdv)
                {
                    but.BackColor=( calculatorControl1.Controls[4] as ButtonAdv ).BackColor;
                }
            }
        }
        #endregion

        #region Exit
        private void menuItem2_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region ValueCalculated
        private void calculatorControl1_ValueCalculated(object sender, Syncfusion.Windows.Forms.Tools.CalculatorValueCalculatedEventArgs arg)
        {
            //Event logging
            string item = arg.Value.ToString();
            string eventlogmessage = String.Format("Event: {0} Value: {1}\r\n", "ValueCalculated", item);
            textBox2.Text = textBox2.Text + eventlogmessage;

            //Actual Code
            if (arg.ErrorCondition == false)
                this.textBox1.Text = arg.Value.ToString();
            else
                this.textBox1.Text = arg.Message;

        }
        #endregion

        #region Theme Effects

        private void OnBarItemClick(object sender, EventArgs e)
        {
            BarItem item = sender as BarItem;
            switch (item.ID)
            {
                case "Classic":
                    this.calculatorControl1.ButtonStyle = ButtonAppearance.Classic;
                    this.popupCalculator1.ButtonStyle = ButtonAppearance.Classic;
                    SetCheckedState(item, this.visualStyleParentBarItem);
                    SetTheme(240, 240, 240, 240, 240, 240);
                    SetForeColor(Color.Black);
                    this.buttonAdv1.Appearance = ButtonAppearance.Classic;
                    this.mainFrameBarManager1.Style = VisualStyle.Default;
                    this.radioButtonAdv5.BackColor = Color.FromArgb(224, 223, 227);
                    this.radioButtonAdv4.BackColor = Color.FromArgb(224, 223, 227);
                    this.radioButtonAdv3.BackColor = Color.FromArgb(224, 223, 227);
                    this.radioButtonAdv2.BackColor = Color.FromArgb(224, 223, 227);
                    this.radioButtonAdv1.BackColor = Color.FromArgb(224, 223, 227);
                    this.BackColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.radioButtonAdv1.Style = RadioButtonAdvStyle.Default;
                    this.radioButtonAdv2.Style = RadioButtonAdvStyle.Default;
                    this.radioButtonAdv3.Style = RadioButtonAdvStyle.Default;
                    this.radioButtonAdv4.Style = RadioButtonAdvStyle.Default;
                    this.radioButtonAdv5.Style = RadioButtonAdvStyle.Default;
                    this.textBox2.Style = TextBoxExt.theme.Office2016White;
                    this.checkBoxAdv2.Style = CheckBoxAdvStyle.Default;
                    this.checkBoxAdv1.Style = CheckBoxAdvStyle.Default;
                    this.checkBoxAdv3.Style = CheckBoxAdvStyle.Default;
                    this.label2.ForeColor = Color.Black;
                    this.label3.ForeColor = Color.Black;
                    this.CaptionBarColor = this.MetroColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.CaptionForeColor = Color.Black;
                    break;
                case "Metro":
                    this.calculatorControl1.ButtonStyle = ButtonAppearance.Metro;
                    this.popupCalculator1.ButtonStyle = ButtonAppearance.Metro;
                    SetCheckedState(item, this.visualStyleParentBarItem);
                    SetTheme(225, 225, 225, 225, 225, 225);
                    SetForeColor(Color.Black);
                    this.calculatorControl1.BorderStyle = Border3DStyle.Flat;
                    this.buttonAdv1.Appearance = ButtonAppearance.Metro;
                    this.mainFrameBarManager1.Style = VisualStyle.Metro;
                    this.calculatorControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                    this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                    this.gradientPanel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                    this.gradientPanel3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                    this.gradientPanel4.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                    this.radioButtonAdv5.BackColor = Color.White;
                    this.radioButtonAdv4.BackColor = Color.White;
                    this.radioButtonAdv3.BackColor = Color.White;
                    this.radioButtonAdv2.BackColor = Color.White;
                    this.radioButtonAdv1.BackColor = Color.White;
                    this.BackColor = Color.White;
                    this.radioButtonAdv1.Style = RadioButtonAdvStyle.Metro;
                    this.radioButtonAdv2.Style = RadioButtonAdvStyle.Metro;
                    this.radioButtonAdv3.Style = RadioButtonAdvStyle.Metro;
                    this.radioButtonAdv4.Style = RadioButtonAdvStyle.Metro;
                    this.radioButtonAdv5.Style = RadioButtonAdvStyle.Metro;
                    this.textBox2.Style = TextBoxExt.theme.Office2016White;
                    this.checkBoxAdv2.Style = CheckBoxAdvStyle.Metro;
                    this.checkBoxAdv1.Style = CheckBoxAdvStyle.Metro;
                    this.checkBoxAdv3.Style = CheckBoxAdvStyle.Metro;
                    this.label2.ForeColor = Color.Black;
                    this.label3.ForeColor = Color.Black;
                    this.CaptionBarColor = this.MetroColor = Color.White;
                    this.CaptionForeColor = Color.Black;
                    break;
                case "Office2016White":
                    this.calculatorControl1.ButtonStyle = ButtonAppearance.Office2016White;
                    this.popupCalculator1.ButtonStyle = ButtonAppearance.Office2016White;
                    SetCheckedState(item, this.visualStyleParentBarItem);
                    SetTheme(197, 197, 197, 255, 255, 255);
                    SetForeColor(Color.Black);
                    this.calculatorControl1.BorderStyle = Border3DStyle.Flat;
                    this.buttonAdv1.Appearance = ButtonAppearance.Office2016White;
                    this.mainFrameBarManager1.Style = VisualStyle.Office2016White;
                    this.calculatorControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#FFFFFF"));
                    this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#FFFFFF"));
                    this.gradientPanel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#FFFFFF"));
                    this.gradientPanel3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#FFFFFF"));
                    this.gradientPanel4.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#FFFFFF"));
                    this.radioButtonAdv1.Style = RadioButtonAdvStyle.Office2016White;
                    this.radioButtonAdv2.Style = RadioButtonAdvStyle.Office2016White;
                    this.radioButtonAdv3.Style = RadioButtonAdvStyle.Office2016White;
                    this.radioButtonAdv4.Style = RadioButtonAdvStyle.Office2016White;
                    this.radioButtonAdv5.Style = RadioButtonAdvStyle.Office2016White;
                    this.BackColor = Color.White;
                    this.textBox2.Style = TextBoxExt.theme.Office2016White;
                    this.checkBoxAdv2.Style = CheckBoxAdvStyle.Office2016White;
                    this.checkBoxAdv1.Style = CheckBoxAdvStyle.Office2016White;
                    this.checkBoxAdv3.Style = CheckBoxAdvStyle.Office2016White;
                    this.label2.ForeColor = Color.Black;
                    this.label3.ForeColor = Color.Black;
                    this.CaptionBarColor = this.MetroColor = Color.White;
                    this.CaptionForeColor = Color.Black;
                    break;
                case "Office2016Black":
                    this.calculatorControl1.ButtonStyle = ButtonAppearance.Office2016Black;
                    this.popupCalculator1.ButtonStyle = ButtonAppearance.Office2016Black;
                    SetCheckedState(item, this.visualStyleParentBarItem);
                    SetTheme(68, 68, 68, 38, 38, 38);
                    SetForeColor(Color.White);
                    this.calculatorControl1.BorderStyle = Border3DStyle.Flat;
                    this.buttonAdv1.Appearance = ButtonAppearance.Office2016Black;
                    this.mainFrameBarManager1.Style = VisualStyle.Office2016Black;
                    this.calculatorControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#262626"));
                    this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#262626"));
                    this.gradientPanel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#262626"));
                    this.gradientPanel3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#262626"));
                    this.gradientPanel4.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#262626"));
                    this.radioButtonAdv1.Style = RadioButtonAdvStyle.Office2016Black;
                    this.radioButtonAdv2.Style = RadioButtonAdvStyle.Office2016Black;
                    this.radioButtonAdv3.Style = RadioButtonAdvStyle.Office2016Black;
                    this.radioButtonAdv4.Style = RadioButtonAdvStyle.Office2016Black;
                    this.radioButtonAdv5.Style = RadioButtonAdvStyle.Office2016Black;
                    this.BackColor = Color.Black;
                    this.textBox2.Style = TextBoxExt.theme.Office2016Black;
                    this.checkBoxAdv2.Style = CheckBoxAdvStyle.Office2016Black;
                    this.checkBoxAdv1.Style = CheckBoxAdvStyle.Office2016Black;
                    this.checkBoxAdv3.Style = CheckBoxAdvStyle.Office2016Black;
                    this.label2.ForeColor = Color.White;
                    this.label3.ForeColor = Color.White;
                    this.CaptionBarColor = this.MetroColor = Color.Black;
                    this.CaptionForeColor = Color.White;
                    break;
                case "Office2016Colorful":
                    this.calculatorControl1.ButtonStyle = ButtonAppearance.Office2016Colorful;
                    this.popupCalculator1.ButtonStyle = ButtonAppearance.Office2016Colorful;
                    SetCheckedState(item, this.visualStyleParentBarItem);
                    SetTheme(197, 197, 197, 255, 255, 255);
                    SetForeColor(Color.Black);
                    this.calculatorControl1.BorderStyle = Border3DStyle.Flat;
                    this.buttonAdv1.Appearance = ButtonAppearance.Office2016Colorful;
                    this.mainFrameBarManager1.Style = VisualStyle.Office2016Colorful;
                    this.calculatorControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#FFFFFF"));
                    this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#FFFFFF"));
                    this.gradientPanel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#FFFFFF"));
                    this.gradientPanel3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#FFFFFF"));
                    this.gradientPanel4.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#FFFFFF"));
                    this.radioButtonAdv1.Style = RadioButtonAdvStyle.Office2016Colorful;
                    this.radioButtonAdv2.Style = RadioButtonAdvStyle.Office2016Colorful;
                    this.radioButtonAdv3.Style = RadioButtonAdvStyle.Office2016Colorful;
                    this.radioButtonAdv4.Style = RadioButtonAdvStyle.Office2016Colorful;
                    this.radioButtonAdv5.Style = RadioButtonAdvStyle.Office2016Colorful;
                    this.BackColor = Color.White;
                    this.textBox2.Style = TextBoxExt.theme.Office2016Colorful;
                    this.checkBoxAdv2.Style = CheckBoxAdvStyle.Office2016Colorful;
                    this.checkBoxAdv1.Style = CheckBoxAdvStyle.Office2016Colorful;
                    this.checkBoxAdv3.Style = CheckBoxAdvStyle.Office2016Colorful;
                    this.label2.ForeColor = Color.Black;
                    this.label3.ForeColor = Color.Black;
                    this.CaptionBarColor = this.MetroColor = Color.White;
                    this.CaptionForeColor = Color.Black;
                    break;
                case "Office2016DarkGray":
                    this.calculatorControl1.ButtonStyle = ButtonAppearance.Office2016DarkGray;
                    this.popupCalculator1.ButtonStyle = ButtonAppearance.Office2016DarkGray;
                    SetCheckedState(item, this.visualStyleParentBarItem);
                    SetTheme(68, 68, 68, 102, 102, 102);
                    SetForeColor(Color.White);
                    this.calculatorControl1.BorderStyle = Border3DStyle.Flat;
                    this.buttonAdv1.Appearance = ButtonAppearance.Office2016DarkGray;
                    this.mainFrameBarManager1.Style = VisualStyle.Office2016DarkGray;
                    this.calculatorControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#666666"));
                    this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#666666"));
                    this.gradientPanel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#666666"));
                    this.gradientPanel3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#666666"));
                    this.gradientPanel4.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#666666"));
                    this.radioButtonAdv1.Style = RadioButtonAdvStyle.Office2016DarkGray;
                    this.radioButtonAdv2.Style = RadioButtonAdvStyle.Office2016DarkGray;
                    this.radioButtonAdv3.Style = RadioButtonAdvStyle.Office2016DarkGray;
                    this.radioButtonAdv4.Style = RadioButtonAdvStyle.Office2016DarkGray;
                    this.radioButtonAdv5.Style = RadioButtonAdvStyle.Office2016DarkGray;
                    this.textBox2.Style = TextBoxExt.theme.Office2016DarkGray;
                    this.checkBoxAdv2.Style = CheckBoxAdvStyle.Office2016DarkGray;
                    this.checkBoxAdv1.Style = CheckBoxAdvStyle.Office2016DarkGray;
                    this.checkBoxAdv3.Style = CheckBoxAdvStyle.Office2016DarkGray;
                    this.BackColor = Color.FromArgb(102, 102, 102);
                    this.label2.ForeColor = Color.White;
                    this.label3.ForeColor = Color.White;
                    this.CaptionBarColor = this.MetroColor = ColorTranslator.FromHtml("#666666");
                    this.CaptionForeColor = Color.Black;
                    break;
                case "Office2000":
                    this.calculatorControl1.ButtonStyle = ButtonAppearance.Office2000;
                    this.popupCalculator1.ButtonStyle = ButtonAppearance.Office2000;
                    SetCheckedState(item, this.visualStyleParentBarItem);
                    SetTheme(240, 240, 240, 240, 240, 240);
                    SetForeColor(Color.Black);
                    this.buttonAdv1.Appearance = ButtonAppearance.Office2000;
                    this.mainFrameBarManager1.Style = VisualStyle.Default;
                    this.radioButtonAdv5.Style = RadioButtonAdvStyle.Default;
                    this.radioButtonAdv4.Style = RadioButtonAdvStyle.Default;
                    this.radioButtonAdv3.Style = RadioButtonAdvStyle.Default;
                    this.radioButtonAdv2.Style = RadioButtonAdvStyle.Default;
                    this.radioButtonAdv1.Style = RadioButtonAdvStyle.Default;
                    this.radioButtonAdv5.BackColor = Color.FromArgb(224, 223, 227);
                    this.radioButtonAdv4.BackColor = Color.FromArgb(224, 223, 227);
                    this.radioButtonAdv3.BackColor = Color.FromArgb(224, 223, 227);
                    this.radioButtonAdv2.BackColor = Color.FromArgb(224, 223, 227);
                    this.radioButtonAdv1.BackColor = Color.FromArgb(224, 223, 227);
                    this.BackColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.textBox2.Style = TextBoxExt.theme.Office2016White;
                    this.checkBoxAdv2.Style = CheckBoxAdvStyle.Default;
                    this.checkBoxAdv1.Style = CheckBoxAdvStyle.Default;
                    this.checkBoxAdv3.Style = CheckBoxAdvStyle.Default;
                    this.label2.ForeColor = Color.Black;
                    this.label3.ForeColor = Color.Black;
                    this.CaptionBarColor = this.MetroColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.CaptionForeColor = Color.Black;
                    break;
                case "WindowsXP":
                    this.calculatorControl1.ButtonStyle = ButtonAppearance.WindowsXP;
                    this.popupCalculator1.ButtonStyle = ButtonAppearance.WindowsXP;
                    SetCheckedState(item, this.visualStyleParentBarItem);
                    SetTheme(240, 240, 240, 240, 240, 240);
                    SetForeColor(Color.Black);
                    this.buttonAdv1.Appearance = ButtonAppearance.WindowsXP;
                    this.mainFrameBarManager1.Style = VisualStyle.OfficeXP;
                    this.radioButtonAdv5.Style = RadioButtonAdvStyle.Default;
                    this.radioButtonAdv4.Style = RadioButtonAdvStyle.Default;
                    this.radioButtonAdv3.Style = RadioButtonAdvStyle.Default;
                    this.radioButtonAdv2.Style = RadioButtonAdvStyle.Default;
                    this.radioButtonAdv1.Style = RadioButtonAdvStyle.Default;
                    this.radioButtonAdv1.BackColor = Color.FromArgb(202, 201, 221);
                    this.radioButtonAdv4.BackColor = Color.FromArgb(202, 201, 221);
                    this.radioButtonAdv3.BackColor = Color.FromArgb(202, 201, 221);
                    this.radioButtonAdv2.BackColor = Color.FromArgb(202, 201, 221);
                    this.radioButtonAdv5.BackColor = Color.FromArgb(202, 201, 221);
                    this.BackColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.textBox2.Style = TextBoxExt.theme.Office2016White;
                    this.checkBoxAdv2.Style = CheckBoxAdvStyle.Default;
                    this.checkBoxAdv1.Style = CheckBoxAdvStyle.Default;
                    this.checkBoxAdv3.Style = CheckBoxAdvStyle.Default;
                    this.label2.ForeColor = Color.Black;
                    this.label3.ForeColor = Color.Black;
                    this.CaptionBarColor = this.MetroColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.CaptionForeColor = Color.Black;
                    break;
                case "OfficeXP":
                    this.calculatorControl1.ButtonStyle = ButtonAppearance.OfficeXP;
                    this.popupCalculator1.ButtonStyle = ButtonAppearance.OfficeXP;
                    SetCheckedState(item, this.visualStyleParentBarItem);
                    SetTheme(240, 240, 240, 240, 240, 240);
                    this.buttonAdv1.Appearance = ButtonAppearance.OfficeXP;
                    SetForeColor(Color.Black);
                    this.mainFrameBarManager1.Style = VisualStyle.OfficeXP;
                    this.radioButtonAdv5.Style = RadioButtonAdvStyle.Default;
                    this.radioButtonAdv4.Style = RadioButtonAdvStyle.Default;
                    this.radioButtonAdv3.Style = RadioButtonAdvStyle.Default;
                    this.radioButtonAdv2.Style = RadioButtonAdvStyle.Default;
                    this.radioButtonAdv1.Style = RadioButtonAdvStyle.Default;
                    this.radioButtonAdv5.BackColor = Color.FromArgb(224, 223, 227);
                    this.radioButtonAdv4.BackColor = Color.FromArgb(224, 223, 227);
                    this.radioButtonAdv3.BackColor = Color.FromArgb(224, 223, 227);
                    this.radioButtonAdv2.BackColor = Color.FromArgb(224, 223, 227);
                    this.radioButtonAdv1.BackColor = Color.FromArgb(224, 223, 227);
                    this.BackColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.textBox2.Style = TextBoxExt.theme.Office2016White;
                    this.checkBoxAdv2.Style = CheckBoxAdvStyle.Default;
                    this.checkBoxAdv1.Style = CheckBoxAdvStyle.Default;
                    this.checkBoxAdv3.Style = CheckBoxAdvStyle.Default;
                    this.label2.ForeColor = Color.Black;
                    this.label3.ForeColor = Color.Black;
                    this.CaptionBarColor = this.MetroColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.CaptionForeColor = Color.Black;
                    break;
                case "Office2003":
                    this.calculatorControl1.ButtonStyle = ButtonAppearance.Office2003;
                    this.popupCalculator1.ButtonStyle = ButtonAppearance.Office2003;
                    SetCheckedState(item, this.visualStyleParentBarItem);
                    SetTheme(240, 240, 240, 240, 240, 240);
                    SetForeColor(Color.Black);
                    this.buttonAdv1.Appearance = ButtonAppearance.Office2003;
                    this.mainFrameBarManager1.Style = VisualStyle.Office2003;
                    this.radioButtonAdv5.Style = RadioButtonAdvStyle.Default;
                    this.radioButtonAdv4.Style = RadioButtonAdvStyle.Default;
                    this.radioButtonAdv3.Style = RadioButtonAdvStyle.Default;
                    this.radioButtonAdv2.Style = RadioButtonAdvStyle.Default;
                    this.radioButtonAdv1.Style = RadioButtonAdvStyle.Default;
                    this.radioButtonAdv5.BackColor = Color.FromArgb(224, 223, 227);
                    this.radioButtonAdv4.BackColor = Color.FromArgb(224, 223, 227);
                    this.radioButtonAdv3.BackColor = Color.FromArgb(224, 223, 227);
                    this.radioButtonAdv2.BackColor = Color.FromArgb(224, 223, 227);
                    this.radioButtonAdv1.BackColor = Color.FromArgb(224, 223, 227);
                    this.BackColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.textBox2.Style = TextBoxExt.theme.Office2016White;
                    this.checkBoxAdv2.Style = CheckBoxAdvStyle.Default;
                    this.checkBoxAdv1.Style = CheckBoxAdvStyle.Default;
                    this.checkBoxAdv3.Style = CheckBoxAdvStyle.Default;
                    this.label2.ForeColor = Color.Black;
                    this.label3.ForeColor = Color.Black;
                    this.CaptionBarColor = Color.White;
                    this.CaptionForeColor = Color.Black;
                    break;
                case "AboutSyncfusion":
                    new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies()).ShowDialog();
                    break;
                case "Blue":
                    SetTheme(Office2007Theme.Blue, 220, 235, 254, 189, 215, 252);
                    SetForeColor(Color.FromArgb(21, 69, 139));
                    blueBarItem.Checked = true;
                    blackBarItem.Checked = false;
                    silverBarItem.Checked = false;
                    this.radioButtonAdv5.Style = RadioButtonAdvStyle.Office2007;
                    this.radioButtonAdv4.Style = RadioButtonAdvStyle.Office2007;
                    this.radioButtonAdv3.Style = RadioButtonAdvStyle.Office2007;
                    this.radioButtonAdv2.Style = RadioButtonAdvStyle.Office2007;
                    this.radioButtonAdv1.Style = RadioButtonAdvStyle.Office2007;
                    this.radioButtonAdv1.Office2007ColorScheme = Office2007Theme.Blue;
                    this.radioButtonAdv4.Office2007ColorScheme = Office2007Theme.Blue;
                    this.radioButtonAdv3.Office2007ColorScheme = Office2007Theme.Blue;
                    this.radioButtonAdv2.Office2007ColorScheme = Office2007Theme.Blue;
                    this.radioButtonAdv5.Office2007ColorScheme = Office2007Theme.Blue;
                    this.radioButtonAdv1.BackColor = Color.FromArgb(189, 215, 252);
                    this.radioButtonAdv2.BackColor = Color.FromArgb(189, 215, 252);
                    this.radioButtonAdv3.BackColor = Color.FromArgb(189, 215, 252);
                    this.radioButtonAdv4.BackColor = Color.FromArgb(189, 215, 252);
                    this.radioButtonAdv5.BackColor = Color.FromArgb(189, 215, 252);
                    this.BackColor = Color.FromArgb(189, 215, 252);
                    this.textBox2.Style = TextBoxExt.theme.Office2007;
                    this.textBox2.Office2007ColorScheme = Office2007Theme.Blue;
                    this.checkBoxAdv2.Style = CheckBoxAdvStyle.Office2007;
                    this.checkBoxAdv2.Office2007ColorScheme = Office2007Theme.Blue;
                    this.checkBoxAdv1.Style = CheckBoxAdvStyle.Office2007;
                    this.checkBoxAdv2.Office2007ColorScheme = Office2007Theme.Blue;
                    this.checkBoxAdv3.Style = CheckBoxAdvStyle.Office2007;
                    this.checkBoxAdv2.Office2007ColorScheme = Office2007Theme.Blue;
                    this.label2.ForeColor = Color.Black;
                    this.label3.ForeColor = Color.Black;
                    this.CaptionBarColor = this.MetroColor = Color.FromArgb(189, 215, 252);
                    this.CaptionForeColor = Color.Black;
                    break;
                case "Black":
                    SetTheme(Office2007Theme.Black, 136, 136, 136, 83, 83, 83);
                    SetForeColor(Color.White);
                    blueBarItem.Checked = false;
                    blackBarItem.Checked = true;
                    silverBarItem.Checked = false;
                    this.radioButtonAdv5.Style = RadioButtonAdvStyle.Office2007;
                    this.radioButtonAdv4.Style = RadioButtonAdvStyle.Office2007;
                    this.radioButtonAdv3.Style = RadioButtonAdvStyle.Office2007;
                    this.radioButtonAdv2.Style = RadioButtonAdvStyle.Office2007;
                    this.radioButtonAdv1.Style = RadioButtonAdvStyle.Office2007;
                    this.radioButtonAdv1.Office2007ColorScheme = Office2007Theme.Black;
                    this.radioButtonAdv4.Office2007ColorScheme = Office2007Theme.Black;
                    this.radioButtonAdv3.Office2007ColorScheme = Office2007Theme.Black;
                    this.radioButtonAdv2.Office2007ColorScheme = Office2007Theme.Black;
                    this.radioButtonAdv5.Office2007ColorScheme = Office2007Theme.Black;
                    this.radioButtonAdv1.BackColor = Color.FromArgb(83, 83, 83);
                    this.radioButtonAdv2.BackColor = Color.FromArgb(83, 83, 83);
                    this.radioButtonAdv3.BackColor = Color.FromArgb(83, 83, 83);
                    this.radioButtonAdv4.BackColor = Color.FromArgb(83, 83, 83);
                    this.radioButtonAdv5.BackColor = Color.FromArgb(83, 83, 83);
                    this.BackColor = Color.FromArgb(83, 83, 83);
                    this.textBox2.Style = TextBoxExt.theme.Office2007;
                    this.textBox2.Office2007ColorScheme = Office2007Theme.Black;
                    this.checkBoxAdv2.Style = CheckBoxAdvStyle.Office2007;
                    this.checkBoxAdv2.Office2007ColorScheme = Office2007Theme.Black;
                    this.checkBoxAdv1.Style = CheckBoxAdvStyle.Office2007;
                    this.checkBoxAdv2.Office2007ColorScheme = Office2007Theme.Black;
                    this.checkBoxAdv3.Style = CheckBoxAdvStyle.Office2007;
                    this.checkBoxAdv2.Office2007ColorScheme = Office2007Theme.Black;
                    this.label2.ForeColor = Color.Black;
                    this.label3.ForeColor = Color.Black;
                    this.CaptionBarColor = this.MetroColor = Color.FromArgb(83, 83, 83);
                    this.CaptionForeColor = Color.Black;
                    break;
                case "Silver":
                    SetTheme(Office2007Theme.Silver, 178, 183, 190, 212, 214, 219);
                    SetForeColor(Color.Black);
                    blueBarItem.Checked = false;
                    blackBarItem.Checked = false;
                    silverBarItem.Checked = true;
                    this.radioButtonAdv5.Style = RadioButtonAdvStyle.Office2007;
                    this.radioButtonAdv4.Style = RadioButtonAdvStyle.Office2007;
                    this.radioButtonAdv3.Style = RadioButtonAdvStyle.Office2007;
                    this.radioButtonAdv2.Style = RadioButtonAdvStyle.Office2007;
                    this.radioButtonAdv1.Style = RadioButtonAdvStyle.Office2007;
                    this.radioButtonAdv5.Office2007ColorScheme = Office2007Theme.Silver;
                    this.radioButtonAdv4.Office2007ColorScheme = Office2007Theme.Silver;
                    this.radioButtonAdv3.Office2007ColorScheme = Office2007Theme.Silver;
                    this.radioButtonAdv2.Office2007ColorScheme = Office2007Theme.Silver;
                    this.radioButtonAdv1.Office2007ColorScheme = Office2007Theme.Silver;
                    this.radioButtonAdv1.BackColor = Color.FromArgb(212, 214, 219);
                    this.radioButtonAdv2.BackColor = Color.FromArgb(212, 214, 219);
                    this.radioButtonAdv3.BackColor = Color.FromArgb(212, 214, 219);
                    this.radioButtonAdv4.BackColor = Color.FromArgb(212, 214, 219);
                    this.radioButtonAdv5.BackColor = Color.FromArgb(212, 214, 219);
                    this.BackColor = Color.FromArgb(212, 214, 219);
                    this.textBox2.Style = TextBoxExt.theme.Office2007;
                    this.textBox2.Office2007ColorScheme = Office2007Theme.Silver;
                    this.checkBoxAdv2.Style = CheckBoxAdvStyle.Office2007;
                    this.checkBoxAdv2.Office2007ColorScheme = Office2007Theme.Silver;
                    this.checkBoxAdv1.Style = CheckBoxAdvStyle.Office2007;
                    this.checkBoxAdv2.Office2007ColorScheme = Office2007Theme.Silver;
                    this.checkBoxAdv3.Style = CheckBoxAdvStyle.Office2007;
                    this.checkBoxAdv2.Office2007ColorScheme = Office2007Theme.Silver;
                    this.label2.ForeColor = Color.Black;
                    this.label3.ForeColor = Color.Black;
                    this.CaptionBarColor = this.MetroColor = Color.FromArgb(212, 214, 219);
                    this.CaptionForeColor = Color.Black;
                    break;
            }
        }

        private void SetCheckedState(BarItem item, ParentBarItem parentBarItem)
        {
            foreach (BarItem i in parentBarItem.Items)
            {
                if (i.ID == item.ID)
                    i.Checked = true;
                else
                    i.Checked = false;
            }
        }

        private void SetForeColor(Color color)
        {
            foreach (Control c in this.Controls)
                c.ForeColor = color;
        }

        private void SetTheme(Office2007Theme theme, int r, int g, int b, int r1, int g1, int b1)
        {
            foreach (BarItem i in this.visualStyleParentBarItem.Items)
                i.Checked = false;
            this.office2007ParentBarItem.Checked = true;
            this.calculatorControl1.ButtonStyle = ButtonAppearance.Office2007;
            this.popupCalculator1.ButtonStyle = ButtonAppearance.Office2007;
			this.popupCalculator1.Office2007ColorTheme = theme;
            this.calculatorControl1.Office2007Theme = theme;
            this.mainFrameBarManager1.Style = VisualStyle.Office2007;
            this.mainFrameBarManager1.Office2007Theme = theme;
            this.buttonAdv1.Appearance = ButtonAppearance.Office2007;
            this.buttonAdv1.Office2007ColorScheme = theme;
            this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((System.Byte)(r1)), ((System.Byte)(g1)), ((System.Byte)(b1))), System.Drawing.Color.FromArgb(((System.Byte)(r)), ((System.Byte)(g)), ((System.Byte)(b))));
            this.calculatorControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((System.Byte)(r1)), ((System.Byte)(g1)), ((System.Byte)(b1))), System.Drawing.Color.FromArgb(((System.Byte)(r)), ((System.Byte)(g)), ((System.Byte)(b))));
            foreach (Control c in this.gradientPanel1.Controls)
            {
                if (c is GradientPanel)
                {
                    GradientPanel panel = c as GradientPanel;
                    panel.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((System.Byte)(r1)), ((System.Byte)(g1)), ((System.Byte)(b1))), System.Drawing.Color.FromArgb(((System.Byte)(r)), ((System.Byte)(g)), ((System.Byte)(b))));
                    panel.BorderColor = Color.FromArgb(r, g, b);
                }
                else if (c is GradientLabel)
                {
                    GradientLabel label = c as GradientLabel;
                    label.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((System.Byte)(r1)), ((System.Byte)(g1)), ((System.Byte)(b1))), System.Drawing.Color.FromArgb(((System.Byte)(r)), ((System.Byte)(g)), ((System.Byte)(b))));
                }
            }
        }

        private void SetTheme(int r, int g, int b, int r1, int g1, int b1)
        {
            foreach (Control c in this.gradientPanel1.Controls)
            {
                if (c is GradientPanel)
                {
                    GradientPanel panel = c as GradientPanel;
                    panel.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((System.Byte)(r1)), ((System.Byte)(g1)), ((System.Byte)(b1))), System.Drawing.Color.FromArgb(((System.Byte)(r)), ((System.Byte)(g)), ((System.Byte)(b))));
                    panel.BorderColor = Color.FromArgb(r, g, b);
                }
                else if (c is GradientLabel)
                {
                    GradientLabel label = c as GradientLabel;
                    label.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((System.Byte)(r1)), ((System.Byte)(g1)), ((System.Byte)(b1))), System.Drawing.Color.FromArgb(((System.Byte)(r)), ((System.Byte)(g)), ((System.Byte)(b))));
                }
            }
            this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((System.Byte)(r1)), ((System.Byte)(g1)), ((System.Byte)(b1))), System.Drawing.Color.FromArgb(((System.Byte)(r)), ((System.Byte)(g)), ((System.Byte)(b))));
            this.calculatorControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((System.Byte)(r1)), ((System.Byte)(g1)), ((System.Byte)(b1))), System.Drawing.Color.FromArgb(((System.Byte)(r)), ((System.Byte)(g)), ((System.Byte)(b))));
            foreach (BarItem i in this.office2007ParentBarItem.Items)
                i.Checked = false;
        }

        #endregion

        #region LayoutType
        private void OnRadioLayoutTypeCheckedChange(object sender, System.EventArgs e)
        {
            if (sender == radioButtonAdv4)
                this.calculatorControl1.LayoutType = Syncfusion.Windows.Forms.Tools.CalculatorLayoutTypes.WindowsStandard;
            else if (sender == radioButtonAdv5)
                this.calculatorControl1.LayoutType = Syncfusion.Windows.Forms.Tools.CalculatorLayoutTypes.Financial;
        }
        #endregion

        #region UseVerticalAndHorizontalSpacing
        private void checkBoxAdv2_CheckStateChanged(object sender, System.EventArgs e)
        {
            this.calculatorControl1.UseVerticalAndHorizontalSpacing = this.checkBoxAdv2.Checked;
        }
        #endregion

        #region DisplayTextAlign
        private void OnRadioDisplayCheckedChange(object sender, System.EventArgs e)
        {
            if (sender == radioButtonAdv1)
                this.calculatorControl1.DisplayTextAlign = HorizontalAlignment.Left;
            else if (sender == radioButtonAdv2)
                this.calculatorControl1.DisplayTextAlign = HorizontalAlignment.Right;
            else if (sender == radioButtonAdv3)
                this.calculatorControl1.DisplayTextAlign = HorizontalAlignment.Center;
        }

        #endregion

        #region SpacingEvents
        private void numericUpDownExt1_ValueChanged(object sender, System.EventArgs e)
        {
            if (this.checkBoxAdv3.Checked)
                this.calculatorControl1.VerticalSpacing = Convert.ToInt32(this.numericUpDownExt1.Value);
        }

        private void numericUpDownExt2_ValueChanged(object sender, System.EventArgs e)
        {
            if (this.checkBoxAdv3.Checked)
                this.calculatorControl1.HorizontalSpacing = Convert.ToInt32(this.numericUpDownExt2.Value);
        }
        #endregion

    }
}
