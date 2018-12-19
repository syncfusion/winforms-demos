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

namespace MetroForm
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : SfForm
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();
            SetMetroFormStyle();
            #region Border Customization
            this.Style.Border.Width = trackBarEx1.Value;
            this.trackBarEx1.ValueChanged += TrackBarEx1_ValueChanged;
            btnBorderColor.ColorSelected += BtnBorderColor_ColorSelected;
            #endregion

            #region TitleBar Customization
            this.btnCaptionBackColor.ColorSelected += BtnCaptionBackColor_ColorSelected;
            this.btnCaptionForeColor.ColorSelected += BtnCaptionForeColor_ColorSelected;
            this.btnCaptionButtonBackColor.ColorSelected += BtnCaptionButtonBackColor_ColorSelected;
            this.btnCaptionButtonForeColor.ColorSelected += BtnCaptionButtonForeColor_ColorSelected1;
            #endregion

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
        /// This method consist of the Metroform style which applied to the SfForm
        /// </summary>
        public void SetMetroFormStyle()
        {
            this.Style.TitleBar.Height = 26;
            this.Style.TitleBar.BackColor = Color.White;
            this.Style.TitleBar.IconBackColor = Color.FromArgb(15, 161, 212);
            this.BackColor = Color.White;
            this.Style.TitleBar.ForeColor = ColorTranslator.FromHtml("#343434");
            this.Style.TitleBar.CloseButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.MaximizeButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.MinimizeButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.HelpButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.IconHorizontalAlignment = HorizontalAlignment.Left;
            this.Style.TitleBar.Font = this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Style.TitleBar.TextHorizontalAlignment = HorizontalAlignment.Center;
            this.Style.TitleBar.TextVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
        }

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
            if (trackBarEx1.Value == 0)
            {
                this.Style.Border.Width = 1;
                this.Style.InactiveBorder.Width = 1;
            }
            else
            {
                this.Style.Border.Width = trackBarEx1.Value;
                this.Style.InactiveBorder.Width = trackBarEx1.Value;
            }

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
    }
}
