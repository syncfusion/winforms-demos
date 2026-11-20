using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;


namespace LINQToSQLCE
{
    public partial class Northwind
    {

    }
	#region Schema Class
    public class TerritoryRegion
    {
        public string TerritoryID { get; set; }
        public string TerritoryDescription { get; set; }
        public int RegionID { get; set; }
        public string RegionDescription { get; set; }

    }

    public class EmployeeInfo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public List<TerritoryRegion> TerritoryRegion { get; set; }
    }

    public class GroupedProduct
    {
        public int? CategoryID { get; set; }
        public List<Products> Products { get; set; }
    }
    #endregion
}
