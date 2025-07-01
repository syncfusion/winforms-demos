#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
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
				languageList.Add("Germany");
				languageList.Add("Poland");
				languageList.Add("Scotland");
				languageList.Add("Netherland");
				languageList.Add("New Zealand");
				languageList.Add("Indonesia");
				languageList.Add("Iceland");
				languageList.Add("South Korea");
				languageList.Add("Singapore");
				languageList.Add("South Africa");
				languageList.Add("Malaysia");
				languageList.Add("Pakistan");
				languageList.Add("Afghanistan");
				languageList.Add("Finland");
				languageList.Add("Ireland");
				languageList.Add("Sweden");
				languageList.Add("Portugal");
                sfListView1.DataSource = languageList;
#else
                this.Icon = new System.Drawing.Icon(@"..\\..\\\logo.ico");
                 System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
                 this.sfListView1.DataSource = ((object)(resources.GetObject("sfListView1.DataSource")));
#endif
                this.Load += Form1_Load;
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(830, 584);

            // 
            // label2
            //
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(110), (int)DpiAware.LogicalToDeviceUnits(27));

            // 
            // sfListView1
            //
            this.sfListView1.Location = new System.Drawing.Point(-1, 25);
            this.sfListView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sfListView1.Size = new System.Drawing.Size(this.textBoxExt1.Width, (int)DpiAware.LogicalToDeviceUnits(162));

            // 
            // textBoxExt1
            // 
            this.textBoxExt1.Height = 30;
            this.textBoxExt1.Location = new System.Drawing.Point(252, 211);
            this.textBoxExt1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxExt1_KeyDown);

            // 
            // showPopupButtonAdv3
            //
            this.showPopupButtonAdv3.Location = new Point(this.textBoxExt1.Bounds.X + this.textBoxExt1.Bounds.Width + 3, this.textBoxExt1.Bounds.Y);
            this.showPopupButtonAdv3.Size = new Size(30, this.textBoxExt1.Bounds.Height);
            this.showPopupButtonAdv3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showPopupButtonAdv3.Click += new System.EventHandler(this.buttonAdv3_Click_1);

            // 
            // popupControlContainer1
            //
            this.popupControlContainer1.Location = new System.Drawing.Point(336, 279);
            this.popupControlContainer1.Size = new System.Drawing.Size(this.textBoxExt1.Width, (int)DpiAware.LogicalToDeviceUnits(216));

            // 
            // gradientPanel1
            //
            this.gradientPanel1.Size = new System.Drawing.Size(this.textBoxExt1.Width,(int)DpiAware.LogicalToDeviceUnits(216));
            this.gradientPanel1.Location = new Point(this.sfListView1.Bounds.X, this.sfListView1.Bounds.Y + this.sfListView1.Height);

            // 
            // addButtonAdv1
            //
            this.addButtonAdv1.Font = new Font("Segoe UI", 10F);
            this.addButtonAdv1.Location = new Point(106, this.sfListView1.Bounds.Y + this.sfListView1.Height + 10);
            this.addButtonAdv1.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(45), (int)DpiAware.LogicalToDeviceUnits(16));
            this.addButtonAdv1.Click += buttonAdv1_Click;

            // 
            // clearButtonAdv2
            // 
            this.clearButtonAdv2.Font = new Font("Segoe UI", 10F);
            this.clearButtonAdv2.Location = new Point(this.addButtonAdv1.Bounds.X + this.addButtonAdv1.Width + 10, this.sfListView1.Bounds.Y + this.sfListView1.Height + 10);
            this.clearButtonAdv2.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(45), (int)DpiAware.LogicalToDeviceUnits(16));
            this.clearButtonAdv2.Click += new System.EventHandler(this.buttonAdv2_Click_1);

            // 
            // closeButtonAdv
            //
            this.closeButtonAdv.Font = new Font("Segoe UI", 10F);
            this.closeButtonAdv.Location = new Point(this.clearButtonAdv2.Bounds.X + this.clearButtonAdv2.Width + 10, 10 + this.sfListView1.Bounds.Y + this.sfListView1.Height);
            this.closeButtonAdv.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(45), (int)DpiAware.LogicalToDeviceUnits(16));
            this.closeButtonAdv.Click += CloseButtonAdv_Click;
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
