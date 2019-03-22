using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Lap2WinForm
{
    class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string CompanyName { get; set; }
        public string CategoryName { get; set; }
        public double UnitPrice { get; set; }
        public bool Discontinued { get; set; }

        public Product(int ProductID, string ProductName, string CompanyName,string CategoryName, double UnitPrice,  bool Discontinued)
        {
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.CompanyName = CompanyName;
            this.CategoryName = CategoryName;
            this.UnitPrice = UnitPrice;
            this.Discontinued = Discontinued;
        }

        public static List<Product> getAllProduct()
        {
            List<Product> proList = new List<Product>();
            DataTable dt = new DataTable();
            dt = DataAccess.getAllProduct();
            foreach (DataRow dr in dt.Rows)
            {
                proList.Add(new Product(
                    Convert.ToInt32(dr["ProductID"]),
                    dr["ProductName"].ToString(),
                    dr["CompanyName"].ToString(),
                    dr["CategoryName"].ToString(),
                    Convert.ToDouble(dr["UnitPrice"]),
                    Convert.ToBoolean(dr["Discontinued"])));
            }
            return proList;
        }

        public static int DeleteProductByID(int ProductID)
        {
            return DataAccess.DeleteProductByID(ProductID);
        }

        public static Product GetProductByID(int ProductID)
        {
            DataRow dr = DataAccess.GetProductByID(ProductID);
            return new Product(
                    Convert.ToInt32(dr["ProductID"]),
                    dr["ProductName"].ToString(),
                    dr["CompanyName"].ToString(),
                    dr["CategoryName"].ToString(),
                    Convert.ToDouble(dr["UnitPrice"]),
                    Convert.ToBoolean(dr["Discontinued"]));
        }

        public static int EditProduct(int productid, string productname, int subID, int catID, double price, bool discontinue)
        {
            return DataAccess.EditProduct(productid, productname, subID, catID, price, discontinue);
        }

        public static int AddProduct(string productname, int subID, int catID, double price, bool discontinue)
        {
            return DataAccess.AddProduct(productname, subID, catID, price, discontinue);
        }
    }
}
