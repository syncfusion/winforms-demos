#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Schedule;

namespace GridScheduleSample
{
	/// <summary>
	/// Summary description for PropertyGridForm.
	/// </summary>
	public class PropertyGridForm : System.Windows.Forms.Form
	{
		public System.Windows.Forms.PropertyGrid AppearancePropertyGrid1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public PropertyGridForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.AppearancePropertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.SuspendLayout();
			// 
			// AppearancePropertyGrid1
			// 
			this.AppearancePropertyGrid1.CommandsVisibleIfAvailable = true;
			this.AppearancePropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AppearancePropertyGrid1.LargeButtons = false;
			this.AppearancePropertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.AppearancePropertyGrid1.Location = new System.Drawing.Point(0, 0);
			this.AppearancePropertyGrid1.Name = "AppearancePropertyGrid1";
			this.AppearancePropertyGrid1.Size = new System.Drawing.Size(376, 614);
			this.AppearancePropertyGrid1.TabIndex = 0;
			this.AppearancePropertyGrid1.Text = "PropertyGrid";
			this.AppearancePropertyGrid1.ViewBackColor = System.Drawing.SystemColors.Window;
			this.AppearancePropertyGrid1.ViewForeColor = System.Drawing.SystemColors.WindowText;
			// 
			// PropertyGridForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CausesValidation = false;
			this.ClientSize = new System.Drawing.Size(376, 614);
			this.Controls.Add(this.AppearancePropertyGrid1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PropertyGridForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Schedule Appearance Properties";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
