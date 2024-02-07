#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using System.Globalization;
using Syncfusion.Licensing;
using System.Reflection;
using System.Text;
using System.IO;
using Syncfusion.WinForms.Controls;
using System.Diagnostics;

namespace Invoice
{
    public partial class FrmInvoice :SfForm 
    {

        #region Fields
        const int m_columnCount = 5;
        private double m_totalDue;
        private IList<InvoiceItem> m_items;
        int m_currentRowIndex = 0;
        int m_selectedIndex = -1;
        int m_prevSelectedIndex = -1;
        const int m_rowHeight = 30;
        FrmEdit frmEditDetails;
        FrmBillTo frmBillTo;
        BillingInformation m_billInfo;
        ProductList m_productList;
        #endregion

        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public double TotalDue
        {
            get
            {
                return m_totalDue;
            }
        }
        #endregion

        public FrmInvoice()
        {	
		#if NETCORE
            Application.SetHighDpiMode(HighDpiMode.DpiUnawareGdiScaled);
            this.AutoScaleMode = AutoScaleMode.Dpi;
        #endif
            InitializeComponent();
            this.btnBillTo.Image = global::Invoice.Properties.Resources.Edit;
            System.Windows.Forms.DataGridViewCellStyle dgvHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();

            dgvHeaderStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

            this.dgvItems.Columns["Item"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvItems.Columns["Quantity"].HeaderCell.Style = dgvHeaderStyle;
            this.dgvItems.Columns["Rate"].HeaderCell.Style = dgvHeaderStyle;
            this.dgvItems.Columns["Taxes"].HeaderCell.Style = dgvHeaderStyle;
            this.dgvItems.Columns["Amount"].HeaderCell.Style = dgvHeaderStyle;

            m_productList = new ProductList();
            m_items = new List<InvoiceItem>();
            m_billInfo = new BillingInformation();

            //Load price list from XML document
            m_productList.LoadFromXml();

            //Set Billing information
            SetBillingInfo(true);

            //Add an item by default
            UpdateInvoiceItems(null, true);
        }		

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SetBillingInfo(bool isDefaultValues)
        {
            if (isDefaultValues)
            {
                this.txtName.Text = m_billInfo.Name = "Fran Wilson";
                this.txtTo.Text = m_billInfo.Address = "89, Chiaroscuro Road, Portland, 97219.";
                this.dtToDate.Value = (m_billInfo.Date = DateTime.Now.Date); //.ToString("d");
                this.txtInvoiceNo.Text = m_billInfo.InvoiceNumber = new Random().Next(100, 10000).ToString();
                this.dtDueDate.Value = (m_billInfo.DueDate = DateTime.Now.Date); //.ToString("d");
            }
            else
            {
                this.txtName.Text = m_billInfo.Name;
                this.txtTo.Text = m_billInfo.Address;
                this.dtToDate.Value = m_billInfo.Date;
                this.txtInvoiceNo.Text = m_billInfo.InvoiceNumber;
                this.dtDueDate.Value = m_billInfo.DueDate;
            }
        }

        private void btnBillTo_Click(object sender, EventArgs e)
        {
            if (frmBillTo == null) frmBillTo = new FrmBillTo(m_billInfo);

            frmBillTo.Text = "Bill To";

            if (frmBillTo.ShowDialog() == DialogResult.OK)
            {
                SetBillingInfo(false);
            }

            frmBillTo.Close();
            frmBillTo.Dispose();
            frmBillTo = null;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            EditFields(true);
        }

        private void EditFields(bool isAddNew)
        {
            if (isAddNew)
            {
                if (frmEditDetails == null) frmEditDetails = new  FrmEdit(m_productList);
            }
            else
            {
                InvoiceItem invoiceItem = m_items[m_selectedIndex];
                int selectedProductIndex = m_productList.IndexOf(m_productList[invoiceItem.ItemName]);
                frmEditDetails = new FrmEdit(invoiceItem, "Edit Fields", m_productList, selectedProductIndex);
            }

            if (frmEditDetails.ShowDialog() == DialogResult.OK)
            {
                UpdateInvoiceItems(frmEditDetails.m_invoiceItem, isAddNew);
            }

            frmEditDetails.Close();
            frmEditDetails.Dispose();
            frmEditDetails = null;
        }
        /// <summary>
        /// Updates InvoiceItems collection
        /// </summary>
        /// <param name="item"></param>
        /// <param name="addToGridAlone"></param>
        public void UpdateInvoiceItems(InvoiceItem invoiceItem, bool IsAddNew)
        {
		    m_totalDue = 0;
            InvoiceItem defaultItem;
            if (invoiceItem == null)
            {
                defaultItem = new InvoiceItem()
                    {
                        ItemName = m_productList[0].Name,
                        Quantity = 1,
                        Rate = m_productList[0].Rate
                    };
                defaultItem.Taxes = m_productList[0].Rate*0.07;
            }
            else
            {
                defaultItem = new InvoiceItem()
                    {
                        ItemName = invoiceItem.ItemName,
                        Quantity = invoiceItem.Quantity,
                        Rate = invoiceItem.Rate,
                        Taxes = invoiceItem.Taxes,
                        TotalAmount = invoiceItem.TotalAmount
                    };
            }

            if (IsAddNew)
                m_items.Add(defaultItem);
           foreach(InvoiceItem item in m_items)
             m_totalDue += Convert.ToDouble(item.TotalAmount);
            m_currentRowIndex++;
            m_selectedIndex = m_items.Count;
            UpdateGrid();
        }
        /// <summary>
        /// Updates the invoice grid
        /// </summary>
        private void UpdateGrid()
        {
            
            //dgvItems.Rows.Clear();
           


            for (int index = dgvItems.Rows.Count ; index < m_items.Count;index++)
            {
                InvoiceItem item = m_items[index];

                int row = this.dgvItems.Rows.Add();

                this.dgvItems.Rows[row].Cells[0].Value = item.ItemName;
                this.dgvItems.Rows[row].Cells[1].Value = item.Quantity.ToString();
                this.dgvItems.Rows[row].Cells[2].Value = "$" + item.Rate.ToString("#,###.00", CultureInfo.InvariantCulture);
                this.dgvItems.Rows[row].Cells[3].Value = "$" + item.Taxes.ToString("#,###.00", CultureInfo.InvariantCulture);
                this.dgvItems.Rows[row].Cells[4].Value = "$" + item.TotalAmount.ToString("#,###.00", CultureInfo.InvariantCulture);
            }
            
            dgvItems.Refresh();

            UpdateTotal();
        }
        /// <summary>
        /// 
        /// </summary>
        void UpdateTotal()
        {
            this.txtTotalDue.Text = "$" + TotalDue.ToString("#,###.00", CultureInfo.InvariantCulture);
        }

        private void dgvItems_DoubleClick(object sender, EventArgs e)
        {
            if (dgvItems.Rows.Count > 0)
            {
                m_selectedIndex = dgvItems.CurrentRow.Index;
                EditFields(false);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvItems.Rows.Count > 0)
            {
                ExportToExcel exportToExcel = new ExportToExcel();
                exportToExcel.GenerateReport(m_items, m_billInfo);

                //Message box confirmation to view the created PDF document.
                if (MessageBox.Show("Do you want to view the Excel file?", "Excel File Created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //Launching the PDF file using the default Application.[Acrobat Reader]
#if !NETCORE
                    System.Diagnostics.Process.Start("Invoice.xlsx");
#else
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = "cmd",
                        WindowStyle = ProcessWindowStyle.Hidden,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        Arguments = "/c start Invoice.xlsx"
                    };
                    Process.Start(psi);
#endif
                }
            }
            else
            {
                MessageBox.Show("No invoice items found to generate the report!", "Export Cancelled",
                                MessageBoxButtons.OK);
            }
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            if (dgvItems.Rows.Count > 0)
            {
                ExportWord exportWord = new ExportWord();
                exportWord.CreateWord(m_items, m_billInfo, TotalDue);

                //Message box confirmation to view the created PDF document.
                if (MessageBox.Show("Do you want to view the Word file?", "Word Document Created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //Launching the PDF file using the default Application.[Acrobat Reader]
#if !NETCORE
                    System.Diagnostics.Process.Start("Invoice.docx");
#else
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = "cmd",
                        WindowStyle = ProcessWindowStyle.Hidden,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        Arguments = "/c start Invoice.docx"
                    };
                    Process.Start(psi);
#endif
                }
            }
            else
            {
                MessageBox.Show("No invoice items found to generate the report!", "Export Cancelled",
                                MessageBoxButtons.OK);
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            if (dgvItems.Rows.Count > 0)
            {
                PdfExport export = new PdfExport();
                export.CreatePDF(m_items, m_billInfo, TotalDue);

                //Message box confirmation to view the created PDF document.
                if (MessageBox.Show("Do you want to view the PDF file?", "PDF File Created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //Launching the PDF file using the default Application.[Acrobat Reader]
#if !NETCORE
                    System.Diagnostics.Process.Start("Invoice.pdf");
#else
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = "cmd",
                        WindowStyle = ProcessWindowStyle.Hidden,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        Arguments = "/c start Invoice.pdf"
                    };
                    Process.Start(psi);
#endif
                }
            }
            else
            {
                MessageBox.Show("No invoice items found to generate the report!", "Export Cancelled",
                                MessageBoxButtons.OK);
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvItems.CurrentRow != null)
            {
                int index = dgvItems.CurrentRow.Index;
                m_totalDue -= Convert.ToDouble(m_items[index].TotalAmount);
                m_items.RemoveAt(index);
                this.dgvItems.Rows.RemoveAt(index);
                UpdateGrid();
            }
        }

        private void dgvItems_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgvItems.CurrentRow != null)
                btnDeleteItem.Enabled = true;
        }

