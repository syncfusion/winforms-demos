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
using Syncfusion.Windows.Forms.Diagram.DataBinding;
using Syncfusion.Windows.Forms.Diagram;

namespace DiagramORM.Sample
{
    [NodeType(Dimensions = new float[] { 100, 100, 100, 75 }, NodeType = typeof(Rectangle))]
    public class ParentChildClass
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int parentId;

        public int ParentId
        {
            get { return parentId; }
            set { parentId = value; }
        }

        private string name;

        [NodeAttribute(VisibilityType = VisibleType.Label)]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public ParentChildClass(int id, int parentId, string name)
        {
            this.id = id;
            this.parentId = parentId;
            this.name = name;
        }
    }
}
