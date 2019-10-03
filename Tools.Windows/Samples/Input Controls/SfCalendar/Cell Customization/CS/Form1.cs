#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
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
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Syncfusion.WinForms.Controls;

namespace AppointmentDemo
{
    public partial class Form1 : SfForm
    {
        #region Variables
        /// <summary>
        /// Generate Random days
        /// </summary>
        private Random gen = new Random();
        /// <summary>
        /// To lock window update
        /// </summary>
        /// <param name="Handle"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        private static extern long LockWindowUpdate(IntPtr Handle);

        #endregion

        #region Constructor

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Variable to hold the appointment
        /// </summary>
        private List<Appointment> m_Appointment = new List<Appointment>();
        /// <summary>
        /// Collection to hold the Appointment
        /// </summary>
        public List<Appointment> Appointment
        {
            get { return m_Appointment; }
        }

        #endregion

        #region Events

        List<string> UsedColors = new List<string>();

        private Color RandColor()
        {
            Random x = new Random();
            int r, g, b;
            Color myRgbColor = new Color();
            while (true)
            {
                r = x.Next(0, 255);
                g = x.Next(0, 255);
                b = x.Next(0, 255);
                if (!UsedColors.Contains(r + "," + g + "," + b))
                {
                    UsedColors.Add(r + "," + g + "," + b);
                    break;
                }
            }
            myRgbColor = Color.FromArgb(r, g, b);
            return myRgbColor;
        }

        /// <summary>
        /// Event for Load
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.sfCalendar1.SelectionChanged += SfCalendar1_SelectionChanged;
            this.sfCalendar1.DrawCell += SfCalendar1_DrawCell1;
            this.sfCalendar1.HighlightTodayCell = false;

            RandomMeetingInfo morInfo;
            RandomMeetingInfo morInfo1;
            EveRandomMeetingInfo eveInfo;

            for (int i = 0; i <= 6; i++)
            {
                
                morInfo = new RandomMeetingInfo(new DateTime(DateTime.Now.Year, DateTime.Now.AddMonths(i).Month, 1), new DateTime(DateTime.Now.Year, DateTime.Now.AddMonths(i).Month, 28));
                morInfo1 = new RandomMeetingInfo(new DateTime(DateTime.Now.Year, DateTime.Now.AddMonths(i).Month, 1), new DateTime(DateTime.Now.Year, DateTime.Now.AddMonths(i).Month, 28));
                eveInfo = new EveRandomMeetingInfo(new DateTime(DateTime.Now.Year, DateTime.Now.AddMonths(i).Month, 1), new DateTime(DateTime.Now.Year, DateTime.Now.AddMonths(i).Month, 28));

                for (int j = 0; j < 8; j++)
                {
                    MeetingAgenda mornmeetingInfo = morInfo.Next();
                    MeetingAgenda mornmeetingInfo1 = morInfo1.Next();
                    MeetingAgenda evemeetingInfo = eveInfo.Next();
                    List<AppointmentTimeRange> ranges = new List<AppointmentTimeRange>();
                    AppointmentTimeRange morningRange = new AppointmentTimeRange(mornmeetingInfo.MorningDescription, mornmeetingInfo.MorningTimeInformation, RandColor());
                    AppointmentTimeRange morningRange1 = new AppointmentTimeRange(mornmeetingInfo1.MorningDescription, mornmeetingInfo1.MorningTimeInformation, RandColor());
                    AppointmentTimeRange eveningRange = new AppointmentTimeRange(evemeetingInfo.EveningDescription, evemeetingInfo.EveningTimeInformation, RandColor());
                    ranges.Add(morningRange);
                    if (j % 17 == 0)
                    {
                        ranges.Add(morningRange1);
                        ranges.Add(eveningRange);
                    }
                    else if (j % 2 == 0)
                    {
                        ranges.Add(eveningRange);
                    }
                    Appointment apt = new Appointment(ranges, mornmeetingInfo.DateInfo);
                    this.Appointment.Add(apt);
                }
            }

