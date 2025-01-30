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
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Reflection;

using Syncfusion.Windows.Forms.Tools;
#if !NETCORE
using System.Data.SqlServerCe;
#endif
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;
using System.IO;

namespace ComboTest
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Splitter splitter1;
		private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBox2;

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textLog;
		private TabPageAdv tabPage1;
		private ComboTest.MultiColumnComboBoxSampleControl comboBoxAdvSampleControl1;
		private TabControlAdv tabControl1;

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
			this.comboBoxAdvSampleControl1.textLog = this.textLog;
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textLog = new System.Windows.Forms.TextBox();
            this.tabPage1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.comboBoxAdvSampleControl1 = new ComboTest.MultiColumnComboBoxSampleControl();
            this.tabControl1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(456, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 517);
            this.panel1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox2.Location = new System.Drawing.Point(3, 0);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(173, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 517);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.textLog);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 192);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Events:";
            // 
            // textLog
            // 
            this.textLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textLog.Location = new System.Drawing.Point(3, 16);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.Size = new System.Drawing.Size(506, 173);
            this.textLog.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.comboBoxAdvSampleControl1);
            this.tabPage1.Image = null;
            this.tabPage1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPage1.Location = new System.Drawing.Point(1, 18);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.ShowCloseButton = true;
            this.tabPage1.Size = new System.Drawing.Size(509, 242);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "ComboBoxAdv";
            this.tabPage1.ThemesEnabled = false;
            // 
            // comboBoxAdvSampleControl1
            // 
            this.comboBoxAdvSampleControl1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdvSampleControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxAdvSampleControl1.Location = new System.Drawing.Point(0, 0);
            this.comboBoxAdvSampleControl1.Name = "comboBoxAdvSampleControl1";
            this.comboBoxAdvSampleControl1.Size = new System.Drawing.Size(509, 242);
            this.comboBoxAdvSampleControl1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.ItemSize = new System.Drawing.Size(82, 18);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(512, 262);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.TabPanelBackColor = System.Drawing.Color.White;
            this.tabControl1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(512, 453);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(524, 486);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi Column ComboBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
        void Form1_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            //Access the database and get the NorthWind
#if !NETCORE
            SqlCeConnection conn = new SqlCeConnection();
            if (conn.ServerVersion.StartsWith("3.5"))
                conn.ConnectionString = "Data Source = " + (@"..\..\Common\Data\" + "NorthwindIO_3.5.sdf");
            else
                conn.ConnectionString = "Data Source = " + (@"..\..\Common\Data\" + "NorthwindIO.sdf");
            conn.Open();
            SqlCeDataAdapter adapter = new SqlCeDataAdapter("SELECT CompanyName, ContactName, City, Country, CustomerID FROM Customers ORDER BY CompanyName ", conn);
            adapter.Fill(table);
            //Bind the Data Table with the MultiColumnBoundCombobox DataSource
            this.comboBoxAdvSampleControl1.multiColumnBoundCombo.DataSource = table;
            this.comboBoxAdvSampleControl1.propertyGrid1.SelectedObject = this.comboBoxAdvSampleControl1.multiColumnBoundCombo;
            adapter.Dispose();
            conn.Close();
#else
            table.Columns.Add("CompanyName", typeof(string));
            table.Columns.Add("ContactName", typeof(string));
            table.Columns.Add("City", typeof(string));
            table.Columns.Add("Country", typeof(string));
            table.Columns.Add("CustomerID", typeof(string));

            // Add rows to the DataTable
            table.Rows.Add("Alfreds Futterkiste", "Maria Anders", "Berlin", "Germany", "ALFKI");
            table.Rows.Add("Ana Trujillo Emparedados y helados", "Ana Trujillo", "M�xico D.F.", "Mexico", "ANATR");
            table.Rows.Add("Antonio Moreno Taquer�a", "Antonio Moreno", "M�xico D.F.", "Mexico", "ANTON");
            table.Rows.Add("Around the Horn", "Thomas Hardy", "London", "UK", "AROUT");

            // Bind the DataTable to the ComboBoxAdv control
            this.comboBoxAdvSampleControl1.multiColumnBoundCombo.DataSource = table;
            this.comboBoxAdvSampleControl1.multiColumnBoundCombo.DisplayMember = "CompanyName"; // Column to display
            this.comboBoxAdvSampleControl1.multiColumnBoundCombo.ValueMember = "CustomerID";    // Column to use as value
            this.comboBoxAdvSampleControl1.propertyGrid1.SelectedObject = this.comboBoxAdvSampleControl1.multiColumnBoundCombo;
#endif
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
    interface IChildSampleControls
	{
		Control GetPrimaryItem();
	}
}
