#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace MarketSimulation
{
    internal class OrderAgreementQueuerC : GridDemoForm
    {
        #region API Definition
        private QuoteManagerC.QuotesUpdatedDelegate quotesUpdateDelegate;

        // Added these to try and improve performance
        private FieldDescriptor symbolColumn;
        private FieldDescriptor openColumn;
        private FieldDescriptor bidColumn;
        private FieldDescriptor askColumn;
        private FieldDescriptor lastColumn;
        private Panel panel1;
        private GridC grid;

        private RecordListDictionary symbolRecordMap = new RecordListDictionary();
        #endregion

        #region Constructor
        public OrderAgreementQueuerC()
        {
            InitializeComponent();
            InitializeGrid();
			grid.SetStyle();
			LoadData();
            GridSettings();            
        }
        #endregion

        #region Grid Settings
        /// <summary>
        /// Grid Settings for better Look and feel
        /// </summary>
        private void GridSettings()
        {
            this.grid.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
            this.grid.AllowProportionalColumnSizing = true;
            //Used to set GridCaptionRowHeight.
            this.grid.Table.DefaultCaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(25);
            this.grid.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30);
            this.grid.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22);            
        }

        private void InitializeGrid()
        {
            this.grid = new MarketSimulation.GridC();
            this.panel1.Controls.Add(this.grid);
            // 
            // grid
            // 
            this.grid.Dock = DockStyle.Fill;
            this.grid.BackColor = System.Drawing.SystemColors.Window;
            this.grid.FreezeCaption = false;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(975, 632);
            this.grid.TabIndex = 1;
            this.grid.Text = "gridGroupingControl1";
        }
        #endregion        

        #region OnLoad
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            BeginInvoke(new MethodInvoker(subscribeQuotes));
        }
        #endregion        

        #region Grid Update
        void QuotesUpdate(QuoteC[] quoteList)
        {
			if (grid.IsDisposed)
				return;

            foreach (QuoteC quote in quoteList)
            {
                if (symbolRecordMap.ContainsKey(quote.Symbol))
                {
                    foreach (Record record in symbolRecordMap[quote.Symbol])
                    {
                        DataRow data = (DataRow) record.GetData();
                        data.BeginEdit();
                        data[openColumn.MappingName] = quote.Open;
                        data[bidColumn.MappingName] = quote.Bid;
                        data[askColumn.MappingName] = quote.Ask;
                        data[lastColumn.MappingName] = quote.Last;
                        data.EndEdit();
                    }
                }
            }

            this.grid.Update(); // calls PaintUpdateRecordFields.
        }
        void subscribeQuotes()
        {
            Application.DoEvents();
            QuoteManagerC.Manager.QuotesUpdate += new QuoteManagerC.QuotesUpdatedDelegate(Manager_QuotesUpdate);
        }

        void Manager_QuotesUpdate(QuoteC[] quoteList)
        {
            // Quote updates come in on a separate thread, so call Control.Invoke()
            try
            {
                if (!IsDisposed)
                    Invoke(quotesUpdateDelegate, new object[] { quoteList });
            }
            catch (Exception)
            { }
        }
        #endregion

        #region Data
        protected void LoadData()
        {
            // In this prototype, the orders will not change... but the market data will
            OrderAgreementListC records = new OrderAgreementListC();

            for (int i = 0; i < Program.NumberOfRows; i++)
            {
                OrderAgreementC orderAgreement = OrderAgreementC.GenerateRandom();
                records.Add(orderAgreement);
            }

            DataTable table = GridC.CreateDataTable(records);

            grid.BindToCurrencyManager = false;
            grid.AllowSwapDataViewWithDataTableList = true;
            grid.DataSource = table;

            symbolColumn = grid.TableDescriptor.Fields["Symbol"];
            openColumn = grid.TableDescriptor.Fields["Opn"];
            bidColumn = grid.TableDescriptor.Fields["Bid"];
            askColumn = grid.TableDescriptor.Fields["Ask"];
            lastColumn = grid.TableDescriptor.Fields["Last"];

            // Cache symbol -> records map for faster market data updates
            int count = grid.Table.Records.Count;
            for (int n = 0; n < count; n++)
            {
                Record record = grid.Table.Records[n];
                string symbol = (string)record.GetValue(symbolColumn);
                if (symbol == null)
                    continue;

                RecordList recordList;                
                if (symbolRecordMap.ContainsKey(symbol))
                {
                    recordList = symbolRecordMap[symbol];
                }
                else
                {
                    recordList = new RecordList();
                    symbolRecordMap.Add(symbol, recordList);
                }
                recordList.Add(record);
            }
            this.grid.GridVisualStyles = GridVisualStyles.Metro;
            this.grid.GridOfficeScrollBars = OfficeScrollBars.Metro;
            quotesUpdateDelegate = new QuoteManagerC.QuotesUpdatedDelegate(QuotesUpdate);
        }
        #endregion

        #region Designer Stuffs

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        protected void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(17, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 632);
            this.panel1.TabIndex = 0;
            this.panel1.Dock = DockStyle.Fill;

            // 
            // OrderAgreementQueuerC
            //            
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 656);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "OrderAgreementQueuerC";
            this.Text = "Market Simulation";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                QuoteManagerC.Manager.QuotesUpdate -= new QuoteManagerC.QuotesUpdatedDelegate(Manager_QuotesUpdate);
                QuoteManagerC.Manager.Dispose();
                if (components != null)
                    components.Dispose();
            }
            base.Dispose(disposing);
        }

        #endregion
    }
	
	#if SyncfusionFramework2_0
    class RecordList : List<Record>
    {
    }

    class RecordListDictionary : Dictionary<string, RecordList>
    {
    }
#else
    class RecordList : ArrayList
    {
        public new Record this[int index]
        {
            get
            {
                return (Record) base[index];
            }
            set
            {
                base[index] = value;
            }
        }
    }

    class RecordListDictionary : Hashtable
    {
        public RecordList this[string key]
        {
            get
            {
                return (RecordList) base[key];
            }
            set
            {
                base[key] = value;
            }
        }
    }
#endif
}