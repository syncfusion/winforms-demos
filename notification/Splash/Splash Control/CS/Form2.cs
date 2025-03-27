#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.Controls;
using System.Diagnostics;

namespace GettingStarted
{
    public partial class Form2 : SfForm
    {
        public Form2()
        {
            InitializeComponent();
            this.comboBoxAdv1.SelectedValueChanged += ComboBoxAdv1_SelectedValueChanged;
            this.comboBoxAdv2.SelectedValueChanged += ComboBoxAdv2_SelectedValueChanged;
            this.comboBoxAdv3.SelectedValueChanged += ComboBoxAdv3_SelectedValueChanged;
            this.comboBoxAdv4.SelectedValueChanged += ComboBoxAdv4_SelectedValueChanged;
            PopulateComboBox();
            this.numericUpDownExt1.Value = Settings1.Default.AnimationSpeed;
            this.textBoxExt2.Text = Settings1.Default.DisplayInterval;
            this.comboBoxAdv1.SelectedIndex = Settings1.Default.SlidePosition;
            this.comboBoxAdv4.SelectedIndex = Settings1.Default.DesktopAlignment;
            this.comboBoxAdv3.SelectedIndex = Settings1.Default.MarqueeDirection;
            this.comboBoxAdv2.SelectedIndex = Settings1.Default.AnimationDirection;
            this.splashPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(69, 69, 69));
            SkinManager.SetVisualStyle(this, "Office2019Colorful");
            this.numericUpDownExt1.ThemeStyle.Font = new Font("Microsoft San serif", 8.25F);
            this.splitContainerAdv1.ThemeName = "None";
            this.gradientPanel1.ThemeStyle.BackColor = Color.White;
            this.gradientPanel2.ThemeStyle.BackColor = Color.White;
            this.splashControl1.ShowAnimation = true;
            this.label6.Enabled = false;
            this.comboBoxAdv3.Enabled = false;
            this.splashControl1.ShowSplash(false);
        }


        private void ComboBoxAdv4_SelectedValueChanged(object sender, EventArgs e)
        {
            this.splashControl1.DesktopAlignment = (Syncfusion.Windows.Forms.Tools.SplashAlignment)Enum.Parse(typeof(Syncfusion.Windows.Forms.Tools.SplashAlignment), comboBoxAdv4.SelectedItem.ToString());
        }

        private void ComboBoxAdv3_SelectedValueChanged(object sender, EventArgs e)
        {
            this.splashPanel1.MarqueeDirection = (Syncfusion.Windows.Forms.Tools.SplashPanelMarqueeDirection)Enum.Parse(typeof(Syncfusion.Windows.Forms.Tools.SplashPanelMarqueeDirection), comboBoxAdv3.SelectedItem.ToString());
        }

        private void ComboBoxAdv2_SelectedValueChanged(object sender, EventArgs e)
        {
            this.splashPanel1.AnimationDirection = (Syncfusion.Windows.Forms.Tools.AnimationDirection)Enum.Parse(typeof(Syncfusion.Windows.Forms.Tools.AnimationDirection), comboBoxAdv2.SelectedItem.ToString());
        }

        private void ComboBoxAdv1_SelectedValueChanged(object sender, EventArgs e)
        {
            this.splashPanel1.SlideStyle = (Syncfusion.Windows.Forms.Tools.SlideStyle)Enum.Parse(typeof(Syncfusion.Windows.Forms.Tools.SlideStyle), this.comboBoxAdv1.SelectedItem.ToString());
            if (this.splashPanel1.SlideStyle == Syncfusion.Windows.Forms.Tools.SlideStyle.Marquee)
            {
                this.label6.Enabled = true;
                this.comboBoxAdv3.Enabled = true;
            }
            else
            {
                this.label6.Enabled = false;
                this.comboBoxAdv3.Enabled = false;
            }
        }


        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            Settings1.Default.AnimationSpeed = this.numericUpDownExt1.Value;
            Settings1.Default.DisplayInterval = this.textBoxExt2.Text;
            Settings1.Default.SlidePosition = this.comboBoxAdv1.SelectedIndex;
            Settings1.Default.DesktopAlignment = this.comboBoxAdv4.SelectedIndex;
            Settings1.Default.MarqueeDirection = this.comboBoxAdv3.SelectedIndex;
            Settings1.Default.AnimationDirection = this.comboBoxAdv2.SelectedIndex;
            this.Hide();
            Form1 frm = new GettingStarted.Form1();
            frm.Show();
        }

        private void textBoxExt2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxExt2.Text) && System.Text.RegularExpressions.Regex.IsMatch(textBoxExt2.Text, "^[0-9]*$"))
                this.splashControl1.TimerInterval = Int32.Parse(textBoxExt2.Text);
            else
            {
                textBoxExt2.Text = string.Empty;
            }
        }

        private void PopulateComboBox()
        {
            List<string> cmb4 = new List<string> { 
            "SystemTray",
            "Center",
            "LeftTop",
            "LeftBottom",
            "RightTop",
            "RightBottom",
            "Custom"};
            this.comboBoxAdv4.DataSource = cmb4;
            List<string> cmb3 = new List<string> {
            "RightToLeft",
            "LeftToRight",
            "BottomToTop",
            "TopToBottom"};
            this.comboBoxAdv3.DataSource = cmb3;
            List<string> cmb2 = new List<string> {
            "Default",
            "RightToLeft",
            "LeftToRight"};
            this.comboBoxAdv2.DataSource = cmb2;
            List<string> cmb1 = new List<string> { "Horizontal",
            "Vertical",
            "LeftToRight",
            "BottomToTop",
            "RightToLeft",
            "TopToBottom",
            "FadeIn",
            "Slide",
            "Default",
            "Marquee"};
            this.comboBoxAdv1.DataSource = cmb1;
            this.comboBoxAdv1.AllowDropDownResize = this.comboBoxAdv2.AllowDropDownResize = this.comboBoxAdv3.AllowDropDownResize = this.comboBoxAdv4.AllowDropDownResize = false;
        }

        private void numericUpDownExt1_ValueChanged(object sender, EventArgs e)
        {
            this.splashPanel1.AnimationSteps = (int)this.numericUpDownExt1.Value;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
