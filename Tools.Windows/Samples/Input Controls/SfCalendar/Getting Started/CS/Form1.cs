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
using System.Globalization;
using Syncfusion.WinForms.Input;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Input.Events;
using System.Runtime.InteropServices;

namespace SfCalendar_2015
{
    public partial class Form1 : MetroForm
    {
        #region Variables

        [DllImport("user32.dll")]
        private static extern long LockWindowUpdate(IntPtr Handle);

        #endregion

        #region Constructor

        public Form1()
        {
            InitializeComponent();

        }

        #endregion

        #region Functions

        /// <summary>
        /// Method to configure DateRange
        /// </summary>
        public void ConfigureDateRange()
        {
            this.cultureCmbBox.SelectedIndex = 0;
            this.multiSelectionCombo.SelectedIndex = 0;
            this.moveDateTimeEdit1.MonthCalendar.ShowFooter = false;
            this.sfCalendar.MaxDate = new DateTime(2100, 1, 1);
            this.sfCalendar.MinDate = new DateTime(1900, 1, 1);
            this.moveDateTimeEdit1.Value = DateTime.Now.Date;
            this.sfCalendar.ShowFooter = false;
            this.SelectedDateLbl.Text = this.sfCalendar.SelectedDate.Value.ToLongDateString();
            this.SelectedDateLbl.Font = new Font(this.SelectedDateLbl.Font.FontFamily, 10, FontStyle.Regular);
            this.sfCalendar.SelectionChanged += sfCalendar_SelectionChanged;
            this.moveDateTimeEdit1.ValueChanged += moveDateTimeEdit1_ValueChanged;
            this.moveDateTimeEdit1.MonthCalendar.ShowFooter = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }



        public void MakePanelCenter()
        {
            this.borderPanel1.Location = new Point(
    this.ClientSize.Width / 2 - borderPanel1.Size.Width / 2,
    this.ClientSize.Height / 2 - borderPanel1.Size.Height / 2);
        }

        #endregion

        #region Events

        /// <summary>
        /// Helps to move to Date
        /// </summary>
        void moveDateTimeEdit1_ValueChanged(object sender, DateTimeValueChangedEventArgs e)
        {
            if (this.sfCalendar.GoToDate(this.moveDateTimeEdit1.Value.Value))
            {
                this.sfCalendar.SelectedDate = this.moveDateTimeEdit1.Value.Value;
            }
        }

        /// <summary>
        /// Occurs when loading Form
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigureDateRange();
            MakePanelCenter();
            this.sfCalendar.ThemeName = "Office2016Colorful";
            this.moveDateTimeEdit1.ThemeName = "Office2016Colorful";
            this.multiSelectionCombo.Style = VisualStyle.Office2016Colorful;
            this.ThemeCmb.Style = VisualStyle.Office2016Colorful;
            this.cultureCmbBox.Style = VisualStyle.Office2016Colorful;
        }

