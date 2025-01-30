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
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;

namespace StatusBarAdvPanelDemo
{
    using Syncfusion.Licensing;
    using System.IO;

    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : MetroForm
	{
		private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel statusBarAdvPanel1;
		private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel statusBarAdvPanel2;
		private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel statusBarAdvPanel3;
		private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel statusBarAdvPanel4;
		private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel statusBarAdvPanel5;
		private Syncfusion.Windows.Forms.Tools.StatusBarAdv statusBarAdv1;
		private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel statusBarAdvPanel7;
		private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel statusBarAdvPanel6;
		private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel statusBarAdvPanel8;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Label label5;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            this.MinimumSize = this.Size;
            try
            {
#if NETCORE
            this.Icon = new Icon("../../../App.ico");
#else
            this.Icon = new Icon("../../App.ico");
#endif
            }
            catch { }



			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusBarAdvPanel1 = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            this.statusBarAdvPanel2 = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            this.statusBarAdvPanel3 = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            this.statusBarAdvPanel4 = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            this.statusBarAdvPanel5 = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            this.statusBarAdv1 = new Syncfusion.Windows.Forms.Tools.StatusBarAdv();
            this.statusBarAdvPanel8 = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            this.statusBarAdvPanel6 = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            this.statusBarAdvPanel7 = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel1)).BeginInit();
            this.statusBarAdvPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdv1)).BeginInit();
            this.statusBarAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBarAdvPanel1
            // 
            this.statusBarAdvPanel1.BorderColor = System.Drawing.Color.DarkGray;
            this.statusBarAdvPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusBarAdvPanel1.Controls.Add(this.statusBarAdvPanel2);
            this.statusBarAdvPanel1.Location = new System.Drawing.Point(266, 107);
            this.statusBarAdvPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.statusBarAdvPanel1.Name = "statusBarAdvPanel1";
            this.statusBarAdvPanel1.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.LongDate;
            this.statusBarAdvPanel1.Size = new System.Drawing.Size(216, 24);
            this.statusBarAdvPanel1.TabIndex = 0;
            this.statusBarAdvPanel1.Text = "statusBarAdvPanel1";
            // 
            // statusBarAdvPanel2
            // 
            this.statusBarAdvPanel2.Location = new System.Drawing.Point(-2, -2);
            this.statusBarAdvPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.statusBarAdvPanel2.Name = "statusBarAdvPanel2";
            this.statusBarAdvPanel2.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.LongDate;
            this.statusBarAdvPanel2.Size = new System.Drawing.Size(216, 24);
            this.statusBarAdvPanel2.TabIndex = 1;
            this.statusBarAdvPanel2.Text = "statusBarAdvPanel1";
            // 
            // statusBarAdvPanel3
            // 
            this.statusBarAdvPanel3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.ForwardDiagonal, System.Drawing.Color.Transparent, System.Drawing.SystemColors.Window);
            this.statusBarAdvPanel3.BorderColor = System.Drawing.Color.DarkGray;
            this.statusBarAdvPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusBarAdvPanel3.Location = new System.Drawing.Point(266, 167);
            this.statusBarAdvPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.statusBarAdvPanel3.Name = "statusBarAdvPanel3";
            this.statusBarAdvPanel3.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.ShortDate;
            this.statusBarAdvPanel3.Size = new System.Drawing.Size(216, 24);
            this.statusBarAdvPanel3.TabIndex = 1;
            this.statusBarAdvPanel3.Text = "statusBarAdvPanel1";
            this.statusBarAdvPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.statusBarAdvPanel3_Paint);
            // 
            // statusBarAdvPanel4
            // 
            this.statusBarAdvPanel4.BackColor = System.Drawing.Color.Transparent;
            this.statusBarAdvPanel4.BorderColor = System.Drawing.Color.DarkGray;
            this.statusBarAdvPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusBarAdvPanel4.Location = new System.Drawing.Point(266, 220);
            this.statusBarAdvPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.statusBarAdvPanel4.Name = "statusBarAdvPanel4";
            this.statusBarAdvPanel4.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.CapsLockState;
            this.statusBarAdvPanel4.Size = new System.Drawing.Size(216, 24);
            this.statusBarAdvPanel4.TabIndex = 2;
            this.statusBarAdvPanel4.Text = "statusBarAdvPanel1";
            // 
            // statusBarAdvPanel5
            // 
            this.statusBarAdvPanel5.BorderColor = System.Drawing.Color.DarkGray;
            this.statusBarAdvPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusBarAdvPanel5.Location = new System.Drawing.Point(266, 273);
            this.statusBarAdvPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.statusBarAdvPanel5.Name = "statusBarAdvPanel5";
            this.statusBarAdvPanel5.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.ScrollLockState;
            this.statusBarAdvPanel5.Size = new System.Drawing.Size(216, 24);
            this.statusBarAdvPanel5.TabIndex = 3;
            this.statusBarAdvPanel5.Text = "statusBarAdvPanel1";
            // 
            // statusBarAdv1
            // 
            this.statusBarAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.statusBarAdv1.BorderColor = System.Drawing.Color.DarkGray;
            this.statusBarAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusBarAdv1.Controls.Add(this.statusBarAdvPanel8);
            this.statusBarAdv1.Controls.Add(this.statusBarAdvPanel6);
            this.statusBarAdv1.Controls.Add(this.statusBarAdvPanel7);
            this.statusBarAdv1.CustomLayoutBounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.statusBarAdv1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBarAdv1.Location = new System.Drawing.Point(0, 318);
            this.statusBarAdv1.Name = "statusBarAdv1";
            this.statusBarAdv1.Padding = new System.Windows.Forms.Padding(3);
            this.statusBarAdv1.Size = new System.Drawing.Size(528, 32);
            this.statusBarAdv1.SizingGrip = false;
            this.statusBarAdv1.Spacing = new System.Drawing.Size(2, 2);
            this.statusBarAdv1.TabIndex = 8;
            this.statusBarAdv1.ThemesEnabled = true;
            // 
            // statusBarAdvPanel8
            // 
            this.statusBarAdvPanel8.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.statusBarAdvPanel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.statusBarAdvPanel8.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.SystemColors.Info, System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))));
            this.statusBarAdvPanel8.BorderColor = System.Drawing.Color.DarkGray;
            this.statusBarAdvPanel8.BorderSingle = System.Windows.Forms.ButtonBorderStyle.Dashed;
            this.statusBarAdvPanel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusBarAdvPanel8.Location = new System.Drawing.Point(0, 2);
            this.statusBarAdvPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.statusBarAdvPanel8.Name = "statusBarAdvPanel8";
            this.statusBarAdvPanel8.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.LongTime;
            this.statusBarAdvPanel8.Size = new System.Drawing.Size(67, 26);
            this.statusBarAdvPanel8.SizeToContent = true;
            this.statusBarAdvPanel8.TabIndex = 12;
            this.statusBarAdvPanel8.Text = null;
            this.statusBarAdvPanel8.ThemesEnabled = true;
            // 
            // statusBarAdvPanel6
            // 
            this.statusBarAdvPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.statusBarAdvPanel6.BorderColor = System.Drawing.Color.DarkGray;
            this.statusBarAdvPanel6.BorderSingle = System.Windows.Forms.ButtonBorderStyle.Dotted;
            this.statusBarAdvPanel6.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify;
            this.statusBarAdvPanel6.Location = new System.Drawing.Point(69, 2);
            this.statusBarAdvPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.statusBarAdvPanel6.Name = "statusBarAdvPanel6";
            this.statusBarAdvPanel6.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.CurrentCulture;
            this.statusBarAdvPanel6.PreferredSize = new System.Drawing.Size(183, 24);
            this.statusBarAdvPanel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusBarAdvPanel6.Size = new System.Drawing.Size(264, 26);
            this.statusBarAdvPanel6.TabIndex = 11;
            this.statusBarAdvPanel6.Text = "statusBarAdvPanel6";
            this.statusBarAdvPanel6.ThemesEnabled = true;
            // 
            // statusBarAdvPanel7
            // 
            this.statusBarAdvPanel7.BackColor = System.Drawing.SystemColors.Control;
            this.statusBarAdvPanel7.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.SystemColors.Info, System.Drawing.SystemColors.InactiveBorder);
            this.statusBarAdvPanel7.BorderColor = System.Drawing.Color.DarkGray;
            this.statusBarAdvPanel7.BorderSingle = System.Windows.Forms.ButtonBorderStyle.Dotted;
            this.statusBarAdvPanel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusBarAdvPanel7.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Right;
            this.statusBarAdvPanel7.Location = new System.Drawing.Point(335, 2);
            this.statusBarAdvPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.statusBarAdvPanel7.Name = "statusBarAdvPanel7";
            this.statusBarAdvPanel7.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.InsertKeyState;
            this.statusBarAdvPanel7.Size = new System.Drawing.Size(184, 26);
            this.statusBarAdvPanel7.TabIndex = 10;
            this.statusBarAdvPanel7.Text = null;
            this.statusBarAdvPanel7.ThemesEnabled = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(42, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Scroll Lock state";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(42, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "CAPS lock state with color border";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(42, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Short date with gradient";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(42, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Long Date";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Controls.Add(this.label5);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.statusBarAdv1);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.statusBarAdvPanel5);
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Controls.Add(this.statusBarAdvPanel4);
            this.gradientPanel1.Controls.Add(this.label4);
            this.gradientPanel1.Controls.Add(this.statusBarAdvPanel3);
            this.gradientPanel1.Controls.Add(this.statusBarAdvPanel1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(10, 10);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(532, 354);
            this.gradientPanel1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(528, 63);
            this.label5.TabIndex = 14;
            this.label5.Text = "In StatusBarAdv different types of panels can be set with the PanelType property." +
    "By using the HAlign property, horizontal alignment in the flow layout can be set" +
    " as Left, Right, Center, or Justify. ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClientSize = new System.Drawing.Size(552, 374);
            this.Controls.Add(this.gradientPanel1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MetroColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatusBarAdv Panel";
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel1)).EndInit();
            this.statusBarAdvPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdv1)).EndInit();
            this.statusBarAdv1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel7)).EndInit();
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

		private void statusBarAdvPanel3_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
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
