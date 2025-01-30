#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Data;
using Syncfusion.WinForms.DataGrid;
using System.Globalization;
using System.Windows.Forms;

namespace IntervalGrouping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OrderInfoCollection orderInfo = new OrderInfoCollection();
            sfDataGrid1.DataSourceChanged += SfDataGrid1_DataSourceChanged;
            sfDataGrid1.BeginUpdate();
            sfDataGrid1.DataSource = orderInfo.OrdersListDetails;
            this.sfDataGrid1.SortComparers.Add(new SortComparer()
            {
                PropertyName = "ShippedDate",
                Comparer = new GroupDateComparer(),
            });

            this.sfDataGrid1.SortComparers.Add(new SortComparer()
            {
                PropertyName = "OrderID",
                Comparer = new GroupNumericComparer(),
            });

            this.sfDataGrid1.GroupColumnDescriptions.Add(new GroupColumnDescription()
            {
                ColumnName = "ShippedDate",
                KeySelector = (string ColumnName, object o) =>
                {
                    var shipDate = (o as OrderInfo).ShippedDate;
                    return shipDate.ToString("MMMM yyyy");
                }
            });

            sfDataGrid1.EndUpdate();
        }

        private void SfDataGrid1_DataSourceChanged(object sender, Syncfusion.WinForms.DataGrid.Events.DataSourceChangedEventArgs e)
        {
            if (e.NewView != null)
                e.NewView.GroupDescriptions.CollectionChanged += GroupDescriptions_CollectionChanged;
            if (e.OldView != null)
                e.NewView.GroupDescriptions.CollectionChanged -= GroupDescriptions_CollectionChanged;
        }

        private void GroupDescriptions_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                if ((e.NewItems[0] as ColumnGroupDescription).PropertyName == "OrderID")
                {
                    (e.NewItems[0] as ColumnGroupDescription).KeySelector = (string OrderID, object o) =>
                    {
                        var orderID = (o as OrderInfo).OrderID;
                        var i = (int)orderID / 10;
                        int GroupingIntervalFrom = (int)i * 10;
                        int GroupingIntervalTo = ((int)i + 1) * 10;
                        return GroupingIntervalFrom.ToString(CultureInfo.InvariantCulture) + " to " + GroupingIntervalTo.ToString(CultureInfo.InvariantCulture);
                    };
                }

                if ((e.NewItems[0] as ColumnGroupDescription).PropertyName == "ShippedDate")
                {
                    (e.NewItems[0] as ColumnGroupDescription).KeySelector = (string ShippedDate, object o) =>
                    {
                        var shipDate = (o as OrderInfo).ShippedDate;
                        return shipDate.ToString("MMMM yyyy");
                    };
                }

                if ((e.NewItems[0] as ColumnGroupDescription).PropertyName == "CustomerID")
                {
                    (e.NewItems[0] as ColumnGroupDescription).KeySelector = (string CustomerID, object o) =>
                    {
                        var customerID = (o as OrderInfo).CustomerID;
                        return customerID[0];
                    };
                }

                if ((e.NewItems[0] as ColumnGroupDescription).PropertyName == "ShipCountry")
                {
                    (e.NewItems[0] as ColumnGroupDescription).KeySelector = (string ShipCountry, object o) =>
                    {
                        var shipCountry = (o as OrderInfo).ShipCountry;
                        return shipCountry[0];
                    };
                }
            }
        }
    }
}
