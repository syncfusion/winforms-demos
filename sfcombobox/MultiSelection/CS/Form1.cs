#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.ListView;
using Syncfusion.WinForms.ListView.Enums;

namespace MultiSelection
{
    public partial class Form1 : SfForm
    {
        CustomHeaderUserControl customTextBox;

        public Form1()
        {
            InitializeComponent();
            this.themeComboBox.Location = new Point(this.label6.Bounds.X + this.label6.Width,this.label6.Bounds.Y - 5);
            this.selectAll.DataSource = GetData();
            this.selectAll.DisplayMember = "LongName";
            this.tokenComboBox.EnableToken = true;   
            this.tokenComboBox.DataSource = this.GetData();
            this.tokenComboBox.DisplayMember = "LongName";
            this.tokenComboBox.DropDownStyle = DropDownStyle.DropDown;
            
           // this.tokenComboBox.Style.TokenStyle
            this.SfComboBoxSeetings();
            try
            {
#if NETCORE
                Bitmap bmp = new Bitmap(Image.FromFile(@"../../../Icon/sficon.ico"));
                this.Icon = Icon.FromHandle(bmp.GetHicon());
#else
                Bitmap bmp = new Bitmap(Image.FromFile(@"../../Icon/sficon.ico"));
                this.Icon = Icon.FromHandle(bmp.GetHicon());
#endif
            }
            catch (Exception ex)
            { }
        }

        void SfComboBoxSeetings()
        {
            List<USState> list = GetData();
            #region selectAll
            this.selectAll.DataSource = list;
            this.selectAll.DisplayMember = "LongName";
            this.selectAll.ComboBoxMode = ComboBoxMode.MultiSelection;
            this.selectAll.AllowSelectAll = true;
            this.selectAll.ThemeName = "Office2016Colorful";
            this.selectAll.DropDownListView.Style.ItemStyle.Font = new Font("Microsoft Sans Serif", 9.75f);
            foreach (object item in list)
            {
                this.selectAll.CheckedItems.Add(item);
            }
            #endregion
            #region toolTip
            this.toolTip.DataSource = list;
            this.toolTip.DisplayMember = "LongName";
            this.toolTip.ComboBoxMode = ComboBoxMode.MultiSelection;
            this.toolTip.ShowToolTip = true;
            this.toolTip.ThemeName = "Office2016Colorful";
            this.toolTip.DropDownListView.Style.ItemStyle.Font = new Font("Microsoft Sans Serif", 9.75f);
            this.toolTip.CheckedItems.Add(list[0]);
            this.toolTip.CheckedItems.Add(list[2]);
            this.toolTip.CheckedItems.Add(list[4]);
            this.toolTip.CheckedItems.Add(list[7]);
            this.toolTip.CheckedItems.Add(list[9]);
            this.toolTip.CheckedItems.Add(list[12]);
            #endregion
            #region delimiterChar
            this.delimiterChar.DataSource = list;
            this.delimiterChar.DisplayMember = "LongName";
            this.delimiterChar.DelimiterChar = "-";
            this.delimiterChar.ComboBoxMode = ComboBoxMode.MultiSelection;
            this.delimiterChar.ThemeName = "Office2016Colorful";
            this.delimiterChar.DropDownListView.Style.ItemStyle.Font = new Font("Microsoft Sans Serif", 9.75f);
            this.delimiterChar.CheckedItems.Add(list[0]);
            this.delimiterChar.CheckedItems.Add(list[3]);
            this.delimiterChar.CheckedItems.Add(list[6]);
            this.delimiterChar.CheckedItems.Add(list[7]);
            #endregion
            #region waterMark
            this.waterMark.DataSource = list;
            this.waterMark.DisplayMember = "LongName";
            this.waterMark.ComboBoxMode = ComboBoxMode.MultiSelection;
            this.waterMark.AllowNull = true;
            this.waterMark.ThemeName = "Office2016Colorful";
            this.waterMark.DropDownListView.Style.ItemStyle.Font = new Font("Microsoft Sans Serif", 9.75f);
            #endregion

            #region Search ComboBox
            this.SearchTextComboBox.DataSource = list;
            this.SearchTextComboBox.DisplayMember = "LongName";
            this.SearchTextComboBox.ComboBoxMode = ComboBoxMode.MultiSelection;
            this.SearchTextComboBox.AllowSelectAll = true;
            this.SearchTextComboBox.ShowToolTip = true;
            this.SearchTextComboBox.ThemeName = "Office2016Colorful";
            customTextBox = new CustomHeaderUserControl(this.SearchTextComboBox);
            this.SearchTextComboBox.TextBox.Font = new Font("Microsoft Sans Serif", 9.75f);
            this.SearchTextComboBox.DropDownListView.Style.ItemStyle.Font = new Font("Microsoft Sans Serif", 9.75f);
            this.SearchTextComboBox.DropDownListView.ShowHeader = true;
            this.SearchTextComboBox.DropDownListView.HeaderHeight = 23;
            this.SearchTextComboBox.DropDownListView.HeaderControl = customTextBox;
            this.SearchTextComboBox.DropDownListView.AllowSelectAll = true;            
            this.SearchTextComboBox.MaxDropDownItems = 11;
            this.SearchTextComboBox.CheckedItems.Add(list[1]);
            this.SearchTextComboBox.CheckedItems.Add(list[12]);
            this.tokenComboBox.SelectedItems.Add(this.tokenComboBox.DropDownListView.View.DisplayItems[0]);
            this.tokenComboBox.SelectedItems.Add(this.tokenComboBox.DropDownListView.View.DisplayItems[1]);
            #endregion

            #region themeCombo
            List<ThemeTypes> theme = new List<ThemeTypes>();
            theme.Add(new ThemeTypes() { ThemeName = "Office2016Black", Value = 0 });
            theme.Add(new ThemeTypes() { ThemeName = "Office2016White", Value = 0 });
            theme.Add(new ThemeTypes() { ThemeName = "Office2016DarkGray", Value = 0 });
            theme.Add(new ThemeTypes() { ThemeName = "Office2016Colorful", Value = 0 });
            this.themeComboBox.DataSource = theme;
            this.themeComboBox.DisplayMember = "ThemeName";
            this.themeComboBox.ValueMember = "ThemeName";
            this.themeComboBox.SelectedValue = "Office2016Colorful";
            this.themeComboBox.ThemeName = "Office2016Colorful";
            this.themeComboBox.DropDownStyle = DropDownStyle.DropDownList;
            this.themeComboBox.DropDownListView.Style.ItemStyle.Font = new Font("Microsoft Sans Serif", 9.75f);
            #endregion
        }

