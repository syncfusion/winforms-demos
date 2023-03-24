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
	/// Summary description for Errorlist.
	/// </summary>
	public class ErrorlistView : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Panel panelErrorList;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem errorsBarItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem warningsBarItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem messagesBarItem;
		public Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar errorlistToolBar;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ListView dwTaskListView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
        private Syncfusion.Windows.Forms.ScrollersFrame scrollersFrame1;
		private System.ComponentModel.IContainer components;

		public ErrorlistView()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call
            this.errorlistToolBar.Bar.BeginGroupAt(this.warningsBarItem);
            this.errorlistToolBar.Bar.BeginGroupAt(this.messagesBarItem);
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "",
            "TODO: Add any constructor code after InitializeComponent call"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorlistView));
            this.panelErrorList = new System.Windows.Forms.Panel();
            this.dwTaskListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorlistToolBar = new Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar();
            this.errorsBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.warningsBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.messagesBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.scrollersFrame1 = new Syncfusion.Windows.Forms.ScrollersFrame(this.components);
            this.panelErrorList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelErrorList
            // 
            this.panelErrorList.Controls.Add(this.dwTaskListView);
            this.panelErrorList.Controls.Add(this.errorlistToolBar);
            this.panelErrorList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelErrorList.Location = new System.Drawing.Point(0, 0);
            this.panelErrorList.Name = "panelErrorList";
            this.panelErrorList.Size = new System.Drawing.Size(680, 190);
            this.panelErrorList.TabIndex = 0;
            // 
            // dwTaskListView
            // 
            this.dwTaskListView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dwTaskListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dwTaskListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.dwTaskListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dwTaskListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dwTaskListView.FullRowSelect = true;
            this.dwTaskListView.GridLines = true;
            listViewItem1.Checked = true;
            listViewItem1.StateImageIndex = 1;
            this.dwTaskListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.dwTaskListView.Location = new System.Drawing.Point(0, 25);
            this.dwTaskListView.MultiSelect = false;
            this.dwTaskListView.Name = "dwTaskListView";
            this.dwTaskListView.Size = new System.Drawing.Size(680, 165);
            this.dwTaskListView.TabIndex = 28;
            this.dwTaskListView.UseCompatibleStateImageBehavior = false;
            this.dwTaskListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "!";
            this.columnHeader1.Width = 20;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            this.columnHeader2.Width = 22;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Description";
            this.columnHeader3.Width = 1000;
            // 
            // errorlistToolBar
            // 
            this.errorlistToolBar.Bar.BarName = "";
            this.errorlistToolBar.Bar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.errorsBarItem,
            this.warningsBarItem,
            this.messagesBarItem});
            this.errorlistToolBar.Bar.Manager = null;
            this.errorlistToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.errorlistToolBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.errorlistToolBar.Location = new System.Drawing.Point(0, 0);
            this.errorlistToolBar.Name = "errorlistToolBar";
            this.errorlistToolBar.Size = new System.Drawing.Size(680, 25);
            this.errorlistToolBar.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.errorlistToolBar.TabIndex = 0;
            // 
            // errorsBarItem
            // 
            this.errorsBarItem.BarName = "errorsBarItem";
            this.errorsBarItem.Checked = true;
            this.errorsBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.errorsBarItem.ID = "Errors";
            this.errorsBarItem.ImageIndex = 0;
            this.errorsBarItem.ImageList = this.imageList1;
            this.errorsBarItem.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.errorsBarItem.ShowToolTipInPopUp = false;
            this.errorsBarItem.SizeToFit = true;
            this.errorsBarItem.Text = "Errors";
            this.errorsBarItem.Click += new System.EventHandler(this.BarItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Wrong.png");
            this.imageList1.Images.SetKeyName(1, "Warning.png");
            this.imageList1.Images.SetKeyName(2, "");
            // 
            // warningsBarItem
            // 
            this.warningsBarItem.BarName = "warningsBarItem";
            this.warningsBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.warningsBarItem.ID = "Warnings";
            this.warningsBarItem.ImageIndex = 1;
            this.warningsBarItem.ImageList = this.imageList1;
            this.warningsBarItem.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.warningsBarItem.ShowToolTipInPopUp = false;
            this.warningsBarItem.SizeToFit = true;
            this.warningsBarItem.Text = "Warnings";
            this.warningsBarItem.Click += new System.EventHandler(this.BarItem_Click);
            // 
            // messagesBarItem
            // 
            this.messagesBarItem.BarName = "messagesBarItem";
            this.messagesBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.messagesBarItem.ID = "Messages";
            this.messagesBarItem.ImageIndex = 2;
            this.messagesBarItem.ImageList = this.imageList1;
            this.messagesBarItem.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.messagesBarItem.ShowToolTipInPopUp = false;
            this.messagesBarItem.SizeToFit = true;
            this.messagesBarItem.Text = "Messages";
            this.messagesBarItem.Click += new System.EventHandler(this.BarItem_Click);
            // 
            // scrollersFrame1
            // 
            this.scrollersFrame1.AttachedTo = this.dwTaskListView;
            this.scrollersFrame1.CustomRender = null;
            this.scrollersFrame1.MetroColorScheme = Syncfusion.Windows.Forms.MetroColorScheme.Managed;
            this.scrollersFrame1.SizeGripperVisibility = Syncfusion.Windows.Forms.SizeGripperVisibility.Auto;
            this.scrollersFrame1.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Metro;
            // 
            // ErrorlistView
            // 
            this.Controls.Add(this.panelErrorList);
            this.Name = "ErrorlistView";
            this.Size = new System.Drawing.Size(680, 190);
            this.panelErrorList.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private void BarItem_Click(object sender, EventArgs e)
        {
            Syncfusion.Windows.Forms.Tools.XPMenus.BarItem item = sender as Syncfusion.Windows.Forms.Tools.XPMenus.BarItem;
            item.Checked = !item.Checked;
        }
	}
}
