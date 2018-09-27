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

namespace NavigationDrawer_2010
{

   

    public partial class MainForm : MetroForm
    {

        #region Variable 

        [DllImport("user32.dll")]
        static extern bool LockWindowUpdate(IntPtr hWndLock);

        /// <summary>
        /// TextBox 
        /// </summary>
        RichTextBox richTextBox = new RichTextBox();
        /// <summary>
        /// Caption Image
        /// </summary>
        Syncfusion.Windows.Forms.CaptionImage captionSettingImage1 = new Syncfusion.Windows.Forms.CaptionImage();
        /// <summary>
        /// People Panel
        /// </summary>
        FlowLayoutPanel peoplepanel = new FlowLayoutPanel();
        /// <summary>
        /// Home Panel
        /// </summary>
        Panel homePanel = new Panel();
        /// <summary>
        /// About Panel
        /// </summary>
        Panel aboutPanel = new Panel();
        /// <summary>
        /// Profile Panel
        /// </summary>
        FlowLayoutPanel profilePanel = new FlowLayoutPanel();
        /// <summary>
        /// Photo Panel
        /// </summary>
        FlowLayoutPanel photoPanel = new FlowLayoutPanel();
        /// <summary>
        /// BigTile
        /// </summary>
        BigTile bigtile = new BigTile();

        #endregion

        #region Constructor

        public MainForm()
        {
            InitializeComponent();

            #region MetroForm Customization

            this.ShowMaximizeBox = false;
            this.Load += new EventHandler(MainForm_Load);
            captionSettingImage1.Image = global::NavigationDrawer_2010.Properties.Resources.icon_settings;
            captionSettingImage1.Name = "CaptionImage2";
            captionSettingImage1.Size = new System.Drawing.Size(25, 25);
            this.CaptionBarHeight = 55;
            this.CaptionLabels[0].Location = new Point(this.CaptionLabels[0].Location.X, this.CaptionLabels[0].Location.Y + 3);
            this.CaptionImages[0].Location = new Point(this.CaptionImages[0].Location.X, this.CaptionImages[0].Location.Y + 3);

            #endregion
           
            #region Customizations

            if (this.navigationDrawer1.Items[0] is DrawerHeader)
            {
                (this.navigationDrawer1.Items[0] as DrawerHeader).HeaderImage = this.imageListAdv1.Images[0];
                (this.navigationDrawer1.Items[0] as DrawerHeader).HeaderText = "Anderson";
            }

            richTextBox.Text = "Lorem ipsum dolor sit amet, lacus amet amet ultricies. Quisque mi venenatis morbi libero, orci dis, mi ut et class porta, massa ligula magna enim, aliquam orci vestibulum tempus. Turpis facilisis vitae consequat, cum a a, turpis dui consequat massa in dolor per, felis non amet. Auctor eleifend in omnis elit vestibulum, donec non elementum tellus est mauris, id aliquam, at lacus, arcu pretium proin lacus dolor et. Eu tortor, vel ultrices amet dignissim mauris vehicula. Lorem tortor neque, purus taciti quis id. Elementum integer orci accumsan minim phasellus vel."
               + Environment.NewLine + Environment.NewLine + "      Vestibulum duis integer diam mi libero felis, sollicitudin id dictum etiam blandit lacus, ac condimentum magna dictumst interdum et, nam commodo mi habitasse enim fringilla nunc, amet aliquam sapien per tortor luctus. Conubia voluptates at nunc, congue lectus, malesuada nulla. Rutrum quo morbi, feugiat sed mi turpis, ac cursus integer ornare dolor. Purus dui in et tincidunt, sed eros pede adipiscing tellus, est suscipit nulla, arcu nec fringilla vel aliquam, mollis lorem rerum hac vestibulum ante nullam. Volutpat a lectus, lorem pulvinar quis. Lobortis vehicula in imperdiet orci urna." + "\n" + "\n" +
               "Lorem ipsum dolor sit amet, lacus amet amet ultricies. Quisque mi venenatis morbi libero, orci dis, mi ut et class porta, massa ligula magna enim, aliquam orci vestibulum tempus. Turpis facilisis vitae consequat, cum a a, turpis dui consequat massa in dolor per, felis non amet. Auctor eleifend in omnis elit vestibulum, donec non elementum tellus est mauris, id aliquam, at lacus, arcu pretium proin lacus dolor et. Eu tortor, vel ultrices amet dignissim mauris vehicula. Lorem tortor neque, purus taciti quis id. Elementum integer orci accumsan minim phasellus vel."
               + Environment.NewLine + Environment.NewLine + "      Vestibulum duis integer diam mi libero felis, sollicitudin id dictum etiam blandit lacus, ac condimentum magna dictumst interdum et, nam commodo mi habitasse enim fringilla nunc, amet aliquam sapien per tortor luctus. Conubia voluptates at nunc, congue lectus, malesuada nulla. Rutrum quo morbi, feugiat sed mi turpis, ac cursus integer ornare dolor. Purus dui in et tincidunt, sed eros pede adipiscing tellus, est suscipit nulla, arcu nec fringilla vel aliquam, mollis lorem rerum hac vestibulum ante nullam. Volutpat a lectus, lorem pulvinar quis. Lobortis vehicula in imperdiet orci urna.";

            this.navigationDrawer1.ContentViewContainer.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            richTextBox.Dock = DockStyle.Fill;
            richTextBox.BackColor = Color.White;
            richTextBox.BorderStyle = BorderStyle.None;
            richTextBox.ReadOnly = true;
            richTextBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#353535");
            richTextBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular);
            homePanel.Controls.Add(richTextBox);
            homePanel.Dock = DockStyle.Fill;
            peoplepanel.Dock = DockStyle.Fill;
            this.navigationDrawer1.ContentViewContainer.Controls.Add(homePanel);
            this.navigationDrawer1.ContentViewContainer.Controls.Add(aboutPanel);
            this.navigationDrawer1.ContentViewContainer.Controls.Add(peoplepanel);
            this.navigationDrawer1.ContentViewContainer.Controls.Add(profilePanel);
            this.profilePanel.Dock = DockStyle.Fill;
            this.navigationDrawer1.ContentViewContainer.Controls.Add(photoPanel);
            this.SettingsPanel.Visible = false;
            this.SettingsPanel.BorderStyle = BorderStyle.FixedSingle;
            this.SettingsPanel.Padding = new Padding(0, 0, 0, 0);
            if (this.navigationDrawer1.Items[0] is DrawerHeader)
            {
                (this.navigationDrawer1.Items[0] as DrawerHeader).TextAlign = TextAlignment.Center;
            }
            this.CaptionButtonColor = Color.White;

            #endregion

            #region Events

            this.drawerMenuItem1.Click += new EventHandler(drawerMenuItem1_Click);
            this.drawerMenuItem2.Click += new EventHandler(drawerMenuItem2_Click);
            this.drawerMenuItem3.Click += new EventHandler(drawerMenuItem3_Click);
            this.drawerMenuItem4.Click += new EventHandler(drawerMenuItem4_Click);
            this.drawerMenuItem5.Click += new EventHandler(drawerMenuItem5_Click);
            this.SizeChanged += new EventHandler(MainForm_SizeChanged);
            this.CaptionImages[0].ImageMouseDown += new CaptionImage.MouseDown(NavigationDrawerShowOnClick);
          //  this.richTextBox.MouseDown += new MouseEventHandler(richTextBox_MouseDown);

            #endregion

            #region Modules

            AddControlsInPeoplePanel();
            AddControlsInProfilePanel();
            AddControlsInPhotoPanel();

            #endregion

            #region Settings Panel 

            this.leftposition.Checked = true;
            this.SlideOnTop.Checked = true;
            this.SettingsPanel.Padding = new System.Windows.Forms.Padding(10);

            #endregion

            #region Border Customization
            richTextBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#060606"); 
            //To Bold the First Line of the RichTextBox
            string firstline = this.richTextBox.Lines[0];
            int srt = richTextBox.Find(firstline);
            richTextBox.Select(richTextBox.Text.Length, 0);

            this.navigationDrawer1.DrawerPanelContainer.BorderStyle = BorderStyle.None;
      //  this.navigationDrawer1.DrawerPanelContainer.Paint += new PaintEventHandler(DrawerPanelContainer_Paint);

            this.navigationDrawer1.DrawerPanelContainer.Padding = new Padding(0,0,3,0);
            this.Resize += new EventHandler(MainForm_Resize);
            this.navigationDrawer1.TouchThreshold = 500;

            #endregion

            richTextBox.Text = "Lorem ipsum dolor sit amet, lacus amet amet ultricies. Quisque mi venenatis morbi libero, orci dis, mi ut et class porta, massa ligula magna enim, aliquam orci vestibulum tempus. Turpis facilisis vitae consequat, cum a a, turpis dui consequat massa in dolor per, felis non amet. Auctor eleifend in omnis elit vestibulum, donec non elementum tellus est mauris, id aliquam, at lacus, arcu pretium proin lacus dolor et. Eu tortor, vel ultrices amet dignissim mauris vehicula. Lorem tortor neque, purus taciti quis id. Elementum integer orci accumsan minim phasellus vel."
                + Environment.NewLine + Environment.NewLine + "      Vestibulum duis integer diam mi libero felis, sollicitudin id dictum etiam blandit lacus, ac condimentum magna dictumst interdum et, nam commodo mi habitasse enim fringilla nunc, amet aliquam sapien per tortor luctus. Conubia voluptates at nunc, congue lectus, malesuada nulla. Rutrum quo morbi, feugiat sed mi turpis, ac cursus integer ornare dolor. Purus dui in et tincidunt, sed eros pede adipiscing tellus, est suscipit nulla, arcu nec fringilla vel aliquam, mollis lorem rerum hac vestibulum ante nullam. Volutpat a lectus, lorem pulvinar quis. Lobortis vehicula in imperdiet orci urna." + "\n" + "\n" +
                "Lorem ipsum dolor sit amet, lacus amet amet ultricies. Quisque mi venenatis morbi libero, orci dis, mi ut et class porta, massa ligula magna enim, aliquam orci vestibulum tempus. Turpis facilisis vitae consequat, cum a a, turpis dui consequat massa in dolor per, felis non amet. Auctor eleifend in omnis elit vestibulum, donec non elementum tellus est mauris, id aliquam, at lacus, arcu pretium proin lacus dolor et. Eu tortor, vel ultrices amet dignissim mauris vehicula. Lorem tortor neque, purus taciti quis id. Elementum integer orci accumsan minim phasellus vel."
                + Environment.NewLine + Environment.NewLine + "      Vestibulum duis integer diam mi libero felis, sollicitudin id dictum etiam blandit lacus, ac condimentum magna dictumst interdum et, nam commodo mi habitasse enim fringilla nunc, amet aliquam sapien per tortor luctus. Conubia voluptates at nunc, congue lectus, malesuada nulla. Rutrum quo morbi, feugiat sed mi turpis, ac cursus integer ornare dolor. Purus dui in et tincidunt, sed eros pede adipiscing tellus, est suscipit nulla, arcu nec fringilla vel aliquam, mollis lorem rerum hac vestibulum ante nullam. Volutpat a lectus, lorem pulvinar quis. Lobortis vehicula in imperdiet orci urna.";

