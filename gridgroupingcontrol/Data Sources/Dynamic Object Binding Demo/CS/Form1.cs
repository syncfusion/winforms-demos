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
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid.Grouping;
using System.Dynamic;
using System.Collections.ObjectModel;
using Syncfusion.Grouping;
using System.Collections;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms;
using System.Drawing.Drawing2D;
using DemoCommon.Grid;
using System.Text.RegularExpressions;

namespace DynamicObjectBinding_Demo
{
    public partial class Form1 : GridDemoForm
    {
        #region "API Definitions"

        private GridGroupingControl gridGroupingControl1;
        private int rowcount = 20;
        private string[] dept = { "CIVIL", "MECHANICAL", "EEE", "ECE", "IT", "CSE", "BIO-TECH", "AERO", "MARINE", "TEXTILE" };
        private string[] year = { "I", "II", "III", "IV" };
        private DataTable dt;
        private Point locn, topLocn, btmLocn; bool isreached = false;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        bool isComplex = false;

        #endregion

        #region "Constructor"

        public Form1()
        {
            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }

            this.SampleCustomization();

            this.GridSettings();

            #region Timer
            timer.Enabled = true;
            timer.Tick += OnTimer;
            timer.Interval = 20; // 50 images per second.
            timer.Start();
            locn = this.label5.Location;
            btmLocn = new Point(locn.X, locn.Y + 20);
            topLocn = new Point(locn.X, locn.Y - 20);
            this.propertyGrid1.SelectedObject = this.gridGroupingControl1;
            #endregion
        }
        #endregion

        #region "Sample Grid Settings"

