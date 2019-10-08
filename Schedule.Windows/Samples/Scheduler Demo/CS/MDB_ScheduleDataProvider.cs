#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Schedule;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using Syncfusion.Windows.Forms.Schedule;
using System.Windows.Forms;

namespace MDB_ScheduleSample_CS
{
    #region Schedule Item

    public class MDB_ScheduleItem : ScheduleAppointment
    {
        public static string Column_AllDay = "AllDay";
        public static string Column_Content = "Content";
        public static string Column_Dirty = "Dirty";
        public static string Column_EndTime = "EndTime";
        public static string Column_IgnoreChanges = "IgnoreChanges";
        public static string Column_LabelValue = "LabelValue";
        public static string Column_LocationValue = "LocationValue";
        public static string Column_MarkerValue = "MarkerValue";
        public static string Column_Owner = "Owner";
        public static string Column_Reminder = "Reminder";
        public static string Column_ReminderValue = "ReminderValue";
        public static string Column_StartTime = "StartTime";
        public static string Column_Subject = "Subject";
        public static string Column_UniqueID = "ID";
        public static string Column_RecurrenceRule = "RecurrenceRule";



        public MDB_ScheduleItem(DataRow dr)
        {
            this.dr = dr;
        }

        

        private DataRow dr;

        public DataRow Dr
        {
            get { return dr; }
        }

        public /*override*/ new bool AllDay
        {
            get
            {
                return (bool) dr[Column_AllDay];
            }
            set
            {
                dr[Column_AllDay] = value;
            }
        }
        public /*override*/ new string Content
        {
            get
            {
                return (string) dr[Column_Content];
            }
            set
            {
                dr[Column_Content] = value;
            }
        }

        internal bool dirtyFlagExplicitlySet = false;
        internal static MDB_ScheduleItem changedItem = null;
        public /*override*/ new bool Dirty
        {
            get
            {
                return dr.RowState != DataRowState.Unchanged;// dr[Column_Dirty];
            }
            set
            {
                dirtyFlagExplicitlySet = true;
                changedItem = this;
                int iii = this.LabelValue;
              //  dr[Column_Dirty] = value;

               
            }
        }


        public /*override*/ new DateTime EndTime
        {
            get
            {
                return (DateTime) dr[Column_EndTime];
            }
            set
            {
                dr[Column_EndTime] = value;
            }
        }
        public /*override*/new bool IgnoreChanges
        {
            get
            {
                return (bool)dr[Column_IgnoreChanges];
            }
            set
            {
                dr[Column_IgnoreChanges] = value;
            }
        }
        public /*override*/new int LabelValue
        {
            get
            {
                return (int)dr[Column_LabelValue];
            }
            set
            {
                dr[Column_LabelValue] = value;
            }
        }
        public /*override*/ new string LocationValue
        {
            get
            {
                return (string)dr[Column_LocationValue];
            }
            set
            {
                dr[Column_LocationValue] = value;
            }
        }

        private string FindLookupValue(LookUpObjectList list, int itemToFind)
        {
            string val = "";
            foreach (ListObject drv in list)
            {
                if (itemToFind.Equals(drv.ValueMember))
                {
                    val = drv.DisplayMember;
                    break;
                }
            }
            return val;
        }

        public /*override*/new int MarkerValue
        {
            get
            {
                return (int)dr[Column_MarkerValue];
            }
            set
            {
                dr[Column_MarkerValue] = value;
            }
        }
        public /*override*/ new int Owner
        {
            get
            {
                return (int)dr[Column_Owner];
            }
            set
            {
                dr[Column_Owner] = value;
            }
        }
        public /*override*/ new bool Reminder
        {
            get
            {
                return (bool)dr[Column_Reminder];
            }
            set
            {
                dr[Column_Reminder] = value;
            }
        }
        public /*override*/ new int ReminderValue
        {
            get
            {
                return (int)dr[Column_ReminderValue];
            }
            set
            {
                dr[Column_ReminderValue] = value;
            }
        }
        public /*override*/ new DateTime StartTime
        {
            get
            {
                return (DateTime)dr[Column_StartTime];
            }
            set
            {
                dr[Column_StartTime] = value;
            }
        }
        public /*override*/ new string Subject
        {
            get
            {
                if (dr[Column_Subject] == DBNull.Value)
                    return "";
                return (string)dr[Column_Subject];
            }
            set
            {
                dr[Column_Subject] = value;
            }
        }
        public /*override*/ new int UniqueID
        {
            get
            {
                return (int)dr[Column_UniqueID];
            }
            set
            {
                dr[Column_UniqueID] = value;
            }
        }

        #region IRecurringScheduleAppointment Members

        private RecurrenceList dateList;

         public RecurrenceList DateList
        {
            get
            {
                if (dateList == null &&
                    RecurrenceRule != null &&
                    RecurrenceRule.StartsWith(RecurrenceSupport.SpanMarker))
                {
                    InitSpanDateList();
                }
                return dateList;
            }
            set { dateList = value; }
        }


