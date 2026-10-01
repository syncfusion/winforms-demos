#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
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
    public partial class Form1 : MetroForm
    {
        bool isDefaultTheme = false;
        public Form1()
        {
            InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            themeComboBoxSettings();
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
        /// ComboBox settings
        /// </summary>
        private void themeComboBoxSettings()
        {
            List<string> list = new List<string>();
            list.AddRange(new string[]
            {
            "Default",
            "Office2007Black",
            "Office2007Blue",
            "Office2007Managed",
            "Office2007Silver",
            "Office2010Black",
            "Office2010Blue",
            "Office2010Managed",
            "Office2010Silver",
            "Metro",
            "Office2016Colorful",
            "Office2016DarkGray",
            "Office2016White" });
            this.themeComboBox.DataSource = list;
            this.themeComboBox.SelectedValue = "Metro";
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
        }

        /// <summary>
        /// Change the theme for MessageBoxAdv.
        /// </summary>
        private void themeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.themeComboBox.SelectedItem.ToString() == "Default")
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Default;
                MessageBoxAdv.UseDefaultTheme = true;
                SetDefaultTheme();
                this.panel2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.tableLayoutPanel1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.label1.ForeColor = ColorTranslator.FromHtml("#000000");
                this.lbl_Description.ForeColor = ColorTranslator.FromHtml("#000000");
                this.Resize.ForeColor = ColorTranslator.FromHtml("#000000");
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.CaptionBarColor = ColorTranslator.FromHtml("#ffffff");
                this.CaptionForeColor = ColorTranslator.FromHtml("#000000");
                this.CaptionButtonColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.Style.ReadOnlyEditorStyle.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.themeComboBox.Style.ReadOnlyEditorStyle.ForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.Style.DropDownStyle.GripperBackColor = ColorTranslator.FromHtml("#ffffff");
                this.themeComboBox.Style.DropDownStyle.GripperForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.DropDownListView.Style.ItemStyle.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.themeComboBox.DropDownListView.Style.ItemStyle.ForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.HoverBackColor = ColorTranslator.FromHtml("#f2f2f2");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.HoverForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.SelectionBackColor = ColorTranslator.FromHtml("#a6d8ff");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.SelectionForeColor = ColorTranslator.FromHtml("#000000");
            }
            if (this.themeComboBox.SelectedItem.ToString() == "Office2007Black")
            {
                MessageBoxAdv.Office2007Theme = Office2007Theme.Black;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Default;
                MessageBoxAdv.UseDefaultTheme = isDefaultTheme ? false : isDefaultTheme;
                setOffice2007Theme();
                this.themeComboBox.ThemeName = "Office2007Black";
                this.panel2.BackColor = ColorTranslator.FromHtml("#444444");
                this.tableLayoutPanel1.BackColor = ColorTranslator.FromHtml("#444444");
                this.label1.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                this.lbl_Description.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                this.Resize.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                this.BackColor = ColorTranslator.FromHtml("#444444");
                this.CaptionBarColor = ColorTranslator.FromHtml("#444444"); 
                this.CaptionForeColor = ColorTranslator.FromHtml("#d3d3d3");
                this.CaptionButtonColor = ColorTranslator.FromHtml("#d3d3d3");
                this.themeComboBox.Style.ReadOnlyEditorStyle.BackColor = ColorTranslator.FromHtml("#444444");
                this.themeComboBox.Style.ReadOnlyEditorStyle.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                this.themeComboBox.Style.DropDownStyle.GripperBackColor = ColorTranslator.FromHtml("#444444");
                this.themeComboBox.Style.DropDownStyle.GripperForeColor = ColorTranslator.FromHtml("#d3d3d3");
                this.themeComboBox.DropDownListView.Style.ItemStyle.BackColor = ColorTranslator.FromHtml("#444444");
                this.themeComboBox.DropDownListView.Style.ItemStyle.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.HoverBackColor = ColorTranslator.FromHtml("#fcf5d2");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.HoverForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.SelectionBackColor = ColorTranslator.FromHtml("#ffdf6a");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.SelectionForeColor = ColorTranslator.FromHtml("#000000");
            }
            if (this.themeComboBox.SelectedItem.ToString() == "Office2007Blue")
            {
                MessageBoxAdv.Office2007Theme = Office2007Theme.Blue;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Default;
                MessageBoxAdv.UseDefaultTheme = isDefaultTheme ? false : isDefaultTheme;
                setOffice2007Theme();
                this.themeComboBox.ThemeName = "Office2007Blue";
                this.panel2.BackColor = ColorTranslator.FromHtml("#d8e8fe");
                this.tableLayoutPanel1.BackColor = ColorTranslator.FromHtml("#d8e8fe");
                this.label1.ForeColor = ColorTranslator.FromHtml("#000000");
                this.lbl_Description.ForeColor = ColorTranslator.FromHtml("#000000");
                this.Resize.ForeColor = ColorTranslator.FromHtml("#000000");
                this.BackColor = ColorTranslator.FromHtml("#d8e8fe");
                this.CaptionBarColor = ColorTranslator.FromHtml("#d8e8fe");
                this.CaptionForeColor = ColorTranslator.FromHtml("#000000");
                this.CaptionButtonColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.Style.ReadOnlyEditorStyle.BackColor = ColorTranslator.FromHtml("#d8e8fe");
                this.themeComboBox.Style.ReadOnlyEditorStyle.ForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.Style.DropDownStyle.GripperBackColor = ColorTranslator.FromHtml("#d8e8fe");
                this.themeComboBox.Style.DropDownStyle.GripperForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.DropDownListView.Style.ItemStyle.BackColor = ColorTranslator.FromHtml("#d8e8fe");
                this.themeComboBox.DropDownListView.Style.ItemStyle.ForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.HoverBackColor = ColorTranslator.FromHtml("#fcf5d2");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.HoverForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.SelectionBackColor = ColorTranslator.FromHtml("#ffdf6a");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.SelectionForeColor = ColorTranslator.FromHtml("#000000");
            }
            if (this.themeComboBox.SelectedItem.ToString() == "Office2007Managed")
            {
                MessageBoxAdv.Office2007Theme = Office2007Theme.Managed;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Default;
                Office2007Colors.ApplyManagedColors(this, Color.Red);
                MessageBoxAdv.UseDefaultTheme = isDefaultTheme ? false : isDefaultTheme;
                setOffice2007Theme();
                this.panel2.BackColor = ColorTranslator.FromHtml("#fad2da");
                this.tableLayoutPanel1.BackColor = ColorTranslator.FromHtml("#fad2da");
                this.label1.ForeColor = ColorTranslator.FromHtml("#000000");
                this.lbl_Description.ForeColor = ColorTranslator.FromHtml("#000000");
                this.Resize.ForeColor = ColorTranslator.FromHtml("#000000");
                this.BackColor = ColorTranslator.FromHtml("#fad2da");
                this.CaptionBarColor = ColorTranslator.FromHtml("#fad2da");
                this.CaptionForeColor = ColorTranslator.FromHtml("#000000");
                this.CaptionButtonColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.Style.ReadOnlyEditorStyle.BackColor = ColorTranslator.FromHtml("#fad2da");
                this.themeComboBox.Style.ReadOnlyEditorStyle.ForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.Style.DropDownStyle.GripperBackColor = ColorTranslator.FromHtml("#fad2da");
                this.themeComboBox.Style.DropDownStyle.GripperForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.DropDownListView.Style.ItemStyle.BackColor = ColorTranslator.FromHtml("#fad2da");
                this.themeComboBox.DropDownListView.Style.ItemStyle.ForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.HoverBackColor = ColorTranslator.FromHtml("#fcf5d2");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.HoverForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.SelectionBackColor = ColorTranslator.FromHtml("#ffdf6a");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.SelectionForeColor = ColorTranslator.FromHtml("#000000");
            }
            if (this.themeComboBox.SelectedItem.ToString() == "Office2007Silver")
            {
                MessageBoxAdv.Office2007Theme = Office2007Theme.Silver;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Default;
                MessageBoxAdv.UseDefaultTheme = isDefaultTheme ? false : isDefaultTheme;
                setOffice2007Theme();
                this.panel2.BackColor = ColorTranslator.FromHtml("#cacfd9");
                this.tableLayoutPanel1.BackColor = ColorTranslator.FromHtml("#cacfd9");
                this.label1.ForeColor = ColorTranslator.FromHtml("#000000");
                this.lbl_Description.ForeColor = ColorTranslator.FromHtml("#000000");
                this.Resize.ForeColor = ColorTranslator.FromHtml("#000000");
                this.BackColor = ColorTranslator.FromHtml("#cacfd9");
                this.CaptionBarColor = ColorTranslator.FromHtml("#cacfd9");
                this.CaptionForeColor = ColorTranslator.FromHtml("#000000");
                this.CaptionButtonColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.Style.ReadOnlyEditorStyle.BackColor = ColorTranslator.FromHtml("#cacfd9");
                this.themeComboBox.Style.ReadOnlyEditorStyle.ForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.Style.DropDownStyle.GripperBackColor = ColorTranslator.FromHtml("#cacfd9");
                this.themeComboBox.Style.DropDownStyle.GripperForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.DropDownListView.Style.ItemStyle.BackColor = ColorTranslator.FromHtml("#cacfd9");
                this.themeComboBox.DropDownListView.Style.ItemStyle.ForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.HoverBackColor = ColorTranslator.FromHtml("#fcf5d2");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.HoverForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.SelectionBackColor = ColorTranslator.FromHtml("#ffdf6a");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.SelectionForeColor = ColorTranslator.FromHtml("#000000");
            }
            if (this.themeComboBox.SelectedItem.ToString() == "Office2010Black")
            {
                MessageBoxAdv.Office2010Theme = Office2010Theme.Black;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2010;
                MessageBoxAdv.UseDefaultTheme = isDefaultTheme ? false : isDefaultTheme;
                setOffice2010Theme();
                this.panel2.BackColor = ColorTranslator.FromHtml("#7b7b7b");
                this.tableLayoutPanel1.BackColor = ColorTranslator.FromHtml("#7b7b7b");
                this.label1.ForeColor = ColorTranslator.FromHtml("#ffffff");
                this.lbl_Description.ForeColor = ColorTranslator.FromHtml("#ffffff");
                this.Resize.ForeColor = ColorTranslator.FromHtml("#ffffff");
                this.BackColor = ColorTranslator.FromHtml("#7b7b7b");
                this.CaptionBarColor = ColorTranslator.FromHtml("#7b7b7b");
                this.CaptionForeColor = ColorTranslator.FromHtml("#ffffff");
                this.CaptionButtonColor = ColorTranslator.FromHtml("#ffffff");
                this.themeComboBox.Style.ReadOnlyEditorStyle.BackColor = ColorTranslator.FromHtml("#7b7b7b");
                this.themeComboBox.Style.ReadOnlyEditorStyle.ForeColor = ColorTranslator.FromHtml("#ffffff");
                this.themeComboBox.Style.DropDownStyle.GripperBackColor = ColorTranslator.FromHtml("#7b7b7b");
                this.themeComboBox.Style.DropDownStyle.GripperForeColor = ColorTranslator.FromHtml("#ffffff");
                this.themeComboBox.DropDownListView.Style.ItemStyle.BackColor = ColorTranslator.FromHtml("#7b7b7b");
                this.themeComboBox.DropDownListView.Style.ItemStyle.ForeColor = ColorTranslator.FromHtml("#ffffff");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.HoverBackColor = ColorTranslator.FromHtml("#fcf5d2");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.HoverForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.SelectionBackColor = ColorTranslator.FromHtml("#ffdf6a");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.SelectionForeColor = ColorTranslator.FromHtml("#000000");
            }
            if (this.themeComboBox.SelectedItem.ToString() == "Office2010Blue")
            {
                MessageBoxAdv.Office2010Theme = Office2010Theme.Blue;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2010;
                MessageBoxAdv.UseDefaultTheme = isDefaultTheme ? false : isDefaultTheme;
                setOffice2010Theme();
                this.panel2.BackColor = ColorTranslator.FromHtml("#b5d2fc");
                this.tableLayoutPanel1.BackColor = ColorTranslator.FromHtml("#b5d2fc");
                this.label1.ForeColor = ColorTranslator.FromHtml("#000000");
                this.lbl_Description.ForeColor = ColorTranslator.FromHtml("#000000");
                this.Resize.ForeColor = ColorTranslator.FromHtml("#000000");
                this.BackColor = ColorTranslator.FromHtml("#b5d2fc");
                this.CaptionBarColor = ColorTranslator.FromHtml("#b5d2fc");
                this.CaptionForeColor = ColorTranslator.FromHtml("#000000");
                this.CaptionButtonColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.Style.ReadOnlyEditorStyle.BackColor = ColorTranslator.FromHtml("#b5d2fc");
                this.themeComboBox.Style.ReadOnlyEditorStyle.ForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.Style.DropDownStyle.GripperBackColor = ColorTranslator.FromHtml("#b5d2fc");
                this.themeComboBox.Style.DropDownStyle.GripperForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.DropDownListView.Style.ItemStyle.BackColor = ColorTranslator.FromHtml("#b5d2fc");
                this.themeComboBox.DropDownListView.Style.ItemStyle.ForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.HoverBackColor = ColorTranslator.FromHtml("#fcf5d2");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.HoverForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.SelectionBackColor = ColorTranslator.FromHtml("#ffdf6a");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.SelectionForeColor = ColorTranslator.FromHtml("#000000");
            }
            if (this.themeComboBox.SelectedItem.ToString() == "Office2010Managed")
            {
                MessageBoxAdv.Office2010Theme = Office2010Theme.Managed;
                Office2010Colors.ApplyManagedColors(this, Color.Brown);
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2010;
                MessageBoxAdv.UseDefaultTheme = isDefaultTheme ? false : isDefaultTheme;
                setOffice2010Theme();
                this.panel2.BackColor = ColorTranslator.FromHtml("#dbbbc9");
                this.tableLayoutPanel1.BackColor = ColorTranslator.FromHtml("#dbbbc9");
                this.label1.ForeColor = ColorTranslator.FromHtml("#000000");
                this.lbl_Description.ForeColor = ColorTranslator.FromHtml("#000000");
                this.Resize.ForeColor = ColorTranslator.FromHtml("#000000");
                this.BackColor = ColorTranslator.FromHtml("#dbbbc9");
                this.CaptionBarColor = ColorTranslator.FromHtml("#dbbbc9");
                this.CaptionForeColor = ColorTranslator.FromHtml("#000000");
                this.CaptionButtonColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.Style.ReadOnlyEditorStyle.BackColor = ColorTranslator.FromHtml("#dbbbc9");
                this.themeComboBox.Style.ReadOnlyEditorStyle.ForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.Style.DropDownStyle.GripperBackColor = ColorTranslator.FromHtml("#dbbbc9");
                this.themeComboBox.Style.DropDownStyle.GripperForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.DropDownListView.Style.ItemStyle.BackColor = ColorTranslator.FromHtml("#dbbbc9");
                this.themeComboBox.DropDownListView.Style.ItemStyle.ForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.HoverBackColor = ColorTranslator.FromHtml("#fcf5d2");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.HoverForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.SelectionBackColor = ColorTranslator.FromHtml("#ffdf6a");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.SelectionForeColor = ColorTranslator.FromHtml("#000000");
            }
            if (this.themeComboBox.SelectedItem.ToString() == "Office2010Silver")
            {
                MessageBoxAdv.Office2010Theme = Office2010Theme.Silver;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2010;
                MessageBoxAdv.UseDefaultTheme = isDefaultTheme ? false : isDefaultTheme;
                setOffice2010Theme();
                this.panel2.BackColor = ColorTranslator.FromHtml("#d1d5de");
                this.tableLayoutPanel1.BackColor = ColorTranslator.FromHtml("#d1d5de");
                this.label1.ForeColor = ColorTranslator.FromHtml("#000000");
                this.lbl_Description.ForeColor = ColorTranslator.FromHtml("#000000");
                this.Resize.ForeColor = ColorTranslator.FromHtml("#000000");
                this.BackColor = ColorTranslator.FromHtml("#d1d5de");
                this.CaptionBarColor = ColorTranslator.FromHtml("#d1d5de");
                this.CaptionForeColor = ColorTranslator.FromHtml("#000000");
                this.CaptionButtonColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.Style.ReadOnlyEditorStyle.BackColor = ColorTranslator.FromHtml("#d1d5de");
                this.themeComboBox.Style.ReadOnlyEditorStyle.ForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.Style.DropDownStyle.GripperBackColor = ColorTranslator.FromHtml("#d1d5de");
                this.themeComboBox.Style.DropDownStyle.GripperForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.DropDownListView.Style.ItemStyle.BackColor = ColorTranslator.FromHtml("#d1d5de");
                this.themeComboBox.DropDownListView.Style.ItemStyle.ForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.HoverBackColor = ColorTranslator.FromHtml("#fcf5d2");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.HoverForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.SelectionBackColor = ColorTranslator.FromHtml("#ffdf6a");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.SelectionForeColor = ColorTranslator.FromHtml("#000000");
            }
            if (this.themeComboBox.SelectedItem.ToString() == "Metro")
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.UseDefaultTheme = isDefaultTheme ? false : isDefaultTheme;
                setMetroTheme();
                this.panel2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.tableLayoutPanel1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.label1.ForeColor = ColorTranslator.FromHtml("#000000");
                this.lbl_Description.ForeColor = ColorTranslator.FromHtml("#000000");
                this.Resize.ForeColor = ColorTranslator.FromHtml("#000000");
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.CaptionBarColor = ColorTranslator.FromHtml("#ffffff");
                this.CaptionForeColor = ColorTranslator.FromHtml("#000000");
                this.CaptionButtonColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.Style.ReadOnlyEditorStyle.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.themeComboBox.Style.ReadOnlyEditorStyle.ForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.Style.DropDownStyle.GripperBackColor = ColorTranslator.FromHtml("#ffffff");
                this.themeComboBox.Style.DropDownStyle.GripperForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.DropDownListView.Style.ItemStyle.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.themeComboBox.DropDownListView.Style.ItemStyle.ForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.HoverBackColor = ColorTranslator.FromHtml("#f2f2f2");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.HoverForeColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.SelectionBackColor = ColorTranslator.FromHtml("#a6d8ff");
                this.themeComboBox.DropDownListView.Style.SelectionStyle.SelectionForeColor = ColorTranslator.FromHtml("#000000");
            }
            if (this.themeComboBox.SelectedItem.ToString() == "Office2016Colorful")
            {
                MessageBoxAdv.Office2016Theme = Office2016Theme.Colorful;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2016;
                MessageBoxAdv.UseDefaultTheme = isDefaultTheme ? false : isDefaultTheme;
                setOffice2016Theme();
                this.panel2.BackColor = ColorTranslator.FromHtml("#fdfdfd");
                this.tableLayoutPanel1.BackColor = ColorTranslator.FromHtml("#fdfdfd");
                this.label1.ForeColor = ColorTranslator.FromHtml("#000000");
                this.lbl_Description.ForeColor = ColorTranslator.FromHtml("#000000");
                this.Resize.ForeColor = ColorTranslator.FromHtml("#000000");
                this.BackColor = ColorTranslator.FromHtml("#fdfdfd");
                this.CaptionBarColor = ColorTranslator.FromHtml("#fdfdfd");
                this.CaptionForeColor = ColorTranslator.FromHtml("#000000");
                this.CaptionButtonColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.CanOverrideStyle = true;
                this.themeComboBox.ThemeName = "Office2016Colorful";
            }
            if (this.themeComboBox.SelectedItem.ToString() == "Office2016DarkGray")
            {
                MessageBoxAdv.Office2016Theme = Office2016Theme.DarkGray;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2016;
                MessageBoxAdv.UseDefaultTheme = isDefaultTheme ? false : isDefaultTheme;
                setOffice2016Theme();
                this.panel2.BackColor = ColorTranslator.FromHtml("#d4d4d4");
                this.tableLayoutPanel1.BackColor = ColorTranslator.FromHtml("#d4d4d4");
                this.label1.ForeColor = ColorTranslator.FromHtml("#000000");
                this.lbl_Description.ForeColor = ColorTranslator.FromHtml("#000000");
                this.Resize.ForeColor = ColorTranslator.FromHtml("#000000");
                this.BackColor = ColorTranslator.FromHtml("#d4d4d4");
                this.CaptionBarColor = ColorTranslator.FromHtml("#d4d4d4");
                this.CaptionForeColor = ColorTranslator.FromHtml("#000000");
                this.CaptionButtonColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.CanOverrideStyle = true;
                this.themeComboBox.ThemeName = "Office2016DarkGray";
            }
            if (this.themeComboBox.SelectedItem.ToString() == "Office2016White")
            {
                MessageBoxAdv.Office2016Theme = Office2016Theme.White;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2016;
                MessageBoxAdv.UseDefaultTheme = isDefaultTheme ? false : isDefaultTheme;
                setOffice2016Theme();
                this.panel2.BackColor = ColorTranslator.FromHtml("#fdfdfd");
                this.tableLayoutPanel1.BackColor = ColorTranslator.FromHtml("#fdfdfd");
                this.label1.ForeColor = ColorTranslator.FromHtml("#000000");
                this.lbl_Description.ForeColor = ColorTranslator.FromHtml("#000000");
                this.Resize.ForeColor = ColorTranslator.FromHtml("#000000");
                this.BackColor = ColorTranslator.FromHtml("#fdfdfd");
                this.CaptionBarColor = ColorTranslator.FromHtml("#fdfdfd");
                this.CaptionForeColor = ColorTranslator.FromHtml("#000000");
                this.CaptionButtonColor = ColorTranslator.FromHtml("#000000");
                this.themeComboBox.CanOverrideStyle = true;
                this.themeComboBox.ThemeName = "Office2016White";
            }
        }

        private void SetDefaultTheme()
        {
            this.btn_custom.Appearance = ButtonAppearance.Classic;
            this.btn_confirmation.Appearance = ButtonAppearance.Classic;
            this.btn_errormsg.Appearance = ButtonAppearance.Classic;
            this.btn_infomsg.Appearance = ButtonAppearance.Classic;
            this.btn_warning.Appearance = ButtonAppearance.Classic;
        }

        private void setOffice2007Theme()
        {
            if (themeComboBox.SelectedItem.ToString() == "Office2007Black")
            {
                this.btn_custom.Appearance = ButtonAppearance.Office2007;
                this.btn_custom.Office2007ColorScheme = Office2007Theme.Black;
                this.btn_confirmation.Appearance = ButtonAppearance.Office2007;
                this.btn_confirmation.Office2007ColorScheme = Office2007Theme.Black;
                this.btn_errormsg.Appearance = ButtonAppearance.Office2007;
                this.btn_errormsg.Office2007ColorScheme = Office2007Theme.Black;
                this.btn_infomsg.Appearance = ButtonAppearance.Office2007;
                this.btn_infomsg.Office2007ColorScheme = Office2007Theme.Black;
                this.btn_warning.Appearance = ButtonAppearance.Office2007;
                this.btn_warning.Office2007ColorScheme = Office2007Theme.Black;
            }
            else if (themeComboBox.SelectedItem.ToString() == "Office2007Blue")
            {
                this.btn_custom.Appearance = ButtonAppearance.Office2007;
                this.btn_custom.Office2007ColorScheme = Office2007Theme.Blue;
                this.btn_confirmation.Appearance = ButtonAppearance.Office2007;
                this.btn_confirmation.Office2007ColorScheme = Office2007Theme.Blue;
                this.btn_errormsg.Appearance = ButtonAppearance.Office2007;
                this.btn_errormsg.Office2007ColorScheme = Office2007Theme.Blue;
                this.btn_infomsg.Appearance = ButtonAppearance.Office2007;
                this.btn_infomsg.Office2007ColorScheme = Office2007Theme.Blue;
                this.btn_warning.Appearance = ButtonAppearance.Office2007;
                this.btn_warning.Office2007ColorScheme = Office2007Theme.Blue;
            }
            else if (themeComboBox.SelectedItem.ToString() == "Office2007Silver")
            {
                this.btn_custom.Appearance = ButtonAppearance.Office2007;
                this.btn_custom.Office2007ColorScheme = Office2007Theme.Silver;
                this.btn_confirmation.Appearance = ButtonAppearance.Office2007;
                this.btn_confirmation.Office2007ColorScheme = Office2007Theme.Silver;
                this.btn_errormsg.Appearance = ButtonAppearance.Office2007;
                this.btn_errormsg.Office2007ColorScheme = Office2007Theme.Silver;
                this.btn_infomsg.Appearance = ButtonAppearance.Office2007;
                this.btn_infomsg.Office2007ColorScheme = Office2007Theme.Silver;
                this.btn_warning.Appearance = ButtonAppearance.Office2007;
                this.btn_warning.Office2007ColorScheme = Office2007Theme.Silver;
            }
            else
            {
                this.btn_custom.Appearance = ButtonAppearance.Office2007;
                this.btn_custom.Office2007ColorScheme = Office2007Theme.Managed;
                this.btn_confirmation.Appearance = ButtonAppearance.Office2007;
                this.btn_confirmation.Office2007ColorScheme = Office2007Theme.Managed;
                this.btn_errormsg.Appearance = ButtonAppearance.Office2007;
                this.btn_errormsg.Office2007ColorScheme = Office2007Theme.Managed;
                this.btn_infomsg.Appearance = ButtonAppearance.Office2007;
                this.btn_infomsg.Office2007ColorScheme = Office2007Theme.Managed;
                this.btn_warning.Appearance = ButtonAppearance.Office2007;
                this.btn_warning.Office2007ColorScheme = Office2007Theme.Managed;
            }
        }
        private void setOffice2010Theme()
        {
            if (themeComboBox.SelectedItem.ToString() == "Office2010Black")
            {
                this.btn_custom.Appearance = ButtonAppearance.Office2010;
                this.btn_custom.Office2010ColorScheme = Office2010Theme.Black;
                this.btn_confirmation.Appearance = ButtonAppearance.Office2010;
                this.btn_confirmation.Office2010ColorScheme = Office2010Theme.Black;
                this.btn_errormsg.Appearance = ButtonAppearance.Office2010;
                this.btn_errormsg.Office2010ColorScheme = Office2010Theme.Black;
                this.btn_infomsg.Appearance = ButtonAppearance.Office2010;
                this.btn_infomsg.Office2010ColorScheme = Office2010Theme.Black;
                this.btn_warning.Appearance = ButtonAppearance.Office2010;
                this.btn_warning.Office2010ColorScheme = Office2010Theme.Black;
            }
            else if (themeComboBox.SelectedItem.ToString() == "Office2010Blue")
            {
                this.btn_custom.Appearance = ButtonAppearance.Office2010;
                this.btn_custom.Office2010ColorScheme = Office2010Theme.Blue;
                this.btn_confirmation.Appearance = ButtonAppearance.Office2010;
                this.btn_confirmation.Office2010ColorScheme = Office2010Theme.Blue;
                this.btn_errormsg.Appearance = ButtonAppearance.Office2010;
                this.btn_errormsg.Office2010ColorScheme = Office2010Theme.Blue;
                this.btn_infomsg.Appearance = ButtonAppearance.Office2010;
                this.btn_infomsg.Office2010ColorScheme = Office2010Theme.Blue;
                this.btn_warning.Appearance = ButtonAppearance.Office2010;
                this.btn_warning.Office2010ColorScheme = Office2010Theme.Blue;
            }
            else if (themeComboBox.SelectedItem.ToString() == "Office2010Silver")
            {
                this.btn_custom.Appearance = ButtonAppearance.Office2010;
                this.btn_custom.Office2010ColorScheme = Office2010Theme.Silver;
                this.btn_confirmation.Appearance = ButtonAppearance.Office2010;
                this.btn_confirmation.Office2010ColorScheme = Office2010Theme.Silver;
                this.btn_errormsg.Appearance = ButtonAppearance.Office2010;
                this.btn_errormsg.Office2010ColorScheme = Office2010Theme.Silver;
                this.btn_infomsg.Appearance = ButtonAppearance.Office2010;
                this.btn_infomsg.Office2010ColorScheme = Office2010Theme.Silver;
                this.btn_warning.Appearance = ButtonAppearance.Office2010;
                this.btn_warning.Office2010ColorScheme = Office2010Theme.Silver;
            }
            else
            {
                this.btn_custom.Appearance = ButtonAppearance.Office2010;
                this.btn_custom.Office2010ColorScheme = Office2010Theme.Managed;
                this.btn_confirmation.Appearance = ButtonAppearance.Office2010;
                this.btn_confirmation.Office2010ColorScheme = Office2010Theme.Managed;
                this.btn_errormsg.Appearance = ButtonAppearance.Office2010;
                this.btn_errormsg.Office2010ColorScheme = Office2010Theme.Managed;
                this.btn_infomsg.Appearance = ButtonAppearance.Office2010;
                this.btn_infomsg.Office2010ColorScheme = Office2010Theme.Managed;
                this.btn_warning.Appearance = ButtonAppearance.Office2010;
                this.btn_warning.Office2010ColorScheme = Office2010Theme.Managed;
            }
        }
        private void setOffice2016Theme()
        {
            if (themeComboBox.SelectedItem.ToString() == "Office2016Black")
            {
                this.btn_custom.Appearance = ButtonAppearance.Office2016Black;                
                this.btn_confirmation.Appearance = ButtonAppearance.Office2016Black;                
                this.btn_errormsg.Appearance = ButtonAppearance.Office2016Black;                
                this.btn_infomsg.Appearance = ButtonAppearance.Office2016Black;
                this.btn_warning.Appearance = ButtonAppearance.Office2016Black;
            }
            else if (themeComboBox.SelectedItem.ToString() == "Office2016Colorful")
            {
                this.btn_custom.Appearance = ButtonAppearance.Office2016Colorful;
                this.btn_confirmation.Appearance = ButtonAppearance.Office2016Colorful;
                this.btn_errormsg.Appearance = ButtonAppearance.Office2016Colorful;
                this.btn_infomsg.Appearance = ButtonAppearance.Office2016Colorful;
                this.btn_warning.Appearance = ButtonAppearance.Office2016Colorful;
            }
            else if (themeComboBox.SelectedItem.ToString() == "Office2016DarkGray")
            {
                this.btn_custom.Appearance = ButtonAppearance.Office2016DarkGray;
                this.btn_confirmation.Appearance = ButtonAppearance.Office2016DarkGray;
                this.btn_errormsg.Appearance = ButtonAppearance.Office2016DarkGray;
                this.btn_infomsg.Appearance = ButtonAppearance.Office2016DarkGray;
                this.btn_warning.Appearance = ButtonAppearance.Office2016DarkGray;
            }
            else
            {
                this.btn_custom.Appearance = ButtonAppearance.Office2016White;
                this.btn_confirmation.Appearance = ButtonAppearance.Office2016White;
                this.btn_errormsg.Appearance = ButtonAppearance.Office2016White;
                this.btn_infomsg.Appearance = ButtonAppearance.Office2016White;
                this.btn_warning.Appearance = ButtonAppearance.Office2016White;
            }
        }
        private void setMetroTheme()
        {
            this.btn_confirmation.Appearance = ButtonAppearance.Metro;
            this.btn_custom.Appearance = ButtonAppearance.Metro;
            this.btn_errormsg.Appearance = ButtonAppearance.Metro;
            this.btn_infomsg.Appearance = ButtonAppearance.Metro;
            this.btn_warning.Appearance = ButtonAppearance.Metro;
        }
        
        /// <summary>
        /// Show Error Message
        /// </summary>
        private void btn_errormsg_Click(object sender, EventArgs e)
        {
            if (this.Resize.CheckState == CheckState.Checked)
            {
                MessageBoxAdv.CanResize = true;
            }
            else
            {
                MessageBoxAdv.CanResize = false;
            }
            string errorMessage = "Windows cannot install required files. The file may be corrupt or missing. Make sure all files " +
                "required for installation are available, and restart the installation.Error code:0x80070570";
            string details = "The file may be corrupt or missing. Make sure all files " +
                "required for installation are available, and restart the installation.Error code:0x80070570";
            MessageBoxAdv.Show(errorMessage, "Install Windows", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning,
              details);
        }

        /// <summary>
        /// Show Notification Message
        /// </summary>
        private void btn_infomsg_Click(object sender, EventArgs e)
        {
            if (this.Resize.CheckState == CheckState.Checked)
            {
                MessageBoxAdv.CanResize = true;
            }
            else
            {
                MessageBoxAdv.CanResize = false;
            }
            string errorMessage = "Windows installed new updates. Your computer was restarted to finish installing updates.";
            MessageBoxAdv.Show(errorMessage, "Windows Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information); 
        }

        /// <summary>
        /// Show Warning Message
        /// </summary>
        private void btn_question_Click(object sender, EventArgs e)
        {
            if (this.Resize.CheckState == CheckState.Checked)
            {
                MessageBoxAdv.CanResize = true;
            }
            else
            {
                MessageBoxAdv.CanResize = false;
            }
            string errorMessage = "There is a problem with this Windows Installer package.\nA program required for this install to complete could not be run.\nContact your support personnel or package vendor.";
            MessageBoxAdv.Show(errorMessage, "Windows Installation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Show Confirmation Message
        /// </summary>
        private void btn_warning_Click(object sender, EventArgs e)
        {
            if (this.Resize.CheckState == CheckState.Checked)
            {
                MessageBoxAdv.CanResize = true;
            }
            else
            {
                MessageBoxAdv.CanResize = false;
            }
            string errorDetails = "Formatting this volume will erase all data on it.\n\nDo you want to continue?";
            MessageBoxAdv.Show(errorDetails, "Delete Disk", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
        }

        /// <summary>
        /// Show message with custom buttons
        /// </summary>
        private void btn_custom_Click(object sender, EventArgs e)
        {
            if (this.Resize.CheckState == CheckState.Checked)
            {
                MessageBoxAdv.CanResize = true;
            }
            else
            {
                MessageBoxAdv.CanResize = false;
            }
            Image image = (Image) global::GettingStarted.Properties.Resources.print;
            Size imageSize = new System.Drawing.Size(image.Width,image.Height);
            string errorMessage = "Do you want to print this page?";
            string details = "To print this page, click Yes otherwise click No to exit.";
            string[] customButtons = new string[] { "Yes", "No", "Help" };
            MessageBoxAdv.Show(this, errorMessage, "Print", customButtons, image, imageSize);
        }
    }
}
