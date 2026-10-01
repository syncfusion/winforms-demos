using System;
using System.Globalization;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using Syncfusion.Schedule;



namespace GridScheduleSample
{

    #region DataProvider
    /// <summary>
    /// Derives <see cref="ScheduleDataProvider"/> and implements <see cref="IRecurringScheduleDataProvider"/>.
    /// </summary>
    /// <remarks>
    /// This implementation of IRecurringScheduleDataProvider uses two collection of <see cref="SimpleRecurringScheduleAppointment"/>
    /// objects to hold the items displayed in the schedule. These collections is serialized to disk as a 
    /// binary file. The SimpleRecurringScheduleDataProvider.MasterList holds the appointment items that appear
    /// in the schedule. The SimpleRecurringScheduleDataProvider.RecurList holds any non-terminiating
    /// appoint definitions. 
    /// </remarks>
    public class SimpleScheduleDataProvider : ScheduleDataProvider, IRecurringScheduleDataProvider
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public SimpleScheduleDataProvider()
            : base()
        {
        }

        private string fileName;

        /// <summary>
        /// The file name used to store the serialized data.
        /// </summary>
        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

       private int nextUniqueID = -1;
        /// <summary>
        /// Tracks the largest ID value used so far in this ScheduleDataProvider.
        /// </summary>
        public int NextUniqueID
        {
            get
            {
                if (nextUniqueID == -1)
                {
                    nextUniqueID = 0;
                    foreach (IRecurringScheduleAppointment item in RecurringList)
                    {
                        if (nextUniqueID < item.RecurrenceRuleID)
                        {
                            nextUniqueID = item.RecurrenceRuleID;
                        }
                    }
                }
                if (nextUniqueID == int.MaxValue)
                    throw new ArgumentOutOfRangeException("NextUniqueID", "must not exceed int.MaxValue");
                return ++nextUniqueID;
            }
        }

        private RecurrenceSupport recurSupport = null;

        internal RecurrenceSupport RecurSupport
        {
            get 
            {
                if (recurSupport == null)
                    recurSupport = new RecurrenceSupport();

                return recurSupport; 
            }
            set { recurSupport = value; }
        }


       // private SimpleRecurringScheduleAppointmentList masterList;
        private SimpleScheduleAppointmentList masterList;

        /// <summary>
        /// Get or sets an IScheduleAppointmentList collection that holds the IRecurringScheduleAppointments. 
        /// </summary>
       // public SimpleRecurringScheduleAppointmentList MasterList
        public SimpleScheduleAppointmentList MasterList
        {
            get { return masterList; }
            set { masterList = value; }
        }

        #region random data

        /// <summary>
        /// A static method that provides random data, not really a part of the implementations.
        /// </summary>
        /// <returns>A SimpleScheduleAppointmentList object holding sample data.</returns>
        //public static SimpleRecurringScheduleAppointmentList InitializeRandomData()
        public static SimpleScheduleAppointmentList InitializeRandomData()
        {
            //int tc = Environment.TickCount;
            //int tc = 26260100;// simple spread 
            int tc = 28882701; // split the appointment across midnight & 3 items at 8am on 2 days ago

            //Console.WriteLine("Random seed: {0}", tc);
            Random r = new Random(tc);
            Random r1 = new Random(tc);

            // set the number of sample items you want in this list.
            //int count = r.Next(20) + 4;
            int count = 400;//1000;//200;//30;

           // SimpleRecurringScheduleAppointmentList masterList = new SimpleRecurringScheduleAppointmentList();
            SimpleScheduleAppointmentList masterList = new SimpleScheduleAppointmentList();
            DateTime now = DateTime.Now.Date;

            for (int i = 0; i < count; ++i)
            {
                ScheduleAppointment item = masterList.NewScheduleAppointment() as ScheduleAppointment;

                //int dayOffSet = 0;
                //int hourOffSet = 8 - r.Next(16);

                //int dayOffSet = 3 - r.Next(6);
                int dayOffSet = 30 - r.Next(60);
                //int dayOffSet = 100 - r.Next(200);
                int hourOffSet = 24 - r.Next(48);

                int len = 30 * (r.Next(4) + 1);
                item.StartTime = now.AddDays((double)dayOffSet).AddHours((double)hourOffSet); ;
                item.EndTime = item.StartTime.AddMinutes((double)len);
                item.Subject = string.Format("subject{0}", i);
                item.Content = string.Format("content{0}", i);
                item.LabelValue = r1.Next(10) < 3 ? 0 : r1.Next(10);
                item.LocationValue = string.Format("location{0}", r1.Next(5));

                item.ReminderValue = r1.Next(10) < 5 ? 0 : r1.Next(12);
                item.Reminder = r1.Next(10) > 1;
                item.AllDay = r1.Next(10) < 1;


                item.MarkerValue = r1.Next(4);
                item.Dirty = false;
                masterList.Add(item);
            }

            ////set explicit values if needed for testing...
            //masterList[142].Reminder = true;
            //masterList[142].ReminderValue = 9;//  hrs; // 7;//3 hrs


            //DisplayList("Before Sort", masterList);
            masterList.SortStartTime();
            //DisplayList("After Sort", masterList);

            return masterList;
        }

