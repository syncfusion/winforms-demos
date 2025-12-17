#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace GettingStarted
{
    /// <summary>
    /// Represents a column that used to display the Rating in its cell.
    /// </summary>
    public class GridRatingColumn : GridColumn
    {
        /// <summary>
        ///  Specifies the selection color of the rating.
        /// </summary>
        private Color itemSelectionColor = ColorTranslator.FromHtml("#FFB223");

        /// <summary>
        /// Specifies the back color of the rating.
        /// </summary>
        private Color itemBackColor = ColorTranslator.FromHtml("#D8D8D8");

        /// <summary>
        /// Specifies the shapes for the rating.
        /// </summary>
        private Shapes shape = Shapes.Star;

        /// <summary>
        /// Specfies the count of the rating.
        /// </summary>
        private int itemCount = 5;

        /// <summary>
        /// Initializes a new instance of the <see cref="GridRatingColumn"/> class.
        /// </summary>
        public GridRatingColumn()
        {
            SetCellType("Rating");
        }

        /// <summary>
        /// Gets or Sets the selection color of the rating.
        /// </summary>
        public Color ItemSelectionColor
        {
            get
            {
                return itemSelectionColor;
            }

            set
            {
                itemSelectionColor = value;
            }
        }

        /// <summary>
        /// Gets or Sets the back color of the rating.
        /// </summary>
        public Color ItemBackColor
        {
            get
            {
                return itemBackColor;
            }

            set
            {
                itemBackColor = value;
            }
        }

        /// <summary>
        /// Gets or Sets  the shapes for the rating.
        /// </summary>
        public Shapes Shape
        {
            get
            {
                return shape;
            }

            set
            {
                shape = value;
            }
        }

        /// <summary>
        /// Gets or Sets the count of the rating.
        /// </summary>
        public int ItemCount
        {
            get
            {
                return itemCount;
            }

            set
            {
                itemCount = value;
            }
        }
    }
}