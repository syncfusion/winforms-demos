#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Drawing;
using Syncfusion.Windows.Forms;

namespace Invoice
{
    public partial class FrmBillTo : MetroForm
    {
        BillingInformation info;

        public  FrmBillTo()
            : this(new BillingInformation())
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="billInfo"></param>
        public FrmBillTo(BillingInformation billInfo)
        {
            this.InitializeComponent();
            info = billInfo;


            UpdateFields();
        }

        private void FrmBillTo_Load(object sender, EventArgs e)
        {
            lblCaption.Text = this.Text;
        }

        private void UpdateFields()
        {
            this.txtName.Text = info.Name;
            this.txtAddress.Text = info.Address;
            this.dtpDate.Value = info.Date;
            this.dtpDueDate.Value = info.DueDate;
            this.txtInvoiceNo.Text = info.InvoiceNumber;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            info.Name = this.txtName.Text;
            info.Address = this.txtAddress.Text;
            info.Date = this.dtpDate.Value;
            info.DueDate = this.dtpDueDate.Value;
            info.InvoiceNumber = this.txtInvoiceNo.Text;
        }

        private void txtInvoiceNo_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            if (int.TryParse(txtInvoiceNo.Text, out value))
            {
                txtInvoiceNo.BorderColor = Color.FromArgb(255, 0, 64, 81);
            }
            else
            {
                txtInvoiceNo.BorderColor = Color.FromArgb(255, 255, 37, 37);
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class BillingInfoEventArgs : EventArgs
    {
        BillingInformation m_billInfo;
        public BillingInformation BillingInformation
        {
            get { return m_billInfo; }
            set { m_billInfo = value; }
        }
    }
}