        //added to provide dynamic initialization for DateList in span rules.
        private void InitSpanDateList()
        {
            string[] parts = RecurrenceRule.Split(new char[] { RecurrenceSupport.RuleDelimiter });
            if (parts.GetLength(0) == 3)
            {
                dateList = new RecurrenceList();
                dateList.BaseDate = DateTime.Parse(parts[1], System.Globalization.CultureInfo.InstalledUICulture.DateTimeFormat);
                dateList.TerminalDate = DateTime.Parse(parts[2], System.Globalization.CultureInfo.InstalledUICulture.DateTimeFormat);
            }
        }



        
        public string RecurrenceRule
        {
            get
            {
                 
                    if (dr.Table == null)
                        return "";

                    if (dr.RowState == DataRowState.Deleted)
                        return "";

                    if (dr[Column_RecurrenceRule] == DBNull.Value)
                        return "";
                 
                return (string)dr[Column_RecurrenceRule];
            }
            set
            {
                dr[Column_RecurrenceRule] = value;
            }
        }

        private int recurrenceRuleID = 0;//int.MinValue;
        public int RecurrenceRuleID
        {
            get
            {
                //if (recurrenceRuleID == int.MinValue && RecurrenceRule.Length > 0)
                //    recurrenceRuleID = MDB_ScheduleDataProvider.ScheduleDataProvider.GetUniqueID();
                return recurrenceRuleID;
            }
            set
            {
                recurrenceRuleID = value;
            }
        }

        #endregion

        #region IScheduleAppointment Members - these members not used in the Windows Forms ScheduleControl


        public new bool AllowClickable
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public new bool AllowDrag
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public new bool AllowResize
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public new Color BackColor
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public new string CustomToolTip
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public new bool IsConflict(DateTime dtStart, DateTime dtEnd)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public new bool IsConflict(IScheduleAppointment item)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public new object Tag
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public new Color TimeSpanColor
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public new ScheduleAppointmentToolTip ToolTip
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public new int Version
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        #endregion

        #region IComparable Members

        public new int CompareTo(object obj)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion

        #region ICloneable Members

        
        private string lastRecurrenceRule = "";
        public new object Clone()
        {

            DataRow dr1 = this.Dr.Table.NewRow();
            dr1.ItemArray = this.Dr.ItemArray.Clone() as object[];
            if (dr1[MDB_ScheduleItem.Column_UniqueID] == null || dr1[MDB_ScheduleItem.Column_UniqueID] == DBNull.Value)
                dr1[MDB_ScheduleItem.Column_UniqueID] = MDB_ScheduleDataProvider.GetNextID();
            MDB_ScheduleItem item1 = new MDB_ScheduleItem(dr1);
            if (dr1[MDB_ScheduleItem.Column_RecurrenceRule].Equals(lastRecurrenceRule))
            {
                item1.recurrenceRuleID = this.recurrenceRuleID;
                item1.dirtyFlagExplicitlySet = this.dirtyFlagExplicitlySet;
                item1.UniqueID = MDB_ScheduleDataProvider.GetNextID();
            }
            lastRecurrenceRule = dr1[MDB_ScheduleItem.Column_RecurrenceRule].ToString();
            return item1;
        }

        #endregion
    }

    #endregion

    #region Schedule Item List

    public class MDB_ScheduleItemList : ArrayListAppointmentList
    {
        public MDB_ScheduleItemList(DataView dv)
        {
            SetDataView(dv);
        }

        protected void SetDataView(DataView dv)
        {
            foreach (DataRowView drv in dv)
            {
                this.Add(new MDB_ScheduleItem(drv.Row));
            }
        }


        public override void Remove(IScheduleAppointment item1)
        {
           base.Remove(item1);

                MDB_ScheduleItem item = item1 as MDB_ScheduleItem;
                if (item != null && item.RecurrenceRule.Length > 0)
                {
                    if (MDB_ScheduleDataProvider.itemsToDelete == null)
                    {
                        MDB_ScheduleDataProvider.itemsToDelete = new List<DataRow>();
                    }
                    foreach (DataRow dr in MDB_ScheduleDataProvider.scheduleDataSet.Tables[MDB_ScheduleDataProvider.Table_Appointments].Rows)
                    {
                        if(dr.RowState != DataRowState.Deleted
                            && dr.RowState != DataRowState.Detached
                            && item.RecurrenceRule.Equals(dr[MDB_ScheduleItem.Column_RecurrenceRule]))
                            MDB_ScheduleDataProvider.itemsToDelete.Add(dr);
                    }
                 }
          }
    }

    #endregion

    #region Schedule Provider

    public class MDB_ScheduleDataProvider : ArrayListDataProvider//ScheduleDataProvider, IRecurringScheduleDataProvider
    {
        public static string DataSet_Name = "Schedule";
        public static string Table_Appointments = "Appointments";
        public static string Table_Markers = "Markers";
        public static string Table_Labels = "Labels";
        public static string Table_Reminders = "Reminders";
        
      
        internal static DataSet scheduleDataSet = null;
        internal static List<DataRow> itemsToDelete;