        private static void DisplayList(string title, ScheduleAppointmentList list)
        {
#if console
			Console.WriteLine("*************" + title);
			foreach(ScheduleAppointment item in list)
			{
				Console.WriteLine(item);
			}
#endif
        }
        #endregion

        #region base class overrides

        /// <summary>
        /// Returns a the subset of MasterList between the 2 dates.
        /// </summary>
        /// <param name="startDate">Starting date limit for the returned items.</param>
        /// <param name="endDate">Ending date limit for the returned items.</param>
        /// <returns>Returns a the subset of MasterList.</returns>
        public override IScheduleAppointmentList GetSchedule(DateTime startDate, DateTime endDate)
        {
            ScheduleAppointmentList list = new ScheduleAppointmentList();
            DateTime start = startDate.Date;
            DateTime end = endDate.Date;
            CheckAndAddIfNeededRecurringAppointments(endDate);
            foreach (ScheduleAppointment item in this.MasterList)
            {
                //item.EndTime.AddMinutes(-1) is to make sure an item that ends at 
                //midnight is not shown on the next days calendar

                if ((item.StartTime.Date >= start && item.StartTime.Date <= end)
                    || (item.EndTime.AddMinutes(-1).Date > start && item.EndTime.Date <= end))
                {
                    list.Add(item);
                }
            }
            list.SortStartTime();
            //DisplayList(string.Format("************dates between {0} and {1}", startDate, endDate), list);
            return list;
        }

        /// <summary>
        /// Returns a the subset of MasterList for a given date.
        /// </summary>
        /// <param name="day">Date for the returned items.</param>
        /// <returns>Returns a the subset of MasterList.</returns>
        public override IScheduleAppointmentList GetScheduleForDay(DateTime day)
        {
            ScheduleAppointmentList list = new ScheduleAppointmentList();
            day = day.Date;
            bool sort = CheckAndAddIfNeededRecurringAppointments(day);
            foreach (ScheduleAppointment item in this.MasterList)
            {
                //do not want anything that ends at 12AM on the day
                if (item.StartTime.Date == day || (item.EndTime.Date == day && item.EndTime > day))
                {
                    list.Add(item);
                }
            }
            if(sort)
            {
                list.SortStartTime();
            }
            //DisplayList(string.Format("*************day {0}", day), list);
            return list;
        }

        /// <summary>
        /// Saves the MasterList as a diskfile.
        /// </summary>
        public override void CommitChanges()
        {
            SaveBinary(FileName);
            this.IsDirty = false;
        }

        /// <summary>
        /// Gets or sets whether the MasterList has been modified.
        /// </summary>
        public override bool IsDirty
        {
            get
            {
                bool val = base.IsDirty;
                if (!val) //if no global setting marked list as dirty, check individual items
                {
                    foreach (IScheduleAppointment item in this.MasterList)
                    {
                        if (item.Dirty)
                        {
                            val = true;
                            break;
                        }
                    }
                }
                return val;
            }
            set
            {
                base.IsDirty = value;
            }
        }


