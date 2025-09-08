#region Copyright Syncfusion Inc. 2001 - 2015
// Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;

namespace DetailsViewExcelExporting
{
    public class OrderInfoCollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderInfoCollection"/> class.
        /// </summary>
        public OrderInfoCollection()
        {
            OrderInfoRepository order = new OrderInfoRepository();
            OrdersDetails = order.GetOrdersDetails(100);
        }

        public List<OrderInfo> _ordersDetails;

        /// <summary>
        /// Gets or sets the orders details.
        /// </summary>
        /// <value>The orders details.</value>
        public List<OrderInfo> OrdersDetails
        {
            get{ return _ordersDetails; }
            set{ _ordersDetails = value;}
        }
    }
}
