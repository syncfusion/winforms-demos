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

namespace UnboundRows
{
    /// <summary>
    /// Represents a class that provides the product sales details.
    /// </summary>
    public class ProductSalesDetails : INotifyPropertyChanged
    {
        #region Fields
        private double january;
        private double february;
        private double june;
        private double may;
        private double april;
        private double march;
        private string _name;
        #endregion

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [Display(Name = "Product Name")]
        public string ProductName
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                RaisePropertyChanged("ProductName");
            }
        }

        /// <summary>
        /// Gets or sets the sales details for the customer at january month.
        /// </summary>
        [DataType(DataType.Currency)]
        public double January
        {
            get
            {
                return january;
            }
            set
            {
                january = value;
                RaisePropertyChanged("January");
            }
        }

        /// <summary>
        /// Gets or sets the sales details at February month.
        /// </summary>
        [DataType(DataType.Currency)]
        public double February
        {
            get
            {
                return february;
            }
            set
            {
                february = value;
                RaisePropertyChanged("February");
            }
        }

        /// <summary>
        /// Gets or sets the sales details at march month.
        /// </summary>
        [DataType(DataType.Currency)]
        public double March
        {
            get
            {
                return march;
            }
            set
            {
                march = value;
                RaisePropertyChanged("March");
            }
        }

        /// <summary>
        /// Gets or sets the sales details at april month.
        /// </summary>
        [DataType(DataType.Currency)]
        public double April
        {
            get
            {
                return april;
            }
            set
            {
                april = value;
                RaisePropertyChanged("April");
            }
        }

        /// <summary>
        /// Gets or sets the sales details at may month.
        /// </summary>
        [DataType(DataType.Currency)]
        public double May
        {
            get
            {
                return may;
            }
            set
            {
                may = value;
                RaisePropertyChanged("May");
            }
        }

        /// <summary>
        /// Gets or sets the sales details at june month.
        /// </summary>
        [DataType(DataType.Currency)]
        public double June
        {
            get
            {
                return june;
            }
            set
            {
                june = value;
                RaisePropertyChanged("June");
            }
        }

        /// <summary>
        /// The property changed event occurs when any properly gets changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Occurs when any properly changes in this class.
        /// </summary>
        /// <param name="propertyName">The property name.</param>
        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    /// <summary>
    /// Represents a class that provides the product sales details collection informations.
    /// </summary>
    public class ProductSalesCollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSalesCollection"/> class.
        /// </summary>
        public ProductSalesCollection()
        {
            SalesInfo = this.GetSalesInfo();
        }

        private List<ProductSalesDetails> _salesInfo;

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
        /// Collection of ProductNames
        /// </summary>
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

        /// <summary>
        /// Gets the sales info.
        /// </summary>
        /// <returns></returns>
        public List<ProductSalesDetails> GetSalesInfo()
        {
            Random r = new Random(0);

            int numberOfRecords = 30;
            List<ProductSalesDetails> listOfProductSales = new List<ProductSalesDetails>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                ProductSalesDetails sales = new ProductSalesDetails()
                {
                    ProductName = productName[r.Next(10)],
                    January = r.Next(10000, 100000) * 0.01,
                    February = r.Next(10000, 100000) * 0.01,
                    April = r.Next(10000, 100000) * 0.01,
                    March = r.Next(10000, 100000) * 0.01,
                    May = r.Next(10000, 100000) * 0.01,
                    June = r.Next(10000, 100000) * 0.01,
                };

                listOfProductSales.Add(sales);
            }

            return listOfProductSales;
        }
    }
}