        public static MDB_ScheduleDataProvider ScheduleDataProvider;
         
        public DataSet ScheduleDataSet
        {
            get { return scheduleDataSet; }
        }

        OleDbDataAdapter dataAdapter;
        OleDbConnection connection;
        public MDB_ScheduleDataProvider(string MDBpathName)
        {
            
            itemsToDelete = new List<DataRow>();
            
            MDB_ScheduleDataProvider.ScheduleDataProvider = this;

            MDB_ScheduleDataProvider.scheduleDataSet = new DataSet(DataSet_Name);

            string connString = @"Provider=Microsoft.JET.OLEDB.4.0;data source=" + MDBpathName;
           // string connString = @"Provider=Microsoft.JET.OLEDB.4.0;data source=" + GetPath(@"Data\nwind.mdb");
			
            connection = new OleDbConnection(connString);

            string sqlString = "SELECT * FROM " + Table_Markers;
            dataAdapter = new OleDbDataAdapter(sqlString, connection);
            dataAdapter.Fill(scheduleDataSet, Table_Markers);

            sqlString = "SELECT * FROM " + Table_Labels;
            dataAdapter = new OleDbDataAdapter(sqlString, connection);
            dataAdapter.Fill(scheduleDataSet, Table_Labels);

            sqlString = "SELECT * FROM " + Table_Reminders;
            dataAdapter = new OleDbDataAdapter(sqlString, connection);
            dataAdapter.Fill(scheduleDataSet, Table_Reminders);

           

            sqlString = "SELECT * FROM " + Table_Appointments;
            dataAdapter = new OleDbDataAdapter(sqlString, connection);
            dataAdapter.Fill(scheduleDataSet, Table_Appointments);

            nextID = int.MinValue;
          //  connection.Close();
        }

        

