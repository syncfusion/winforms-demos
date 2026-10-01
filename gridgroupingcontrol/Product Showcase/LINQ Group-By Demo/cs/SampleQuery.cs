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
