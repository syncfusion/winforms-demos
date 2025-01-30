#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using NavigationDrawTile;
using System.Runtime.InteropServices;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.ListView.Events;

namespace NavigationDrawer_2010
{
    public partial class MainForm : SfForm
    {

        #region Variable 

        [DllImport("user32.dll")]
        static extern bool LockWindowUpdate(IntPtr hWndLock);

        /// <summary>
        /// Inbox Panel
        /// </summary>
        Panel inboxPanel = new Panel();
        /// <summary>
        /// Profile Panel
        /// </summary>
        Panel profilePanel = new Panel();
       
        private Syncfusion.WinForms.ListView.SfListView sfListView;
        DataSet ds;
        DataTable dt;
        int rowIndex = 0;
        Rectangle closeImageRect = new Rectangle();
        Rectangle flagImageRect = new Rectangle();
        int firstrowHeight = 25;
        int secondrowHeight = 20;
        int thirdrowHeight = 15;
        object mouseHoverItemData = null;
        TileControl profile1 = new TileControl();

        #endregion

        #region Constructor

        public MainForm()
        {
            InitializeComponent();
            sfListView = new Syncfusion.WinForms.ListView.SfListView();
            var filter = navigationDrawer1.GetType().GetField("filter", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            dynamic navigationDrawerMouseMessageFilter = filter.GetValue(navigationDrawer1);
            NavigationDrawerMouseMessageFilter MouseMessageFilter = navigationDrawerMouseMessageFilter;
            Application.RemoveMessageFilter(MouseMessageFilter);
            ds = new DataSet();
            ReadXml(ds, "data.xml");
            ds.DataSetName = "DataSet1";
           
            #region SfListView
            this.listView1.VerticalScrollBarVisible = false;
            this.listView1.SelectionMode = SelectionMode.One;
            this.listView1.DrawItem += sfListView_DrawItem;
            this.listView1.MouseUp += sfListView_MouseUp;
            this.listView1.HotTracking = true;
            listView1.DataSource = ds.Tables[0];
            listView1.DisplayMember = "Today";
            listView1.View.GroupDescriptors.Add(new Syncfusion.DataSource.GroupDescriptor()
            {
                PropertyName = "Today",
            });
            dt = ds.Tables[0];
            this.listView1.View.LiveDataUpdateMode = Syncfusion.DataSource.LiveDataUpdateMode.AllowDataShaping;
            this.listView1.Dock = DockStyle.Fill;
            this.listView1.Refresh();
            this.listView1.SelectedIndex = 3;
            #endregion

            #region Customizations

            if (this.navigationDrawer1.Items[0] is DrawerHeader)
            {
                (this.navigationDrawer1.Items[0] as DrawerHeader).HeaderImage = this.imageListAdv1.Images[1];
                (this.navigationDrawer1.Items[0] as DrawerHeader).HeaderText = "Anderson";
            }
            inboxPanel.Controls.Add(listView1);
            inboxPanel.Dock = DockStyle.Fill;
            this.navigationDrawer1.ContentViewContainer.Controls.Add(inboxPanel);
            this.navigationDrawer1.ContentViewContainer.Controls.Add(profilePanel);
            this.profilePanel.Dock = DockStyle.Fill;
            this.profilePanel.BackColor = Color.Red;
            if (this.navigationDrawer1.Items[0] is DrawerHeader)
            {
                (this.navigationDrawer1.Items[0] as DrawerHeader).TextAlign = TextAlignment.Center;
            }
            this.navigationDrawer1.DrawerPanelContainer.BorderStyle = BorderStyle.None;
            this.navigationDrawer1.TouchThreshold = 500;
            #endregion

            #region Events

            this.drawerMenuItem1.Click += new EventHandler(drawerMenuItem1_Click);
            this.drawerMenuItem2.Click += new EventHandler(drawerMenuItem2_Click);
            this.drawerMenuItem3.Click += new EventHandler(drawerMenuItem3_Click);
            this.drawerMenuItem4.Click += new EventHandler(drawerMenuItem4_Click);
            this.drawerMenuItem5.Click += new EventHandler(drawerMenuItem5_Click);
            this.numericUpDown1.ValueChanged += NumericUpDown1_ValueChanged;
            this.numericUpDown2.ValueChanged += NumericUpDown1_ValueChanged;
            #endregion

            PopulateComboBox();
            AddControlsInProfilePanel();
            this.navigationDrawer1.DrawerHeight = this.navigationDrawer1.DisplayRectangle.Height;
            this.SizeChanged += MainForm_SizeChanged;
            this.numericUpDown2.Value = this.navigationDrawer1.DrawerWidth;
            this.numericUpDown1.ThemeStyle.Font = new Font("Microsoft San Serif", 8.25F);
            this.numericUpDown2.ThemeStyle.Font = new Font("Microsoft San Serif", 8.25F);
            SkinManager.SetVisualStyle(this, "Office2019Colorful");
            this.gradientPanel1.ThemeStyle.BackColor = this.gradientPanel2.ThemeStyle.BackColor = Color.White;
            this.gradientPanel1.BorderColor = this.gradientPanel2.BorderColor = Color.FromArgb(210, 210, 210);
            this.gradientPanel1.BorderStyle = BorderStyle.None;
            this.gradientPanel2.BorderStyle = BorderStyle.FixedSingle;
            this.listView1.Style.BorderColor= Color.FromArgb(210, 210, 210);
            this.listView1.BackColor = Color.White;
            this.listView1.Style.BorderSides = Border3DSide.Bottom | Border3DSide.Left | Border3DSide.Right;
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            this.navigationDrawer1.DrawerHeight = this.navigationDrawer1.DisplayRectangle.Height;
        }

        #endregion

        #region Events

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if ((sender as NumericUpDownExt).Name.Equals("numericUpDown1"))
            {
                this.navigationDrawer1.AnimationDuration = (int)this.numericUpDown1.Value;
            }
            else if ((sender as NumericUpDownExt).Name.Equals("numericUpDown2"))
            {
                this.navigationDrawer1.DrawerWidth = (int)this.numericUpDown2.Value;
            }
        }

