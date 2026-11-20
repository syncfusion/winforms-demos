#region Copyright Syncfusion Inc. 2001 - 2007
//
//  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Text;
using System.Diagnostics;

using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;

namespace RecursiveNestedCollection
{
	/// <summary>
	/// GroupingEngineFactory
	/// </summary>
	public class GroupingEngineFactory : GridEngineFactoryBase
	{
		// Add this line in your forms ctor:
		// GroupingEngineFactory provides a modified GridChildTable that adds an extra section
		// GridEngineFactory.Factory = new GroupingEngineFactory();

		public override GridEngine CreateEngine()
		{
			return new GroupingEngine();
		}
	}

	public class GroupingEngine : GridEngine
	{
       
        public override ChildTable CreateChildTable(Element parent)
        {
            return new GroupingChildTable(parent);
        }
	}

     

    /// <summary>
    /// Derived GridChildTable that gets hidden when it has no records to show.
    /// </summary>
    public class GroupingChildTable : GridChildTable, IGridGroupOptionsSource
    {
        public GroupingChildTable(Element parent)
            : base(parent)
        {
        }

        /// <override/>
        public override int GetVisibleCount()
        {
            if (this.Details == null || this.Records.Count == 0 /*|| Name=="ChildTables"*/)
                return 0;

            return base.GetVisibleCount();
        }

        /// <override/>
        public override double GetYAmountCount()
        {
            if (this.Details == null || this.Records.Count == 0 /*|| Name == "ChildTables"*/)
                return 0;

            return base.GetYAmountCount();
        }

        /// <override/>
        public override double GetVisibleCustomCount()
        {
            if (this.Details == null || this.Records.Count == 0 /*|| Name == "ChildTables"*/)
                return 0;

            return base.GetVisibleCustomCount();
        }
    }
}
