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
using Syncfusion.Licensing;

using Syncfusion.Windows.Forms.HTMLUI;

namespace Syncfusion.Windows.Forms.HTMLUI.Samples
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
	{
		Assembly _assembly;
		Stream _htmlStream;

		private Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl htmluiControl1;

		IHTMLElement[] descriptions = null;
		private System.Windows.Forms.Panel panel1;

		private Point beginPoint, endPoint = Point.Empty;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
        private Panel panel4;
		private System.Windows.Forms.Label label1;

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
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.htmluiControl1 = new Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // htmluiControl1
            // 
            this.htmluiControl1.AutoScroll = true;
            this.htmluiControl1.AutoScrollMinSize = new System.Drawing.Size(442, 427);
            this.htmluiControl1.BackColor = System.Drawing.Color.White;
            this.htmluiControl1.DefaultFormat.BackgroundColor = System.Drawing.SystemColors.Control;
            this.htmluiControl1.DefaultFormat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.htmluiControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmluiControl1.Location = new System.Drawing.Point(0, 0);
            this.htmluiControl1.Name = "htmluiControl1";
            this.htmluiControl1.ShowTitle = false;
            this.htmluiControl1.Size = new System.Drawing.Size(459, 442);
            this.htmluiControl1.TabIndex = 0;
            this.htmluiControl1.Text = resources.GetString("htmluiControl1.Text");
            this.htmluiControl1.LoadFinished += new System.EventHandler(this.htmluiControl1_LoadFinished);
            this.htmluiControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.htmluiControl1_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(480, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 446);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(8, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 256);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(148, 252);
            this.panel3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(2, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 88);
            this.label3.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(2, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 84);
            this.label2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 56);
            this.label1.TabIndex = 7;
            this.label1.Text = "Click on the product descriptions to get their coordinates";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.htmluiControl1);
            this.panel4.Location = new System.Drawing.Point(13, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(461, 444);
            this.panel4.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(658, 467);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.DropShadow = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(670, 503);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Element Coordinates";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
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

		private void Form1_Load(object sender, System.EventArgs e)
		{
			LoadHTMLResource();			
		}

		private bool LoadHTMLResource()
		{
			bool success = false;

			try
			{
				_assembly = Assembly.GetExecutingAssembly();
				_htmlStream = (Stream)_assembly.GetManifestResourceStream("Syncfusion.Windows.Forms.HTMLUI.Samples.products.htm");
				if(_htmlStream != null)
				{
					this.htmluiControl1.LoadHTML(_htmlStream);
					success = true;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return success;
		}

		private void description_Click( object sender, EventArgs e )
		{
			BaseElement element = sender as BaseElement;
			beginPoint = element.Location;
            if (htmluiControl1.AutoScrollPosition.Y != 0)
                beginPoint.Y += htmluiControl1.AutoScrollPosition.Y;
			endPoint = new Point(beginPoint.X+element.Size.Width,beginPoint.Y+element.Size.Height);
			this.label2.Text = "Element begins at " + beginPoint.ToString() + " and ends at " +  endPoint.ToString();
			this.label3.Text = "Element's Height\n" + element.Height.ToString() + "\n\nElement's Width\n" + element.Width.ToString();
			this.htmluiControl1.Refresh();
			
		}

		private void htmluiControl1_LoadFinished(object sender, System.EventArgs e)
		{
			descriptions = this.htmluiControl1.Document.GetElementsByName("description");

			foreach (IHTMLElement description in descriptions)
			{
				description.Click += new EventHandler( description_Click );
			}
		}

		private void htmluiControl1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			if(beginPoint != Point.Empty  && endPoint != Point.Empty)
			{
				Size sz = new Size(endPoint.X - beginPoint.X,endPoint.Y-beginPoint.Y);
				Rectangle rect = new Rectangle(beginPoint,sz);
				e.Graphics.DrawRectangle(new Pen(Color.Red),rect);
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