        List<USState> GetData()
        {
            // DisplayMember is used to display just the long name of each state.
            List<USState> USStates = new List<USState>();
            USStates.Add(new USState("Alaska", "AK", 1));
            USStates.Add(new USState("Arizona", "AZ", 2));
            USStates.Add(new USState("Arkansas", "AK", 3));
            USStates.Add(new USState("California", "CA", 4));
            USStates.Add(new USState("Colorado", "CO", 5));
            USStates.Add(new USState("Connecticut", "CT", 6));
            USStates.Add(new USState("Delaware", "DE", 3));
            USStates.Add(new USState("Florida", "FL", 4));
            USStates.Add(new USState("Georgia", "GA", 1));
            USStates.Add(new USState("Hawaii", "HI", 0));
            USStates.Add(new USState("Idaho", "ID", 3));
            USStates.Add(new USState("Illinois", "IL", 2));
            USStates.Add(new USState("Indiana", "IN", 6));
            USStates.Add(new USState("Iowa", "IA", 5));
            USStates.Add(new USState("Kansas", "KA", 5));
            USStates.Add(new USState("Kentucky", "KY", 4));
            USStates.Add(new USState("Louisiana", "LA", 3));
            USStates.Add(new USState("Maine", "ME", 0));
            USStates.Add(new USState("Maryland", "MD", 0));
            USStates.Add(new USState("Massachusetts", "MA", 2));
            USStates.Add(new USState("Michigan", "MI", 1));
            USStates.Add(new USState("Minnesota", "MN", 6));
            USStates.Add(new USState("Mississippi", "MS", 5));
            USStates.Add(new USState("Missouri", "MO", 2));
            USStates.Add(new USState("Montana", "MT", 1));
            USStates.Add(new USState("Nebraska", "NE", 4));
            USStates.Add(new USState("Nevada", "NV", 0));
            USStates.Add(new USState("New Hampshire", "NH", 3));
            USStates.Add(new USState("New Jersey", "NJ", 3));
            USStates.Add(new USState("New Mexico", "NM", 2));
            USStates.Add(new USState("New York", "NY", 5));
            USStates.Add(new USState("North Carolina", "NC", 4));
            USStates.Add(new USState("North Dakota", "ND", 4));
            USStates.Add(new USState("Ohio", "OH", 1));
            USStates.Add(new USState("Oklahoma", "OK", 2));
            USStates.Add(new USState("Oregon", "OR", 5));
            USStates.Add(new USState("Pennsylvania", "PA", 0));
            USStates.Add(new USState("Rhode Island", "RI", 6));
            USStates.Add(new USState("South Carolina", "SC", 5));
            USStates.Add(new USState("South Dakota", "SD", 4));
            USStates.Add(new USState("Tennessee", "TN", 3));
            USStates.Add(new USState("Texas", "TX", 2));
            USStates.Add(new USState("Utah", "UT", 0));
            USStates.Add(new USState("Vermont", "VT", 1));
            USStates.Add(new USState("Virginia", "VA", 0));
            USStates.Add(new USState("Washington", "WA", 2));
            USStates.Add(new USState("West Virginia", "WV", 0));
            USStates.Add(new USState("Wisconsin", "WI", 3));
            USStates.Add(new USState("Wyoming", "WY", 5));

            return USStates;
        }