        static int nextID = int.MinValue;
        internal static int GetNextID()
        {
            if (nextID == int.MinValue)
            {
                int id = int.MinValue;
                foreach (DataRow dr in scheduleDataSet.Tables[Table_Appointments].Rows)
                {
                    if (dr[MDB_ScheduleItem.Column_UniqueID] != null &&
                        dr[MDB_ScheduleItem.Column_UniqueID] != DBNull.Value &&
                        (int)dr[MDB_ScheduleItem.Column_UniqueID] > id)
                    {
                        id = (int)dr[MDB_ScheduleItem.Column_UniqueID] + 1;
                    }
                }
                nextID = id;
            }
            return nextID++;
        }
        public override void AddItem(IScheduleAppointment item)
        {
            if (((MDB_ScheduleItem)item).Dr[MDB_ScheduleItem.Column_UniqueID] == DBNull.Value)
                ((MDB_ScheduleItem)item).Dr[MDB_ScheduleItem.Column_UniqueID] = GetNextID();
            scheduleDataSet.Tables[Table_Appointments].Rows.Add(((MDB_ScheduleItem) item).Dr);
        //    base.AddItem(item);
        }


        
        public override void CommitChanges()
        {

            foreach (DataRow dr in itemsToDelete)
            {
                dr.Delete();
            }
            itemsToDelete.Clear();

            #region Update Command

            this.dataAdapter.UpdateCommand = new OleDbCommand();
            this.dataAdapter.UpdateCommand.Connection = this.connection;
            this.dataAdapter.UpdateCommand.CommandText = string.Format(@"UPDATE `{0}` SET `{1}` = ?, `{2}` = ?, `{3}` = ?, `{4}` = ?, `{5}` = ?, `{6}` = ?, `{7}` = ?, `{8}` = ?, `{9}` = ?, `{10}` = ?, `{11}` = ?, `{13}` = ? WHERE ((`{12}` = ?) AND ((? = 1 AND `{1}` IS NULL) OR (`{1}` = ?)) AND ((? = 1 AND `{3}` IS NULL) OR (`{3}` = ?)) AND ((? = 1 AND `{4}` IS NULL) OR (`{4}` = ?)) AND ((? = 1 AND `{5}` IS NULL) OR (`{5}` = ?)) AND ((? = 1 AND `{6}` IS NULL) OR (`{6}` = ?)) AND ((? = 1 AND `{7}` IS NULL) OR (`{7}` = ?)) AND ((? = 1 AND `{8}` IS NULL) OR (`{8}` = ?)) AND ((? = 1 AND `{9}` IS NULL) OR (`{9}` = ?)) AND ((? = 1 AND `{10}` IS NULL) OR (`{10}` = ?)))",
                                                                    Table_Appointments, MDB_ScheduleItem.Column_AllDay, MDB_ScheduleItem.Column_Content, MDB_ScheduleItem.Column_EndTime,
                                                                    MDB_ScheduleItem.Column_LabelValue, MDB_ScheduleItem.Column_LocationValue, MDB_ScheduleItem.Column_MarkerValue,
                                                                    MDB_ScheduleItem.Column_Owner, MDB_ScheduleItem.Column_Reminder, MDB_ScheduleItem.Column_ReminderValue, MDB_ScheduleItem.Column_StartTime, MDB_ScheduleItem.Column_Subject, MDB_ScheduleItem.Column_UniqueID, MDB_ScheduleItem.Column_RecurrenceRule);
            this.dataAdapter.UpdateCommand.CommandType = CommandType.Text;
            this.dataAdapter.UpdateCommand.Parameters.Add(new OleDbParameter(MDB_ScheduleItem.Column_AllDay, OleDbType.Boolean, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_AllDay, DataRowVersion.Current, false, null));
            this.dataAdapter.UpdateCommand.Parameters.Add(new OleDbParameter(MDB_ScheduleItem.Column_Content, OleDbType.LongVarWChar, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_Content, DataRowVersion.Current, false, null));
            this.dataAdapter.UpdateCommand.Parameters.Add(new OleDbParameter(MDB_ScheduleItem.Column_EndTime, OleDbType.Date, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_EndTime, DataRowVersion.Current, false, null));
            this.dataAdapter.UpdateCommand.Parameters.Add(new OleDbParameter(MDB_ScheduleItem.Column_LabelValue, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_LabelValue, DataRowVersion.Current, false, null));
            this.dataAdapter.UpdateCommand.Parameters.Add(new OleDbParameter(MDB_ScheduleItem.Column_LocationValue, OleDbType.LongVarWChar, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_LocationValue, DataRowVersion.Current, false, null));
            this.dataAdapter.UpdateCommand.Parameters.Add(new OleDbParameter(MDB_ScheduleItem.Column_MarkerValue, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_MarkerValue, DataRowVersion.Current, false, null));
            this.dataAdapter.UpdateCommand.Parameters.Add(new OleDbParameter(MDB_ScheduleItem.Column_Owner, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_Owner, DataRowVersion.Current, false, null));
            this.dataAdapter.UpdateCommand.Parameters.Add(new OleDbParameter(MDB_ScheduleItem.Column_Reminder, OleDbType.Boolean, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_Reminder, DataRowVersion.Current, false, null));
            this.dataAdapter.UpdateCommand.Parameters.Add(new OleDbParameter(MDB_ScheduleItem.Column_ReminderValue, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_ReminderValue, DataRowVersion.Current, false, null));
            this.dataAdapter.UpdateCommand.Parameters.Add(new OleDbParameter(MDB_ScheduleItem.Column_StartTime, OleDbType.Date, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_StartTime, DataRowVersion.Current, false, null));
            this.dataAdapter.UpdateCommand.Parameters.Add(new OleDbParameter(MDB_ScheduleItem.Column_Subject, OleDbType.LongVarWChar, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_Subject, DataRowVersion.Current, false, null));
            this.dataAdapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_" + MDB_ScheduleItem.Column_UniqueID, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_UniqueID, DataRowVersion.Original, false, null));
            this.dataAdapter.UpdateCommand.Parameters.Add(new OleDbParameter(MDB_ScheduleItem.Column_RecurrenceRule, OleDbType.LongVarWChar, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_RecurrenceRule, DataRowVersion.Current, false, null));
            this.dataAdapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_" + MDB_ScheduleItem.Column_AllDay, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_AllDay, DataRowVersion.Original, true, null));
            this.dataAdapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_" + MDB_ScheduleItem.Column_AllDay, OleDbType.Boolean, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_AllDay, DataRowVersion.Original, false, null));
            this.dataAdapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_" + MDB_ScheduleItem.Column_EndTime, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_EndTime, DataRowVersion.Original, true, null));
            this.dataAdapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_" + MDB_ScheduleItem.Column_EndTime, OleDbType.Date, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_EndTime, DataRowVersion.Original, false, null));
            this.dataAdapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_" + MDB_ScheduleItem.Column_LabelValue, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_LabelValue, DataRowVersion.Original, true, null));
            this.dataAdapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_" + MDB_ScheduleItem.Column_LabelValue, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_LabelValue, DataRowVersion.Original, false, null));
            this.dataAdapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_" + MDB_ScheduleItem.Column_LocationValue, OleDbType.LongVarWChar, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_LocationValue, DataRowVersion.Original, true, null));
            this.dataAdapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_" + MDB_ScheduleItem.Column_LocationValue, OleDbType.LongVarWChar, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_LocationValue, DataRowVersion.Original, false, null));
            this.dataAdapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_" + MDB_ScheduleItem.Column_MarkerValue, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_MarkerValue, DataRowVersion.Original, true, null));
            this.dataAdapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_" + MDB_ScheduleItem.Column_MarkerValue, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_MarkerValue, DataRowVersion.Original, false, null));
            this.dataAdapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_" + MDB_ScheduleItem.Column_Owner, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_Owner, DataRowVersion.Original, true, null));
            this.dataAdapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_" + MDB_ScheduleItem.Column_Owner, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_Owner, DataRowVersion.Original, false, null));
            this.dataAdapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_" + MDB_ScheduleItem.Column_Reminder, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_Reminder, DataRowVersion.Original, true, null));
            this.dataAdapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_" + MDB_ScheduleItem.Column_Reminder, OleDbType.Boolean, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_Reminder, DataRowVersion.Original, false, null));
            this.dataAdapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_" + MDB_ScheduleItem.Column_ReminderValue, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_ReminderValue, DataRowVersion.Original, true, null));
            this.dataAdapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_" + MDB_ScheduleItem.Column_ReminderValue, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_ReminderValue, DataRowVersion.Original, false, null));
            this.dataAdapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_" + MDB_ScheduleItem.Column_StartTime, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_StartTime, DataRowVersion.Original, true, null));
            this.dataAdapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_" + MDB_ScheduleItem.Column_StartTime, OleDbType.Date, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_StartTime, DataRowVersion.Original, false, null));
            #endregion

            #region Insert Command

            this.dataAdapter.InsertCommand = new OleDbCommand();
            this.dataAdapter.InsertCommand.CommandText = string.Format("INSERT INTO `{0}`(`{1}`, `{2}`, `{3}`, `{4}`, `{5}`, `{6}`, `{7}`, `{8}`, `{9}`, `{10}`, `{11}`, `{12}`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)",
                                                         Table_Appointments, MDB_ScheduleItem.Column_AllDay, MDB_ScheduleItem.Column_Content, MDB_ScheduleItem.Column_EndTime,
                                                         MDB_ScheduleItem.Column_LabelValue, MDB_ScheduleItem.Column_LocationValue, MDB_ScheduleItem.Column_MarkerValue,
                                                         MDB_ScheduleItem.Column_Owner, MDB_ScheduleItem.Column_Reminder, MDB_ScheduleItem.Column_ReminderValue, MDB_ScheduleItem.Column_StartTime, MDB_ScheduleItem.Column_Subject, MDB_ScheduleItem.Column_RecurrenceRule);
            this.dataAdapter.InsertCommand.CommandType = CommandType.Text;
            this.dataAdapter.InsertCommand.Parameters.Add(new OleDbParameter(MDB_ScheduleItem.Column_AllDay, OleDbType.Boolean, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_AllDay, DataRowVersion.Current, false, null));
            this.dataAdapter.InsertCommand.Parameters.Add(new OleDbParameter(MDB_ScheduleItem.Column_Content, OleDbType.LongVarWChar, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_Content, DataRowVersion.Current, false, null));
            this.dataAdapter.InsertCommand.Parameters.Add(new OleDbParameter(MDB_ScheduleItem.Column_EndTime, OleDbType.Date, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_EndTime, DataRowVersion.Current, false, null));
            this.dataAdapter.InsertCommand.Parameters.Add(new OleDbParameter(MDB_ScheduleItem.Column_LabelValue, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_LabelValue, DataRowVersion.Current, false, null));
            this.dataAdapter.InsertCommand.Parameters.Add(new OleDbParameter(MDB_ScheduleItem.Column_LocationValue, OleDbType.LongVarWChar, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_LocationValue, DataRowVersion.Current, false, null));
            this.dataAdapter.InsertCommand.Parameters.Add(new OleDbParameter(MDB_ScheduleItem.Column_MarkerValue, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_MarkerValue, DataRowVersion.Current, false, null));
            this.dataAdapter.InsertCommand.Parameters.Add(new OleDbParameter(MDB_ScheduleItem.Column_Owner, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_Owner, DataRowVersion.Current, false, null));
            this.dataAdapter.InsertCommand.Parameters.Add(new OleDbParameter(MDB_ScheduleItem.Column_Reminder, OleDbType.Boolean, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_Reminder, DataRowVersion.Current, false, null));
            this.dataAdapter.InsertCommand.Parameters.Add(new OleDbParameter(MDB_ScheduleItem.Column_ReminderValue, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_ReminderValue, DataRowVersion.Current, false, null));
            this.dataAdapter.InsertCommand.Parameters.Add(new OleDbParameter(MDB_ScheduleItem.Column_StartTime, OleDbType.Date, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_StartTime, DataRowVersion.Current, false, null));
            this.dataAdapter.InsertCommand.Parameters.Add(new OleDbParameter(MDB_ScheduleItem.Column_Subject, OleDbType.LongVarWChar, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_Subject, DataRowVersion.Current, false, null));
            this.dataAdapter.InsertCommand.Parameters.Add(new OleDbParameter(MDB_ScheduleItem.Column_RecurrenceRule, OleDbType.LongVarWChar, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_RecurrenceRule, DataRowVersion.Current, false, null));
           			
            this.dataAdapter.InsertCommand.Connection = this.connection;

            #endregion

            #region Delete Command

            this.dataAdapter.DeleteCommand = new OleDbCommand();
            this.dataAdapter.DeleteCommand.Connection = this.connection;
            this.dataAdapter.DeleteCommand.CommandText = @"DELETE FROM `Appointments` WHERE ((`ID` = ?) AND ((? = 1 AND `AllDay` IS NULL) OR (`AllDay` = ?)) AND ((? = 1 AND `EndTime` IS NULL) OR (`EndTime` = ?)) AND ((? = 1 AND `LabelValue` IS NULL) OR (`LabelValue` = ?)) AND ((? = 1 AND `LocationValue` IS NULL) OR (`LocationValue` = ?)) AND ((? = 1 AND `MarkerValue` IS NULL) OR (`MarkerValue` = ?)) AND ((? = 1 AND `Owner` IS NULL) OR (`Owner` = ?)) AND ((? = 1 AND `Reminder` IS NULL) OR (`Reminder` = ?)) AND ((? = 1 AND `ReminderValue` IS NULL) OR (`ReminderValue` = ?)) AND ((? = 1 AND `StartTime` IS NULL) OR (`StartTime` = ?)))";
            this.dataAdapter.DeleteCommand.CommandType = CommandType.Text;
            this.dataAdapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_" + MDB_ScheduleItem.Column_UniqueID, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_UniqueID, DataRowVersion.Original, false, null));
            this.dataAdapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_" + MDB_ScheduleItem.Column_AllDay, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_AllDay, DataRowVersion.Original, true, null));
            this.dataAdapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_" + MDB_ScheduleItem.Column_AllDay, OleDbType.Boolean, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_AllDay, DataRowVersion.Original, false, null));
            this.dataAdapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_" + MDB_ScheduleItem.Column_EndTime, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_EndTime, DataRowVersion.Original, true, null));
            this.dataAdapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_" + MDB_ScheduleItem.Column_EndTime, OleDbType.Date, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_EndTime, DataRowVersion.Original, false, null));
            this.dataAdapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_" + MDB_ScheduleItem.Column_LabelValue, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_LabelValue, DataRowVersion.Original, true, null));
            this.dataAdapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_" + MDB_ScheduleItem.Column_LabelValue, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_LabelValue, DataRowVersion.Original, false, null));
            this.dataAdapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_" + MDB_ScheduleItem.Column_LocationValue, OleDbType.LongVarWChar, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_LocationValue, DataRowVersion.Original, true, null));
            this.dataAdapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_" + MDB_ScheduleItem.Column_LocationValue, OleDbType.LongVarWChar, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_LocationValue, DataRowVersion.Original, false, null));
            this.dataAdapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_" + MDB_ScheduleItem.Column_MarkerValue, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_MarkerValue, DataRowVersion.Original, true, null));
            this.dataAdapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_" + MDB_ScheduleItem.Column_MarkerValue, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_MarkerValue, DataRowVersion.Original, false, null));
            this.dataAdapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_" + MDB_ScheduleItem.Column_Owner, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_Owner, DataRowVersion.Original, true, null));
            this.dataAdapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_" + MDB_ScheduleItem.Column_Owner, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_Owner, DataRowVersion.Original, false, null));
            this.dataAdapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_" + MDB_ScheduleItem.Column_Reminder, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_Reminder, DataRowVersion.Original, true, null));
            this.dataAdapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_" + MDB_ScheduleItem.Column_Reminder, OleDbType.Boolean, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_Reminder, DataRowVersion.Original, false, null));
            this.dataAdapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_" + MDB_ScheduleItem.Column_ReminderValue, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_ReminderValue, DataRowVersion.Original, true, null));
            this.dataAdapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_" + MDB_ScheduleItem.Column_ReminderValue, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_ReminderValue, DataRowVersion.Original, false, null));
            this.dataAdapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_" + MDB_ScheduleItem.Column_StartTime, OleDbType.Integer, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_StartTime, DataRowVersion.Original, true, null));
            this.dataAdapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_" + MDB_ScheduleItem.Column_StartTime, OleDbType.Date, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), MDB_ScheduleItem.Column_StartTime, DataRowVersion.Original, false, null));

            #endregion

            this.dataAdapter.Update(scheduleDataSet, Table_Appointments);
            this.connection.Close();
          
        }

