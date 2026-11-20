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
