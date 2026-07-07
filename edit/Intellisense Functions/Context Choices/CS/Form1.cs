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

using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;      
using System.IO;

using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Edit;
using Syncfusion.Windows.Forms.Edit.Interfaces;
using Syncfusion.Windows.Forms.Edit.Implementation;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using Syncfusion.Licensing;
using Syncfusion.WinForms.Controls;

namespace ContextChoiceAndContextPromptDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : SfForm
	{
        private Syncfusion.Windows.Forms.Edit.EditControl editControl1;
		private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.IContainer components = null;
        private Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem5;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem6;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem7;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem8;
#if NETCORE
        private string ConfigPath = Path.GetDirectoryName(Application.ExecutablePath) + @"..\..\..\..\config.xml";
#else
        private string ConfigPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\config.xml";
#endif

        public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(GetIconFile(@"..\\..\\\logo.ico")));
                this.Icon = ico;
            }
            catch { }
			this.AutoScaleMode = AutoScaleMode.Font;
			this.editControl1.ShowContextTooltip = false;
			this.editControl1.ShowOutliningCollapsers = false;
			this.editControl1.ShowHorizontalSplitters = false;
			this.editControl1.ShowVerticalSplitters = false;
            Customization();
			this.editControl1.Configurator.Open(ConfigPath);
			this.editControl1.ApplyConfiguration("CustomLanguage");

			int index=0;
			foreach (Image img in this.imageList1.Images)
			{
				// Populating images using an external ImageList
				this.editControl1.ContextChoiceController.AddImage("Image"+index.ToString(), img);
				index++;
			}

			this.editControl1.Text = "/* Type 'this' or 'me' and a DOT to see the context choice list. After you type 'this.', select 'Find' (or any of the items)from the context choice list and type a BRACE '(' to see the context prompt */\n\n";
            this.editControl1.FilterAutoCompleteItems = false;
		}
        private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
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
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Edit.Implementation.Config.Config config3 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.editControl1 = new Syncfusion.Windows.Forms.Edit.EditControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "menu");
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // editControl1
            // 
            this.editControl1.BackColor = System.Drawing.SystemColors.Window;
            this.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.editControl1.CodeSnipptSize = new System.Drawing.Size(100, 100);
            this.editControl1.Configurator = config3;
            this.editControl1.ContextChoiceForeColor = System.Drawing.SystemColors.InfoText;
            this.editControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editControl1.IndicatorMarginBackColor = System.Drawing.Color.Empty;
            this.editControl1.LineNumbersFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editControl1.Location = new System.Drawing.Point(10, 42);
            this.editControl1.Name = "editControl1";
            this.editControl1.RenderRightToLeft = false;
            this.editControl1.SaveOnClose = false;
            this.editControl1.ScrollPosition = new System.Drawing.Point(0, 0);
            this.editControl1.ScrollVisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Metro;
            this.editControl1.ShowIndicatorMargin = false;
            this.editControl1.Size = new System.Drawing.Size(522, 394);
            this.editControl1.StatusBarSettings.CoordsPanel.Width = 150;
            this.editControl1.StatusBarSettings.EncodingPanel.Width = 100;
            this.editControl1.StatusBarSettings.FileNamePanel.Width = 100;
            this.editControl1.StatusBarSettings.InsertPanel.Width = 33;
            this.editControl1.StatusBarSettings.Offcie2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Blue;
            this.editControl1.StatusBarSettings.Offcie2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Blue;
            this.editControl1.StatusBarSettings.StatusPanel.Width = 70;
            this.editControl1.StatusBarSettings.TextPanel.Width = 80;
            this.editControl1.StatusBarSettings.VisualStyle = Syncfusion.Windows.Forms.Tools.Controls.StatusBar.VisualStyle.Default;
            this.editControl1.TabIndex = 0;
            this.editControl1.Text = "";
            this.editControl1.TransferFocusOnTab = true;
            this.editControl1.UseXPStyleBorder = true;
            this.editControl1.VisualColumn = 1;
            this.editControl1.WordWrap = true;
            this.editControl1.ContextChoiceBeforeOpen += new System.ComponentModel.CancelEventHandler(this.editControl1_ContextChoiceBeforeOpen);
            this.editControl1.ContextChoiceOpen += new Syncfusion.Windows.Forms.Edit.ContextChoiceEventHandler(this.editControl1_ContextChoiceOpen);
            this.editControl1.ContextChoiceClose += new Syncfusion.Windows.Forms.Edit.ContextChoiceCloseEventHandler(this.editControl1_ContextChoiceClose);
            this.editControl1.ContextPromptBeforeOpen += new System.ComponentModel.CancelEventHandler(this.editControl1_ContextPromptBeforeOpen);
            this.editControl1.ContextPromptOpen += new Syncfusion.Windows.Forms.Edit.ContextPromptUpdateEventHandler(this.editControl1_ContextPromptOpen);
            this.editControl1.ContextPromptClose += new Syncfusion.Windows.Forms.Edit.ContextPromptCloseEventHandler(this.editControl1_ContextPromptClose);
            this.editControl1.ContextChoiceItemSelected += new Syncfusion.Windows.Forms.Edit.ContextChoiceItemSelectedEventHandler(this.editControl1_ContextChoiceItemSelected);
            this.editControl1.ContextPromptSelectionChanged += new Syncfusion.Windows.Forms.Edit.ContextPromptSelectionChangedEventHandler(this.editControl1_ContextPromptSelectionChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            // 
            // mainFrameBarManager1
            // 
#if !NETCORE
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
#endif
            this.mainFrameBarManager1.Bars.Add(this.bar1);
            this.mainFrameBarManager1.Categories.Add("file");
            this.mainFrameBarManager1.Categories.Add("filter");
            this.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.MetroForm";
            this.mainFrameBarManager1.EnableMenuMerge = true;
            this.mainFrameBarManager1.Font = this.mainFrameBarManager1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.barItem4,
            this.barItem5,
            this.barItem6,
            this.parentBarItem2,
            this.barItem7,
            this.barItem8});
            this.mainFrameBarManager1.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.mainFrameBarManager1.ResetCustomization = false;
            this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.mainFrameBarManager1.UseBackwardCompatiblity = false;
            // 
            // bar1
            // 
            this.bar1.BarName = "menu";
            this.bar1.Caption = "menu";
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.parentBarItem2});
            this.bar1.Manager = this.mainFrameBarManager1;
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.BarName = "parentBarItem1";
            this.parentBarItem1.CategoryIndex = 0;
            this.parentBarItem1.ID = "File";
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.barItem4,
            this.barItem5,
            this.barItem6});
            this.parentBarItem1.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.Text = "File";
            this.parentBarItem1.WrapLength = 20;
            // 
            // barItem1
            // 
            this.barItem1.BarName = "barItem1";
            this.barItem1.CategoryIndex = 0;
            this.barItem1.ID = "New";
            this.barItem1.ShowToolTipInPopUp = false;
            this.barItem1.SizeToFit = true;
            this.barItem1.Text = "New";
            this.barItem1.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // barItem2
            // 
            this.barItem2.BarName = "barItem2";
            this.barItem2.CategoryIndex = 0;
            this.barItem2.ID = "Open";
            this.barItem2.ShowToolTipInPopUp = false;
            this.barItem2.SizeToFit = true;
            this.barItem2.Text = "Open";
            this.barItem2.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // barItem3
            // 
            this.barItem3.BarName = "barItem3";
            this.barItem3.CategoryIndex = 0;
            this.barItem3.ID = "Save";
            this.barItem3.ShowToolTipInPopUp = false;
            this.barItem3.SizeToFit = true;
            this.barItem3.Text = "Save";
            this.barItem3.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // barItem4
            // 
            this.barItem4.BarName = "barItem4";
            this.barItem4.CategoryIndex = 0;
            this.barItem4.ID = "SaveAs";
            this.barItem4.ShowToolTipInPopUp = false;
            this.barItem4.SizeToFit = true;
            this.barItem4.Text = "SaveAs";
            this.barItem4.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // barItem5
            // 
            this.barItem5.BarName = "barItem5";
            this.barItem5.CategoryIndex = 0;
            this.barItem5.ID = "Close";
            this.barItem5.ShowToolTipInPopUp = false;
            this.barItem5.SizeToFit = true;
            this.barItem5.Text = "Close";
            this.barItem5.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // barItem6
            // 
            this.barItem6.BarName = "barItem6";
            this.barItem6.CategoryIndex = 0;
            this.barItem6.ID = "Exit";
            this.barItem6.ShowToolTipInPopUp = false;
            this.barItem6.SizeToFit = true;
            this.barItem6.Text = "Exit";
            this.barItem6.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.BarName = "parentBarItem2";
            this.parentBarItem2.CategoryIndex = 1;
            this.parentBarItem2.ID = "FilterAutoCompleteItems";
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem7,
            this.barItem8});
            this.parentBarItem2.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.parentBarItem2.ShowToolTipInPopUp = false;
            this.parentBarItem2.SizeToFit = true;
            this.parentBarItem2.Text = "FilterAutoCompleteItems";
            this.parentBarItem2.WrapLength = 20;
            // 
            // barItem7
            // 
            this.barItem7.BarName = "barItem7";
            this.barItem7.CategoryIndex = 1;
            this.barItem7.ID = "True";
            this.barItem7.ShowToolTipInPopUp = false;
            this.barItem7.SizeToFit = true;
            this.barItem7.Text = "True";
            this.barItem7.Click += new System.EventHandler(this.menuItem11_Click);
            // 
            // barItem8
            // 
            this.barItem8.BarName = "barItem8";
            this.barItem8.CategoryIndex = 1;
            this.barItem8.ID = "False";
            this.barItem8.ShowToolTipInPopUp = false;
            this.barItem8.SizeToFit = true;
            this.barItem8.Text = "False";
            this.barItem8.Click += new System.EventHandler(this.menuItem12_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.ClientSize = new System.Drawing.Size(542, 446);
            this.Controls.Add(this.editControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(554, 482);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Context Choices";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
Application.EnableVisualStyles();
			Application.Run(new Form1());
		}

        #region Customization
        public void Customization()
        {
            this.mainFrameBarManager1.Style = VisualStyle.Office2016White;
            this.editControl1.Style = Syncfusion.Windows.Forms.Edit.EditControlStyle.Default;
            this.Padding = new System.Windows.Forms.Padding(0);
        }
        #endregion

        private void MainMenuClick(object sender, System.EventArgs e)
		{
            BarItem mi = sender as BarItem;

			switch (mi.Text)
			{
				case "New" :
					this.editControl1.NewFile();
					break;
				case "Open" :
					this.editControl1.LoadFile();
					break;
				case "Save" :
					this.editControl1.Save();
					break;
				case "SaveAs" :
					this.editControl1.SaveAs();
					break;
				case "Close" :
					this.editControl1.Close();
					break;
				case "Exit" :
					this.Close();
					break;
			}
		}

		//Store the lexem name invoking the ContextPrompt popup
		string contextPromptLexem = "";
		private void editControl1_ContextPromptBeforeOpen(object sender, System.ComponentModel.CancelEventArgs e)
		{			
			ILexem lex;
			ILexemLine lexemLine = this.editControl1.GetLine(this.editControl1.CurrentLine); 

			//Gets the index of the current word in that line
			int ind = GetContextPromptCharIndex(lexemLine);

			if (ind<=0) 
			{
				e.Cancel = true;
				return;
			}
			lex = lexemLine.LineLexems[ind-1] as ILexem;			
			
			// If the count is less than '2', do not show the ContextPrompt popup
			if (lexemLine.LineLexems.Count<2)
				e.Cancel = true;
			else
			{
				// Display ContextChoice popup if the lexem used to invoke them is "this" or "me" only
				if ((lex.Text == "Chat") || (lex.Text == "Database") || (lex.Text == "NewFile") || (lex.Text == "Find") || (lex.Text == "Home") || (lex.Text == "PieChart") || (lex.Text == "Tools"))
				{
					this.contextPromptLexem = lex.Text;
					e.Cancel = false;
				}
				else
					e.Cancel = true;
			}
		}


		// Populate the context prompt list on popup
		private void editControl1_ContextPromptOpen(object sender, Syncfusion.Windows.Forms.Edit.ContextPromptUpdateEventArgs e)
		{
			if (this.contextPromptLexem != "")
			{
				PopulateContextPromptItems(e);
			}
		}


		// Method that populates the context prompt list based on the lexem invoking it
		private void PopulateContextPromptItems (ContextPromptUpdateEventArgs e)
		{
			switch (this.contextPromptLexem)
			{
				case "Chat" :
					e.List.Clear();
					e.AddPrompt( "Chat(string chatText, int senderID, int receiverID, int connectionID)", "Specify the chat text, the sender information, the receiver information and the connection ID" );
					e.AddPrompt( "Chat(string chatText, int senderID, bool isBroadCast)", "Specify the chat text, the sender information, and if its a broadcast" );
					break;
				case "Database" :
					e.List.Clear();
					e.AddPrompt( "Database()", "Create a new database" );
					e.AddPrompt( "Database(string dataBaseName)", "Create a new database with the specified name" );
					break;
				case "NewFile" :
					e.List.Clear();
					e.AddPrompt( "NewFile()", "Create a new file" );
					e.AddPrompt( "NewFile(string fileName)", "Create a new file with the specified name" );
					break;
				case "Find" :
					e.List.Clear();
					e.AddPrompt( "Find()", "Display the Find dialog" );
					e.AddPrompt( "Find(string searchText)", "Find occurences of the specified search text" );
					e.AddPrompt( "Find(string searchText, bool searchUp)", "Find occurences of the specified search text and search up if specified" );
					break;
				case "Home" :
					e.List.Clear();
					e.AddPrompt( "Home()","Go to the initial application form" );
					break;
				case "PieChart" :
					e.List.Clear();
					e.AddPrompt( "PieChart()","Create an empty Pie-chart" );
					e.AddPrompt( "PieChart(string[] sectionNames, int[] sectionAngles)","Create a Pie-chart containing the specified sections with the specified angles information" );
					e.AddPrompt( "PieChart(string[] sectionNames, int[] sectionAngles, Color[] sectionColors)","Create a Pie-chart containing the specified sections with the specified angles and color information" );
					break;
				case "Tools" :
					e.List.Clear();
					e.AddPrompt( "Tools()","Display the Tools dialog" );
					e.AddPrompt( "Tools(int ToolID)","Display the Tools dialog and select the specified Tool" );
					break;
			}
		}


		// Display the selected Context prompt item's index
		private void editControl1_ContextPromptSelectionChanged(Syncfusion.Windows.Forms.Edit.Forms.Popup.ContextPrompt sender, Syncfusion.Windows.Forms.Edit.ContextPromptSelectionChangedEventArgs e)
		{
			Console.WriteLine("SelectedIndex : " + e.SelectedIndex.ToString());
			Console.WriteLine("ContextPromptSelectionChanged");	
		}		


		// Returns the last index of the context prompt character - '(' in the current line
		private int GetContextPromptCharIndex(ILexemLine line)
		{
			int lastPos = -1;

			for (int i=0; i<line.LineLexems.Count; i++)
			{
				ILexem lex = line.LineLexems[i] as ILexem;

				if (lex.Text == "(")
					lastPos = i;
			}

			return lastPos;
		}


		// Clear the context prompt lexem name on close
		private void editControl1_ContextPromptClose(object sender, Syncfusion.Windows.Forms.Edit.ContextPromptCloseEventArgs e)
		{
			this.contextPromptLexem = "";
		}	
	

		// Ensure that the context choice popup is displayed if the invoking lexems are "this" or "me" only
		private void editControl1_ContextChoiceBeforeOpen(object sender, System.ComponentModel.CancelEventArgs e)
		{
			ILexem lex;
			ILexemLine lexemLine = this.editControl1.GetLine(this.editControl1.CurrentLine); 

			//Gets the index of the current word in that line
			int ind = GetContextChoiceCharIndex(lexemLine);

			if (ind<=0) 
			{
				e.Cancel = true;
				return;
			}

			lex = lexemLine.LineLexems[ind-1] as ILexem;			
			
			// If the count is less than '2', do not show the ContextChoice popup
			if (lexemLine.LineLexems.Count<2)
				e.Cancel = true;
			else
			{
				// Display ContextChoice popup if the lexem used to invoke them is "this" or "me" only
				if ((lex.Text == "this") || (lex.Text == "me"))
					e.Cancel = false;
				else
					e.Cancel = true;
			}
		}


		// Populate the context choice list on popup
		private void editControl1_ContextChoiceOpen(Syncfusion.Windows.Forms.Edit.Interfaces.IContextChoiceController controller)
		{			
			controller.Items.Add("Chat", "This is Chat", this.editControl1.ContextChoiceController.Images["Image0"]);
			controller.Items.Add("Database", "This is Database", this.editControl1.ContextChoiceController.Images["Image1"]);    
			controller.Items.Add("NewFile", "This is NewFile", this.editControl1.ContextChoiceController.Images["Image2"]);
			controller.Items.Add("Find", "This is Find", this.editControl1.ContextChoiceController.Images["Image3"]);
			controller.Items.Add("Home", "This is Home", this.editControl1.ContextChoiceController.Images["Image4"]);
			controller.Items.Add("PieChart", "This is PieChart", this.editControl1.ContextChoiceController.Images["Image6"]);   
			controller.Items.Add("Tools", "This is Tools", this.editControl1.ContextChoiceController.Images["Image7"]);  		 
		}


		private void editControl1_ContextChoiceItemSelected(Syncfusion.Windows.Forms.Edit.Interfaces.IContextChoiceController sender, Syncfusion.Windows.Forms.Edit.ContextChoiceItemSelectedEventArgs e)
		{	
			// Display the Context Choice item selected		
			Console.WriteLine("SelectedItem : " + e.SelectedItem.Text);
		}


		// Clear the Context Choice items list on closing the Context Choice popup
		private void editControl1_ContextChoiceClose(Syncfusion.Windows.Forms.Edit.Interfaces.IContextChoiceController controller, System.Windows.Forms.DialogResult dialogresult)
		{
			controller.Items.Clear();
		}

		// Returns the last index of the context choice character - '.' in the current line
		private int GetContextChoiceCharIndex(ILexemLine line)
		{
			int lastPos = -1;

			for (int i=0; i<line.LineLexems.Count; i++)
			{
				ILexem lex = line.LineLexems[i] as ILexem;

				if (lex.Text == ".")
					lastPos = i;
			}

			return lastPos;
        }
        #region FilterAutoCompleteItems

        private void menuItem11_Click(object sender, EventArgs e)
        {
            this.barItem7.Checked = true;
            this.barItem8.Checked = false;
            //Filters the item in the AutoComplete Context choice and the filtered item alone will be visible.
            this.editControl1.FilterAutoCompleteItems = true;
        }

        private void menuItem12_Click(object sender, EventArgs e)
        {
            this.barItem7.Checked = false;
            this.barItem8.Checked = true;
            //All the items will be visible and the selection will be navigated to the item. 
            this.editControl1.FilterAutoCompleteItems = false;
        }
        #endregion
    }
 /// <summary>
    /// Represents a class that is used to find the licensing file for Syncfusion controls.
    /// </summary>
    public class DemoCommon
    {
        /// <summary>
        /// Finds the license key from the Common folder.
        /// </summary>
        /// <returns>Returns the license key.</returns>
        public static string FindLicenseKey()
        {
            string licenseKeyFile = "..\\Common\\SyncfusionLicense.txt";
            for (int n = 0; n < 20; n++)
            {
                if (!System.IO.File.Exists(licenseKeyFile))
                {
                    licenseKeyFile = @"..\" + licenseKeyFile;
                    continue;
                }
                return File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }
}
