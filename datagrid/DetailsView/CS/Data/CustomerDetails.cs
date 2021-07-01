#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;

namespace DetailsView
{
    public class Customers : List<string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Customers"/> class.
        /// </summary>
        public Customers()
        {
            var orderInfo = new OrderInfoRepository();
            this.AddRange(orderInfo.Customers);
        }
    }
}
