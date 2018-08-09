using System.Drawing;
using Syncfusion.Windows.Forms;

namespace SfNumericTextBoxDemo
{
    public partial class GettingStarted : MetroForm
    {
        #region Constructor

        /// <summary>
        /// Initialize the new instance of <see cref="GettingStarted"/> class.
        /// </summary>
        public GettingStarted()
        {
            InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
            this.ValidationTextBox.ThemeName =
            this.RTLTextBox.ThemeName =
            this.MinMaxTextBox.ThemeName =
            this.PrefixSuffixTextBox.ThemeName =
            this.WatermarkTextBox.ThemeName =
            this.CurrencyTextBox.ThemeName =
            this.PercentageTextBox.ThemeName =
            this.NumericTextBox.ThemeName = "Office2016Colorful";
            this.ValidationTextBox.ValueChanged += ValidationTextBox_ValueChanged;
            this.ValidationTextBox.NumberFormatInfo = new System.Globalization.NumberFormatInfo() { NumberGroupSeparator = "", NumberDecimalDigits = 0};
        }

        #endregion

        #region Events

        /// <summary>
        /// Validates the control and updated the error message for <see cref="ValidationTextBox"/>.
        /// </summary>
        /// <param name="sender"><see cref="ValidationTextBox"/>.</param>
        /// <param name="e">Event args that contains new value and old value.</param>
        private void ValidationTextBox_ValueChanged(object sender, Syncfusion.WinForms.Input.Events.ValueChangedEventArgs e)
        {
            if((this.ValidationTextBox.Value >= 1000000000 && this.ValidationTextBox.Value <= 9999999999) || this.ValidationTextBox.Value == null)
            {
                this.errorProvider.SetError(this.ValidationTextBox, string.Empty);
                this.ValidationTextBox.Style.FocusBorderColor = this.ValidationTextBox.Style.BorderColor = ColorTranslator.FromHtml("#7A7A7A");
            }
            else
            {
                this.errorProvider.SetError(this.ValidationTextBox, "Invalid mobile number.");
                this.ValidationTextBox.Style.FocusBorderColor = this.ValidationTextBox.Style.BorderColor = Color.Red;
            }
        }

        #endregion

        #region Methods.

        /// <summary>
        /// Gets the icon.
        /// </summary>
        /// <param name="bitmapName">Bitmap image.</param>
        /// <returns>Location of the bitmap image.</returns>
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
        
    }
}
