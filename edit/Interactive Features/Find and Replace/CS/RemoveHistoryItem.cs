#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;

namespace FindReplaceDemo
{
	/// <summary>
	/// Summary description for RemoveHistoryItem.
	/// </summary>
	public class RemoveHistoryItem : SfForm
	{
		private System.Windows.Forms.ListBox HistoryList;
		private System.Windows.Forms.ListBox RemoveList;
		private ButtonAdv btnOk;
		private System.Collections.ArrayList myArrayList;
		private System.Collections.ArrayList myRemoveList;
        private ButtonAdv BtnCancel;
        private ButtonAdv btnCancelRemoved;
		private System.Collections.ICollection collection;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
        private ButtonAdv BtnRemoveItem;
        private IContainer components;

		public RemoveHistoryItem(System.Collections.ArrayList ar)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			this.myArrayList=ar;
			//this.myRemoveList=new ArrayList();

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
            this.components = new System.ComponentModel.Container();
            this.HistoryList = new System.Windows.Forms.ListBox();
            this.RemoveList = new System.Windows.Forms.ListBox();
            this.btnOk = new Syncfusion.Windows.Forms.ButtonAdv();
            this.BtnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.BtnRemoveItem = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnCancelRemoved = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HistoryList
            // 
            this.HistoryList.Location = new System.Drawing.Point(24, 32);
            this.HistoryList.Name = "HistoryList";
            this.HistoryList.Size = new System.Drawing.Size(136, 121);
            this.HistoryList.TabIndex = 0;
            // 
            // RemoveList
            // 
            this.RemoveList.Location = new System.Drawing.Point(208, 32);
            this.RemoveList.Name = "RemoveList";
            this.RemoveList.Size = new System.Drawing.Size(128, 121);
            this.RemoveList.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(352, 48);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(96, 28);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Remove";
            this.btnOk.UseVisualStyle = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(352, 96);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(96, 28);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyle = true;
            // 
            // BtnRemoveItem
            // 
            this.BtnRemoveItem.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.BtnRemoveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.BtnRemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemoveItem.Location = new System.Drawing.Point(168, 48);
            this.BtnRemoveItem.Name = "BtnRemoveItem";
            this.BtnRemoveItem.Size = new System.Drawing.Size(32, 24);
            this.BtnRemoveItem.TabIndex = 4;
            this.BtnRemoveItem.Text = ">>";
            this.BtnRemoveItem.UseVisualStyle = true;
            this.BtnRemoveItem.Click += new System.EventHandler(this.Remove_Click);
            // 
            // btnCancelRemoved
            // 
            this.btnCancelRemoved.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnCancelRemoved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.btnCancelRemoved.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelRemoved.Location = new System.Drawing.Point(168, 88);
            this.btnCancelRemoved.Name = "btnCancelRemoved";
            this.btnCancelRemoved.Size = new System.Drawing.Size(32, 24);
            this.btnCancelRemoved.TabIndex = 5;
            this.btnCancelRemoved.Text = "<<";
            this.btnCancelRemoved.UseVisualStyle = true;
            this.btnCancelRemoved.Click += new System.EventHandler(this.btnCancelRemoved_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Existing ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(208, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Remove List";
            // 
            // RemoveHistoryItem
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.ClientSize = new System.Drawing.Size(464, 166);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelRemoved);
            this.Controls.Add(this.BtnRemoveItem);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.RemoveList);
            this.Controls.Add(this.HistoryList);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RemoveHistoryItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RemoveHistoryItem";
            this.Load += new System.EventHandler(this.RemoveHistoryItem_Load);
            this.ResumeLayout(false);

		}
		#endregion

		private void RemoveHistoryItem_Load(object sender, System.EventArgs e)
		{			
			foreach(object item in this.myArrayList)
			{
				this.HistoryList.Items.Add(item);
			}			
		}

		private void Remove_Click(object sender, System.EventArgs e)
		{
            if (HistoryList.SelectedItem != null)
            {
                this.RemoveList.Items.Add(this.HistoryList.SelectedItem);
                this.HistoryList.Items.Remove(this.HistoryList.SelectedItem);
            }

		}
		
		private void btnOk_Click(object sender, System.EventArgs e)
		{			
			collection=this.RemoveList.Items;
			this.myRemoveList=new ArrayList(collection);
		}

		private void btnCancelRemoved_Click(object sender, System.EventArgs e)
		{
            if (RemoveList.SelectedItem != null)
            {
                this.HistoryList.Items.Add(this.RemoveList.SelectedItem);
                this.RemoveList.Items.Remove(this.RemoveList.SelectedItem);
            }
		}

		public System.Collections.ArrayList RemoveListItems
		{
			get
			{
				if(this.RemoveList.Items!=null)
					return this.myRemoveList;
				else
					return null;
			}
		}
	}
}
