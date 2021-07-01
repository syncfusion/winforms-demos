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
