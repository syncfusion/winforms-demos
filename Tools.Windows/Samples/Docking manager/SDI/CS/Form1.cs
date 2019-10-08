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
namespace SDIDemo
{
    using System;
    using System.Drawing;
    using System.Collections;
    using System.ComponentModel;
    using System.Windows.Forms;
    using System.Data;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;
    using Microsoft.Win32;
    using System.Drawing.Drawing2D;
    using Syncfusion.Licensing;
    using Syncfusion.WinForms.Controls;
    using Syncfusion.WinForms.Themes;
    using Syncfusion.HighContrastTheme.WinForms;

    public partial class Form1 : SfForm
    {
        #region

        private System.Windows.Forms.Panel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.DockingManager dockingManager1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel12;
        private System.Windows.Forms.Panel gradientPanel2;
        private System.Windows.Forms.Panel gradientPanel3;
        private System.Windows.Forms.Panel gradientPanel4;
        private System.Windows.Forms.Panel gradientPanel5;
        private System.Windows.Forms.Panel gradientPanel6;
        private System.Windows.Forms.Panel gradientPanel7;
        private System.Windows.Forms.Panel gradientPanel8;
        private System.Windows.Forms.Panel gradientPanel9;
        private System.Windows.Forms.Panel gradientPanel10;
        private System.Windows.Forms.Panel gradientPanel11;
        private System.Windows.Forms.Label autoLabel6;
        private System.Windows.Forms.Label autoLabel5;
        private System.Windows.Forms.Label autoLabel2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv3;

        #endregion

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Form1()
        {
            
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(GetIconFile(@"..\\..\\\App.ico")));
                this.Icon = ico;
            }
            catch { }
            InitEvents();
            this.dockingManager1.ShowMetroCaptionDottedLines = false;
            this.dockingManager1.ThemeStyle.ShowCaptionDottedLines = false;
#if NETCORE
            UpdateLayout();
#endif
        }

        #region Icon
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


#endregion

        /// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
        public static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon .FindLicenseKey());
            SkinManager.LoadAssembly(typeof(Office2019Theme).Assembly);
            SkinManager.LoadAssembly(typeof(HighContrastTheme).Assembly);
            Application.Run(new Form1());
        }

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
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbgradientPanel1 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbgradientPanel2 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbgradientPanel3 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbgradientPanel4 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbgradientPanel5 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbgradientPanel6 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbgradientPanel7 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbgradientPanel8 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbgradientPanel9 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbgradientPanel10 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbgradientPanel11 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            this.dockingManager1 = new Syncfusion.Windows.Forms.Tools.DockingManager(this.components);
            this.gradientPanel1 = new System.Windows.Forms.Panel();
            this.gradientPanel2 = new System.Windows.Forms.Panel();
            this.gradientPanel3 = new System.Windows.Forms.Panel();
            this.gradientPanel4 = new System.Windows.Forms.Panel();
            this.gradientPanel5 = new System.Windows.Forms.Panel();
            this.gradientPanel6 = new System.Windows.Forms.Panel();
            this.gradientPanel7 = new System.Windows.Forms.Panel();
            this.gradientPanel8 = new System.Windows.Forms.Panel();
            this.gradientPanel9 = new System.Windows.Forms.Panel();
            this.gradientPanel10 = new System.Windows.Forms.Panel();
            this.gradientPanel11 = new System.Windows.Forms.Panel();
            this.gradientPanel12 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.comboBoxAdv3 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.autoLabel6 = new System.Windows.Forms.Label();
            this.autoLabel5 = new System.Windows.Forms.Label();
            this.autoLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).BeginInit();
            this.gradientPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dockingManager1
            // 
            this.dockingManager1.AnimateAutoHiddenWindow = true;
            this.dockingManager1.AutoHideTabForeColor = System.Drawing.Color.Empty;
            this.dockingManager1.CloseTabOnMiddleClick = false;
#if !NETCORE
            this.dockingManager1.DockLayoutStream = ((System.IO.MemoryStream)(resources.GetObject("dockingManager1.DockLayoutStream")));
