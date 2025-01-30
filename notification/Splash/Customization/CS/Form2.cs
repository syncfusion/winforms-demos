#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashControl_Customization
{
    public partial class Form2 : SfForm
    {
        bool start;

        public Form2()
        {
            InitializeComponent();
            this.splashPanel1.SlideStyle = Syncfusion.Windows.Forms.Tools.SlideStyle.FadeIn;
            this.splashPanel1.AnimationSteps = 10;
            this.splashPanel2.AnimationSteps = 10;
            this.splashPanel5.AnimationSteps = 10;
            this.splashPanel6.AnimationSteps = 10;
            this.splashPanel1.Hide();
            this.splashPanel2.Hide();
            this.splashPanel5.Hide();
            this.splashPanel6.Hide();
            this.radioButtonAdv1.Checked = Properties.Settings.Default.Outlook;
            this.radioButtonAdv2.Checked = Properties.Settings.Default.VisualStudio;
            this.radioButtonAdv3.Checked = Properties.Settings.Default.Ubuntu;
            this.radioButtonAdv4.Checked = Properties.Settings.Default.ProgressBar;
            this.radioButtonAdv1.ThemeName = "Office2019Colorful";
            this.radioButtonAdv2.ThemeName = "Office2019Colorful";
            this.radioButtonAdv3.ThemeName = "Office2019Colorful";
            this.radioButtonAdv4.ThemeName = "Office2019Colorful";
            this.buttonAdv1.ThemeName = "Office2019Colorful";
        }
        
        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Outlook = this.radioButtonAdv1.Checked;
            Properties.Settings.Default.VisualStudio = this.radioButtonAdv2.Checked;
            Properties.Settings.Default.Ubuntu = this.radioButtonAdv3.Checked;
            Properties.Settings.Default.ProgressBar = this.radioButtonAdv4.Checked;
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(start)
            {
                if (this.progressBarAdv1.Value < 100)
                {
                    this.progressBarAdv1.Value++;
                }
            }
        }

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            this.splashPanel1.HideSplash();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.splashControl1.ShowSplash(false);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void radioButtonAdv1_CheckChanged_1(object sender, EventArgs e)
        {
            if ((sender as RadioButtonAdv).Name.Equals("radioButtonAdv1"))
            {
                this.pictureBox1.Image = global::SplashControl_Customization.Properties.Resources.outlook_preview;
                this.splashControl1.CustomSplashPanel = this.splashPanel1;
            }
            else if ((sender as RadioButtonAdv).Name.Equals("radioButtonAdv2"))
            {
                this.pictureBox1.Image = global::SplashControl_Customization.Properties.Resources.vs_previewimg;
                this.splashControl1.CustomSplashPanel = this.splashPanel5;
            }
            else if ((sender as RadioButtonAdv).Name.Equals("radioButtonAdv3"))
            {
                this.splashControl1.CustomSplashPanel = this.splashPanel2;
                this.splashPanel2.Size = Screen.PrimaryScreen.Bounds.Size;
                this.autoLabel1.Anchor = AnchorStyles.None;
                this.splashPanel2.Anchor = AnchorStyles.None;
                this.pictureBox1.Image = global::SplashControl_Customization.Properties.Resources.ubuntu_previewimg;
            }
            else if ((sender as RadioButtonAdv).Name.Equals("radioButtonAdv4"))
            {
                this.splashControl1.CustomSplashPanel = this.splashPanel6;
                this.progressBarAdv1.Value = 50;
                start = true;
                this.pictureBox1.Image = global::SplashControl_Customization.Properties.Resources.pb_previewimg;
            }
        }
    }
}
