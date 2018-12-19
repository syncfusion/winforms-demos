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
public class Employee
{
    private String strName = String.Empty;
    private String strID = String.Empty;
    private String strPrimaryKeyID = String.Empty;
    private String strForeignKeyID = String.Empty;
    private String strGender = String.Empty;
    private ArrayList alSubEmployees = new ArrayList();
    private int nRecSubEmployeeCount = 0;
    private String strImageName = String.Empty;
    private ArrayList strColumns = new ArrayList();


    public String TableName
    {
        get { return this.strName; }
        set { this.strName = value; }
    }

    public String EmployeeID
    {
        get { return this.strID; }
        set { this.strID = value; }
    }

    public String PrimaryKeyID
    {
        get { return this.strPrimaryKeyID; }
        set { this.strPrimaryKeyID = value; }
    }

    public String Gender
    {
        get { return this.strGender; }
        set { this.strGender = value; }
    }

    public ArrayList Coloumns
    {
        get { return this.strColumns; }
        set { this.strColumns = value; }
    }

    public String ForeignKeyID
    {
        get { return this.strForeignKeyID; }
        set { this.strForeignKeyID = value; }
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

    public Employee()
    {
    }

    public Employee(string name, string id, ArrayList Coloumn)
    {
        this.strName = name;
        this.strID = id;
        this.strColumns = Coloumn;
    }

    public Employee(string name, string id, ArrayList Coloumn, string primaryKey,string foreignKey)
    {
        this.strName = name;
        this.strID = id;
        this.strColumns = Coloumn;
        this.strPrimaryKeyID = primaryKey;
        this.strForeignKeyID = foreignKey;
    }
}
