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
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

using Syncfusion.Drawing;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using Syncfusion.Windows.Forms.Schedule;

using System.Diagnostics;

namespace OutlookDemo
{
    #region Form
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : RibbonForm
    {
        #region Members
        private System.Windows.Forms.Panel parentPanel;
        private Syncfusion.Windows.Forms.Tools.GroupBar groupBar1;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem1;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem4;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem5;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem6;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem7;
        private System.Windows.Forms.Panel mailPanel;
        private System.Windows.Forms.TreeView treeView3;
        private System.Windows.Forms.ImageList smallImageList;
        private System.Windows.Forms.Panel calendarPanel;
        private System.Windows.Forms.Panel contactsPanel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.Panel tasksPanel;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.Panel notesPanel;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.RadioButton radioButton16;
        private System.Windows.Forms.RadioButton radioButton17;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem2;
        private System.Windows.Forms.Panel journalPanel;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.RadioButton radioButton18;
        private System.Windows.Forms.RadioButton radioButton19;
        private System.Windows.Forms.RadioButton radioButton20;
        private System.Windows.Forms.RadioButton radioButton21;
        private System.Windows.Forms.RadioButton radioButton22;
        private System.Windows.Forms.LinkLabel linkLabel9;
        private System.Windows.Forms.LinkLabel linkLabel11;
        private System.ComponentModel.IContainer components;
        //private AxSHDocVw.AxWebBrowser Display;

        // Outlook Groups Add/Remove Implementation		
        private System.Collections.Hashtable htLabelToImageIndex = new Hashtable();
        private System.Windows.Forms.Panel clientPanel;
        private System.Windows.Forms.Label clientPanelImage;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private System.Windows.Forms.Label clientPanelLabel2;
        private System.Windows.Forms.Label clientPanelLabel1;
        private System.Windows.Forms.Panel gridContainerPanel;
        private System.Collections.ArrayList restoreList = new ArrayList();
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.RichTextBox Display;
        private System.Windows.Forms.Panel scheduleContainerPanel;
        private System.Windows.Forms.Panel contactsGridPanel;
        private ContactsPaneForm contactForm = null;
        private CalendarForm calForm = null;
        private XPTaskBar mailTaskBar;
        private XPTaskBarBox favouritesTaskBarBox;
        private XPTaskBarBox mailTaskBarBox;
        private GradientPanel gradientPanel2;
        private GradientPanel gradientPanel3;
        private XPTaskBar xpTaskBar1;
        private XPTaskBarBox myCalendarsTaskBarBox1;
        private GradientPanel gradientPanel4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Panel panel11;
        private LinkLabel linkLabel12;
        private LinkLabel linkLabel10;
        private LinkLabel linkLabel13;
        private LinkLabel linkLabel14;
        private LinkLabel linkLabel15;
        private LinkLabel linkLabel16;
        private LinkLabel linkLabel17;
        private GradientPanel gradientPanel5;
        private XPTaskBar xpTaskBar2;
        private XPTaskBarBox myContactsTaskBarBox;
        private XPTaskBarBox currentViewTaskBarBox;
        private Panel panel2;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton25;
        private RadioButton radioButton24;
        private RadioButton radioButton23;
        private Panel panel3;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel18;
        private LinkLabel linkLabel19;
        private LinkLabel linkLabel3;
        private GradientPanel gradientPanel6;
        private XPTaskBar xpTaskBar3;
        private XPTaskBarBox mytasksTaskBarBox;
        private XPTaskBarBox currentViewTaskBarBox1;
        private RadioButton radioButton31;
        private RadioButton radioButton30;
        private RadioButton radioButton28;
        private RadioButton radioButton27;
        private LinkLabel linkLabel20;
        private LinkLabel linkLabel21;
        private Panel panel4;
        private GradientPanel gradientPanel7;
        private XPTaskBar xpTaskBar4;
        private XPTaskBarBox notesTaskBarBox;
        private XPTaskBarBox currentViewTaskBarBox2;
        private LinkLabel linkLabel22;
        private Panel panel5;
        private LinkLabel linkLabel23;
        private XPTaskBar xpTaskBar5;
        private XPTaskBarBox allFoldersTaskBarBox;
        private GradientPanel gradientPanel9;
        private Panel panel1;
        private Panel panel6;
        private GradientPanel gradientPanel10;
        private XPTaskBar xpTaskBar6;
        private XPTaskBarBox myJournalTaskBarBox;
        private XPTaskBarBox currentViewTaskBarBox3;
        private RadioButton radioButton29;
        private RadioButton radioButton26;
        private LinkLabel linkLabel25;
        private LinkLabel linkLabel24;
        private SplitContainer splitContainer1;
        private Panel folderlistPanel;
        private GradientPanel gradientPanel8;
        private Panel panel8;
        private StatusStripEx statusStripEx1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private SplashControl splashControl1;
        private RibbonControlAdv ribbonControlAdv1;
        private ToolStripEx toolStripEx1;
        private ToolStripPanelItem toolStripPanelItem1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripEx toolStripEx2;
        private ToolStripPanelItem toolStripPanelItem2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
        private ToolStripLabel toolStripLabel1;
        private ToolStripEx toolStripEx3;
        private ToolStripPanelItem toolStripPanelItem3;
        private ToolStripButton toolStripButton7;
        private ToolStripButton toolStripButton10;
        private ToolStripPanelItem toolStripPanelItem4;
        private ToolStripButton toolStripButton8;
        private ToolStripButton toolStripButton9;
        private ToolStripEx toolStripEx4;
        private ToolStripPanelItem toolStripPanelItem5;
        private ToolStripButton toolStripButton11;
        private ToolStripButton toolStripButton12;
        private ToolStripButton toolbtnswitch;
        private ToolStripTabItem toolStripStyle;
        private ToolStripTabItem toolStripFile;
        private ToolStripTabItem toolStripEdit;
        private ToolStripTabItem toolStripView;
        private ToolStripTabItem toolStripGo;
        private ToolStripTabItem toolStripAction;
        private ToolStripEx toolStripFileNew;
        private ToolStripPanelItem toolStripNewPanel;
        private ToolStripButton toolbtnmailMessage;
        private ToolStripButton toolbtnappointment;
        private ToolStripButton toolbtncontact;
        private ToolStripButton toolbtntask;
        private ToolStripButton toolbtnjournal;
        private ToolStripButton toolbtnnotes;
        private ToolStripEx toolStripFileSearch;
        private ToolStripPanelItem toolStripSearchPanel;
        private ToolStripButton toolbtnfolder;
        private ToolStripButton toolbtnsearch;
        private ToolStripEx toolStripFilePage;
        private ToolStripPanelItem toolStripPagePanel;
        private ToolStripButton toolbtnpreview;
        private ToolStripButton toolbtnprint;
        private ToolStripEx toolStripFileHelp;
        private ToolStripPanelItem toolStripHelpPanel;
        private ToolStripButton toolbtnhelp;
        private ToolStripButton toolbtnabout;
        private ToolStripEx toolStripEditAction;
        private ToolStripPanelItem toolStripActionPanel;
        private ToolStripButton toolbtnundo;
        private ToolStripButton toolbtnredo;
        private ToolStripEx toolStripEditClipBoard;
        private ToolStripPanelItem toolStripClipbdPanel;
        private ToolStripButton toolbtncopy;
        private ToolStripButton toolbtncut;
        private ToolStripPanelItem toolStripClipbd2Panel;
        private ToolStripButton toolbtnclipboard;
        private ToolStripButton toolbtnpaste;
        private ToolStripEx toolStripEditDelete;
        private ToolStripPanelItem toolStripDeletePanel;
        private ToolStripButton toolbtndel;
        private ToolStripButton toolbtnundel;
        private ToolStripPanelItem toolStripEditDelete2;
        private ToolStripButton toolbtnmove;
        private ToolStripButton toolbtncopyto;
        private ToolStripEx toolStripViewArrange;
        private ToolStripButton toolStripButton14;
        private ToolStripEx toolStripViewSwitch;
        private ToolStripEx toolStripViewExp;
        private ToolStripEx toolStripGoItems;
        private ToolStripPanelItem toolStripGoItemsPanel;
        private ToolStripButton toolbtnmail;
        private ToolStripButton toolbtncalndr;
        private ToolStripButton toolbtncnt;
        private ToolStripButton toolbtntasks;
        private ToolStripButton toolbtnGonote;
        private ToolStripEx toolStripGoMisc;
        private ToolStripPanelItem toolStripGoMiscPanel;
        private ToolStripButton toolbtnfolderlist;
        private ToolStripButton toolbtnGojournal;
        private ToolStripEx toolStripActionsMail;
        private ToolStripPanelItem toolStripActionMailPanel;
        private ToolStripButton toolbtnActionmail;
        private ToolStripButton toolbtnJunk;
        private ToolStripEx toolStripActionRespond;
        private ToolStripButton toolbtnreply;
        private ToolStripButton toolbtnreplyall;
        private ToolStripButton toolbtnfwd;
        private ToolStripEx toolStripStyles;
        private ToolStripButton toolbtnstyleBlue;
        private ToolStripButton toolbtnstyleBlack;
        private ToolStripButton toolbtnstyleSilver;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton toolbtnexit;
        private ToolStripEx toolStripEx5;
        private ToolStripPanelItem toolStripReadPane;
        private ToolStripButton toolbtnRight;
        private ToolStripButton toolbtnBottom;
        private ToolStripButton toolbtnTop;
        private ToolStripPanelItem toolStripViewSwitchPanel;
        private ToolStripCheckBox toolchknav;
        private ToolStripCheckBox toolbtnautoprev;
        private BackStageTab backStageTab2;
        private PictureBox pictureBox2;
        private BackStageTab backStageTab3;
        private PictureBox pictureBox3;
        private BackStageButton backStageButton1;
        private BackStageButton backStageButton2;
        private BackStage backStage1;
        private BackStageTab backStageTab1;
        private PictureBox pictureBox1;
        private BackStageTab backStageTab4;
        private PictureBox pictureBox4;
        private BackStageTab backStageTab5;
        private PictureBox pictureBox5;
        private BackStageButton backStageButton3;
        private BackStageButton backStageButton4;
        private BackStageView backStageView1;
        private ToolStripPanelItem toolStripViewExpand;
        private ToolStripButton toolbtnExpAllGroup;
        private ToolStripButton toolbtnCollapse;
        private ToolStripButton toolbtnExpthisGroup;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripPanelItem toolStripPanelItem6;
        private ToolStripButton toolbtnMeeting;
        private ToolStripButton toolbtnMore;

        private OutlookDemo.GroupingPanel gridGroupingPanel;

        #endregion

        #region Properties
        public GroupBar GroupBarControl
        {
            get { return this.groupBar1; }
        }

        public IEnumerator ItemStateStore
        {
            get { return this.restoreList.GetEnumerator(); }
        }

        #endregion

        public Form1()
        {
            InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"Windows\Common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
                this.splashControl1.SplashImage = System.Drawing.Image.FromFile(GetIconFile(@"../images\Splash.png"));
            }
            catch
            { }
            this.splashControl1.SplashControlPanel.BorderType = SplashBorderType.None;
            this.splashControl1.ShowDialogSplash(this);

            #region Settings

            Color[] clrDefault = new Color[]{
										Color.FromArgb(192,219,255), Color.FromArgb(188,217,255), Color.FromArgb(184,215,255),
										Color.FromArgb(181,213,255), Color.FromArgb(177,211,255), Color.FromArgb(173,209,255),
										Color.FromArgb(198,222,255), Color.FromArgb(204,225,255), Color.FromArgb(210,229,255),
										Color.FromArgb(215,232,255), Color.FromArgb(221,236,255), Color.FromArgb(227,239,255)
									};
            this.Display.Hide();
            scheduleContainerPanel.Hide();
            contactsGridPanel.Hide();
            
            // Set the 1 and 3 monthAdv instances in the Calendar panel to the previous and next month

            this.treeView1.ExpandAll();
            this.treeView3.ExpandAll();

            // Initialize the htLabelToImageIndex map - the index refers to the icon position in the smallImageList
            this.htLabelToImageIndex.Add("Mail", 2);
            this.htLabelToImageIndex.Add("Calendar", 12);
            this.htLabelToImageIndex.Add("Contacts", 9);
            this.htLabelToImageIndex.Add("Tasks", 10);
            this.htLabelToImageIndex.Add("Notes", 11);
            this.htLabelToImageIndex.Add("Folder List", 3);
            this.htLabelToImageIndex.Add("Journal", 13);

            // The restoreList is used by the OptionsForm Restore functionality to restore the GroupBarItems to the state set in the designer.
            foreach (GroupBarItem item in this.groupBar1.GroupBarItems)
                this.restoreList.Add(new GroupBarItemState(item.Text, item.InNavigationPane, item.Visible));

            this.InitializeGroupBarClientColors();

            // Set the text for the ClientPanel labels
            GroupBarItem selitem = this.groupBar1.GroupBarItems[this.groupBar1.SelectedItem];
            this.clientPanelLabel1.Text = "Inbox";
            this.clientPanelLabel2.Text = String.Empty;
            this.clientPanelImage.ImageIndex = (int)this.htLabelToImageIndex[selitem.Text];

            // Create the GroupingPanel instance that contains the grouped Essential Grid and add it to the form's placeholder Panel
            this.gridGroupingPanel = new GroupingPanel();
            this.gridContainerPanel.Controls.Add(this.gridGroupingPanel);
            this.gridGroupingPanel.Dock = DockStyle.Fill;

            this.contactForm = new ContactsPaneForm();
            this.contactsGridPanel.Controls.Add(contactForm);
            this.contactForm.Dock = DockStyle.Fill;
            this.contactForm.BringToFront();

            this.calForm = new CalendarForm();
            this.scheduleContainerPanel.Controls.Add(calForm);
            this.calForm.Dock = DockStyle.Fill;

            this.Closing += new CancelEventHandler(Form1_Closing);
            this.gridGroupingPanel.Grid.TableControl.Model.SelectionChanging += new GridSelectionChangingEventHandler(Model_SelectionChanging);
            this.gridGroupingPanel.Grid.Table.Records[0].SetCurrent();
            this.gridGroupingPanel.Grid.TableControl.Model.Selections.Add(GridRangeInfo.Row(3));//this.gridGroupingPanel.Grid.TableControl.TopRowIndex + 1));//.Records[0].GetRowIndex()));

            //this.barItem47.PerformClick();
            this.groupBar1.GroupBarItemSelectionChanging += new GroupBarItemSelectionChangingEventHandler(groupBar1_GroupBarItemSelectionChanging);
            this.toolStripStatusLabel1.Text = this.gridGroupingPanel.Grid.Table.Records.Count.ToString() + " Messages";

            this.gridGroupingPanel.Grid.Table.RecordDeleted += new RecordEventHandler(Table_RecordDeleted);
            this.mailTaskBar.SizeChanged += new EventHandler(mailTaskBar_SizeChanged);
            SetGradientColors();
            this.groupBar1.HeaderForeColor = Color.MidnightBlue;

            this.splitContainer1.Dock = DockStyle.Fill;
            this.splitContainer1.BringToFront();
            #endregion

            this.gridContainerPanel.Height = 325;
            this.gridContainerPanel.Dock = DockStyle.Top;
            this.splitter2.Dock = DockStyle.Top;
            this.panel16.Dock = DockStyle.Fill;
            this.panel16.Show();
            this.groupBar1.SelectedItem = 0;
            SetBackGroundTheme();
        }

        #region Helper Methods

        private void SetGradientColors()
        {
			Office2003Colors.GroupBarHeaderColorDark = Color.FromArgb(175, 210, 255);
			Office2003Colors.GroupBarHeaderColorLight = Color.FromArgb(227, 239, 255);
			Office2003Colors.GroupBarItemTextColor = Color.MidnightBlue;
			Office2003Colors.GroupBarHighlightColorDark = Color.FromArgb(255, 215, 103);
			Office2003Colors.GroupBarHighlightColorLight = Color.FromArgb(255, 254, 228);
			Office2003Colors.GroupBarSelectedColorDark = Color.FromArgb(251, 140, 60);
			Office2003Colors.GroupBarSelectedColorLight = Color.FromArgb(255, 211, 101);
			Office2003Colors.SeparatorColor = Color.FromArgb(101, 147, 207);
        }