        private static LookUpObjectList labels;

        internal static LookUpObjectList Labels
        {
            get 
            {
                if (labels == null)
                {
                    labels = new LookUpObjectList(scheduleDataSet.Tables[Table_Labels].DefaultView);
                }
                return MDB_ScheduleDataProvider.labels; 
            }
            set { MDB_ScheduleDataProvider.labels = value; }
        }
        public override ILookUpObjectList GetLabels()
        {
            return Labels;
        }
       

        private static LookUpObjectList markers;

        internal static LookUpObjectList Markers
        {
            get
            {
                if (markers == null)
                {
                    markers = new LookUpObjectList(scheduleDataSet.Tables[Table_Markers].DefaultView);
                }
                return MDB_ScheduleDataProvider.markers;
            }
            set { MDB_ScheduleDataProvider.markers = value; }
        }
        public override ILookUpObjectList GetMarkers()
        {
            return Markers;
        }

        //not used in this sample...
        public override IScheduleResourceList GetOwners()
        {
            return base.GetOwners();
        }

        private static LookUpObjectList reminders;

        internal static LookUpObjectList Reminders
        {
            get
            {
                if (reminders == null)
                {
                    reminders = new LookUpObjectList(scheduleDataSet.Tables[Table_Reminders].DefaultView);
                }

                return reminders;
            }
            set { reminders = value; }
        }
        public override ILookUpObjectList GetReminders()
        {
            return Reminders;
        }

