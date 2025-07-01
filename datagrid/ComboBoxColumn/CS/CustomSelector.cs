#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxColumn
{
    public class CustomSelector : IDataSourceSelector
    {
        public IEnumerable GetDataSource(object record, object dataSource)
        {
            if (record == null)
                return null;

            var orderinfo = record as OrderDetails;
            var countryName = orderinfo.ShipCountry;

            var countryDetails = new CountryInfoRepository();

            //Returns ShipCity collection based on ShipCountry.
            if (countryDetails.ShipCities.ContainsKey(countryName))
            {
                ObservableCollection<ShipCityDetails> shipcities = null;
                countryDetails.ShipCities.TryGetValue(countryName, out shipcities);
                return shipcities.ToList();
            }
            return null;
        }
    }
}
