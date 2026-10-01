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
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Licensing;


namespace HTMLUIControlEvents
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
	{
		private Assembly _assembly;
		private Stream _htmlStream;

		private Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl htmluiControl1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox1;
        private ButtonAdv button3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private ButtonAdv button1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
        private CheckBoxAdv checkBoxShowTitleChanged;
        private CheckBoxAdv checkBoxTitleChanged;
        private ButtonAdv button2;
		private CheckBoxAdv checkBoxLoadStarted;
        private CheckBoxAdv checkBoxLoadFinished;
        private CheckBoxAdv checkBoxLoadError;
        private CheckBoxAdv checkBoxPreRenderDocument;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private GradientPanel gradientPanel1;
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.checkBoxShowTitleChanged = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxTitleChanged = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxPreRenderDocument = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxLoadError = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxLoadFinished = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxLoadStarted = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxShowTitleChanged)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxTitleChanged)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxPreRenderDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxLoadError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxLoadFinished)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxLoadStarted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // htmluiControl1
            // 
            this.htmluiControl1.BackColor = System.Drawing.Color.White;
            this.htmluiControl1.DefaultFormat.BackgroundColor = System.Drawing.SystemColors.Control;
            this.htmluiControl1.DefaultFormat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.htmluiControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmluiControl1.Location = new System.Drawing.Point(0, 0);
            this.htmluiControl1.Name = "htmluiControl1";
            this.htmluiControl1.Size = new System.Drawing.Size(512, 352);
            this.htmluiControl1.TabIndex = 0;
            this.htmluiControl1.Text = resources.GetString("htmluiControl1.Text");
            this.htmluiControl1.TitleChanged += new Syncfusion.Windows.Forms.HTMLUI.ValueChangedEventHandler(this.htmluiControl1_TitleChanged);
            this.htmluiControl1.ShowTitleChanged += new Syncfusion.Windows.Forms.HTMLUI.ValueChangedEventHandler(this.htmluiControl1_ShowTitleChanged);
            this.htmluiControl1.LoadFinished += new System.EventHandler(this.htmluiControl1_LoadFinished);
            this.htmluiControl1.LoadStarted += new System.EventHandler(this.htmluiControl1_LoadStarted);
            this.htmluiControl1.LoadError += new Syncfusion.Windows.Forms.HTMLUI.LoadErrorEventHandler(this.htmluiControl1_LoadError);
            this.htmluiControl1.PreRenderDocument += new Syncfusion.Windows.Forms.HTMLUI.PreRenderDocumentEventHandler(this.htmluiControl1_PreRenderDocument);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 457);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 128);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.checkBoxShowTitleChanged);
            this.panel3.Controls.Add(this.checkBoxTitleChanged);
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(116, 124);
            this.panel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Title events";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 8.25F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(10, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 22);
            this.button2.TabIndex = 16;
            this.button2.Text = "Change Title";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBoxShowTitleChanged
            // 
            this.checkBoxShowTitleChanged.BackColor = System.Drawing.Color.White;
            this.checkBoxShowTitleChanged.Checked = true;
            this.checkBoxShowTitleChanged.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowTitleChanged.DrawFocusRectangle = false;
            this.checkBoxShowTitleChanged.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowTitleChanged.ForeColor = System.Drawing.Color.Black;
            this.checkBoxShowTitleChanged.Location = new System.Drawing.Point(10, 54);
            this.checkBoxShowTitleChanged.MetroColor = System.Drawing.Color.Gray;
            this.checkBoxShowTitleChanged.Name = "checkBoxShowTitleChanged";
            this.checkBoxShowTitleChanged.Size = new System.Drawing.Size(98, 30);
            this.checkBoxShowTitleChanged.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxShowTitleChanged.TabIndex = 15;
            this.checkBoxShowTitleChanged.Text = "Show TitleChanged";
            this.checkBoxShowTitleChanged.ThemesEnabled = false;
            // 
            // checkBoxTitleChanged
            // 
            this.checkBoxTitleChanged.BackColor = System.Drawing.Color.White;
            this.checkBoxTitleChanged.Checked = true;
            this.checkBoxTitleChanged.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTitleChanged.DrawFocusRectangle = false;
            this.checkBoxTitleChanged.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTitleChanged.ForeColor = System.Drawing.Color.Black;
            this.checkBoxTitleChanged.Location = new System.Drawing.Point(10, 28);
            this.checkBoxTitleChanged.MetroColor = System.Drawing.Color.Gray;
            this.checkBoxTitleChanged.Name = "checkBoxTitleChanged";
            this.checkBoxTitleChanged.Size = new System.Drawing.Size(96, 24);
            this.checkBoxTitleChanged.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxTitleChanged.TabIndex = 14;
            this.checkBoxTitleChanged.Text = "TitleChanged";
            this.checkBoxTitleChanged.ThemesEnabled = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(12, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 200);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.checkBoxPreRenderDocument);
            this.panel5.Controls.Add(this.checkBoxLoadError);
            this.panel5.Controls.Add(this.checkBoxLoadFinished);
            this.panel5.Controls.Add(this.checkBoxLoadStarted);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Location = new System.Drawing.Point(2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(116, 196);
            this.panel5.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(-2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Load Events";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxPreRenderDocument
            // 
            this.checkBoxPreRenderDocument.BackColor = System.Drawing.Color.White;
            this.checkBoxPreRenderDocument.Checked = true;
            this.checkBoxPreRenderDocument.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPreRenderDocument.DrawFocusRectangle = false;
            this.checkBoxPreRenderDocument.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPreRenderDocument.ForeColor = System.Drawing.Color.Black;
            this.checkBoxPreRenderDocument.Location = new System.Drawing.Point(10, 125);
            this.checkBoxPreRenderDocument.MetroColor = System.Drawing.Color.Gray;
            this.checkBoxPreRenderDocument.Name = "checkBoxPreRenderDocument";
            this.checkBoxPreRenderDocument.Size = new System.Drawing.Size(96, 29);
            this.checkBoxPreRenderDocument.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxPreRenderDocument.TabIndex = 14;
            this.checkBoxPreRenderDocument.Text = "PreRenderDocument";
            this.checkBoxPreRenderDocument.ThemesEnabled = false;
            // 
            // checkBoxLoadError
            // 
            this.checkBoxLoadError.BackColor = System.Drawing.Color.White;
            this.checkBoxLoadError.Checked = true;
            this.checkBoxLoadError.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLoadError.DrawFocusRectangle = false;
            this.checkBoxLoadError.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLoadError.ForeColor = System.Drawing.Color.Black;
            this.checkBoxLoadError.Location = new System.Drawing.Point(10, 96);
            this.checkBoxLoadError.MetroColor = System.Drawing.Color.Gray;
            this.checkBoxLoadError.Name = "checkBoxLoadError";
            this.checkBoxLoadError.Size = new System.Drawing.Size(96, 18);
            this.checkBoxLoadError.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxLoadError.TabIndex = 13;
            this.checkBoxLoadError.Text = "LoadError";
            this.checkBoxLoadError.ThemesEnabled = false;
            // 
            // checkBoxLoadFinished
            // 
            this.checkBoxLoadFinished.BackColor = System.Drawing.Color.White;
            this.checkBoxLoadFinished.Checked = true;
            this.checkBoxLoadFinished.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLoadFinished.DrawFocusRectangle = false;
            this.checkBoxLoadFinished.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLoadFinished.ForeColor = System.Drawing.Color.Black;
            this.checkBoxLoadFinished.Location = new System.Drawing.Point(10, 64);
            this.checkBoxLoadFinished.MetroColor = System.Drawing.Color.Gray;
            this.checkBoxLoadFinished.Name = "checkBoxLoadFinished";
            this.checkBoxLoadFinished.Size = new System.Drawing.Size(96, 20);
            this.checkBoxLoadFinished.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxLoadFinished.TabIndex = 12;
            this.checkBoxLoadFinished.Text = "LoadFinished";
            this.checkBoxLoadFinished.ThemesEnabled = false;
            // 
            // checkBoxLoadStarted
            // 
            this.checkBoxLoadStarted.BackColor = System.Drawing.Color.White;
            this.checkBoxLoadStarted.Checked = true;
            this.checkBoxLoadStarted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLoadStarted.DrawFocusRectangle = false;
            this.checkBoxLoadStarted.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLoadStarted.ForeColor = System.Drawing.Color.Black;
            this.checkBoxLoadStarted.Location = new System.Drawing.Point(10, 32);
            this.checkBoxLoadStarted.MetroColor = System.Drawing.Color.Gray;
            this.checkBoxLoadStarted.Name = "checkBoxLoadStarted";
            this.checkBoxLoadStarted.Size = new System.Drawing.Size(96, 26);
            this.checkBoxLoadStarted.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxLoadStarted.TabIndex = 11;
            this.checkBoxLoadStarted.Text = "LoadStarted";
            this.checkBoxLoadStarted.ThemesEnabled = false;
            // 
            // button1
            // 
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(8, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 24);
            this.button1.TabIndex = 11;
            this.button1.Text = "Load Document";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(16, 345);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 24);
            this.button3.TabIndex = 4;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(154, 364);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(514, 103);
            this.textBox1.TabIndex = 2;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.htmluiControl1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(154, 10);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(514, 354);
            this.gradientPanel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClientSize = new System.Drawing.Size(678, 477);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.IconTextRelation = System.Windows.Forms.LeftRightAlignment.Left;
            this.MetroColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(690, 513);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Events";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxShowTitleChanged)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxTitleChanged)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxPreRenderDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxLoadError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxLoadFinished)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxLoadStarted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
				_htmlStream = (Stream)_assembly.GetManifestResourceStream("Syncfusion.Windows.Forms.HTMLUI.Samples.display.htm");
				if(_htmlStream != null)
				{
					this.htmluiControl1.LoadHTML(_htmlStream);
					success = true;
				}
			}
			catch(Exception ex)
			{
				OutputText(ex.ToString());
			}
			return success;
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			LoadHTMLResource();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
				LoadHTMLResource();
		}

		private void OutputText(string output)
		{
			this.textBox1.Text += output + "\r\n";
			this.textBox1.SelectionStart = this.textBox1.Text.Length -1;
			this.textBox1.SelectionLength =0;
			this.textBox1.ScrollToCaret();
		}

		private void htmluiControl1_LoadFinished(object sender, System.EventArgs e)
		{
			if(this.checkBoxLoadFinished.Checked)
			{
				OutputText("LoadFinished event.");
			}
		}

		private void htmluiControl1_LoadStarted(object sender, System.EventArgs e)
		{
			if(this.checkBoxLoadStarted.Checked)
			{
				OutputText("LoadStarted event.");
			}	
		}

		private void htmluiControl1_LoadError(object sender, Syncfusion.Windows.Forms.HTMLUI.LoadErrorEventArgs e)
		{
			if(this.checkBoxLoadError.Checked)
			{
				OutputText("LoadError event.");
			}	
		}

		private void htmluiControl1_PreRenderDocument(object sender, Syncfusion.Windows.Forms.HTMLUI.PreRenderDocumentArgs e)
		{
			if(this.checkBoxPreRenderDocument.Checked)
			{
				OutputText("LoadPrerenderDocument event.");
			}
		}

		private void htmluiControl1_TitleChanged(object sender, Syncfusion.Windows.Forms.HTMLUI.ValueChangedEventArgs e)
		{
			if(this.checkBoxTitleChanged.Checked)
			{
				OutputText("TitleChanged event.");
			}
		}

		

		private void button3_Click(object sender, System.EventArgs e)
		{
			this.textBox1.Clear();
		}

		private void htmluiControl1_ShowTitleChanged(object sender, Syncfusion.Windows.Forms.HTMLUI.ValueChangedEventArgs e)
		{
			if(this.checkBoxShowTitleChanged.Checked)
			{
				OutputText("ShowTitleChanged event.");
			}

		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if(this.htmluiControl1.ShowTitle == true)
			{
				this.htmluiControl1.Title = "";
				this.htmluiControl1.ShowTitle = false;
			}
			else
			{
				this.htmluiControl1.Title = "HTMLUIControl Title";
				this.htmluiControl1.ShowTitle = true;
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
