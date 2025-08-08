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

namespace RecursiveNestedCollection
{
    public class MyData
    {
        private string field1 = "";
        private string field2 = "";
        private string name;
        private string value;

        public MyData(string name, string value)
        {
            this.name = name;
            this.value = value;
        }

        public string Field1
        {
            get { return field1; }
            set { field1 = value; }
        }

        public string Field2
        {
            get { return field2; }
            set { field2 = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
    }
}