        #region SfListView Events
        private void sfListView_DrawItem(object sender, Syncfusion.WinForms.ListView.Events.DrawItemEventArgs e)
        {
            int rowCount = dt.Rows.Count + listView1.View.Groups.Count;
            StringFormat format = new StringFormat();
            format.Trimming = StringTrimming.EllipsisCharacter;
            if (e.ItemType == Syncfusion.WinForms.ListView.Enums.ItemType.Record)
            {
                var record = (e.ItemData as DataRowView).Row;
                if (e.ItemIndex < rowCount)
                {
                    Graphics g = e.Graphics;
                    Rectangle clRect = e.Bounds;
                    rowIndex = e.ItemIndex;
                    Point mousePosition = listView1.PointToClient(Cursor.Position);
                    bool isHover = false;
                    if (e.Bounds.Contains(mousePosition))
                    {
                        isHover = true;
                        mouseHoverItemData = e.ItemData;
                    }
                    if (rowIndex == this.listView1.SelectedIndex)
                    {
                        isHover = true;
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
                        g.DrawImage(global::NavigationDrawer_2010.Properties.Resources.flag, flagImageRect);
                        g.DrawImage(global::NavigationDrawer_2010.Properties.Resources.delete, closeImageRect);
                    }

                    Rectangle firstDrawString = new Rectangle(clRect.X + 2, clRect.Y + 1, clRect.Width - 110, firstrowHeight);
                    Rectangle secondDrawString = new Rectangle(clRect.X + 2, clRect.Y + firstrowHeight, clRect.Width - 110, secondrowHeight);
                    Rectangle thirdDrawString = new Rectangle(clRect.X + 2, clRect.Y + firstrowHeight + secondrowHeight, clRect.Width - 110, thirdrowHeight);
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

                    Color brush= this.ForeColor;
                    if (this.comboboxAdv1.SelectedItem.ToString().Equals("HighContrastBlack") || this.comboboxAdv1.SelectedItem.ToString().Equals("Office2016Black") || this.comboboxAdv1.SelectedItem.ToString().Equals("Office2016DarkGray"))
                    {
                        if (isHover)
                        {
                            brush = this.BackColor;
                        }
                        else
                        {
                            brush = this.ForeColor;
                        }
                    }
                    SolidBrush firstBrush = new SolidBrush(brush);
                   
                    string firstString = "Customer Support";
                    string secondString = "Please schedule the meeting on tomorrow";
                    string thirdString = "<http.customersupport.com>";
                    string fourthString = "11.58 AM";

                    firstString = record.ItemArray[2].ToString();
                    secondString = record.ItemArray[3].ToString();
                    thirdString = record.ItemArray[5].ToString();
                    if (char.IsNumber(record.ItemArray[12].ToString(), 0))
                    {
                        fourthString = "    " + record.ItemArray[12].ToString();
                    }
                    else
                        fourthString = record.ItemArray[12].ToString();

                    g.DrawString(firstString, firstFont, firstBrush, firstDrawString, format);
                    g.DrawString(secondString, secondFont, firstBrush, secondDrawString, format);
                    g.DrawString(thirdString, thirdFont, firstBrush, thirdDrawString, format);
                    g.DrawString(fourthString, fourthFont, firstBrush, fourthDrawString, format);

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
                if (this.sfListView.View != null && this.sfListView.View.Groups != null)
                    this.sfListView.View.Groups.RemoveItemInGroup(mouseHoverItemData);
                mouseHoverItemData = null;
            }
        }

        #endregion

        /// <summary>
        /// Profile
        /// </summary>
        void drawerMenuItem5_Click(object sender, EventArgs e)
        {
            LockWindowUpdate(this.navigationDrawer1.ContentViewContainer.Handle);
            this.profilePanel.Visible = true;
            this.inboxPanel.Visible = false;
            this.label7.Text = "Profile";
            this.navigationDrawer1.ToggleDrawer();
            LockWindowUpdate(IntPtr.Zero);
        }

        /// <summary>
        /// Sent
        /// </summary>
        void drawerMenuItem4_Click(object sender, EventArgs e)
        {
            LockWindowUpdate(this.navigationDrawer1.ContentViewContainer.Handle);
            dt = ds.Tables[2];
            this.listView1.DataSource = dt;
            listView1.DisplayMember = "Today";
            if (listView1.View.GroupDescriptors.Count <= 0)
            {
                listView1.View.GroupDescriptors.Add(new Syncfusion.DataSource.GroupDescriptor()
                {
                    PropertyName = "Today",
                });
            }
            this.label7.Text = "Outbox";
            this.profilePanel.Visible = false;
            this.inboxPanel.Visible = true;
            this.navigationDrawer1.ToggleDrawer();
            LockWindowUpdate(IntPtr.Zero);
        }

        /// <summary>
        /// Drafts
        /// </summary>
        void drawerMenuItem3_Click(object sender, EventArgs e)
        {
            LockWindowUpdate(this.navigationDrawer1.ContentViewContainer.Handle);
            dt = ds.Tables[1];
            this.listView1.DataSource = dt;
            listView1.DisplayMember = "Today";
            if (listView1.View.GroupDescriptors.Count <= 0)
            {
                listView1.View.GroupDescriptors.Add(new Syncfusion.DataSource.GroupDescriptor()
                {
                    PropertyName = "Today",
                });
            }
            this.label7.Text = "Sent";
            this.profilePanel.Visible = false;
            this.inboxPanel.Visible = true;
            this.navigationDrawer1.ToggleDrawer();
            LockWindowUpdate(IntPtr.Zero);
        }

        /// <summary>
        /// Outbox
        /// </summary>
        void drawerMenuItem2_Click(object sender, EventArgs e)
        {
            LockWindowUpdate(this.navigationDrawer1.ContentViewContainer.Handle);
            dt = ds.Tables[3];
            this.listView1.DataSource = dt;
            listView1.DisplayMember = "Today";
            if (listView1.View.GroupDescriptors.Count <= 0)
            {
                listView1.View.GroupDescriptors.Add(new Syncfusion.DataSource.GroupDescriptor()
                {
                    PropertyName = "Today",
                });
            }
            this.label7.Text = "Drafts";
            this.profilePanel.Visible = false;
            this.inboxPanel.Visible = true;
            this.navigationDrawer1.ToggleDrawer();
            LockWindowUpdate(IntPtr.Zero);
        }

        /// <summary>
        /// Inbox
        /// </summary>
        void drawerMenuItem1_Click(object sender, EventArgs e)
        {
            LockWindowUpdate(this.navigationDrawer1.ContentViewContainer.Handle);
            dt = ds.Tables[0];
            this.listView1.DataSource = dt;
            listView1.DisplayMember = "Today";
            if (listView1.View.GroupDescriptors.Count <= 0)
            {
                listView1.View.GroupDescriptors.Add(new Syncfusion.DataSource.GroupDescriptor()
                {
                    PropertyName = "Today",
                });
            }
            this.label7.Text = "Inbox";
            this.profilePanel.Visible = false;
            this.inboxPanel.Visible = true;
            this.navigationDrawer1.ToggleDrawer();
            LockWindowUpdate(IntPtr.Zero);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.navigationDrawer1.ToggleDrawer();
        }

        private void comboBoxAdv3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.navigationDrawer1.Transition = (Syncfusion.Windows.Forms.Tools.Transition)Enum.Parse(typeof(Syncfusion.Windows.Forms.Tools.Transition), this.comboBoxAdv3.SelectedItem.ToString());
            if(this.navigationDrawer1.Transition == Syncfusion.Windows.Forms.Tools.Transition.Push|| this.navigationDrawer1.Transition == Syncfusion.Windows.Forms.Tools.Transition.Reveal)
            {
                List<string> positionList = new List<string>() {
            "Left",
            "Right"
            };
                this.comboBoxAdv2.DataSource = positionList;
                this.comboBoxAdv2.SelectedIndex = 0;
            }
            else
            {
                List<string> positionList = new List<string>() {
            "Left",
            "Right",
            "Top",
            "Bottom"};
                this.comboBoxAdv2.DataSource = positionList;
                this.comboBoxAdv2.SelectedIndex = 0;
            }
            this.listView1.Refresh();
        }

