#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
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

namespace MessageBoxAdv_2010
{
    public partial class Form1 : MetroForm
    {
        Image SelectedIcon;
        List<string> messages = new List<string>();
        string detailsText = string.Empty;
        string localizedDetailsText = string.Empty;

        public Form1()
        {
            InitializeComponent();
            if (this.imageListAdv1.Images.Count > 0)
                SelectedIcon = this.imageListAdv1.Images[0];

            this.ThemeCmb.SelectedIndex = 7;
            this.DlgRtTxtBox.ReadOnly = true;
            this.DlgRtTxtBox.BackColor = Color.White;
            this.captionAlignCombo.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv3_SelectedIndexChanged);

            messages.Add("Please find the warning message here.");
            messages.Add("Please find the error message here.");
            messages.Add("Please find the confirmation message here.");
            messages.Add("Please find the information here.");
            messages.Add("Please find the query here.");
            detailsText = "Please find the complete stack trace or any other detailed information in this section of the message box.";
            localizedDetailsText = "الرجاء البحث عن تتبع المكدس الكامل أو أي معلومات مفصلة أخرى في هذا القسم من مربع الرسالة";
            this.txt_Details.Text = detailsText;
            this.MsgBoxBodyTxtBox.Text = messages[0];
        }

        /// <summary>
        /// MessageBox Panel SizeChanged Event
        /// </summary>
        private void MessageBoxPanel_SizeChanged(object sender, EventArgs e)
        {
            this.Msgbtn.Left = (this.MessageBoxPanel.Width - this.Msgbtn.Width) / 2;
            this.Msgbtn.Top = (this.MessageBoxPanel.Height - this.Msgbtn.Height) / 2;
        }

        /// <summary>
        /// Property Panel SizeChanged Event
        /// </summary>
        private void PropertiesPanel_SizeChanged(object sender, EventArgs e)
        {
            this.groupBar1.Left = (this.PropertiesPanel.Width - this.groupBar1.Width) / 2;
            this.groupBar1.Top = (this.PropertiesPanel.Height - this.groupBar1.Height) / 2;
        }

