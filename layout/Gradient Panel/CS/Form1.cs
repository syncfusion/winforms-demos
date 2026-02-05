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
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Licensing;
using System.IO;
using Syncfusion.WinForms.Controls;

namespace GradientPanelDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : SfForm
    {
        private Panel panel1;
        private GradientPanel gradientPanel1;
        private GradientPanel gradientPanel4;
        private GradientPanel gradientPanel5;
        private GradientPanel gradientPanel3;
        private GradientPanel gradientPanel6;
        private GradientPanel gradientPanel2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            

            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.gradientPanel5 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.gradientPanel6 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gradientPanel4);
            this.panel1.Controls.Add(this.gradientPanel5);
            this.panel1.Controls.Add(this.gradientPanel3);
            this.panel1.Controls.Add(this.gradientPanel6);
            this.panel1.Controls.Add(this.gradientPanel2);
            this.panel1.Controls.Add(this.gradientPanel1);
            this.panel1.Location = new System.Drawing.Point(29, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 465);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(743, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Path Ellipse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(413, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Path Rectangle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(105, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Vertical";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(743, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Horizontal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(399, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Backward Diagonal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(83, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Forward Diagonal";
            // 
            // gradientPanel4
            // 
            this.gradientPanel4.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathEllipse, System.Drawing.Color.BurlyWood, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))));
            this.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel4.Location = new System.Drawing.Point(633, 266);
            this.gradientPanel4.Name = "gradientPanel4";
            this.gradientPanel4.Size = new System.Drawing.Size(278, 168);
            this.gradientPanel4.TabIndex = 5;
            // 
            // gradientPanel5
            // 
            this.gradientPanel5.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(105)))), ((int)(((byte)(212))))), System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(23)))), ((int)(((byte)(111))))));
            this.gradientPanel5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel5.Location = new System.Drawing.Point(318, 266);
            this.gradientPanel5.Name = "gradientPanel5";
            this.gradientPanel5.Size = new System.Drawing.Size(278, 168);
            this.gradientPanel5.TabIndex = 4;
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(47)))), ((int)(((byte)(162))))), System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(105)))), ((int)(((byte)(115))))));
            this.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel3.Location = new System.Drawing.Point(633, 3);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(278, 168);
            this.gradientPanel3.TabIndex = 2;
            // 
            // gradientPanel6
            // 
            this.gradientPanel6.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(26)))), ((int)(((byte)(70))))), System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(112)))), ((int)(((byte)(81))))));
            this.gradientPanel6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel6.Location = new System.Drawing.Point(3, 266);
            this.gradientPanel6.Name = "gradientPanel6";
            this.gradientPanel6.Size = new System.Drawing.Size(278, 168);
            this.gradientPanel6.TabIndex = 3;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.BackwardDiagonal, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(132)))), ((int)(((byte)(20))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(145)))), ((int)(((byte)(21))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(94)))), ((int)(((byte)(22))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(77)))), ((int)(((byte)(23)))))});
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel2.Location = new System.Drawing.Point(318, 3);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(278, 168);
            this.gradientPanel2.TabIndex = 1;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.ForwardDiagonal, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(23)))), ((int)(((byte)(111))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(64)))), ((int)(((byte)(169))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(105)))), ((int)(((byte)(212))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))))});
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel1.Location = new System.Drawing.Point(3, 3);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(278, 168);
            this.gradientPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 512);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gradient Panel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
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
}