        /// <summary>
        /// GridGrouping control getting started customization.
        /// </summary>
        private void GridSettings()
        {

            this.gridGroupingControl1 = new GridGroupingControl();
            this.gridGroupingControl1.BorderStyle = BorderStyle.None;
            this.gridGroupingControl1.Location = new Point(10, 10);
            this.gridGroupingControl1.Size = new Size(755, 307);
            this.gridGroupingControl1.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(this.gridGroupingControl1);

            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.ShowGroupDropArea = true;
            this.gridGroupingControl1.IsDynamicData = true;
            //For setting filetr for columns
            foreach (GridColumnDescriptor col in this.gridGroupingControl1.TableDescriptor.Columns)
                col.AllowFilter = true;

            this.comboBoxAdv1.Text = "Expando Object";

            //used to set multiextended selection mode in gridgrouping control. 
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;

            this.gridGroupingControl1.TableControl.DpiAware = true;
			//used to set GridCaptionRowHeight.
            this.gridGroupingControl1.Table.DefaultCaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridGroupingControl1.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30.0f);
            this.gridGroupingControl1.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            this.gridGroupingControl1.AllowProportionalColumnSizing = true;

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;
        }

        #endregion

        #region "Sample Customization"

      /// <summary>
      /// Implements Dynamic Object Binding .
      /// </summary>

        private void SampleCustomization()
        {
            #region DATASOURCE
            dt = new DataTable();
            dt.Columns.Add("SNo");
            dt.Columns.Add("StudentID");
            dt.Columns.Add("Department");
            dt.Columns.Add("Year");
            dt.Columns.Add("Location");

            Random r = new Random(124321);
            for (int i = 0; i < rowcount; i++)
            {
                DataRow dr = dt.NewRow();
                if ((i + 1) < 10)
                {
                    dr[0] = "0" + (i + 1).ToString();
                    dr[1] = "S" + "0" + (i + 1).ToString();
                }
                else
                {
                    dr[0] = (i + 1).ToString();
                    dr[1] = "S" + (i + 1).ToString();
                }
                dr[2] = dept[r.Next(0, 9)];
                dr[3] = year[r.Next(0, 3)];
                dr[4] = "City";
                dt.Rows.Add(dr);
            }
            #endregion
        }

        #region "Events"

        //used to load Expando or Dynamic object based on combobox selection.
        void comboBoxAdv1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            InitializeData();
            this.checkBoxAdv1.Checked = false;
            isComplex = false;
            
        }
        private void InitializeData()
        {
            if (this.comboBoxAdv1.SelectedItem.ToString() == "Expando Object")
            {
                this.gridGroupingControl1.DataSource = null;
                this.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear();
                this.gridGroupingControl1.DataSource = new DynamicOrders(isComplex);
                //Setting Column header text.
                foreach (GridColumnDescriptor col in this.gridGroupingControl1.TableDescriptor.Columns)
                {
                    Regex rex = new Regex(@"\p{Lu}");
                    int index = rex.Match(col.MappingName.Substring(1)).Index;
                    string name = "";
                    while (index > 0)
                    {
                        name += col.MappingName.Substring(0, index + 1) + " ";
                        string secondName = col.MappingName.Substring(index + 1);
                        index = rex.Match(secondName.Substring(1)).Index;
                        while (index > 0)
                        {
                            name += secondName.Substring(0, index + 1) + " ";
                            index = rex.Match(col.MappingName.Substring(name.Replace(" ", "").Length).Substring(1)).Index;
                        }
                    }
                    name += col.MappingName.Substring(name.Replace(" ", "").Length);
                    col.HeaderText = name;
                }

            }
            else if (this.comboBoxAdv1.SelectedItem.ToString() == "Dynamic Object")
            {
                this.gridGroupingControl1.DataSource = null;
                this.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear();
                this.gridGroupingControl1.DataSource = new DynamicList(isComplex);
            }
        }

        // used to update value on Check state changed.
        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            isComplex = !isComplex;
            InitializeData();
            if (isComplex)
            {
                label5.Visible = false;
                label3.Visible = this.comboBoxAdv1.Text == "Expando Object" ? true : false;
                label4.Visible = this.comboBoxAdv1.Text == "Dynamic Object" ? true : false;
            }
            else
            {
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(213, 223, 229)), 2), this.panel1.ClientRectangle);
        }

        #endregion

        #endregion

        #region "Designer Stuffs"

        private void OnTimer(object sender, System.EventArgs e)
        {

            if (!this.isComplex)
            {
                if (!isreached && locn.Y > topLocn.Y && locn.Y <= btmLocn.Y)
                {
                    label5.Location = new Point(locn.X, locn.Y - 1);
                    locn = label5.Location;
                }
                else if (locn.Y < btmLocn.Y)
                {
                    isreached = true;
                    label5.Location = new Point(locn.X, locn.Y + 1);
                    locn = label5.Location;
                }
                else if (locn.Y >= btmLocn.Y)
                {
                    isreached = false;
                }

            }
        }

        #endregion

    }

    #region Custom Object derived from DynamicObject
    // The class derived from DynamicObject. 
    public class DynamicDictionary : DynamicObject, IDictionary<string, object>
    {
        // The inner dictionary.
        public Dictionary<string, object> dictionary
            = new Dictionary<string, object>();

        // This property returns the number of elements 
        // in the inner dictionary. 
        public int Count
        {
            get
            {
                return dictionary.Count;
            }
        }

        // If you try to get a value of a property  
        // not defined in the class, this method is called. 
        public override bool TryGetMember(
            GetMemberBinder binder, out object result)
        {
            // Converting the property name to lowercase 
            // so that property names become case-insensitive. 
            string name = binder.Name;

            // If the property name is found in a dictionary, 
            // set the result parameter to the property value and return true. 
            // Otherwise, return false. 
            return dictionary.TryGetValue(name, out result);
        }

        // If you try to set a value of a property that is 
        // not defined in the class, this method is called. 
        public override bool TrySetMember(
            SetMemberBinder binder, object value)
        {
            // Converting the property name to lowercase 
            // so that property names become case-insensitive.
            dictionary[binder.Name] = value;

            // You can always add a value to a dictionary, 
            // so this method always returns true. 
            return true;
        }

        public void Add(string key, object value)
        {
            dictionary.Add(key, value);
        }

        public void Clear()
        {
            dictionary.Clear();
        }

        public bool Contains(string key)
        {
            return dictionary.ContainsKey(key);
        }

        public IDictionaryEnumerator GetEnumerator()
        {
            return dictionary.GetEnumerator();
        }

        public bool IsFixedSize
        {
            get { return false; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public ICollection Keys
        {
            get { return dictionary.Keys; }
        }

        public void Remove(string key)
        {
            dictionary.Remove(key);
        }

        public ICollection Values
        {
            get { return dictionary.Values; }
        }

        public object this[string key]
        {
            get
            {
                if(dictionary.ContainsKey(key))
                    return dictionary[key];
                return null;
            }
            set
            {
                dictionary[key] = value;
            }
        }

        public bool ContainsKey(string key)
        {
            return dictionary.ContainsKey(key);
        }

        ICollection<string> IDictionary<string, object>.Keys
        {
            get { return dictionary.Keys; }
        }

        bool IDictionary<string, object>.Remove(string key)
        {
            return dictionary.Remove(key);
        }

        public bool TryGetValue(string key, out object value)
        {
            value = dictionary[key];
            return true;
        }

        ICollection<object> IDictionary<string, object>.Values
        {
            get { return dictionary.Values; }
        }

        public void Add(KeyValuePair<string, object> item)
        {
            dictionary.Add(item.Key, item.Value);
        }

        public bool Contains(KeyValuePair<string, object> item)
        {
            return dictionary.ContainsKey(item.Key);
        }

        public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<string, object> item)
        {
            return dictionary.Remove(item.Key);
        }

        IEnumerator<KeyValuePair<string, object>> IEnumerable<KeyValuePair<string, object>>.GetEnumerator()
        {
            return dictionary.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return dictionary.GetEnumerator();
        }
    }
    #endregion

    #region Dynamic objects defined using ExpandoObject
    public class DynamicOrders : List<dynamic>
    {
        public DynamicOrders(bool isComplex)
        {
                var orders = NorthwindOrders.Model;
                foreach (var o in orders)
                {
                    dynamic d = new ExpandoObject();
                    d.OrderID = o.OrderID;
                    d.CustomerID = o.CustomerID;
                    d.EmployeeID = o.EmployeeID;
                    d.ShipCity = o.ShipCity;
                    d.Freight = o.Freight;
                    if (isComplex)
                    {
                        d.ShipCountry = new DynamicDictionary();
                        d.ShipCountry.DestinatedCity = o.ShipCity;
                        d.ShipCountry.DestinatedCountry = o.ShipCountry;
                    }
                    else
                    {
                        d.ShipCountry = o.ShipCountry; 
                    }
                    this.Add(d);
                }
        }
    }
    #endregion

    #region Dynamic objects defined using Custom Object
    public class DynamicList:BindingList<DynamicDictionary>
    {
        public DynamicList(bool isComplex)
        {
            for (int i = 0; i < 1000; i++)
            {
                // Creating a dynamic dictionary.
                dynamic person = new DynamicDictionary();
                // Adding new dynamic properties.  
                // The TrySetMember method is called.
                if (isComplex)
                {
                    person.Name = "Adams";
                    person.Address = new DynamicDictionary();
                    person.City = "North Caroline";
                    person.Country = "United States";
                }
                else
                {
                    person.Name = "Adams";
                    person.Address = "United States";
                }
                this.Add(person);
            }
        }
    }
    #endregion
}
