#region Copyright Syncfusion Inc. 2001 - 2023
//
//  Copyright Syncfusion Inc. 2001 - 2023. All rights reserved.
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
    using Syncfusion.WinForms.Themes;
    using Syncfusion.WinForms.Controls;

    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class MainForm : SfForm
    {
        public Syncfusion.Windows.Forms.Tools.CalculatorControl calculatorControl1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBox2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
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
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem office2016ParentBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem blueBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem blackBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem silverBarItem;
        private BarItem barItem6;
        private BarItem barItem8;
        private BarItem barItem9;
        private BarItem barItem10;
        private BarItem barItem11;
        private CalculatorControl calculatorControl2;
        private Label label2;
        private Label label1;
        private Panel panel1;
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
            this.barItem5.Checked = true;
            this.calculatorControl1.ThemeName = "Office2019Colorful";
            this.calculatorControl2.ThemeName = "Office2019Colorful";
            SetTheme(197, 197, 197, 255, 255, 255);
            SetForeColor(Color.Black);
            this.calculatorControl1.BorderStyle = Border3DStyle.Flat;
            this.calculatorControl1.Size = new System.Drawing.Size(292, 250);
            this.calculatorControl2.Size = new System.Drawing.Size(292, 250);
            this.mainFrameBarManager1.Style = VisualStyle.Office2016White;
            this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#FFFFFF"));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.textBox2.ThemeName = "Office2019Colorful";
            this.Style.TitleBar.ForeColor = Color.Black;
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.calculatorControl2 = new Syncfusion.Windows.Forms.Tools.CalculatorControl();
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "MainMenu");
            this.visualStyleParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.office2016ParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem9 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem10 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem11 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.blueBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.blackBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.silverBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // calculatorControl1
            // 
            this.calculatorControl1.AccessibleDescription = "Calculator control";
            this.calculatorControl1.AccessibleName = "Calculator Control";
            this.calculatorControl1.AutoScroll = true;
            this.calculatorControl1.BeforeTouchSize = new System.Drawing.Size(292, 250);
            this.calculatorControl1.BorderStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.calculatorControl1.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.calculatorControl1.Culture = new System.Globalization.CultureInfo("en-US");
            this.calculatorControl1.DoubleValue = 0D;
            this.calculatorControl1.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.calculatorControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calculatorControl1.HorizontalSpacing = 3;
            this.calculatorControl1.Location = new System.Drawing.Point(77, 72);
            this.calculatorControl1.MetroColor = System.Drawing.SystemColors.Control;
            this.calculatorControl1.Name = "calculatorControl1";
            this.calculatorControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.calculatorControl1.Size = new System.Drawing.Size(292, 250);
            this.calculatorControl1.TabIndex = 0;
            this.calculatorControl1.ThemeName = "Metro";
            this.calculatorControl1.ThemesEnabled = false;
            this.calculatorControl1.UseVerticalAndHorizontalSpacing = true;
            this.calculatorControl1.UseVisualStyle = true;
            this.calculatorControl1.VerticalSpacing = 3;
            this.calculatorControl1.ValueCalculated += new Syncfusion.Windows.Forms.Tools.CalculatorValueCalculatedEventHandler(this.calculatorControl1_ValueCalculated);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // textBox2
            // 
            this.textBox2.BeforeTouchSize = new System.Drawing.Size(718, 105);
            this.textBox2.BorderColor = System.Drawing.Color.Gray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox2.Location = new System.Drawing.Point(10, 403);
            this.textBox2.Metrocolor = System.Drawing.Color.Gray;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(718, 105);
            this.textBox2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textBox2.TabIndex = 4;
            this.textBox2.ThemeName = "Metro";
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderColor = System.Drawing.Color.Silver;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.calculatorControl2);
            this.gradientPanel1.Controls.Add(this.calculatorControl1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(10, 42);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(718, 353);
            this.gradientPanel1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Financial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "WindowsStandard";
            // 
            // calculatorControl2
            // 
            this.calculatorControl2.AccessibleDescription = "Calculator control";
            this.calculatorControl2.AccessibleName = "Calculator Control";
            this.calculatorControl2.AutoScroll = true;
            this.calculatorControl2.BeforeTouchSize = new System.Drawing.Size(292, 250);
            this.calculatorControl2.BorderStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.calculatorControl2.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.calculatorControl2.Culture = new System.Globalization.CultureInfo("en-US");
            this.calculatorControl2.DoubleValue = 0D;
            this.calculatorControl2.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.calculatorControl2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorControl2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calculatorControl2.HorizontalSpacing = 3;
            this.calculatorControl2.LayoutType = Syncfusion.Windows.Forms.Tools.CalculatorLayoutTypes.Financial;
            this.calculatorControl2.Location = new System.Drawing.Point(398, 72);
            this.calculatorControl2.MetroColor = System.Drawing.SystemColors.Control;
            this.calculatorControl2.Name = "calculatorControl2";
            this.calculatorControl2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.calculatorControl2.Size = new System.Drawing.Size(292, 250);
            this.calculatorControl2.TabIndex = 20;
            this.calculatorControl2.Text = "calculatorControl2";
            this.calculatorControl2.ThemeName = "Metro";
            this.calculatorControl2.ThemesEnabled = false;
            this.calculatorControl2.UseVerticalAndHorizontalSpacing = true;
            this.calculatorControl2.UseVisualStyle = true;
            this.calculatorControl2.VerticalSpacing = 3;
            this.calculatorControl2.ValueCalculated += new Syncfusion.Windows.Forms.Tools.CalculatorValueCalculatedEventHandler(this.calculatorControl2_ValueCalculated);
            // 
            // mainFrameBarManager1
            // 
#if !NETCORE
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
#endif
            this.mainFrameBarManager1.Bars.Add(this.bar1);
            this.mainFrameBarManager1.Categories.Add("VisualStyles");
            this.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.WinForms.Controls.SfForm";
            this.mainFrameBarManager1.EnableMenuMerge = true;
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.barItem4,
            this.visualStyleParentBarItem,
            this.barItem7,
            this.barItem5,
            this.office2016ParentBarItem,
            this.blueBarItem,
            this.blackBarItem,
            this.silverBarItem,
            this.barItem6,
            this.barItem8,
            this.barItem9,
            this.barItem10,
            this.barItem11});
            this.mainFrameBarManager1.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.mainFrameBarManager1.ResetCustomization = false;
            this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.mainFrameBarManager1.ThemeName = "Metro";
            this.mainFrameBarManager1.ThemeStyle.ComboBoxBarItemStyle.ArrowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mainFrameBarManager1.UseBackwardCompatiblity = false;
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
            this.barItem5,
            this.office2016ParentBarItem,
            this.barItem6});
            this.visualStyleParentBarItem.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.visualStyleParentBarItem.ShowToolTipInPopUp = false;
            this.visualStyleParentBarItem.SizeToFit = true;
            this.visualStyleParentBarItem.Text = "&Visual Styles";
            this.visualStyleParentBarItem.WrapLength = 20;
            // 
            // barItem5
            // 
            this.barItem5.BarName = "barItem5";
            this.barItem5.CategoryIndex = 0;
            this.barItem5.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem5.ID = "Office2019Colorful";
            this.barItem5.ShowToolTipInPopUp = false;
            this.barItem5.SizeToFit = true;
            this.barItem5.Text = "Office2019";
            this.barItem5.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // office2016ParentBarItem
            // 
            this.office2016ParentBarItem.BarName = "office2016ParentBarItem";
            this.office2016ParentBarItem.CategoryIndex = 0;
            this.office2016ParentBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.office2016ParentBarItem.ID = "Office2016";
            this.office2016ParentBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem8,
            this.barItem9,
            this.barItem10,
            this.barItem11});
            this.office2016ParentBarItem.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.office2016ParentBarItem.ShowToolTipInPopUp = false;
            this.office2016ParentBarItem.SizeToFit = true;
            this.office2016ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.office2016ParentBarItem.Text = "Office2016";
            this.office2016ParentBarItem.WrapLength = 20;
            // 
            // barItem8
            // 
            this.barItem8.BarName = "barItem8";
            this.barItem8.CategoryIndex = 0;
            this.barItem8.ID = "Office2016White";
            this.barItem8.ShowToolTipInPopUp = false;
            this.barItem8.SizeToFit = true;
            this.barItem8.Text = "Office2016White";
            this.barItem8.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem9
            // 
            this.barItem9.BarName = "barItem9";
            this.barItem9.CategoryIndex = 0;
            this.barItem9.ID = "Office2016Colorful";
            this.barItem9.ShowToolTipInPopUp = false;
            this.barItem9.SizeToFit = true;
            this.barItem9.Text = "Office2016Colorful";
            this.barItem9.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem10
            // 
            this.barItem10.BarName = "barItem10";
            this.barItem10.CategoryIndex = 0;
            this.barItem10.ID = "Office2016Black";
            this.barItem10.ShowToolTipInPopUp = false;
            this.barItem10.SizeToFit = true;
            this.barItem10.Text = "Office2016Black";
            this.barItem10.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem11
            // 
            this.barItem11.BarName = "barItem11";
            this.barItem11.CategoryIndex = 0;
            this.barItem11.ID = "Office2016DarkGray";
            this.barItem11.ShowToolTipInPopUp = false;
            this.barItem11.SizeToFit = true;
            this.barItem11.Text = "Office2016DarkGray";
            this.barItem11.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem6
            // 
            this.barItem6.BarName = "barItem6";
            this.barItem6.CategoryIndex = 0;
            this.barItem6.ID = "Metro";
            this.barItem6.ShowToolTipInPopUp = false;
            this.barItem6.SizeToFit = true;
            this.barItem6.Text = "Metro";
            this.barItem6.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.BarName = "parentBarItem2";
            this.parentBarItem2.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem2.ShowToolTipInPopUp = false;
            this.parentBarItem2.SizeToFit = true;
            this.parentBarItem2.WrapLength = 20;
            // 
            // barItem1
            // 
            this.barItem1.BarName = "barItem1";
            this.barItem1.ID = "_1";
            this.barItem1.ShowToolTipInPopUp = false;
            this.barItem1.SizeToFit = true;
            // 
            // barItem2
            // 
            this.barItem2.BarName = "barItem2";
            this.barItem2.ID = "_2";
            this.barItem2.ShowToolTipInPopUp = false;
            this.barItem2.SizeToFit = true;
            // 
            // barItem3
            // 
            this.barItem3.BarName = "barItem3";
            this.barItem3.ID = "_3";
            this.barItem3.ShowToolTipInPopUp = false;
            this.barItem3.SizeToFit = true;
            // 
            // barItem4
            // 
            this.barItem4.BarName = "barItem4";
            this.barItem4.ID = "_4";
            this.barItem4.ShowToolTipInPopUp = false;
            this.barItem4.SizeToFit = true;
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
            // blueBarItem
            // 
            this.blueBarItem.BarName = "blueBarItem";
            this.blueBarItem.ID = "_5";
            this.blueBarItem.ShowToolTipInPopUp = false;
            this.blueBarItem.SizeToFit = true;
            // 
            // blackBarItem
            // 
            this.blackBarItem.BarName = "blackBarItem";
            this.blackBarItem.ID = "_6";
            this.blackBarItem.ShowToolTipInPopUp = false;
            this.blackBarItem.SizeToFit = true;
            // 
            // silverBarItem
            // 
            this.silverBarItem.BarName = "silverBarItem";
            this.silverBarItem.ID = "_7";
            this.silverBarItem.ShowToolTipInPopUp = false;
            this.silverBarItem.SizeToFit = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 395);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 8);
            this.panel1.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.ClientSize = new System.Drawing.Size(738, 518);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator Control";
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
            SkinManager.LoadAssembly(typeof(Office2019Theme).Assembly);
            Application.Run(new MainForm());
        }


        #region ValueCalculated
        /// <summary>
        /// The value has changed for the CalculatorControl.
        /// </summary>
        /// <param name="sender">The CalculatorControl raising the event.</param>
        /// <param name="arg">The event data.</param>

        private void CodeGen_calculatorControl1_ValueCalculated(object sender, CalculatorValueCalculatedEventArgs arg)
        {
            this.calculatorControl1.ValueCalculated += new Syncfusion.Windows.Forms.Tools.CalculatorValueCalculatedEventHandler(this.CodeGen_calculatorControl1_ValueCalculated);
        }

        private void CodeGen_calculatorControl2_ValueCalculated(object sender, CalculatorValueCalculatedEventArgs arg)
        {
            this.calculatorControl2.ValueCalculated += new CalculatorValueCalculatedEventHandler(this.CodeGen_calculatorControl2_ValueCalculated);
        }
       
        private void calculatorControl1_ValueCalculated(object sender, Syncfusion.Windows.Forms.Tools.CalculatorValueCalculatedEventArgs arg)
        {
            //Event logging
            string item = arg.Value.ToString();
            string eventlogmessage = String.Format("Event: {0} Value: {1}\r\n", "ValueCalculated", item);
            textBox2.Text = textBox2.Text + eventlogmessage;

        }

        private void calculatorControl2_ValueCalculated(object sender, CalculatorValueCalculatedEventArgs arg)
        {
            string item1 = arg.Value.ToString();
            string eventlogmessage1 = string.Format("Event: {0} Value: {1}\r\n", "ValueCalculated", item1);
            textBox2.Text = textBox2.Text + eventlogmessage1;
        }
        #endregion

        #region Theme Effects

        private void OnBarItemClick(object sender, EventArgs e)
        {
            BarItem item = sender as BarItem;
            switch (item.ID)
            {
                case "Metro":
                    this.calculatorControl1.ButtonStyle = ButtonAppearance.Metro;
                    this.calculatorControl2.ButtonStyle = ButtonAppearance.Metro;
                    SetCheckedState(item, this.visualStyleParentBarItem);
                    SetTheme(225, 225, 225, 225, 225, 225);
                    SetForeColor(Color.Black);
                    this.calculatorControl1.BorderStyle = Border3DStyle.Flat;
                    this.mainFrameBarManager1.Style = VisualStyle.Metro;
                    this.calculatorControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                    this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                    this.BackColor = Color.White;
                    this.textBox2.Style = TextBoxExt.theme.Office2016White;
                    this.Style.TitleBar.BackColor = Color.FromArgb(242, 242, 242);
                    this.Style.TitleBar.ForeColor = Color.Black;
                    this.Style.TitleBar.MinimizeButtonForeColor = Color.Black;
                    this.Style.TitleBar.MaximizeButtonForeColor = Color.Black;
                    this.Style.TitleBar.CloseButtonForeColor = Color.Black;
                    break;
                case "Office2016White":
                    this.calculatorControl1.ButtonStyle = ButtonAppearance.Office2016White;
                    this.calculatorControl2.ButtonStyle = ButtonAppearance.Office2016White;
                    SetCheckedState(item, this.visualStyleParentBarItem);
                    SetTheme(197, 197, 197, 255, 255, 255);
                    SetForeColor(Color.Black);
                    this.office2016ParentBarItem.Checked = true;
                    barItem8.Checked = true;
                    barItem9.Checked = false;
                    barItem10.Checked = false;
                    barItem11.Checked = false;
                    this.calculatorControl1.BorderStyle = Border3DStyle.Flat;
                    this.mainFrameBarManager1.Style = VisualStyle.Office2016White;
                    this.calculatorControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#FFFFFF"));
                    this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#FFFFFF"));
                    this.BackColor = Color.White;
                    this.textBox2.Style = TextBoxExt.theme.Office2016White;
                    this.Style.TitleBar.BackColor = Color.FromArgb(242, 242, 242);
                    this.Style.TitleBar.ForeColor = Color.Black;
                    this.Style.TitleBar.MinimizeButtonForeColor = Color.Black;
                    this.Style.TitleBar.MaximizeButtonForeColor = Color.Black;
                    this.Style.TitleBar.CloseButtonForeColor = Color.Black;
                    break;
                case "Office2016Black":
                    this.calculatorControl1.ButtonStyle = ButtonAppearance.Office2016Black;
                    this.calculatorControl2.ButtonStyle = ButtonAppearance.Office2016Black;
                    SetCheckedState(item, this.visualStyleParentBarItem);
                    SetTheme(68, 68, 68, 38, 38, 38);
                    SetForeColor(Color.White);
                    this.office2016ParentBarItem.Checked = true;
                    barItem8.Checked = false;
                    barItem9.Checked = false;
                    barItem10.Checked = true;
                    barItem11.Checked = false;
                    this.calculatorControl1.BorderStyle = Border3DStyle.Flat;
                    this.mainFrameBarManager1.Style = VisualStyle.Office2016Black;
                    this.calculatorControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#262626"));
                    this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#262626"));
                    this.BackColor = ColorTranslator.FromHtml("#262626");
                    this.textBox2.Style = TextBoxExt.theme.Office2016Black;
                    this.Style.TitleBar.BackColor = Color.Black;
                    this.Style.TitleBar.ForeColor = Color.White;
                    this.Style.TitleBar.MinimizeButtonForeColor = Color.White;
                    this.Style.TitleBar.MaximizeButtonForeColor = Color.White;
                    this.Style.TitleBar.CloseButtonForeColor = Color.White;
                    break;
                case "Office2016Colorful":
                    this.calculatorControl1.ButtonStyle = ButtonAppearance.Office2016Colorful;
                    this.calculatorControl2.ButtonStyle = ButtonAppearance.Office2016Colorful;
                    SetCheckedState(item, this.visualStyleParentBarItem);
                    SetTheme(197, 197, 197, 255, 255, 255);
                    SetForeColor(Color.Black);
                    this.office2016ParentBarItem.Checked = true;
                    barItem8.Checked = false;
                    barItem9.Checked = true;
                    barItem10.Checked = false;
                    barItem11.Checked = false;
                    this.calculatorControl1.BorderStyle = Border3DStyle.Flat;
                    this.mainFrameBarManager1.Style = VisualStyle.Office2016Colorful;
                    this.calculatorControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#FFFFFF"));
                    this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#FFFFFF"));
                    this.BackColor = Color.White;
                    this.textBox2.Style = TextBoxExt.theme.Office2016Colorful;
                    this.Style.TitleBar.BackColor = Color.FromArgb(242, 242, 242);
                    this.Style.TitleBar.ForeColor = Color.Black;
                    this.Style.TitleBar.MinimizeButtonForeColor = Color.Black;
                    this.Style.TitleBar.MaximizeButtonForeColor = Color.Black;
                    this.Style.TitleBar.CloseButtonForeColor = Color.Black;
                    break;
                case "Office2019Colorful":
                    this.calculatorControl1.ThemeName = "Office2019Colorful";
                    this.calculatorControl2.ThemeName = "Office2019Colorful";
                    SetCheckedState(item, this.visualStyleParentBarItem);
                    SetTheme(225, 225, 225, 225, 225, 225);
                    SetForeColor(Color.Black);
                    this.calculatorControl1.BorderStyle = Border3DStyle.Flat;
                    this.mainFrameBarManager1.Style = VisualStyle.Office2016White;
                    this.calculatorControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                    this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.White);
                    this.BackColor = Color.White;
                    this.textBox2.ThemeName= "Office2019Colorful";
                    this.Style.TitleBar.BackColor = Color.FromArgb(242, 242, 242);
                    this.Style.TitleBar.ForeColor = Color.Black;
                    this.Style.TitleBar.MinimizeButtonForeColor = Color.Black;
                    this.Style.TitleBar.MaximizeButtonForeColor = Color.Black;
                    this.Style.TitleBar.CloseButtonForeColor = Color.Black;
                    break;
                case "Office2016DarkGray":
                    this.calculatorControl1.ButtonStyle = ButtonAppearance.Office2016DarkGray;
                    this.calculatorControl2.ButtonStyle = ButtonAppearance.Office2016DarkGray;
                    SetCheckedState(item, this.visualStyleParentBarItem);
                    SetTheme(68, 68, 68, 102, 102, 102);
                    SetForeColor(Color.White);
                    this.office2016ParentBarItem.Checked = true;
                    barItem8.Checked = false;
                    barItem9.Checked = false;
                    barItem10.Checked = false;
                    barItem11.Checked = true;
                    this.calculatorControl1.BorderStyle = Border3DStyle.Flat;
                    this.mainFrameBarManager1.Style = VisualStyle.Office2016DarkGray;
                    this.visualStyleParentBarItem.CustomActiveTextColor = Color.White;
                    this.calculatorControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#666666"));
                    this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#666666"));
                    this.textBox2.Style = TextBoxExt.theme.Office2016DarkGray;
                    this.BackColor = Color.FromArgb(102, 102, 102);
                    this.Style.TitleBar.BackColor = Color.DarkGray;
                    this.Style.TitleBar.ForeColor = Color.Black;
                    this.Style.TitleBar.MinimizeButtonForeColor = Color.White;
                    this.Style.TitleBar.MaximizeButtonForeColor = Color.White;
                    this.Style.TitleBar.CloseButtonForeColor = Color.White;
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
            this.office2016ParentBarItem.Checked = true;
            this.calculatorControl1.ButtonStyle = ButtonAppearance.Office2007;
            this.calculatorControl1.Office2007Theme = theme;
            this.mainFrameBarManager1.Style = VisualStyle.Office2007;
            this.mainFrameBarManager1.Office2007Theme = theme;
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
            foreach (BarItem i in this.office2016ParentBarItem.Items)
                i.Checked = false;
        }

        #endregion
      
    }
}
