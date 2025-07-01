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
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using System.Xml;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.GridHelperClasses;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.IO;
using DemoCommon.Grid;

namespace PdfConverter
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : GridDemoForm
    {
        #region "API Definition"

        public readonly static string connString = @"Data Source=" + FindFile("NorthwindwithImage.sdf");

        #endregion

        #region "Constructor"

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();     
            this.SampleCustomization();
            GridSettings();
        }

        #endregion

        #region "Sample Grid Settings"

        /// <summary>
        /// GridGrouping control getting started customization.
        /// </summary>
        private void GridSettings()
        {
            //used to set multiextended selection mode in gridgrouping control.            
            this.gridGroupingControl2.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl2.GridOfficeScrollBars = OfficeScrollBars.Metro;

            checkBoxAdv1.CheckState = CheckState.Checked;
            checkBoxAdv2.CheckState = CheckState.Checked;
            this.MetroColor = System.Drawing.Color.Transparent;

            //gridGroupingControl2
            gridGroupingControl2.TopLevelGroupOptions.ShowCaption = false;
            gridGroupingControl2.TopLevelGroupOptions.ShowAddNewRecordAfterDetails = false;
            gridGroupingControl2.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl2.TableControl.DpiAware = true; 
           

            //used to set GridCaptionRowHeight.
           // this.gridGroupingControl2.AllowProportionalColumnSizing = true;
            this.gridGroupingControl2.Table.DefaultCaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridGroupingControl2.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30.0f);
            this.gridGroupingControl2.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(32.0f);
            this.gridGroupingControl2.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl2.WantTabKey = false;
        }

        #endregion

        #region "Sample Customization"
        /// <summary>
        /// Set the dataset to the GridGroupingControl
        /// </summary>
        private void SampleCustomization()
        {
            String commandstring = "select * from Products";
            SqlCeDataAdapter da = new SqlCeDataAdapter(commandstring, connString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Customers");
            gridGroupingControl2.DataSource = ds.Tables[0];
            this.gridGroupingControl2.TableDescriptor.Columns["ProductID"].HeaderText = "Product ID";
            this.gridGroupingControl2.TableDescriptor.Columns["CategoryID"].HeaderText = "Category ID";
            this.gridGroupingControl2.TableDescriptor.Columns["SupplierID"].HeaderText = "Supplier ID";
            this.gridGroupingControl2.TableDescriptor.Columns["QuantityPerUnit"].HeaderText = "Quantity Per Unit";
            this.gridGroupingControl2.TableDescriptor.Columns["UnitPrice"].HeaderText = "Unit Price";
            this.gridGroupingControl2.TableDescriptor.Columns["UnitsInStock"].HeaderText = "Units In Stock";
            this.gridGroupingControl2.TableDescriptor.Columns["UnitsOnOrder"].HeaderText = "Units On Order";
            this.gridGroupingControl2.TableDescriptor.Columns["ProductName"].HeaderText = "Product Name";
            this.gridGroupingControl2.TableDescriptor.Columns["ReorderLevel"].HeaderText = "Reorder Level";
            this.gridGroupingControl2.BorderStyle = BorderStyle.FixedSingle;
          
        }

        #region "Events"

        //create the pdf footer
        void pdfConvertor_DrawPDFFooter(object sender, PDFHeaderFooterEventArgs e)
        {

            PdfPageTemplateElement footer = e.HeaderFooterTemplate;

            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 8);

            PdfSolidBrush brush = new PdfSolidBrush(Color.Gray);

            PdfPen pen = new PdfPen(Color.DarkBlue, 3f);
            font = new PdfStandardFont(PdfFontFamily.Helvetica, 6, PdfFontStyle.Bold);
            PdfStringFormat format = new PdfStringFormat();
            format.Alignment = PdfTextAlignment.Center;
            format.LineAlignment = PdfVerticalAlignment.Middle;
            footer.Graphics.DrawString("@Copyright 2008", font, brush, new RectangleF(0, footer.Height - 40, footer.Width, footer.Height), format);

            format = new PdfStringFormat();
            format.Alignment = PdfTextAlignment.Right;
            format.LineAlignment = PdfVerticalAlignment.Bottom;

            //Create page number field
            PdfPageNumberField pageNumber = new PdfPageNumberField(font, brush);

            //Create page count field
            PdfPageCountField count = new PdfPageCountField(font, brush);

            PdfCompositeField compositeField = new PdfCompositeField(font, brush, "Page {0} of {1}", pageNumber, count);
            compositeField.Bounds = footer.Bounds;
            compositeField.Draw(footer.Graphics, new PointF(470, footer.Height - 10));
        }

        //create the pdf header
        void pdfConvertor_DrawPDFHeader(object sender, PDFHeaderFooterEventArgs e)
        {
            PdfPageTemplateElement header = e.HeaderFooterTemplate;

            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 24);
            float doubleHeight = font.Height * 2;
            Color activeColor = Color.FromArgb(44, 71, 120);
            SizeF imageSize = new SizeF(110f, 35f);
            //Locating the logo on the right corner of the Drawing Surface
            PointF imageLocation = new PointF(e.HeaderFooterTemplate.Width - imageSize.Width - 20, 5);

            PdfImage img = new PdfBitmap(FindImageFile(@"Common\Images\Grid\PDF_logo\logo.png"));

            //Draw the image in the Header.
            header.Graphics.DrawImage(img, imageLocation, imageSize);

            PdfSolidBrush brush = new PdfSolidBrush(activeColor);

            PdfPen pen = new PdfPen(Color.DarkBlue, 3f);
            font = new PdfStandardFont(PdfFontFamily.Helvetica, 16, PdfFontStyle.Bold);

            //Set formattings for the text
            PdfStringFormat format = new PdfStringFormat();
            format.Alignment = PdfTextAlignment.Center;
            format.LineAlignment = PdfVerticalAlignment.Middle;

            //Draw title
            header.Graphics.DrawString("Syncfusion Essential Grid", font, brush, new RectangleF(0, 0, header.Width, header.Height), format);
            brush = new PdfSolidBrush(Color.Gray);
            font = new PdfStandardFont(PdfFontFamily.Helvetica, 6, PdfFontStyle.Bold);

            format = new PdfStringFormat();
            format.Alignment = PdfTextAlignment.Left;
            format.LineAlignment = PdfVerticalAlignment.Bottom;

            //Draw some lines in the header
            pen = new PdfPen(Color.DarkBlue, 0.7f);
            header.Graphics.DrawLine(pen, 0, 0, header.Width, 0);
            pen = new PdfPen(Color.DarkBlue, 2f);
            header.Graphics.DrawLine(pen, 0, 03, header.Width + 3, 03);
            pen = new PdfPen(Color.DarkBlue, 2f);
            header.Graphics.DrawLine(pen, 0, header.Height - 3, header.Width, header.Height - 3);
            header.Graphics.DrawLine(pen, 0, header.Height, header.Width, header.Height);
        }

        //perform the toolstrip operation
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (ShowDialog() == DialogResult.OK)
            {
                GridPDFConverter pdfConvertor = new GridPDFConverter();

                if (checkBoxAdv1.CheckState == CheckState.Checked)
                {
                    pdfConvertor.ShowHeader = true;

                }
                if (checkBoxAdv2.CheckState == CheckState.Checked)
                {
                    pdfConvertor.ShowFooter = true;
                }

                pdfConvertor.Margins.Left = (int)domainUpDown1.Value;
                pdfConvertor.Margins.Right = (int)domainUpDown2.Value;
                pdfConvertor.Margins.Top = (int)domainUpDown3.Value;
                pdfConvertor.Margins.Bottom = (int)domainUpDown4.Value;

                pdfConvertor.DrawPDFHeader += new GridPDFConverter.DrawPDFHeaderFooterEventHandler(pdfConvertor_DrawPDFHeader);

                pdfConvertor.DrawPDFFooter += new GridPDFConverter.DrawPDFHeaderFooterEventHandler(pdfConvertor_DrawPDFFooter);

                //pdfConvertor.Margins.All = 25;
                pdfConvertor.ExportToPdf("Sample.pdf", this.gridGroupingControl2.TableControl);
                //Launching the PDF file using the default Application.[Acrobat Reader]
                System.Diagnostics.Process.Start("Sample.pdf");
            }
        }

        //set the backcolor
      

        private void button1_Click(object sender, EventArgs e)
        {
            GridPDFConverter pdfConvertor = new GridPDFConverter();

            if (checkBoxAdv1.CheckState == CheckState.Checked)
            {
                pdfConvertor.ShowHeader = true;

            }
            if (checkBoxAdv2.CheckState == CheckState.Checked)
            {
                pdfConvertor.ShowFooter = true;
            }

            pdfConvertor.Margins.Left = (int)domainUpDown1.Value;
            pdfConvertor.Margins.Right = (int)domainUpDown2.Value;
            pdfConvertor.Margins.Top = (int)domainUpDown3.Value;
            pdfConvertor.Margins.Bottom = (int)domainUpDown4.Value;

            pdfConvertor.DrawPDFHeader += new GridPDFConverter.DrawPDFHeaderFooterEventHandler(pdfConvertor_DrawPDFHeader);

            pdfConvertor.DrawPDFFooter += new GridPDFConverter.DrawPDFHeaderFooterEventHandler(pdfConvertor_DrawPDFFooter);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Sample";
            saveFileDialog.Filter = "Files(*.pdf)|*.pdf";
            saveFileDialog.DefaultExt = ".pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //pdfConvertor.Margins.All = 25;            
                pdfConvertor.ExportToPdf(saveFileDialog.FileName, this.gridGroupingControl2.TableControl);

                //Launching the PDF file using the default Application.[Acrobat Reader]
                System.Diagnostics.Process.Start(saveFileDialog.FileName);
            }
        }

        #endregion
        #endregion

        #region "Designer Stuff"

        #region "Find Utility"

        /// <summary>
        /// Find the image from the specified location
        /// </summary>        
        private string FindImageFile(string bitmapName)
        {
            string bitmappath = "";
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    bitmappath = bitmapName;

                bitmapName = @"..\" + bitmapName;
            }
            return bitmappath;
        }

        /// <summary>
        /// Find the file from the specified location
        /// </summary>        
        private static string FindFile(string fileName)
        {
            // Check both in parent folder and Parent\Data folders.
            string dataFileName = @"Common\Data\" + fileName;
            for (int n = 0; n < 12; n++)
            {
                if (System.IO.File.Exists(fileName))
                {
                    return new FileInfo(fileName).FullName;
                }
                if (System.IO.File.Exists(dataFileName))
                {
                    return new FileInfo(dataFileName).FullName;
                }
                fileName = @"..\" + fileName;
                dataFileName = @"..\" + dataFileName;
            }

            return fileName;
        }

        #endregion

        #endregion

      
    }
}
