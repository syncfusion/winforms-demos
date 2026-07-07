#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.ListView.Enums;

namespace HeaderFooter
{
    public partial class Form1 : SfForm
    {
        /// <summary>
        /// Initialize the custom textbox to add at header area.
        /// </summary>
        CustomHeaderUserControl customTextBox;

        #region constructor
        public Form1()
        {
            InitializeComponent();
            this.sfListView1.DataSource = GetData();
            this.sfListView1.DisplayMember = "LongName";
            this.sfListViewSettings();

            try
            {
                Bitmap bmp = new Bitmap(Image.FromFile(@"../../Icon/sficon.ico"));
                this.Icon = Icon.FromHandle(bmp.GetHicon());
            }
            catch (Exception ex)
            { }
        }
        #endregion

        #region sfListViewSeetings

        private void sfListViewSettings()
        {
            this.sfListView1.AllowRecursiveChecking = true;
            this.sfListView1.ShowCheckBoxes = true;
            this.sfListView1.HotTracking = true;

            #region Header and footer customization
            this.sfListView1.ShowHeader = true;
            this.ShowFooterCheckBox.Enabled = false;
            this.sfListView1.HeaderHeight = 24;
            this.sfListView1.FooterHeight = 24;
            this.sfListView1.CheckBoxSelectionMode = CheckBoxSelectionMode.CheckOnItemClick;
            customTextBox = new CustomHeaderUserControl(this.sfListView1);
            customTextBox.TextBox.Font = this.sfListView1.Style.ItemStyle.Font;
            customTextBox.Width = this.sfListView1.Size.Width - 14;
            this.sfListView1.DrawItem += OnSfListViewDrawItem;
            #endregion
        }

        /// <summary>
        /// Occurs when draws the items in SfListView.
        /// </summary>
        private void OnSfListViewDrawItem(object sender, Syncfusion.WinForms.ListView.Events.DrawItemEventArgs e)
        {
            if (e.ItemType == Syncfusion.WinForms.ListView.Enums.ItemType.Header)
            {
                e.Text = "List of US States";
            }

            if (e.ItemType == Syncfusion.WinForms.ListView.Enums.ItemType.Footer)
            {
                e.Text = "Filtered Items Count : " + this.sfListView1.View.Items.Count;
            }
        }

        /// <summary>
        /// Get the data for the <see cref="SfListView"/> control.
        /// </summary>
        /// <returns>Returns the data.</returns>
        private List<USState> GetData()
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

        /// <summary>
        /// Occurs when ShowHeader checkbox changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">A event arguments.</param>
        private void OnShowHeaderCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            this.sfListView1.ShowHeader = ShowHeaderCheckBox.Checked;
        }

        /// <summary>
        /// Occurs when ShowFooter checkbox changed.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">A event arguments.</param>
        private void OnShowFooterCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            this.sfListView1.ShowFooter = ShowFooterCheckBox.Checked;
        }

        /// <summary>
        /// Occurs when ShowControlCheckBox changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">A event arguments.</param>
        private void OnShowControlCheckBoxChanged(object sender, EventArgs e)
        {
            if (this.ShowControlCheckBox.Checked && this.sfListView1.ShowHeader)
                this.sfListView1.HeaderControl = customTextBox;
            else
                this.sfListView1.HeaderControl = null;

            this.ShowFooterCheckBox.Enabled = this.ShowControlCheckBox.Checked;
            this.ShowFooterCheckBox.Checked = this.ShowControlCheckBox.Checked;
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
}
