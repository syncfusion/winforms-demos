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
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System.Drawing.Drawing2D;
using Syncfusion.Runtime.Serialization;
using System.Collections;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using Syncfusion.WinForms.Controls;

namespace GroupBarDemo_2005
{
    public partial class Form1 : SfForm
    {
        #region Form's Constructor
        public Form1()
        {
            InitializeComponent();
            populateComboBoxItems();
            this.gbVisualStudio.CollapsedText = "Toolbox";
            this.numericUpDown1.Value = this.gbVisualStudio.GroupBarItemHeight;
            this.gbVisualStudio.SelectedItem = 0;
            this.gbVisualStudio.ThemeName = "Office2019Colorful";
            this.WinFormsGroupView.ThemeName = this.ComponentsGroupView.ThemeName = this.GeneralGroupView.ThemeName = "Office2019Colorful";
            this.WinFormsGroupView.ThemeStyle.BorderThickness = 0;
            this.ComponentsGroupView.ThemeStyle.BorderThickness = 0;
            this.GeneralGroupView.ThemeStyle.BorderThickness = 0;
            this.checkBoxAdv1.ThemeName = this.checkBoxAdv3.ThemeName = this.checkBoxAdv7.ThemeName = this.checkBoxAdv9.ThemeName = "Office2019Colorful";
            this.numericUpDown1.ThemeStyle.Font = new Font("Microsoft Sans Serif", 8.25F);
            this.numericUpDown1.ThemeName= "Office2019Colorful";
            this.cmbGBBorder.ThemeName= this.cmbGBVisualStyle.ThemeName = this.cmbTextAlignment.ThemeName = "Office2019Colorful";
            this.checkBoxAdv7.Checked = this.gbVisualStudio.ShowChevron;
            this.checkBoxAdv1.Checked = this.gbVisualStudio.IntegratedScrolling;
            this.checkBoxAdv3.Checked = this.gbVisualStudio.Collapsed;
            this.checkBoxAdv9.Checked = this.gbVisualStudio.StackedMode;

        }

        #endregion

        #region ComboBox setting

        private void populateComboBoxItems()
        {
            List<string> cmbTextAlignmenitem = new List<string>();
            List<string> cmbGBBorderitem = new List<string>();
            List<string> cmbGBVisualStyleitem = new List<string>();
            cmbTextAlignmenitem.AddRange(new string[] {
            "Left",
            "Center",
            "Right"});
            this.cmbTextAlignment.DataSource = cmbTextAlignmenitem;
            this.cmbTextAlignment.AllowDropDownResize = false;

            cmbGBBorderitem.AddRange(new string[] {
            "None",
            "FixedSingle",
            "Fixed3D"});

            this.cmbGBBorder.DataSource = cmbGBBorderitem;
            this.cmbGBBorder.AllowDropDownResize = false;

            cmbGBVisualStyleitem.AddRange(new string[] {
            "Office2019Colorful",
            "HighContrastBlack",
            "Office2016Colorful",
            "Office2016White",
            "Office2016DarkGray",
            "Office2016Black"});

            this.cmbGBVisualStyle.DataSource = cmbGBVisualStyleitem;
            this.cmbGBVisualStyle.AllowDropDownResize = false;
        }


        //GroupBar BorderStyle
        private void GBBorderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.gbVisualStudio.BorderStyle = (BorderStyle)Enum.Parse(typeof(BorderStyle), this.cmbGBBorder.SelectedItem.ToString(), true);
        }

        //GroupBar Visual style
        #region Visual style

