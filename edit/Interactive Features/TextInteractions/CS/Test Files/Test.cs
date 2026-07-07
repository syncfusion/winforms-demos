#region Copyright Syncfusion Inc. 2001 - 2013
//
//  Copyright fhgfghfghSyncfusion Inc. 2001 - 2013. All rights reserved.
//
//  Use of fghfghthis code is subject to the terms of our license.
//  A copy of the current license can be obtained at any timfghfge by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuhfghfted under
//  applghicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace SelectionMarginDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Syncfusion.Windows.Forms.Edit.EditControl editControl1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.MenuItem menuItem16;
		private System.Windows.Forms.MenuItem menuItem17;
		private System.Windows.Forms.MenuItem menuItem18;
		private System.Windows.Forms.MenuItem menuItem19;
		private System.Windows.Forms.MenuItem menuItem20;
		private System.Windows.Forms.MenuItem menuItem21;
		private System.Windows.Forms.MenuItem menuItem22;
		private System.Windows.Forms.MenuItem menuItem23;
		private System.Windows.Forms.MenuItem menuItem24;
		private System.Windows.Forms.MenuItem menuItem25;
		private System.Windows.Forms.MenuItem menuItem26;
		private System.Windows.Forms.MenuItem ChangedLineMarkingMenu;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			
			this.editControl1.SelectionMarginBackgroundColor = Color.IndianRed;
			this.editControl1.SelectionMarginForegroundColor = Color.Gray;
			this.editControl1.LoadFile("..\\..\\Test Files\\Test.cs");
			this.editControl1.ApplyConfiguration("C#");
			this.editControl1.MarkChangedLines=true;			

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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.editControl1 = new Syncfusion.Windows.Forms.Edit.EditControl();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem20 = new System.Windows.Forms.MenuItem();
			this.menuItem21 = new System.Windows.Forms.MenuItem();
			this.menuItem22 = new System.Windows.Forms.MenuItem();
			this.menuItem25 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem17 = new System.Windows.Forms.MenuItem();
			this.menuItem18 = new System.Windows.Forms.MenuItem();
			this.menuItem19 = new System.Windows.Forms.MenuItem();
			this.menuItem24 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem23 = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			this.menuItem15 = new System.Windows.Forms.MenuItem();
			this.menuItem16 = new System.Windows.Forms.MenuItem();
			this.menuItem26 = new System.Windows.Forms.MenuItem();
			this.ChangedLineMarkingMenu = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// editControl1
			// 
			this.editControl1.AutoIndentMode = Syncfusion.Windows.Forms.Edit.Enums.AutoIndentMode.Smart;
			this.editControl1.BackColor = System.Drawing.SystemColors.Window;
			this.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.editControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.editControl1.DropAllFiles = false;
			this.editControl1.FileExtensions = new string[] {
																".cs",
																".htm",
																".html",
																".java",
																".js",
																".pas",
																".sql",
																".vb",
																".vbs",
																".xml"};
			this.editControl1.Name = "editControl1";
			this.editControl1.PseudoFileName = "";
			this.editControl1.ShowIndicatorMargin = false;
			this.editControl1.Size = new System.Drawing.Size(542, 445);
			this.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70;
			this.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.editControl1.TabIndex = 0;
			this.editControl1.Text = "editControl1";
			this.editControl1.TransferFocusOnTab = true;
			this.editControl1.WordWrap = true;
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem9,
																					  this.ChangedLineMarkingMenu});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem3,
																					  this.menuItem4,
																					  this.menuItem5,
																					  this.menuItem6,
																					  this.menuItem7,
																					  this.menuItem8});
			this.menuItem1.Text = "File";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "New";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "Open";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 2;
			this.menuItem4.Text = "-";
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 3;
			this.menuItem5.Text = "Save";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 4;
			this.menuItem6.Text = "SaveAs";
			this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 5;
			this.menuItem7.Text = "-";
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 6;
			this.menuItem8.Text = "Exit";
			this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 1;
			this.menuItem9.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem10,
																					  this.menuItem11,
																					  this.menuItem12});
			this.menuItem9.Text = "SelectionMarginMenu";
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 0;
			this.menuItem10.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem20,
																					   this.menuItem21,
																					   this.menuItem22,
																					   this.menuItem25});
			this.menuItem10.Text = "BackgroundColor";
			// 
			// menuItem20
			// 
			this.menuItem20.Index = 0;
			this.menuItem20.Text = "LightBlue";
			this.menuItem20.Click += new System.EventHandler(this.BackgroundColor_menuItem_Click);
			// 
			// menuItem21
			// 
			this.menuItem21.Index = 1;
			this.menuItem21.Text = "IndianRed";
			this.menuItem21.Click += new System.EventHandler(this.BackgroundColor_menuItem_Click);
			// 
			// menuItem22
			// 
			this.menuItem22.Index = 2;
			this.menuItem22.Text = "Beige";
			this.menuItem22.Click += new System.EventHandler(this.BackgroundColor_menuItem_Click);
			// 
			// menuItem25
			// 
			this.menuItem25.Index = 3;
			this.menuItem25.Text = "None";
			this.menuItem25.Click += new System.EventHandler(this.BackgroundColor_menuItem_Click);
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 1;
			this.menuItem11.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem17,
																					   this.menuItem18,
																					   this.menuItem19,
																					   this.menuItem24});
			this.menuItem11.Text = "ForegroundColor";
			// 
			// menuItem17
			// 
			this.menuItem17.Index = 0;
			this.menuItem17.Text = "Gray";
			this.menuItem17.Click += new System.EventHandler(this.ForegroundColor_menuItem_Click);
			// 
			// menuItem18
			// 
			this.menuItem18.Index = 1;
			this.menuItem18.Text = "Maroon";
			this.menuItem18.Click += new System.EventHandler(this.ForegroundColor_menuItem_Click);
			// 
			// menuItem19
			// 
			this.menuItem19.Index = 2;
			this.menuItem19.Text = "Navy";
			this.menuItem19.Click += new System.EventHandler(this.ForegroundColor_menuItem_Click);
			// 
			// menuItem24
			// 
			this.menuItem24.Index = 3;
			this.menuItem24.Text = "None";
			this.menuItem24.Click += new System.EventHandler(this.ForegroundColor_menuItem_Click);
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 2;
			this.menuItem12.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem23,
																					   this.menuItem13,
																					   this.menuItem14,
																					   this.menuItem15,
																					   this.menuItem16,
																					   this.menuItem26});
			this.menuItem12.Text = "Width";
			// 
			// menuItem23
			// 
			this.menuItem23.Index = 0;
			this.menuItem23.Text = "25";
			this.menuItem23.Click += new System.EventHandler(this.Width_menuItem_Click);
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 1;
			this.menuItem13.Text = "50";
			this.menuItem13.Click += new System.EventHandler(this.Width_menuItem_Click);
			// 
			// menuItem14
			// 
			this.menuItem14.Index = 2;
			this.menuItem14.Text = "75";
			this.menuItem14.Click += new System.EventHandler(this.Width_menuItem_Click);
			// 
			// menuItem15
			// 
			this.menuItem15.Index = 3;
			this.menuItem15.Text = "100";
			this.menuItem15.Click += new System.EventHandler(this.Width_menuItem_Click);
			// 
			// menuItem16
			// 
			this.menuItem16.Index = 4;
			this.menuItem16.Text = "125";
			this.menuItem16.Click += new System.EventHandler(this.Width_menuItem_Click);
			// 
			// menuItem26
			// 
			this.menuItem26.Index = 5;
			this.menuItem26.Text = "Default";
			this.menuItem26.Click += new System.EventHandler(this.Width_menuItem_Click);
			// 
			// ChangedLineMarkingMenu
			// 
			this.ChangedLineMarkingMenu.Index = 2;
			this.ChangedLineMarkingMenu.Text = "ToggleChangedLineMarking";
			this.ChangedLineMarkingMenu.Click += new System.EventHandler(this.ChangedLineMarkingMenu_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(542, 445);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.editControl1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Selection Margin Demo";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
			((System.ComponentModel.ISupportInitialize)(this.editControl1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			this.editControl1.NewFile();
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			this.editControl1.LoadFile();
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			this.editControl1.Save();
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			this.editControl1.SaveAs();
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
		}

		private void Width_menuItem_Click(object sender, System.EventArgs e)
		{
			MenuItem item = sender as MenuItem;

			 if (item.Text == "Default")
				this.editControl1.SelectionMarginWidth = 5;
			else if (item.Text == "25")
				this.editControl1.SelectionMarginWidth = 25;
			else if (item.Text == "50")
				this.editControl1.SelectionMarginWidth = 50;
			else if (item.Text == "75")
				this.editControl1.SelectionMarginWidth = 75;
			else if (item.Text == "100")
				this.editControl1.SelectionMarginWidth = 100;
			else if (item.Text == "125")
				this.editControl1.SelectionMarginWidth = 125;
		}

		private void BackgroundColor_menuItem_Click(object sender, System.EventArgs e)
		{

			MenuItem mi = sender as MenuItem;

			switch (mi.Text)
			{
				case "LightBlue" :
					this.editControl1.SelectionMarginBackgroundColor = Color.LightBlue;
					break;
				case "IndianRed" :
					this.editControl1.SelectionMarginBackgroundColor = Color.IndianRed;
					break;
				case "Beige" :
					this.editControl1.SelectionMarginBackgroundColor = Color.Beige;
					break;				
				case "None" :
					this.editControl1.SelectionMarginBackgroundColor =  Color.Empty;			
					break;				
			}			
		}

		private void ForegroundColor_menuItem_Click(object sender, System.EventArgs e)
		{
			MenuItem mi = sender as MenuItem;

			switch (mi.Text)
			{
				case "Gray" :
					this.editControl1.SelectionMarginForegroundColor = Color.Gray;
					break;
				case "Maroon" :
					this.editControl1.SelectionMarginForegroundColor = Color.Maroon;
					break;
				case "Navy" :
					this.editControl1.SelectionMarginForegroundColor = Color.Navy;	
					break;				
				case "None" :
					this.editControl1.SelectionMarginForegroundColor = Color.Empty;			
					break;				
			}
		}
		
		private void ChangedLineMarkingMenu_Click(object sender, System.EventArgs e)
		{
			
			this.editControl1.MarkChangedLines=!this.editControl1.MarkChangedLines;
		}
				
	}
}