        /// <summary>
        /// Saves the current <see cref="MasterList"/> object in binary format to a file 
        /// with the specified filename.
        /// </summary>
        public void SaveBinary(string fileName)
        {
            Stream s = File.Create(fileName);
            SaveBinary(s);
            s.Close();
        }

        /// <summary>
        /// Saves the current <see cref="MasterList"/> object to a stream in binary format.
        /// </summary>
        public void SaveBinary(Stream s)
        {
            ArrayList list = new ArrayList();
            foreach (IRecurringScheduleAppointment item in this.RecurringList)
            {
                if (item.DateList.TerminalDate < DateTime.MaxValue)
                    list.Add(item);
            }
            foreach (IRecurringScheduleAppointment item in list)
                this.RecurringList.Remove(item);

            BinaryFormatter b = new BinaryFormatter();
            b.AssemblyFormat = FormatterAssemblyStyle.Simple;
            b.Serialize(s, this.MasterList);
             b.Serialize(s, this.RecurringList);
             b.Serialize(s, this.nextUniqueID);
          //  b.Serialize(s, this.StartLimitDate);
          //  b.Serialize(s, this.EndLimitDate);
        }


        /// <summary>
        /// Creates an instance of <see cref="SimpleScheduleDataProvider"/> and loads 
        /// a previously serialized MasterList into the instance.
        /// </summary>
        /// <param name="fileName">The serialized filename.</param>
        /// <returns>A SimpleScheduleDataProvider.</returns>
        /// <remarks>
        /// This method uses <see cref="AppDomain.CurrentDomain.AssemblyResolve"/> to 
        /// avoid versioning issues with the binary serialization of the MasterList.
        /// </remarks>
        public static SimpleScheduleDataProvider LoadBinary(string fileName)
        {
            SimpleScheduleDataProvider t = new SimpleScheduleDataProvider();
            Stream s = File.OpenRead(fileName);
            try
            {
                AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(Syncfusion.ScheduleWindowsAssembly.AssemblyResolver);
                BinaryFormatter b = new BinaryFormatter();
                b.AssemblyFormat = FormatterAssemblyStyle.Simple;
                object obj = b.Deserialize(s);
                //t.MasterList = obj as SimpleRecurringScheduleAppointmentList;
                t.MasterList = obj as SimpleScheduleAppointmentList;
                obj = b.Deserialize(s);
                //t.recurringList = obj as SimpleRecurringScheduleAppointmentList;
                t.recurringList = obj as SimpleScheduleAppointmentList;
                t.nextUniqueID = (int) b.Deserialize(s);
               }
            finally
            {
                s.Close();
                AppDomain.CurrentDomain.AssemblyResolve -= new ResolveEventHandler(Syncfusion.ScheduleWindowsAssembly.AssemblyResolver);
            }
            return t;
        }

        /// <summary>
        /// Overridden to return a <see cref="SimpleScheduleAppointment"/>.
        /// </summary>
        /// <returns></returns>
        public override IScheduleAppointment NewScheduleAppointment()
        {
            return new SimpleRecurringScheduleAppointment();
        }

        /// <summary>
        /// Overridden to add the item to the MasterList.
        /// </summary>
        /// <param name="item">IScheduleAppointment item to be added.</param>
        public override void AddItem(IScheduleAppointment item)
        {
            //Dynamically grow the tracked date range for recurring appointments
            //if (item.EndTime.Date > this.EndLimitDate)
            //    this.EndLimitDate = item.EndTime.Date;
            //if (item.StartTime.Date < this.StartLimitDate)
            //    this.StartLimitDate = item.StartTime.Date;

            this.MasterList.Add(item);
        }

        /// <summary>
        /// Overridden to remove the item from the MasterList.
        /// </summary>
        /// <param name="item">IScheduleAppointment item to be removed.</param>
        public override void RemoveItem(IScheduleAppointment item)
        {
            this.MasterList.Remove(item);
        }

        ///// <summary>
        ///// Returns true to indicate recurring events are supported.
        ///// </summary>
        //public override bool SupportsRecurrences
        //{
        //    get
        //    {
        //        return true;
        //    }
        //}
        #endregion

