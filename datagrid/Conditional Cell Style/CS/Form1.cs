#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Drawing;
using Syncfusion.WinForms.DataGrid.Styles;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.Core;
using Syncfusion.WinForms.Core.Enums;
using System.Windows.Forms;

namespace ConditionalCellStyle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SalesInfo salesInfo = new SalesInfo();
            sfDataGrid.DataSource = salesInfo.YearlySalesDetails;
            sfDataGrid.QueryCellStyle += SfDataGrid_QueryCellStyle;
            (sfDataGrid.Columns["Total"] as GridNumericColumn).FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            sfDataGrid.DrawCell += SfDataGrid_DrawCell;
        }

        private void SfDataGrid_DrawCell(object sender, DrawCellEventArgs e)
        {
            if (this.sfDataGrid.CurrentCell != null && this.sfDataGrid.CurrentCell.IsEditing)
                return;

            if (e.Column.MappingName == "Total" && e.DataRow.RowType == RowType.DefaultRow)
            {
                var value = (e.DataRow.RowData as SalesByYear).Total;
                var graphics = e.Graphics;
                var rect = e.Bounds;
                Rectangle rect1 = new Rectangle(rect.X + 15, rect.Y + 6, rect.Width / 6, rect.Height / 2);
                StringFormat format = new StringFormat();
                if (value > 2500000)
                {
                    ShapesPainter.DrawTriangle(graphics, rect1, TriangleDirection.Up, Brushes.Green, new Pen(Color.Green), true);
                    graphics.DrawString(e.DisplayText, e.Style.Font.GetFont(), new SolidBrush(e.Style.TextColor), rect.X + 40, rect.Y + 5, format);
                }
                else
                {
                    ShapesPainter.DrawTriangle(graphics, rect1, TriangleDirection.Down, Brushes.Red, new Pen(Color.Red), true);
                    graphics.DrawString(e.DisplayText, e.Style.Font.GetFont(), new SolidBrush(e.Style.TextColor), rect.X + 40, rect.Y + 5, format);
                }

                Pen borderPen = new Pen(Brushes.LightGray);
                graphics.DrawLine(borderPen, rect.Right - 1, rect.Top, rect.Right - 1, rect.Bottom);
                graphics.DrawLine(borderPen, rect.Left, rect.Bottom - 1, rect.Right - 1, rect.Bottom - 1);                
                e.Handled = true;
            }
        }

        private void SfDataGrid_QueryCellStyle(object sender, QueryCellStyleEventArgs e)
        {
            double qS2 = (e.DataRow.RowData as SalesByYear).QS2;
            double qS3 = (e.DataRow.RowData as SalesByYear).QS3;
            double qS4 = (e.DataRow.RowData as SalesByYear).QS4;

            if (e.Column.MappingName == "QS2" && qS2 < 300000.00 && qS2 > 100000.00)
                e.Style.BackColor = Color.LightGoldenrodYellow;

            if (e.Column.MappingName == "QS3" && qS3 < 500000.00 && qS3 > 300000.00)
                e.Style.BackColor = Color.LightBlue;

            if (e.Column.MappingName == "QS4" && qS4 < 600000.00 && qS4 > 300000.00)
                e.Style.BackColor = Color.RosyBrown;
        }
    }
}