#endif
            this.dockingManager1.HostControl = this;
            this.dockingManager1.MetroButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dockingManager1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.dockingManager1.MetroSplitterBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(159)))), ((int)(((byte)(183)))));
            this.dockingManager1.ReduceFlickeringInRtl = false;
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Restore, "RestoreButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"));
            this.dockingManager1.SetDockLabel(this.gradientPanel1, "gradientPanel1");
            this.dockingManager1.SetEnableDocking(this.gradientPanel1, true);
            ccbgradientPanel1.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.gradientPanel1, ccbgradientPanel1);
            this.dockingManager1.SetDockLabel(this.gradientPanel2, "gradientPanel2");
            this.dockingManager1.SetEnableDocking(this.gradientPanel2, true);
            ccbgradientPanel2.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.gradientPanel2, ccbgradientPanel2);
            this.dockingManager1.SetDockLabel(this.gradientPanel3, "gradientPanel3");
            this.dockingManager1.SetEnableDocking(this.gradientPanel3, true);
            ccbgradientPanel3.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.gradientPanel3, ccbgradientPanel3);
            this.dockingManager1.SetDockLabel(this.gradientPanel4, "gradientPanel4");
            this.dockingManager1.SetEnableDocking(this.gradientPanel4, true);
            ccbgradientPanel4.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.gradientPanel4, ccbgradientPanel4);
            this.dockingManager1.SetDockLabel(this.gradientPanel5, "gradientPanel5");
            this.dockingManager1.SetEnableDocking(this.gradientPanel5, true);
            ccbgradientPanel5.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.gradientPanel5, ccbgradientPanel5);
            this.dockingManager1.SetDockLabel(this.gradientPanel6, "gradientPanel6");
            this.dockingManager1.SetEnableDocking(this.gradientPanel6, true);
            ccbgradientPanel6.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.gradientPanel6, ccbgradientPanel6);
            this.dockingManager1.SetDockLabel(this.gradientPanel7, "gradientPanel7");
            this.dockingManager1.SetEnableDocking(this.gradientPanel7, true);
            ccbgradientPanel7.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.gradientPanel7, ccbgradientPanel7);
            this.dockingManager1.SetDockLabel(this.gradientPanel8, "gradientPanel8");
            this.dockingManager1.SetEnableDocking(this.gradientPanel8, true);
            ccbgradientPanel8.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.gradientPanel8, ccbgradientPanel8);
            this.dockingManager1.SetDockLabel(this.gradientPanel9, "gradientPanel9");
            this.dockingManager1.SetEnableDocking(this.gradientPanel9, true);
            ccbgradientPanel9.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.gradientPanel9, ccbgradientPanel9);
            this.dockingManager1.SetDockLabel(this.gradientPanel10, "gradientPanel10");
            this.dockingManager1.SetEnableDocking(this.gradientPanel10, true);
            ccbgradientPanel10.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.gradientPanel10, ccbgradientPanel10);
            this.dockingManager1.SetDockLabel(this.gradientPanel11, "gradientPanel11");
            this.dockingManager1.SetEnableDocking(this.gradientPanel11, true);
            ccbgradientPanel11.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.gradientPanel11, ccbgradientPanel11);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Location = new System.Drawing.Point(1, 24);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(75, 693);
            this.gradientPanel1.TabIndex = 0;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Location = new System.Drawing.Point(1, 24);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(63, 693);
            this.gradientPanel2.TabIndex = 2;
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.Location = new System.Drawing.Point(1, 24);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(69, 693);
            this.gradientPanel3.TabIndex = 3;
            // 
            // gradientPanel4
            // 
            this.gradientPanel4.Location = new System.Drawing.Point(1, 24);
            this.gradientPanel4.Name = "gradientPanel4";
            this.gradientPanel4.Size = new System.Drawing.Size(59, 693);
            this.gradientPanel4.TabIndex = 8;
            // 
            // gradientPanel5
            // 
            this.gradientPanel5.Location = new System.Drawing.Point(1, 24);
            this.gradientPanel5.Name = "gradientPanel5";
            this.gradientPanel5.Size = new System.Drawing.Size(66, 693);
            this.gradientPanel5.TabIndex = 9;
            // 
            // gradientPanel6
            // 
            this.gradientPanel6.Location = new System.Drawing.Point(1, 24);
            this.gradientPanel6.Name = "gradientPanel6";
            this.gradientPanel6.Size = new System.Drawing.Size(71, 693);
            this.gradientPanel6.TabIndex = 14;
            // 
            // gradientPanel7
            // 
            this.gradientPanel7.Location = new System.Drawing.Point(1, 24);
            this.gradientPanel7.Name = "gradientPanel7";
            this.gradientPanel7.Size = new System.Drawing.Size(90, 693);
            this.gradientPanel7.TabIndex = 15;
            // 
            // gradientPanel8
            // 
            this.gradientPanel8.Location = new System.Drawing.Point(1, 24);
            this.gradientPanel8.Name = "gradientPanel8";
            this.gradientPanel8.Size = new System.Drawing.Size(87, 693);
            this.gradientPanel8.TabIndex = 20;
            // 
            // gradientPanel9
            // 
            this.gradientPanel9.Location = new System.Drawing.Point(1, 24);
            this.gradientPanel9.Name = "gradientPanel9";
            this.gradientPanel9.Size = new System.Drawing.Size(74, 693);
            this.gradientPanel9.TabIndex = 22;
            // 
            // gradientPanel10
            // 
            this.gradientPanel10.Location = new System.Drawing.Point(1, 24);
            this.gradientPanel10.Name = "gradientPanel10";
            this.gradientPanel10.Size = new System.Drawing.Size(83, 693);
            this.gradientPanel10.TabIndex = 24;
            // 
            // gradientPanel11
            // 
            this.gradientPanel11.Location = new System.Drawing.Point(1, 24);
            this.gradientPanel11.Name = "gradientPanel11";
            this.gradientPanel11.Size = new System.Drawing.Size(50, 693);
            this.gradientPanel11.TabIndex = 26;
            // 
            // gradientPanel12
            // 
            this.gradientPanel12.Controls.Add(this.comboBoxAdv3);
            this.gradientPanel12.Controls.Add(this.comboBoxAdv1);
            this.gradientPanel12.Controls.Add(this.autoLabel6);
            this.gradientPanel12.Controls.Add(this.autoLabel5);
            this.gradientPanel12.Controls.Add(this.autoLabel2);
            this.gradientPanel12.Dock = System.Windows.Forms.DockStyle.Right;
            this.gradientPanel12.Location = new System.Drawing.Point(860, 2);
            this.gradientPanel12.Name = "gradientPanel12";
            this.gradientPanel12.Size = new System.Drawing.Size(300, 718);
            this.gradientPanel12.TabIndex = 28;
            // 
            // comboBoxAdv3
            // 
            this.comboBoxAdv3.BeforeTouchSize = new System.Drawing.Size(161, 21);
            this.comboBoxAdv3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv3.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Top",
            "Bottom"});
            this.comboBoxAdv3.Location = new System.Drawing.Point(126, 73);
            this.comboBoxAdv3.Name = "comboBoxAdv3";
            this.comboBoxAdv3.Size = new System.Drawing.Size(161, 21);
            this.comboBoxAdv3.TabIndex = 39;
            this.comboBoxAdv3.Text = "Left";
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(161, 21);
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Metro",
            "Office2016Colorful",
            "Office2016White",
            "Office2016Black",
            "Office2016DarkGray",
            "Office2019Colorful",
            "HighContrastBlack"});
            this.comboBoxAdv1.Location = new System.Drawing.Point(126, 117);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(161, 21);
            this.comboBoxAdv1.TabIndex = 37;
            this.comboBoxAdv1.Text = "Metro";
            // 
            // autoLabel6
            // 
            this.autoLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel6.Location = new System.Drawing.Point(88, 24);
            this.autoLabel6.Name = "autoLabel6";
            this.autoLabel6.Size = new System.Drawing.Size(81, 20);
            this.autoLabel6.TabIndex = 36;
            this.autoLabel6.Text = "Properties";
            // 
            // autoLabel5
            // 
            this.autoLabel5.Location = new System.Drawing.Point(7, 117);
            this.autoLabel5.Name = "autoLabel5";
            this.autoLabel5.Size = new System.Drawing.Size(69, 13);
            this.autoLabel5.TabIndex = 32;
            this.autoLabel5.Text = "Visual Style";
            // 
            // autoLabel2
            // 
            this.autoLabel2.Location = new System.Drawing.Point(7, 73);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(113, 13);
            this.autoLabel2.TabIndex = 31;
            this.autoLabel2.Text = "Dock Tab Alignment";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 722);
            this.Controls.Add(this.gradientPanel12);
            this.Name = "Form1";
            this.Text = "Docking Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).EndInit();
            this.gradientPanel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            this.ResumeLayout(false);

        }

