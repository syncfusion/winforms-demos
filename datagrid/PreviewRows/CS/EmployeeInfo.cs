#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace PreviewRows
{
    /// <summary>
    /// Represents the class that contains the details of the employee.
    /// </summary>
    public class EmployeeInfo
    {
        /// <summary>
        /// Gets or sets first name of the employee.
        /// </summary>
        [Display(Name = "First Name")]
        public string FirstName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets last name of the employee.
        /// </summary>
        [Display(Name = "Last Name")]
        public string LastName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets Title of the employee.
        /// </summary>
        [Display(Name = "Title")]
        public string Title
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets country name of the employee.
        /// </summary>
        [Display(Name = "Country")]
        public string Country
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets address of the employee.
        /// </summary>
        [Display(Name = "Address", AutoGenerateField = false)]
        public string Address
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets postal code of the employee.
        /// </summary>
        [Display(Name = "PostalCode", AutoGenerateField = false)]
        public string PostalCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the city of the employee.
        /// </summary>
        [Display(Name = "City", AutoGenerateField = false)]
        public string City
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets Phone no of the employee.
        /// </summary>
        [Display(Name = "Phone", AutoGenerateField = false)]
        public string Phone
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the hired date of the employee.
        /// </summary>
        [Display(Name = "HireDate", AutoGenerateField = false)]
        public DateTime HireDate
        {
            get;
            set;
        }
    }

    /// <summary>
    /// Represents a class that provides the collection of the employee details.
    /// </summary>
    public class EmployeeDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeDetails"/> class.
        /// </summary>
        public EmployeeDetails()
        {
            EmployeeInfoCollection = GetEmployeesDetails();
        }

        /// <summary>
        /// Gets or sets the collection of the Employee Info.
        /// </summary>
        public List<EmployeeInfo> EmployeeInfoCollection { get; set; }

        /// <summary>
        /// Gets the collection of the Employee details.
        /// </summary>
        /// <returns>Returns the collection of Employees.</returns>
        public List<EmployeeInfo> GetEmployeesDetails()
        {
            EmployeeInfoCollection = new List<EmployeeInfo>();

            EmployeeInfoCollection.Add(new EmployeeInfo()
            {
                FirstName = "Michael",
                LastName = "Suyama",
                Country = "UK",
                City = "London",
                Address = "Coventry House Miner Rd.",
                HireDate = Convert.ToDateTime("10/11/1994"), 
                Phone = "(71) 555-7773",
                PostalCode = "RG1 9SP",
                Title = "Sales Representative"
            });

            EmployeeInfoCollection.Add(new EmployeeInfo()
            {
                FirstName = "Robert",
                LastName = "King",
                Country = "UK",
                City = "London",
                Address = "Edgeham Hollow Winchester Way",
                HireDate = Convert.ToDateTime("1/2/1994"),
                Phone = "(71) 555-5598",
                PostalCode = "98105",
                Title = "Sales Representative"
            });

            EmployeeInfoCollection.Add(new EmployeeInfo()
            {
                FirstName = "Laura",
                LastName = "Callahan",
                Country = "USA",
                City = "Seattle",
                Address = "4726 - 11th Ave. N.E.",
                HireDate = Convert.ToDateTime("3/5/1994"),
                Phone = "(71) 555-4444",
                PostalCode = "WG2 7LT",
                Title = "Inside Sales Coordinator"
            });

            EmployeeInfoCollection.Add(new EmployeeInfo()
            {
                FirstName = "Nancy",
                LastName = "Davolio",
                Country = "USA",
                City = "Seattle",
                Address = "507 - 20th Ave. E. Apt. 2A",
                HireDate = Convert.ToDateTime("5/1/1992"),
                Phone = "(206) 555-9847",
                PostalCode = "98122",
                Title = "Sales Representative"
            });

            EmployeeInfoCollection.Add(new EmployeeInfo()
            {
                FirstName = "Andrew",
                LastName = "Fuller",
                Country = "USA",
                City = "Tacoma",
                Address = "908 W. Capital Way",
                HireDate = Convert.ToDateTime("8/11/1992"),
                Phone = "(206) 555-9482",
                PostalCode = "98033",
                Title = "Vice President, Sales"
            });

            EmployeeInfoCollection.Add(new EmployeeInfo()
            {
                FirstName = "Janet",
                LastName = "Leverling",
                Country = "USA",
                City = "Kirkland",
                Address = "722 Moss Bay Blvd.",
                HireDate = Convert.ToDateTime("4/1/1992"),
                Phone = "(206) 555-3412",
                PostalCode = "98052",
                Title = "Sales Representative"
            });

            EmployeeInfoCollection.Add(new EmployeeInfo()
            {
                FirstName = "Margaret",
                LastName = "Peacock",
                Country = "USA",
                City = "Redmond",
                Address = "4110 Old Redmond Rd.",
                HireDate = Convert.ToDateTime("5/3/1992"),
                Phone = "(206) 555-8122",
                PostalCode = "SW1 8JR",
                Title = "Sales Representative"
            });

            EmployeeInfoCollection.Add(new EmployeeInfo()
            {
                FirstName = "Steven",
                LastName = "Buchanan",
                Country = "UK",
                City = "London",
                Address = "14 Garrett Hill",
                HireDate = Convert.ToDateTime("10/12/1993"),
                Phone = "(71) 555-4848",
                PostalCode = "EC2 7JR",
                Title = "Sales Representative"
            });

            EmployeeInfoCollection.Add(new EmployeeInfo()
            {
                FirstName = "Anne",
                LastName = "Dodsworth",
                Country = "UK",
                City = "London",
                Address = "7 Houndstooth Rd.",
                HireDate = Convert.ToDateTime("11/10/1994"),
                Phone = "(71) 555-4444",
                PostalCode = "WG2 7LT",
                Title = "Sales Representative"
            });

            return EmployeeInfoCollection;
        }
    }
}
