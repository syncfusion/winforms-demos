#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
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
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Grid;
using System.Collections;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.ListView.Events;
using System.Runtime.InteropServices;
using Syncfusion.Drawing;

namespace OutlookDemo_2010
{
    public partial class OutlookForm : RibbonForm
    {
        [DllImport("user32.dll")]
        static extern bool LockWindowUpdate(IntPtr hWndLock);
        int readerSplitterDistance = 0;
        Label lbl;
        Label draftLbl;
        DataSet ds;
        DataTable dt;
        private SuperAccelerator SuperAccelerator1;
        int firstrowHeight = 0;
        int secondrowHeight = 0;
        int thirdrowHeight = 0;
        public OutlookForm()
        {
            InitializeComponent();
            ConfigureGroupbar();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.backStage1.BackStagePanelWidth = (int)DpiAware.LogicalToDeviceUnits(this.backStage1.BackStagePanelWidth);
            }
        }

        private void GroupBar1_Layout(object sender, LayoutEventArgs e)
        {
            if (!groupBar1.Collapsed)
            {
                if (this.Favorites.InNavigationPane)
                {
                    if (this.groupBar1.SelectedItem == 0)
                    {
                        this.Favorites.Image = global::OutlookDemo_2010.Properties.Resources.people_selected;
                    }
                    else
                    {
                        this.Favorites.Image = global::OutlookDemo_2010.Properties.Resources.favorites;
                    }
                }
                else
                {
                    this.Favorites.Image = null;
                }

                if (this.Mail.InNavigationPane)
                {
                    if (this.groupBar1.SelectedItem == 1)
                    {
                        this.Mail.Image = global::OutlookDemo_2010.Properties.Resources.Mail_selected;
                    }
                    else
                    {
                        this.Mail.Image = global::OutlookDemo_2010.Properties.Resources.Mail;
                    }
                }
                else
                {
                    this.Mail.Image = null;
                }

                if (this.Calendar.InNavigationPane)
                {
                    if (this.groupBar1.SelectedItem == 2)
                    {
                        this.Calendar.Image = global::OutlookDemo_2010.Properties.Resources.Calendar_selected;
                    }
                    else
                    {
                        this.Calendar.Image = global::OutlookDemo_2010.Properties.Resources.Calendar;
                    }
                }
                else
                {
                    this.Calendar.Image = null;
                }

                if (this.Notes.InNavigationPane)
                {
                    if (this.groupBar1.SelectedItem == 3)
                    {
                        this.Notes.Image = global::OutlookDemo_2010.Properties.Resources.Notes_selected;
                    }
                    else
                    {
                        this.Notes.Image = global::OutlookDemo_2010.Properties.Resources.Tasks;
                    }
                }
                else
                {
                    this.Notes.Image = null;
                }
            }

        }

        private void GroupBar1_BeforePopup(object sender, GroupBar.BeforePopupEventArgs args)
        {
            args.PopupBounds = new Rectangle(args.PopupBounds.Location, new Size(args.PopupBounds.Width, this.groupBar1.DisplayRectangle.Height));

            this.groupBar1.PopupClientSize = new Size(300, this.groupBar1.DisplayRectangle.Height);
        }

        private void GroupBar1_GroupBarItemSelectionChanging(object sender, GroupBarItemSelectionChangingEventArgs args)
        {
            if (!this.groupBar1.Collapsed)
            {
                if (args.NewSelected == 0)
                {
                    this.groupBar1.CollapsedText = "Favorites";
                    this.Favorites.Image = global::OutlookDemo_2010.Properties.Resources.people_selected;
                    this.Mail.Image = global::OutlookDemo_2010.Properties.Resources.Mail;
                    this.Calendar.Image = global::OutlookDemo_2010.Properties.Resources.Calendar;
                    this.Notes.Image = global::OutlookDemo_2010.Properties.Resources.Tasks;
                }
                else if (args.NewSelected == 1)
                {
                    this.groupBar1.CollapsedText = "Mail";
                    this.Favorites.Image = global::OutlookDemo_2010.Properties.Resources.favorites;
                    this.Mail.Image = global::OutlookDemo_2010.Properties.Resources.Mail_selected;
                    this.Calendar.Image = global::OutlookDemo_2010.Properties.Resources.Calendar;
                    this.Notes.Image = global::OutlookDemo_2010.Properties.Resources.Tasks;
                }
                else if (args.NewSelected == 2)
                {
                    this.groupBar1.CollapsedText = "Calendar";
                    this.Favorites.Image = global::OutlookDemo_2010.Properties.Resources.favorites;
                    this.Mail.Image = global::OutlookDemo_2010.Properties.Resources.Mail;
                    this.Calendar.Image = global::OutlookDemo_2010.Properties.Resources.Calendar_selected;
                    this.Notes.Image = global::OutlookDemo_2010.Properties.Resources.Tasks;
                }
                else if (args.NewSelected == 3)
                {
                    this.groupBar1.CollapsedText = "Notes";
                    this.Favorites.Image = global::OutlookDemo_2010.Properties.Resources.favorites;
                    this.Mail.Image = global::OutlookDemo_2010.Properties.Resources.Mail;
                    this.Calendar.Image = global::OutlookDemo_2010.Properties.Resources.Calendar;
                    this.Notes.Image = global::OutlookDemo_2010.Properties.Resources.Notes_selected;
                }
            }
            else
            {
                if (args.NewSelected == 0)
                {
                    this.groupBar1.CollapsedText = "Favorites";
                    this.Favorites.Image = global::OutlookDemo_2010.Properties.Resources.people_collapsed_selected;
                    this.Mail.Image = global::OutlookDemo_2010.Properties.Resources.mail_collapsed;
                    this.Calendar.Image = global::OutlookDemo_2010.Properties.Resources.calender_collapsed;
                    this.Notes.Image = global::OutlookDemo_2010.Properties.Resources.notes_collapsed;
                }
                else if (args.NewSelected == 1)
                {
                    this.groupBar1.CollapsedText = "Mail";
                    this.Favorites.Image = global::OutlookDemo_2010.Properties.Resources.people_collapsed;
                    this.Mail.Image = global::OutlookDemo_2010.Properties.Resources.mail_collapsed_selected;
                    this.Calendar.Image = global::OutlookDemo_2010.Properties.Resources.calender_collapsed;
                    this.Notes.Image = global::OutlookDemo_2010.Properties.Resources.notes_collapsed;
                }
                else if (args.NewSelected == 2)
                {
                    this.groupBar1.CollapsedText = "Calendar";
                    this.Favorites.Image = global::OutlookDemo_2010.Properties.Resources.people_collapsed;
                    this.Mail.Image = global::OutlookDemo_2010.Properties.Resources.mail_collapsed;
                    this.Calendar.Image = global::OutlookDemo_2010.Properties.Resources.calender_collapsed_selected;
                    this.Notes.Image = global::OutlookDemo_2010.Properties.Resources.notes_collapsed;
                }
                else if (args.NewSelected == 3)
                {
                    this.groupBar1.CollapsedText = "Notes";
                    this.Favorites.Image = global::OutlookDemo_2010.Properties.Resources.people_collapsed;
                    this.Mail.Image = global::OutlookDemo_2010.Properties.Resources.mail_collapsed;
                    this.Calendar.Image = global::OutlookDemo_2010.Properties.Resources.calender_collapsed;
                    this.Notes.Image = global::OutlookDemo_2010.Properties.Resources.notes_collapsed_selected;
                }
            }
        }