        /// <summary>
        /// Applies the selected theme to the control.
        /// </summary>
        private void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ThemeCmb.SelectedItem.ToString() == "Office2007Blue")
            {
                MessageBoxAdv.Office2007Theme = Office2007Theme.Blue;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Default;
                this.Msgbtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
                this.Msgbtn.Office2007ColorScheme = Office2007Theme.Blue;
            }
            else if (this.ThemeCmb.SelectedItem.ToString() == "Office2007Black")
            {
                MessageBoxAdv.Office2007Theme = Office2007Theme.Black;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Default;
                this.Msgbtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
                this.Msgbtn.Office2007ColorScheme = Office2007Theme.Black;
            }
            else if (this.ThemeCmb.SelectedItem.ToString() == "Office2007Silver")
            {
                MessageBoxAdv.Office2007Theme = Office2007Theme.Silver;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Default;
                this.Msgbtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
                this.Msgbtn.Office2007ColorScheme = Office2007Theme.Silver;
            }
            else if (this.ThemeCmb.SelectedItem.ToString() == "Office2010Blue")
            {                
                MessageBoxAdv.Office2010Theme = Office2010Theme.Blue;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2010;
                this.Msgbtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2010;
                this.Msgbtn.Office2010ColorScheme = Office2010Theme.Blue;
            }
            else if (this.ThemeCmb.SelectedItem.ToString() == "Office2010Black")
            {
                MessageBoxAdv.Office2010Theme = Office2010Theme.Black;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2010;
                this.Msgbtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2010;
                this.Msgbtn.Office2010ColorScheme = Office2010Theme.Black;
            }
            else if (this.ThemeCmb.SelectedItem.ToString() == "Office2010Silver")
            {
                MessageBoxAdv.Office2010Theme = Office2010Theme.Silver;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2010;
                this.Msgbtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2010;
                this.Msgbtn.Office2010ColorScheme = Office2010Theme.Silver;
            }
            else if (this.ThemeCmb.SelectedItem.ToString() == "Metro")
            {                
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                this.Msgbtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            }
            else if (this.ThemeCmb.SelectedItem.ToString() == "Office2013DarkGray")
            {
                MessageBoxAdv.Office2013Theme = Office2013Theme.DarkGray;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2013;
            }
            else if (this.ThemeCmb.SelectedItem.ToString() == "Office2013LightGray")
            {
                MessageBoxAdv.Office2013Theme = Office2013Theme.LightGray;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2013;
            }
            else if (this.ThemeCmb.SelectedItem.ToString() == "Office2013White")
            {
                MessageBoxAdv.Office2013Theme = Office2013Theme.White;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2013;
            }
            else if (this.ThemeCmb.SelectedItem.ToString() == "Office2016Colorful")
            {
                MessageBoxAdv.Office2016Theme = Office2016Theme.Colorful;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2016;
                this.Msgbtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            }
            else if (this.ThemeCmb.SelectedItem.ToString() == "Office2016DarkGray")
            {
                MessageBoxAdv.Office2016Theme = Office2016Theme.DarkGray;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2016;
                this.Msgbtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016DarkGray;
            }
            else if (this.ThemeCmb.SelectedItem.ToString() == "Office2016White")
            {
                MessageBoxAdv.Office2016Theme = Office2016Theme.White;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2016;
                this.Msgbtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016White;
            }
        }

        /// <summary>
        /// Applies the selected alignment setting to caption text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxAdv3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(captionAlignCombo.SelectedItem.ToString()=="Center")
            {
                MessageBoxAdv.CaptionAlign = HorizontalAlignment.Center;
            }
            if(captionAlignCombo.SelectedItem.ToString()=="Left")
            {
                MessageBoxAdv.CaptionAlign = HorizontalAlignment.Left;
            }
            if (captionAlignCombo.SelectedItem.ToString() == "Right")
            {
                MessageBoxAdv.CaptionAlign = HorizontalAlignment.Right;
            }
            UpdateMessageBoxAdvTheme();
        }

        /// <summary>
        /// Displays the MessageBox with the selected theme by default.
        /// </summary>
        public void UpdateMessageBoxAdvTheme()
        {
            if (this.BtnCmb.SelectedItem != null)
            {
                if (this.ThemeCmb.SelectedItem.ToString() == "Office2007Blue")
                {
                    MessageBoxAdv.Office2007Theme = Office2007Theme.Blue;
                    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Default;
                }
                else if (this.ThemeCmb.SelectedItem.ToString() == "Office2007Black")
                {
                    MessageBoxAdv.Office2007Theme = Office2007Theme.Black;
                    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Default;
                }
                else if (this.ThemeCmb.SelectedItem.ToString() == "Office2007Silver")
                {
                    MessageBoxAdv.Office2007Theme = Office2007Theme.Silver;
                    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Default;
                }
                else if (this.ThemeCmb.SelectedItem.ToString() == "Office2010Blue")
                {
                    MessageBoxAdv.Office2010Theme = Office2010Theme.Blue;
                    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2010;
                }
                else if (this.ThemeCmb.SelectedItem.ToString() == "Office2010Black")
                {
                    MessageBoxAdv.Office2010Theme = Office2010Theme.Black;
                    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2010;
                }
                else if (this.ThemeCmb.SelectedItem.ToString() == "Office2010Silver")
                {
                    MessageBoxAdv.Office2010Theme = Office2010Theme.Silver;
                    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2010;
                }
                else if (this.ThemeCmb.SelectedItem.ToString() == "Metro")
                {
                    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                }
                else if (this.ThemeCmb.SelectedItem.ToString() == "Office2013DarkGray")
                {
                    MessageBoxAdv.Office2013Theme = Office2013Theme.DarkGray;
                    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2013;
                }
                else if (this.ThemeCmb.SelectedItem.ToString() == "Office2013LightGray")
                {
                    MessageBoxAdv.Office2013Theme = Office2013Theme.LightGray;
                    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2013;
                }
                else if (this.ThemeCmb.SelectedItem.ToString() == "Office2013White")
                {
                    MessageBoxAdv.Office2013Theme = Office2013Theme.White;
                    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2013;
                }
                else if (this.ThemeCmb.SelectedItem.ToString() == "Office2016Colorful")
                {
                    MessageBoxAdv.Office2016Theme = Office2016Theme.Colorful;
                    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2016;
                }
                else if (this.ThemeCmb.SelectedItem.ToString() == "Office2016DarkGray")
                {
                    MessageBoxAdv.Office2016Theme = Office2016Theme.DarkGray;
                    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2016;
                }
                else if (this.ThemeCmb.SelectedItem.ToString() == "Office2016White")
                {
                    MessageBoxAdv.Office2016Theme = Office2016Theme.White;
                    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2016;
                }
                else if (this.ThemeCmb.SelectedItem.ToString() == "Custom")
                {
                    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                    MessageBoxAdv.MetroColorTable.NoButtonBackColor = ColorTranslator.FromHtml("#5cc0e7");
                    MessageBoxAdv.MetroColorTable.YesButtonBackColor = ColorTranslator.FromHtml("#5cc0e7");
                    MessageBoxAdv.MetroColorTable.CancelButtonBackColor = ColorTranslator.FromHtml("#5cc0e7");
                    MessageBoxAdv.MetroColorTable.OKButtonBackColor = ColorTranslator.FromHtml("#5cc0e7");
                    MessageBoxAdv.MetroColorTable.RetryButtonBackColor = ColorTranslator.FromHtml("#5cc0e7");
                    MessageBoxAdv.MetroColorTable.AbortButtonBackColor = ColorTranslator.FromHtml("#5cc0e7");
                    MessageBoxAdv.MetroColorTable.BackColor = ColorTranslator.FromHtml("#4d4d4d");
                    MessageBoxAdv.MetroColorTable.BorderColor = ColorTranslator.FromHtml("#5cc0e7");
                    MessageBoxAdv.MetroColorTable.CaptionBarColor = ColorTranslator.FromHtml("#4d4d4d");
                    MessageBoxAdv.MetroColorTable.CaptionForeColor = Color.White;
                    MessageBoxAdv.MetroColorTable.ForeColor = Color.White;
                }
            }
        }

        /// <summary>
        /// Displays the message box.
        /// </summary>
        public void DisplayMessageBoxAdv()
        {
            DialogResult result = DialogResult.OK;
            int clickedIndex = 0;
            string[] CustomButtons = new string[] {"Okay","Cancel","Help"};
            UpdateMessageBoxAdvTheme();
            string bdyText = string.Empty;
            string CaptionText = string.Empty;
            MessageBoxAdv.MaximumSize = Screen.PrimaryScreen.Bounds.Size;
            if(this.Resizecheckbox.CheckState == CheckState.Checked)
            {
                MessageBoxAdv.CanResize = true;
            }
            else
            {
                MessageBoxAdv.CanResize = false;
            }
            if (this.RTLCkBox.CheckState == CheckState.Checked)
            {
                MessageBoxAdv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            }
            else
            {
                MessageBoxAdv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            }
            if (this.BtnCmb.SelectedItem != null)
            {
                CaptionText = this.MsgBoxCaptionTxtBox.Text;
                bdyText = this.MsgBoxBodyTxtBox.Text;
                if (!LocalizationChkBx.Checked)
                {
                    LocalizationProvider.Provider = null;
                }
                else
                {
                    LocalizationProvider.Provider = new Localizer();
                }
                if (this.BtnCmb.SelectedItem.ToString() == "OK")
                {
                    if (LocalizationChkBx.CheckState == CheckState.Checked)
                    {
                        result = MessageBoxAdv.Show(this, bdyText, CaptionText, MessageBoxButtons.OK, SelectedIcon, SelectedIcon.Size, localizedDetailsText);
                    }
                    else
                    {
                        result = MessageBoxAdv.Show(this, bdyText, CaptionText, MessageBoxButtons.OK, SelectedIcon, SelectedIcon.Size, this.txt_Details.Text);
                    }
                }
                else if (this.BtnCmb.SelectedItem.ToString() == "OK, Cancel")
                {
                    if (LocalizationChkBx.CheckState == CheckState.Checked)
                    {
                        result = MessageBoxAdv.Show(this, bdyText, CaptionText, MessageBoxButtons.OKCancel, SelectedIcon, SelectedIcon.Size, localizedDetailsText);
                    }
                    else
                    {
                        result = MessageBoxAdv.Show(this, bdyText, CaptionText, MessageBoxButtons.OKCancel, SelectedIcon, SelectedIcon.Size, this.txt_Details.Text);
                    }
                }
                else if (this.BtnCmb.SelectedItem.ToString() == "Yes, No")
                {
                    if (LocalizationChkBx.CheckState == CheckState.Checked)
                    {
                        result = MessageBoxAdv.Show(this, bdyText, CaptionText, MessageBoxButtons.YesNo, SelectedIcon, SelectedIcon.Size, localizedDetailsText);
                    }
                    else
                    {
                        result = MessageBoxAdv.Show(this, bdyText, CaptionText, MessageBoxButtons.YesNo, SelectedIcon, SelectedIcon.Size, this.txt_Details.Text);
                    }
                }
                else if (this.BtnCmb.SelectedItem.ToString() == "Yes, No, Cancel")
                {
                    if (LocalizationChkBx.CheckState == CheckState.Checked)
                    {
                        result = MessageBoxAdv.Show(this, bdyText, CaptionText, MessageBoxButtons.YesNoCancel, SelectedIcon, SelectedIcon.Size, localizedDetailsText);
                    }
                    else
                    {
                        result = MessageBoxAdv.Show(this, bdyText, CaptionText, MessageBoxButtons.YesNoCancel, SelectedIcon, SelectedIcon.Size, this.txt_Details.Text);
                    }
                }
                else if (this.BtnCmb.SelectedItem.ToString() == "Retry, Cancel")
                {
                    if (LocalizationChkBx.CheckState == CheckState.Checked)
                    {
                        result = MessageBoxAdv.Show(this, bdyText, CaptionText, MessageBoxButtons.RetryCancel, SelectedIcon, SelectedIcon.Size, localizedDetailsText);
                    }
                    else
                    {
                        result = MessageBoxAdv.Show(this, bdyText, CaptionText, MessageBoxButtons.RetryCancel, SelectedIcon, SelectedIcon.Size, this.txt_Details.Text);
                    }
                }
                else if (this.BtnCmb.SelectedItem.ToString() == "Abort, Retry, Ignore")
                {
                    if (LocalizationChkBx.CheckState == CheckState.Checked)
                    {
                        result = MessageBoxAdv.Show(this, bdyText, CaptionText, MessageBoxButtons.AbortRetryIgnore, SelectedIcon, SelectedIcon.Size, localizedDetailsText);
                    }
                    else
                    {
                        result = MessageBoxAdv.Show(this, bdyText, CaptionText, MessageBoxButtons.AbortRetryIgnore, SelectedIcon, SelectedIcon.Size, this.txt_Details.Text);
                    }
                }
                else if (this.BtnCmb.SelectedItem.ToString() == "Custom")
                {
                    if (LocalizationChkBx.CheckState == CheckState.Checked)
                    {
                        CustomButtons = new string[] { "حسنا", "إلغاء", "مساعدة" };
                        clickedIndex = MessageBoxAdv.Show(this, bdyText, CaptionText, CustomButtons, SelectedIcon, SelectedIcon.Size, localizedDetailsText);
                    }
                    else
                    {
                        CustomButtons = new string[] { "Okay", "Cancel", "Help" };
                        clickedIndex = MessageBoxAdv.Show(this, bdyText, CaptionText, CustomButtons, SelectedIcon, SelectedIcon.Size, this.txt_Details.Text);
                    }
                }
                if (this.BtnCmb.SelectedItem.ToString() == "Custom")
                {
                    CustomButtons = new string[] { "Okay", "Cancel", "Help" };
                    DlgRtTxtBox.Text = CustomButtons[clickedIndex - 1];
                }
                else
                {
                    DlgRtTxtBox.Text = result.ToString();
                }
            }
        }
    

        /// <summary>
        /// Show MessageBoxAdv
        /// </summary>
        private void Msgbtn_Click(object sender, EventArgs e)
        {
            DisplayMessageBoxAdv();
        }

        /// <summary>
        /// Displays messagebox with selected icon.
        /// </summary>
        private void MsgIconCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.MsgBoxCaptionTxtBox.Text = this.MsgIconCmb.SelectedItem.ToString();
            MsgBoxBodyTxtBox.Text = messages[this.MsgIconCmb.SelectedIndex];
            if (this.MsgIconCmb.SelectedIndex == 0)
            {
                SelectedIcon = this.imageListAdv1.Images[0];
            }
            else if (this.MsgIconCmb.SelectedIndex == 1)
            {
                SelectedIcon = this.imageListAdv1.Images[1];
            }
            else if (this.MsgIconCmb.SelectedIndex == 2)
            {
                SelectedIcon = this.imageListAdv1.Images[2];
            }
            else if(this.MsgIconCmb.SelectedIndex==3)
            {
                SelectedIcon = SystemIcons.Information.ToBitmap();
            }
            else if (this.MsgIconCmb.SelectedIndex == 4)
            {
                SelectedIcon = SystemIcons.Question.ToBitmap();
            }

        }
    }
}