        private void dgvItems_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgvItems.CurrentRow == null)
                btnDeleteItem.Enabled = false;
        }

        private void dgvItems_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItems.CurrentRow != null)
                btnDeleteItem.Enabled = true;
        }

        private void dgvItems_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItems.CurrentRow == null)
                btnDeleteItem.Enabled = false;
        }

        /// <summary>
        /// To draw empty grid lines
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvItems_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);

            int rowHeight = this.dgvItems.RowTemplate.Height;

            int h = this.dgvItems.ColumnHeadersHeight + rowHeight * this.dgvItems.RowCount;

            int imgWidth = this.Width; // - 2

            Rectangle rFrame = new Rectangle(0, 0, imgWidth, rowHeight);

            Rectangle rFill = new Rectangle(0, 1, imgWidth, rowHeight);

            //Rectangle rowHeader = new Rectangle(2, 2, this.dgvItems.RowHeadersWidth - 3, rowHeight);


            Pen pen = new Pen(this.dgvItems.GridColor, 1);

            Bitmap rowImg = new Bitmap(imgWidth, rowHeight);

            Graphics g = Graphics.FromImage(rowImg);

            g.DrawRectangle(pen, rFrame);

            g.FillRectangle(new SolidBrush(this.dgvItems.DefaultCellStyle.BackColor), rFill);
            //g.FillRectangle(new HatchBrush(HatchStyle.DashedHorizontal, Color.White), rFill);

            //g.FillRectangle(new SolidBrush(this.dgvItems.RowHeadersDefaultCellStyle.BackColor), rowHeader);



            Bitmap rowImgAAlternative = rowImg.Clone() as Bitmap;

            Graphics g2 = Graphics.FromImage(rowImgAAlternative);

            rFill.X += 0; // this.dgvItems.RowHeadersWidth - 1;

            g2.FillRectangle(new SolidBrush(this.dgvItems.AlternatingRowsDefaultCellStyle.BackColor), rFill);
            //g2.FillRectangle(new HatchBrush(HatchStyle.DashedHorizontal, Color.White), rFill);



            //int w = this.dgvItems.RowHeadersWidth - 1;

            //for (int j = 0; j < this.dgvItems.ColumnCount; j++)
            //{

            //    g.DrawLine(pen, new Point(w, 0), new Point(w, rowHeight));

            //    g2.DrawLine(pen, new Point(w, 0), new Point(w, rowHeight));

            //    w += this.dgvItems.Columns[j].Width;

            //}



            int loop = (this.Height - h) / rowHeight;

            for (int j = 0; j < loop + 1; j++)
            {

                int index = this.dgvItems.RowCount + j;

                if (index % 2 == 0)
                {
                    e.Graphics.DrawImage(rowImg, 1, h + j * (rowHeight-1));
                }

                else
                {
                    e.Graphics.DrawImage(rowImgAAlternative, 1, h + j * (rowHeight-1));
                }

            }
        }
    }
}
