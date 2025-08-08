#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace RecursiveNestedCollection
{
    [TypeDescriptionProviderAttribute(typeof(BaseClassDescriptorProvider))]
    public class BaseClass
    {
        private Dictionary<string, List<BaseClass>> childTables = new Dictionary<string, List<BaseClass>>();
        private int id;
        private BaseClass parent;
        private Dictionary<string, MyData> data = new Dictionary<string, MyData>();

        public int fieldInt = 0;
        public string fieldStr = ""; 

        private static int nextID = 0;
        public static int NextID
        {
            get
            {
                return nextID++;
            }
        }

        public BaseClass(BaseClass parent)
        {
            id = NextID;
            this.parent = parent;
        }

        public Dictionary<string, List<BaseClass>> ChildTables
        {
            get { return childTables; }
        }

        public int ID
        {
            get { return id; }
        }

        public Dictionary<string, MyData> Data
        {
            get { return data; }
        }
    }

    public class FirstClass : BaseClass
    {
        public FirstClass(BaseClass parent, int fieldInt, string fieldStr)
            : base(parent)
        {
            this.fieldInt = fieldInt;
            this.fieldStr = fieldStr;

            this.Data.Add("Property1", new MyData("Data_FieldInt", Property1.ToString()));
            this.Data.Add("Property2", new MyData("Data_FieldStr", Property2));
        }

        public int Property1
        {
            get { return fieldInt; }
        }

        public string Property2
        {
            get { return fieldStr; }
        }
        
    }

    public class SecondClass : BaseClass
    {
        public SecondClass(BaseClass parent, int fieldInt, string fieldStr)
            : base(parent)
        {
            this.fieldInt = fieldInt;
            this.fieldStr = fieldStr;

            this.Data.Add("Property1", new MyData("Data_FieldOne", Property1));
            this.Data.Add("Property2", new MyData("Data_FieldTwo", Property2.ToString()));
            this.Data.Add("Property3", new MyData("Data_FieldThree", Property3));
        }

        public string Property1
        {
            get { return fieldInt.ToString(); }
        }

        public double Property2
        {
            get { return (double)fieldInt * 1.01234; }
        }

        public string Property3
        {
            get { return fieldStr; }
        }
    }
}
