#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DataBinding
{
    public class GenericCollection : INotifyPropertyChanged
    {
        int id;
        string first_name;
        string last_name;
        string address;
        string city;
        public GenericCollection(int id, string fname, string lname, string addr, string city)
        {
            this.id = id;
            first_name = fname;
            last_name = lname;
            address = addr;
            this.city = city;
        }

        public int ID
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    RaisePropertyChanged("ID");
                }
            }
        }

        public string FirstName
        {
            get { return first_name; }
            set
            {
                if (first_name != value)
                {
                    first_name = value;
                    RaisePropertyChanged("FirstName");
                }
            }
        }
        public string LastName
        {
            get { return last_name; }
            set
            {
                if (last_name != value)
                {
                    last_name = value;
                    RaisePropertyChanged("LastName");
                }
                last_name = value;
            }
        }
        public string Address
        {
            get { return address; }
            set
            {
                if (address != value)
                {
                    address = value;
                    RaisePropertyChanged("Address");
                }
            }
        }
        public string City
        {
            get { return city; }
            set
            {
                if (city != value)
                {
                    city = value;
                    RaisePropertyChanged("City");
                }
            }
        }

        void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
