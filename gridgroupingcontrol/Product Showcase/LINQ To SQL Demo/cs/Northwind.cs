using System.Collections.Generic;

namespace LINQToSQL
{
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
        public List<Product> Products { get; set; }
    }
    #endregion

    partial class NorthwindDataContext
    {

        static NorthwindDataContext db = null;

        public static NorthwindDataContext DataContext
        {
            get
            {
                if (db == null)
                    db = new NorthwindDataContext();
                return db;
            }
        }
    }

}

namespace LINQToSQLCE
{

    partial class Northwind
    {
        static Northwind db = null;
        public static Northwind DataContext
        {
            get
            {
                if (db == null)
                    db = new Northwind();
                return db;
            }
        }
    }
}