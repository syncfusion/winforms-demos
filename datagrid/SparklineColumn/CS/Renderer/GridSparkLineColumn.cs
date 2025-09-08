#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SparklineColumn
{
    /// <summary>
    ///  Represents a column that used to display the Sparkline in its cell.
    /// </summary>
    public class GridSparklineColumn : GridColumn
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GridSparklineColumn"/> class.
        /// </summary>
        public GridSparklineColumn()
        {
            SetCellType("Sparkline");
            this.SparklineType = SparkLineType.Line;
        }

        /// <summary>
        /// Gets or sets the type of the sparkline control.
        /// </summary>
        public SparkLineType SparklineType { get; set; }
    }
}
