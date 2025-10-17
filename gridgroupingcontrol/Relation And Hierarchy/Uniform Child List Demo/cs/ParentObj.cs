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
using System.Text;

namespace UniformChildList
{
    public class ParentObj : INotifyPropertyChanged
    {
        private string f1, f2;
        private int f3;
        private BindingList<ChildObj> childObj = new BindingList<ChildObj>();


        public ParentObj(string f1, string f2, int f3, params ChildObj[] c)
        {
            this.f1 = f1;
            this.f2 = f2;
            this.f3 = f3;
            foreach(ChildObj i in c)
                childObj.Add(i);
        }

        public string Field1
        {
            get { return f1; }
            set
            {
                if (f1 != value) 
                { 
                    f1 = value; 
                    RaisePropertyChanged("Field1"); 
                }
            }
        }

        public string Field2
        {
            get { return f2; }
            set
            {
                if (f2 != value)
                {
                    f2 = value;
                    RaisePropertyChanged("Field2");
                }
            }
        }

        public int Field3 {
            get { return f3; }
            set
            {
                if (f3 != value)
                {
                    f3 = value;
                    RaisePropertyChanged("Field3");
                }
            }
        }

        public BindingList<ChildObj> Child {
            get { return childObj;  }
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
