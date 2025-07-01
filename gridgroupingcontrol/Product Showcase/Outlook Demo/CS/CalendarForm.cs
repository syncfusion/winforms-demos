#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Schedule;
using Syncfusion.Windows.Forms;
using Syncfusion.Schedule;

namespace OutlookDemo
{
	/// <summary>
	/// Summary description for CalanderForm.
	/// </summary>
	public class CalendarForm : System.Windows.Forms.UserControl
    {
        internal ScheduleControl scheduleControl1;
        #region Declaration

        SimpleScheduleDataProvider scheduleProvider = null;
        internal ButtonAdv btnDay;
        internal ButtonAdv btnWeek;
        internal ButtonAdv btnMonth;
        internal RadioButton radWorkWeek;
        internal RadioButton radFullWeek;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
        #endregion

        public CalendarForm()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

            #region SetData

            string fileName = "default.xml";
			if (FindFile(ref fileName))
			{
				scheduleProvider = SimpleScheduleDataProvider.LoadXML(fileName);
				scheduleProvider.FileName = fileName;
                OffsetData();
			}
			else
			{
				scheduleProvider = new SimpleScheduleDataProvider();
				scheduleProvider.MasterList = new SimpleScheduleItemList();
				scheduleProvider.FileName = "default.xml";
			}
          
			scheduleControl1.ScheduleType=ScheduleViewType.Day;
          
			scheduleControl1.DataSource=scheduleProvider;

            #endregion

            #region Style Settings
            this.scheduleControl1.EnableAlerts = true;
            this.scheduleControl1.Appearance.ShowCaptionButtons = true;
            this.radWorkWeek.Visible = false;
            this.radFullWeek.Visible = false;
            #endregion


            //need to size a padding panel...
            foreach (Control c in scheduleControl1.CaptionPanel.Controls)
            {
                if (c.Name == "panelSpacer")
                    c.Width = 40;
            }
            this.scheduleControl1.Appearance.VisualStyle = GridVisualStyles.Office2007Blue;
		}

        //used to center sample data around the current date.
        private void OffsetData()
        {
            int offSet = ((TimeSpan)(DateTime.Now - new DateTime(2006, 11, 6))).Days - 2;
            foreach (ScheduleAppointment item in scheduleProvider.MasterList)
            {
                item.StartTime = item.StartTime.AddDays(offSet);
                item.EndTime = item.EndTime.AddDays(offSet);
            }
            scheduleProvider.MasterList.SortStartTime();
        }

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

