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
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;

using Syncfusion.Windows.Forms.Edit;
using Syncfusion.Windows.Forms.Edit.Enums;
using Syncfusion.Windows.Forms.Edit.Dialogs;
using Syncfusion.Windows.Forms.Edit.Implementation;
using Syncfusion.Windows.Forms.Edit.Interfaces;
using Syncfusion.Windows.Forms.Edit.Utils;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;
using Syncfusion.WinForms.Controls;

namespace XPThemesDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : SfForm
	{
       
        private Syncfusion.Windows.Forms.Edit.EditControl editControl1;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ImageList imageList1;
#if !NET5_0_OR_GREATER
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
#endif
        private Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem5;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem6;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem7;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem9;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem10;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem11;
        private ParentBarItem parentBarItem3;
        private BarItem barItem15;
        private BarItem barItem16;
        private BarItem barItem12;
        private BarItem barItem13;
        private BarItem barItem14;
#if NETCORE
        private string configPath = Path.GetDirectoryName(Application.ExecutablePath) + @"..\..\..\..\config.xml";
        private string white = Path.GetDirectoryName(Application.ExecutablePath) + @"..\..\..\..\WhiteThemeConfig.xml";
        private string filePath = Path.GetDirectoryName(Application.ExecutablePath) + @"..\..\..\..\Test Files\CSharpSource.cs";
#else
        private string configPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\config.xml";
        private string white = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\WhiteThemeConfig.xml";
        private string filePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Test Files\CSharpSource.cs";
#endif

        [DllImport("user32.dll")]
        static extern bool LockWindowUpdate(IntPtr hWndLock);
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
			this.editControl1.WordWrap = false;
			this.editControl1.SaveOnClose = false;
            this.editControl1.Configurator.Open(configPath);
            this.editControl1.LoadFile(filePath);
            Customization();

			int index=0;
			foreach (Image img in this.imageList1.Images)
			{
				// Populating images using an external ImageList
				this.editControl1.ContextChoiceController.AddImage("Image"+index.ToString(), img);
				index++;
			}
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
            Syncfusion.Windows.Forms.Edit.Implementation.Config.Config config1 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.editControl1 = new Syncfusion.Windows.Forms.Edit.EditControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
#if !NET5_0_OR_GREATER
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
#endif
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "Menu");
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem9 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem10 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem11 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem15 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem16 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem12 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem13 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem14 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
#if !NET5_0_OR_GREATER
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
#endif
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // editControl1
            // 
            this.editControl1.BackColor = System.Drawing.SystemColors.Window;
            this.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editControl1.CodeSnipptSize = new System.Drawing.Size(100, 100);
            this.editControl1.Configurator = config1;
            this.editControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editControl1.IndicatorMarginBackColor = System.Drawing.Color.Empty;
            this.editControl1.LineNumbersFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.editControl1.Location = new System.Drawing.Point(0, 29);
            this.editControl1.Name = "editControl1";
            this.editControl1.RenderRightToLeft = false;
            this.editControl1.ScrollPosition = new System.Drawing.Point(0, 0);
            this.editControl1.ScrollVisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Metro;
            this.editControl1.ShowIndicatorMargin = false;
            this.editControl1.ShowSelectionMargin = false;
            this.editControl1.Size = new System.Drawing.Size(542, 394);

            this.editControl1.StatusBarSettings.TextPanel.AutoSize = false;

            this.editControl1.TabIndex = 0;
            this.editControl1.Text = "editControl1";
            this.editControl1.TransferFocusOnTab = true;
            this.editControl1.UseXPStyleBorder = true;
            this.editControl1.VisualColumn = 1;
            this.editControl1.WordWrap = true;
            this.editControl1.ContextChoiceOpen += new Syncfusion.Windows.Forms.Edit.ContextChoiceEventHandler(this.editControl1_ContextChoiceOpen);
            this.editControl1.ContextChoiceClose += new Syncfusion.Windows.Forms.Edit.ContextChoiceCloseEventHandler(this.editControl1_ContextChoiceClose);
            this.editControl1.ContextPromptOpen += new Syncfusion.Windows.Forms.Edit.ContextPromptUpdateEventHandler(this.editControl1_ContextPromptOpen);
            this.editControl1.UpdateContextToolTip += new Syncfusion.Windows.Forms.Edit.UpdateTooltipEventHandler(this.editControl1_UpdateContextToolTip);
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
            // statusBarPanel1
            // 
