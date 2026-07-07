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
using Syncfusion.Runtime.Serialization;
using Syncfusion.WinForms.Controls;
using System.Collections.Generic;

namespace DataBindingDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
    {
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private ComboBoxAdv comboBoxAdv1;
        private Syncfusion.Windows.Forms.Tools.AutoComplete autoComplete1;
        private TextBoxExt textBox1;
        private Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo autoCompleteDataColumnInfo1;
        private Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo autoCompleteDataColumnInfo2;
        private Label label2;
        private ComboBoxAdv dataSource_ComboBox;
        private Label label3;
        private ComboBoxAdv autoComplete_Combo;
        private Label label4;
        private ComboBoxAdv format_Combo;
        private Label label5;
        private System.ComponentModel.IContainer components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            this.autoComplete1.ShowColumnHeader = true;

            this.dataSource_ComboBox.Items.AddRange(new object[] {
                "Array List",
            "Collection Base",
            "Data Table",
            "Generic Collection",
            "IBinding List",
            "Observable Collection"});

            this.autoComplete_Combo.Items.AddRange(new object[] {
                "Auto Suggest",
            "Auto Append", "Both",
            "Multi Suggest",
            "Multi Suggest Extended",
            "Disabled"});

            this.format_Combo.Items.AddRange(new object[] {
                "XML",
            "Binary",
            "Memory Stream"});

            this.format_Combo.SelectedIndex = 0;
            this.autoComplete_Combo.SelectedIndex = 0;
            this.dataSource_ComboBox.SelectedIndex = 0;
            this.SetArrayListData();

            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                if (ico != null)
                    this.Icon = ico;
            }
            catch { }


            this.dataSource_ComboBox.ThemeName = "Office2019Colorful";
            this.format_Combo.ThemeName = "Office2019Colorful";
            this.autoComplete_Combo.ThemeName = "Office2019Colorful";

            this.dataSource_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.format_Combo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.autoComplete_Combo.DropDownStyle = ComboBoxStyle.DropDownList;

            //ForeColor
            this.label1.ForeColor = ColorTranslator.FromHtml("#444444");
            this.label2.ForeColor = ColorTranslator.FromHtml("#444444");
            this.label3.ForeColor = ColorTranslator.FromHtml("#444444");
            this.label4.ForeColor = ColorTranslator.FromHtml("#444444");
            this.label5.ForeColor = ColorTranslator.FromHtml("#444444");
        }

        StringCollection stringCollection = new StringCollection() { "Bangladesh", "Brazil", "China", "Egypt", "India", "Indonesia", "Japan", "Mexico",
        "Nigeria", "Pakistan", "Philippines", "Russia", "USA"};
        private void SetTable()                                   
        {                                                          
            DataTable dataTable = new DataTable();                  
            dataTable.Columns.Add("Country");
            for (int i = 0; i < stringCollection.Count ; i++)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = stringCollection[i];
                dataTable.Rows.Add(dataRow);
            }

            autoComplete1.ResetHistory();
            autoComplete1 = new AutoComplete(this.components);
            autoComplete1.ParentForm = this;
            setAutoCompleteMode(autoComplete1);
            autoComplete1.ShowColumnHeader = true;
            autoComplete1.ThemeName = "Office2019Colorful";
            autoComplete1.DataSource = null;
            autoComplete1.CategoryName = "Country";
            autoComplete1.DataSource = dataTable;
            autoComplete1.RefreshColumns();
            this.autoComplete1.Columns[0].MatchingColumn = true;
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.format_Combo = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.autoComplete_Combo = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.dataSource_ComboBox = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoComplete1 = new Syncfusion.Windows.Forms.Tools.AutoComplete(this.components);
            this.autoCompleteDataColumnInfo1 = new Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo("Flag", 100, true);
            this.autoCompleteDataColumnInfo2 = new Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo("Country", 100, true);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.format_Combo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoComplete_Combo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource_ComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoComplete1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.format_Combo);
            this.panel1.Controls.Add(this.autoComplete_Combo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dataSource_ComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(492, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 421);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Format To Serialize";
            // 
            // format_Combo
            // 
            this.format_Combo.BeforeTouchSize = new System.Drawing.Size(124, 21);
            this.format_Combo.Location = new System.Drawing.Point(127, 133);
            this.format_Combo.Margin = new System.Windows.Forms.Padding(2);
            this.format_Combo.Name = "format_Combo";
            this.format_Combo.Size = new System.Drawing.Size(124, 21);
            this.format_Combo.TabIndex = 4;
            this.format_Combo.Text = "comboBoxAdv3";
            this.format_Combo.SelectedIndexChanged += new System.EventHandler(this.format_Combo_SelectedIndexChanged);
            // 
            // autoComplete_Combo
            // 
            this.autoComplete_Combo.BeforeTouchSize = new System.Drawing.Size(124, 21);
            this.autoComplete_Combo.Location = new System.Drawing.Point(127, 77);
            this.autoComplete_Combo.Margin = new System.Windows.Forms.Padding(2);
            this.autoComplete_Combo.Name = "autoComplete_Combo";
            this.autoComplete_Combo.Size = new System.Drawing.Size(124, 21);
            this.autoComplete_Combo.TabIndex = 3;
            this.autoComplete_Combo.Text = "comboBoxAdv2";
            this.autoComplete_Combo.SelectedIndexChanged += new System.EventHandler(this.autoComplete_Combo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Auto Complete Mode";
            // 
            // dataSource_ComboBox
            // 
            this.dataSource_ComboBox.BeforeTouchSize = new System.Drawing.Size(124, 21);
            this.dataSource_ComboBox.Location = new System.Drawing.Point(127, 27);
            this.dataSource_ComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.dataSource_ComboBox.Name = "dataSource_ComboBox";
            this.dataSource_ComboBox.Size = new System.Drawing.Size(124, 21);
            this.dataSource_ComboBox.TabIndex = 1;
            this.dataSource_ComboBox.Text = "Select Data Source";
            this.dataSource_ComboBox.SelectedIndexChanged += new System.EventHandler(this.dataSource_ComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data Source ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visual Style";
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(186, 21);
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Office2019Colorful",
            "HighContrastBlack",
            "Office2016Colorful",
            "Office2016White",
            "Office2016Black",
            "Office2016DarkGray",
            "Metro",
            "Default"});
            this.comboBoxAdv1.Location = new System.Drawing.Point(155, 84);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(186, 21);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.comboBoxAdv1.TabIndex = 3;
            this.comboBoxAdv1.Text = "Office2019Colorful";
            this.comboBoxAdv1.ThemeName = "Office2016Colorful";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(4, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 421);
            this.panel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Enter your option :";
            // 
            // textBox1
            // 
            this.autoComplete1.SetAutoComplete(this.textBox1, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.MultiSuggestExtended);
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox1.BeforeTouchSize = new System.Drawing.Size(201, 22);
            this.textBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox1.Location = new System.Drawing.Point(193, 148);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Metrocolor = System.Drawing.Color.Gray;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 22);
            this.textBox1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.textBox1.TabIndex = 2;
            this.textBox1.ThemeName = "Office2019Colorful";
            // 
            // autoComplete1
            // 
            this.autoComplete1.AdjustHeightToItemCount = false;
            this.autoComplete1.HeaderFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.autoComplete1.ItemFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.autoComplete1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.autoComplete1.ParentForm = this;
            this.autoComplete1.Style = Syncfusion.Windows.Forms.Tools.AutoCompleteStyle.Default;
            this.autoComplete1.ThemeName = "Default";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ClientSize = new System.Drawing.Size(768, 437);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Binding";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.format_Combo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoComplete_Combo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource_ComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoComplete1)).EndInit();
            this.ResumeLayout(false);

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

        private int selectedIndex = 0;
        private void dataSource_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxAdv comboBox = sender as ComboBoxAdv;
            if (comboBox.SelectedIndex != selectedIndex)
            {
                selectedIndex = comboBox.SelectedIndex;
                switch (comboBox.Text)
                {
                    case "Data Table":
                        SetTable();
                        break;
                    case "IBinding List":
                        SetIBindingSource();
                        break;

                    case "Array List":
                        SetArrayListData();
                        break;

                    case "Collection Base":
                        SetCollectionBaseSource();
                        break;

                    case "Generic Collection":
                        SetGenericCollectionSource();
                        break;

                    case "Observable Collection":
                        SetObservableCollection();
                        break;
                }
            }
        }

        #region DataSource
        /// <summary>
        /// Sets the ArrayList datasource to the Grid.
        /// </summary>
        private void SetArrayListData()
        {
            ArrayList al = new ArrayList();
            al.Add(new ParentItem(1, "Condiments", "Charlotte Cooper", "Bigfoot Breweries"));
            al.Add(new ParentItem(2, "Confections", "Regina Murphy", "Grandma Kelly's Homestead"));
            al.Add(new ParentItem(3, "Grains/Cereals", "Jean-Guy Lauzon", "Ma Maison"));
            al.Add(new ParentItem(4, "Meat/Poultry", "Shelley Burke", "New Orleans Cajun Delights"));
            al.Add(new ParentItem(5, "Produce", "Mayumi Ohno", "Mayumi's"));
            al.Add(new ParentItem(6, "Seafood", "Robb Merchant", "New England Seafood Cannery"));
            al.Add(new ParentItem(7, "Condiments", "Charlotte Cooper", "Bigfoot Breweries"));
            al.Add(new ParentItem(8, "Confections", "Regina Murphy", "Grandma Kelly's Homestead"));
            al.Add(new ParentItem(9, "Grains/Cereals", "Jean-Guy Lauzon", "Ma Maison"));
            al.Add(new ParentItem(10, "Meat/Poultry", "Shelley Burke", "New Orleans Cajun Delights"));

            autoComplete1.ResetHistory();
            autoComplete1 = new AutoComplete(this.components);
            autoComplete1.ParentForm = this;
            setAutoCompleteMode(autoComplete1);
            autoComplete1.ShowColumnHeader = true;
            autoComplete1.ThemeName = "Office2019Colorful";
            autoComplete1.Columns.Clear();
            this.autoComplete1.DataSource = null;
            this.autoComplete1.DataSource = al;
            autoComplete1.RefreshColumns();
            this.autoComplete1.Columns[1].MatchingColumn = true;

            this.autoComplete1.Columns[0].ColumnHeaderText = "S.No";
            this.autoComplete1.Columns[1].ColumnHeaderText = "Category Name";
            this.autoComplete1.Columns[1].ColumnHeaderText = "Supplier Name";
            this.autoComplete1.Columns[1].ColumnHeaderText = "Company Name";

            foreach (AutoCompleteDataColumnInfo column in autoComplete1.Columns)
            {
                column.MinColumnWidth = 150;
            }
        }
        public void SetIBindingSource()
        {
            BindingList<ProductDetails> list = new BindingList<ProductDetails>();
            list.Add(new ProductDetails(1,"Confections"));
            list.Add(new ProductDetails(2,"Cereals"));
            list.Add(new ProductDetails(3,"Grains"));
            list.Add(new ProductDetails(4,"Meat/Poultry"));
            list.Add(new ProductDetails(5,"Produce"));
            list.Add(new ProductDetails(6,"Seafood"));

            autoComplete1.ResetHistory();
            autoComplete1 = new AutoComplete(this.components);
            autoComplete1.ParentForm = this;
            setAutoCompleteMode(autoComplete1);
            autoComplete1.ShowColumnHeader = true;
            autoComplete1.ThemeName = "Office2019Colorful";
            autoComplete1.Columns.Clear();
            autoComplete1.DataSource = null;
            autoComplete1.DataSource = list;
            autoComplete1.RefreshColumns();
            this.autoComplete1.Columns[1].MatchingColumn = true;

            this.autoComplete1.Columns[0].ColumnHeaderText = "S.No";
            this.autoComplete1.Columns[1].ColumnHeaderText = "Category Name";
            foreach (AutoCompleteDataColumnInfo column in autoComplete1.Columns)
            {
                column.MinColumnWidth = 150;
            }
        }

        void SetCollectionBaseSource()
        {
            CollectionBaseData collectionBaseSource = new CollectionBaseData();
            collectionBaseSource.Add(new Data(1, "Produce", "Sweets", "Out of stock"));
            collectionBaseSource.Add(new Data(2, "Healthy", "Deserts and Candies", "Out of stock"));
            collectionBaseSource.Add(new Data(3, "Grains/Cereals", "Breads, pasta and cereal", "Available"));
            collectionBaseSource.Add(new Data(4, "Meat/Poultry", "Prepared meats", "Available"));
            collectionBaseSource.Add(new Data(5, "Produce", "Dried fruit and bean curd", "Out of stock"));
            collectionBaseSource.Add(new Data(6, "Seafood", "Seeweed and fish", "Available"));
            collectionBaseSource.Add(new Data(7, "Hot Beverages ", "Coffees", "Available"));
            collectionBaseSource.Add(new Data(8, "Healthy", "Sweet potatoes", "Available"));

            autoComplete1.ResetHistory();
            autoComplete1 = new AutoComplete(this.components);
            autoComplete1.ParentForm = this;
            setAutoCompleteMode(autoComplete1);
            autoComplete1.ShowColumnHeader = true;
            autoComplete1.Columns.Clear();
            autoComplete1.ThemeName = "Office2019Colorful";
            autoComplete1.DataSource = null;
            autoComplete1.DataSource = collectionBaseSource;
            autoComplete1.RefreshColumns();
            this.autoComplete1.Columns[1].MatchingColumn = true;

            this.autoComplete1.Columns[0].ColumnHeaderText = "Category ID";
            this.autoComplete1.Columns[1].ColumnHeaderText = "Description";
            this.autoComplete1.Columns[2].ColumnHeaderText = "Category Name";
            this.autoComplete1.Columns[3].ColumnHeaderText = "Other Info";
            foreach (AutoCompleteDataColumnInfo column in autoComplete1.Columns)
            {
                column.MinColumnWidth = 150;
            }
        }

        void SetGenericCollectionSource()
        {
            BindingList<GenericCollection> genericData = new BindingList<GenericCollection>();
            genericData.Add(new GenericCollection(0101, "Charlotte", "Cooper", "49 Gilbert St.", "London"));
            genericData.Add(new GenericCollection(0102, "Shelley", "Burke", "P.O. Box 78934", "New Orleans"));
            genericData.Add(new GenericCollection(0103, "Regina", "Murphy", "707 Oxford Rd.", "Ann Arbor"));
            genericData.Add(new GenericCollection(0104, "Yoshi", "Nagase", "9-8 Sekimai Musashino-shi", "Tokyo"));
            genericData.Add(new GenericCollection(0105, "Mayumi", "Ohno", "Calle del Rosal 4", "Oviedo"));
            genericData.Add(new GenericCollection(0106, "Ian", "Devling", "92 Setsuko Chuo-ku", "Osaka"));
            genericData.Add(new GenericCollection(0107, "Peter", "Wilson", "74 Rose St. Moonie Ponds", "Melbourne"));

            autoComplete1.ResetHistory();
            autoComplete1 = new AutoComplete(this.components);
            autoComplete1.ParentForm = this;
            setAutoCompleteMode(autoComplete1);
            autoComplete1.ShowColumnHeader = true;
            autoComplete1.ThemeName = "Office2019Colorful";
            autoComplete1.Columns.Clear();
            autoComplete1.DataSource = null;
            autoComplete1.DataSource = genericData;
            autoComplete1.RefreshColumns();
            this.autoComplete1.Columns[1].MatchingColumn = true;

            this.autoComplete1.Columns[0].ColumnHeaderText = "ID";
            this.autoComplete1.Columns[1].ColumnHeaderText = "First Name";
            this.autoComplete1.Columns[2].ColumnHeaderText = "Last Name";
            this.autoComplete1.Columns[3].ColumnHeaderText = "Address";
            this.autoComplete1.Columns[4].ColumnHeaderText = "City";
            foreach (AutoCompleteDataColumnInfo column in autoComplete1.Columns)
            {
                column.MinColumnWidth = 150;
            }
        }

        void SetObservableCollection()
        {
            autoComplete1.ResetHistory();
            autoComplete1 = new AutoComplete(this.components);
            autoComplete1.ParentForm = this;
            setAutoCompleteMode(autoComplete1);
            autoComplete1.ShowColumnHeader = true;
            autoComplete1.ThemeName = "Office2019Colorful";
            autoComplete1.DataSource = null;
#if !NETCORE
            autoComplete1.DataSource = new Customer();
#else
            autoComplete1.DataSource = GetSampleCustomers(); 
#endif
            autoComplete1.RefreshColumns();
            this.autoComplete1.Columns[2].MatchingColumn = true;

            this.autoComplete1.Columns[0].ColumnHeaderText = "Order ID";
            this.autoComplete1.Columns[1].ColumnHeaderText = "Customer ID";
            this.autoComplete1.Columns[2].ColumnHeaderText = "Ship Name";
            this.autoComplete1.Columns[3].ColumnHeaderText = "Ship Address";
            this.autoComplete1.Columns[4].ColumnHeaderText = "Ship City";
            this.autoComplete1.Columns[5].ColumnHeaderText = "Ship Postal Code";
            this.autoComplete1.Columns[6].ColumnHeaderText = "Ship Country";

            foreach(AutoCompleteDataColumnInfo column in autoComplete1.Columns)
            {
                column.MinColumnWidth = 150;
            }
        }

        private List<OrderInfo> GetSampleCustomers()
        {
            return new List<OrderInfo>
        {
        new OrderInfo { OrderID = 101, CustomerID = "CUS001", ShipName = "Sunrise Traders", ShipAddress = "123 Elm Street", ShipCity = "New York", ShipPostalCode = "10001", ShipCountry = "USA" },
        new OrderInfo { OrderID = 102, CustomerID = "CUS002", ShipName = "Oceanic Enterprises", ShipAddress = "456 Oak Avenue", ShipCity = "Los Angeles", ShipPostalCode = "90001", ShipCountry = "USA" },
        new OrderInfo { OrderID = 103, CustomerID = "CUS003", ShipName = "Global Supplies Ltd.", ShipAddress = "789 Pine Road", ShipCity = "Chicago", ShipPostalCode = "60601", ShipCountry = "USA" },
        new OrderInfo { OrderID = 104, CustomerID = "CUS004", ShipName = "Horizon Exports", ShipAddress = "321 Maple Lane", ShipCity = "Houston", ShipPostalCode = "77001", ShipCountry = "USA" },
        new OrderInfo { OrderID = 105, CustomerID = "CUS005", ShipName = "Northern Lights Logistics", ShipAddress = "654 Birch Boulevard", ShipCity = "Seattle", ShipPostalCode = "98101", ShipCountry = "USA" },
        new OrderInfo { OrderID = 106, CustomerID = "CUS006", ShipName = "Eastern Cargo Co.", ShipAddress = "987 Cedar Drive", ShipCity = "Boston", ShipPostalCode = "02108", ShipCountry = "USA" },
        new OrderInfo { OrderID = 107, CustomerID = "CUS007", ShipName = "Pacific Trading Corp.", ShipAddress = "135 Palm Street", ShipCity = "San Francisco", ShipPostalCode = "94101", ShipCountry = "USA" },
        new OrderInfo { OrderID = 108, CustomerID = "CUS008", ShipName = "Summit Wholesale", ShipAddress = "246 Spruce Court", ShipCity = "Denver", ShipPostalCode = "80201", ShipCountry = "USA" },
        new OrderInfo { OrderID = 109, CustomerID = "CUS009", ShipName = "Aspen Ventures", ShipAddress = "369 Aspen Way", ShipCity = "Salt Lake City", ShipPostalCode = "84101", ShipCountry = "USA" }
        };
        }

        public class OrderInfo
        {
            public int OrderID { get; set; }
            public string CustomerID { get; set; }
            public string ShipName { get; set; }
            public string ShipAddress { get; set; }
            public string ShipCity { get; set; }
            public string ShipPostalCode { get; set; }
            public string ShipCountry { get; set; }
        }
        #endregion

        string autoCompleteMode = "Auto Suggest";
        private void setAutoCompleteMode(AutoComplete autoComplete)
        {
            if (autoCompleteMode == "Auto Suggest")
                autoComplete.SetAutoComplete(this.textBox1, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoSuggest);
            else if (autoCompleteMode == "Auto Append")
                autoComplete.SetAutoComplete(this.textBox1, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoAppend);
            else if (autoCompleteMode == "Both")
                autoComplete.SetAutoComplete(this.textBox1, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Both);
            else if (autoCompleteMode == "Multi Suggest")
                autoComplete.SetAutoComplete(this.textBox1, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.MultiSuggest);
            else if (autoCompleteMode == "Multi Suggest Extended")
                autoComplete.SetAutoComplete(this.textBox1, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.MultiSuggestExtended);
            else
                autoComplete.SetAutoComplete(this.textBox1, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Disabled);
        }
        private void autoComplete_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxAdv comboBox = sender as ComboBoxAdv;
            autoCompleteMode = comboBox.SelectedItem.ToString();

            setAutoCompleteMode(this.autoComplete1);
        }

        string formatToSerialize = "XML";
        private void format_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxAdv comboBox = sender as ComboBoxAdv;
            formatToSerialize = comboBox.SelectedItem.ToString();
        }
    }
}
