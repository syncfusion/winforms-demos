#region Copyright Syncfusion Inc. 2001 - 2007
//
//  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Xml;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;
using System.Data.OleDb;
using System.IO;
using Syncfusion.Collections;
using Syncfusion.Drawing;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;

namespace OutlookDemo
{
    # region delegates
    // A delegate type for hooking up change notifications.
    public delegate void ChangedEventHandler(object sender, EventArgs e);
    # endregion

    # region enums
    public enum days
    {
        Today = 1,
        Yesterday = 2,
        Thursday = 3,
        Wednesday = 4,
        Tuesday = 5,
        Monday = 6,
        Sunday = 7,
        LastWeek = 8,
        TwoWeeksAgo = 9,
        ThreeWeeksAgo = 10,
        LastMonth = 11,
        Older = 12
    }

    public enum flags
    {
        Clear = 0,
        Red = 1,
        Blue = 2,
        Yellow = 3,
        Green = 4,
        Orange = 5,
        Purple = 6,
        Complete = 7,
        HighPriority = 8,
        LowPriority = 9,
        ShowClip = 11
    }

    public enum categories
    {
        Red = 0, Blue = 1, Green = 2, Orange = 3, Purple = 4, Yellow = 5
    }

    public enum mail { Unread = 0, Read = 1 }
    internal enum headerImage { Priority = 10, Attachment = 11, Mail = 12, ReadState = 13, Flag = 0, Up = 15, Down = 16 }

    # endregion

    # region Class
    /// <summary>
    /// Summary description for GroupingPanel.
    /// </summary>
    public class GroupingPanel : System.Windows.Forms.Panel
    {

