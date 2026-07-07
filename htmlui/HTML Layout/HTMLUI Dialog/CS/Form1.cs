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
using System.IO;
using System.Reflection;

using Syncfusion.Windows.Forms.HTMLUI;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Edit;
using Syncfusion.Licensing;

namespace Syncfusion.Windows.Forms.HTMLUI.Samples
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
	{
		private Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl htmluiControl1;
		private StatusBarAdv statusBar1;

		static string filePath = null;

		Hashtable htmlelements = new Hashtable();
		ArrayList listUsers = new ArrayList();

		INPUTElementImpl txtFname;
		INPUTElementImpl txtLname;
		INPUTElementImpl txtUname;
        INPUTElementImpl txtPass;
        private Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
        private Tools.XPMenus.Bar bar1;
        private Tools.XPMenus.ParentBarItem parentBarItem1;
        private Tools.XPMenus.BarItem barItem1;
        private Tools.GradientPanel gradientPanel1;
        private StatusBarAdvPanel statusBarAdvPanel1;
        private EditControl editControl1;

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
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			UserClass oneUser = new UserClass("John", "Doe", "johndoe", "");
			this.listUsers.Add(oneUser);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.htmluiControl1 = new Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl();
            this.statusBar1 = new Syncfusion.Windows.Forms.Tools.StatusBarAdv();
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "HTMLUIDialog");
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.statusBarAdvPanel1 = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            ((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBar1)).BeginInit();
            this.statusBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // htmluiControl1
            // 
            this.htmluiControl1.AutoScroll = true;
            this.htmluiControl1.AutoScrollMinSize = new System.Drawing.Size(629, 359);
            this.htmluiControl1.BackColor = System.Drawing.Color.White;
            this.htmluiControl1.DefaultFormat.BackgroundColor = System.Drawing.SystemColors.Control;
            this.htmluiControl1.DefaultFormat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.htmluiControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmluiControl1.Location = new System.Drawing.Point(0, 0);
            this.htmluiControl1.Name = "htmluiControl1";
            this.htmluiControl1.ShowTitle = false;
            this.htmluiControl1.Size = new System.Drawing.Size(646, 374);
            this.htmluiControl1.TabIndex = 0;
            this.htmluiControl1.Text = resources.GetString("htmluiControl1.Text");
            this.htmluiControl1.LoadFinished += new System.EventHandler(this.htmluiControl1_LoadFinished);
            this.htmluiControl1.LoadError += new Syncfusion.Windows.Forms.HTMLUI.LoadErrorEventHandler(this.htmluiControl1_LoadError);
            // 
            // statusBar1
            // 
            this.statusBar1.Controls.Add(this.statusBarAdvPanel1);
            this.statusBar1.CustomLayoutBounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.statusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBar1.Location = new System.Drawing.Point(10, 415);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Padding = new System.Windows.Forms.Padding(10);
            this.statusBar1.Size = new System.Drawing.Size(648, 30);
            this.statusBar1.Spacing = new System.Drawing.Size(2, 2);
            this.statusBar1.TabIndex = 1;
            this.statusBar1.Text = "statusBar1";
            // 
            // mainFrameBarManager1
            // 