#endregion
        private void InitEvents()
        {
            this.comboBoxAdv1.SelectedIndexChanged += VisualStyle_Changed;
            this.comboBoxAdv3.SelectedIndexChanged += DockTabAlignmentChanged;
            this.dockingManager1.NewDockStateEndLoad += DockingManager1_NewDockStateEndLoad;
        }

#region Setting of DockTabAlignment style
        /// <summary>
        /// Updates the dock tab alignment of DockingManager.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DockTabAlignmentChanged(object sender, EventArgs e)
        {
            if (this.comboBoxAdv3.SelectedItem.ToString() == "Left")
            {
                this.dockingManager1.DockTabAlignment = DockTabAlignmentStyle.Left;
            }
            else if (this.comboBoxAdv3.SelectedItem.ToString() == "Right")
            {
                this.dockingManager1.DockTabAlignment = DockTabAlignmentStyle.Right;
            }
            else if (this.comboBoxAdv3.SelectedItem.ToString() == "Top")
            {
                this.dockingManager1.DockTabAlignment = DockTabAlignmentStyle.Top;
            }
            else if (this.comboBoxAdv3.SelectedItem.ToString() == "Bottom")
            {
                this.dockingManager1.DockTabAlignment = DockTabAlignmentStyle.Bottom;
            }
        }
