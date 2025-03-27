#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
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
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using System.IO;
using Syncfusion.Licensing;
using Syncfusion.HighContrastTheme.WinForms;
using System.Collections.Specialized;

namespace AutoCompleteDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
    {
        private Panels panel1;
        private Panels panel2;
        private Syncfusion.Windows.Forms.Tools.AutoComplete autoComplete1;
        private TextBoxExt textBox1;
        private Label label2;
        private Panel groupBox1;
        private RadioButtonAdv radioButton6;
        private RadioButtonAdv radioButton5;
        private RadioButtonAdv radioButton4;
        private RadioButtonAdv radioButton3;
        private RadioButtonAdv radioButton2;
        private RadioButtonAdv radioButton1;
        private Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo autoCompleteDataColumnInfo1;
        private Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo autoCompleteDataColumnInfo2;
        private ImageList imageList;
        private Image image;
        private RadioButtonAdv radioButtonAdv1;
        private System.ComponentModel.IContainer components = null;


        public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            this.AddImages();
            autoComplete1.DataSource = this.Table();
            HookEvents();
            AddRadioButtonContent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
		}

        private void AddRadioButtonContent()
        {
            this.radioButtonAdv1.Text = "Metro";
            this.radioButton6.Text = "Office2016 Dark Gray";
            this.radioButton5.Text = "Office2016 Black";
            this.radioButton4.Text = "Office2016 White";
            this.radioButton3.Text = "Office2016 Colorful";
            this.radioButton2.Text = "High Contrast Black";
            this.radioButton1.Text = "Office2019 Colorful";
            this.radioButton1.Size = new System.Drawing.Size(255, 33);
            this.radioButton2.Size = new System.Drawing.Size(255, 33);
            this.radioButton3.Size = new System.Drawing.Size(255, 33);
            this.radioButton4.Size = new System.Drawing.Size(255, 33);
            this.radioButton5.Size = new System.Drawing.Size(255, 33);
            this.radioButton6.Size = new System.Drawing.Size(255, 33);
            this.radioButtonAdv1.Size = new System.Drawing.Size(255, 33);

        }

        private void HookEvents()
        {
            this.radioButton1.CheckChanged += RadioButton1_CheckChanged;
            this.radioButton2.CheckChanged += RadioButton1_CheckChanged;
            this.radioButton3.CheckChanged += RadioButton1_CheckChanged;
            this.radioButton4.CheckChanged += RadioButton1_CheckChanged;
            this.radioButton5.CheckChanged += RadioButton1_CheckChanged;
            this.radioButton6.CheckChanged += RadioButton1_CheckChanged;
            this.radioButtonAdv1.CheckChanged += RadioButton1_CheckChanged;
        }


        StringCollection stringCollection = new StringCollection() { "Bangladesh", "Brazil", "China", "Egypt", "India", "Indonesia", "Japan", "Mexico",
        "Nigeria", "Pakistan", "Philippines", "USA"};

        StringCollection stringCollection1 = new StringCollection() { "Andorra", "Armenia", "Austria", "Belgium", "Brazil", "Denmark", "France", "Georgia",
        "Germany", "Iran", "Malasiya", "New Zealand", "North Korea", "Russia", "Singapore", "South Korea", "Spain", "Sri Lanka", "United Kingdom"};
        private DataTable Table()                                   
        {                                                          
            DataTable dataTable = new DataTable();                  
            dataTable.Columns.Add("Flag");                          
            dataTable.Columns.Add("Country");
            for (int i = 0; i < stringCollection.Count ; i++)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = stringCollection[i];
                dataRow[1] = i;
                dataTable.Rows.Add(dataRow);
            }
            int index = stringCollection.Count;
            for (int i = 0; i < stringCollection1.Count ; i++)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = stringCollection1[i];
                dataRow[1] = index++;
                dataTable.Rows.Add(dataRow);
            }
            return dataTable;
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
            this.autoComplete1 = new Syncfusion.Windows.Forms.Tools.AutoComplete(this.components);
            this.autoCompleteDataColumnInfo1 = new Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo("Flag", 100, true);
            this.autoCompleteDataColumnInfo2 = new Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo("Country", 100, true);
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.panel1 = new AutoCompleteDemo.Panels();
            this.groupBox1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonAdv1 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton6 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton5 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton4 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton3 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton1 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.panel2 = new AutoCompleteDemo.Panels();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.autoComplete1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // autoComplete1
            // 
            this.autoComplete1.AdjustHeightToItemCount = false;
            this.autoComplete1.Columns.Add(this.autoCompleteDataColumnInfo1);
            this.autoComplete1.Columns.Add(this.autoCompleteDataColumnInfo2);
            this.autoComplete1.HeaderFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.autoComplete1.ImageList = this.imageList;
            this.autoComplete1.ItemFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.autoComplete1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.autoComplete1.ParentForm = this;
            this.autoComplete1.Style = Syncfusion.Windows.Forms.Tools.AutoCompleteStyle.Default;
            this.autoComplete1.ThemeName = "Office2019Colorful";
            // 
            // autoCompleteDataColumnInfo1
            // 
            this.autoCompleteDataColumnInfo1.ColumnHeaderText = "Flag";
            this.autoCompleteDataColumnInfo1.ImageColumn = false;
            this.autoCompleteDataColumnInfo1.MatchingColumn = false;
            this.autoCompleteDataColumnInfo1.Visible = true;
            // 
            // autoCompleteDataColumnInfo2
            // 
            this.autoCompleteDataColumnInfo2.ColumnHeaderText = "Country";
            this.autoCompleteDataColumnInfo2.ImageColumn = true;
            this.autoCompleteDataColumnInfo2.MatchingColumn = false;
            this.autoCompleteDataColumnInfo2.Visible = true;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // textBox1
            // 
            this.autoComplete1.SetAutoComplete(this.textBox1, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.MultiSuggestExtended);
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox1.BeforeTouchSize = new System.Drawing.Size(270, 29);
            this.textBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox1.Location = new System.Drawing.Point(303, 227);
            this.textBox1.Metrocolor = System.Drawing.Color.Gray;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 29);
            this.textBox1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.textBox1.TabIndex = 2;
            this.textBox1.ThemeName = "Office2019Colorful";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(762, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 655);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButtonAdv1);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.groupBox1.Location = new System.Drawing.Point(42, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 391);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.Text = "Visual Styles";
            // 
            // radioButton2
            // 
            this.radioButton2.BeforeTouchSize = new System.Drawing.Size(164, 23);
            this.radioButton2.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButton2.Location = new System.Drawing.Point(13, 88);
            this.radioButton2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(150, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = false;
            this.radioButton2.ThemeName = "Office2019Colorful";
            // 
            // radioButtonAdv1
            // 
            this.radioButtonAdv1.BeforeTouchSize = new System.Drawing.Size(72, 23);
            this.radioButtonAdv1.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButtonAdv1.Location = new System.Drawing.Point(13, 340);
            this.radioButtonAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.radioButtonAdv1.Name = "radioButtonAdv1";
            this.radioButtonAdv1.Size = new System.Drawing.Size(72, 23);
            this.radioButtonAdv1.TabIndex = 6;
            this.radioButtonAdv1.TabStop = false;
            this.radioButtonAdv1.ThemeName = "Office2019Colorful";
            // 
            // radioButton6
            // 
            this.radioButton6.BeforeTouchSize = new System.Drawing.Size(177, 23);
            this.radioButton6.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButton6.Location = new System.Drawing.Point(13, 291);
            this.radioButton6.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(177, 23);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = false;
            this.radioButton6.ThemeName = "Office2019Colorful";
            // 
            // radioButton5
            // 
            this.radioButton5.BeforeTouchSize = new System.Drawing.Size(148, 23);
            this.radioButton5.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButton5.Location = new System.Drawing.Point(13, 242);
            this.radioButton5.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(148, 23);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = false;
            this.radioButton5.ThemeName = "Office2019Colorful";
            // 
            // radioButton4
            // 
            this.radioButton4.BeforeTouchSize = new System.Drawing.Size(150, 23);
            this.radioButton4.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButton4.Location = new System.Drawing.Point(13, 193);
            this.radioButton4.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(150, 23);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = false;
            this.radioButton4.ThemeName = "Office2019Colorful";
            // 
            // radioButton3
            // 
            this.radioButton3.BeforeTouchSize = new System.Drawing.Size(163, 23);
            this.radioButton3.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButton3.Location = new System.Drawing.Point(13, 140);
            this.radioButton3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(163, 23);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = false;
            this.radioButton3.ThemeName = "Office2019Colorful";
            // 
            // radioButton1
            // 
            this.radioButton1.BeforeTouchSize = new System.Drawing.Size(163, 23);
            this.radioButton1.Checked = true;
            this.radioButton1.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButton1.Location = new System.Drawing.Point(13, 40);
            this.radioButton1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(163, 23);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.ThemeName = "Office2019Colorful";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(1, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(755, 655);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label2.Location = new System.Drawing.Point(104, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter country name : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ClientSize = new System.Drawing.Size(1150, 617);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Getting Started";
            ((System.ComponentModel.ISupportInitialize)(this.autoComplete1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void AddImages()
        {
            for(int i=0; i < stringCollection.Count; i++)
            {
#if NETCORE
                image = Image.FromFile("../../../Flags/"+ stringCollection[i] +".jpg");
#else
                image = Image.FromFile("../../Flags/"+ stringCollection[i] +".jpg");
#endif
                imageList.Images.Add(image);
            }
            for (int i = 0; i < stringCollection1.Count; i++)
            {
#if NETCORE
                image = Image.FromFile("../../../Flags/" + stringCollection1[i] + ".png");
#else
                image = Image.FromFile("../../Flags/" + stringCollection1[i] + ".png");
#endif

                imageList.Images.Add(image);
            }
            this.imageList.ImageSize = new Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
        }

#endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
		static void Main() 
		{
            SkinManager.LoadAssembly(typeof(Syncfusion.WinForms.Themes.Office2019Theme).Assembly);
            SkinManager.LoadAssembly(typeof(HighContrastTheme).Assembly);
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

        private void RadioButton1_CheckChanged(object sender, EventArgs e)
        {
            string selectedItem = (sender as RadioButtonAdv).Text;
            switch (selectedItem)
            {
                case "Metro":
                    {
                        this.autoComplete1.Style = AutoCompleteStyle.Metro;
                        this.textBox1.Style = TextBoxExt.theme.Metro;
                        this.radioButton1.Style = RadioButtonAdvStyle.Metro;
                        this.radioButton2.Style = RadioButtonAdvStyle.Metro;
                        this.radioButton3.Style = RadioButtonAdvStyle.Metro;
                        this.radioButton4.Style = RadioButtonAdvStyle.Metro;
                        this.radioButton5.Style = RadioButtonAdvStyle.Metro;
                        this.radioButton6.Style = RadioButtonAdvStyle.Metro;
                        this.radioButtonAdv1.Style = RadioButtonAdvStyle.Metro;
                        this.CaptionBarColor = this.BackColor = Color.White;
                        this.CaptionButtonColor = this.CaptionForeColor = ColorTranslator.FromHtml("#444444");
                        this.label2.BackColor = this.textBox1.BackColor = Color.White;
                        this.label2.ForeColor = this.textBox1.ForeColor = ColorTranslator.FromHtml("#444444");
                        this.radioButton1.ForeColor = ColorTranslator.FromHtml("#444444");
                        this.radioButton2.ForeColor = ColorTranslator.FromHtml("#444444");
                        this.radioButton3.ForeColor = ColorTranslator.FromHtml("#444444");
                        this.radioButton4.ForeColor = ColorTranslator.FromHtml("#444444");
                        this.radioButton5.ForeColor = ColorTranslator.FromHtml("#444444");
                        this.radioButton6.ForeColor = ColorTranslator.FromHtml("#444444");
                        this.radioButtonAdv1.ForeColor = ColorTranslator.FromHtml("#444444");
                        break;
                    }
                case "Office2016 Colorful":
                    {
                        this.autoComplete1.Style = AutoCompleteStyle.Office2016Colorful;
                        this.textBox1.Style = TextBoxExt.theme.Office2016Colorful;
                        this.radioButton1.Style = RadioButtonAdvStyle.Office2016Colorful;
                        this.radioButton2.Style = RadioButtonAdvStyle.Office2016Colorful;
                        this.radioButton3.Style = RadioButtonAdvStyle.Office2016Colorful;
                        this.radioButton4.Style = RadioButtonAdvStyle.Office2016Colorful;
                        this.radioButton5.Style = RadioButtonAdvStyle.Office2016Colorful;
                        this.radioButton6.Style = RadioButtonAdvStyle.Office2016Colorful;
                        this.radioButtonAdv1.Style = RadioButtonAdvStyle.Office2016Colorful;
                        ChangeStyles(textBox1.ForeColor, textBox1.BackColor);
                        break;
                    }
                case "Office2016 White":
                    {
                        this.autoComplete1.Style = AutoCompleteStyle.Office2016White;
                        this.textBox1.Style = TextBoxExt.theme.Office2016White;
                        this.radioButton1.ThemeName = "Office2016White";
                        this.radioButton2.ThemeName = "Office2016White";
                        this.radioButton3.ThemeName = "Office2016White";
                        this.radioButton4.ThemeName = "Office2016White";
                        this.radioButton5.ThemeName = "Office2016White";
                        this.radioButton6.ThemeName = "Office2016White";
                        this.radioButtonAdv1.ThemeName = "Office2016White";
                        ChangeStyles(textBox1.ForeColor, textBox1.BackColor);
                        break;
                    }
                case "Office2016 Dark Gray":
                    {
                        this.autoComplete1.Style = AutoCompleteStyle.Office2016DarkGray;
                        this.textBox1.Style = TextBoxExt.theme.Office2016DarkGray;
                        this.radioButton1.Style = RadioButtonAdvStyle.Office2016DarkGray;
                        this.radioButton2.Style = RadioButtonAdvStyle.Office2016DarkGray;
                        this.radioButton3.Style = RadioButtonAdvStyle.Office2016DarkGray;
                        this.radioButton4.Style = RadioButtonAdvStyle.Office2016DarkGray;
                        this.radioButton5.Style = RadioButtonAdvStyle.Office2016DarkGray;
                        this.radioButton6.Style = RadioButtonAdvStyle.Office2016DarkGray;
                        this.radioButtonAdv1.Style = RadioButtonAdvStyle.Office2016DarkGray;
                        ChangeStyles(radioButtonAdv1.ForeColor, radioButtonAdv1.BackColor);
                        break;
                    }
                case "Office2016 Black":
                    {
                        this.autoComplete1.Style = AutoCompleteStyle.Office2016Black;
                        this.textBox1.Style = TextBoxExt.theme.Office2016Black;
                        this.radioButton1.ThemeName = "Office2016Black";
                        this.radioButton2.ThemeName = "Office2016Black";
                        this.radioButton3.ThemeName = "Office2016Black";
                        this.radioButton4.ThemeName = "Office2016Black";
                        this.radioButton5.ThemeName = "Office2016Black";
                        this.radioButton6.ThemeName = "Office2016Black";
                        this.radioButtonAdv1.ThemeName = "Office2016Black";
                        ChangeStyles(textBox1.ForeColor, radioButtonAdv1.BackColor);
                        break;
                    }
                case "Office2019 Colorful":
                    {
                        this.autoComplete1.ThemeName = "Office2019Colorful";
                        this.textBox1.ThemeName = "Office2019Colorful";
                        this.radioButton1.ThemeName = "Office2019Colorful";
                        this.radioButton2.ThemeName = "Office2019Colorful";
                        this.radioButton3.ThemeName = "Office2019Colorful";
                        this.radioButton4.ThemeName = "Office2019Colorful";
                        this.radioButton5.ThemeName = "Office2019Colorful";
                        this.radioButton6.ThemeName = "Office2019Colorful";
                        this.radioButtonAdv1.ThemeName = "Office2019Colorful";
                        ChangeStyles(autoComplete1.ThemeStyle.ItemStyle.ForeColor, autoComplete1.ThemeStyle.ItemStyle.BackColor);
                        break;
                    }
                case "High Contrast Black":
                    {
                        this.autoComplete1.ThemeName = "HighContrastBlack";
                        this.textBox1.ThemeName = "HighContrastBlack";
                        this.radioButton1.ThemeName = "HighContrastBlack";
                        this.radioButton2.ThemeName = "HighContrastBlack";
                        this.radioButton3.ThemeName = "HighContrastBlack";
                        this.radioButton4.ThemeName = "HighContrastBlack";
                        this.radioButton5.ThemeName = "HighContrastBlack";
                        this.radioButton6.ThemeName = "HighContrastBlack";
                        this.radioButtonAdv1.ThemeName = "HighContrastBlack";

                        ChangeStyles(autoComplete1.ThemeStyle.ItemStyle.ForeColor,autoComplete1.ThemeStyle.ItemStyle.BackColor);
                        break;
                    }
            }
            
        }

        private void ChangeStyles(Color foreColor, Color BackColor)
        {
            
            this.label2.ForeColor = foreColor;
            this.label2.BackColor = BackColor;
            this.CaptionForeColor = foreColor;
            this.CaptionButtonColor = foreColor;
           this.CaptionBarColor = BackColor;
            
            this.BackColor = BackColor != Color.Transparent ? BackColor : Color.White;
            radioButtonAdv1.BackColor = Color.Transparent;
            this.radioButton1.BackColor = Color.Transparent;
            this.radioButton2.BackColor = Color.Transparent;
            this.radioButton3.BackColor = Color.Transparent;
            this.radioButton4.BackColor = Color.Transparent;
            this.radioButton5.BackColor = Color.Transparent;
            this.radioButton6.BackColor = Color.Transparent;
        }
    }
    public class Panels : Panel
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int borderWidth = 1;
            Color borderColor = ColorTranslator.FromHtml("#c5c5c5");

            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, borderColor,
            borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth,

            ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid,

            borderColor, borderWidth, ButtonBorderStyle.Solid);
        }
    }
}
