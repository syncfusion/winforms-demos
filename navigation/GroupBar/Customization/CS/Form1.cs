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
            //Initial settings
            cmbPopupResize.SelectedIndex = 0;
            this.groupBar1.CollapsedWidth = 45;
            this.groupBar1.ThemeName = "Office2019Colorful";
            this.cbChevron.ThemeName = this.cbAllowCollapse.ThemeName = this.cbCollapse.ThemeName = this.cbShowGripper.ThemeName = this.cbAutoClose.ThemeName = "Office2019Colorful";
            this.cmbPopupResize.ThemeName= "Office2019Colorful";
            this.numericCollapsedWidth.ThemeStyle.Font = new Font("Microsoft Sans Serif", 8.25F);
            this.numericCollapsedWidth.ThemeName = "Office2019Colorful";
            this.monthCalendar1.ThemeName= "Office2019Colorful";
            this.treeViewAdv1.ThemeName= this.treeViewAdv2.ThemeName = this.treeViewAdv3.ThemeName = this.treeViewAdv4.ThemeName = this.treeViewAdv5.ThemeName = "Office2019Colorful";
#if NETCORE
            this.Mail.Image = this.Mail.NavigationPaneImage = Image.FromFile("..//..//..//Resources//Mail.png");
            this.Calendar.Image = this.Calendar.NavigationPaneImage = Image.FromFile("..//..//..//Resources//Calendar.png");
            this.Folders.Image = this.Folders.NavigationPaneImage = Image.FromFile("..//..//..//Resources//Folders.png");
            this.Tasks.Image = this.Tasks.NavigationPaneImage = Image.FromFile("..//..//..//Resources//Tasks.png");
            this.Favorites.Image = this.Favorites.NavigationPaneImage = Image.FromFile("..//..//..//Resources//favorites.png");
            this.Notes.Image = this.Notes.NavigationPaneImage = Image.FromFile("..//..//..//Resources//Notes.png");
#else
            this.Mail.Image = this.Mail.NavigationPaneImage = Image.FromFile("..//..//Resources//Mail.png");
            this.Calendar.Image = this.Calendar.NavigationPaneImage = Image.FromFile("..//..//Resources//Calendar.png");
            this.Folders.Image = this.Folders.NavigationPaneImage = Image.FromFile("..//..//Resources//Folders.png");
            this.Tasks.Image = this.Tasks.NavigationPaneImage = Image.FromFile("..//..//Resources//Tasks.png");
            this.Favorites.Image = this.Favorites.NavigationPaneImage = Image.FromFile("..//..//Resources//favorites.png");
            this.Notes.Image = this.Notes.NavigationPaneImage = Image.FromFile("..//..//Resources//Notes.png");
#endif
            this.cbCollapse.Enabled= this.label18.Enabled = this.numericCollapsedWidth.Enabled = this.groupBar1.AllowCollapse;
            this.label18.Enabled = this.numericCollapsedWidth.Enabled = this.groupBar1.Collapsed;
            this.label15.Enabled = this.cmbPopupResize.Enabled = this.groupBar1.ShowPopupGripper; 
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.gradientPanel2.Size = new Size((int)DpiAware.LogicalToDeviceUnits(286), 531);
                this.cmbPopupResize.Location = new Point((this.label15.Width + this.label15.Location.X + 4), label15.Location.Y);
                this.cmbPopupResize.Height = this.label15.Height;
                this.numericCollapsedWidth.Location = new Point((this.label15.Width + this.label15.Location.X + 4), label18.Location.Y);
                this.Size = new Size(((1 + ((((int)DpiAware.GetCurrentDpi() / 96) - 1) / 2)) * this.Size.Width) + 200, 590);
                this.treeViewAdv1.ItemHeight = (int)DpiAware.LogicalToDeviceUnits(this.treeViewAdv1.ItemHeight);
                this.treeViewAdv2.ItemHeight = (int)DpiAware.LogicalToDeviceUnits(this.treeViewAdv2.ItemHeight);
                this.treeViewAdv3.ItemHeight = (int)DpiAware.LogicalToDeviceUnits(this.treeViewAdv3.ItemHeight);
                this.treeViewAdv4.ItemHeight = (int)DpiAware.LogicalToDeviceUnits(this.treeViewAdv4.ItemHeight);
            }
        }

        private void populateComboBoxItems()
        {
            List<string> cmbPopupResizeItem = new List<string>();
            cmbPopupResizeItem.AddRange(new string[] {
            "Both",
            "Horizontal",
            "None",
            "Vertical"});
            this.cmbPopupResize.DataSource = cmbPopupResizeItem;
            cmbPopupResize.AllowDropDownResize = false;
        }
       
#endregion

#region Outlook  GroupBar

        //ShowChevron
        private void ChevronCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBar1.ShowChevron = cbChevron.Checked;
        }
        
        //Allow collapse
        private void cbAllowCollapse_CheckedChanged(object sender, System.EventArgs e)
        {
            this.groupBar1.AllowCollapse = cbAllowCollapse.Checked;
            this.cbCollapse.Enabled= this.label18.Enabled = this.numericCollapsedWidth.Enabled = this.groupBar1.AllowCollapse;
        }

        //Collapse GroupBar
        private void cbCollapse_CheckedChanged(object sender, System.EventArgs e)
        {
            this.groupBar1.Collapsed = cbCollapse.Checked;
            this.label18.Enabled = this.numericCollapsedWidth.Enabled = this.groupBar1.Collapsed;
        }

        //Show Gripper
        private void cbShowGripper_CheckedChanged(object sender, System.EventArgs e)
        {
            this.groupBar1.ShowPopupGripper = cbShowGripper.Checked;
            this.label15.Enabled = this.cmbPopupResize.Enabled = this.groupBar1.ShowPopupGripper;
        }

        //PopupAuto close 
        private void cbAutoClose_CheckedChanged(object sender, System.EventArgs e)
        {
            this.groupBar1.PopupAutoClose = this.cbAutoClose.Checked;
        }

        //Collapsed width
        private void CollapsedWidthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.groupBar1.CollapsedWidth = (int)this.numericCollapsedWidth.Value;
        }

        //PopupResize mode
        private void PopupResizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.groupBar1.PopupResizeMode = (PopupResizeMode)Enum.Parse(typeof(PopupResizeMode), this.cmbPopupResize.SelectedItem.ToString());
        }


#endregion

        private void groupBar1_StateChanged(object sender, EventArgs e)
        {
            this.cbCollapse.Checked = this.groupBar1.Collapsed;
            this.label18.Enabled = this.numericCollapsedWidth.Enabled = this.groupBar1.Collapsed;
        }
    }
}