        # region Declarations

        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
        private Syncfusion.Grouping.GroupingConfig groupingConfig1;
        private System.ComponentModel.IContainer components;
        private ColumnSetViewHeader CSVHeader;
        private Image i1 = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "flag_clear.png"));
        private Image i2 = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "today.png"));
        private Image i3 = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "tomorrow.png"));
        private Image i4 = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "thisweek.png"));
        private Image i5 = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "thisweek.png"));
        private Image i6 = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "today.png"));
        private Image i7 = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "today.png"));
        private Image i8 = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "alert.png"));
        private Image i9 = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "priority.png"));
        private Image i10 = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "LowPriority.png"));
        private Image i11 = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "priority_black.png"));
        private Image i12 = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "clip_32.png")); //attach_icon.ico
        private Image i13 = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "mailHeader.ico"));
        private Image i14 = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "readStateHeader.ico"));
        private Image i15 = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "plus.png"));
        private Image i16 = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "minus.png"));
        private Image i17 = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "flag_complete.png"));

        private Image m1 = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "Mail_S.ico"));
        private Image m2 = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "mail_open.png"));
        private Image m3 = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "reply.png"));
        private Image m4 = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "forward.png"));
        private Image m5 = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "replyall.png"));

        private Image u1 = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "TBPrint_S.ico"));
        private Image u2 = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "TBDelete_S.ico"));
        private Image u3 = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "TBMoveToFolder_S.ico"));
        private Image u4 = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "TBCreateRule_S.ico"));

        private Image h1 = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "sortasc.bmp"));
        private Image h2 = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "sortdesc.bmp"));
        private Image h3 = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "grp.bmp"));
        private Image h4 = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "groupByBox.png"));
        private Image h5 = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "fldChooser.png"));

        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem_ArrangeBy;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem_Date;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem_From;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem_Subject;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem_Size;
        private Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu normalViewPopUpMenu;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem_To;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem_SortAscending;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem_sortDescending;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem_GroupByThisField;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem_GroupByBox;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem_RemoveThisColumn;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem_FieldChooser;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem_BestFit;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem_FormatColumns;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem_CustomizeCurrentView;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem_Conversation;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem_Folder;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem_Type;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem_Flag;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem_Attachments;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem_EmailAccounts;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem_Importance;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem_Categories;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem_Custom;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem_ShowInGroups;
        private Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu flagPopupMenu;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem todayBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem tomoBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem thisweekFlagBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem nextweekFlagBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem nodateFlagBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem customFlagBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem addReminderBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem markcompleteFlagBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem redAsDefaultBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem blueAsDefaultBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem yellowAsDefaultBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem greenAsDefaultBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem orangeAsDefaultBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem purpleAsDefaultBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem setquickclickBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem flagMenusParentBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem clearflagParentBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu CaptionPopupMenu;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItemForCaption;
        public Syncfusion.Windows.Forms.Tools.XPMenus.BarItem collapseAllGroupsBarItem;
        public Syncfusion.Windows.Forms.Tools.XPMenus.BarItem ExpandAllGroupsBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem OpenItemsBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem PrintfromCaptionBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem ForwardfromCaptionBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem categoriesBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem MarkAsReadfromCaptionBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem MarkAsUnreadfromCaptionBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem DeletefromCaptionBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem MovetoFolderfromCaptionBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem FollowUpParentBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem todayCaptionBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem nextweekCaptionBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem tomoCaptionBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem thisweekfromCaptionBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem nodateCaptionBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem customCaptionBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem addreminderCaptionBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem markcompletefromCaptionBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu RecordPopupMenu;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem RecordsParentBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem OpenfromRecordBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem PrintfromRecordBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem ReplyfromRecordBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem ReplyToAllfromRecordBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem ForwardfromRecordBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem RecordFollowUpParentBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem todayRecordBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem tomoRecordBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem thisweekRecordBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem nextweekRecordBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem nodateRecordBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem customRecordBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem addreminderRecordBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem ClearFlagfromRecordBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem BlueasDefaultfromRecordBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem YellowasDefaultfromRecordBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem GreenasDefaultfromRecordBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem OrangeasDefaultfromRecordBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem PurpleasDefaultfromRecordBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem RedAsDefaultfromRecordBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem MarkfromRecordBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem CategoriesfromRecordBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem CreateRulefromRecordBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem FindAllfromRecordparentBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem MessagesfromsenderBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem RelatedMessagesBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem JunkEmailsfromRecordParentBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem AddSendertoBlockedSendersListBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem AddSendertoSafeSendersListBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem AddSendersDomaintoSafeSendersListBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem AddRecipienttoSafeRecipientsListBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem MarkasNotJunkBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem JunkEmailOptionsBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem DeletefromRecordBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem MoveToFolderfromRecordBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem OptionsfromRecordBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem markcompleteRecordItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem headerParentBarItem;
        private System.Windows.Forms.ImageList iList;
        private Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu headerPopUpMenu;
        private ImageList mailList;
        private ImageList UtilIconList;
        private ImageList fList, hmenuList;
        private BarItem clearflagCaptionBarItem;
        private BarItem setBarItem;
        private BarItem setRecordBarItem1;
        private PopupMenu categoryPopUpMenu;
        private ParentBarItem categoryParentBarItem;
        private BarItem clearallcategBarItem;
        private BarItem categsearchBarItem;
        private BarItem redcategBarItem;
        private BarItem blueBarItem;
        private BarItem greenBarItem;
        private BarItem orangeBarItem;
        private BarItem purpleBarItem;
        private BarItem yellowBarItem;
        private BarItem allcategBarItem;
        private BarItem setcategBarItem;
        private ImageList imageList1;
        string[] visibleCols;

        # endregion

        # region events

        public event ChangedEventHandler Changed;
        public event ChangedEventHandler ShowViewChanged;

        // Invoke the Changed event, called whenever the NormalView property changes
        protected virtual void OnChanged(EventArgs e)
        {
            if (Changed != null)
                Changed(this, e);
        }

        # endregion

        # region Properties
        public bool PreviewSelected;
        private bool normalView;
        /// <summary>
        /// Indicates the Normal view..
        /// </summary>
        public bool NormalView
        {
            get { return normalView; }
            set
            {
                if (normalView != value)
                    OnChanged(EventArgs.Empty);
                normalView = value;
            }
        }
        private string groupedBy = "";
        private string columnAtBottom;
        /// <summary>
        /// To know the column which is at the bottom 
        /// useful for column set view
        /// </summary>
        public string ColumnAtBottom
        {
            get { return columnAtBottom; }
        }
        private string columnAtTop;
        /// <summary>
        /// To know the column which is at the top/first 
        /// useful for column set view
        /// </summary>
        public string ColumnAtTop
        {
            get { return columnAtTop; }
        }
        // to check and allow to set for the available columns
        private int numberOfLayers = 2;
        /// <summary>
        /// Number of Layers/MultiLine required 
        /// Minimum 2 lines and the update is fetched from the field chooser..
        /// </summary>
        public int NumberOfLayers
        {
            get { return numberOfLayers; }
            set { numberOfLayers = value; }
        }
        private string groupColumn;
        /// <summary>
        /// The column that is to be grouped in the normal view
        /// </summary>
        public string GroupColumn
        {
            get { return groupColumn; }
            set { groupColumn = value; }
        }
        private int secondColumnSetSize;
        public int SecondColumnSetSize
        {
            get
            {
                return secondColumnSetSize;
            }
        }
        private string secondRowColumn;
        public string SecondRowColumn
        {
            get { return secondRowColumn; }
            set { secondRowColumn = value; }
        }

        public GridGroupingControl Grid
        {
            get { return this.gridGroupingControl1; }
        }
        private flags defaultFlag = flags.Red;
        public flags DefaultFlag
        {
            get { return defaultFlag; }
            set { defaultFlag = value; }
        }

        public Color HeaderForeColor
        {
            get
            {
                switch (this.gridGroupingControl1.TableOptions.GridVisualStyles)
                {
                    case GridVisualStyles.Office2007Black:
                        return Color.FromArgb(248, 248, 248); 
                    case GridVisualStyles.Office2007Silver:
                        return Color.FromArgb(241, 243, 243); 
                    default:
                        return Color.FromArgb(249, 252, 255); 
                }
            }
        }

        public Color HeaderBackColor
        {
            get
            {
                switch (this.gridGroupingControl1.TableOptions.GridVisualStyles)
                {
                    case GridVisualStyles.Office2007Black:
                        return Color.FromArgb(223, 223, 223); 
                    case GridVisualStyles.Office2007Silver:
                        return Color.FromArgb(200, 201, 202); 
                    default:
                        return Color.FromArgb(197, 222, 255); 
                }
            }
        }

        public Color SortIconColor
        {
            get
            {
                switch (this.gridGroupingControl1.TableOptions.GridVisualStyles)
                {
                    case GridVisualStyles.Office2007Black:
                        return Color.FromArgb(145, 153, 164); 
                    case GridVisualStyles.Office2007Silver:
                        return Color.FromArgb(110, 109, 143); 
                    default:
                        return Color.FromArgb(154, 198, 255); 
                }
            }
        }

        # endregion

        # region dataTable
        private DataTable GetTable()
        {
            DataTable dt = new DataTable();

            //	DataColumn dcDate = new DataColumn("Date");
            DataColumn dcAttachment = new DataColumn("Attachment");
            DataColumn dcFrom = new DataColumn("From");
            DataColumn dcSubject = new DataColumn("Subject");
            DataColumn dcReceived = new DataColumn("Received", typeof(DateTime));

            DataColumn dcMails = new DataColumn("mails", typeof(int));
            DataColumn dcReadState = new DataColumn("ReadState", typeof(int));
            DataColumn dcTo = new DataColumn("To");
            DataColumn dcContent = new DataColumn("Content");
            //DataColumn dcflag = new DataColumn("flag", typeof(int));
            DataColumn dcSize = new DataColumn("Size", typeof(double));
            DataColumn dcPriority = new DataColumn("Priority");
            DataColumn dcCategory = new DataColumn("Category", typeof(string));
            DataColumn dcFlag = new DataColumn("flag", typeof(int));

            dt.Columns.Add(dcAttachment);
            //dt.Columns.Add(dcDate);
            dt.Columns.Add(dcFrom);
            dt.Columns.Add(dcSubject);
            dt.Columns.Add(dcReceived);
            //
            dt.Columns.Add(dcMails);
            dt.Columns.Add(dcReadState);
            dt.Columns.Add(dcTo);
            dt.Columns.Add(dcContent);
            //dt.Columns.Add(dcflag);
            dt.Columns.Add(dcSize);
            dt.Columns.Add(dcPriority);
            dt.Columns.Add(dcCategory);
            dt.Columns.Add(dcFlag);

            dt.Rows.Add(new object[] { string.Empty, "Tindale", "Eval version Key", DateTime.Now, 0, 0, "Jake", "Please provide me the key to the new version", 5010, string.Empty, "Red Category", (int)flags.Red });
            dt.Rows.Add(new object[] { string.Empty, "Tony", "Re: Tool Missing ", DateTime.Now.AddMinutes(-2), 0, 0, "Jake", "Thanks Jake, Now it works", 29300, string.Empty, null, (int)flags.Clear });
            dt.Rows.Add(new object[] { string.Empty, "Brown", "Essential Grid ", DateTime.Now.AddHours(-1), 0, 0, "Jake", "Will you help me in purchasing Essential Grid", 5010, string.Empty, "Purple Category", (int)flags.Yellow });
            dt.Rows.Add(new object[] { string.Empty, "Sam", "Re:Latest Version", DateTime.Now.AddHours(-3), 0, 0, "Jake", "You can download the latest version now", 293000, 1, null, (int)flags.Clear });
            dt.Rows.Add(new object[] { string.Empty, "Ted", "UserAccount", DateTime.Now.AddHours(-3), 0, 0, "Jake", "User accounts have been created", 55000, 1, null, (int)flags.Clear });
            dt.Rows.Add(new object[] { string.Empty, "George", "Re: Solution", DateTime.Now.AddDays(-1), 0, 0, "Jake", "Thanks! This sorted the problem", 1025, string.Empty, null, (int)flags.Clear });
            dt.Rows.Add(new object[] { 1, "Paul", "New Image", DateTime.Now.AddDays(-10), 0, 0, "Jake", "Please have a look at this", 3453454, string.Empty, null, (int)flags.Clear });
            dt.Rows.Add(new object[] { 1, "Donald", "Re: icons", DateTime.Now.AddDays(-12), 2, 1, "Jake", "Please modify them", 3434100, string.Empty, null, (int)flags.Clear });
            dt.Rows.Add(new object[] { string.Empty, "Jerry", "Re: ", DateTime.Now.AddDays(-21), 2, 1, "Jake", "The feature is added now. It is ready for testing", 2033, -1, null, (int)flags.Clear });
            dt.Rows.Add(new object[] { string.Empty, "George", "Installaion Procedure", DateTime.Now.AddDays(-42), 2, 1, "Jake", "It is uploaded in server. Please go through this", 20400, string.Empty, null, (int)flags.Clear });
            dt.Rows.Add(new object[] { 1, "Paul", "Report Format", DateTime.Now.AddDays(-50), 3, 1, "Jake", "Please have a look at this", 3453440, 1, null, (int)flags.Clear });
            dt.Rows.Add(new object[] { string.Empty, "Donald", "Code Optimizer tool", DateTime.Now.AddDays(-63), 2, 1, "Jake", "Where can I found the complete documentation", 34341, string.Empty, null, (int)flags.Clear });
            dt.Rows.Add(new object[] { string.Empty, "Bob", "FeatureList", DateTime.Now.AddDays(-75), 2, 1, "Jake", "Could you please send me the list of new features ", 5010, string.Empty, null, (int)flags.Clear });
            dt.Rows.Add(new object[] { 1, "Sam", "Re: redraw issue", DateTime.Now.AddDays(-98), 1, 1, "Jake", "It is fixed", 293000, 1, null, (int)flags.Clear });
            dt.Rows.Add(new object[] { string.Empty, "Ted", "Re: Helper tool", DateTime.Now.AddDays(-100), 2, 1, "Jake", "This works great!!", 55000, 1, null, (int)flags.Clear });
            dt.Rows.Add(new object[] { string.Empty, "Babu", "Re:Defects", DateTime.Now.AddDays(-101), 1, 1, "Jake", "All Defects have been fixed.", 5010, string.Empty, null, (int)flags.Clear });
            dt.Rows.Add(new object[] { 1, "Domnique", "Code file missing", DateTime.Now.AddDays(-113), 2, 1, "Jake", "Could you please resend it again", 293000, -1, null, (int)flags.Clear });
            dt.Rows.Add(new object[] { string.Empty, "Haddok", "Re: resize problem", DateTime.Now.AddDays(-120), 2, 1, "Jake", "Thanks for your solution", 55000, 1, null, (int)flags.Clear });
            dt.Rows.Add(new object[] { string.Empty, "George", "Re: ReleaseDates", DateTime.Now.AddDays(-128), 3, 1, "Jake", "It will be announced tommorrow", 1025, string.Empty, null, (int)flags.Clear });
            dt.Rows.Add(new object[] { 1, "Paul", "Icons", DateTime.Now.AddDays(-199), 2, 1, "Jake", "Here is a list of icons", 3453454, string.Empty, null, (int)flags.Clear });
            dt.Rows.Add(new object[] { 1, "Donald", "Re: FeatureList", DateTime.Now.AddDays(-200), 1, 1, "Jake", "Please find the attachment for details", 3434100, string.Empty, null, (int)flags.Clear });
            dt.Rows.Add(new object[] { string.Empty, "Jerry", "Re:Latest Version", DateTime.Now.AddDays(-208), 2, 1, "Jake", "You can download the latest version now", 2033, -1, null, (int)flags.Clear });
            dt.Rows.Add(new object[] { string.Empty, "George", "Re: scrolling issue", DateTime.Now.AddDays(-259), 2, 1, "Jake", "It is fixed", 20400, string.Empty, null, (int)flags.Clear });
            dt.Rows.Add(new object[] { 1, "Paul", "New sample", DateTime.Now.AddDays(-270), 1, 1, "Jake", "Please test this", 3454540, 1, null, (int)flags.Clear });
            dt.Rows.Add(new object[] { string.Empty, "Don", "Re: Evaluation Keys", DateTime.Now.AddDays(-295), 2, 1, "Jake", "Hello, Finally decided purchasing Essential Grid.", 34341, string.Empty, null, (int)flags.Clear });
            dt.Rows.Add(new object[] { string.Empty, "George", "New website ", DateTime.Now.AddDays(-300), 1, 1, "Jake", "Please send me the link", 20400, string.Empty, null, (int)flags.Clear });
            dt.Rows.Add(new object[] { string.Empty, "Paul", "Refresh issues", DateTime.Now.AddDays(-350), 1, 1, "Jake", "Please check them", 3453540, 1, null, (int)flags.Clear });
            dt.Rows.Add(new object[] { 1, "Don", "Re: UI design", DateTime.Now.AddDays(-351), 2, 1, "Jake", "Thanks for your pointers! we came up with solution", 34341, string.Empty, "Green Category", (int)flags.Green });
            dt.Rows.Add(new object[] { string.Empty, "Neal Culiner", "Kudos Folks!!!", DateTime.Now.AddDays(-355), 2, 1, "Jake", "All I can say is WOW! Beautiful works!", 1025, string.Empty, "Purple Category", (int)flags.Purple });
            dt.Rows.Add(new object[] { string.Empty, "Paul", "Re: License issue", DateTime.Now.AddDays(-356), 3, 1, "Jake", "Thanks!!", 3453454, string.Empty, null, (int)flags.Clear });
            dt.Rows.Add(new object[] { 1, "Don", "UI design", DateTime.Now.AddDays(-357), 3, 1, "Jake", "Will it be possible to tune grids as in the attachment.", 3434100, string.Empty, null, (int)flags.Clear });
            dt.Rows.Add(new object[] { string.Empty, "Jerry", "Evalutation", DateTime.Now.AddDays(-358), 2, 1, "Jake", "Testing is completed. This product works fine", 2033, string.Empty, null, (int)flags.Clear });
            dt.Rows.Add(new object[] { string.Empty, "Patrick", "Feedback", DateTime.Now.AddDays(-359), 2, 1, "Jake", "Thanks for your extraordinary support.", 20400, string.Empty, null, (int)flags.Clear });
            dt.Rows.Add(new object[] { string.Empty, "Paul", "License issue", DateTime.Now.AddDays(-360), 3, 1, "Jake", "How do I enable license to my customers?", 344540, 1, null, (int)flags.Clear });
            dt.Rows.Add(new object[] { string.Empty, "Don", "Evaluation Keys", DateTime.Now.AddDays(-365), 1, 1, "Jake", "Can you send the keys to test your produts.", 34341, string.Empty, null, (int)flags.Complete });
            return dt;
        }
        # endregion

        # region Constructor

        public GroupingPanel()
        {
            // GroupingEngineFactory provides a modified GridChildTable that adds an extra section
            GridEngineFactory.Factory = new GroupingEngineFactory();

            InitializeComponent();

            CSVHeader = new ColumnSetViewHeader();
            this.gridGroupingControl1.DataSource = GetTable();
			this.gridGroupingControl1.TableControl.DpiAware = true;
            this.gridGroupingControl1.TableDescriptor.Columns.Clear();
            this.gridGroupingControl1.TableDescriptor.Columns.Add("Priority");
            this.gridGroupingControl1.TableDescriptor.Columns.Add("mails");
            this.gridGroupingControl1.TableDescriptor.Columns.Add("Attachment");
            this.gridGroupingControl1.TableDescriptor.Columns.Add("Subject");
            this.gridGroupingControl1.TableDescriptor.Columns.Add("From");
            this.gridGroupingControl1.TableDescriptor.Columns.Add("Received");
            this.gridGroupingControl1.TableDescriptor.Columns.Add("Size");
            this.gridGroupingControl1.TableDescriptor.Columns.Add("Category");
            this.gridGroupingControl1.TableDescriptor.Columns.Add("flag");

            visibleCols = new string[this.gridGroupingControl1.TableDescriptor.VisibleColumns.Count];
            for (int i = 0; i < visibleCols.Length; i++)
                visibleCols[i] = this.gridGroupingControl1.TableDescriptor.VisibleColumns[i].Name;

            this.gridGroupingControl1.TableOptions.RecordPreviewRowHeight = 40;

            fList = new ImageList();
            fList.Images.Add(i1);
            fList.Images.Add(i2);
            fList.Images.Add(i3);
            fList.Images.Add(i4);
            fList.Images.Add(i5);
            fList.Images.Add(i6);
            fList.Images.Add(i7);
            fList.Images.Add(i8);
            fList.Images.Add(i17);
            fList.ColorDepth = ColorDepth.Depth32Bit;

            iList = new ImageList();
            iList.Images.Add(i1);
            iList.Images.Add(i2);
            iList.Images.Add(i3);
            iList.Images.Add(i4);
            iList.Images.Add(i5);
            iList.Images.Add(i6);
            iList.Images.Add(i7);
            iList.Images.Add(i8);
            iList.Images.Add(i9);
            iList.Images.Add(i10);
            iList.Images.Add(i11);
            iList.Images.Add(i12);
            iList.Images.Add(i13);
            iList.Images.Add(i14);
            iList.Images.Add(i15);
            iList.Images.Add(i16);


            mailList = new ImageList();
            mailList.Images.Add(m1);
            mailList.Images.Add(m2);
            mailList.Images.Add(m3);
            mailList.Images.Add(m4);
            mailList.Images.Add(m5);


            UtilIconList = new ImageList();
            UtilIconList.Images.Add(u1);
            UtilIconList.Images.Add(u2);
            UtilIconList.Images.Add(u3);
            UtilIconList.Images.Add(u4);

            hmenuList = new ImageList();
            hmenuList.Images.Add(h1);
            hmenuList.Images.Add(h2);
            hmenuList.Images.Add(h3);
            hmenuList.Images.Add(h4);
            hmenuList.Images.Add(h5);

            //HeaderPopMenuImageList
            for (int h = 0; h < this.headerParentBarItem.Items.Count; h++)
                this.headerParentBarItem.Items[h].ImageList = this.hmenuList;
            this.barItem_SortAscending.ImageIndex = 0;
            this.barItem_sortDescending.ImageIndex = 1;
            this.barItem_GroupByThisField.ImageIndex = 2;
            this.barItem_GroupByBox.ImageIndex = 3;
            this.barItem_FieldChooser.ImageIndex = 4;

            //Flag Item
            this.markcompleteFlagBarItem.ImageList = this.fList;
            this.todayBarItem.ImageList = this.fList;
            this.tomoBarItem.ImageList = this.fList;
            this.thisweekFlagBarItem.ImageList = this.fList;
            this.nextweekFlagBarItem.ImageList = this.fList;
            this.nodateFlagBarItem.ImageList = this.fList;
            this.customFlagBarItem.ImageList = this.fList;
            this.addReminderBarItem.ImageList = this.fList;
            this.markcompleteFlagBarItem.ImageList = this.fList;

            // Flag of caption
            this.todayCaptionBarItem.ImageList = this.fList;
            this.tomoCaptionBarItem.ImageList = this.fList;
            this.thisweekfromCaptionBarItem.ImageList = this.fList;
            this.nextweekCaptionBarItem.ImageList = this.fList;
            this.nodateCaptionBarItem.ImageList = this.fList;
            this.customCaptionBarItem.ImageList = this.fList;
            this.addreminderCaptionBarItem.ImageList = this.fList;
            this.markcompletefromCaptionBarItem.ImageList = this.fList;

            // Flag of Records
            this.todayRecordBarItem.ImageList = this.fList;
            this.tomoRecordBarItem.ImageList = this.fList;
            this.thisweekRecordBarItem.ImageList = this.fList;
            this.nextweekRecordBarItem.ImageList = this.fList;
            this.nodateRecordBarItem.ImageList = this.fList;
            this.customRecordBarItem.ImageList = this.fList;
            this.addreminderRecordBarItem.ImageList = this.fList;
            this.markcompleteRecordItem.ImageList = this.fList;

            // Default Flag
            this.redAsDefaultBarItem.ImageList = this.fList;
            this.blueAsDefaultBarItem.ImageList = this.fList;
            this.yellowAsDefaultBarItem.ImageList = this.fList;
            this.greenAsDefaultBarItem.ImageList = this.fList;
            this.orangeAsDefaultBarItem.ImageList = this.fList;
            this.purpleAsDefaultBarItem.ImageList = this.fList;


            // Default flag of Caption
            this.todayCaptionBarItem.ImageList = this.fList;
            this.tomoCaptionBarItem.ImageList = this.fList;
            this.thisweekfromCaptionBarItem.ImageList = this.fList;
            this.nextweekCaptionBarItem.ImageList = this.fList;
            this.markcompletefromCaptionBarItem.ImageList = this.fList;
            this.clearflagCaptionBarItem.ImageList = this.fList;

            // Default flag of Records
            this.RedAsDefaultfromRecordBarItem.ImageList = this.fList;
            this.BlueasDefaultfromRecordBarItem.ImageList = this.fList;
            this.YellowasDefaultfromRecordBarItem.ImageList = this.fList;
            this.GreenasDefaultfromRecordBarItem.ImageList = this.fList;
            this.OrangeasDefaultfromRecordBarItem.ImageList = this.fList;
            this.PurpleasDefaultfromRecordBarItem.ImageList = this.fList;

            // Caption Menu
            this.PrintfromCaptionBarItem.ImageList = this.UtilIconList;
            this.PrintfromCaptionBarItem.ImageIndex = 0;
            this.ForwardfromCaptionBarItem.ImageList = this.mailList;
            this.ForwardfromCaptionBarItem.ImageIndex = 3;
            this.MarkAsReadfromCaptionBarItem.ImageList = this.mailList;
            this.MarkAsReadfromCaptionBarItem.ImageIndex = 1;
            this.MarkAsUnreadfromCaptionBarItem.ImageList = this.mailList;
            this.MarkAsUnreadfromCaptionBarItem.ImageIndex = 0;
            this.DeletefromCaptionBarItem.ImageList = this.UtilIconList;
            this.DeletefromCaptionBarItem.ImageIndex = 1;
            this.MovetoFolderfromCaptionBarItem.ImageList = this.UtilIconList;
            this.MovetoFolderfromCaptionBarItem.ImageIndex = 2;

            // Record Menu
            this.PrintfromRecordBarItem.ImageList = this.UtilIconList;
            this.PrintfromRecordBarItem.ImageIndex = 0;
            this.ReplyfromRecordBarItem.ImageList = this.mailList;
            this.ReplyfromRecordBarItem.ImageIndex = 2;
            this.ReplyToAllfromRecordBarItem.ImageList = this.mailList;
            this.ReplyToAllfromRecordBarItem.ImageIndex = 4;
            this.ForwardfromRecordBarItem.ImageList = this.mailList;
            this.ForwardfromRecordBarItem.ImageIndex = 3;
            this.MarkfromRecordBarItem.ImageList = this.mailList;
            this.MarkfromRecordBarItem.ImageIndex = 0;
            this.CreateRulefromRecordBarItem.ImageList = this.UtilIconList;
            this.CreateRulefromRecordBarItem.ImageIndex = 3;
            this.DeletefromRecordBarItem.ImageList = this.UtilIconList;
            this.DeletefromRecordBarItem.ImageIndex = 1;
            this.MoveToFolderfromRecordBarItem.ImageList = this.UtilIconList;
            this.MoveToFolderfromRecordBarItem.ImageIndex = 2;
            //option

            # region Settings

            this.gridGroupingControl1.ThemesEnabled = false;
            this.gridGroupingControl1.TableControl.VScrollPixel = true;
            this.gridGroupingControl1.GroupDropPanel.BackColor = Color.FromArgb(Form1.r, Form1.g, Form1.b);
            this.gridGroupingControl1.GroupDropPanel.Height = 30;
            this.gridGroupingControl1.Splitter.BackColor = Color.FromArgb(Form1.r, Form1.g, Form1.b);
            this.gridGroupingControl1.Splitter.Height = 1;
            this.gridGroupingControl1.Appearance.GroupCaptionCell.CellType = "Static";


            this.gridGroupingControl1.GroupExpanded += new GroupEventHandler(gridGroupingControl1_GroupExpanded);
            this.gridGroupingControl1.GroupCollapsed += new GroupEventHandler(gridGroupingControl1_GroupCollapsed);

            // Removing some unnecessary elements
            this.gridGroupingControl1.TableOptions.ShowRowHeader = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.Appearance.GroupCaptionPlusMinusCell.BorderMargins.Top = 12;
            this.gridGroupingControl1.Appearance.GroupCaptionPlusMinusCell.CellType = "Image";
            this.gridGroupingControl1.Appearance.GroupCaptionPlusMinusCell.CellValue = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "minus.png"));
            this.gridGroupingControl1.TableModel.Properties.DisplayVertLines = false;
            // setting required settings
            this.gridGroupingControl1.Appearance.GroupIndentCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, Color.FromArgb(Form1.r, Form1.g, Form1.b), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.Appearance.AnyRecordFieldCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, Color.FromArgb(Form1.r, Form1.g, Form1.b), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableOptions.CaptionRowHeight = 34;
            this.gridGroupingControl1.TableOptions.ColumnHeaderRowHeight = 22;
            this.gridGroupingControl1.TableOptions.IndentWidth = 20;
            this.gridGroupingControl1.TableOptions.RecordRowHeight = 22;
            this.gridGroupingControl1.TableModel.TableStyle.Trimming = StringTrimming.EllipsisCharacter;
            //this.gridGroupingControl1.Appearance.ColumnHeaderCell.Font.Bold = true;
            //this.gridGroupingControl1.Appearance.RecordFieldCell.Font.Facename = "Corbel";

            // selections
            this.gridGroupingControl1.TableOptions.ListBoxSelectionCurrentCellOptions = GridListBoxSelectionCurrentCellOptions.None;
            this.gridGroupingControl1.TableModel.Options.ShowCurrentCellBorderBehavior = GridShowCurrentCellBorder.HideAlways;
            this.gridGroupingControl1.TableOptions.AllowSelection = GridSelectionFlags.Any;
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.One;
            this.gridGroupingControl1.TableModel.Options.AlphaBlendSelectionColor = SystemColors.InactiveCaptionText;

            this.gridGroupingControl1.TableDescriptor.Columns["Priority"].Width = 12;
            this.gridGroupingControl1.TableDescriptor.Columns["mails"].Width = 12;
            this.gridGroupingControl1.TableDescriptor.Columns["Attachment"].Width = 12;

            this.CSVHeader.wire(this);
            # endregion

            #region Unbound Fields

            FieldDescriptor date = new FieldDescriptor("date", "date", false, "");
            this.gridGroupingControl1.TableDescriptor.UnboundFields.Add(date);
            GridColumnDescriptor cddate = new GridColumnDescriptor(date);
            cddate.HeaderText = "Date";
            this.gridGroupingControl1.TableDescriptor.Columns.Add(cddate);
            this.gridGroupingControl1.TableDescriptor.Columns["date"].Width = 0;

            FieldDescriptor customSize = new FieldDescriptor("customSize", "customSize", false, "");
            this.gridGroupingControl1.TableDescriptor.UnboundFields.Add(customSize);
            GridColumnDescriptor cdcustomSize = new GridColumnDescriptor(customSize);
            cdcustomSize.HeaderText = "Size";
            this.gridGroupingControl1.TableDescriptor.Columns.Add(cdcustomSize);
            this.gridGroupingControl1.TableDescriptor.Columns["customSize"].Width = 0;

            FieldDescriptor DummyCol = new FieldDescriptor("DummyCol", "DummyCol", true, "");
            this.gridGroupingControl1.TableDescriptor.UnboundFields.Add(DummyCol);
            GridColumnDescriptor cdDummyCol = new GridColumnDescriptor(DummyCol);
            cdDummyCol.HeaderText = "";

            // mails column are in the left side
            int src = this.gridGroupingControl1.TableDescriptor.Columns.IndexOf("mails");
            this.gridGroupingControl1.TableDescriptor.Columns.Move(src, 0);

            # endregion

            # region event subscribed

            this.gridGroupingControl1.TableModel.QueryColWidth += new GridRowColSizeEventHandler(TableModel_QueryColWidth);
            this.gridGroupingControl1.TableModel.ColWidthsChanging += new GridRowColSizeChangingEventHandler(TableModel_ColWidthsChanging);
            this.gridGroupingControl1.TableModel.ColWidthsChanged += new GridRowColSizeChangedEventHandler(TableModel_ColWidthsChanged);
            this.gridGroupingControl1.SizeChanged += new EventHandler(gridGroupingControl1_SizeChanged);
            this.gridGroupingControl1.QueryCellStyleInfo += new GridTableCellStyleInfoEventHandler(gridGroupingControl1_QueryCellStyleInfo);
            this.gridGroupingControl1.TableControlCellClick += new GridTableControlCellClickEventHandler(gridGroupingControl1_TableControlCellClick);
            this.gridGroupingControl1.QueryValue += new FieldValueEventHandler(gridGroupingControl1_QueryValue);
            this.gridGroupingControl1.TableModel.QueryCoveredRange += new GridQueryCoveredRangeEventHandler(TableModel_QueryCoveredRange);
            this.gridGroupingControl1.GridGroupDropArea.Model.QueryColWidth += new GridRowColSizeEventHandler(Model_QueryColWidth);
            this.gridGroupingControl1.TableControlCurrentCellActivating += new GridTableControlCurrentCellActivatingEventHandler(gridGroupingControl1_TableControlCurrentCellActivating);
            this.gridGroupingControl1.TableDescriptor.GroupedColumns.Changed += new ListPropertyChangedEventHandler(GroupedColumns_Changed);
            this.gridGroupingControl1.TableControlKeyDown += new GridTableControlKeyEventHandler(gridGroupingControl1_TableControlKeyDown);
            this.gridGroupingControl1.Resize += new EventHandler(gridGroupingControl1_Resize);
            this.gridGroupingControl1.TableControl.PrepareViewStyleInfo += new GridPrepareViewStyleInfoEventHandler(TableControl_PrepareViewStyleInfo);
            this.Changed += new ChangedEventHandler(GroupingPanel_Changed);
            this.ShowViewChanged += new ChangedEventHandler(GroupingPanel_ShowViewChanged);
            this.gridGroupingControl1.TableControl.Model.SelectionChanging += new GridSelectionChangingEventHandler(Model_SelectionChanging);
            //this.gridGroupingControl1.GridGroupDropArea.PrepareViewStyleInfo += new GridPrepareViewStyleInfoEventHandler(GridGroupDropArea_PrepareViewStyleInfo);
            this.gridGroupingControl1.TableControlCellDrawn += new GridTableControlDrawCellEventHandler(gridGroupingControl1_TableControlCellDrawn);

            # endregion

            // Assuming when the Grouping Grid is resized less than the width of 400, column set view is good 
            CreateColumnSetView(numberOfLayers);
            this.gridGroupingControl1.TableControl.HScrollBehavior = GridScrollbarMode.Disabled;
            this.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("date");
            this.barItem_Date.Checked = true;
            this.gridGroupingControl1.TableDescriptor.Columns["Size"].AllowGroupByColumn = false;
            this.gridGroupingControl1.TableOptions.GridVisualStyles = GridVisualStyles.Office2007Blue;
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        # endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupingPanel));
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.groupingConfig1 = new Syncfusion.Grouping.GroupingConfig();
            this.normalViewPopUpMenu = new Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(this.components);
            this.headerParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.parentBarItem_ArrangeBy = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem_Date = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem_Conversation = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem_From = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem_To = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem_Folder = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem_Size = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem_Subject = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem_Type = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem_Flag = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem_Attachments = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem_EmailAccounts = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem_Importance = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem_Categories = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem_Custom = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem_ShowInGroups = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem_SortAscending = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem_sortDescending = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem_GroupByThisField = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem_GroupByBox = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem_RemoveThisColumn = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem_FieldChooser = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem_BestFit = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem_FormatColumns = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem_CustomizeCurrentView = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.headerPopUpMenu = new Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(this.components);
            this.flagPopupMenu = new Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(this.components);
            this.flagMenusParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.todayBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.tomoBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.thisweekFlagBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.nextweekFlagBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.nodateFlagBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.customFlagBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.addReminderBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.markcompleteFlagBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.clearflagParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.redAsDefaultBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.blueAsDefaultBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.yellowAsDefaultBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.greenAsDefaultBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.orangeAsDefaultBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.purpleAsDefaultBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.setquickclickBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.CaptionPopupMenu = new Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(this.components);
            this.parentBarItemForCaption = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.collapseAllGroupsBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.ExpandAllGroupsBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.OpenItemsBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.PrintfromCaptionBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.ForwardfromCaptionBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.FollowUpParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.todayCaptionBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.tomoCaptionBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.thisweekfromCaptionBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.nextweekCaptionBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.nodateCaptionBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.customCaptionBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.addreminderCaptionBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.markcompletefromCaptionBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.clearflagCaptionBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.setBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.categoriesBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.MarkAsReadfromCaptionBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.MarkAsUnreadfromCaptionBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.DeletefromCaptionBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.MovetoFolderfromCaptionBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.RecordPopupMenu = new Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(this.components);
            this.RecordsParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.OpenfromRecordBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.PrintfromRecordBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.ReplyfromRecordBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.ReplyToAllfromRecordBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.ForwardfromRecordBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.RecordFollowUpParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.todayRecordBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.tomoRecordBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.thisweekRecordBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.nextweekRecordBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.nodateRecordBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.customRecordBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.addreminderRecordBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.markcompleteRecordItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.ClearFlagfromRecordBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.setRecordBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.MarkfromRecordBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.CategoriesfromRecordBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.FindAllfromRecordparentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.RelatedMessagesBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.MessagesfromsenderBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.CreateRulefromRecordBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.JunkEmailsfromRecordParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.AddSendertoBlockedSendersListBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.AddSendertoSafeSendersListBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.AddSendersDomaintoSafeSendersListBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.AddRecipienttoSafeRecipientsListBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.MarkasNotJunkBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.JunkEmailOptionsBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.DeletefromRecordBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.MoveToFolderfromRecordBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.OptionsfromRecordBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.RedAsDefaultfromRecordBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.BlueasDefaultfromRecordBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.YellowasDefaultfromRecordBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.GreenasDefaultfromRecordBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.OrangeasDefaultfromRecordBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.PurpleasDefaultfromRecordBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.categoryPopUpMenu = new Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(this.components);
            this.categoryParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.clearallcategBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.categsearchBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.redcategBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.blueBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.greenBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.orangeBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.purpleBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.yellowBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.allcategBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.setcategBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.BackColor = System.Drawing.Color.White;
            this.gridGroupingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGroupingControl1.Location = new System.Drawing.Point(0, 0);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.Size = new System.Drawing.Size(688, 353);
            this.gridGroupingControl1.TabIndex = 0;
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            // 
            // normalViewPopUpMenu
            // 
            this.normalViewPopUpMenu.ParentBarItem = this.headerParentBarItem;
            // 
            // headerParentBarItem
            // 
            this.headerParentBarItem.CustomTextFont = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerParentBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem_ArrangeBy,
            this.barItem_SortAscending,
            this.barItem_sortDescending,
            this.barItem_GroupByThisField,
            this.barItem_GroupByBox,
            this.barItem_RemoveThisColumn,
            this.barItem_FieldChooser,
            this.barItem_BestFit,
            this.barItem_FormatColumns,
            this.barItem_CustomizeCurrentView});
            this.headerParentBarItem.SeparatorIndices.AddRange(new int[] {
            1,
            3,
            5,
            9});
            this.headerParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook;
            // 
            // parentBarItem_ArrangeBy
            // 
            this.parentBarItem_ArrangeBy.ID = "ArrangeBy";
            this.parentBarItem_ArrangeBy.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem_Date,
            this.barItem_Conversation,
            this.barItem_From,
            this.barItem_To,
            this.barItem_Folder,
            this.barItem_Size,
            this.barItem_Subject,
            this.barItem_Type,
            this.barItem_Flag,
            this.barItem_Attachments,
            this.barItem_EmailAccounts,
            this.barItem_Importance,
            this.barItem_Categories,
            this.barItem_Custom,
            this.barItem_ShowInGroups});
            this.parentBarItem_ArrangeBy.SeparatorIndices.AddRange(new int[] {
            13,
            14});
            this.parentBarItem_ArrangeBy.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook;
            this.parentBarItem_ArrangeBy.Text = "ArrangeBy";
            // 
            // barItem_Date
            // 
            this.barItem_Date.Checked = true;
            this.barItem_Date.ID = "Date";
            this.barItem_Date.Text = "Date";
            this.barItem_Date.Click += new System.EventHandler(this.barItem_Date_Click);
            // 
            // barItem_Conversation
            // 
            this.barItem_Conversation.ID = "Conversation";
            this.barItem_Conversation.ShortcutText = "C";
            this.barItem_Conversation.Text = "Conversation";
            this.barItem_Conversation.Click += new System.EventHandler(this.barItem_Conversation_Click);
            // 
            // barItem_From
            // 
            this.barItem_From.ID = "From";
            this.barItem_From.Text = "From";
            this.barItem_From.Click += new System.EventHandler(this.barItem_From_Click);
            // 
            // barItem_To
            // 
            this.barItem_To.ID = "Received";
            this.barItem_To.ShortcutText = "T";
            this.barItem_To.Text = "To";
            // 
            // barItem_Folder
            // 
            this.barItem_Folder.Enabled = false;
            this.barItem_Folder.ID = "Folder";
            this.barItem_Folder.ShortcutText = "l";
            this.barItem_Folder.Text = "Folder";
            // 
            // barItem_Size
            // 
            this.barItem_Size.ID = "Size";
            this.barItem_Size.Text = "Size";
            this.barItem_Size.Click += new System.EventHandler(this.barItem_Size_Click);
            // 
            // barItem_Subject
            // 
            this.barItem_Subject.ID = "Subject";
            this.barItem_Subject.Text = "Subject";
            this.barItem_Subject.Click += new System.EventHandler(this.barItem_Subject_Click);
            // 
            // barItem_Type
            // 
            this.barItem_Type.ID = "Type";
            this.barItem_Type.ShortcutText = "y";
            this.barItem_Type.Text = "Type";
            this.barItem_Type.Click += new System.EventHandler(this.barItem_Type_Click);
            // 
            // barItem_Flag
            // 
            this.barItem_Flag.ID = "Flag";
            this.barItem_Flag.ShortcutText = "g";
            this.barItem_Flag.Text = "Flag";
            this.barItem_Flag.Click += new System.EventHandler(this.barItem_Flag_Click);
            // 
            // barItem_Attachments
            // 
            this.barItem_Attachments.ID = "Attachments";
            this.barItem_Attachments.ShortcutText = "A";
            this.barItem_Attachments.ShowMnemonicUnderlinesAlways = true;
            this.barItem_Attachments.Text = "&Attachments";
            this.barItem_Attachments.Click += new System.EventHandler(this.barItem_Attachments_Click);
            // 
            // barItem_EmailAccounts
            // 
            this.barItem_EmailAccounts.ID = "E-mail Accounts";
            this.barItem_EmailAccounts.ShortcutText = "o";
            this.barItem_EmailAccounts.Text = "E-mail Accounts";
            this.barItem_EmailAccounts.Click += new System.EventHandler(this.barItem_EmailAccounts_Click);
            // 
            // barItem_Importance
            // 
            this.barItem_Importance.ID = "Importance";
            this.barItem_Importance.ShortcutText = "I";
            this.barItem_Importance.Text = "Importance";
            this.barItem_Importance.Click += new System.EventHandler(this.barItem_Importance_Click);
            // 
            // barItem_Categories
            // 
            this.barItem_Categories.ID = "Categories";
            this.barItem_Categories.ShortcutText = "e";
            this.barItem_Categories.Text = "Categories";
            this.barItem_Categories.Click += new System.EventHandler(this.barItem_Categories_Click);
            // 
            // barItem_Custom
            // 
            this.barItem_Custom.ID = "Custom";
            this.barItem_Custom.ShortcutText = "m";
            this.barItem_Custom.Text = "Custom";
            // 
            // barItem_ShowInGroups
            // 
            this.barItem_ShowInGroups.Checked = true;
            this.barItem_ShowInGroups.ID = "Show in Groups";
            this.barItem_ShowInGroups.ShortcutText = "w";
            this.barItem_ShowInGroups.Text = "Show in Groups";
            this.barItem_ShowInGroups.Click += new System.EventHandler(this.barItem_ShowInGroups_Click);
            // 
            // barItem_SortAscending
            // 
            this.barItem_SortAscending.ID = "Sort Ascending";
            this.barItem_SortAscending.Text = "Sort Ascending";
            this.barItem_SortAscending.Click += new System.EventHandler(this.barItem_SortAscending_Click);
            // 
            // barItem_sortDescending
            // 
            this.barItem_sortDescending.ID = "Sort Descending";
            this.barItem_sortDescending.Text = "Sort Descending";
            this.barItem_sortDescending.Click += new System.EventHandler(this.barItem_sortDescending_Click);
            // 
            // barItem_GroupByThisField
            // 
            this.barItem_GroupByThisField.ID = "Group By this Field";
            this.barItem_GroupByThisField.ShortcutText = "G";
            this.barItem_GroupByThisField.Text = "Group By this Field";
            this.barItem_GroupByThisField.Click += new System.EventHandler(this.barItem_GroupByThisField_Click);
            // 
            // barItem_GroupByBox
            // 
            this.barItem_GroupByBox.ID = "Show in Groups";
            this.barItem_GroupByBox.ShortcutText = "B";
            this.barItem_GroupByBox.Text = "Group By Box";
            this.barItem_GroupByBox.Click += new System.EventHandler(this.barItem_GroupByBox_Click);
            // 
            // barItem_RemoveThisColumn
            // 
            this.barItem_RemoveThisColumn.ID = "Remove This Column";
            this.barItem_RemoveThisColumn.ShortcutText = "R";
            this.barItem_RemoveThisColumn.Text = "Remove This Column";
            this.barItem_RemoveThisColumn.Click += new System.EventHandler(this.barItem_RemoveThisColumn_Click);
            // 
            // barItem_FieldChooser
            // 
            this.barItem_FieldChooser.ID = "Field Chooser";
            this.barItem_FieldChooser.ShortcutText = "C";
            this.barItem_FieldChooser.Text = "Field Chooser";
            this.barItem_FieldChooser.Click += new System.EventHandler(this.barItem_FieldChooser_Click);
            // 
            // barItem_BestFit
            // 
            this.barItem_BestFit.Enabled = false;
            this.barItem_BestFit.ID = "Best Fit";
            this.barItem_BestFit.ShortcutText = "F";
            this.barItem_BestFit.Text = "Best Fit";
            // 
            // barItem_FormatColumns
            // 
            this.barItem_FormatColumns.Enabled = false;
            this.barItem_FormatColumns.ID = "Format Columns...";
            this.barItem_FormatColumns.ShortcutText = "m";
            this.barItem_FormatColumns.Text = "Format Columns...";
            // 
            // barItem_CustomizeCurrentView
            // 
            this.barItem_CustomizeCurrentView.ID = "Customize Current View";
            this.barItem_CustomizeCurrentView.Text = "Customize Current View";
            this.barItem_CustomizeCurrentView.Tooltip = "C";
            this.barItem_CustomizeCurrentView.Click += new System.EventHandler(this.barItem_CustomizeCurrentView_Click);
            // 
            // headerPopUpMenu
            // 
            this.headerPopUpMenu.ParentBarItem = this.headerParentBarItem;
            // 
            // flagPopupMenu
            // 
            this.flagPopupMenu.ParentBarItem = this.flagMenusParentBarItem;
            // 
            // flagMenusParentBarItem
            // 
            this.flagMenusParentBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.todayBarItem,
            this.tomoBarItem,
            this.thisweekFlagBarItem,
            this.nextweekFlagBarItem,
            this.nodateFlagBarItem,
            this.customFlagBarItem,
            this.addReminderBarItem,
            this.markcompleteFlagBarItem,
            this.clearflagParentBarItem,
            this.setquickclickBarItem});
            this.flagMenusParentBarItem.SeparatorIndices.AddRange(new int[] {
            6,
            9});
            this.flagMenusParentBarItem.ShowMnemonicUnderlinesAlways = true;
            this.flagMenusParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook;
            // 
            // todayBarItem
            // 
            this.todayBarItem.ID = "&Red Flag";
            this.todayBarItem.ImageIndex = 1;
            this.todayBarItem.ShowMnemonicUnderlinesAlways = true;
            this.todayBarItem.Text = "&Today";
            this.todayBarItem.Click += new System.EventHandler(this.redFlagBarItem_Click);
            // 
            // tomoBarItem
            // 
            this.tomoBarItem.ID = "&Blue Flag";
            this.tomoBarItem.ImageIndex = 2;
            this.tomoBarItem.ShowMnemonicUnderlinesAlways = true;
            this.tomoBarItem.Text = "T&ommorrow";
            this.tomoBarItem.Click += new System.EventHandler(this.blueFlagBarItem_Click);
            // 
            // thisweekFlagBarItem
            // 
            this.thisweekFlagBarItem.ID = "Yellow Flag";
            this.thisweekFlagBarItem.ImageIndex = 3;
            this.thisweekFlagBarItem.ShowMnemonicUnderlinesAlways = true;
            this.thisweekFlagBarItem.Text = "This &Week";
            this.thisweekFlagBarItem.Click += new System.EventHandler(this.yellowFlagBarItem_Click);
            // 
            // nextweekFlagBarItem
            // 
            this.nextweekFlagBarItem.ID = "&Green Flag";
            this.nextweekFlagBarItem.ImageIndex = 4;
            this.nextweekFlagBarItem.ShowMnemonicUnderlinesAlways = true;
            this.nextweekFlagBarItem.Text = "&Next Week";
            this.nextweekFlagBarItem.Click += new System.EventHandler(this.greenFlagBarItem_Click);
            // 
            // nodateFlagBarItem
            // 
            this.nodateFlagBarItem.ID = "&Orange Flag";
            this.nodateFlagBarItem.ImageIndex = 5;
            this.nodateFlagBarItem.ShowMnemonicUnderlinesAlways = true;
            this.nodateFlagBarItem.Text = "No D&ate";
            this.nodateFlagBarItem.Click += new System.EventHandler(this.orangeFlagBarItem_Click);
            // 
            // customFlagBarItem
            // 
            this.customFlagBarItem.ID = "P&urple Flag";
            this.customFlagBarItem.ImageIndex = 6;
            this.customFlagBarItem.ShowMnemonicUnderlinesAlways = true;
            this.customFlagBarItem.Text = "&Custom...";
            this.customFlagBarItem.Click += new System.EventHandler(this.purpleFlagBarItem_Click);
            // 
            // addReminderBarItem
            // 
            this.addReminderBarItem.ID = "&Add Reminder";
            this.addReminderBarItem.ImageIndex = 7;
            this.addReminderBarItem.ShowMnemonicUnderlinesAlways = true;
            this.addReminderBarItem.Text = "Add &Reminder...";
            this.addReminderBarItem.Click += new System.EventHandler(this.addReminderBarItem_Click);
            // 
            // markcompleteFlagBarItem
            // 
            this.markcompleteFlagBarItem.ID = "Clear Flag";
            this.markcompleteFlagBarItem.ImageIndex = 8;
            this.markcompleteFlagBarItem.ShowMnemonicUnderlinesAlways = true;
            this.markcompleteFlagBarItem.Text = "&Mark Complete";
            this.markcompleteFlagBarItem.Click += new System.EventHandler(this.clearFlagBarItem_Click);
            // 
            // clearflagParentBarItem
            // 
            this.clearflagParentBarItem.Enabled = false;
            this.clearflagParentBarItem.ID = "&Set Default Flag";
            this.clearflagParentBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.redAsDefaultBarItem,
            this.blueAsDefaultBarItem,
            this.yellowAsDefaultBarItem,
            this.greenAsDefaultBarItem,
            this.orangeAsDefaultBarItem,
            this.purpleAsDefaultBarItem});
            this.clearflagParentBarItem.ShowMnemonicUnderlinesAlways = true;
            this.clearflagParentBarItem.Text = "Cl&ear Flag";
            // 
            // redAsDefaultBarItem
            // 
            this.redAsDefaultBarItem.ID = "&Red Flag as Default";
            this.redAsDefaultBarItem.ImageIndex = 1;
            this.redAsDefaultBarItem.ShowMnemonicUnderlinesAlways = true;
            this.redAsDefaultBarItem.Text = "&Red Flag as Default";
            this.redAsDefaultBarItem.Click += new System.EventHandler(this.redAsDefaultBarItem_Click);
            // 
            // blueAsDefaultBarItem
            // 
            this.blueAsDefaultBarItem.ID = "&Blue Flag as Default";
            this.blueAsDefaultBarItem.ImageIndex = 2;
            this.blueAsDefaultBarItem.ShowMnemonicUnderlinesAlways = true;
            this.blueAsDefaultBarItem.Text = "&Blue Flag as Default";
            this.blueAsDefaultBarItem.Click += new System.EventHandler(this.blueAsDefaultBarItem_Click);
            // 
            // yellowAsDefaultBarItem
            // 
            this.yellowAsDefaultBarItem.ID = "&Yellow Flag as Default";
            this.yellowAsDefaultBarItem.ImageIndex = 3;
            this.yellowAsDefaultBarItem.ShowMnemonicUnderlinesAlways = true;
            this.yellowAsDefaultBarItem.Text = "&Yellow Flag as Default";
            this.yellowAsDefaultBarItem.Click += new System.EventHandler(this.yellowAsDefaultBarItem_Click);
            // 
            // greenAsDefaultBarItem
            // 
            this.greenAsDefaultBarItem.ID = "&Green Flag as Default";
            this.greenAsDefaultBarItem.ImageIndex = 4;
            this.greenAsDefaultBarItem.ShowMnemonicUnderlinesAlways = true;
            this.greenAsDefaultBarItem.Text = "&Green Flag as Default";
            this.greenAsDefaultBarItem.Click += new System.EventHandler(this.greenAsDefaultBarItem_Click);
            // 
            // orangeAsDefaultBarItem
            // 
            this.orangeAsDefaultBarItem.ID = "&Orange Flag as Default";
            this.orangeAsDefaultBarItem.ImageIndex = 5;
            this.orangeAsDefaultBarItem.ShowMnemonicUnderlinesAlways = true;
            this.orangeAsDefaultBarItem.Text = "&Orange Flag as Default";
            this.orangeAsDefaultBarItem.Click += new System.EventHandler(this.orangeAsDefaultBarItem_Click);
            // 
            // purpleAsDefaultBarItem
            // 
            this.purpleAsDefaultBarItem.ID = "P&urple Flag as Default";
            this.purpleAsDefaultBarItem.ImageIndex = 6;
            this.purpleAsDefaultBarItem.ShowMnemonicUnderlinesAlways = true;
            this.purpleAsDefaultBarItem.Text = "P&urple Flag as Default";
            this.purpleAsDefaultBarItem.Click += new System.EventHandler(this.purpleAsDefaultBarItem_Click);
            // 
            // setquickclickBarItem
            // 
            this.setquickclickBarItem.ID = "Flag Complete";
            this.setquickclickBarItem.ImageIndex = 7;
            this.setquickclickBarItem.ShowMnemonicUnderlinesAlways = true;
            this.setquickclickBarItem.Text = "Set &Quick Click...";
            this.setquickclickBarItem.Click += new System.EventHandler(this.flagCompleteBarItem_Click);
            // 
            // CaptionPopupMenu
            // 
            this.CaptionPopupMenu.ParentBarItem = this.parentBarItemForCaption;
            // 
            // parentBarItemForCaption
            // 
            this.parentBarItemForCaption.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.collapseAllGroupsBarItem,
            this.ExpandAllGroupsBarItem,
            this.OpenItemsBarItem,
            this.PrintfromCaptionBarItem,
            this.ForwardfromCaptionBarItem,
            this.FollowUpParentBarItem,
            this.categoriesBarItem,
            this.MarkAsReadfromCaptionBarItem,
            this.MarkAsUnreadfromCaptionBarItem,
            this.DeletefromCaptionBarItem,
            this.MovetoFolderfromCaptionBarItem});
            this.parentBarItemForCaption.SeparatorIndices.AddRange(new int[] {
            2,
            4,
            5,
            9});
            this.parentBarItemForCaption.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook;
            // 
            // collapseAllGroupsBarItem
            // 
            this.collapseAllGroupsBarItem.ID = "Co&llapse All Groups";
            this.collapseAllGroupsBarItem.ShowMnemonicUnderlinesAlways = true;
            this.collapseAllGroupsBarItem.Text = "Co&llapse All Groups";
            this.collapseAllGroupsBarItem.Click += new System.EventHandler(this.collapseAllGroupsBarItem_Click);
            // 
            // ExpandAllGroupsBarItem
            // 
            this.ExpandAllGroupsBarItem.ID = "&Expand All Groups";
            this.ExpandAllGroupsBarItem.ShowMnemonicUnderlinesAlways = true;
            this.ExpandAllGroupsBarItem.Text = "&Expand All Groups";
            this.ExpandAllGroupsBarItem.Click += new System.EventHandler(this.ExpandAllGroupsBarItem_Click);
            // 
            // OpenItemsBarItem
            // 
            this.OpenItemsBarItem.ID = "&Open Items";
            this.OpenItemsBarItem.ShowMnemonicUnderlinesAlways = true;
            this.OpenItemsBarItem.Text = "&Open Items";
            // 
            // PrintfromCaptionBarItem
            // 
            this.PrintfromCaptionBarItem.ID = "&Print";
            this.PrintfromCaptionBarItem.ShowMnemonicUnderlinesAlways = true;
            this.PrintfromCaptionBarItem.Text = "&Print";
            // 
            // ForwardfromCaptionBarItem
            // 
            this.ForwardfromCaptionBarItem.Enabled = false;
            this.ForwardfromCaptionBarItem.ID = "&Forward Items";
            this.ForwardfromCaptionBarItem.ShowMnemonicUnderlinesAlways = true;
            this.ForwardfromCaptionBarItem.Text = "&Forward Items";
            // 
            // FollowUpParentBarItem
            // 
            this.FollowUpParentBarItem.ID = "Follow &Up";
            this.FollowUpParentBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.todayCaptionBarItem,
            this.tomoCaptionBarItem,
            this.thisweekfromCaptionBarItem,
            this.nextweekCaptionBarItem,
            this.nodateCaptionBarItem,
            this.customCaptionBarItem,
            this.addreminderCaptionBarItem,
            this.markcompletefromCaptionBarItem,
            this.clearflagCaptionBarItem,
            this.setBarItem});
            this.FollowUpParentBarItem.SeparatorIndices.AddRange(new int[] {
            6,
            9});
            this.FollowUpParentBarItem.ShowMnemonicUnderlinesAlways = true;
            this.FollowUpParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP;
            this.FollowUpParentBarItem.Text = "Follow &Up";
            // 
            // todayCaptionBarItem
            // 
            this.todayCaptionBarItem.ID = "&Red Flag";
            this.todayCaptionBarItem.ImageIndex = 1;
            this.todayCaptionBarItem.ShowMnemonicUnderlinesAlways = true;
            this.todayCaptionBarItem.Text = "&Today";
            this.todayCaptionBarItem.Click += new System.EventHandler(this.RedfromCaptionBarItem_Click);
            // 
            // tomoCaptionBarItem
            // 
            this.tomoCaptionBarItem.ID = "&Blue Flag";
            this.tomoCaptionBarItem.ImageIndex = 2;
            this.tomoCaptionBarItem.ShowMnemonicUnderlinesAlways = true;
            this.tomoCaptionBarItem.Text = "T&ommorrow";
            this.tomoCaptionBarItem.Click += new System.EventHandler(this.BluefromCaptionBarItem_Click);
            // 
            // thisweekfromCaptionBarItem
            // 
            this.thisweekfromCaptionBarItem.ID = "&Yellow Flag";
            this.thisweekfromCaptionBarItem.ImageIndex = 3;
            this.thisweekfromCaptionBarItem.ShowMnemonicUnderlinesAlways = true;
            this.thisweekfromCaptionBarItem.Text = "This &Week";
            this.thisweekfromCaptionBarItem.Click += new System.EventHandler(this.YellowfromCaptionBarItem_Click);
            // 
            // nextweekCaptionBarItem
            // 
            this.nextweekCaptionBarItem.ID = "&Green Flag";
            this.nextweekCaptionBarItem.ImageIndex = 4;
            this.nextweekCaptionBarItem.ShowMnemonicUnderlinesAlways = true;
            this.nextweekCaptionBarItem.Text = "&Next Week";
            this.nextweekCaptionBarItem.Click += new System.EventHandler(this.GreenfromCaptionBarItem_Click);
            // 
            // nodateCaptionBarItem
            // 
            this.nodateCaptionBarItem.ID = "&Orange Flag";
            this.nodateCaptionBarItem.ImageIndex = 5;
            this.nodateCaptionBarItem.ShowMnemonicUnderlinesAlways = true;
            this.nodateCaptionBarItem.Text = "No D&ate";
            this.nodateCaptionBarItem.Click += new System.EventHandler(this.OrangefromCaptionBarItem_Click);
            // 
            // customCaptionBarItem
            // 
            this.customCaptionBarItem.ID = "P&urple Flag";
            this.customCaptionBarItem.ImageIndex = 6;
            this.customCaptionBarItem.ShowMnemonicUnderlinesAlways = true;
            this.customCaptionBarItem.Text = "&Custom...";
            this.customCaptionBarItem.Click += new System.EventHandler(this.PurplefromCaptionBarItem_Click);
            // 
            // addreminderCaptionBarItem
            // 
            this.addreminderCaptionBarItem.ID = "Flag Complete";
            this.addreminderCaptionBarItem.ImageIndex = 7;
            this.addreminderCaptionBarItem.Text = "Add &Reminder...";
            this.addreminderCaptionBarItem.Click += new System.EventHandler(this.FlagCompletefromCaptionBarItem_Click);
            // 
            // markcompletefromCaptionBarItem
            // 
            this.markcompletefromCaptionBarItem.ID = "&Clear Flag";
            this.markcompletefromCaptionBarItem.ImageIndex = 8;
            this.markcompletefromCaptionBarItem.ShowMnemonicUnderlinesAlways = true;
            this.markcompletefromCaptionBarItem.Text = "&Mark Complete";
            this.markcompletefromCaptionBarItem.Click += new System.EventHandler(this.ClearFlagfromCaptionBarItem_Click);
            // 
            // clearflagCaptionBarItem
            // 
            this.clearflagCaptionBarItem.ID = "Cl&ear Flag";
            this.clearflagCaptionBarItem.Text = "Cl&ear Flag";
            // 
            // setBarItem
            // 
            this.setBarItem.ID = "Set &Quick Click...";
            this.setBarItem.Text = "Set &Quick Click...";
            // 
            // categoriesBarItem
            // 
            this.categoriesBarItem.ID = "Catego&ries...";
            this.categoriesBarItem.ShowMnemonicUnderlinesAlways = true;
            this.categoriesBarItem.Text = "Catego&ries...";
            // 
            // MarkAsReadfromCaptionBarItem
            // 
            this.MarkAsReadfromCaptionBarItem.ID = "Mar&k as Read";
            this.MarkAsReadfromCaptionBarItem.ShowMnemonicUnderlinesAlways = true;
            this.MarkAsReadfromCaptionBarItem.Text = "Mar&k as Read";
            this.MarkAsReadfromCaptionBarItem.Click += new System.EventHandler(this.MarkAsReadfromCaptionBarItem_Click);
            // 
            // MarkAsUnreadfromCaptionBarItem
            // 
            this.MarkAsUnreadfromCaptionBarItem.ID = "Mark As U&nread";
            this.MarkAsUnreadfromCaptionBarItem.ShowMnemonicUnderlinesAlways = true;
            this.MarkAsUnreadfromCaptionBarItem.Text = "Mark As U&nread";
            this.MarkAsUnreadfromCaptionBarItem.Click += new System.EventHandler(this.MarkAsUnreadfromCaptionBarItem_Click);
            // 
            // DeletefromCaptionBarItem
            // 
            this.DeletefromCaptionBarItem.ID = "D&elete";
            this.DeletefromCaptionBarItem.ShowMnemonicUnderlinesAlways = true;
            this.DeletefromCaptionBarItem.Text = "D&elete";
            // 
            // MovetoFolderfromCaptionBarItem
            // 
            this.MovetoFolderfromCaptionBarItem.ID = "&Move to Folder";
            this.MovetoFolderfromCaptionBarItem.ShowMnemonicUnderlinesAlways = true;
            this.MovetoFolderfromCaptionBarItem.Text = "&Move to Folder";
            // 
            // RecordPopupMenu
            // 
            this.RecordPopupMenu.ParentBarItem = this.RecordsParentBarItem;
            // 
            // RecordsParentBarItem
            // 
            this.RecordsParentBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.OpenfromRecordBarItem,
            this.PrintfromRecordBarItem,
            this.ReplyfromRecordBarItem,
            this.ReplyToAllfromRecordBarItem,
            this.ForwardfromRecordBarItem,
            this.RecordFollowUpParentBarItem,
            this.MarkfromRecordBarItem,
            this.CategoriesfromRecordBarItem,
            this.FindAllfromRecordparentBarItem,
            this.CreateRulefromRecordBarItem,
            this.JunkEmailsfromRecordParentBarItem,
            this.DeletefromRecordBarItem,
            this.MoveToFolderfromRecordBarItem,
            this.OptionsfromRecordBarItem});
            this.RecordsParentBarItem.SeparatorIndices.AddRange(new int[] {
            2,
            5,
            8,
            11,
            13});
            this.RecordsParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook;
            // 
            // OpenfromRecordBarItem
            // 
            this.OpenfromRecordBarItem.ID = "&Open";
            this.OpenfromRecordBarItem.ShowMnemonicUnderlinesAlways = true;
            this.OpenfromRecordBarItem.Text = "&Open";
            // 
            // PrintfromRecordBarItem
            // 
            this.PrintfromRecordBarItem.ID = "&Print";
            this.PrintfromRecordBarItem.ShowMnemonicUnderlinesAlways = true;
            this.PrintfromRecordBarItem.Text = "&Print";
            // 
            // ReplyfromRecordBarItem
            // 
            this.ReplyfromRecordBarItem.ID = "&Reply";
            this.ReplyfromRecordBarItem.ShowMnemonicUnderlinesAlways = true;
            this.ReplyfromRecordBarItem.Text = "&Reply";
            // 
            // ReplyToAllfromRecordBarItem
            // 
            this.ReplyToAllfromRecordBarItem.ID = "Reply to &All";
            this.ReplyToAllfromRecordBarItem.ShowMnemonicUnderlinesAlways = true;
            this.ReplyToAllfromRecordBarItem.Text = "Reply to &All";
            // 
            // ForwardfromRecordBarItem
            // 
            this.ForwardfromRecordBarItem.ID = "For&ward";
            this.ForwardfromRecordBarItem.ShowMnemonicUnderlinesAlways = true;
            this.ForwardfromRecordBarItem.Text = "For&ward";
            // 
            // RecordFollowUpParentBarItem
            // 
            this.RecordFollowUpParentBarItem.ID = "Follow &Up";
            this.RecordFollowUpParentBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.todayRecordBarItem,
            this.tomoRecordBarItem,
            this.thisweekRecordBarItem,
            this.nextweekRecordBarItem,
            this.nodateRecordBarItem,
            this.customRecordBarItem,
            this.addreminderRecordBarItem,
            this.markcompleteRecordItem,
            this.ClearFlagfromRecordBarItem,
            this.setRecordBarItem1});
            this.RecordFollowUpParentBarItem.SeparatorIndices.AddRange(new int[] {
            6,
            9});
            this.RecordFollowUpParentBarItem.ShowMnemonicUnderlinesAlways = true;
            this.RecordFollowUpParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook;
            this.RecordFollowUpParentBarItem.Text = "Follow &Up";
            // 
            // todayRecordBarItem
            // 
            this.todayRecordBarItem.ID = "&Red Flag";
            this.todayRecordBarItem.ImageIndex = 1;
            this.todayRecordBarItem.ShowMnemonicUnderlinesAlways = true;
            this.todayRecordBarItem.Text = "&Today";
            this.todayRecordBarItem.Click += new System.EventHandler(this.redFlagBarItem_Click);
            // 
            // tomoRecordBarItem
            // 
            this.tomoRecordBarItem.ID = "&Blue Flag";
            this.tomoRecordBarItem.ImageIndex = 2;
            this.tomoRecordBarItem.ShowMnemonicUnderlinesAlways = true;
            this.tomoRecordBarItem.Text = "T&ommorrow";
            this.tomoRecordBarItem.Click += new System.EventHandler(this.blueFlagBarItem_Click);
            // 
            // thisweekRecordBarItem
            // 
            this.thisweekRecordBarItem.ID = "&Yellow Flag";
            this.thisweekRecordBarItem.ImageIndex = 3;
            this.thisweekRecordBarItem.ShowMnemonicUnderlinesAlways = true;
            this.thisweekRecordBarItem.Text = "This &Week";
            this.thisweekRecordBarItem.Click += new System.EventHandler(this.yellowFlagBarItem_Click);
            // 
            // nextweekRecordBarItem
            // 
            this.nextweekRecordBarItem.ID = "&Green Flag";
            this.nextweekRecordBarItem.ImageIndex = 4;
            this.nextweekRecordBarItem.ShowMnemonicUnderlinesAlways = true;
            this.nextweekRecordBarItem.Text = "&Next Week";
            this.nextweekRecordBarItem.Click += new System.EventHandler(this.greenFlagBarItem_Click);
            // 
            // nodateRecordBarItem
            // 
            this.nodateRecordBarItem.ID = "&Orange Flag";
            this.nodateRecordBarItem.ImageIndex = 5;
            this.nodateRecordBarItem.ShowMnemonicUnderlinesAlways = true;
            this.nodateRecordBarItem.Text = "No D&ate";
            this.nodateRecordBarItem.Click += new System.EventHandler(this.orangeFlagBarItem_Click);
            // 
            // customRecordBarItem
            // 
            this.customRecordBarItem.ID = "&Purple Flag";
            this.customRecordBarItem.ImageIndex = 6;
            this.customRecordBarItem.ShowMnemonicUnderlinesAlways = true;
            this.customRecordBarItem.Text = "&Custom...";
            this.customRecordBarItem.Click += new System.EventHandler(this.purpleFlagBarItem_Click);
            // 
            // addreminderRecordBarItem
            // 
            this.addreminderRecordBarItem.ID = "Flag Com&plete";
            this.addreminderRecordBarItem.ImageIndex = 7;
            this.addreminderRecordBarItem.ShowMnemonicUnderlinesAlways = true;
            this.addreminderRecordBarItem.Text = "Add &Reminder...";
            this.addreminderRecordBarItem.Click += new System.EventHandler(this.flagCompleteBarItem_Click);
            // 
            // markcompleteRecordItem
            // 
            this.markcompleteRecordItem.ID = "&Add Reminder...";
            this.markcompleteRecordItem.ImageIndex = 8;
            this.markcompleteRecordItem.ShowMnemonicUnderlinesAlways = true;
            this.markcompleteRecordItem.Text = "&Mark Complete";
            // 
            // ClearFlagfromRecordBarItem
            // 
            this.ClearFlagfromRecordBarItem.ID = "&Clear Flag";
            this.ClearFlagfromRecordBarItem.ShowMnemonicUnderlinesAlways = true;
            this.ClearFlagfromRecordBarItem.Text = "Cl&ear Flag";
            this.ClearFlagfromRecordBarItem.Click += new System.EventHandler(this.clearFlagBarItem_Click);
            // 
            // setRecordBarItem1
            // 
            this.setRecordBarItem1.ID = "Set &Quick Click...";
            this.setRecordBarItem1.Text = "Set &Quick Click...";
            // 
            // MarkfromRecordBarItem
            // 
            this.MarkfromRecordBarItem.ID = "Mark as U&nread";
            this.MarkfromRecordBarItem.ShowMnemonicUnderlinesAlways = true;
            this.MarkfromRecordBarItem.Text = "Mark as U&nread";
            this.MarkfromRecordBarItem.Click += new System.EventHandler(this.MarkfromRecordBarItem_Click);
            // 
            // CategoriesfromRecordBarItem
            // 
            this.CategoriesfromRecordBarItem.ID = "Catego&ries...";
            this.CategoriesfromRecordBarItem.ShowMnemonicUnderlinesAlways = true;
            this.CategoriesfromRecordBarItem.Text = "Catego&ries...";
            // 
            // FindAllfromRecordparentBarItem
            // 
            this.FindAllfromRecordparentBarItem.ID = "Find &All";
            this.FindAllfromRecordparentBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.RelatedMessagesBarItem,
            this.MessagesfromsenderBarItem});
            this.FindAllfromRecordparentBarItem.ShowMnemonicUnderlinesAlways = true;
            this.FindAllfromRecordparentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook;
            this.FindAllfromRecordparentBarItem.Text = "Find &All";
            // 
            // RelatedMessagesBarItem
            // 
            this.RelatedMessagesBarItem.ID = "&Related Messages";
            this.RelatedMessagesBarItem.ShowMnemonicUnderlinesAlways = true;
            this.RelatedMessagesBarItem.Text = "&Related Messages";
            // 
            // MessagesfromsenderBarItem
            // 
            this.MessagesfromsenderBarItem.ID = "&Messages from Sender";
            this.MessagesfromsenderBarItem.ShowMnemonicUnderlinesAlways = true;
            this.MessagesfromsenderBarItem.Text = "&Messages from Sender";
            // 
            // CreateRulefromRecordBarItem
            // 
            this.CreateRulefromRecordBarItem.ID = "&Create Rule...";
            this.CreateRulefromRecordBarItem.ShowMnemonicUnderlinesAlways = true;
            this.CreateRulefromRecordBarItem.Text = "&Create Rule...";
            // 
            // JunkEmailsfromRecordParentBarItem
            // 
            this.JunkEmailsfromRecordParentBarItem.ID = "&Junk E-mail";
            this.JunkEmailsfromRecordParentBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.AddSendertoBlockedSendersListBarItem,
            this.AddSendertoSafeSendersListBarItem,
            this.AddSendersDomaintoSafeSendersListBarItem,
            this.AddRecipienttoSafeRecipientsListBarItem,
            this.MarkasNotJunkBarItem,
            this.JunkEmailOptionsBarItem});
            this.JunkEmailsfromRecordParentBarItem.SeparatorIndices.AddRange(new int[] {
            4,
            5});
            this.JunkEmailsfromRecordParentBarItem.ShowMnemonicUnderlinesAlways = true;
            this.JunkEmailsfromRecordParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook;
            this.JunkEmailsfromRecordParentBarItem.Text = "&Junk E-mail";
            // 
            // AddSendertoBlockedSendersListBarItem
            // 
            this.AddSendertoBlockedSendersListBarItem.ID = "Add Sender to &Blocked Senders List";
            this.AddSendertoBlockedSendersListBarItem.ShowMnemonicUnderlinesAlways = true;
            this.AddSendertoBlockedSendersListBarItem.Text = "Add Sender to &Blocked Senders List";
            // 
            // AddSendertoSafeSendersListBarItem
            // 
            this.AddSendertoSafeSendersListBarItem.ID = "Add &Sender to Safe Senders List";
            this.AddSendertoSafeSendersListBarItem.ShowMnemonicUnderlinesAlways = true;
            this.AddSendertoSafeSendersListBarItem.Text = "Add &Sender to Safe Senders List";
            // 
            // AddSendersDomaintoSafeSendersListBarItem
            // 
            this.AddSendersDomaintoSafeSendersListBarItem.ID = "Add Sender\'s Domain (@example.com) to Safe Senders List";
            this.AddSendersDomaintoSafeSendersListBarItem.ShowMnemonicUnderlinesAlways = true;
            this.AddSendersDomaintoSafeSendersListBarItem.Text = "Add Sender\'s Domain (@example.com) to Safe Senders List";
            // 
            // AddRecipienttoSafeRecipientsListBarItem
            // 
            this.AddRecipienttoSafeRecipientsListBarItem.ID = "Add &Recipient to Safe Recipients List";
            this.AddRecipienttoSafeRecipientsListBarItem.ShowMnemonicUnderlinesAlways = true;
            this.AddRecipienttoSafeRecipientsListBarItem.Text = "Add &Recipient to Safe Recipients List";
            // 
            // MarkasNotJunkBarItem
            // 
            this.MarkasNotJunkBarItem.ID = "&Mark as Not Junk";
            this.MarkasNotJunkBarItem.ShowMnemonicUnderlinesAlways = true;
            this.MarkasNotJunkBarItem.Text = "&Mark as Not Junk";
            // 
            // JunkEmailOptionsBarItem
            // 
            this.JunkEmailOptionsBarItem.ID = "&Junk Email Options";
            this.JunkEmailOptionsBarItem.ShowMnemonicUnderlinesAlways = true;
            this.JunkEmailOptionsBarItem.Text = "&Junk Email Options";
            // 
            // DeletefromRecordBarItem
            // 
            this.DeletefromRecordBarItem.ID = "&Delete";
            this.DeletefromRecordBarItem.ShowMnemonicUnderlinesAlways = true;
            this.DeletefromRecordBarItem.Text = "&Delete";
            this.DeletefromRecordBarItem.Click += new System.EventHandler(this.DeletefromRecordBarItem_Click);
            // 
            // MoveToFolderfromRecordBarItem
            // 
            this.MoveToFolderfromRecordBarItem.ID = "&Move to Folder...";
            this.MoveToFolderfromRecordBarItem.ShowMnemonicUnderlinesAlways = true;
            this.MoveToFolderfromRecordBarItem.Text = "&Move to Folder...";
            // 
            // OptionsfromRecordBarItem
            // 
            this.OptionsfromRecordBarItem.ID = "O&ptions";
            this.OptionsfromRecordBarItem.ShowMnemonicUnderlinesAlways = true;
            this.OptionsfromRecordBarItem.Text = "O&ptions";
            // 
            // RedAsDefaultfromRecordBarItem
            // 
            this.RedAsDefaultfromRecordBarItem.ID = "&Red as Default Flag";
            this.RedAsDefaultfromRecordBarItem.ImageIndex = 1;
            this.RedAsDefaultfromRecordBarItem.ShowMnemonicUnderlinesAlways = true;
            this.RedAsDefaultfromRecordBarItem.Text = "&Red as Default Flag";
            this.RedAsDefaultfromRecordBarItem.Click += new System.EventHandler(this.redAsDefaultBarItem_Click);
            // 
            // BlueasDefaultfromRecordBarItem
            // 
            this.BlueasDefaultfromRecordBarItem.ID = "&Blue as Default Flag";
            this.BlueasDefaultfromRecordBarItem.ImageIndex = 2;
            this.BlueasDefaultfromRecordBarItem.ShowMnemonicUnderlinesAlways = true;
            this.BlueasDefaultfromRecordBarItem.Text = "&Blue as Default Flag";
            this.BlueasDefaultfromRecordBarItem.Click += new System.EventHandler(this.blueAsDefaultBarItem_Click);
            // 
            // YellowasDefaultfromRecordBarItem
            // 
            this.YellowasDefaultfromRecordBarItem.ID = "&Yellow as Default Flag";
            this.YellowasDefaultfromRecordBarItem.ImageIndex = 3;
            this.YellowasDefaultfromRecordBarItem.ShowMnemonicUnderlinesAlways = true;
            this.YellowasDefaultfromRecordBarItem.Text = "&Yellow as Default Flag";
            this.YellowasDefaultfromRecordBarItem.Click += new System.EventHandler(this.yellowAsDefaultBarItem_Click);
            // 
            // GreenasDefaultfromRecordBarItem
            // 
            this.GreenasDefaultfromRecordBarItem.ID = "&Green as Default Flag";
            this.GreenasDefaultfromRecordBarItem.ImageIndex = 4;
            this.GreenasDefaultfromRecordBarItem.ShowMnemonicUnderlinesAlways = true;
            this.GreenasDefaultfromRecordBarItem.Text = "&Green as Default Flag";
            this.GreenasDefaultfromRecordBarItem.Click += new System.EventHandler(this.greenAsDefaultBarItem_Click);
            // 
            // OrangeasDefaultfromRecordBarItem
            // 
            this.OrangeasDefaultfromRecordBarItem.ID = "&Orange as Default Flag";
            this.OrangeasDefaultfromRecordBarItem.ImageIndex = 5;
            this.OrangeasDefaultfromRecordBarItem.ShowMnemonicUnderlinesAlways = true;
            this.OrangeasDefaultfromRecordBarItem.Text = "&Orange as Default Flag";
            this.OrangeasDefaultfromRecordBarItem.Click += new System.EventHandler(this.orangeAsDefaultBarItem_Click);
            // 
            // PurpleasDefaultfromRecordBarItem
            // 
            this.PurpleasDefaultfromRecordBarItem.ID = "P&urple as Default Flag";
            this.PurpleasDefaultfromRecordBarItem.ImageIndex = 6;
            this.PurpleasDefaultfromRecordBarItem.ShowMnemonicUnderlinesAlways = true;
            this.PurpleasDefaultfromRecordBarItem.Text = "P&urple as Default Flag";
            this.PurpleasDefaultfromRecordBarItem.Click += new System.EventHandler(this.purpleAsDefaultBarItem_Click);
            // 
            // categoryPopUpMenu
            // 
            this.categoryPopUpMenu.ParentBarItem = this.categoryParentBarItem;
            // 
            // categoryParentBarItem
            // 
            this.categoryParentBarItem.ImageList = this.imageList1;
            this.categoryParentBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.clearallcategBarItem,
            this.categsearchBarItem,
            this.redcategBarItem,
            this.blueBarItem,
            this.greenBarItem,
            this.orangeBarItem,
            this.purpleBarItem,
            this.yellowBarItem,
            this.allcategBarItem,
            this.setcategBarItem});
            this.categoryParentBarItem.SeparatorIndices.AddRange(new int[] {
            1,
            2,
            9});
            this.categoryParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "red_square.gif");
            this.imageList1.Images.SetKeyName(1, "blue_square.gif");
            this.imageList1.Images.SetKeyName(2, "green_square.gif");
            this.imageList1.Images.SetKeyName(3, "orange_square.gif");
            this.imageList1.Images.SetKeyName(4, "violet_square.gif");
            this.imageList1.Images.SetKeyName(5, "yellow_square.gif");
            this.imageList1.Images.SetKeyName(6, "square.gif");
            // 
            // clearallcategBarItem
            // 
            this.clearallcategBarItem.ID = "&Clear All Categories";
            this.clearallcategBarItem.Text = "&Clear All Categories";
            // 
            // categsearchBarItem
            // 
            this.categsearchBarItem.ID = "Category &Search Folder...";
            this.categsearchBarItem.Text = "Category &Search Folder...";
            // 
            // redcategBarItem
            // 
            this.redcategBarItem.ID = "Red Category";
            this.redcategBarItem.ImageIndex = 0;
            this.redcategBarItem.ImageList = this.imageList1;
            this.redcategBarItem.Text = "Red Category";
            this.redcategBarItem.Click += new System.EventHandler(this.redcategBarItem_Click);
            // 
            // blueBarItem
            // 
            this.blueBarItem.ID = "Blue Category";
            this.blueBarItem.ImageIndex = 1;
            this.blueBarItem.ImageList = this.imageList1;
            this.blueBarItem.Text = "Blue Category";
            this.blueBarItem.Click += new System.EventHandler(this.blueBarItem_Click);
            // 
            // greenBarItem
            // 
            this.greenBarItem.ID = "Blue Category";
            this.greenBarItem.ImageIndex = 2;
            this.greenBarItem.ImageList = this.imageList1;
            this.greenBarItem.Text = "Green Category";
            this.greenBarItem.Click += new System.EventHandler(this.greenBarItem_Click);
            // 
            // orangeBarItem
            // 
            this.orangeBarItem.ID = "Orange Category";
            this.orangeBarItem.ImageIndex = 3;
            this.orangeBarItem.ImageList = this.imageList1;
            this.orangeBarItem.Text = "Orange Category";
            this.orangeBarItem.Click += new System.EventHandler(this.orangeBarItem_Click);
            // 
            // purpleBarItem
            // 
            this.purpleBarItem.ID = "Purple Category";
            this.purpleBarItem.ImageIndex = 4;
            this.purpleBarItem.ImageList = this.imageList1;
            this.purpleBarItem.Text = "Purple Category";
            this.purpleBarItem.Click += new System.EventHandler(this.purpleBarItem_Click);
            // 
            // yellowBarItem
            // 
            this.yellowBarItem.ID = "Yellow Category";
            this.yellowBarItem.ImageIndex = 5;
            this.yellowBarItem.ImageList = this.imageList1;
            this.yellowBarItem.Text = "Yellow Category";
            this.yellowBarItem.Click += new System.EventHandler(this.yellowBarItem_Click);
            // 
            // allcategBarItem
            // 
            this.allcategBarItem.ID = "&All Categories";
            this.allcategBarItem.ImageIndex = 6;
            this.allcategBarItem.ImageList = this.imageList1;
            this.allcategBarItem.Text = "&All Categories";
            // 
            // setcategBarItem
            // 
            this.setcategBarItem.ID = "Set &Quick Click...";
            this.setcategBarItem.Text = "Set &Quick Click...";
            // 
            // GroupingPanel
            // 
            this.Controls.Add(this.gridGroupingControl1);
            this.Size = new System.Drawing.Size(688, 353);
            this.Text = "GroupingPanel";
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        # region Class helper functions

        /// <summary>
        /// CreateColumnSetView creates columns columnSetDescriptor to implement
        /// the ColumnSet view or Card view while narrowing the grid..
        /// </summary>
        /// <param name="rows">Number of required rows in the ColumnSet or card view </param>
        public void CreateColumnSetView(int rows)
        {
            //There are four column sets needs to be created
            // Wherein  2nd column set appends dynamically the extra layers of column needed

            CreateFirstColumnSet("First", rows);
            CreateSecondColumnSet("Second", rows);
            CreateThirdColumnSet("Third", rows);
            CreateFourthColumnSet("Fourth", rows);
            OtherCols();
        }

        /// <summary>
        /// Dynamically creates column spans for this column set
        /// </summary>
        /// <param name="name">The name of the column set</param>
        /// <param name="rows">Number of required rows in the ColumnSet or card view</param>
        private void CreateFirstColumnSet(string name, int rows)
        {
            //The mails column is the first column set and is mandatory.. 
            GridColumnSetDescriptor csd1 = new GridColumnSetDescriptor(name); // Mails Icon column
            string range = RangeGenarator(0, 0, rows - 1, 0);
            csd1.ColumnSpans.Add(new GridColumnSpanDescriptor("mails", range));
            this.gridGroupingControl1.TableDescriptor.Columns["mails"].Width = 24;
            this.gridGroupingControl1.TableDescriptor.ColumnSets.Add(csd1);
        }
        /// <summary>
        /// Dynamically creates column spans for this column set
        /// </summary>
        /// <param name="name">The name of the column set</param>
        /// <param name="rows">Number of required rows in the ColumnSet or card view</param>
        private void CreateSecondColumnSet(string name, int rows)
        {
            GridColumnSetDescriptor csd2 = new GridColumnSetDescriptor(name);

            int i = 0; //counts the added columns to the column set 
            foreach (GridColumnDescriptor cd in this.gridGroupingControl1.TableDescriptor.Columns)
            {
                string ColumnName = cd.Name;
                //this.gridGroupingControl1.TableDescriptor.VisibleColumns[i].Name;
                if (i == rows)
                    break;
                // Should have been added in the first column set
                if (ColumnName == "mails")
                    continue;

                // Reserved for 3rd column set..
                if (ColumnName == "Received" || ColumnName == "Attachment" || ColumnName == "Priority")
                    continue;

                string range = RangeGenarator(i, 0, i, 0);
                csd2.ColumnSpans.Add(new GridColumnSpanDescriptor(cd.Name, range));
                i++;
            }

            this.gridGroupingControl1.TableDescriptor.ColumnSets.Add(csd2);

            //Make a note of the column at the first row, second row and last row
            columnAtTop = csd2.ColumnSpans[0].Name;
            secondRowColumn = csd2.ColumnSpans[1].Name;
            columnAtBottom = csd2.ColumnSpans[csd2.ColumnSpans.Count - 1].Name;
        }

        /// <summary>
        /// Dynamically creates column spans for this column set
        /// </summary>
        /// <param name="name">The name of the column set</param>
        /// <param name="rows">Number of required rows in the ColumnSet or card view</param>
        private void CreateThirdColumnSet(string name, int rows)
        {
            GridColumnSetDescriptor csd3 = new GridColumnSetDescriptor(name);

            // If Received is not taken into account then Provide a dummy column to have the column set view undisturbed..
            string range = RangeGenarator(0, 0, 0, 1);
            if (this.gridGroupingControl1.TableDescriptor.Columns.Contains("Received"))
                csd3.ColumnSpans.Add(new GridColumnSpanDescriptor("Received", range));
            else
            {
                if (!this.gridGroupingControl1.TableDescriptor.Columns.Contains("DummyCol"))
                    this.gridGroupingControl1.TableDescriptor.Columns.Add("DummyCol");

                csd3.ColumnSpans.Add(new GridColumnSpanDescriptor("DummyCol", range));
            }
            range = RangeGenarator(1, 0, rows - 1, 0);
            csd3.ColumnSpans.Add(new GridColumnSpanDescriptor("Priority", range));
            this.gridGroupingControl1.TableDescriptor.Columns["Priority"].Width = 68;
            range = RangeGenarator(1, 1, rows - 1, 1);
            csd3.ColumnSpans.Add(new GridColumnSpanDescriptor("Attachment", range));
            this.gridGroupingControl1.TableDescriptor.ColumnSets.Add(csd3);
            this.gridGroupingControl1.TableDescriptor.Columns["Attachment"].Width = 12;
        }

        /// <summary>
        /// Dynamically creates column spans for this column set
        /// </summary>
        /// <param name="name">The name of the column set</param>
        /// <param name="rows">Number of required rows in the ColumnSet or card view</param>
        private void CreateFourthColumnSet(string name, int rows)
        {
            // flag column (Optional)
            GridColumnSetDescriptor csd4 = new GridColumnSetDescriptor(name);
            string range = RangeGenarator(0, 0, rows - 1, 1);
            if (this.gridGroupingControl1.TableDescriptor.Columns.Contains("flag"))
            {
                csd4.ColumnSpans.Add(new GridColumnSpanDescriptor("flag", range));
                this.gridGroupingControl1.TableDescriptor.Columns["flag"].Width = 24;
                this.gridGroupingControl1.TableDescriptor.ColumnSets.Add(csd4);
            }
        }

        private Hashtable Ht_ColWidth;
        private void OtherCols()
        {
            Ht_ColWidth = new Hashtable();
            bool columnPresent;
            //for each columns that are not in the column set are to be reduced to 0..
            foreach (GridColumnDescriptor cd in this.gridGroupingControl1.TableDescriptor.Columns)
            {
                columnPresent = false;
                foreach (GridColumnSetDescriptor csd in this.gridGroupingControl1.TableDescriptor.ColumnSets)
                {
                    columnPresent |= csd.ColumnSpans.Contains(cd.Name);
                }
                if (!columnPresent)
                {
                    Ht_ColWidth.Add(cd.Name, cd.Width);
                    cd.Width = 0;
                }
            }
        }

        private void RollBackSizeChanges()
        {
            this.gridGroupingControl1.TableDescriptor.Columns["Priority"].Width = 15;
            this.gridGroupingControl1.TableDescriptor.Columns["Attachment"].Width = 15;
            this.gridGroupingControl1.TableDescriptor.Columns["flag"].Width = 15;
            this.gridGroupingControl1.TableDescriptor.Columns["mails"].Width = 15;

            foreach (String keys in Ht_ColWidth.Keys)
                this.gridGroupingControl1.TableDescriptor.Columns[keys].Width = (int)Ht_ColWidth[keys];
        }
        /// <summary>
        /// Creates ranges when CreateColumnSetView requires
        /// </summary>
        /// <param name="top"></param>
        /// <param name="left"></param>
        /// <param name="bottom"></param>
        /// <param name="right"></param>
        /// <returns>range in string format</returns>
        private string RangeGenarator(int top, int left, int bottom, int right)
        {
            return GridRangeInfo.Auto(top, left, bottom, right).ToString();
        }

        /// <summary>
        /// Controls the display of the custom section..
        /// </summary>
        /// <param name="value">true to enable, false othervise</param>
        public void EnableCustomSection(bool value)
        {
            // Enable the custom section
            GroupingChildTable.SectionRequired = value;
            this.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("Fake");
            this.gridGroupingControl1.TableDescriptor.GroupedColumns.Remove("Fake");
        }

        public void Close()
        {
            //			XmlTextWriter xw = new XmlTextWriter("GridSchema.Xml", System.Text.Encoding.UTF8);
            //			this.gridGroupingControl1.WriteXmlSchema(xw);
            //			xw.Close();
        }

        /// <summary>
        /// The total col width of the grid is known
        /// </summary>
        /// <returns></returns>
        private int GetTotalColumnWidth()
        {
            int actualSize = 0;
            foreach (GridColumnDescriptor vcd in this.gridGroupingControl1.TableDescriptor.Columns)
            {
                if (vcd.Name == "flag" && vcd.Name == "mails")//fixed cols
                {
                    FixedColumnWidths += vcd.Width;
                }
                else
                    actualSize += vcd.Width;
            }
            return actualSize;
        }
        private int FixedColumnWidths;


        private int ComputePeriodReceived(int dateReceivedInTotalDays)
        {
            DateTime TodaysDate = DateTime.Today;
            int age = dateReceivedInTotalDays;
            int nDay = (int)TodaysDate.DayOfWeek;
            int noOfDaysInWeekSoFar = nDay + 1;
            string val = " ";
            if (age == 0)
                return Convert.ToInt32(days.Today);
            else if (age == 1)
                return Convert.ToInt32(days.Yesterday);
            else if (age < noOfDaysInWeekSoFar)
                val = GetDayOfWeek(nDay - age);
            switch (val)
            {
                case "Sunday":
                    return Convert.ToInt32(days.Sunday);
                case "Monday":
                    return Convert.ToInt32(days.Monday);
                case "Tuesday":
                    return Convert.ToInt32(days.Tuesday);
                case "Wednesday":
                    return Convert.ToInt32(days.Wednesday);
                case "Thursday":
                    return Convert.ToInt32(days.Thursday);
            }

            int ageInWeeks = (age - noOfDaysInWeekSoFar) / 7;
            switch (ageInWeeks)
            {
                case 0:
                case 1:
                    return Convert.ToInt32(days.LastWeek);
                case 2:
                    return Convert.ToInt32(days.TwoWeeksAgo);
                case 3:
                    return Convert.ToInt32(days.ThreeWeeksAgo);
            }
            if (ageInWeeks < 5)
                return Convert.ToInt32(days.LastMonth);
            return Convert.ToInt32(days.Older);
        }


        private string GetDayOfWeek(int intDay)
        {
            return ((DayOfWeek)intDay).ToString();
        }

        private void ShowGroupDropArea()
        {
            if (this.barItem_ShowInGroups.Checked)
                this.gridGroupingControl1.ShowGroupDropArea = true;
            else
            {
                this.gridGroupingControl1.ShowGroupDropArea = false;
                this.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear();
            }
        }
        private void ClearChecks(ParentBarItem parentBarItem)
        {
            foreach (BarItem barItem in parentBarItem.Items)
            {
                string name = barItem.Text;
                if (parentBarItem.IsGroupBeginning(barItem))
                    return;
                if (barItem.Checked)
                {
                    barItem.Checked = false;
                    return;
                }
            }
        }

        /// <summary>
        /// Expands the group if collapsed..
        /// </summary>
        public void ExpandthisGroup()
        {
            // from the row of the nesteddispaly elemnt 
            Element el = this.gridGroupingControl1.Table.GetInnerMostCurrentElement();
            int row = this.gridGroupingControl1.Table.NestedDisplayElements.IndexOf(el);
            if (this.gridGroupingControl1.Table.NestedDisplayElements[row].IsCaption())
            {
                GridCaptionRow crow = (GridCaptionRow)el;
                Group gp = crow.ParentGroup;
                gp.IsExpanded = true;
            }
        }

        /// <summary>
        /// Sets the required flag, also selects the group..
        /// </summary>
        /// <param name="thisFlag">flag identifier from flags enum</param>
        private void ApplythisGroupwithFlag(int thisFlag)
        {
            ExpandthisGroup();
            // from the row of the current nesteddispaly elemnt 
            Element el = this.gridGroupingControl1.Table.GetInnerMostCurrentElement();
            int row = this.gridGroupingControl1.Table.NestedDisplayElements.IndexOf(el);
            int rows = ++row;
            // enumerate each rows and clear the flag
            for (; rows < this.gridGroupingControl1.Table.NestedDisplayElements.Count; rows++)
            {
                // check till the next available caption element..
                if (this.gridGroupingControl1.Table.NestedDisplayElements[rows].IsCaption())
                    break;
                else
                {
                    this.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Row(rows));
                    Record r = this.gridGroupingControl1.Table.NestedDisplayElements[rows].GetRecord();
                    r.SetValue("flag", thisFlag);
                    //fl[r.Id] = thisFlag;
                }
            }
        }

        /// <summary>
        /// Sets the required mark into the ReadState column..
        /// So as to show read or unread
        /// </summary>
        /// <param name="mark">read as 1 or unread as 0</param>
        private void ApplythisGroupwithReadState(int mark)
        {
            ExpandthisGroup();
            // from the row of the nesteddispaly elemnt 
            Element el = this.gridGroupingControl1.Table.GetInnerMostCurrentElement();
            int row = this.gridGroupingControl1.Table.NestedDisplayElements.IndexOf(el);
            int rows = ++row;
            // enumerate each rows and clear the flag
            for (; rows < this.gridGroupingControl1.Table.NestedDisplayElements.Count; rows++)
            {
                // check till the next available caption element..
                if (this.gridGroupingControl1.Table.NestedDisplayElements[rows].IsCaption())
                    break;
                else
                {
                    this.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Row(rows));
                    Record r = this.gridGroupingControl1.Table.NestedDisplayElements[rows].GetRecord();
                    r.SetValue("ReadState", mark);
                }
            }
        }
        # endregion

        
        # region event Handlers

        # region GridGroupingControl event handlers
        private int keyId = -1;
        /// <summary>
        /// Queries the column width as required
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableModel_QueryColWidth(object sender, GridRowColSizeEventArgs e)
        {
            GridTableModel gridModel = sender as GridTableModel;
            if (NormalView)
            {
                // proportional sizing of the normal view
                float factor = 0f;
                int availableWidth = this.gridGroupingControl1.Width - (FixedColumnWidths + gridModel.GetColumnIndentCount() * this.gridGroupingControl1.TableOptions.IndentWidth);
                if (this.gridGroupingControl1.TableControl.VScroll)
                    factor = (float)(availableWidth - SystemInformation.VerticalScrollBarWidth) / GetTotalColumnWidth();
                else
                    factor = (float)availableWidth / GetTotalColumnWidth();
                if (e.Index >= gridModel.GetColumnIndentCount() && e.Index != keyId)
                {
                    e.Size = Convert.ToInt32(Math.Round((e.Size + 2) * factor));
                }
                e.Handled = true;
            }
            else // column set view
            {
                if (e.Index == 2 + (gridModel.GetColumnIndentCount() - 1)) // resize 2nd column only
                {
                    e.Size = this.gridGroupingControl1.Width - this.gridGroupingControl1.TableDescriptor.Columns["mails"].Width;
                    if (this.gridGroupingControl1.TableDescriptor.Columns.Contains("Received"))
                        e.Size -= this.gridGroupingControl1.TableDescriptor.Columns["Received"].Width;
                    else
                        e.Size -= this.gridGroupingControl1.TableDescriptor.Columns["DummyCol"].Width;
                    if (this.gridGroupingControl1.TableDescriptor.Columns.Contains("flag"))
                        e.Size -= this.gridGroupingControl1.TableDescriptor.Columns["flag"].Width;
                    if (this.gridGroupingControl1.TableControl.VScroll)
                        e.Size -= SystemInformation.VerticalScrollBarWidth;
                    secondColumnSetSize = e.Size;

                    e.Handled = true;
                }
            }
        }

        private void TableModel_ColWidthsChanging(object sender, GridRowColSizeChangingEventArgs e)
        {
            GridTableModel gridModel = sender as GridTableModel;

            if (this.gridGroupingControl1.TableDescriptor.Columns[e.From - gridModel.GetColumnIndentCount()].Name == "mails" ||
                this.gridGroupingControl1.TableDescriptor.Columns[e.From - gridModel.GetColumnIndentCount()].Name == "flag" ||
                this.gridGroupingControl1.TableDescriptor.Columns[e.From - gridModel.GetColumnIndentCount()].Name == "ReadState" ||
                this.gridGroupingControl1.TableDescriptor.Columns[e.From - gridModel.GetColumnIndentCount()].Name == "Priority" ||
                this.gridGroupingControl1.TableDescriptor.Columns[e.From - gridModel.GetColumnIndentCount()].Name == "Attachment")
            {
                e.Cancel = true;
                return;
            }
            keyId = e.From;
        }

        private void TableModel_ColWidthsChanged(object sender, GridRowColSizeChangedEventArgs e)
        {
            keyId = -1;
        }

        private void gridGroupingControl1_SizeChanged(object sender, EventArgs e)
        {
            if (this.gridGroupingControl1.Width > 400)
                this.NormalView = true;
            else
                this.NormalView = false;
        }

        private Color UsedColors(int index)
        {
            switch (index)
            {
                case 0:
                    return SystemColors.ControlLightLight;

                case 1:
                    return Color.FromArgb(80, 255, 48, 0);

                case 2:
                    return Color.FromArgb(80, Color.DarkBlue);

                case 3:
                    return Color.FromArgb(80, 255, 207, 49);

                case 4:
                    return Color.FromArgb(80, 0, 255, 0);

                case 5:
                    return Color.FromArgb(80, Color.Orange);

                case 6:
                    return Color.FromArgb(80, Color.Purple);

                default:
                    return Color.FromArgb(80, Color.White);
            }
        }

        private void gridGroupingControl1_QueryCellStyleInfo(object sender, GridTableCellStyleInfoEventArgs e)
        {
            if (this.gridGroupingControl1.TableOptions.ShowRecordPreviewRow)
            {
                if (e.TableCellIdentity.TableCellType == GridTableCellType.RecordPreviewCell)
                {
                    GridRecord record = e.TableCellIdentity.DisplayElement.ParentRecord as GridRecord;
                    if (record != null)
                    {
                        e.Style.TextColor = System.Drawing.Color.Black;
                        e.Style.CellValue = record.GetValue("Content").ToString().Trim();
                        e.Style.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, Color.FromArgb(Form1.r, Form1.g, Form1.b), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
                    }
                    else
                    {
                        e.Style.CellValue = " ";
                    }
                    e.Style.Trimming = StringTrimming.EllipsisCharacter;
                }
            }
            if (e.Style.CellType == "ColumnHeaderCell")
            {
                e.Style.Borders.Top = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(Form1.r, Form1.g, Form1.b), GridBorderWeight.Thin);
                e.Style.Borders.Bottom = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(Form1.r, Form1.g, Form1.b), GridBorderWeight.Thin);
                e.Style.CellTipText = e.Style.Text;
                e.Style.HorizontalAlignment = GridHorizontalAlignment.Left;
                e.Style.Interior = new BrushInfo(GradientStyle.Vertical, HeaderForeColor, HeaderBackColor);
            }
            if (e.Style != null && e.TableCellIdentity.Column != null)
            {
                e.Style.Font.Facename = "Arial";
                e.Style.Font.Size = 8f;
                e.Style.Trimming = StringTrimming.EllipsisCharacter;
                e.Style.ReadOnly = true;
                if (e.TableCellIdentity.Column.Name == "Received")
                    e.Style.ShowButtons = GridShowButtons.Hide;

                if (!this.NormalView)
                {
                    e.Style.Borders.Bottom = new GridBorder(GridBorderStyle.None);
                    if (e.TableCellIdentity.Column.Name == "mails" || e.TableCellIdentity.Column.Name == "flag"
                        || e.TableCellIdentity.Column.Name == this.ColumnAtBottom || e.TableCellIdentity.Column.Name == "Attachment"
                        || e.TableCellIdentity.Column.Name == "Priority")
                        e.Style.Borders.Bottom = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(Form1.r, Form1.g, Form1.b), GridBorderWeight.ExtraThin);
                }
                if (!this.NormalView && e.TableCellIdentity.Column.Name != this.columnAtTop &&
                    e.TableCellIdentity.Column.Name != "Received")
                    e.Style.TextColor = Color.Gray;

                if (e.TableCellIdentity.Column.Name == "flag")
                {
                    if (e.Style.CellType != "ColumnHeaderCell")
                    {
                        e.Style.CellType = "Image";
                        e.Style.ImageList = this.fList;
                        e.Style.ImageIndex = Convert.ToInt32(e.Style.CellValue);

                    }

                    if (e.Style.CellType == "ColumnHeaderCell")
                    {
                        e.Style.CellType = "Static";
                        e.Style.ImageList = this.fList;
                        e.Style.ImageIndex = (int)headerImage.Flag;
                        e.Style.Text = "";
                    }
                }
                if (e.TableCellIdentity.Column.Name == "Category")
                {
                    if (e.Style.CellType != "ColumnHeaderCell")
                    {
                        e.Style.CellType = "Static";
                        e.Style.ImageList = this.imageList1;
                        switch ((string)e.Style.CellValue)
                        {
                            case "Red Category": e.Style.ImageIndex = 0; break;
                            case "Blue Category": e.Style.ImageIndex = 1; break;
                            case "Green Category": e.Style.ImageIndex = 2; break;
                            case "Orange Category": e.Style.ImageIndex = 3; break;
                            case "Purple Category": e.Style.ImageIndex = 4; break;
                            case "Yellow Category": e.Style.ImageIndex = 5; break;
                        }
                    }
                }
                if (e.TableCellIdentity.Column.Name == "Size")
                {
                    if (e.Style.CellType != "ColumnHeaderCell")
                    {
                        double value = (double)e.Style.CellValue;
                        if (value < 1024)
                        {
                            e.Style.CellValue = value + " B";
                        }
                        else if (value < 1048575)
                        {
                            value = Math.Floor(value / 1024);
                            e.Style.CellValue = value + " KB";
                        }
                        else if (value < 1073741824)
                        {
                            value = Math.Floor(value / 1048575);
                            e.Style.CellValue = value + " MB";
                        }
                        else if (value > 1073741824)
                        {
                            value = Math.Floor(value / 1073741824);
                            e.Style.CellValue = value + " GB";
                        }
                        e.Style.HorizontalAlignment = GridHorizontalAlignment.Left;
                    }
                }
                if (e.TableCellIdentity.Column.Name == "mails")
                {
                    if (e.Style.CellType != "ColumnHeaderCell")
                    {
                        e.Style.CellType = "Image";
                        e.Style.ImageList = this.mailList;
                        e.Style.ImageIndex = (int)e.Style.CellValue;
                    }
                    if (e.Style.CellType == "ColumnHeaderCell")
                    {
                        e.Style.CellType = "Static";
                        e.Style.ImageList = this.iList;
                        e.Style.ImageIndex = (int)headerImage.Mail;
                        e.Style.Text = "";
                    }
                }

                if (e.TableCellIdentity.Column.Name == "ReadState")
                {
                    if (e.Style.CellType != "ColumnHeaderCell")
                    {
                        e.Style.CellType = "Image";
                        e.Style.ImageList = this.mailList;
                        e.Style.ImageIndex = (int)e.Style.CellValue;
                    }
                    if (e.Style.CellType == "ColumnHeaderCell")
                    {
                        e.Style.CellType = "Static";
                        e.Style.ImageList = this.iList;
                        e.Style.ImageIndex = (int)headerImage.ReadState;
                        e.Style.Text = "";
                    }
                }

                if (e.TableCellIdentity.Column.Name == "Priority")
                {
                    if (e.Style.CellType != "ColumnHeaderCell")
                    {
                        if (e.Style.Text == "1" || e.Style.Text == "-1")
                        {
                            e.Style.CellType = "Image";
                            e.Style.ImageList = this.iList;
                            e.Style.ImageIndex = e.Style.Text == "1" ? (int)flags.HighPriority : (int)flags.LowPriority;
                        }
                    }
                    if (e.Style.CellType == "ColumnHeaderCell")
                    {
                        e.Style.CellType = "Static";
                        e.Style.ImageList = this.iList;
                        e.Style.Text = "";
                        e.Style.ImageIndex = (int)headerImage.Priority;
                    }
                }

                if (e.TableCellIdentity.Column.Name == "Attachment")
                {
                    if (e.Style.CellType != "ColumnHeaderCell")
                    {
                        if (e.Style.Text == "1")
                        {
                            e.Style.CellType = "Image";
                            e.Style.ImageList = this.iList;
                            e.Style.ImageIndex = (int)flags.ShowClip;
                        }
                    }
                    if (e.Style.CellType == "ColumnHeaderCell")
                    {
                        e.Style.CellType = "Static";
                        e.Style.ImageList = this.iList;
                        e.Style.ImageIndex = (int)headerImage.Attachment;
                        e.Style.Text = "";
                    }
                }
                if (e.Style.CellType == "ColumnHeaderCell")
                {
                    e.Style.CellType = "Static";
                }

                if (e.TableCellIdentity.DisplayElement is GridRecordRow)
                {
                    if (this.NormalView)
                    {
                        DataRowView dr = e.TableCellIdentity.DisplayElement.ParentRecord.GetData() as DataRowView;
                        if (dr != null && Convert.ToInt32(dr["ReadState"]) == 1)
                        {
                            e.Style.Font.Bold = false;
                            if (e.TableCellIdentity.Column.Name == "mails" && e.Style.CellType != "ColumnHeaderCell" && (int)e.Style.CellValue == 0)
                                e.Style.ImageIndex = 1;
                        }
                        else if (dr != null && Convert.ToInt32(dr["ReadState"]) == 0)
                        {
                            e.Style.Font.Bold = true;
                            if (e.TableCellIdentity.Column.Name == "mails" && e.Style.CellType != "ColumnHeaderCell" && (int)e.Style.CellValue == 1)
                                e.Style.ImageIndex = 0;
                        }
                    }
                }
            }
            if (e.TableCellIdentity.TableCellType == GridTableCellType.GroupCaptionCell)
            {
                e.Style.Themed = false;
                e.Style.BackColor = Color.White;
                e.Style.Borders.Top = new GridBorder(GridBorderStyle.None, Color.FromArgb(Form1.r, Form1.g, Form1.b), GridBorderWeight.Thick);
                e.Style.Borders.Bottom = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(Form1.r, Form1.g, Form1.b), GridBorderWeight.Thick);
                e.Style.TextColor = Color.FromArgb(50, 100, 160);
                e.Style.Text = e.TableCellIdentity.DisplayElement.ParentGroup.Category.ToString();
                e.Style.TextMargins.Bottom = 8 - 3;

                e.Style.VerticalAlignment = GridVerticalAlignment.Bottom;
            }
            if (e.TableCellIdentity.TableCellType == GridTableCellType.GroupCaptionPlusMinusCell)
            {
                e.Style.CellAppearance = GridCellAppearance.Flat;
                e.Style.Borders.Top = new GridBorder(GridBorderStyle.None);
                e.Style.Borders.Bottom = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(Form1.r, Form1.g, Form1.b), GridBorderWeight.Thick);
            }
            if (e.TableCellIdentity.TableCellType == GridTableCellType.GroupIndentCell)
            {
                e.Style.Borders.Top = new GridBorder(GridBorderStyle.None);
                e.Style.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, Color.FromArgb(227, 239, 255), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            }

            if ((e.TableCellIdentity.TableCellType == GridTableCellType.GroupCaptionCell && e.TableCellIdentity.RowIndex > 1))
            {
                if (gridGroupingControl1.TableDescriptor.GroupedColumns.IndexOf("date") > -1)
                {
                    e.Style.Font.Bold = true;
                    try
                    {
                        switch ((days)Convert.ToInt32(e.Style.Text))
                        {
                            case days.LastWeek:
                                {
                                    e.Style.Text = "Date: Last Week";
                                    break;
                                }
                            case days.TwoWeeksAgo:
                                {
                                    e.Style.Text = "Date: Two Weeks Ago";
                                    break;
                                }
                            case days.ThreeWeeksAgo:
                                {
                                    e.Style.Text = "Date: Three Weeks Ago";
                                    break;
                                }
                            case days.LastMonth:
                                {
                                    e.Style.Text = "Date: Last Month";
                                    break;
                                }
                            default:
                                {
                                    e.Style.Text = "Date: " + (days)Convert.ToInt32(e.Style.Text);
                                    break;
                                }
                        }
                    }
                    catch
                    {
                        //Console.WriteLine(ex.Message);
                    }
                }
                if (gridGroupingControl1.TableDescriptor.GroupedColumns.IndexOf("customSize") > -1)
                {
                    e.Style.Font.Bold = true;
                    if (e.Style.Text == "1")
                        e.Style.Text = "Tiny (<10 KB)";
                    else if (e.Style.Text == "2")
                        e.Style.Text = "Small (10 KB - 25 KB)";
                    else if (e.Style.Text == "3")
                        e.Style.Text = "Medium (25 KB - 100 KB)";
                    else if (e.Style.Text == "4")
                        e.Style.Text = "Large (100 KB - 500 KB)";
                    else if (e.Style.Text == "5")
                        e.Style.Text = "Very Large (500 KB - 1 MB)";
                    else if (e.Style.Text == "6")
                        e.Style.Text = "Huge (1 MB - 5 MB)";
                    else if (e.Style.Text == "7")
                        e.Style.Text = "Enormous (>5 MB)";
                }
                if (gridGroupingControl1.TableDescriptor.GroupedColumns.IndexOf("Priority") > -1)
                {
                    e.Style.Font.Bold = false;
                    if (e.Style.Text == "1")
                        e.Style.Text = "Importance: High(" + e.TableCellIdentity.DisplayElement.ParentGroup.GetFilteredRecordCount() + "items)";
                    else if (e.Style.Text == "-1")
                        e.Style.Text = "Importance: Low(" + e.TableCellIdentity.DisplayElement.ParentGroup.GetFilteredRecordCount() + "items)";
                    else if (e.Style.Text == "0")
                        e.Style.Text = "Importance: Normal(" + e.TableCellIdentity.DisplayElement.ParentGroup.GetFilteredRecordCount() + "items)";
                }
                if (gridGroupingControl1.TableDescriptor.GroupedColumns.IndexOf("Attachment") > -1)
                {
                    e.Style.Font.Bold = false;
                    if (e.Style.Text == "1")
                        e.Style.Text = "Attachment: With Attachments(" + e.TableCellIdentity.DisplayElement.ParentGroup.GetFilteredRecordCount() + "items)";
                    else if (e.Style.Text == "0")
                        e.Style.Text = "Attachment: No Attachments(" + e.TableCellIdentity.DisplayElement.ParentGroup.GetFilteredRecordCount() + "items)";
                }
                if (gridGroupingControl1.TableDescriptor.GroupedColumns.IndexOf("flag") > -1)
                {
                    e.Style.Font.Bold = false;
                    if (e.Style.Text == "0")
                        e.Style.Text = "Flag Status: Unflagged(" + e.TableCellIdentity.DisplayElement.ParentGroup.GetFilteredRecordCount() + "items)";
                    else if (e.Style.Text == "1")
                        e.Style.Text = "Flag Status: Red Flag(" + e.TableCellIdentity.DisplayElement.ParentGroup.GetFilteredRecordCount() + "items)";
                    else if (e.Style.Text == "2")
                        e.Style.Text = "Flag Status: Blue Flag(" + e.TableCellIdentity.DisplayElement.ParentGroup.GetFilteredRecordCount() + "items)";
                    else if (e.Style.Text == "3")
                        e.Style.Text = "Flag Status: Yellow Flag(" + e.TableCellIdentity.DisplayElement.ParentGroup.GetFilteredRecordCount() + "items)";
                    else if (e.Style.Text == "4")
                        e.Style.Text = "Flag Status: Green Flag(" + e.TableCellIdentity.DisplayElement.ParentGroup.GetFilteredRecordCount() + "items)";
                    else if (e.Style.Text == "5")
                        e.Style.Text = "Flag Status: Orange Flag(" + e.TableCellIdentity.DisplayElement.ParentGroup.GetFilteredRecordCount() + "items)";
                    else if (e.Style.Text == "6")
                        e.Style.Text = "Flag Status: Purple Flag(" + e.TableCellIdentity.DisplayElement.ParentGroup.GetFilteredRecordCount() + "items)";
                    else if (e.Style.Text == "7")
                        e.Style.Text = "Flag Status: Flag Complete(" + e.TableCellIdentity.DisplayElement.ParentGroup.GetFilteredRecordCount() + "items)";
                }
            }
            if (!normalView && e.TableCellIdentity.DisplayElement is ExtraSection)
            {
                e.Style.CellType = "Control";
                e.Style.Control = this.CSVHeader;
            }
        }

        private int record;
        private void gridGroupingControl1_TableControlCellClick(object sender, GridTableControlCellClickEventArgs e)
        {

            if (e.Inner.MouseEventArgs.Button == MouseButtons.Left)
            {
                if (e.Inner.RowIndex > 1 && e.TableControl.Table.CurrentElement is GridCaptionRow)
                {
                    GridTableCellStyleInfo style = e.TableControl.GetTableViewStyleInfo(e.Inner.RowIndex, e.Inner.ColIndex);
                    if (style.TableCellIdentity.TableCellType == GridTableCellType.GroupCaptionPlusMinusCell)
                    {
                        GridCaptionRow curGrp = e.TableControl.Table.CurrentElement as GridCaptionRow;
                        curGrp.ParentGroup.IsExpanded = !curGrp.ParentGroup.IsExpanded;
                    }
                }

                if (e.Inner.RowIndex > 1 && e.TableControl.Table.CurrentElement is GridRecord)
                {
                    GridRecord r = (GridRecord)e.TableControl.Table.CurrentElement;
                    GridTableCellStyleInfo style = e.TableControl.GetTableViewStyleInfo(e.Inner.RowIndex, e.Inner.ColIndex);
                    if (style.TableCellIdentity.Column != null && style.TableCellIdentity.Column.Name == "flag")
                    {
                        if ((int)style.CellValue == (int)flags.Clear)
                            r.SetValue("flag", (int)this.defaultFlag);
                        else if ((int)style.CellValue != (int)flags.Complete)
                            r.SetValue("flag", (int)flags.Complete);
                        else if ((int)style.CellValue == (int)flags.Complete)
                            r.SetValue("flag", (int)this.defaultFlag);
                    }
                }

                if (this.PreviewSelected)
                {
                    // Select both record & record preview in case of clicks either in record or record preview
                    GridTableCellStyleInfo tableCellStyle = e.TableControl.GetTableViewStyleInfo(e.Inner.RowIndex, e.Inner.ColIndex);
                    Element elt = tableCellStyle.TableCellIdentity.DisplayElement;
                    if (elt is GridRecordRow)
                    {
                        catchRecord = this.gridGroupingControl1.Table.NestedDisplayElements.IndexOf(elt);
                        catchPreview = this.gridGroupingControl1.Table.NestedDisplayElements.IndexOf(elt) + 1;

                        e.TableControl.Selections.Add(GridRangeInfo.Rows(e.Inner.RowIndex, e.Inner.RowIndex + 1));
                    }
                    if (elt is GridRecordPreviewRow)
                    {
                        catchRecord = this.gridGroupingControl1.Table.NestedDisplayElements.IndexOf(elt) - 1;
                        catchPreview = this.gridGroupingControl1.Table.NestedDisplayElements.IndexOf(elt);

                        e.TableControl.Selections.Add(GridRangeInfo.Rows(e.Inner.RowIndex - 1, e.Inner.RowIndex));
                    }
                }
            }
            else if (e.Inner.MouseEventArgs.Button == MouseButtons.Right)
            {
                Point pos = new Point(e.Inner.MouseEventArgs.X, e.Inner.MouseEventArgs.Y);
                int col = 0;
                int row = 0;
                e.TableControl.PointToRowCol(pos, out row, out col);
                col = e.TableControl.TableDescriptor.ColIndexToField(col);
                if (normalView && e.Inner.RowIndex == 1)
                {
                    e.Inner.Cancel = true;
                    groupColumn = (string)e.TableControl.TableDescriptor.Columns[col].Name;
                    if (groupColumn == "Received")
                        groupColumn = "date";
                    if (groupColumn == "Size")
                        groupColumn = "customSize";

                    this.normalViewPopUpMenu.Show(e.TableControl, pos);
                }
                GridTableCellStyleInfo tableCellStyle = e.TableControl.GetTableViewStyleInfo(row, col);

                Element contextElement = tableCellStyle.TableCellIdentity.DisplayElement;
                if (e.Inner.RowIndex > 1 && contextElement is GridCaptionRow)
                {
                    int count = 0;
                    e.TableControl.Table.CurrentElement = e.TableControl.Table.NestedDisplayElements[row];
                    for (int i = 0; i <= e.Inner.RowIndex; i++)
                    {
                        Element elt = this.gridGroupingControl1.Table.NestedDisplayElements[i];
                        if (elt.Kind == DisplayElementKind.Caption)
                            count++;
                    }
                    countas = count;
                    this.CaptionPopupMenu.Show(e.TableControl, pos);
                }
                // Not a right way for this condition is the try - catch used
                if (this.PreviewSelected && contextElement is GridRecordPreviewRow)
                {
                    this.MarkfromRecordBarItem.Text = Convert.ToInt32(contextElement.GetRecord().GetValue("ReadState")) == 0 ? "Mar&k as Read" : "Mark as U&nread";
                    this.MarkfromRecordBarItem.ImageIndex = Convert.ToInt32(contextElement.GetRecord().GetValue("ReadState")) == 0 ? 1 : 0;
                    this.RecordPopupMenu.Show(e.TableControl, pos);
                }
                else if (e.Inner.RowIndex > 1 && e.TableControl.Table.CurrentElement is GridRecord)
                {
                    try
                    {
                        GridRecord r = (GridRecord)e.TableControl.Table.CurrentElement;
                        r.SetCurrent();
                        GridTableCellStyleInfo style = e.TableControl.GetTableViewStyleInfo(e.Inner.RowIndex, e.Inner.ColIndex);
                        if (style.TableCellIdentity.Column != null && style.TableCellIdentity.Column.Name == "flag")
                        {
                            record = r.Id;
                            rowas = row;
                            this.flagPopupMenu.Show(e.TableControl, pos);
                        }
                        else if (style.TableCellIdentity.Column != null && style.TableCellIdentity.Column.Name == "Category")
                        {
                            record = r.Id;
                            rowas = row;
                            this.categoryPopUpMenu.Show(e.TableControl, pos);
                        }
                        else
                        {
                            record = r.Id; // For the sake of the flag through Follow up menu..
                            rowas = row;
                            this.MarkfromRecordBarItem.Text = Convert.ToInt32(r.GetValue("ReadState")) == 0 ? "Mar&k as Read" : "Mark as U&nread";
                            this.MarkfromRecordBarItem.ImageIndex = Convert.ToInt32(r.GetValue("ReadState")) == 0 ? 1 : 0;

                            this.RecordPopupMenu.Show(e.TableControl, pos);
                        }
                    }

                    catch/*System.InvalidCastException ex*/
                    {

                    }

                }
            }
        }
        private int rowas, countas;

        private void TableModel_QueryCoveredRange(object sender, GridQueryCoveredRangeEventArgs e)
        {
            if (!normalView)
            {
                GridTableModel tm = sender as GridTableModel;
                Element el = tm.Table.DisplayElements[e.RowIndex];
                if (el is ExtraSection)
                {
                    e.Range = GridRangeInfo.Cells(e.RowIndex, 0, e.ColIndex, tm.ColCount);
                    e.Handled = true;
                }
            }
        }

        private void gridGroupingControl1_QueryValue(object sender, Syncfusion.Grouping.FieldValueEventArgs e)
        {
            Syncfusion.Grouping.Record rd = (Syncfusion.Grouping.Record)e.Record;
            DateTime TodaysDate = DateTime.Today;
            DateTime dt = DateTime.Parse(Convert.ToDateTime(rd.GetValue("Received")).ToShortDateString());
            System.TimeSpan dtvalue = TodaysDate - dt;
            int totdays = dtvalue.TotalDays < 1 ? 0 : (int)Math.Round(dtvalue.TotalDays);
            if (e.Field.Name == "date")
            {
                e.Value = ComputePeriodReceived(totdays);
            }
            if (e.Field.Name == "customSize")
            {
                double d = Convert.ToDouble(rd.GetValue("Size"));
                if (d < 10240)
                    e.Value = 1;
                else if (d < 25600)
                    e.Value = 2;
                else if (d < 102400)
                    e.Value = 3;
                else if (d < 512000)
                    e.Value = 4;
                else if (d < 1048576)
                    e.Value = 5;
                else if (d < 5242880)
                    e.Value = 6;
                else
                    e.Value = 7;
            }
        }

        private void Model_QueryColWidth(object sender, GridRowColSizeEventArgs e)
        {
            if (e.Index == 2)
            {
                e.Size = 0;
                e.Handled = true;
            }
        }

        private void GroupedColumns_Changed(object sender, ListPropertyChangedEventArgs e)
        {
            Syncfusion.Grouping.SortColumnDescriptor scd = e.Item as Syncfusion.Grouping.SortColumnDescriptor;
            if (e.Action == Syncfusion.Collections.ListPropertyChangedType.Insert ||
                e.Action == Syncfusion.Collections.ListPropertyChangedType.Add)
            {
                ClearChecks(parentBarItem_ArrangeBy);
                this.barItem_Custom.Checked = false;

                if (scd.Name == "date")
                    this.barItem_Date.Checked = true;
                if (scd.Name == "customSize")
                    this.barItem_Size.Checked = true;
                if (scd.Name == "From")
                    this.barItem_From.Checked = true;
                if (scd.Name == "To")
                    this.barItem_To.Checked = true;
                if (scd.Name == "Subject")
                    this.barItem_Subject.Checked = true;
                if (scd.Name == "flag")
                    this.barItem_Flag.Checked = true;
                if (scd.Name == "Attachment")
                    this.barItem_Attachments.Checked = true;
                if (scd.Name == "Priority")
                    this.barItem_Importance.Checked = true;

                if (this.gridGroupingControl1.TableDescriptor.GroupedColumns.Count > 1)
                {
                    ClearChecks(parentBarItem_ArrangeBy);
                    this.barItem_Custom.Checked = true;
                }
            }
            if (e.Action == Syncfusion.Collections.ListPropertyChangedType.Remove)
            {
                ClearChecks(parentBarItem_ArrangeBy);
                this.barItem_Custom.Checked = false;
            }

            if (this.gridGroupingControl1.TableDescriptor.GroupedColumns.Count >= 1)
                this.barItem_ShowInGroups.Checked = true;
            else
                this.barItem_ShowInGroups.Checked = false;
            if (this.gridGroupingControl1.TableDescriptor.GroupedColumns.Count >= 1)
            {
                foreach (Element el in this.gridGroupingControl1.Table.DisplayElements)
                {
                    if (!(el is GridRecordRow))
                    {
                        int row = this.gridGroupingControl1.Table.NestedDisplayElements.IndexOf(el);
                        if (this.gridGroupingControl1.Table.NestedDisplayElements[row].IsCaption())
                        {
                            GridCaptionRow crow = (GridCaptionRow)el;
                            Group gp = crow.ParentGroup;
                            if (gp.IsExpanded)
                                crow.Appearance.GroupCaptionPlusMinusCell.CellValue = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "minus.png"));
                            else
                                crow.Appearance.GroupCaptionPlusMinusCell.CellValue = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "plus.png"));
                        }
                    }
                }
            }
        }

        private void GroupedColumns_Changing(object sender, Syncfusion.Collections.ListPropertyChangedEventArgs e)
        {
            Syncfusion.Grouping.SortColumnDescriptor scd = e.Item as Syncfusion.Grouping.SortColumnDescriptor;
            if (e.Action == Syncfusion.Collections.ListPropertyChangedType.Insert ||
                e.Action == Syncfusion.Collections.ListPropertyChangedType.Add)
            {
                //Custom sort with IComparer class below
                //				if (scd.Name == "date" && scd.Comparer == null)
                //					scd.Comparer = new CustomDateComparer();
                groupedBy = scd.Name;

                gridGroupingControl1.TableDescriptor.Columns[scd.Name].Appearance.AnyRecordFieldCell.BackColor = Color.FromArgb(Form1.r, Form1.g, Form1.b);
            }
            if (e.Action == Syncfusion.Collections.ListPropertyChangedType.Remove)
            {
                if (scd.Name == "date")
                {
                    groupedBy = "";
                }
                if (scd.Name == "customSize")
                    groupedBy = "";
                gridGroupingControl1.TableDescriptor.Columns[scd.Name].Appearance.AnyRecordFieldCell.BackColor = Color.FromArgb(Form1.r, Form1.g, Form1.b);
            }
        }

        private void gridGroupingControl1_TableControlCurrentCellActivating(object sender, GridTableControlCurrentCellActivatingEventArgs e)
        {
            e.Inner.ColIndex = 0;
        }

        // May be at the point teh preview is turned on we will add preview selection
        int catchRecord, catchPreview, celling, floor;
        private void gridGroupingControl1_TableControlKeyDown(object sender, GridTableControlKeyEventArgs e)
        {
            GridCurrentCell cc = e.TableControl.CurrentCell;
            Element el = this.gridGroupingControl1.Table.GetInnerMostCurrentElement();
            this.gridGroupingControl1.TableControl.Selections.Clear();
            int row = this.gridGroupingControl1.Table.NestedDisplayElements.IndexOf(el);

            int foundRow = LocateSelectionToKey(e.Inner.KeyCode);
            if (foundRow != -1)
            {
                this.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Row(foundRow));
                this.gridGroupingControl1.TableControl.ScrollCellInView(foundRow, 1, GridScrollCurrentCellReason.KeyPress);
            }

            # region Navigation while preview on..
            if (this.PreviewSelected)
            {
                if (e.Inner.KeyCode == Keys.Down)
                {
                    //					if(celling > 0 && celling <= catchRecord)
                    //					{
                    //						catchPreview = catchRecord = celling;
                    //						celling = 0;
                    //					}

                    if (catchRecord + 2 > gridGroupingControl1.Table.NestedDisplayElements.Count - 1)
                    {
                        if (this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord].IsRecord())
                        {
                            catchPreview = catchRecord + 1;
                            this.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord, catchPreview));
                        }
                        else if (this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord + 1].IsCaption())
                        {
                            floor = catchRecord + 1;
                            this.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord + 1, catchRecord + 1));
                        }
                        //						else if(this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord].IsCaption())
                        //						{
                        //							catchPreview = catchRecord;
                        //							this.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord, catchPreview));
                        //						}
                    }
                    else
                    {
                        // Move down two by two in case of record & record preview
                        if (this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord + 1].IsRecord())
                            // Correct the indexes here
                            catchRecord--;
                        if (this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord + 2].IsRecord())
                            this.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord += 2, catchPreview += 2));
                        // in case of caption just select the caption
                        else if (this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord + 1].IsCaption())
                            // Look from reverse * suppose looking ahead is full of captions
                            this.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord += 1, catchPreview += 1));
                        else if (this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord + 2].IsCaption())
                            this.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord += 2, catchPreview += 1));
                    }
                    // Move the scroll bar together.. 
                    this.gridGroupingControl1.TableControl.ScrollCellInView(catchRecord + 1, 1, GridScrollCurrentCellReason.KeyPress);
                }
                if (e.Inner.KeyCode == Keys.Up)
                {
                    if (catchRecord - 2 < 2)
                    {
                        if (this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord - 1].IsCaption())
                        {
                            this.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord - 1, catchRecord - 1));
                            catchPreview = catchRecord;
                        }
                        else if (this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord].IsRecord())
                            this.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord, catchPreview));
                        else if (this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord].IsCaption())
                        {
                            catchPreview = catchRecord;
                            this.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord, catchPreview));
                        }
                    }
                    else
                    {
                        // Move up two by two in case of record & record preview
                        if (this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord - 2].IsRecord() && catchPreview == catchRecord)
                            catchPreview++;// Correct the indexes here
                        if (this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord - 2].IsRecord())
                            this.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord -= 2, catchPreview -= 2));
                        // in case of caption just select the caption
                        else if (this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord - 1].IsCaption())
                            this.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord -= 1, catchPreview -= 2));
                    }
                    // Move the scroll bar together.. 
                    this.gridGroupingControl1.TableControl.ScrollCellInView(catchRecord, 1, GridScrollCurrentCellReason.KeyPress);
                }
                if (e.Inner.KeyCode == Keys.Left)
                {
                    if (catchRecord - 2 < 2)
                    {
                        // Might need to collapse
                        if (this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord - 1].IsCaption())
                        {
                            this.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord - 1, catchRecord - 1));
                            int count = 0;
                            for (int i = 0; i < catchRecord - 1; i++)
                            {
                                Element elt = this.gridGroupingControl1.Table.NestedDisplayElements[i];
                                if (elt.Kind == DisplayElementKind.Caption)
                                    count++;
                            }
                            e.TableControl.Table.TopLevelGroup.Groups[count].IsExpanded = false;
                            catchPreview = catchRecord;
                            celling = catchRecord - 1;
                        }
                        else if (this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord].IsRecord())
                            this.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord, catchPreview));
                        else if (this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord].IsCaption())
                        {
                            this.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord, catchRecord));
                            catchPreview = catchRecord;
                        }
                    }
                    else
                    {
                        if (floor >= catchRecord)
                        {
                            catchPreview = catchRecord = floor;
                            floor = 0;
                        }
                        // Collapse the group and move up
                        if (this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord - 1].IsCaption() && catchPreview == catchRecord)
                            // Correct the indexes here
                            catchPreview++;
                        if (this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord - 2].IsRecord() && catchPreview == catchRecord)
                            // Correct the indexes here
                            catchPreview++;
                        if (this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord - 2].IsRecord())
                            this.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord -= 2, catchPreview -= 2));
                        // in case of caption just select the caption
                        else if (this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord - 1].IsCaption())
                        {
                            int count = 0;
                            for (int i = 0; i < catchRecord - 1; i++)
                            {
                                Element elt = this.gridGroupingControl1.Table.NestedDisplayElements[i];
                                if (elt.Kind == DisplayElementKind.Caption)
                                    count++;
                            }
                            e.TableControl.Table.TopLevelGroup.Groups[count].IsExpanded = false;
                            // Look from reverse * suppose looking ahead is full of captions
                            this.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord -= 1, catchPreview -= 2));
                        }
                    }
                    // Move the scroll bar together.. 
                    e.TableControl.ScrollCellInView(catchRecord, 1, GridScrollCurrentCellReason.KeyPress);
                }
                if (e.Inner.KeyCode == Keys.Right)
                {
                    if (celling > 0 && celling <= catchRecord)
                    {
                        catchPreview = catchRecord = celling;
                        celling = 0;
                    }
                    if (catchRecord + 2 > gridGroupingControl1.Table.NestedDisplayElements.Count - 1)
                    {
                        if (this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord].IsRecord())
                        {
                            catchPreview = catchRecord + 1;
                            this.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord, catchPreview));
                        }
                        //						else if(this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord].IsCaption())
                        //						{
                        //							int count =0;
                        //							for(int i = 0; i < catchRecord+1; i++)
                        //							{
                        //								Element elt = this.gridGroupingControl1.Table.NestedDisplayElements[i];
                        //								if(elt.Kind == DisplayElementKind.Caption)
                        //									count++;
                        //							}
                        //							e.TableControl.Table.TopLevelGroup.Groups[count].IsExpanded = true;
                        //							this.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord+=1, catchPreview+=1));
                        //						}
                    }
                    else
                    {
                        // Expand the group and Move Down 
                        // Move down two by two in case of record & record preview
                        if (this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord + 1].IsRecord())
                        {
                            // Correct the indexes here
                            catchRecord--;
                        }
                        if (this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord + 2].IsRecord())
                            this.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord += 2, catchPreview += 2));
                        // in case of caption just select the caption
                        else if (this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord].IsCaption())
                        {
                            this.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord, catchPreview));
                            //Expand the first caption..
                            e.TableControl.Table.TopLevelGroup.Groups[0].IsExpanded = true;
                        }
                        else if (this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord + 1].IsCaption())
                        {
                            // Look from reverse * suppose looking ahead is full of captions
                            this.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord += 1, catchPreview += 1));
                            int count = 0;
                            for (int i = 0; i < catchRecord + 1; i++)
                            {
                                Element elt = this.gridGroupingControl1.Table.NestedDisplayElements[i];
                                if (elt.Kind == DisplayElementKind.Caption)
                                    count++;
                            }
                            e.TableControl.Table.TopLevelGroup.Groups[count].IsExpanded = true;
                        }
                        else if (this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord + 2].IsCaption())
                        {
                            int count = 0;
                            for (int i = 0; i < catchRecord + 2; i++)
                            {
                                Element elt = this.gridGroupingControl1.Table.NestedDisplayElements[i];
                                if (elt.Kind == DisplayElementKind.Caption)
                                    count++;
                            }
                            e.TableControl.Table.TopLevelGroup.Groups[count].IsExpanded = true;
                            this.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord += 2, catchPreview += 1));
                        }
                    }
                    // Move the scroll bar together.. 
                    this.gridGroupingControl1.TableControl.ScrollCellInView(catchRecord + 1, 1, GridScrollCurrentCellReason.KeyPress);
                }

            }
            # endregion

            # region Navigation without Preview
            else
            {
                if (e.Inner.KeyCode == Keys.Up)
                {
                    // Move up one by one
                    if (row > 2)// dont move to header
                        e.TableControl.Selections.Add(GridRangeInfo.Row(row - 1));
                    else
                        e.TableControl.Selections.Add(GridRangeInfo.Row(row));

                }
                if (e.Inner.KeyCode == Keys.Down)
                {
                    // Move down one by one
                    if (row < gridGroupingControl1.Table.NestedDisplayElements.Count - 1) // stop by the last row
                        e.TableControl.Selections.Add(GridRangeInfo.Row(row + 1));
                    else
                        e.TableControl.Selections.Add(GridRangeInfo.Row(row));
                }
                if (e.Inner.KeyCode == Keys.Left)
                {
                    if (row <= 2)// dont move to header
                        e.TableControl.Selections.Add(GridRangeInfo.Row(row));
                    else
                    {
                        //Close this group and move up one by one 
                        if (el is GridRecord)
                        {
                            //No code necessary! // Worked in Laptop version *to be checked
                            e.TableControl.CurrentCell.MoveUp();
                            e.TableControl.Selections.Add(GridRangeInfo.Row(row - 1));
                        }
                        //With MoveUp caption row is recoganized instead of record
                        if (el is GridCaptionRow)
                        {
                            GridCaptionRow crow = (GridCaptionRow)el;
                            el.ParentGroup.IsExpanded = false;
                            e.TableControl.CurrentCell.MoveUp();
                            e.TableControl.Selections.Add(GridRangeInfo.Row(row - 1));
                        }
                    }
                }
                if (e.Inner.KeyCode == Keys.Right)
                {
                    //expand the cloapsed group and move down one by one
                    if (el is GridCaptionRow)
                    //if(this.gridGroupingControl1.Table.NestedDisplayElements[row].IsCaption())
                    {
                        int count = 0;
                        for (int i = 0; i < row; i++)
                        {
                            Element elt = this.gridGroupingControl1.Table.NestedDisplayElements[i];
                            if (elt.Kind == DisplayElementKind.Caption)
                                count++;
                        }
                        e.TableControl.Table.TopLevelGroup.Groups[count].IsExpanded = true;
                        e.TableControl.CurrentCell.MoveDown();
                        e.TableControl.Selections.Add(GridRangeInfo.Row(row + 1));
                    }

                    if (el is GridRecord)
                    //if(this.gridGroupingControl1.Table.NestedDisplayElements[row].IsRecord())
                    {
                        e.TableControl.CurrentCell.MoveDown();
                        e.TableControl.Selections.Add(GridRangeInfo.Row(row + 1));
                    }
                    //&& e.TableControl.Selections.Count == 0

                    if (row >= e.TableControl.Table.NestedDisplayElements.Count - 2 && e.TableControl.Selections.Count > 1) // Stop by last row
                        e.TableControl.Selections.Add(GridRangeInfo.Row(row));
                    Console.WriteLine("From KeyDown " + e.TableControl.Selections.Count);
                }
            }
            # endregion
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="key">enum System.Windows.Form.Keys is passed from KeyDown handler</param>
        /// <returns>The rowindex in the display elements for the </returns>
        private int LocateSelectionToKey(Keys key)
        {
            // Check if the key is valid
            if ((int)key > (int)Keys.Z || (int)key < (int)Keys.A)
                return -1;
            bool notfound = true;
            // loop throgh the caption 
            // check for the starting text that matches with the the key
            // send the row number to mark selection in that caption
            while (notfound)
            {
                for (int row = 2; row < this.gridGroupingControl1.Table.DisplayElements.Count; row++)
                {
                    // check every caption element..
                    if (this.gridGroupingControl1.Table.DisplayElements[row].IsCaption())
                    {
                        Element element = (Element)this.gridGroupingControl1.Table.DisplayElements[row];
                        GridCaptionRow captionRow = (GridCaptionRow)element;
                        string foundString = captionRow.ParentGroup.Category.ToString();
                        if (foundString.StartsWith(key.ToString()))
                        {
                            notfound = false;
                            return row;
                        }
                    }
                }
                key = key == Keys.Z ? Keys.A : key;
                // Search next alphabet
                key = (Keys)((int)key + 1);

            }
            return 0;
        }

        private void gridGroupingControl1_Resize(object sender, EventArgs e)
        {
            ((GridGroupingControl)sender).Invalidate(true);
        }


        private void TableControl_PrepareViewStyleInfo(object sender, GridPrepareViewStyleInfoEventArgs e)
        {
            if (e.RowIndex > 0 && e.ColIndex > 0)
            {
                if (this.gridGroupingControl1.TableControl.Selections.GetSelectedRows(true, false).AnyRangeContains(GridRangeInfo.Row(e.RowIndex)))
                {
                    e.Style.TextColor = SystemColors.ControlText;
                    //e.Style.BackColor = SystemColors.Highlight;
                    e.Style.BackColor = SystemColors.GradientInactiveCaption;

                    if (e.ColIndex == this.gridGroupingControl1.TableDescriptor.Columns.IndexOf("flag") + 2)
                    {
                        try
                        {
                            //e.Style.BackColor = UsedColors(Convert.ToInt32(e.Style.CellValue));

                            // If Mouse Hovers..
                            Point mousePosition = Cursor.Position;
                            Rectangle rect = this.gridGroupingControl1.TableControl.RangeInfoToRectangle(GridRangeInfo.Cell(e.RowIndex, e.ColIndex));
                            Rectangle RectToScreen = this.gridGroupingControl1.TableControl.RectangleToScreen(rect);
                            if (RectToScreen.Contains(mousePosition))
                                e.Style.BackColor = SystemColors.Info;
                        }
                        catch { }
                    }
                }

                GridTableCellStyleInfo style = (GridTableCellStyleInfo)e.Style;

                if (style.TableCellIdentity.TableCellType == GridTableCellType.GroupCaptionPlusMinusCell)
                    e.Style.TextColor = SystemColors.Desktop;
            }
        }


        private void Model_SelectionChanging(object sender, GridSelectionChangingEventArgs e)
        {
            bool ForcedCancel = false;
            if (Control.MouseButtons == MouseButtons.Right)
            {
                e.Cancel = true;
                //ForcedCancel = true;
            }
            // use the Nested display elements to know the selection is of record or caption
            int row = e.Range.Top;
            if (!ForcedCancel && row == 0) // this helps in preview selection on readstate but lately..
            {
                GridRangeInfoList rangeInfo;
                bool check = this.gridGroupingControl1.TableControl.Selections.GetSelectedRanges(out rangeInfo, true);

                row = rangeInfo.ActiveRange.Top;
                Console.WriteLine(check + " " + row);
            }
            // If the selection is of record and Unread, then mark that as Read
            if (this.gridGroupingControl1.Table.NestedDisplayElements[row] != null && this.gridGroupingControl1.Table.NestedDisplayElements[row].IsRecord())
            {
                Record r = (Record)this.gridGroupingControl1.Table.NestedDisplayElements[row].GetRecord();
                if (Convert.ToInt32(r.GetValue("ReadState")) == 0 && e.Reason == (GridSelectionReason.MouseDown | GridSelectionReason.ArrowKey))
                {
                    r.SetValue("ReadState", 1);
                }
            }
        }
        private void gridGroupingControl1_GroupCollapsed(object sender, GroupEventArgs e)
        {
            GridCaptionRow gcr = (GridCaptionRow)e.Group.Caption.CaptionRows[0];
            gcr.Appearance.GroupCaptionPlusMinusCell.CellValue = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "plus.png"));
        }

        private void gridGroupingControl1_GroupExpanded(object sender, GroupEventArgs e)
        {
            GridCaptionRow gcr = (GridCaptionRow)e.Group.Caption.CaptionRows[0];
            gcr.Appearance.GroupCaptionPlusMinusCell.CellValue = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "minus.png"));
        }

        private void GridGroupDropArea_PrepareViewStyleInfo(object sender, GridPrepareViewStyleInfoEventArgs e)
        {
            e.Style.Font.Facename = "Corbel";
           
            if (e.Style.Text != " ")
            {
                if (e.Style.Text.StartsWith("Drag a"))
                {
                    e.Style.TextColor = Color.FromArgb(22, 74, 167);
                }
            }
            e.Style.Borders.All = new GridBorder(GridBorderStyle.None);
        }

        private void gridGroupingControl1_TableControlCellDrawn(object sender, GridTableControlDrawCellEventArgs e)
        {
            if (e.Inner.RowIndex == 1)
            {
                Rectangle rect1 = e.Inner.Bounds;
                rect1.X = (rect1.X + rect1.Width) - 10;
                rect1.Width = 10;
                rect1.Y = (rect1.Y + rect1.Height) - 16;
                rect1.Height = 10;
                e.Inner.Graphics.DrawLine(new Pen(Color.FromArgb(Form1.r, Form1.g, Form1.b)), new Point(rect1.X + 9, rect1.Y - 2), new Point(rect1.X + 9, rect1.Y + 12));
                e.Inner.Graphics.DrawLine(Pens.AliceBlue, new Point(rect1.X + 10, rect1.Y - 2), new Point(rect1.X + 10, rect1.Y + 12));
                string colName = e.Inner.Style.Text;
                if (colName == "Subject" || colName == "Received" || colName == "From" || colName == "Size")
                {
                    GridTableCellStyleInfo style = e.TableControl.GetTableViewStyleInfo(e.Inner.RowIndex, e.Inner.ColIndex);
                    if (style.Tag != null)
                    {
                        Rectangle rect = e.Inner.Bounds;
                        rect.X = (rect.X + rect.Width) - 25;
                        rect.Width = 10;
                        rect.Y = (rect.Y + rect.Height) - 15;
                        rect.Height = 10;
                        if (style.Tag.ToString() == "Ascending")
                        {
                            Point p1 = new Point(rect.X - 4, rect.Y + 6);
                            Point p2 = new Point(rect.X, rect.Y + 2);
                            Point p3 = new Point(rect.X + 4, rect.Y + 6);

                            e.Inner.Graphics.DrawLine(new Pen(Color.FromArgb(154, 198, 255)), p2, p3);
                            e.Inner.Graphics.DrawLine(new Pen(Color.FromArgb(154, 198, 255)), p3, p1);
                            e.Inner.Graphics.DrawLine(new Pen(Color.FromArgb(154, 198, 255)), p1, p2);
                            e.Inner.Graphics.FillPolygon(new SolidBrush(SortIconColor), new Point[] { p1, p2, p3 });
                        }
                        else
                        {
                            Point p1 = new Point(rect.X - 4, rect.Y + 2);
                            Point p2 = new Point(rect.X, rect.Y + 6);
                            Point p3 = new Point(rect.X + 4, rect.Y + 2);

                            e.Inner.Graphics.DrawLine(new Pen(Color.FromArgb(154, 198, 255)), p1, p2);
                            e.Inner.Graphics.DrawLine(new Pen(Color.FromArgb(154, 198, 255)), p3, p1);
                            e.Inner.Graphics.DrawLine(new Pen(Color.FromArgb(154, 198, 255)), p2, p3);
                            e.Inner.Graphics.FillPolygon(new SolidBrush(SortIconColor), new Point[] { p1, p2, p3 });
                        }
                    }
                }
            }
        }
        # endregion

        # region Custom event handlers

        private void GroupingPanel_Changed(object sender, EventArgs e)
        {
            // the state before event is only known
            if (!this.NormalView)
            {
                this.gridGroupingControl1.Table.TableDirty = true;
                // NormalStyle without column sets
                this.gridGroupingControl1.TableDescriptor.ColumnSets.Clear();
                RollBackSizeChanges();
                // Also remove the custom section
                EnableCustomSection(false);
                //show the default column headers 
                this.gridGroupingControl1.TopLevelGroupOptions.ShowColumnHeaders = true;
            }
            else
            {
                CreateColumnSetView(numberOfLayers);
                EnableCustomSection(false); // true
                // Hide the default multi headers to a header in the custom section..
                this.gridGroupingControl1.TopLevelGroupOptions.ShowColumnHeaders = false;
            }
        }

        private void GroupingPanel_CancelGroup(object sender, EventArgs e)
        {
            if (groupedBy == "date" || groupedBy == "customSize")
            {
                foreach (GridColumnDescriptor cd in this.gridGroupingControl1.TableDescriptor.Columns)
                    cd.AllowGroupByColumn = false;
                MessageBox.Show("Cannot Group items by this field");
            }
            else
                foreach (GridColumnDescriptor cd in this.gridGroupingControl1.TableDescriptor.Columns)
                    cd.AllowGroupByColumn = true;
        }

        private void GroupingPanel_ShowViewChanged(object sender, EventArgs e)
        {
            //			if(this.gridGroupingControl1.TableOptions.ShowRecordPreviewRow )
            //			{
            //				int catchRecord = this.gridGroupingControl1.TableControl.Selections.Ranges.ActiveRange.Top;
            //
            //				//this.gridGroupingControl1.TableControl.Selections.Clear();
            //				//Console.WriteLine(this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord].ToString());
            //				//if(this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord].IsRecord())
            //				this.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Row(10));
            //			}
            //			else
            //			{			
            //				int catchRecord = this.gridGroupingControl1.TableControl.Selections.Ranges.ActiveRange.Top;
            //				//int catchPreview = this.gridGroupingControl1.TableControl.Selections.Ranges.ActiveRange.Bottom;
            //				this.gridGroupingControl1.TableControl.Selections.Clear();
            //				//if(this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord].IsRecord())			
            //				this.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord, catchRecord));
            //			}
        }
        # endregion

        # endregion

        # region Menus

        # region Normal view Popup menu handlers

        private void barItem_Attachments_Click(object sender, System.EventArgs e)
        {
            ClearChecks(parentBarItem_ArrangeBy);
            this.barItem_Custom.Checked = false;
            ShowGroupDropArea();
            this.barItem_Attachments.Checked = true;
            this.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear();
            this.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("attachments");
        }

        private void barItem_Conversation_Click(object sender, System.EventArgs e)
        {
            ClearChecks(parentBarItem_ArrangeBy);
            this.barItem_Custom.Checked = false;
            ShowGroupDropArea();
            this.barItem_Conversation.Checked = true;

            if (this.gridGroupingControl1.TableDescriptor.Columns.Contains("conversation"))
            {
                this.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear();
                this.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("conversation");
            }
            else
                MessageBox.Show("Is not currently supported");
        }

        private void barItem_EmailAccounts_Click(object sender, System.EventArgs e)
        {
            ClearChecks(parentBarItem_ArrangeBy);
            this.barItem_Custom.Checked = false;
            ShowGroupDropArea();
            this.barItem_EmailAccounts.Checked = true;

            if (this.gridGroupingControl1.TableDescriptor.Columns.Contains("emailAccounts"))
            {
                this.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear();
                this.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("emailAccounts");
            }
            else
                MessageBox.Show("Is not currently supported");
        }

        private void barItem_Importance_Click(object sender, System.EventArgs e)
        {
            ClearChecks(parentBarItem_ArrangeBy);
            this.barItem_Custom.Checked = false;
            ShowGroupDropArea();
            this.barItem_Importance.Checked = true;

            if (this.gridGroupingControl1.TableDescriptor.Columns.Contains("Priority"))
            {
                this.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear();
                this.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("Priority");
            }
            else
                MessageBox.Show("Is not currently supported");
        }

        private void barItem_Categories_Click(object sender, System.EventArgs e)
        {
            ClearChecks(parentBarItem_ArrangeBy);
            this.barItem_Custom.Checked = false;
            ShowGroupDropArea();
            this.barItem_Categories.Checked = true;
            if (this.gridGroupingControl1.TableDescriptor.Columns.Contains("Categories"))
            {
                this.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear();
                this.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("Categories");
            }
            else
                MessageBox.Show("Is not currently supported");
        }

        private void barItem_Flag_Click(object sender, System.EventArgs e)
        {
            ClearChecks(parentBarItem_ArrangeBy);
            this.barItem_Custom.Checked = false;
            ShowGroupDropArea();
            this.barItem_Flag.Checked = true;
            this.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear();
            this.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("flag");
        }

        private void barItem_Type_Click(object sender, System.EventArgs e)
        {
            ClearChecks(parentBarItem_ArrangeBy);
            this.barItem_Custom.Checked = false;
            ShowGroupDropArea();
            this.barItem_Type.Checked = true;
            if (this.gridGroupingControl1.TableDescriptor.Columns.Contains("Type"))
            {
                this.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear();
                this.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("Type");
            }
            else
                MessageBox.Show("Is not currently supported");
        }

        private void barItem_GroupByBox_Click(object sender, System.EventArgs e)
        {
            this.gridGroupingControl1.ShowGroupDropArea = !this.gridGroupingControl1.ShowGroupDropArea;
        }

        private void barItem_Subject_Click(object sender, System.EventArgs e)
        {
            ClearChecks(parentBarItem_ArrangeBy);
            this.barItem_Custom.Checked = false;
            ShowGroupDropArea();
            this.barItem_Subject.Checked = true;
            this.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear();
            this.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("Subject");
        }

        private void barItem_From_Click(object sender, System.EventArgs e)
        {
            ClearChecks(parentBarItem_ArrangeBy);
            this.barItem_Custom.Checked = false;
            ShowGroupDropArea();
            this.barItem_From.Checked = true;
            this.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear();
            this.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("From");
        }

        private void barItem_Date_Click(object sender, System.EventArgs e)
        {
            ClearChecks(parentBarItem_ArrangeBy);
            this.barItem_Custom.Checked = false;
            ShowGroupDropArea();
            this.barItem_Date.Checked = true;
            this.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear();
            this.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("date");
        }

        private void barItem_Size_Click(object sender, System.EventArgs e)
        {
            ClearChecks(parentBarItem_ArrangeBy);
            this.barItem_Custom.Checked = false;
            ShowGroupDropArea();
            this.barItem_Size.Checked = true;
            this.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear();
            this.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("customSize");
            //this.gridGroupingControl1.TableDescriptor.Columns["customSize"].HeaderText = "Size";
        }

        private void barItem_ShowInGroups_Click(object sender, System.EventArgs e)
        {
            this.barItem_ShowInGroups.Checked = !this.barItem_ShowInGroups.Checked;
            ShowGroupDropArea();
        }

        private void barItem_GroupByThisField_Click(object sender, System.EventArgs e)
        {
            bool flag = false;
            foreach (SortColumnDescriptor des in this.gridGroupingControl1.TableDescriptor.GroupedColumns)
            {
                if (des.Name == groupColumn)
                    flag = true;
            }
            if (!flag)
                this.gridGroupingControl1.TableDescriptor.GroupedColumns.Add(groupColumn);
        }

        private void barItem_SortAscending_Click(object sender, System.EventArgs e)
        {
            this.gridGroupingControl1.TableDescriptor.SortedColumns.Remove(groupColumn);
            this.gridGroupingControl1.TableDescriptor.SortedColumns.Add(groupColumn, ListSortDirection.Ascending);
        }

        private void barItem_sortDescending_Click(object sender, System.EventArgs e)
        {
            this.gridGroupingControl1.TableDescriptor.SortedColumns.Remove(groupColumn);
            this.gridGroupingControl1.TableDescriptor.SortedColumns.Add(groupColumn, ListSortDirection.Descending);
        }

        private void barItem_RemoveThisColumn_Click(object sender, System.EventArgs e)
        {
            if (groupColumn == "date")
                groupColumn = "Received";
            if (groupColumn == "customSize")
                groupColumn = "Size";
            //this.gridGroupingControl1.TableDescriptor.VisibleColumns.Remove(groupColumn);
            this.gridGroupingControl1.TableDescriptor.Columns.Remove(groupColumn);
        }

        private void barItem_FieldChooser_Click(object sender, System.EventArgs e)
        {
            string[] hiddenCols = new string[this.gridGroupingControl1.TableDescriptor.Columns.Count];
            bool flag = false;
            int hiddenIndex = 0;
            string temp;
            for (int i = 0; i < hiddenCols.Length; i++)
            {
                temp = this.gridGroupingControl1.TableDescriptor.Columns[i].Name;
                for (int j = 0; j < visibleCols.Length; j++)
                {
                    if (visibleCols[j].CompareTo(temp) == 0)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    hiddenCols[hiddenIndex] = temp;
                    hiddenIndex++;
                }
                else
                    flag = false;
            }
            FieldChooserDialog dlg = new FieldChooserDialog(hiddenCols, visibleCols);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.gridGroupingControl1.TableDescriptor.VisibleColumns.Clear();
                foreach (string str in dlg.SelectedFields)
                    this.gridGroupingControl1.TableDescriptor.VisibleColumns.Add(str);
            }
        }

        private void barItem_CustomizeCurrentView_Click(object sender, System.EventArgs e)
        {
            //			CurrentView curView=new CurrentView(this);
            //			curView.ShowDialog();
        }

        # endregion

        # region Flag Menu context menu handlers

        private void redFlagBarItem_Click(object sender, System.EventArgs e)
        {
            this.gridGroupingControl1.Table.NestedDisplayElements[rowas].GetRecord().SetValue("flag", (int)flags.Red);
        }

        private void blueFlagBarItem_Click(object sender, System.EventArgs e)
        {
            this.gridGroupingControl1.Table.NestedDisplayElements[rowas].GetRecord().SetValue("flag", (int)flags.Blue);
        }

        private void yellowFlagBarItem_Click(object sender, System.EventArgs e)
        {
            this.gridGroupingControl1.Table.NestedDisplayElements[rowas].GetRecord().SetValue("flag", (int)flags.Yellow);
        }

        private void greenFlagBarItem_Click(object sender, System.EventArgs e)
        {
            this.gridGroupingControl1.Table.NestedDisplayElements[rowas].GetRecord().SetValue("flag", (int)flags.Green);
        }

        private void orangeFlagBarItem_Click(object sender, System.EventArgs e)
        {
            this.gridGroupingControl1.Table.NestedDisplayElements[rowas].GetRecord().SetValue("flag", (int)flags.Orange);
        }

        private void purpleFlagBarItem_Click(object sender, System.EventArgs e)
        {
            this.gridGroupingControl1.Table.NestedDisplayElements[rowas].GetRecord().SetValue("flag", (int)flags.Purple);
        }

        private void flagCompleteBarItem_Click(object sender, System.EventArgs e)
        {
            this.gridGroupingControl1.Table.NestedDisplayElements[rowas].GetRecord().SetValue("flag", (int)flags.Complete);
        }

        private void addReminderBarItem_Click(object sender, System.EventArgs e)
        {

        }

        private void clearFlagBarItem_Click(object sender, System.EventArgs e)
        {
            this.gridGroupingControl1.Table.NestedDisplayElements[rowas].GetRecord().SetValue("flag", (int)flags.Clear);
        }

        private void redAsDefaultBarItem_Click(object sender, System.EventArgs e)
        {
            BarItem barItem = sender as BarItem;
            this.DefaultFlag = flags.Red;
            ClearChecks(FollowUpParentBarItem);
            ClearChecks(clearflagParentBarItem);
            ClearChecks(RecordFollowUpParentBarItem);
            this.redAsDefaultBarItem.Checked = this.todayCaptionBarItem.Checked =
                this.RedAsDefaultfromRecordBarItem.Checked = true;
        }

        private void blueAsDefaultBarItem_Click(object sender, System.EventArgs e)
        {
            this.DefaultFlag = flags.Blue;
            ClearChecks(FollowUpParentBarItem);
            ClearChecks(clearflagParentBarItem);
            ClearChecks(RecordFollowUpParentBarItem);
            this.blueAsDefaultBarItem.Checked = this.tomoCaptionBarItem.Checked =
                this.BlueasDefaultfromRecordBarItem.Checked = true;
        }

        private void yellowAsDefaultBarItem_Click(object sender, System.EventArgs e)
        {
            this.DefaultFlag = flags.Yellow;
            ClearChecks(FollowUpParentBarItem);
            ClearChecks(clearflagParentBarItem);
            ClearChecks(RecordFollowUpParentBarItem);
            this.yellowAsDefaultBarItem.Checked = this.thisweekfromCaptionBarItem.Checked =
                this.YellowasDefaultfromRecordBarItem.Checked = true;
        }

        private void greenAsDefaultBarItem_Click(object sender, System.EventArgs e)
        {
            this.DefaultFlag = flags.Green;
            ClearChecks(FollowUpParentBarItem);
            ClearChecks(clearflagParentBarItem);
            ClearChecks(RecordFollowUpParentBarItem);
            this.greenAsDefaultBarItem.Checked = this.nextweekCaptionBarItem.Checked =
                this.GreenasDefaultfromRecordBarItem.Checked = true;
        }

        private void orangeAsDefaultBarItem_Click(object sender, System.EventArgs e)
        {
            this.DefaultFlag = flags.Orange;
            ClearChecks(FollowUpParentBarItem);
            ClearChecks(clearflagParentBarItem);
            ClearChecks(RecordFollowUpParentBarItem);
            this.orangeAsDefaultBarItem.Checked = this.markcompletefromCaptionBarItem.Checked =
                this.OrangeasDefaultfromRecordBarItem.Checked = true;
        }

        private void purpleAsDefaultBarItem_Click(object sender, System.EventArgs e)
        {
            this.DefaultFlag = flags.Purple;
            ClearChecks(FollowUpParentBarItem);
            ClearChecks(clearflagParentBarItem);
            ClearChecks(RecordFollowUpParentBarItem);
            this.purpleAsDefaultBarItem.Checked = this.PurpleasDefaultfromRecordBarItem.Checked =
                this.clearflagCaptionBarItem.Checked = true;
        }
        # endregion

        # region Record fields context menu handlers

        private void MarkfromRecordBarItem_Click(object sender, System.EventArgs e)
        {
            if (Convert.ToInt32(this.gridGroupingControl1.Table.NestedDisplayElements[rowas].GetRecord().GetValue("ReadState")) == 1)
                this.gridGroupingControl1.Table.NestedDisplayElements[rowas].GetRecord().SetValue("ReadState", 0);
            else if (Convert.ToInt32(this.gridGroupingControl1.Table.NestedDisplayElements[rowas].GetRecord().GetValue("ReadState")) == 0)
                this.gridGroupingControl1.Table.NestedDisplayElements[rowas].GetRecord().SetValue("ReadState", 1);
        }

        private void DeletefromRecordBarItem_Click(object sender, System.EventArgs e)
        {
            //Should take it to the delete table
            DataRow dr = this.gridGroupingControl1.Table.NestedDisplayElements[rowas].GetRecord().GetData() as DataRow;
            this.gridGroupingControl1.Table.NestedDisplayElements[rowas].GetRecord().Delete();
        }

        # endregion

        # region Caption PopUp Menu Handlers

        private void collapseAllGroupsBarItem_Click(object sender, System.EventArgs e)
        {
            this.gridGroupingControl1.Table.CollapseAllGroups();
            this.gridGroupingControl1.Refresh();
        }

        private void ExpandAllGroupsBarItem_Click(object sender, System.EventArgs e)
        {
            int i = 0;
            int count = 0;
            this.gridGroupingControl1.Table.ExpandAllGroups();
            do
            {
                Element elt = this.gridGroupingControl1.Table.NestedDisplayElements[i++];
                if (elt.Kind == DisplayElementKind.Caption)
                    count++;
            } while (count < countas);

            this.gridGroupingControl1.TableControl.Selections.Clear();
            this.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Row(i));
            //this.gridGroupingControl1.Refresh();
        }

        private void RedfromCaptionBarItem_Click(object sender, System.EventArgs e)
        {
            ApplythisGroupwithFlag((int)flags.Red);
            this.gridGroupingControl1.Refresh();
        }
        private void BluefromCaptionBarItem_Click(object sender, System.EventArgs e)
        {
            ApplythisGroupwithFlag((int)flags.Blue);
            this.gridGroupingControl1.Refresh();
        }
        private void YellowfromCaptionBarItem_Click(object sender, System.EventArgs e)
        {
            ApplythisGroupwithFlag((int)flags.Yellow);
            this.gridGroupingControl1.Refresh();
        }

        private void GreenfromCaptionBarItem_Click(object sender, System.EventArgs e)
        {
            ApplythisGroupwithFlag((int)flags.Green);
            this.gridGroupingControl1.Refresh();
        }

        private void OrangefromCaptionBarItem_Click(object sender, System.EventArgs e)
        {
            ApplythisGroupwithFlag((int)flags.Orange);
            this.gridGroupingControl1.Refresh();
        }

        private void PurplefromCaptionBarItem_Click(object sender, System.EventArgs e)
        {
            ApplythisGroupwithFlag((int)flags.Purple);
            this.gridGroupingControl1.Refresh();
        }
        private void ClearFlagfromCaptionBarItem_Click(object sender, System.EventArgs e)
        {
            ApplythisGroupwithFlag((int)flags.Clear);
            this.gridGroupingControl1.Refresh();
        }
        private void FlagCompletefromCaptionBarItem_Click(object sender, System.EventArgs e)
        {
            ApplythisGroupwithFlag((int)flags.Complete);
            this.gridGroupingControl1.Refresh();
        }
        private void MarkAsReadfromCaptionBarItem_Click(object sender, System.EventArgs e)
        {
            ApplythisGroupwithReadState((int)mail.Read);
            this.gridGroupingControl1.Refresh();
        }

        private void MarkAsUnreadfromCaptionBarItem_Click(object sender, System.EventArgs e)
        {
            ApplythisGroupwithReadState((int)mail.Unread);
            this.gridGroupingControl1.Refresh();
        }
        # endregion

        #region Category PopUp Menu Handlers

        void yellowBarItem_Click(object sender, EventArgs e)
        {
            this.gridGroupingControl1.Table.NestedDisplayElements[rowas].GetRecord().SetValue("Category", "Yellow Category");
        }

        void purpleBarItem_Click(object sender, EventArgs e)
        {
            this.gridGroupingControl1.Table.NestedDisplayElements[rowas].GetRecord().SetValue("Category", "Purple Category");
        }

        void orangeBarItem_Click(object sender, EventArgs e)
        {
            this.gridGroupingControl1.Table.NestedDisplayElements[rowas].GetRecord().SetValue("Category", "Orange Category");
        }

        void greenBarItem_Click(object sender, EventArgs e)
        {
            this.gridGroupingControl1.Table.NestedDisplayElements[rowas].GetRecord().SetValue("Category", "Green Category");
        }

        void blueBarItem_Click(object sender, EventArgs e)
        {
            this.gridGroupingControl1.Table.NestedDisplayElements[rowas].GetRecord().SetValue("Category", "Blue Category");
        }

        void redcategBarItem_Click(object sender, EventArgs e)
        {
            this.gridGroupingControl1.Table.NestedDisplayElements[rowas].GetRecord().SetValue("Category", "Red Category");
        }
        #endregion

        #endregion


    }
    # endregion

    
    
    

}