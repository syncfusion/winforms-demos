#region Copyright Syncfusion Inc. 2001 - 2014
//
//  Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

namespace SplashControlDemo
{
	using System;
	using System.Collections;
	using System.ComponentModel;
	using System.Drawing;
	using System.Reflection ;

	using System.Windows.Forms;

	public class SplashControlAboutForm : DemoCommon.AboutForm
	{
		private System.ComponentModel.IContainer components = null;

		public SplashControlAboutForm()
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
		
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(442, 192);
			this.Name = "SplashControlAboutForm";
			this.Load += new System.EventHandler(this.SplashControlAboutForm_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void SplashControlAboutForm_Load(object sender, System.EventArgs e)
		{
		
		}
	}
}