        //void display(DataView dv)
        //{
        //    foreach (DataRowView drv in dv)
        //    {
        //        if (drv[MDB_ScheduleItem.Column_RecurrenceRule].ToString().Length > 0)
        //        {
        //            Console.WriteLine("{0}  [{1}] {2}", drv[MDB_ScheduleItem.Column_UniqueID], drv[MDB_ScheduleItem.Column_RecurrenceRule], drv[MDB_ScheduleItem.Column_LabelValue]);
        //        }
        //    }
        //    Console.WriteLine("========");
        //}

        //void display(ArrayListAppointmentList dv)
        //{
        //    foreach (MDB_ScheduleItem drv in dv)
        //    {
        //        if (drv.RecurrenceRule.Length > 0)
        //        {
        //            Console.WriteLine("{0}  [{1}] {2}  {3}  {4}", drv.UniqueID, drv.RecurrenceRule, drv.RecurrenceRuleID, drv.LabelValue, drv.dirtyFlagExplicitlySet);
        //        }
        //    }
        //    Console.WriteLine("+++++========");
        //}

        DataView theDataView = null;
        public override IScheduleAppointmentList GetSchedule(DateTime startDate, DateTime endDate)
        {
            ProcessOldMasterListForUnSaveRecurrences();
            theDataView = new DataView(scheduleDataSet.Tables[Table_Appointments]);
            string filter = string.Format("[{0}] >= #{1}# AND [{2}] < #{3}#", MDB_ScheduleItem.Column_StartTime, startDate.Date,
               MDB_ScheduleItem.Column_EndTime, endDate.Date.AddDays(1));
            foreach (DataRow dr in itemsToDelete)
            {
                filter = string.Format("{0} AND [{1}]<>{2} ", filter, MDB_ScheduleItem.Column_UniqueID, dr[MDB_ScheduleItem.Column_UniqueID]);

            }
            theDataView.RowFilter = filter;
            //display(theDataView);
            
            //display(this.MasterList);
            this.MasterList = new MDB_ScheduleItemList(theDataView);
            
            EnforceUniqueIDs();
           // display(this.MasterList);
            this.MasterList.SortStartTime();
            return MasterList;
            //return base.GetSchedule(startDate, endDate);
        }

        
         

