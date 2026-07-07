#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentDemo
{
    public class AppointmentTimeRange
    {
        public AppointmentTimeRange(string des, string tme, Color apt)
        {
            Description = des;
            Time = tme;
            AppointmentColor = apt;
        }

        private string m_Description;

        public string Description
        {
            get { return m_Description; }
            set { m_Description = value; }
        }

        private string m_Time;

        public string Time
        {
            get { return m_Time; }
            set { m_Time = value; }
        }

        private Color m_AppointmentColor;

        public Color AppointmentColor
        {
            get { return m_AppointmentColor; }
            set { m_AppointmentColor = value; }
        }
    }

    public class Appointment
    {
        public Appointment(List<AppointmentTimeRange> Ats, DateTime value)
        {
            Date = value;
            m_Appointments = Ats;
        }


        private DateTime m_Date;

        public DateTime Date
        {
            get { return m_Date; }
            set { m_Date = value; }
        }


        private List<AppointmentTimeRange> m_Appointments;

        public List<AppointmentTimeRange> Appointments
        {
            get { return m_Appointments; }
        }



    }

}
