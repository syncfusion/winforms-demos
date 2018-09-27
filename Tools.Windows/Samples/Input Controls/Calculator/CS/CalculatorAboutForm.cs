#region Copyright Syncfusion Inc. 2001 - 2007
//
//  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Re-distribution in any form is strictly
//  prohibited. Any infringement will be prosecuted under applicable laws. 
//
#endregion

namespace CalculatorControlDemo
{

	using System;
	using System.Collections;
	using System.ComponentModel;
	using System.Drawing;

	using System.Windows.Forms;

	public class CalculatorAboutForm : DemoCommon.AboutForm
	{
		private System.ComponentModel.IContainer components = null;

		public CalculatorAboutForm()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Visible = true;
			// 
			// label1
			// 
			this.label1.Text = "Syncfusion Essential Tools - Calculator control sample";
			this.label1.Visible = true;
			// 
			// label2
			// 
			this.label2.Visible = true;
			// 
			// linkLabel1
			// 
			this.linkLabel1.Visible = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Visible = true;
			// 
			// CalculatorAboutForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(442, 192);
			this.Name = "CalculatorAboutForm";
			this.ResumeLayout(false);

		}
		#endregion
	}
}

