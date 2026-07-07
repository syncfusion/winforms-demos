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
using System.Text;
using System.Xml;
using System.Xml.Serialization;

using Syncfusion.Windows.Forms.Edit;
using Syncfusion.Windows.Forms.Edit.Dialogs;
using Syncfusion.Windows.Forms.Edit.Implementation.Config;
using Syncfusion.Windows.Forms.Edit.Interfaces;
using Syncfusion.Windows.Forms.Edit.Implementation.IO;
using Syncfusion.Windows.Forms.Edit.Implementation.Formatting;
using Syncfusion.Windows.Forms.Edit.Implementation.Parser;
using Syncfusion.IO;
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;
using Syncfusion.WinForms.Controls;

namespace PositionsAndOffsetsDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : SfForm
	{
        private Syncfusion.Windows.Forms.Edit.EditControl editControl1;
#if !NET5_0_OR_GREATER
        private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
#endif
#if NETCORE
        private string BasePath = Path.GetDirectoryName(Application.ExecutablePath) + @"..\..\..\..\Test Files\CSharpSource.cs";
#else
        private string BasePath = Path.GetDirectoryName(Application.ExecutablePath) + @"..\..\..\Test Files\CSharpSource.cs";
#endif
        private Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem6;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem7;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem10;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem11;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem5;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem8;
        private IContainer components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
;            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(GetIconFile(@"..\\..\\\logo.ico")));
                this.Icon = ico;
            }
            catch { }
            this.AutoScaleMode = AutoScaleMode.Font;
			this.editControl1.LoadFile(BasePath);
			this.editControl1.ShowOutliningCollapsers = true;

			this.editControl1.ShowVerticalSplitters = false;
			this.editControl1.ShowHorizontalSplitters = false;
			this.editControl1.BringToFront();
            Customization();
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
            Syncfusion.Windows.Forms.Edit.Implementation.Config.Config config1 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.editControl1 = new Syncfusion.Windows.Forms.Edit.EditControl();
#if !NET5_0_OR_GREATER
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
#endif
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "Menu");
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem10 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem11 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
#if !NET5_0_OR_GREATER
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
#endif
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // editControl1
            // 
            this.editControl1.AutoIndentMode = Syncfusion.Windows.Forms.Edit.Enums.AutoIndentMode.Smart;
            this.editControl1.BackColor = System.Drawing.SystemColors.Window;
            this.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.editControl1.CodeSnipptSize = new System.Drawing.Size(100, 100);
            this.editControl1.Configurator = config1;
            this.editControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editControl1.IndicatorMarginBackColor = System.Drawing.Color.Empty;
            this.editControl1.LineNumbersFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.editControl1.Location = new System.Drawing.Point(10, 39);
            this.editControl1.Name = "editControl1";
            this.editControl1.RenderRightToLeft = false;
            this.editControl1.ScrollPosition = new System.Drawing.Point(0, 0);
            this.editControl1.ScrollVisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Metro;
            this.editControl1.ShowIndicatorMargin = false;
            this.editControl1.ShowLineNumbers = false;
            this.editControl1.Size = new System.Drawing.Size(540, 383);
            this.editControl1.TabIndex = 0;
            this.editControl1.Text = "";
            this.editControl1.TransferFocusOnTab = true;
            this.editControl1.UseXPStyleBorder = true;
            this.editControl1.VisualColumn = 1;
            this.editControl1.WordWrap = true;
            // 
            // statusBar1
            // 
#if !NET5_0_OR_GREATER
            this.statusBar1.Location = new System.Drawing.Point(10, 422);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(540, 22);
            this.statusBar1.SizingGrip = false;
            this.statusBar1.TabIndex = 1;
            this.statusBar1.Text = "statusBar1";
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.statusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Width = 540;
#endif
            // 
            // mainFrameBarManager1
            // 
