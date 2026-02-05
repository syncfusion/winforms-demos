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
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Grouping;
using Syncfusion.GridHelperClasses;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace PrintGroupingGrid
{
    public partial class Form1 : GridDemoForm
    {
        #region "Constructor"
        // <summary>
        /// Summary description for Form1.
        /// </summary>
        public Form1()
        {
            #region Intialization Settings
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            InitializeGrid();
            this.GridSettings();
            #endregion
        }
        #endregion

        #region "Sample Grid Settings"

        /// <summary>
        /// GridGrouping control getting started customization.
        /// </summary>
        private void GridSettings()
        {
            //used to set multiextended selection mode in gridgrouping control. 
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
			this.gridGroupingControl1.TableControl.DpiAware = true;

            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.propertyGrid1.SelectedObject = this.gridGroupingControl1;            
            this.MetroColor = System.Drawing.Color.Transparent;
            
            //GGC options
            this.gridGroupingControl1.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.ThemesEnabled = true;
            this.gridGroupingControl1.TableDescriptor.Columns["OrderID"].HeaderText = "Order ID";
            this.gridGroupingControl1.TableDescriptor.Columns["CustomerID"].HeaderText = "Customer ID";
            this.gridGroupingControl1.TableDescriptor.Columns["EmployeeID"].HeaderText = "Employee ID";
            this.gridGroupingControl1.TableDescriptor.Columns["OrderDate"].HeaderText = "Order Date";
            this.gridGroupingControl1.TableDescriptor.Columns["RequiredDate"].HeaderText = "Required Date";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipName"].HeaderText = "Ship Name";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipAddress"].HeaderText = "Ship Address";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipVia"].HeaderText = "Ship Via";
            this.gridGroupingControl1.TableDescriptor.Columns["ShippedDate"].HeaderText = "Shipped Date";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipCountry"].HeaderText = "Ship Country";

            //used to set GridCaptionRowHeight.
            this.gridGroupingControl1.Table.DefaultCaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(25);
            this.gridGroupingControl1.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(35);
            this.gridGroupingControl1.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22); 

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;
        }

        #endregion

        #region " Xml"
       
        //read the xml file
        bool ReadXml(DataSet ds, string xmlFileName)
        {
            // Check both in parent folder and Parent\Data folders.
            string xmlDataFileName = @"Common\Data\" + xmlFileName;
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

        #region "Sample Customization"

        #region "Initialize Grid"

        //load the xml file
        void InitializeGrid()
        {
            //Load Data  
            string xmlName = "Orders.xml";

            DataSet orderDataSet = new DataSet();

            if (this.ReadXml(orderDataSet, xmlName))
            {
                DataTable orderTable = orderDataSet.Tables[0];
                int recordCount = orderTable.Rows.Count;

                //Load only 150 records
                for (int row = 0; row < recordCount - 150; row++)
                {
                    orderTable.Rows.RemoveAt(0);
                }

                this.gridGroupingControl1.DataSource = orderTable;
            }

            for (int col = 3; col < 6; col++)
            {
                //DateTime columns
                this.gridGroupingControl1.TableDescriptor.Columns[col].Appearance.AnyRecordFieldCell.CellValueType = typeof(DateTime);
                this.gridGroupingControl1.TableDescriptor.Columns[col].Appearance.AnyRecordFieldCell.Format = "mm/dd/yyyy";

                //Remove some columns
                this.gridGroupingControl1.TableDescriptor.VisibleColumns.RemoveAt(10);
            }
           
        }
        #endregion

        #region "Event Handlers"

        //Used to create own header
        void pd_DrawGridPrintHeader(object sender, Syncfusion.GridHelperClasses.GridPrintHeaderFooterTemplateArgs e)
        {
            // Get the rectangle area to draw
            Rectangle header = e.DrawRectangle;

            //IMAGE
            //scale the image
            SizeF imageSize = new SizeF(header.Width / 3, header.Height * 0.8f);
            //Locating the logo on the right corner of the Drawing Surface
            PointF imageLocation = new PointF(e.DrawRectangle.Width - imageSize.Width - 20, header.Y + 5);
#if  NETCOREAPP
            Bitmap img = new Bitmap(@"..\..\..\Data\logo.png");
#else
            Bitmap img = new Bitmap(@"..\..\Data\logo.png");
#endif
            //Draw the image in the Header.
            e.Graphics.DrawImage(img, new RectangleF(imageLocation, imageSize));

            //TITLE
            Color activeColor = Color.FromArgb(44, 71, 120);
            SolidBrush brush = new SolidBrush(activeColor);
            Font font = new Font("Helvetica", 20, FontStyle.Bold);
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

        //Used to create own footer
        void pd_DrawGridPrintFooter(object sender, Syncfusion.GridHelperClasses.GridPrintHeaderFooterTemplateArgs e)
        {
            //Get the rectangle area to draw
            Rectangle footer = e.DrawRectangle;

            //Draw copy right
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            Font font = new Font("Helvetica", 8);
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

        //Used to create customized Printpreview dialog
        private void PrintPreview_Click(object sender, EventArgs e)
        {
            try
            {
                this.gridGroupingControl1.TableModel.Properties.PrintFrame = false;

                Syncfusion.GridHelperClasses.GridPrintDocumentAdv pd = new Syncfusion.GridHelperClasses.GridPrintDocumentAdv(this.gridGroupingControl1.TableControl);
                pd.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(25, 25, 25, 25);

                //Set header and footer height
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

                //Whether scale columns to fit
                pd.ScaleColumnsToFitPage = this.ScaleColumnsToFit.Checked;

                //Handle the events to draw the header / footer
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