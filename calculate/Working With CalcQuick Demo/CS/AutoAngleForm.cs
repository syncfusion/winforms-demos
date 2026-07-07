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
using Syncfusion.Calculate;
using DemoCommon.Grid;
using Syncfusion.Windows.Forms;

namespace FirstSample
{
	/// <summary>
	/// Summary description for AutoAngleForm.
	/// </summary>
	public class AutoAngleForm : GridDemoForm
    {
        #region API Definitions
        private System.Windows.Forms.TextBox Angle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox cosTB;
		private System.Windows.Forms.TextBox sinTB;
		private System.Windows.Forms.Label label4;
        CalcQuick calculator = null;
        #endregion
        private Panel panel1;
        /// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AutoAngleForm()
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
		/// Required method for Designer suppor; do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.Angle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cosTB = new System.Windows.Forms.TextBox();
            this.sinTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Angle
            // 
            this.Angle.Location = new System.Drawing.Point(145, 73);
            this.Angle.Name = "Angle";
            this.Angle.Size = new System.Drawing.Size(56, 20);
            this.Angle.TabIndex = 0;
            this.Angle.Text = "30";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "angle in degrees";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(25, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "cosine of angle";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(25, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "sine of angle";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cosTB
            // 
            this.cosTB.Location = new System.Drawing.Point(145, 113);
            this.cosTB.Name = "cosTB";
            this.cosTB.Size = new System.Drawing.Size(136, 20);
            this.cosTB.TabIndex = 4;
            this.cosTB.Text = "= sin([Angle] * pi() / 180) ";
            // 
            // sinTB
            // 
            this.sinTB.Location = new System.Drawing.Point(145, 153);
            this.sinTB.Name = "sinTB";
            this.sinTB.Size = new System.Drawing.Size(136, 20);
            this.sinTB.TabIndex = 5;
            this.sinTB.Text = "= cos([Angle] * pi() / 180) ";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter an angle and press Tab to see its Sine and Cosine.";
            // 
            // panel1
            // 
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Angle);
            this.panel1.Controls.Add(this.sinTB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cosTB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 189);
            this.panel1.TabIndex = 8;
            // 
            // AutoAngleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 18F);
            this.ClientSize = new System.Drawing.Size(342, 206);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(336, 244);
            this.Name = "AutoAngleForm";
            this.Text = "Auto Angle Form ";
            this.Load += new System.EventHandler(this.AngleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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

		private void AngleForm_Load(object sender, System.EventArgs e)
		{
			//TextBox Angle = new TextBox();
			this.Angle.Name = "Angle";
			this.Angle.Text = "30";

			//cosTB = new TextBox();
			this.cosTB.Name = "cosTB";
			this.cosTB.Text = "= cos([Angle] * pi() / 180) ";

			//sinTB = new TextBox();
			this.sinTB.Name = "sinTB";
			this.sinTB.Text = "= sin([Angle] * pi() / 180) ";

			//Instantiate a CalcQuick object:
			calculator = new CalcQuick();

			//Register the controls used in calculations.
			//The formula names used are the Control.Name strings.
            this.calculator.RegisterControlArray(new Control[]
                                                {
                                                    this.Angle,
                                                    this.cosTB,
                                                    this.sinTB
                                                });

			//Allow the CalcQuick sheet to create dependency lists among the formula objects
			//necesary for auto-calculations.
			this.calculator.RefreshAllCalculations();
		}
	}
}
