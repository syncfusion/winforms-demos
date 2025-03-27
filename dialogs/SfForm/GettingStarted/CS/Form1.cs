#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Windows.Forms;
using Syncfusion.WinForms.Controls;
using System.Drawing;
using System.Collections.Generic;
using Syncfusion.Windows.Forms;

namespace GettingStarted
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : SfForm
    {
        #region Constructor
        SfToolTip toolTipRoundedCorners = new SfToolTip();
        public Form1()
        {
            InitializeComponent();
            label6.ThemeStyle.Font =  new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sficon.ico"));
                this.Icon = ico;
            }
            catch { }
            ToolTipItem toolTipItem = new ToolTipItem();
            toolTipItem.Text = "This option will work only in Windows 11 OS";
            Syncfusion.WinForms.Controls.ToolTipInfo toolTipInfo = new Syncfusion.WinForms.Controls.ToolTipInfo();
            toolTipInfo.Items.Add(toolTipItem);
            toolTipInfo.MinWidth = 250;
            toolTipRoundedCorners.SetToolTipInfo(checkBoxRoundedCorners, toolTipInfo);
            #region Border Customization
            this.trackBarEx1.ValueChanged += TrackBarEx1_ValueChanged;
            this.trackBarEx1.Value = 2;
            btnBorderColor.ColorSelected += BtnBorderColor_ColorSelected;

            #endregion

            #region TitleBar Customization
            this.btnCaptionBackColor.ColorSelected += BtnCaptionBackColor_ColorSelected;
            this.btnCaptionForeColor.ColorSelected += BtnCaptionForeColor_ColorSelected;
            this.btnCaptionButtonBackColor.ColorSelected += BtnCaptionButtonBackColor_ColorSelected;
            this.btnCaptionButtonForeColor.ColorSelected += BtnCaptionButtonForeColor_ColorSelected1;
            #endregion

            #region themComboBox settings
            List<ThemeTypes> theme = new List<ThemeTypes>();
            theme.Add(new ThemeTypes() { ThemeName = "Office2016 Black", Value = 1 });
            theme.Add(new ThemeTypes() { ThemeName = "Office2016 White", Value = 2 });
            theme.Add(new ThemeTypes() { ThemeName = "Office2016 DarkGray", Value = 3 });
            theme.Add(new ThemeTypes() { ThemeName = "Office2016 Colorful", Value = 4 });
            theme.Add(new ThemeTypes() { ThemeName = "Office2019 Colorful", Value = 5 });
            theme.Add(new ThemeTypes() { ThemeName = "HighContrast Black", Value = 6 });
            comboBox1.DataSource = theme;
            comboBox1.DisplayMember = "ThemeName";
            comboBox1.ValueMember = "ThemeName";
            comboBox1.SelectedValueChanged += ComboBox1_SelectedValueChanged;
            comboBox1.SelectedValue = "Office2016 Colorful";

            #endregion
        }

        private void ComboBox1_SelectedValueChanged(object sender, System.EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() == "Office2016 Black")
            {
                SkinManager.SetVisualStyle(this, "Office2016Black");
            }
            else if (comboBox1.SelectedValue.ToString() == "Office2016 DarkGray")
            {
                SkinManager.SetVisualStyle(this, "Office2016DarkGray");
            }
            else if (comboBox1.SelectedValue.ToString() == "Office2016 Colorful")
            {
                SkinManager.SetVisualStyle(this, "Office2016Colorful");
            }
            else if (comboBox1.SelectedValue.ToString() == "Office2016 White")
            {
                SkinManager.SetVisualStyle(this, "Office2016White");
            }
            else if (comboBox1.SelectedValue.ToString() == "Office2019 Colorful")
            {
                SkinManager.SetVisualStyle(this, "Office2019Colorful");
            }
            if (comboBox1.SelectedValue.ToString() == "HighContrast Black")
            {
                SkinManager.SetVisualStyle(this, "HighContrastBlack");
            }
        }
        #endregion

        #region Icon Handlers
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
        /// Set CaptionButtons Fore color
        /// </summary>
        private void BtnCaptionButtonForeColor_ColorSelected1(object sender, System.EventArgs e)
        {
            this.Style.TitleBar.MaximizeButtonHoverForeColor = btnCaptionButtonForeColor.SelectedColor;
            this.Style.TitleBar.MinimizeButtonHoverForeColor = btnCaptionButtonForeColor.SelectedColor;
            this.Style.TitleBar.HelpButtonHoverForeColor = btnCaptionButtonForeColor.SelectedColor;
            this.Style.TitleBar.CloseButtonHoverForeColor = btnCaptionButtonForeColor.SelectedColor;

            this.Style.TitleBar.MaximizeButtonPressedForeColor = btnCaptionButtonForeColor.SelectedColor;
            this.Style.TitleBar.MinimizeButtonPressedForeColor = btnCaptionButtonForeColor.SelectedColor;
            this.Style.TitleBar.HelpButtonPressedForeColor = btnCaptionButtonForeColor.SelectedColor;
            this.Style.TitleBar.CloseButtonPressedForeColor = btnCaptionButtonForeColor.SelectedColor;

            this.Style.TitleBar.MaximizeButtonForeColor = btnCaptionButtonForeColor.SelectedColor;
            this.Style.TitleBar.MinimizeButtonForeColor = btnCaptionButtonForeColor.SelectedColor;
            this.Style.TitleBar.HelpButtonForeColor = btnCaptionButtonForeColor.SelectedColor;
            this.Style.TitleBar.CloseButtonForeColor = btnCaptionButtonForeColor.SelectedColor;
            UpdateStyles();

        }

        /// <summary>
        /// Set CaptionButtons Back color
        /// </summary>
        private void BtnCaptionButtonBackColor_ColorSelected(object sender, System.EventArgs e)
        {
            this.Style.TitleBar.MaximizeButtonHoverBackColor = btnCaptionButtonBackColor.SelectedColor;
            this.Style.TitleBar.MinimizeButtonHoverBackColor = btnCaptionButtonBackColor.SelectedColor;
            this.Style.TitleBar.HelpButtonHoverBackColor = btnCaptionButtonBackColor.SelectedColor;
            this.Style.TitleBar.CloseButtonHoverBackColor = btnCaptionButtonBackColor.SelectedColor;
            this.Style.TitleBar.MaximizeButtonPressedBackColor = btnCaptionButtonBackColor.SelectedColor;
            this.Style.TitleBar.MinimizeButtonPressedBackColor = btnCaptionButtonBackColor.SelectedColor;
            this.Style.TitleBar.HelpButtonPressedBackColor = btnCaptionButtonBackColor.SelectedColor;
            this.Style.TitleBar.CloseButtonPressedBackColor = btnCaptionButtonBackColor.SelectedColor;
            UpdateStyles();
        }

        /// <summary>
        /// Set Caption Fore color
        /// </summary>
        private void BtnCaptionForeColor_ColorSelected(object sender, System.EventArgs e)
        {
            this.Style.TitleBar.ForeColor = btnCaptionForeColor.SelectedColor;
            UpdateStyles();
        }

        /// <summary>
        /// Set Caption Back color
        /// </summary>
        private void BtnCaptionBackColor_ColorSelected(object sender, System.EventArgs e)
        {
            this.Style.TitleBar.BackColor = btnCaptionBackColor.SelectedColor;
            UpdateStyles();
        }

        /// <summary>
        /// Set Border color
        /// </summary>
        private void BtnBorderColor_ColorSelected(object sender, System.EventArgs e)
        {
            this.Style.Border.Color = btnBorderColor.SelectedColor;
            this.Style.InactiveBorder.Color = btnBorderColor.SelectedColor;
            this.UpdateStyles();
        }

        /// <summary>
        /// Set Border thickness
        /// </summary>
        private void TrackBarEx1_ValueChanged(object sender, System.EventArgs e)
        {
            this.Style.Border.Width = trackBarEx1.Value;
            this.Style.InactiveBorder.Width = trackBarEx1.Value;
            this.UpdateStyles();
        }

        private void radioButtonCenter_CheckChanged(object sender, System.EventArgs e)
        {
            this.Style.TitleBar.TextHorizontalAlignment = HorizontalAlignment.Center;
            UpdateStyles();
        }

        private void radioButtonRight_CheckChanged(object sender, System.EventArgs e)
        {
            this.Style.TitleBar.TextHorizontalAlignment = HorizontalAlignment.Right;
            UpdateStyles();
        }

        private void radioButtonLeft_CheckChanged(object sender, System.EventArgs e)
        {
            if (radioButtonLeft.Checked)
                this.Style.TitleBar.TextHorizontalAlignment = HorizontalAlignment.Left;
        }

        private void radioButtonCenter_CheckChanged_1(object sender, System.EventArgs e)
        {
            this.Style.TitleBar.TextHorizontalAlignment = HorizontalAlignment.Center;
        }

        private void radioButtonRight_CheckChanged_1(object sender, System.EventArgs e)
        {
            this.Style.TitleBar.TextHorizontalAlignment = HorizontalAlignment.Right;
        }

        private void radioButtonTop_CheckChanged(object sender, System.EventArgs e)
        {
            this.Style.TitleBar.TextVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Top;
        }

        private void radioButtonMiddle_CheckChanged(object sender, System.EventArgs e)
        {
            if (radioButtonMiddle.Checked)
                this.Style.TitleBar.TextVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
        }

        private void radioButtonBottom_CheckChanged(object sender, System.EventArgs e)
        {
            this.Style.TitleBar.TextVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Bottom;
        }

        private void checkBoxIcon_CheckStateChanged(object sender, System.EventArgs e)
        {
            this.ShowIcon = checkBoxIcon.Checked;
        }

        private void checkBoxHelpButton_CheckStateChanged(object sender, System.EventArgs e)
        {
            this.HelpButton = checkBoxHelpButton.Checked;
        }

        private void checkBoxRoundedCorners_CheckStateChanged(object sender, System.EventArgs e)
        {
            this.AllowRoundedCorners = checkBoxRoundedCorners.Checked;
        }

    }

    #region ThemeData
    public class ThemeTypes
    {
        public string ThemeName { get; set; }
        public int Value { get; set; }
    }
    #endregion
}