#if !NETCORE
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
#endif
            this.mainFrameBarManager1.Bars.Add(this.bar1);
            this.mainFrameBarManager1.Categories.Add("file");
            this.mainFrameBarManager1.Categories.Add("position");
            this.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.MetroForm";
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.barItem4,
            this.barItem6,
            this.parentBarItem2,
            this.barItem7,
            this.barItem10,
            this.barItem11,
            this.barItem5,
            this.barItem8});
            this.mainFrameBarManager1.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.mainFrameBarManager1.ResetCustomization = false;
            this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // bar1
            // 
            this.bar1.BarName = "Menu";
            this.bar1.Caption = "Menu";
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
            this.barItem6});
            this.parentBarItem1.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.Text = "File";
            // 
            // barItem1
            // 
            this.barItem1.BarName = "barItem1";
            this.barItem1.CategoryIndex = 0;
            this.barItem1.ID = "New";
            this.barItem1.ShowToolTipInPopUp = false;
            this.barItem1.SizeToFit = true;
            this.barItem1.Text = "New";
            this.barItem1.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // barItem2
            // 
            this.barItem2.BarName = "barItem2";
            this.barItem2.CategoryIndex = 0;
            this.barItem2.ID = "Open";
            this.barItem2.ShowToolTipInPopUp = false;
            this.barItem2.SizeToFit = true;
            this.barItem2.Text = "Open";
            this.barItem2.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // barItem3
            // 
            this.barItem3.BarName = "barItem3";
            this.barItem3.CategoryIndex = 0;
            this.barItem3.ID = "Save";
            this.barItem3.ShowToolTipInPopUp = false;
            this.barItem3.SizeToFit = true;
            this.barItem3.Text = "Save";
            this.barItem3.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // barItem4
            // 
            this.barItem4.BarName = "barItem4";
            this.barItem4.CategoryIndex = 0;
            this.barItem4.ID = "SaveAs";
            this.barItem4.ShowToolTipInPopUp = false;
            this.barItem4.SizeToFit = true;
            this.barItem4.Text = "SaveAs";
            this.barItem4.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // barItem6
            // 
            this.barItem6.BarName = "barItem6";
            this.barItem6.CategoryIndex = 0;
            this.barItem6.ID = "Exit";
            this.barItem6.ShowToolTipInPopUp = false;
            this.barItem6.SizeToFit = true;
            this.barItem6.Text = "Exit";
            this.barItem6.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.BarName = "parentBarItem2";
            this.parentBarItem2.CategoryIndex = 1;
            this.parentBarItem2.ID = "PositionMenu";
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem7,
            this.barItem5,
            this.barItem8,
            this.barItem10,
            this.barItem11});
            this.parentBarItem2.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.parentBarItem2.ShowToolTipInPopUp = false;
            this.parentBarItem2.SizeToFit = true;
            this.parentBarItem2.Text = "Position Options";
            // 
            // barItem7
            // 
            this.barItem7.BarName = "barItem7";
            this.barItem7.CategoryIndex = 1;
            this.barItem7.ID = "MousePosition To VirtualPosition";
            this.barItem7.ShowToolTipInPopUp = false;
            this.barItem7.SizeToFit = true;
            this.barItem7.Text = "MousePosition To VirtualPosition";
            this.barItem7.Click += new System.EventHandler(this.menuItem10_Click);
            // 
            // barItem5
            // 
            this.barItem5.BarName = "barItem5";
            this.barItem5.CategoryIndex = 1;
            this.barItem5.ID = "MousePosition To PhysicalPosition";
            this.barItem5.ShowToolTipInPopUp = false;
            this.barItem5.SizeToFit = true;
            this.barItem5.Text = "MousePosition To PhysicalPosition";
            this.barItem5.Click += new System.EventHandler(this.menuItem11_Click);
            // 
            // barItem8
            // 
            this.barItem8.BarName = "barItem8";
            this.barItem8.CategoryIndex = 1;
            this.barItem8.ID = "CursorPosition To PhysicalPosition";
            this.barItem8.ShowToolTipInPopUp = false;
            this.barItem8.SizeToFit = true;
            this.barItem8.Text = "CursorPosition To PhysicalPosition";
            this.barItem8.Click += new System.EventHandler(this.menuItem13_Click);
            // 
            // barItem10
            // 
            this.barItem10.BarName = "barItem10";
            this.barItem10.CategoryIndex = 1;
            this.barItem10.ID = "VirtualPosition To Offset";
            this.barItem10.ShowToolTipInPopUp = false;
            this.barItem10.SizeToFit = true;
            this.barItem10.Text = "VirtualPosition To Offset";
            this.barItem10.Click += new System.EventHandler(this.menuItem16_Click);
            // 
            // barItem11
            // 
            this.barItem11.BarName = "barItem11";
            this.barItem11.CategoryIndex = 1;
            this.barItem11.ID = "Offset To VirtualPosition";
            this.barItem11.ShowToolTipInPopUp = false;
            this.barItem11.SizeToFit = true;
            this.barItem11.Text = "Offset To VirtualPosition";
            this.barItem11.Click += new System.EventHandler(this.menuItem14_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.ClientSize = new System.Drawing.Size(560, 454);
            this.Controls.Add(this.editControl1);
#if !NET5_0_OR_GREATER
            this.Controls.Add(this.statusBar1);
#endif
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MinimumSize = new System.Drawing.Size(572, 491);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Positions and Offsets";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
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
            this.editControl1.MouseDown += EditControl1_MouseDown;
            this.Padding = new System.Windows.Forms.Padding(0);
        }

        private void EditControl1_MouseDown(object sender, MouseEventArgs e)
        {
            Point p1, p2;

            p1 = this.editControl1.CurrentPosition;
            p2 = this.editControl1.ConvertVirtualPositionToPhysical(p1);
#if !NET5_0_OR_GREATER
            this.statusBarPanel1.Text = "CursorPosition : (" + p1.X.ToString() + "," + p1.Y.ToString() + ")          ";
            this.statusBarPanel1.Text += "PhysicalPosition : (" + p2.X.ToString() + "," + p2.Y.ToString() + ")";
#endif
        }
        #endregion

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

		private void menuItem10_Click(object sender, System.EventArgs e)
		{
            this.barItem7.Checked = true;
            this.barItem5.Checked = false;
            this.barItem8.Checked = false;
            this.barItem10.Checked = false;
            this.barItem11.Checked = false;
            Point p1, p2;
			
			p1 = this.editControl1.PointToClient(Control.MousePosition);
			p2 = this.editControl1.PointToVirtualPosition(p1);
#if !NET5_0_OR_GREATER
			this.statusBarPanel1.Text = "MousePosition : (" + p1.X.ToString() + "," + p1.Y.ToString() + ")          ";
			this.statusBarPanel1.Text += "VirtualPosition : (" + p2.X.ToString() + "," + p2.Y.ToString() + ")";
#endif
		}

		private void menuItem11_Click(object sender, System.EventArgs e)
		{
            this.barItem7.Checked = false;
            this.barItem5.Checked = true;
            this.barItem8.Checked = false;
            this.barItem10.Checked = false;
            this.barItem11.Checked = false;
            Point p1, p2;
			
			p1 = this.editControl1.PointToClient(Control.MousePosition);
			p2 = this.editControl1.PointToPhysicalPosition(p1);
#if !NET5_0_OR_GREATER
			this.statusBarPanel1.Text = "MousePosition : (" + p1.X.ToString() + "," + p1.Y.ToString() + ")          ";
			this.statusBarPanel1.Text += "PhysicalPosition : (" + p2.X.ToString() + "," + p2.Y.ToString() + ")";
#endif
		}

		private void menuItem13_Click(object sender, System.EventArgs e)
		{
            this.barItem7.Checked = false;
            this.barItem5.Checked = false;
            this.barItem8.Checked = true;
            this.barItem10.Checked = false;
            this.barItem11.Checked = false;
            Point p1, p2;
			
			p1 = this.editControl1.CurrentPosition;
			p2 = this.editControl1.ConvertVirtualPositionToPhysical(p1);
#if !NET5_0_OR_GREATER
			this.statusBarPanel1.Text = "CursorPosition : (" + p1.X.ToString() + "," + p1.Y.ToString() + ")          ";
			this.statusBarPanel1.Text += "PhysicalPosition : (" + p2.X.ToString() + "," + p2.Y.ToString() + ")";
#endif
		}

		private void menuItem16_Click(object sender, System.EventArgs e)
		{
            this.barItem7.Checked = false;
            this.barItem5.Checked = false;
            this.barItem8.Checked = false;
            this.barItem10.Checked = true;
            this.barItem11.Checked = false;
            Point p1;
			long offset;
			
			p1 = this.editControl1.CurrentPosition;
			offset = this.editControl1.ConvertVirtualPositionToOffset(p1);
#if !NET5_0_OR_GREATER
			this.statusBarPanel1.Text = "CursorPosition : (" + p1.X.ToString() + "," + p1.Y.ToString() + ")          ";
			this.statusBarPanel1.Text += "Offset : " + offset.ToString();
#endif
		}

		private void menuItem14_Click(object sender, System.EventArgs e)
		{
            this.barItem7.Checked = false;
            this.barItem5.Checked = false;
            this.barItem8.Checked = false;
            this.barItem10.Checked = false;
            this.barItem11.Checked = true;
            Point p1;
			long offset = 60;

			p1 = this.editControl1.ConvertOffsetToVirtualPosition(offset);
			this.editControl1.CurrentPosition = p1;
#if !NET5_0_OR_GREATER
			this.statusBarPanel1.Text = "CursorPosition : (" + p1.X.ToString() + "," + p1.Y.ToString() + ")          ";
			this.statusBarPanel1.Text += "Offset : " + offset.ToString();
#endif
		}

        private void menuItem4_Click(object sender, EventArgs e)
        {

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
