#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Interactivity;

namespace SparklineColumn
{
    /// <summary>
    /// Represents the class that process the selection operation in SfDataGrid.
    /// </summary>
    public class CustomSelectionController : RowSelectionController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomSelectionController"/> class.
        /// </summary>
        /// <param name="dataGrid">The DataGrid.</param>
        public CustomSelectionController(SfDataGrid dataGrid)
            : base(dataGrid)
        {
        }

        /// <summary>
        /// Process the key operations for SfDataGrid.
        /// </summary>
        /// <param name="e">that contains the event data.</param>
        public new void HandleKeyOperations(KeyEventArgs e)
        {
            base.HandleKeyOperations(e);
        }
    }
}