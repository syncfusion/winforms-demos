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
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms;

namespace PivotGridLibrary
{
	/// <summary>
	/// Summary description for DropDownUser.
	/// </summary>
	public class DropDownUser : System.Windows.Forms.UserControl
	{
		public event EventHandler UserControlSave;
        public event EventHandler UserControlCancel;
		public System.Windows.Forms.CheckedListBox CheckedList;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
        private Panel panel1;
        private Button cancelButton;
        private Button okButton;

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

            CheckedList.CheckOnClick = true;
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
            this.CheckedList = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.CheckedList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CheckedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckedList.Items.AddRange(new object[] {
            "choice1",
            "choice2",
            "choice3",
            "choice4",
            "choice5",
            "choice6"});
            this.CheckedList.Location = new System.Drawing.Point(3, 3);
            this.CheckedList.Name = "checkedListBox1";
            this.CheckedList.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(139), (int)DpiAware.LogicalToDeviceUnits(128));
            this.CheckedList.TabIndex = 3;
            this.CheckedList.Dock = DockStyle.Top;
            this.CheckedList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.okButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, (int)DpiAware.LogicalToDeviceUnits(122));
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(139), (int)DpiAware.LogicalToDeviceUnits(35));
            this.panel1.TabIndex = 2;
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(4, 5);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(64), (int)DpiAware.LogicalToDeviceUnits(23));
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.AutoSize = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(73, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(59), (int)DpiAware.LogicalToDeviceUnits(23));
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.AutoSize = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // DropDownUser
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(110)))), ((int)(((byte)(152)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CheckedList);
            this.Name = "DropDownUser";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(145), (int)DpiAware.LogicalToDeviceUnits(160));
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		public void SetValuesFromString(string val)
		{
            string temp = ListSeparator + val + ListSeparator; //make everything stars and ends with delimiter
			
			for(int i = 0; i < this.CheckedList.Items.Count; ++i)
			{
				string s = this.CheckedList.Items[i].ToString();
                this.CheckedList.SetItemChecked(i, temp.IndexOf(ListSeparator + s + ListSeparator) > -1); 
			}
			changed = false;
		}

		public string GetValuesToString()
		{
			string val = ""; //make everything stars and ends with delimiter
			int i = 0;
			foreach(object s in this.CheckedList.Items)
			{
				if(this.CheckedList.GetItemChecked(i))
				{
					if(val.Length > 0)
                        val += ListSeparator;
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
        private bool inItemChecked = false;

		private void checkedListBox1_ItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e)
		{
            if (inItemChecked)
                return;
            inItemChecked = true;
			if(!this.initDone)
				return;

			changed = true;
            //if (All) clicked, flip them all the same way....
            if (e.Index == 0)
            {
                for (int i = 1; i < this.CheckedList.Items.Count; ++i)
                    this.CheckedList.SetItemChecked(i, !this.CheckedList.GetItemChecked(0));
            }
            else
            {
                this.CheckedList.SetItemChecked(0, false);
            }
             bool allChecked = true;
             for (int i = 1; i < this.CheckedList.Items.Count; ++i)
             {
                 if ((e.Index == i && this.CheckedList.GetItemChecked(i))
                     || (e.Index != i && !this.CheckedList.GetItemChecked(i)))
                 {
                     allChecked = false;
                     break;
                 }
             }
            if(allChecked)
                this.CheckedList.SetItemChecked(0, true);
            inItemChecked = false;
		}

        private char listSeparator = ',';

        public char ListSeparator
        {
            get { return listSeparator; }
            set { listSeparator = value; }
        }


    }
}
