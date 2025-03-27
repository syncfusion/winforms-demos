#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.DataGrid.Styles;
using System.Drawing;
using System.Windows.Forms;

namespace ConditionalRowStyle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var employeeInfoRespository = new EmployeeInfoRespository();
            sfDataGrid.DataSource = employeeInfoRespository.EmployeeList;
            sfDataGrid.QueryRowStyle += SfDataGrid_QueryRowStyle1;
        }

        private void SfDataGrid_QueryRowStyle1(object sender, QueryRowStyleEventArgs e)
        {
            if (e.RowData == null || e.RowType != RowType.DefaultRow)
                return;
            int rating = (e.RowData as Employees).Rating;
            if (rating == 5)
            {
                e.Style.BackColor = Color.Transparent;
            }
            else if (rating < 5)
            {
                var i = ((double)rating * 2 / 10) * 255;
                var color = ColorTranslator.FromHtml("#FFFFD356");
                e.Style.BackColor = Color.FromArgb((int)i, color);
            }
            else
            {
                rating = rating - 5;
                var i = ((double)rating * 2 / 10) * 255;
                var color = ColorTranslator.FromHtml("#FF70FCA0");
                e.Style.BackColor = Color.FromArgb((int)i, color);
            }
        }
    }
}