        private void SplitContainerAdv1_SplitterMoving(object sender, Syncfusion.Windows.Forms.Tools.Events.SplitterMoveEventArgs e)
        {
            if (e.NewSplitPosition.X < 70)
            {
                this.groupBar1.Collapsed = true;
            }
        }

        private void ConfigureGroupbar()
        {

            LockWindowUpdate(this.Handle);
            this.calendar1.ViewMode = Syncfusion.WinForms.Input.Enums.CalendarViewType.Month;
            this.calendar2.ViewMode = Syncfusion.WinForms.Input.Enums.CalendarViewType.Month;
            this.calendar3.ViewMode = Syncfusion.WinForms.Input.Enums.CalendarViewType.Month;

            lbl = new Label();
            lbl.Text = "3";
            lbl.ForeColor = Color.DeepSkyBlue;
            draftLbl = new Label();
            draftLbl.Text = "15";
            draftLbl.ForeColor = Color.DeepSkyBlue;
            lbl.AutoSize = true;
            draftLbl.AutoSize = true;
            this.ribbonControlAdv1.MenuButtonVisible = true;
            this.ribbonControlAdv1.SelectedTab = this.toolStripTabItem1;
            this.SuperAccelerator();
            Office2016ColorTable officeColorTable = new Office2016ColorTable();
            officeColorTable.BackStageCaptionColor = Color.White;
            this.ribbonControlAdv1.Office2016ColorTable.Add(officeColorTable);
            this.ribbonControlAdv1.AutoLayoutToolStrip = true;
            this.groupBar1.CollapsedText = "Mail";
            this.groupBar1.StateChanging += GroupBar1_StateChanging;
            this.groupBar1.GroupBarItemSelectionChanging += GroupBar1_GroupBarItemSelectionChanging;
            this.groupBar1.HeaderFont = new Font("Segoe UI", 9, FontStyle.Regular);
            this.treeViewAdv4.BackgroundColor = new Syncfusion.Drawing.BrushInfo(GradientStyle.Vertical, new Color[] { ColorTranslator.FromHtml("#F3F3F3"), ColorTranslator.FromHtml("#FFFFFF") });
            this.treeViewAdv5.BackgroundColor = new Syncfusion.Drawing.BrushInfo(GradientStyle.Vertical, new Color[] { ColorTranslator.FromHtml("#F3F3F3"), ColorTranslator.FromHtml("#FFFFFF") });
            this.treeViewAdv2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(GradientStyle.Vertical, new Color[] { ColorTranslator.FromHtml("#F3F3F3"), ColorTranslator.FromHtml("#FFFFFF") });
            this.treeViewAdv1.BorderStyle = BorderStyle.None;
            this.treeViewAdv1.FullRowSelect = true;
            this.treeViewAdv2.BorderStyle = BorderStyle.None;
            this.treeViewAdv2.FullRowSelect = true;
            this.treeViewAdv3.BorderStyle = BorderStyle.None;
            this.treeViewAdv3.FullRowSelect = true;
            this.treeViewAdv4.BorderStyle = BorderStyle.None;
            this.treeViewAdv4.FullRowSelect = true;
            this.treeViewAdv5.BorderStyle = BorderStyle.None;
            this.treeViewAdv5.FullRowSelect = true;
            this.treeViewAdv6.BorderStyle = BorderStyle.None;
            this.treeViewAdv6.FullRowSelect = true;
            lbl.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            draftLbl.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            this.groupBar1.NavigationPaneDropDownClick += GroupBar1_NavigationPaneDropDownClick;
            this.groupBar1.TextAlign = TextAlignment.Left;
            this.groupBar1.GroupBarItems[0].BackColor = Color.White;
            this.groupBar1.GroupBarItems[1].BackColor = Color.White;
            this.groupBar1.GroupBarItems[2].BackColor = Color.White;
            this.groupBar1.GroupBarItems[3].BackColor = Color.White;
            ds = new DataSet();
            ReadXml(ds, "data.xml");
            #region SfListView Setting
            this.sfListView.DataSource = ds.Tables[0];
            this.sfListView.DisplayMember = "Today";
            this.sfListView.VerticalScrollBarVisible = true;
            this.sfListView.SizeChanged += new EventHandler(sfListView_SizeChanged);
            this.sfListView.SelectionMode = SelectionMode.One;
            this.setMessageTextBoxText();
            this.sfListView.SelectionChanged += sfListView_SelectionChanged;
            this.sfListView.DrawItem += sfListView_DrawItem;
            this.sfListView.QueryItemHeight += sfListView_QueryItemHeight;
            this.sfListView.MouseUp += sfListView_MouseUp;
            this.sfListView.HotTracking = true;
            this.sfListView.View.LiveDataUpdateMode = Syncfusion.DataSource.LiveDataUpdateMode.AllowDataShaping;
            sfListView.View.GroupDescriptors.Add(new Syncfusion.DataSource.GroupDescriptor()
            {
                PropertyName = "Today",
            });
            sfListView.Refresh();
            #endregion

            using (Graphics g = this.CreateGraphics())
            {
                if (g.DpiX >= 120)
                {
                    this.ribbonControlAdv1.Size = new System.Drawing.Size(351, 163);
                    this.ribbonControlAdv1.MinimumSize = new Size(0, 200);
                    firstrowHeight = 35;
                    secondrowHeight = 28;
                    thirdrowHeight = 20;
                    this.sfListView.ItemHeight = 100;
                }
                else
                {
                    this.ribbonControlAdv1.Size = new System.Drawing.Size(351, 153);
                    firstrowHeight = 25;
                    secondrowHeight = 20;
                    thirdrowHeight = 15;
                    sfListView.ItemHeight = 70;
                }
            }
            this.InnerSplitterContainer.Panel1MinSize = 350;
            this.splitContainerAdv1.SplitterMoving += SplitContainerAdv1_SplitterMoving;
            this.InnerSplitterContainer.SplitterMoved += new Syncfusion.Windows.Forms.Tools.Events.SplitterMoveEventHandler(InnerSplitterContainer_SplitterMoved);
            this.statusStripEx1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));

            this.splashControl1.SplashControlPanel.BorderType = SplashBorderType.None;
            this.splashControl1.ShowDialogSplash(this);
            this.splashControl1.AutoMode = false;
            this.splashControl1.HostForm = this;

            dt = ds.Tables[0];

            foreach (Control ctrl in this.outlookSearchBox1.Controls)
            {
                if (ctrl is Label)
                {
                    if ((ctrl as Label).Text.ToLower() == "unread")
                    {
                        (ctrl as Label).ForeColor = Color.FromArgb(68, 68, 68);
                    }
                    else if ((ctrl as Label).Text.ToLower() == "all")
                    {
                        (ctrl as Label).ForeColor = Color.FromArgb(58, 187, 246);
                        outlookSearchBox1.Label1Clicked = true;
                    }
                    ((Label)ctrl).Click += new EventHandler(OutlookForm_Click);
                }
            }
            unreadMessage.Add(1);
            unreadMessage.Add(2);
            unreadMessage.Add(3);
            lbl.BackColor = Color.Transparent;
            draftLbl.BackColor = Color.Transparent;
            this.toolStripTextBox1.BorderStyle = BorderStyle.FixedSingle;
            this.toolStripTextBox1.MouseDown += new MouseEventHandler(toolStripTextBox1_MouseDown);
            this.toolStripTextBox1.LostFocus += new EventHandler(toolStripTextBox1_LostFocus);
            this.toolStripTextBox1.Text = "Search";
            this.toolStripTextBox1.ForeColor = Color.Gray;
            this.ribbonControlAdv1.QuickPanelVisible = true;
            this.ribbonControlAdv1.TouchMode = false;

            this.ribbonControlAdv1.ShowRibbonDisplayOptionButton = false;
            this.ribbonControlAdv1.AutoLayoutToolStrip = true;
            using (Graphics g = this.CreateGraphics())
            {
                if (g.DpiX >= 120)
                {
                    //this.treeViewAdv2.Size = new Size(210, 232);
                    this.Size = new Size(700, 500);
                }
            }
            this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.None;
            this.Load += new EventHandler(OutlookForm_Load);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.splitContainerAdv1.IsSplitterFixed = false;
            this.Shown += new EventHandler(OutlookForm_Shown);
            screenBounds = Screen.PrimaryScreen.Bounds;
            this.MessageRichTextBox.MouseEnter += new EventHandler(MessageRichTextBox_MouseEnter);

            foreach (ToolStripTabItem items in this.ribbonControlAdv1.Header.MainItems)
            {
                foreach (ToolStripEx item in items.Panel.Controls)
                {
                    item.LauncherClick += Item_LauncherClick;
                }
            }

            this.treeViewAdv1.VScroll = false;
            this.treeViewAdv1.HScroll = false;
            this.treeViewAdv2.VScroll = false;
            this.treeViewAdv2.HScroll = false;
            this.treeViewAdv3.VScroll = false;
            this.treeViewAdv3.HScroll = false;
            this.treeViewAdv4.VScroll = false;
            this.treeViewAdv4.HScroll = false;
            this.treeViewAdv5.VScroll = false;
            this.treeViewAdv5.HScroll = false;
            this.treeViewAdv6.VScroll = false;
            this.treeViewAdv6.HScroll = false;
            this.calendar1.ShowNavigationButton = false;
            this.calendar2.ShowNavigationButton = false;
            this.calendar3.ShowNavigationButton = false;
            this.calendar1.Style.Header.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.calendar1.Style.Cell.CellFont = new System.Drawing.Font("Segoe UI", 8F);
            this.calendar1.Style.Cell.TodayFont = new System.Drawing.Font("Segoe UI", 8F);
            this.calendar2.Style.Cell.TodayFont = new System.Drawing.Font("Segoe UI", 8F);
            this.calendar3.Style.Cell.TodayFont = new System.Drawing.Font("Segoe UI", 8F);
            this.calendar2.Style.Header.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.calendar2.Style.Cell.CellFont = new System.Drawing.Font("Segoe UI", 8F);
            this.calendar3.Style.Header.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.calendar3.Style.Cell.CellFont = new System.Drawing.Font("Segoe UI", 8F);
            this.groupBar1.SelectedItem = 1;
            this.calendar1.MinimumSize = new Size(200, 200);
            this.calendar2.MinimumSize = new Size(200, 200);
            this.calendar3.MinimumSize = new Size(200, 200);
            this.groupBar1.BeforePopup += GroupBar1_BeforePopup;
            this.groupBar1.Layout += GroupBar1_Layout;
            LockWindowUpdate(IntPtr.Zero);
        }
        private void GroupBar1_NavigationPaneDropDownClick(object sender, NavigationPaneDropDownClickEventArgs args)
        {
            args.ContextMenuProvider.RemoveContextMenuItem("Show &More Buttons");
            args.ContextMenuProvider.RemoveContextMenuItem("Show &Fewer Buttons");
            args.ContextMenuProvider.AddContextMenuItem("Navigation Options...", NavigationOptions);
        }

        private void NavigationOptions(object sender, EventArgs args)
        {
        }

        private void GroupBar1_StateChanging(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (groupBar1.Collapsed == true)
            {
                this.splitContainerAdv1.SplitterDistance = (int)DpiAware.LogicalToDeviceUnits(250);
                this.groupBar1.NavigationPaneButtonWidth = (int)DpiAware.LogicalToDeviceUnits(50);
                this.groupBar1.NavigationPaneHeight = (int)DpiAware.LogicalToDeviceUnits(40);
                this.Mail.InNavigationPane = true;
                this.Favorites.InNavigationPane = true;
                this.Calendar.InNavigationPane = true;
                this.Notes.InNavigationPane = true;
                this.Tasks.InNavigationPane = true;
                this.Folders.InNavigationPane = true;
                this.splitContainerAdv1.IsSplitterFixed = false;
                if (groupBar1.SelectedItem == 0)
                {
                    this.groupBar1.CollapsedText = "Favorites";
                    this.Favorites.Image = global::OutlookDemo_2010.Properties.Resources.people_selected;
                    this.Mail.Image = global::OutlookDemo_2010.Properties.Resources.Mail;
                    this.Calendar.Image = global::OutlookDemo_2010.Properties.Resources.Calendar;
                    this.Notes.Image = global::OutlookDemo_2010.Properties.Resources.Tasks;
                }
                else if (groupBar1.SelectedItem == 1)
                {
                    this.groupBar1.CollapsedText = "Mail";
                    this.Favorites.Image = global::OutlookDemo_2010.Properties.Resources.favorites;
                    this.Mail.Image = global::OutlookDemo_2010.Properties.Resources.Mail_selected;
                    this.Calendar.Image = global::OutlookDemo_2010.Properties.Resources.Calendar;
                    this.Notes.Image = global::OutlookDemo_2010.Properties.Resources.Tasks;
                }
                else if (groupBar1.SelectedItem == 2)
                {
                    this.groupBar1.CollapsedText = "Calendar";
                    this.Favorites.Image = global::OutlookDemo_2010.Properties.Resources.favorites;
                    this.Mail.Image = global::OutlookDemo_2010.Properties.Resources.Mail;
                    this.Calendar.Image = global::OutlookDemo_2010.Properties.Resources.Calendar_selected;
                    this.Notes.Image = global::OutlookDemo_2010.Properties.Resources.Tasks;
                }
                else if (groupBar1.SelectedItem == 3)
                {
                    this.groupBar1.CollapsedText = "Notes";
                    this.Favorites.Image = global::OutlookDemo_2010.Properties.Resources.favorites;
                    this.Mail.Image = global::OutlookDemo_2010.Properties.Resources.Mail;
                    this.Calendar.Image = global::OutlookDemo_2010.Properties.Resources.Calendar;
                    this.Notes.Image = global::OutlookDemo_2010.Properties.Resources.Notes_selected;
                }
            }
            else
            {
                this.groupBar1.NavigationPaneButtonWidth = (int)DpiAware.LogicalToDeviceUnits(40);
                this.groupBar1.NavigationPaneHeight = (int)DpiAware.LogicalToDeviceUnits(40);
                this.groupBar1.GroupBarItemHeight = (int)DpiAware.LogicalToDeviceUnits(50);
                this.splitContainerAdv1.SplitterDistance = groupBar1.CollapsedWidth;
                this.Mail.InNavigationPane = false;
                this.Favorites.InNavigationPane = false;
                this.Calendar.InNavigationPane = false;
                this.Notes.InNavigationPane = false;
                this.Tasks.InNavigationPane = false;
                this.Folders.InNavigationPane = false;
                this.splitContainerAdv1.IsSplitterFixed = true;
                if (groupBar1.SelectedItem == 0)
                {
                    this.groupBar1.CollapsedText = "Favorites";
                    this.Favorites.Image = global::OutlookDemo_2010.Properties.Resources.people_collapsed_selected;
                    this.Mail.Image = global::OutlookDemo_2010.Properties.Resources.mail_collapsed;
                    this.Calendar.Image = global::OutlookDemo_2010.Properties.Resources.calender_collapsed;
                    this.Notes.Image = global::OutlookDemo_2010.Properties.Resources.notes_collapsed;
                }
                else if (groupBar1.SelectedItem == 1)
                {
                    this.groupBar1.CollapsedText = "Mail";
                    this.Favorites.Image = global::OutlookDemo_2010.Properties.Resources.people_collapsed;
                    this.Mail.Image = global::OutlookDemo_2010.Properties.Resources.mail_collapsed_selected;
                    this.Calendar.Image = global::OutlookDemo_2010.Properties.Resources.calender_collapsed;
                    this.Notes.Image = global::OutlookDemo_2010.Properties.Resources.notes_collapsed;
                }
                else if (groupBar1.SelectedItem == 2)
                {
                    this.groupBar1.CollapsedText = "Calendar";
                    this.Favorites.Image = global::OutlookDemo_2010.Properties.Resources.people_collapsed;
                    this.Mail.Image = global::OutlookDemo_2010.Properties.Resources.mail_collapsed;
                    this.Calendar.Image = global::OutlookDemo_2010.Properties.Resources.calender_collapsed_selected;
                    this.Notes.Image = global::OutlookDemo_2010.Properties.Resources.notes_collapsed;
                }
                else if (groupBar1.SelectedItem == 3)
                {
                    this.groupBar1.CollapsedText = "Notes";
                    this.Favorites.Image = global::OutlookDemo_2010.Properties.Resources.people_collapsed;
                    this.Mail.Image = global::OutlookDemo_2010.Properties.Resources.mail_collapsed;
                    this.Calendar.Image = global::OutlookDemo_2010.Properties.Resources.calender_collapsed;
                    this.Notes.Image = global::OutlookDemo_2010.Properties.Resources.notes_collapsed_selected;
                }
            }
        }

        #region SfListView Events
        private void sfListView_SelectionChanged(object sender, ItemSelectionChangedEventArgs e)
        {
            int row = 0;
            row = sfListView.SelectedIndex;
            this.MessageRichTextBox.Clear();
            if (unreadMessage.Contains(row))
            {
                unreadMessage.Remove(rowIndex);
                unreadMessage.Remove(row);
                this.lbl.Text = unreadMessage.Count.ToString();
                if (lbl.Text == "0")
                    lbl.Text = " ";
            }
            if (this.sfListView.RowCount > row ) 
            { 
                if (e.AddedItems != null && e.AddedItems.Count > 0 && e.AddedItems[0] is DataRowView)
                {
                    var record = (e.AddedItems[0] as DataRowView).Row.ItemArray;
                    this.DateTimeLabel.Text = DateTime.Now.ToString();
                    this.Tolabel.Text = record[6].ToString();
                    this.Maillabel.Text = record[2].ToString();
                    string rtf2 =
                        @"{\rtf1\ansi" +
                        // font table
                        @"{\fonttbl" +
                        @"\f0\fswiss Segoe UI;}" +
                        @"\highlight\ql\f0\f0\fs20   " + "\\plain\\par" +
                        @"\highlight1\ql\cf0\f0\fs20 {    Hi }" + record[6] + "," + "\\plain\\par" + Environment.NewLine +
                        @"\highlight1\ql\f0\f2\fs20 " + "\\plain\\par" +
                        // third line
                        @"\highlight1\ql\cf0\f0\fs20     " + record[5] + "." + "\\plain\\par" +
                        @"\highlight\ql\f0\f0\fs20   " + "\\plain\\par" +
                        @"\highlight1\ql\cf0\f0\fs20     " + "Thanks" + "," + "\\plain\\par" +
                        @"\highlight1\ql\cf0\f0\fs20     " + record[2] + "." + "\\plain\\par" +
                        // closing bracket
                        @"}";

                    // Use display to show the content..
                    this.MessageRichTextBox.Rtf = rtf2;
                }
            }
        }
        

        private void sfListView_QueryItemHeight(object sender, QueryItemHeightEventArgs e)
        {
            if (isUnreadClicked)
            {
                if (!unreadMessage.Contains(e.ItemIndex))
                {
                    e.ItemHeight = 0;
                    e.Handled = true;
                }
            }
        }

        object mouseHoverItemData = null;
        private void sfListView_DrawItem(object sender, Syncfusion.WinForms.ListView.Events.DrawItemEventArgs e)
        {
            int rowCount = dt.Rows.Count+sfListView.View.Groups.Count;
            
            StringFormat format = new StringFormat();
            format.Trimming = StringTrimming.EllipsisCharacter;
            if (isUnreadClicked)
            {
                rowCount = unreadMessage.Count;
            }

            if(e.ItemType==Syncfusion.WinForms.ListView.Enums.ItemType.Record)
            {
                var record = (e.ItemData as DataRowView).Row;
                if (e.ItemIndex < rowCount)
                {
                    Graphics g = e.Graphics;
                    Rectangle clRect = e.Bounds;
                    rowIndex = e.ItemIndex;
                    Point mousePosition = sfListView.PointToClient(Cursor.Position);
                    bool isHover = false;
                    if(e.Bounds.Contains(mousePosition))
                    {                        
                        isHover = true;
                        mouseHoverItemData = e.ItemData;
                    }
                    
                        if (rowIndex == this.sfListView.SelectedIndex)
                        {
                            Rectangle paintRect = new Rectangle(e.Bounds.X, e.Bounds.Y + 1, e.Bounds.Width, e.Bounds.Height - 2);
                            g.FillRectangle(new SolidBrush(ColorTranslator.FromHtml("#c7e0f4")), paintRect);
                        }
                        else if (isHover)
                        {
                            Rectangle paintRect = new Rectangle(e.Bounds.X, e.Bounds.Y + 1, e.Bounds.Width, e.Bounds.Height - 2);
                            g.FillRectangle(new SolidBrush(ColorTranslator.FromHtml("#deecf9")), paintRect);
                        }

                    if (isHover)
                    {
                        closeImageRect = new Rectangle(clRect.X + clRect.Width - 25, clRect.Y + 20, 20, 20);
                        flagImageRect = new Rectangle(clRect.X + clRect.Width - 60, clRect.Y + 5, 20, 20);
                        g.DrawImage(global::OutlookDemo_2010.Properties.Resources.flag, flagImageRect);
                        g.DrawImage(global::OutlookDemo_2010.Properties.Resources.delete, closeImageRect);
                    }
                    
                    Rectangle firstDrawString = new Rectangle(clRect.X + 2, clRect.Y + 1, clRect.Width - 110, firstrowHeight);
                    Rectangle secondDrawString = new Rectangle(clRect.X + 2, clRect.Y + firstrowHeight, clRect.Width - 110, secondrowHeight);
                    Rectangle thirdDrawString = new Rectangle(clRect.X + 2, clRect.Y +firstrowHeight+secondrowHeight , clRect.Width - 110, thirdrowHeight);
                    Rectangle fourthDrawString = new Rectangle(clRect.Width - 100, clRect.Y + firstrowHeight, 100, secondrowHeight);
                    Font firstFont;
                    Font secondFont;
                    Font thirdFont;
                    Font fourthFont;
                    using (Graphics g1 = Graphics.FromImage(new Bitmap(10, 10)))
                    {
                        firstFont = new Font("Segoe UI", 11.5f);
                        secondFont = new Font("Segoe UI", 9f);
                        thirdFont = new Font("Segoe UI", 7.55f);
                        fourthFont = new Font("Segoe UI", 8f);
                    }
                    SolidBrush firstBrush = new SolidBrush(ColorTranslator.FromHtml("#0E0E0E"));
                    SolidBrush secondBrush = new SolidBrush(ColorTranslator.FromHtml("#0E0E0E"));
                    SolidBrush thirdBrush = new SolidBrush(ColorTranslator.FromHtml("#0E0E0E"));
                    SolidBrush fourthBrush = new SolidBrush(ColorTranslator.FromHtml("#0E0E0E"));

                    string firstString = "Customer Support";
                    string secondString = "Please schedule the meeting on tomorrow";
                    string thirdString = "<http.customersupport.com>";
                    string fourthString = "11.58 AM";

                    if (e.ItemIndex < rowCount &e.ItemType==Syncfusion.WinForms.ListView.Enums.ItemType.Record)
                    { 
                        
                        firstString = record.ItemArray[2].ToString();
                        secondString = record.ItemArray[3].ToString();
                        thirdString = record.ItemArray[5].ToString();
                        if (char.IsNumber(record.ItemArray[12].ToString(), 0))
                        {
                            fourthString = "    " + record.ItemArray[12].ToString();
                        }
                        else
                            fourthString = record.ItemArray[12].ToString();
                    }

                    if (unreadMessage.Contains(rowIndex))
                    {
                        using (Graphics g1 = Graphics.FromImage(new Bitmap(10, 10)))
                        {
                            firstFont = new Font("Segoe UI", 11.55f);
                            secondFont = new Font("Segoe UI", 9f, FontStyle.Bold);
                            fourthFont = new Font("Segoe UI", 8f, FontStyle.Bold);
                        }
                        firstBrush = new SolidBrush(Color.Black);
                        secondBrush = new SolidBrush(ColorTranslator.FromHtml("#006FC4"));
                        g.FillRectangle(secondBrush, clRect.X, clRect.Y + 1, 3, clRect.Height - 2);
                    }
                    g.DrawString(firstString, firstFont, firstBrush, firstDrawString, format);
                    g.DrawString(secondString, secondFont, secondBrush, secondDrawString, format);
                    g.DrawString(thirdString, thirdFont, thirdBrush, thirdDrawString, format);
                    g.DrawString(fourthString, fourthFont, secondBrush, fourthDrawString, format);
               
                    e.Handled = true;
                }
            }
        }


        private void sfListView_MouseUp(object sender, MouseEventArgs e)
        {
            if (closeImageRect.Contains(e.Location) && mouseHoverItemData != null)
            {
                if (this.sfListView.SelectedItems.Contains(mouseHoverItemData))
                    this.sfListView.SelectedItems.Remove(mouseHoverItemData);
                this.sfListView.View.Groups.RemoveItemInGroup(mouseHoverItemData);
                mouseHoverItemData = null;
                this.MessageRichTextBox.Clear();
            }
        }


        #endregion

        /// <summary>
        /// This event raises when the launcher is clicked
        /// </summary>
        /// <param name="sender">Instance of the Object</param>
        /// <param name="e">Contains data for the source</param>
        private void Item_LauncherClick(object sender, EventArgs e)
        {
          
            MessageBox.Show("Launcher is clicked", "Launcher");
        }

        private void SuperAccelerator()
        {
            //SuperAccelerator
            this.SuperAccelerator1 = new SuperAccelerator(this);
            this.SuperAccelerator1.Appearance = Syncfusion.Windows.Forms.Tools.Appearance.Advanced;
            this.SuperAccelerator1.BackColor = Color.Black;
            this.SuperAccelerator1.ForeColor = Color.White;
            this.ribbonControlAdv1.SuperAccelerator = this.SuperAccelerator1;
            this.SuperAccelerator1.SetAccelerator(toolStripTabItem1, "F");
            this.SuperAccelerator1.SetMenuButtonAccelerator(this.ribbonControlAdv1, "F");
            this.SuperAccelerator1.SetAccelerator(this.toolStripTabItem1, "H");
            this.SuperAccelerator1.SetAccelerator(this.newmail, "N");
            this.SuperAccelerator1.SetAccelerator(this.newmailitems, "I");
            this.SuperAccelerator1.SetAccelerator(this.IgnoreButton, "X");
            this.SuperAccelerator1.SetAccelerator(this.CleanUpSplitButton, "C");
            this.SuperAccelerator1.SetAccelerator(this.JunkSplitButton, "J");
            this.SuperAccelerator1.SetAccelerator(this.toolStripButton2, "D");
            this.SuperAccelerator1.SetAccelerator(this.replybutton, "RP");
            this.SuperAccelerator1.SetAccelerator(this.replyall, "RA");
            this.SuperAccelerator1.SetAccelerator(this.forward, "FW");
            this.SuperAccelerator1.SetAccelerator(this.MeetingButton, "MR");
            this.SuperAccelerator1.SetAccelerator(this.MoreButton, "ME");
            this.SuperAccelerator1.SetAccelerator(this.movetn, "MV");
            this.SuperAccelerator1.SetAccelerator(this.rules, "RR");
            this.SuperAccelerator1.SetAccelerator(this.readunread, "W");
            this.SuperAccelerator1.SetAccelerator(this.categorize, "G");
            this.SuperAccelerator1.SetAccelerator(this.toolStripButton16, "V");
            this.SuperAccelerator1.SetAccelerator(this.toolStripTextBox1, "FC");
            this.SuperAccelerator1.SetAccelerator(this.AddressBookButton, "AB");
            this.SuperAccelerator1.SetAccelerator(this.FilterEmailButton, "L");
            this.SuperAccelerator1.SetAccelerator(this.toolStripTabItem2, "S");
            this.SuperAccelerator1.SetAccelerator(this.toolStripButton3, "S");
            this.SuperAccelerator1.SetAccelerator(this.UpdateFolderButton, "D");
            this.SuperAccelerator1.SetAccelerator(this.SendAllButton, "A");
            this.SuperAccelerator1.SetAccelerator(this.SendReceiveGroupsSplit, "G");
            this.SuperAccelerator1.SetAccelerator(this.toolStripButton5, "P");
            this.SuperAccelerator1.SetAccelerator(this.toolStripButton4, "C");
            this.SuperAccelerator1.SetAccelerator(this.followupsptbtn, "U");
            this.SuperAccelerator1.SetAccelerator(this.toolStripTabItem2, "S");
            this.SuperAccelerator1.SetAccelerator(this.toolStripTabItem3, "O");
            this.SuperAccelerator1.SetAccelerator(this.toolStripButton25, "N");
            this.SuperAccelerator1.SetAccelerator(this.toolStripButton9, "SF");
            this.SuperAccelerator1.SetAccelerator(this.toolStripTabItem5, "RN");
            this.SuperAccelerator1.SetAccelerator(this.toolStripButton10, "CF");
            this.SuperAccelerator1.SetAccelerator(this.toolStripButton11, "MV");
            this.SuperAccelerator1.SetAccelerator(this.toolStripButton13, "DF");
            this.SuperAccelerator1.SetAccelerator(this.toolStripButton28, "MA");
            this.SuperAccelerator1.SetAccelerator(this.toolStripButton27, "RR");
            this.SuperAccelerator1.SetAccelerator(this.toolStripButton26, "H");
            this.SuperAccelerator1.SetAccelerator(this.toolStripButton14, "CU");
            this.SuperAccelerator1.SetAccelerator(this.toolStripButton15, "DA");
            this.SuperAccelerator1.SetAccelerator(this.toolStripSplitButton7, "RD");
            this.SuperAccelerator1.SetAccelerator(this.toolStripButton12, "FA");
            this.SuperAccelerator1.SetAccelerator(this.toolStripButton16, "V");
            this.SuperAccelerator1.SetAccelerator(this.toolStripButton19, "A");
            this.SuperAccelerator1.SetAccelerator(this.toolStripButton18, "PP");
            this.SuperAccelerator1.SetAccelerator(this.toolStripButton17, "FP");
            this.SuperAccelerator1.SetAccelerator(this.toolStripTabItem9, "V");
            this.SuperAccelerator1.SetAccelerator(this.toolStripSplitButton12, "CV");
            this.SuperAccelerator1.SetAccelerator(this.toolStripButton21, "V");
            this.SuperAccelerator1.SetAccelerator(this.toolStripButton20, "X");
            this.SuperAccelerator1.SetAccelerator(this.toolStripButton23, "CA");
            this.SuperAccelerator1.SetAccelerator(this.toolStripCheckBox1, "GC");
            this.SuperAccelerator1.SetAccelerator(this.toolStripSplitButton8, "CS");
            this.SuperAccelerator1.SetAccelerator(this.toolStripSplitButton11, "F");
            this.SuperAccelerator1.SetAccelerator(this.toolStripSplitButton10, "PN");
            this.SuperAccelerator1.SetAccelerator(this.toolStripSplitButton9, "B");
            this.SuperAccelerator1.SetAccelerator(this.toolStripSplitButton13, "PP");
            this.SuperAccelerator1.SetAccelerator(this.toolStripButton22, "M");
            this.SuperAccelerator1.SetAccelerator(this.toolStripButton24, "ON");
            this.SuperAccelerator1.SetAccelerator(this.backStageTab2, "O");
            this.SuperAccelerator1.SetAccelerator(this.backStageTab1, "I");
            this.SuperAccelerator1.SetAccelerator(this.backStageTab3, "A");
            this.SuperAccelerator1.SetAccelerator(this.backStageTab4, "M");
            this.SuperAccelerator1.SetAccelerator(this.backStageTab5, "P");
            this.SuperAccelerator1.SetAccelerator(this.backStageTab6, "D");
            this.SuperAccelerator1.SetAccelerator(this.backStageTab7, "X");
            this.SuperAccelerator1.SetAccelerator(this.backStageButton1, "X");

            ToolStripButton btn = new ToolStripButton(OutlookDemo_2010.Properties.Resources.New_Mail);
            this.SuperAccelerator1.SetAccelerator(btn, "1");
            QuickButtonReflectable quickMail = new QuickButtonReflectable(btn);
            this.ribbonControlAdv1.Header.AddQuickItem(quickMail);
            ToolStripButton btn1 = new ToolStripButton(OutlookDemo_2010.Properties.Resources.PasteQAT);
            this.SuperAccelerator1.SetAccelerator(btn1, "2");
            QuickButtonReflectable quickPaste = new QuickButtonReflectable(btn1);
            this.ribbonControlAdv1.Header.AddQuickItem(quickPaste);
        }
       
        void MessageRichTextBox_MouseEnter(object sender, EventArgs e)
        {
            this.sfListView.Refresh();
        }
        Rectangle screenBounds = new Rectangle();
        void OutlookForm_Shown(object sender, EventArgs e)
        {
            this.sfListView.Refresh();
        }

        void sfListView_SizeChanged(object sender, EventArgs e)
        {
            this.sfListView.Refresh();
        }
        void OutlookForm_Load(object sender, EventArgs e)
        {
            this.splitContainerAdv1.SplitterDistance = 150;
            this.InnerSplitterContainer.SplitterDistance = 70;
            this.WindowState = FormWindowState.Maximized;
        }
       
        /// <summary>
        /// When DPI is greater than 100 then the DefaultRowHeight will be set based on the font size.
        /// </summary>
        /// <returns>The Height Value</returns>
      
        void toolStripTextBox1_LostFocus(object sender, EventArgs e)
        {
            this.toolStripTextBox1.Text = "Search";
        }

        void toolStripTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.toolStripTextBox1.Text = "";
        }
        bool isUnreadClicked = false;
        void OutlookForm_Click(object sender, EventArgs e)
        {
            if (((Label)sender).Text == "Unread")
            {
                isUnreadClicked = true;
                this.sfListView.Refresh();
            }
            if (((Label)sender).Text == "All")
            {
                isUnreadClicked = false;
                this.sfListView.Refresh();
            }
        }

        List<int> category = new List<int>();

       
        public List<int> unreadMessage = new List<int>();
        int rowIndex = 0;
      
        Rectangle closeImageRect = new Rectangle();
        Rectangle flagImageRect = new Rectangle();
      
        void InnerSplitterContainer_SplitterMoved(object sender, Syncfusion.Windows.Forms.Tools.Events.SplitterMoveEventArgs e)
        {
            readerSplitterDistance = this.InnerSplitterContainer.SplitterIncrement;
        }

        void splitContainerAdv1_SplitterMoved(object sender, Syncfusion.Windows.Forms.Tools.Events.SplitterMoveEventArgs e)
        {
           
        }
        
      
        private void setMessageTextBoxText()
        {
            this.DateTimeLabel.Text = DateTime.Now.ToString();
            this.Tolabel.Text = "Katrina";
            this.Maillabel.Text = "John Peter";
            string rtf2 =
                @"{\rtf1\ansi" +
                // font table
                @"{\fonttbl" +
                @"\f0\fswiss Segoe UI;}" +
                @"\highlight\ql\f0\f0\fs20   " + "\\plain\\par" +
                @"\highlight1\ql\cf0\f0\fs20 {    Hi }" + "Katrina" + "," + "\\plain\\par" + Environment.NewLine +
                @"\highlight1\ql\f0\f2\fs20 " + "\\plain\\par" +
                // third line
                @"\highlight1\ql\cf0\f0\fs20     " + "Your appointment has been scheduled at 9.00 A.M. today." + "." + "\\plain\\par" +
                @"\highlight\ql\f0\f0\fs20   " + "\\plain\\par" +
                @"\highlight1\ql\cf0\f0\fs20     " + "Thanks" + "," + "\\plain\\par" +
                @"\highlight1\ql\cf0\f0\fs20     " + "John" + "." + "\\plain\\par" +
                // closing bracket
                @"}";

            // Use display to show the content..
            this.MessageRichTextBox.Rtf = rtf2;
        }


        void treeViewAdv1_MouseLeave(object sender, EventArgs e)
        {
            ////if ((sender as TreeViewAdv) == this.treeViewAdv2)
            ////{
            ////    this.treeViewAdv2.Nodes[0].Background = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(0, 255, 255, 255));
            ////    foreach (TreeNodeAdv item in this.treeViewAdv2.Nodes[0].Nodes)
            ////    {
            ////        item.Background = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(0, 255, 255, 255));
            ////    }
            ////}
        }

        void ReadXml(DataSet ds, string xmlFileName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(xmlFileName))
                {
                    ds.ReadXml(xmlFileName);
                    break;
                }
                xmlFileName = @"..\" + xmlFileName;
            }
        }

        void treeViewAdv1_MouseMove(object sender, MouseEventArgs e)
        {
            //if ((sender as TreeViewAdv) == this.treeViewAdv2)
            //{
            //    this.treeViewAdv2.Nodes[0].Background = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(0, 255, 255, 255));
            //    foreach (TreeNodeAdv item in this.treeViewAdv2.Nodes[0].Nodes)
            //    {
            //        item.Background = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(0, 255, 255, 255));
            //    }
            //    if (this.treeViewAdv2.GetNodeAtPoint(new Point(e.X, e.Y)) != null)
            //    {
            //        TreeNodeAdv node = this.treeViewAdv2.GetNodeAtPoint(new Point(e.X, e.Y));
            //        node.Background = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(205, 230, 247));
            //    }
            //}
        }

        void treeViewAdv1_MouseUp(object sender, MouseEventArgs e)
        {
            //if ((sender as TreeViewAdv) == this.treeViewAdv2)
            //{
            //    if (this.treeViewAdv2.Nodes[0] != this.treeViewAdv2.SelectedNode)
            //        this.treeViewAdv2.Nodes[0].Font = new Font(this.treeViewAdv2.Nodes[0].Font.FontFamily, this.treeViewAdv2.Nodes[0].Font.Size, FontStyle.Regular);
            //    foreach (TreeNodeAdv item in this.treeViewAdv2.Nodes[0].Nodes)
            //    {
            //        if (item != this.treeViewAdv2.SelectedNode)
            //        {
            //            item.Font = new Font(item.Font.FontFamily, item.Font.Size, FontStyle.Regular);
            //        }
            //    }
            //}
        }
        bool emptyData = false;
        bool sentItems = false;
        private void treeViewAdv1_NodeMouseClick(object sender, TreeViewAdvMouseClickEventArgs e)
        {
            sentItems = false;
            if (e.Node.Text == "Sent Items")
            {
                emptyData = false;
                sentItems = true;
            }
            if (e.Node.Text == "Deleted Items" || e.Node.Text == "Junk E-Mail" || e.Node.Text == "Outbox" ||
                e.Node.Text == "Drafts")
            {
                emptyData = true;
            }
            else if (e.Node.Text == "Inbox")
            {
                emptyData = false;
            }
            this.sfListView.Refresh();
            e.Node.Font = new Font(e.Node.Font.FontFamily, e.Node.Font.Size, FontStyle.Bold);
        }

        

    

        private void backStageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.splitContainerAdv2.SplitterDistance = (int)DpiAware.LogicalToDeviceUnits((float)(this.panel2.Size.Height / 2.4));
            this.splitContainerAdv3.SplitterDistance = (int)DpiAware.LogicalToDeviceUnits((float)(this.panel2.Size.Height / 2.5));
            this.splitContainerAdv4.SplitterDistance = (int)DpiAware.LogicalToDeviceUnits(53);
            this.splitContainerAdv4.CollapsedPanel = Syncfusion.Windows.Forms.Tools.Enums.CollapsedPanel.Panel1;
        }

        private void unreadlabel_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Label).ForeColor = Color.FromArgb(58, 187, 246);
        }

        private void unreadlabel_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.FromArgb(58, 187, 246);
        }

        private void unreadlabel_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.Black;
        }

        private void Alllabel_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Alllabel_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.FromArgb(58, 187, 246);
        }

        
        private void pointerControl2_Click(object sender, EventArgs e)
        {
            this.splitContainerAdv1.Panel1Collapsed = false;
            //this.HiddenPanel.Visible = false;            
            //this.splitContainerAdv1.SplitterDistance = 226;
        }

        private void pointerControl1_Click_2(object sender, EventArgs e)
        {          
            //this.HiddenPanel.Visible = true;        
            //this.splitContainerAdv1.SplitterDistance = this.HiddenPanel.Width;      
        }

        private void HiddenPanel_MouseDown(object sender, MouseEventArgs e)
        {           
            //this.HiddenPanel.Visible = false;       
            //this.splitContainerAdv1.SplitterDistance = 226;
        }

        private void groupBar1_GroupBarItemSelected(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