#if !NETCORE
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
#endif
            this.mainFrameBarManager1.Bars.Add(this.bar1);
            this.mainFrameBarManager1.Categories.Add("File");
            this.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.MetroForm";
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.barItem1});
            this.mainFrameBarManager1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.mainFrameBarManager1.ResetCustomization = false;
            this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // bar1
            // 
            this.bar1.BarName = "HTMLUIDialog";
            this.bar1.Caption = "HTMLUIDialog";
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1});
            this.bar1.Manager = this.mainFrameBarManager1;
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.BarName = "parentBarItem1";
            this.parentBarItem1.CategoryIndex = 0;
            this.parentBarItem1.ID = "File";
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1});
            this.parentBarItem1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem1.Text = "File";
            // 
            // barItem1
            // 
            this.barItem1.BarName = "barItem1";
            this.barItem1.CategoryIndex = 0;
            this.barItem1.ID = "View Source";
            this.barItem1.ShowToolTipInPopUp = false;
            this.barItem1.SizeToFit = true;
            this.barItem1.Text = "View Source";
            this.barItem1.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.htmluiControl1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(10, 39);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(648, 376);
            this.gradientPanel1.TabIndex = 4;
            // 
            // statusBarAdvPanel1
            // 
            this.statusBarAdvPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusBarAdvPanel1.Location = new System.Drawing.Point(0, 2);
            this.statusBarAdvPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.statusBarAdvPanel1.Name = "statusBarAdvPanel1";
            this.statusBarAdvPanel1.Size = new System.Drawing.Size(579, 22);
            this.statusBarAdvPanel1.TabIndex = 0;
            this.statusBarAdvPanel1.Text = "statusBarAdvPanel1";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClientSize = new System.Drawing.Size(668, 455);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.statusBar1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.IconTextRelation = System.Windows.Forms.LeftRightAlignment.Left;
            this.MetroColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(680, 491);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTMLUI Dialog";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBar1)).EndInit();
            this.statusBar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel1)).EndInit();
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

		private void htmluiControl1_LoadError(object sender, Syncfusion.Windows.Forms.HTMLUI.LoadErrorEventArgs e)
		{
			this.statusBarAdvPanel1.Text = "Load failed " + e.Document.FileName + " " +e.Document.RenderException.Message;
		}

		private void htmluiControl1_LoadFinished(object sender, System.EventArgs e)
		{
			try
			{

                this.statusBarAdvPanel1.Text = "Load succeeded.";

				string path = String.Empty;

				if(this.htmluiControl1.Document.Uri != null)
					path = this.htmluiControl1.Document.Uri.LocalPath;
				else
					path = this.htmluiControl1.Document.FileName;

				if(path == GetFilesLocation() + "viewusers.htm")
				{
					htmlelements = this.htmluiControl1.Document.GetElementsByUserIdHash();
					BaseElement list = htmlelements["allusersList"] as BaseElement;
					string listString = String.Empty;;
					foreach(UserClass c in this.listUsers)
					{
						listString += c.userName + "(" + c.fName+ " " + c.lName+ ")<p/>";
					}
					list.InnerHTML = listString;
				}
				else if(path  == GetFilesLocation() + "createuser.htm")
				{
					htmlelements = this.htmluiControl1.Document.GetElementsByUserIdHash();

					BaseElement cuBtn = htmlelements["createUserBtn"] as BaseElement;
					BaseElement caBtn = htmlelements["cancelUserBtn"] as BaseElement;

					txtFname = htmlelements["FirstName"] as INPUTElementImpl;
					txtLname = htmlelements["LastName"] as INPUTElementImpl;
					txtUname = htmlelements["username"] as INPUTElementImpl;
					txtPass = htmlelements["password"] as INPUTElementImpl;

					cuBtn.Click += new EventHandler( cuBtn_Click );
					caBtn.Click += new EventHandler( caBtn_Click );
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			LoadFromFile("main.htm");
		}

		private void caBtn_Click( object sender, EventArgs e )
		{
			LoadFromFile("main.htm");
		}

		private void cuBtn_Click( object sender, EventArgs e )
		{
			htmlelements = this.htmluiControl1.Document.GetElementsByUserIdHash();

			BaseElement errorElem = htmlelements["errormsg"] as BaseElement;

			string errorMsg = "The following errors were encountered <br/>";
			string fname = txtFname.UserControl.CustomControl.Text.Trim();
			string lname =  txtLname.UserControl.CustomControl.Text.Trim();
			string uname = txtUname.UserControl.CustomControl.Text.Trim();
			string pass = txtPass.UserControl.CustomControl.Text.Trim();

			bool proceed = true;

			if( fname == String.Empty)
			{
				errorMsg  += "First Name is required<br/>";
				proceed = false;
			}

			if(lname == String.Empty)
			{
				errorMsg  += "Last Name is required<br/>";
				proceed = false;
			}

			if(uname == String.Empty)
			{
				errorMsg  += "User Name is required<br/>";
				proceed = false;
			}

			if(pass == String.Empty)
			{
				errorMsg  += "Password is required<br/>";
				proceed = false;
			}

			if(proceed)
			{
				UserClass newUser = new UserClass(fname ,lname ,uname ,pass );
				this.listUsers.Add(newUser);
				LoadFromFile("viewusers.htm");
			}
			else
			{
				errorElem.InnerHTML = errorMsg;
			}
		}

		private void LoadFromFile(string fileName)
		{
			string filePath = GetFilesLocation() + fileName;
			this.htmluiControl1.LoadHTML(filePath);
		}

		static string GetFilesLocation()
		{
			if(filePath != null)
				return filePath;

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
			filePath = path + "\\files\\";
			return filePath;
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
            Form form1 = new MetroForm();
            form1.Text = "Script";
            form1.ShowIcon = false;
            form1.StartPosition = FormStartPosition.CenterScreen;
            this.editControl1 = new EditControl();
            editControl1.ScrollVisualStyle = ScrollBarCustomDrawStyles.Metro;
            this.editControl1.Dock = DockStyle.Fill;
            this.editControl1.ShowLineNumbers = false;
            this.editControl1.ShowOutliningCollapsers = false;
            this.editControl1.SaveOnClose = false;
            this.editControl1.ReadOnly = true;
            this.editControl1.ShowVerticalSplitters = false;
            this.editControl1.ShowHorizontalSplitters = false;
            this.editControl1.ShowIndicatorMargin = false;
            editControl1.ApplyConfiguration(Edit.Enums.KnownLanguages.HTML);
            form1.Controls.Add(editControl1);
            form1.Size = new System.Drawing.Size(600, 500);
            this.editControl1.Text = this.htmluiControl1.Text;
            form1.ShowDialog();      
		}

		private class UserClass
		{
			public string fName;
			public string lName;
			public string userName;
			public string password;

			public UserClass(string fName, string lName,string userName, string password)
			{
				this.fName = fName;
				this.lName = lName;
				this.userName = userName;
				this.password = password;
			}
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