        #region IRecurringScheduleDataProvider Members

        //SimpleRecurringScheduleAppointmentList recurringList = null;
        SimpleScheduleAppointmentList recurringList = null;
        /// <summary>
        /// Gets a SimpleRecurringScheduleAppointmentList collection that holds ScheduleRecurringAppointments.
        /// </summary>
        public IScheduleAppointmentList RecurringList
        {
            get
            {
                if (recurringList == null)
                    //recurringList = new SimpleRecurringScheduleAppointmentList();
                    recurringList = new SimpleScheduleAppointmentList();
                return recurringList;
            }
        }

        /// <summary>
        /// Adds recurring appointments.
        /// </summary>
        /// <param name="item">The recurring appointment definition.</param>
        /// <param name="dateLimit">A date limit at which the recurring appointments end.</param>
        /// <remarks> The date limit may be dateTime.MaxValue which indicates no limit.</remarks>
        public void AddNewRecurringAppointments(IRecurringScheduleAppointment item, DateTime dateLimit)
        {
            string[] rulesArray = item.RecurrenceRule.Split(new char[] { RecurrenceSupport.RuleDelimiter });
            DateTime baseDate = DateTime.Parse(rulesArray[0]);
            DateTime date = rulesArray[1].Length > 0 ? DateTime.Parse(rulesArray[1]) : dateLimit;
       
            if (item.DateList == null)
            { //if null, then need to create it.
                CreateDateListFromItem(item);
                //conditionally set terminal date if present in rule.
                if (rulesArray[1].Length > 0)
                    item.DateList.TerminalDate = date;
            }
            item.DateList.IsValidRecurrence(date); //this populates DateList up through date
            bool needToSort = false;
            foreach (DateTime dt in item.DateList)
            {   //now go through and add appointments that match the datelist entries
                if (dt >= item.DateList.BaseDate && dt <= item.DateList.TerminalDate)
                {
                    AddAppointmentFromItem(item, dt);
                    needToSort = true;
                }
            }
            if (needToSort)
            {
                ResetBaseDate(item);
                MasterList.SortStartTime();
            }
        }

        #region private helper methods
        private void CreateDateListFromItem(IRecurringScheduleAppointment item)
        {
            string[] rulesArray = item.RecurrenceRule.Split(new char[] { RecurrenceSupport.RuleDelimiter });
            DateTime baseDate = DateTime.Parse(rulesArray[0]);
            item.DateList = new RecurrenceList(rulesArray[2], baseDate, null);
        }

        private void AddAppointmentFromItem(IRecurringScheduleAppointment item, DateTime dt)
        {
            IRecurringScheduleAppointment item1 = item.Clone() as IRecurringScheduleAppointment;
            item1.StartTime = new DateTime(dt.Year, dt.Month, dt.Day, item.StartTime.Hour, item.StartTime.Minute, 0);
            item1.EndTime = new DateTime(dt.Year, dt.Month, dt.Day, item.EndTime.Hour, item.EndTime.Minute, 0);
            this.MasterList.Add(item1);             
        }

        private void ResetBaseDate(IRecurringScheduleAppointment item)
        {
            item.DateList.BaseDate = item.DateList[item.DateList.Count - 1];//.AddDays(1);
            if (item.DateList.BaseDate > item.DateList.TerminalDate)
                item.DateList.BaseDate = item.DateList.TerminalDate;
            int i = item.RecurrenceRule.IndexOf(RecurrenceSupport.RuleDelimiter);
            if (i > -1)
            {
                item.RecurrenceRule = string.Format("{0}{1}", item.DateList.BaseDate.ToShortDateString(), item.RecurrenceRule.Substring(i));
            }
        }

        private IScheduleAppointment SetExceptDates(IScheduleAppointment targetItem, IScheduleAppointment sourceItem)
        {
            DateTime start = targetItem.StartTime;
            DateTime end = targetItem.EndTime;
            targetItem = sourceItem.Clone() as IRecurringScheduleAppointment;
            targetItem.StartTime = start;
            targetItem.EndTime = end;
            return targetItem;

        }
        #endregion

