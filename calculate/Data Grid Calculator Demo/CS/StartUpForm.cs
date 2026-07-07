#region Copyright Syncfusion Inc. 2001 - 2006
//
//  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DemoCommon.Grid;
using Syncfusion.Windows.Forms;

namespace DataGridCalculator
{
	/// <summary>
	/// Summary description for StartUpForm.
	/// </summary>
	public class StartUpForm : GridDemoForm
    {
        #region API defenitions
        private ButtonAdv button1;
        private ButtonAdv button2;
        private IContainer components;
        #endregion 

        public StartUpForm()
		{
			//
			// Required for Windows Form Designer support.
			//
			InitializeComponent();
            if(DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
     
		#region Windows Form Designer stuffs
		/// <summary>
		/// Required method for Designer support; do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(184, 48);
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.IsBackStageButton = false;
            this.button1.Location = new System.Drawing.Point(32, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Single DataGrid with Calculation support";
            this.button1.UseVisualStyle = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button2.BeforeTouchSize = new System.Drawing.Size(184, 48);
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.IsBackStageButton = false;
            this.button2.Location = new System.Drawing.Point(32, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "Workbook of DataGrids with Calculation support";
            this.button2.UseVisualStyle = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // StartUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 15F);
            this.ClientSize = new System.Drawing.Size(248, 196);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "StartUpForm";
            this.Text = "Start Up Form";
            this.Load += new System.EventHandler(this.StartUpForm_Load);
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

		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()        
		{
	        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
			# if SyncfusionFramework1_1 || SyncfusionFramework2_0  
				Application.EnableVisualStyles();
			# endif
			Application.Run(new StartUpForm());
		}


		private Form[] forms = new Form[2];
		private void button1_Click(object sender, System.EventArgs e)
		{
			SingleDataGridForm f = new SingleDataGridForm();

			if(Environment.CommandLine.EndsWith("automatedtest"))
			{
				f.Show();
				forms[0] = f;
			}
			else
				f.ShowDialog();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			DataGridWorkBookForm f = new DataGridWorkBookForm();
			if(Environment.CommandLine.EndsWith("automatedtest"))
			{
				f.Show();
				forms[1] = f;
			}
			else
				f.ShowDialog();
		}

		private void StartUpForm_Load(object sender, System.EventArgs e)
		{
			if(Environment.CommandLine.EndsWith("automatedtest"))
			{
				this.button1.PerformClick();
				this.button2.PerformClick();
				Size sz = SystemInformation.PrimaryMonitorSize;;
				this.forms[0].Location = new Point(0,0);
				this.forms[0].Size = new Size(sz.Width/2, sz.Height);
				this.forms[1].Location = new Point(sz.Width/2+1,0);
				this.forms[1].Size = new Size(sz.Width/2, sz.Height);
				this.WindowState = FormWindowState.Minimized;
			}
		}
	}
}
