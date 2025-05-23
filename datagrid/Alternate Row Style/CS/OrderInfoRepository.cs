#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace AlternateRowStyle
{
    public class OrderInfoRepository
    {
        Random r = new Random();
        int customerIdCount = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderInfoRepository"/> class.
        /// </summary>
        public OrderInfoRepository()
        {
            OrdersDetail = this.GetOrdersDetail(100);
        }

        private ObservableCollection<OrderInfo> _ordersDetail;
        /// <summary>
        /// Gets or sets the orders details.
        /// </summary>
        /// <value>The orders details.</value>
        public ObservableCollection<OrderInfo> OrdersDetail
        {
            get
            {
                return _ordersDetail;
            }
            set
            {
                _ordersDetail = value;
            }
        }

        /// <summary>
        /// Gets the orders details.
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<OrderInfo> GetOrdersDetail(int count)
        {
            ObservableCollection<OrderInfo> ordersDetail = new ObservableCollection<OrderInfo>();
            for (int i = 10000; i <= count + 10000; i++)
            {
                ordersDetail.Add(GetOrder(i));
            }

            return ordersDetail;
        }

        private OrderInfo GetOrder(int i)
        {
            return new OrderInfo()
            {
                OrderID = i,
                CustomerID = GetCustomerID(i),
                OrderDate = new DateTime(r.Next(2011, 2013), r.Next(1, 12), r.Next(1, 28)),
                ShipName = shipname[r.Next(5)],
                ShippedDate = new DateTime(r.Next(2011, 2013), r.Next(1, 12), r.Next(1, 28)),
                ShipAddress = shipaddress[r.Next(4)],
                ShipCountry = ShipCountry[r.Next(8)],
                Freight = r.Next(20, 60),
            };
        }

        string GetCustomerID(int i)
        {
            if (i % 4 != 0 || i == 0)
                return CustomerID[customerIdCount];
            else
            {
                if (i % 4 == 0)
                    customerIdCount++;

                if (customerIdCount > 9)
                    customerIdCount = 0;

                return CustomerID[customerIdCount];
            }
        }

        string[] shipaddress = new string[]
        {
            "Via Monte Bianco 34",
            "43 rue St.Laurent",
            "Akergatan 24",
            "Vinbalete 34",
            "Smagsloget 45",
            "Torikatu 38",
            "Via Monte Bianco 34",
            "Heerstr 22",
            "Jardim das rosas n.32",
            "90 Wadhurst Rd",
           "Starenwerg 5",
           "Geislweg 14",
           "Erling Skakkes gate 78",
           "Luisenstr.48",
           "187 Suffolk Ln",
           "Av.Copacabana,267",
           "55 Grizzly Peak Rd",
        };

        string[] shipname = new string[]
        {
            "Franchi S.p.A",
            "Mere Paillarde",
            "Folk och fa HB",
            "Simons Bistro",
            "Vaffeljernet",
            "Wartian Herkku",
            "Morgenstern Gesundkost",
            "Furia Bacalhau e Frutos do",
            "Seven Seas Import",
            "Wellington IMporttadora",
            "LINO-Delicateres",
            "B's Bevearages",
            "GROSELLA-Restaurante",
            "Piccolo und mehr",
            "Folies gowmandes",
            "Ernst Handel",
            "LILA-Supermercado",
            "Ottilies Kaseladen",
            "Eastern Connection"
        };

        string[] productName = new string[]
        {
            "Alice Mutton",
            "NuNuCa Nu�-Nougat-Creme",
            "Boston Crab Meat",
            "Raclette Courdavault",
            "Wimmers gute",
            "Gorgonzola Telino",
            "Chartreuse verte",
            "Fl�temysost",
            "Carnarvon Tigers",
            "Th�ringer",
            "Vegie-spread",
            "Tarte au sucre",
            "Konbu",
            "Valkoinen suklaa",
            "Queso Manchego",
            "Perth Pasties",
            "Vegie-spread",
            "Tofu",
            "Sir Rodney's",
            "Manjimup Dried Apples"
        };

        string[] ShipCountry = new string[]
        {

            "Argentina",
            "Austria",
            "Belgium",
            "Brazil",
            "Canada",
            "Denmark",
            "Finland",
            "France",
            "Germany",
            "Ireland",
            "Italy",
            "Mexico",
            "Norway",
            "Poland",
            "Portugal",
            "Spain",
            "Sweden",
            "Switzerland",
            "UK",
            "USA",
            "Venezuela"
        };

        string[] CustomerID = new string[]
        {
            "ALFKI",
            "FRANS",
            "MEREP",
            "FOLKO",
            "SIMOB",
            "WARTH",
            "VAFFE",
            "FURIB",
            "SEVES",
            "LINOD",
            "RISCU",
            "PICCO",
            "BLONP",
            "WELLI",
            "FOLIG",
            "SHIWL",
            "ASDFI",
            "YIWOL",
            "SIEPZ",
            "UIKOC",
            "BNUTQ",
            "FDKIO",
            "UJIKW",
            "QOLPX",
            "WJXKO",
            "SXEWD",
            "ZXSOL",
            "KKMJU",
            "QMICP",
            "SJWII",
            "WDOPO",
            "SAIOP",
            "SSOLE",
            "CUEMC",
            "HWIMQ"
        };
    }
}