        private void ProcessOldMasterListForUnSaveRecurrences()
        {
            if (itemsToDelete.Count > 0)
            {
                  this.IsDirty = true;
               // MDB_ScheduleDataProvider.scheduleDataSet.Tables[MDB_ScheduleDataProvider.Table_Appointments].AcceptChanges();

            }
            GetUniqueIdsForRecurrences();

             foreach (MDB_ScheduleItem item in MasterList)
            {
                if (item.Dr.RowState == DataRowState.Detached)
                {
                    if (item.RecurrenceRule.Length > 0)
                    {
                        int loc = recurrences.BinarySearch(item.RecurrenceRule);
                        if (loc < 0)
                        {
                            scheduleDataSet.Tables[Table_Appointments].Rows.Add(item.Dr);
                        }
                        else
                        {
                            //need to replace
                            string filter = string.Format("[{0}] = #{1}# AND [{2}]='{3}'", MDB_ScheduleItem.Column_StartTime, item.StartTime, MDB_ScheduleItem.Column_RecurrenceRule, item.RecurrenceRule);
                            DataView dv = new DataView(scheduleDataSet.Tables[Table_Appointments], filter, "", DataViewRowState.CurrentRows);
                            if (dv.Count == 1)
                            {
                                 itemsToDelete.Add(dv[0].Row);
                                 scheduleDataSet.Tables[Table_Appointments].Rows.Add(item.Dr);
                             }
                        }
                    }
                }
                
                
            }
            
            MDB_ScheduleItem.changedItem = null;
            
        }

       
       

