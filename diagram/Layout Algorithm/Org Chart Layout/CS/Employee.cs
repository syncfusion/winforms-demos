#region Copyright Syncfusion Inc. 2001 - 2012
//
//  Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Collections;


/// <summary>
/// The Employee class represents an employee in the orgranization structure. This class is used only for 
/// extracting the oganization structure data and creating the diagram symbol nodes
/// </summary>
public class Employee_CS
{
    private String strName = String.Empty;
    private String strID = String.Empty;
    private String strManagerID = String.Empty;
    private String strDesignation = String.Empty;
    private String strGender = String.Empty;
    private ArrayList alSubEmployees = new ArrayList();
    private int nRecSubEmployeeCount = 0;
    private String strImageName = String.Empty;
    private String strDOJ = string.Empty;


    public String EmployeeName
    {
        get { return this.strName; }
        set { this.strName = value; }
    }

    public String EmployeeID
    {
        get { return this.strID; }
        set { this.strID = value; }
    }

    public String Designation
    {
        get { return this.strDesignation; }
        set { this.strDesignation = value; }
    }

    public String Gender
    {
        get { return this.strGender; }
        set { this.strGender = value; }
    }

    public String DOJ
    {
        get { return this.strDOJ; }
        set { this.strDOJ = value; }
    }

    public String ManagerID
    {
        get { return this.strManagerID; }
        set { this.strManagerID = value; }
    }

    public string ImageName
    {
        get { return this.strImageName; }
        set { this.strImageName = value; }
    }

    public ArrayList SubEmployees
    {
        get { return this.alSubEmployees; }
    }

    public int RecSubEmployeeCount
    {
        get { return this.nRecSubEmployeeCount; }
        set { this.nRecSubEmployeeCount = value; }
    }

    public Employee_CS()
    {
    }

    public Employee_CS(string name, string id, string Designation)
    {
        this.strName = name;
        this.strID = id;
        this.Designation = Designation;
    }

    public Employee_CS(string name, string id, string Designation, string managerid)
    {
        this.strName = name;
        this.strID = id;
        this.Designation = Designation;
        this.strManagerID = managerid;
    }
}
