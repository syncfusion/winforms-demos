#region Copyright Syncfusion Inc. 2001 - 2014
// Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;

namespace Office2010Form_2005
{
    public partial class MainForm : Office2010Form
    {
        #region Constructor
        SfToolTip roundedCornersToolTip = new SfToolTip();
        public MainForm()
        {
            InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            ToolTipItem toolTipItem = new ToolTipItem();
            toolTipItem.Text = "This option will work only in Windows 11 OS";
            Syncfusion.WinForms.Controls.ToolTipInfo toolTipInfo = new Syncfusion.WinForms.Controls.ToolTipInfo();
            toolTipInfo.Items.Add(toolTipItem);
            toolTipInfo.MinWidth = 250;
            roundedCornersToolTip.SetToolTipInfo(checkBoxAdv4, toolTipInfo);
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Padding = new System.Windows.Forms.Padding(10);
            this.MinimumSize = this.Size;
            this.checkBoxAdv3.Checked = true;
            this.ApplyAeroTheme = false;
            foreach (String str in Enum.GetNames(typeof(FontStyle)))
                this.comboBox3.Items.Add(str);

            this.comboBox3.SelectedIndex = 1;
            this.comboBox1.SelectedIndex = 0;
            this.colorPickerButton1.SelectedColor = Color.Green;
            this.CaptionForeColor = this.colorPickerButton1.SelectedColor;
            this.colorPickerButton1.SelectedAsText = true;
            this.panel1.Location = new Point(
            this.ClientSize.Width / 2 - this.panel1.Size.Width / 2,
            this.ClientSize.Height / 2 - this.panel1.Size.Height / 2);
            this.panel1.Anchor = AnchorStyles.None;
            this.CaptionFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));

        }
        #endregion

        #region Themes
        private void radioButtonAdv1_CheckChanged(object sender, EventArgs e)
        {
            this.ColorScheme = Office2010Theme.Blue;
            this.BackColor = Color.FromArgb(241, 244, 254);          
            
        }

        private void radioButtonAdv2_CheckChanged(object sender, EventArgs e)
        {
            this.ColorScheme = Office2010Theme.Silver;
            this.BackColor = Color.FromArgb(202, 207, 217);
       }

        private void radioButtonAdv3_CheckChanged(object sender, EventArgs e)
        {
            this.ColorScheme = Office2010Theme.Black;
            this.BackColor = Color.FromArgb(113, 113, 113);
             }
        #endregion

        #region Help Button
        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.checkBoxAdv1.Checked)
            {
                this.MaximizeBox = false;
                this.MinimizeBox = false;
            }
            else
            {
                this.MaximizeBox = true;
                this.MinimizeBox = true;
            }

        }
        #endregion 

        #region RightToLeft

        private void checkBoxAdv2_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.checkBoxAdv2.Checked)
            {
                this.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                this.RightToLeft = RightToLeft.No;
            }
        }
        #endregion

        #region Show Icon
        private void checkBoxAdv3_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.checkBoxAdv3.Checked)
            {
                this.ShowIcon = true;
            }
            else
            {
                this.ShowIcon = false;
            }
        }
        #endregion

        #region Caption settings
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    this.CaptionAlign = HorizontalAlignment.Left;
                    break;
                case 1:
                    this.CaptionAlign = HorizontalAlignment.Center;
                    break;
                case 2:
                    this.CaptionAlign = HorizontalAlignment.Right;
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCaptionFont();
        }

        protected void SetCaptionFont()
        {
            FontStyle fs = (FontStyle)Enum.Parse(typeof(FontStyle), this.comboBox3.SelectedItem.ToString(), true);
            this.CaptionFont = new Font(this.comboBox2.Text, (int)this.numericUpDown1.Value, fs);
        
        }

        private void NumericUpDown2_ValueChanged1(object sender, System.EventArgs e)
        {
            this.CaptionBarHeight = (int)this.numericUpDown2.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            SetCaptionFont();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCaptionFont();
        }

        private void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            this.CaptionForeColor = this.colorPickerButton1.SelectedColor;
        }
        #endregion

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

        private void checkBoxAdv4_CheckStateChanged(object sender, EventArgs e)
        {
            this.AllowRoundedCorners = this.checkBoxAdv4.Checked;
        }
    }
}