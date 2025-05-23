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
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;
using System.IO;

namespace ComboBoxAutoCompleteDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
	{
		private ArrayList itemsList = new ArrayList();
		private ArrayList alphaList = new ArrayList();
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.GroupBox groupBox1;
        private Panel panel1;
        private ComboBoxAdv comboBox1;
        private Label label2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAutoComplete comboBoxAutoComplete1;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            this.Resize += new EventHandler(Form1_Resize);
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            this.MinimumSize = this.Size;
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

        void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.comboBoxAutoComplete1.Location = new Point(550, 350);
            }
            else
            {
                this.comboBoxAutoComplete1.Location = new Point(192, 259);
            }
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxAutoComplete1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAutoComplete();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAutoComplete1.AutoCompleteControl)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.comboBoxAutoComplete1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 454);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 53);
            this.panel1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox1.BeforeTouchSize = new System.Drawing.Size(194, 27);
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.Items.AddRange(new object[] {
            "Office2016Colorful",
            "Office2016White",
            "Office2016Black",
            "Office2016DarkGray",
            "Metro",
            "Office2010",
            "Office2007",
            "Default"});
            this.comboBox1.Location = new System.Drawing.Point(325, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 27);
            this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Office2016Colorful";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Visual Style";
            // 
            // comboBoxAutoComplete1
            // 
            // 
            // 
            // 
            this.comboBoxAutoComplete1.AutoCompleteControl.ChangeDataManagerPosition = true;
            this.comboBoxAutoComplete1.AutoCompleteControl.HeaderFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.comboBoxAutoComplete1.AutoCompleteControl.ItemFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.comboBoxAutoComplete1.AutoCompleteControl.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.comboBoxAutoComplete1.AutoCompleteControl.OverrideCombo = true;
            this.comboBoxAutoComplete1.AutoCompleteControl.ParentForm = this.groupBox1;
            this.comboBoxAutoComplete1.AutoCompleteControl.Style = Syncfusion.Windows.Forms.Tools.AutoCompleteStyle.Office2016Colorful;
            this.comboBoxAutoComplete1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxAutoComplete1.DropDownWidth = this.comboBoxAutoComplete1.Width;
            this.comboBoxAutoComplete1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAutoComplete1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBoxAutoComplete1.ItemHeight = 21;
            this.comboBoxAutoComplete1.Location = new System.Drawing.Point(192, 259);
            this.comboBoxAutoComplete1.Name = "comboBoxAutoComplete1";
            this.comboBoxAutoComplete1.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.comboBoxAutoComplete1.ParentForm = this.groupBox1;
            this.comboBoxAutoComplete1.Size = new System.Drawing.Size(336, 27);
            this.comboBoxAutoComplete1.TabIndex = 4;
            this.comboBoxAutoComplete1.VisualStyle = Syncfusion.Windows.Forms.Tools.ThemedComboBoxStyles.Office2016Colorful;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(760, 76);
            this.label1.TabIndex = 5;
            this.label1.Text = "The ComboBoxAutoComplete control combines a combo box control with an AutoComplet" +
    "e control to provide autocompletion for that instance of the combo box.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 19);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBox AutoComplete";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAutoComplete1.AutoCompleteControl)).EndInit();
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


        private void Form1_Load(object sender, System.EventArgs e)
		{
			#region DataSource 
			this.alphaList.AddRange(new String[]{"A",
												"B",
												"C",
												"D",
												"E",
												"F",
												"G",
												"H",
												"I",
												"J",
												"K",
												"L",
												"M",
												"N",
												"O",
												"P",
												"Q",
												"R",
												"S",
												"T",
												"U",
												"V",
												"W",
												"X",
												"Y",
												"Z"
			});

			foreach(string s in this.alphaList)
			{
				for(int i = 0; i < 15; i++)
				{
					this.itemsList.Add(s + i.ToString());
				}
			}

			this.comboBoxAutoComplete1.AutoCompleteControl.DataSource = this.itemsList;
            this.comboBoxAutoComplete1.DropDownWidth = this.comboBoxAutoComplete1.Width;
			#endregion
		}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBox1.SelectedItem.ToString())
            {
                case "Default":
                    {
                        this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Default;
                        this.comboBoxAutoComplete1.AutoCompleteControl.Style = AutoCompleteStyle.Default;
                        this.comboBoxAutoComplete1.VisualStyle = ThemedComboBoxStyles.Default;
                        this.GetColors(Color.White, Color.Black);
                        break;
                    }
                case "Office2007":
                    {
                        this.comboBoxAutoComplete1.VisualStyle = ThemedComboBoxStyles.Office2007;
                        this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
                        this.GetColors(Color.White, Color.Black);
                        break;
                    }
                case "Office2010":
                    {
                        this.comboBoxAutoComplete1.VisualStyle = ThemedComboBoxStyles.Office2010;
                        this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2010;
                        this.GetColors(Color.White, Color.Black);
                        break;
                    }
                case "Metro":
                    {
                        this.comboBoxAutoComplete1.AutoCompleteControl.Style = AutoCompleteStyle.Metro;
                        this.comboBoxAutoComplete1.VisualStyle = ThemedComboBoxStyles.Metro;
                        this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
                        this.GetColors(Color.White, Color.Black);
                        break;
                    }
                case "Office2016Colorful":
                    {
                        this.comboBoxAutoComplete1.AutoCompleteControl.Style = AutoCompleteStyle.Office2016Colorful;
                        this.comboBoxAutoComplete1.VisualStyle = ThemedComboBoxStyles.Office2016Colorful;
                        this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
                        this.GetColors(Color.White, Color.Black);
                        break;
                    }
                case "Office2016White":
                    {
                        this.comboBoxAutoComplete1.AutoCompleteControl.Style = AutoCompleteStyle.Office2016White;
                        this.comboBoxAutoComplete1.VisualStyle = ThemedComboBoxStyles.Office2016White;
                        this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016White;
                        this.GetColors(Color.White, Color.Black);
                        break;
                    }
                case "Office2016DarkGray":
                    {
                        this.comboBoxAutoComplete1.AutoCompleteControl.Style = AutoCompleteStyle.Office2016DarkGray;
                        this.comboBoxAutoComplete1.VisualStyle = ThemedComboBoxStyles.Office2016DarkGray;
                        this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016DarkGray;
                        this.GetColors(Color.FromArgb(124, 124, 124), Color.LightGray);
                        
                        break;
                    }
                case "Office2016Black":
                    {
                        this.comboBoxAutoComplete1.AutoCompleteControl.Style = AutoCompleteStyle.Office2016Black;
                        this.comboBoxAutoComplete1.VisualStyle = ThemedComboBoxStyles.Office2016Black;
                        this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Black;
                        this.GetColors(Color.FromArgb(37, 37, 37), Color.White);
                        break;
                    }
            }
        }

        private void GetColors(Color backcolor, Color forecolor)
        {
            this.BackColor = backcolor;
            this.CaptionBarColor = backcolor;
            this.MetroColor = backcolor;
            this.ForeColor = forecolor;
            this.CaptionForeColor = forecolor;
            this.groupBox1.BackColor = backcolor;
            this.groupBox1.ForeColor = forecolor;
            this.label1.ForeColor = forecolor;
        }
    }
}
