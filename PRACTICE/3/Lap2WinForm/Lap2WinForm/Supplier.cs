using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Lap2WinForm
{
    class Supplier
    {
        public int SupplierID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public Supplier(int SupplierID, string CompanyName, string ContactName, string ContactTitle)
        {
            this.SupplierID = SupplierID;
            this.CompanyName = CompanyName;
            this.ContactName = ContactName;
            this.ContactTitle = ContactTitle;
        }
        public static List<Supplier> GetAllSupplier()
        {
            DataTable dt = new DataTable();
            List<Supplier> supList = new List<Supplier>();
            dt = DataAccess.getAllSupplier();
            foreach (DataRow dr in dt.Rows)
            {
                supList.Add(new Supplier(
                    Convert.ToInt32(dr["SupplierID"]),
                    dr["CompanyName"].ToString(),
                    dr["ContactName"].ToString(),
                    dr["ContactTitle"].ToString()
                    ));
            }
            return supList;
        }
    }
}
