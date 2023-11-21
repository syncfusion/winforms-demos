#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using System.IO;
using Syncfusion.Licensing;
using System.Collections.Specialized;
namespace AutoCompleteDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
    {
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private FlatCombo comboBox;
        private Syncfusion.Windows.Forms.Tools.AutoComplete autoComplete1;
        private Label label2;
        private Label label3;
        private Panel groupBox1;
        private CheckBoxAdv checkBox3;
        private CheckBoxAdv checkBox2;
        private CheckBoxAdv checkBox1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private Label label4;
        private CheckBoxAdv checkBox6;
        private System.ComponentModel.IContainer components = null;
        private Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo autoCompleteDataColumnInfo1;
        private Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo autoCompleteDataColumnInfo2;

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.autoComplete1.OverrideCombo = true;
            HookEvents();
            AddCheckBox();
            this.autoComplete1.EnableDuplicateValues = true;
            this.autoComplete1.DataSource = Table();
            this.label2.ForeColor = ColorTranslator.FromHtml("#444444");
            this.groupBox1.ForeColor = ColorTranslator.FromHtml("#444444");

            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
        }

        private void AddCheckBox()
        {

            this.checkBox1.Text = "Ignore Case";
            this.checkBox2.Text = "Case Sensitive";
            this.checkBox3.Text = "AutoSort List";
            this.checkBox6.Text = "Override Combo";

            this.checkBox1.Size = new System.Drawing.Size(190, 40);
            this.checkBox2.Size = new System.Drawing.Size(190, 40);
            this.checkBox3.Size = new System.Drawing.Size(190, 40);
            this.checkBox6.Size = new System.Drawing.Size(190, 40);


        }

        private void HookEvents()
        {
            this.numericUpDown2.ValueChanged += NumericUpDown2_ValueChanged;
            this.numericUpDown1.ValueChanged += NumericUpDown1_ValueChanged;
            this.checkBox6.CheckedChanged += CheckBox6_CheckedChanged;
            this.checkBox3.CheckedChanged += CheckBox3_CheckedChanged;
            this.checkBox2.CheckedChanged += CheckBox2_CheckedChanged;
            this.checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
        }

        StringCollection countryCollection = new StringCollection() { "andorra", "Armenia", "Austria", "belgium", "Brazil", "Denmark", "France", "Georgia",
        "Germany", "Iran", "Malasiya", "New Zealand", "North Korea", "Russia", "Singapore", "South Korea", "Spain", "Sri Lanka", "United Kingdom", "Bangladesh", "Brazil", "China", "Egypt", "India", "Indonesia", "Japan", "Mexico",
        "Nigeria", "Pakistan", "Philippines", "Russia", "USA", "Austria", "Belgium", "United Kingdom", "Bangladesh", "India"
        };

        StringCollection capitalCollection = new StringCollection() { "Andorra la Vella", "Yerevan", "Vienna", "Brussels", "Brasilia", "Copenhagen", "Paris", "Tbilisi",
            "Berlin", "Tehran", "Kuala Lumpur", "Wellington", "Pyongyang", "Moscow",
        "Pulau Ujong", "Seoul", "Madrid", "Colombo", "London", "Dhaka", "Brasilia", "Beijing", "Cairo", "Delhi", "Jakarta", "Tokyo", "Mexico City",
            "Abuja", "Islamabad", "Manila", "Moscow", "Washington, D.C.","Vienna", "Brussels", "London", "Dhaka", "Delhi" };
        private DataTable Table()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Capital");
            dataTable.Columns.Add("Country");
            for (int i = 0; i < countryCollection.Count; i++)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow[1] = countryCollection[i];
                dataRow[0] = capitalCollection[i];
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
            this.checkBox6 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox3 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.autoCompleteDataColumnInfo1 = new Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo("Capital", 100, true);
            this.autoCompleteDataColumnInfo2 = new Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo("Country", 100, true);
            this.autoComplete1 = new Syncfusion.Windows.Forms.Tools.AutoComplete(this.components);
            this.comboBox = new AutoCompleteDemo.FlatCombo();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoComplete1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(832, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 593);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(22, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 274);
            this.groupBox1.TabIndex = 0;
            // 
            // checkBox6
            // 
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.checkBox6.Location = new System.Drawing.Point(39, 43);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(150, 21);
            this.checkBox6.TabIndex = 4;
            this.checkBox6.ThemeName = "Office2019Colorful";
            // 
            // checkBox3
            // 
            this.checkBox3.DrawFocusRectangle = false;
            this.checkBox3.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.checkBox3.Location = new System.Drawing.Point(39, 100);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(150, 21);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.ThemeName = "Office2019Colorful";
            // 
            // checkBox2
            // 
            this.checkBox2.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.checkBox2.Location = new System.Drawing.Point(39, 159);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(150, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.ThemeName = "Office2019Colorful";
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.checkBox1.Location = new System.Drawing.Point(39, 216);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(150, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.ThemeName = "Office2019Colorful";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(190, 159);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown2.TabIndex = 6;
            this.numericUpDown2.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(190, 100);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Preferred Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Preferred Height";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBox);
            this.panel2.Dock = DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 593);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter capital name : ";
            // 
            // autoCompleteDataColumnInfo1
            // 
            this.autoCompleteDataColumnInfo1.ColumnHeaderText = "Capital";
            this.autoCompleteDataColumnInfo1.ImageColumn = false;
            this.autoCompleteDataColumnInfo1.MatchingColumn = true;
            this.autoCompleteDataColumnInfo1.Visible = true;
            // 
            // autoCompleteDataColumnInfo2
            // 
            this.autoCompleteDataColumnInfo2.ColumnHeaderText = "Country";
            this.autoCompleteDataColumnInfo2.ImageColumn = false;
            this.autoCompleteDataColumnInfo2.MatchingColumn = false;
            this.autoCompleteDataColumnInfo2.Visible = true;
            // 
            // autoComplete1
            // 
            this.autoComplete1.AdjustHeightToItemCount = false;
            this.autoComplete1.AutoSortList = false;
            this.autoComplete1.Columns.Add(this.autoCompleteDataColumnInfo1);
            this.autoComplete1.Columns.Add(this.autoCompleteDataColumnInfo2);
            this.autoComplete1.HeaderFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.autoComplete1.ItemFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.autoComplete1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.autoComplete1.ParentForm = this;
            this.autoComplete1.ShowColumnHeader = true;
            this.autoComplete1.Style = Syncfusion.Windows.Forms.Tools.AutoCompleteStyle.Default;
            this.autoComplete1.ThemeName = "Office2019Colorful";
            // 
            // comboBox
            // 
            this.autoComplete1.SetAutoComplete(this.comboBox, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoSuggest);
            this.comboBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBox.Location = new System.Drawing.Point(250, 227);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(500, 31);
            this.comboBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ClientSize = new System.Drawing.Size(1137, 617);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customization";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoComplete1)).EndInit();
            this.ResumeLayout(false);

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int value = Int32.Parse((sender as NumericUpDown).Value.ToString());
            this.autoComplete1.PreferredHeight = value;
            
        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int value = Int32.Parse((sender as NumericUpDown).Value.ToString());
                this.autoComplete1.PreferredWidth = value;
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            bool checkedState = (sender as CheckBoxAdv).Checked;
            if (checkedState)
            {
                this.autoComplete1.AdjustHeightToItemCount = true;
                this.numericUpDown1.Enabled = false;
                this.numericUpDown2.Enabled = false;
                this.autoComplete1.AutoPersistentDropDownSize = false;

            }
            else
            {
                this.autoComplete1.AdjustHeightToItemCount = false;
                this.numericUpDown1.Enabled = true;
                this.numericUpDown2.Enabled = true;
                this.autoComplete1.AutoPersistentDropDownSize = true;
                this.autoComplete1.PreferredHeight = 100;
                this.autoComplete1.PreferredWidth = -1;
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            bool checkedState = (sender as CheckBoxAdv).Checked;
            if (checkedState)
            {
                this.autoComplete1.CaseSensitive = true;
            }
            else
            {
                this.autoComplete1.CaseSensitive = false;
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool checkedState = (sender as CheckBoxAdv).Checked;
            if (checkedState)
            {
                this.autoComplete1.IgnoreCase = true;
            }
            else
            {
                this.autoComplete1.IgnoreCase = false;
            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            bool checkedState = (sender as CheckBoxAdv).Checked;
            if (checkedState)
            {
                this.autoComplete1.AutoSortList = true;
            }
            else
            {
                this.autoComplete1.AutoSortList = false;
            }
        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            bool checkedState = (sender as CheckBoxAdv).Checked;
            if (checkedState)
            {
                this.autoComplete1.OverrideCombo = true;
                this.comboBox.DataSource = null;
            }
            else
            {
                this.autoComplete1.OverrideCombo = false;
                this.comboBox.DataSource = Table();
                this.comboBox.DisplayMember = "Country";
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
    public class FlatCombo : ComboBox
    {
        private const int WM_PAINT = 0xF;
        private int buttonWidth = SystemInformation.HorizontalScrollBarArrowWidth;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_PAINT)
            {
                using (var g = Graphics.FromHwnd(Handle))
                {
                    using (var p = new Pen(this.ForeColor))
                    {
                        g.DrawRectangle(p, 0, 0, Width - 1, Height - 1);
                        g.DrawLine(p, Width - buttonWidth, 0, Width - buttonWidth, Height);
                    }
                }
            }
        }
    }
}