            UpdateNavigationDrawerStyleForOffice2016();
        }
       
        #endregion

        #region Events

        /// <summary>
        /// RichTextBox MouseDown
        /// </summary>
        void richTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            //if (this.navigationDrawer1.IsDrawerShowing())
            //    this.navigationDrawer1.ToggleDrawer();
            this.SettingsPanel.Visible = false;
        }

        /// <summary>
        /// Setting Panel Paint
        /// </summary>
        void SettingsPanel_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(BackColor))
                e.Graphics.FillRectangle(brush, this.SettingsPanel.ClientRectangle);

            Pen pen = new Pen(System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(165)))), ((int)(((byte)(221))))));
            e.Graphics.DrawRectangle(pen, 0, 0, this.SettingsPanel.ClientSize.Width - 3, this.SettingsPanel.ClientSize.Height - 1);

        }

        /// <summary>
        /// MainForm Resize
        /// </summary>
        void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.CaptionImages.Count > 1)
                this.CaptionImages[1].Location = new Point(this.Width - 80, this.CaptionImages[1].Location.Y);
            this.SettingsPanel.Visible = false;
        }

        /// <summary>
        /// Paint Event
        /// </summary>
        void DrawerPanelContainer_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(BackColor))
                e.Graphics.FillRectangle(brush, this.navigationDrawer1.DrawerPanelContainer.ClientRectangle);

            Pen pen = new Pen(System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(165)))), ((int)(((byte)(221))))));
            e.Graphics.DrawRectangle(pen, 0, 0, this.navigationDrawer1.DrawerPanelContainer.ClientSize.Width - 3, this.navigationDrawer1.DrawerPanelContainer.ClientSize.Height - 1);
        }


        /// <summary>
        /// About us
        /// </summary>
        void drawerMenuItem5_Click(object sender, EventArgs e)
        {
            LockWindowUpdate(this.navigationDrawer1.ContentViewContainer.Handle);

            this.CaptionLabels[0].Text = "About us";
            this.SettingsPanel.Visible = false;
            this.photoPanel.Visible = false;
            this.aboutPanel.Visible = false;
            this.profilePanel.Visible = false;
            this.peoplepanel.Visible = false;
           // richTextBox.Select(richTextBox.Text.Length, 0);
            this.richTextBox.Text = "Lorem ipsum dolor sit amet, lacus amet amet ultricies. Quisque mi venenatis morbi libero, orci dis, mi ut et class porta, massa ligula magna enim, aliquam orci vestibulum tempus. Turpis facilisis vitae consequat, cum a a, turpis dui consequat massa in dolor per, felis non amet. Auctor eleifend in omnis elit vestibulum, donec non elementum tellus est mauris, id aliquam, at lacus, arcu pretium proin lacus dolor et. Eu tortor, vel ultrices amet dignissim mauris vehicula. Lorem tortor neque, purus taciti quis id. Elementum integer orci accumsan minim phasellus vel.";
            //this.richTextBox.Text = "Syncfusion is the enterprise technology partner of choice for software development, delivering a broad range of web, mobile, and desktop controls coupled with a service-oriented approach throughout the entire application lifecycle. Syncfusion has established itself as the trusted partner worldwide for use in mission-critical applications. Founded in 2001 and headquartered in Research Triangle Park, N.C., Syncfusion has more than 12,000 customers, including large financial institutions, Fortune 100 companies, and global IT consultancies.";
          //  string firstline = this.richTextBox.Lines[0];
            //int srt = richTextBox.Find(firstline);
           // richTextBox.SelectionFont = new Font(richTextBox.Font, FontStyle.Regular);
            richTextBox.Select(richTextBox.Text.Length, 0);

            this.navigationDrawer1.ToggleDrawer();
            this.homePanel.Visible = true;
            LockWindowUpdate(IntPtr.Zero);
        }

        /// <summary>
        /// Photos
        /// </summary>
        void drawerMenuItem4_Click(object sender, EventArgs e)
        {
            LockWindowUpdate(this.navigationDrawer1.ContentViewContainer.Handle);

            this.CaptionLabels[0].Text = "Photos";
            this.SettingsPanel.Visible = false;
            this.homePanel.Visible = false;
            this.profilePanel.Visible = false;
            this.aboutPanel.Visible = false;

            this.photoPanel.Visible = false;
            this.peoplepanel.Visible = true;
            this.navigationDrawer1.ToggleDrawer();

            LockWindowUpdate(IntPtr.Zero);
        }

        /// <summary>
        /// Profile
        /// </summary>
        void drawerMenuItem3_Click(object sender, EventArgs e)
        {
            LockWindowUpdate(this.navigationDrawer1.ContentViewContainer.Handle);

            this.CaptionLabels[0].Text = "Profile";
            this.SettingsPanel.Visible = false;
            this.navigationDrawer1.ToggleDrawer();
            
            this.homePanel.Visible = false;

            this.aboutPanel.Visible = false;
            this.profilePanel.Visible = false;
            this.peoplepanel.Visible = false;
            this.photoPanel.Visible = true;
            LockWindowUpdate(IntPtr.Zero);
        }

        /// <summary>
        /// People
        /// </summary>
        void drawerMenuItem2_Click(object sender, EventArgs e)
        {
            LockWindowUpdate(this.navigationDrawer1.ContentViewContainer.Handle);

            this.CaptionLabels[0].Text = "People";
            this.SettingsPanel.Visible = false;
            this.navigationDrawer1.ToggleDrawer();
            aboutPanel.Visible = false;
            this.homePanel.Visible = false;
            peoplepanel.Visible = false;
            this.profilePanel.Visible = true;
            this.photoPanel.Visible = false;
            LockWindowUpdate(IntPtr.Zero);
          
        }

        /// <summary>
        /// Home
        /// </summary>
        void drawerMenuItem1_Click(object sender, EventArgs e)
        {
            LockWindowUpdate(this.navigationDrawer1.ContentViewContainer.Handle);
            this.CaptionLabels[0].Text = "Home";
            this.SettingsPanel.Visible = false;
            this.navigationDrawer1.ToggleDrawer();
            this.photoPanel.Visible = false;
            this.aboutPanel.Visible = false;
            this.profilePanel.Visible = false;
            this.peoplepanel.Visible = false;
            this.richTextBox.Text = "";
            richTextBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular);
            richTextBox.Text = "Lorem ipsum dolor sit amet, lacus amet amet ultricies. Quisque mi venenatis morbi libero, orci dis, mi ut et class porta, massa ligula magna enim, aliquam orci vestibulum tempus. Turpis facilisis vitae consequat, cum a a, turpis dui consequat massa in dolor per, felis non amet. Auctor eleifend in omnis elit vestibulum, donec non elementum tellus est mauris, id aliquam, at lacus, arcu pretium proin lacus dolor et. Eu tortor, vel ultrices amet dignissim mauris vehicula. Lorem tortor neque, purus taciti quis id. Elementum integer orci accumsan minim phasellus vel."
               + Environment.NewLine + Environment.NewLine + "      Vestibulum duis integer diam mi libero felis, sollicitudin id dictum etiam blandit lacus, ac condimentum magna dictumst interdum et, nam commodo mi habitasse enim fringilla nunc, amet aliquam sapien per tortor luctus. Conubia voluptates at nunc, congue lectus, malesuada nulla. Rutrum quo morbi, feugiat sed mi turpis, ac cursus integer ornare dolor. Purus dui in et tincidunt, sed eros pede adipiscing tellus, est suscipit nulla, arcu nec fringilla vel aliquam, mollis lorem rerum hac vestibulum ante nullam. Volutpat a lectus, lorem pulvinar quis. Lobortis vehicula in imperdiet orci urna." + "\n" + "\n" +
               "Lorem ipsum dolor sit amet, lacus amet amet ultricies. Quisque mi venenatis morbi libero, orci dis, mi ut et class porta, massa ligula magna enim, aliquam orci vestibulum tempus. Turpis facilisis vitae consequat, cum a a, turpis dui consequat massa in dolor per, felis non amet. Auctor eleifend in omnis elit vestibulum, donec non elementum tellus est mauris, id aliquam, at lacus, arcu pretium proin lacus dolor et. Eu tortor, vel ultrices amet dignissim mauris vehicula. Lorem tortor neque, purus taciti quis id. Elementum integer orci accumsan minim phasellus vel."
               + Environment.NewLine + Environment.NewLine + "      Vestibulum duis integer diam mi libero felis, sollicitudin id dictum etiam blandit lacus, ac condimentum magna dictumst interdum et, nam commodo mi habitasse enim fringilla nunc, amet aliquam sapien per tortor luctus. Conubia voluptates at nunc, congue lectus, malesuada nulla. Rutrum quo morbi, feugiat sed mi turpis, ac cursus integer ornare dolor. Purus dui in et tincidunt, sed eros pede adipiscing tellus, est suscipit nulla, arcu nec fringilla vel aliquam, mollis lorem rerum hac vestibulum ante nullam. Volutpat a lectus, lorem pulvinar quis. Lobortis vehicula in imperdiet orci urna.";
            //To Bold the First Line of the RichTextBox
            string firstline = this.richTextBox.Lines[0];
            int srt = richTextBox.Find(firstline);
           // richTextBox.SelectionFont = new Font(richTextBox.Font, FontStyle.Bold);
            //richTextBox.Select(richTextBox.Text.Length, 0);
            this.homePanel.Visible = true;
            LockWindowUpdate(IntPtr.Zero);
        }

        /// <summary>
        /// ToggleOption 
        /// </summary>
        void NavigationDrawerShowOnClick(object sender, ImageMouseDownEventArgs e)
        {
            this.SettingsPanel.Visible = false;
            this.navigationDrawer1.ToggleDrawer();
        }

        /// <summary>
        /// Setting Option
        /// </summary>
        void SettingsShowOnClick(object sender, ImageMouseDownEventArgs e)
        {
            this.SettingsPanel.BringToFront();
            this.SettingsPanel.Location = new Point(this.DisplayRectangle.Width - this.SettingsPanel.Width, this.navigationDrawer1.DisplayRectangle.Y);
            this.SettingsPanel.Visible = !this.SettingsPanel.Visible;
            if (this.navigationDrawer1.IsDrawerShowing())
                this.navigationDrawer1.ToggleDrawer();
        }

        /// <summary>
        /// Load
        /// </summary>
        void MainForm_Load(object sender, EventArgs e)
        {
            this.navigationDrawer1.DrawerWidth = (int)(this.navigationDrawer1.DisplayRectangle.Width / 4.5);
            this.navigationDrawer1.DrawerHeight = this.navigationDrawer1.DisplayRectangle.Height;
            captionSettingImage1.Location = new System.Drawing.Point(this.Width - 85, 18);
            //this.CaptionLabels[1].Location = new System.Drawing.Point(this.Width - 105, 45);
            //this.CaptionLabels[1].Font = new Font("Segoe UI", 9, FontStyle.Regular);
            //this.CaptionLabels[1].ForeColor = Color.White;
            this.CaptionImages.Add(captionSettingImage1);
            this.CaptionImages[1].ImageMouseDown += new CaptionImage.MouseDown(SettingsShowOnClick);
            this.richTextBox.Click += new EventHandler(richTextBox_Click);
            this.Text = "Navigation Drawer";
            this.CaptionForeColor = Color.White;
            this.CaptionFont = this.CaptionLabels[0].Font;

        }
        /// <summary>
        /// ricktextbox click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void richTextBox_Click(object sender, EventArgs e)
        {
            if (this.navigationDrawer1.IsDrawerShowing())
                this.navigationDrawer1.ToggleDrawer();
        }

        /// <summary>
        /// Size Changed
        /// </summary>
        void MainForm_SizeChanged(object sender, EventArgs e)
        {
            this.SettingsPanel.Height = this.navigationDrawer1.Height;
            this.MinimumSize = this.Size;
        }

        /// <summary>
        /// ProfilePanel Click
        /// </summary>
        void profilePanel_Click(object sender, EventArgs e)
        {
            this.SettingsPanel.Visible = false;
            if (this.navigationDrawer1.IsDrawerShowing())
                this.navigationDrawer1.ToggleDrawer();
        }

        /// <summary>
        /// PicturePanel Click
        /// </summary>
        void pic_Click(object sender, EventArgs e)
        {
            bigtile.HeaderText = (sender as HubTile).Banner.Text;
            bigtile.TileImage = (sender as HubTile).ImageSource;
            bigtile.PostionText = (sender as HubTile).Text;
            bigtile.DOBText = "27/09/2975";
            bigtile.OrganizatonText = "Management";
            bigtile.LocationText = "NewYork";
            bigtile.Invalidate();
            this.SettingsPanel.Visible = false;
            if (this.navigationDrawer1.IsDrawerShowing())
                this.navigationDrawer1.ToggleDrawer();
        }

        /// <summary>
        /// PhotoPanel Click
        /// </summary>
        void photoPanel_Click(object sender, EventArgs e)
        {
            this.SettingsPanel.Visible = false;
            if (this.navigationDrawer1.IsDrawerShowing())
                this.navigationDrawer1.ToggleDrawer();
        }
        
        /// <summary>
        /// PeoplePanel Click
        /// </summary>
        void peoplepanel_Click(object sender, EventArgs e)
        {
            this.SettingsPanel.Visible = false;
            if (this.navigationDrawer1.IsDrawerShowing())
                this.navigationDrawer1.ToggleDrawer();
        }

        /// <summary>
        /// ControlCollection Click
        /// </summary>
        void ctrl_Click(object sender, EventArgs e)
        {
            this.SettingsPanel.Visible = false;
            if (this.navigationDrawer1.IsDrawerShowing())
                this.navigationDrawer1.ToggleDrawer();
        }

        /// <summary>
        /// Label Click
        /// </summary>
        //void label1_Click(object sender, EventArgs e)
        //{
        //    this.SettingsPanel.Visible = false;
        //    if (this.navigationDrawer1.IsDrawerShowing())
        //        this.navigationDrawer1.ToggleDrawer();
        //}
        
        /// <summary>
        /// HubTile Click
        /// </summary>
        void hubTile1_Click(object sender, EventArgs e)
        {
            this.SettingsPanel.Visible = false;
            if (this.navigationDrawer1.IsDrawerShowing())
                this.navigationDrawer1.ToggleDrawer();
        }

        #endregion

        #region Functions

        /// <summary>
        /// To populate People Panel
        /// </summary>
        public void AddControlsInPeoplePanel()
        {
            FlowLayout peoplepanellayout = new FlowLayout();
            peoplepanellayout.ContainerControl = this.peoplepanel;
            peoplepanellayout.Alignment = FlowAlignment.Near;
            peoplepanellayout.HGap = 25;
            peoplepanellayout.VGap = 20;
            // peoplepanellayout.TopMargin = 25;
            // peoplepanellayout.HorzNearMargin = 25;

            PersonelView customPanel1 = new PersonelView();
            PersonelView customPanel2 = new PersonelView();
            PersonelView customPanel3 = new PersonelView();
            PersonelView customPanel4 = new PersonelView();
            PersonelView customPanel5 = new PersonelView();
            PersonelView customPanel6 = new PersonelView();
            PersonelView customPanel7 = new PersonelView();
            PersonelView customPanel8 = new PersonelView();
            PersonelView customPanel9 = new PersonelView();
            PersonelView customPanel10 = new PersonelView();
            PersonelView customPanel11 = new PersonelView();
            PersonelView customPanel12 = new PersonelView();
            PersonelView customPanel13 = new PersonelView();
            PersonelView customPanel14 = new PersonelView();
            PersonelView customPanel15 = new PersonelView();
            PersonelView customPanel16 = new PersonelView();
            PersonelView customPanel17 = new PersonelView();
            PersonelView customPanel18 = new PersonelView();
            PersonelView customPanel19 = new PersonelView();
            PersonelView customPanel20 = new PersonelView();
            PersonelView customPanel21 = new PersonelView();
            PersonelView customPanel22 = new PersonelView();
            PersonelView customPanel23 = new PersonelView();
            PersonelView customPanel24 = new PersonelView();

            this.peoplepanel.Controls.Add(customPanel1);
            this.peoplepanel.Controls.Add(customPanel2);
            this.peoplepanel.Controls.Add(customPanel3);
            this.peoplepanel.Controls.Add(customPanel4);
            this.peoplepanel.Controls.Add(customPanel5);
            this.peoplepanel.Controls.Add(customPanel6);
            this.peoplepanel.Controls.Add(customPanel7);
            this.peoplepanel.Controls.Add(customPanel8);
            this.peoplepanel.Controls.Add(customPanel9);
            this.peoplepanel.Controls.Add(customPanel10);
            this.peoplepanel.Controls.Add(customPanel11);
            this.peoplepanel.Controls.Add(customPanel12);
            this.peoplepanel.Controls.Add(customPanel13);
            this.peoplepanel.Controls.Add(customPanel14);
            this.peoplepanel.Controls.Add(customPanel15);
            this.peoplepanel.Controls.Add(customPanel16);
            this.peoplepanel.Controls.Add(customPanel17);
            this.peoplepanel.Controls.Add(customPanel18);
            this.peoplepanel.Controls.Add(customPanel19);
            this.peoplepanel.Controls.Add(customPanel20);
            this.peoplepanel.Controls.Add(customPanel21);
            this.peoplepanel.Controls.Add(customPanel22);
            this.peoplepanel.Controls.Add(customPanel23);
            this.peoplepanel.Controls.Add(customPanel24);

            customPanel1.hubTile1.ImageSource = this.imageListAdv1.Images[1];
            //customPanel1.hubTile1.Footer.Text = "       John";
            //customPanel1.label1.Location = new Point(customPanel1.label1.Location.X + 10, customPanel1.label1.Location.Y);

            customPanel2.hubTile1.ImageSource = this.imageListAdv1.Images[2];
            //customPanel2.hubTile1.Footer.Text = "Agatha Jessie";
            //customPanel2.label1.Location = new Point(customPanel2.label1.Location.X - 25, customPanel1.label1.Location.Y);

            customPanel3.hubTile1.ImageSource = this.imageListAdv1.Images[3];
            //customPanel3.hubTile1.Footer.Text = "Lilly Thomas";
            //customPanel3.label1.Location = new Point(customPanel3.label1.Location.X - 15, customPanel1.label1.Location.Y);

            customPanel4.hubTile1.ImageSource = this.imageListAdv1.Images[4];
            //customPanel4.hubTile1.Footer.Text = "Andew Philip";
            //customPanel4.label1.Location = new Point(customPanel4.label1.Location.X - 20, customPanel1.label1.Location.Y);

            customPanel5.hubTile1.ImageSource = this.imageListAdv1.Images[5];
            //customPanel5.hubTile1.Footer.Text = "Jaden Storm";
            //customPanel5.label1.Location = new Point(customPanel5.label1.Location.X - 20, customPanel1.label1.Location.Y);

            customPanel6.hubTile1.ImageSource = this.imageListAdv1.Images[6];
            //customPanel6.hubTile1.Footer.Text = "Marie Luke";
            //customPanel6.label1.Location = new Point(customPanel6.label1.Location.X - 15, customPanel1.label1.Location.Y);

            customPanel7.hubTile1.ImageSource = this.imageListAdv1.Images[7];
            //customPanel7.hubTile1.Footer.Text = "Magen Mia";
            //customPanel7.label1.Location = new Point(customPanel7.label1.Location.X - 15, customPanel1.label1.Location.Y);

            customPanel8.hubTile1.ImageSource = this.imageListAdv1.Images[8];
            //customPanel8.hubTile1.Footer.Text = "Angel Christie";
            //customPanel8.label1.Location = new Point(customPanel8.label1.Location.X - 25, customPanel1.label1.Location.Y);

            customPanel8.hubTile1.ImageSource = this.imageListAdv1.Images[3];
            //customPanel8.hubTile1.Footer.Text = "Lilly Thomas";

            customPanel9.hubTile1.ImageSource = this.imageListAdv1.Images[2];
            //customPanel9.hubTile1.Footer.Text = "Agatha Jessie";
            //customPanel9.label1.Location = new Point(customPanel9.label1.Location.X - 25, customPanel9.label1.Location.Y);

            customPanel10.hubTile1.ImageSource = this.imageListAdv1.Images[1];
            //customPanel10.hubTile1.Footer.Text = "       John";

            customPanel11.hubTile1.ImageSource = this.imageListAdv1.Images[2];
            //customPanel11.hubTile1.Footer.Text = "Agatha Jessie";
            //customPanel11.label1.Location = new Point(customPanel11.label1.Location.X - 25, customPanel11.label1.Location.Y);

            customPanel12.hubTile1.ImageSource = this.imageListAdv1.Images[3];
            //customPanel12.hubTile1.Footer.Text = "Lilly Thomas";

            customPanel13.hubTile1.ImageSource = this.imageListAdv1.Images[4];
            //customPanel13.hubTile1.Footer.Text = "Andew Philip";

            customPanel14.hubTile1.ImageSource = this.imageListAdv1.Images[5];
            //customPanel14.hubTile1.Footer.Text = "Jaden Storm";

            customPanel15.hubTile1.ImageSource = this.imageListAdv1.Images[6];
            //customPanel15.hubTile1.Footer.Text = "Marie Luke";

            customPanel16.hubTile1.ImageSource = this.imageListAdv1.Images[7];
            //customPanel16.hubTile1.Footer.Text = "Magen Mia";

            customPanel17.hubTile1.ImageSource = this.imageListAdv1.Images[1];
            //customPanel17.hubTile1.Footer.Text = "      John";

            customPanel18.hubTile1.ImageSource = this.imageListAdv1.Images[7];
            //customPanel18.hubTile1.Footer.Text = "Andew Philip";               

            customPanel19.hubTile1.ImageSource = this.imageListAdv1.Images[1];
            //customPanel19.hubTile1.Footer.Text = "       John";

            customPanel20.hubTile1.ImageSource = this.imageListAdv1.Images[2];
            //customPanel20.hubTile1.Footer.Text = "Agatha Jessie";
            //customPanel20.label1.Location = new Point(customPanel20.label1.Location.X - 25, customPanel20.label1.Location.Y);

            customPanel21.hubTile1.ImageSource = this.imageListAdv1.Images[3];
            //customPanel21.hubTile1.Footer.Text = "Lilly Thomas";

            customPanel22.hubTile1.ImageSource = this.imageListAdv1.Images[4];
            //customPanel22.hubTile1.Footer.Text = "Andew Philip";

            customPanel23.hubTile1.ImageSource = this.imageListAdv1.Images[5];
            //customPanel23.hubTile1.Footer.Text = "Jaden Storm";

            customPanel24.hubTile1.ImageSource = this.imageListAdv1.Images[6];
            //customPanel24.hubTile1.Footer.Text = "Marie Luke";           
           
            
            peoplepanel.Click += new EventHandler(peoplepanel_Click);
            foreach (PersonelView ctrl in this.peoplepanel.Controls)
            {
                ctrl.hubTile1.Click += new EventHandler(hubTile1_Click);
                ctrl.Click += new EventHandler(ctrl_Click);
            }
        }

        /// <summary>
        /// To populate Photo Panel
        /// </summary>
        public void AddControlsInPhotoPanel()
        {
            this.photoPanel.Dock = DockStyle.Fill;
            FlowLayout photoLayout = new FlowLayout();

            FlowLayoutPanel CustomProfilePanel = new FlowLayoutPanel();
            CustomProfilePanel.WrapContents = true;
            CustomProfilePanel.FlowDirection = FlowDirection.TopDown;
            Panel BigImagePanel = new Panel();
            BigImagePanel.BackColor = Color.Green;
            BigImagePanel.Size = new System.Drawing.Size(this.Width, this.Height);
            CustomProfilePanel.AutoScroll = true;

            photpanelimage1.TileType = HubTileType.DefaultTile;
            photpanelimage1.ShowBanner = true;
            photpanelimage1.EnableTileSlideEffect = false;
            photpanelimage1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            photpanelimage1.Footer.Text = "John";
            photpanelimage1.Footer.TextColor = Color.White;
            photpanelimage1.Text = "Chairman";
            photpanelimage1.Banner.Text = "John";
            photpanelimage1.BannerHeight = 35;
            photpanelimage1.BannerColor = ColorTranslator.FromHtml("#0d83bd");
            
            photpanelimage2.TileType = HubTileType.DefaultTile;
            photpanelimage2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            photpanelimage2.EnableTileSlideEffect = false;
            photpanelimage2.ShowBanner = true;
            photpanelimage2.BannerHeight = 35;
            photpanelimage2.BannerColor = Color.Green;
            photpanelimage2.Banner.Text = "Marie Luke";
            photpanelimage2.Text = "Manager";
            photpanelimage2.BannerColor = ColorTranslator.FromHtml("#15cd81");

            photpanelimage3.TileType = HubTileType.DefaultTile;
            photpanelimage3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            photpanelimage3.ShowBanner = true;
            photpanelimage3.BannerHeight = 35;
            photpanelimage3.EnableTileSlideEffect = false;
            photpanelimage3.BannerColor = Color.Green;
            photpanelimage3.Banner.Text = "Agatha Jessie";
            photpanelimage3.Text = "CEO";
            photpanelimage3.BannerColor = ColorTranslator.FromHtml("#09b8bf");
            
            photpanelimage4.TileType = HubTileType.DefaultTile;
            photpanelimage4.ShowBanner = true;
            photpanelimage4.BannerHeight = 40;
            photpanelimage4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            photpanelimage4.BannerColor = Color.Green;
            photpanelimage4.Banner.Text = "Andrew Philip";
            photpanelimage4.EnableTileSlideEffect = false;
            photpanelimage4.Text = "Senior Manager";
            photpanelimage4.BannerColor = ColorTranslator.FromHtml("#35b999");

            CustomProfilePanel.Controls.Add(photpanelimage1);
            CustomProfilePanel.Controls.Add(photpanelimage2);
            CustomProfilePanel.Controls.Add(photpanelimage3);
            CustomProfilePanel.Controls.Add(photpanelimage4);

            photpanelimage1.Size = new Size(175, photoPanel.Height / 4 - 10);
            photpanelimage2.Size = new Size(175, photoPanel.Height / 4 - 10);
            photpanelimage3.Size = new Size(175, photoPanel.Height / 4 - 10);
            photpanelimage4.Size = new Size(175, photoPanel.Height / 4 - 10);
            CustomProfilePanel.Size = new System.Drawing.Size(200, this.Height);

            this.photoPanel.Controls.Add(CustomProfilePanel);
            this.photoPanel.Controls.Add(BigImagePanel);
            
            photpanelimage1.ImageSource = this.imageListAdv1.Images[1];
            photpanelimage2.ImageSource = this.imageListAdv1.Images[6];
            photpanelimage3.ImageSource = this.imageListAdv1.Images[2];
            photpanelimage4.ImageSource = this.imageListAdv1.Images[4];
            
            bigtile.HeaderColor = Color.Orange;
            bigtile.BackColor = Color.Orange;

            bigtile.HeaderText = "Agatha Jessie";
            bigtile.TileImage = this.imageListAdv1.Images[2];
            bigtile.PostionText = "CEO";
            bigtile.DOBText = "27/09/2975";
            bigtile.OrganizatonText = "Management";
            bigtile.LocationText = "NewYork";
            bigtile.Description = "Lorem ipsum dolor sit amet, lacus amet amet ultricies. Quisque mi venenatis morbi libero, orci dis, mi ut et class porta, massa ligula magna enim, aliquam orci vestibulum tempus. Turpis facilisis vitae consequat, cum a a, turpis dui consequat massa in dolor per, felis non amet. Auctor eleifend in omnis elit vestibulum, donec non elementum tellus est mauris, id aliquam, at lacus, arcu pretium proin lacus dolor et. Eu tortor, vel ultrices amet dignissim mauris vehicula. Lorem tortor neque, purus taciti quis id. Elementum integer orci accumsan minim phasellus vel.";
            BigImagePanel.Controls.Add(bigtile);
            bigtile.Dock = DockStyle.Fill;

            this.photoPanel.Click += new EventHandler(photoPanel_Click);
            foreach (Control tile in CustomProfilePanel.Controls)
            {
                if (tile is HubTile)
                    tile.Click += new EventHandler(pic_Click);
            }
        }

        /// <summary>
        /// To populate Profile Panel
        /// </summary>
        public void AddControlsInProfilePanel()
        {
           
            profile1.HeaderText = "John";
            profile2.HeaderText = "Agatha Jessie";
            profile3.HeaderText = "Lilly Thomas";
            profile4.HeaderText = "Andew Philip";
            profile5.HeaderText = "Jaden Storm";
            profile6.HeaderText = "Marie Luke";

            profile1.TileImage = this.imageListAdv1.Images[1];
            profile2.TileImage = this.imageListAdv1.Images[2];
            profile3.TileImage = this.imageListAdv1.Images[3];
            profile4.TileImage = this.imageListAdv1.Images[4];
            profile5.TileImage = this.imageListAdv1.Images[5];
            profile6.TileImage = this.imageListAdv1.Images[6];

            profile1.PostionText = "Chairman";
            profile2.PostionText = "CEO";
            profile3.PostionText = "CEA";
            profile4.PostionText = "Senior Manager";
            profile5.PostionText = "Senior Executive";
            profile6.PostionText = "Manager";

            profile1.OrganizatonText = "Management";
            profile2.OrganizatonText = "Management";
            profile3.OrganizatonText = "Management";
            profile4.OrganizatonText = "Operational unit";
            profile5.OrganizatonText = "Operational unit";
            profile6.OrganizatonText = "Custom Service";

            profile1.DOBText = "26/09/1973";
            profile2.DOBText = "27/09/1975";
            profile3.DOBText = "23/07/1978";
            profile4.DOBText = "26/09/1973";
            profile5.DOBText = "28/09/1979";
            profile6.DOBText = "26/11/1973";

            profile1.LocationText = "NewYork";
            profile2.LocationText = "NewYork";
            profile3.LocationText = "NewYork";
            profile4.LocationText = "NewYork";
            profile5.LocationText = "NewYork";
            profile6.LocationText = "NewYork";

            profile1.HeaderColor = Color.Orange;
            profile2.HeaderColor = Color.Green;
            profile3.HeaderColor = Color.Maroon;
            profile4.HeaderColor = Color.DarkKhaki;
            profile5.HeaderColor = Color.BlueViolet;
            profile6.HeaderColor = Color.DarkMagenta;

            profilePanel.Controls.Add(profile1);
            profilePanel.Controls.Add(profile2);
            profilePanel.Controls.Add(profile3);
            profilePanel.Controls.Add(profile4);
            profilePanel.Controls.Add(profile5);
            profilePanel.Controls.Add(profile6);
            profilePanel.AutoScroll = true;
            profile1.Size = new Size(425, 225);
            profile2.Size = new Size(425, 225);
            profile3.Size = new Size(425, 225);
            profile4.Size = new Size(425, 225);
            profile5.Size = new Size(425, 225);
            profile6.Size = new Size(425, 225);

            RichTextBox rich = new RichTextBox();
            ScrollersFrame frame = new ScrollersFrame();
            frame.AttachedTo = profilePanel;
            profilePanel.Dock = DockStyle.Fill;
            frame.VisualStyle = ScrollBarCustomDrawStyles.Metro;
            frame.MetroThumbSize = new System.Drawing.Size(5, frame.MetroThumbSize.Height);
            rich.BorderStyle = BorderStyle.None;

            // richTextBox1
            // 
            //rich.Dock = DockStyle.Fill;
            rich.Location = new System.Drawing.Point(0, 277);
            rich.Name = "richTextBox1";
            rich.Size = new System.Drawing.Size(700, 300);
            rich.TabIndex = 9;
            rich.Text = "Born on December 25, 1984, in Spokane, Washington. Anderson graduated from Texas University in 2008." +
                " He started his career as a teacher. Later he started business with his friend Paul. " +
                " They both spent more time together working on business. They earned enough money and spent that for poor and social welfares." +
                " Later they together started an organization for children welfare.";
            rich.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular);
            rich.ForeColor = System.Drawing.ColorTranslator.FromHtml("#353535");
            rich.Size = new System.Drawing.Size(this.Width + 100, 300);
            profilePanel.Click += new EventHandler(profilePanel_Click);

            foreach (Control ctrl in this.profilePanel.Controls)
            {
                ctrl.Click += new EventHandler(profilePanel_Click);
            }
        }

        void profilePanel_Enter(object sender, EventArgs e)
        {
            this.profilePanel.Focus();
        }

        #endregion

        #region Setting Panel

        /// <summary>
        /// Settings Panel Apply Selection
        /// </summary>
        private void Apply_Click(object sender, EventArgs e)
        {
            if (this.BottomPosition.Checked)
            {
                this.navigationDrawer1.DrawerHeight = this.navigationDrawer1.DisplayRectangle.Height / 2;
                this.navigationDrawer1.DrawerWidth = this.navigationDrawer1.DisplayRectangle.Width;
                this.navigationDrawer1.Position = SlidePosition.Bottom;
                this.navigationDrawer1.DrawerPanelContainer.Padding = new Padding(0, 1, 0, 0);
            }
            else if (rightPosition.Checked)
            {
                this.navigationDrawer1.DrawerHeight = this.navigationDrawer1.DisplayRectangle.Height;
                this.navigationDrawer1.DrawerWidth = this.navigationDrawer1.DisplayRectangle.Width/4;
                this.navigationDrawer1.Position = SlidePosition.Right;
                this.navigationDrawer1.DrawerPanelContainer.Padding = new Padding(1, 0, 0, 0);
            }
            else if (TopPosition.Checked)
            {
                this.navigationDrawer1.DrawerHeight = this.navigationDrawer1.DisplayRectangle.Height / 2;
                this.navigationDrawer1.DrawerWidth = this.navigationDrawer1.DisplayRectangle.Width;
                this.navigationDrawer1.Position = SlidePosition.Top;
                this.navigationDrawer1.DrawerPanelContainer.Padding = new Padding(0, 0, 0, 3);
            }
            else if (leftposition.Checked)
            {
                this.navigationDrawer1.DrawerHeight = this.navigationDrawer1.DisplayRectangle.Height;
                this.navigationDrawer1.DrawerWidth = this.navigationDrawer1.DisplayRectangle.Width/4;
                this.navigationDrawer1.Position = SlidePosition.Left;
                this.navigationDrawer1.DrawerPanelContainer.Padding = new Padding(0, 0, 3, 0);
            }

            if (this.SlideOnTop.Checked)
            {
                this.navigationDrawer1.Transition = Syncfusion.Windows.Forms.Tools.Transition.SlideOnTop;
            }
            else if (this.Reveal.Checked)
            {
                this.navigationDrawer1.Transition = Syncfusion.Windows.Forms.Tools.Transition.Reveal;
            }
            else if (this.Push.Checked)
            {
                this.navigationDrawer1.Transition = Syncfusion.Windows.Forms.Tools.Transition.Push;
            }
            if(this.comboboxAdv1.SelectedIndex == 0)
            {
                this.navigationDrawer1.Style = NavigationDrawerStyle.Office2016Colorful;
            }
            else if (this.comboboxAdv1.SelectedIndex == 1)
            {
                this.navigationDrawer1.Style = NavigationDrawerStyle.Office2016White;
            }
            else if (this.comboboxAdv1.SelectedIndex == 2)
            {
                this.navigationDrawer1.Style = NavigationDrawerStyle.Office2016DarkGray;
            }
            else if (this.comboboxAdv1.SelectedIndex == 3)
            {
                this.navigationDrawer1.Style = NavigationDrawerStyle.Office2016Black;
            }
            this.SettingsPanel.Visible = false;
            UpdateNavigationDrawerStyleForOffice2016();
        }
        /// <summary>
        /// Event for applying style
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboboxAdv1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.comboboxAdv1.ListBox.SelectedIndex == 0)
            {
                this.comboboxAdv1.Text = this.comboboxAdv1.ListBox.SelectedItem.ToString();
            }
            else if (this.comboboxAdv1.SelectedIndex == 1)
            {
                this.comboboxAdv1.Text = this.comboboxAdv1.ListBox.SelectedItem.ToString();
            }
            else if (this.comboboxAdv1.SelectedIndex == 2)
            {
                this.comboboxAdv1.Text = this.comboboxAdv1.ListBox.SelectedItem.ToString();
            }
            else if (this.comboboxAdv1.SelectedIndex == 3)
            {
                this.comboboxAdv1.Text = this.comboboxAdv1.ListBox.SelectedItem.ToString();
            }
            else if (this.comboboxAdv1.SelectedIndex == 4)
            {
                 this.comboboxAdv1.Text = this.comboboxAdv1.ListBox.SelectedItem.ToString();
            }
        }

        /// <summary>
        /// Settings Panel Reset Selection
        /// </summary>
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.SlideOnTop.Checked = true;
            this.leftposition.Checked = true;
            this.SettingsPanel.Visible = false;
            this.navigationDrawer1.DrawerHeight = this.navigationDrawer1.DisplayRectangle.Height;
            this.navigationDrawer1.DrawerWidth = this.navigationDrawer1.DisplayRectangle.Width / 4;
            this.navigationDrawer1.Position = SlidePosition.Left;
            this.navigationDrawer1.Transition = Syncfusion.Windows.Forms.Tools.Transition.SlideOnTop;
            this.navigationDrawer1.DrawerPanelContainer.Padding = new Padding(0, 0, 3, 0);
        }
        private void UpdateNavigationDrawerStyleForOffice2016()
        {
            LockWindowUpdate(this.Handle);

            if (this.navigationDrawer1.Style == NavigationDrawerStyle.Default)
            {
                this.BackColor = System.Drawing.Color.White;
                this.ForeColor = System.Drawing.Color.Black;
                this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(165)))), ((int)(((byte)(221)))));
                this.CaptionForeColor = System.Drawing.Color.White;

                this.label1.ForeColor = System.Drawing.Color.Black;
                this.label2.ForeColor = System.Drawing.Color.Black;
                this.label3.ForeColor = System.Drawing.Color.Black;
                this.label4.ForeColor = System.Drawing.Color.Black;
                this.richTextBox.ForeColor = System.Drawing.Color.Black;
                this.peoplepanel.ForeColor = System.Drawing.Color.Black;
                this.homePanel.ForeColor = System.Drawing.Color.Black;
                this.photoPanel.ForeColor = System.Drawing.Color.Black;
                this.profilePanel.ForeColor = System.Drawing.Color.Black;
                this.SettingsPanel.ForeColor = System.Drawing.Color.Black;
                this.captionLabel1.ForeColor = System.Drawing.Color.White;

                this.label1.BackColor = System.Drawing.Color.White;
                this.label2.BackColor = System.Drawing.Color.White;
                this.label3.BackColor = System.Drawing.Color.White;
                this.label4.BackColor = System.Drawing.Color.White;
                this.panel1.BackColor = System.Drawing.Color.White;
                this.panel2.BackColor = System.Drawing.Color.White;
                this.panel3.BackColor = System.Drawing.Color.White;
                this.panel4.BackColor = System.Drawing.Color.White;
                this.richTextBox.BackColor = System.Drawing.Color.White;
                this.peoplepanel.BackColor = System.Drawing.Color.White;
                this.homePanel.BackColor = System.Drawing.Color.White;
                this.photoPanel.BackColor = System.Drawing.Color.White;
                this.profilePanel.BackColor = System.Drawing.Color.White;
                this.SettingsPanel.BackColor = System.Drawing.Color.White;

                this.navigationDrawer1.ContentViewContainer.BackColor = Color.White;
                this.drawerMenuItem1.BackColor = System.Drawing.Color.White;
                 this.drawerMenuItem1.DefaultColor = System.Drawing.Color.White;
                 this.drawerMenuItem1.HoverColor = System.Drawing.Color.LightGray;
                 this.drawerMenuItem1.SelectionColor = System.Drawing.Color.LightGray;
                 this.drawerMenuItem1.TextColor = System.Drawing.Color.Black;

                this.drawerMenuItem2.BackColor = System.Drawing.Color.White;
                this.drawerMenuItem2.DefaultColor = System.Drawing.Color.White;
                this.drawerMenuItem2.HoverColor = System.Drawing.Color.LightGray;
                this.drawerMenuItem2.SelectionColor = System.Drawing.Color.LightGray;
                this.drawerMenuItem2.TextColor = System.Drawing.Color.Black;

                this.drawerMenuItem3.BackColor = System.Drawing.Color.White;
                this.drawerMenuItem3.DefaultColor = System.Drawing.Color.White;
                this.drawerMenuItem3.HoverColor = System.Drawing.Color.LightGray;
                this.drawerMenuItem3.SelectionColor = System.Drawing.Color.LightGray;
                this.drawerMenuItem3.TextColor = System.Drawing.Color.Black;

                this.drawerMenuItem4.BackColor = System.Drawing.Color.White;
                this.drawerMenuItem4.DefaultColor = System.Drawing.Color.White;
                this.drawerMenuItem4.HoverColor = System.Drawing.Color.LightGray;
                this.drawerMenuItem4.SelectionColor = System.Drawing.Color.LightGray;
                this.drawerMenuItem4.TextColor = System.Drawing.Color.Black;

                this.drawerMenuItem5.BackColor = System.Drawing.Color.White;
                this.drawerMenuItem5.DefaultColor = System.Drawing.Color.White;
                this.drawerMenuItem5.HoverColor = System.Drawing.Color.LightGray;
                this.drawerMenuItem5.SelectionColor = System.Drawing.Color.LightGray;
                this.drawerMenuItem5.TextColor = System.Drawing.Color.Black;

                this.Apply.Appearance = ButtonAppearance.Metro;
                this.Cancel.Appearance = ButtonAppearance.Metro;
                this.rightPosition.Style = RadioButtonAdvStyle.Metro;
                this.leftposition.Style = RadioButtonAdvStyle.Metro;
                this.TopPosition.Style = RadioButtonAdvStyle.Metro;
                this.BottomPosition.Style = RadioButtonAdvStyle.Metro;
                this.SlideOnTop.Style = RadioButtonAdvStyle.Metro;
                this.Push.Style = RadioButtonAdvStyle.Metro;
                this.Reveal.Style = RadioButtonAdvStyle.Metro;
                this.comboboxAdv1.Style = VisualStyle.Metro;

                this.rightPosition.BackColor = System.Drawing.Color.White;
                this.leftposition.BackColor = System.Drawing.Color.White;
                this.TopPosition.BackColor = System.Drawing.Color.White;
                this.BottomPosition.BackColor = System.Drawing.Color.White;
                this.SlideOnTop.BackColor = System.Drawing.Color.White;
                this.Push.BackColor = System.Drawing.Color.White;
                this.Reveal.BackColor = System.Drawing.Color.White;

                this.rightPosition.ForeColor = System.Drawing.Color.Black;
                this.leftposition.ForeColor = System.Drawing.Color.Black;
                this.TopPosition.ForeColor = System.Drawing.Color.Black;
                this.BottomPosition.ForeColor = System.Drawing.Color.Black; 
                this.SlideOnTop.ForeColor = System.Drawing.Color.Black; ;
                this.Push.ForeColor = System.Drawing.Color.Black;
                this.Reveal.ForeColor = System.Drawing.Color.Black;

                profile1.HeaderColor = Color.Orange;
                profile2.HeaderColor = Color.Green;
                profile3.HeaderColor = Color.Maroon;
                profile4.HeaderColor = Color.DarkKhaki;
                profile5.HeaderColor = Color.BlueViolet;
                profile6.HeaderColor = Color.DarkMagenta;

                profile1.BackColor = System.Drawing.Color.White;
                profile2.BackColor = System.Drawing.Color.White;
                profile3.BackColor = System.Drawing.Color.White;
                profile4.BackColor = System.Drawing.Color.White;
                profile5.BackColor = System.Drawing.Color.White;
                profile6.BackColor = System.Drawing.Color.White;

                profile1.ForeColor = System.Drawing.Color.Black;
                profile2.ForeColor = System.Drawing.Color.Black;
                profile3.ForeColor = System.Drawing.Color.Black;
                profile4.ForeColor = System.Drawing.Color.Black;
                profile5.ForeColor = System.Drawing.Color.Black;
                profile6.ForeColor = System.Drawing.Color.Black;
                
                photpanelimage1.Footer.TextColor = Color.White;
                photpanelimage2.Footer.TextColor = Color.White;
                photpanelimage3.Footer.TextColor = Color.White;
                photpanelimage4.Footer.TextColor = Color.White;

                photpanelimage1.BannerColor = ColorTranslator.FromHtml("#0d83bd");
                photpanelimage2.BannerColor = ColorTranslator.FromHtml("#15cd81");
                photpanelimage3.BannerColor = ColorTranslator.FromHtml("#09b8bf");
                photpanelimage4.BannerColor = ColorTranslator.FromHtml("#35b999");

                bigtile.HeaderColor = Color.Orange;
                bigtile.BackColor = Color.Orange;
                bigtile.TextColor = Color.White;

                this.ShowIcon = true;
                this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(165)))), ((int)(((byte)(221)))));
                this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
                this.CaptionButtonColor = System.Drawing.Color.White;
                this.SettingsPanel.BorderStyle = BorderStyle.FixedSingle;
                this.navigationDrawer1.DrawerPanelContainer.BorderStyle = BorderStyle.FixedSingle;

                captionSettingImage1.Image = global::NavigationDrawer_2010.Properties.Resources.icon_settings;
                captionImage1.Image = global::NavigationDrawer_2010.Properties.Resources.TriggerImage6_1;
                captionImage1.Size = new System.Drawing.Size(60, 40);
                captionImage1.Location = new Point(0,14);
            }
            else if (this.navigationDrawer1.Style == NavigationDrawerStyle.Office2016Colorful)
            {
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.ForeColor = ColorTranslator.FromHtml("#262626");
                this.CaptionBarColor = ColorTranslator.FromHtml("#0173c7");
                this.CaptionForeColor = ColorTranslator.FromHtml("#ffffff");

                this.label1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label2.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label3.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label4.ForeColor = ColorTranslator.FromHtml("#262626");
                this.richTextBox.ForeColor = ColorTranslator.FromHtml("#262626");
                this.peoplepanel.ForeColor = ColorTranslator.FromHtml("#262626");
                this.homePanel.ForeColor = ColorTranslator.FromHtml("#262626");
                this.photoPanel.ForeColor = ColorTranslator.FromHtml("#262626");
                this.profilePanel.ForeColor = ColorTranslator.FromHtml("#262626");
                this.SettingsPanel.ForeColor = ColorTranslator.FromHtml("#262626");
                this.captionLabel1.ForeColor = ColorTranslator.FromHtml("#ffffff");

                this.label1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.label2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.label3.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.label4.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel3.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel4.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.richTextBox.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.peoplepanel.BackColor= ColorTranslator.FromHtml("#ffffff");
                this.homePanel.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.photoPanel.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.profilePanel.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.SettingsPanel.BackColor = ColorTranslator.FromHtml("#ffffff");



                this.Apply.Appearance = ButtonAppearance.Office2016Colorful;
                this.Cancel.Appearance = ButtonAppearance.Office2016Colorful;
                this.rightPosition.Style = RadioButtonAdvStyle.Office2016Colorful;
                this.leftposition.Style = RadioButtonAdvStyle.Office2016Colorful;
                this.TopPosition.Style = RadioButtonAdvStyle.Office2016Colorful;
                this.BottomPosition.Style = RadioButtonAdvStyle.Office2016Colorful;
                this.SlideOnTop.Style = RadioButtonAdvStyle.Office2016Colorful;
                this.Push.Style = RadioButtonAdvStyle.Office2016Colorful;
                this.Reveal.Style = RadioButtonAdvStyle.Office2016Colorful;
                this.comboboxAdv1.Style = VisualStyle.Office2016Colorful;

                profile1.HeaderColor = ColorTranslator.FromHtml("#0173c7");
                profile2.HeaderColor = ColorTranslator.FromHtml("#0173c7");
                profile3.HeaderColor = ColorTranslator.FromHtml("#0173c7");
                profile4.HeaderColor = ColorTranslator.FromHtml("#0173c7");
                profile5.HeaderColor = ColorTranslator.FromHtml("#0173c7");
                profile6.HeaderColor = ColorTranslator.FromHtml("#0173c7");

                profile1.BackColor = System.Drawing.Color.White;
                profile2.BackColor = System.Drawing.Color.White;
                profile3.BackColor = System.Drawing.Color.White;
                profile4.BackColor = System.Drawing.Color.White;
                profile5.BackColor = System.Drawing.Color.White;
                profile6.BackColor = System.Drawing.Color.White;

                profile1.TextColor = System.Drawing.Color.Black;
                profile2.TextColor = System.Drawing.Color.Black;
                profile3.TextColor = System.Drawing.Color.Black;
                profile4.TextColor = System.Drawing.Color.Black;
                profile5.TextColor = System.Drawing.Color.Black;
                profile6.TextColor = System.Drawing.Color.Black;

                profile1.HeaderTextColor = System.Drawing.Color.White;
                profile2.HeaderTextColor = System.Drawing.Color.White;
                profile3.HeaderTextColor = System.Drawing.Color.White;
                profile4.HeaderTextColor = System.Drawing.Color.White;
                profile5.HeaderTextColor = System.Drawing.Color.White;
                profile6.HeaderTextColor = System.Drawing.Color.White;

                photpanelimage1.BannerColor = ColorTranslator.FromHtml("#0173c7");
                photpanelimage2.BannerColor = ColorTranslator.FromHtml("#0173c7");
                photpanelimage3.BannerColor = ColorTranslator.FromHtml("#0173c7");
                photpanelimage4.BannerColor = ColorTranslator.FromHtml("#0173c7");

                photpanelimage1.Banner.TextColor = Color.White;
                photpanelimage2.Banner.TextColor = Color.White;
                photpanelimage3.Banner.TextColor = Color.White;
                photpanelimage4.Banner.TextColor = Color.White;

                bigtile.HeaderColor = ColorTranslator.FromHtml("#0173c7");
                bigtile.BackColor = ColorTranslator.FromHtml("#0173c7");
                bigtile.TextColor = Color.White;

                this.ShowIcon = false;
                this.MetroColor = ColorTranslator.FromHtml("#0173c7");
                this.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.CaptionButtonColor = ColorTranslator.FromHtml("#ffffff");
                this.SettingsPanel.BorderStyle = BorderStyle.FixedSingle;
                this.navigationDrawer1.DrawerPanelContainer.BorderStyle = BorderStyle.FixedSingle;

                captionSettingImage1.Image = global::NavigationDrawer_2010.Properties.Resources.Icon_Setting_Colorful;
                captionSettingImage1.BackColor = ColorTranslator.FromHtml("#0173c7");
                captionImage1.Image = global::NavigationDrawer_2010.Properties.Resources.Icon_menu_Colorful;
                captionImage1.Size = new Size(40,40);
                captionImage1.Location = new Point(6, 14);
                captionImage1.BackColor = ColorTranslator.FromHtml("#0173c7");
            }
            else if (this.navigationDrawer1.Style == NavigationDrawerStyle.Office2016White)
            {
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.ForeColor = ColorTranslator.FromHtml("#262626");
                this.CaptionBarColor = ColorTranslator.FromHtml("#ffffff");
                this.CaptionForeColor = ColorTranslator.FromHtml("#262626");
                this.captionLabel1.ForeColor = ColorTranslator.FromHtml("#262626");

                this.label1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label2.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label3.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label4.ForeColor = ColorTranslator.FromHtml("#262626");
                this.richTextBox.ForeColor = ColorTranslator.FromHtml("#262626");
                this.peoplepanel.ForeColor = ColorTranslator.FromHtml("#262626");
                this.homePanel.ForeColor = ColorTranslator.FromHtml("#262626");
                this.photoPanel.ForeColor = ColorTranslator.FromHtml("#262626");
                this.profilePanel.ForeColor = ColorTranslator.FromHtml("#262626");
                this.SettingsPanel.ForeColor = ColorTranslator.FromHtml("#262626");

                this.label1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.label2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.label3.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.label4.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel3.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel4.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.richTextBox.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.peoplepanel.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.homePanel.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.photoPanel.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.profilePanel.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.SettingsPanel.BackColor = ColorTranslator.FromHtml("#ffffff");

                this.Apply.Appearance = ButtonAppearance.Office2016White;
                this.Cancel.Appearance = ButtonAppearance.Office2016White;
                this.rightPosition.Style = RadioButtonAdvStyle.Office2016White;
                this.leftposition.Style = RadioButtonAdvStyle.Office2016White;
                this.TopPosition.Style = RadioButtonAdvStyle.Office2016White;
                this.BottomPosition.Style = RadioButtonAdvStyle.Office2016White;
                this.SlideOnTop.Style = RadioButtonAdvStyle.Office2016White;
                this.Push.Style = RadioButtonAdvStyle.Office2016White;
                this.Reveal.Style = RadioButtonAdvStyle.Office2016White;
                this.comboboxAdv1.Style = VisualStyle.Office2016White;

                profile1.HeaderColor = ColorTranslator.FromHtml("#e6f1fa");
                profile2.HeaderColor = ColorTranslator.FromHtml("#e6f1fa");
                profile3.HeaderColor = ColorTranslator.FromHtml("#e6f1fa");
                profile4.HeaderColor = ColorTranslator.FromHtml("#e6f1fa");
                profile5.HeaderColor = ColorTranslator.FromHtml("#e6f1fa");
                profile6.HeaderColor = ColorTranslator.FromHtml("#e6f1fa");

                profile1.BackColor = System.Drawing.Color.White;
                profile2.BackColor = System.Drawing.Color.White;
                profile3.BackColor = System.Drawing.Color.White;
                profile4.BackColor = System.Drawing.Color.White;
                profile5.BackColor = System.Drawing.Color.White;
                profile6.BackColor = System.Drawing.Color.White;

                profile1.TextColor = System.Drawing.Color.Black;
                profile2.TextColor = System.Drawing.Color.Black;
                profile3.TextColor = System.Drawing.Color.Black;
                profile4.TextColor = System.Drawing.Color.Black;
                profile5.TextColor = System.Drawing.Color.Black;
                profile6.TextColor = System.Drawing.Color.Black;

                profile1.HeaderTextColor = System.Drawing.Color.Black;
                profile2.HeaderTextColor = System.Drawing.Color.Black;
                profile3.HeaderTextColor = System.Drawing.Color.Black;
                profile4.HeaderTextColor = System.Drawing.Color.Black;
                profile5.HeaderTextColor = System.Drawing.Color.Black;
                profile6.HeaderTextColor = System.Drawing.Color.Black;
           
                photpanelimage1.BannerColor = ColorTranslator.FromHtml("#e6f1fa");
                photpanelimage2.BannerColor = ColorTranslator.FromHtml("#e6f1fa");
                photpanelimage3.BannerColor = ColorTranslator.FromHtml("#e6f1fa");
                photpanelimage4.BannerColor = ColorTranslator.FromHtml("#e6f1fa");

                photpanelimage1.Banner.TextColor = ColorTranslator.FromHtml("#000000");
                photpanelimage2.Banner.TextColor = ColorTranslator.FromHtml("#000000");
                photpanelimage3.Banner.TextColor = ColorTranslator.FromHtml("#000000");
                photpanelimage4.Banner.TextColor = ColorTranslator.FromHtml("#000000");

                bigtile.HeaderColor = ColorTranslator.FromHtml("#e6f1fa");
                bigtile.BackColor = ColorTranslator.FromHtml("#e6f1fa");
                bigtile.TextColor = ColorTranslator.FromHtml("#000000");
                this.MetroColor = ColorTranslator.FromHtml("#ffffff");
                this.ShowIcon = false;
                this.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.CaptionButtonColor = ColorTranslator.FromHtml("#000000");
                this.SettingsPanel.BorderStyle = BorderStyle.FixedSingle;
                this.navigationDrawer1.DrawerPanelContainer.BorderStyle = BorderStyle.FixedSingle;

                captionSettingImage1.Image = global::NavigationDrawer_2010.Properties.Resources.Icon_Setting_White;
                captionSettingImage1.BackColor = ColorTranslator.FromHtml("#ffffff");
                captionImage1.Image = global::NavigationDrawer_2010.Properties.Resources.Icon_menu_White;
                captionImage1.Size = new Size(40, 40);
                captionImage1.Location = new Point(6, 14);
                captionImage1.BackColor = ColorTranslator.FromHtml("#ffffff");
            }
            else if (this.navigationDrawer1.Style == NavigationDrawerStyle.Office2016Black)
            {
                this.BackColor = ColorTranslator.FromHtml("#262626");
                this.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.CaptionBarColor = ColorTranslator.FromHtml("#000000");
                this.CaptionForeColor = ColorTranslator.FromHtml("#f0f0f0");
                
                this.label1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label4.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.richTextBox.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.peoplepanel.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.homePanel.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.photoPanel.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.profilePanel.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.SettingsPanel.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.captionLabel1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");

                this.label1.BackColor = ColorTranslator.FromHtml("#262626");
                this.label2.BackColor = ColorTranslator.FromHtml("#262626");
                this.label3.BackColor = ColorTranslator.FromHtml("#262626");
                this.label4.BackColor = ColorTranslator.FromHtml("#262626");
                this.panel1.BackColor = ColorTranslator.FromHtml("#262626");
                this.panel2.BackColor = ColorTranslator.FromHtml("#262626");
                this.panel3.BackColor = ColorTranslator.FromHtml("#262626");
                this.panel4.BackColor = ColorTranslator.FromHtml("#262626");
                this.richTextBox.BackColor = ColorTranslator.FromHtml("#262626");
                this.peoplepanel.BackColor = ColorTranslator.FromHtml("#262626");
                this.homePanel.BackColor = ColorTranslator.FromHtml("#262626");
                this.photoPanel.BackColor = ColorTranslator.FromHtml("#262626");
                this.profilePanel.BackColor = ColorTranslator.FromHtml("#262626");
                this.SettingsPanel.BackColor = ColorTranslator.FromHtml("#262626");

                this.Apply.Appearance = ButtonAppearance.Office2016Black;
                this.Cancel.Appearance = ButtonAppearance.Office2016Black;
                this.rightPosition.Style = RadioButtonAdvStyle.Office2016Black;
                this.leftposition.Style = RadioButtonAdvStyle.Office2016Black;
                this.TopPosition.Style = RadioButtonAdvStyle.Office2016Black;
                this.BottomPosition.Style = RadioButtonAdvStyle.Office2016Black;
                this.SlideOnTop.Style = RadioButtonAdvStyle.Office2016Black;
                this.Push.Style = RadioButtonAdvStyle.Office2016Black;
                this.Reveal.Style = RadioButtonAdvStyle.Office2016Black;
                this.comboboxAdv1.Style = VisualStyle.Office2016Black;

                profile1.HeaderColor = ColorTranslator.FromHtml("#363636");
                profile2.HeaderColor = ColorTranslator.FromHtml("#363636");
                profile3.HeaderColor = ColorTranslator.FromHtml("#363636");
                profile4.HeaderColor = ColorTranslator.FromHtml("#363636");
                profile5.HeaderColor = ColorTranslator.FromHtml("#363636");
                profile6.HeaderColor = ColorTranslator.FromHtml("#363636");

                profile1.BackColor = ColorTranslator.FromHtml("#262626");
                profile2.BackColor = ColorTranslator.FromHtml("#262626");
                profile3.BackColor = ColorTranslator.FromHtml("#262626");
                profile4.BackColor = ColorTranslator.FromHtml("#262626");
                profile5.BackColor = ColorTranslator.FromHtml("#262626");
                profile6.BackColor = ColorTranslator.FromHtml("#262626");

                profile1.TextColor = ColorTranslator.FromHtml("#f0f0f0");
                profile2.TextColor = ColorTranslator.FromHtml("#f0f0f0");
                profile3.TextColor = ColorTranslator.FromHtml("#f0f0f0"); 
                profile4.TextColor = ColorTranslator.FromHtml("#f0f0f0");
                profile5.TextColor = ColorTranslator.FromHtml("#f0f0f0");
                profile6.TextColor = ColorTranslator.FromHtml("#f0f0f0");

                profile1.HeaderTextColor = ColorTranslator.FromHtml("#f0f0f0");
                profile2.HeaderTextColor = ColorTranslator.FromHtml("#f0f0f0");
                profile3.HeaderTextColor = ColorTranslator.FromHtml("#f0f0f0");
                profile4.HeaderTextColor = ColorTranslator.FromHtml("#f0f0f0");
                profile5.HeaderTextColor = ColorTranslator.FromHtml("#f0f0f0");
                profile6.HeaderTextColor = ColorTranslator.FromHtml("#f0f0f0");

                photpanelimage1.BannerColor = ColorTranslator.FromHtml("#363636");
                photpanelimage2.BannerColor = ColorTranslator.FromHtml("#363636");
                photpanelimage3.BannerColor = ColorTranslator.FromHtml("#363636");
                photpanelimage4.BannerColor = ColorTranslator.FromHtml("#363636");

                photpanelimage1.Banner.TextColor = ColorTranslator.FromHtml("#f0f0f0");
                photpanelimage2.Banner.TextColor = ColorTranslator.FromHtml("#f0f0f0");
                photpanelimage3.Banner.TextColor = ColorTranslator.FromHtml("#f0f0f0");
                photpanelimage4.Banner.TextColor = ColorTranslator.FromHtml("#f0f0f0");

                bigtile.HeaderColor = ColorTranslator.FromHtml("#363636");
                bigtile.BackColor = ColorTranslator.FromHtml("#363636");
                bigtile.TextColor = ColorTranslator.FromHtml("#f0f0f0");

                this.ShowIcon = false;
                this.BorderColor = ColorTranslator.FromHtml("#363636");
                this.MetroColor = ColorTranslator.FromHtml("#363636");
                this.CaptionButtonColor = ColorTranslator.FromHtml("#f0f0f0");
                this.SettingsPanel.BorderStyle = BorderStyle.FixedSingle;
                this.navigationDrawer1.DrawerPanelContainer.BorderStyle = BorderStyle.FixedSingle;

                captionSettingImage1.Image = global::NavigationDrawer_2010.Properties.Resources.Icon_Setting_Black;
                captionSettingImage1.BackColor = ColorTranslator.FromHtml("#000000");
                captionImage1.Image = global::NavigationDrawer_2010.Properties.Resources.Icon_menu_Black;
                captionImage1.Size = new Size(40, 40);
                captionImage1.Location = new Point(6, 14);
                captionImage1.BackColor = ColorTranslator.FromHtml("#000000");
            }
            else if (this.navigationDrawer1.Style == NavigationDrawerStyle.Office2016DarkGray)
            {
                this.BackColor = ColorTranslator.FromHtml("#666666");
                this.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.CaptionBarColor = ColorTranslator.FromHtml("#505050");
                this.CaptionForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label4.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.richTextBox.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.peoplepanel.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.homePanel.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.photoPanel.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.profilePanel.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.SettingsPanel.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.captionLabel1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");

                this.label1.BackColor = ColorTranslator.FromHtml("#666666");
                this.label2.BackColor = ColorTranslator.FromHtml("#666666");
                this.label3.BackColor = ColorTranslator.FromHtml("#666666");
                this.label4.BackColor = ColorTranslator.FromHtml("#666666");
                this.panel1.BackColor = ColorTranslator.FromHtml("#666666");
                this.panel2.BackColor = ColorTranslator.FromHtml("#666666");
                this.panel3.BackColor = ColorTranslator.FromHtml("#666666");
                this.panel4.BackColor = ColorTranslator.FromHtml("#666666");
                this.richTextBox.BackColor = ColorTranslator.FromHtml("#808080");
                this.peoplepanel.BackColor = ColorTranslator.FromHtml("#808080");
                this.homePanel.BackColor = ColorTranslator.FromHtml("#808080");
                this.photoPanel.BackColor = ColorTranslator.FromHtml("#808080");
                this.profilePanel.BackColor = ColorTranslator.FromHtml("#808080");
                this.SettingsPanel.BackColor = ColorTranslator.FromHtml("#666666");

                this.Apply.Appearance = ButtonAppearance.Office2016DarkGray;
                this.Cancel.Appearance = ButtonAppearance.Office2016DarkGray;
                this.Apply.ForeColor = ColorTranslator.FromHtml("#000000");
                this.Cancel.ForeColor = ColorTranslator.FromHtml("#000000");
                this.rightPosition.Style = RadioButtonAdvStyle.Office2016DarkGray;
                this.leftposition.Style = RadioButtonAdvStyle.Office2016DarkGray;
                this.TopPosition.Style = RadioButtonAdvStyle.Office2016DarkGray;
                this.BottomPosition.Style = RadioButtonAdvStyle.Office2016DarkGray;
                this.SlideOnTop.Style = RadioButtonAdvStyle.Office2016DarkGray;
                this.Push.Style = RadioButtonAdvStyle.Office2016DarkGray;
                this.Reveal.Style = RadioButtonAdvStyle.Office2016DarkGray;
                this.comboboxAdv1.Style = VisualStyle.Office2016DarkGray;

                profile1.BackColor= ColorTranslator.FromHtml("#666666");
                profile2.BackColor = ColorTranslator.FromHtml("#666666");
                profile3.BackColor = ColorTranslator.FromHtml("#666666");
                profile4.BackColor = ColorTranslator.FromHtml("#666666");
                profile5.BackColor = ColorTranslator.FromHtml("#666666");
                profile6.BackColor = ColorTranslator.FromHtml("#666666");

                profile1.TextColor = ColorTranslator.FromHtml("#f0f0f0");
                profile2.TextColor = ColorTranslator.FromHtml("#f0f0f0");
                profile3.TextColor = ColorTranslator.FromHtml("#f0f0f0");
                profile4.TextColor = ColorTranslator.FromHtml("#f0f0f0");
                profile5.TextColor = ColorTranslator.FromHtml("#f0f0f0");
                profile6.TextColor = ColorTranslator.FromHtml("#f0f0f0");

                profile1.HeaderTextColor = ColorTranslator.FromHtml("#f0f0f0");
                profile2.HeaderTextColor = ColorTranslator.FromHtml("#f0f0f0");
                profile3.HeaderTextColor = ColorTranslator.FromHtml("#f0f0f0");
                profile4.HeaderTextColor = ColorTranslator.FromHtml("#f0f0f0");
                profile5.HeaderTextColor = ColorTranslator.FromHtml("#f0f0f0");
                profile6.HeaderTextColor = ColorTranslator.FromHtml("#f0f0f0");

                profile1.HeaderColor = ColorTranslator.FromHtml("#505050");
                profile2.HeaderColor = ColorTranslator.FromHtml("#505050");
                profile3.HeaderColor = ColorTranslator.FromHtml("#505050");
                profile4.HeaderColor = ColorTranslator.FromHtml("#505050");
                profile5.HeaderColor = ColorTranslator.FromHtml("#505050");
                profile6.HeaderColor = ColorTranslator.FromHtml("#505050");

                photpanelimage1.BannerColor = ColorTranslator.FromHtml("#505050");
                photpanelimage2.BannerColor = ColorTranslator.FromHtml("#505050");
                photpanelimage3.BannerColor = ColorTranslator.FromHtml("#505050");
                photpanelimage4.BannerColor = ColorTranslator.FromHtml("#505050");

                photpanelimage1.Banner.TextColor = ColorTranslator.FromHtml("#f0f0f0");
                photpanelimage2.Banner.TextColor = ColorTranslator.FromHtml("#f0f0f0");
                photpanelimage3.Banner.TextColor = ColorTranslator.FromHtml("#f0f0f0");
                photpanelimage4.Banner.TextColor = ColorTranslator.FromHtml("#f0f0f0");

                bigtile.HeaderColor = ColorTranslator.FromHtml("#505050");
                bigtile.BackColor = ColorTranslator.FromHtml("#505050");
                bigtile.TextColor = ColorTranslator.FromHtml("#f0f0f0");

                this.CaptionButtonColor = ColorTranslator.FromHtml("#f0f0f0");
                this.MetroColor = ColorTranslator.FromHtml("#505050");
                this.ShowIcon = false;
                this.BorderColor = ColorTranslator.FromHtml("#444444");
                this.SettingsPanel.BorderStyle = BorderStyle.Fixed3D;
                this.navigationDrawer1.DrawerPanelContainer.BorderStyle = BorderStyle.FixedSingle;

                captionSettingImage1.Image = global::NavigationDrawer_2010.Properties.Resources.Icon_Setting_Darkgray;
                captionSettingImage1.BackColor = ColorTranslator.FromHtml("#505050");
                captionImage1.Image = global::NavigationDrawer_2010.Properties.Resources.Icon_menu_Darkgray;
                captionImage1.Size = new Size(40, 40);
                captionImage1.Location = new Point(6, 14);
                captionImage1.BackColor = ColorTranslator.FromHtml("#505050");
            }

            LockWindowUpdate(IntPtr.Zero);
        }
        #endregion


        TileControl profile1 = new TileControl();
        TileControl profile2 = new TileControl();
        TileControl profile3 = new TileControl();
        TileControl profile4 = new TileControl();
        TileControl profile5 = new TileControl();
        TileControl profile6 = new TileControl();
        HubTile photpanelimage1 = new HubTile();
        HubTile photpanelimage2 = new HubTile();
        HubTile photpanelimage3 = new HubTile();
        HubTile photpanelimage4 = new HubTile();
        

    }
}
