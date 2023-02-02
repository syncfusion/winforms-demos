#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using Syncfusion.Windows.Forms;
using System.Windows.Forms;

namespace Invoice
{
    public partial class FrmEdit : MetroForm
    {
        #region Fields
        internal InvoiceItem m_invoiceItem;
        internal ProductList m_productlist;
        const double DefaultTaxInPercent = 7;
        bool onInit;
        #endregion

#region Constructors
        public FrmEdit()
            : this(null, "Add Item", new ProductList())
        {
        }

        public FrmEdit(ProductList productList)
            : this(null, "Add Item", productList)
        {
        }

        public FrmEdit(InvoiceItem newItem, string title, ProductList productList)
            : this(newItem, title, productList, 0)
        {
            
        }

        public FrmEdit(InvoiceItem newItem, string title, ProductList productList, int productIndex)
        {
            this.InitializeComponent();

            if (newItem == null)
            {
                newItem = new InvoiceItem();
                newItem.ItemName = productList[0].Name;
                newItem.Rate = productList[0].Rate;
            }
            m_invoiceItem = newItem;
            onInit = true;
            
            //this.DataContext = m_invoiceItem;
            
            this.Text = title;
            double currentRate = m_invoiceItem.Rate;

            m_productlist = productList;
            this.cmbItems.DataSource = m_productlist;
            this.cmbItems.DisplayMember = "Name";
            this.cmbItems.SelectedItem = m_productlist[productIndex];
            if (currentRate != 0)
                this.txtPrice.Text = currentRate.ToString();
            if (!newItem.Taxes.Equals("0"))
            {
                this.txtTaxes.Text = newItem.Taxes.ToString();
            }
            if (newItem.Rate != 0)
                this.txtPrice.Text = newItem.Rate.ToString("C");

            if (newItem.Quantity == 0)
            {
                newItem.Quantity = 1;
                this.txtQty.Value = 1;
            }
            else
            {
                txtQty.Value = newItem.Quantity;
            }

            CalculateTax();
            UpdateTotalAmount();

            onInit = false;
        }
#endregion

        private void FrmEdit_Load(object sender, EventArgs e)
        {
            lblCaption.Text = this.Text;
        }

        #region Helper Methods
        /// <summary>
        /// 
        /// </summary>
        private void CalculateTax()
        {
            double currentRate = Convert.ToDouble(txtPrice.Text.Substring(1));
            int currentQuantity = GetQuantityAsInt();

            {
                double calculatedTax = 0.0;
                calculatedTax = (currentRate * currentQuantity) * (DefaultTaxInPercent / 100);
                m_invoiceItem.Taxes = calculatedTax;
                txtTaxes.Text = calculatedTax.ToString("C");
            }
        }

        public int GetQuantityAsInt()
        {
            return (txtQty.Value is int) ? (int)txtQty.Value : (int)(double)txtQty.Value;
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateTotalAmount()
        {

            int quantityValue = GetQuantityAsInt();
            double rateValue = Convert.ToDouble(txtPrice.Text.Substring(1));
            double calculatedTax = m_invoiceItem.Taxes;
            double taxedAmount = (quantityValue * rateValue) + calculatedTax;
            this.txtTotal.Text = taxedAmount.ToString("C");
        }
        #endregion

        private void cmbItems_Click(object sender, EventArgs e)
        {

        }

        private void cmbItems_SelectedValueChanged(object sender, EventArgs e)
        {
            if (onInit)
                return;
            Product product = cmbItems.SelectedItem as Product;
            if (product != null)
            {
                m_invoiceItem.ItemName = product.Name;
                if (!m_invoiceItem.Rate.Equals(product.Rate.ToString()))
                {
                    m_invoiceItem.Rate = product.Rate;
                    txtPrice.Text = m_invoiceItem.Rate.ToString("C");
                    CalculateTax();
                    UpdateTotalAmount();
                }
            }
        }

        private void UpdateInvoiceItem()
        {
            m_invoiceItem.ItemName = (cmbItems.SelectedValue as Product).Name;
            m_invoiceItem.Quantity = Convert.ToInt16(txtQty.Text);
            m_invoiceItem.Rate = Convert.ToDouble(txtPrice.Text.Substring(1));
            m_invoiceItem.Taxes = Convert.ToDouble(txtTaxes.Text.Substring(1));
            m_invoiceItem.TotalAmount = Convert.ToDouble(txtTotal.Text.Substring(1));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateInvoiceItem();
        }

        private void txtQty_ValueChanged(object sender, EventArgs e)
        {
            CalculateTax();
            UpdateTotalAmount();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
