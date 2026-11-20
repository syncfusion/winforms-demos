#region Copyright Syncfusion Inc. 2001 - 2007
//
//  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
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

using Syncfusion.Windows.Forms.Tools;

namespace OutlookDemo
{
	/// <summary>
	/// Summary description for OptionsForm.
	/// </summary>
	public class OptionsForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button upButton;
		private System.Windows.Forms.Button downButton;
		private System.Windows.Forms.Button resetButton;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		private OutlookDemo.Form1 mainForm = null;

		public OptionsForm(Form1 mainfrm)
		{
			this.mainForm = mainfrm;
			InitializeComponent();

			// Populate the checkedListBox with the GroupBarItems
			foreach(GroupBarItem item in this.mainForm.GroupBarControl.GroupBarItems)
			{				
				if(item.Visible == true)
					this.checkedListBox1.Items.Add(item.Text, CheckState.Checked);
				else
					this.checkedListBox1.Items.Add(item.Text, CheckState.Unchecked);
			}
			this.checkedListBox1.SelectedIndex = 0;
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.upButton = new System.Windows.Forms.Button();
			this.downButton = new System.Windows.Forms.Button();
			this.resetButton = new System.Windows.Forms.Button();
			this.okButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Display buttons in this order";
			// 
			// label2
			// 
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Location = new System.Drawing.Point(160, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(148, 2);
			this.label2.TabIndex = 1;
			// 
			// upButton
			// 
			this.upButton.Location = new System.Drawing.Point(232, 32);
			this.upButton.Name = "upButton";
			this.upButton.TabIndex = 2;
			this.upButton.Text = "Move Up";
			this.upButton.Click += new System.EventHandler(this.upButton_Click);
			// 
			// downButton
			// 
			this.downButton.Location = new System.Drawing.Point(232, 64);
			this.downButton.Name = "downButton";
			this.downButton.TabIndex = 3;
			this.downButton.Text = "Move Down";
			this.downButton.Click += new System.EventHandler(this.downButton_Click);
			// 
			// resetButton
			// 
			this.resetButton.Location = new System.Drawing.Point(232, 104);
			this.resetButton.Name = "resetButton";
			this.resetButton.TabIndex = 4;
			this.resetButton.Text = "Reset";
			this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
			// 
			// okButton
			// 
			this.okButton.Location = new System.Drawing.Point(144, 144);
			this.okButton.Name = "okButton";
			this.okButton.TabIndex = 6;
			this.okButton.Text = "OK";
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(232, 144);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.TabIndex = 7;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.IntegralHeight = false;
			this.checkedListBox1.Location = new System.Drawing.Point(16, 32);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(209, 108);
			this.checkedListBox1.TabIndex = 8;
			this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
			// 
			// OptionsForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(312, 171);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.checkedListBox1,
																		  this.cancelButton,
																		  this.okButton,
																		  this.resetButton,
																		  this.downButton,
																		  this.upButton,
																		  this.label2,
																		  this.label1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "OptionsForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Navigation Pane Options";
			this.ResumeLayout(false);

		}
		#endregion

		private void okButton_Click(object sender, System.EventArgs e)
		{
			// Compare the items order in the checkedListBox with that in the GroupBar's collection and if the two 
			// are not identical then perform a reinsertion of all GroupBarItems using the checkedListBox's order
			bool breinsertitems = false;
			GroupBarItem[] itemstore = new GroupBarItem[this.mainForm.GroupBarControl.GroupBarItems.Count];
			int index = 0;
			foreach(GroupBarItem item in this.mainForm.GroupBarControl.GroupBarItems)
			{
				itemstore[index++] = item;
			}
			for(int i=0; i<this.checkedListBox1.Items.Count; i++)
			{
				String itemtext = this.checkedListBox1.Items[i] as String;
				if(itemtext != itemstore[i].Text)
				{
					GroupBarItem currentitem = itemstore[i];
					for(int newitempos=0; newitempos<this.checkedListBox1.Items.Count; newitempos++)
					{
						if(itemstore[newitempos].Text == itemtext)
						{
							// Switch the currentitem and newitem positions in the mainform's GroupBarItemStore					
							GroupBarItem newitem = itemstore[newitempos];
							itemstore[i] = newitem;
							itemstore[newitempos] = currentitem;
							breinsertitems = true;
							break;
						}
					}					
				}
			}
			
			// Synchronize the GroupBarItem positions of the GroupBar control with the new GroupBarItem positions of the itemstore
			if(breinsertitems == true)
			{
				// The number of items in the navigation pane should remain the same even after the insertion. Use the 
				// non-NavPane item count to ensure this.
				int nstackcount = 0;
				foreach(GroupBarItem item in this.mainForm.GroupBarControl.GroupBarItems)
				{
					if(item.InNavigationPane == false)
						nstackcount++;
				}

				for(int i=0; i<itemstore.GetLength(0); i++)
				{
					GroupBarItem iteminstore = itemstore[i];				
					int controlindex = this.mainForm.GroupBarControl.GroupBarItems.IndexOf(iteminstore);
					if(controlindex != -1)
					{
						// If the item is present in the GroupBar control but is in a different index than in the itemstore 
						// then remove the item from it's current position and reinsert at the itemstore position.
						int itemstorepos = i;
						if(itemstorepos >= this.mainForm.GroupBarControl.GroupBarItems.Count)
							itemstorepos = this.mainForm.GroupBarControl.GroupBarItems.Count-1;
						if(controlindex != itemstorepos)
						{						
							this.mainForm.GroupBarControl.GroupBarItems.Remove(iteminstore);						
							this.mainForm.GroupBarControl.GroupBarItems.Insert(itemstorepos, iteminstore);
						}
					}
				}

				// The GroupBarItem stack should contain only nstackcount items.
				foreach(GroupBarItem item in this.mainForm.GroupBarControl.GroupBarItems)
				{
					if(this.mainForm.GroupBarControl.GroupBarItems.IndexOf(item) >= nstackcount)
						item.InNavigationPane = true;
					else
						item.InNavigationPane = false;
				}
			}

			// If the visibility state of an item in the CheckedListBox has changed by checking/unchecking then 
			// apply the new state to the GroupBarItem			
			for(int i=0; i<this.checkedListBox1.Items.Count; i++)
			{
				String itemtext = this.checkedListBox1.Items[i] as String;
				foreach(GroupBarItem item in this.mainForm.GroupBarControl.GroupBarItems)
				{
					if(item.Text == itemtext)
					{
						if(this.checkedListBox1.GetItemChecked(i) == true)
						{
							if(item.Visible == false)
								item.Visible = true;
						}
						else
						{
							if(item.Visible == true)
								item.Visible = false;
						}
						break;
					}
				}				
			}

			this.Close();
		}

		private void cancelButton_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void upButton_Click(object sender, System.EventArgs e)
		{
			int currentposition = this.checkedListBox1.SelectedIndex;
			Object currentitem = this.checkedListBox1.SelectedItem;
			CheckState state = this.checkedListBox1.GetItemCheckState(currentposition);
			this.checkedListBox1.Items.Remove(currentitem);
			this.checkedListBox1.Items.Insert(currentposition-1, currentitem);
			this.checkedListBox1.SetItemCheckState(currentposition-1, state);
			this.checkedListBox1.SelectedItem = currentitem;
		}

		private void downButton_Click(object sender, System.EventArgs e)
		{
			int currentposition = this.checkedListBox1.SelectedIndex;
			Object currentitem = this.checkedListBox1.SelectedItem;
			CheckState state = this.checkedListBox1.GetItemCheckState(currentposition);
			this.checkedListBox1.Items.Remove(currentitem);
			this.checkedListBox1.Items.Insert(currentposition+1, currentitem);
			this.checkedListBox1.SetItemCheckState(currentposition+1, state);
			this.checkedListBox1.SelectedItem = currentitem;
		}

		private void resetButton_Click(object sender, System.EventArgs e)
		{
			this.checkedListBox1.Items.Clear();
			IEnumerator itemsenumerator = this.mainForm.ItemStateStore;
			itemsenumerator.Reset();
			while(itemsenumerator.MoveNext())
			{
				GroupBarItemState itemstate = itemsenumerator.Current as GroupBarItemState;
				this.checkedListBox1.Items.Add(itemstate.ItemText, itemstate.Visible);
			}
		}

		private void checkedListBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(this.checkedListBox1.SelectedIndex == 0)
				this.upButton.Enabled = false;
			else
				this.upButton.Enabled = true;

			if(this.checkedListBox1.SelectedIndex == (this.checkedListBox1.Items.Count-1))
				this.downButton.Enabled = false;
			else
				this.downButton.Enabled = true;
		}		
	
	}
}
