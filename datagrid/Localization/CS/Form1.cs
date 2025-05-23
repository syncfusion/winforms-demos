#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Localization
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor
        public Form1()
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("fr-FR");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr-FR");
            InitializeComponent();
            this.GridSettings();
            sfDataGrid1.DataSource = new OrderInfoCollection().OrdersListDetails;
            (sfDataGrid1.Columns[5] as GridNumericColumn).FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
        }

        #endregion

        #region Grid Settings

        /// <summary>
        /// Grid Settings for better Look and Feel.
        /// </summary>
        private void GridSettings()
        {
            ArrayList list = new ArrayList();
            list.Add("AllColumns");
            foreach (GridColumn column in sfDataGrid1.Columns)
            {
                list.Add(column.MappingName);
            }

            textFilter.Add("Contains");
            textFilter.Add("StartsWith");
            textFilter.Add("EndsWith");

            numberFilter.Add("Equals");
            numberFilter.Add("LessThan");
            numberFilter.Add("GreaterThan");
            numberFilter.Add("NotEquals");

            textColumns.Add("CustomerID");
            textColumns.Add("ProductName");
            textColumns.Add("ShipCountry");
        }

        #endregion

        ArrayList numberFilter = new ArrayList();
        ArrayList textFilter = new ArrayList();
        ArrayList textColumns = new ArrayList();
    }
}
