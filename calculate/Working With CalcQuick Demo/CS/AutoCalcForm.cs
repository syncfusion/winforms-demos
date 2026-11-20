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
using Syncfusion.Calculate;
using DemoCommon.Grid;
using Syncfusion.Windows.Forms;

namespace FirstSample
{
	/// <summary>
	/// Summary description for AutoCalcForm.
	/// </summary>
	public class AutoCalcForm : GridDemoForm
    {
        #region API Definitions
        private System.Windows.Forms.TextBox textBoxD;
		private System.Windows.Forms.TextBox textBoxC;
		private System.Windows.Forms.TextBox textBoxB;
		private System.Windows.Forms.TextBox textBoxA;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelA;
		private System.Windows.Forms.Label labelB;
		private System.Windows.Forms.Label labelC;
		private System.Windows.Forms.Label labelD;
        #endregion
        private Panel panel1;
        /// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AutoCalcForm()
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

		#region Windows Form Designer stuffs
		/// <summary>
		/// Required method for Designer support; do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(81, 146);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(176, 20);
            this.textBoxD.TabIndex = 15;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(81, 106);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(176, 20);
            this.textBoxC.TabIndex = 14;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(81, 66);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(176, 20);
            this.textBoxB.TabIndex = 13;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(81, 26);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(176, 20);
            this.textBoxA.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "D";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "C";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "B";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "A";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelA
            // 
            this.labelA.Location = new System.Drawing.Point(260, 42);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(124, 23);
            this.labelA.TabIndex = 16;
            // 
            // labelB
            // 
            this.labelB.Location = new System.Drawing.Point(287, 79);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(121, 23);
            this.labelB.TabIndex = 17;
            // 
            // labelC
            // 
            this.labelC.Location = new System.Drawing.Point(287, 124);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(121, 23);
            this.labelC.TabIndex = 18;
            // 
            // labelD
            // 
            this.labelD.Location = new System.Drawing.Point(272, 152);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(160, 23);
            this.labelD.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelC);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxA);
            this.panel1.Controls.Add(this.textBoxD);
            this.panel1.Controls.Add(this.textBoxB);
            this.panel1.Controls.Add(this.textBoxC);
            this.panel1.Location = new System.Drawing.Point(5, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 205);
            this.panel1.TabIndex = 20;
            // 
            // AutoCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 18F);
            this.ClientSize = new System.Drawing.Size(443, 214);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 260);
            this.Name = "AutoCalcForm";
            this.Text = "Auto Calculation Form";
            this.Load += new System.EventHandler(this.AutoCalcForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		CalcQuick calculator = null;

		private void AutoCalcForm_Load(object sender, System.EventArgs e)
		{
			//1) Instantiate a CalcQuick object:
			calculator = new CalcQuick();

			//2) Populate your controls:
			this.textBoxA.Text = "12";
			this.textBoxB.Text = "3";
			this.textBoxC.Text = "= [A] + 2 * [B]";

			//C is the only formula:
			this.labelC.Text = this.textBoxC.Text;
			

			//Must enter formula names before turning on calculations.
			//3) Assign formula object names:
			calculator["A"] = this.textBoxA.Text;
			calculator["B"] = this.textBoxB.Text;
			calculator["C"] = this.textBoxC.Text;
			calculator["D"] = this.textBoxD.Text;

			//4) Turn on auto calculations:
			this.calculator.AutoCalc = true;

			//5) Subscribe to the event to set newly calculated values:
			this.calculator.ValueSet += new QuickValueSetEventHandler(calculator_ValueSet);

			//6) Subscribe to some events (in this case, Leave events) to trigger setting values into CalcQuick:
			this.textBoxA.Leave +=new EventHandler(textBoxA_Leave);
			this.textBoxB.Leave +=new EventHandler(textBoxB_Leave);
			this.textBoxC.Leave +=new EventHandler(textBoxC_Leave);
			this.textBoxD.Leave +=new EventHandler(textBoxD_Leave);

			//7) Allow the CalcQuick sheet to create dependency lists among the formula objects
			//   necesary for auto-calculations.
			this.calculator.RefreshAllCalculations();

		}

		// Raised when a value is calculated:
		private void calculator_ValueSet(object sender, QuickValueSetEventArgs e)
		{
		//	if(e.Action == FormulaInfoSetAction.CalculatedValueSet)
			{
				switch(e.Key)
				{
					case "A":
						this.textBoxA.Text = this.calculator[e.Key].ToString();
						break;
					case "B":
						this.textBoxB.Text = this.calculator[e.Key].ToString();
						break;
					case "C":
						this.textBoxC.Text = this.calculator[e.Key].ToString();
						break;
					case "D":
						this.textBoxD.Text = this.calculator[e.Key].ToString();
						break;
					default:
						break;
				}
			}
		}

		private void textBoxA_Leave(object sender, EventArgs e)
		{
			if(this.textBoxA.Modified)
			{
				calculator["A"] = this.textBoxA.Text;
				this.labelA.Text = this.calculator.GetFormula("A");
			}
			this.textBoxA.Modified = false;
			
		}
		private void textBoxB_Leave(object sender, EventArgs e)
		{
			if(this.textBoxB.Modified)
			{
				calculator["B"] = this.textBoxB.Text;
				this.labelB.Text = this.calculator.GetFormula("B");
			}
			this.textBoxB.Modified = false;
		}
		private void textBoxC_Leave(object sender, EventArgs e)
		{
			if(this.textBoxC.Modified)
			{
				calculator["C"] = this.textBoxC.Text;
				this.labelC.Text = this.calculator.GetFormula("C");
			}
			this.textBoxC.Modified = false;
		}
		private void textBoxD_Leave(object sender, EventArgs e)
		{
			if(this.textBoxD.Modified)
			{
				calculator["D"] = this.textBoxD.Text;
				this.labelD.Text = this.calculator.GetFormula("D");
			}
			this.textBoxD.Modified = false;
		}
	}
}
