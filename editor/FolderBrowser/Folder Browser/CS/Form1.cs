#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
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
using System.Data;
using System.IO;
using Syncfusion.Licensing;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Controls;

namespace FolderBrowserDemo
{
	public class frmFolderBrowser : SfForm
	{
		private Syncfusion.Windows.Forms.FolderBrowser folderBrowser1;
        private Syncfusion.Windows.Forms.FolderBrowser folderBrowser2;
        private Syncfusion.Windows.Forms.FolderBrowser folderBrowser3;
        private ButtonAdv buttonAdv7;
        private ButtonAdv buttonAdv4;
        private ButtonAdv buttonAdv3;
        private ButtonAdv buttonAdv2;
        private ButtonAdv buttonAdv1;
        private ButtonAdv buttonAdv5;
        private Label label5;
        private SfToolTip sfToolTip1;
        private System.ComponentModel.IContainer components;

        public frmFolderBrowser()
		{
			InitializeComponent();		
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }


		}

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


		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFolderBrowser));
            this.buttonAdv7 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv4 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv5 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label5 = new System.Windows.Forms.Label();
            this.sfToolTip1 = new Syncfusion.Windows.Forms.SfToolTip(this.components);
            this.SuspendLayout();
            // 
            // buttonAdv7
            // 
            this.buttonAdv7.BeforeTouchSize = new System.Drawing.Size(136, 34);
            this.buttonAdv7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdv7.Font = new System.Drawing.Font("Segoe UI", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv7.IsBackStageButton = false;
            this.buttonAdv7.Location = new System.Drawing.Point(375, 191);
            this.buttonAdv7.Name = "buttonAdv7";
            this.buttonAdv7.Size = new System.Drawing.Size(136, 34);
            this.buttonAdv7.TabIndex = 20;
            this.buttonAdv7.Text = "Custom location";
            this.buttonAdv7.ThemeName = "Office2019Colorful";
            this.sfToolTip1.SetToolTip(this.buttonAdv7, "Custom start location can be given for Folder Browser ");
            this.buttonAdv7.Click += new System.EventHandler(this.buttonAdv7_Click);
            // 
            // buttonAdv4
            // 
            this.buttonAdv4.BeforeTouchSize = new System.Drawing.Size(136, 34);
            this.buttonAdv4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdv4.Font = new System.Drawing.Font("Segoe UI", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv4.IsBackStageButton = false;
            this.buttonAdv4.Location = new System.Drawing.Point(534, 127);
            this.buttonAdv4.Name = "buttonAdv4";
            this.buttonAdv4.Size = new System.Drawing.Size(136, 34);
            this.buttonAdv4.TabIndex = 17;
            this.buttonAdv4.Text = "ShowTextBox";
            this.buttonAdv4.ThemeName = "Office2019Colorful";
            this.sfToolTip1.SetToolTip(this.buttonAdv4, "Selected file or folder will be displayed in a textbox.");
            this.buttonAdv4.Click += new System.EventHandler(this.buttonAdv4_Click);
            // 
            // buttonAdv3
            // 
            this.buttonAdv3.BeforeTouchSize = new System.Drawing.Size(136, 34);
            this.buttonAdv3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdv3.Font = new System.Drawing.Font("Segoe UI", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv3.IsBackStageButton = false;
            this.buttonAdv3.Location = new System.Drawing.Point(369, 127);
            this.buttonAdv3.Name = "buttonAdv3";
            this.buttonAdv3.Size = new System.Drawing.Size(136, 34);
            this.buttonAdv3.TabIndex = 16;
            this.buttonAdv3.Text = "NewDialogStyle";
            this.buttonAdv3.ThemeName = "Office2019Colorful";
            this.sfToolTip1.SetToolTip(this.buttonAdv3, "Folder Browser will have an option to create a new folder and is resizable");
            this.buttonAdv3.Click += new System.EventHandler(this.buttonAdv3_Click);
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.BeforeTouchSize = new System.Drawing.Size(136, 34);
            this.buttonAdv2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdv2.Font = new System.Drawing.Font("Segoe UI", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv2.IsBackStageButton = false;
            this.buttonAdv2.Location = new System.Drawing.Point(204, 127);
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Size = new System.Drawing.Size(136, 34);
            this.buttonAdv2.TabIndex = 15;
            this.buttonAdv2.Text = "BrowseForEverything";
            this.buttonAdv2.ThemeName = "Office2019Colorful";
            this.sfToolTip1.SetToolTip(this.buttonAdv2, "Displays the files and folders available in the system");
            this.buttonAdv2.Click += new System.EventHandler(this.buttonAdv2_Click);
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(136, 34);
            this.buttonAdv1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdv1.Font = new System.Drawing.Font("Segoe UI", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.Location = new System.Drawing.Point(39, 127);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(136, 34);
            this.buttonAdv1.TabIndex = 14;
            this.buttonAdv1.Text = "BrowseForComputer";
            this.buttonAdv1.ThemeName = "Office2019Colorful";
            this.sfToolTip1.SetToolTip(this.buttonAdv1, "Displays the drivers and folders available in MyComputer.");
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // buttonAdv5
            // 
            this.buttonAdv5.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.buttonAdv5.BeforeTouchSize = new System.Drawing.Size(136, 34);
            this.buttonAdv5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdv5.Font = new System.Drawing.Font("Segoe UI", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv5.IsBackStageButton = false;
            this.buttonAdv5.Location = new System.Drawing.Point(198, 191);
            this.buttonAdv5.Name = "buttonAdv5";
            this.buttonAdv5.Size = new System.Drawing.Size(136, 34);
            this.buttonAdv5.TabIndex = 18;
            this.buttonAdv5.Text = "ShowAdministrativeShares";
            this.buttonAdv5.ThemeName = "Office2019Colorful";
            this.sfToolTip1.SetToolTip(this.buttonAdv5, "Displays administrative shares existing on the system");
            this.buttonAdv5.Click += new System.EventHandler(this.buttonAdv5_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.label5.Location = new System.Drawing.Point(8, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(693, 38);
            this.label5.TabIndex = 19;
            this.label5.Text = "The following sample demonstrates the default functionalities of FolderBrowser,cl" +
    "ick on the below buttons to see the various browsing capabilities available.";
            // 
            // frmFolderBrowser
            // 
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 353);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAdv7);
            this.Controls.Add(this.buttonAdv4);
            this.Controls.Add(this.buttonAdv3);
            this.Controls.Add(this.buttonAdv2);
            this.Controls.Add(this.buttonAdv1);
            this.Controls.Add(this.buttonAdv5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFolderBrowser";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folder Browser";
            this.Load += new System.EventHandler(this.frmFolderBrowser_Load_1);
            this.ResumeLayout(false);

		}
        #endregion

        [STAThread]
        static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            SkinManager.LoadAssembly(typeof(Syncfusion.WinForms.Themes.Office2019Theme).Assembly);
            Application.Run(new frmFolderBrowser());
        }

        private void frmFolderBrowser_Load_1(object sender, EventArgs e)
        {
            this.buttonAdv1.Focus();
            this.folderBrowser1 = new FolderBrowser();
            this.folderBrowser2 = new FolderBrowser();
            this.folderBrowser3 = new FolderBrowser();
            Label label = new Label();
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            this.folderBrowser1.StartLocation = FolderBrowserFolder.MyComputer;
            this.folderBrowser1.Style = FolderBrowserStyles.BrowseForComputer;
            this.folderBrowser1.Description = "Displays the drivers and folders available in MyComputer";
            this.folderBrowser1.ShowDialog();
        }

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            this.folderBrowser1.StartLocation = FolderBrowserFolder.Desktop;
            this.folderBrowser1.Style = FolderBrowserStyles.BrowseForEverything;
            this.folderBrowser1.Description = "Displays the files and folders available in the system";
            this.folderBrowser1.ShowDialog();
        }

        private void buttonAdv3_Click(object sender, EventArgs e)
        {
            this.folderBrowser1.Style = FolderBrowserStyles.NewDialogStyle;
            this.folderBrowser1.Description = "Folder Browser will have an option to create a new folder and is resizable";
            this.folderBrowser1.ShowDialog();
        }

        private void buttonAdv4_Click(object sender, EventArgs e)
        {
            this.folderBrowser1.Style = FolderBrowserStyles.ShowTextBox;
            this.folderBrowser1.Description = "Selected file or folder will be displayed in a textbox";
            this.folderBrowser1.ShowDialog();
        }

        private void buttonAdv5_Click(object sender, EventArgs e)
        {
            this.folderBrowser3.Style = FolderBrowserStyles.NewDialogStyle| FolderBrowserStyles.ShowAdministrativeShares;
            this.folderBrowser3.Description = "Displays administrative shares existing on the system";
            this.folderBrowser3.ShowDialog();
        }

        private void buttonAdv7_Click(object sender, EventArgs e)
        {
            this.folderBrowser2.Description = "Custom start location can be given for Folder Browser";
            this.folderBrowser2.StartLocation = FolderBrowserFolder.MyPictures;
            this.folderBrowser2.ShowDialog();
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
