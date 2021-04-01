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
		private Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl htmluiControl1;
		Assembly _assembly;
		Stream _htmlStream;

		Hashtable htmlelements = new Hashtable();

		BaseElement text1Element;
		BaseElement radio1Element;
		BaseElement checkBox1Element;
		BaseElement image1Element;
		BaseElement button1Element;
		BaseElement outputCellElement;
        private System.Windows.Forms.Label label1;
        private ScrollersFrame scrollersFrame1;
        private Tools.GradientPanel gradientPanel1;
        private IContainer components;

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
            this.htmluiControl1 = new Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl();
            this.label1 = new System.Windows.Forms.Label();
            this.scrollersFrame1 = new Syncfusion.Windows.Forms.ScrollersFrame(this.components);
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // htmluiControl1
            // 
            this.htmluiControl1.AutoScroll = true;
            this.htmluiControl1.AutoScrollMinSize = new System.Drawing.Size(572, 302);
            this.htmluiControl1.BackColor = System.Drawing.Color.White;
            this.htmluiControl1.DefaultFormat.BackgroundColor = System.Drawing.SystemColors.Control;
            this.htmluiControl1.DefaultFormat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.htmluiControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmluiControl1.Location = new System.Drawing.Point(0, 0);
            this.htmluiControl1.Name = "htmluiControl1";
            this.htmluiControl1.ShowTitle = false;
            this.htmluiControl1.Size = new System.Drawing.Size(589, 317);
            this.htmluiControl1.TabIndex = 0;
            this.htmluiControl1.Text = resources.GetString("htmluiControl1.Text");
            this.htmluiControl1.LoadFinished += new System.EventHandler(this.htmluiControl1_LoadFinished);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "HTMLUI Element Events";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scrollersFrame1
            // 
            this.scrollersFrame1.AttachedTo = this.htmluiControl1;
            this.scrollersFrame1.CustomRender = null;
            this.scrollersFrame1.MetroColorScheme = Syncfusion.Windows.Forms.MetroColorScheme.Managed;
            this.scrollersFrame1.SizeGripperVisibility = Syncfusion.Windows.Forms.SizeGripperVisibility.Auto;
            this.scrollersFrame1.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Metro;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanel1.Controls.Add(this.htmluiControl1);
            this.gradientPanel1.Location = new System.Drawing.Point(10, 92);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(593, 321);
            this.gradientPanel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClientSize = new System.Drawing.Size(613, 426);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.label1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.IconTextRelation = System.Windows.Forms.LeftRightAlignment.Left;
            this.MetroColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(625, 462);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Element Events";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
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

		private bool LoadHTMLResource()
		{
			bool success = false;

			try
			{
				_assembly = Assembly.GetExecutingAssembly();
				_htmlStream = (Stream)_assembly.GetManifestResourceStream("Syncfusion.Windows.Forms.HTMLUI.Samples.events.htm");
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

		private void WireElements()
		{
			try
			{
				htmlelements = this.htmluiControl1.Document.GetElementsByUserIdHash();

				this.text1Element  = htmlelements["Text1"] as BaseElement;
				this.radio1Element = htmlelements["Radio1"] as BaseElement;
				this.checkBox1Element = htmlelements["CheckBox1"] as BaseElement;
				this.image1Element = htmlelements["Image1"] as BaseElement;
				this.button1Element = htmlelements["Button1"] as BaseElement;
				this.outputCellElement = htmlelements["outputCell"] as BaseElement;

				this.text1Element.Click += new EventHandler( element_Click );
				this.text1Element.DoubleClick += new EventHandler( element_DoubleClick );
				this.text1Element.KeyDown += new EventHandler( element_KeyDown );
				this.text1Element.KeyPress += new EventHandler( element_KeyPress );
				this.text1Element.KeyUp  += new EventHandler( element_KeyUp );
				this.text1Element.MouseDown += new EventHandler( element_MouseDown );
				this.text1Element.MouseEnter += new EventHandler( element_MouseEnter );
				this.text1Element.MouseLeave += new EventHandler( element_MouseLeave );
				this.text1Element.MouseMove += new EventHandler( element_MouseMove );

				this.radio1Element.Click += new EventHandler( element_Click );
				this.radio1Element.DoubleClick += new EventHandler( element_DoubleClick );
				this.radio1Element.KeyDown += new EventHandler( element_KeyDown );
				this.radio1Element.KeyPress += new EventHandler( element_KeyPress );
				this.radio1Element.KeyUp  += new EventHandler( element_KeyUp );
				this.radio1Element.MouseDown += new EventHandler( element_MouseDown );
				this.radio1Element.MouseEnter += new EventHandler( element_MouseEnter );
				this.radio1Element.MouseLeave += new EventHandler( element_MouseLeave );
				this.radio1Element.MouseMove += new EventHandler( element_MouseMove );


				this.checkBox1Element.Click += new EventHandler( element_Click );
				this.checkBox1Element.DoubleClick += new EventHandler( element_DoubleClick );
				this.checkBox1Element.KeyDown += new EventHandler( element_KeyDown );
				this.checkBox1Element.KeyPress += new EventHandler( element_KeyPress );
				this.checkBox1Element.KeyUp  += new EventHandler( element_KeyUp );
				this.checkBox1Element.MouseDown += new EventHandler( element_MouseDown );
				this.checkBox1Element.MouseEnter += new EventHandler( element_MouseEnter );
				this.checkBox1Element.MouseLeave += new EventHandler( element_MouseLeave );
				this.checkBox1Element.MouseMove += new EventHandler( element_MouseMove );

				this.image1Element.Click += new EventHandler( element_Click );
				this.image1Element.DoubleClick += new EventHandler( element_DoubleClick );
				this.image1Element.KeyDown += new EventHandler( element_KeyDown );
				this.image1Element.KeyPress += new EventHandler( element_KeyPress );
				this.image1Element.KeyUp  += new EventHandler( element_KeyUp );
				this.image1Element.MouseDown += new EventHandler( element_MouseDown );
				this.image1Element.MouseEnter += new EventHandler( element_MouseEnter );
				this.image1Element.MouseLeave += new EventHandler( element_MouseLeave );
				this.image1Element.MouseMove += new EventHandler( element_MouseMove );

				this.button1Element.Click += new EventHandler( element_Click );
				this.button1Element.DoubleClick += new EventHandler( element_DoubleClick );
				this.button1Element.KeyDown += new EventHandler( element_KeyDown );
				this.button1Element.KeyPress += new EventHandler( element_KeyPress );
				this.button1Element.KeyUp  += new EventHandler( element_KeyUp );
				this.button1Element.MouseDown += new EventHandler( element_MouseDown );
				this.button1Element.MouseEnter += new EventHandler( element_MouseEnter );
				this.button1Element.MouseLeave += new EventHandler( element_MouseLeave );
				this.button1Element.MouseMove += new EventHandler( element_MouseMove );
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		private void element_Click( object sender, EventArgs e )
		{
			OutputEvent(sender, " - Click");
		}

		private void element_DoubleClick( object sender, EventArgs e )
		{
			OutputEvent(sender, " - DoubleClick");
		}

		private void element_KeyDown( object sender, EventArgs e )
		{
			OutputEvent(sender, " - KeyDown");
		}

		private void element_KeyPress( object sender, EventArgs e )
		{
			OutputEvent(sender, " - KeyPress");
		}

		private void element_KeyUp( object sender, EventArgs e )
		{
			OutputEvent(sender, " - KeyUp");
		}

		private void element_MouseDown( object sender, EventArgs e )
		{
			OutputEvent(sender, " - MouseDown");
		}

		private void element_MouseLeave( object sender, EventArgs e )
		{
			OutputEvent(sender, " - MouseLeave");
		}

		private void element_MouseEnter( object sender, EventArgs e )
		{
			OutputEvent(sender, " - MouseEnter");
		}

		private void element_MouseMove( object sender, EventArgs e )
		{
			OutputEvent(sender, " - MouseMove");
		}

		private void htmluiControl1_LoadFinished(object sender, System.EventArgs e)
		{
			WireElements();
		}

		private void OutputEvent(object sender, string eventName)
		{
			this.outputCellElement.InnerHTML = "     "+((BaseElement)sender).ID  + " " + eventName + "<br>" + this.outputCellElement.InnerHTML;
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			LoadHTMLResource();
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