        private void GBVisualStyleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SuspendLayout();
            SkinManager.SetVisualStyle(this.splitContainerAdv1.Panel1, this.cmbGBVisualStyle.SelectedItem.ToString());
            SkinManager.SetVisualStyle(this.splitContainerAdv1.Panel2, this.cmbGBVisualStyle.SelectedItem.ToString());
            if (this.cmbGBVisualStyle.SelectedItem.ToString() == "Office2016Colorful")
            {
                this.BackColor = this.splitContainerAdv1.BackColor =this.gradientPanel1.BackColor= Color.White;
                this.Style.TitleBar.BackColor = Color.FromArgb(242, 242, 242);
                this.Style.TitleBar.CloseButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.MinimizeButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.MaximizeButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.ForeColor = Color.Black;
                this.label1.ForeColor = this.label2.ForeColor = this.label3.ForeColor = this.label4.ForeColor = Color.Black;
            }
            else if (this.cmbGBVisualStyle.SelectedItem.ToString() == "Office2016Black")
            {
                this.splitContainerAdv1.BackColor = Color.FromArgb(37, 37, 37);
                this.BackColor = this.gradientPanel1.BackColor = Color.FromArgb(37, 37, 37);
                this.Style.TitleBar.BackColor = ColorTranslator.FromHtml("#363636");
                this.Style.TitleBar.CloseButtonForeColor = Color.White;
                this.Style.TitleBar.MinimizeButtonForeColor = Color.White;
                this.Style.TitleBar.MaximizeButtonForeColor = Color.White;
                this.Style.TitleBar.ForeColor = Color.White;
                this.label1.ForeColor = this.label2.ForeColor = this.label3.ForeColor = this.label4.ForeColor = Color.White;
            }
            else if (this.cmbGBVisualStyle.SelectedItem.ToString() == "Office2016DarkGray")
            {
                this.BackColor = this.gradientPanel1.BackColor = this.splitContainerAdv1.BackColor = Color.FromArgb(102, 102, 102);
                this.label1.ForeColor = this.label2.ForeColor = this.label3.ForeColor = this.label4.ForeColor = Color.White;
                this.Style.TitleBar.BackColor = ColorTranslator.FromHtml("#505050");
                this.Style.TitleBar.CloseButtonForeColor = Color.White;
                this.Style.TitleBar.MinimizeButtonForeColor = Color.White;
                this.Style.TitleBar.MaximizeButtonForeColor = Color.White;
                this.Style.TitleBar.ForeColor = Color.White;
            }
            else if (this.cmbGBVisualStyle.SelectedItem.ToString() == "Office2016White")
            {
                this.BackColor = this.gradientPanel1.BackColor = this.splitContainerAdv1.BackColor = Color.White;
                this.label1.ForeColor = this.label2.ForeColor = this.label3.ForeColor = this.label4.ForeColor = Color.Black;
                this.Style.TitleBar.BackColor = Color.FromArgb(242, 242, 242);
                this.Style.TitleBar.CloseButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.MinimizeButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.MaximizeButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.ForeColor = Color.Black;
            }
            else if (this.cmbGBVisualStyle.SelectedItem.ToString() == "Office2019Colorful")
            {
                this.label1.ForeColor = this.label2.ForeColor = this.label3.ForeColor = this.label4.ForeColor = Color.Black;
                this.BackColor = this.gradientPanel1.ThemeStyle.BackColor = this.splitContainerAdv1.BackColor = Color.White;
                this.Style.TitleBar.BackColor = Color.FromArgb(242, 242, 242);
                this.Style.TitleBar.CloseButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.MinimizeButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.MaximizeButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.ForeColor = Color.Black;
            }
            else if (this.cmbGBVisualStyle.SelectedItem.ToString() == "HighContrastBlack")
            {
                this.BackColor = this.gradientPanel1.ThemeStyle.BackColor = Color.Black;
                this.Style.TitleBar.BackColor = Color.FromArgb(37, 37, 37);
                this.Style.TitleBar.CloseButtonForeColor = Color.White;
                this.Style.TitleBar.MinimizeButtonForeColor = Color.White;
                this.Style.TitleBar.MaximizeButtonForeColor = Color.White;
                this.Style.TitleBar.ForeColor = Color.White;
                this.label1.ForeColor = this.label2.ForeColor = this.label3.ForeColor = this.label4.ForeColor = Color.White;
            }
            this.numericUpDown1.Value = this.gbVisualStudio.GroupBarItemHeight;
            this.ResumeLayout();
        }
        #endregion

        //Text Alignment
        private void GBTextAlignmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.gbVisualStudio.TextAlign = (Syncfusion.Windows.Forms.Tools.TextAlignment)Enum.Parse(typeof(Syncfusion.Windows.Forms.Tools.TextAlignment), this.cmbTextAlignment.SelectedItem.ToString(), true);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.gbVisualStudio.GroupBarItemHeight = (int)this.numericUpDown1.Value; 
        }

        #endregion

        #region Checkbox setting

        //ShowChevron
        private void ChevronCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.gbVisualStudio.ShowChevron = checkBoxAdv7.Checked;
        }
        
        //Enable Stacked Mode
        private void StackedModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.gbVisualStudio.StackedMode = this.checkBoxAdv9.Checked;
            this.checkBoxAdv7.Enabled = this.checkBoxAdv3.Enabled = checkBoxAdv9.Checked;
        }

        private void IntegratedScrollingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.gbVisualStudio.IntegratedScrolling = this.checkBoxAdv1.Checked;
        }

        private void cbAllowCollapse_CheckStateChanged(object sender, EventArgs e)
        {
            this.gbVisualStudio.Collapsed = this.checkBoxAdv3.Checked;
        }

        #endregion

    }
}