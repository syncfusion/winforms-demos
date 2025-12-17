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

using Syncfusion.Windows.Forms.Schedule;
using Syncfusion.Schedule;
using System.Collections.Specialized;
using MDB_ScheduleSample_CS;
using Syncfusion.Windows.Forms;
using Syncfusion.GridHelperClasses;

namespace GridScheduleSample
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
    {
        #region API Definition
        private Syncfusion.Windows.Forms.Schedule.ScheduleControl scheduleControl1;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv6;
        private Label label1;
        private Panel panel1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv4;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv3;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
        private Panel panel2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv5;
        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveCalendarToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem mergeCalendarAsToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem newItemToolStripMenuItem;
        private ToolStripMenuItem newAllDayItemToolStripMenuItem;
        private ToolStripMenuItem editItemToolStripMenuItem;
        private ToolStripMenuItem deleteItemToolStripMenuItem;
        private ToolStripMenuItem randomDataToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip3;
        private ToolStripMenuItem dayToolStripMenuItem;
        private ToolStripMenuItem workWeekToolStripMenuItem;
        private ToolStripMenuItem weekToolStripMenuItem;
        private ToolStripMenuItem monthToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip4;
        private ToolStripMenuItem appearanceToolStripMenuItem;
        private ToolStripMenuItem changeToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem1;
        private ToolStripMenuItem cultureToolStripMenuItem;
        private ToolStripMenuItem invariantToolStripMenuItem;
        private ToolStripMenuItem applicationToolStripMenuItem;
        private ToolStripMenuItem frIRToolStripMenuItem;
        private ToolStripMenuItem itITToolStripMenuItem;
        private ToolStripMenuItem enUSToolStripMenuItem;
        private ToolStripMenuItem deDEToolStripMenuItem;
        private ToolStripMenuItem navigationPanelToolStripMenuItem;
        private ToolStripMenuItem hiddenToolStripMenuItem;
        private ToolStripMenuItem leftToolStripMenuItem;
        private ToolStripMenuItem rightToolStripMenuItem;
        private ToolStripMenuItem saveOnCloseToolStripMenuItem;
        private ToolStripMenuItem doNotSaveToolStripMenuItem;
        private ToolStripMenuItem promptBeforSavingToolStripMenuItem;
        private ToolStripMenuItem saveWithoutPromptToolStripMenuItem;
        private ToolStripMenuItem weekNumbersToolStripMenuItem;
        private ToolStripMenuItem alertsToolStripMenuItem;
        private ToolStripMenuItem additionalPanelToolStripMenuItem;
        private ToolStripMenuItem testsToolStripMenuItem;
        private PictureBox pictureBox2;
        private IContainer components;
        #endregion

        #region Constructor
        public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            pictureBox1.Image = new Bitmap("..\\..\\menu.png");
            pictureBox1.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            
            pictureBox1.MouseMove += new MouseEventHandler(pictureBox1_MouseMove);


            pictureBox2.Image = new Bitmap("..\\..\\climate.png");

            SimpleScheduleDataProvider scheduleProvider;

            string fileName = "default.schedule";
            if (FindFile(ref fileName))
            {
                scheduleProvider = SimpleScheduleDataProvider.LoadBinary(fileName);
                scheduleProvider.FileName = fileName;
            }
            else
            {
                scheduleProvider = new SimpleScheduleDataProvider();
                scheduleProvider.MasterList = new SimpleScheduleAppointmentList();
                scheduleProvider.FileName = "default.schedule";
            }

			this.scheduleControl1.ScheduleType =  ScheduleViewType.Month;
            scheduleControl1.DataSource = scheduleProvider;
            scheduleControl1.Appearance.VisualStyle = Syncfusion.Windows.Forms.GridVisualStyles.Metro;

            SimpleScheduleDataProvider dataProvider = new SimpleScheduleDataProvider();
            dataProvider.MasterList = SimpleScheduleDataProvider.InitializeRandomData();
            scheduleControl1.DataSource = dataProvider;

            foreach (ScheduleAppointment sc in dataProvider.MasterList)
            {
                sc.ReminderText = dataProvider.GetReminders()[sc.ReminderValue].DisplayMember;
            }

            //propertyEditor1.

            StringCollection ar = new StringCollection();
            ar.Add("Schedule Provider");
            ar.Add("DataBase");
            comboBoxAdv5.DataSource = ar;

			//subscibe to item click event
			this.scheduleControl1.ScheduleAppointmentClick += new ScheduleAppointmentClickEventHandler(scheduleControl1_ScheduleAppointmentClick);
            this.scheduleControl1.Appearance.EnableAdvancedToolTip = true;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"Windows\common\Images\Grid\Icon\sficon.ico"));
                this.Icon = ico;
            }
            catch { }
            ToolTip();
            this.pictureBox1.MouseHover += new EventHandler(pictureBox1_MouseHover);
            this.pictureBox1.MouseLeave += new EventHandler(pictureBox1_MouseLeave);
            this.scheduleControl1.Calendar.CalenderGrid.DpiAware = true;

            this.scheduleControl1.NavigationPanelFillWithCalendar = true;
            this.scheduleControl1.NavigationPanel.Width = (int)DpiAware.LogicalToDeviceUnits(180);
            this.scheduleControl1.Calendar.CalenderGrid.DpiAware = true;
            this.scheduleControl1.Calendar.CalenderGrid.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(15);
            this.scheduleControl1.GetScheduleHost().DpiAware = true;
        }
        #endregion             

        #region ToolTip
        /// <summary>
        /// Showing the tooltip on appointments
        /// </summary>
        private void ToolTip()
        {
            ToolTipControl control = new ToolTipControl();
            
            AdvancedToolTip userToolTip = new AdvancedToolTip(control,pictureBox2);
            //userToolTip.FocusOnOpen = true;
            userToolTip.AnimationDuration = 0;
            userToolTip.ShowingAnimation = ToolTipAnimations.RightToLeft | ToolTipAnimations.Blend;
            userToolTip.ArrowHeadDirection = ArrowHeadDirection.Top;
            userToolTip.DropShadowEnabled = false;
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
            this.buttonAdv6 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxAdv4 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBoxAdv3 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBoxAdv2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxAdv5 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCalendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeCalendarAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAllDayItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workWeekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.appearanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cultureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invariantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deDEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigationPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiddenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveOnCloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doNotSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promptBeforSavingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWithoutPromptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weekNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alertsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.additionalPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.contextMenuStrip4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // scheduleControl1
            // 
            this.scheduleControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.scheduleControl1.BackColor = System.Drawing.Color.Gray;
            this.scheduleControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scheduleControl1.Culture = new System.Globalization.CultureInfo("");
            this.scheduleControl1.DataSource = null;
            this.scheduleControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.scheduleControl1.ISO8601CalenderFormat = false;
            this.scheduleControl1.Location = new System.Drawing.Point(6, 3);
            this.scheduleControl1.Name = "scheduleControl1";
            this.scheduleControl1.NavigationPanelPosition = Syncfusion.Schedule.CalendarNavigationPanelPosition.Left;
            this.scheduleControl1.ShowRoundedCorners = true;
            this.scheduleControl1.Size = new System.Drawing.Size(963, 445);
            this.scheduleControl1.TabIndex = 3;
            // 
            // buttonAdv6
            // 
            this.buttonAdv6.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonAdv6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv6.ForeColor = System.Drawing.Color.White;
            this.buttonAdv6.Location = new System.Drawing.Point(217, 30);
            this.buttonAdv6.Name = "buttonAdv6";
            this.buttonAdv6.Size = new System.Drawing.Size(84, 25);
            this.buttonAdv6.TabIndex = 10;
            this.buttonAdv6.Text = "Load";
            this.buttonAdv6.UseVisualStyle = true;
            this.buttonAdv6.Click += new System.EventHandler(this.buttonAdv6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(2, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Choose Data Source";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.scheduleControl1);
            this.panel1.Location = new System.Drawing.Point(12, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 448);
            this.panel1.TabIndex = 13;
            // 
            // comboBoxAdv4
            // 
            this.comboBoxAdv4.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv4.Location = new System.Drawing.Point(10, 26);
            this.comboBoxAdv4.Name = "comboBoxAdv4";
            this.comboBoxAdv4.Size = new System.Drawing.Size(119, 21);
            this.comboBoxAdv4.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv4.TabIndex = 19;
            // 
            // comboBoxAdv3
            // 
            this.comboBoxAdv3.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv3.Location = new System.Drawing.Point(6, 26);
            this.comboBoxAdv3.Name = "comboBoxAdv3";
            this.comboBoxAdv3.Size = new System.Drawing.Size(119, 21);
            this.comboBoxAdv3.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv3.TabIndex = 19;
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.Location = new System.Drawing.Point(13, 28);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(119, 21);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv1.TabIndex = 18;
            // 
            // comboBoxAdv2
            // 
            this.comboBoxAdv2.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv2.Location = new System.Drawing.Point(10, 28);
            this.comboBoxAdv2.Name = "comboBoxAdv2";
            this.comboBoxAdv2.Size = new System.Drawing.Size(119, 21);
            this.comboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv2.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.comboBoxAdv5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonAdv6);
            this.panel2.Location = new System.Drawing.Point(12, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(972, 62);
            this.panel2.TabIndex = 26;
            // 
            // comboBoxAdv5
            // 
            this.comboBoxAdv5.AllowNewText = false;
            this.comboBoxAdv5.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.comboBoxAdv5.Location = new System.Drawing.Point(6, 34);
            this.comboBoxAdv5.Name = "comboBoxAdv5";
            this.comboBoxAdv5.Size = new System.Drawing.Size(188, 21);
            this.comboBoxAdv5.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv5.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 37);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveCalendarToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.mergeCalendarAsToolStripMenuItem,
            this.randomDataToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(175, 158);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.newToolStripMenuItem.Text = "New Calendar";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.openToolStripMenuItem.Text = "Open Calendar";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveCalendarToolStripMenuItem
            // 
            this.saveCalendarToolStripMenuItem.Name = "saveCalendarToolStripMenuItem";
            this.saveCalendarToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.saveCalendarToolStripMenuItem.Text = "Save Calendar";
            this.saveCalendarToolStripMenuItem.Click += new System.EventHandler(this.saveCalendarToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.saveToolStripMenuItem.Text = "Save Calendar As";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // mergeCalendarAsToolStripMenuItem
            // 
            this.mergeCalendarAsToolStripMenuItem.Name = "mergeCalendarAsToolStripMenuItem";
            this.mergeCalendarAsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.mergeCalendarAsToolStripMenuItem.Text = "Merge Calendar As";
            this.mergeCalendarAsToolStripMenuItem.Click += new System.EventHandler(this.mergeCalendarAsToolStripMenuItem_Click);
            // 
            // randomDataToolStripMenuItem
            // 
            this.randomDataToolStripMenuItem.Name = "randomDataToolStripMenuItem";
            this.randomDataToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.randomDataToolStripMenuItem.Text = "Random Data";
            this.randomDataToolStripMenuItem.Click += new System.EventHandler(this.randomDataToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newItemToolStripMenuItem,
            this.newAllDayItemToolStripMenuItem,
            this.editItemToolStripMenuItem,
            this.deleteItemToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(166, 92);
            // 
            // newItemToolStripMenuItem
            // 
            this.newItemToolStripMenuItem.Name = "newItemToolStripMenuItem";
            this.newItemToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.newItemToolStripMenuItem.Text = "New Item";
            this.newItemToolStripMenuItem.Click += new System.EventHandler(this.newItemToolStripMenuItem_Click);
            // 
            // newAllDayItemToolStripMenuItem
            // 
            this.newAllDayItemToolStripMenuItem.Name = "newAllDayItemToolStripMenuItem";
            this.newAllDayItemToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.newAllDayItemToolStripMenuItem.Text = "New All Day Item";
            this.newAllDayItemToolStripMenuItem.Click += new System.EventHandler(this.newAllDayItemToolStripMenuItem_Click);
            // 
            // editItemToolStripMenuItem
            // 
            this.editItemToolStripMenuItem.Name = "editItemToolStripMenuItem";
            this.editItemToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.editItemToolStripMenuItem.Text = "Edit Item";
            this.editItemToolStripMenuItem.Click += new System.EventHandler(this.editItemToolStripMenuItem_Click);
            // 
            // deleteItemToolStripMenuItem
            // 
            this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.deleteItemToolStripMenuItem.Text = "Delete Item";
            this.deleteItemToolStripMenuItem.Click += new System.EventHandler(this.deleteItemToolStripMenuItem_Click);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dayToolStripMenuItem,
            this.workWeekToolStripMenuItem,
            this.weekToolStripMenuItem,
            this.monthToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(135, 92);
            // 
            // dayToolStripMenuItem
            // 
            this.dayToolStripMenuItem.Name = "dayToolStripMenuItem";
            this.dayToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.dayToolStripMenuItem.Text = "Day";
            this.dayToolStripMenuItem.Click += new System.EventHandler(this.dayToolStripMenuItem_Click);
            // 
            // workWeekToolStripMenuItem
            // 
            this.workWeekToolStripMenuItem.Name = "workWeekToolStripMenuItem";
            this.workWeekToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.workWeekToolStripMenuItem.Text = "Work Week";
            this.workWeekToolStripMenuItem.Click += new System.EventHandler(this.workWeekToolStripMenuItem_Click);
            // 
            // weekToolStripMenuItem
            // 
            this.weekToolStripMenuItem.Name = "weekToolStripMenuItem";
            this.weekToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.weekToolStripMenuItem.Text = "Week";
            this.weekToolStripMenuItem.Click += new System.EventHandler(this.weekToolStripMenuItem_Click);
            // 
            // monthToolStripMenuItem
            // 
            this.monthToolStripMenuItem.Name = "monthToolStripMenuItem";
            this.monthToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.monthToolStripMenuItem.Text = "Month";
            this.monthToolStripMenuItem.Click += new System.EventHandler(this.monthToolStripMenuItem_Click);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appearanceToolStripMenuItem,
            this.cultureToolStripMenuItem,
            this.navigationPanelToolStripMenuItem,
            this.saveOnCloseToolStripMenuItem,
            this.weekNumbersToolStripMenuItem,
            this.alertsToolStripMenuItem,
            this.additionalPanelToolStripMenuItem,
            this.testsToolStripMenuItem});
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(165, 180);
            // 
            // appearanceToolStripMenuItem
            // 
            this.appearanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem1});
            this.appearanceToolStripMenuItem.Name = "appearanceToolStripMenuItem";
            this.appearanceToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.appearanceToolStripMenuItem.Text = "Appearance";
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.changeToolStripMenuItem.Text = "Change";
            this.changeToolStripMenuItem.Click += new System.EventHandler(this.changeToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.loadToolStripMenuItem.Text = "Save";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.saveToolStripMenuItem1.Text = "Load";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // cultureToolStripMenuItem
            // 
            this.cultureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invariantToolStripMenuItem,
            this.applicationToolStripMenuItem,
            this.frIRToolStripMenuItem,
            this.itITToolStripMenuItem,
            this.enUSToolStripMenuItem,
            this.deDEToolStripMenuItem});
            this.cultureToolStripMenuItem.Name = "cultureToolStripMenuItem";
            this.cultureToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cultureToolStripMenuItem.Text = "Culture";
            // 
            // invariantToolStripMenuItem
            // 
            this.invariantToolStripMenuItem.Name = "invariantToolStripMenuItem";
            this.invariantToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.invariantToolStripMenuItem.Text = "Invariant";
            this.invariantToolStripMenuItem.Click += new System.EventHandler(this.invariantToolStripMenuItem_Click);
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.applicationToolStripMenuItem.Text = "Application";
            this.applicationToolStripMenuItem.Click += new System.EventHandler(this.applicationToolStripMenuItem_Click);
            // 
            // frIRToolStripMenuItem
            // 
            this.frIRToolStripMenuItem.Name = "frIRToolStripMenuItem";
            this.frIRToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.frIRToolStripMenuItem.Text = "fr-IR";
            this.frIRToolStripMenuItem.Click += new System.EventHandler(this.frIRToolStripMenuItem_Click);
            // 
            // itITToolStripMenuItem
            // 
            this.itITToolStripMenuItem.Name = "itITToolStripMenuItem";
            this.itITToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.itITToolStripMenuItem.Text = "it-IT";
            this.itITToolStripMenuItem.Click += new System.EventHandler(this.itITToolStripMenuItem_Click);
            // 
            // enUSToolStripMenuItem
            // 
            this.enUSToolStripMenuItem.Name = "enUSToolStripMenuItem";
            this.enUSToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.enUSToolStripMenuItem.Text = "en-US";
            this.enUSToolStripMenuItem.Click += new System.EventHandler(this.enUSToolStripMenuItem_Click);
            // 
            // deDEToolStripMenuItem
            // 
            this.deDEToolStripMenuItem.Name = "deDEToolStripMenuItem";
            this.deDEToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.deDEToolStripMenuItem.Text = "de-DE";
            this.deDEToolStripMenuItem.Click += new System.EventHandler(this.deDEToolStripMenuItem_Click);
            // 
            // navigationPanelToolStripMenuItem
            // 
            this.navigationPanelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiddenToolStripMenuItem,
            this.leftToolStripMenuItem,
            this.rightToolStripMenuItem});
            this.navigationPanelToolStripMenuItem.Name = "navigationPanelToolStripMenuItem";
            this.navigationPanelToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.navigationPanelToolStripMenuItem.Text = "Navigation Panel";
            // 
            // hiddenToolStripMenuItem
            // 
            this.hiddenToolStripMenuItem.Name = "hiddenToolStripMenuItem";
            this.hiddenToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.hiddenToolStripMenuItem.Text = "Hidden";
            this.hiddenToolStripMenuItem.Click += new System.EventHandler(this.hiddenToolStripMenuItem_Click);
            // 
            // leftToolStripMenuItem
            // 
            this.leftToolStripMenuItem.Name = "leftToolStripMenuItem";
            this.leftToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.leftToolStripMenuItem.Text = "Left";
            this.leftToolStripMenuItem.Click += new System.EventHandler(this.leftToolStripMenuItem_Click);
            // 
            // rightToolStripMenuItem
            // 
            this.rightToolStripMenuItem.Name = "rightToolStripMenuItem";
            this.rightToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.rightToolStripMenuItem.Text = "Right";
            this.rightToolStripMenuItem.Click += new System.EventHandler(this.rightToolStripMenuItem_Click);
            // 
            // saveOnCloseToolStripMenuItem
            // 
            this.saveOnCloseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doNotSaveToolStripMenuItem,
            this.promptBeforSavingToolStripMenuItem,
            this.saveWithoutPromptToolStripMenuItem});
            this.saveOnCloseToolStripMenuItem.Name = "saveOnCloseToolStripMenuItem";
            this.saveOnCloseToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.saveOnCloseToolStripMenuItem.Text = "Save On Close";
            // 
            // doNotSaveToolStripMenuItem
            // 
            this.doNotSaveToolStripMenuItem.Name = "doNotSaveToolStripMenuItem";
            this.doNotSaveToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.doNotSaveToolStripMenuItem.Text = "Do Not Save";
            this.doNotSaveToolStripMenuItem.Click += new System.EventHandler(this.doNotSaveToolStripMenuItem_Click);
            // 
            // promptBeforSavingToolStripMenuItem
            // 
            this.promptBeforSavingToolStripMenuItem.Name = "promptBeforSavingToolStripMenuItem";
            this.promptBeforSavingToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.promptBeforSavingToolStripMenuItem.Text = "Prompt Before Saving";
            this.promptBeforSavingToolStripMenuItem.Click += new System.EventHandler(this.promptBeforSavingToolStripMenuItem_Click);
            // 
            // saveWithoutPromptToolStripMenuItem
            // 
            this.saveWithoutPromptToolStripMenuItem.Name = "saveWithoutPromptToolStripMenuItem";
            this.saveWithoutPromptToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.saveWithoutPromptToolStripMenuItem.Text = "Save Without Prompt";
            this.saveWithoutPromptToolStripMenuItem.Click += new System.EventHandler(this.saveWithoutPromptToolStripMenuItem_Click);
            // 
            // weekNumbersToolStripMenuItem
            // 
            this.weekNumbersToolStripMenuItem.Name = "weekNumbersToolStripMenuItem";
            this.weekNumbersToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.weekNumbersToolStripMenuItem.Text = "Week Numbers";
            this.weekNumbersToolStripMenuItem.Click += new System.EventHandler(this.menuItem20_Click);
            // 
            // alertsToolStripMenuItem
            // 
            this.alertsToolStripMenuItem.Name = "alertsToolStripMenuItem";
            this.alertsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.alertsToolStripMenuItem.Text = "Alerts";
            this.alertsToolStripMenuItem.Click += new System.EventHandler(this.alertsToolStripMenuItem_Click);
            // 
            // additionalPanelToolStripMenuItem
            // 
            this.additionalPanelToolStripMenuItem.Name = "additionalPanelToolStripMenuItem";
            this.additionalPanelToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.additionalPanelToolStripMenuItem.Text = "Additional Panel";
            this.additionalPanelToolStripMenuItem.Click += new System.EventHandler(this.additionalPanelToolStripMenuItem_Click);
            // 
            // testsToolStripMenuItem
            // 
            this.testsToolStripMenuItem.Name = "testsToolStripMenuItem";
            this.testsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.testsToolStripMenuItem.Text = "Test";
            this.testsToolStripMenuItem.Click += new System.EventHandler(this.testsToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(339, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 56);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.BorderThickness = 2;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = Color.White;
            this.MetroColor = Color.Transparent;
            this.ClientSize = new System.Drawing.Size(996, 586);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(900, 590);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scheduler";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.contextMenuStrip4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

		}
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            //Application.EnableVisualStyles();
            Application.Run(new Form1());
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

        //overridden to close propertyForm if opened.
        protected override void OnClosing(CancelEventArgs e)
        {
            if (((SimpleScheduleDataProvider)this.scheduleControl1.DataSource).FileName == null)
            {
                ((SimpleScheduleDataProvider)this.scheduleControl1.DataSource).FileName = "default.schedule";
            }
            if (this.propertyForm != null)
            {
                this.propertyForm.Hide();
                propertyForm.AppearancePropertyGrid1.PropertyValueChanged -= new PropertyValueChangedEventHandler(AppearancePropertyGrid1_PropertyValueChanged);
                propertyForm.Closing -= new CancelEventHandler(propertyForm_Closing);
                propertyForm.Close();
            }

            base.OnClosing(e);
        }
		#endregion

        #region Events
        //sample event handler to catch clicks on the schedule control.
		private void scheduleControl1_ScheduleAppointmentClick(object sender, ScheduleAppointmentClickEventArgs e)
		{
			Console.WriteLine("scheduleControl1_ScheduleAppointmentClick: {0} {1}", e.ClickType, e.ClickDateTime);
		}
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckAndSaveIfNeeded(true);

            SimpleScheduleDataProvider scheduleProvider = new SimpleScheduleDataProvider();
            scheduleProvider.MasterList = new SimpleScheduleAppointmentList();
            scheduleProvider.FileName = "newScheduleFile.schedule";
            scheduleProvider.IsDirty = true;
            this.scheduleControl1.DataSource = scheduleProvider;

        }
        void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

        }
        void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Location.X >= 218 && e.Location.X <= 236 && e.Location.Y >= 22 & e.Location.Y <= 32)
            {

                Point pt = pictureBox1.PointToScreen(e.Location);
                pt.X -= 50;
                pt.Y += 7;
                this.contextMenuStrip1.Show(pt);
            }

            if (e.Location.X >= 262 && e.Location.X <= 286 && e.Location.Y >= 22 & e.Location.Y <= 32)
            {

                Point pt = pictureBox1.PointToScreen(e.Location);
                pt.X -= 50;
                pt.Y += 7;
                this.contextMenuStrip2.Show(pt);
                this.SetDisplayRectLocation(247, 17);
            }

            if (e.Location.X >= 308 && e.Location.X <= 337 && e.Location.Y >= 22 & e.Location.Y <= 32)
            {

                Point pt = pictureBox1.PointToScreen(e.Location);
                pt.X -= 50;
                pt.Y += 7;
                this.contextMenuStrip3.Show(pt);
            }

            if (e.Location.X >= 358 && e.Location.X <= 408 && e.Location.Y >= 22 & e.Location.Y <= 32)
            {

                Point pt = pictureBox1.PointToScreen(e.Location);
                pt.X -= 50;
                pt.Y += 7;
                this.contextMenuStrip4.Show(pt);
            }

        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckAndSaveIfNeeded(true);

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Schedule file";
            dlg.InitialDirectory = Environment.CurrentDirectory;
            dlg.Filter = "Schedule files (*.schedule)|*.schedule|All files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.scheduleControl1.DataSource = SimpleScheduleDataProvider.LoadBinary(dlg.FileName);
                    ((SimpleScheduleDataProvider)this.scheduleControl1.DataSource).FileName = dlg.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void saveCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((SimpleScheduleDataProvider)this.scheduleControl1.DataSource).FileName == "newScheduleFile.schedule")
            {
                //do a saveas for new file
                this.saveToolStripMenuItem.PerformClick();
            }
            else
            {
                CheckAndSaveIfNeeded(false);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "*.schedule";
            saveFile.FileName = ((SimpleScheduleDataProvider)this.scheduleControl1.DataSource).FileName;
            saveFile.Filter = "Schedule Files|*.schedule";

            // get a file name from the user
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ((SimpleScheduleDataProvider)this.scheduleControl1.DataSource).SaveBinary(saveFile.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void mergeCalendarAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Merge Schedule file";
            dlg.InitialDirectory = Environment.CurrentDirectory;
            dlg.Filter = "Schedule files (*.schedule)|*.schedule|All files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SimpleScheduleDataProvider mergeProvider = SimpleScheduleDataProvider.LoadBinary(dlg.FileName);
                    SimpleScheduleDataProvider dataProvider = this.scheduleControl1.DataSource as SimpleScheduleDataProvider;
                    this.scheduleControl1.Calendar.BeginUpdate();
                    foreach (SimpleScheduleAppointment item in mergeProvider.MasterList)
                    {
                        dataProvider.AddItem(item);
                    }
                    dataProvider.MasterList.SortStartTime();
                    this.scheduleControl1.Calendar.EndUpdate();
                    this.scheduleControl1.ResetProvider(this.scheduleControl1.ScheduleType);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void randomDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckAndSaveIfNeeded(true);

            SimpleScheduleDataProvider dataProvider = new SimpleScheduleDataProvider();
            dataProvider.MasterList = SimpleScheduleDataProvider.InitializeRandomData();
            dataProvider.FileName = "random.schedule";

            this.scheduleControl1.DataSource = dataProvider;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //The below line is commented out to resolve double time save changes messagebox shown while clicking exit item in menu. 
            //CheckAndSaveIfNeeded(true);
            this.Close();
        }

        private void newItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.scheduleControl1.PerformNewItemClick();
        }

        private void newAllDayItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.scheduleControl1.PerformNewAllDayItemClick();
        }

        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.scheduleControl1.PerformEditItemClick();
        }

        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.scheduleControl1.PerformDeleteItemClick();
        }

        private void testsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimpleScheduleDataProvider dataProvider = this.scheduleControl1.DataSource as SimpleScheduleDataProvider;
            if (dataProvider == null || dataProvider.MasterList.Count < 4)
                this.testsToolStripMenuItem.PerformClick();

            //change to day
            this.scheduleControl1.SwitchToScheduleViewTypeDay(DateTime.Now);


            //enable alerts
            this.scheduleControl1.EnableAlerts = true;

        }

        private void dayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCheckValues(sender as ToolStripMenuItem);
            if (this.scheduleControl1.ScheduleType != ScheduleViewType.Day)
                this.scheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.Day);
        }

        private void SetCheckValues(ToolStripMenuItem item)
        {
            item.Checked = true;
            ContextMenuStrip contextMenuStrip = item.Owner as ContextMenuStrip;
            foreach (ToolStripMenuItem menuItem in contextMenuStrip.Items)
            {
                if (item != menuItem)
                    menuItem.Checked = false;
            }
        }

        private void workWeekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCheckValues(sender as ToolStripMenuItem);
            if (this.scheduleControl1.ScheduleType != ScheduleViewType.WorkWeek)
                this.scheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.WorkWeek);
        }

        private void weekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCheckValues(sender as ToolStripMenuItem);
            if (this.scheduleControl1.ScheduleType != ScheduleViewType.Week)
                this.scheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.Week);
        }

        private void monthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCheckValues(sender as ToolStripMenuItem);
            if (this.scheduleControl1.ScheduleType != ScheduleViewType.Month)
                this.scheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.Month);
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propertyForm == null)
            {
                propertyForm = new PropertyGridForm();
                propertyForm.Closing += new CancelEventHandler(propertyForm_Closing);
                propertyForm.AppearancePropertyGrid1.SelectedObject = this.scheduleControl1.Appearance;
                propertyForm.AppearancePropertyGrid1.PropertyValueChanged += new PropertyValueChangedEventHandler(AppearancePropertyGrid1_PropertyValueChanged);
            }
            if (!propertyForm.Visible)
                propertyForm.Show();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "*.appearance";
            saveFile.FileName = "";
            saveFile.Filter = "Appearance Files|*.appearance";

            // get a file name from the user
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.scheduleControl1.Appearance.SaveBinary(saveFile.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Appearance file";
            dlg.InitialDirectory = Environment.CurrentDirectory;
            dlg.Filter = "Appearance files (*.appearance)|*.appearance";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ScheduleAppearance appearance = ScheduleAppearance.LoadBinary(dlg.FileName);
                    appearance.AttachSchedule(this.scheduleControl1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void invariantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.scheduleControl1.Culture = CultureInfo.InvariantCulture;
        }

        private void applicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.scheduleControl1.Culture = Application.CurrentCulture;
        }

        private void frIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.scheduleControl1.Culture = CultureInfo.CreateSpecificCulture("fr-FR");
        }

        private void itITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.scheduleControl1.Culture = CultureInfo.CreateSpecificCulture("it-IT");
        }

        private void enUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.scheduleControl1.Culture = CultureInfo.CreateSpecificCulture("en-US");
        }

        private void deDEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.scheduleControl1.Culture = CultureInfo.CreateSpecificCulture("de-DE");
        }
        private void alertsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.scheduleControl1.EnableAlerts = !this.scheduleControl1.EnableAlerts;
            this.alertsToolStripMenuItem.Checked = this.scheduleControl1.EnableAlerts;
        }

        private void doNotSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.scheduleControl1.DataSource.SaveOnCloseBehaviorAction = SaveOnCloseBehavior.DoNotSave;
        }

        private void promptBeforSavingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.scheduleControl1.DataSource.SaveOnCloseBehaviorAction = SaveOnCloseBehavior.PromptBeforeSave;
        }

        private void saveWithoutPromptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.scheduleControl1.DataSource.SaveOnCloseBehaviorAction = SaveOnCloseBehavior.SaveWithoutPrompt;
        }

        private void hiddenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.scheduleControl1.SetNavigationPanelPosition(CalendarNavigationPanelPosition.Hidden);
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.scheduleControl1.SetNavigationPanelPosition(CalendarNavigationPanelPosition.Left);
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.scheduleControl1.SetNavigationPanelPosition(CalendarNavigationPanelPosition.Right);
        }

        private void additionalPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.additionalPanelToolStripMenuItem.Checked = !this.additionalPanelToolStripMenuItem.Checked;
            if (this.additionalPanelToolStripMenuItem.Checked)
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
        #endregion

        #region Utility methods
        void CheckAndSaveIfNeeded(bool prompt)
		{
            if (((SimpleScheduleDataProvider)this.scheduleControl1.DataSource).FileName == null)
            {
                ((SimpleScheduleDataProvider)this.scheduleControl1.DataSource).FileName = "default.schedule";
            }
            string name = ((SimpleScheduleDataProvider)this.scheduleControl1.DataSource).FileName;
			int i = name.LastIndexOf('\\');
			if(i > -1)
				name = name.Substring(i + 1);
			if(this.scheduleControl1.DataSource.IsDirty
                && (!prompt || MessageBox.Show("Save changes?", this.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) 
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
			dlg.Filter = "Schedule files (*.schedule)|*.schedule|All files (*.*)|*.*" ; 
		 
			if(dlg.ShowDialog() == DialogResult.OK) 
			{ 
				try
				{
					this.scheduleControl1.DataSource = SimpleScheduleDataProvider.LoadBinary(dlg.FileName);
					((SimpleScheduleDataProvider)this.scheduleControl1.DataSource).FileName = dlg.FileName;
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
			if(((SimpleScheduleDataProvider)this.scheduleControl1.DataSource).FileName 
				== "newScheduleFile.schedule")
			{
				//do a saveas for new file
				//this.menuItem25.PerformClick();
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

			SimpleScheduleDataProvider scheduleProvider = new SimpleScheduleDataProvider();
			scheduleProvider.MasterList = new SimpleScheduleAppointmentList();
			scheduleProvider.FileName = "newScheduleFile.schedule";
			scheduleProvider.IsDirty = true;
			this.scheduleControl1.DataSource = scheduleProvider;
			
		}

		#endregion

		#region File|Random data...
		private void menuItem26_Click(object sender, System.EventArgs e)
		{
			CheckAndSaveIfNeeded(true);

			SimpleScheduleDataProvider dataProvider = new SimpleScheduleDataProvider();
			dataProvider.MasterList	= SimpleScheduleDataProvider.InitializeRandomData();
			dataProvider.FileName = "random.schedule";

			this.scheduleControl1.DataSource = dataProvider;
		}

		#endregion

		#region File|SaveAs
		private void menuItem25_Click(object sender, System.EventArgs e)
		{
			SaveFileDialog saveFile = new SaveFileDialog();
			saveFile.DefaultExt = "*.schedule";
			saveFile.FileName = ((SimpleScheduleDataProvider)this.scheduleControl1.DataSource).FileName;
			saveFile.Filter = "Schedule Files|*.schedule";

			// get a file name from the user
			if(saveFile.ShowDialog() == DialogResult.OK)
			{
				try
				{
					((SimpleScheduleDataProvider)this.scheduleControl1.DataSource).SaveBinary(saveFile.FileName);
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
			dlg.Title = "Merge Schedule file" ; 
			dlg.InitialDirectory = Environment.CurrentDirectory; 
			dlg.Filter = "Schedule files (*.schedule)|*.schedule|All files (*.*)|*.*" ; 
		 
			if(dlg.ShowDialog() == DialogResult.OK) 
			{ 
				try
				{
					SimpleScheduleDataProvider mergeProvider = SimpleScheduleDataProvider.LoadBinary(dlg.FileName);
					SimpleScheduleDataProvider dataProvider = this.scheduleControl1.DataSource as SimpleScheduleDataProvider;
					this.scheduleControl1.Calendar.BeginUpdate();
					foreach(SimpleScheduleAppointment item in mergeProvider.MasterList)
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
            //this.menuItem9.Enabled = this.scheduleControl1.ItemSelected;
            //this.menuItem10.Enabled = this.scheduleControl1.ItemSelected;
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
			dlg.Filter = "Appearance files (*.appearance)|*.appearance|All files (*.*)|*.*" ; 
		 
			if(dlg.ShowDialog() == DialogResult.OK) 
			{ 
				try
				{
					ScheduleAppearance appearance = ScheduleAppearance.LoadBinary(dlg.FileName);
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
			saveFile.Filter = "Appearance Files|*.appearance";

			// get a file name from the user
			if(saveFile.ShowDialog() == DialogResult.OK)
			{
				try
				{
					this.scheduleControl1.Appearance.SaveBinary(saveFile.FileName);
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
			//this.menuItem20.Checked = this.scheduleControl1.Calendar.ShowWeekNumbers;
		}

		#endregion

		#region  Options|Show Additional Panel
		Panel p;
		private void menuItem21_Click(object sender, System.EventArgs e)
		{
            //this.menuItem21.Checked = ! this.menuItem21.Checked;
            //if(this.menuItem21.Checked)
            //{
            //    p = new Panel();
            //    p.BackColor = Color.Blue;
            //    p.Dock = DockStyle.Fill;
            //    this.scheduleControl1.NavigationPanel.Controls.Add(p);
            //}
            //else
            //{
            //    this.scheduleControl1.NavigationPanel.Controls.Remove(p);
            //    p.Dispose();
            //    p = null;
            //}
		}

		#region Options|NavigationPanel

		private void menuItem22_Popup(object sender, System.EventArgs e)
		{
            //menuItem29.Checked = false;
            //menuItem30.Checked = false;
            //menuItem31.Checked = false;
            //switch(this.scheduleControl1.NavigationPanelPosition)
            //{
            //    case CalendarNavigationPanelPosition.Hidden:
            //        menuItem29.Checked = true;
            //        break;
            //    case CalendarNavigationPanelPosition.Left:
            //        menuItem30.Checked = true;
            //        break;
            //    case CalendarNavigationPanelPosition.Right:
            //        menuItem31.Checked = true;
            //        break;
            //}
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
        //private void menuItem18_Popup(object sender, System.EventArgs e)
        //{
			

        //    if(this.scheduleControl1.Culture.DisplayName == CultureInfo.InvariantCulture.DisplayName)
        //    {
        //        menuItem32.Checked = true;
        //    }
        //    else if(this.scheduleControl1.Culture.Name == Application.CurrentCulture.Name)
        //    {
        //        menuItem33.Checked = true;
        //    }
			
        //    if(this.scheduleControl1.Culture.Name == "fr-FR")
        //    {
        //        menuItem34.Checked = true;
        //    }
        //    else if(this.scheduleControl1.Culture.Name == "it-IT")
        //    {
        //        menuItem35.Checked = true;
        //    }
        //    else if(this.scheduleControl1.Culture.Name == "en-US")
        //    {
        //        menuItem36.Checked = true;
        //    }
        //    else if(this.scheduleControl1.Culture.Name == "de-DE")
        //    {
        //        menuItem37.Checked = true;
        //    }
        //}

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
            //random data
            SimpleScheduleDataProvider dataProvider = this.scheduleControl1.DataSource as SimpleScheduleDataProvider;
           if(dataProvider == null || dataProvider.MasterList.Count < 4)

            //change to day
           this.scheduleControl1.SwitchToScheduleViewTypeDay(DateTime.Now);

           
            //enable alerts
           this.scheduleControl1.EnableAlerts = true;

            

        }



		#endregion

        private void buttonAdv6_Click(object sender, EventArgs e)
        {
            if (comboBoxAdv5.SelectedIndex == 0)
            {
                SimpleScheduleDataProvider scheduleProvider;
               
                string fileName = "default.schedule";
                if (FindFile(ref fileName))
                {
                    scheduleProvider = SimpleScheduleDataProvider.LoadBinary(fileName);
                    scheduleProvider.FileName = fileName;
                }
                else
                {
                    scheduleProvider = new SimpleScheduleDataProvider();
                    scheduleProvider.MasterList = new SimpleScheduleAppointmentList();
                    scheduleProvider.FileName = "default.schedule";
                }

                SimpleScheduleDataProvider dataProvider = new SimpleScheduleDataProvider();
                dataProvider.MasterList = SimpleScheduleDataProvider.InitializeRandomData();
                scheduleControl1.DataSource = dataProvider;

                this.scheduleControl1.ScheduleType = ScheduleViewType.Month;
                scheduleControl1.Appearance.VisualStyle = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            }

            else if (comboBoxAdv5.SelectedIndex == 1)
            {
                string path = Application.ExecutablePath;
                MDB_ScheduleDataProvider scheduleProvider = new MDB_ScheduleDataProvider("..\\..\\ScheduleData.mdb");

                SimpleScheduleDataProvider dataProvider = new SimpleScheduleDataProvider();
                dataProvider.MasterList = SimpleScheduleDataProvider.InitializeRandomDataSource();
                //scheduleControl1.DataSource = scheduleProvider;


                this.scheduleControl1.ScheduleType = ScheduleViewType.Month;
                scheduleControl1.DataSource = dataProvider;
                scheduleControl1.Appearance.VisualStyle = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            }

        }

		#endregion

        #endregion
  }

    /// <summary>
    /// Represents a class that is used to find the licensing file for Syncfusion controls.
    /// </summary>
    public class DemoCommon
    {

        /// <summary>
        /// Finds the license key from the Common folder.
        /// </summary>
        /// <returns>Returns the license key.</returns>
        public static string FindLicenseKey()
        {
            string licenseKeyFile = "..\\Common\\SyncfusionLicense.txt";
            for (int n = 0; n < 20; n++)
            {
                if (!System.IO.File.Exists(licenseKeyFile))
                {
                    licenseKeyFile = @"..\" + licenseKeyFile;
                    continue;
                }
                return System.IO.File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }
}



