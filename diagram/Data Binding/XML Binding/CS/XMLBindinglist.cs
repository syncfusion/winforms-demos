#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Web;
using System.Collections;

/// <summary>
/// Summary description for XMLBinding
/// </summary>
public class XMLBindinglist
{
	private String strName = String.Empty;
    private String strID = String.Empty;
    private String strManagerID = String.Empty;
    private String strDesignation = String.Empty;
    private ArrayList alSubEmployees = new ArrayList();

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

    
    public String ManagerID
    {
        get { return this.strManagerID; }
        set { this.strManagerID = value; }
    }

    public ArrayList SubEmployees
    {
        get { return this.alSubEmployees; }
    }

    public XMLBindinglist()
    {
    }

    public XMLBindinglist(string name, string id, string Designation)
    {
        this.strName = name;
        this.strID = id;
        this.Designation = Designation;
    }

    public XMLBindinglist(string name, string id, string Designation, string managerid)
    {
        this.strName = name;
        this.strID = id;
        this.Designation = Designation;
        this.strManagerID = managerid;
    }
}