#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
# region Directives
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using Queries = PortfolioManager.LINQqueries;
using PortfolioManager.DataModel;
using Syncfusion.Windows.Forms;
#endregion

namespace PortfolioManager
{
    /// <summary>
    /// DashBoard UserControl
    /// </summary>
    public partial class DashBoard : UserControl
    {
        # region Variable Declaration
        PortfolioGrid portfolioGrid;
        BindingList<Queries.CurrentHoldings> holdingList;
        int holdingID = 10000;
        #endregion

        # region Method
        /// <summary>
        /// ctor
        /// </summary>
        public DashBoard()
        {
            InitializeComponent();

            //Holding List
            holdingList = new BindingList<Queries.CurrentHoldings>(Queries.GetHoldingsList());

            portfolioGrid = new PortfolioGrid(this.Grid, holdingList, this.dashboardImageList, this.dashBoardImages16, this.dashBoardImages24);
            portfolioGrid.GridView = GridViewType.Overview;

            //Enable ToolStrip labels
            this.UpdateViewLabels(this.overViewToolStripLabel, true);

            //AddPortfolioPanel
            this.ConfigureAddPortfolioPanel();
        }

        /// <summary>
        /// Setup Account ComboBox
        /// </summary>
        private void ConfigureAccountComboBox()
        {
            IEnumerable<string> accountNames = LINQqueries.GetAccounts();

            //Account ComobBox
            this.accountsComboBox.Items.Clear();
            foreach (string name in accountNames)
                this.accountsComboBox.Items.Add(name);
            this.accountsComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Setup Exchange ComboBox
        /// </summary>
        private void ConfigureExchangeComboBox()
        {
            IEnumerable<string> exchangeNames = LINQqueries.GetExchangeNames();
            
            this.exchangeComboBox.Items.Clear();
            foreach (string name in exchangeNames)
                this.exchangeComboBox.Items.Add(name);
            this.exchangeComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// SetUp Portfolio Panel
        /// </summary>
        private void ConfigureAddPortfolioPanel()
        {
            //SymbolAutoCompleteTextBox
            //Set the parentForm
            this.symbolAutoComplete.ParentForm = this;
            //Set AutoComplete DataSource
            this.symbolAutoComplete.DataSource = LINQqueries.GetSymbolAndCompanyNamefromQuotes();
            this.symbolAutoComplete.Columns.Add(new Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo("Symbol", 40, true));
            this.symbolAutoComplete.Columns.Add(new Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo("CompanyName", 40, true));

            this.symbolTextBox.PreviewKeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Tab)
                    this.symbolAutoComplete.CloseDropDown();
            };

            //Account ComboBox
            ConfigureAccountComboBox();

            //StockExchange ComboBox
            ConfigureExchangeComboBox();
        }

        /// <summary>
        /// Updates ViewLabel
        /// </summary>
        /// <param name="toolStripLabel">ToolStripLabel</param>
        /// <param name="Enable">True if it is enabled</param>
        private void UpdateViewLabels(ToolStripLabel toolStripLabel, bool Enable)
        {
            foreach (ToolStripLabel label in this.dashBoardToolStrip.Items)
            {
                if (label == toolStripLabel)
                    label.Enabled = !Enable;
                else
                    label.Enabled = Enable;
            }
        }

        #endregion


        # region Event Handler
        // ToolStripLabel Handlers
        private void detailViewToolStripLabel_Click(object sender, EventArgs e)
        {
            this.UpdateViewLabels(sender as ToolStripLabel, true);
            this.portfolioGrid.GridView = GridViewType.DetailView;
            this.dockingManager.SetAutoHideMode(this.addPortfolioPanel, true);
        }

        private void overViewToolStripLabel_Click(object sender, EventArgs e)
        {
            this.UpdateViewLabels(sender as ToolStripLabel, true);
            this.portfolioGrid.GridView = GridViewType.Overview;            
            this.dockingManager.SetAutoHideMode(this.addPortfolioPanel, false);
        }

