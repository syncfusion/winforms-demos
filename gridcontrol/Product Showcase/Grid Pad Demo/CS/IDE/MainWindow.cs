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
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Reflection;
using System.Diagnostics;
using System.Resources;
using Syncfusion.Windows.Forms.InternalMenus;
using DemoCommon.Grid;
using Syncfusion.Windows.Forms;

namespace Syncfusion.Samples.GridPad
{
	/// <summary>
	///    Summary description for MainFrame.
	/// </summary>
	public class MainWindow : GridDemoForm
    {
        #region API Definition
        /// <summary>
		///    Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components;
		protected MenuItem lastfiles;
		public ArrayList BufferOpenMenuItems = new ArrayList();
		public StatusBar      statusBar       = new StatusBar();
		public StatusBarPanel statusBarPanel  = new StatusBarPanel();
		StatusBarPanel statusBarPanel1 = new StatusBarPanel();
		StatusBarPanel statusBarPanel2 = new StatusBarPanel();
		protected ToolBar standardtoolbar;
		MenuFactory menuFactory;
        #endregion

        #region Constructor
        public MainWindow()
		{
			InitializeComponent();
			if(DpiAware.GetCurrentDpi() > 96)
			{
				this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
			}
            this.Size = new System.Drawing.Size(300, 300);
            this.CaptionAlign = HorizontalAlignment.Left;
            this.Text = "Grid Pad";        
            try
			{
				InitializeMenu();
			
				StandardStatusBar(null, null);
				statusBarPanel.BorderStyle = StatusBarPanelBorderStyle.None;                
				statusBarPanel.Width = (int)DpiAware.LogicalToDeviceUnits(500.0f);
				statusBarPanel.AutoSize = StatusBarPanelAutoSize.Spring;
				
				statusBarPanel1.BorderStyle = StatusBarPanelBorderStyle.Sunken;
				statusBarPanel1.Width = (int)DpiAware.LogicalToDeviceUnits(50.0f);
				statusBarPanel1.AutoSize = StatusBarPanelAutoSize.None;

				statusBarPanel2.BorderStyle = StatusBarPanelBorderStyle.Sunken;
				statusBarPanel2.Width = (int)DpiAware.LogicalToDeviceUnits(50.0f);                      
				statusBarPanel2.AutoSize = StatusBarPanelAutoSize.None;
				statusBar.ShowPanels = true;
				statusBar.Panels.Add(statusBarPanel);
				statusBar.Panels.Add(statusBarPanel1);
				statusBar.Panels.Add(statusBarPanel2);

				this.IsMdiContainer = true;
				Anchor = ~AnchorStyles.None;
				MenuComplete += new EventHandler(StandardStatusBar);
				
				// set the old form start position
				this.Size = new System.Drawing.Size(1028, 591);

				GridFrame doc = new GridFrame();
                doc.MdiParent = this;
                doc.Show();
				this.Controls.Add(statusBar);
			}  
			catch
			{
			}  
		}
        #endregion

        #region Designer Stuffs
        /// <summary>
        ///    Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

		/// <summary>
		///    Required method for Designer support - do not modify
		///    the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.SuspendLayout();
			// 
			// MainWindow
			//           
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(588, 463);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;            
            this.ResumeLayout(false);
            this.components = new Container();

		}
        #endregion

        /// <summary>
        /// Status bar status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void StandardStatusBar(object sender, EventArgs e)
		{
			statusBarPanel.Text = "Ready";            
		}

        /// <summary>
        /// Updating the previous files
        /// </summary>
		public void UpdateLastFiles()
		{
			if (lastfiles != null) 
			{
				lastfiles.MenuItems.Clear();
				MenuItem tmp = new MenuItem("last files");
				tmp.Enabled  = false;                
				lastfiles.MenuItems.Add(tmp);
			}
		}

        /// <summary>
        /// Initializing the menu items
        /// </summary>
        /// <returns></returns>
		private bool InitializeMenu()
		{
			try
			{
				string maintoolbarResource = ApplicationMain.manifestNamespace + "DefaultToolbarItems.xml";
				string menuResource = ApplicationMain.manifestNamespace + "DefaultMenuItems.xml";
				FactoryType ft;
#if SyncfusionFramework2_0	
                ft = FactoryType.WhidbeyMenuFactory;
#else
				ft = FactoryType.WinFormsMenuFactory;
#endif
				menuFactory = MenuLoader.CreateFactory(ft, ApplicationMain.menuNamespace, new string[] { maintoolbarResource },
					new string[] { menuResource }, ApplicationMain.IconResources, this);
                
				if (menuFactory.ToolBars != null)
					this.Controls.AddRange(menuFactory.ToolBars as Control[]);

				if (menuFactory.Menus != null)
				{
					if (typeof(Menu).IsInstanceOfType(menuFactory.Menus[0]))
					{                        
						Menu = menuFactory.Menus[0] as MainMenu;
                       
					}
					else
					{
						this.Controls.Add(menuFactory.Menus[0] as Control);                          
					}
				}


			}
			catch (Exception ex)
			{
				Trace.WriteLine("Unable to create menu factory due to the following error:");
				Trace.WriteLine(ex.ToString());
				return false;
			}
			return true;
		}        
	}
}
