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
