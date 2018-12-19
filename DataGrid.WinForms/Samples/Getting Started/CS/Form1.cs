using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid.Styles;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Enums;
using System.Collections.ObjectModel;
using System;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Events;
using System.Drawing;
using System.Globalization;
using Syncfusion.WinForms.Input.Enums;

namespace GettingStarted
{
    public partial class Form1 : Form
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();
            var data = new EmployeeCollection();
            sfDataGrid.DataSource = data.EmployeeDetails;

            sfDataGrid.QueryImageCellStyle += SfDataGrid_QueryImageCellStyle;
            sfDataGrid.QueryCellStyle += SfDataGrid_QueryCellStyle;
        }

        private void SfDataGrid_QueryCellStyle(object sender, QueryCellStyleEventArgs e)
        {
            if (e.Column.MappingName == "Status")
            {
                if (e.DisplayText.ToString() == "Active")
                    e.Style.TextColor = Color.Green;
                else
                    e.Style.TextColor = Color.Red;
            }
        }

        private void SfDataGrid_QueryImageCellStyle(object sender, QueryImageCellStyleEventArgs e)
        {
            var employee = (Employee)e.Record;

            if (e.Column.MappingName == "Rating")
            {
                if (employee.Rating == 1)
                    e.Image = (Image.FromFile(@"..\..\Images\Rating1.png"));
                else if (employee.Rating == 2)
                    e.Image = (Image.FromFile(@"..\..\Images\Rating2.png"));
                else if (employee.Rating == 3)
                    e.Image = (Image.FromFile(@"..\..\Images\Rating3.png"));
                else if (employee.Rating == 4)
                    e.Image = (Image.FromFile(@"..\..\Images\Rating4.png"));
                else if (employee.Rating == 5)
                    e.Image = (Image.FromFile(@"..\..\Images\Rating5.png"));
                e.DisplayText = "";
            }
            else if (e.Column.MappingName == "Trustworthiness")
            {
                if (employee.Trustworthiness.ToString() == "Sufficient")
                {
                    e.Image = (Image.FromFile(@"..\..\Images\Sufficient.png"));
                    e.DisplayText = (e.Record as Employee).Trustworthiness.ToString();
                    e.TextImageRelation = TextImageRelation.ImageBeforeText;
                }
                else if (employee.Trustworthiness.ToString() == "InSufficient")
                {
                    e.Image = (Image.FromFile(@"..\..\Images\InSufficient.png"));
                    e.DisplayText = (e.Record as Employee).Trustworthiness.ToString();
                    e.TextImageRelation = TextImageRelation.ImageBeforeText;
                }
                else if (employee.Trustworthiness.ToString() == "Perfect")
                {
                    e.Image = (Image.FromFile(@"..\..\Images\Perfect.png"));
                    e.DisplayText = (e.Record as Employee).Trustworthiness.ToString();
                    e.TextImageRelation = TextImageRelation.ImageBeforeText;
                }
            }
            else if (e.Column.MappingName == "EmployeeName")
            {
                e.Image = employee.Gender == "1" ? (Image.FromFile(@"..\..\Images\Male.png")) : (Image.FromFile(@"..\..\Images\Female.png"));
                e.DisplayText = (e.Record as Employee).EmployeeName.ToString();
                e.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
            else
            {
                e.Image = (Image.FromFile(@"..\..\Images\location.png"));
                e.DisplayText = (e.Record as Employee).Location.ToString();
                e.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
        }
        #endregion
    }
}