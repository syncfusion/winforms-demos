using System;
using System.Collections.Generic;

using System.Web;

/// <summary>
/// Summary description for ClassList
/// </summary>

[Serializable]
public class ClassList
{
    #region class members
    private string className = string.Empty;
    private string classType = string.Empty;
    private string objectType = string.Empty;
    private List<PropertyList> propertyList = new List<PropertyList>();
    private List<MethodList> methodList = new List<MethodList>();
    #endregion

    #region ClassProperties
    public string ClassName 
    {
        get { return className; }
        set { className = value; }
    }
    public string ClassType 
    {
        get { return classType; }
        set { classType = value; }
    }
    public string ObjectType
    {
        get { return objectType; }
        set { objectType = value; }
    }
    

    public List<PropertyList> PropertyList
    {
        get { return propertyList; }
        set { propertyList = value; }
    }

    public List<MethodList> MethodList
    {
        get { return methodList; }
        set { methodList = value; }
    }

    #endregion
}

public class PropertyList
{
    private string propertyName = string.Empty;
    private PropertyType propertyType = PropertyType.Internal;
    public string PropertyName
    {
        get { return propertyName; }
        set { propertyName = value; }
    }

    public PropertyType PropertyType
    {
        get { return propertyType; }
        set { propertyType = value; }
    }
}

public enum PropertyType
{
    Internal,
    Public,
    Protected,
    Private
}

public enum MethodType
{
    Internal, 
    Protected, 
    Public, 
    Private
        
}

public class MethodList
{
    private string methodName = string.Empty;
    private MethodType methodType = MethodType.Internal;

    public string MethodName
    {
        get { return methodName; }
        set { methodName = value; }
    }

    public MethodType MethodType
    {
        get { return methodType; }
        set { methodType = value; }
    }
}

