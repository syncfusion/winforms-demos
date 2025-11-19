#region Copyright Syncfusion Inc. 2001 - 2015
// Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OnDemandPaging
{
    public class NotificationObject : INotifyPropertyChanged
    {
        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }

    public class Employees : NotificationObject
    {
        private int _EmployeeID;
        private string _Name;
        private int _ContactID;
        private string _Title;
        private DateTime _BirthDate;
        private string _MaritalStatus;
        private string _Gender;
        private DateTime _HireDate;
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

        [Display(Name = "Contact ID")]
        public int ContactID
        {
            get { return this._ContactID; }
            set
            {
                this._ContactID = value;
                this.RaisePropertyChanged("ContactID");
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


        [Display(Name = "Marital Status")]
        public string MaritalStatus
        {
            get { return this._MaritalStatus; }
            set
            {
                this._MaritalStatus = value;
                this.RaisePropertyChanged("MaritalStatus");
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

        [Display(Name = "Hired Date")]
        public DateTime HiredDate
        {
            get { return this._HireDate; }
            set
            {
                this._HireDate = value;
                this.RaisePropertyChanged("HiredDate");
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
    }
}