        /// <summary>
        /// Used after the inital load to add additional recurring appointments to the dataprovider.
        /// </summary>
        /// <param name="date">The recurring appointment definition.</param>
        /// <returns>True if dates were added.</returns>
        /// <remarks>Dynamically provide appointments on demand as new dates are exposed.</remarks>
        public bool CheckAndAddIfNeededRecurringAppointments(DateTime date)
        {
            bool ret = false;
            foreach (IRecurringScheduleAppointment item in RecurringList)
            {
                if (item.DateList == null && item.RecurrenceRule != null && item.RecurrenceRule.Length > 0)
                {   //create initial DateList and add any appointments
                    CreateDateListFromItem(item);
                    AddNewRecurringAppointments(item, item.DateList.BaseDate);
                }
                RecurrenceList list = item.DateList;
                if (list != null)
                {
                    //now loop thru and add appointments if needed
                    DateTime date1 = date.CompareTo(list.TerminalDate) > 0 ? list.TerminalDate : date;
                    if (date1.CompareTo(list[list.Count - 1]) > 0)
                    {
                        //need to add
                        int start = list.Count;
                        list.IsValidRecurrence(date1);
                        bool needToSort = false;
                        while (start < list.Count)
                        {
                            date1 = list[start];
                            if (date1 >= item.DateList.BaseDate && date1 <= item.DateList.TerminalDate)
                            {
                                AddAppointmentFromItem(item, date1);
                                needToSort = true;
                            }
                            start++;
                        }
                        if (needToSort)
                        {
                            ResetBaseDate(item);
                            MasterList.SortStartTime();
                            ret = true;
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>
        /// Removes all occurrences the given appointment.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool RemoveRecurringAppointments(IRecurringScheduleAppointment recurItem)
        {
            bool deleted = false;
            ArrayList list = new ArrayList();
            foreach (IRecurringScheduleAppointment item in this.MasterList)
            {
                if (item.RecurrenceRuleID == recurItem.RecurrenceRuleID)
                    list.Add(item);
            }

            foreach (IRecurringScheduleAppointment item in list)
            {
                this.MasterList.Remove(item);
                deleted = true;
            }
            IRecurringScheduleAppointment found = null;

            foreach (IRecurringScheduleAppointment item in this.RecurringList)
            {
                if (item.RecurrenceRuleID == recurItem.RecurrenceRuleID)
                {
                    found = item;
                    deleted = true;
                    break;
                }
            }

            if (found != null)
                RecurringList.Remove(found);

            return deleted;
        }

        /// <summary>
        /// Makes changes to appointments in a recurring sequence of appointments.
        /// </summary>
        /// <param name="item">The edit appointment.</param>
        /// <param name="action">The requested edit action.</param>
        public void SaveModifiedRecurringAppointment(IRecurringScheduleAppointment modifiedItem, IRecurringScheduleAppointment originalItem, RecurringAppointmentEditAction action)
        {
            switch (action)
            {
                case RecurringAppointmentEditAction.ChangeAllAppointments:
                    for(int i = 0; i < this.MasterList.Count; ++i)
                    {
                       IRecurringScheduleAppointment item = this.MasterList[i] as IRecurringScheduleAppointment;
                       if (item.RecurrenceRuleID == originalItem.RecurrenceRuleID)
                       {
                          this.MasterList[i] = SetExceptDates(this.MasterList[i], modifiedItem);
                          // this.MasterList[i] = modifiedItem;
                       }
                       
                    }
                    for (int i = 0; i < this.RecurringList.Count; ++i)
                    {
                        IRecurringScheduleAppointment item = this.MasterList[i] as IRecurringScheduleAppointment;

                        if (item.RecurrenceRuleID == originalItem.RecurrenceRuleID
                             && this.RecurringList[i].StartTime >= originalItem.StartTime)
                        {
                            this.RecurringList[i] = SetExceptDates(this.RecurringList[i], modifiedItem);
                            // this.RecurringList[i] = modifiedItem;
                        }
                    }
                    break;
                case RecurringAppointmentEditAction.ChangeAllFutureAppointments:

                    for (int i = 0; i < this.MasterList.Count; ++i)
                    {
                        IRecurringScheduleAppointment item = this.MasterList[i] as IRecurringScheduleAppointment;

                        if (item.RecurrenceRuleID == originalItem.RecurrenceRuleID
                            && this.MasterList[i].StartTime >= originalItem.StartTime)
                        {
                           // this.MasterList[i] = modifiedItem;
                            this.MasterList[i] = SetExceptDates(this.MasterList[i], modifiedItem);
                        }
                    }

                    for (int i = 0; i < this.RecurringList.Count; ++i)
                    {
                        IRecurringScheduleAppointment item = this.MasterList[i] as IRecurringScheduleAppointment;

                        if (item.RecurrenceRuleID == originalItem.RecurrenceRuleID
                             && this.RecurringList[i].StartTime >= originalItem.StartTime)
                        {
                            this.RecurringList[i] = SetExceptDates(this.RecurringList[i], modifiedItem);
                           // this.RecurringList[i] = modifiedItem;
                        }
                    }
                    
                    break;
                case RecurringAppointmentEditAction.ChangeSingleAppointmentOnly:
                    for (int i = 0; i < this.MasterList.Count; ++i)
                    {
                        if (this.MasterList[i].Equals(originalItem))
                        {
                            this.MasterList[i] = modifiedItem;
                            break;
                        }
                    }
                    break;
                case  RecurringAppointmentEditAction.Cancel:
                    //no action....
                    break;
                default:
                    break;
                    
            }
        }


        /// <summary>
        /// Returns a unique integer that serves to identify a recurring family of appointments.
        /// </summary>
        /// <returns>A unique integer.</returns>
        public int GetUniqueID()
        {
            return NextUniqueID;
        }
        #endregion
    }
    #endregion

    #region ScheduleRecurringAppointment

    /// <summary>
    /// Derives <see cref="SimpleScheduleAppointment"/> to add a recurrence definition string.
    /// </summary>
    [Serializable]
    public class SimpleRecurringScheduleAppointment : SimpleScheduleAppointment, ISerializable, IRecurringScheduleAppointment
    {
        #region ISerializable Members

        /// <summary>
        /// Default constructor.
        /// </summary>
        public SimpleRecurringScheduleAppointment()
            : base()
        {
        }

        /// <summary>
        /// Overridden to handle serilaization.
        /// </summary>
        /// <param name="info">The SerialazationInfo.</param>
        /// <param name="context">The StreamingContext.</param>
        protected SimpleRecurringScheduleAppointment(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            ////this.UniqueID = (int)info.GetValue("UniqueID", typeof(int));
            ////this.Subject = (string)info.GetValue("Subject", typeof(string));
            ////this.StartTime = (DateTime)info.GetValue("StartTime", typeof(DateTime));
            ////this.ReminderValue = (int)info.GetValue("ReminderValue", typeof(int));
            ////this.Reminder = (bool)info.GetValue("Reminder", typeof(bool));
            ////this.Owner = (int)info.GetValue("Owner", typeof(int));
            ////this.MarkerValue = (int)info.GetValue("MarkerValue", typeof(int));
            ////this.LocationValue = (string)info.GetValue("LocationValue", typeof(string));
            ////this.LabelValue = (int)info.GetValue("LabelValue", typeof(int));
            ////this.EndTime = (DateTime)info.GetValue("EndTime", typeof(DateTime));
            ////this.Content = (string)info.GetValue("Content", typeof(string));
            ////this.AllDay = (bool)info.GetValue("AllDay", typeof(bool));
            this.recurrenceRule = (string)info.GetValue("RecurrenceRule", typeof(string));
            this.recurrenceRuleID = (int)info.GetValue("RecurrenceRuleID", typeof(int));
          //  this.dateList = (RecurrenceList)info.GetValue("DateList", typeof(RecurrenceList));

            //trigger setting DateList
      //      this.RecurrenceRule = this.recurrenceRule;

            this.Dirty = false;
        }

        /// <summary>
        /// Handle serilaization.
        /// </summary>
        /// <param name="info">The SerializationInfo.</param>
        /// <param name="context">The StreamingContext.</param>
        public new void GetObjectData(SerializationInfo info, StreamingContext context)
             
        {
            base.GetObjectData(info, context);
            //info.AddValue("UniqueID", this.UniqueID);
            //info.AddValue("Subject", this.Subject);
            //info.AddValue("StartTime", this.StartTime);
            //info.AddValue("ReminderValue", this.ReminderValue);
            //info.AddValue("Reminder", this.Reminder);
            //info.AddValue("Owner", this.Owner);
            //info.AddValue("MarkerValue", this.MarkerValue);
            //info.AddValue("LocationValue", this.LocationValue);
            //info.AddValue("LabelValue", this.LabelValue);
            //info.AddValue("EndTime", this.EndTime);
            //info.AddValue("Content", this.Content);
            //info.AddValue("AllDay", this.AllDay);
            info.AddValue("RecurrenceRule", this.recurrenceRule);
            info.AddValue("RecurrenceRuleID", this.recurrenceRuleID);
     //       info.AddValue("DateList", this.dateList);

        }

        #endregion

        //public override bool Equals(object obj)
        //{
        //    if (obj == null)
        //        return false;
        //    else
        //       return this.RecurrenceRuleID == ((SimpleRecurringScheduleAppointment)obj).RecurrenceRuleID;
        //}

        #region IRecurringScheduleAppointment Members

        ///// <summary>
        ///// Gets whether this appointment is a recurring appointment.
        ///// </summary>
        //public bool IsRecurring
        //{
        //    get
        //    {
        //        return RecurrenceRule != null && RecurrenceRule.Length > 0;
        //    }
        //    set
        //    {
        //        //no setter
        //    }
        //}

        private string recurrenceRule = "";
        /// <summary>
        /// Gets or sets the string that defines this recurrence.
        /// </summary>
        public string RecurrenceRule
        {
            get
            {
                return recurrenceRule;
            }
            set
            {
                recurrenceRule = value;

                //string[] rulesArray = recurrenceRule.Split(new char[] { RecurrenceSupport.RuleDelimiter });
                //if (rulesArray.GetLength(0) == 3)
                //{
                //    DateTime baseDate = DateTime.Parse(rulesArray[0]);
                //    DateTime date = rulesArray[1].Length > 0 ? DateTime.Parse(rulesArray[1]) : baseDate;
                //    dateList = new RecurrenceList(rulesArray[2], baseDate, null);
                //    dateList.IsValidRecurrence(date); //add a single date...
                //    dateList.RuleString = recurrenceRule;
                //    dateList.TerminalDate = rulesArray[1].Length > 0 ? date : DateTime.MaxValue;
                //}
                //else if (recurrenceRule.Length == 0)
                //{
                //    dateList = new RecurrenceList();
                //}
                //else
                //{
                //    throw new Exception("Invalue recurrence definition.");
                //}
            }
        }
        [NonSerialized]
        private RecurrenceList dateList;
        
        public RecurrenceList DateList
        {
            get { return dateList;  }
            set { dateList = value; }
        }

        int recurrenceRuleID = 0;

        /// <summary>
        /// Unique identifier assigned to this recurrence appointment.
        /// </summary>
        /// <remarks>This value is zero for all non-recurring appointments. For a recurring appointment, 
        /// this value is the same for all appointments in the same recurrence definition.</remarks>
        public int RecurrenceRuleID 
        { 
            get { return recurrenceRuleID;}
            set { recurrenceRuleID = value; }
        }

        #endregion
    }
    #endregion

    #region ScheduleAppointmentList

    /// <summary>
    /// Derives <see cref="ScheduleAppointmentList"/> to implement IScheduleAppointmentList.
    /// </summary>
    [Serializable]
    public class SimpleScheduleAppointmentList : ScheduleAppointmentList, ISerializable
    {
        #region ISerializable Members

        #region ISerializable Members

        /// <summary>
        /// Used in serialization.
        /// </summary>
        /// <param name="info"> The SerializationInfo.</param>
        /// <param name="context">The StreamingContext.</param>
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            GetObjectData(info, context);
        }

        #endregion


        /// <summary>
        /// Override to control serialization.
        /// </summary>
        /// <param name="info"> The SerializationInfo.</param>
        /// <param name="context">The StreamingContext.</param>
        protected virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("List", this.List);
        }


        #endregion

        /// <summary>
        /// Used in serialization.
        /// </summary>
        /// <param name="info"> The SerializationInfo.</param>
        /// <param name="context">The StreamingContext.</param>
        protected SimpleScheduleAppointmentList(SerializationInfo info, StreamingContext context)
        {
            this.List = (ArrayList)info.GetValue("List", typeof(ArrayList));
        }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public SimpleScheduleAppointmentList()
            : base()
        {

        }

        /// <summary>
        /// Overridden to return a <see cref="SimpleScheduleAppointment"/>.
        /// </summary>
        /// <returns>A SimpleScheduleAppointment.</returns>
        public override IScheduleAppointment NewScheduleAppointment()
        {
            return new SimpleScheduleAppointment();
        }


    }
    #endregion

    #region ScheduleAppointment

    /// <summary>
    /// Derives <see cref="ScheduleAppointment"/> to implement IScheduleAppointment.
    /// </summary>
    [Serializable]
    public class SimpleScheduleAppointment : ScheduleAppointment, ISerializable
    {
        #region ISerializable Members

        /// <summary>
        /// Default constructor.
        /// </summary>
        public SimpleScheduleAppointment()
            : base()
        {
        }

        /// <summary>
        /// Overridden to handle serilaization.
        /// </summary>
        /// <param name="info">The SerialazationInfo.</param>
        /// <param name="context">The StreamingContext.</param>
        protected SimpleScheduleAppointment(SerializationInfo info, StreamingContext context)
        {
            this.UniqueID = (int)info.GetValue("UniqueID", typeof(int));
            this.Subject = (string)info.GetValue("Subject", typeof(string));
            this.StartTime = (DateTime)info.GetValue("StartTime", typeof(DateTime));
            this.ReminderValue = (int)info.GetValue("ReminderValue", typeof(int));
            this.Reminder = (bool)info.GetValue("Reminder", typeof(bool));
            this.Owner = (int)info.GetValue("Owner", typeof(int));
            this.MarkerValue = (int)info.GetValue("MarkerValue", typeof(int));
            this.LocationValue = (string)info.GetValue("LocationValue", typeof(string));
            this.LabelValue = (int)info.GetValue("LabelValue", typeof(int));
            this.EndTime = (DateTime)info.GetValue("EndTime", typeof(DateTime));
            this.Content = (string)info.GetValue("Content", typeof(string));
            this.AllDay = (bool)info.GetValue("AllDay", typeof(bool));
   //         this.RecurrenceRule = (string)info.GetValue("RecurrenceRule", typeof(string));

            this.Dirty = false;
        }

        /// <summary>
        /// Handle serilaization.
        /// </summary>
        /// <param name="info">The SerialazationInfo.</param>
        /// <param name="context">The StreamingContext.</param>
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("UniqueID", this.UniqueID);
            info.AddValue("Subject", this.Subject);
            info.AddValue("StartTime", this.StartTime);
            info.AddValue("ReminderValue", this.ReminderValue);
            info.AddValue("Reminder", this.Reminder);
            info.AddValue("Owner", this.Owner);
            info.AddValue("MarkerValue", this.MarkerValue);
            info.AddValue("LocationValue", this.LocationValue);
            info.AddValue("LabelValue", this.LabelValue);
            info.AddValue("EndTime", this.EndTime);
            info.AddValue("Content", this.Content);
            info.AddValue("AllDay", this.AllDay);
      //      info.AddValue("RecurrenceRule", this.RecurrenceRule);

            //info.AddValue("Tag", this.Tag); assume Tag not serializable in this implemetation
        }

        #endregion

        //#region IRecurringScheduleAppointment Members

        //private string recurrenceRule = "";
        //public string RecurrenceRule
        //{
        //    get
        //    {
        //        return recurrenceRule;
        //    }
        //    set
        //    {
        //        recurrenceRule = value;
        //    }
        //}

        //#endregion
    }
    #endregion

}


