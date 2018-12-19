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
using Syncfusion.WinForms.Input.Events;

namespace SfCalendar_2015
{
    public partial class Form1 : MetroForm
    {

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
            this.minDateTimeEdit.ValueChanged += MinDateTimeEdit_ValueChanged;
            this.maxDateTimeEdit.ValueChanged += MaxDateTimeEdit_ValueChanged;
            minDateTimeEdit.Value = DateTime.Now.Date.AddMonths(-6);
            maxDateTimeEdit.Value = DateTime.Now.Date.AddMonths(6);            
            GetWeekends();
            this.sfCalendar.MinDate = minDateTimeEdit.Value.Value;
            this.sfCalendar.MaxDate = maxDateTimeEdit.Value.Value;
            this.minDateTimeEdit.MonthCalendar.ShowFooter = false;
            this.maxDateTimeEdit.MonthCalendar.ShowFooter = false;
            this.label2.Text = this.sfCalendar.SelectedDate.Value.ToLongDateString();
        }

        /// <summary>
        /// Method to make the panel Center
        /// </summary>
        public void MakePanelCenter()
        {
            this.borderPanel1.Location = new Point(this.ClientSize.Width / 2 - borderPanel1.Size.Width / 2, this.ClientSize.Height / 2 - borderPanel1.Size.Height / 2);
        }

        /// <summary>
        /// Method to get Weekends and marked as blackoutdates
        /// </summary>
        public void GetWeekends()
        {
            var weekends = GetDaysBetween(minDateTimeEdit.Value.Value, maxDateTimeEdit.Value.Value).Where(d => d.DayOfWeek == DayOfWeek.Saturday || d.DayOfWeek == DayOfWeek.Sunday);
            List<DateTime> time = new List<DateTime>();
            time = weekends.ToList();
            this.sfCalendar.BlackoutDates = time;
        }

        /// <summary>
        /// Get Weekend days beween two years
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
        #endregion

        #region Events

        private void MaxDateTimeEdit_ValueChanged(object sender, Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventArgs e)
        {
            this.sfCalendar.MaxDate = (sender as SfDateTimeEdit).Value.Value;
            this.minDateTimeEdit.MaxDateTime = (sender as SfDateTimeEdit).Value.Value;
            GetWeekends();
        }

        private void MinDateTimeEdit_ValueChanged(object sender, Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventArgs e)
        {
            this.sfCalendar.MinDate = (sender as SfDateTimeEdit).Value.Value;
            this.maxDateTimeEdit.MinDateTime = (sender as SfDateTimeEdit).Value.Value;
            GetWeekends();
        }

        /// <summary>
        /// Method to make the panel center 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            MakePanelCenter();
            ConfigureDateRange();
        }

        /// <summary>
        /// Method to make the panel center On Resize
        /// </summary>
        /// <param name="e"></param>
        protected override void OnSizeChanged(EventArgs e)
        {
            MakePanelCenter();
            base.OnSizeChanged(e);
        }

        /// <summary>
        /// Event to display the selected date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sfCalendar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.sfCalendar.SelectedDate == null)
            {
                this.label2.Text = "None";
            }
            else
            {
                this.label2.Text = this.sfCalendar.SelectedDate.Value.ToLongDateString();
            }
        }

        #endregion

    }
}
