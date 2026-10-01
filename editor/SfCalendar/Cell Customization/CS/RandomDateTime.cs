#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentDemo
{
    public class RandomMeetingInfo
    {
        DateTime start;
        Random gen;
        int dateRange;

        public RandomMeetingInfo(DateTime str, DateTime end)
        {
            gen = new Random();
            dateRange = (end - str).Days;
            start = str;
        }

        public MeetingAgenda Next()
        {
            DateTime date = start.AddDays(gen.Next(dateRange));
            MeetingAgenda meetingAgenda = new MeetingAgenda();
            meetingAgenda.DateInfo = date;
            string morningMeeting = MorningMeetingDescription[gen.Next(0, MorningMeetingDescription.Count - 1)].Description;
            string morningMeetingTimeInfo = MorningMeetingDescription[gen.Next(0, MorningMeetingDescription.Count - 1)].TimeInfo;
            string eveningMeeting = EveningMeetingDescription[gen.Next(0, EveningMeetingDescription.Count - 1)].Description;
            string eveningMeetingTimeInfo = EveningMeetingDescription[gen.Next(0, EveningMeetingDescription.Count - 1)].TimeInfo;
            return new MeetingAgenda(morningMeeting, eveningMeeting, morningMeetingTimeInfo, eveningMeetingTimeInfo, date);
        }

        private List<DisplayInfo> m_MorningMeetingDescription = new List<DisplayInfo>();

        public List<DisplayInfo> MorningMeetingDescription
        {
            get
            {
                if (m_MorningMeetingDescription.Count == 0)
                {
                    m_MorningMeetingDescription.Add(new DisplayInfo("DENMARK vs FRANCE", "10:30 AM - 1:30 PM"));
                    m_MorningMeetingDescription.Add(new DisplayInfo("AUSTRALIA vs PERU", "9:30 AM - 12:30 PM"));
                    m_MorningMeetingDescription.Add(new DisplayInfo("JAPAN vs POLAND", "10:30 AM - 3:30 PM"));
                    m_MorningMeetingDescription.Add(new DisplayInfo("SAUDI ARABIA vs EGYPT", "09:30 AM - 10:30 PM"));
                    m_MorningMeetingDescription.Add(new DisplayInfo("SENEGAL vs COLOMBIA", "9:45 PM - 9:30 PM"));
                    m_MorningMeetingDescription.Add(new DisplayInfo("URUGUAY vs RUSSIA", "10:30 PM - 12:30 PM"));

                    m_MorningMeetingDescription.Add(new DisplayInfo("EGYPT vs FRANCE", "11:30 AM - 1:30 PM"));
                    m_MorningMeetingDescription.Add(new DisplayInfo("URUGUAY vs COLOMBIA", "10:30 AM - 12:30 PM"));
                    m_MorningMeetingDescription.Add(new DisplayInfo("JAPAN vs POLAND", "11:30 AM - 12:30 PM"));
                    m_MorningMeetingDescription.Add(new DisplayInfo("SAUDI ARABIA vs POLAND", "10:30 AM - 11:30 PM"));
                    m_MorningMeetingDescription.Add(new DisplayInfo("AUSTRALIA vs COLOMBIA", "9:45 PM - 11:45 PM"));
                    m_MorningMeetingDescription.Add(new DisplayInfo("DENMARK vs RUSSIA", "10:30 PM - 12:30 PM"));
                }
                return m_MorningMeetingDescription;
            }
        }

        private List<DisplayInfo> m_EveningMeetingDescription = new List<DisplayInfo>();

        public List<DisplayInfo> EveningMeetingDescription
        {
            get
            {
                if (m_EveningMeetingDescription.Count == 0)
                {
                    m_EveningMeetingDescription.Add(new DisplayInfo("ENGLAND vs BELGIUM", "2:30 PM - 4:30 PM"));
                    m_EveningMeetingDescription.Add(new DisplayInfo("FRANCE vs PERU", "2:30 PM - 4:30 PM"));
                    m_EveningMeetingDescription.Add(new DisplayInfo("NIGERIA vs ARGENTINA", "3:30 PM - 5:30 PM"));
                    m_EveningMeetingDescription.Add(new DisplayInfo("ICELAND vs CROATIA", "3:30 PM - 5:30 PM"));
                    m_EveningMeetingDescription.Add(new DisplayInfo("ARGENTINA vs CROATIA", "3:30 PM - 5:30 PM"));
                    m_EveningMeetingDescription.Add(new DisplayInfo("PANAMA vs TUNISIA", "3:30 PM - 5:30 PM"));

                    m_EveningMeetingDescription.Add(new DisplayInfo("BELGIUM vs ENGLAND", "2:30 PM - 4:30 PM"));
                    m_EveningMeetingDescription.Add(new DisplayInfo("CROATIA vs PERU", "2:30 PM - 4:30 PM"));
                    m_EveningMeetingDescription.Add(new DisplayInfo("PERU vs ARGENTINA", "3:30 PM - 5:30 PM"));
                    m_EveningMeetingDescription.Add(new DisplayInfo("ICELAND vs ICELAND", "3:30 PM - 5:30 PM"));
                    m_EveningMeetingDescription.Add(new DisplayInfo("ARGENTINA vs CROATIA", "3:30 PM - 5:30 PM"));
                    m_EveningMeetingDescription.Add(new DisplayInfo("PANAMA vs TUNISIA", "3:30 PM - 5:30 PM"));
                }
                return m_EveningMeetingDescription;
            }
        }

    }

    public class EveRandomMeetingInfo
    {
        DateTime start;
        Random gen;
        int dateRange;

        public EveRandomMeetingInfo(DateTime str, DateTime end)
        {
            gen = new Random();
            dateRange = (end - str).Days;
            start = str;
        }

        public MeetingAgenda Next()
        {
            DateTime date = start.AddDays(gen.Next(dateRange));
            MeetingAgenda meetingAgenda = new MeetingAgenda();
            meetingAgenda.DateInfo = date;
            string eveningMeeting = EveningMeetingDescription[gen.Next(0, EveningMeetingDescription.Count - 1)].Description;
            string eveningMeetingTimeInfo = EveningMeetingDescription[gen.Next(0, EveningMeetingDescription.Count - 1)].TimeInfo;
            return new MeetingAgenda(eveningMeeting, eveningMeetingTimeInfo, date);
        }


        private List<DisplayInfo> m_EveningMeetingDescription = new List<DisplayInfo>();

        public List<DisplayInfo> EveningMeetingDescription
        {
            get
            {
                if (m_EveningMeetingDescription.Count == 0)
                {
                    m_EveningMeetingDescription.Add(new DisplayInfo("ENGLAND vs BELGIUM", "2:30 PM - 4:30 PM"));
                    m_EveningMeetingDescription.Add(new DisplayInfo("FRANCE vs PERU", "2:30 PM - 4:30 PM"));
                    m_EveningMeetingDescription.Add(new DisplayInfo("NIGERIA vs ARGENTINA", "3:30 PM - 5:30 PM"));
                    m_EveningMeetingDescription.Add(new DisplayInfo("ICELAND vs CROATIA", "3:30 PM - 5:30 PM"));
                    m_EveningMeetingDescription.Add(new DisplayInfo("ARGENTINA vs CROATIA", "3:30 PM - 5:30 PM"));
                    m_EveningMeetingDescription.Add(new DisplayInfo("PANAMA vs TUNISIA", "3:30 PM - 5:30 PM"));

                    m_EveningMeetingDescription.Add(new DisplayInfo("BELGIUM vs ENGLAND", "2:30 PM - 4:30 PM"));
                    m_EveningMeetingDescription.Add(new DisplayInfo("CROATIA vs PERU", "2:30 PM - 4:30 PM"));
                    m_EveningMeetingDescription.Add(new DisplayInfo("PERU vs ARGENTINA", "3:30 PM - 5:30 PM"));
                    m_EveningMeetingDescription.Add(new DisplayInfo("ICELAND vs ICELAND", "3:30 PM - 5:30 PM"));
                    m_EveningMeetingDescription.Add(new DisplayInfo("ARGENTINA vs CROATIA", "3:30 PM - 5:30 PM"));
                    m_EveningMeetingDescription.Add(new DisplayInfo("PANAMA vs TUNISIA", "3:30 PM - 5:30 PM"));
                }
                return m_EveningMeetingDescription;
            }
        }

    }

    public class DisplayInfo
    {
        public DisplayInfo(string descrip, string time)
        {
            Description = descrip;
            TimeInfo = time;
        }

        private string m_Description;

        public string Description
        {
            get { return m_Description; }
            set { m_Description = value; }
        }

        private string m_TimeInfo;

        public string TimeInfo
        {
            get { return m_TimeInfo; }
            set { m_TimeInfo = value; }
        }

    }

    public class MeetingAgenda
    {
        public MeetingAgenda()
        {

        }

        public MeetingAgenda(string eveDes, string eveTime, DateTime date)
        {
            EveningDescription = eveDes;
            EveningTimeInformation = eveTime;
            DateInfo = date;
        }


        public MeetingAgenda(string mornDes, string eveDes, string mornTime, string eveTime, DateTime date)
        {
            MorningDescription = mornDes;
            EveningDescription = eveDes;
            MorningTimeInformation = mornTime;
            EveningTimeInformation = eveTime;
            DateInfo = date;
        }

        private DateTime m_DateInfo;

        public DateTime DateInfo
        {
            get { return m_DateInfo; }
            set { m_DateInfo = value; }
        }


        private string m_MorningDescription = string.Empty;

        public string MorningDescription
        {
            get { return m_MorningDescription; }
            set { m_MorningDescription = value; }
        }

        private string m_EveningDescription = string.Empty;

        public string EveningDescription
        {
            get { return m_MorningDescription; }
            set { m_MorningDescription = value; }
        }

        private string m_MorningTime;

        public string MorningTimeInformation
        {
            get { return m_MorningTime; }
            set { m_MorningTime = value; }
        }

        private string m_EveningTime;

        public string EveningTimeInformation
        {
            get { return m_EveningTime; }
            set { m_EveningTime = value; }
        }

    }
    
}
