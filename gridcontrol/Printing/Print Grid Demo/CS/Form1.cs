#region Copyright Syncfusion Inc. 2001 - 2015
//
//  Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.GridHelperClasses;
using System.IO;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace PrintGrid
{
    public partial class Form1 : GridDemoForm
    {
        #region "Constructor"
        public Form1()
        {
            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            this.GridSettings();
			this.gridControl1.ColWidths[0] = (int)DpiAware.LogicalToDeviceUnits(30);
        }
        #endregion

        #region "Sample Grid Settings"

        /// <summary>
        /// Grid control getting started customization.
        /// </summary>
        private void GridSettings()
        {
            InitializeGrid();
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridControl1[0, 1].Text = "Order ID";
            this.gridControl1[0, 2].Text = "Customer ID";
            this.gridControl1[0, 3].Text = "Employee ID";
            this.gridControl1[0, 4].Text = "Order Date";
            this.gridControl1[0, 5].Text = "Required Date";
            this.gridControl1[0, 6].Text = "Shipped Date";
            this.gridControl1[0, 7].Text = "Shipped Via";
            this.gridControl1[0, 8].Text = "Freight";
            this.gridControl1[0, 9].Text = "Ship Name";
            this.gridControl1[0, 10].Text = "Ship Address";
            this.gridControl1[0, 11].Text = "Ship City";
            this.gridControl1[0, 12].Text = "Ship Region";
            this.gridControl1[0, 13].Text = "Ship Postal Code";

            //tab key navigation set as false to move the next control
            this.gridControl1.WantTabKey = false;
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Initialize the properties for the grid
        /// </summary>
        void InitializeGrid()
        {
            //Load Data  
            string xmlName = GetFile("Orders.xml");

            DataSet orderDataSet = new DataSet();

            if (this.ReadXml(orderDataSet, xmlName))
            {
                DataTable orderTable = orderDataSet.Tables[0];
                this.gridControl1.RowCount = 100;
                this.gridControl1.ColCount = orderTable.Columns.Count - 1;

                this.gridControl1.PopulateValues(GridRangeInfo.Cells(1, 1, this.gridControl1.RowCount, this.gridControl1.ColCount), orderDataSet.Tables[0]);
                this.gridControl1.PopulateHeaders(GridRangeInfo.Cells(0, 1, 0, this.gridControl1.ColCount), orderTable);
            }

            for (int col = 4; col < 7; col++)
            {
                this.gridControl1.ColStyles[col].CellType = "MonthCalendar";
                this.gridControl1.ColStyles[col].ShowButtons = GridShowButtons.Hide;
                this.gridControl1.ColStyles[col].CellValueType = typeof(DateTime);
                this.gridControl1.ColStyles[col].Format = "MM/dd/yyyy";
            }

            //Set grid appearance
            this.gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Table());
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid;
        }

        #region GetFile
        /// <summary>
        /// Get xml file to save the vales
        /// </summary>
        private string GetFile(string fileName)
        {
            string dataFileName = @"Common\Data\" + fileName;
            for (int n = 0; n < 12; n++)
            {
                if (System.IO.File.Exists(dataFileName))
                {
                    return new FileInfo(dataFileName).FullName;
                }
                dataFileName = @"..\" + dataFileName;
            }
            return dataFileName;
        }
        #endregion

        #region ReadXml
        /// <summary>
        /// Read file to set the datasource
        /// </summary>
        bool ReadXml(DataSet ds, string xmlFileName)
        {
            // Check both in parent folder and Parent\Data folders.
            string xmlDataFileName = @"Common\Data" + xmlFileName;
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(xmlFileName))
                {
                    ds.ReadXml(xmlFileName);
                    return true;
                }
                if (System.IO.File.Exists(xmlDataFileName))
                {
                    ds.ReadXml(xmlDataFileName);
                    return true;
                }
                xmlFileName = @"..\" + xmlFileName;
                xmlDataFileName = @"..\" + xmlDataFileName;
            }

            return false;
        }
        #endregion

        #endregion

        #region Event Handlers

        #region DrawPrintPreview Headers

        /// <summary>
        /// Used to draw the Print Preview Header
        /// </summary>
        void pd_DrawGridPrintHeader(object sender, Syncfusion.GridHelperClasses.GridPrintHeaderFooterTemplateArgs e)
        {
            // Get the rectangle area to draw
            Rectangle header = e.DrawRectangle;

            //IMAGE
            //scale the image
            SizeF imageSize = new SizeF(header.Width / 3, header.Height * 0.8f);
            //Locating the logo on the right corner of the Drawing Surface
            PointF imageLocation = new PointF(e.DrawRectangle.Width - imageSize.Width - 20, header.Y + 5);
            Bitmap img = new Bitmap(GetIconFile(@"Common\Images\Grid\PDF_logo\logo.png"));
            //Draw the image in the Header.
            e.Graphics.DrawImage(img, new RectangleF(imageLocation, imageSize));

            //TITLE
            Color activeColor = Color.FromArgb(44, 71, 120);
            SolidBrush brush = new SolidBrush(activeColor);
            Font font = new Font("Segoe UI", 20, FontStyle.Bold);
            //Set formattings for the text
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Near;
            format.LineAlignment = StringAlignment.Near;
            //Draw the title
            e.Graphics.DrawString("Customers Order Report", font, brush, new RectangleF(header.Location.X + 20, header.Location.Y + 20, e.DrawRectangle.Width, e.DrawRectangle.Height), format);

            ///BORDER LINES - Draw some lines in the header
            Pen pen = new Pen(Color.DarkBlue, 0.8f);
            e.Graphics.DrawLine(pen, new Point(header.Left, header.Top + 2), new Point(header.Right, header.Top + 2));
            e.Graphics.DrawLine(pen, new Point(header.Left, header.Top + 5), new Point(header.Right, header.Top + 5));
            e.Graphics.DrawLine(pen, new Point(header.Left, header.Bottom - 8), new Point(header.Right, header.Bottom - 8));
            e.Graphics.DrawLine(pen, new Point(header.Left, header.Bottom - 5), new Point(header.Right, header.Bottom - 5));

            //Dispose drawing resources
            font.Dispose();
            format.Dispose();
            pen.Dispose();
        }
        #endregion

        #region DrawGridPrintFooter
        /// <summary>
        /// Draw the PrintPReview Footer
        /// </summary>
        void pd_DrawGridPrintFooter(object sender, Syncfusion.GridHelperClasses.GridPrintHeaderFooterTemplateArgs e)
        {
            //Get the rectangle area to draw
            Rectangle footer = e.DrawRectangle;

            //Draw copy right
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            Font font = new Font("Segoe UI", 8);
            SolidBrush brush = new SolidBrush(Color.Red);
            e.Graphics.DrawString("@copyright", font, brush, GridUtil.CenterPoint(footer), format);

            //Draw page number
            format.LineAlignment = StringAlignment.Far;
            format.Alignment = StringAlignment.Far;
            e.Graphics.DrawString(string.Format("page {0} of {1}", e.PageNumber, e.PageCount), font, brush, new Point(footer.Right - 100, footer.Bottom - 20), format);

            //Dispose resources
            format.Dispose();
            font.Dispose();
            brush.Dispose();
        }
        #endregion

        #region PrintPreview

        /// <summary>
        /// Preview the content of the grid to be print
        /// </summary>
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                this.gridControl1.Model.Properties.PrintFrame = false;

                Syncfusion.GridHelperClasses.GridPrintDocumentAdv pd = new Syncfusion.GridHelperClasses.GridPrintDocumentAdv(this.gridControl1);
                pd.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(25, 25, 25, 25);

                if (this.ShowHeaderFooter.Checked)
                {
                    pd.HeaderHeight = 70;
                    pd.FooterHeight = 50;
                }
                else
                {
                    pd.HeaderHeight = 0;
                    pd.HeaderHeight = 0;
                }

                pd.ScaleColumnsToFitPage = this.ScaleColumnsToFit.Checked;

                pd.DrawGridPrintHeader += new Syncfusion.GridHelperClasses.GridPrintDocumentAdv.DrawGridHeaderFooterEventHandler(pd_DrawGridPrintHeader);
                pd.DrawGridPrintFooter += new Syncfusion.GridHelperClasses.GridPrintDocumentAdv.DrawGridHeaderFooterEventHandler(pd_DrawGridPrintFooter);

                PrintPreviewDialog previewDialog = new PrintPreviewDialog();
                previewDialog.Document = pd;
                previewDialog.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while print preview" + ex.ToString());
            }
        }

        #endregion

        #endregion
    }
}
