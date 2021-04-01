#region Copyright Syncfusion Inc. 2001 - 2019
//
//  Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
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
using Syncfusion.Licensing;
using System.IO;

namespace Syncfusion.Windows.Forms.HTMLUI.Samples
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
	{
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private IContainer components;
		private Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl htmluiControl1;
		private System.Windows.Forms.ContextMenuStrip cxtMenu;
        private ScrollersFrame scrollersFrame1;
        private Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
        private Tools.XPMenus.Bar bar1;
        private Tools.XPMenus.ParentBarItem parentBarItem1;
        private Tools.XPMenus.BarItem barItem1;
        private Tools.XPMenus.BarItem barItem2;
        private Tools.XPMenus.ParentBarItem parentBarItem2;
        private Tools.XPMenus.BarItem barItem3;
        private Tools.XPMenus.ParentBarItem parentBarItem3;
        private Tools.XPMenus.BarItem barItem4;
		private System.Windows.Forms.ToolStripMenuItem cxtEdit;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

        #region Function

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

        #endregion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.htmluiControl1 = new Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl();
            this.cxtMenu = new System.Windows.Forms.ContextMenuStrip();
            this.cxtEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.scrollersFrame1 = new Syncfusion.Windows.Forms.ScrollersFrame(this.components);
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "HTMLUIEditor");
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.htmluiControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 392);
            this.panel1.TabIndex = 0;
            // 
            // htmluiControl1
            // 
            this.htmluiControl1.AutoScroll = true;
            this.htmluiControl1.AutoScrollMinSize = new System.Drawing.Size(602, 375);
            this.htmluiControl1.BackColor = System.Drawing.Color.White;
            this.htmluiControl1.ContextMenuStrip = this.cxtMenu;
            this.htmluiControl1.DefaultFormat.BackgroundColor = System.Drawing.SystemColors.Control;
            this.htmluiControl1.DefaultFormat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.htmluiControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmluiControl1.Location = new System.Drawing.Point(0, 0);
            this.htmluiControl1.Name = "htmluiControl1";
            this.htmluiControl1.Size = new System.Drawing.Size(619, 390);
            this.htmluiControl1.TabIndex = 0;
            this.htmluiControl1.Text = "htmluiControl1";
            this.htmluiControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.htmluiControl1_KeyDown);
            // 
            // cxtMenu
            // 
            this.cxtMenu.Items.AddRange(new System.Windows.Forms.ToolStripMenuItem[] {
            this.cxtEdit});
            // 
            // cxtEdit
            // 
            this.cxtEdit.MergeIndex = 0;
            this.cxtEdit.Text = "Edit HTML";
            this.cxtEdit.Click += new System.EventHandler(this.cxtEdit_Click);
            // 
            // openFileDlg
            // 
            this.openFileDlg.Filter = "html files|*.html|htm files|*.htm";
            // 
            // scrollersFrame1
            // 
            this.scrollersFrame1.AttachedTo = this.htmluiControl1;
            this.scrollersFrame1.CustomRender = null;
            this.scrollersFrame1.MetroColorScheme = Syncfusion.Windows.Forms.MetroColorScheme.Managed;
            this.scrollersFrame1.SizeGripperVisibility = Syncfusion.Windows.Forms.SizeGripperVisibility.Auto;
            this.scrollersFrame1.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Metro;
            // 
            // mainFrameBarManager1
            // 
