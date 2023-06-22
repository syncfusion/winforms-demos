#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
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
using System.Windows.Forms;

namespace VSDemo
{
	/// <summary>
	/// Summary description for FindResults1.
	/// </summary>
	public class FindResultsView : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Panel panelfindResults;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FindResultsView()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call

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
            this.panelfindResults = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panelfindResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelfindResults
            // 
            this.panelfindResults.Controls.Add(this.listBox1);
            this.panelfindResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelfindResults.Location = new System.Drawing.Point(0, 0);
            this.panelfindResults.Name = "panelfindResults";
            this.panelfindResults.Size = new System.Drawing.Size(672, 190);
            this.panelfindResults.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.listBox1.Items.AddRange(new object[] {
            "Find all \"BarManager\", SubFolders, Find Results 2, \"Current Project\".."});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(672, 190);
            this.listBox1.TabIndex = 0;
            // 
            // FindResultsView
            // 
            this.Controls.Add(this.panelfindResults);
            this.Name = "FindResultsView";
            this.Size = new System.Drawing.Size(672, 190);
            this.panelfindResults.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion
	}
}