        /// <summary>
        /// Occurs when Selection changed
        /// </summary>
        private void sfCalendar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.sfCalendar.SelectedDate == null)
            {
                this.SelectedDateLbl.Text = "None";
            }
            else
            {
                this.SelectedDateLbl.Text = this.sfCalendar.SelectedDate.Value.ToLongDateString();
            }
        }

        /// <summary>
        /// Occurs when Culture option is selected
        /// </summary>
        private void culture_Changed(object sender, EventArgs e)
        {
            this.sfCalendar.Culture = System.Globalization.CultureInfo.CreateSpecificCulture((sender as ComboBoxAdv).SelectedItem.ToString());
        }

        /// <summary>
        /// Occurs when Multi selection option is updated
        /// </summary>
        private void MultiSelection_Changed(object sender, EventArgs e)
        {
            this.sfCalendar.AllowMultipleSelection = bool.Parse((sender as ComboBoxAdv).SelectedItem.ToString());
        }

        /// <summary>
        /// Occurs when the Minimum date is modified
        /// </summary>
        private void Mindate_Changed(object sender, EventArgs e)
        {
            this.sfCalendar.MinDate = (sender as SfDateTimeEdit).Value.Value;
        }

        /// <summary>
        /// Occurs when the Maximum date is modified
        /// </summary>
        private void MaxDate_Changed(object sender, EventArgs e)
        {
            this.sfCalendar.MaxDate = (sender as SfDateTimeEdit).Value.Value;
        }

        /// <summary>
        /// Occurs when size is changed
        /// </summary>
        protected override void OnSizeChanged(EventArgs e)
        {
            MakePanelCenter();
            base.OnSizeChanged(e);
        }

        /// <summary>
        /// To customize Themes
        /// </summary>
        private void ThemeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            LockWindowUpdate(this.Handle);
            if (this.ThemeCmb.SelectedIndex == 0 || this.ThemeCmb.SelectedIndex == 1)
            {
                if (this.ThemeCmb.SelectedIndex == 0)
                {
                    this.sfCalendar.ThemeName = "Office2016Colorful";
                    this.moveDateTimeEdit1.ThemeName = "Office2016Colorful";
                }
                else if (this.ThemeCmb.SelectedIndex == 1)
                {
                    this.sfCalendar.ThemeName = "Office2016White";
                    this.moveDateTimeEdit1.ThemeName = "Office2016White";
                }
                this.BackColor = System.Drawing.Color.White;
                this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
                this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
                this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
                this.CaptionButtonHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
                this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
                this.multiSelectionCombo.Style = VisualStyle.Office2016Colorful;
                this.ThemeCmb.Style = VisualStyle.Office2016Colorful;
                this.cultureCmbBox.Style = VisualStyle.Office2016Colorful;
                this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
                this.label1.BackColor = System.Drawing.Color.White;
                this.culture_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
                this.culture_lbl.BackColor = System.Drawing.Color.White;
                this.captionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
                this.captionLbl.BackColor = System.Drawing.Color.White;
                this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
                this.label2.BackColor = System.Drawing.Color.White;
                this.Movedate_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
                this.Movedate_lbl.BackColor = System.Drawing.Color.White;
                this.SelectedDateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
                this.SelectedDateLbl.BackColor = System.Drawing.Color.White;
                this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
                this.label3.BackColor = System.Drawing.Color.White;
                this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
                this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            }
            else if (this.ThemeCmb.SelectedIndex == 2)
            {
                this.sfCalendar.ThemeName = "Office2016DarkGray";
                this.moveDateTimeEdit1.ThemeName = "Office2016DarkGray";
                this.CaptionButtonColor = ColorTranslator.FromHtml("#f0f0f0");
                this.CaptionButtonHoverColor = ColorTranslator.FromHtml("#f0f0f0");
                this.CaptionBarColor = ColorTranslator.FromHtml("#444444");
                this.CaptionForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.MetroColor = ColorTranslator.FromHtml("#444444");
                this.BackColor = ColorTranslator.FromHtml("#444444");
                this.BorderColor = ColorTranslator.FromHtml("#444444");
                this.multiSelectionCombo.Style = VisualStyle.Office2016DarkGray;
                this.ThemeCmb.Style = VisualStyle.Office2016DarkGray;
                this.cultureCmbBox.Style = VisualStyle.Office2016DarkGray;
                this.label1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label1.BackColor = ColorTranslator.FromHtml("#444444");
                this.culture_lbl.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.culture_lbl.BackColor = ColorTranslator.FromHtml("#444444");
                this.captionLbl.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.captionLbl.BackColor = ColorTranslator.FromHtml("#444444");
                this.label2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label2.BackColor = ColorTranslator.FromHtml("#444444");
                this.Movedate_lbl.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Movedate_lbl.BackColor = ColorTranslator.FromHtml("#444444");
                this.SelectedDateLbl.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.SelectedDateLbl.BackColor = ColorTranslator.FromHtml("#444444");
                this.label3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label3.BackColor = ColorTranslator.FromHtml("#444444");
                this.panel6.BackColor = ColorTranslator.FromHtml("#444444");
                this.MetroColor = ColorTranslator.FromHtml("#444444");
            }
            else if (this.ThemeCmb.SelectedIndex == 3)
            {
                this.sfCalendar.ThemeName = "Office2016Black";
                this.moveDateTimeEdit1.ThemeName = "Office2016Black";
                this.MetroColor = ColorTranslator.FromHtml("#0a0a0a");
                this.CaptionBarColor = ColorTranslator.FromHtml("#0a0a0a");
                this.CaptionForeColor = ColorTranslator.FromHtml("#ffffff");
                this.BackColor = ColorTranslator.FromHtml("#0a0a0a");
                this.panel6.BackColor = ColorTranslator.FromHtml("#0a0a0a");
                this.MetroColor = ColorTranslator.FromHtml("#0a0a0a");
                this.BorderColor = ColorTranslator.FromHtml("#0a0a0a");
                this.label1.ForeColor = ColorTranslator.FromHtml("#ffffff");
                this.label1.BackColor = ColorTranslator.FromHtml("#0a0a0a");
                this.multiSelectionCombo.ForeColor = ColorTranslator.FromHtml("#ffffff");
                this.multiSelectionCombo.BackColor = ColorTranslator.FromHtml("#0a0a0a");
                this.cultureCmbBox.ForeColor = ColorTranslator.FromHtml("#ffffff");
                this.cultureCmbBox.BackColor = ColorTranslator.FromHtml("#0a0a0a");
                this.culture_lbl.ForeColor = ColorTranslator.FromHtml("#ffffff");
                this.culture_lbl.BackColor = ColorTranslator.FromHtml("#0a0a0a");
                this.captionLbl.ForeColor = ColorTranslator.FromHtml("#ffffff");
                this.captionLbl.BackColor = ColorTranslator.FromHtml("#0a0a0a");
                this.label2.ForeColor = ColorTranslator.FromHtml("#ffffff");
                this.label2.BackColor = ColorTranslator.FromHtml("#0a0a0a");
                this.Movedate_lbl.ForeColor = ColorTranslator.FromHtml("#ffffff");
                this.Movedate_lbl.BackColor = ColorTranslator.FromHtml("#0a0a0a");
                this.SelectedDateLbl.ForeColor = ColorTranslator.FromHtml("#ffffff");
                this.SelectedDateLbl.BackColor = ColorTranslator.FromHtml("#0a0a0a");
                this.ThemeCmb.ForeColor = ColorTranslator.FromHtml("#ffffff");
                this.ThemeCmb.BackColor = ColorTranslator.FromHtml("#0a0a0a");
                this.label3.ForeColor = ColorTranslator.FromHtml("#ffffff");
                this.label3.BackColor = ColorTranslator.FromHtml("#0a0a0a");
                this.multiSelectionCombo.Style = VisualStyle.Office2016Black;
                this.ThemeCmb.Style = VisualStyle.Office2016Black;
                this.cultureCmbBox.Style = VisualStyle.Office2016Black;
                this.panel6.BackColor = ColorTranslator.FromHtml("#0a0a0a");
            }
            LockWindowUpdate(IntPtr.Zero);
        }

        #endregion

    }
}
