#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Tools.MultiColumnTreeView;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FilteringDemo
{
    public partial class Form1 : SfForm
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();
#if NETCORE
                Bitmap bmp = new Bitmap(Image.FromFile(@"../../../Icon/sficon.ico"));
                this.Icon = Icon.FromHandle(bmp.GetHicon());
#else
            Bitmap bmp = new Bitmap(Image.FromFile(@"../../Icon/sficon.ico"));
            this.Icon = Icon.FromHandle(bmp.GetHicon());
#endif
            this.MaximizeBox = false;
            this.Load += Form1_Load;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.multiColumnTreeView1.BorderStyle = BorderStyle.Fixed3D;
            this.multiColumnTreeView1.Border3DStyle = Border3DStyle.Flat;
            this.multiColumnTreeView1.DataSource = CreatePersonData();
            this.multiColumnTreeView1.ChildMember = "Children";
            this.comboBox1.SelectedIndex = 0;
            this.textBox1.Text = "Here, Filter will be applied to all the nodes based on salary greater than 23000 in MultiColumnTreeView";
            this.comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        /// <summary>
        /// Form loading event
        /// </summary>
        /// <param name="sender">Senter of this event</param>
        /// <param name="e">Event argument</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(TreeColumnAdv item in this.multiColumnTreeView1.Columns)
            {
                item.HorizontalAlignment = StringAlignment.Near;
            }
            this.multiColumnTreeView1.AutoSizeMode = Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.AutoSizeMode.Fill;
        }
        #endregion

        #region Set Filter Level
        /// <summary>
        /// Filter level will be set based on the selected index
        /// </summary>
        /// <param name="sender">Sender of this event</param>
        /// <param name="e">Event argument</param>
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex == 0)
            {
                this.textBox1.Text = string.Empty;
                this.textBox1.Text = "Here, Filter will be applied to all the nodes based on salary greater than 23000 in MultiColumnTreeView";
                this.multiColumnTreeView1.FilterLevel = FilterLevel.All;
            }
            else if (this.comboBox1.SelectedIndex == 1)
            {
                this.textBox1.Text = string.Empty;
                this.textBox1.Text = "Here, Filter will be applied to root nodes only based on salary greater than 23000 in MultiColumnTreeView";
                this.multiColumnTreeView1.FilterLevel = FilterLevel.Root;
            }
            else if (this.comboBox1.SelectedIndex == 2)
            {
                this.textBox1.Text = string.Empty;
                this.textBox1.Text = "Here, Filter will be applied to all the nodes based on salary greater than 23000. If a node matches the filter condition, its all ancestors will be displayed even though the parent node does not match the filter condition.";
                this.multiColumnTreeView1.FilterLevel = FilterLevel.Extended;
            } 
        }
        #endregion

        #region Collection
        /// <summary>
        /// Person data collection
        /// </summary>
        /// <returns>Returns the collection of person data</returns>
        private ObservableCollection<PersonInfo> CreatePersonData()
        {
            var personList = new ObservableCollection<PersonInfo>();

            ObservableCollection<PersonInfo> childCollection5 = new ObservableCollection<PersonInfo>();
            childCollection5.Add(new PersonInfo() { FirstName = "Robert", LastName = "King", Availability = true, Salary = 4000 });
            childCollection5.Add(new PersonInfo() { FirstName = "Jimmy", LastName = "King", Availability = true, Salary = 1000 });
            childCollection5.Add(new PersonInfo() { FirstName = "Jammy", LastName = "King", Availability = true, Salary = 31000 });

            ObservableCollection<PersonInfo> childCollection6 = new ObservableCollection<PersonInfo>();
            childCollection6.Add(new PersonInfo() { FirstName = "Jerry", LastName = "Saso", Availability = true, Salary = 44000 });
            childCollection6.Add(new PersonInfo() { FirstName = "Tomy", LastName = "Jin", Availability = true, Salary = 10000 });
            childCollection6.Add(new PersonInfo() { FirstName = "Karald", LastName = "King", Availability = true, Salary = 311000 });

            ObservableCollection<PersonInfo> childCollection7 = new ObservableCollection<PersonInfo>();
            childCollection7.Add(new PersonInfo() { FirstName = "Einstan", LastName = "Gaby", Availability = true, Salary = 44000 });
            childCollection7.Add(new PersonInfo() { FirstName = "Bobby", LastName = "Jin", Availability = true, Salary = 10000 });
            childCollection7.Add(new PersonInfo() { FirstName = "Winter", LastName = "Quaran", Availability = true, Salary = 311000 });

            ObservableCollection<PersonInfo> childCollection8 = new ObservableCollection<PersonInfo>();
            childCollection8.Add(new PersonInfo() { FirstName = "Jerry", LastName = "Saso", Availability = true, Salary = 44000 });
            childCollection8.Add(new PersonInfo() { FirstName = "Tomy", LastName = "Jin", Availability = true, Salary = 10000 });
            childCollection8.Add(new PersonInfo() { FirstName = "Karald", LastName = "King", Availability = true, Salary = 311000 });

            ObservableCollection<PersonInfo> childCollection1 = new ObservableCollection<PersonInfo>();
            childCollection1.Add(new PersonInfo() { FirstName = "Andrew", LastName = "Fuller", Availability = true, Salary = 2000, Children = childCollection5 });
            childCollection1.Add(new PersonInfo() { FirstName = "Theodore", LastName = "Hoover", Availability = true, Salary = 15000, Children = childCollection6 });
            childCollection1.Add(new PersonInfo() { FirstName = "Harry", LastName = "Nixon", Availability = false, Salary = 20000, Children = childCollection7 });
            childCollection1.Add(new PersonInfo() { FirstName = "Robert", LastName = "King", Availability = true, Salary = 9000, Children = childCollection8 });

            ObservableCollection<PersonInfo> childCollection2 = new ObservableCollection<PersonInfo>();
            childCollection2.Add(new PersonInfo { FirstName = "Ronald", LastName = "Fillmore", Availability = false, Salary = 3000, Children = childCollection5 });
            childCollection2.Add(new PersonInfo() { FirstName = "Steven", LastName = "Buchanan", Availability = true, Salary = 40000, Children = childCollection6 });
            childCollection2.Add(new PersonInfo() { FirstName = "Robert", LastName = "King", Availability = true, Salary = 2000, Children = childCollection7 });
            childCollection2.Add(new PersonInfo() { FirstName = "Jimmy", LastName = "King", Availability = true, Salary = 1000, Children = childCollection8 });

            ObservableCollection<PersonInfo> childCollection3 = new ObservableCollection<PersonInfo>();
            childCollection3.Add(new PersonInfo { FirstName = "Kessav", LastName = "Fillmore", Availability = false, Salary = 3000, Children = childCollection5 });
            childCollection3.Add(new PersonInfo() { FirstName = "Zim", LastName = "Buchanan", Availability = true, Salary = 40000, Children = childCollection6 });
            childCollection3.Add(new PersonInfo() { FirstName = "Zuo", LastName = "King", Availability = true, Salary = 2000, Children = childCollection7 });
            childCollection3.Add(new PersonInfo() { FirstName = "Martin", LastName = "King", Availability = true, Salary = 1000, Children = childCollection8 });

            ObservableCollection<PersonInfo> childCollection4 = new ObservableCollection<PersonInfo>();
            childCollection4.Add(new PersonInfo { FirstName = "Ranny", LastName = "Fillmore", Availability = false, Salary = 3000, Children = childCollection5 });
            childCollection4.Add(new PersonInfo() { FirstName = "George", LastName = "Buchanan", Availability = true, Salary = 40000, Children = childCollection6 });
            childCollection4.Add(new PersonInfo() { FirstName = "Peter", LastName = "King", Availability = true, Salary = 2000, Children = childCollection7 });
            childCollection4.Add(new PersonInfo() { FirstName = "Candy", LastName = "King", Availability = true, Salary = 1000, Children = childCollection8 });


            personList.Add(new PersonInfo() { FirstName = "Obama", LastName = "bosh", Availability = false, Salary = 90000, Children = childCollection1 });
            personList.Add(new PersonInfo() { FirstName = "John", LastName = "Adams", Availability = true, Salary = 2000000, Children = childCollection2 });
            personList.Add(new PersonInfo() { FirstName = "Thomas", LastName = "Jefferson", Availability = true, Salary = 300000, Children = childCollection3 });
            personList.Add(new PersonInfo() { FirstName = "Andrew", LastName = "Madison", Availability = false, Salary = 40000, Children = childCollection4 });
            personList.Add(new PersonInfo() { FirstName = "Ulysses", LastName = "Pierce", Availability = true, Salary = 1500000, Children = childCollection1 });
            personList.Add(new PersonInfo() { FirstName = "Jimmy", LastName = "Harrison", Availability = false, Salary = 200000, Children = childCollection2 });
            personList.Add(new PersonInfo() { FirstName = "Ronald", LastName = "Fillmore", Availability = false, Salary = 2800000, Children = childCollection3 });
            personList.Add(new PersonInfo() { FirstName = "Tom", LastName = "Wilson", Availability = false, Salary = 3000000, Children = childCollection4 });

            return personList;
        }
        #endregion

        #region Apply and clear filter
        /// <summary>
        /// Applies filter based on the filter condition
        /// </summary>
        /// <param name="sender">Sender of this event</param>
        /// <param name="e">Event argument</param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (multiColumnTreeView1 != null)
            {
                multiColumnTreeView1.Filter = FilterNodes;
                multiColumnTreeView1.RefreshFilter();
            }
        }

        /// <summary>
        /// Clears the filter
        /// </summary>
        /// <param name="sender">Sender of this event</param>
        /// <param name="e">Event argument</param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (multiColumnTreeView1 != null)
            {
                multiColumnTreeView1.Filter = null;
                multiColumnTreeView1.RefreshFilter();
            }
        }
        #endregion

        #region Filter condition
        /// <summary>
        /// Contains the Filtering condition
        /// </summary>
        /// <param name="o">Treenode for which filtering is applied</param>
        /// <returns>Returns whether node satisfies the filtering condition</returns>
        public bool FilterNodes(object o)
        {
            var nodeadv = o as TreeNodeAdv;
            int value = int.Parse(nodeadv.SubItems[2].Text.ToString());
            if (value > 23000)
                return true;
            return false;
        }
        #endregion
    }

    #region Person Information class
    /// <summary>
    /// PersonInfo class
    /// </summary>
    public class PersonInfo
    {
        private string _firstName;
        private string _lastName;
        private bool _available;
        private double _salary;
        private ObservableCollection<PersonInfo> _children;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public bool Availability
        {
            get { return _available; }
            set { _available = value; }
        }

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public ObservableCollection<PersonInfo> Children
        {
            get { return _children; }
            set { _children = value; }
        }
    }
    #endregion
}