        private void Industry_SectorViewtoolStripLabel_Click(object sender, EventArgs e)
        {
            this.UpdateViewLabels(sender as ToolStripLabel, true);
            this.portfolioGrid.GridView = GridViewType.SectorIndustryView;
            this.dockingManager.SetAutoHideMode(this.addPortfolioPanel, true);
        }

        private void exchangeViewToolStripLabel_Click(object sender, EventArgs e)
        {
            this.UpdateViewLabels(sender as ToolStripLabel, true);
            this.portfolioGrid.GridView = GridViewType.CountryView;
        }    

        private void symbolTextBox_Enter(object sender, EventArgs e)
        {
            if (this.symbolTextBox.Text == "Symbol")
            {  
                this.symbolTextBox.Text = null;
                this.symbolTextBox.Font = new Font(this.symbolTextBox.Font, FontStyle.Regular);
            }
        }

        private void symbolTextBox_Leave(object sender, EventArgs e)
        {
            if (this.symbolTextBox.Text == string.Empty)
            {
                this.symbolTextBox.Text = "Symbol";
                this.symbolTextBox.Font = new Font(this.symbolTextBox.Font, FontStyle.Italic);
            }           
        }     

        private void quantityTextBox_Enter(object sender, EventArgs e)
        {
            if (this.quantityTextBox.Text == "0")
            {
                this.quantityTextBox.Text = null;
                this.quantityTextBox.Font = new Font(this.symbolTextBox.Font, FontStyle.Regular);
            }
        }

        private void quantityTextBox_Leave(object sender, EventArgs e)
        {
            if (this.quantityTextBox.Text == string.Empty)
            {
                this.quantityTextBox.Text = "0";
                this.quantityTextBox.Font = new Font(this.symbolTextBox.Font, FontStyle.Italic);
            }
        }

        private void priceLookUpCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            string symbol = this.symbolTextBox.Text;

            if (symbol != null && this.priceLookUpCheckBox.Checked)
            {
               this.priceDoubleTextBox.DoubleValue = (double)LINQqueries.GetPriceforSymbol(symbol);
            }
        }       

        //Add a new Stock to the portfolio account
        private void addPortfolioButton_Click(object sender, EventArgs e)
        {
            try
            {
                string accountName = this.accountsComboBox.Text;
                string exchangeName = this.exchangeComboBox.Text;                
                string symbol = this.symbolTextBox.Text.Trim();
                Quotes qt = Queries.GetQuote(symbol);

                //Check if this is valid and get the AccountID
                int acctID = LINQqueries.GetAccountID(accountName);

                //Check if this is valid and get the ExchangeID
                int exchangeID = LINQqueries.GetExchangeID(exchangeName);

                if (acctID != -1)
                {   
                    Decimal quantity = Convert.ToDecimal(this.quantityTextBox.Text);
                    Decimal price = Convert.ToDecimal(this.priceDoubleTextBox.DoubleValue);

                    if (symbol != null && quantity > 0)
                    {
                        LINQqueries.CurrentHoldings currentHolding = new LINQqueries.CurrentHoldings()
                       {
                           HoldingID = holdingID++,
                           Open = true,
                           PricePaid = price,
                           Quantity = quantity,
                           Quote___Change = qt.PertChange,
                           Quote_Change = qt.Change,
                           Quote_CompanyName = qt.CompanyName,
                           Quotes_Symbol = qt.Symbol,
                           Account_AccountName = accountName,
                           Quote_Industry_IndusrtyName = Queries.GetIndustryName(qt.Industry_IndustryID),
                           Quote_Industry_Sector_SectorName = Queries.GetSectorName(qt.Industry_IndustryID),
                           Quote_Price = qt.Price,
                           StockExchange_StockExchangeName = exchangeName
                       };

                        //Add it to the local list Bound to Grid                        
                        this.holdingList.Add(currentHolding);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex.ToString());
            }
        }

        #endregion
    }
}