        private void comboBoxAdv2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.navigationDrawer1.Position = (SlidePosition)Enum.Parse(typeof(SlidePosition), this.comboBoxAdv2.SelectedItem.ToString());
            if (navigationDrawer1.Position == SlidePosition.Bottom || navigationDrawer1.Position == SlidePosition.Top)
            {
                this.navigationDrawer1.Transition = Syncfusion.Windows.Forms.Tools.Transition.SlideOnTop;
            }
            this.listView1.Refresh();
        }
        /// <summary>
        /// Event for applying style
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboboxAdv1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.comboboxAdv1.SelectedIndex == 0)
            {
                SkinManager.SetVisualStyle(this, "Office2019Colorful");
                (this.navigationDrawer1.Items[1] as DrawerMenuItem).Image = this.imageListAdv1.Images[34];
                (this.navigationDrawer1.Items[2] as DrawerMenuItem).Image = this.imageListAdv1.Images[35];
                (this.navigationDrawer1.Items[3] as DrawerMenuItem).Image = this.imageListAdv1.Images[36];
                (this.navigationDrawer1.Items[4] as DrawerMenuItem).Image = this.imageListAdv1.Images[37];
                (this.navigationDrawer1.Items[5] as DrawerMenuItem).Image = this.imageListAdv1.Images[38];
            }
            else if (this.comboboxAdv1.SelectedIndex == 1)
            {
                var filter = navigationDrawer1.GetType().GetProperty("SelectedIndex", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                int SelectedIndex = (int)filter.GetValue(navigationDrawer1, null);
                SkinManager.SetVisualStyle(this, "HighContrastBlack");
                if (SelectedIndex == 1)
                    drawerMenuItem1.Image = this.imageListAdv1.Images[39];
                else
                    (this.navigationDrawer1.Items[1] as DrawerMenuItem).Image = this.imageListAdv1.Images[34];
                if (SelectedIndex == 2)
                    drawerMenuItem2.Image = this.imageListAdv1.Images[40];
                else
                    (this.navigationDrawer1.Items[2] as DrawerMenuItem).Image = this.imageListAdv1.Images[35];
                if (SelectedIndex == 3)
                    drawerMenuItem3.Image = this.imageListAdv1.Images[41];
                else
                    (this.navigationDrawer1.Items[3] as DrawerMenuItem).Image = this.imageListAdv1.Images[36];
                if (SelectedIndex == 4)
                    drawerMenuItem4.Image = this.imageListAdv1.Images[42];
                else
                    (this.navigationDrawer1.Items[4] as DrawerMenuItem).Image = this.imageListAdv1.Images[37];
                if (SelectedIndex == 5)
                    drawerMenuItem5.Image = this.imageListAdv1.Images[43];
                else
                    (this.navigationDrawer1.Items[5] as DrawerMenuItem).Image = this.imageListAdv1.Images[38];
            }
            else if (this.comboboxAdv1.SelectedIndex == 2)
            {
                SkinManager.SetVisualStyle(this, "Office2016Colorful");
                (this.navigationDrawer1.Items[1] as DrawerMenuItem).Image = this.imageListAdv1.Images[14];
                (this.navigationDrawer1.Items[2] as DrawerMenuItem).Image = this.imageListAdv1.Images[15];
                (this.navigationDrawer1.Items[3] as DrawerMenuItem).Image = this.imageListAdv1.Images[16];
                (this.navigationDrawer1.Items[4] as DrawerMenuItem).Image = this.imageListAdv1.Images[17];
                (this.navigationDrawer1.Items[5] as DrawerMenuItem).Image = this.imageListAdv1.Images[18];
            }
            else if (this.comboboxAdv1.SelectedIndex == 3)
            {
                SkinManager.SetVisualStyle(this, "Office2016White");
                (this.navigationDrawer1.Items[1] as DrawerMenuItem).Image = this.imageListAdv1.Images[19];
                (this.navigationDrawer1.Items[2] as DrawerMenuItem).Image = this.imageListAdv1.Images[20];
                (this.navigationDrawer1.Items[3] as DrawerMenuItem).Image = this.imageListAdv1.Images[21];
                (this.navigationDrawer1.Items[4] as DrawerMenuItem).Image = this.imageListAdv1.Images[22];
                (this.navigationDrawer1.Items[5] as DrawerMenuItem).Image = this.imageListAdv1.Images[23];
            }
            else if (this.comboboxAdv1.SelectedIndex == 4)
            {
                SkinManager.SetVisualStyle(this, "Office2016DarkGray");
                (this.navigationDrawer1.Items[1] as DrawerMenuItem).Image = this.imageListAdv1.Images[24];
                (this.navigationDrawer1.Items[2] as DrawerMenuItem).Image = this.imageListAdv1.Images[25];
                (this.navigationDrawer1.Items[3] as DrawerMenuItem).Image = this.imageListAdv1.Images[26];
                (this.navigationDrawer1.Items[4] as DrawerMenuItem).Image = this.imageListAdv1.Images[27];
                (this.navigationDrawer1.Items[5] as DrawerMenuItem).Image = this.imageListAdv1.Images[28];
            }
            else if (this.comboboxAdv1.SelectedIndex == 5)
            {
                SkinManager.SetVisualStyle(this, "Office2016Black");
                (this.navigationDrawer1.Items[1] as DrawerMenuItem).Image = this.imageListAdv1.Images[29];
                (this.navigationDrawer1.Items[2] as DrawerMenuItem).Image = this.imageListAdv1.Images[30];
                (this.navigationDrawer1.Items[3] as DrawerMenuItem).Image = this.imageListAdv1.Images[31];
                (this.navigationDrawer1.Items[4] as DrawerMenuItem).Image = this.imageListAdv1.Images[32];
                (this.navigationDrawer1.Items[5] as DrawerMenuItem).Image = this.imageListAdv1.Images[33];
            }
            UpdateNavigationStyle(this.comboboxAdv1.SelectedItem.ToString());
        }

        #endregion

        #region Functions

        private void PopulateComboBox()
        {
            List<string> styleList = new List<string>() {
           "Office2019Colorful","HighContrastBlack", "Office2016Colorful",
            "Office2016White",
            "Office2016DarkGray",
            "Office2016Black"};
            this.comboboxAdv1.DataSource = styleList;
            List<string> positionList = new List<string>() {
            "Left",
            "Right",
            "Top",
            "Bottom"};
            this.comboBoxAdv2.DataSource = positionList;
            this.comboBoxAdv3.AllowDropDownResize = this.comboBoxAdv2.AllowDropDownResize = this.comboboxAdv1.AllowDropDownResize = sfComboBox1.AllowDropDownResize = sfComboBox2.AllowDropDownResize = false;
            List<string> textImageList = new List<string>() {
            "ImageAboveText",
            "ImageBeforeText",
            "Overlay",
            "TextAboveImage",
            "TextBeforeImage"
            };

            List<string> transitionList = new List<string>() {
            "SlideOnTop",
            "Push",
            "Reveal"};

            List<string> textAlignList = new List<string>() {
            "Left",
            "Center",
            "Right"};
            this.comboBoxAdv3.DataSource = transitionList;
            this.sfComboBox1.DataSource = textImageList;
            this.sfComboBox2.DataSource = textAlignList;
            this.comboboxAdv1.SelectedIndex = this.comboBoxAdv2.SelectedIndex = this.comboBoxAdv3.SelectedIndex = 0;
            sfComboBox1.SelectedIndex = 1;
            sfComboBox2.SelectedIndex = 0;
            this.comboBoxAdv3.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv3_SelectedIndexChanged);
            this.comboBoxAdv2.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv2_SelectedIndexChanged);
            this.sfComboBox1.SelectedIndexChanged += SfComboBox1_SelectedIndexChanged;
            this.sfComboBox2.SelectedIndexChanged += SfComboBox2_SelectedIndexChanged;
        }

        private void SfComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sfComboBox2.SelectedIndex == 0)
            {
                drawerMenuItem1.TextAlign = TextAlignment.Left;
                drawerMenuItem2.TextAlign = TextAlignment.Left;
                drawerMenuItem3.TextAlign = TextAlignment.Left;
                drawerMenuItem4.TextAlign = TextAlignment.Left;
                drawerMenuItem5.TextAlign = TextAlignment.Left;
            }
            else if (sfComboBox2.SelectedIndex == 1)
            {
                drawerMenuItem1.TextAlign = TextAlignment.Center;
                drawerMenuItem2.TextAlign = TextAlignment.Center;
                drawerMenuItem3.TextAlign = TextAlignment.Center;
                drawerMenuItem4.TextAlign = TextAlignment.Center;
                drawerMenuItem5.TextAlign = TextAlignment.Center;
            }
            else if (sfComboBox2.SelectedIndex == 2)
            {
                drawerMenuItem1.TextAlign = TextAlignment.Right;
                drawerMenuItem2.TextAlign = TextAlignment.Right;
                drawerMenuItem3.TextAlign = TextAlignment.Right;
                drawerMenuItem4.TextAlign = TextAlignment.Right;
                drawerMenuItem5.TextAlign = TextAlignment.Right;
            }
        }

        private void SfComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sfComboBox1.SelectedIndex == 0)
            {
                drawerMenuItem1.TextImageRelation = TextImageRelation.ImageAboveText;
                drawerMenuItem2.TextImageRelation = TextImageRelation.ImageAboveText;
                drawerMenuItem3.TextImageRelation = TextImageRelation.ImageAboveText;
                drawerMenuItem4.TextImageRelation = TextImageRelation.ImageAboveText;
                drawerMenuItem5.TextImageRelation = TextImageRelation.ImageAboveText;
            }
            else if(sfComboBox1.SelectedIndex == 1)
            {
                drawerMenuItem1.TextImageRelation = TextImageRelation.ImageBeforeText;
                drawerMenuItem2.TextImageRelation = TextImageRelation.ImageBeforeText;
                drawerMenuItem3.TextImageRelation = TextImageRelation.ImageBeforeText;
                drawerMenuItem4.TextImageRelation = TextImageRelation.ImageBeforeText;
                drawerMenuItem5.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
            else if (sfComboBox1.SelectedIndex == 2)
            {
                drawerMenuItem1.TextImageRelation = TextImageRelation.Overlay;
                drawerMenuItem2.TextImageRelation = TextImageRelation.Overlay;
                drawerMenuItem3.TextImageRelation = TextImageRelation.Overlay;
                drawerMenuItem4.TextImageRelation = TextImageRelation.Overlay;
                drawerMenuItem5.TextImageRelation = TextImageRelation.Overlay;
            }
            else if (sfComboBox1.SelectedIndex == 3)
            {
                drawerMenuItem1.TextImageRelation = TextImageRelation.TextAboveImage;
                drawerMenuItem2.TextImageRelation = TextImageRelation.TextAboveImage;
                drawerMenuItem3.TextImageRelation = TextImageRelation.TextAboveImage;
                drawerMenuItem4.TextImageRelation = TextImageRelation.TextAboveImage;
                drawerMenuItem5.TextImageRelation = TextImageRelation.TextAboveImage;
            }
            else if (sfComboBox1.SelectedIndex == 4)
            {
                drawerMenuItem1.TextImageRelation = TextImageRelation.TextBeforeImage;
                drawerMenuItem2.TextImageRelation = TextImageRelation.TextBeforeImage;
                drawerMenuItem3.TextImageRelation = TextImageRelation.TextBeforeImage;
                drawerMenuItem4.TextImageRelation = TextImageRelation.TextBeforeImage;
                drawerMenuItem5.TextImageRelation = TextImageRelation.TextBeforeImage;
            }
        }

        /// <summary>
        /// To populate Profile Panel
        /// </summary>
        public void AddControlsInProfilePanel()
        {

            profile1.HeaderText = "Anderson";
            profile1.TileImage = this.imageListAdv1.Images[1];
            profile1.PostionText = "Senior Executive";
            profile1.OrganizatonText = "Custom Service";
            profile1.DOBText = "26/11/1973";
            profile1.LocationText = "NewYork";
            profile1.Height = 300;
            profile1.Dock = DockStyle.Top;
            profilePanel.Controls.Add(profile1);
            profilePanel.AutoScroll = true;
        }
        
        /// <summary>
        /// Reads xml data
        /// </summary>
        /// <param name="ds">DataSet</param>
        /// <param name="xmlFileName">XML file</param>
        void ReadXml(DataSet ds, string xmlFileName)
        {
            for (int n = 0; n < 13; n++)
            {
                if (System.IO.File.Exists(xmlFileName))
                {
                    ds.ReadXml(xmlFileName);
                    break;
                }
                xmlFileName = @"..\" + xmlFileName;
            }
        }
       
        private void UpdateNavigationStyle(string themes)
        {
            LockWindowUpdate(this.Handle);
            if(themes.Equals("Office2019Colorful") || themes.Equals("Office2016Colorful")|| themes.Equals("Office2016White"))
            {
                this.BackColor = this.listView1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.Style.TitleBar.CloseButtonForeColor = this.Style.TitleBar.MinimizeButtonForeColor = this.Style.TitleBar.MaximizeButtonForeColor =
                this.Style.TitleBar.ForeColor = this.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label2.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label3.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label4.ForeColor = this.label5.ForeColor = this.label6.ForeColor = this.label8.ForeColor = this.label7.ForeColor = ColorTranslator.FromHtml("#262626");
                this.inboxPanel.ForeColor = ColorTranslator.FromHtml("#262626");
                this.pictureBox1.Image = global::NavigationDrawer_2010.Properties.Resources.Icon_menu_Colorful;
                this.profilePanel.ForeColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanel1.BackColor = this.panel1.BackColor = ColorTranslator.FromHtml("#ffffff");
                if (themes.Equals("Office2019Colorful"))
                {
                    this.gradientPanel1.ThemeStyle.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.gradientPanel1.BorderStyle = BorderStyle.None;
                    this.gradientPanel2.BorderStyle = BorderStyle.None;
                }
                else
                {
                    this.gradientPanel1.BorderStyle = BorderStyle.FixedSingle;
                    this.gradientPanel2.BorderStyle = BorderStyle.FixedSingle;
                    this.drawerMenuItem1.DefaultColor = this.drawerMenuItem2.DefaultColor = this.drawerMenuItem3.DefaultColor = this.drawerMenuItem4.DefaultColor = this.drawerMenuItem5.DefaultColor = this.navigationDrawer1.DrawerPanelContainer.BackColor;
                }
                this.inboxPanel.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.profilePanel.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.Style.TitleBar.BackColor = Color.FromArgb(240, 240, 240);
                profile1.HeaderColor = ColorTranslator.FromHtml("#0173c7");
                profile1.BackColor = System.Drawing.Color.White;
                profile1.TextColor = System.Drawing.Color.Black;
                profile1.HeaderTextColor = System.Drawing.Color.White;
            }
            else if (themes.Equals("HighContrastBlack") || themes.Equals("Office2016Black"))
            {
                this.BackColor = this.listView1.BackColor = ColorTranslator.FromHtml("#262626");
                this.Style.TitleBar.CloseButtonForeColor = this.Style.TitleBar.MinimizeButtonForeColor = this.Style.TitleBar.MaximizeButtonForeColor =
                this.Style.TitleBar.ForeColor = this.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.listView1.ForeColor = this.label1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label4.ForeColor = this.label5.ForeColor = this.label6.ForeColor = this.label8.ForeColor = this.label7.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.inboxPanel.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.profilePanel.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.gradientPanel1.BackColor = this.panel1.BackColor = ColorTranslator.FromHtml("#262626");
                if(themes.Equals("HighContrastBlack"))
                {
                    this.gradientPanel1.ThemeStyle.BackColor = ColorTranslator.FromHtml("#262626");
                    this.gradientPanel1.BorderStyle = BorderStyle.None;
                    this.gradientPanel2.BorderStyle = BorderStyle.None;
                }
                else
                {
                    this.gradientPanel1.BorderStyle = BorderStyle.FixedSingle;
                    this.gradientPanel2.BorderStyle = BorderStyle.FixedSingle;
                    this.drawerMenuItem1.DefaultColor = this.drawerMenuItem2.DefaultColor= this.drawerMenuItem3.DefaultColor= this.drawerMenuItem4.DefaultColor= this.drawerMenuItem5.DefaultColor = this.navigationDrawer1.DrawerPanelContainer.BackColor;
                }
                this.pictureBox1.Image = global::NavigationDrawer_2010.Properties.Resources.Icon_menu_Black;
                this.inboxPanel.BackColor = ColorTranslator.FromHtml("#262626");
                this.profilePanel.BackColor = ColorTranslator.FromHtml("#262626");
                this.Style.TitleBar.BackColor= profile1.HeaderColor = ColorTranslator.FromHtml("#363636");
                profile1.BackColor = ColorTranslator.FromHtml("#262626");
                profile1.TextColor = ColorTranslator.FromHtml("#f0f0f0");
                profile1.HeaderTextColor = ColorTranslator.FromHtml("#f0f0f0");
            }
            else if (themes.Equals("Office2016DarkGray"))
            {
                this.Style.TitleBar.BackColor= ColorTranslator.FromHtml("#505050");
                this.BackColor = this.listView1.BackColor = ColorTranslator.FromHtml("#666666");
                this.Style.TitleBar.CloseButtonForeColor = this.Style.TitleBar.MinimizeButtonForeColor = this.Style.TitleBar.MaximizeButtonForeColor =
                this.Style.TitleBar.ForeColor = this.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.pictureBox1.Image = global::NavigationDrawer_2010.Properties.Resources.Icon_menu_Darkgray;
                this.drawerMenuItem1.DefaultColor = this.drawerMenuItem2.DefaultColor = this.drawerMenuItem3.DefaultColor = this.drawerMenuItem4.DefaultColor = this.drawerMenuItem5.DefaultColor = this.navigationDrawer1.DrawerPanelContainer.BackColor;
                this.label4.ForeColor = this.label5.ForeColor = this.label6.ForeColor = this.label8.ForeColor =this.label7.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.inboxPanel.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.profilePanel.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.gradientPanel1.BackColor = this.panel1.BackColor = ColorTranslator.FromHtml("#666666");
                this.inboxPanel.BackColor = ColorTranslator.FromHtml("#808080");
                this.profilePanel.BackColor = ColorTranslator.FromHtml("#808080");
                profile1.BackColor= ColorTranslator.FromHtml("#666666");
                profile1.TextColor = ColorTranslator.FromHtml("#f0f0f0");
                profile1.HeaderTextColor = ColorTranslator.FromHtml("#f0f0f0");
                profile1.HeaderColor = ColorTranslator.FromHtml("#505050");
                this.navigationDrawer1.DrawerPanelContainer.BorderStyle = BorderStyle.FixedSingle;
                this.gradientPanel1.BorderStyle = BorderStyle.FixedSingle;
                this.gradientPanel2.BorderStyle = BorderStyle.FixedSingle;
            }
            LockWindowUpdate(IntPtr.Zero);
        }
        #endregion

        private void drawerMenuItem1_MouseDown(object sender, MouseEventArgs e)
        {
            if (navigationDrawer1.ThemeName == "HighContrastBlack")
            {
                (this.navigationDrawer1.Items[1] as DrawerMenuItem).Image = this.imageListAdv1.Images[34];
                (this.navigationDrawer1.Items[2] as DrawerMenuItem).Image = this.imageListAdv1.Images[35];
                (this.navigationDrawer1.Items[3] as DrawerMenuItem).Image = this.imageListAdv1.Images[36];
                (this.navigationDrawer1.Items[4] as DrawerMenuItem).Image = this.imageListAdv1.Images[37];
                (this.navigationDrawer1.Items[5] as DrawerMenuItem).Image = this.imageListAdv1.Images[38];
                if ((sender as DrawerMenuItem) == drawerMenuItem1)
                {
                    drawerMenuItem1.Image = this.imageListAdv1.Images[39];
                }
                else if ((sender as DrawerMenuItem) == drawerMenuItem2)
                {
                        drawerMenuItem2.Image = this.imageListAdv1.Images[40];
                }
                else if ((sender as DrawerMenuItem) == drawerMenuItem3)
                {
                        drawerMenuItem3.Image = this.imageListAdv1.Images[41];
                }
                else if ((sender as DrawerMenuItem) == drawerMenuItem4)
                {
                        drawerMenuItem4.Image = this.imageListAdv1.Images[42];
                }
                else if ((sender as DrawerMenuItem) == drawerMenuItem5)
                {
                    drawerMenuItem5.Image = this.imageListAdv1.Images[43];
                }
            }

        }


        private void drawerMenuItem1_MouseLeave(object sender, EventArgs e)
        {
            if (navigationDrawer1.ThemeName == "HighContrastBlack")
            {
                var filter = navigationDrawer1.GetType().GetProperty("SelectedIndex", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                int SelectedIndex = (int)filter.GetValue(navigationDrawer1, null);
                if ((sender as DrawerMenuItem) == drawerMenuItem1)
                {
                    if (SelectedIndex == 1)
                        drawerMenuItem1.Image = this.imageListAdv1.Images[39];
                    else
                        drawerMenuItem1.Image = this.imageListAdv1.Images[34];
                }
                else if ((sender as DrawerMenuItem) == drawerMenuItem2)
                {
                    if (SelectedIndex == 2)
                        drawerMenuItem2.Image = this.imageListAdv1.Images[40];
                    else
                        drawerMenuItem2.Image = this.imageListAdv1.Images[35];
                }
                else if ((sender as DrawerMenuItem) == drawerMenuItem3)
                {
                    if (SelectedIndex == 3)
                        drawerMenuItem3.Image = this.imageListAdv1.Images[41];
                    else
                        drawerMenuItem3.Image = this.imageListAdv1.Images[36];
                }
                else if ((sender as DrawerMenuItem) == drawerMenuItem4)
                {
                    if (SelectedIndex == 4)
                        drawerMenuItem4.Image = this.imageListAdv1.Images[42];
                    else
                        drawerMenuItem4.Image = this.imageListAdv1.Images[37];
                }
                else if ((sender as DrawerMenuItem) == drawerMenuItem5)
                {
                    if (SelectedIndex == 5)
                        drawerMenuItem5.Image = this.imageListAdv1.Images[43];
                    else
                        drawerMenuItem5.Image = this.imageListAdv1.Images[38];
                }
            }
        }

        private void drawerMenuItem1_MouseEnter(object sender, EventArgs e)
        {
            if (navigationDrawer1.ThemeName == "HighContrastBlack")
            {
                var filter = navigationDrawer1.GetType().GetProperty("SelectedIndex", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                int SelectedIndex = (int)filter.GetValue(navigationDrawer1, null);
                if ((sender as DrawerMenuItem) == drawerMenuItem1)
                {
                    if(SelectedIndex == 1)
                        drawerMenuItem1.Image = this.imageListAdv1.Images[39];
                    else
                    drawerMenuItem1.Image = this.imageListAdv1.Images[19];
                }
                else if ((sender as DrawerMenuItem) == drawerMenuItem2)
                {
                    if (SelectedIndex == 2)
                        drawerMenuItem2.Image = this.imageListAdv1.Images[40];
                    else
                        drawerMenuItem2.Image = this.imageListAdv1.Images[20];
                }
                else if ((sender as DrawerMenuItem) == drawerMenuItem3)
                {
                    if (SelectedIndex == 3)
                        drawerMenuItem3.Image = this.imageListAdv1.Images[41];
                    else
                        drawerMenuItem3.Image = this.imageListAdv1.Images[21];
                }
                else if ((sender as DrawerMenuItem) == drawerMenuItem4)
                {
                    if (SelectedIndex == 4)
                        drawerMenuItem4.Image = this.imageListAdv1.Images[42];
                    else
                        drawerMenuItem4.Image = this.imageListAdv1.Images[22];
                }
                else if ((sender as DrawerMenuItem) == drawerMenuItem5)
                {
                    if (SelectedIndex == 5)
                        drawerMenuItem5.Image = this.imageListAdv1.Images[43];
                    else
                        drawerMenuItem5.Image = this.imageListAdv1.Images[23];
                }
            }
        }

    }
}