#if !NETCORE
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
#endif
            this.mainFrameBarManager1.Bars.Add(this.bar1);
            this.mainFrameBarManager1.Categories.Add("File");
            this.mainFrameBarManager1.Categories.Add("Edit");
            this.mainFrameBarManager1.Categories.Add("View");
            this.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.MetroForm";
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.barItem1,
            this.barItem2,
            this.parentBarItem2,
            this.barItem3,
            this.parentBarItem3,
            this.barItem4});
            this.mainFrameBarManager1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.mainFrameBarManager1.ResetCustomization = false;
            this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // bar1
            // 
            this.bar1.BarName = "HTMLUIEditor";
            this.bar1.Caption = "HTMLUIEditor";
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.parentBarItem2,
            this.parentBarItem3});
            this.bar1.Manager = this.mainFrameBarManager1;
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.BarName = "parentBarItem1";
            this.parentBarItem1.CategoryIndex = 0;
            this.parentBarItem1.ID = "File";
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem2});
            this.parentBarItem1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.Text = "File";
            // 
            // barItem1
            // 
            this.barItem1.BarName = "barItem1";
            this.barItem1.CategoryIndex = 0;
            this.barItem1.ID = "Open";
            this.barItem1.ShowToolTipInPopUp = false;
            this.barItem1.SizeToFit = true;
            this.barItem1.Text = "Open";
            this.barItem1.Click += new System.EventHandler(this.Open_Click);
            // 
            // barItem2
            // 
            this.barItem2.BarName = "barItem2";
            this.barItem2.CategoryIndex = 0;
            this.barItem2.ID = "Exit";
            this.barItem2.ShowToolTipInPopUp = false;
            this.barItem2.SizeToFit = true;
            this.barItem2.Text = "Exit";
            this.barItem2.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.BarName = "parentBarItem2";
            this.parentBarItem2.CategoryIndex = 1;
            this.parentBarItem2.ID = "Edit";
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem3});
            this.parentBarItem2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem2.ShowToolTipInPopUp = false;
            this.parentBarItem2.SizeToFit = true;
            this.parentBarItem2.Text = "Edit";
            // 
            // barItem3
            // 
            this.barItem3.BarName = "barItem3";
            this.barItem3.CategoryIndex = 1;
            this.barItem3.ID = "Edit HTML";
            this.barItem3.ShowToolTipInPopUp = false;
            this.barItem3.SizeToFit = true;
            this.barItem3.Text = "Edit HTML";
            this.barItem3.Click += new System.EventHandler(this.MenuEdit_Click);
            // 
            // parentBarItem3
            // 
            this.parentBarItem3.BarName = "parentBarItem3";
            this.parentBarItem3.CategoryIndex = 2;
            this.parentBarItem3.ID = "View";
            this.parentBarItem3.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem4});
            this.parentBarItem3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem3.ShowToolTipInPopUp = false;
            this.parentBarItem3.SizeToFit = true;
            this.parentBarItem3.Text = "View";
            // 
            // barItem4
            // 
            this.barItem4.BarName = "barItem4";
            this.barItem4.CategoryIndex = 2;
            this.barItem4.ID = "HTML Source";
            this.barItem4.ShowToolTipInPopUp = false;
            this.barItem4.SizeToFit = true;
            this.barItem4.Text = "HTML Source";
            this.barItem4.Click += new System.EventHandler(this.HTMLSource_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClientSize = new System.Drawing.Size(641, 441);
            this.Controls.Add(this.panel1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(653, 477);
            this.IconTextRelation = System.Windows.Forms.LeftRightAlignment.Left;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTMLUI Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).EndInit();
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
            Application.Run(new Form1());
		}

		#region ClassEvents
		private void Open_Click(object sender, System.EventArgs e)
		{
			this.openFileDlg.InitialDirectory = GetFilesLocation();;
			if(openFileDlg.ShowDialog() == DialogResult.OK)
			{
				string fileName = this.openFileDlg.FileName.ToString();
				this.htmluiControl1.LoadHTML(fileName);
			}
		}

		private void MenuExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void MenuEdit_Click(object sender, System.EventArgs e)
		{
			OpenEditForm();
		}

		private void HTMLSource_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(this.htmluiControl1.Text.ToString());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.LoadFromFile("products.htm");
		}

		private void cxtEdit_Click(object sender, System.EventArgs e)
		{
			OpenEditForm();
		}

		private void htmluiControl1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.Alt == true && e.KeyCode == Keys.E)
			{
				OpenEditForm();
			}
		}
		#endregion

		#region ClassMethods
		/// <summary>
		/// Loads the main HTMLUI control with the specified file
		/// </summary>
		/// <param name="fileName">Name of the file to be loaded.</param>
		private void LoadFromFile(string fileName)
		{
			string filePath = GetFilesLocation() + fileName;
			this.htmluiControl1.LoadHTML(filePath);
		}

		/// <summary>
		/// Gets the project location
		/// </summary>
		/// <returns>string</returns>
		static string GetFilesLocation()
		{
			string path;
			path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase );
			int slashPos = path.LastIndexOf("\\",path.Length);
			slashPos = path.LastIndexOf("\\",slashPos-1);
			slashPos = path.LastIndexOf("\\",slashPos-1);
#if NETCORE
            slashPos = path.LastIndexOf("\\", slashPos - 1);
#endif
            if (slashPos > 0)
				path = path.Substring(0,slashPos);
			path = path.Replace("file:\\", "");
			path = path + "\\files\\";
			return path;
		}

		/// <summary>
		/// Opens the editor dialog to edit the html.
		/// </summary>
		private void OpenEditForm()
		{
			editForm edit = new editForm(this.htmluiControl1.Text);
			if(edit.ShowDialog() == DialogResult.OK)
			{
				this.htmluiControl1.LoadFromString(edit.newHtml.ToString());
			}
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
