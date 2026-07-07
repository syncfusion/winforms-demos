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
