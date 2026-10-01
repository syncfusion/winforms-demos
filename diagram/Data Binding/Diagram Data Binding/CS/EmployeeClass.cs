#region Copyright Syncfusion Inc. 2001 - 2012
// Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Diagram;
using Syncfusion.Windows.Forms.Diagram.DataBinding;

namespace DiagramORM.Sample
{
    [NodeType(Dimensions = new float[] { 100, 100, 100, 65 }, NodeType = typeof(Rectangle))]
    public class EmployeeClass
    {
        private string empName;
        [NodeAttribute(VisibilityType = VisibleType.Label)]
        public string EmployeeName
        {
            get
            {
                return empName;
            }
            set
            {
                empName = value;
            }
        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int managerId;
        public int ManagerId
        {
            get { return managerId; }
            set { managerId = value; }
        }

        public EmployeeClass(int id, int managerId, string name)
        {
            this.id = id;
            this.managerId = managerId;
            this.empName = name;
        }

    }
}
