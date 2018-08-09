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
                graphics.DrawLine(borderPen, rect.Right, rect.Top, rect.Right, rect.Bottom);
                graphics.DrawLine(borderPen, rect.Left, rect.Bottom, rect.Right, rect.Bottom);
                e.Handled = true;
            }
        }

        private void SfDataGrid_QueryCellStyle(object sender, QueryCellStyleEventArgs e)
        {
            double value = (e.DataRow.RowData as SalesByYear).QS2;

            if (value < 300000 && e.ColumnIndex == 2)
                e.Style.BackColor = Color.LightGoldenrodYellow;

            if (value < 200000 && e.ColumnIndex == 3)
                e.Style.BackColor = Color.LightBlue;

            if (value < 400000 && e.ColumnIndex == 4)
                e.Style.BackColor = Color.RosyBrown;
        }
    }
}
