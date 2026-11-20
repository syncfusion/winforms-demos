#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace AddNewRow
{
    /// <summary>
    /// Represents a class that contains the product sales details collection.
    /// </summary>
    public class ProductSalesDetailsCollection
    {
        /// <summary>
        /// It contains the list of product sales details.
        /// </summary>
        private List<ProductSalesDetails> _salesInfo;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSalesDetailsCollection"/> class.
        /// </summary>
        public ProductSalesDetailsCollection()
        {
            SalesInfo = this.GetSalesInfo();
        }

        /// <summary>
        /// Gets or sets the sales info.
        /// </summary>
        /// <value>The sales info.</value>
        public List<ProductSalesDetails> SalesInfo
        {
            get
            {
                return _salesInfo;
            }
            set
            {
                _salesInfo = value;
            }
        }

        /// <summary>
        /// Gets the sales info.
        /// </summary>
        /// <returns></returns>
        public List<ProductSalesDetails> GetSalesInfo()
        {
            /// Geography
            string[] countries = new string[] { "Australia", "Canada", "France", "Germany", "United States" };
            string[] ausStates = new string[] { "New South Wales", "Queensland", "South Australia", "Tasmania", "Victoria" };
            string[] canadaStates = new string[] { "Alberta", "British Columbia", "Brunswick", "Manitoba", "Ontario", "Quebec" };
            string[] franceStates = new string[] { "Charente-Maritime", "Essonne", "Garonne (Haute)", "Gers", };
            string[] germanyStates = new string[] { "Bayern", "Brandenburg", "Hamburg", "Hessen", "Nordrhein-Westfalen", "Saarland" };

            string[] ussStates = new string[] { "New York", "North Carolina", "Alabama", "California", "Colorado", "New Mexico", "South Carolina" };

            /// Products
            string[] products = new string[] { "Bike", "Car", "Truck", "Van", "BiCycle" };
            Random r = new Random(0);

            int numberOfRecords = 30;
            List<ProductSalesDetails> listOfProductSales = new List<ProductSalesDetails>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                ProductSalesDetails sales = new ProductSalesDetails();
                sales.Country = countries[r.Next(1, countries.GetLength(0))];
                sales.Quantity = r.Next(1, 12);
                sales.Discount = sales.Quantity;
                sales.Amount = (30000 * sales.Quantity);
                sales.Product = products[r.Next(r.Next(products.GetLength(0) + 1))];
                switch (sales.Country)
                {
                    case "Australia":
                        {
                            sales.State = ausStates[r.Next(ausStates.GetLength(0))];
                            break;
                        }
                    case "Canada":
                        {
                            sales.State = canadaStates[r.Next(canadaStates.GetLength(0))];
                            break;
                        }
                    case "France":
                        {
                            sales.State = franceStates[r.Next(franceStates.GetLength(0))];
                            break;
                        }
                    case "Germany":
                        {
                            sales.State = germanyStates[r.Next(germanyStates.GetLength(0))];
                            break;
                        }
                    case "United States":
                        {
                            sales.State = ussStates[r.Next(ussStates.GetLength(0))];
                            break;
                        }
                }

                listOfProductSales.Add(sales);
            }

            return listOfProductSales;
        }
    }

    /// <summary>
    /// Represents a class that contains the product sales details.
    /// </summary>
    public class ProductSalesDetails : INotifyPropertyChanged
    {
        #region Fields

        private string _product;

        private string _country;

        private string _state;

        private int _quantity;

        private double _discount;

        private double _amount;

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        /// <summary>
        /// Gets or sets the product.
        /// </summary>
        /// <value>The product.</value>
        [Display(Name = "Product")]
        public string Product
        {
            get
            {
                return _product;
            }
            set
            {
                _product = value;
                RaisePropertyChanged("Product");
            }
        }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>The country.</value>
        [Display(Name = "Country")]
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
                RaisePropertyChanged("Country");
            }
        }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        [Display(Name = "State")]
        public string State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
                RaisePropertyChanged("State");
            }
        }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>The quantity.</value>
        [Display(Name = "Quantity")]
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
                RaisePropertyChanged("Quantity");
            }
        }

        /// <summary>
        /// Gets or sets the discount.
        /// </summary>
        /// <value>The discount.</value>
        [DisplayFormat(DataFormatString = "{0}%")]
        [Display(Name = "Discount")]
        public double Discount
        {
            get
            {
                return _discount;
            }
            set
            {
                _discount = value;
                RaisePropertyChanged("Discount");
            }
        }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>The amount.</value>
        [DataType(DataType.Currency)]
        [Display(Name = "Amount")]
        public double Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
                RaisePropertyChanged("Amount");
            }
        }

        /// <summary>
        /// Occurs when any property value changed.
        /// </summary>
        /// <param name="propertyName">The name of the property which was changed.</param>
        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
