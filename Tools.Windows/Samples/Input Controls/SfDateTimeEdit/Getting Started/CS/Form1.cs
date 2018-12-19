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
using Syncfusion.WinForms.Input;
using System.Globalization;
using Syncfusion.WinForms.Input.Events;

namespace SfDateTimeEdit_2015
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();             
        }

        #region Validating Event

        
        /// <summary>
        /// Validate the DateTimeText  
        /// </summary> 
        void DateRange_Validating(SfDateTimeEdit sender, ValidatingEventArgs args)
        {
            if (args.IsError)
                args.Cancel = true;
        }
        
        #endregion       

        #region Function

        /// <summary>
        /// Method to get Weekends and marked as blackoutdates
        /// </summary>
        public void GetWeekEnds()
        {
            var weekends = GetDaysBetween(DisabledDates.MinDateTime.Date, DisabledDates.MaxDateTime.Date).Where(d => d.DayOfWeek == DayOfWeek.Saturday || d.DayOfWeek == DayOfWeek.Sunday);
            List<DateTime> dates = new List<DateTime>();
            dates = weekends.ToList();
            this.DisabledDates.MonthCalendar.BlackoutDates = dates;           
        }

        /// <summary>
        /// Method to configure DateRange
        /// </summary>
        public void ConfigureDateRange()
        {
            this.DisabledDates.MinDateTime = new DateTime(DateTime.Now.Year - 1, DateTime.Now.Month, 1);
            this.DisabledDates.MaxDateTime = new DateTime(DateTime.Now.Year + 1, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year + 1, DateTime.Now.Month));
        }

        /// <summary>
        /// Get  WeekEnds days between year
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        IEnumerable<DateTime> GetDaysBetween(DateTime start, DateTime end)
        {
            for (DateTime i = start; i < end; i = i.AddDays(1))
            {
                yield return i;
            }
        }

        /// <summary>
        /// Method to make panel Center
        /// </summary>
        public void MakePanelCenter()
        {
            this.controlPanel.Location = new Point(this.ClientSize.Width / 2 - controlPanel.Size.Width / 2, this.ClientSize.Height / 2 - controlPanel.Size.Height / 2);
        }

        /// <summary>
        /// To make panel Center on form load
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            MakePanelCenter();
            ConfigureDateRange();
            GetWeekEnds();         
            this.dateTimeEdit.ThemeName = "Office2016Colorful";
            this.Mask.ThemeName = "Office2016Colorful";
            this.SpecialDates.ThemeName = "Office2016Colorful";
            this.Pattern.ThemeName = "Office2016Colorful";
            this.Allownull.ThemeName = "Office2016Colorful";
            this.DateRange.ThemeName = "Office2016Colorful";
            this.Culture.ThemeName = "Office2016Colorful";
            this.DisabledDates.ThemeName = "Office2016Colorful";
        }


        /// <summary>
        /// To make panel Center on form resize
        /// </summary>
        protected override void OnSizeChanged(EventArgs e)
        {
            MakePanelCenter();
            base.OnSizeChanged(e);
        }

        /// <summary>
        /// Event for Customize the date celll
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void MonthCalendar_DrawCell(SfCalendar sender, DrawCellEventArgs args)
        {
            DateTime Christmas = new DateTime(2017, 12, 25);
            DateTime Chris = new DateTime(2017, 12, 12);
            DateTime birthday = new DateTime(2018, 01, 26);
            DateTime farwell = new DateTime(2018, 01, 14);
            DateTime newyear = new DateTime(2018, 01, 01);
            if (args.Value != null)
            {
                if (args.Value == Christmas)
                {
                    args.ForeColor = Color.Chocolate;
                    args.ImageBounds = new Rectangle(2, 1, 24, 28);
                }
                if (args.Value == farwell)

                {
                    args.ForeColor = Color.Brown;
                }
                if (args.Value == Chris)

                {
                    args.ForeColor = Color.Red;                   
                }

                if (args.Value == newyear)

                {
                    args.ForeColor = Color.Blue;
                }
                if (args.Value == birthday)

                {
                    args.ForeColor = Color.GreenYellow;

                }
            }
        }
        #endregion
    }
}
