#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
# region Directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Syncfusion.Windows.Forms.Grid.Grouping;

#endregion

namespace LinqGroupBy
{
    public abstract class SampleQuery
    {
        # region Public Method

        public abstract void InitializeGrid(GridGroupingControl grid, NorthwindwithImage db);

        #endregion
    }
}
