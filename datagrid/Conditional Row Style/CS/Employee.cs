#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ConditionalRowStyle
{
    public class Employees : INotifyPropertyChanged
    {
        private int _EmployeeID;
        private string _Name;
        private string _Title;
        private int _rating;
        private DateTime _BirthDate;
        private string _Gender;
        private double _Salary;

        [Display(Name = "Employee ID")]
        public int EmployeeID
        {
            get { return this._EmployeeID; }
            set
            {
                this._EmployeeID = value;
                this.RaisePropertyChanged("EmployeeID");
            }
        }

        public string Name
        {
            get { return this._Name; }
            set
            {
                this._Name = value;
                this.RaisePropertyChanged("Name");
            }
        }

        public string Title
        {
            get { return this._Title; }
            set
            {
                this._Title = value;
                this.RaisePropertyChanged("Title");
            }
        }

        public int Rating
        {
            get { return _rating; }
            set
            {
                _rating = value;
                this.RaisePropertyChanged("Rating");
            }
        }

        [Display(Name = "Birth Date")]
        public DateTime BirthDate
        {
            get { return this._BirthDate; }
            set
            {
                this._BirthDate = value;
                this.RaisePropertyChanged("BirthDate");
            }
        }

        public string Gender
        {
            get { return this._Gender; }
            set
            {
                this._Gender = value;
                this.RaisePropertyChanged("Gender");
            }
        }

        [DataType(DataType.Currency)]
        public double Salary
        {
            get { return this._Salary; }
            set
            {
                this._Salary = value;
                this.RaisePropertyChanged("Salary");
            }
        }

        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
