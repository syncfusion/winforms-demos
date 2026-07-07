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
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;

namespace DropDownCellDemo
{
	/// <summary>
	/// Summary description for DropDownUser.
	/// </summary>
	public class DropDownUser : System.Windows.Forms.UserControl
	{
		public event EventHandler UserControlSave;
		public event EventHandler UserControlCancel;

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		private bool initDone = false;

		public DropDownUser()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// This is the user control  class that is used in the drop down cell.
			// Besides the CheckedListBox and buttons, it these members added:
			//
			// 1) public method SetValuesFromString that accepts a string and
			//    sets the string to set the CheckedListValues appropriately.
			// 2) public method GetValuesToString that returns the CheckedList
			//    values as a comma separated string.
			// 3) Events UserControlSave and UserControlCancel that indicate
			//    how the user chooses to leave the user control.
			// 3) OK.Cancel button event handlers that fires 
			//    UserControlSave/UserControlSave events to indicate 
			//    which button was clicked.
			// 4) A checkedlistbox ItemCheck event handler to flag when a 
			//    change was made.
			
			initDone = true;
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.cancelButton = new System.Windows.Forms.Button();
			this.okButton = new System.Windows.Forms.Button();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(233)), ((System.Byte)(184)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.cancelButton);
			this.panel1.Controls.Add(this.okButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(3, 109);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(154, 48);
			this.panel1.TabIndex = 2;
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cancelButton.Location = new System.Drawing.Point(9, 11);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(59, 23);
			this.cancelButton.TabIndex = 1;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// okButton
			// 
			this.okButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.okButton.Location = new System.Drawing.Point(80, 11);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(64, 23);
			this.okButton.TabIndex = 0;
			this.okButton.Text = "OK";
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkedListBox1.Items.AddRange(new object[] {
																 "choice1",
																 "choice2",
																 "choice3",
																 "choice4",
																 "choice5",
																 "choice6"});
			this.checkedListBox1.Location = new System.Drawing.Point(3, 3);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(154, 152);
			this.checkedListBox1.TabIndex = 3;
			this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
			// 
			// DropDownUser
			// 
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(102)), ((System.Byte)(110)), ((System.Byte)(152)));
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.checkedListBox1);
			this.DockPadding.All = 3;
			this.Name = "DropDownUser";
			this.Size = new System.Drawing.Size(160, 160);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		public void SetValuesFromString(string val)
		{
			string temp = ',' + val + ','; //make everything stars and ends with delimiter
			
			for(int i = 0; i < this.checkedListBox1.Items.Count; ++i)
			{
				string s = this.checkedListBox1.Items[i].ToString();
				this.checkedListBox1.SetItemChecked(i, temp.IndexOf(',' + s + ',') > -1); 
			}
			changed = false;
		}

		public string GetValuesToString()
		{
			string val = ""; //make everything stars and ends with delimiter
			int i = 0;
			foreach(object s in this.checkedListBox1.Items)
			{
				if(this.checkedListBox1.GetItemChecked(i))
				{
					if(val.Length > 0)
						val += ',';
					val += s.ToString();
				}
				i += 1;
			}
			return val;
		}

		private void cancelButton_Click(object sender, System.EventArgs e)
		{
			changed = false;
			if (UserControlCancel != null)
				UserControlCancel(this, EventArgs.Empty);
		}

		private void okButton_Click(object sender, System.EventArgs e)
		{
			bool saveChanged = this.changed;
			this.changed = false;
			if(saveChanged && UserControlSave != null)
				UserControlSave(this, EventArgs.Empty);
			else if (UserControlCancel != null)
				UserControlCancel(this, EventArgs.Empty);
		}

		//used to indicate changes to the values
		private bool changed = false;
		private void checkedListBox1_ItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e)
		{
			if(!this.initDone)
				return;

			changed = true;
		}

	}
}