        List<string> recurrences = new List<string>();
        List<int> recurrenceIDs = new List<int>();
        private void GetUniqueIdsForRecurrences()
        {
            foreach (DataRow dr in scheduleDataSet.Tables[Table_Appointments].Rows)
            {
                if (dr.RowState != DataRowState.Deleted)
                {
                    string s = dr[MDB_ScheduleItem.Column_RecurrenceRule].ToString();
                    if (s.Length > 0)
                    {
                        int loc = recurrences.BinarySearch(s);
                        if (loc < 0)
                        {
                            recurrences.Insert(-loc - 1, s);
                            recurrenceIDs.Insert(-loc - 1, recurrences.Count);
                        }

                    }
                }
            }
        }
        private void EnforceUniqueIDs()
        {
            foreach (MDB_ScheduleItem item in MasterList)
            {
                if (item.RecurrenceRule.Length > 0)
                {
                    int loc = recurrences.BinarySearch(item.RecurrenceRule);
                    if (loc > -1)
                    {
                        item.RecurrenceRuleID = recurrenceIDs[loc];
                    }
                }
            }
        }
        public override IScheduleAppointmentList GetSchedule(DateTime startDate, DateTime endDate, int owner)
        {
            //owner not supported...
            //return base.GetSchedule(startDate, endDate, owner);
            return GetSchedule(startDate, endDate);
        }
        public override IScheduleAppointmentList GetScheduleForDay(DateTime day)
        {
            return GetSchedule(day, day); ;
        }
        public override IScheduleAppointmentList GetScheduleForDay(DateTime day, int owner)
        {
            //return base.GetScheduleForDay(day, owner);
            //owner not supported
            return GetScheduleForDay(day);
        }
        public override bool IsDirty
        {
            get
            {
                DataTable dt = scheduleDataSet.Tables[Table_Appointments].GetChanges();
                return base.IsDirty || (dt != null && dt.Rows.Count > 0);
            }
            set
            {
               base.IsDirty = value;
            }
        }
        public override IScheduleAppointment NewScheduleAppointment()
        {
            DataRow dr = scheduleDataSet.Tables[Table_Appointments].NewRow();

            PopulateDefaults(dr);
            return new MDB_ScheduleItem(dr); 
        }

        private void PopulateDefaults(DataRow dr)
        {
             dr[MDB_ScheduleItem.Column_AllDay] = false;
             dr[MDB_ScheduleItem.Column_Content] = "";
       // dr[MDB_ScheduleItem.Column_Dirty] = false;
        dr[MDB_ScheduleItem.Column_EndTime] = DateTime.Now;
       // dr[MDB_ScheduleItem.Column_IgnoreChanges] = false;
        dr[MDB_ScheduleItem.Column_LabelValue] = 0;
        dr[MDB_ScheduleItem.Column_LocationValue] = "";
        dr[MDB_ScheduleItem.Column_MarkerValue] = 0;
        dr[MDB_ScheduleItem.Column_Owner] = 0;
        dr[MDB_ScheduleItem.Column_Reminder] = false;
        dr[MDB_ScheduleItem.Column_ReminderValue] = 0;
        dr[MDB_ScheduleItem.Column_StartTime] = DateTime.Now;
        dr[MDB_ScheduleItem.Column_Subject] = "";
        dr[MDB_ScheduleItem.Column_RecurrenceRule] = "";
        //dr[MDB_ScheduleItem.Column_UniqueID] = "ID"; 
        }
        


        public override void RemoveItem(IScheduleAppointment item)
        {
            if (MDB_ScheduleDataProvider.itemsToDelete == null)
            {
                MDB_ScheduleDataProvider.itemsToDelete = new List<DataRow>();
            }
            MDB_ScheduleDataProvider.itemsToDelete.Add((item as MDB_ScheduleItem).Dr);
        }
        public override void SaveModifiedItem(IScheduleAppointment appModifiedItem, IScheduleAppointment appOriginalItem)
        {
          
            (appOriginalItem as MDB_ScheduleItem).Dr.ItemArray = (appModifiedItem as MDB_ScheduleItem).Dr.ItemArray.Clone() as object[];
        }

       
    }

    #endregion

    #region lookup lists

    public class LookUpObjectList : ListObjectList 
    {
        
        public LookUpObjectList(DataView dv)
        {
            foreach (DataRowView drv in dv)
            {
                this.Add(new LookUpObject(drv) as ILookUpObject);
            }
        }
    }

    public class LookUpObject : ListObject
    {
        public static string Column_ID = "ID";
        public static string Column_ColorRed = "ColorRed";
        public static string Column_ColorBlue = "ColorBlue";
        public static string Column_ColorGreen = "ColorGreen";
        public static string Column_Display = "Display";

        DataRowView drv;
        public LookUpObject(DataRowView drv)
            : base((int)drv[Column_ID], drv[Column_Display].ToString(), Color.FromArgb((int)drv[Column_ColorRed], (int)drv[Column_ColorBlue], (int)drv[Column_ColorGreen]))
        {
            this.drv = drv;
        }

        public override Color ColorMember
        {
            get
            {
                return Color.FromArgb((int)drv[Column_ColorRed], (int)drv[Column_ColorBlue], (int)drv[Column_ColorGreen]);
            }
            set
            {
                drv[Column_ColorRed] = value.R;
                drv[Column_ColorBlue] = value.B;
                drv[Column_ColorGreen] = value.G;
            }
        }

        public override string DisplayMember
        {
            get
            {
                return drv[Column_Display].ToString();
            }
            set
            {
                drv[Column_Display] = value;
            }
        }

        public override int ValueMember
        {
            get
            {
                return (int)drv[Column_ID];
            }
            set
            {
                drv[Column_ID] = value;
            }
        }
    }
    #endregion
}
