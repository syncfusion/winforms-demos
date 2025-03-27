#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace DataBinding
{
    public class Employee : INotifyPropertyChanged, IDataErrorInfo
    {
        private int _EmployeeID;
        private int count;
        private int _NationalIDNumber;
        private int _ContactID;
        private int age;
        private int experience;
        private double _Salary;
        private EmployeeComplexModel empcomplexmodel;
        private EmployeeIndex[] empdetails;

        [Display(Name = "Employee ID")]
        public int EmployeeID
        {
            get
            {
                return this._EmployeeID;
            }
            set
            {
                this._EmployeeID = value;
                this.RaisePropertyChanged("EmployeeID");
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }
            set
            {
                this.count = value;
                this.RaisePropertyChanged("Count");
            }
        }

        [Display(Name = "National ID Number")]
        public int NationalIDNumber
        {
            get
            {
                return this._NationalIDNumber;
            }
            set
            {
                this._NationalIDNumber = value;
                this.RaisePropertyChanged("NationalIDNumber");
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
                this.RaisePropertyChanged("Age");
            }
        }

        [Display(Name = "Contact ID")]
        public int ContactID
        {
            get
            {
                return this._ContactID;
            }
            set
            {
                this._ContactID = value;
                this.RaisePropertyChanged("ContactID");
            }
        }

        public int Experience
        {
            get
            {
                return this.experience;
            }
            set
            {
                this.experience = value;
                this.RaisePropertyChanged("Experience");
            }
        }

        [DataType(DataType.Currency)]
        public double Salary
        {
            get
            {
                return this._Salary;
            }
            set
            {
                this._Salary = value;
                this.RaisePropertyChanged("Salary");
            }
        }

        public EmployeeComplexModel Empcomplexmodel
        {
            get
            {
                return empcomplexmodel;
            }
            set
            {
                empcomplexmodel = value;
                this.RaisePropertyChanged("Empcomplexmodel");
            }
        }

        public EmployeeIndex[] EmpDetails
        {
            get
            {
                return empdetails;
            }
            set
            {
                empdetails = value;
                this.RaisePropertyChanged("EmpDetails");
            }
        }

        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        [Display(AutoGenerateField = false)]
        public string Error
        {
            get { return null; }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName.Equals("Salary"))
                {
                    if (this.Salary < 500000.0)
                        return null;
                    else
                        return "Salary sholud have more than 500000.0";
                }
                return null;
            }
        }
    }

    public class EmployeeComplexModel : INotifyPropertyChanged
    {
        private int empID;
        private string name;

        public EmployeeComplexModel() { }

        public int EmpID
        {
            get
            {
                return empID;
            }
            set
            {
                empID = value;
                RaisePropertyChanged("EmpID");
            }
        }

        public string EmpName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                RaisePropertyChanged("EmpName");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class EmployeeIndex : INotifyPropertyChanged
    {
        private string title;
        private int id;

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
                RaisePropertyChanged("Title");
            }
        }

        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
                RaisePropertyChanged("ID");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class DynamicCollection : INotifyPropertyChanged
    {
        public DynamicCollection()
        {
            Employee = GetEmployeesDetails(30);
            ChangeCollection = ChangeEmployeeCollection(30);
            _name = new List<string>();
            _name.Add("Kumr");
            _name.Add("Arun");
            _name.Add("Bala");
            _name.Add("Laal");
            _name.Add("Dena");
            _name.Add("Mala");
            _name.Add("Mena");
            _name.Add("Raam");
        }

        private ObservableCollection<dynamic> employee;
        public ObservableCollection<dynamic> Employee
        {
            get
            {
                return employee;
            }
            set
            {
                employee = value;
                RaisePropertyChanged("Employee");
            }
        }

        private ObservableCollection<dynamic> emptyEmployeecollection;
        public ObservableCollection<dynamic> EmptyEmployeecollection
        {
            get
            {
                return emptyEmployeecollection;
            }
            set
            {
                emptyEmployeecollection = value;
                RaisePropertyChanged("EmptyEmployeecollection");
            }
        }

        private ObservableCollection<dynamic> changeCollection;
        public ObservableCollection<dynamic> ChangeCollection
        {
            get
            {
                return changeCollection;
            }
            set
            {
                changeCollection = value;
                RaisePropertyChanged("ChangeCollection");
            }
        }

        public ObservableCollection<dynamic> ChangeEmployeeCollection(int count)
        {
            var employees = new ObservableCollection<dynamic>();

            for (int i = 1; i < count; i++)
            {
                employees.Add(GetnewEmployeesdetails(i));
            }

            return employees;
        }

        private Employee GetnewEmployeesdetails(int i)
        {
            var employee = new Employee();
            for (int j = 0; j < 3; j++)
            {
                employee.Count = i;
                employee.EmployeeID = i;
                employee.NationalIDNumber = i + 1000;
                employee.ContactID = i;
                employee.Age = i;
                employee.Experience = i;
                employee.Salary = Math.Round(i * 1500.0, 2);
                employee.Empcomplexmodel = new EmployeeComplexModel() { EmpName = employeeName[i] };
                employee.EmpDetails = new EmployeeIndex[1];
                employee.EmpDetails[0] = new EmployeeIndex();
                employee.EmpDetails[0].ID = i;
                employee.EmpDetails[0].Title = title[i + 10];
            }

            return employee;
        }


        public ObservableCollection<dynamic> GetEmployeesDetails(int count)
        {
            ObservableCollection<dynamic> employees = new ObservableCollection<dynamic>();

            for (int i = 5; i < count; i++)
            {
                employees.Add(GetEmployees(i));
            }

            return employees;
        }

        private dynamic GetEmployees(int i)
        {
            dynamic employee = new ExpandoObject();
            employee.Name = employeeName[i];
            employee.Count = i;
            employee.NationalIDNumber = i + 100;
            employee.ContactID = i;
            employee.Title = title[i];
            employee.Age = i;
            employee.Experiance = i;
            employee.Salary = Math.Round(i * 2000.0, 2);
            employee.Empcomplexmodel = new EmployeeComplexModel() { EmpName = employeeName[i] };
            employee.EmpDetails = new EmployeeIndex[1];
            employee.EmpDetails[0] = new EmployeeIndex();
            employee.EmpDetails[0].Title = title[i];
            employee.EmpDetails[0].ID = 1000 + i;
            return employee;
        }

        private List<string> _name;
        public List<string> Namelist
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        string[] title = new string[]
        {
            "Marketing Assistant",
            "Engineering Manager",
            "Senior Tool Designer",
            "Tool Designer",
            "Marketing Manager",
            "Production Supervisor - WC60",
            "Production Technician - WC10",
            "Design Engineer",
            "Production Technician - WC10",
            "Design Engineer",
            "Vice President of Engineering",
            "Production Technician - WC10",
            "Production Supervisor - WC50",
            "Production Technician - WC10",
            "Production Supervisor - WC60",
            "Production Technician - WC10",
            "Production Supervisor - WC60",
            "Production Technician - WC10",
            "Production Technician - WC30",
            "Production Control Manager",
            "Production Technician - WC45",
            "Production Technician - WC45",
            "Production Technician - WC30",
            "Production Supervisor - WC10",
            "Production Technician - WC20",
            "Production Technician - WC40",
            "Network Administrator",
            "Production Technician - WC50",
            "Human Resources Manager",
            "Production Technician - WC40",
            "Production Technician - WC30",
            "Production Technician - WC30",
            "Stocker",
            "Shipping and Receiving Clerk",
            "Production Technician - WC50",
            "Production Technician - WC60",
            "Production Supervisor - WC50",
            "Production Technician - WC20",
            "Production Technician - WC45",
            "Quality Assurance Supervisor",
            "Information Services Manager",
            "Production Technician - WC50",
            "Master Scheduler",
            "Production Technician - WC40",
            "Marketing Specialist",
            "Recruiter",
            "Production Technician - WC50",
            "Maintenance Supervisor",
            "Production Technician - WC30",
        };

        string[] employeeName = new string[]
        {
            "Sean Jacobson",
            "Phyllis Allen",
            "Marvin Allen",
            "Michael Allen",
            "Cecil Allison",
            "Oscar Alpuerto",
            "Sandra Altamirano",
            "Selena Alvarad",
            "Emilio Alvaro",
            "Maxwell Amland",
            "Mae Anderson",
            "Ramona Antrim",
            "Sabria Appelbaum",
            "Hannah Arakawa",
            "Kyley Arbelaez",
            "Tom Johnston",
            "Thomas Armstrong",
            "John Arthur",
            "Chris Ashton",
            "Teresa Atkinson",
            "John Ault",
            "Robert Avalos",
            "Stephen Ayers",
            "Phillip Bacalzo",
            "Gustavo Achong",
            "Catherine Abel",
            "Kim Abercrombie",
            "Humberto Acevedo",
            "Pilar Ackerman",
            "Frances Adams",
            "Margar Smith",
            "Carla Adams",
            "Jay Adams",
            "Ronald Adina",
            "Samuel Agcaoili",
            "James Aguilar",
            "Robert Ahlering",
            "Francois Ferrier",
            "Kim Akers",
            "Lili Alameda",
            "Amy Alberts",
            "Anna Albright",
            "Milton Albury",
            "Paul Alcorn",
            "Gregory Alderson",
            "J. Phillip Alexander",
            "Michelle Alexander",
            "Daniel Blanco",
            "Cory Booth",
            "James Bailey"
        };

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }


    public class List_Collectionclass : INotifyPropertyChanged
    {
        public List_Collectionclass()
        {
            Employeelist = GetEmployeesDetailslist(5);
            ChangeCollection = ChangeEmployeeCollection(5);
            EmptyList = new List<Employee>();
        }

        private List<Employee> emptylist;
        public List<Employee> EmptyList
        {
            get
            {
                return emptylist;
            }
            set
            {
                emptylist = value;
                RaisePropertyChanged("EmptyList");
            }
        }

        private List<Employee> employeelist;
        public List<Employee> Employeelist
        {
            get
            {
                return employeelist;
            }
            set
            {
                employeelist = value;
                RaisePropertyChanged("Employeelist");
            }
        }

        private List<Employee> changeCollection;
        public List<Employee> ChangeCollection
        {
            get
            {
                return changeCollection;
            }
            set
            {
                changeCollection = value;
                RaisePropertyChanged("ChangeCollection");
            }
        }

        public List<Employee> ChangeEmployeeCollection(int count)
        {
            var employees = new List<Employee>();

            for (int i = 1; i < count; i++)
            {
                employees.Add(GetnewEmployeesdetails(i));
            }

            return employees;
        }

        private Employee GetnewEmployeesdetails(int i)
        {
            var employee = new Employee();

            employee.Count = employee.Count + i;
            employee.EmployeeID = 100 + i;
            employee.NationalIDNumber = i + 100;
            employee.ContactID = i;
            employee.Age = 20 + i;
            employee.Experience = 1 + i;
            employee.Salary = Math.Round(i * 1000.0, 2);
            employee.Empcomplexmodel = new EmployeeComplexModel() { EmpName = employeeName[i] };
            employee.EmpDetails = new EmployeeIndex[1];
            employee.EmpDetails[0] = new EmployeeIndex();
            employee.EmpDetails[0].ID = 100 + i;
            employee.EmpDetails[0].Title = title[i + 10];
            return employee;
        }

        public List<Employee> GetEmployeesDetailslist(int count)
        {
            List<Employee> employees = new List<Employee>();

            for (int i = 1; i < count; i++)
            {
                employees.Add(GetEmployeeslist(i));
            }

            return employees;
        }

        private Employee GetEmployeeslist(int i)
        {
            var employee = new Employee();
            employee.EmployeeID = 100 + i;
            employee.Count = employee.Count + i;
            employee.NationalIDNumber = i + 100;
            employee.ContactID = i + 500;
            employee.Age = 20 + i;
            employee.Experience = 1 + i;
            employee.Salary = Math.Round(i * 2000.0, 2);
            employee.Empcomplexmodel = new EmployeeComplexModel() { EmpName = employeeName[i] };
            employee.EmpDetails = new EmployeeIndex[1];
            employee.EmpDetails[0] = new EmployeeIndex();
            employee.EmpDetails[0].Title = title[i];
            employee.EmpDetails[0].ID = 100 + i;
            return employee;
        }

        string[] title = new string[]
        {
            "Marketing Assistant",
            "Engineering Manager",
            "Senior Tool Designer",
            "Tool Designer",
            "Marketing Manager",
            "Production Supervisor - WC60",
            "Production Technician - WC10",
            "Design Engineer",
            "Production Technician - WC10",
            "Design Engineer",
            "Vice President of Engineering",
            "Production Technician - WC10",
            "Production Supervisor - WC50",
            "Production Technician - WC10",
            "Production Supervisor - WC60",
            "Production Technician - WC10",
            "Production Supervisor - WC60",
            "Production Technician - WC10",
            "Production Technician - WC30",
            "Production Control Manager",
            "Production Technician - WC45",
            "Production Technician - WC45",
            "Production Technician - WC30",
            "Production Supervisor - WC10",
            "Production Technician - WC20",
            "Production Technician - WC40",
            "Network Administrator",
            "Production Technician - WC50",
            "Human Resources Manager",
            "Production Technician - WC40",
            "Production Technician - WC30",
            "Production Technician - WC30",
            "Stocker",
            "Shipping and Receiving Clerk",
            "Production Technician - WC50",
            "Production Technician - WC60",
            "Production Supervisor - WC50",
            "Production Technician - WC20",
            "Production Technician - WC45",
            "Quality Assurance Supervisor",
            "Information Services Manager",
            "Production Technician - WC50",
            "Master Scheduler",
            "Production Technician - WC40",
            "Marketing Specialist",
            "Recruiter",
            "Production Technician - WC50",
            "Maintenance Supervisor",
            "Production Technician - WC30",
        };

        string[] employeeName = new string[]
        {
            "Sean Jacobson",
            "Phyllis Allen",
            "Marvin Allen",
            "Michael Allen",
            "Cecil Allison",
            "Oscar Alpuerto",
            "Sandra Altamirano",
            "Selena Alvarad",
            "Emilio Alvaro",
            "Maxwell Amland",
            "Mae Anderson",
            "Ramona Antrim",
            "Sabria Appelbaum",
            "Hannah Arakawa",
            "Kyley Arbelaez",
            "Tom Johnston",
            "Thomas Armstrong",
            "John Arthur",
            "Chris Ashton",
            "Teresa Atkinson",
            "John Ault",
            "Robert Avalos",
            "Stephen Ayers",
            "Phillip Bacalzo",
            "Gustavo Achong",
            "Catherine Abel",
            "Kim Abercrombie",
            "Humberto Acevedo",
            "Pilar Ackerman",
            "Frances Adams",
            "Margar Smith",
            "Carla Adams",
            "Jay Adams",
            "Ronald Adina",
            "Samuel Agcaoili",
            "James Aguilar",
            "Robert Ahlering",
            "Francois Ferrier",
            "Kim Akers",
            "Lili Alameda",
            "Amy Alberts",
            "Anna Albright",
            "Milton Albury",
            "Paul Alcorn",
            "Gregory Alderson",
            "J. Phillip Alexander",
            "Michelle Alexander",
            "Daniel Blanco",
            "Cory Booth",
            "James Bailey"
        };

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class EmployeeCollection : INotifyPropertyChanged
    {
        public EmployeeCollection()
        {
            Employee = GetEmployeesDetails(35);
            ChangeCollection = ChangeEmployeeCollection(35);
        }

        private ObservableCollection<Employee> employee;
        public ObservableCollection<Employee> Employee
        {
            get
            {
                return employee;
            }
            set
            {
                employee = value;
                RaisePropertyChanged("Employee");
            }
        }

        private ObservableCollection<Employee> emptyEmployeecollection;
        public ObservableCollection<Employee> EmptyEmployeecollection
        {
            get
            {
                return emptyEmployeecollection;
            }
            set
            {
                emptyEmployeecollection = value;
                RaisePropertyChanged("EmptyEmployeecollection");
            }
        }

        private ObservableCollection<Employee> changeCollection;
        public ObservableCollection<Employee> ChangeCollection
        {
            get
            {
                return changeCollection;
            }
            set
            {
                changeCollection = value;
                RaisePropertyChanged("ChangeCollection");
            }
        }

        public ObservableCollection<Employee> ChangeEmployeeCollection(int count)
        {
            var employees = new ObservableCollection<Employee>();

            for (int i = 1; i < count; i++)
            {
                employees.Add(GetnewEmployeesdetails(i));
            }

            return employees;
        }

        private Employee GetnewEmployeesdetails(int i)
        {
            var employee = new Employee();

            employee.Count = employee.Count + i;
            employee.EmployeeID = 100 + i;
            employee.NationalIDNumber = i + 100;
            employee.ContactID = i;
            employee.Age = employee.Age;
            employee.Experience = employee.Experience;
            employee.Salary = Math.Round(i * 1000.0, 2);
            employee.Empcomplexmodel = new EmployeeComplexModel() { EmpName = employeeName[i] };
            employee.EmpDetails = new EmployeeIndex[1];
            employee.EmpDetails[0] = new EmployeeIndex();
            employee.EmpDetails[0].ID = 100 + i;
            employee.EmpDetails[0].Title = title[i + 10];
            return employee;
        }


        public ObservableCollection<Employee> GetEmployeesDetails(int count)
        {
            ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

            for (int i = 1; i < count; i++)
            {
                employees.Add(GetEmployees(i));
            }

            return employees;
        }

        private Employee GetEmployees(int i)
        {
            var employee = new Employee();
            for (int j = 0; j < 3; j++)
            {
                employee.Count = employee.Count + i;
                employee.EmployeeID = 1000 + i;
                employee.NationalIDNumber = i + 100;
                employee.ContactID = i;
                employee.Age = 20 + i;
                employee.Experience = 1 + i;
                employee.Salary = Math.Round(i * 2000.0, 2);
                employee.Empcomplexmodel = new EmployeeComplexModel() { EmpName = employeeName[0] };
                employee.EmpDetails = new EmployeeIndex[1];
                employee.EmpDetails[0] = new EmployeeIndex();
                employee.EmpDetails[0].ID = 1000 + i;
                employee.EmpDetails[0].Title = title[0];
            }

            return employee;
        }

        string[] title = new string[]
        {
            "Marketing Assistant",
            "Engineering Manager",
            "Senior Tool Designer",
            "Tool Designer",
            "Marketing Manager",
            "Production Supervisor - WC60",
            "Production Technician - WC10",
            "Design Engineer",
            "Production Technician - WC10",
            "Design Engineer",
            "Vice President of Engineering",
            "Production Technician - WC10",
            "Production Supervisor - WC50",
            "Production Technician - WC10",
            "Production Supervisor - WC60",
            "Production Technician - WC10",
            "Production Supervisor - WC60",
            "Production Technician - WC10",
            "Production Technician - WC30",
            "Production Control Manager",
            "Production Technician - WC45",
            "Production Technician - WC45",
            "Production Technician - WC30",
            "Production Supervisor - WC10",
            "Production Technician - WC20",
            "Production Technician - WC40",
            "Network Administrator",
            "Production Technician - WC50",
            "Human Resources Manager",
            "Production Technician - WC40",
            "Production Technician - WC30",
            "Production Technician - WC30",
            "Stocker",
            "Shipping and Receiving Clerk",
            "Production Technician - WC50",
            "Production Technician - WC60",
            "Production Supervisor - WC50",
            "Production Technician - WC20",
            "Production Technician - WC45",
            "Quality Assurance Supervisor",
            "Information Services Manager",
            "Production Technician - WC50",
            "Master Scheduler",
            "Production Technician - WC40",
            "Marketing Specialist",
            "Recruiter",
            "Production Technician - WC50",
            "Maintenance Supervisor",
            "Production Technician - WC30",
        };

        string[] employeeName = new string[]
        {
            "Sean Jacobson",
            "Phyllis Allen",
            "Marvin Allen",
            "Michael Allen",
            "Cecil Allison",
            "Oscar Alpuerto",
            "Sandra Altamirano",
            "Selena Alvarad",
            "Emilio Alvaro",
            "Maxwell Amland",
            "Mae Anderson",
            "Ramona Antrim",
            "Sabria Appelbaum",
            "Hannah Arakawa",
            "Kyley Arbelaez",
            "Tom Johnston",
            "Thomas Armstrong",
            "John Arthur",
            "Chris Ashton",
            "Teresa Atkinson",
            "John Ault",
            "Robert Avalos",
            "Stephen Ayers",
            "Phillip Bacalzo",
            "Gustavo Achong",
            "Catherine Abel",
            "Kim Abercrombie",
            "Humberto Acevedo",
            "Pilar Ackerman",
            "Frances Adams",
            "Margar Smith",
            "Carla Adams",
            "Jay Adams",
            "Ronald Adina",
            "Samuel Agcaoili",
            "James Aguilar",
            "Robert Ahlering",
            "Francois Ferrier",
            "Kim Akers",
            "Lili Alameda",
            "Amy Alberts",
            "Anna Albright",
            "Milton Albury",
            "Paul Alcorn",
            "Gregory Alderson",
            "J. Phillip Alexander",
            "Michelle Alexander",
            "Daniel Blanco",
            "Cory Booth",
            "James Bailey"
        };

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