        // Sets the Office2003 colors for the GroupBar's client controls
        private void InitializeGroupBarClientColors()
        {
            Office2003Colors.UpdateMenuColors();
        }

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

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Junk Mail", 3, 3);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Deleted Items", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Junk Email", 0, 0);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("InBox", 2, 2);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Sent Items", 6, 6);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Search Folders", 4, 4);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Calendar");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Contacts", 9, 9);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Drafts", 5, 5);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Journal", 13, 13);
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Personal Folders", 7, 7, new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Search Folders", 4, 4);
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Sent Items", 6, 6);
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Deleted Items", 1, 1);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Archive Folders", 8, 8, new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Drafts", 5, 5);
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("InBox", 2, 2);
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("OutBox", 3, 3);
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Sent Items", 6, 6);
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Public");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Syncfusion Email", 8, 8, new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("For Follow Up", 4, 4);
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Large Mail", 4, 4);
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Search Folders", 4, 4, new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Deleted Items", 1, 1);
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Junk Email", 0, 0);
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Inbox", 2, 2);
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Sent Items", 6, 6);
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Search Folders", 4, 4);
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Personal Folders", 7, 7, new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Search Folders", 4, 4);
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Sent Items", 6, 6);
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Deleted Items", 1, 1);
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Archive Folders", 8, 8, new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode32,
            treeNode33});
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Drafts", 5, 5);
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Inbox", 2, 2);
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Outbox", 3, 3);
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Sent Items", 6, 6);
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Public");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Syncfusion Email", 8, 8, new System.Windows.Forms.TreeNode[] {
            treeNode35,
            treeNode36,
            treeNode37,
            treeNode38,
            treeNode39});
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "ListViewItem0"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "ListViewItem1"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "ListViewItem2"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "ListViewItem3"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "ListViewItem4"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            this.parentPanel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBar1 = new Syncfusion.Windows.Forms.Tools.GroupBar();
            this.contactsPanel = new System.Windows.Forms.Panel();
            this.gradientPanel5 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.xpTaskBar2 = new Syncfusion.Windows.Forms.Tools.XPTaskBar();
            this.myContactsTaskBarBox = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.smallImageList = new System.Windows.Forms.ImageList(this.components);
            this.currentViewTaskBarBox = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton25 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton24 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton23 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.linkLabel18 = new System.Windows.Forms.LinkLabel();
            this.linkLabel19 = new System.Windows.Forms.LinkLabel();
            this.journalPanel = new System.Windows.Forms.Panel();
            this.gradientPanel10 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.linkLabel25 = new System.Windows.Forms.LinkLabel();
            this.xpTaskBar6 = new Syncfusion.Windows.Forms.Tools.XPTaskBar();
            this.myJournalTaskBarBox = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.currentViewTaskBarBox3 = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.radioButton29 = new System.Windows.Forms.RadioButton();
            this.radioButton18 = new System.Windows.Forms.RadioButton();
            this.radioButton26 = new System.Windows.Forms.RadioButton();
            this.radioButton19 = new System.Windows.Forms.RadioButton();
            this.radioButton20 = new System.Windows.Forms.RadioButton();
            this.radioButton21 = new System.Windows.Forms.RadioButton();
            this.radioButton22 = new System.Windows.Forms.RadioButton();
            this.linkLabel24 = new System.Windows.Forms.LinkLabel();
            this.linkLabel11 = new System.Windows.Forms.LinkLabel();
            this.linkLabel9 = new System.Windows.Forms.LinkLabel();
            this.folderlistPanel = new System.Windows.Forms.Panel();
            this.gradientPanel8 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.xpTaskBar5 = new Syncfusion.Windows.Forms.Tools.XPTaskBar();
            this.allFoldersTaskBarBox = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.gradientPanel9 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.calendarPanel = new System.Windows.Forms.Panel();
            this.gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.linkLabel10 = new System.Windows.Forms.LinkLabel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.linkLabel12 = new System.Windows.Forms.LinkLabel();
            this.linkLabel13 = new System.Windows.Forms.LinkLabel();
            this.xpTaskBar1 = new Syncfusion.Windows.Forms.Tools.XPTaskBar();
            this.myCalendarsTaskBarBox1 = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkLabel14 = new System.Windows.Forms.LinkLabel();
            this.linkLabel17 = new System.Windows.Forms.LinkLabel();
            this.linkLabel15 = new System.Windows.Forms.LinkLabel();
            this.linkLabel16 = new System.Windows.Forms.LinkLabel();
            this.mailPanel = new System.Windows.Forms.Panel();
            this.mailTaskBar = new Syncfusion.Windows.Forms.Tools.XPTaskBar();
            this.favouritesTaskBarBox = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.mailTaskBarBox = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.treeView3 = new System.Windows.Forms.TreeView();
            this.notesPanel = new System.Windows.Forms.Panel();
            this.gradientPanel7 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.linkLabel22 = new System.Windows.Forms.LinkLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.linkLabel23 = new System.Windows.Forms.LinkLabel();
            this.xpTaskBar4 = new Syncfusion.Windows.Forms.Tools.XPTaskBar();
            this.notesTaskBarBox = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.currentViewTaskBarBox2 = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.radioButton17 = new System.Windows.Forms.RadioButton();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.tasksPanel = new System.Windows.Forms.Panel();
            this.gradientPanel6 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.linkLabel20 = new System.Windows.Forms.LinkLabel();
            this.xpTaskBar3 = new Syncfusion.Windows.Forms.Tools.XPTaskBar();
            this.mytasksTaskBarBox = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.currentViewTaskBarBox1 = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.radioButton31 = new System.Windows.Forms.RadioButton();
            this.radioButton30 = new System.Windows.Forms.RadioButton();
            this.radioButton28 = new System.Windows.Forms.RadioButton();
            this.radioButton27 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.linkLabel21 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.groupBarItem1 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem7 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem3 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem4 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem5 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem6 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem2 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.clientPanel = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.Display = new System.Windows.Forms.RichTextBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.gridContainerPanel = new System.Windows.Forms.Panel();
            this.scheduleContainerPanel = new System.Windows.Forms.Panel();
            this.contactsGridPanel = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.clientPanelImage = new System.Windows.Forms.Label();
            this.clientPanelLabel1 = new System.Windows.Forms.Label();
            this.clientPanelLabel2 = new System.Windows.Forms.Label();
            this.statusStripEx1 = new Syncfusion.Windows.Forms.Tools.StatusStripEx();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splashControl1 = new Syncfusion.Windows.Forms.Tools.SplashControl();
            this.ribbonControlAdv1 = new Syncfusion.Windows.Forms.Tools.RibbonControlAdv();
            this.backStageView1 = new Syncfusion.Windows.Forms.BackStageView(this.components);
            this.backStage1 = new Syncfusion.Windows.Forms.BackStage();
            this.backStageTab1 = new Syncfusion.Windows.Forms.BackStageTab();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backStageTab4 = new Syncfusion.Windows.Forms.BackStageTab();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.backStageTab5 = new Syncfusion.Windows.Forms.BackStageTab();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.backStageButton3 = new Syncfusion.Windows.Forms.BackStageButton();
            this.backStageButton4 = new Syncfusion.Windows.Forms.BackStageButton();
            this.toolStripFile = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripFileNew = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripNewPanel = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolbtnmailMessage = new System.Windows.Forms.ToolStripButton();
            this.toolbtnappointment = new System.Windows.Forms.ToolStripButton();
            this.toolbtncontact = new System.Windows.Forms.ToolStripButton();
            this.toolbtntask = new System.Windows.Forms.ToolStripButton();
            this.toolbtnjournal = new System.Windows.Forms.ToolStripButton();
            this.toolbtnnotes = new System.Windows.Forms.ToolStripButton();
            this.toolStripFileSearch = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripSearchPanel = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolbtnfolder = new System.Windows.Forms.ToolStripButton();
            this.toolbtnsearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripFilePage = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripPagePanel = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolbtnpreview = new System.Windows.Forms.ToolStripButton();
            this.toolbtnprint = new System.Windows.Forms.ToolStripButton();
            this.toolStripFileHelp = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripHelpPanel = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolbtnhelp = new System.Windows.Forms.ToolStripButton();
            this.toolbtnabout = new System.Windows.Forms.ToolStripButton();
            this.toolbtnexit = new System.Windows.Forms.ToolStripButton();
            this.toolStripEdit = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripEditAction = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripActionPanel = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolbtnundo = new System.Windows.Forms.ToolStripButton();
            this.toolbtnredo = new System.Windows.Forms.ToolStripButton();
            this.toolStripEditClipBoard = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripClipbdPanel = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolbtncopy = new System.Windows.Forms.ToolStripButton();
            this.toolbtncut = new System.Windows.Forms.ToolStripButton();
            this.toolStripClipbd2Panel = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolbtnclipboard = new System.Windows.Forms.ToolStripButton();
            this.toolbtnpaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripEditDelete = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripDeletePanel = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolbtndel = new System.Windows.Forms.ToolStripButton();
            this.toolbtnundel = new System.Windows.Forms.ToolStripButton();
            this.toolStripEditDelete2 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolbtnmove = new System.Windows.Forms.ToolStripButton();
            this.toolbtncopyto = new System.Windows.Forms.ToolStripButton();
            this.toolStripView = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripViewArrange = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.toolStripViewSwitch = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripViewSwitchPanel = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolchknav = new Syncfusion.Windows.Forms.Tools.ToolStripCheckBox();
            this.toolbtnautoprev = new Syncfusion.Windows.Forms.Tools.ToolStripCheckBox();
            this.toolStripViewExp = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripViewExpand = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolbtnExpAllGroup = new System.Windows.Forms.ToolStripButton();
            this.toolbtnCollapse = new System.Windows.Forms.ToolStripButton();
            this.toolbtnExpthisGroup = new System.Windows.Forms.ToolStripButton();
            this.toolStripEx5 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripReadPane = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolbtnRight = new System.Windows.Forms.ToolStripButton();
            this.toolbtnBottom = new System.Windows.Forms.ToolStripButton();
            this.toolbtnTop = new System.Windows.Forms.ToolStripButton();
            this.toolStripGo = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripGoItems = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripGoItemsPanel = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolbtnmail = new System.Windows.Forms.ToolStripButton();
            this.toolbtncalndr = new System.Windows.Forms.ToolStripButton();
            this.toolbtncnt = new System.Windows.Forms.ToolStripButton();
            this.toolbtntasks = new System.Windows.Forms.ToolStripButton();
            this.toolbtnGonote = new System.Windows.Forms.ToolStripButton();
            this.toolStripGoMisc = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripGoMiscPanel = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolbtnfolderlist = new System.Windows.Forms.ToolStripButton();
            this.toolbtnGojournal = new System.Windows.Forms.ToolStripButton();
            this.toolStripAction = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripActionsMail = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripActionMailPanel = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolbtnActionmail = new System.Windows.Forms.ToolStripButton();
            this.toolbtnJunk = new System.Windows.Forms.ToolStripButton();
            this.toolStripActionRespond = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolbtnreply = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbtnreplyall = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbtnfwd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripPanelItem6 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolbtnMeeting = new System.Windows.Forms.ToolStripButton();
            this.toolbtnMore = new System.Windows.Forms.ToolStripButton();
            this.toolStripStyle = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripStyles = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolbtnstyleBlue = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbtnstyleBlack = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbtnstyleSilver = new System.Windows.Forms.ToolStripButton();
            this.toolbtnswitch = new System.Windows.Forms.ToolStripButton();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripPanelItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripEx2 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripPanelItem2 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripEx3 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripPanelItem3 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripPanelItem4 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripEx4 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripPanelItem5 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.backStageTab2 = new Syncfusion.Windows.Forms.BackStageTab();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.backStageTab3 = new Syncfusion.Windows.Forms.BackStageTab();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.backStageButton1 = new Syncfusion.Windows.Forms.BackStageButton();
            this.backStageButton2 = new Syncfusion.Windows.Forms.BackStageButton();
            this.parentPanel.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).BeginInit();
            this.groupBar1.SuspendLayout();
            this.contactsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel5)).BeginInit();
            this.gradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar2)).BeginInit();
            this.xpTaskBar2.SuspendLayout();
            this.currentViewTaskBarBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.journalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel10)).BeginInit();
            this.gradientPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar6)).BeginInit();
            this.xpTaskBar6.SuspendLayout();
            this.currentViewTaskBarBox3.SuspendLayout();
            this.panel14.SuspendLayout();
            this.folderlistPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel8)).BeginInit();
            this.gradientPanel8.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar5)).BeginInit();
            this.xpTaskBar5.SuspendLayout();
            this.allFoldersTaskBarBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel9)).BeginInit();
            this.gradientPanel9.SuspendLayout();
            this.calendarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).BeginInit();
            this.gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar1)).BeginInit();
            this.xpTaskBar1.SuspendLayout();
            this.myCalendarsTaskBarBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).BeginInit();
            this.gradientPanel4.SuspendLayout();
            this.mailPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mailTaskBar)).BeginInit();
            this.mailTaskBar.SuspendLayout();
            this.mailTaskBarBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            this.notesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel7)).BeginInit();
            this.gradientPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar4)).BeginInit();
            this.xpTaskBar4.SuspendLayout();
            this.currentViewTaskBarBox2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tasksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel6)).BeginInit();
            this.gradientPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar3)).BeginInit();
            this.xpTaskBar3.SuspendLayout();
            this.currentViewTaskBarBox1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.clientPanel.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.statusStripEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).BeginInit();
            this.ribbonControlAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backStage1)).BeginInit();
            this.backStage1.SuspendLayout();
            this.backStageTab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.backStageTab4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.backStageTab5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.toolStripFile.Panel.SuspendLayout();
            this.toolStripFileNew.SuspendLayout();
            this.toolStripFileSearch.SuspendLayout();
            this.toolStripFilePage.SuspendLayout();
            this.toolStripFileHelp.SuspendLayout();
            this.toolStripEdit.Panel.SuspendLayout();
            this.toolStripEditAction.SuspendLayout();
            this.toolStripEditClipBoard.SuspendLayout();
            this.toolStripEditDelete.SuspendLayout();
            this.toolStripView.Panel.SuspendLayout();
            this.toolStripViewArrange.SuspendLayout();
            this.toolStripViewSwitch.SuspendLayout();
            this.toolStripViewExp.SuspendLayout();
            this.toolStripEx5.SuspendLayout();
            this.toolStripGo.Panel.SuspendLayout();
            this.toolStripGoItems.SuspendLayout();
            this.toolStripGoMisc.SuspendLayout();
            this.toolStripAction.Panel.SuspendLayout();
            this.toolStripActionsMail.SuspendLayout();
            this.toolStripActionRespond.SuspendLayout();
            this.toolStripStyle.Panel.SuspendLayout();
            this.toolStripStyles.SuspendLayout();
            this.toolStripEx1.SuspendLayout();
            this.toolStripEx2.SuspendLayout();
            this.toolStripEx3.SuspendLayout();
            this.toolStripEx4.SuspendLayout();
            this.backStageTab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.backStageTab3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // parentPanel
            // 
            this.parentPanel.Controls.Add(this.splitContainer1);
            this.parentPanel.Controls.Add(this.statusStripEx1);
            this.parentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parentPanel.Location = new System.Drawing.Point(6, 157);
            this.parentPanel.Name = "parentPanel";
            this.parentPanel.Size = new System.Drawing.Size(862, 579);
            this.parentPanel.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(215)))), ((int)(((byte)(252)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBar1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.clientPanel);
            this.splitContainer1.Size = new System.Drawing.Size(862, 579);
            this.splitContainer1.SplitterDistance = 169;
            this.splitContainer1.TabIndex = 1002;
            // 
            // groupBar1
            // 
            this.groupBar1.AllowDrop = true;
            this.groupBar1.AnimatedSelection = false;
            this.groupBar1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupBar1.Controls.Add(this.contactsPanel);
            this.groupBar1.Controls.Add(this.journalPanel);
            this.groupBar1.Controls.Add(this.folderlistPanel);
            this.groupBar1.Controls.Add(this.calendarPanel);
            this.groupBar1.Controls.Add(this.mailPanel);
            this.groupBar1.Controls.Add(this.notesPanel);
            this.groupBar1.Controls.Add(this.tasksPanel);
            this.groupBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBar1.ExpandButtonToolTip = null;
            this.groupBar1.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold);
            this.groupBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(77)))), ((int)(((byte)(140)))));
            this.groupBar1.GroupBarDropDownToolTip = null;
            this.groupBar1.GroupBarItemCursor = System.Windows.Forms.Cursors.Hand;
            this.groupBar1.GroupBarItemHeight = 32;
            this.groupBar1.GroupBarItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupBarItem[] {
            this.groupBarItem1,
            this.groupBarItem7,
            this.groupBarItem3,
            this.groupBarItem4,
            this.groupBarItem5,
            this.groupBarItem6,
            this.groupBarItem2});
            this.groupBar1.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))));
            this.groupBar1.IndexOnVisibleItems = true;
            this.groupBar1.Location = new System.Drawing.Point(0, 0);
            this.groupBar1.MinimizeButtonToolTip = null;
            this.groupBar1.Name = "groupBar1";
            this.groupBar1.NavigationPaneTooltip = null;
            this.groupBar1.PopupClientSize = new System.Drawing.Size(0, 0);
            this.groupBar1.SelectedItem = 2;
            this.groupBar1.Size = new System.Drawing.Size(169, 579);
            this.groupBar1.StackedMode = true;
            this.groupBar1.TabIndex = 0;
            this.groupBar1.Text = "groupBar1";
            this.groupBar1.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left;
            this.groupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.groupBar1.GroupBarItemSelected += new System.EventHandler(this.groupBar1_GroupBarItemSelected);
            this.groupBar1.NavigationPaneDropDownClick += new Syncfusion.Windows.Forms.Tools.NavigationPaneDropDownClickEventHandler(this.groupBar1_NavigationPaneDropDownClick);
            // 
            // contactsPanel
            // 
            this.contactsPanel.Controls.Add(this.gradientPanel5);
            this.contactsPanel.Location = new System.Drawing.Point(1, 27);
            this.contactsPanel.Name = "contactsPanel";
            this.contactsPanel.Size = new System.Drawing.Size(167, 289);
            this.contactsPanel.TabIndex = 1;
            // 
            // gradientPanel5
            // 
            this.gradientPanel5.BackColor = System.Drawing.Color.White;
            this.gradientPanel5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel5.Controls.Add(this.linkLabel1);
            this.gradientPanel5.Controls.Add(this.panel3);
            this.gradientPanel5.Controls.Add(this.linkLabel2);
            this.gradientPanel5.Controls.Add(this.xpTaskBar2);
            this.gradientPanel5.Controls.Add(this.linkLabel18);
            this.gradientPanel5.Controls.Add(this.linkLabel19);
            this.gradientPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel5.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel5.Name = "gradientPanel5";
            this.gradientPanel5.Size = new System.Drawing.Size(167, 289);
            this.gradientPanel5.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel1.Location = new System.Drawing.Point(9, 264);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(125, 14);
            this.linkLabel1.TabIndex = 1003;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Open Shared Contacts...";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 253);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 5);
            this.panel3.TabIndex = 1;
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel2.Location = new System.Drawing.Point(9, 282);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(140, 14);
            this.linkLabel2.TabIndex = 1004;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Share My Contacts Folder...";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // xpTaskBar2
            // 
            this.xpTaskBar2.BackColor = System.Drawing.Color.White;
            this.xpTaskBar2.BorderColor = System.Drawing.Color.Black;
            this.xpTaskBar2.Controls.Add(this.myContactsTaskBarBox);
            this.xpTaskBar2.Controls.Add(this.currentViewTaskBarBox);
            this.xpTaskBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.xpTaskBar2.Location = new System.Drawing.Point(0, 0);
            this.xpTaskBar2.MinimumSize = new System.Drawing.Size(0, 0);
            this.xpTaskBar2.Name = "xpTaskBar2";
            this.xpTaskBar2.Size = new System.Drawing.Size(167, 253);
            this.xpTaskBar2.TabIndex = 0;
            // 
            // myContactsTaskBarBox
            // 
            this.myContactsTaskBarBox.BackColor = System.Drawing.SystemColors.Control;
            this.myContactsTaskBarBox.DrawFocusRect = false;
            this.myContactsTaskBarBox.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.myContactsTaskBarBox.HeaderForeColor = System.Drawing.Color.MidnightBlue;
            this.myContactsTaskBarBox.HeaderImageIndex = -1;
            this.myContactsTaskBarBox.HitTaskBoxArea = false;
            this.myContactsTaskBarBox.HotTrackColor = System.Drawing.Color.Empty;
            this.myContactsTaskBarBox.ImageList = this.smallImageList;
            this.myContactsTaskBarBox.ItemBackColor = System.Drawing.Color.White;
            this.myContactsTaskBarBox.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPTaskBarItem[] {
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Contacts", System.Drawing.Color.Empty, 38, null, "", true, true, "XPTaskBarItem4", new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), 0)});
            this.myContactsTaskBarBox.Location = new System.Drawing.Point(0, 0);
            this.myContactsTaskBarBox.Name = "myContactsTaskBarBox";
            this.myContactsTaskBarBox.Size = new System.Drawing.Size(167, 54);
            this.myContactsTaskBarBox.TabIndex = 0;
            this.myContactsTaskBarBox.Text = "My Contacts";
            this.myContactsTaskBarBox.ProvideHeaderBackgroundBrush += new Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(this.TaskBarBox_ProvideHeaderBackgroundBrush);
            // 
            // smallImageList
            // 
            this.smallImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallImageList.ImageStream")));
            this.smallImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.smallImageList.Images.SetKeyName(0, "");
            this.smallImageList.Images.SetKeyName(1, "");
            this.smallImageList.Images.SetKeyName(2, "");
            this.smallImageList.Images.SetKeyName(3, "");
            this.smallImageList.Images.SetKeyName(4, "");
            this.smallImageList.Images.SetKeyName(5, "");
            this.smallImageList.Images.SetKeyName(6, "");
            this.smallImageList.Images.SetKeyName(7, "");
            this.smallImageList.Images.SetKeyName(8, "");
            this.smallImageList.Images.SetKeyName(9, "");
            this.smallImageList.Images.SetKeyName(10, "");
            this.smallImageList.Images.SetKeyName(11, "");
            this.smallImageList.Images.SetKeyName(12, "");
            this.smallImageList.Images.SetKeyName(13, "");
            this.smallImageList.Images.SetKeyName(14, "");
            this.smallImageList.Images.SetKeyName(15, "");
            this.smallImageList.Images.SetKeyName(16, "");
            this.smallImageList.Images.SetKeyName(17, "");
            this.smallImageList.Images.SetKeyName(18, "");
            this.smallImageList.Images.SetKeyName(19, "");
            this.smallImageList.Images.SetKeyName(20, "");
            this.smallImageList.Images.SetKeyName(21, "");
            this.smallImageList.Images.SetKeyName(22, "");
            this.smallImageList.Images.SetKeyName(23, "");
            this.smallImageList.Images.SetKeyName(24, "");
            this.smallImageList.Images.SetKeyName(25, "");
            this.smallImageList.Images.SetKeyName(26, "");
            this.smallImageList.Images.SetKeyName(27, "");
            this.smallImageList.Images.SetKeyName(28, "");
            this.smallImageList.Images.SetKeyName(29, "");
            this.smallImageList.Images.SetKeyName(30, "");
            this.smallImageList.Images.SetKeyName(31, "");
            this.smallImageList.Images.SetKeyName(32, "");
            this.smallImageList.Images.SetKeyName(33, "");
            this.smallImageList.Images.SetKeyName(34, "");
            this.smallImageList.Images.SetKeyName(35, "");
            this.smallImageList.Images.SetKeyName(36, "");
            this.smallImageList.Images.SetKeyName(37, "");
            this.smallImageList.Images.SetKeyName(38, "");
            this.smallImageList.Images.SetKeyName(39, "");
            this.smallImageList.Images.SetKeyName(40, "");
            this.smallImageList.Images.SetKeyName(41, "");
            this.smallImageList.Images.SetKeyName(42, "");
            this.smallImageList.Images.SetKeyName(43, "");
            this.smallImageList.Images.SetKeyName(44, "");
            this.smallImageList.Images.SetKeyName(45, "");
            this.smallImageList.Images.SetKeyName(46, "");
            this.smallImageList.Images.SetKeyName(47, "");
            this.smallImageList.Images.SetKeyName(48, "");
            this.smallImageList.Images.SetKeyName(49, "today.png");
            // 
            // currentViewTaskBarBox
            // 
            this.currentViewTaskBarBox.Controls.Add(this.panel2);
            this.currentViewTaskBarBox.DrawFocusRect = false;
            this.currentViewTaskBarBox.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.currentViewTaskBarBox.HeaderForeColor = System.Drawing.Color.MidnightBlue;
            this.currentViewTaskBarBox.HeaderImageIndex = -1;
            this.currentViewTaskBarBox.HitTaskBoxArea = false;
            this.currentViewTaskBarBox.HotTrackColor = System.Drawing.Color.Empty;
            this.currentViewTaskBarBox.ItemBackColor = System.Drawing.Color.White;
            this.currentViewTaskBarBox.Location = new System.Drawing.Point(0, 54);
            this.currentViewTaskBarBox.Name = "currentViewTaskBarBox";
            this.currentViewTaskBarBox.PreferredChildPanelHeight = 165;
            this.currentViewTaskBarBox.Size = new System.Drawing.Size(167, 196);
            this.currentViewTaskBarBox.TabIndex = 1;
            this.currentViewTaskBarBox.Text = "Current View";
            this.currentViewTaskBarBox.ProvideHeaderBackgroundBrush += new Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(this.TaskBarBox_ProvideHeaderBackgroundBrush);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.radioButton25);
            this.panel2.Controls.Add(this.radioButton5);
            this.panel2.Controls.Add(this.radioButton24);
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Controls.Add(this.radioButton23);
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Location = new System.Drawing.Point(2, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 165);
            this.panel2.TabIndex = 2;
            // 
            // radioButton25
            // 
            this.radioButton25.AutoSize = true;
            this.radioButton25.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton25.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton25.Location = new System.Drawing.Point(10, 143);
            this.radioButton25.Name = "radioButton25";
            this.radioButton25.Size = new System.Drawing.Size(133, 20);
            this.radioButton25.TabIndex = 2;
            this.radioButton25.TabStop = true;
            this.radioButton25.Text = "Outlook Data Files";
            this.radioButton25.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(10, 102);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(98, 20);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.Text = "By Company";
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton24
            // 
            this.radioButton24.AutoSize = true;
            this.radioButton24.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton24.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton24.Location = new System.Drawing.Point(10, 123);
            this.radioButton24.Name = "radioButton24";
            this.radioButton24.Size = new System.Drawing.Size(93, 20);
            this.radioButton24.TabIndex = 1;
            this.radioButton24.TabStop = true;
            this.radioButton24.Text = "By Location";
            this.radioButton24.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackColor = System.Drawing.SystemColors.Window;
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(10, 82);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(95, 20);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "By Category";
            this.radioButton4.UseVisualStyleBackColor = false;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton23
            // 
            this.radioButton23.AutoSize = true;
            this.radioButton23.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton23.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton23.Location = new System.Drawing.Point(10, 4);
            this.radioButton23.Name = "radioButton23";
            this.radioButton23.Size = new System.Drawing.Size(115, 20);
            this.radioButton23.TabIndex = 0;
            this.radioButton23.TabStop = true;
            this.radioButton23.Text = "Business Cards";
            this.radioButton23.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(10, 62);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(87, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Phone List";
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(10, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(159, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Detailed Address Cards";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(10, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Address Cards";
            // 
            // linkLabel18
            // 
            this.linkLabel18.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel18.AutoSize = true;
            this.linkLabel18.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel18.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel18.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel18.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel18.Location = new System.Drawing.Point(9, 299);
            this.linkLabel18.Name = "linkLabel18";
            this.linkLabel18.Size = new System.Drawing.Size(84, 14);
            this.linkLabel18.TabIndex = 1005;
            this.linkLabel18.TabStop = true;
            this.linkLabel18.Text = "Add New Group";
            this.linkLabel18.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // linkLabel19
            // 
            this.linkLabel19.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel19.AutoSize = true;
            this.linkLabel19.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel19.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel19.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel19.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel19.Location = new System.Drawing.Point(9, 317);
            this.linkLabel19.Name = "linkLabel19";
            this.linkLabel19.Size = new System.Drawing.Size(133, 14);
            this.linkLabel19.TabIndex = 1006;
            this.linkLabel19.TabStop = true;
            this.linkLabel19.Text = "Customize Current View...";
            this.linkLabel19.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // journalPanel
            // 
            this.journalPanel.BackColor = System.Drawing.SystemColors.Window;
            this.journalPanel.Controls.Add(this.gradientPanel10);
            this.journalPanel.Location = new System.Drawing.Point(1, 225);
            this.journalPanel.Name = "journalPanel";
            this.journalPanel.Size = new System.Drawing.Size(218, 74);
            this.journalPanel.TabIndex = 4;
            // 
            // gradientPanel10
            // 
            this.gradientPanel10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel10.Controls.Add(this.panel8);
            this.gradientPanel10.Controls.Add(this.linkLabel25);
            this.gradientPanel10.Controls.Add(this.xpTaskBar6);
            this.gradientPanel10.Controls.Add(this.linkLabel24);
            this.gradientPanel10.Controls.Add(this.linkLabel11);
            this.gradientPanel10.Controls.Add(this.linkLabel9);
            this.gradientPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel10.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel10.Name = "gradientPanel10";
            this.gradientPanel10.Size = new System.Drawing.Size(218, 74);
            this.gradientPanel10.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 263);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(218, 5);
            this.panel8.TabIndex = 4;
            // 
            // linkLabel25
            // 
            this.linkLabel25.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel25.AutoSize = true;
            this.linkLabel25.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel25.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel25.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel25.Location = new System.Drawing.Point(6, 309);
            this.linkLabel25.Name = "linkLabel25";
            this.linkLabel25.Size = new System.Drawing.Size(84, 14);
            this.linkLabel25.TabIndex = 3;
            this.linkLabel25.TabStop = true;
            this.linkLabel25.Text = "Add New Group";
            this.linkLabel25.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // xpTaskBar6
            // 
            this.xpTaskBar6.BackColor = System.Drawing.Color.White;
            this.xpTaskBar6.BorderColor = System.Drawing.Color.Black;
            this.xpTaskBar6.Controls.Add(this.myJournalTaskBarBox);
            this.xpTaskBar6.Controls.Add(this.currentViewTaskBarBox3);
            this.xpTaskBar6.Dock = System.Windows.Forms.DockStyle.Top;
            this.xpTaskBar6.Location = new System.Drawing.Point(0, 0);
            this.xpTaskBar6.MinimumSize = new System.Drawing.Size(0, 0);
            this.xpTaskBar6.Name = "xpTaskBar6";
            this.xpTaskBar6.Size = new System.Drawing.Size(218, 263);
            this.xpTaskBar6.TabIndex = 0;
            // 
            // myJournalTaskBarBox
            // 
            this.myJournalTaskBarBox.DrawFocusRect = false;
            this.myJournalTaskBarBox.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.myJournalTaskBarBox.HeaderFont = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myJournalTaskBarBox.HeaderForeColor = System.Drawing.Color.MidnightBlue;
            this.myJournalTaskBarBox.HeaderImageIndex = -1;
            this.myJournalTaskBarBox.HitTaskBoxArea = false;
            this.myJournalTaskBarBox.HotTrackColor = System.Drawing.Color.Empty;
            this.myJournalTaskBarBox.ImageList = this.smallImageList;
            this.myJournalTaskBarBox.ItemBackColor = System.Drawing.Color.White;
            this.myJournalTaskBarBox.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPTaskBarItem[] {
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Journal", System.Drawing.Color.Empty, 13, null, "", true, true, "XPTaskBarItem9", new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Journal in Archive Folders", System.Drawing.Color.Empty, 13, null, "", true, true, "XPTaskBarItem10", new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), 0)});
            this.myJournalTaskBarBox.Location = new System.Drawing.Point(0, 0);
            this.myJournalTaskBarBox.Name = "myJournalTaskBarBox";
            this.myJournalTaskBarBox.Size = new System.Drawing.Size(218, 76);
            this.myJournalTaskBarBox.TabIndex = 0;
            this.myJournalTaskBarBox.Text = "My Journal";
            this.myJournalTaskBarBox.ProvideHeaderBackgroundBrush += new Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(this.TaskBarBox_ProvideHeaderBackgroundBrush);
            // 
            // currentViewTaskBarBox3
            // 
            this.currentViewTaskBarBox3.Controls.Add(this.panel14);
            this.currentViewTaskBarBox3.DrawFocusRect = false;
            this.currentViewTaskBarBox3.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.currentViewTaskBarBox3.HeaderForeColor = System.Drawing.Color.MidnightBlue;
            this.currentViewTaskBarBox3.HeaderImageIndex = -1;
            this.currentViewTaskBarBox3.HitTaskBoxArea = false;
            this.currentViewTaskBarBox3.HotTrackColor = System.Drawing.Color.Empty;
            this.currentViewTaskBarBox3.ItemBackColor = System.Drawing.Color.White;
            this.currentViewTaskBarBox3.Location = new System.Drawing.Point(0, 76);
            this.currentViewTaskBarBox3.Name = "currentViewTaskBarBox3";
            this.currentViewTaskBarBox3.PreferredChildPanelHeight = 150;
            this.currentViewTaskBarBox3.Size = new System.Drawing.Size(218, 181);
            this.currentViewTaskBarBox3.TabIndex = 1;
            this.currentViewTaskBarBox3.Text = "Current View";
            this.currentViewTaskBarBox3.ProvideHeaderBackgroundBrush += new Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(this.TaskBarBox_ProvideHeaderBackgroundBrush);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel14.Controls.Add(this.radioButton29);
            this.panel14.Controls.Add(this.radioButton18);
            this.panel14.Controls.Add(this.radioButton26);
            this.panel14.Controls.Add(this.radioButton19);
            this.panel14.Controls.Add(this.radioButton20);
            this.panel14.Controls.Add(this.radioButton21);
            this.panel14.Controls.Add(this.radioButton22);
            this.panel14.Location = new System.Drawing.Point(2, 29);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(214, 150);
            this.panel14.TabIndex = 6;
            // 
            // radioButton29
            // 
            this.radioButton29.AutoSize = true;
            this.radioButton29.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton29.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton29.Location = new System.Drawing.Point(6, 128);
            this.radioButton29.Name = "radioButton29";
            this.radioButton29.Size = new System.Drawing.Size(133, 20);
            this.radioButton29.TabIndex = 3;
            this.radioButton29.TabStop = true;
            this.radioButton29.Text = "Outlook Data Files";
            this.radioButton29.UseVisualStyleBackColor = true;
            // 
            // radioButton18
            // 
            this.radioButton18.AutoSize = true;
            this.radioButton18.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton18.Location = new System.Drawing.Point(6, 108);
            this.radioButton18.Name = "radioButton18";
            this.radioButton18.Size = new System.Drawing.Size(96, 20);
            this.radioButton18.TabIndex = 4;
            this.radioButton18.Text = "Phone Calls";
            // 
            // radioButton26
            // 
            this.radioButton26.AutoSize = true;
            this.radioButton26.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton26.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton26.Location = new System.Drawing.Point(6, 90);
            this.radioButton26.Name = "radioButton26";
            this.radioButton26.Size = new System.Drawing.Size(117, 20);
            this.radioButton26.TabIndex = 2;
            this.radioButton26.TabStop = true;
            this.radioButton26.Text = "Last Seven Days";
            this.radioButton26.UseVisualStyleBackColor = true;
            // 
            // radioButton19
            // 
            this.radioButton19.AutoSize = true;
            this.radioButton19.BackColor = System.Drawing.SystemColors.Window;
            this.radioButton19.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton19.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton19.Location = new System.Drawing.Point(6, 68);
            this.radioButton19.Name = "radioButton19";
            this.radioButton19.Size = new System.Drawing.Size(81, 20);
            this.radioButton19.TabIndex = 3;
            this.radioButton19.Text = "Entry List";
            this.radioButton19.UseVisualStyleBackColor = false;
            // 
            // radioButton20
            // 
            this.radioButton20.AutoSize = true;
            this.radioButton20.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton20.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton20.Location = new System.Drawing.Point(6, 46);
            this.radioButton20.Name = "radioButton20";
            this.radioButton20.Size = new System.Drawing.Size(95, 20);
            this.radioButton20.TabIndex = 2;
            this.radioButton20.Text = "By Category";
            // 
            // radioButton21
            // 
            this.radioButton21.AutoSize = true;
            this.radioButton21.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton21.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton21.Location = new System.Drawing.Point(6, 24);
            this.radioButton21.Name = "radioButton21";
            this.radioButton21.Size = new System.Drawing.Size(89, 20);
            this.radioButton21.TabIndex = 1;
            this.radioButton21.Text = "By Contact";
            // 
            // radioButton22
            // 
            this.radioButton22.AutoSize = true;
            this.radioButton22.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton22.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton22.Location = new System.Drawing.Point(6, 2);
            this.radioButton22.Name = "radioButton22";
            this.radioButton22.Size = new System.Drawing.Size(71, 20);
            this.radioButton22.TabIndex = 0;
            this.radioButton22.Text = "By Type";
            // 
            // linkLabel24
            // 
            this.linkLabel24.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel24.AutoSize = true;
            this.linkLabel24.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel24.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel24.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel24.Location = new System.Drawing.Point(6, 293);
            this.linkLabel24.Name = "linkLabel24";
            this.linkLabel24.Size = new System.Drawing.Size(125, 14);
            this.linkLabel24.TabIndex = 2;
            this.linkLabel24.TabStop = true;
            this.linkLabel24.Text = "Share My Journal Folder";
            this.linkLabel24.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // linkLabel11
            // 
            this.linkLabel11.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel11.AutoSize = true;
            this.linkLabel11.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel11.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel11.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel11.Location = new System.Drawing.Point(6, 276);
            this.linkLabel11.Name = "linkLabel11";
            this.linkLabel11.Size = new System.Drawing.Size(126, 14);
            this.linkLabel11.TabIndex = 0;
            this.linkLabel11.TabStop = true;
            this.linkLabel11.Text = "Open a Shared Journal...";
            this.linkLabel11.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // linkLabel9
            // 
            this.linkLabel9.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel9.AutoSize = true;
            this.linkLabel9.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel9.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel9.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel9.Location = new System.Drawing.Point(6, 327);
            this.linkLabel9.Name = "linkLabel9";
            this.linkLabel9.Size = new System.Drawing.Size(133, 14);
            this.linkLabel9.TabIndex = 1;
            this.linkLabel9.TabStop = true;
            this.linkLabel9.Text = "Customize Current View...";
            this.linkLabel9.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // folderlistPanel
            // 
            this.folderlistPanel.Controls.Add(this.gradientPanel8);
            this.folderlistPanel.Location = new System.Drawing.Point(1, 27);
            this.folderlistPanel.Name = "folderlistPanel";
            this.folderlistPanel.Size = new System.Drawing.Size(205, 453);
            this.folderlistPanel.TabIndex = 1;
            // 
            // gradientPanel8
            // 
            this.gradientPanel8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel8.Controls.Add(this.panel6);
            this.gradientPanel8.Controls.Add(this.xpTaskBar5);
            this.gradientPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel8.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel8.Name = "gradientPanel8";
            this.gradientPanel8.Size = new System.Drawing.Size(205, 453);
            this.gradientPanel8.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.linkLabel7);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.linkLabel8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 391);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(205, 62);
            this.panel6.TabIndex = 2;
            // 
            // linkLabel7
            // 
            this.linkLabel7.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel7.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel7.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel7.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel7.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel7.Location = new System.Drawing.Point(11, 31);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(176, 16);
            this.linkLabel7.TabIndex = 1;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "Data File Management...";
            this.linkLabel7.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 6);
            this.panel1.TabIndex = 1;
            // 
            // linkLabel8
            // 
            this.linkLabel8.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel8.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel8.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel8.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel8.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel8.Location = new System.Drawing.Point(11, 10);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(176, 16);
            this.linkLabel8.TabIndex = 0;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "Folder Sizes";
            this.linkLabel8.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // xpTaskBar5
            // 
            this.xpTaskBar5.BackColor = System.Drawing.Color.White;
            this.xpTaskBar5.BorderColor = System.Drawing.Color.Black;
            this.xpTaskBar5.Controls.Add(this.allFoldersTaskBarBox);
            this.xpTaskBar5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpTaskBar5.Location = new System.Drawing.Point(0, 0);
            this.xpTaskBar5.MinimumSize = new System.Drawing.Size(0, 0);
            this.xpTaskBar5.Name = "xpTaskBar5";
            this.xpTaskBar5.Size = new System.Drawing.Size(205, 453);
            this.xpTaskBar5.TabIndex = 0;
            // 
            // allFoldersTaskBarBox
            // 
            this.allFoldersTaskBarBox.Controls.Add(this.gradientPanel9);
            this.allFoldersTaskBarBox.DrawFocusRect = false;
            this.allFoldersTaskBarBox.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.allFoldersTaskBarBox.HeaderFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allFoldersTaskBarBox.HeaderForeColor = System.Drawing.Color.MidnightBlue;
            this.allFoldersTaskBarBox.HeaderImageIndex = -1;
            this.allFoldersTaskBarBox.HitTaskBoxArea = false;
            this.allFoldersTaskBarBox.HotTrackColor = System.Drawing.Color.Empty;
            this.allFoldersTaskBarBox.ItemBackColor = System.Drawing.Color.White;
            this.allFoldersTaskBarBox.Location = new System.Drawing.Point(0, 0);
            this.allFoldersTaskBarBox.Name = "allFoldersTaskBarBox";
            this.allFoldersTaskBarBox.PreferredChildPanelHeight = 360;
            this.allFoldersTaskBarBox.Size = new System.Drawing.Size(205, 392);
            this.allFoldersTaskBarBox.TabIndex = 0;
            this.allFoldersTaskBarBox.Text = "All Folders";
            this.allFoldersTaskBarBox.ProvideHeaderBackgroundBrush += new Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(this.TaskBarBox_ProvideHeaderBackgroundBrush);
            // 
            // gradientPanel9
            // 
            this.gradientPanel9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel9.Controls.Add(this.treeView1);
            this.gradientPanel9.Location = new System.Drawing.Point(2, 30);
            this.gradientPanel9.Name = "gradientPanel9";
            this.gradientPanel9.Size = new System.Drawing.Size(201, 360);
            this.gradientPanel9.TabIndex = 5;
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.smallImageList;
            this.treeView1.Indent = 25;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 3;
            treeNode1.Name = "";
            treeNode1.SelectedImageIndex = 3;
            treeNode1.Text = "Junk Mail";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "Deleted Items";
            treeNode3.ImageIndex = 0;
            treeNode3.Name = "";
            treeNode3.SelectedImageIndex = 0;
            treeNode3.Text = "Junk Email";
            treeNode4.ImageIndex = 2;
            treeNode4.Name = "";
            treeNode4.SelectedImageIndex = 2;
            treeNode4.Text = "InBox";
            treeNode5.ImageIndex = 6;
            treeNode5.Name = "";
            treeNode5.SelectedImageIndex = 6;
            treeNode5.Text = "Sent Items";
            treeNode6.ImageIndex = 4;
            treeNode6.Name = "";
            treeNode6.SelectedImageIndex = 4;
            treeNode6.Text = "Search Folders";
            treeNode7.Name = "";
            treeNode7.Text = "Calendar";
            treeNode8.ImageIndex = 9;
            treeNode8.Name = "";
            treeNode8.SelectedImageIndex = 9;
            treeNode8.Text = "Contacts";
            treeNode9.ImageIndex = 5;
            treeNode9.Name = "";
            treeNode9.SelectedImageIndex = 5;
            treeNode9.Text = "Drafts";
            treeNode10.ImageIndex = 13;
            treeNode10.Name = "";
            treeNode10.SelectedImageIndex = 13;
            treeNode10.Text = "Journal";
            treeNode11.ImageIndex = 7;
            treeNode11.Name = "";
            treeNode11.SelectedImageIndex = 7;
            treeNode11.Text = "Personal Folders";
            treeNode12.ImageIndex = 4;
            treeNode12.Name = "";
            treeNode12.SelectedImageIndex = 4;
            treeNode12.Text = "Search Folders";
            treeNode13.ImageIndex = 6;
            treeNode13.Name = "";
            treeNode13.SelectedImageIndex = 6;
            treeNode13.Text = "Sent Items";
            treeNode14.ImageIndex = 1;
            treeNode14.Name = "";
            treeNode14.SelectedImageIndex = 1;
            treeNode14.Text = "Deleted Items";
            treeNode15.ImageIndex = 8;
            treeNode15.Name = "";
            treeNode15.SelectedImageIndex = 8;
            treeNode15.Text = "Archive Folders";
            treeNode16.ImageIndex = 5;
            treeNode16.Name = "";
            treeNode16.SelectedImageIndex = 5;
            treeNode16.Text = "Drafts";
            treeNode17.ImageIndex = 2;
            treeNode17.Name = "";
            treeNode17.SelectedImageIndex = 2;
            treeNode17.Text = "InBox";
            treeNode18.ImageIndex = 3;
            treeNode18.Name = "";
            treeNode18.SelectedImageIndex = 3;
            treeNode18.Text = "OutBox";
            treeNode19.ImageIndex = 6;
            treeNode19.Name = "";
            treeNode19.SelectedImageIndex = 6;
            treeNode19.Text = "Sent Items";
            treeNode20.Name = "";
            treeNode20.Text = "Public";
            treeNode21.ImageIndex = 8;
            treeNode21.Name = "";
            treeNode21.SelectedImageIndex = 8;
            treeNode21.Text = "Syncfusion Email";
            treeNode22.ImageIndex = 4;
            treeNode22.Name = "";
            treeNode22.SelectedImageIndex = 4;
            treeNode22.Text = "For Follow Up";
            treeNode23.ImageIndex = 4;
            treeNode23.Name = "";
            treeNode23.SelectedImageIndex = 4;
            treeNode23.Text = "Large Mail";
            treeNode24.ImageIndex = 4;
            treeNode24.Name = "";
            treeNode24.SelectedImageIndex = 4;
            treeNode24.Text = "Search Folders";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode15,
            treeNode21,
            treeNode24});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(201, 360);
            this.treeView1.TabIndex = 4;
            // 
            // calendarPanel
            // 
            this.calendarPanel.BackColor = System.Drawing.Color.White;
            this.calendarPanel.Controls.Add(this.gradientPanel3);
            this.calendarPanel.Location = new System.Drawing.Point(1, 27);
            this.calendarPanel.Name = "calendarPanel";
            this.calendarPanel.Size = new System.Drawing.Size(205, 453);
            this.calendarPanel.TabIndex = 1;
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            this.gradientPanel3.Controls.Add(this.linkLabel10);
            this.gradientPanel3.Controls.Add(this.panel11);
            this.gradientPanel3.Controls.Add(this.linkLabel12);
            this.gradientPanel3.Controls.Add(this.linkLabel13);
            this.gradientPanel3.Controls.Add(this.xpTaskBar1);
            this.gradientPanel3.Controls.Add(this.linkLabel14);
            this.gradientPanel3.Controls.Add(this.linkLabel17);
            this.gradientPanel3.Controls.Add(this.linkLabel15);
            this.gradientPanel3.Controls.Add(this.linkLabel16);
            this.gradientPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel3.Location = new System.Drawing.Point(0, 215);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(205, 238);
            this.gradientPanel3.TabIndex = 0;
            // 
            // linkLabel10
            // 
            this.linkLabel10.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel10.AutoSize = true;
            this.linkLabel10.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.linkLabel10.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel10.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel10.Location = new System.Drawing.Point(9, 96);
            this.linkLabel10.Name = "linkLabel10";
            this.linkLabel10.Size = new System.Drawing.Size(124, 14);
            this.linkLabel10.TabIndex = 2;
            this.linkLabel10.TabStop = true;
            this.linkLabel10.Text = "How to Share Calendars";
            this.linkLabel10.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 79);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(201, 5);
            this.panel11.TabIndex = 1;
            // 
            // linkLabel12
            // 
            this.linkLabel12.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel12.AutoSize = true;
            this.linkLabel12.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.linkLabel12.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel12.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel12.Location = new System.Drawing.Point(9, 117);
            this.linkLabel12.Name = "linkLabel12";
            this.linkLabel12.Size = new System.Drawing.Size(133, 14);
            this.linkLabel12.TabIndex = 3;
            this.linkLabel12.TabStop = true;
            this.linkLabel12.Text = "Open a Shared Calendar...";
            this.linkLabel12.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // linkLabel13
            // 
            this.linkLabel13.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel13.AutoSize = true;
            this.linkLabel13.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel13.ForeColor = System.Drawing.SystemColors.Desktop;
            this.linkLabel13.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel13.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel13.Location = new System.Drawing.Point(10, 134);
            this.linkLabel13.Name = "linkLabel13";
            this.linkLabel13.Size = new System.Drawing.Size(127, 14);
            this.linkLabel13.TabIndex = 4;
            this.linkLabel13.TabStop = true;
            this.linkLabel13.Text = "Search Calendars Online";
            this.linkLabel13.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // xpTaskBar1
            // 
            this.xpTaskBar1.BackColor = System.Drawing.Color.White;
            this.xpTaskBar1.BorderColor = System.Drawing.Color.Black;
            this.xpTaskBar1.Controls.Add(this.myCalendarsTaskBarBox1);
            this.xpTaskBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xpTaskBar1.Location = new System.Drawing.Point(0, 0);
            this.xpTaskBar1.MinimumSize = new System.Drawing.Size(0, 0);
            this.xpTaskBar1.Name = "xpTaskBar1";
            this.xpTaskBar1.Size = new System.Drawing.Size(201, 79);
            this.xpTaskBar1.TabIndex = 0;
            // 
            // myCalendarsTaskBarBox1
            // 
            this.myCalendarsTaskBarBox1.Controls.Add(this.gradientPanel4);
            this.myCalendarsTaskBarBox1.DrawFocusRect = false;
            this.myCalendarsTaskBarBox1.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.myCalendarsTaskBarBox1.HeaderForeColor = System.Drawing.Color.DarkBlue;
            this.myCalendarsTaskBarBox1.HeaderImageIndex = -1;
            this.myCalendarsTaskBarBox1.HitTaskBoxArea = false;
            this.myCalendarsTaskBarBox1.HotTrackColor = System.Drawing.Color.Empty;
            this.myCalendarsTaskBarBox1.ItemBackColor = System.Drawing.Color.White;
            this.myCalendarsTaskBarBox1.Location = new System.Drawing.Point(0, 0);
            this.myCalendarsTaskBarBox1.Name = "myCalendarsTaskBarBox1";
            this.myCalendarsTaskBarBox1.PreferredChildPanelHeight = 45;
            this.myCalendarsTaskBarBox1.Size = new System.Drawing.Size(201, 76);
            this.myCalendarsTaskBarBox1.TabIndex = 0;
            this.myCalendarsTaskBarBox1.Text = "My Calendars";
            this.myCalendarsTaskBarBox1.ProvideHeaderBackgroundBrush += new Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(this.TaskBarBox_ProvideHeaderBackgroundBrush);
            // 
            // gradientPanel4
            // 
            this.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel4.Controls.Add(this.checkBox2);
            this.gradientPanel4.Controls.Add(this.checkBox1);
            this.gradientPanel4.Location = new System.Drawing.Point(2, 29);
            this.gradientPanel4.Name = "gradientPanel4";
            this.gradientPanel4.Size = new System.Drawing.Size(197, 45);
            this.gradientPanel4.TabIndex = 0;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.White;
            this.checkBox2.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ImageIndex = 12;
            this.checkBox2.ImageList = this.smallImageList;
            this.checkBox2.Location = new System.Drawing.Point(3, 23);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(169, 18);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Calendar in Archive Folder";
            this.checkBox2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.White;
            this.checkBox1.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ImageIndex = 12;
            this.checkBox1.ImageList = this.smallImageList;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 18);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Calendar";
            this.checkBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // linkLabel14
            // 
            this.linkLabel14.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel14.AutoSize = true;
            this.linkLabel14.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel14.ForeColor = System.Drawing.SystemColors.Desktop;
            this.linkLabel14.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel14.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel14.Location = new System.Drawing.Point(9, 158);
            this.linkLabel14.Name = "linkLabel14";
            this.linkLabel14.Size = new System.Drawing.Size(108, 14);
            this.linkLabel14.TabIndex = 5;
            this.linkLabel14.TabStop = true;
            this.linkLabel14.Text = "Share My Calendar...";
            this.linkLabel14.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // linkLabel17
            // 
            this.linkLabel17.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel17.AutoSize = true;
            this.linkLabel17.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel17.ForeColor = System.Drawing.SystemColors.Desktop;
            this.linkLabel17.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel17.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel17.Location = new System.Drawing.Point(9, 217);
            this.linkLabel17.Name = "linkLabel17";
            this.linkLabel17.Size = new System.Drawing.Size(84, 14);
            this.linkLabel17.TabIndex = 8;
            this.linkLabel17.TabStop = true;
            this.linkLabel17.Text = "Add New Group";
            this.linkLabel17.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // linkLabel15
            // 
            this.linkLabel15.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel15.AutoSize = true;
            this.linkLabel15.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel15.ForeColor = System.Drawing.SystemColors.Desktop;
            this.linkLabel15.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel15.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel15.Location = new System.Drawing.Point(9, 175);
            this.linkLabel15.Name = "linkLabel15";
            this.linkLabel15.Size = new System.Drawing.Size(147, 14);
            this.linkLabel15.TabIndex = 6;
            this.linkLabel15.TabStop = true;
            this.linkLabel15.Text = "Send a Calendar via E-mail...";
            this.linkLabel15.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // linkLabel16
            // 
            this.linkLabel16.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel16.AutoSize = true;
            this.linkLabel16.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel16.ForeColor = System.Drawing.SystemColors.Desktop;
            this.linkLabel16.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel16.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel16.Location = new System.Drawing.Point(9, 194);
            this.linkLabel16.Name = "linkLabel16";
            this.linkLabel16.Size = new System.Drawing.Size(115, 14);
            this.linkLabel16.TabIndex = 7;
            this.linkLabel16.TabStop = true;
            this.linkLabel16.Text = "Publish My Calendar...";
            this.linkLabel16.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // mailPanel
            // 
            this.mailPanel.Controls.Add(this.mailTaskBar);
            this.mailPanel.Location = new System.Drawing.Point(1, 27);
            this.mailPanel.Name = "mailPanel";
            this.mailPanel.Size = new System.Drawing.Size(205, 453);
            this.mailPanel.TabIndex = 1;
            // 
            // mailTaskBar
            // 
            this.mailTaskBar.BackColor = System.Drawing.Color.White;
            this.mailTaskBar.BorderColor = System.Drawing.Color.Black;
            this.mailTaskBar.Controls.Add(this.favouritesTaskBarBox);
            this.mailTaskBar.Controls.Add(this.mailTaskBarBox);
            this.mailTaskBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mailTaskBar.Location = new System.Drawing.Point(0, 0);
            this.mailTaskBar.MinimumSize = new System.Drawing.Size(0, 0);
            this.mailTaskBar.Name = "mailTaskBar";
            this.mailTaskBar.Size = new System.Drawing.Size(205, 453);
            this.mailTaskBar.TabIndex = 4;
            // 
            // favouritesTaskBarBox
            // 
            this.favouritesTaskBarBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.favouritesTaskBarBox.DrawFocusRect = false;
            this.favouritesTaskBarBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.favouritesTaskBarBox.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.favouritesTaskBarBox.HeaderFont = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favouritesTaskBarBox.HeaderForeColor = System.Drawing.Color.MidnightBlue;
            this.favouritesTaskBarBox.HeaderImageIndex = -1;
            this.favouritesTaskBarBox.HitTaskBoxArea = false;
            this.favouritesTaskBarBox.HotTrackColor = System.Drawing.Color.Empty;
            this.favouritesTaskBarBox.ImageList = this.smallImageList;
            this.favouritesTaskBarBox.ItemBackColor = System.Drawing.Color.White;
            this.favouritesTaskBarBox.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPTaskBarItem[] {
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Inbox", System.Drawing.Color.Empty, 2, null, "", true, true, "XPTaskBarItem0", new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Unread Mail", System.Drawing.Color.Empty, 4, null, "", true, true, "XPTaskBarItem1", new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Sent Items", System.Drawing.Color.Empty, 6, null, "", true, true, "XPTaskBarItem2", new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), 0)});
            this.favouritesTaskBarBox.Location = new System.Drawing.Point(0, 0);
            this.favouritesTaskBarBox.Name = "favouritesTaskBarBox";
            this.favouritesTaskBarBox.Size = new System.Drawing.Size(205, 98);
            this.favouritesTaskBarBox.TabIndex = 0;
            this.favouritesTaskBarBox.Text = "Favourite Folders";
            this.favouritesTaskBarBox.ProvideHeaderBackgroundBrush += new Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(this.TaskBarBox_ProvideHeaderBackgroundBrush);
            // 
            // mailTaskBarBox
            // 
            this.mailTaskBarBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.mailTaskBarBox.Controls.Add(this.gradientPanel2);
            this.mailTaskBarBox.DrawFocusRect = false;
            this.mailTaskBarBox.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.mailTaskBarBox.HeaderForeColor = System.Drawing.Color.MidnightBlue;
            this.mailTaskBarBox.HeaderImageIndex = -1;
            this.mailTaskBarBox.HitTaskBoxArea = false;
            this.mailTaskBarBox.HotTrackColor = System.Drawing.Color.Empty;
            this.mailTaskBarBox.ItemBackColor = System.Drawing.Color.White;
            this.mailTaskBarBox.Location = new System.Drawing.Point(0, 98);
            this.mailTaskBarBox.Name = "mailTaskBarBox";
            this.mailTaskBarBox.PreferredChildPanelHeight = 130;
            this.mailTaskBarBox.Size = new System.Drawing.Size(205, 161);
            this.mailTaskBarBox.TabIndex = 1;
            this.mailTaskBarBox.Text = "Mail Folders";
            this.mailTaskBarBox.ProvideHeaderBackgroundBrush += new Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(this.TaskBarBox_ProvideHeaderBackgroundBrush);
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel2.Controls.Add(this.treeView3);
            this.gradientPanel2.Location = new System.Drawing.Point(2, 29);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(201, 130);
            this.gradientPanel2.TabIndex = 4;
            // 
            // treeView3
            // 
            this.treeView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView3.ImageIndex = 0;
            this.treeView3.ImageList = this.smallImageList;
            this.treeView3.Indent = 25;
            this.treeView3.Location = new System.Drawing.Point(0, 0);
            this.treeView3.Name = "treeView3";
            treeNode25.ImageIndex = 1;
            treeNode25.Name = "";
            treeNode25.SelectedImageIndex = 1;
            treeNode25.Text = "Deleted Items";
            treeNode26.ImageIndex = 0;
            treeNode26.Name = "";
            treeNode26.SelectedImageIndex = 0;
            treeNode26.Text = "Junk Email";
            treeNode27.ImageIndex = 2;
            treeNode27.Name = "";
            treeNode27.SelectedImageIndex = 2;
            treeNode27.Text = "Inbox";
            treeNode28.ImageIndex = 6;
            treeNode28.Name = "";
            treeNode28.SelectedImageIndex = 6;
            treeNode28.Text = "Sent Items";
            treeNode29.ImageIndex = 4;
            treeNode29.Name = "";
            treeNode29.SelectedImageIndex = 4;
            treeNode29.Text = "Search Folders";
            treeNode30.ImageIndex = 7;
            treeNode30.Name = "";
            treeNode30.SelectedImageIndex = 7;
            treeNode30.Text = "Personal Folders";
            treeNode31.ImageIndex = 4;
            treeNode31.Name = "";
            treeNode31.SelectedImageIndex = 4;
            treeNode31.Text = "Search Folders";
            treeNode32.ImageIndex = 6;
            treeNode32.Name = "";
            treeNode32.SelectedImageIndex = 6;
            treeNode32.Text = "Sent Items";
            treeNode33.ImageIndex = 1;
            treeNode33.Name = "";
            treeNode33.SelectedImageIndex = 1;
            treeNode33.Text = "Deleted Items";
            treeNode34.ImageIndex = 8;
            treeNode34.Name = "";
            treeNode34.SelectedImageIndex = 8;
            treeNode34.Text = "Archive Folders";
            treeNode35.ImageIndex = 5;
            treeNode35.Name = "";
            treeNode35.SelectedImageIndex = 5;
            treeNode35.Text = "Drafts";
            treeNode36.ImageIndex = 2;
            treeNode36.Name = "";
            treeNode36.SelectedImageIndex = 2;
            treeNode36.Text = "Inbox";
            treeNode37.ImageIndex = 3;
            treeNode37.Name = "";
            treeNode37.SelectedImageIndex = 3;
            treeNode37.Text = "Outbox";
            treeNode38.ImageIndex = 6;
            treeNode38.Name = "";
            treeNode38.SelectedImageIndex = 6;
            treeNode38.Text = "Sent Items";
            treeNode39.Name = "";
            treeNode39.Text = "Public";
            treeNode40.ImageIndex = 8;
            treeNode40.Name = "";
            treeNode40.SelectedImageIndex = 8;
            treeNode40.Text = "Syncfusion Email";
            this.treeView3.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode30,
            treeNode34,
            treeNode40});
            this.treeView3.SelectedImageIndex = 0;
            this.treeView3.ShowLines = false;
            this.treeView3.Size = new System.Drawing.Size(201, 130);
            this.treeView3.TabIndex = 3;
            // 
            // notesPanel
            // 
            this.notesPanel.Controls.Add(this.gradientPanel7);
            this.notesPanel.Location = new System.Drawing.Point(1, 27);
            this.notesPanel.Name = "notesPanel";
            this.notesPanel.Size = new System.Drawing.Size(205, 453);
            this.notesPanel.TabIndex = 1;
            // 
            // gradientPanel7
            // 
            this.gradientPanel7.BackColor = System.Drawing.Color.White;
            this.gradientPanel7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel7.Controls.Add(this.linkLabel22);
            this.gradientPanel7.Controls.Add(this.panel5);
            this.gradientPanel7.Controls.Add(this.linkLabel23);
            this.gradientPanel7.Controls.Add(this.xpTaskBar4);
            this.gradientPanel7.Controls.Add(this.linkLabel5);
            this.gradientPanel7.Controls.Add(this.linkLabel6);
            this.gradientPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel7.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel7.Name = "gradientPanel7";
            this.gradientPanel7.Size = new System.Drawing.Size(205, 453);
            this.gradientPanel7.TabIndex = 0;
            // 
            // linkLabel22
            // 
            this.linkLabel22.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel22.AutoSize = true;
            this.linkLabel22.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel22.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel22.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel22.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel22.Location = new System.Drawing.Point(4, 249);
            this.linkLabel22.Name = "linkLabel22";
            this.linkLabel22.Size = new System.Drawing.Size(126, 14);
            this.linkLabel22.TabIndex = 0;
            this.linkLabel22.TabStop = true;
            this.linkLabel22.Text = "Share My Notes Folder...";
            this.linkLabel22.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 215);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(205, 5);
            this.panel5.TabIndex = 1;
            // 
            // linkLabel23
            // 
            this.linkLabel23.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel23.AutoSize = true;
            this.linkLabel23.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel23.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel23.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel23.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel23.Location = new System.Drawing.Point(4, 267);
            this.linkLabel23.Name = "linkLabel23";
            this.linkLabel23.Size = new System.Drawing.Size(84, 14);
            this.linkLabel23.TabIndex = 1;
            this.linkLabel23.TabStop = true;
            this.linkLabel23.Text = "Add New Group";
            this.linkLabel23.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // xpTaskBar4
            // 
            this.xpTaskBar4.BackColor = System.Drawing.Color.White;
            this.xpTaskBar4.BorderColor = System.Drawing.Color.Black;
            this.xpTaskBar4.Controls.Add(this.notesTaskBarBox);
            this.xpTaskBar4.Controls.Add(this.currentViewTaskBarBox2);
            this.xpTaskBar4.Dock = System.Windows.Forms.DockStyle.Top;
            this.xpTaskBar4.Location = new System.Drawing.Point(0, 0);
            this.xpTaskBar4.MinimumSize = new System.Drawing.Size(0, 0);
            this.xpTaskBar4.Name = "xpTaskBar4";
            this.xpTaskBar4.Size = new System.Drawing.Size(205, 215);
            this.xpTaskBar4.TabIndex = 0;
            // 
            // notesTaskBarBox
            // 
            this.notesTaskBarBox.DrawFocusRect = false;
            this.notesTaskBarBox.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.notesTaskBarBox.HeaderFont = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesTaskBarBox.HeaderForeColor = System.Drawing.Color.MidnightBlue;
            this.notesTaskBarBox.HeaderImageIndex = -1;
            this.notesTaskBarBox.HitTaskBoxArea = false;
            this.notesTaskBarBox.HotTrackColor = System.Drawing.Color.Empty;
            this.notesTaskBarBox.ImageList = this.smallImageList;
            this.notesTaskBarBox.ItemBackColor = System.Drawing.Color.White;
            this.notesTaskBarBox.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPTaskBarItem[] {
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Notes", System.Drawing.Color.Empty, 11, null, "", true, true, "XPTaskBarItem8", new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), 0)});
            this.notesTaskBarBox.Location = new System.Drawing.Point(0, 0);
            this.notesTaskBarBox.Name = "notesTaskBarBox";
            this.notesTaskBarBox.Size = new System.Drawing.Size(205, 54);
            this.notesTaskBarBox.TabIndex = 0;
            this.notesTaskBarBox.Text = "My Notes";
            this.notesTaskBarBox.ProvideHeaderBackgroundBrush += new Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(this.TaskBarBox_ProvideHeaderBackgroundBrush);
            // 
            // currentViewTaskBarBox2
            // 
            this.currentViewTaskBarBox2.Controls.Add(this.panel9);
            this.currentViewTaskBarBox2.DrawFocusRect = false;
            this.currentViewTaskBarBox2.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.currentViewTaskBarBox2.HeaderFont = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentViewTaskBarBox2.HeaderForeColor = System.Drawing.Color.MidnightBlue;
            this.currentViewTaskBarBox2.HeaderImageIndex = -1;
            this.currentViewTaskBarBox2.HitTaskBoxArea = false;
            this.currentViewTaskBarBox2.HotTrackColor = System.Drawing.Color.Empty;
            this.currentViewTaskBarBox2.ItemBackColor = System.Drawing.Color.White;
            this.currentViewTaskBarBox2.Location = new System.Drawing.Point(0, 54);
            this.currentViewTaskBarBox2.Name = "currentViewTaskBarBox2";
            this.currentViewTaskBarBox2.PreferredChildPanelHeight = 125;
            this.currentViewTaskBarBox2.Size = new System.Drawing.Size(205, 156);
            this.currentViewTaskBarBox2.TabIndex = 1;
            this.currentViewTaskBarBox2.Text = "Current View";
            this.currentViewTaskBarBox2.ProvideHeaderBackgroundBrush += new Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(this.TaskBarBox_ProvideHeaderBackgroundBrush);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.radioButton13);
            this.panel9.Controls.Add(this.radioButton14);
            this.panel9.Controls.Add(this.radioButton15);
            this.panel9.Controls.Add(this.radioButton16);
            this.panel9.Controls.Add(this.radioButton17);
            this.panel9.Location = new System.Drawing.Point(2, 29);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(201, 125);
            this.panel9.TabIndex = 6;
            // 
            // radioButton13
            // 
            this.radioButton13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton13.Location = new System.Drawing.Point(8, 98);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(176, 24);
            this.radioButton13.TabIndex = 4;
            this.radioButton13.Text = "Outlook Data Files";
            // 
            // radioButton14
            // 
            this.radioButton14.BackColor = System.Drawing.SystemColors.Window;
            this.radioButton14.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton14.Location = new System.Drawing.Point(8, 75);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(176, 24);
            this.radioButton14.TabIndex = 3;
            this.radioButton14.Text = "By Category";
            this.radioButton14.UseVisualStyleBackColor = false;
            // 
            // radioButton15
            // 
            this.radioButton15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton15.Location = new System.Drawing.Point(8, 52);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(176, 24);
            this.radioButton15.TabIndex = 2;
            this.radioButton15.Text = "Last Seven Days";
            // 
            // radioButton16
            // 
            this.radioButton16.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton16.Location = new System.Drawing.Point(8, 29);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new System.Drawing.Size(176, 24);
            this.radioButton16.TabIndex = 1;
            this.radioButton16.Text = "Notes List";
            // 
            // radioButton17
            // 
            this.radioButton17.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton17.Location = new System.Drawing.Point(8, 6);
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.Size = new System.Drawing.Size(176, 24);
            this.radioButton17.TabIndex = 0;
            this.radioButton17.Text = "Icons";
            // 
            // linkLabel5
            // 
            this.linkLabel5.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel5.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel5.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel5.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel5.Location = new System.Drawing.Point(4, 288);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(176, 16);
            this.linkLabel5.TabIndex = 1;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Customize Current View...";
            this.linkLabel5.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // linkLabel6
            // 
            this.linkLabel6.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel6.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel6.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel6.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel6.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel6.Location = new System.Drawing.Point(4, 232);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(176, 16);
            this.linkLabel6.TabIndex = 0;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Open Shared Notes...";
            this.linkLabel6.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // tasksPanel
            // 
            this.tasksPanel.BackColor = System.Drawing.SystemColors.Window;
            this.tasksPanel.Controls.Add(this.gradientPanel6);
            this.tasksPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasksPanel.Location = new System.Drawing.Point(1, 27);
            this.tasksPanel.Name = "tasksPanel";
            this.tasksPanel.Size = new System.Drawing.Size(205, 453);
            this.tasksPanel.TabIndex = 1;
            // 
            // gradientPanel6
            // 
            this.gradientPanel6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel6.Controls.Add(this.panel4);
            this.gradientPanel6.Controls.Add(this.linkLabel20);
            this.gradientPanel6.Controls.Add(this.xpTaskBar3);
            this.gradientPanel6.Controls.Add(this.linkLabel21);
            this.gradientPanel6.Controls.Add(this.linkLabel4);
            this.gradientPanel6.Controls.Add(this.linkLabel3);
            this.gradientPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel6.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel6.Name = "gradientPanel6";
            this.gradientPanel6.Size = new System.Drawing.Size(205, 453);
            this.gradientPanel6.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 359);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(205, 5);
            this.panel4.TabIndex = 1005;
            // 
            // linkLabel20
            // 
            this.linkLabel20.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel20.AutoSize = true;
            this.linkLabel20.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel20.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel20.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel20.Location = new System.Drawing.Point(7, 392);
            this.linkLabel20.Name = "linkLabel20";
            this.linkLabel20.Size = new System.Drawing.Size(124, 14);
            this.linkLabel20.TabIndex = 1003;
            this.linkLabel20.TabStop = true;
            this.linkLabel20.Text = "Share My Tasks Folder...";
            this.linkLabel20.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // xpTaskBar3
            // 
            this.xpTaskBar3.BackColor = System.Drawing.Color.White;
            this.xpTaskBar3.BorderColor = System.Drawing.Color.Black;
            this.xpTaskBar3.Controls.Add(this.mytasksTaskBarBox);
            this.xpTaskBar3.Controls.Add(this.currentViewTaskBarBox1);
            this.xpTaskBar3.Dock = System.Windows.Forms.DockStyle.Top;
            this.xpTaskBar3.Location = new System.Drawing.Point(0, 0);
            this.xpTaskBar3.MinimumSize = new System.Drawing.Size(0, 0);
            this.xpTaskBar3.Name = "xpTaskBar3";
            this.xpTaskBar3.Size = new System.Drawing.Size(205, 359);
            this.xpTaskBar3.TabIndex = 0;
            // 
            // mytasksTaskBarBox
            // 
            this.mytasksTaskBarBox.DrawFocusRect = false;
            this.mytasksTaskBarBox.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.mytasksTaskBarBox.HeaderFont = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mytasksTaskBarBox.HeaderForeColor = System.Drawing.Color.MidnightBlue;
            this.mytasksTaskBarBox.HeaderImageIndex = -1;
            this.mytasksTaskBarBox.HitTaskBoxArea = false;
            this.mytasksTaskBarBox.HotTrackColor = System.Drawing.Color.Empty;
            this.mytasksTaskBarBox.ImageList = this.smallImageList;
            this.mytasksTaskBarBox.ItemBackColor = System.Drawing.Color.White;
            this.mytasksTaskBarBox.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPTaskBarItem[] {
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("To-Do List", System.Drawing.Color.Empty, 49, null, "", true, true, "XPTaskBarItem5", new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Tasks", System.Drawing.Color.Empty, 10, null, "", true, true, "XPTaskBarItem6", new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Tasks in Archieve Folders", System.Drawing.Color.Empty, 10, null, "", true, true, "XPTaskBarItem7", new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), 0)});
            this.mytasksTaskBarBox.Location = new System.Drawing.Point(0, 0);
            this.mytasksTaskBarBox.Name = "mytasksTaskBarBox";
            this.mytasksTaskBarBox.Size = new System.Drawing.Size(205, 95);
            this.mytasksTaskBarBox.TabIndex = 0;
            this.mytasksTaskBarBox.Text = "My Tasks";
            this.mytasksTaskBarBox.ProvideHeaderBackgroundBrush += new Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(this.TaskBarBox_ProvideHeaderBackgroundBrush);
            // 
            // currentViewTaskBarBox1
            // 
            this.currentViewTaskBarBox1.Controls.Add(this.panel7);
            this.currentViewTaskBarBox1.DrawFocusRect = false;
            this.currentViewTaskBarBox1.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.currentViewTaskBarBox1.HeaderFont = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentViewTaskBarBox1.HeaderForeColor = System.Drawing.Color.MidnightBlue;
            this.currentViewTaskBarBox1.HeaderImageIndex = -1;
            this.currentViewTaskBarBox1.HitTaskBoxArea = false;
            this.currentViewTaskBarBox1.HotTrackColor = System.Drawing.Color.Empty;
            this.currentViewTaskBarBox1.ItemBackColor = System.Drawing.Color.White;
            this.currentViewTaskBarBox1.Location = new System.Drawing.Point(0, 95);
            this.currentViewTaskBarBox1.Name = "currentViewTaskBarBox1";
            this.currentViewTaskBarBox1.PreferredChildPanelHeight = 232;
            this.currentViewTaskBarBox1.Size = new System.Drawing.Size(205, 263);
            this.currentViewTaskBarBox1.TabIndex = 1;
            this.currentViewTaskBarBox1.Text = "Current View";
            this.currentViewTaskBarBox1.ProvideHeaderBackgroundBrush += new Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(this.TaskBarBox_ProvideHeaderBackgroundBrush);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.radioButton31);
            this.panel7.Controls.Add(this.radioButton30);
            this.panel7.Controls.Add(this.radioButton28);
            this.panel7.Controls.Add(this.radioButton27);
            this.panel7.Controls.Add(this.radioButton12);
            this.panel7.Controls.Add(this.radioButton11);
            this.panel7.Controls.Add(this.radioButton6);
            this.panel7.Controls.Add(this.radioButton7);
            this.panel7.Controls.Add(this.radioButton8);
            this.panel7.Controls.Add(this.radioButton9);
            this.panel7.Controls.Add(this.radioButton10);
            this.panel7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(2, 29);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(201, 232);
            this.panel7.TabIndex = 6;
            // 
            // radioButton31
            // 
            this.radioButton31.AutoSize = true;
            this.radioButton31.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton31.Location = new System.Drawing.Point(7, 209);
            this.radioButton31.Name = "radioButton31";
            this.radioButton31.Size = new System.Drawing.Size(84, 20);
            this.radioButton31.TabIndex = 12;
            this.radioButton31.TabStop = true;
            this.radioButton31.Text = "To-Do List";
            this.radioButton31.UseVisualStyleBackColor = true;
            // 
            // radioButton30
            // 
            this.radioButton30.AutoSize = true;
            this.radioButton30.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton30.Location = new System.Drawing.Point(7, 190);
            this.radioButton30.Name = "radioButton30";
            this.radioButton30.Size = new System.Drawing.Size(133, 20);
            this.radioButton30.TabIndex = 11;
            this.radioButton30.TabStop = true;
            this.radioButton30.Text = "Outlook Data Files";
            this.radioButton30.UseVisualStyleBackColor = true;
            // 
            // radioButton28
            // 
            this.radioButton28.AutoSize = true;
            this.radioButton28.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton28.Location = new System.Drawing.Point(7, 170);
            this.radioButton28.Name = "radioButton28";
            this.radioButton28.Size = new System.Drawing.Size(111, 20);
            this.radioButton28.TabIndex = 9;
            this.radioButton28.TabStop = true;
            this.radioButton28.Text = "Tasks Timeline";
            this.radioButton28.UseVisualStyleBackColor = true;
            // 
            // radioButton27
            // 
            this.radioButton27.AutoSize = true;
            this.radioButton27.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton27.Location = new System.Drawing.Point(7, 147);
            this.radioButton27.Name = "radioButton27";
            this.radioButton27.Size = new System.Drawing.Size(122, 20);
            this.radioButton27.TabIndex = 8;
            this.radioButton27.TabStop = true;
            this.radioButton27.Text = "Completed Tasks";
            this.radioButton27.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton12.Location = new System.Drawing.Point(7, 125);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(94, 20);
            this.radioButton12.TabIndex = 6;
            this.radioButton12.Text = "Assignment";
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton11.Location = new System.Drawing.Point(7, 104);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(95, 20);
            this.radioButton11.TabIndex = 5;
            this.radioButton11.Text = "By Category";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.Location = new System.Drawing.Point(7, 83);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(110, 20);
            this.radioButton6.TabIndex = 4;
            this.radioButton6.Text = "Overdue Tasks";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.BackColor = System.Drawing.SystemColors.Window;
            this.radioButton7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton7.Location = new System.Drawing.Point(7, 63);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(119, 20);
            this.radioButton7.TabIndex = 3;
            this.radioButton7.Text = "Next Seven Days";
            this.radioButton7.UseVisualStyleBackColor = false;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton8.Location = new System.Drawing.Point(7, 43);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(96, 20);
            this.radioButton8.TabIndex = 2;
            this.radioButton8.Text = "Active Tasks";
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton9.Location = new System.Drawing.Point(7, 23);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(99, 20);
            this.radioButton9.TabIndex = 1;
            this.radioButton9.Text = "Detailed List";
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton10.Location = new System.Drawing.Point(7, 4);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(90, 20);
            this.radioButton10.TabIndex = 0;
            this.radioButton10.Text = "Simple List";
            // 
            // linkLabel21
            // 
            this.linkLabel21.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel21.AutoSize = true;
            this.linkLabel21.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel21.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel21.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel21.Location = new System.Drawing.Point(7, 409);
            this.linkLabel21.Name = "linkLabel21";
            this.linkLabel21.Size = new System.Drawing.Size(84, 14);
            this.linkLabel21.TabIndex = 1004;
            this.linkLabel21.TabStop = true;
            this.linkLabel21.Text = "Add New Group";
            this.linkLabel21.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // linkLabel4
            // 
            this.linkLabel4.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel4.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel4.Location = new System.Drawing.Point(7, 374);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(109, 14);
            this.linkLabel4.TabIndex = 0;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Open Shared Tasks...";
            this.linkLabel4.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // linkLabel3
            // 
            this.linkLabel3.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel3.Location = new System.Drawing.Point(7, 428);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(133, 14);
            this.linkLabel3.TabIndex = 1;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Customize Current View...";
            this.linkLabel3.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // groupBarItem1
            // 
            this.groupBarItem1.Client = this.mailPanel;
            this.groupBarItem1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBarItem1.Icon = ((System.Drawing.Icon)(resources.GetObject("groupBarItem1.Icon")));
            this.groupBarItem1.NavigationPaneIcon = ((System.Drawing.Icon)(resources.GetObject("groupBarItem1.NavigationPaneIcon")));
            this.groupBarItem1.Padding = 4;
            this.groupBarItem1.Text = "Mail";
            // 
            // groupBarItem7
            // 
            this.groupBarItem7.Client = this.calendarPanel;
            this.groupBarItem7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBarItem7.Icon = ((System.Drawing.Icon)(resources.GetObject("groupBarItem7.Icon")));
            this.groupBarItem7.NavigationPaneIcon = ((System.Drawing.Icon)(resources.GetObject("groupBarItem7.NavigationPaneIcon")));
            this.groupBarItem7.Padding = 4;
            this.groupBarItem7.Text = "Calendar";
            // 
            // groupBarItem3
            // 
            this.groupBarItem3.Client = this.contactsPanel;
            this.groupBarItem3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBarItem3.Icon = ((System.Drawing.Icon)(resources.GetObject("groupBarItem3.Icon")));
            this.groupBarItem3.NavigationPaneIcon = ((System.Drawing.Icon)(resources.GetObject("groupBarItem3.NavigationPaneIcon")));
            this.groupBarItem3.Padding = 4;
            this.groupBarItem3.Text = "Contacts";
            // 
            // groupBarItem4
            // 
            this.groupBarItem4.Client = this.tasksPanel;
            this.groupBarItem4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBarItem4.Icon = ((System.Drawing.Icon)(resources.GetObject("groupBarItem4.Icon")));
            this.groupBarItem4.NavigationPaneIcon = ((System.Drawing.Icon)(resources.GetObject("groupBarItem4.NavigationPaneIcon")));
            this.groupBarItem4.Padding = 4;
            this.groupBarItem4.Text = "Tasks";
            // 
            // groupBarItem5
            // 
            this.groupBarItem5.Client = this.notesPanel;
            this.groupBarItem5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBarItem5.Icon = ((System.Drawing.Icon)(resources.GetObject("groupBarItem5.Icon")));
            this.groupBarItem5.NavigationPaneIcon = ((System.Drawing.Icon)(resources.GetObject("groupBarItem5.NavigationPaneIcon")));
            this.groupBarItem5.Padding = 4;
            this.groupBarItem5.Text = "Notes";
            // 
            // groupBarItem6
            // 
            this.groupBarItem6.Client = this.folderlistPanel;
            this.groupBarItem6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBarItem6.Icon = ((System.Drawing.Icon)(resources.GetObject("groupBarItem6.Icon")));
            this.groupBarItem6.NavigationPaneIcon = ((System.Drawing.Icon)(resources.GetObject("groupBarItem6.NavigationPaneIcon")));
            this.groupBarItem6.Padding = 4;
            this.groupBarItem6.Text = "Folder List";
            // 
            // groupBarItem2
            // 
            this.groupBarItem2.Client = this.journalPanel;
            this.groupBarItem2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBarItem2.Icon = ((System.Drawing.Icon)(resources.GetObject("groupBarItem2.Icon")));
            this.groupBarItem2.NavigationPaneIcon = ((System.Drawing.Icon)(resources.GetObject("groupBarItem2.NavigationPaneIcon")));
            this.groupBarItem2.Padding = 4;
            this.groupBarItem2.Text = "Journal";
            this.groupBarItem2.Visible = false;
            // 
            // clientPanel
            // 
            this.clientPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.clientPanel.Controls.Add(this.panel16);
            this.clientPanel.Controls.Add(this.splitter2);
            this.clientPanel.Controls.Add(this.gridContainerPanel);
            this.clientPanel.Controls.Add(this.scheduleContainerPanel);
            this.clientPanel.Controls.Add(this.contactsGridPanel);
            this.clientPanel.Controls.Add(this.gradientPanel1);
            this.clientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientPanel.Location = new System.Drawing.Point(0, 0);
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Size = new System.Drawing.Size(689, 579);
            this.clientPanel.TabIndex = 4;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel16.Controls.Add(this.Display);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(0, 357);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(689, 222);
            this.panel16.TabIndex = 4;
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.SystemColors.Window;
            this.Display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Display.Location = new System.Drawing.Point(0, 0);
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.Size = new System.Drawing.Size(687, 220);
            this.Display.TabIndex = 0;
            this.Display.Text = "";
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 353);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(689, 4);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // gridContainerPanel
            // 
            this.gridContainerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.gridContainerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridContainerPanel.Location = new System.Drawing.Point(0, 28);
            this.gridContainerPanel.Name = "gridContainerPanel";
            this.gridContainerPanel.Size = new System.Drawing.Size(689, 325);
            this.gridContainerPanel.TabIndex = 2;
            // 
            // scheduleContainerPanel
            // 
            this.scheduleContainerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.scheduleContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scheduleContainerPanel.Location = new System.Drawing.Point(0, 28);
            this.scheduleContainerPanel.Name = "scheduleContainerPanel";
            this.scheduleContainerPanel.Size = new System.Drawing.Size(689, 551);
            this.scheduleContainerPanel.TabIndex = 2;
            // 
            // contactsGridPanel
            // 
            this.contactsGridPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactsGridPanel.Location = new System.Drawing.Point(0, 28);
            this.contactsGridPanel.Name = "contactsGridPanel";
            this.contactsGridPanel.Size = new System.Drawing.Size(685, 560);
            this.contactsGridPanel.TabIndex = 5;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(210)))), ((int)(((byte)(255))))));
            this.gradientPanel1.BorderColor = System.Drawing.Color.MidnightBlue;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.clientPanelImage);
            this.gradientPanel1.Controls.Add(this.clientPanelLabel1);
            this.gradientPanel1.Controls.Add(this.clientPanelLabel2);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(689, 28);
            this.gradientPanel1.TabIndex = 1;
            // 
            // clientPanelImage
            // 
            this.clientPanelImage.BackColor = System.Drawing.Color.Transparent;
            this.clientPanelImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.clientPanelImage.ImageIndex = 2;
            this.clientPanelImage.ImageList = this.smallImageList;
            this.clientPanelImage.Location = new System.Drawing.Point(0, 0);
            this.clientPanelImage.Name = "clientPanelImage";
            this.clientPanelImage.Size = new System.Drawing.Size(32, 26);
            this.clientPanelImage.TabIndex = 3;
            // 
            // clientPanelLabel1
            // 
            this.clientPanelLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientPanelLabel1.BackColor = System.Drawing.Color.Transparent;
            this.clientPanelLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientPanelLabel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.clientPanelLabel1.Location = new System.Drawing.Point(38, -1);
            this.clientPanelLabel1.Name = "clientPanelLabel1";
            this.clientPanelLabel1.Size = new System.Drawing.Size(554, 28);
            this.clientPanelLabel1.TabIndex = 5;
            this.clientPanelLabel1.Text = "Inbox";
            this.clientPanelLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clientPanelLabel2
            // 
            this.clientPanelLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clientPanelLabel2.BackColor = System.Drawing.Color.Transparent;
            this.clientPanelLabel2.ForeColor = System.Drawing.Color.White;
            this.clientPanelLabel2.Location = new System.Drawing.Point(598, 0);
            this.clientPanelLabel2.Name = "clientPanelLabel2";
            this.clientPanelLabel2.Size = new System.Drawing.Size(88, 28);
            this.clientPanelLabel2.TabIndex = 4;
            this.clientPanelLabel2.Text = "label12";
            this.clientPanelLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusStripEx1
            // 
            this.statusStripEx1.AllowItemReorder = true;
            this.statusStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStripEx1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStripEx1.Location = new System.Drawing.Point(1, 827);
            this.statusStripEx1.Name = "statusStripEx1";
            this.statusStripEx1.Size = new System.Drawing.Size(200, 22);
            this.statusStripEx1.TabIndex = 1003;
            this.statusStripEx1.Text = "statusStripEx1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(62, 14);
            this.toolStripStatusLabel1.Text = "Messages";
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.listView1.Location = new System.Drawing.Point(1, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(302, 246);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            this.imageList1.Images.SetKeyName(12, "");
            this.imageList1.Images.SetKeyName(13, "");
            this.imageList1.Images.SetKeyName(14, "");
            this.imageList1.Images.SetKeyName(15, "");
            this.imageList1.Images.SetKeyName(16, "");
            this.imageList1.Images.SetKeyName(17, "");
            this.imageList1.Images.SetKeyName(18, "");
            this.imageList1.Images.SetKeyName(19, "");
            this.imageList1.Images.SetKeyName(20, "");
            this.imageList1.Images.SetKeyName(21, "");
            this.imageList1.Images.SetKeyName(22, "");
            this.imageList1.Images.SetKeyName(23, "");
            this.imageList1.Images.SetKeyName(24, "");
            this.imageList1.Images.SetKeyName(25, "");
            this.imageList1.Images.SetKeyName(26, "");
            this.imageList1.Images.SetKeyName(27, "");
            this.imageList1.Images.SetKeyName(28, "");
            this.imageList1.Images.SetKeyName(29, "");
            // 
            // splashControl1
            // 
            this.splashControl1.AutoMode = false;
            this.splashControl1.HostForm = this;
            
            // 
            // ribbonControlAdv1
            // 
            this.ribbonControlAdv1.BackStageView = this.backStageView1;
            this.ribbonControlAdv1.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControlAdv1.Header.AddMainItem(toolStripFile);
            this.ribbonControlAdv1.Header.AddMainItem(toolStripEdit);
            this.ribbonControlAdv1.Header.AddMainItem(toolStripView);
            this.ribbonControlAdv1.Header.AddMainItem(toolStripGo);
            this.ribbonControlAdv1.Header.AddMainItem(toolStripAction);
            this.ribbonControlAdv1.Header.AddMainItem(toolStripStyle);
            this.ribbonControlAdv1.Location = new System.Drawing.Point(1, 0);
            this.ribbonControlAdv1.MaximizeToolTip = "Maximize Ribbon";
            this.ribbonControlAdv1.MenuButtonImage = ((System.Drawing.Image)(resources.GetObject("ribbonControlAdv1.MenuButtonImage")));
            this.ribbonControlAdv1.MenuButtonText = "";
            this.ribbonControlAdv1.MinimizeToolTip = "Minimize Ribbon";
            this.ribbonControlAdv1.Name = "ribbonControlAdv1";
            // 
            // ribbonControlAdv1.OfficeMenu
            // 
            this.ribbonControlAdv1.OfficeMenu.AuxPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnswitch});
            this.ribbonControlAdv1.OfficeMenu.Name = "OfficeMenu";
            this.ribbonControlAdv1.OfficeMenu.Size = new System.Drawing.Size(137, 68);
            this.ribbonControlAdv1.SelectedTab = this.toolStripFile;
            this.ribbonControlAdv1.Size = new System.Drawing.Size(872, 156);
            this.ribbonControlAdv1.SystemText.QuickAccessDialogDropDownName = "Start menu";
            this.ribbonControlAdv1.TabIndex = 5;
            this.ribbonControlAdv1.Text = "ribbonControlAdv1";
            // 
            // backStageView1
            // 
            this.backStageView1.BackStage = this.backStage1;
            this.backStageView1.HostControl = null;
            this.backStageView1.HostForm = this;
            // 
            // backStage1
            // 
            this.backStage1.AllowDrop = true;
            this.backStage1.Controls.Add(this.backStageTab1);
            this.backStage1.Controls.Add(this.backStageTab4);
            this.backStage1.Controls.Add(this.backStageTab5);
            this.backStage1.Controls.Add(this.backStageButton3);
            this.backStage1.Controls.Add(this.backStageButton4);
            this.backStage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backStage1.ItemSize = new System.Drawing.Size(130, 30);
            this.backStage1.Location = new System.Drawing.Point(6, 58);
            this.backStage1.Name = "backStage1";
            this.backStage1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Managed;
            this.backStage1.Size = new System.Drawing.Size(862, 678);
            this.backStage1.TabIndex = 6;
            this.backStage1.Visible = false;
            // 
            // backStageTab1
            // 
            this.backStageTab1.BackColor = System.Drawing.Color.White;
            this.backStageTab1.Controls.Add(this.pictureBox1);
            this.backStageTab1.Image = null;
            this.backStageTab1.ImageSize = new System.Drawing.Size(16, 16);
            this.backStageTab1.Location = new System.Drawing.Point(130, 1);
            this.backStageTab1.Name = "backStageTab1";
            this.backStageTab1.ShowCloseButton = true;
            this.backStageTab1.Size = new System.Drawing.Size(730, 675);
            this.backStageTab1.TabIndex = 2;
            this.backStageTab1.Text = "Info";
            this.backStageTab1.ThemesEnabled = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(730, 675);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // backStageTab4
            // 
            this.backStageTab4.BackColor = System.Drawing.Color.White;
            this.backStageTab4.Controls.Add(this.pictureBox4);
            this.backStageTab4.Image = null;
            this.backStageTab4.ImageSize = new System.Drawing.Size(16, 16);
            this.backStageTab4.Location = new System.Drawing.Point(130, 1);
            this.backStageTab4.Name = "backStageTab4";
            this.backStageTab4.ShowCloseButton = true;
            this.backStageTab4.Size = new System.Drawing.Size(730, 675);
            this.backStageTab4.TabIndex = 3;
            this.backStageTab4.Text = "Open";
            this.backStageTab4.ThemesEnabled = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(730, 675);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // backStageTab5
            // 
            this.backStageTab5.BackColor = System.Drawing.Color.White;
            this.backStageTab5.Controls.Add(this.pictureBox5);
            this.backStageTab5.Image = null;
            this.backStageTab5.ImageSize = new System.Drawing.Size(16, 16);
            this.backStageTab5.Location = new System.Drawing.Point(130, 1);
            this.backStageTab5.Name = "backStageTab5";
            this.backStageTab5.ShowCloseButton = true;
            this.backStageTab5.Size = new System.Drawing.Size(730, 675);
            this.backStageTab5.TabIndex = 4;
            this.backStageTab5.Text = "Help";
            this.backStageTab5.ThemesEnabled = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(730, 675);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // backStageButton3
            // 
            this.backStageButton3.BackColor = System.Drawing.Color.Transparent;
            this.backStageButton3.Location = new System.Drawing.Point(-37, 90);
            this.backStageButton3.Name = "backStageButton3";
            this.backStageButton3.Size = new System.Drawing.Size(75, 23);
            this.backStageButton3.TabIndex = 5;
            this.backStageButton3.Text = "Switch Style";
            this.backStageButton3.Click += new System.EventHandler(this.backStageButton3_Click);
            // 
            // backStageButton4
            // 
            this.backStageButton4.BackColor = System.Drawing.Color.Transparent;
            this.backStageButton4.Location = new System.Drawing.Point(-37, 113);
            this.backStageButton4.Name = "backStageButton4";
            this.backStageButton4.Size = new System.Drawing.Size(75, 23);
            this.backStageButton4.TabIndex = 6;
            this.backStageButton4.Text = "       Exit";
            this.backStageButton4.Click += new System.EventHandler(this.backStageButton4_Click);
            // 
            // toolStripFile
            // 
            this.toolStripFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripFile.Name = "toolStripFile";
            // 
            // ribbonControlAdv1.ribbonPanel1
            // 
            this.toolStripFile.Panel.Controls.Add(this.toolStripFileNew);
            this.toolStripFile.Panel.Controls.Add(this.toolStripFileSearch);
            this.toolStripFile.Panel.Controls.Add(this.toolStripFilePage);
            this.toolStripFile.Panel.Controls.Add(this.toolStripFileHelp);
            this.toolStripFile.Panel.Name = "ribbonPanel1";
            this.toolStripFile.Panel.ScrollPosition = 0;
            this.toolStripFile.Panel.TabIndex = 2;
            this.toolStripFile.Panel.Text = "File";
            this.toolStripFile.Position = 0;
            this.toolStripFile.Size = new System.Drawing.Size(33, 21);
            this.toolStripFile.Text = "File";
            // 
            // toolStripFileNew
            // 
            this.toolStripFileNew.AutoSize = false;
            this.toolStripFileNew.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripFileNew.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripFileNew.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripFileNew.Image = null;
            this.toolStripFileNew.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNewPanel});
            this.toolStripFileNew.Location = new System.Drawing.Point(0, 1);
            this.toolStripFileNew.Name = "toolStripFileNew";
            this.toolStripFileNew.Size = new System.Drawing.Size(192, 94);
            this.toolStripFileNew.TabIndex = 0;
            this.toolStripFileNew.Text = "New";
            // 
            // toolStripNewPanel
            // 
            this.toolStripNewPanel.CausesValidation = false;
            this.toolStripNewPanel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripNewPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnmailMessage,
            this.toolbtnappointment,
            this.toolbtncontact,
            this.toolbtntask,
            this.toolbtnjournal,
            this.toolbtnnotes});
            this.toolStripNewPanel.Name = "toolStripNewPanel";
            this.toolStripNewPanel.Size = new System.Drawing.Size(167, 76);
            this.toolStripNewPanel.Text = "toolStripPanelItem6";
            this.toolStripNewPanel.Transparent = true;
            // 
            // toolbtnmailMessage
            // 
            this.toolbtnmailMessage.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnmailMessage.Image")));
            this.toolbtnmailMessage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnmailMessage.Name = "toolbtnmailMessage";
            this.toolbtnmailMessage.Size = new System.Drawing.Size(96, 20);
            this.toolbtnmailMessage.Text = "MailMessage";
            this.toolbtnmailMessage.Click += new System.EventHandler(this.toolbtnmailMessage_Click);
            // 
            // toolbtnappointment
            // 
            this.toolbtnappointment.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnappointment.Image")));
            this.toolbtnappointment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnappointment.Name = "toolbtnappointment";
            this.toolbtnappointment.Size = new System.Drawing.Size(98, 20);
            this.toolbtnappointment.Text = "Appointment";
            this.toolbtnappointment.Click += new System.EventHandler(this.toolbtnappointment_Click);
            // 
            // toolbtncontact
            // 
            this.toolbtncontact.Image = ((System.Drawing.Image)(resources.GetObject("toolbtncontact.Image")));
            this.toolbtncontact.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtncontact.Name = "toolbtncontact";
            this.toolbtncontact.Size = new System.Drawing.Size(69, 20);
            this.toolbtncontact.Text = "Contact";
            this.toolbtncontact.Click += new System.EventHandler(this.toolbtncontact_Click);
            // 
            // toolbtntask
            // 
            this.toolbtntask.Image = ((System.Drawing.Image)(resources.GetObject("toolbtntask.Image")));
            this.toolbtntask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtntask.Name = "toolbtntask";
            this.toolbtntask.Size = new System.Drawing.Size(51, 20);
            this.toolbtntask.Text = "Task";
            // 
            // toolbtnjournal
            // 
            this.toolbtnjournal.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnjournal.Image")));
            this.toolbtnjournal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnjournal.Name = "toolbtnjournal";
            this.toolbtnjournal.Size = new System.Drawing.Size(65, 20);
            this.toolbtnjournal.Text = "Journal";
            // 
            // toolbtnnotes
            // 
            this.toolbtnnotes.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnnotes.Image")));
            this.toolbtnnotes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnnotes.Name = "toolbtnnotes";
            this.toolbtnnotes.Size = new System.Drawing.Size(58, 20);
            this.toolbtnnotes.Text = "Notes";
            // 
            // toolStripFileSearch
            // 
            this.toolStripFileSearch.AutoSize = false;
            this.toolStripFileSearch.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripFileSearch.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripFileSearch.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripFileSearch.Image = null;
            this.toolStripFileSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSearchPanel});
            this.toolStripFileSearch.Location = new System.Drawing.Point(194, 1);
            this.toolStripFileSearch.Name = "toolStripFileSearch";
            this.toolStripFileSearch.Size = new System.Drawing.Size(127, 94);
            this.toolStripFileSearch.TabIndex = 1;
            this.toolStripFileSearch.Text = "Search";
            // 
            // toolStripSearchPanel
            // 
            this.toolStripSearchPanel.CausesValidation = false;
            this.toolStripSearchPanel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripSearchPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnfolder,
            this.toolbtnsearch});
            this.toolStripSearchPanel.Name = "toolStripSearchPanel";
            this.toolStripSearchPanel.Size = new System.Drawing.Size(102, 76);
            this.toolStripSearchPanel.Text = "toolStripPanelItem6";
            this.toolStripSearchPanel.Transparent = true;
            // 
            // toolbtnfolder
            // 
            this.toolbtnfolder.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnfolder.Image")));
            this.toolbtnfolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnfolder.Name = "toolbtnfolder";
            this.toolbtnfolder.Size = new System.Drawing.Size(60, 20);
            this.toolbtnfolder.Text = "Folder";
            // 
            // toolbtnsearch
            // 
            this.toolbtnsearch.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnsearch.Image")));
            this.toolbtnsearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnsearch.Name = "toolbtnsearch";
            this.toolbtnsearch.Size = new System.Drawing.Size(98, 20);
            this.toolbtnsearch.Text = "Search Folder";
            // 
            // toolStripFilePage
            // 
            this.toolStripFilePage.AutoSize = false;
            this.toolStripFilePage.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripFilePage.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripFilePage.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripFilePage.Image = null;
            this.toolStripFilePage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPagePanel});
            this.toolStripFilePage.Location = new System.Drawing.Point(323, 1);
            this.toolStripFilePage.Name = "toolStripFilePage";
            this.toolStripFilePage.Size = new System.Drawing.Size(126, 94);
            this.toolStripFilePage.TabIndex = 2;
            this.toolStripFilePage.Text = "Page Setup";
            // 
            // toolStripPagePanel
            // 
            this.toolStripPagePanel.CausesValidation = false;
            this.toolStripPagePanel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPagePanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnpreview,
            this.toolbtnprint});
            this.toolStripPagePanel.Name = "toolStripPagePanel";
            this.toolStripPagePanel.Size = new System.Drawing.Size(100, 76);
            this.toolStripPagePanel.Text = "toolStripPanelItem6";
            this.toolStripPagePanel.Transparent = true;
            // 
            // toolbtnpreview
            // 
            this.toolbtnpreview.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnpreview.Image")));
            this.toolbtnpreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnpreview.Name = "toolbtnpreview";
            this.toolbtnpreview.Size = new System.Drawing.Size(96, 20);
            this.toolbtnpreview.Text = "Print preview";
            // 
            // toolbtnprint
            // 
            this.toolbtnprint.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnprint.Image")));
            this.toolbtnprint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnprint.Name = "toolbtnprint";
            this.toolbtnprint.Size = new System.Drawing.Size(52, 20);
            this.toolbtnprint.Text = "print";
            // 
            // toolStripFileHelp
            // 
            this.toolStripFileHelp.AutoSize = false;
            this.toolStripFileHelp.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripFileHelp.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripFileHelp.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripFileHelp.Image = null;
            this.toolStripFileHelp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripHelpPanel});
            this.toolStripFileHelp.Location = new System.Drawing.Point(451, 1);
            this.toolStripFileHelp.Name = "toolStripFileHelp";
            this.toolStripFileHelp.Size = new System.Drawing.Size(106, 94);
            this.toolStripFileHelp.TabIndex = 3;
            this.toolStripFileHelp.Text = "Help";
            // 
            // toolStripHelpPanel
            // 
            this.toolStripHelpPanel.CausesValidation = false;
            this.toolStripHelpPanel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripHelpPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnhelp,
            this.toolbtnabout,
            this.toolbtnexit});
            this.toolStripHelpPanel.Name = "toolStripHelpPanel";
            this.toolStripHelpPanel.Size = new System.Drawing.Size(80, 76);
            this.toolStripHelpPanel.Text = "toolStripPanelItem6";
            this.toolStripHelpPanel.Transparent = true;
            // 
            // toolbtnhelp
            // 
            this.toolbtnhelp.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnhelp.Image")));
            this.toolbtnhelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnhelp.Name = "toolbtnhelp";
            this.toolbtnhelp.Size = new System.Drawing.Size(52, 20);
            this.toolbtnhelp.Text = "Help";
            this.toolbtnhelp.Click += new System.EventHandler(this.toolbtnhelp_Click);
            // 
            // toolbtnabout
            // 
            this.toolbtnabout.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnabout.Image")));
            this.toolbtnabout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnabout.Name = "toolbtnabout";
            this.toolbtnabout.Size = new System.Drawing.Size(76, 20);
            this.toolbtnabout.Text = "About Us";
            this.toolbtnabout.Click += new System.EventHandler(this.toolbtnabout_Click);
            // 
            // toolbtnexit
            // 
            this.toolbtnexit.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnexit.Image")));
            this.toolbtnexit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnexit.Name = "toolbtnexit";
            this.toolbtnexit.Size = new System.Drawing.Size(45, 20);
            this.toolbtnexit.Text = "Exit";
            this.toolbtnexit.Click += new System.EventHandler(this.toolbtnexit_Click);
            // 
            // toolStripEdit
            // 
            this.toolStripEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.toolStripEdit.Name = "toolStripEdit";
            // 
            // ribbonControlAdv1.ribbonPanel2
            // 
            this.toolStripEdit.Panel.Controls.Add(this.toolStripEditAction);
            this.toolStripEdit.Panel.Controls.Add(this.toolStripEditClipBoard);
            this.toolStripEdit.Panel.Controls.Add(this.toolStripEditDelete);
            this.toolStripEdit.Panel.Name = "ribbonPanel2";
            this.toolStripEdit.Panel.ScrollPosition = 0;
            this.toolStripEdit.Panel.TabIndex = 3;
            this.toolStripEdit.Panel.Text = "Edit";
            this.toolStripEdit.Position = 1;
            this.toolStripEdit.Size = new System.Drawing.Size(34, 21);
            this.toolStripEdit.Text = "Edit";
            // 
            // toolStripEditAction
            // 
            this.toolStripEditAction.AutoSize = false;
            this.toolStripEditAction.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEditAction.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEditAction.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEditAction.Image = null;
            this.toolStripEditAction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripActionPanel});
            this.toolStripEditAction.Location = new System.Drawing.Point(0, 1);
            this.toolStripEditAction.Name = "toolStripEditAction";
            this.toolStripEditAction.Size = new System.Drawing.Size(88, 0);
            this.toolStripEditAction.TabIndex = 0;
            this.toolStripEditAction.Text = "Actions";
            // 
            // toolStripActionPanel
            // 
            this.toolStripActionPanel.CausesValidation = false;
            this.toolStripActionPanel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripActionPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnundo,
            this.toolbtnredo});
            this.toolStripActionPanel.Name = "toolStripActionPanel";
            this.toolStripActionPanel.Size = new System.Drawing.Size(60, 0);
            this.toolStripActionPanel.Text = "toolStripPanelItem6";
            this.toolStripActionPanel.Transparent = true;
            // 
            // toolbtnundo
            // 
            this.toolbtnundo.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnundo.Image")));
            this.toolbtnundo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnundo.Name = "toolbtnundo";
            this.toolbtnundo.Size = new System.Drawing.Size(56, 20);
            this.toolbtnundo.Text = "Undo";
            // 
            // toolbtnredo
            // 
            this.toolbtnredo.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnredo.Image")));
            this.toolbtnredo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnredo.Name = "toolbtnredo";
            this.toolbtnredo.Size = new System.Drawing.Size(54, 20);
            this.toolbtnredo.Text = "Redo";
            // 
            // toolStripEditClipBoard
            // 
            this.toolStripEditClipBoard.AutoSize = false;
            this.toolStripEditClipBoard.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEditClipBoard.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEditClipBoard.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEditClipBoard.Image = null;
            this.toolStripEditClipBoard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripClipbdPanel,
            this.toolStripClipbd2Panel});
            this.toolStripEditClipBoard.Location = new System.Drawing.Point(90, 1);
            this.toolStripEditClipBoard.Name = "toolStripEditClipBoard";
            this.toolStripEditClipBoard.Size = new System.Drawing.Size(204, 0);
            this.toolStripEditClipBoard.TabIndex = 1;
            this.toolStripEditClipBoard.Text = "Clipboard";
            // 
            // toolStripClipbdPanel
            // 
            this.toolStripClipbdPanel.CausesValidation = false;
            this.toolStripClipbdPanel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripClipbdPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtncopy,
            this.toolbtncut});
            this.toolStripClipbdPanel.Name = "toolStripClipbdPanel";
            this.toolStripClipbdPanel.Size = new System.Drawing.Size(59, 0);
            this.toolStripClipbdPanel.Text = "toolStripPanelItem6";
            this.toolStripClipbdPanel.Transparent = true;
            // 
            // toolbtncopy
            // 
            this.toolbtncopy.Image = ((System.Drawing.Image)(resources.GetObject("toolbtncopy.Image")));
            this.toolbtncopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtncopy.Name = "toolbtncopy";
            this.toolbtncopy.Size = new System.Drawing.Size(55, 20);
            this.toolbtncopy.Text = "Copy";
            // 
            // toolbtncut
            // 
            this.toolbtncut.Image = ((System.Drawing.Image)(resources.GetObject("toolbtncut.Image")));
            this.toolbtncut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtncut.Name = "toolbtncut";
            this.toolbtncut.Size = new System.Drawing.Size(46, 20);
            this.toolbtncut.Text = "Cut";
            // 
            // toolStripClipbd2Panel
            // 
            this.toolStripClipbd2Panel.CausesValidation = false;
            this.toolStripClipbd2Panel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripClipbd2Panel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnclipboard,
            this.toolbtnpaste});
            this.toolStripClipbd2Panel.Name = "toolStripClipbd2Panel";
            this.toolStripClipbd2Panel.Size = new System.Drawing.Size(118, 0);
            this.toolStripClipbd2Panel.Text = "toolStripPanelItem6";
            this.toolStripClipbd2Panel.Transparent = true;
            // 
            // toolbtnclipboard
            // 
            this.toolbtnclipboard.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnclipboard.Image")));
            this.toolbtnclipboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnclipboard.Name = "toolbtnclipboard";
            this.toolbtnclipboard.Size = new System.Drawing.Size(114, 20);
            this.toolbtnclipboard.Text = "Office Clipboard";
            // 
            // toolbtnpaste
            // 
            this.toolbtnpaste.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnpaste.Image")));
            this.toolbtnpaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnpaste.Name = "toolbtnpaste";
            this.toolbtnpaste.Size = new System.Drawing.Size(55, 20);
            this.toolbtnpaste.Text = "Paste";
            // 
            // toolStripEditDelete
            // 
            this.toolStripEditDelete.AutoSize = false;
            this.toolStripEditDelete.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEditDelete.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEditDelete.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEditDelete.Image = null;
            this.toolStripEditDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDeletePanel,
            this.toolStripEditDelete2});
            this.toolStripEditDelete.Location = new System.Drawing.Point(296, 1);
            this.toolStripEditDelete.Name = "toolStripEditDelete";
            this.toolStripEditDelete.Size = new System.Drawing.Size(220, 0);
            this.toolStripEditDelete.TabIndex = 2;
            this.toolStripEditDelete.Text = "Delete";
            // 
            // toolStripDeletePanel
            // 
            this.toolStripDeletePanel.CausesValidation = false;
            this.toolStripDeletePanel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripDeletePanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtndel,
            this.toolbtnundel});
            this.toolStripDeletePanel.Name = "toolStripDeletePanel";
            this.toolStripDeletePanel.Size = new System.Drawing.Size(78, 0);
            this.toolStripDeletePanel.Text = "toolStripPanelItem6";
            this.toolStripDeletePanel.Transparent = true;
            // 
            // toolbtndel
            // 
            this.toolbtndel.Image = ((System.Drawing.Image)(resources.GetObject("toolbtndel.Image")));
            this.toolbtndel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtndel.Name = "toolbtndel";
            this.toolbtndel.Size = new System.Drawing.Size(60, 20);
            this.toolbtndel.Text = "Delete";
            // 
            // toolbtnundel
            // 
            this.toolbtnundel.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnundel.Image")));
            this.toolbtnundel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnundel.Name = "toolbtnundel";
            this.toolbtnundel.Size = new System.Drawing.Size(74, 20);
            this.toolbtnundel.Text = "Undelete";
            // 
            // toolStripEditDelete2
            // 
            this.toolStripEditDelete2.CausesValidation = false;
            this.toolStripEditDelete2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEditDelete2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnmove,
            this.toolbtncopyto});
            this.toolStripEditDelete2.Name = "toolStripEditDelete2";
            this.toolStripEditDelete2.Size = new System.Drawing.Size(114, 0);
            this.toolStripEditDelete2.Text = "toolStripPanelItem6";
            this.toolStripEditDelete2.Transparent = true;
            // 
            // toolbtnmove
            // 
            this.toolbtnmove.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnmove.Image")));
            this.toolbtnmove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnmove.Name = "toolbtnmove";
            this.toolbtnmove.Size = new System.Drawing.Size(110, 20);
            this.toolbtnmove.Text = "Move To Folder";
            // 
            // toolbtncopyto
            // 
            this.toolbtncopyto.Image = ((System.Drawing.Image)(resources.GetObject("toolbtncopyto.Image")));
            this.toolbtncopyto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtncopyto.Name = "toolbtncopyto";
            this.toolbtncopyto.Size = new System.Drawing.Size(108, 20);
            this.toolbtncopyto.Text = "Copy To Folder";
            // 
            // toolStripView
            // 
            this.toolStripView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.toolStripView.Name = "toolStripView";
            // 
            // ribbonControlAdv1.ribbonPanel3
            // 
            this.toolStripView.Panel.Controls.Add(this.toolStripViewArrange);
            this.toolStripView.Panel.Controls.Add(this.toolStripViewSwitch);
            this.toolStripView.Panel.Controls.Add(this.toolStripViewExp);
            this.toolStripView.Panel.Controls.Add(this.toolStripEx5);
            this.toolStripView.Panel.Name = "ribbonPanel3";
            this.toolStripView.Panel.ScrollPosition = 0;
            this.toolStripView.Panel.TabIndex = 4;
            this.toolStripView.Panel.Text = "View";
            this.toolStripView.Position = 2;
            this.toolStripView.Size = new System.Drawing.Size(39, 21);
            this.toolStripView.Text = "View";
            // 
            // toolStripViewArrange
            // 
            this.toolStripViewArrange.AutoSize = false;
            this.toolStripViewArrange.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripViewArrange.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripViewArrange.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripViewArrange.Image = null;
            this.toolStripViewArrange.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton14});
            this.toolStripViewArrange.Location = new System.Drawing.Point(0, 1);
            this.toolStripViewArrange.Name = "toolStripViewArrange";
            this.toolStripViewArrange.Size = new System.Drawing.Size(137, 0);
            this.toolStripViewArrange.TabIndex = 0;
            this.toolStripViewArrange.Text = "Arrange";
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(112, 0);
            this.toolStripButton14.Text = "Arrange by Date";
            // 
            // toolStripViewSwitch
            // 
            this.toolStripViewSwitch.AutoSize = false;
            this.toolStripViewSwitch.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripViewSwitch.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripViewSwitch.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripViewSwitch.Image = null;
            this.toolStripViewSwitch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripViewSwitchPanel});
            this.toolStripViewSwitch.Location = new System.Drawing.Point(139, 1);
            this.toolStripViewSwitch.Name = "toolStripViewSwitch";
            this.toolStripViewSwitch.Size = new System.Drawing.Size(143, 0);
            this.toolStripViewSwitch.TabIndex = 1;
            this.toolStripViewSwitch.Text = "Switch";
            // 
            // toolStripViewSwitchPanel
            // 
            this.toolStripViewSwitchPanel.CausesValidation = false;
            this.toolStripViewSwitchPanel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripViewSwitchPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolchknav,
            this.toolbtnautoprev});
            this.toolStripViewSwitchPanel.Name = "toolStripViewSwitchPanel";
            this.toolStripViewSwitchPanel.Size = new System.Drawing.Size(117, 0);
            this.toolStripViewSwitchPanel.Text = "toolStripPanelItem6";
            this.toolStripViewSwitchPanel.Transparent = true;
            // 
            // toolchknav
            // 
            this.toolchknav.Checked = true;
            this.toolchknav.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolchknav.Name = "toolchknav";
            this.toolchknav.Size = new System.Drawing.Size(113, 19);
            this.toolchknav.Text = "Navigation Pane";
            this.toolchknav.Click += new System.EventHandler(this.toolchknav_Click);
            // 
            // toolbtnautoprev
            // 
            this.toolbtnautoprev.Name = "toolbtnautoprev";
            this.toolbtnautoprev.Size = new System.Drawing.Size(96, 19);
            this.toolbtnautoprev.Text = "Auto Preview";
            this.toolbtnautoprev.Click += new System.EventHandler(this.toolbtnautoprev_Click);
            // 
            // toolStripViewExp
            // 
            this.toolStripViewExp.AutoSize = false;
            this.toolStripViewExp.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripViewExp.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripViewExp.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripViewExp.Image = null;
            this.toolStripViewExp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripViewExpand});
            this.toolStripViewExp.Location = new System.Drawing.Point(284, 1);
            this.toolStripViewExp.Name = "toolStripViewExp";
            this.toolStripViewExp.Size = new System.Drawing.Size(160, 0);
            this.toolStripViewExp.TabIndex = 2;
            this.toolStripViewExp.Text = "Expand/Collapse";
            // 
            // toolStripViewExpand
            // 
            this.toolStripViewExpand.CausesValidation = false;
            this.toolStripViewExpand.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripViewExpand.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnExpAllGroup,
            this.toolbtnCollapse,
            this.toolbtnExpthisGroup});
            this.toolStripViewExpand.Name = "toolStripViewExpand";
            this.toolStripViewExpand.Size = new System.Drawing.Size(132, 0);
            this.toolStripViewExpand.Text = "toolStripPanelItem6";
            this.toolStripViewExpand.Transparent = true;
            // 
            // toolbtnExpAllGroup
            // 
            this.toolbtnExpAllGroup.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnExpAllGroup.Image")));
            this.toolbtnExpAllGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnExpAllGroup.Name = "toolbtnExpAllGroup";
            this.toolbtnExpAllGroup.Size = new System.Drawing.Size(121, 20);
            this.toolbtnExpAllGroup.Text = "Expand all Groups";
            this.toolbtnExpAllGroup.Click += new System.EventHandler(this.toolbtnExpAllGroup_Click);
            // 
            // toolbtnCollapse
            // 
            this.toolbtnCollapse.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnCollapse.Image")));
            this.toolbtnCollapse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnCollapse.Name = "toolbtnCollapse";
            this.toolbtnCollapse.Size = new System.Drawing.Size(128, 20);
            this.toolbtnCollapse.Text = "Collapse all Groups";
            this.toolbtnCollapse.Click += new System.EventHandler(this.toolbtnCollapse_Click_1);
            // 
            // toolbtnExpthisGroup
            // 
            this.toolbtnExpthisGroup.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnExpthisGroup.Image")));
            this.toolbtnExpthisGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnExpthisGroup.Name = "toolbtnExpthisGroup";
            this.toolbtnExpthisGroup.Size = new System.Drawing.Size(123, 20);
            this.toolbtnExpthisGroup.Text = "Expand this Group";
            this.toolbtnExpthisGroup.Click += new System.EventHandler(this.toolbtnExpthisGroup_Click);
            // 
            // toolStripEx5
            // 
            this.toolStripEx5.AutoSize = false;
            this.toolStripEx5.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx5.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx5.Image = null;
            this.toolStripEx5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripReadPane});
            this.toolStripEx5.Location = new System.Drawing.Point(446, 1);
            this.toolStripEx5.Name = "toolStripEx5";
            this.toolStripEx5.Size = new System.Drawing.Size(80, 0);
            this.toolStripEx5.TabIndex = 3;
            this.toolStripEx5.Text = "Reading Pane";
            // 
            // toolStripReadPane
            // 
            this.toolStripReadPane.CausesValidation = false;
            this.toolStripReadPane.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripReadPane.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnRight,
            this.toolbtnBottom,
            this.toolbtnTop});
            this.toolStripReadPane.Name = "toolStripReadPane";
            this.toolStripReadPane.Size = new System.Drawing.Size(55, 0);
            this.toolStripReadPane.Text = "toolStripPanelItem6";
            this.toolStripReadPane.Transparent = true;
            // 
            // toolbtnRight
            // 
            this.toolbtnRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolbtnRight.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnRight.Image")));
            this.toolbtnRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnRight.Name = "toolbtnRight";
            this.toolbtnRight.Size = new System.Drawing.Size(39, 19);
            this.toolbtnRight.Text = "Right";
            this.toolbtnRight.Click += new System.EventHandler(this.toolbtnRight_Click);
            // 
            // toolbtnBottom
            // 
            this.toolbtnBottom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolbtnBottom.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnBottom.Image")));
            this.toolbtnBottom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnBottom.Name = "toolbtnBottom";
            this.toolbtnBottom.Size = new System.Drawing.Size(51, 19);
            this.toolbtnBottom.Text = "Bottom";
            this.toolbtnBottom.Click += new System.EventHandler(this.toolbtnBottom_Click);
            // 
            // toolbtnTop
            // 
            this.toolbtnTop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolbtnTop.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnTop.Image")));
            this.toolbtnTop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnTop.Name = "toolbtnTop";
            this.toolbtnTop.Size = new System.Drawing.Size(28, 19);
            this.toolbtnTop.Text = "Off";
            this.toolbtnTop.Click += new System.EventHandler(this.toolbtnTop_Click);
            // 
            // toolStripGo
            // 
            this.toolStripGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.toolStripGo.Name = "toolStripGo";
            // 
            // ribbonControlAdv1.ribbonPanel4
            // 
            this.toolStripGo.Panel.Controls.Add(this.toolStripGoItems);
            this.toolStripGo.Panel.Controls.Add(this.toolStripGoMisc);
            this.toolStripGo.Panel.Name = "ribbonPanel4";
            this.toolStripGo.Panel.ScrollPosition = 0;
            this.toolStripGo.Panel.TabIndex = 5;
            this.toolStripGo.Panel.Text = "Go";
            this.toolStripGo.Position = 3;
            this.toolStripGo.Size = new System.Drawing.Size(29, 21);
            this.toolStripGo.Text = "Go";
            // 
            // toolStripGoItems
            // 
            this.toolStripGoItems.AutoSize = false;
            this.toolStripGoItems.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripGoItems.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripGoItems.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripGoItems.Image = null;
            this.toolStripGoItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripGoItemsPanel});
            this.toolStripGoItems.Location = new System.Drawing.Point(0, 1);
            this.toolStripGoItems.Name = "toolStripGoItems";
            this.toolStripGoItems.Size = new System.Drawing.Size(176, 0);
            this.toolStripGoItems.TabIndex = 0;
            this.toolStripGoItems.Text = "Items";
            // 
            // toolStripGoItemsPanel
            // 
            this.toolStripGoItemsPanel.CausesValidation = false;
            this.toolStripGoItemsPanel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripGoItemsPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnmail,
            this.toolbtncalndr,
            this.toolbtncnt,
            this.toolbtntasks,
            this.toolbtnGonote});
            this.toolStripGoItemsPanel.Name = "toolStripGoItemsPanel";
            this.toolStripGoItemsPanel.Size = new System.Drawing.Size(136, 0);
            this.toolStripGoItemsPanel.Text = "toolStripPanelItem6";
            this.toolStripGoItemsPanel.Transparent = true;
            // 
            // toolbtnmail
            // 
            this.toolbtnmail.CheckOnClick = true;
            this.toolbtnmail.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnmail.Image")));
            this.toolbtnmail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnmail.Name = "toolbtnmail";
            this.toolbtnmail.Size = new System.Drawing.Size(50, 20);
            this.toolbtnmail.Text = "Mail";
            this.toolbtnmail.Click += new System.EventHandler(this.toolbtnmail_Click);
            // 
            // toolbtncalndr
            // 
            this.toolbtncalndr.CheckOnClick = true;
            this.toolbtncalndr.Image = ((System.Drawing.Image)(resources.GetObject("toolbtncalndr.Image")));
            this.toolbtncalndr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtncalndr.Name = "toolbtncalndr";
            this.toolbtncalndr.Size = new System.Drawing.Size(74, 20);
            this.toolbtncalndr.Text = "Calendar";
            this.toolbtncalndr.Click += new System.EventHandler(this.toolbtncalndr_Click);
            // 
            // toolbtncnt
            // 
            this.toolbtncnt.CheckOnClick = true;
            this.toolbtncnt.Image = ((System.Drawing.Image)(resources.GetObject("toolbtncnt.Image")));
            this.toolbtncnt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtncnt.Name = "toolbtncnt";
            this.toolbtncnt.Size = new System.Drawing.Size(74, 20);
            this.toolbtncnt.Text = "Contacts";
            this.toolbtncnt.Click += new System.EventHandler(this.toolbtncnt_Click);
            // 
            // toolbtntasks
            // 
            this.toolbtntasks.CheckOnClick = true;
            this.toolbtntasks.Image = ((System.Drawing.Image)(resources.GetObject("toolbtntasks.Image")));
            this.toolbtntasks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtntasks.Name = "toolbtntasks";
            this.toolbtntasks.Size = new System.Drawing.Size(56, 20);
            this.toolbtntasks.Text = "Tasks";
            this.toolbtntasks.Click += new System.EventHandler(this.toolbtntasks_Click);
            // 
            // toolbtnGonote
            // 
            this.toolbtnGonote.CheckOnClick = true;
            this.toolbtnGonote.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnGonote.Image")));
            this.toolbtnGonote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnGonote.Name = "toolbtnGonote";
            this.toolbtnGonote.Size = new System.Drawing.Size(58, 20);
            this.toolbtnGonote.Text = "Notes";
            this.toolbtnGonote.Click += new System.EventHandler(this.toolbtnGonote_Click);
            // 
            // toolStripGoMisc
            // 
            this.toolStripGoMisc.AutoSize = false;
            this.toolStripGoMisc.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripGoMisc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripGoMisc.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripGoMisc.Image = null;
            this.toolStripGoMisc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripGoMiscPanel});
            this.toolStripGoMisc.Location = new System.Drawing.Point(178, 1);
            this.toolStripGoMisc.Name = "toolStripGoMisc";
            this.toolStripGoMisc.Size = new System.Drawing.Size(100, 0);
            this.toolStripGoMisc.TabIndex = 1;
            this.toolStripGoMisc.Text = "Misc";
            // 
            // toolStripGoMiscPanel
            // 
            this.toolStripGoMiscPanel.CausesValidation = false;
            this.toolStripGoMiscPanel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripGoMiscPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnfolderlist,
            this.toolbtnGojournal});
            this.toolStripGoMiscPanel.Name = "toolStripGoMiscPanel";
            this.toolStripGoMiscPanel.Size = new System.Drawing.Size(85, 0);
            this.toolStripGoMiscPanel.Text = "toolStripPanelItem6";
            this.toolStripGoMiscPanel.Transparent = true;
            // 
            // toolbtnfolderlist
            // 
            this.toolbtnfolderlist.CheckOnClick = true;
            this.toolbtnfolderlist.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnfolderlist.Image")));
            this.toolbtnfolderlist.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnfolderlist.Name = "toolbtnfolderlist";
            this.toolbtnfolderlist.Size = new System.Drawing.Size(81, 20);
            this.toolbtnfolderlist.Text = "Folder List";
            this.toolbtnfolderlist.Click += new System.EventHandler(this.toolbtnfolderlist_Click);
            // 
            // toolbtnGojournal
            // 
            this.toolbtnGojournal.CheckOnClick = true;
            this.toolbtnGojournal.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnGojournal.Image")));
            this.toolbtnGojournal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnGojournal.Name = "toolbtnGojournal";
            this.toolbtnGojournal.Size = new System.Drawing.Size(70, 20);
            this.toolbtnGojournal.Text = "Journals";
            this.toolbtnGojournal.Click += new System.EventHandler(this.toolbtnGojournal_Click);
            // 
            // toolStripAction
            // 
            this.toolStripAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.toolStripAction.Name = "toolStripAction";
            // 
            // ribbonControlAdv1.ribbonPanel5
            // 
            this.toolStripAction.Panel.Controls.Add(this.toolStripActionsMail);
            this.toolStripAction.Panel.Controls.Add(this.toolStripActionRespond);
            this.toolStripAction.Panel.Name = "ribbonPanel5";
            this.toolStripAction.Panel.ScrollPosition = 0;
            this.toolStripAction.Panel.TabIndex = 6;
            this.toolStripAction.Panel.Text = "Actions";
            this.toolStripAction.Position = 4;
            this.toolStripAction.Size = new System.Drawing.Size(52, 21);
            this.toolStripAction.Text = "Actions";
            // 
            // toolStripActionsMail
            // 
            this.toolStripActionsMail.AutoSize = false;
            this.toolStripActionsMail.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripActionsMail.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripActionsMail.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripActionsMail.Image = null;
            this.toolStripActionsMail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripActionMailPanel});
            this.toolStripActionsMail.Location = new System.Drawing.Point(0, 1);
            this.toolStripActionsMail.Name = "toolStripActionsMail";
            this.toolStripActionsMail.Size = new System.Drawing.Size(158, 0);
            this.toolStripActionsMail.TabIndex = 0;
            this.toolStripActionsMail.Text = "Mail";
            // 
            // toolStripActionMailPanel
            // 
            this.toolStripActionMailPanel.CausesValidation = false;
            this.toolStripActionMailPanel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripActionMailPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnActionmail,
            this.toolbtnJunk});
            this.toolStripActionMailPanel.Name = "toolStripActionMailPanel";
            this.toolStripActionMailPanel.Size = new System.Drawing.Size(127, 0);
            this.toolStripActionMailPanel.Text = "toolStripPanelItem6";
            this.toolStripActionMailPanel.Transparent = true;
            // 
            // toolbtnActionmail
            // 
            this.toolbtnActionmail.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnActionmail.Image")));
            this.toolbtnActionmail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnActionmail.Name = "toolbtnActionmail";
            this.toolbtnActionmail.Size = new System.Drawing.Size(123, 20);
            this.toolbtnActionmail.Text = "New MailMessage";
            // 
            // toolbtnJunk
            // 
            this.toolbtnJunk.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnJunk.Image")));
            this.toolbtnJunk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnJunk.Name = "toolbtnJunk";
            this.toolbtnJunk.Size = new System.Drawing.Size(77, 20);
            this.toolbtnJunk.Text = "Junk Mail";
            // 
            // toolStripActionRespond
            // 
            this.toolStripActionRespond.AutoSize = false;
            this.toolStripActionRespond.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripActionRespond.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripActionRespond.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripActionRespond.Image = null;
            this.toolStripActionRespond.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnreply,
            this.toolStripSeparator2,
            this.toolbtnreplyall,
            this.toolStripSeparator1,
            this.toolbtnfwd,
            this.toolStripSeparator5,
            this.toolStripPanelItem6});
            this.toolStripActionRespond.Location = new System.Drawing.Point(160, 1);
            this.toolStripActionRespond.Name = "toolStripActionRespond";
            this.toolStripActionRespond.Size = new System.Drawing.Size(284, 0);
            this.toolStripActionRespond.TabIndex = 1;
            this.toolStripActionRespond.Text = "Respond";
            // 
            // toolbtnreply
            // 
            this.toolbtnreply.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnreply.Image")));
            this.toolbtnreply.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnreply.Name = "toolbtnreply";
            this.toolbtnreply.Size = new System.Drawing.Size(40, 0);
            this.toolbtnreply.Text = "Reply";
            this.toolbtnreply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 0);
            // 
            // toolbtnreplyall
            // 
            this.toolbtnreplyall.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnreplyall.Image")));
            this.toolbtnreplyall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnreplyall.Name = "toolbtnreplyall";
            this.toolbtnreplyall.Size = new System.Drawing.Size(71, 0);
            this.toolbtnreplyall.Text = "Reply to All";
            this.toolbtnreplyall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 0);
            // 
            // toolbtnfwd
            // 
            this.toolbtnfwd.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnfwd.Image")));
            this.toolbtnfwd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnfwd.Name = "toolbtnfwd";
            this.toolbtnfwd.Size = new System.Drawing.Size(54, 0);
            this.toolbtnfwd.Text = "Forward";
            this.toolbtnfwd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 0);
            // 
            // toolStripPanelItem6
            // 
            this.toolStripPanelItem6.CausesValidation = false;
            this.toolStripPanelItem6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnMeeting,
            this.toolbtnMore});
            this.toolStripPanelItem6.Name = "toolStripPanelItem6";
            this.toolStripPanelItem6.Size = new System.Drawing.Size(75, 0);
            this.toolStripPanelItem6.Text = "toolStripActionsPanel";
            this.toolStripPanelItem6.Transparent = true;
            // 
            // toolbtnMeeting
            // 
            this.toolbtnMeeting.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnMeeting.Image")));
            this.toolbtnMeeting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnMeeting.Name = "toolbtnMeeting";
            this.toolbtnMeeting.Size = new System.Drawing.Size(71, 20);
            this.toolbtnMeeting.Text = "Meeting";
            // 
            // toolbtnMore
            // 
            this.toolbtnMore.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnMore.Image")));
            this.toolbtnMore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnMore.Name = "toolbtnMore";
            this.toolbtnMore.Size = new System.Drawing.Size(55, 20);
            this.toolbtnMore.Text = "More";
            // 
            // toolStripStyle
            // 
            this.toolStripStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.toolStripStyle.Name = "toolStripStyle";
            // 
            // ribbonControlAdv1.ribbonPanel6
            // 
            this.toolStripStyle.Panel.Controls.Add(this.toolStripStyles);
            this.toolStripStyle.Panel.Name = "ribbonPanel6";
            this.toolStripStyle.Panel.ScrollPosition = 0;
            this.toolStripStyle.Panel.TabIndex = 7;
            this.toolStripStyle.Panel.Text = "OfficeThemeStyles";
            this.toolStripStyle.Position = 5;
            this.toolStripStyle.Size = new System.Drawing.Size(115, 21);
            this.toolStripStyle.Text = "OfficeThemeStyles";
            // 
            // toolStripStyles
            // 
            this.toolStripStyles.AutoSize = false;
            this.toolStripStyles.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripStyles.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripStyles.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripStyles.Image = null;
            this.toolStripStyles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnstyleBlue,
            this.toolStripSeparator3,
            this.toolbtnstyleBlack,
            this.toolStripSeparator4,
            this.toolbtnstyleSilver});
            this.toolStripStyles.Location = new System.Drawing.Point(0, 1);
            this.toolStripStyles.Name = "toolStripStyles";
            this.toolStripStyles.Size = new System.Drawing.Size(203, 0);
            this.toolStripStyles.TabIndex = 0;
            this.toolStripStyles.Text = "Skins";
            // 
            // toolbtnstyleBlue
            // 
            this.toolbtnstyleBlue.CheckOnClick = true;
            this.toolbtnstyleBlue.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnstyleBlue.Image")));
            this.toolbtnstyleBlue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnstyleBlue.Name = "toolbtnstyleBlue";
            this.toolbtnstyleBlue.Size = new System.Drawing.Size(50, 0);
            this.toolbtnstyleBlue.Text = "Blue";
            this.toolbtnstyleBlue.Click += new System.EventHandler(this.toolbtnstyleBlue_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 0);
            // 
            // toolbtnstyleBlack
            // 
            this.toolbtnstyleBlack.CheckOnClick = true;
            this.toolbtnstyleBlack.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnstyleBlack.Image")));
            this.toolbtnstyleBlack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnstyleBlack.Name = "toolbtnstyleBlack";
            this.toolbtnstyleBlack.Size = new System.Drawing.Size(55, 0);
            this.toolbtnstyleBlack.Text = "Black";
            this.toolbtnstyleBlack.Click += new System.EventHandler(this.toolbtnstyleBlack_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 0);
            // 
            // toolbtnstyleSilver
            // 
            this.toolbtnstyleSilver.CheckOnClick = true;
            this.toolbtnstyleSilver.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnstyleSilver.Image")));
            this.toolbtnstyleSilver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnstyleSilver.Name = "toolbtnstyleSilver";
            this.toolbtnstyleSilver.Size = new System.Drawing.Size(55, 0);
            this.toolbtnstyleSilver.Text = "Silver";
            this.toolbtnstyleSilver.Click += new System.EventHandler(this.toolbtnstyleSilver_Click);
            // 
            // toolbtnswitch
            // 
            this.toolbtnswitch.BackColor = System.Drawing.Color.Transparent;
            this.toolbtnswitch.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnswitch.Image")));
            this.toolbtnswitch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnswitch.Name = "toolbtnswitch";
            this.toolbtnswitch.Size = new System.Drawing.Size(125, 20);
            this.toolbtnswitch.Text = "Switch Office Style";
            this.toolbtnswitch.Click += new System.EventHandler(this.toolStripButton13_Click);
            // 
            // toolStripEx1
            // 
            this.toolStripEx1.AutoSize = false;
            this.toolStripEx1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPanelItem1});
            this.toolStripEx1.Location = new System.Drawing.Point(0, 1);
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.Size = new System.Drawing.Size(94, 91);
            this.toolStripEx1.TabIndex = 0;
            // 
            // toolStripPanelItem1
            // 
            this.toolStripPanelItem1.CausesValidation = false;
            this.toolStripPanelItem1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStripPanelItem1.Name = "toolStripPanelItem1";
            this.toolStripPanelItem1.Size = new System.Drawing.Size(60, 76);
            this.toolStripPanelItem1.Transparent = true;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(56, 20);
            this.toolStripButton1.Text = "Undo";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(54, 20);
            this.toolStripButton2.Text = "Redo";
            // 
            // toolStripEx2
            // 
            this.toolStripEx2.AutoSize = false;
            this.toolStripEx2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx2.Image = null;
            this.toolStripEx2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPanelItem2});
            this.toolStripEx2.Location = new System.Drawing.Point(96, 1);
            this.toolStripEx2.Name = "toolStripEx2";
            this.toolStripEx2.Size = new System.Drawing.Size(201, 91);
            this.toolStripEx2.TabIndex = 1;
            // 
            // toolStripPanelItem2
            // 
            this.toolStripPanelItem2.CausesValidation = false;
            this.toolStripPanelItem2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripLabel1});
            this.toolStripPanelItem2.Name = "toolStripPanelItem2";
            this.toolStripPanelItem2.Size = new System.Drawing.Size(173, 76);
            this.toolStripPanelItem2.Transparent = true;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(46, 20);
            this.toolStripButton3.Text = "Cut";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(55, 20);
            this.toolStripButton4.Text = "Copy";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(55, 20);
            this.toolStripButton5.Text = "Paste";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(114, 20);
            this.toolStripButton6.Text = "Office Clipboard";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(71, 16);
            this.toolStripLabel1.Text = "Select All";
            // 
            // toolStripEx3
            // 
            this.toolStripEx3.AutoSize = false;
            this.toolStripEx3.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx3.Image = null;
            this.toolStripEx3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPanelItem3,
            this.toolStripPanelItem4});
            this.toolStripEx3.Location = new System.Drawing.Point(299, 1);
            this.toolStripEx3.Name = "toolStripEx3";
            this.toolStripEx3.Size = new System.Drawing.Size(220, 91);
            this.toolStripEx3.TabIndex = 2;
            // 
            // toolStripPanelItem3
            // 
            this.toolStripPanelItem3.CausesValidation = false;
            this.toolStripPanelItem3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton7,
            this.toolStripButton10});
            this.toolStripPanelItem3.Name = "toolStripPanelItem3";
            this.toolStripPanelItem3.Size = new System.Drawing.Size(79, 76);
            this.toolStripPanelItem3.Transparent = true;
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(60, 20);
            this.toolStripButton7.Text = "Delete";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(75, 20);
            this.toolStripButton10.Text = "UnDelete";
            // 
            // toolStripPanelItem4
            // 
            this.toolStripPanelItem4.CausesValidation = false;
            this.toolStripPanelItem4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton8,
            this.toolStripButton9});
            this.toolStripPanelItem4.Name = "toolStripPanelItem4";
            this.toolStripPanelItem4.Size = new System.Drawing.Size(114, 76);
            this.toolStripPanelItem4.Transparent = true;
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(110, 20);
            this.toolStripButton8.Text = "Move To Folder";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(108, 20);
            this.toolStripButton9.Text = "Copy To Folder";
            // 
            // toolStripEx4
            // 
            this.toolStripEx4.AutoSize = false;
            this.toolStripEx4.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx4.Image = null;
            this.toolStripEx4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPanelItem5});
            this.toolStripEx4.Location = new System.Drawing.Point(521, 1);
            this.toolStripEx4.Name = "toolStripEx4";
            this.toolStripEx4.Size = new System.Drawing.Size(144, 91);
            this.toolStripEx4.TabIndex = 3;
            // 
            // toolStripPanelItem5
            // 
            this.toolStripPanelItem5.CausesValidation = false;
            this.toolStripPanelItem5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton11,
            this.toolStripButton12});
            this.toolStripPanelItem5.Name = "toolStripPanelItem5";
            this.toolStripPanelItem5.Size = new System.Drawing.Size(113, 76);
            this.toolStripPanelItem5.Transparent = true;
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(97, 20);
            this.toolStripButton11.Text = "Mark as Read";
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.Size = new System.Drawing.Size(109, 20);
            this.toolStripButton12.Text = "Mark as Unread";
            // 
            // backStageTab2
            // 
            this.backStageTab2.BackColor = System.Drawing.Color.White;
            this.backStageTab2.Controls.Add(this.pictureBox2);
            this.backStageTab2.Image = null;
            this.backStageTab2.ImageSize = new System.Drawing.Size(16, 16);
            this.backStageTab2.Location = new System.Drawing.Point(130, 1);
            this.backStageTab2.Name = "backStageTab2";
            this.backStageTab2.ShowCloseButton = true;
            this.backStageTab2.Size = new System.Drawing.Size(742, 686);
            this.backStageTab2.TabFont = null;
            this.backStageTab2.TabIndex = 3;
            this.backStageTab2.Text = "Open";
            this.backStageTab2.ThemesEnabled = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(742, 686);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // backStageTab3
            // 
            this.backStageTab3.BackColor = System.Drawing.Color.White;
            this.backStageTab3.Controls.Add(this.pictureBox3);
            this.backStageTab3.Image = null;
            this.backStageTab3.ImageSize = new System.Drawing.Size(16, 16);
            this.backStageTab3.Location = new System.Drawing.Point(130, 1);
            this.backStageTab3.Name = "backStageTab3";
            this.backStageTab3.ShowCloseButton = true;
            this.backStageTab3.Size = new System.Drawing.Size(742, 686);
            this.backStageTab3.TabFont = null;
            this.backStageTab3.TabIndex = 4;
            this.backStageTab3.Text = "Help";
            this.backStageTab3.ThemesEnabled = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(742, 686);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // backStageButton1
            // 
            this.backStageButton1.BackColor = System.Drawing.Color.Transparent;
            this.backStageButton1.Location = new System.Drawing.Point(27, 90);
            this.backStageButton1.Name = "backStageButton1";
            this.backStageButton1.Size = new System.Drawing.Size(75, 23);
            this.backStageButton1.TabIndex = 5;
            this.backStageButton1.Text = "Switch Style";
            // 
            // backStageButton2
            // 
            this.backStageButton2.BackColor = System.Drawing.Color.Transparent;
            this.backStageButton2.Location = new System.Drawing.Point(27, 113);
            this.backStageButton2.Name = "backStageButton2";
            this.backStageButton2.Size = new System.Drawing.Size(75, 23);
            this.backStageButton2.TabIndex = 6;
            this.backStageButton2.Text = "       Exit";
            this.backStageButton2.Click += new System.EventHandler(this.backStageButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(874, 742);
            this.Controls.Add(this.backStage1);
            this.Controls.Add(this.parentPanel);
            this.Controls.Add(this.ribbonControlAdv1);
            this.HelpButtonImage = ((System.Drawing.Image)(resources.GetObject("$this.HelpButtonImage")));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Outlook Demo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.parentPanel.ResumeLayout(false);
            this.parentPanel.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            //((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).EndInit();
            this.groupBar1.ResumeLayout(false);
            this.contactsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel5)).EndInit();
            this.gradientPanel5.ResumeLayout(false);
            this.gradientPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar2)).EndInit();
            this.xpTaskBar2.ResumeLayout(false);
            this.currentViewTaskBarBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.journalPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel10)).EndInit();
            this.gradientPanel10.ResumeLayout(false);
            this.gradientPanel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar6)).EndInit();
            this.xpTaskBar6.ResumeLayout(false);
            this.currentViewTaskBarBox3.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.folderlistPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel8)).EndInit();
            this.gradientPanel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar5)).EndInit();
            this.xpTaskBar5.ResumeLayout(false);
            this.allFoldersTaskBarBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel9)).EndInit();
            this.gradientPanel9.ResumeLayout(false);
            this.calendarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).EndInit();
            this.gradientPanel3.ResumeLayout(false);
            this.gradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar1)).EndInit();
            this.xpTaskBar1.ResumeLayout(false);
            this.myCalendarsTaskBarBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).EndInit();
            this.gradientPanel4.ResumeLayout(false);
            this.gradientPanel4.PerformLayout();
            this.mailPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mailTaskBar)).EndInit();
            this.mailTaskBar.ResumeLayout(false);
            this.mailTaskBarBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.notesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel7)).EndInit();
            this.gradientPanel7.ResumeLayout(false);
            this.gradientPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar4)).EndInit();
            this.xpTaskBar4.ResumeLayout(false);
            this.currentViewTaskBarBox2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.tasksPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel6)).EndInit();
            this.gradientPanel6.ResumeLayout(false);
            this.gradientPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar3)).EndInit();
            this.xpTaskBar3.ResumeLayout(false);
            this.currentViewTaskBarBox1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.clientPanel.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.statusStripEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).EndInit();
            this.ribbonControlAdv1.ResumeLayout(false);
            this.ribbonControlAdv1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backStage1)).EndInit();
            this.backStage1.ResumeLayout(false);
            this.backStageTab1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.backStageTab4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.backStageTab5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.toolStripFile.Panel.ResumeLayout(false);
            this.toolStripFileNew.ResumeLayout(false);
            this.toolStripFileNew.PerformLayout();
            this.toolStripFileSearch.ResumeLayout(false);
            this.toolStripFileSearch.PerformLayout();
            this.toolStripFilePage.ResumeLayout(false);
            this.toolStripFilePage.PerformLayout();
            this.toolStripFileHelp.ResumeLayout(false);
            this.toolStripFileHelp.PerformLayout();
            this.toolStripEdit.Panel.ResumeLayout(false);
            this.toolStripEditAction.ResumeLayout(false);
            this.toolStripEditAction.PerformLayout();
            this.toolStripEditClipBoard.ResumeLayout(false);
            this.toolStripEditClipBoard.PerformLayout();
            this.toolStripEditDelete.ResumeLayout(false);
            this.toolStripEditDelete.PerformLayout();
            this.toolStripView.Panel.ResumeLayout(false);
            this.toolStripViewArrange.ResumeLayout(false);
            this.toolStripViewArrange.PerformLayout();
            this.toolStripViewSwitch.ResumeLayout(false);
            this.toolStripViewSwitch.PerformLayout();
            this.toolStripViewExp.ResumeLayout(false);
            this.toolStripViewExp.PerformLayout();
            this.toolStripEx5.ResumeLayout(false);
            this.toolStripEx5.PerformLayout();
            this.toolStripGo.Panel.ResumeLayout(false);
            this.toolStripGoItems.ResumeLayout(false);
            this.toolStripGoItems.PerformLayout();
            this.toolStripGoMisc.ResumeLayout(false);
            this.toolStripGoMisc.PerformLayout();
            this.toolStripAction.Panel.ResumeLayout(false);
            this.toolStripActionsMail.ResumeLayout(false);
            this.toolStripActionsMail.PerformLayout();
            this.toolStripActionRespond.ResumeLayout(false);
            this.toolStripActionRespond.PerformLayout();
            this.toolStripStyle.Panel.ResumeLayout(false);
            this.toolStripStyles.ResumeLayout(false);
            this.toolStripStyles.PerformLayout();
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            this.toolStripEx2.ResumeLayout(false);
            this.toolStripEx2.PerformLayout();
            this.toolStripEx3.ResumeLayout(false);
            this.toolStripEx3.PerformLayout();
            this.toolStripEx4.ResumeLayout(false);
            this.toolStripEx4.PerformLayout();
            this.backStageTab2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.backStageTab3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Theme Changes

        private string themeStyle = "Blue";
        public static int r = 189, g = 215, b = 252, r1 = 220, g1 = 235, b1 = 254;
       

        private void SetBackGroundTheme()
        {
            this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((System.Byte)(r1)), ((System.Byte)(g1)), ((System.Byte)(b1))), System.Drawing.Color.FromArgb(((System.Byte)(r)), ((System.Byte)(g)), ((System.Byte)(b))));
            this.gridContainerPanel.BackColor = Color.FromArgb(r, g, b);
            this.splitContainer1.BackColor = Color.FromArgb(r, g, b);
            this.gridGroupingPanel.BackColor = Color.FromArgb(r, g, b);
            this.splitter2.BackColor = Color.FromArgb(r, g, b);
            this.panel16.BackColor = Color.FromArgb(r1, g1, b1);
            this.panel3.BackColor = Color.FromArgb(r, g, b);
            this.panel4.BackColor = Color.FromArgb(r, g, b);
            this.panel5.BackColor = Color.FromArgb(r, g, b);
			this.panel1.BackColor = Color.FromArgb(r, g, b);
			this.panel8.BackColor = Color.FromArgb(r, g, b);
			this.panel11.BackColor = Color.FromArgb(r, g, b);
            this.calForm.BackColor = Color.FromArgb(r, g, b);
            
        }

        
        #endregion

        #region Event Handlers
        private void OnNewMailMessageClick(object sender, EventArgs e)
        {
            new NewMailForm(this, this.themeStyle).Show();
        }

        private void TaskBarBox_ProvideHeaderBackgroundBrush(object sender, ProvideBrushEventArgs args)
        {
            System.Drawing.Drawing2D.Blend blend = new System.Drawing.Drawing2D.Blend();
            blend.Factors = new float[] { 0.0f, 0.25F, 0.5f, 1.0F };
            blend.Positions = new float[] { 0.0F, 0.25F, 0.5F, 1.0F, 1.5F };
            // Estimate the GroupBarItem bounds

            Rectangle rcgroupbaritem = args.Bounds;
            // Create and initialize the LinearGradientBrush
            System.Drawing.Drawing2D.LinearGradientBrush lgbrush = new System.Drawing.Drawing2D.LinearGradientBrush(rcgroupbaritem, Color.White, Color.FromArgb(r, g, b), 90, true);
            lgbrush.Blend = blend;
            args.Brush = lgbrush;
        }

        void mailTaskBar_SizeChanged(object sender, EventArgs e)
        {
            //this.mailTaskBarBox.PreferredChildPanelHeight = this.mailTaskBar.Height - this.favouritesTaskBarBox.Height;
        }

        private void groupBar1_NavigationPaneDropDownClick(object sender, Syncfusion.Windows.Forms.Tools.NavigationPaneDropDownClickEventArgs args)
        {
            // Add the 'Navigation Pane Options' and 'Add and Remove Buttons' menu commands to the GroupBar's dropdown menu
            args.ContextMenuProvider.AddContextMenuItem(String.Empty, "Navigation Pane Options...", new EventHandler(this.NavPaneOptions_Click));
            String addremove = "Add or Remove Buttons";
            
            // Create and add a BarItem for each GroupBarItem in the GroupBar control
            foreach (GroupBarItem item in this.groupBar1.GroupBarItems)
            {
                args.ContextMenuProvider.AddContextMenuItem(addremove, item.Text, new EventHandler(this.AddRemoveButtons_Click));
                args.ContextMenuProvider.SetContextMenuItemChecked(item.Text, item.Visible);
                args.ContextMenuProvider.SetContextMenuItemImage(item.Text, this.smallImageList, (int)this.htLabelToImageIndex[item.Text]);
            }
        }

        public void SetTheme(String theme)
        {
            switch (theme)
            {
                case "Blue":
                    themeStyle = "Blue";
                    r = 189; g = 215; b = 252; r1 = 220; g1 = 235; b1 = 254;
                    SetBackGroundTheme();
                    this.groupBar1.Office2007Theme = Office2007Theme.Blue;
                    this.statusStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Blue;
                    this.ColorScheme = ColorSchemeType.Blue;

                    this.calForm.btnDay.Office2007ColorScheme = Office2007Theme.Blue;
                    this.calForm.btnMonth.Office2007ColorScheme = Office2007Theme.Blue;
                    this.calForm.btnWeek.Office2007ColorScheme = Office2007Theme.Blue;
                    this.calForm.scheduleControl1.Appearance.VisualStyle = GridVisualStyles.Office2007Blue;
                    this.gridGroupingPanel.Grid.TableOptions.GridVisualStyles = GridVisualStyles.Office2007Blue;
                    break;
                case "Black":
                    themeStyle = "Black";
                    SetBackGroundTheme();
                    r = 109; g = 109; b = 109; r1 = 61; g1 = 61; b1 = 61;
                    SetBackGroundTheme();
                    this.groupBar1.Office2007Theme = Office2007Theme.Black;
                    this.statusStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Black;
                    this.ColorScheme = ColorSchemeType.Black;
                    this.calForm.btnDay.Office2007ColorScheme = Office2007Theme.Black;
                    this.calForm.btnMonth.Office2007ColorScheme = Office2007Theme.Black;
                    this.calForm.btnWeek.Office2007ColorScheme = Office2007Theme.Black;
                    this.calForm.scheduleControl1.Appearance.VisualStyle = GridVisualStyles.Office2007Black;
                    this.gridGroupingPanel.Grid.TableOptions.GridVisualStyles = GridVisualStyles.Office2007Black;
                    break;
                case "Silver":
                    themeStyle = "Silver";
                    r = 212; g = 214; b = 219; r1 = 178; g1 = 183; b1 = 190;
                    SetBackGroundTheme();
                    this.groupBar1.Office2007Theme = Office2007Theme.Silver;
                    this.statusStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Silver;
                    this.ColorScheme = ColorSchemeType.Silver;
                    this.calForm.btnDay.Office2007ColorScheme = Office2007Theme.Silver;
                    this.calForm.btnMonth.Office2007ColorScheme = Office2007Theme.Silver;
                    this.calForm.btnWeek.Office2007ColorScheme = Office2007Theme.Silver;
                    this.calForm.scheduleControl1.Appearance.VisualStyle = GridVisualStyles.Office2007Silver;
                    this.gridGroupingPanel.Grid.TableOptions.GridVisualStyles = GridVisualStyles.Office2007Silver;
                    break;
            }
            this.Refresh();
        }

        private void NavPaneOptions_Click(object sender, System.EventArgs e)
        {
            OutlookDemo.OptionsForm optform = new OutlookDemo.OptionsForm(this);
            optform.ShowDialog(this);
        }

        private void AddRemoveButtons_Click(object sender, System.EventArgs e)
        {
            // Hide or show the GroupBarItem that was clicked on the PopupMenu
            Syncfusion.Windows.Forms.ContextMenuItem cntxtitem = sender as ContextMenuItem;
            String itemtext = cntxtitem.ContextMenuItemText;
            foreach (GroupBarItem item in this.groupBar1.GroupBarItems)
            {
                if (item.Text == itemtext)
                {
                    item.Visible = !item.Visible;
                    break;
                }
            }
        }

        protected override void OnSystemColorsChanged(EventArgs e)
        {
            base.OnSystemColorsChanged(e);
            this.InitializeGroupBarClientColors();
        }



        private void groupBar1_GroupBarItemSelected(object sender, System.EventArgs e)
        {
            // Set the text for the ClientPanel labels
            GroupBarItem selitem = this.groupBar1.GroupBarItems[this.groupBar1.SelectedItem];
            if (selitem.Text == "Mail")
                this.clientPanelLabel1.Text = "Inbox";
            else
                this.clientPanelLabel1.Text = selitem.Text;
            this.clientPanelLabel2.Text = String.Empty;
			if (htLabelToImageIndex.Count > 0 )
            this.clientPanelImage.ImageIndex = (int)this.htLabelToImageIndex[selitem.Text];
        }

        private void mailBarItem_Click(object sender, System.EventArgs e)
        {
            this.SetGroupBarSelectedItem("Mail");
        }

        private void calendarBarItem_Click(object sender, System.EventArgs e)
        {
            this.groupBar1.SelectedItem = 1;
        }

        private void contactsBarItem_Click(object sender, System.EventArgs e)
        {
            this.SetGroupBarSelectedItem("Contacts");
        }

        private void tasksBarItem_Click(object sender, System.EventArgs e)
        {
            this.SetGroupBarSelectedItem("Tasks");
        }

        private void notesBarItem_Click(object sender, System.EventArgs e)
        {
            this.SetGroupBarSelectedItem("Notes");
        }

        private void folderlistBarItem_Click(object sender, System.EventArgs e)
        {
            this.SetGroupBarSelectedItem("Folder List");
        }

        private void journalBarItem_Click(object sender, System.EventArgs e)
        {
            this.SetGroupBarSelectedItem("Journal");
        }

        private void SetGroupBarSelectedItem(String itemtext)
        {
            int selecteditem = -1;
            foreach (GroupBarItem item in this.groupBar1.GroupBarItems)
            {
                if (item.Text == itemtext)
                {
                    if (item.Visible == true)
                        selecteditem = this.groupBar1.GroupBarItems.IndexOf(item);
                    break;
                }
            }
            if (selecteditem != -1)
                this.groupBar1.SelectedItem = selecteditem;
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.gridGroupingPanel.Grid.Table.ExpandAllGroups();
            
        }

        private void Form1_Closing(object sender, CancelEventArgs e)
        {
            this.gridGroupingPanel.Close();
        }

        private GridBorder gridBottomBorderhide = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
        private GridBorder gridBottomBorderShow = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, Color.FromArgb(227, 239, 255), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);

        private void Model_SelectionChanging(object sender, GridSelectionChangingEventArgs e)
        {
            // use the Nested display elements to know the selection is of record or caption
            int row = 0;
            if (Control.MouseButtons == MouseButtons.Right)
                e.Cancel = true;

            if (e.Reason != GridSelectionReason.MouseMove)
                row = e.Range.Top;

            if (this.gridGroupingPanel.Grid.Table.NestedDisplayElements.Count > row)
            {
                // If the selection is of caption hide the reading pane
                if (this.gridGroupingPanel.Grid.Table.NestedDisplayElements[row].IsCaption())
                    this.Display.Hide();
                if (this.gridGroupingPanel.Grid.Table.NestedDisplayElements[row].IsRecord())
                {
                    this.Display.Show();

                    Record rec = this.gridGroupingPanel.Grid.Table.CurrentRecord;
                    DataRowView drv = this.gridGroupingPanel.Grid.Table.NestedDisplayElements[row].GetData() as DataRowView;

                    string rtf2 =
                        @"{\rtf1\ansi" +
                        // font table
                        @"{\fonttbl" +
                        @"\f0\fswiss Calibri;} " +
                        @"\highlight0\ql\f3\f0\fs28   " + drv["Subject"] + "\\plain\\par" +
                        @"\highlight\ql\f0\f0\fs26    " + drv["From"] + "\\plain\\par" +
                        @"\highlight1\ql\cf0\f0\fs20 {\b     To :}" + drv["To"] + "\\plain\\par" + Environment.NewLine +
                        @"\highlight1\ql\f0\f2\fs20 " + "\\plain\\par" +
                        // third line
                        @"\highlight1\ql\cf0\f0\fs20     " + drv["Content"] + "\\plain\\par" +
                        // closing bracket
                        @"}";

                    // Use display to show the content..
                    if (e.Reason == GridSelectionReason.MouseDown || e.Reason == GridSelectionReason.ArrowKey)
                    {
                        Display.Rtf = rtf2;
                    }
                }
            }
        }

        private void groupBar1_GroupBarItemSelectionChanging(object sender, GroupBarItemSelectionChangingEventArgs args)
        {
            if (this.groupBar1.GroupBarItems[args.NewSelected].Text == "Calendar")
            {
                this.gradientPanel1.Hide();
                this.gridContainerPanel.Hide();
                this.panel16.Hide();
                scheduleContainerPanel.Show();
                this.calendarPanel.Controls.Add(this.calForm.Scheduler.Calendar);
                this.toolStripStatusLabel1.Text = this.calForm.Scheduler.Calendar.DateValue.ToLongDateString();
                this.clientPanel.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (this.groupBar1.GroupBarItems[args.NewSelected].Text == "Contacts")
            {
                this.clientPanel.BorderStyle = BorderStyle.None;
                this.gridContainerPanel.Hide();
                this.panel16.Hide();
                this.scheduleContainerPanel.Hide();
                this.gradientPanel1.Show();
                this.contactsGridPanel.Show();
                int count = this.contactForm.Grid.TableModel.RowCount - 1;
                this.toolStripStatusLabel1.Text = count.ToString() + " Items";
            }
            else
            {
                this.clientPanel.BorderStyle = BorderStyle.None;
                this.scheduleContainerPanel.Hide();
                this.gridContainerPanel.Show();
                this.panel16.Show();
                this.contactsGridPanel.Hide();
                this.gradientPanel1.Show();
                this.toolStripStatusLabel1.Text = this.gridGroupingPanel.Grid.Table.Records.Count.ToString() + " Messages";
            }
        }

        private void Table_RecordDeleted(object sender, RecordEventArgs e)
        {
            this.toolStripStatusLabel1.Text = this.gridGroupingPanel.Grid.Table.Records.Count.ToString() + " Messages";
        }

        private void radioButton5_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioButton5.Checked)
                this.contactForm.Grid.TableDescriptor.GroupedColumns.Add("CompanyName");
            else
                this.contactForm.Grid.TableDescriptor.GroupedColumns.Remove("CompanyName");
        }

        private void radioButton4_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioButton4.Checked)
                this.contactForm.Grid.TableDescriptor.GroupedColumns.Add("ContactTitle");
            else
                this.contactForm.Grid.TableDescriptor.GroupedColumns.Remove("ContactTitle");
        }

        private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioButton3.Checked)
                this.contactForm.Grid.TableDescriptor.GroupedColumns.Add("Phone");
            else
                this.contactForm.Grid.TableDescriptor.GroupedColumns.Remove("Phone");
        }

        #endregion

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            if (this.ribbonControlAdv1.RibbonStyle == RibbonStyle.Office2010)
            {
                this.ribbonControlAdv1.RibbonStyle = RibbonStyle.Office2007;
                this.ribbonControlAdv1.MenuButtonImage = Image.FromFile(@"..\..\res\outlook2007_small.jpg");
            }
            else
            {
                this.ribbonControlAdv1.RibbonStyle = RibbonStyle.Office2010;
                this.ribbonControlAdv1.MenuButtonImage = Image.FromFile(@"..\..\res\Outlook2010IconSmall.jpg");
            }
        }

        private void toolbtnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolchknav_Click(object sender, EventArgs e)
        {
            if (this.toolchknav.Checked)
                this.groupBar1.Show();
            else
                this.groupBar1.Hide();
        }

        private void toolbtnautoprev_Click(object sender, EventArgs e)
        {
            if (this.groupBar1.SelectedItem == 0)
            {
                ToolStripCheckBox barItem = (ToolStripCheckBox)sender;
                this.gridGroupingPanel.Grid.TableOptions.ShowRecordPreviewRow = !this.gridGroupingPanel.Grid.TableOptions.ShowRecordPreviewRow;
                if (barItem.Checked)
                {
                    //Turning Preview On
                    this.gridGroupingPanel.Grid.Appearance.AnyRecordFieldCell.Borders.Bottom = gridBottomBorderhide;
                    this.gridGroupingPanel.Grid.Appearance.AnyIndentCell.Borders.Bottom = gridBottomBorderhide;
                    foreach (Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gcd in this.gridGroupingPanel.Grid.TableDescriptor.Columns)
                    {
                        gcd.Appearance.AnyRecordFieldCell.Borders.Bottom = gridBottomBorderhide;
                        gcd.GroupByAppearance.GroupIndentCell.Borders.Bottom = gridBottomBorderhide;
                    }
                    this.gridGroupingPanel.PreviewSelected = true;
                }
                else
                {
                    //Turning Preview Off
                    this.gridGroupingPanel.Grid.Appearance.AnyRecordFieldCell.Borders.Bottom = gridBottomBorderShow;
                    this.gridGroupingPanel.Grid.Appearance.AnyIndentCell.Borders.Bottom = gridBottomBorderShow;
                    foreach (Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gcd in this.gridGroupingPanel.Grid.TableDescriptor.Columns)
                    {
                        gcd.Appearance.AnyRecordFieldCell.Borders.Bottom = gridBottomBorderShow;
                        gcd.GroupByAppearance.GroupIndentCell.Borders.Bottom = gridBottomBorderShow;
                    }
                    this.gridGroupingPanel.PreviewSelected = false;
                }
            }
            else if (this.groupBar1.SelectedItem == 2)
            {
                this.contactForm.Grid.TableModel.Properties.DisplayVertLines = !this.contactForm.Grid.TableModel.Properties.DisplayVertLines;
            }
        }


        private void toolbtnRight_Click(object sender, EventArgs e)
        {
            // Toggle the reading pane to dock right

            this.gridContainerPanel.Width = 700;
            this.gridContainerPanel.Dock = DockStyle.Left;
            this.splitter2.Dock = DockStyle.Left;
            //this.panel16.Width=280;
            this.panel16.Width = 310;
            this.panel16.Dock = DockStyle.Right;
            this.panel16.Show();
        }

        private void toolbtnBottom_Click(object sender, EventArgs e)
        {
            // Toggle the reading pane to dock bottom
            this.gridContainerPanel.Height = 325;
            this.gridContainerPanel.Dock = DockStyle.Top;
            this.splitter2.Dock = DockStyle.Top;
            this.panel16.Dock = DockStyle.Fill;
            this.panel16.Show();
        }

        private void toolbtnTop_Click(object sender, EventArgs e)
        {
            this.panel16.Hide();
            this.gridContainerPanel.Dock = DockStyle.Fill;
        }

        private void toolbtnstyleBlue_Click(object sender, EventArgs e)
        {
            this.toolbtnstyleBlack.Checked = false;
            this.toolbtnstyleSilver.Checked = false;
            themeStyle = "Blue";
            r = 189; g = 215; b = 252; r1 = 220; g1 = 235; b1 = 254;
            SetBackGroundTheme();
            this.groupBar1.Office2007Theme = Office2007Theme.Blue;
            this.statusStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Blue;
            this.ColorScheme = ColorSchemeType.Blue;

            this.calForm.btnDay.Office2007ColorScheme = Office2007Theme.Blue;
            this.calForm.btnMonth.Office2007ColorScheme = Office2007Theme.Blue;
            this.calForm.btnWeek.Office2007ColorScheme = Office2007Theme.Blue;
            this.calForm.scheduleControl1.Appearance.VisualStyle = GridVisualStyles.Office2007Blue;
            this.gridGroupingPanel.Grid.TableOptions.GridVisualStyles = GridVisualStyles.Office2007Blue;
            this.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Blue;
            this.Refresh();
        }

        private void toolbtnstyleBlack_Click(object sender, EventArgs e)
        {
            this.toolbtnstyleBlue.Checked = false;
            this.toolbtnstyleSilver.Checked = false;
            themeStyle = "Black";
            SetBackGroundTheme();
            r = 109; g = 109; b = 109; r1 = 61; g1 = 61; b1 = 61;
            SetBackGroundTheme();
            this.groupBar1.Office2007Theme = Office2007Theme.Black;
            this.statusStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Black;
            this.ColorScheme = ColorSchemeType.Black;

            this.calForm.btnDay.Office2007ColorScheme = Office2007Theme.Black;
            this.calForm.btnMonth.Office2007ColorScheme = Office2007Theme.Black;
            this.calForm.btnWeek.Office2007ColorScheme = Office2007Theme.Black;
            this.calForm.scheduleControl1.Appearance.VisualStyle = GridVisualStyles.Office2007Black;
            this.gridGroupingPanel.Grid.TableOptions.GridVisualStyles = GridVisualStyles.Office2007Black;
            this.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Black;
            this.Refresh();
        }

        private void toolbtnstyleSilver_Click(object sender, EventArgs e)
        {
            this.toolbtnstyleBlack.Checked = false;
            this.toolbtnstyleBlue.Checked = false;
            themeStyle = "Silver";
            r = 212; g = 214; b = 219; r1 = 178; g1 = 183; b1 = 190;
            SetBackGroundTheme();
            this.groupBar1.Office2007Theme = Office2007Theme.Silver;
            this.statusStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Silver;
            this.ColorScheme = ColorSchemeType.Silver;
            this.calForm.btnDay.Office2007ColorScheme = Office2007Theme.Silver;
            this.calForm.btnMonth.Office2007ColorScheme = Office2007Theme.Silver;
            this.calForm.btnWeek.Office2007ColorScheme = Office2007Theme.Silver;
            this.calForm.scheduleControl1.Appearance.VisualStyle = GridVisualStyles.Office2007Silver;
            this.gridGroupingPanel.Grid.TableOptions.GridVisualStyles = GridVisualStyles.Office2007Silver;
            this.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Silver;
            this.Refresh();
        }

        private void toolbtnmail_Click(object sender, EventArgs e)
        {
            this.SetGroupBarSelectedItem("Mail");
            this.toolbtncalndr.Checked = false;
            this.toolbtncnt.Checked = false;
            this.toolbtntasks.Checked = false;
            this.toolbtnGonote.Checked = false;
            this.toolbtnfolderlist.Checked = false;
            this.toolbtnGojournal.Checked = false;
        }

        private void toolbtncalndr_Click(object sender, EventArgs e)
        {
            this.groupBar1.SelectedItem = 1;
            this.toolbtnmail.Checked = false;
            this.toolbtncnt.Checked = false;
            this.toolbtntasks.Checked = false;
            this.toolbtnGonote.Checked = false;
            this.toolbtnfolderlist.Checked = false;
            this.toolbtnGojournal.Checked = false;
        }

        private void toolbtncnt_Click(object sender, EventArgs e)
        {
            this.SetGroupBarSelectedItem("Contacts");
            this.toolbtnmail.Checked = false;
            this.toolbtncalndr.Checked = false;
            this.toolbtntasks.Checked = false;
            this.toolbtnGonote.Checked = false;
            this.toolbtnfolderlist.Checked = false;
            this.toolbtnGojournal.Checked = false;
        }

        private void toolbtntasks_Click(object sender, EventArgs e)
        {
            this.SetGroupBarSelectedItem("Tasks");
            this.toolbtnmail.Checked = false;
            this.toolbtncalndr.Checked = false;
            this.toolbtncnt.Checked = false;
            this.toolbtnGonote.Checked = false;
            this.toolbtnfolderlist.Checked = false;
            this.toolbtnGojournal.Checked = false;
        }

        private void toolbtnGonote_Click(object sender, EventArgs e)
        {
            this.SetGroupBarSelectedItem("Notes");
            this.toolbtnmail.Checked = false;
            this.toolbtncalndr.Checked = false;
            this.toolbtncnt.Checked = false;
            this.toolbtntasks.Checked = false;
            this.toolbtnfolderlist.Checked = false;
            this.toolbtnGojournal.Checked = false;
        }

        private void toolbtnfolderlist_Click(object sender, EventArgs e)
        {
            this.SetGroupBarSelectedItem("Folder List");
            this.toolbtnmail.Checked = false;
            this.toolbtncalndr.Checked = false;
            this.toolbtncnt.Checked = false;
            this.toolbtntasks.Checked = false;
            this.toolbtnGonote.Checked = false;
            this.toolbtnGojournal.Checked = false;
        }

        private void toolbtnGojournal_Click(object sender, EventArgs e)
        {
            this.SetGroupBarSelectedItem("Journal");
            this.toolbtnmail.Checked = false;
            this.toolbtncalndr.Checked = false;
            this.toolbtncnt.Checked = false;
            this.toolbtntasks.Checked = false;
            this.toolbtnGonote.Checked = false;
            this.toolbtnfolderlist.Checked = false;
        }

        private void toolbtnhelp_Click(object sender, EventArgs e)
        {

        }

        private void toolbtnabout_Click(object sender, EventArgs e)
        {
            DemoCommon.AboutForm abtForm = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
            abtForm.ShowDialog();
        }

        private void toolbtnmailMessage_Click(object sender, EventArgs e)
        {
            NewMailForm mailForm = new NewMailForm(this, themeStyle);
            mailForm.Show();
        }

        private void toolbtnappointment_Click(object sender, EventArgs e)
        {
            CalendarForm appointmentForm = new CalendarForm();
            appointmentForm.Show();
        }

        private void toolbtncontact_Click(object sender, EventArgs e)
        {
            NewContactDialog contactDialog = new NewContactDialog();
            contactDialog.ShowDialog(); 
        }

        
        private void backStageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backStageButton3_Click(object sender, EventArgs e)
        {
            this.ribbonControlAdv1.RibbonStyle = RibbonStyle.Office2007;
            this.ribbonControlAdv1.MenuButtonImage = Image.FromFile(@"..\..\res\outlook2007_small.jpg");
            this.ribbonControlAdv1.BackStageView.BackStage.Hide();
        }

        private void backStageButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolbtnExpAllGroup_Click(object sender, EventArgs e)
        {
            this.gridGroupingPanel.ExpandAllGroupsBarItem.PerformClick();
        }

        private void toolbtnCollapse_Click_1(object sender, EventArgs e)
        {
            this.gridGroupingPanel.collapseAllGroupsBarItem.PerformClick();
        }

        private void toolbtnExpthisGroup_Click(object sender, EventArgs e)
        {
            this.gridGroupingPanel.ExpandthisGroup();
        }


        

    }
    #endregion

    #region GroupBarItem class
    // Serves as a temporary store for the GroupBarItem state - Used by the Options Form 'Restore' functionality
    public class GroupBarItemState
    {
        private String strItemText;
        private bool bInNavPane = false;
        private bool bVisible = true;

        public String ItemText { get { return this.strItemText; } }
        public bool InNavPane { get { return this.bInNavPane; } }
        public bool Visible { get { return this.bVisible; } }

        public GroupBarItemState(String text, bool navpane, bool visible)
        {
            this.strItemText = text;
            this.bInNavPane = navpane;
            this.bVisible = visible;
        }
    }
    #endregion

}