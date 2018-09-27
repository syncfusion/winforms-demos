using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.ListView;
using Syncfusion.WinForms.ListView.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GettingStarted
{
    public partial class Form1 : SfForm
    {
        #region constructor
        public Form1()
        {
            InitializeComponent();
            this.SfComboBoxSeetings();

            try
            {
                Bitmap bmp = new Bitmap(Image.FromFile(@"../../Icon/sficon.ico"));
                this.Icon = Icon.FromHandle(bmp.GetHicon());
            }
            catch (Exception ex)
            { }
        }
        #endregion

        #region SfComboBoxSettings
        void SfComboBoxSeetings()
        {
            List<USState> list = GetData();
            
            #region editMode
            this.editMode.DataSource = list;
            this.editMode.DisplayMember = "LongName";
            this.editMode.ValueMember = "LongName";
            this.editMode.SelectedValue = "Alaska";
            this.editMode.AutoCompleteMode = AutoCompleteMode.None;
            this.editMode.ThemeName = "Office2016Colorful";
            this.editMode.DropDownListView.Style.ItemStyle.Font = new Font("Microsoft Sans Serif", 9.75f);
            #endregion
           
            #region waterMark
            this.waterMark.DataSource = list;
            this.waterMark.DisplayMember = "LongName";
            this.waterMark.ValueMember = "LongName";
            this.waterMark.AllowNull = true;
            this.waterMark.AutoCompleteMode = AutoCompleteMode.None;
            this.waterMark.ThemeName = "Office2016Colorful";
            this.waterMark.DropDownListView.Style.ItemStyle.Font = new Font("Microsoft Sans Serif", 9.75f);
            #endregion

            #region suggest
            this.suggest.DataSource = list;
            this.suggest.DisplayMember = "LongName";
            this.editMode.ValueMember = "LongName";
            this.suggest.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.suggest.ThemeName = "Office2016Colorful";
            this.suggest.DropDownListView.Style.ItemStyle.Font = new Font("Microsoft Sans Serif", 9.75f);
            #endregion

            #region Suggest&Append
            this.suggestAppend.DataSource = list;
            this.suggestAppend.DisplayMember = "LongName";
            this.suggestAppend.ValueMember = "LongName";
            this.suggestAppend.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.suggestAppend.ThemeName = "Office2016Colorful";
            this.suggestAppend.DropDownListView.Style.ItemStyle.Font = new Font("Microsoft Sans Serif", 9.75f);
            #endregion

            #region append
            this.append.DataSource = list;
            this.append.DisplayMember = "LongName";
            this.append.ValueMember = "LongName";
            this.append.AutoCompleteMode = AutoCompleteMode.Append;
            this.append.ThemeName = "Office2016Colorful";
            this.append.DropDownListView.Style.ItemStyle.Font = new Font("Microsoft Sans Serif", 9.75f);
            #endregion

            #region dropDownStyle
            this.dropDownStyle.DataSource = list;
            this.dropDownStyle.DisplayMember = "LongName";
            this.dropDownStyle.ValueMember = "LongName";
            this.dropDownStyle.DropDownStyle = DropDownStyle.DropDownList;
            this.dropDownStyle.ThemeName = "Office2016Colorful";
            this.dropDownStyle.DropDownListView.Style.ItemStyle.Font = new Font("Microsoft Sans Serif", 9.75f);
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

        #region GenerateData
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
        #endregion
        #endregion

        #region Events
        private void autoCompleteMode_CheckedChanged(object sender, EventArgs e)
        {
            AutoCompleteMode mode;
            var control = sender as RadioButton;
            if (Enum.TryParse<AutoCompleteMode>(control.Text, out mode))
                this.editMode.AutoCompleteMode = mode;
        }

        private void dropDownStyles_CheckedChanged(object sender, EventArgs e)
        {
            DropDownStyle style;
            var control = sender as RadioButton;
            if(control.Checked && Enum.TryParse<DropDownStyle>(control.Text,out style))
                this.waterMark.DropDownStyle = style;
        }

        private void sfComboBox5_SelectedValueChanged(object sender, EventArgs e)
        {
            AutoCompleteMode mode;
            if (Enum.TryParse<AutoCompleteMode>(this.dropDownStyle.TextBox.Text, out mode))
                this.editMode.AutoCompleteMode = mode;
        }

        private void themeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.BeginUpdate();
            this.themeComboBox.ThemeName = this.themeComboBox.SelectedValue.ToString();
            this.editMode.ThemeName = this.themeComboBox.SelectedValue.ToString();
            this.waterMark.ThemeName = this.themeComboBox.SelectedValue.ToString();
            this.dropDownStyle.ThemeName = this.themeComboBox.SelectedValue.ToString();
            this.suggest.ThemeName = this.themeComboBox.SelectedValue.ToString();
            this.append.ThemeName = this.themeComboBox.SelectedValue.ToString();
            this.suggestAppend.ThemeName = this.themeComboBox.SelectedValue.ToString();
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
                    this.Style.TitleBar.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                    this.label1.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                    this.label2.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                    this.label3.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                    this.label4.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                    this.label5.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                    this.label6.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                    this.label7.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                    this.label8.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
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
                    this.Style.TitleBar.ForeColor = Color.FromArgb(240, 240, 240);
                    this.label1.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label2.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label3.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label4.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label5.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label6.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label7.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.label7.ForeColor = ColorTranslator.FromHtml("#262626");
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

                    this.Style.TitleBar.ForeColor = ColorTranslator.FromHtml("#444444");
                    this.label1.ForeColor = ColorTranslator.FromHtml("#444444");
                    this.label2.ForeColor = ColorTranslator.FromHtml("#444444");
                    this.label3.ForeColor = ColorTranslator.FromHtml("#444444");
                    this.label4.ForeColor = ColorTranslator.FromHtml("#444444");
                    this.label5.ForeColor = ColorTranslator.FromHtml("#444444");
                    this.label6.ForeColor = ColorTranslator.FromHtml("#444444");
                    this.label7.ForeColor = ColorTranslator.FromHtml("#444444");
                    this.label8.ForeColor = ColorTranslator.FromHtml("#444444");
                    break;
            }
            this.EndUpdate();
        }

        #endregion
    }


    #region SelecionModeData
    public class SelecionModeData
    {
        public string Mode { get; set; }
        public int Value { get; set; }
    }
    #endregion

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
