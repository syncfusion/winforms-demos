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
using System.Collections.Specialized;
using Syncfusion.HighContrastTheme.WinForms;

namespace AutoCompleteDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
    {
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Syncfusion.Windows.Forms.Tools.AutoComplete autoComplete1;
        private TextBoxExt textBox1;
        private Label label2;
        private Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo autoCompleteDataColumnInfo1;
        private Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo autoCompleteDataColumnInfo2;
        private Panel groupBox1;
        private CheckBoxAdv checkBox4;
        private CheckBoxAdv checkBox3;
        private CheckBoxAdv checkBox2;
        private CheckBoxAdv checkBox1;
        private ComboBoxAdv comboBoxAdv1;
        private Label label7;
        private System.ComponentModel.IContainer components = null;

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            autoComplete1.DataSource = this.Table();
            this.autoComplete1.AdjustHeightToItemCount = false;
            this.autoComplete1.ShowColumnHeader = true;
            this.autoComplete1.ShowGripper = true;
            this.autoComplete1.Columns.Add(this.autoCompleteDataColumnInfo1);
            this.autoComplete1.Columns.Add(this.autoCompleteDataColumnInfo2);
            HookEvents();
            AddStyles();
            AddingCheckBox();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
        }

        private void AddingCheckBox()
        {
            this.checkBox1.Text = "Show Column Header";
            this.checkBox2.Text = "Show Close Button";
            this.checkBox3.Text = "Show Gripper";
            this.checkBox4.Text = "Auto Add Item";

            this.checkBox1.Size = new System.Drawing.Size(255, 33);
            this.checkBox2.Size = new System.Drawing.Size(255, 33);
            this.checkBox3.Size = new System.Drawing.Size(255, 33);
            this.checkBox4.Size = new System.Drawing.Size(255, 33);
        }

        private void AddStyles()
        {
            this.groupBox1.ForeColor = ColorTranslator.FromHtml("#444444");
            this.checkBox1.ForeColor = ColorTranslator.FromHtml("#444444");
            this.checkBox2.ForeColor = ColorTranslator.FromHtml("#444444");
            this.checkBox3.ForeColor = ColorTranslator.FromHtml("#444444");
            this.checkBox4.ForeColor = ColorTranslator.FromHtml("#444444");
            this.label2.ForeColor = ColorTranslator.FromHtml("#444444");
            this.label7.ForeColor = ColorTranslator.FromHtml("#444444");
        }

        private void HookEvents()
        {
            this.comboBoxAdv1.SelectedIndexChanged += ComboBoxAdv1_SelectedIndexChanged;
            this.checkBox4.CheckedChanged += CheckBox4_CheckedChanged1;
            this.checkBox3.CheckedChanged += CheckBox3_CheckedChanged1;
            this.checkBox2.CheckedChanged += CheckBox2_CheckedChanged1;
            this.checkBox1.CheckedChanged += CheckBox1_CheckedChanged1;

        }

        private void CheckBox1_CheckedChanged1(object sender, EventArgs e)
        {
            bool checkedState = (sender as CheckBoxAdv).Checked;
            if (checkedState)
            {
                this.autoComplete1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            }
            else
            {
                this.autoComplete1.HeaderStyle = ColumnHeaderStyle.None;
            }
        }

        private void CheckBox2_CheckedChanged1(object sender, EventArgs e)
        {
            bool checkedState = (sender as CheckBoxAdv).Checked;
            if (checkedState)
            {
                this.autoComplete1.ShowCloseButton = true;
            }
            else
            {
                this.autoComplete1.ShowCloseButton = false;
            }
        }

        private void CheckBox3_CheckedChanged1(object sender, EventArgs e)
        {
            bool checkedState = (sender as CheckBoxAdv).Checked;
            if (checkedState)
            {
                this.autoComplete1.ShowGripper = true;
            }
            else
            {
                this.autoComplete1.ShowGripper = false;
            }
        }

        private void CheckBox4_CheckedChanged1(object sender, EventArgs e)
        {
           if(this.checkBox4.Checked)
            {
                this.autoComplete1.AutoAddItem = true;
            }
           else
            {
                this.autoComplete1.AutoAddItem = false;
            }
        }

        StringCollection countryCollection = new StringCollection() { "Antigua and Barbuda", "Bahamas", "Barbados", "Belize", "Canada", "Costa Rica", "Cuba", "Dominica",
        "Dominican Republic", "El Salvador", "Grenada", "Guatemala", "Haiti", "Honduras","Jamaica", "Mexico", "Nicaragua", "Panama", "Trinidad and Tobago", "United States of America"};

        StringCollection capitalCollection = new StringCollection() { "Saint John's", "Nassau", "Bridgetown", "Belmopan", "Ottawa", "San Jose", "Havana", "Roseau",
        "Santo Domingo", "San Salvador", "Saint George's", "Guatemala City", "Port-au-Prince", "Tegucigalpa","Kingston", "Mexico City", "Managua", "Panama City", "Port of Spain", "Washington, D.C."};
        private DataTable Table()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Country");
            dataTable.Columns.Add("Capital");
            for (int i = 0; i < countryCollection.Count; i++)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = countryCollection[i];
                dataRow[1] = capitalCollection[i];
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
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.Panel();
            this.checkBox4 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox3 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoComplete1 = new Syncfusion.Windows.Forms.Tools.AutoComplete(this.components);
            this.autoCompleteDataColumnInfo1 = new Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo("Country", 100, true);
            this.autoCompleteDataColumnInfo2 = new Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo("Capital", 100, true);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoComplete1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = DockStyle.Right;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(728, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 645);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.comboBoxAdv1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.groupBox1.Location = new System.Drawing.Point(18, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 332);
            this.groupBox1.TabIndex = 0;
            // 
            // checkBox4
            // 
            this.checkBox4.BeforeTouchSize = new System.Drawing.Size(134, 23);
            this.checkBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.checkBox4.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.checkBox4.Location = new System.Drawing.Point(33, 211);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(150, 21);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.ThemeName = "Office2019Colorful";
            // 
            // checkBox3
            // 
            this.checkBox3.BeforeTouchSize = new System.Drawing.Size(128, 23);
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.checkBox3.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.checkBox3.Location = new System.Drawing.Point(33, 156);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(150, 21);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.ThemeName = "Office2019Colorful";
            // 
            // checkBox2
            // 
            this.checkBox2.BeforeTouchSize = new System.Drawing.Size(167, 23);
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.checkBox2.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.checkBox2.Location = new System.Drawing.Point(33, 99);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(150, 21);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.ThemeName = "Office2019Colorful";
            // 
            // checkBox1
            // 
            this.checkBox1.BeforeTouchSize = new System.Drawing.Size(186, 23);
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.checkBox1.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.checkBox1.Location = new System.Drawing.Point(33, 42);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(150, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.ThemeName = "Office2019Colorful";
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(143, 28);
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.FlatStyle = Syncfusion.Windows.Forms.Tools.ComboFlatStyle.Flat;
            this.comboBoxAdv1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Country",
            "Capital"
            });
            this.comboBoxAdv1.Location = new System.Drawing.Point(175, 270);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(143, 28);
            this.comboBoxAdv1.TabIndex = 4;
            this.comboBoxAdv1.Text = "Country";
            this.comboBoxAdv1.ThemeName = "Office2019Colorful";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Matching Column";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = DockStyle.Left;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(1, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 645);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label2.Location = new System.Drawing.Point(14, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter country name :";
            // 
            // textBox1
            // 
            this.autoComplete1.SetAutoComplete(this.textBox1, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoSuggest);
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox1.BeforeTouchSize = new System.Drawing.Size(500, 29);
            this.textBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox1.Location = new System.Drawing.Point(188, 277);
            this.textBox1.Metrocolor = System.Drawing.Color.Gray;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(500, 29);
            this.textBox1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.textBox1.TabIndex = 2;
            this.textBox1.ThemeName = "Office2019Colorful";
            // 
            // autoComplete1
            // 
            this.autoComplete1.HeaderFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.autoComplete1.ItemFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.autoComplete1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.autoComplete1.ParentForm = this;
            this.autoComplete1.Style = Syncfusion.Windows.Forms.Tools.AutoCompleteStyle.Office2016Colorful;
            this.autoComplete1.ThemeName = "Office2019Colorful";
            // 
            // autoCompleteDataColumnInfo1
            // 
            this.autoCompleteDataColumnInfo1.ColumnHeaderText = "Country";
            this.autoCompleteDataColumnInfo1.ImageColumn = false;
            this.autoCompleteDataColumnInfo1.MatchingColumn = true;
            this.autoCompleteDataColumnInfo1.Visible = true;
            // 
            // autoCompleteDataColumnInfo2
            // 
            this.autoCompleteDataColumnInfo2.ColumnHeaderText = "Capital";
            this.autoCompleteDataColumnInfo2.ImageColumn = false;
            this.autoCompleteDataColumnInfo2.MatchingColumn = false;
            this.autoCompleteDataColumnInfo2.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ClientSize = new System.Drawing.Size(1122, 617);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appearance";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoComplete1)).EndInit();
            this.ResumeLayout(false);

        }

        private void ComboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = (sender as ComboBoxAdv).SelectedItem.ToString();
            if(selectedItem == "Country")
            {
                this.autoCompleteDataColumnInfo1.MatchingColumn = true;
                this.autoCompleteDataColumnInfo2.MatchingColumn = false;
            }
            else if( selectedItem == "Capital")
            {
                this.autoCompleteDataColumnInfo1.MatchingColumn = false;
                this.autoCompleteDataColumnInfo2.MatchingColumn = true;
            }
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
    }
}
