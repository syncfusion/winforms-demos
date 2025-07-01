#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
//#define console

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
using System.Xml;

using Syncfusion.Windows.Forms.Schedule;
using Syncfusion.Schedule;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using System.Xml.Serialization;
using DemoCommon.Grid;


namespace GridScheduleSample
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : GridDemoForm
    {
        #region API Definition
        private Syncfusion.Windows.Forms.Schedule.ScheduleControl scheduleControl1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.MenuItem menuItem16;
		private System.Windows.Forms.MenuItem menuItem17;
		private System.Windows.Forms.MenuItem menuItem18;
		private System.Windows.Forms.MenuItem menuItem20;
		private System.Windows.Forms.MenuItem menuItem21;
		private System.Windows.Forms.MenuItem menuItem22;
		private System.Windows.Forms.MenuItem menuItem23;
		private System.Windows.Forms.MenuItem menuItem24;
		private System.Windows.Forms.MenuItem menuItem25;
		private System.Windows.Forms.MenuItem menuItem26;
		private System.Windows.Forms.MenuItem menuItem27;
		private System.Windows.Forms.MenuItem menuItem28;
		private System.Windows.Forms.MenuItem menuItem29;
		private System.Windows.Forms.MenuItem menuItem30;
		private System.Windows.Forms.MenuItem menuItem31;
		private System.Windows.Forms.MenuItem menuItem32;
		private System.Windows.Forms.MenuItem menuItem33;
		private System.Windows.Forms.MenuItem menuItem34;
		private System.Windows.Forms.MenuItem menuItem35;
		private System.Windows.Forms.MenuItem menuItem36;
		private System.Windows.Forms.MenuItem menuItem37;
		private System.Windows.Forms.MenuItem menuItem38;
		private System.Windows.Forms.MenuItem menuItem39;
		private System.Windows.Forms.MenuItem menuItem40;
		private System.Windows.Forms.MenuItem menuItem19;
		private System.Windows.Forms.MenuItem menuItem41;
        private System.Windows.Forms.MenuItem menuItem42;
        private MenuItem menuItem43;
        private MenuItem menuItem44;
        private IContainer components;
        bool flag = false;
        #endregion

        #region Constructor
        public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
 
			//initialize the data somehow - specific to your implementation          

			ArrayListDataProvider scheduleProvider;
            string fileName = "default.XML";
            if (FindFile(ref fileName))
			{
                scheduleProvider = ArrayListDataProvider.LoadXML(fileName);
                scheduleProvider.FileName = fileName;
                OffSetSampleData(scheduleProvider);
                scheduleProvider.IsDirty = false;
			}
			else
			{
				scheduleProvider = new ArrayListDataProvider();
                scheduleProvider.MasterList = new ArrayListAppointmentList();
                scheduleProvider.FileName = "default.XML";
			}

            //Set the display date before setting the ScheduleType to avoid default current date being set.
            //bring up Nov 2006 since it has some appointments in the default.schedule file
            //this.scheduleControl1.Calendar.DateValue = new DateTime(2006, 11, 15);

            this.scheduleControl1.Calendar.DateValue = DateTime.Now;

            this.scheduleControl1.ScheduleType =  ScheduleViewType.Month;//ScheduleViewType.Day;//.WorkWeek;//.Week;//ScheduleViewType.WorkWeek;// ScheduleViewType.Day;//.WorkWeek;
			//set the data source
			this.scheduleControl1.DataSource = scheduleProvider;

			//subscribe to item click event
			this.scheduleControl1.ScheduleAppointmentClick += new ScheduleAppointmentClickEventHandler(scheduleControl1_ScheduleAppointmentClick);

			this.menuItem6.Popup += new EventHandler(menuItem6_Popup);

            // display Office2007Blue look
            this.scheduleControl1.Appearance.VisualStyle = GridVisualStyles.Office2007Blue;

            this.scheduleControl1.NavigationPanelFillWithCalendar = true;
            this.scheduleControl1.NavigationPanel.Width = (int)DpiAware.LogicalToDeviceUnits(160);
            this.scheduleControl1.Calendar.CalenderGrid.DpiAware = true;
            this.scheduleControl1.Calendar.CalenderGrid.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(15);
            this.scheduleControl1.GetScheduleHost().DpiAware = true;

		}
        #endregion

        #region Offset Time Settings
        /// <summary>
        /// Setting the Offset time for schedule control
        /// </summary>
        /// <param name="scheduleProvider">ArrayList data</param>
        private void OffSetSampleData(ArrayListDataProvider scheduleProvider)
        {
            if (scheduleProvider.MasterList.Count > 0 && scheduleProvider.MasterList[0].StartTime.Date == new DateTime(2006, 11, 3))
            {
                int offSet = ((TimeSpan)(DateTime.Now - new DateTime(2006, 11, 15))).Days;
                foreach (ScheduleAppointment item in scheduleProvider.MasterList)
                {
                    item.StartTime = item.StartTime.AddDays(offSet);
                    item.EndTime = item.EndTime.AddDays(offSet);
                }
                scheduleProvider.MasterList.SortStartTime();
            }
        }
        #endregion        

		#region Designer Stuffs
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.scheduleControl1 = new Syncfusion.Windows.Forms.Schedule.ScheduleControl();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem25 = new System.Windows.Forms.MenuItem();
            this.menuItem27 = new System.Windows.Forms.MenuItem();
            this.menuItem26 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.menuItem16 = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.menuItem19 = new System.Windows.Forms.MenuItem();
            this.menuItem41 = new System.Windows.Forms.MenuItem();
            this.menuItem42 = new System.Windows.Forms.MenuItem();
            this.menuItem18 = new System.Windows.Forms.MenuItem();
            this.menuItem32 = new System.Windows.Forms.MenuItem();
            this.menuItem33 = new System.Windows.Forms.MenuItem();
            this.menuItem34 = new System.Windows.Forms.MenuItem();
            this.menuItem35 = new System.Windows.Forms.MenuItem();
            this.menuItem36 = new System.Windows.Forms.MenuItem();
            this.menuItem37 = new System.Windows.Forms.MenuItem();
            this.menuItem22 = new System.Windows.Forms.MenuItem();
            this.menuItem29 = new System.Windows.Forms.MenuItem();
            this.menuItem30 = new System.Windows.Forms.MenuItem();
            this.menuItem31 = new System.Windows.Forms.MenuItem();
            this.menuItem28 = new System.Windows.Forms.MenuItem();
            this.menuItem38 = new System.Windows.Forms.MenuItem();
            this.menuItem39 = new System.Windows.Forms.MenuItem();
            this.menuItem40 = new System.Windows.Forms.MenuItem();
            this.menuItem20 = new System.Windows.Forms.MenuItem();
            this.menuItem44 = new System.Windows.Forms.MenuItem();
            this.menuItem21 = new System.Windows.Forms.MenuItem();
            this.menuItem43 = new System.Windows.Forms.MenuItem();
            this.menuItem23 = new System.Windows.Forms.MenuItem();
            this.menuItem24 = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // scheduleControl1
            // 
            this.scheduleControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scheduleControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(201)))), ((int)(((byte)(219)))));
            this.scheduleControl1.Culture = new System.Globalization.CultureInfo("");
            this.scheduleControl1.DataSource = null;
            this.scheduleControl1.ISO8601CalenderFormat = false;
            this.scheduleControl1.Location = new System.Drawing.Point(32, 24);
            this.scheduleControl1.Name = "scheduleControl1";
            this.scheduleControl1.NavigationPanelPosition = Syncfusion.Schedule.CalendarNavigationPanelPosition.Left;
            this.scheduleControl1.Size = new System.Drawing.Size(816, 581);
            this.scheduleControl1.TabIndex = 3;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem6,
            this.menuItem11,
            this.menuItem16,
            this.menuItem23});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem4,
            this.menuItem3,
            this.menuItem25,
            this.menuItem27,
            this.menuItem26,
            this.menuItem5});
            this.menuItem1.Text = "File";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "Open Calendar...";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.Text = "New Calendar...";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "Save Calendar";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem25
            // 
            this.menuItem25.Index = 3;
            this.menuItem25.Text = "Save Calendar as...";
            this.menuItem25.Click += new System.EventHandler(this.menuItem25_Click);
            // 
            // menuItem27
            // 
            this.menuItem27.Index = 4;
            this.menuItem27.Text = "Merge Calendar...";
            this.menuItem27.Click += new System.EventHandler(this.menuItem27_Click);
            // 
            // menuItem26
            // 
            this.menuItem26.Index = 5;
            this.menuItem26.Text = "Random Data";
            this.menuItem26.Click += new System.EventHandler(this.menuItem26_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 6;
            this.menuItem5.Text = "Exit";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 1;
            this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem7,
            this.menuItem8,
            this.menuItem9,
            this.menuItem10});
            this.menuItem6.Text = "Edit";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 0;
            this.menuItem7.Text = "New Item";
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 1;
            this.menuItem8.Text = "New AllDay Item";
            this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 2;
            this.menuItem9.Text = "Edit Item";
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 3;
            this.menuItem10.Text = "Delete Item";
            this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 2;
            this.menuItem11.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem12,
            this.menuItem13,
            this.menuItem14,
            this.menuItem15});
            this.menuItem11.Text = "View";
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 0;
            this.menuItem12.Text = "Day";
            this.menuItem12.Click += new System.EventHandler(this.menuItem12_Click);
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 1;
            this.menuItem13.Text = "Workweek";
            this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 2;
            this.menuItem14.Text = "Week";
            this.menuItem14.Click += new System.EventHandler(this.menuItem14_Click);
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 3;
            this.menuItem15.Text = "Month";
            this.menuItem15.Click += new System.EventHandler(this.menuItem15_Click);
            // 
            // menuItem16
            // 
            this.menuItem16.Index = 3;
            this.menuItem16.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem17,
            this.menuItem18,
            this.menuItem22,
            this.menuItem28,
            this.menuItem20,
            this.menuItem44,
            this.menuItem21,
            this.menuItem43});
            this.menuItem16.Text = "Options";
            // 
            // menuItem17
            // 
            this.menuItem17.Index = 0;
            this.menuItem17.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem19,
            this.menuItem41,
            this.menuItem42});
            this.menuItem17.Text = "Appearance...";
            // 
            // menuItem19
            // 
            this.menuItem19.Index = 0;
            this.menuItem19.Text = "Change...";
            this.menuItem19.Click += new System.EventHandler(this.menuItem19_Click);
            // 
            // menuItem41
            // 
            this.menuItem41.Index = 1;
            this.menuItem41.Text = "Load...";
            this.menuItem41.Click += new System.EventHandler(this.menuItem41_Click);
            // 
            // menuItem42
            // 
            this.menuItem42.Index = 2;
            this.menuItem42.Text = "Save...";
            this.menuItem42.Click += new System.EventHandler(this.menuItem42_Click);
            // 
            // menuItem18
            // 
            this.menuItem18.Index = 1;
            this.menuItem18.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem32,
            this.menuItem33,
            this.menuItem34,
            this.menuItem35,
            this.menuItem36,
            this.menuItem37});
            this.menuItem18.Text = "Culture";
            this.menuItem18.Popup += new System.EventHandler(this.menuItem18_Popup);
            // 
            // menuItem32
            // 
            this.menuItem32.Index = 0;
            this.menuItem32.Text = "Invariant";
            this.menuItem32.Click += new System.EventHandler(this.menuItem32_Click);
            // 
            // menuItem33
            // 
            this.menuItem33.Index = 1;
            this.menuItem33.Text = "Application";
            this.menuItem33.Click += new System.EventHandler(this.menuItem33_Click);
            // 
            // menuItem34
            // 
            this.menuItem34.Index = 2;
            this.menuItem34.Text = "fr-FR";
            this.menuItem34.Click += new System.EventHandler(this.menuItem34_Click);
            // 
            // menuItem35
            // 
            this.menuItem35.Index = 3;
            this.menuItem35.Text = "it-IT";
            this.menuItem35.Click += new System.EventHandler(this.menuItem35_Click);
            // 
            // menuItem36
            // 
            this.menuItem36.Index = 4;
            this.menuItem36.Text = "en-US";
            this.menuItem36.Click += new System.EventHandler(this.menuItem36_Click);
            // 
            // menuItem37
            // 
            this.menuItem37.Index = 5;
            this.menuItem37.Text = "de-DE";
            this.menuItem37.Click += new System.EventHandler(this.menuItem37_Click);
            // 
            // menuItem22
            // 
            this.menuItem22.Index = 2;
            this.menuItem22.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem29,
            this.menuItem30,
            this.menuItem31});
            this.menuItem22.Text = "Navigation Panel";
            this.menuItem22.Popup += new System.EventHandler(this.menuItem22_Popup);
            // 
            // menuItem29
            // 
            this.menuItem29.Index = 0;
            this.menuItem29.Text = "Hidden";
            this.menuItem29.Click += new System.EventHandler(this.menuItem29_Click);
            // 
            // menuItem30
            // 
            this.menuItem30.Index = 1;
            this.menuItem30.Text = "Left";
            this.menuItem30.Click += new System.EventHandler(this.menuItem30_Click);
            // 
            // menuItem31
            // 
            this.menuItem31.Index = 2;
            this.menuItem31.Text = "Right";
            this.menuItem31.Click += new System.EventHandler(this.menuItem31_Click);
            // 
            // menuItem28
            // 
            this.menuItem28.Index = 3;
            this.menuItem28.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem38,
            this.menuItem39,
            this.menuItem40});
            this.menuItem28.Text = "Save on Close";
            this.menuItem28.Popup += new System.EventHandler(this.menuItem28_Popup);
            // 
            // menuItem38
            // 
            this.menuItem38.Index = 0;
            this.menuItem38.Text = "Do Not Save";
            this.menuItem38.Click += new System.EventHandler(this.menuItem38_Click);
            // 
            // menuItem39
            // 
            this.menuItem39.Index = 1;
            this.menuItem39.Text = "Prompt Before Saving";
            this.menuItem39.Click += new System.EventHandler(this.menuItem39_Click);
            // 
            // menuItem40
            // 
            this.menuItem40.Index = 2;
            this.menuItem40.Text = "Save Without Prompt";
            this.menuItem40.Click += new System.EventHandler(this.menuItem40_Click);
            // 
            // menuItem20
            // 
            this.menuItem20.Checked = true;
            this.menuItem20.Index = 4;
            this.menuItem20.Text = "Week Numbers";
            this.menuItem20.Click += new System.EventHandler(this.menuItem20_Click);
            // 
            // menuItem44
            // 
            this.menuItem44.Index = 5;
            this.menuItem44.Text = "Alerts";
            this.menuItem44.Click += new System.EventHandler(this.menuItem44_Click);
            // 
            // menuItem21
            // 
            this.menuItem21.Index = 6;
            this.menuItem21.Text = "Additional Panel";
            this.menuItem21.Click += new System.EventHandler(this.menuItem21_Click);
            // 
            // menuItem43
            // 
            this.menuItem43.Index = 7;
            this.menuItem43.Text = "Test";
            this.menuItem43.Click += new System.EventHandler(this.menuItem43_Click);
            // 
            // menuItem23
            // 
            this.menuItem23.Index = 4;
            this.menuItem23.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem24});
            this.menuItem23.Text = "Help";
            // 
            // menuItem24
            // 
            this.menuItem24.Index = 0;
            this.menuItem24.Text = "About...";
            this.menuItem24.Click += new EventHandler(menuItem24_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 638);
            this.Controls.Add(this.scheduleControl1);
            this.Menu = this.mainMenu1;
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scheduler With Recurrence";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

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

        //overridden to close propertyForm if opened.
        protected override void OnClosing(CancelEventArgs e)
        {
            if (this.propertyForm != null)
            {
                this.propertyForm.Hide();
                propertyForm.AppearancePropertyGrid1.PropertyValueChanged -= new PropertyValueChangedEventHandler(AppearancePropertyGrid1_PropertyValueChanged);
                propertyForm.Closing -= new CancelEventHandler(propertyForm_Closing);
                propertyForm.Close();
            }
            if (flag)
                base.OnClosing(e);
        }
        //utility that looks for the file in the project folder up from the exe folder
        private bool FindFile(ref string fileName)
        {
            int i = 0;
            while (i < 4 && !File.Exists(fileName))
            {
                fileName = "..\\" + fileName;
                i++;
            }
            return File.Exists(fileName);
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
            //Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
		#endregion		   
 
        #region Events
        /// <summary>
        /// sample event handler to catch clicks on the schedule control.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">ScheduleAppointmentClickEventArgs</param>
		private void scheduleControl1_ScheduleAppointmentClick(object sender, ScheduleAppointmentClickEventArgs e)
		{
            flag = true;
			Console.WriteLine("scheduleControl1_ScheduleAppointmentClick: {0} {1}", e.ClickType, e.ClickDateTime);
		}
        #endregion

        #region Utility methods
        /// <summary>
        /// Save the changes if needed
        /// </summary>
        /// <param name="prompt">To check whether save needed</param>
        void CheckAndSaveIfNeeded(bool prompt)
		{
			string name = ((ArrayListDataProvider)this.scheduleControl1.DataSource).FileName;
			int i = name.LastIndexOf('\\');
			if(i > -1)
				name = name.Substring(i + 1);
			if(this.scheduleControl1.DataSource.IsDirty 
				&& (!prompt || MessageBox.Show("Save changes?", name + " changed.", MessageBoxButtons.YesNo) 
				== DialogResult.Yes))
			{
				this.scheduleControl1.DataSource.CommitChanges();
			}
		}

		#endregion
		
		#region Menu handlers
		
		#region File Menu

		#region file|open calendar
		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			CheckAndSaveIfNeeded(true);

			OpenFileDialog dlg = new OpenFileDialog(); 
			dlg.Title = "Open Schedule file" ; 
			dlg.InitialDirectory = Environment.CurrentDirectory;
            dlg.Filter = "Schedule XML files (*.XML)|*.XML|Schedule files (*.schedule)|*.schedule|All files (*.*)|*.*"; 
		 
			if(dlg.ShowDialog() == DialogResult.OK) 
			{ 
				try
				{
                    if (dlg.FileName.ToUpper().EndsWith(".XML"))
                    {
                        this.scheduleControl1.DataSource = ArrayListDataProvider.LoadXML(dlg.FileName);
                        ((ArrayListDataProvider)this.scheduleControl1.DataSource).FileName = dlg.FileName;
                    }
                    else
                    {
                        this.scheduleControl1.DataSource = ArrayListDataProvider.LoadBinary(dlg.FileName);
                        ((ArrayListDataProvider)this.scheduleControl1.DataSource).FileName = dlg.FileName;
                    }
                    this.scheduleControl1.DataSource.IsDirty = false;
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			} 
		}
		#endregion

		#region file|save calendar
		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			if(((ArrayListDataProvider)this.scheduleControl1.DataSource).FileName 
				== "newScheduleFile.XML")
			{
				//do a saveas for new file
				this.menuItem25.PerformClick();
			}
			else
			{			
				CheckAndSaveIfNeeded(false);
			}
		}

		#endregion

		#region file|new calendar
		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			CheckAndSaveIfNeeded(true);

			ArrayListDataProvider scheduleProvider = new ArrayListDataProvider();
            scheduleProvider.MasterList = new ArrayListAppointmentList();
			scheduleProvider.FileName = "newScheduleFile.XML";
			scheduleProvider.IsDirty = true;
			this.scheduleControl1.DataSource = scheduleProvider;
			
		}

		#endregion

		#region File|Random data...
		private void menuItem26_Click(object sender, System.EventArgs e)
		{
			CheckAndSaveIfNeeded(true);

			ArrayListDataProvider dataProvider = new ArrayListDataProvider();
			dataProvider.MasterList	= ArrayListDataProvider.InitializeRandomData();
			dataProvider.FileName = "random.XML";

			this.scheduleControl1.DataSource = dataProvider;
		}

		#endregion

		#region File|SaveAs
		private void menuItem25_Click(object sender, System.EventArgs e)
		{
			SaveFileDialog saveFile = new SaveFileDialog();
			saveFile.DefaultExt = "*.XML";
			saveFile.FileName = ((ArrayListDataProvider)this.scheduleControl1.DataSource).FileName;
            saveFile.Filter = "Schedule XML Files|*.XML|Schedule Files|*.schedule";

			// get a file name from the user
			if(saveFile.ShowDialog() == DialogResult.OK)
			{
				try
				{
                    if (saveFile.FileName.ToUpper().EndsWith(".XML"))
                    {
                        ((ArrayListDataProvider)this.scheduleControl1.DataSource).SaveXML(saveFile.FileName);
                    }
                    else
                    {
                        ((ArrayListDataProvider)this.scheduleControl1.DataSource).SaveBinary(saveFile.FileName);
                    }
                    this.scheduleControl1.DataSource.IsDirty = false;
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}	
		}

		#endregion

		#region File|Merge
		private void menuItem27_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog(); 
			dlg.Title = "Merge Schedule file"; 
			dlg.InitialDirectory = Environment.CurrentDirectory;
            dlg.Filter = "Schedule XML files (*.XML)|*.XML|Schedule files (*.schedule)|*.schedule|All files (*.*)|*.*"; 
		 
			if(dlg.ShowDialog() == DialogResult.OK) 
			{ 
				try
				{
					ArrayListDataProvider mergeProvider = ArrayListDataProvider.LoadBinary(dlg.FileName);
					ArrayListDataProvider dataProvider = this.scheduleControl1.DataSource as ArrayListDataProvider;
					this.scheduleControl1.Calendar.BeginUpdate();
					foreach(ArrayListAppointment item in mergeProvider.MasterList)
					{
						dataProvider.AddItem(item);
					}
					dataProvider.MasterList.SortStartTime();
					this.scheduleControl1.Calendar.EndUpdate();
					this.scheduleControl1.ResetProvider(this.scheduleControl1.ScheduleType);
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			} 
		}
		#endregion

		#region file|exit
		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			CheckAndSaveIfNeeded(true);
			this.Close();
		}

		#endregion
		#endregion

		#region Edit Menu
		 
		#region handle enabling menus

		private void menuItem6_Popup(object sender, EventArgs e)
		{
			//enable or disable the menu item depending upon a 
			//selected schedule item like Edit and Delete
			this.menuItem9.Enabled = this.scheduleControl1.ItemSelected;
			this.menuItem10.Enabled = this.scheduleControl1.ItemSelected;
		}

		#endregion

		#region Edit|NewItem
		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			this.scheduleControl1.PerformNewItemClick();
		}

		#endregion

		#region Edit New AllDay Item
		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			this.scheduleControl1.PerformNewAllDayItemClick();
		}

		#endregion

		#region Edit|Edit Item
		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			this.scheduleControl1.PerformEditItemClick();
		}

		#endregion

		#region Edit|Delete Item
		private void menuItem10_Click(object sender, System.EventArgs e)
		{
			this.scheduleControl1.PerformDeleteItemClick();
		}

		#endregion

		#endregion

		#region View Menu

		#region View|Day
		private void menuItem12_Click(object sender, System.EventArgs e)
		{
			if(this.scheduleControl1.ScheduleType != ScheduleViewType.Day)
				this.scheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.Day);
		}

		#endregion

		#region View|WorkWeek
		private void menuItem13_Click(object sender, System.EventArgs e)
		{
			if(this.scheduleControl1.ScheduleType != ScheduleViewType.WorkWeek)
				this.scheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.WorkWeek);	
		}
		#endregion

		#region View|Week
		private void menuItem14_Click(object sender, System.EventArgs e)
		{
			if(this.scheduleControl1.ScheduleType != ScheduleViewType.Week)
				this.scheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.Week);
		}
		#endregion

		#region View|Month

		private void menuItem15_Click(object sender, System.EventArgs e)
		{
			if(this.scheduleControl1.ScheduleType != ScheduleViewType.Month)
				this.scheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.Month);
		}
		#endregion

		#endregion

		#region Options Menu

		#region Options | Appearance

		PropertyGridForm propertyForm = null;
		//Options|Appearance|Edit
		private void menuItem19_Click(object sender, System.EventArgs e)
		{
			if(propertyForm == null)
			{
				propertyForm = new PropertyGridForm();
				propertyForm.Closing += new CancelEventHandler(propertyForm_Closing);
				propertyForm.AppearancePropertyGrid1.SelectedObject = this.scheduleControl1.Appearance;
				propertyForm.AppearancePropertyGrid1.PropertyValueChanged += new PropertyValueChangedEventHandler(AppearancePropertyGrid1_PropertyValueChanged);
			}
			if(!propertyForm.Visible)
				propertyForm.Show();
		}
		private void propertyForm_Closing(object sender, CancelEventArgs e)
		{
			propertyForm.Hide();
			e.Cancel = true;
		}
		private void AppearancePropertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
		{
		
			e.ChangedItem.PropertyDescriptor.SetValue(this.scheduleControl1.Appearance, e.ChangedItem.Value);
			this.scheduleControl1.Refresh();
		}
	 
		//Options|Appearance|Load
		private void menuItem41_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog(); 
			dlg.Title = "Open Appearance file" ; 
			dlg.InitialDirectory = Environment.CurrentDirectory;
            dlg.Filter = "Appearance files (*.appearance)|*.appearance|Appearance XML files (*.appearance.xml)|*.appearance.xml|All files(*.*)|*.*"; 
		 
			if(dlg.ShowDialog() == DialogResult.OK) 
			{ 
				try
				{
                    ScheduleAppearance appearance = null;
                    if (dlg.FileName.ToLower().EndsWith(".xml"))
                    {
                        appearance = ScheduleAppearance.LoadXML(dlg.FileName);
                    }
                    else
                    {
                        appearance = ScheduleAppearance.LoadBinary(dlg.FileName);
                    }
                    appearance.AttachSchedule(this.scheduleControl1);
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			} 
		}
		//Options|Appearance|Save
		private void menuItem42_Click(object sender, System.EventArgs e)
		{
			SaveFileDialog saveFile = new SaveFileDialog();
			saveFile.DefaultExt = "*.appearance";
			saveFile.FileName = "";
            saveFile.Filter = "Appearance files|*.appearance|Appearance XML files|*.appearance.xml";

			// get a file name from the user
			if(saveFile.ShowDialog() == DialogResult.OK)
			{
				try
				{
                    if (saveFile.FileName.ToLower().EndsWith(".xml"))
                    {
                        this.scheduleControl1.Appearance.SaveXML(saveFile.FileName);
                    }
                    else
                    {
                        this.scheduleControl1.Appearance.SaveBinary(saveFile.FileName);
                    }
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}	
		}
	 
		#endregion
		
		#region  Options|Week Numbers
		private void menuItem20_Click(object sender, System.EventArgs e)
		{
			this.scheduleControl1.Calendar.ShowWeekNumbers = ! this.scheduleControl1.Calendar.ShowWeekNumbers;
			this.menuItem20.Checked = this.scheduleControl1.Calendar.ShowWeekNumbers;
		}

		#endregion

		#region  Options|Show Additional Panel
		Panel p;
		private void menuItem21_Click(object sender, System.EventArgs e)
		{
			this.menuItem21.Checked = ! this.menuItem21.Checked;
			if(this.menuItem21.Checked)
			{
				p = new Panel();
				p.BackColor = Color.Blue;
				p.Dock = DockStyle.Fill;
				this.scheduleControl1.NavigationPanel.Controls.Add(p);
			}
			else
			{
				this.scheduleControl1.NavigationPanel.Controls.Remove(p);
				p.Dispose();
				p = null;
			}
		}

		#region Options|NavigationPanel

		private void menuItem22_Popup(object sender, System.EventArgs e)
		{
			menuItem29.Checked = false;
			menuItem30.Checked = false;
			menuItem31.Checked = false;
			switch(this.scheduleControl1.NavigationPanelPosition)
			{
				case CalendarNavigationPanelPosition.Hidden:
					menuItem29.Checked = true;
					break;
				case CalendarNavigationPanelPosition.Left:
					menuItem30.Checked = true;
					break;
				case CalendarNavigationPanelPosition.Right:
					menuItem31.Checked = true;
					break;
			}
		}


		//Options|NavigationPanel|Hidden
		private void menuItem29_Click(object sender, System.EventArgs e)
		{
			this.scheduleControl1.SetNavigationPanelPosition(CalendarNavigationPanelPosition.Hidden);
		}
		//Options|NavigationPanel|Left
		private void menuItem30_Click(object sender, System.EventArgs e)
		{
			this.scheduleControl1.SetNavigationPanelPosition(CalendarNavigationPanelPosition.Left);
		}
		//Options|NavigationPanel|Right
		private void menuItem31_Click(object sender, System.EventArgs e)
		{
			this.scheduleControl1.SetNavigationPanelPosition(CalendarNavigationPanelPosition.Right);
		}

		#endregion

        #region Options|Alerts
        private void menuItem44_Click(object sender, EventArgs e)
        {
            this.scheduleControl1.EnableAlerts = !this.scheduleControl1.EnableAlerts;
            this.menuItem44.Checked = this.scheduleControl1.EnableAlerts;

            // change the look of the AlertWindow....
//            if (this.scheduleControl1.EnableAlerts)
//            {
//                this.scheduleControl1.AlertWindow.BackColor = Color.FromArgb(240, 240, 255);
//                this.scheduleControl1.AlertWindow.Grid.TableStyle.BackColor = Color.FromArgb(100, 240, 240, 255);
//                this.scheduleControl1.AlertWindow.Grid.Properties.BackgroundColor = Color.FromArgb(100, Color.Blue);
//                Syncfusion.Windows.Forms.Grid.GridStyleInfo headerStyle =
//                   this.scheduleControl1.AlertWindow.Grid.BaseStylesMap["Header"].StyleInfo;
//                headerStyle.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, Color.Blue, Color.White);
//                this.scheduleControl1.AlertWindow.Grid.Refresh();
//            }
        }
        #endregion

        #region Options|Culture
        //set checks on popup
		private void menuItem18_Popup(object sender, System.EventArgs e)
		{
			menuItem32.Checked = false;
			menuItem33.Checked = false;
			menuItem34.Checked = false;
			menuItem35.Checked = false;
			menuItem36.Checked = false;
			menuItem37.Checked = false;

			if(this.scheduleControl1.Culture.DisplayName == CultureInfo.InvariantCulture.DisplayName)
			{
				menuItem32.Checked = true;
			}
			else if(this.scheduleControl1.Culture.Name == Application.CurrentCulture.Name)
			{
				menuItem33.Checked = true;
			}
			
			if(this.scheduleControl1.Culture.Name == "fr-FR")
			{
				menuItem34.Checked = true;
			}
			else if(this.scheduleControl1.Culture.Name == "it-IT")
			{
				menuItem35.Checked = true;
			}
			else if(this.scheduleControl1.Culture.Name == "en-US")
			{
				menuItem36.Checked = true;
			}
			else if(this.scheduleControl1.Culture.Name == "de-DE")
			{
				menuItem37.Checked = true;
			}
		}

		//Options|Culture|Invariant
		private void menuItem32_Click(object sender, System.EventArgs e)
		{
			this.scheduleControl1.Culture = CultureInfo.InvariantCulture;
		}

		//Options|Culture|Application
		private void menuItem33_Click(object sender, System.EventArgs e)
		{
			this.scheduleControl1.Culture = Application.CurrentCulture;
		}

		//Options|Culture|IT
		private void menuItem34_Click(object sender, System.EventArgs e)
		{
			this.scheduleControl1.Culture = CultureInfo.CreateSpecificCulture("fr-FR");
		}

		//Options|Culture|FR
		private void menuItem35_Click(object sender, System.EventArgs e)
		{
			this.scheduleControl1.Culture = CultureInfo.CreateSpecificCulture("it-IT");
		}

		//Options|Culture|US
		private void menuItem36_Click(object sender, System.EventArgs e)
		{
			this.scheduleControl1.Culture = CultureInfo.CreateSpecificCulture("en-US");
		}
		//Options|Culture|DE
		private void menuItem37_Click(object sender, System.EventArgs e)
		{
			this.scheduleControl1.Culture = CultureInfo.CreateSpecificCulture("de-DE");
		}
		#endregion

		#region Options | Save On Close Behavior

		//display check
		private void menuItem28_Popup(object sender, System.EventArgs e)
		{
			menuItem38.Checked = false;
			menuItem39.Checked = false;
			menuItem40.Checked = false;
			switch(this.scheduleControl1.DataSource.SaveOnCloseBehaviorAction)
			{
				case SaveOnCloseBehavior.DoNotSave:
					menuItem38.Checked = true;
					break;
				case SaveOnCloseBehavior.PromptBeforeSave:
					menuItem39.Checked = true;
					break;
				case SaveOnCloseBehavior.SaveWithoutPrompt:
					menuItem40.Checked = true;
					break;
			}
		}

		//Options|SaveOnCloseBehavior|Do Not Save
		private void menuItem38_Click(object sender, System.EventArgs e)
		{
			this.scheduleControl1.DataSource.SaveOnCloseBehaviorAction = SaveOnCloseBehavior.DoNotSave;
		}
		//Options|SaveOnCloseBehavior|Propmt Before Saving
		private void menuItem39_Click(object sender, System.EventArgs e)
		{
			this.scheduleControl1.DataSource.SaveOnCloseBehaviorAction = SaveOnCloseBehavior.PromptBeforeSave;
		}
		//Options|SaveOnCloseBehavior|Save Without Prompt
		private void menuItem40_Click(object sender, System.EventArgs e)
		{
			this.scheduleControl1.DataSource.SaveOnCloseBehaviorAction = SaveOnCloseBehavior.SaveWithoutPrompt;
		}
		#endregion


        //used for testing 
        private void menuItem43_Click(object sender, EventArgs e)
        {

            this.scheduleControl1.NavigationPanelFillWithCalendar = true;

             //change the look of the AlertWindow....
            this.scheduleControl1.AlertWindow.BackColor = Color.FromArgb(240, 240, 255);
            this.scheduleControl1.AlertWindow.Grid.TableStyle.BackColor = Color.FromArgb(100, 240, 240, 255);
            this.scheduleControl1.AlertWindow.Grid.Properties.BackgroundColor = Color.FromArgb(100, Color.Blue);
            Syncfusion.Windows.Forms.Grid.GridStyleInfo headerStyle =
               this.scheduleControl1.AlertWindow.Grid.BaseStylesMap["Header"].StyleInfo;
            headerStyle.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, Color.Blue, Color.White);
            this.scheduleControl1.AlertWindow.Grid.Refresh();
            MessageBox.Show("Test process successed"); 
        }


        void menuItem24_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Syncfusion Essential Schedule is a Windows Forms class library \n built around the functionality that is found in the Windows Forms Grid control.\nThe control allows you to add scheduling support to your applications.\nThe scheduling support includes creating new appointments, displaying these appointments in a variety of views, \nincluding Monthly, Daily, Weekly, Work Week and multiple days. In the daily formats, you can use the UI to drag appointments to another time slot and to extend appointments. \nA flexible navigation calendar lets you easily home in on the dates you would like to see in the Schedule control.");
        }

        void Options_OptionsChanged(object sender, EventArgs e)
        {
            throw new Exception("The method or operation is not implemented.");
        }



		#endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

		
	
		#endregion

	    #endregion
	}	
}



