#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp48
{
    public partial class Form1 : SfForm
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
#if NETCORE
                this.Icon = new System.Drawing.Icon(@"..\\..\\..\\\logo.ico");
                List<string> languageList = new List<string>();
                languageList.Add("Belgium");
                languageList.Add("Brazil");
                languageList.Add("Canada");
                languageList.Add("China");
                languageList.Add("Denmark");
                languageList.Add("Egypt");
                languageList.Add("France");
                languageList.Add("Japan");
                languageList.Add("India");
                languageList.Add("United States");
                languageList.Add("Russia");
                languageList.Add("Italy");
                languageList.Add("Spain");
                sfListView1.DataSource = languageList;
#else
                this.Icon = new System.Drawing.Icon(@"..\\..\\\logo.ico");
                 System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
                 this.sfListView1.DataSource = ((object)(resources.GetObject("sfListView1.DataSource")));
#endif

            }
            catch { }
        }
        private string itemChecked = "";
        #region Button_Click Events
        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            itemChecked = "";
            this.gradientPanel1.Visible = false;
            this.popupControlContainer1.Visible = false;
            ObservableCollection<object> checkedItem = new ObservableCollection<object>();
            checkedItem = this.sfListView1.CheckedItems;
            for (int i = 0; i < checkedItem.Count; i++)
            {
                if (i < checkedItem.Count - 1)
                {
                    itemChecked += checkedItem[i].ToString() + "," + " ";
                }
                else
                {
                    itemChecked += checkedItem[i].ToString();
                }
            }
            this.textBoxExt1.Text = itemChecked;
        }

        private void buttonAdv2_Click_1(object sender, EventArgs e)
        {
            this.textBoxExt1.Clear();
            this.sfListView1.CheckedItems.Clear();
            this.sfListView1.Refresh();
        }

        private void CloseButtonAdv_Click(object sender, System.EventArgs e)
        {
            this.gradientPanel1.Visible = false;
            this.popupControlContainer1.Visible = false;
        }

        private void buttonAdv3_Click_1(object sender, EventArgs e)
        {
            string checkedListItem = "";
            this.gradientPanel1.Visible = true;
            this.popupControlContainer1.BackColor = Color.White;
            this.popupControlContainer1.ParentControl = this.textBoxExt1;
            this.popupControlContainer1.ShowPopup(Point.Empty);
            if (textBoxExt1.Text.Length > 0)
            {
                ObservableCollection<object> checkedItem = new ObservableCollection<object>();
                checkedItem = this.sfListView1.CheckedItems;

                for (int i = 0; i < checkedItem.Count; i++)
                {
                    if (i < checkedItem.Count - 1)
                    {
                        checkedListItem += checkedItem[i].ToString() + "," + " ";
                    }
                    else
                    {
                        checkedListItem += checkedItem[i].ToString();
                    }
                }
                string itemsReplace = checkedListItem.Replace(" ", "");
                string[] itemsAdded = itemsReplace.Split(new char[] { ',' });
                string textBoxItems = this.textBoxExt1.Text;
                string textBoxSpace = textBoxItems.Replace(" ", "");
                string[] textBox = textBoxSpace.Split(new char[] { ',' });
                string[] item = new string[textBox.Count()];
                int count = 0;
                for (int index = 0; index < textBox.Count(); index++)
                {
                    if (textBox[index] != "")
                    {
                        item[count] = textBox[index];
                        count++;
                    }
                }
                int itemsCount = 0;
                for (int index = 0; index < checkedItem.Count(); index++)
                {
                    itemsCount = 0;
                    for (int secondIndex = 0; secondIndex < count; secondIndex++)
                    {
                        if (item[secondIndex] != "")
                        {
                            if (itemsAdded[index] == item[secondIndex])
                            {
                                itemsCount++;
                            }
                        }
                    }
                    if (itemsCount == 0)
                    {
                        this.sfListView1.CheckedItems.Remove(checkedItem[index]);
                    }
                }
            }
        }
        #endregion
        
        private void TextBoxExt1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            this.popupControlContainer1.BackColor = Color.White;
            if (e.Alt)
            {
                if (e.KeyCode == Keys.Down)
                {
                    if (!this.popupControlContainer1.IsShowing())
                    {
                        this.popupControlContainer1.Visible = true;
                        this.gradientPanel1.Visible = true;
                        this.popupControlContainer1.ParentControl = this.textBoxExt1;
                        this.popupControlContainer1.ShowPopup(Point.Empty);
                        e.Handled = true;
                    }
                    else
                    {
                        this.popupControlContainer1.Visible = true;
                        this.gradientPanel1.Visible = true;
                        this.popupControlContainer1.ParentControl = this.textBoxExt1;
                        this.popupControlContainer1.ShowPopup(Point.Empty);
                        e.Handled = true;
                    }
                    string checkedListItem = "";
                    if (textBoxExt1.Text.Length > 0)
                    {
                        ObservableCollection<object> checkedItem = new ObservableCollection<object>();

                        checkedItem = this.sfListView1.CheckedItems;

                        for (int i = 0; i < checkedItem.Count; i++)
                        {
                            if (i < checkedItem.Count - 1)
                            {
                                checkedListItem += checkedItem[i].ToString() + "," + " ";
                            }
                            else
                            {
                                checkedListItem += checkedItem[i].ToString();
                            }
                        }
                        string itemsReplace = checkedListItem.Replace(" ", "");
                        string[] itemsAdded = itemsReplace.Split(new char[] { ',' });
                        string textBoxItems = this.textBoxExt1.Text;
                        string textBoxSpace = textBoxItems.Replace(" ", "");
                        string[] textBox = textBoxSpace.Split(new char[] { ',' });
                        string[] item = new string[textBox.Count()];
                        int count = 0;
                        for (int index = 0; index < textBox.Count(); index++)
                        {
                            if (textBox[index] != "")
                            {
                                item[count] = textBox[index];
                                count++;
                            }
                        }
                        int itemsCount = 0;
                        for (int index = 0; index < checkedItem.Count(); index++)
                        {
                            itemsCount = 0;
                            for (int secondIndex = 0; secondIndex < count; secondIndex++)
                            {
                                if (item[secondIndex] != "")
                                {
                                    if (itemsAdded[index] == item[secondIndex])
                                    {
                                        itemsCount++;
                                    }
                                }
                            }
                            if (itemsCount == 0)
                            {
                                this.sfListView1.CheckedItems.Remove(checkedItem[index]);
                            }
                        }
                    }
                }
            }           
        }
    }
}
