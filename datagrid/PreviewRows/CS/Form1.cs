#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid.Styles;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Enums;
using System.Drawing;
using Syncfusion.Data;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.Windows.Forms;
using System;

namespace PreviewRows
{   
    public partial class Form1 : Form
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the Form.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            var data = new EmployeeDetails();
            sfDataGrid.DataSource = data.EmployeeInfoCollection;    

            //Enable preview row for the SfDataGrid.
            sfDataGrid.ShowPreviewRow = true;
            sfDataGrid.PreviewRowMappingName = "FirstName";
            sfDataGrid.PreviewRowHeight = (int)DpiAware.LogicalToDeviceUnits(114.0f);
            sfDataGrid.ExpandAllPreviewRow();
            sfDataGrid.DrawPreviewRow += OnDrawPreviewRow;
            sfDataGrid.CurrentCellEndEdit += SfDataGrid_CurrentCellEndEdit;
        }

        #endregion 

        #region Method

        private void SfDataGrid_CurrentCellEndEdit(object sender, CurrentCellEndEditEventArgs e)
        {
            this.sfDataGrid.TableControl.Invalidate(this.sfDataGrid.TableControl.GetRowRectangle(e.DataRow.Index + 1, false));
        }

        /// <summary>
        /// Draws the preview row.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">An <see cref="DrawPreviewRowEventArgs"/> that contains the event data.</param>
        private void OnDrawPreviewRow(object sender, DrawPreviewRowEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Text))
            {
                var clipbounds = e.Graphics.ClipBounds;
                e.Graphics.SetClip(e.Bounds);

                var font = e.Style.Font.GetFont();
                var record = (e.Record as RecordEntry).Data as EmployeeInfo;
                var headerBrush = new SolidBrush(e.Style.TextColor);
                var subItemsFont = new Font("Segoe UI", 8f, FontStyle.Bold);
                var textBrush = new SolidBrush(e.Style.TextColor);

                var rect = new Rectangle(e.Bounds.X + (int)DpiAware.LogicalToDeviceUnits(50f), e.Bounds.Y + (int)DpiAware.LogicalToDeviceUnits(12f), (int)DpiAware.LogicalToDeviceUnits(90f), (int)DpiAware.LogicalToDeviceUnits(90f));

                try
                {
#if NETCORE
                var image = Image.FromFile("../../../Images/" + e.Text + ".png");
#else
                var image = Image.FromFile(@"..\..\Images\" + e.Text + ".png");
#endif
                e.Graphics.DrawImage(image, rect);
                }
                catch (Exception e1)
                {

                }

                int textWidth1 = (int)e.Graphics.MeasureString("First Name", e.Style.Font.GetFont()).Width +5;
                int textWidth2 = (int)e.Graphics.MeasureString("Last Name", e.Style.Font.GetFont()).Width + 5;
                int textWidth3 = (int)e.Graphics.MeasureString("Title", e.Style.Font.GetFont()).Width + 5;
                int textWidth4 = (int)e.Graphics.MeasureString("Address", e.Style.Font.GetFont()).Width + 5;
                int textWidth5 = (int)e.Graphics.MeasureString("Postal Code", e.Style.Font.GetFont()).Width + 5;
                int textWidth6 = (int)e.Graphics.MeasureString("City", e.Style.Font.GetFont()).Width + 5;
                int textWidth7 = (int)e.Graphics.MeasureString("Phone", e.Style.Font.GetFont()).Width + 5;
                int textWidth8 = (int)e.Graphics.MeasureString("HireDate", e.Style.Font.GetFont()).Width + 5;

                e.Graphics.DrawString("First Name", subItemsFont, headerBrush, new PointF(rect.Right + (int)DpiAware.LogicalToDeviceUnits(50f), rect.Y + (int)DpiAware.LogicalToDeviceUnits(7f)));
                e.Graphics.DrawString("Last Name", subItemsFont, headerBrush, new PointF(rect.Right + (int)DpiAware.LogicalToDeviceUnits(50f), rect.Y + (int)DpiAware.LogicalToDeviceUnits(27f)));
                e.Graphics.DrawString("Title", subItemsFont, headerBrush, new PointF(rect.Right + (int)DpiAware.LogicalToDeviceUnits(50f), rect.Y + (int)DpiAware.LogicalToDeviceUnits(47f)));
                e.Graphics.DrawString("Address", subItemsFont, headerBrush, new PointF(rect.Right + (int)DpiAware.LogicalToDeviceUnits(50f), rect.Y + (int)DpiAware.LogicalToDeviceUnits(67f)));

                e.Graphics.DrawString(":", subItemsFont, headerBrush, new PointF(rect.Right + (int)DpiAware.LogicalToDeviceUnits(50f) + textWidth1, rect.Y + (int)DpiAware.LogicalToDeviceUnits(7f)));
                e.Graphics.DrawString(":", subItemsFont, headerBrush, new PointF(rect.Right + (int)DpiAware.LogicalToDeviceUnits(50f) + textWidth2, rect.Y + (int)DpiAware.LogicalToDeviceUnits(27f)));
                e.Graphics.DrawString(":", subItemsFont, headerBrush, new PointF(rect.Right + (int)DpiAware.LogicalToDeviceUnits(50f) + textWidth3, rect.Y + (int)DpiAware.LogicalToDeviceUnits(47f)));
                e.Graphics.DrawString(":", subItemsFont, headerBrush, new PointF(rect.Right + (int)DpiAware.LogicalToDeviceUnits(50f) + textWidth4, rect.Y + (int)DpiAware.LogicalToDeviceUnits(67f)));


                e.Graphics.DrawString(record.FirstName, font, textBrush, new PointF(rect.Right + textWidth1 + (int)DpiAware.LogicalToDeviceUnits(60f), rect.Y + (int)DpiAware.LogicalToDeviceUnits(7f)));
                e.Graphics.DrawString(record.LastName.ToString(), font, textBrush, new PointF(rect.Right + textWidth2 + (int)DpiAware.LogicalToDeviceUnits(60f), rect.Y + (int)DpiAware.LogicalToDeviceUnits(27f)));
                e.Graphics.DrawString(record.Title.ToString(), font, textBrush, new PointF(rect.Right + textWidth3 + (int)DpiAware.LogicalToDeviceUnits(60f), rect.Y + (int)DpiAware.LogicalToDeviceUnits(47f)));
                e.Graphics.DrawString(record.Address, font, textBrush, new PointF(rect.Right + textWidth4 + (int)DpiAware.LogicalToDeviceUnits(60f), rect.Y + (int)DpiAware.LogicalToDeviceUnits(67f)));

                e.Graphics.DrawString("\tPostal Code", subItemsFont, headerBrush, new PointF(rect.Right + (int)DpiAware.LogicalToDeviceUnits(300f), rect.Y + (int)DpiAware.LogicalToDeviceUnits(7f)));
                e.Graphics.DrawString("\tCity", subItemsFont, headerBrush, new PointF(rect.Right + (int)DpiAware.LogicalToDeviceUnits(300f), rect.Y + (int)DpiAware.LogicalToDeviceUnits(27f)));
                e.Graphics.DrawString("\tPhone", subItemsFont, headerBrush, new PointF(rect.Right + (int)DpiAware.LogicalToDeviceUnits(300f), rect.Y + (int)DpiAware.LogicalToDeviceUnits(47f)));
                e.Graphics.DrawString("\tHire Date", subItemsFont, headerBrush, new PointF(rect.Right + (int)DpiAware.LogicalToDeviceUnits(300f), rect.Y + (int)DpiAware.LogicalToDeviceUnits(67f)));

                e.Graphics.DrawString(":", subItemsFont, headerBrush, new PointF(rect.Right + (int)DpiAware.LogicalToDeviceUnits(340f) + textWidth5, rect.Y + (int)DpiAware.LogicalToDeviceUnits(7f)));
                e.Graphics.DrawString(":", subItemsFont, headerBrush, new PointF(rect.Right + (int)DpiAware.LogicalToDeviceUnits(340f) + textWidth6, rect.Y + (int)DpiAware.LogicalToDeviceUnits(27f)));
                e.Graphics.DrawString(":", subItemsFont, headerBrush, new PointF(rect.Right + (int)DpiAware.LogicalToDeviceUnits(340f) + textWidth7, rect.Y + (int)DpiAware.LogicalToDeviceUnits(47f)));
                e.Graphics.DrawString(":", subItemsFont, headerBrush, new PointF(rect.Right + (int)DpiAware.LogicalToDeviceUnits(340f) + textWidth8, rect.Y + (int)DpiAware.LogicalToDeviceUnits(67f)));

                e.Graphics.DrawString(record.PostalCode, font, textBrush, new PointF(rect.Right + (int)DpiAware.LogicalToDeviceUnits(350f) + textWidth5, rect.Y + (int)DpiAware.LogicalToDeviceUnits(7f)));
                e.Graphics.DrawString(record.City, font, textBrush, new PointF(rect.Right + (int)DpiAware.LogicalToDeviceUnits(350f) + textWidth6, rect.Y + (int)DpiAware.LogicalToDeviceUnits(27f)));
                e.Graphics.DrawString( record.Phone, font, textBrush, new PointF(rect.Right + (int)DpiAware.LogicalToDeviceUnits(350f) + textWidth7, rect.Y + (int)DpiAware.LogicalToDeviceUnits(47f)));
                e.Graphics.DrawString(record.HireDate.ToString(), font, textBrush, new PointF(rect.Right + (int)DpiAware.LogicalToDeviceUnits(350f) + textWidth8, rect.Y + (int)DpiAware.LogicalToDeviceUnits(67f)));

                e.Graphics.DrawLine(new Pen(e.Style.Borders.Bottom.Color), new Point(e.Bounds.Left, e.Bounds.Bottom - 1), new Point(e.Bounds.Right, e.Bounds.Bottom - 1));
                e.Graphics.DrawLine(new Pen(e.Style.Borders.Right.Color), new Point(e.Bounds.Right - 1, e.Bounds.Top), new Point(e.Bounds.Right - 1, e.Bounds.Bottom - 1));
                e.Graphics.SetClip(clipbounds);
                e.Handled = true;
            }
        }

        #endregion
    }
}