#endregion

#region Setting of visual style
        /// <summary>
        /// Sets the visual style for DockingManager
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VisualStyle_Changed(object sender, EventArgs e)
        {
            if(this.comboBoxAdv1.SelectedItem.ToString().Equals("Office2019Colorful"))
            {
                SkinManager.SetVisualStyle(this, "Office2019Colorful");
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString().Equals("HighContrastBlack"))
            {
                SkinManager.SetVisualStyle(this, "HighContrastBlack");
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString().Equals("Office2016Colorful"))
            {
                SkinManager.SetVisualStyle(this, "Office2016Colorful");
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString().Equals("Office2016White"))
            {
                SkinManager.SetVisualStyle(this, "Office2016White");
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString().Equals("Office2016DarkGray"))
            {
                SkinManager.SetVisualStyle(this, "Office2016DarkGray");
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString().Equals("Office2016Black"))
            {
                SkinManager.SetVisualStyle(this, "Office2016Black");
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString().Equals("Metro"))
            {
                SkinManager.SetVisualStyle(this, "Metro");
            }
            UpdateVisualStyles(this.comboBoxAdv1.SelectedItem.ToString());
        }
#endregion

        /// <summary>
        /// Updates the visual styles.
        /// </summary>
        /// <param name="themename"></param>
        private void UpdateVisualStyles(string themename)
        {
            this.gradientPanel12.BorderStyle = BorderStyle.FixedSingle;
            if (themename == "Metro" || themename == "Office2016Colorful" || themename == "Office2016White" || themename == "Office2019Colorful")
            {
                gradientPanel2.BackColor = Color.White;
                gradientPanel3.BackColor = Color.White;
                gradientPanel4.BackColor = Color.White;
                gradientPanel5.BackColor = Color.White;
                gradientPanel6.BackColor = Color.White;
                gradientPanel7.BackColor = Color.White;
                gradientPanel8.BackColor = Color.White;
                gradientPanel9.BackColor = Color.White;
                gradientPanel10.BackColor = Color.White;
                gradientPanel11.BackColor = Color.White;
                gradientPanel12.BackColor = Color.White;
                this.gradientPanel1.BackColor = Color.White;
            }

            if (themename == "Office2019Colorful")
            {
				this.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                this.autoLabel2.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                this.autoLabel5.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                this.autoLabel6.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                this.autoLabel2.ForeColor = ColorTranslator.FromHtml("#444444");
                this.autoLabel5.ForeColor = ColorTranslator.FromHtml("#444444");
                this.autoLabel6.ForeColor = ColorTranslator.FromHtml("#444444");
                this.dockingManager1.ThemeStyle.SplitterColor = ColorTranslator.FromHtml("#dadada");
                this.gradientPanel12.BorderColor = ColorTranslator.FromHtml("#f3f3f3");
                this.gradientPanel12.ThemeStyle.BackColor = Color.White;
            }
            else if (themename == "HighContrastBlack")
            {
                this.BackColor = ColorTranslator.FromHtml("#000000");
                 
                this.dockingManager1.ThemeStyle.SplitterColor = Color.Black;
                this.autoLabel2.BackColor = ColorTranslator.FromHtml("#000000");
                this.autoLabel5.BackColor = ColorTranslator.FromHtml("#000000");
                this.autoLabel6.BackColor = ColorTranslator.FromHtml("#000000");
                this.autoLabel2.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                this.autoLabel5.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                this.autoLabel6.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

                gradientPanel2.BackColor = Color.Black;
                gradientPanel3.BackColor = Color.Black;
                gradientPanel4.BackColor = Color.Black;
                gradientPanel5.BackColor = Color.Black;
                gradientPanel6.BackColor = Color.Black;
                gradientPanel7.BackColor = Color.Black;
                gradientPanel8.BackColor = Color.Black;
                gradientPanel9.BackColor = Color.Black;
                gradientPanel10.BackColor = Color.Black;
                gradientPanel11.BackColor = Color.Black;
                gradientPanel12.BackColor = Color.Black;
                this.gradientPanel1.BackColor = Color.Black;

                this.gradientPanel12.BorderColor = ColorTranslator.FromHtml("#FFFFFF");
                this.gradientPanel12.ThemeStyle.BackColor = Color.Black;
            }
            else if (themename == "Office2016Colorful")
            {
                this.BackColor = Color.White;
                this.dockingManager1.ThemeStyle.SplitterColor = ColorTranslator.FromHtml("#e1e1e1 ");               
                this.autoLabel2.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                this.autoLabel5.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                this.autoLabel6.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                this.autoLabel2.ForeColor = ColorTranslator.FromHtml("#262626");
                this.autoLabel5.ForeColor = ColorTranslator.FromHtml("#262626");
                this.autoLabel6.ForeColor = ColorTranslator.FromHtml("#262626");

                this.gradientPanel12.BorderColor = ColorTranslator.FromHtml("#e1e1e1");
                this.gradientPanel12.ThemeStyle.BackColor = Color.White;

            }
            else if (themename == "Office2016White")
            {
                this.BackColor = Color.White;
                this.dockingManager1.ThemeStyle.SplitterColor = ColorTranslator.FromHtml("#e1e1e1 ");                
                this.autoLabel2.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                this.autoLabel5.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                this.autoLabel6.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                this.autoLabel2.ForeColor = ColorTranslator.FromHtml("#262626");
                this.autoLabel5.ForeColor = ColorTranslator.FromHtml("#262626");
                this.autoLabel6.ForeColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanel12.BorderColor = ColorTranslator.FromHtml("#e1e1e1");
                this.gradientPanel12.ThemeStyle.BackColor = Color.White;

            }
            else if (themename == "Office2016Black")
            {
                this.BackColor = ColorTranslator.FromHtml("#262626");
                this.dockingManager1.ThemeStyle.SplitterColor = ColorTranslator.FromHtml("#383838 ");            
                this.autoLabel2.BackColor = ColorTranslator.FromHtml("#262626");
                this.autoLabel5.BackColor = ColorTranslator.FromHtml("#262626");
                this.autoLabel6.BackColor = ColorTranslator.FromHtml("#262626");
                this.autoLabel2.ForeColor = ColorTranslator.FromHtml("#F0F0F0");
                this.autoLabel5.ForeColor = ColorTranslator.FromHtml("#F0F0F0");
                this.autoLabel6.ForeColor = ColorTranslator.FromHtml("#F0F0F0");
                this.gradientPanel2.BackColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanel3.BackColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanel4.BackColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanel5.BackColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanel6.BackColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanel7.BackColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanel8.BackColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanel9.BackColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanel10.BackColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanel11.BackColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanel12.BackColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanel1.BackColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanel12.BorderColor = ColorTranslator.FromHtml("#383838");
                this.gradientPanel12.ThemeStyle.BackColor = ColorTranslator.FromHtml("#262626");
            }
            else if (themename == "Office2016DarkGray")
            {
                this.BackColor = ColorTranslator.FromHtml("#666666");
                this.dockingManager1.ThemeStyle.SplitterColor = ColorTranslator.FromHtml("#444444");               
                this.autoLabel2.BackColor = ColorTranslator.FromHtml("#666666");
                this.autoLabel5.BackColor = ColorTranslator.FromHtml("#666666");
                this.autoLabel6.BackColor = ColorTranslator.FromHtml("#666666");
                this.autoLabel2.ForeColor = ColorTranslator.FromHtml("#F0F0F0");
                this.autoLabel5.ForeColor = ColorTranslator.FromHtml("#F0F0F0");
                this.autoLabel6.ForeColor = ColorTranslator.FromHtml("#F0F0F0");
                this.gradientPanel2.BackColor = ColorTranslator.FromHtml("#666666");
                this.gradientPanel3.BackColor = ColorTranslator.FromHtml("#666666");
                this.gradientPanel4.BackColor = ColorTranslator.FromHtml("#666666");
                this.gradientPanel5.BackColor = ColorTranslator.FromHtml("#666666");
                this.gradientPanel6.BackColor = ColorTranslator.FromHtml("#666666");
                this.gradientPanel7.BackColor = ColorTranslator.FromHtml("#666666");
                this.gradientPanel8.BackColor = ColorTranslator.FromHtml("#666666");
                this.gradientPanel9.BackColor = ColorTranslator.FromHtml("#666666");
                this.gradientPanel10.BackColor = ColorTranslator.FromHtml("#666666");
                this.gradientPanel11.BackColor = ColorTranslator.FromHtml("#666666");
                this.gradientPanel12.BackColor = ColorTranslator.FromHtml("#666666");
                this.gradientPanel1.BackColor = ColorTranslator.FromHtml("#666666");
                this.gradientPanel12.BorderColor = ColorTranslator.FromHtml("#444444");
                this.gradientPanel12.ThemeStyle.BackColor = ColorTranslator.FromHtml("#666666");
            }
            else
            {
                this.BackColor = Color.White;
                this.dockingManager1.ThemeStyle.SplitterColor = ColorTranslator.FromHtml("#FFFFFF ");             
                this.autoLabel2.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                this.autoLabel5.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                this.autoLabel6.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                this.autoLabel2.ForeColor = ColorTranslator.FromHtml("#262626");
                this.autoLabel5.ForeColor = ColorTranslator.FromHtml("#262626");
                this.autoLabel6.ForeColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanel12.BorderColor = ColorTranslator.FromHtml("#F3F3F3");
                this.gradientPanel12.ThemeStyle.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            }           
            
        }

        /// <summary>
        /// Update the Dock Layout
        /// </summary>
        private void UpdateLayout()
        {
            this.dockingManager1.DockControl(this.gradientPanel11, this, DockingStyle.Bottom, 250);
            this.dockingManager1.DockControl(this.gradientPanel7, this.gradientPanel11, DockingStyle.Right, gradientPanel11.Width / 2 + 50);
            this.dockingManager1.DockControl(this.gradientPanel10, this, DockingStyle.Left, 250);

            this.dockingManager1.DockControlInAutoHideMode(this.gradientPanel5, DockingStyle.Right, 250);
            this.dockingManager1.DockControlInAutoHideMode(this.gradientPanel8, DockingStyle.Bottom, 250);
            this.dockingManager1.DockControl(this.gradientPanel1, this, DockingStyle.Right, 250);

            this.dockingManager1.DockControl(this.gradientPanel9, this, DockingStyle.Bottom, 200);
            this.dockingManager1.DockControl(this.gradientPanel6, this, DockingStyle.Bottom, 200);
            this.dockingManager1.DockControl(this.gradientPanel6, this.gradientPanel9, DockingStyle.Tabbed, 200);

            this.dockingManager1.EnableDocumentMode = true;
            this.dockingManager1.DockAsDocument(this.gradientPanel2);
            this.dockingManager1.DockAsDocument(this.gradientPanel3);
            this.dockingManager1.DockAsDocument(this.gradientPanel4);

            gradientPanel2.BackColor = Color.White;
            gradientPanel3.BackColor = Color.White;
            gradientPanel4.BackColor = Color.White;

            this.dockingManager1.SetDockLabel(this.gradientPanel1, "Solution Explorer");
            this.dockingManager1.SetDockLabel(this.gradientPanel11, "Error List");
            this.dockingManager1.SetDockLabel(this.gradientPanel10, "ToolBox");
            this.dockingManager1.SetDockLabel(this.gradientPanel2, "MainForm.cs");
            this.dockingManager1.SetDockLabel(this.gradientPanel3, "MainForm.design");
            this.dockingManager1.SetDockLabel(this.gradientPanel4, "Program.cs");
            this.dockingManager1.SetDockLabel(this.gradientPanel7, "Find Results");
            this.dockingManager1.SetDockLabel(this.gradientPanel6, "Server Explorer");
            this.dockingManager1.SetDockLabel(this.gradientPanel9, "Team Explorer");
            this.dockingManager1.SetDockLabel(this.gradientPanel5, "Properties");
            this.dockingManager1.SetDockLabel(this.gradientPanel8, "Output");

            this.comboBoxAdv1.SelectedIndex = 5;
            this.comboBoxAdv3.SelectedIndex = 3;
        }
       

        private void DockingManager1_NewDockStateEndLoad(object sender, EventArgs e)
        {

            this.dockingManager1.DockControl(this.gradientPanel11, this, DockingStyle.Bottom, 250);
            this.dockingManager1.DockControl(this.gradientPanel7, this.gradientPanel11, DockingStyle.Right, gradientPanel11.Width / 2 +50);
            this.dockingManager1.DockControl(this.gradientPanel10, this, DockingStyle.Left, 250);

            this.dockingManager1.DockControlInAutoHideMode(this.gradientPanel5, DockingStyle.Right, 250);
            this.dockingManager1.DockControlInAutoHideMode(this.gradientPanel8, DockingStyle.Bottom, 250);
            this.dockingManager1.DockControl(this.gradientPanel1, this, DockingStyle.Right, 250);

            this.dockingManager1.DockControl(this.gradientPanel9, this, DockingStyle.Bottom, 200);
            this.dockingManager1.DockControl(this.gradientPanel6,this,DockingStyle.Bottom, 200);
            this.dockingManager1.DockControl(this.gradientPanel6, this.gradientPanel9, DockingStyle.Tabbed, 200);

            this.dockingManager1.EnableDocumentMode = true;
            this.dockingManager1.DockAsDocument(this.gradientPanel2);
            this.dockingManager1.DockAsDocument(this.gradientPanel3);
            this.dockingManager1.DockAsDocument(this.gradientPanel4);

            gradientPanel2.BackColor = Color.White;
            gradientPanel3.BackColor = Color.White;
            gradientPanel4.BackColor = Color.White;

            this.dockingManager1.SetDockLabel(this.gradientPanel1, "Solution Explorer");
            this.dockingManager1.SetDockLabel(this.gradientPanel11, "Error List");
            this.dockingManager1.SetDockLabel(this.gradientPanel10, "ToolBox");
            this.dockingManager1.SetDockLabel(this.gradientPanel2, "MainForm.cs");
            this.dockingManager1.SetDockLabel(this.gradientPanel3, "MainForm.design");
            this.dockingManager1.SetDockLabel(this.gradientPanel4, "Program.cs");
            this.dockingManager1.SetDockLabel(this.gradientPanel7, "Find Results");
            this.dockingManager1.SetDockLabel(this.gradientPanel6, "Server Explorer");
            this.dockingManager1.SetDockLabel(this.gradientPanel9, "Team Explorer");
            this.dockingManager1.SetDockLabel(this.gradientPanel5, "Properties");
            this.dockingManager1.SetDockLabel(this.gradientPanel8, "Output");

            this.comboBoxAdv1.SelectedIndex = 5;
            this.comboBoxAdv3.SelectedIndex = 3;
        }
    }
}
