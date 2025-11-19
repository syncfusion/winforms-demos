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
using System.Linq;
using System.Text;

namespace I58680b
{
    public class Employee
    {
        public string Name { get; set; }

        [TypeConverter(typeof(StatusConverter))]
        public Status Status { get; set; }

        [Browsable(true)]
        public Context Context { get; set; }

        public Employee(string name, Status status, Context context)
        {
            Name = name;
            Status = status;
            Context = context;
        }

    }

    public enum Status
    {
        Married,
        Single,
        Divorced,
        Widow
    }

    public enum Context
    {
        Employed,
        Retired,
        OnVacation,
        Sick
    }
}
