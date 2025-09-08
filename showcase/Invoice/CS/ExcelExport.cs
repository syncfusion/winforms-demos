#region Copyright Syncfusion Inc. 2001 - 2013
// Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.XlsIO;
using System.Collections.Generic;
using System.IO;

namespace Invoice
{
    public class ExportToExcel
    {
        public  void GenerateReport(IList<InvoiceItem> items, BillingInformation billInfo)
        {
            Stream inputStream = new FileStream("Assets/InvoiceTemplate.xlsx",FileMode.Open,FileAccess.Read);
            ExcelEngine excelEngine = new ExcelEngine();
            IWorkbook book = excelEngine.Excel.Workbooks.Open(inputStream);
            inputStream.Dispose();

            //Create Template Marker Processor
            ITemplateMarkersProcessor marker = book.CreateTemplateMarkersProcessor();
            //Binding the business object with the marker.
            marker.AddVariable("InvoiceItem", items);
            marker.AddVariable("BillInfo", billInfo);
            marker.AddVariable("Company", billInfo);
            //Applies the marker.
            marker.ApplyMarkers(UnknownVariableAction.Skip);

            book.SaveAs("Invoice.xlsx");

            book.Close();
            excelEngine.Dispose();
        }
    }
}