        private void themeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.BeginUpdate();
            this.themeComboBox.ThemeName = this.themeComboBox.SelectedValue.ToString();
            this.tokenComboBox.ThemeName = this.themeComboBox.SelectedValue.ToString();
            this.SearchTextComboBox.ThemeName = this.themeComboBox.SelectedValue.ToString();
            this.selectAll.ThemeName = this.themeComboBox.SelectedValue.ToString();
            this.toolTip.ThemeName = this.themeComboBox.SelectedValue.ToString();
            this.delimiterChar.ThemeName = this.themeComboBox.SelectedValue.ToString();
            this.waterMark.ThemeName = this.themeComboBox.SelectedValue.ToString();
            switch (this.themeComboBox.SelectedValue.ToString())
            {
                case "Office2016Black":
                    this.Style.TitleBar.BackColor = Color.FromArgb(38, 38, 38);
                    this.Style.TitleBar.CloseButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.Style.TitleBar.CloseButtonHoverBackColor = ColorTranslator.FromHtml("#d4d4d4");
                    this.Style.TitleBar.MinimizeButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.Style.TitleBar.MinimizeButtonHoverBackColor = ColorTranslator.FromHtml("#d4d4d4");
                    this.BackColor = ColorTranslator.FromHtml("#444444");
                    this.label1.BackColor = ColorTranslator.FromHtml("#444444");
                    this.label2.BackColor = ColorTranslator.FromHtml("#444444");
                    this.label3.BackColor = ColorTranslator.FromHtml("#444444");
                    this.label4.BackColor = ColorTranslator.FromHtml("#444444");
                    this.label5.BackColor = ColorTranslator.FromHtml("#444444");
                    this.label6.BackColor = ColorTranslator.FromHtml("#444444");
                    this.label7.BackColor = ColorTranslator.FromHtml("#444444");
                    this.label8.BackColor = ColorTranslator.FromHtml("#444444");
                    this.customTextBox.BackColor = ColorTranslator.FromHtml("#444444");
                    this.Style.TitleBar.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                    this.label1.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                    this.label2.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                    this.label3.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                    this.label4.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                    this.label5.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                    this.label6.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                    this.label7.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                    this.label8.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                    this.customTextBox.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
#if NETCORE
                    this.customTextBox.pictureBox.Image = Image.FromFile(@"../../../Icon/Search_Black.png");
#else
                this.customTextBox.pictureBox.Image = Image.FromFile(@"../../Icon/Search_Black.png");
#endif

                    break;
                case "Office2016DarkGray":
                    this.BackColor = ColorTranslator.FromHtml("#d4d4d4");

                    this.Style.TitleBar.CloseButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.Style.TitleBar.CloseButtonHoverBackColor = ColorTranslator.FromHtml("#d4d4d4");
                    this.Style.TitleBar.MinimizeButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.Style.TitleBar.MinimizeButtonHoverBackColor = ColorTranslator.FromHtml("#d4d4d4");
                    this.Style.TitleBar.BackColor = Color.FromArgb(102, 102, 102);
                    this.label1.BackColor = ColorTranslator.FromHtml("#d4d4d4");
                    this.label2.BackColor = ColorTranslator.FromHtml("#d4d4d4");
                    this.label3.BackColor = ColorTranslator.FromHtml("#d4d4d4");
                    this.label4.BackColor = ColorTranslator.FromHtml("#d4d4d4");
                    this.label5.BackColor = ColorTranslator.FromHtml("#d4d4d4");
                    this.label6.BackColor = ColorTranslator.FromHtml("#d4d4d4");
                    this.label7.BackColor = ColorTranslator.FromHtml("#d4d4d4");
                    this.label8.BackColor = ColorTranslator.FromHtml("#d4d4d4");
                    this.customTextBox.BackColor = ColorTranslator.FromHtml("#d4d4d4");
                    this.Style.TitleBar.ForeColor = Color.FromArgb(240, 240, 240);
                    this.label1.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label2.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label3.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label4.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label5.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label6.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label7.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label8.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.customTextBox.ForeColor = ColorTranslator.FromHtml("#262626");
#if NETCORE
                    this.customTextBox.pictureBox.Image = Image.FromFile(@"../../../Icon/search_DarkGray.png");
#else
                this.customTextBox.pictureBox.Image = Image.FromFile(@"../../Icon/search_DarkGray.png");
#endif

                    break;
                default:
                    this.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    this.Style.TitleBar.BackColor = Color.FromArgb(242, 242, 242);
                    this.Style.TitleBar.CloseButtonForeColor = Color.FromArgb(51, 51, 51);
                    this.Style.TitleBar.MinimizeButtonForeColor = Color.FromArgb(51, 51, 51);
                    this.Style.TitleBar.CloseButtonHoverBackColor = this.Style.TitleBar.MinimizeButtonHoverBackColor;
                    this.Style.TitleBar.CloseButtonHoverForeColor = this.Style.TitleBar.MinimizeButtonHoverForeColor;
                    this.label1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    this.label2.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    this.label3.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    this.label4.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    this.label5.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    this.label6.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    this.label7.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    this.label8.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    this.customTextBox.BackColor = ColorTranslator.FromHtml("#FFFFFF");

                    this.Style.TitleBar.ForeColor = ColorTranslator.FromHtml("#444444");
                    this.label1.ForeColor = ColorTranslator.FromHtml("#444444");
                    this.label2.ForeColor = ColorTranslator.FromHtml("#444444");
                    this.label3.ForeColor = ColorTranslator.FromHtml("#444444");
                    this.label4.ForeColor = ColorTranslator.FromHtml("#444444");
                    this.label5.ForeColor = ColorTranslator.FromHtml("#444444");
                    this.label6.ForeColor = ColorTranslator.FromHtml("#444444");
                    this.label7.ForeColor = ColorTranslator.FromHtml("#444444");
                    this.label8.ForeColor = ColorTranslator.FromHtml("#444444");
                    this.customTextBox.ForeColor = ColorTranslator.FromHtml("#444444");
#if NETCORE
                    this.customTextBox.pictureBox.Image = Image.FromFile(@"../../../Icon/search_Colorful.png");
#else
                this.customTextBox.pictureBox.Image = Image.FromFile(@"../../Icon/search_Colorful.png");
#endif

                    break;
            }

            this.EndUpdate();
        }
    }

    #region "USState Class"
    /// <summary>
    /// Creating the class 
    /// </summary>
    public class USState
    {
        private string myShortName;
        private string myLongName;
        private int imgIndex;

        public USState(string strLongName, string strShortName, int imageIndex)
        {
            this.myShortName = strShortName;
            this.myLongName = strLongName;
            this.imgIndex = imageIndex;
        }

        public string ShortName
        {
            get
            {
                return myShortName;
            }
        }

        public string LongName
        {

            get
            {
                return myLongName;
            }
        }

        public int ImageIndex
        {
            get
            {
                return imgIndex;
            }
            set
            {
                imgIndex = value;
            }
        }


        public override string ToString()
        {
            return this.ShortName + " - " + this.LongName;
        }
    }
    #endregion

    #region ThemeData
    public class ThemeTypes
    {
        public string ThemeName { get; set; }
        public int Value { get; set; }
    }
    #endregion
}
