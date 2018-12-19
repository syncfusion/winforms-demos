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

        public Form1()
        {
            InitializeComponent();
            if (this.imageListAdv1.Images.Count > 0)
                SelectedIcon = this.imageListAdv1.Images[0];
            
            this.DlgRtTxtBox.ReadOnly = true;
            this.DlgRtTxtBox.BackColor = Color.White;
            this.fontComboBox1.SelectedValueChanged += ComboBoxAdv2_SelectedValueChanged;
            this.comboBoxAdv1.SelectedValueChanged += ComboBoxAdv2_SelectedValueChanged;
            this.comboBoxAdv2.SelectedValueChanged += ComboBoxAdv2_SelectedValueChanged;
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
        /// ComboBoxAdv
        /// </summary>
        private void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
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
        }

        private void comboBoxAdv3_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMessageBoxAdvTheme();
        }

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

        public void DisplayMessageBoxAdv()
        {
            DialogResult result = DialogResult.OK;
            int clickedIndex = 0;
            string[] CustomButtons = new string[] {"Okay","Cancel","Help"};
            UpdateMessageBoxAdvTheme();
            string bdyText = string.Empty;
            string CaptionText = string.Empty;
            MessageBoxAdv.MaximumSize = Screen.PrimaryScreen.Bounds.Size;
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
                    //bdyText = "你好，世界！";
                    //CaptionText = "你好";
                }
                if (this.BtnCmb.SelectedItem.ToString() == "OK")
                {
                    if (LocalizationChkBx.CheckState == CheckState.Checked)
                    {
                        result = MessageBoxAdv.Show(this, bdyText, CaptionText, MessageBoxButtons.OK, SelectedIcon, SelectedIcon.Size, "سينكفوسيون هو شريك تكنولوجيا المؤسسة المفضل لتطوير البرمجيات، وتقديم مجموعة واسعة من الضوابط على شبكة الإنترنت، المحمول، وسطح المكتب إلى جانب نهج خدمة المنحى طوال دورة حياة التطبيق بأكمله. وقد أنشأت سينكفوسيون نفسها كشريك موثوق به في جميع أنحاء العالم لاستخدامها في التطبيقات المهمة الحرجة. تأسست في عام 2001 ومقرها في ريزارتش تريانجل بارك، N.C.، سينكفوسيون لديها أكثر من 12،000 عميل، بما في ذلك المؤسسات المالية الكبيرة، فورتشن 100 شركة، .");
                    }
                    else
                    {
                        result = MessageBoxAdv.Show(this, bdyText, CaptionText, MessageBoxButtons.OK, SelectedIcon, SelectedIcon.Size, "Syncfusion is the enterprise technology partner of choice for software development, delivering a broad range of web, mobile, and desktop controls coupled with a service-oriented approach throughout the entire application lifecycle. Syncfusion has established itself as the trusted partner worldwide for use in mission-critical applications. Founded in 2001 and headquartered in Research Triangle Park, N.C., Syncfusion has more than 12,000 customers, including large financial institutions, Fortune 100 companies, and global IT consultancies.");
                    }
                }
                else if (this.BtnCmb.SelectedItem.ToString() == "OK, Cancel")
                {
                   
                    if (LocalizationChkBx.CheckState == CheckState.Checked)
                    {
                        result = MessageBoxAdv.Show(this, bdyText, CaptionText, MessageBoxButtons.OKCancel, SelectedIcon, SelectedIcon.Size, "سينكفوسيون هو شريك تكنولوجيا المؤسسة المفضل لتطوير البرمجيات، وتقديم مجموعة واسعة من الضوابط على شبكة الإنترنت، المحمول، وسطح المكتب إلى جانب نهج خدمة المنحى طوال دورة حياة التطبيق بأكمله. وقد أنشأت سينكفوسيون نفسها كشريك موثوق به في جميع أنحاء العالم لاستخدامها في التطبيقات المهمة الحرجة. تأسست في عام 2001 ومقرها في ريزارتش تريانجل بارك، N.C.، سينكفوسيون لديها أكثر من 12،000 عميل، بما في ذلك المؤسسات المالية الكبيرة، فورتشن 100 شركة، ");
                    }
                    else
                    {
                        result = MessageBoxAdv.Show(this, bdyText, CaptionText, MessageBoxButtons.OKCancel, SelectedIcon, SelectedIcon.Size, "Syncfusion is the enterprise technology partner of choice for software development, delivering a broad range of web, mobile, and desktop controls coupled with a service-oriented approach throughout the entire application lifecycle. Syncfusion has established itself as the trusted partner worldwide for use in mission-critical applications. Founded in 2001 and headquartered in Research Triangle Park, N.C., Syncfusion has more than 12,000 customers, including large financial institutions, Fortune 100 companies, and global IT consultancies.");
                    }
                }
                else if (this.BtnCmb.SelectedItem.ToString() == "Yes, No")
                {
                    if (LocalizationChkBx.CheckState == CheckState.Checked)
                    {
                        result = MessageBoxAdv.Show(this, bdyText, CaptionText, MessageBoxButtons.YesNo, SelectedIcon, SelectedIcon.Size, "سينكفوسيون هو شريك تكنولوجيا المؤسسة المفضل لتطوير البرمجيات، وتقديم مجموعة واسعة من الضوابط على شبكة الإنترنت، المحمول، وسطح المكتب إلى جانب نهج خدمة المنحى طوال دورة حياة التطبيق بأكمله. وقد أنشأت سينكفوسيون نفسها كشريك موثوق به في جميع أنحاء العالم لاستخدامها في التطبيقات المهمة الحرجة. تأسست في عام 2001 ومقرها في ريزارتش تريانجل بارك، N.C.، سينكفوسيون لديها أكثر من 12،000 عميل، بما في ذلك المؤسسات المالية الكبيرة، فورتشن 100 شركة، .");
                    }
                    else
                    {
                        result = MessageBoxAdv.Show(this, bdyText, CaptionText, MessageBoxButtons.YesNo, SelectedIcon, SelectedIcon.Size, "Syncfusion is the enterprise technology partner of choice for software development, delivering a broad range of web, mobile, and desktop controls coupled with a service-oriented approach throughout the entire application lifecycle. Syncfusion has established itself as the trusted partner worldwide for use in mission-critical applications. Founded in 2001 and headquartered in Research Triangle Park, N.C., Syncfusion has more than 12,000 customers, including large financial institutions, Fortune 100 companies, and global IT consultancies.");
                    }
                }
                else if (this.BtnCmb.SelectedItem.ToString() == "Yes, No, Cancel")
                {
                    if (LocalizationChkBx.CheckState == CheckState.Checked)
                    {
                        result = MessageBoxAdv.Show(this, bdyText, CaptionText, MessageBoxButtons.YesNoCancel, SelectedIcon, SelectedIcon.Size, "سينكفوسيون هو شريك تكنولوجيا المؤسسة المفضل لتطوير البرمجيات، وتقديم مجموعة واسعة من الضوابط على شبكة الإنترنت، المحمول، وسطح المكتب إلى جانب نهج خدمة المنحى طوال دورة حياة التطبيق بأكمله. وقد أنشأت سينكفوسيون نفسها كشريك موثوق به في جميع أنحاء العالم لاستخدامها في التطبيقات المهمة الحرجة. تأسست في عام 2001 ومقرها في ريزارتش تريانجل بارك، N.C.، سينكفوسيون لديها أكثر من 12،000 عميل، بما في ذلك المؤسسات المالية الكبيرة، فورتشن 100 شركة، .");
                    }
                    else
                    {
                        result = MessageBoxAdv.Show(this, bdyText, CaptionText, MessageBoxButtons.YesNoCancel, SelectedIcon, SelectedIcon.Size, "Syncfusion is the enterprise technology partner of choice for software development, delivering a broad range of web, mobile, and desktop controls coupled with a service-oriented approach throughout the entire application lifecycle. Syncfusion has established itself as the trusted partner worldwide for use in mission-critical applications. Founded in 2001 and headquartered in Research Triangle Park, N.C., Syncfusion has more than 12,000 customers, including large financial institutions, Fortune 100 companies, and global IT consultancies.");
                    }
                }
                else if (this.BtnCmb.SelectedItem.ToString() == "Retry, Cancel")
                {
                    if (LocalizationChkBx.CheckState == CheckState.Checked)
                    {
                        result = MessageBoxAdv.Show(this, bdyText, CaptionText, MessageBoxButtons.RetryCancel, SelectedIcon, SelectedIcon.Size, "سينكفوسيون هو شريك تكنولوجيا المؤسسة المفضل لتطوير البرمجيات، وتقديم مجموعة واسعة من الضوابط على شبكة الإنترنت، المحمول، وسطح المكتب إلى جانب نهج خدمة المنحى طوال دورة حياة التطبيق بأكمله. وقد أنشأت سينكفوسيون نفسها كشريك موثوق به في جميع أنحاء العالم لاستخدامها في التطبيقات المهمة الحرجة. تأسست في عام 2001 ومقرها في ريزارتش تريانجل بارك، N.C.، سينكفوسيون لديها أكثر من 12،000 عميل، بما في ذلك المؤسسات المالية الكبيرة، فورتشن 100 شركة،.");
                    }
                    else
                    {
                        result = MessageBoxAdv.Show(this, bdyText, CaptionText, MessageBoxButtons.RetryCancel, SelectedIcon, SelectedIcon.Size, "Syncfusion is the enterprise technology partner of choice for software development, delivering a broad range of web, mobile, and desktop controls coupled with a service-oriented approach throughout the entire application lifecycle. Syncfusion has established itself as the trusted partner worldwide for use in mission-critical applications. Founded in 2001 and headquartered in Research Triangle Park, N.C., Syncfusion has more than 12,000 customers, including large financial institutions, Fortune 100 companies, and global IT consultancies.");
                    }
                }
                else if (this.BtnCmb.SelectedItem.ToString() == "Abort, Retry, Ignore")
                {
                    if (LocalizationChkBx.CheckState == CheckState.Checked)
                    {
                        result = MessageBoxAdv.Show(this, bdyText, CaptionText, MessageBoxButtons.AbortRetryIgnore, SelectedIcon, SelectedIcon.Size, "سينكفوسيون هو شريك تكنولوجيا المؤسسة المفضل لتطوير البرمجيات، وتقديم مجموعة واسعة من الضوابط على شبكة الإنترنت، المحمول، وسطح المكتب إلى جانب نهج خدمة المنحى طوال دورة حياة التطبيق بأكمله. وقد أنشأت سينكفوسيون نفسها كشريك موثوق به في جميع أنحاء العالم لاستخدامها في التطبيقات المهمة الحرجة. تأسست في عام 2001 ومقرها في ريزارتش تريانجل بارك، N.C.، سينكفوسيون لديها أكثر من 12،000 عميل، بما في ذلك المؤسسات المالية الكبيرة، فورتشن 100 شركة، .");
                    }
                    else
                    {
                        result = MessageBoxAdv.Show(this, bdyText, CaptionText, MessageBoxButtons.AbortRetryIgnore, SelectedIcon, SelectedIcon.Size, "Syncfusion is the enterprise technology partner of choice for software development, delivering a broad range of web, mobile, and desktop controls coupled with a service-oriented approach throughout the entire application lifecycle. Syncfusion has established itself as the trusted partner worldwide for use in mission-critical applications. Founded in 2001 and headquartered in Research Triangle Park, N.C., Syncfusion has more than 12,000 customers, including large financial institutions, Fortune 100 companies, and global IT consultancies.");
                    }
                }
                else if (this.BtnCmb.SelectedItem.ToString() == "Custom")
                {
                    if (LocalizationChkBx.CheckState == CheckState.Checked)
                    {
                        CustomButtons = new string[] { "حسنا", "إلغاء", "مساعدة" };
                        clickedIndex = MessageBoxAdv.Show(this, bdyText, CaptionText, CustomButtons, SelectedIcon, SelectedIcon.Size, "سينكفوسيون هو شريك تكنولوجيا المؤسسة المفضل لتطوير البرمجيات، وتقديم مجموعة واسعة من الضوابط على شبكة الإنترنت، المحمول، وسطح المكتب إلى جانب نهج خدمة المنحى طوال دورة حياة التطبيق بأكمله. وقد أنشأت سينكفوسيون نفسها كشريك موثوق به في جميع أنحاء العالم لاستخدامها في التطبيقات المهمة الحرجة. تأسست في عام 2001 ومقرها في ريزارتش تريانجل بارك، N.C.، سينكفوسيون لديها أكثر من 12،000 عميل، بما في ذلك المؤسسات المالية الكبيرة، فورتشن 100 شركة، .");
                    }
                    else
                    {
                        CustomButtons = new string[] { "Okay", "Cancel", "Help" };
                        clickedIndex = MessageBoxAdv.Show(this, bdyText, CaptionText, CustomButtons, SelectedIcon, SelectedIcon.Size, "Syncfusion is the enterprise technology partner of choice for software development, delivering a broad range of web, mobile, and desktop controls coupled with a service-oriented approach throughout the entire application lifecycle. Syncfusion has established itself as the trusted partner worldwide for use in mission-critical applications. Founded in 2001 and headquartered in Research Triangle Park, N.C., Syncfusion has more than 12,000 customers, including large financial institutions, Fortune 100 companies, and global IT consultancies.");
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
        /// Icons
        /// </summary>
        private void MsgIconCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        }
        
    }
}
