#region Copyright Syncfusion Inc. 2001 - 2015
//
//  Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
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

namespace FirstSample
{
	/// <summary>
	/// Summary description for SelectForm.
	/// </summary>
	public class SelectForm : GridDemoForm
    {
        #region API Definitions
        private ButtonAdv manualButton;
        private ButtonAdv autoButton;
        private ButtonAdv button1;
        private ButtonAdv angleFormButton;
        private ButtonAdv button2;
        private ButtonAdv button3;
        #endregion
        private IContainer components;
    
        public SelectForm()
		{
			//
			// Required for Windows Form Designer support.
			//
			InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
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
            this.manualButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.autoButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.angleFormButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.SuspendLayout();
            // 
            // manualButton
            // 
            this.manualButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.manualButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.manualButton.BeforeTouchSize = new System.Drawing.Size(184, 23);
            this.manualButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manualButton.ForeColor = System.Drawing.Color.White;
            this.manualButton.IsBackStageButton = false;
            this.manualButton.Location = new System.Drawing.Point(48, 24);
            this.manualButton.Name = "manualButton";
            this.manualButton.Size = new System.Drawing.Size(184, 23);
            this.manualButton.TabIndex = 0;
            this.manualButton.Text = "Manual Calculations";
            this.manualButton.UseVisualStyle = true;
            this.manualButton.Click += new System.EventHandler(this.manualButton_Click);
            // 
            // autoButton
            // 
            this.autoButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.autoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.autoButton.BeforeTouchSize = new System.Drawing.Size(184, 23);
            this.autoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autoButton.ForeColor = System.Drawing.Color.White;
            this.autoButton.IsBackStageButton = false;
            this.autoButton.Location = new System.Drawing.Point(48, 64);
            this.autoButton.Name = "autoButton";
            this.autoButton.Size = new System.Drawing.Size(184, 23);
            this.autoButton.TabIndex = 1;
            this.autoButton.Text = "Auto Calculations";
            this.autoButton.UseVisualStyle = true;
            this.autoButton.Click += new System.EventHandler(this.autoButton_Click);
            // 
            // button1
            // 
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(184, 23);
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.IsBackStageButton = false;
            this.button1.Location = new System.Drawing.Point(48, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Controls as Keys";
            this.button1.UseVisualStyle = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // angleFormButton
            // 
            this.angleFormButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.angleFormButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.angleFormButton.BeforeTouchSize = new System.Drawing.Size(184, 23);
            this.angleFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.angleFormButton.ForeColor = System.Drawing.Color.White;
            this.angleFormButton.IsBackStageButton = false;
            this.angleFormButton.Location = new System.Drawing.Point(48, 144);
            this.angleFormButton.Name = "angleFormButton";
            this.angleFormButton.Size = new System.Drawing.Size(184, 23);
            this.angleFormButton.TabIndex = 3;
            this.angleFormButton.Text = "Angle Calculations";
            this.angleFormButton.UseVisualStyle = true;
            this.angleFormButton.Click += new System.EventHandler(this.angleFormButton_Click);
            // 
            // button2
            // 
            this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button2.BeforeTouchSize = new System.Drawing.Size(184, 23);
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.IsBackStageButton = false;
            this.button2.Location = new System.Drawing.Point(48, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Auto Angle Calculations";
            this.button2.UseVisualStyle = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button3.BeforeTouchSize = new System.Drawing.Size(184, 23);
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.IsBackStageButton = false;
            this.button3.Location = new System.Drawing.Point(48, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Algebraic Expressions";
            this.button3.UseVisualStyle = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 18F);
            this.ClientSize = new System.Drawing.Size(276, 270);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.angleFormButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.autoButton);
            this.Controls.Add(this.manualButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(288, 308);
            this.Name = "SelectForm";
            this.Text = "Select Form ";
            this.Load += new System.EventHandler(this.SelectForm_Load);
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
			Application.Run(new SelectForm());
		}

        #region [Event Handlers]
        //used in automated testing
		Form[] forms = new Form[6];
		private void manualButton_Click(object sender, System.EventArgs e)
		{
			ManualCalcForm f = new ManualCalcForm();
			forms[0] = f;
			f.Show();
		}

		private void autoButton_Click(object sender, System.EventArgs e)
		{
			AutoCalcForm f = new AutoCalcForm();
			forms[1] = f;
			f.Show();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			MoreComplexForm f = new MoreComplexForm();
			forms[2] = f;
			f.Show();
		}

		private void angleFormButton_Click(object sender, System.EventArgs e)
		{
			AngleForm f = new AngleForm();
			forms[3] = f;
			f.Show();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			AutoAngleForm f = new AutoAngleForm();
			forms[4] = f;
			f.Show();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			AlgebraicExpressions f = new AlgebraicExpressions();
			forms[5] = f;
			f.Show();
		}
        #endregion

        private void SelectForm_Load(object sender, System.EventArgs e)
		{
			if(Environment.CommandLine.EndsWith("automatedtest"))
			{
				this.manualButton.PerformClick();
				this.autoButton.PerformClick();
				this.button1.PerformClick();
				this.angleFormButton.PerformClick();
				this.button2.PerformClick();
				this.button3.PerformClick();
				Size sz = SystemInformation.PrimaryMonitorSize;;
				this.forms[0].Location = new Point(0,0);
				this.forms[0].Size = new Size(sz.Width/3, sz.Height/2);
				this.forms[1].Location = new Point(sz.Width/3+1,0);
				this.forms[1].Size = new Size(sz.Width/3, sz.Height/2);
				this.forms[2].Location = new Point(2*sz.Width/3+1,0);
				this.forms[2].Size = new Size(sz.Width/3, sz.Height/2);
				this.forms[3].Location = new Point(0,sz.Height/2+1);
				this.forms[3].Size = new Size(sz.Width/3, sz.Height/2);
				this.forms[4].Location = new Point(sz.Width/3+1,sz.Height/2+1);
				this.forms[4].Size = new Size(sz.Width/3, sz.Height/2);
				this.forms[5].Location = new Point(2*sz.Width/3+1,sz.Height/2+1);
				this.forms[5].Size = new Size(sz.Width/3, sz.Height/2);
				this.WindowState = FormWindowState.Minimized;
			}
		}
	}
}