		public ScheduleControl Scheduler
		{
			get{return this.scheduleControl1;}
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.scheduleControl1 = new Syncfusion.Windows.Forms.Schedule.ScheduleControl();
			this.btnDay = new Syncfusion.Windows.Forms.ButtonAdv();
			this.btnWeek = new Syncfusion.Windows.Forms.ButtonAdv();
			this.btnMonth = new Syncfusion.Windows.Forms.ButtonAdv();
			this.radWorkWeek = new System.Windows.Forms.RadioButton();
			this.radFullWeek = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// scheduleControl1
			// 
			this.scheduleControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.scheduleControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(215)))), ((int)(((byte)(252)))));
			this.scheduleControl1.Culture = new System.Globalization.CultureInfo("");
			this.scheduleControl1.DataSource = null;
			this.scheduleControl1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scheduleControl1.Location = new System.Drawing.Point(0, 34);
			this.scheduleControl1.Name = "scheduleControl1";
			this.scheduleControl1.NavigationPanelPosition = Syncfusion.Schedule.CalendarNavigationPanelPosition.Hidden;
			this.scheduleControl1.Size = new System.Drawing.Size(600, 326);
			this.scheduleControl1.TabIndex = 0;
			// 
			// btnDay
			// 
			this.btnDay.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
			this.btnDay.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Solid;
			this.btnDay.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDay.KeepFocusRectangle = false;
			this.btnDay.Location = new System.Drawing.Point(1, 0);
			this.btnDay.Name = "btnDay";
			this.btnDay.Size = new System.Drawing.Size(75, 33);
			this.btnDay.TabIndex = 1;
			this.btnDay.Text = "Day";
			this.btnDay.UseVisualStyle = true;
			this.btnDay.Click += new System.EventHandler(this.buttonAdv1_Click);
			// 
			// btnWeek
			// 
			this.btnWeek.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
			this.btnWeek.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Solid;
			this.btnWeek.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnWeek.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnWeek.KeepFocusRectangle = false;
			this.btnWeek.Location = new System.Drawing.Point(76, 0);
			this.btnWeek.Name = "btnWeek";
			this.btnWeek.Size = new System.Drawing.Size(75, 33);
			this.btnWeek.TabIndex = 2;
			this.btnWeek.Text = "Week";
			this.btnWeek.UseVisualStyle = true;
			this.btnWeek.Click += new System.EventHandler(this.buttonAdv2_Click);
			// 
			// btnMonth
			// 
			this.btnMonth.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
			this.btnMonth.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
			this.btnMonth.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMonth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMonth.KeepFocusRectangle = false;
			this.btnMonth.Location = new System.Drawing.Point(151, 0);
			this.btnMonth.Name = "btnMonth";
			this.btnMonth.Size = new System.Drawing.Size(75, 33);
			this.btnMonth.TabIndex = 3;
			this.btnMonth.Text = "Month";
			this.btnMonth.UseVisualStyle = true;
			this.btnMonth.Click += new System.EventHandler(this.buttonAdv3_Click);
			// 
			// radWorkWeek
			// 
			this.radWorkWeek.AutoSize = true;
			this.radWorkWeek.BackColor = System.Drawing.Color.Transparent;
			this.radWorkWeek.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radWorkWeek.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radWorkWeek.Location = new System.Drawing.Point(261, 8);
			this.radWorkWeek.Name = "radWorkWeek";
			this.radWorkWeek.Size = new System.Drawing.Size(120, 20);
			this.radWorkWeek.TabIndex = 4;
			this.radWorkWeek.TabStop = true;
			this.radWorkWeek.Text = "Show work week";
			this.radWorkWeek.UseVisualStyleBackColor = false;
			this.radWorkWeek.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// radFullWeek
			// 
			this.radFullWeek.AutoSize = true;
			this.radFullWeek.BackColor = System.Drawing.Color.Transparent;
			this.radFullWeek.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radFullWeek.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radFullWeek.Location = new System.Drawing.Point(435, 8);
			this.radFullWeek.Name = "radFullWeek";
			this.radFullWeek.Size = new System.Drawing.Size(112, 20);
			this.radFullWeek.TabIndex = 5;
			this.radFullWeek.TabStop = true;
			this.radFullWeek.Text = "Show full week";
			this.radFullWeek.UseVisualStyleBackColor = false;
			this.radFullWeek.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// CalendarForm
			// 
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
			this.Controls.Add(this.radFullWeek);
			this.Controls.Add(this.radWorkWeek);
			this.Controls.Add(this.btnMonth);
			this.Controls.Add(this.btnWeek);
			this.Controls.Add(this.btnDay);
			this.Controls.Add(this.scheduleControl1);
			this.Name = "CalendarForm";
			this.Size = new System.Drawing.Size(600, 360);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

        #region Event Handlers

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            this.radWorkWeek.Visible = false;
            this.radFullWeek.Visible = false;
            if (this.scheduleControl1.ScheduleType != ScheduleViewType.Day)
                this.scheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.Day);
        }

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            this.radWorkWeek.Visible = true;
            this.radFullWeek.Visible = true;
            this.radWorkWeek.Checked = true;
            if (this.scheduleControl1.ScheduleType != ScheduleViewType.WorkWeek)
                this.scheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.WorkWeek);
        }

        private void buttonAdv3_Click(object sender, EventArgs e)
        {
            this.radWorkWeek.Visible = false;
            this.radFullWeek.Visible = false;
            if (this.scheduleControl1.ScheduleType != ScheduleViewType.Month)
                this.scheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.Month);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.scheduleControl1.ScheduleType != ScheduleViewType.WorkWeek)
                this.scheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.WorkWeek);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.scheduleControl1.ScheduleType != ScheduleViewType.Week)
                this.scheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.Week);
        }
        #endregion

    }
}
