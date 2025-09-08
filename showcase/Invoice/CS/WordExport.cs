#region Copyright Syncfusion Inc. 2001 - 2013
// Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Invoice
{
    /// <summary>
    /// Helper Class to export invoice details to a Word document
    /// </summary>
    class ExportWord
    {
        /// <summary>
        /// Export the UI data to Word document.
        /// </summary>
        /// <param name="invoiceItems">The InvoiceItems.</param>
        /// <param name="billInfo">The BillingInformation.</param>
        /// <param name="totalDue">The TotalDue.</param>
        public void CreateWord(IList<InvoiceItem> invoiceItems, BillingInformation billInfo, double totalDue)
        {
            //Load Template document stream
            Stream inputStream = new FileStream("Assets/Template.docx",FileMode.Open,FileAccess.Read);
            //Create instance
            WordDocument document = new WordDocument();
            //Open Template document
            document.Open(inputStream, FormatType.Word2013);
            //Dispose input stream
            inputStream.Dispose();

            //Set Clear Fields to false
            document.MailMerge.ClearFields = false;
            //Create Mail Merge Data Table
            MailMergeDataTable mailMergeDataTable = new MailMergeDataTable("Invoice", invoiceItems);
            //Executes mail merge using the data generated in the app.
            document.MailMerge.ExecuteGroup(mailMergeDataTable);

            //Mail Merge Billing information
            string[] fieldNames = { "Name", "Address", "Date", "InvoiceNumber", "DueDate", "TotalDue" };
            string[] fieldValues = { billInfo.Name, billInfo.Address, billInfo.Date.ToString("d"), billInfo.InvoiceNumber, billInfo.DueDate.ToString("d"), totalDue.ToString("#,###.00", CultureInfo.InvariantCulture) };
            document.MailMerge.Execute(fieldNames, fieldValues);

            //Create Output file in Document library location
            document.Save("Invoice.docx",FormatType.Word2013);
            document.Close();
        }
    }
}