#if !NET5_0_OR_GREATER
            this.statusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Width = 525;
#endif
            // 
            // mainFrameBarManager1
            // 
#if !NETCORE
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
#endif
            this.mainFrameBarManager1.Bars.Add(this.bar1);
            this.mainFrameBarManager1.Categories.Add("File");
            this.mainFrameBarManager1.Categories.Add("Intellisense");
            this.mainFrameBarManager1.Categories.Add("VisualStyle");
            this.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.MetroForm";
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.barItem4,
            this.barItem5,
            this.barItem6,
            this.barItem9,
            this.barItem10,
            this.barItem11,
            this.parentBarItem3,
            this.barItem15,
            this.barItem16,
            this.barItem12,
            this.barItem13,
            this.barItem14});
            this.mainFrameBarManager1.MetroColor = System.Drawing.SystemColors.Highlight;
            this.mainFrameBarManager1.ResetCustomization = false;
            this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // bar1
            // 
            this.bar1.BarName = "Menu";
            this.bar1.Caption = "Menu";
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
              this.parentBarItem3,
          });
            this.bar1.Manager = this.mainFrameBarManager1;
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.BarName = "parentBarItem1";
            this.parentBarItem1.CategoryIndex = 0;
            this.parentBarItem1.ID = "&File";
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.barItem4,
            this.barItem5,
            this.barItem6});
            this.parentBarItem1.MetroColor = System.Drawing.SystemColors.Highlight;
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem1.Text = "&File";
            // 
            // barItem1
            // 
            this.barItem1.BarName = "barItem1";
            this.barItem1.CategoryIndex = 0;
            this.barItem1.ID = "&New";
            this.barItem1.ShowToolTipInPopUp = false;
            this.barItem1.SizeToFit = true;
            this.barItem1.Text = "&New";
            this.barItem1.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // barItem2
            // 
            this.barItem2.BarName = "barItem2";
            this.barItem2.CategoryIndex = 0;
            this.barItem2.ID = "&Open";
            this.barItem2.ShowToolTipInPopUp = false;
            this.barItem2.SizeToFit = true;
            this.barItem2.Text = "&Open";
            this.barItem2.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // barItem3
            // 
            this.barItem3.BarName = "barItem3";
            this.barItem3.CategoryIndex = 0;
            this.barItem3.ID = "&Save";
            this.barItem3.ShowToolTipInPopUp = false;
            this.barItem3.SizeToFit = true;
            this.barItem3.Text = "&Save";
            this.barItem3.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // barItem4
            // 
            this.barItem4.BarName = "barItem4";
            this.barItem4.CategoryIndex = 0;
            this.barItem4.ID = "Save&As";
            this.barItem4.ShowToolTipInPopUp = false;
            this.barItem4.SizeToFit = true;
            this.barItem4.Text = "Save&As";
            this.barItem4.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // barItem5
            // 
            this.barItem5.BarName = "barItem5";
            this.barItem5.CategoryIndex = 0;
            this.barItem5.ID = "&Close";
            this.barItem5.ShowToolTipInPopUp = false;
            this.barItem5.SizeToFit = true;
            this.barItem5.Text = "&Close";
            this.barItem5.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // barItem6
            // 
            this.barItem6.BarName = "barItem6";
            this.barItem6.CategoryIndex = 0;
            this.barItem6.ID = "&Exit";
            this.barItem6.ShowToolTipInPopUp = false;
            this.barItem6.SizeToFit = true;
            this.barItem6.Text = "&Exit";
            this.barItem6.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // barItem7
            // 
            this.barItem7.BarName = "barItem7";
            this.barItem7.CategoryIndex = 0;
            this.barItem7.ID = "ToogleXPThemes";
            this.barItem7.ShowToolTipInPopUp = false;
            this.barItem7.SizeToFit = true;
            this.barItem7.Text = "ToogleXPThemes";
            this.barItem7.Click += new System.EventHandler(this.menuItem10_Click);
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.BarName = "parentBarItem2";
            this.parentBarItem2.CategoryIndex = 1;
            this.parentBarItem2.ID = "IntellisensePopups";
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem9,
            this.barItem10,
            this.barItem11});
            this.parentBarItem2.MetroColor = System.Drawing.SystemColors.Highlight;
            this.parentBarItem2.ShowToolTipInPopUp = false;
            this.parentBarItem2.SizeToFit = true;
            this.parentBarItem2.Text = "IntellisensePopups";
            // 
            // barItem9
            // 
            this.barItem9.BarName = "barItem9";
            this.barItem9.CategoryIndex = 1;
            this.barItem9.ID = "Context Tooltip";
            this.barItem9.ShowToolTipInPopUp = false;
            this.barItem9.SizeToFit = true;
            this.barItem9.Text = "Context Tooltip";
            this.barItem9.Click += new System.EventHandler(this.IntellisensePopupsClick);
            // 
            // barItem10
            // 
            this.barItem10.BarName = "barItem10";
            this.barItem10.CategoryIndex = 1;
            this.barItem10.ID = "Context Prompt";
            this.barItem10.ShowToolTipInPopUp = false;
            this.barItem10.SizeToFit = true;
            this.barItem10.Text = "Context Prompt";
            this.barItem10.Click += new System.EventHandler(this.IntellisensePopupsClick);
            // 
            // barItem11
            // 
            this.barItem11.BarName = "barItem11";
            this.barItem11.CategoryIndex = 1;
            this.barItem11.ID = "Context Choice";
            this.barItem11.ShowToolTipInPopUp = false;
            this.barItem11.SizeToFit = true;
            this.barItem11.Text = "Context Choice";
            this.barItem11.Click += new System.EventHandler(this.IntellisensePopupsClick);
            // 
            // parentBarItem3
            // 
            this.parentBarItem3.BarName = "parentBarItem3";
            this.parentBarItem3.CategoryIndex = 2;
            this.parentBarItem3.ID = "VisualStyle";
            this.parentBarItem3.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem15,
            this.barItem16,
            this.barItem12,
            this.barItem13,
            this.barItem14});
            this.parentBarItem3.MetroColor = System.Drawing.SystemColors.Highlight;
            this.parentBarItem3.ShowToolTipInPopUp = false;
            this.parentBarItem3.SizeToFit = true;
            this.parentBarItem3.Text = "VisualStyle";
            this.barItem15.BarName = "barItem10";
            this.barItem15.CategoryIndex = 2;
            this.barItem15.ID = "Default";
            this.barItem15.ShowToolTipInPopUp = false;
            this.barItem15.SizeToFit = true;
            this.barItem15.Text = "Default";
            this.barItem15.Click += new System.EventHandler(this.SplittersMenuClick);

            this.barItem16.BarName = "barItem11";
            this.barItem16.CategoryIndex = 2;
            this.barItem16.ID = "Office2016White";
            this.barItem16.ShowToolTipInPopUp = false;
            this.barItem16.SizeToFit = true;
            this.barItem16.Text = "Office2016White";
            this.barItem16.Click += new System.EventHandler(this.SplittersMenuClick);
            this.barItem16.Checked = true;
            // 
            // barItem12
            // 
            this.barItem12.BarName = "barItem12";
            this.barItem12.CategoryIndex = 2;
            this.barItem12.ID = "Office2016Colorful";
            this.barItem12.ShowToolTipInPopUp = false;
            this.barItem12.SizeToFit = true;
            this.barItem12.Text = "Office2016Colorful";
            this.barItem12.Click += new System.EventHandler(this.SplittersMenuClick);
            // 
            // barItem13
            // 
            this.barItem13.BarName = "barItem13";
            this.barItem13.CategoryIndex = 2;
            this.barItem13.ID = "Office2016DarkGray";
            this.barItem13.ShowToolTipInPopUp = false;
            this.barItem13.SizeToFit = true;
            this.barItem13.Text = "Office2016DarkGray";
            this.barItem13.Click += new System.EventHandler(this.SplittersMenuClick);
            // 
            // barItem14
            // 
            this.barItem14.BarName = "barItem14";
            this.barItem14.CategoryIndex = 2;
            this.barItem14.ID = "Office2016Black";
            this.barItem14.ShowToolTipInPopUp = false;
            this.barItem14.SizeToFit = true;
            this.barItem14.Text = "Office2016Black";
            this.barItem14.Click += new System.EventHandler(this.SplittersMenuClick);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.ClientSize = new System.Drawing.Size(542, 445);
            this.Controls.Add(this.editControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(554, 482);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Themes Support";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).EndInit();
#if !NET5_0_OR_GREATER
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
#endif
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
            this.editControl1.Style = Syncfusion.Windows.Forms.Edit.EditControlStyle.Office2016White;
            this.Padding = new System.Windows.Forms.Padding(0);

        }
        #endregion

        private void MainMenuClick(object sender, System.EventArgs e)
		{
			BarItem mi = sender as BarItem;

			switch (mi.Text)
			{
				case "&New" :
					this.editControl1.NewFile();
					break;
				case "&Open" :
					this.editControl1.LoadFile();
					break;
				case "&Save" :
					this.editControl1.Save();
					break;
				case "Save&As" :
					this.editControl1.SaveAs();
					break;
				case "&Close" :
					this.editControl1.Close();
					break;
				case "&Exit" :
					this.Close();
					break;
			}
		}

		private void menuItem10_Click(object sender, System.EventArgs e)
		{
			this.editControl1.UseXPStyle = !this.editControl1.UseXPStyle;
		}

		private void editControl1_UpdateContextToolTip(object sender, Syncfusion.Windows.Forms.Edit.UpdateTooltipEventArgs e)
		{
			if( e.Text == string.Empty )  
			{  
				Point pointVirtual = editControl1.PointToVirtualPosition( new Point( e.X, e.Y ) );  
 
				if( pointVirtual.Y > 0 )  
				{  
					// Get the current line  
					ILexemLine line = editControl1.GetLine( pointVirtual.Y );  
 
					if( line != null )  
					{  
						// Get tokens from the current line  
						ILexem lexem = line.FindLexemByColumn( pointVirtual.X );  
 
						if( lexem != null )  
						{  
							IConfigLexem configLexem = lexem.Config as IConfigLexem; 
							string formatName = configLexem.Format.Name; 
							e.Text = "This is a " + formatName + " : " + lexem.Text;  
						}  
					}  
				}  
			}  
		}

		private void IntellisensePopupsClick(object sender, System.EventArgs e)
		{	
            BarItem mi = sender as BarItem;

			switch (mi.Text)
			{
				case "Context Tooltip" :
					this.editControl1.ShowContextTooltip = true;
                    this.barItem9.Checked = true;
                    this.barItem10.Checked = false;
                    this.barItem11.Checked = false;
					break;
				case "Context Choice" :
					
					this.editControl1.ShowContextTooltip = false;		
					this.editControl1.SplitHorizontally();
					this.editControl1.HorizontalSplitterPosition = 0;
					this.editControl1.Text = "\n\nthis.editControl1.";

					this.editControl1.ShowContextChoice();
                    this.barItem9.Checked = false;
                    this.barItem10.Checked = false;
                    this.barItem11.Checked = true;
                    break;
				case "Context Prompt" :
				
					this.editControl1.ShowContextTooltip = false;		
					this.editControl1.SplitHorizontally();
					this.editControl1.HorizontalSplitterPosition = 0;
					this.editControl1.Text = "\n\nthis.editControl1.Find(";				
					this.editControl1.ShowContextPrompt();
                    this.barItem9.Checked = false;
                    this.barItem10.Checked = true;
                    this.barItem11.Checked = false;
                    break;
			}
		}

		private void editControl1_ContextChoiceOpen(Syncfusion.Windows.Forms.Edit.Interfaces.IContextChoiceController controller)
		{
			controller.Items.Add("Copy", "This is Copy", this.editControl1.ContextChoiceController.Images["Image1"]);
			controller.Items.Add("Cut", "This is Cut", this.editControl1.ContextChoiceController.Images["Image2"]);    
			controller.Items.Add("Paste", "This is Paste", this.editControl1.ContextChoiceController.Images["Image5"]);
			controller.Items.Add("Find", "This is Find", this.editControl1.ContextChoiceController.Images["Image3"]);
			controller.Items.Add("Replace", "This is Replace", this.editControl1.ContextChoiceController.Images["Image6"]);
			controller.Items.Add("Open", "This is Open", this.editControl1.ContextChoiceController.Images["Image4"]);     
			controller.Items.Add("Save", "This is Save", this.editControl1.ContextChoiceController.Images["Image7"]);     
			controller.Items.Add("Test", "This is Test", this.editControl1.ContextChoiceController.Images["Image8"]);     
			controller.Items.Add("Bookmark", "This is Bookmark", this.editControl1.ContextChoiceController.Images["Image0"]);     
		}

		private void editControl1_ContextPromptOpen(object sender, Syncfusion.Windows.Forms.Edit.ContextPromptUpdateEventArgs e)
		{
			e.AddPrompt( "Find()", "Display the Find dialog" );
			e.AddPrompt( "Find(string searchText)", "Find occurences of the specified search text" );
			e.AddPrompt( "Find(string searchText, bool searchUp)", "Find occurences of the specified search text and search up if specified" );				
		}

		private void editControl1_ContextChoiceClose(Syncfusion.Windows.Forms.Edit.Interfaces.IContextChoiceController controller, System.Windows.Forms.DialogResult dialogresult)
		{
			controller.Items.Clear();
		}
               

        private void SplittersMenuClick(object sender, System.EventArgs e)
		{
            BarItem mi = sender as BarItem;

            this.barItem15.Checked = false;
            this.barItem12.Checked = false;
            this.barItem13.Checked = false;
            this.barItem14.Checked = false;
            this.barItem16.Checked = false;

            LockWindowUpdate(this.Handle);
            switch (mi.Text)
			{
                case "Office2016White":
                    this.mainFrameBarManager1.Style = VisualStyle.Office2016White;
                    this.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.editControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#ffffff"));
                    this.editControl1.Style = EditControlStyle.Office2016White;
                    this.editControl1.Configurator.Open(configPath);
                    this.editControl1.ApplyConfiguration("CustomLanguage");
                    this.editControl1.SelectionTextColor = ColorTranslator.FromHtml("#bfdfff");
                    mi.Checked = true;

                    break;

                case "Default":
                    this.mainFrameBarManager1.Style = VisualStyle.Office2016White;
                    this.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.editControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#ffffff"));
                    this.editControl1.Style = EditControlStyle.Default;
                    this.editControl1.Configurator.Open(configPath);
                    this.editControl1.ApplyConfiguration("CustomLanguage");
                    this.editControl1.SelectionTextColor = ColorTranslator.FromHtml("#bfdfff");

                    mi.Checked = true;

                    break;

				case "Office2016DarkGray":
                    this.mainFrameBarManager1.Style = VisualStyle.Office2016DarkGray;
                    this.BackColor = ColorTranslator.FromHtml("#444444");
                    this.editControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#2d2d30"));
                    this.editControl1.Style = EditControlStyle.Office2016DarkGray;
                    this.editControl1.Configurator.Open(white);
                    this.editControl1.ApplyConfiguration("C#");
                    this.editControl1.SelectionTextColor = ColorTranslator.FromHtml("#0173c7");
                    mi.Checked = true;

                    break;
                case "Office2016Colorful":
                    this.mainFrameBarManager1.Style = VisualStyle.Office2016Colorful;
                    this.BackColor= ColorTranslator.FromHtml("#0173c7");
                    this.editControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#ffffff"));
                    this.editControl1.Style = EditControlStyle.Office2016Colorful;
                    this.editControl1.SelectionTextColor = ColorTranslator.FromHtml("#bfdfff");
                    this.editControl1.Configurator.Open(configPath);
                    this.editControl1.ApplyConfiguration("CustomLanguage");
                    mi.Checked = true;

                    break;
                case "Office2016Black":
                    this.BackColor = ColorTranslator.FromHtml("#0a0a0a");
                    this.mainFrameBarManager1.Style = VisualStyle.Office2016Black;
                    this.editControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#0a0a0a"));
                    this.editControl1.Style = EditControlStyle.Office2016Black;
                    this.editControl1.Configurator.Open(white);
                   this.editControl1.ApplyConfiguration("C#");
                    this.editControl1.SelectionTextColor = ColorTranslator.FromHtml("#0173c7");

                    mi.Checked = true;
                    break;
            }
            LockWindowUpdate(IntPtr.Zero);
        }

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
