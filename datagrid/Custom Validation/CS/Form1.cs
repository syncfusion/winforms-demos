#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.DataGrid.Styles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomValidation
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();          
            OrderInfoRepository collection = new OrderInfoRepository();
            sfDataGrid1.DataSource = collection.GetListOrdersDetails(1000);                            
            this.sfDataGrid1.RowValidating += SfDataGrid1_RowValidating;
            this.sfDataGrid1.CurrentCellValidating += SfDataGrid1_CurrentCellValidating;                  
        }  

        /// <summary>
        /// Occurs when curent cell is validating.
        /// </summary>
        private void SfDataGrid1_CurrentCellValidating(object sender, CurrentCellValidatingEventArgs args)
        {
            if (args.Column.MappingName == "Discount" && Convert.ToDouble(args.NewValue) > 40)
            {
                args.ErrorMessage = "Discount should not exceed 40 percent.";
                args.IsValid = false;
            }
        }

        /// <summary>
        /// Occurs when the row is validating.
        /// </summary>
        private void SfDataGrid1_RowValidating(object sender, RowValidatingEventArgs args)
        {
            var data = args.DataRow.RowData as OrderInfo;
            double total = data.Freight + data.Expense;
          
            if (total < 3000) 
            {
                args.ErrorMessage = "Sum of Expense and Freight should be a minimum of 3000 to be eligible for Discount.";
                args.IsValid = false;
            }
        }      
    }
}
