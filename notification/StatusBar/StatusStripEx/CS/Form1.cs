#region Copyright Syncfusion Inc. 2001 - 2014
//
//  Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
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
using Syncfusion.Licensing;

namespace StatusStripExDemo
{
    using Syncfusion.Licensing;
    using Syncfusion.Windows.Forms.Tools;
    using Syncfusion.WinForms.Controls;
    using Syncfusion.WinForms.ListView;
    using System.Collections.Generic;

    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : SfForm
	{
		private System.Windows.Forms.ImageList imageList1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.StatusStripEx statusStripEx1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Syncfusion.Windows.Forms.Tools.StatusStripLabel statusStripLabel1;
        private Syncfusion.Windows.Forms.Tools.StatusStripLabel statusStripLabel2;
        private Syncfusion.Windows.Forms.Tools.TrackBarItem trackBarItem1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripDropDownButton toolStripDropDownButton3;
        private Label label3;
        private SfComboBox comboBoxAdv1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv3;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv2;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv1;
        private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            SkinManager.SetVisualStyle(this, "Office2019Colorful");
            this.gradientPanel1.ThemeStyle.BackColor = this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            PopulateComboBox();
            this.comboBoxAdv1.SelectedIndex = 0;
            this.statusStripEx1.ShowItemToolTips = true;
            this.checkBoxAdv1.Checked = this.statusStripEx1.ShowSeparator;
            this.checkBoxAdv2.Checked = this.statusStripEx1.SizingGrip;
            this.checkBoxAdv3.Checked = this.statusStripEx1.ShowItemToolTips;
            this.trackBarItem1.ValueChanged += TrackBarItem1_ValueChanged;
            this.trackBarItem1.TrackBarExControl.ThemeStyle.BackColor = this.statusStripEx1.ThemeStyle.BackColor;
            this.trackBarItem1.TrackBarExControl.ThemeStyle.TrackBarColor = this.trackBarItem1.TrackBarExControl.ThemeStyle.ButtonForeColor =
                this.trackBarItem1.TrackBarExControl.ThemeStyle.SliderColor=Color.White;
                this.trackBarItem1.TrackBarExControl.ThemeStyle.ButtonBackColor = this.statusStripEx1.ThemeStyle.BackColor;

            this.trackBarItem1.TrackBarExControl.SmallChange = 10;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void TrackBarItem1_ValueChanged(object sender, EventArgs e)
        {
            this.toolStripDropDownButton3.Text = this.trackBarItem1.TrackBarExControl.Value.ToString()+" %";
        }

        private void PopulateComboBox()
        {
           List<string> comboStyle = new List<string> {
            "Office2019Colorful",
            "HighContrastBlack",
            "Office2016Colorful",
            "Office2016White",
            "Office2016DarkGray",
            "Office2016Black"};
            this.comboBoxAdv1.AllowDropDownResize = false;
            this.comboBoxAdv1.DataSource = comboStyle;
            this.comboBoxAdv1.SelectedIndex = 0;
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
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.comboBoxAdv1 = new Syncfusion.WinForms.ListView.SfComboBox();
            this.checkBoxAdv3 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStripEx1 = new Syncfusion.Windows.Forms.Tools.StatusStripEx();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.trackBarItem1 = new Syncfusion.Windows.Forms.Tools.TrackBarItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.statusStripLabel1 = new Syncfusion.Windows.Forms.Tools.StatusStripLabel();
            this.statusStripLabel2 = new Syncfusion.Windows.Forms.Tools.StatusStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            this.statusStripEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.comboBoxAdv1);
            this.gradientPanel1.Controls.Add(this.checkBoxAdv3);
            this.gradientPanel1.Controls.Add(this.checkBoxAdv2);
            this.gradientPanel1.Controls.Add(this.checkBoxAdv1);
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(920, 396);
            this.gradientPanel1.TabIndex = 14;
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.comboBoxAdv1.Location = new System.Drawing.Point(474, 245);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(138, 21);
            this.comboBoxAdv1.TabIndex = 6;
            this.comboBoxAdv1.Text = "Office2019Colorful";
            this.comboBoxAdv1.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv1_SelectedIndexChanged);
            // 
            // checkBoxAdv3
            // 
            this.checkBoxAdv3.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxAdv3.Location = new System.Drawing.Point(377, 188);
            this.checkBoxAdv3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.checkBoxAdv3.Name = "checkBoxAdv3";
            this.checkBoxAdv3.Size = new System.Drawing.Size(150, 21);
            this.checkBoxAdv3.TabIndex = 5;
            this.checkBoxAdv3.Text = "Show Item ToolTip";
            this.checkBoxAdv3.ThemesEnabled = false;
            this.checkBoxAdv3.CheckedChanged += new System.EventHandler(this.checkBoxAdv3_CheckedChanged);
            // 
            // checkBoxAdv2
            // 
            this.checkBoxAdv2.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxAdv2.Location = new System.Drawing.Point(377, 128);
            this.checkBoxAdv2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.checkBoxAdv2.Name = "checkBoxAdv2";
            this.checkBoxAdv2.Size = new System.Drawing.Size(150, 21);
            this.checkBoxAdv2.TabIndex = 4;
            this.checkBoxAdv2.Text = "Show gripper";
            this.checkBoxAdv2.ThemesEnabled = false;
            this.checkBoxAdv2.CheckedChanged += new System.EventHandler(this.checkBoxAdv3_CheckedChanged);
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxAdv1.Location = new System.Drawing.Point(377, 68);
            this.checkBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(150, 21);
            this.checkBoxAdv1.TabIndex = 3;
            this.checkBoxAdv1.Text = "Show separator";
            this.checkBoxAdv1.ThemesEnabled = false;
            this.checkBoxAdv1.CheckedChanged += new System.EventHandler(this.checkBoxAdv3_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Visual style";
            // 
            // statusStripEx1
            // 
            this.statusStripEx1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.statusStripEx1.BeforeTouchSize = new System.Drawing.Size(920, 30);
            this.statusStripEx1.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Bottom;
            this.statusStripEx1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.trackBarItem1,
            this.toolStripDropDownButton3,
            this.statusStripLabel1,
            this.statusStripLabel2});
            this.statusStripEx1.Location = new System.Drawing.Point(0, 396);
            this.statusStripEx1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.statusStripEx1.Name = "statusStripEx1";
            this.statusStripEx1.Size = new System.Drawing.Size(920, 30);
            this.statusStripEx1.TabIndex = 15;
            this.statusStripEx1.Text = "statusStripEx1";
            this.statusStripEx1.ThemeName = "Office2016Colorful";
            this.statusStripEx1.VisualStyle = Syncfusion.Windows.Forms.Tools.StatusStripExStyle.Office2016Colorful;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(139, 15);
            this.toolStripStatusLabel1.Text = "All folders are up to date.";
            this.toolStripStatusLabel1.ToolTipText = "Synchronization status.";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(189, 15);
            this.toolStripStatusLabel2.Text = "Connected to: Microsoft Exchange";
            this.toolStripStatusLabel2.ToolTipText = "Connectivity to your server.";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = global::StatusStripExDemo.Properties.Resources.@__ShowHide2019_other_theme;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(28, 28);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.ToolTipText = "Normal View. Show All Pinned Panes.";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.Image = global::StatusStripExDemo.Properties.Resources.@__Book2019;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.ShowDropDownArrow = false;
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(28, 28);
            this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.ToolTipText = "Reading View. Hide All Pinned Panes.";
            // 
            // trackBarItem1
            // 
            this.trackBarItem1.Maximum = 200;
            this.trackBarItem1.Minimum = 0;
            this.trackBarItem1.Name = "trackBarItem1";
            this.trackBarItem1.Size = new System.Drawing.Size(250, 20);
            this.trackBarItem1.Text = "trackBarItem1";
            this.trackBarItem1.ToolTipText = "Zoom";
            this.trackBarItem1.Value = 100;
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.ShowDropDownArrow = false;
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(42, 19);
            this.toolStripDropDownButton3.Text = "100 %";
            this.toolStripDropDownButton3.ToolTipText = "Zoom level";
            // 
            // statusStripLabel1
            // 
            this.statusStripLabel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.statusStripLabel1.Name = "statusStripLabel1";
            this.statusStripLabel1.Size = new System.Drawing.Size(60, 15);
            this.statusStripLabel1.Text = "Items: 128";
            this.statusStripLabel1.ToolTipText = "Number of items in this folder.";
            // 
            // statusStripLabel2
            // 
            this.statusStripLabel2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.statusStripLabel2.Name = "statusStripLabel2";
            this.statusStripLabel2.Size = new System.Drawing.Size(63, 15);
            this.statusStripLabel2.Text = "Unread: 20";
            this.statusStripLabel2.ToolTipText = "Number of unread items in this folder.";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.ClientSize = new System.Drawing.Size(920, 426);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.statusStripEx1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatusStripEx";
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            this.statusStripEx1.ResumeLayout(false);
            this.statusStripEx1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            SkinManager.LoadAssembly(typeof(Syncfusion.WinForms.Themes.Office2019Theme).Assembly);
            SkinManager.LoadAssembly(typeof(Syncfusion.WinForms.Themes.Office2016Theme).Assembly);
            SkinManager.LoadAssembly(typeof(Syncfusion.HighContrastTheme.WinForms.HighContrastTheme).Assembly);
            Application.Run(new Form1());
		}

        private void checkBoxAdv3_CheckedChanged(object sender, EventArgs e)
        {
            if((sender as CheckBoxAdv).Name.Equals("checkBoxAdv1"))
            {
                this.statusStripEx1.ShowSeparator = this.checkBoxAdv1.Checked;
            }
            else if ((sender as CheckBoxAdv).Name.Equals("checkBoxAdv2"))
            {
                this.statusStripEx1.SizingGrip = this.checkBoxAdv2.Checked;
            }
            else if ((sender as CheckBoxAdv).Name.Equals("checkBoxAdv3"))
            {
                this.statusStripEx1.ShowItemToolTips = this.checkBoxAdv3.Checked;
            }
        }

        private void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(this.comboBoxAdv1.SelectedItem.ToString())
            {
                case "Office2019Colorful":
                    SkinManager.SetVisualStyle(this, "Office2019Colorful");
                    this.gradientPanel1.ThemeStyle.BackColor = this.BackColor = Color.White;
                    this.ForeColor = Color.Black;
                    this.label3.ForeColor = Color.Black;
                    this.Style.TitleBar.ForeColor = this.Style.TitleBar.CloseButtonForeColor =
                        this.Style.TitleBar.MinimizeButtonForeColor = this.Style.TitleBar.MaximizeButtonForeColor = Color.Black;
                    this.Style.TitleBar.BackColor = Color.FromArgb(242, 242, 242);
                    this.toolStripDropDownButton2.Image = global::StatusStripExDemo.Properties.Resources.__Book2019;
                    this.toolStripDropDownButton1.Image = global::StatusStripExDemo.Properties.Resources.__ShowHide2019_other_theme;
                    this.Icon = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sficon.ico"));
                    break;
                case "Office2016Colorful":
                    SkinManager.SetVisualStyle(this, "Office2016Colorful");
                    this.gradientPanel1.BackColor = this.BackColor = Color.White;
					this.label3.ForeColor = Color.Black;
                    this.Style.TitleBar.ForeColor = this.Style.TitleBar.CloseButtonForeColor = 
                    this.Style.TitleBar.MinimizeButtonForeColor = this.Style.TitleBar.MaximizeButtonForeColor = Color.Black;
                    this.Style.TitleBar.BackColor = Color.FromArgb(242, 242, 242);
                    this.toolStripDropDownButton2.Image = global::StatusStripExDemo.Properties.Resources.__Book2016;
                    this.toolStripDropDownButton1.Image = global::StatusStripExDemo.Properties.Resources.__ShowHide2016_1;
                    this.Icon = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sficon.ico"));
                    break;
                case "Office2016Black":
                    SkinManager.SetVisualStyle(this, "Office2016Black");
                    this.Style.TitleBar.ForeColor = this.Style.TitleBar.CloseButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.Style.TitleBar.MinimizeButtonForeColor=this.Style.TitleBar.MaximizeButtonForeColor= ColorTranslator.FromHtml("#f0f0f0");
                    this.Style.TitleBar.BackColor = ColorTranslator.FromHtml("#363636");
                    this.gradientPanel1.BackColor = this.BackColor = ColorTranslator.FromHtml("#252525");
                    this.label3.ForeColor = Color.White;
                    this.ForeColor = Color.White;
                    this.toolStripDropDownButton2.Image = global::StatusStripExDemo.Properties.Resources.__Book2019;
                    this.toolStripDropDownButton1.Image = global::StatusStripExDemo.Properties.Resources.__ShowHide2019_other_theme;
                    this.Icon = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                    break;
                case "HighContrastBlack":
                    SkinManager.SetVisualStyle(this, "HighContrastBlack");
                    this.Style.TitleBar.ForeColor = this.Style.TitleBar.CloseButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.Style.TitleBar.MinimizeButtonForeColor = this.Style.TitleBar.MaximizeButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.Style.TitleBar.BackColor = ColorTranslator.FromHtml("#363636");
                    this.gradientPanel1.BackColor = this.BackColor = ColorTranslator.FromHtml("#252525");
                    this.gradientPanel1.ThemeStyle.BackColor = Color.Black;
                    this.label3.ForeColor = Color.Black;
                    this.ForeColor = Color.White;
                    this.toolStripDropDownButton2.Image = global::StatusStripExDemo.Properties.Resources.__Book2019;
                    this.toolStripDropDownButton1.Image = global::StatusStripExDemo.Properties.Resources.__ShowHide2019_other_theme;
                    this.Icon = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                    break;
                case "Office2016DarkGray":
                    SkinManager.SetVisualStyle(this, "Office2016DarkGray");
                    this.gradientPanel1.BackColor = this.BackColor = ColorTranslator.FromHtml("#666666");
                    this.ForeColor = Color.Black;
                    this.label3.ForeColor = Color.White;
                    this.Style.TitleBar.ForeColor = this.Style.TitleBar.CloseButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.Style.TitleBar.MinimizeButtonForeColor = this.Style.TitleBar.MaximizeButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.Style.TitleBar.BackColor = ColorTranslator.FromHtml("#505050");
                    this.toolStripDropDownButton2.Image = global::StatusStripExDemo.Properties.Resources.__Book2019;
                    this.toolStripDropDownButton1.Image = global::StatusStripExDemo.Properties.Resources.__ShowHide2019_other_theme;
                    this.Icon= new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                    break;
                case "Office2016White":
                    SkinManager.SetVisualStyle(this, "Office2016White");
                    this.gradientPanel1.BackColor = this.BackColor = Color.White;
                    this.label3.ForeColor = Color.Black;
                    this.Style.TitleBar.ForeColor = this.Style.TitleBar.CloseButtonForeColor =
                        this.Style.TitleBar.MinimizeButtonForeColor = this.Style.TitleBar.MaximizeButtonForeColor = Color.Black;
                    this.Style.TitleBar.BackColor = Color.FromArgb(242, 242, 242);
                    this.toolStripDropDownButton2.Image = global::StatusStripExDemo.Properties.Resources.__Book2019;
                    this.toolStripDropDownButton1.Image = global::StatusStripExDemo.Properties.Resources.__ShowHide2019_other_theme;
                    this.Icon = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sficon.ico"));
                    break;
            }
        }
    }
}