            this.sfCalendar1.Style.Cell.CellFont = new Font("Segoe UI", this.sfCalendar1.Style.Cell.CellFont.Size + 2);
            this.sfCalendar1.Style.Cell.TrailingCellFont = new Font("Segoe UI", this.sfCalendar1.Style.Cell.CellFont.Size + 2);
            this.sfCalendar1.Style.Cell.SelectedCellFont = new Font("Segoe UI", this.sfCalendar1.Style.Cell.CellFont.Size + 2);
            this.sfCalendar1.SelectedDate = this.Appointment[0].Date;
        }

        public static Color ChangeColorBrightness(Color color, float correctionFactor)
        {
            float red = (float)color.R;
            float green = (float)color.G;
            float blue = (float)color.B;

            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (int)red, (int)green, (int)blue);
        }

        /// <summary>
        /// Event helps to customize the Cell.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SfCalendar1_DrawCell1(Syncfusion.WinForms.Input.SfCalendar sender, Syncfusion.WinForms.Input.Events.DrawCellEventArgs args)
        {
            if (!args.Value.HasValue)
            {
                return;
            }
            Image image = null;
            if (args.ViewType == Syncfusion.WinForms.Input.Enums.CalendarViewType.Year && args.Value.Value.Month == new DateTime(2018, 12, 25).Month && args.Value.Value.Year == new DateTime(2018, 12, 25).Year)
            {
                args.Handled = true;
                image = Properties.Resources.Icon_Christmas_day;
                args.Graphics.DrawImage(image, args.CellBounds);
            }

            if (args.ViewType == Syncfusion.WinForms.Input.Enums.CalendarViewType.Year && args.Value.Value.Month == new DateTime(2018, 02, 14).Month && args.Value.Value.Year == new DateTime(2018, 02, 14).Year)
            {
                args.Handled = true;
                image = Properties.Resources.Icon_Valentines_day;
                args.Graphics.DrawImage(image, args.CellBounds);
            }
            if (args.ViewType == Syncfusion.WinForms.Input.Enums.CalendarViewType.Year && args.Value.Value.Month == new DateTime(2018, 07, 1).Month && args.Value.Value.Year == new DateTime(2018, 07, 1).Year)
            {
                args.Handled = true;
                image = Properties.Resources.Icon_Doctor_s_Day;
                args.Graphics.DrawImage(image, args.CellBounds);
            }
            if (args.ViewType == Syncfusion.WinForms.Input.Enums.CalendarViewType.Year && args.Value.Value.Month == new DateTime(2018, 09, 25).Month && args.Value.Value.Year == new DateTime(2018, 09, 25).Year)
            {
                args.Handled = true;
                image = Properties.Resources.Icon_Engineers_day;
                args.Graphics.DrawImage(image, args.CellBounds);
            }
            if (args.ViewType == Syncfusion.WinForms.Input.Enums.CalendarViewType.Month)
            {

                args.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                int startPosition = 0;
                Appointment appointment = this.Appointment.Find(
                delegate (Appointment bk)
                {
                    return ((bk.Date.Day == args.Value.Value.Date.Day) && (bk.Date.Month == args.Value.Value.Date.Month) && (bk.Date.Year == args.Value.Value.Date.Year));
                }
                );
                if (appointment != null && (args.Value.Value.DayOfWeek != DayOfWeek.Sunday))
                {
                    args.Handled = true;
                    {
                        if (args.IsTrailingDate)
                        {
                            for (int j = 0; j < appointment.Appointments.Count; j++)
                            {
                                args.Graphics.FillRectangle(new SolidBrush(ControlPaint.LightLight(appointment.Appointments[j].AppointmentColor)), new Rectangle((args.CellBounds.X + (args.CellBounds.Width - args.CellBounds.Width / 2)) - (appointment.Appointments.Count * 2) - (appointment.Appointments.Count * 6) - startPosition, (args.CellBounds.Y + (args.CellBounds.Height - 20)), 12, 12));
                                startPosition -= 18;
                            }
                            TextRenderer.DrawText(args.Graphics, args.Value.Value.Day.ToString(), new Font("Segoe UI", this.sfCalendar1.Style.Cell.CellFont.Size), args.CellBounds, ControlPaint.LightLight(Color.IndianRed), TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
                        }
                        else
                        {
                            for (int j = 0; j < appointment.Appointments.Count; j++)
                            {
                                args.Graphics.FillRectangle(new SolidBrush(appointment.Appointments[j].AppointmentColor), new Rectangle((args.CellBounds.X + (args.CellBounds.Width - args.CellBounds.Width / 2)) - (appointment.Appointments.Count * 2) - (appointment.Appointments.Count * 6) - startPosition, (args.CellBounds.Y + (args.CellBounds.Height - 20)), 12, 12));
                                startPosition -= 18;
                            }
                            TextRenderer.DrawText(args.Graphics, args.Value.Value.Day.ToString(), new Font("Segoe UI", this.sfCalendar1.Style.Cell.CellFont.Size), args.CellBounds, Color.IndianRed, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
                        }
                    }
                }
                else
                {
                    args.Handled = true;
                    if (!args.IsTrailingDate)

                        TextRenderer.DrawText(args.Graphics, args.Value.Value.Day.ToString(), new Font("Segoe UI", this.sfCalendar1.Style.Cell.CellFont.Size), args.CellBounds, this.sfCalendar1.Style.Cell.CellForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
                    else
                        TextRenderer.DrawText(args.Graphics, args.Value.Value.Day.ToString(), new Font("Segoe UI", this.sfCalendar1.Style.Cell.CellFont.Size), args.CellBounds, ControlPaint.LightLight(this.sfCalendar1.Style.Cell.TrailingCellForeColor), TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
                }
            }
        }

        /// <summary>
        /// Occurs on Closing the Form
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosing(CancelEventArgs e)
        {
            this.Load -= new EventHandler(Form1_Load);
            this.sfCalendar1.SelectionChanged -= SfCalendar1_SelectionChanged;
            this.sfCalendar1.DrawCell -= new Syncfusion.WinForms.Input.Events.DrawCellEventHandler(SfCalendar1_DrawCell1);
            base.OnClosing(e);
        }

        private void SfCalendar1_SelectionChanged(Syncfusion.WinForms.Input.SfCalendar sender, Syncfusion.WinForms.Input.Events.SelectionChangedEventArgs args)
        {
            LockWindowUpdate(this.panel3.Handle);
            this.flowLayoutPanel1.Controls.Clear();
            if (this.sfCalendar1.SelectedDate == null)
            {
                return;
            }

            EventHeaderControl headerControl = new EventHeaderControl();
            headerControl.EventHeaderLabel.Text = "Appointments";
            this.flowLayoutPanel1.Controls.Add(headerControl);

            SelectedDateControl SelectedDateControl = new SelectedDateControl();
            SelectedDateControl.SelectedDateLabel.Text = this.sfCalendar1.SelectedDate.Value.ToString("dddd, dd MMMM yyyy");
            this.flowLayoutPanel1.Controls.Add(SelectedDateControl);

            Appointment appointment = this.Appointment.Find(
            delegate (Appointment bk)
            {
                 return ((bk.Date.Day == args.NewValue.Value.Date.Day) && (bk.Date.Month == args.NewValue.Value.Date.Month) && (bk.Date.Year == args.NewValue.Value.Date.Year));
            }
            );
            if (appointment != null)
            {
                for (int i = 0; i < appointment.Appointments.Count; i++)
                {
                    AppointmentControl appointmentControl = new AppointmentControl();
                    appointmentControl.DescriptionLbl.Text = appointment.Appointments[i].Description;
                    appointmentControl.TimeLbl.Text = appointment.Appointments[i].Time;
                    if (args.NewValue.Value.DayOfWeek != DayOfWeek.Sunday)
                        this.flowLayoutPanel1.Controls.Add(appointmentControl);
                }
            }

            if (this.flowLayoutPanel1.Controls.Count == 2 ||  args.NewValue.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                NoAppointmentControl appointmentControl = new NoAppointmentControl();
                appointmentControl.NoAppointmentLabel.Text = "No Appointments";
                this.flowLayoutPanel1.Controls.Add(appointmentControl);
            }
            LockWindowUpdate(IntPtr.Zero);
            this.flowLayoutPanel1.Refresh();
        }

        #endregion

    }
}
