using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Lap2WinForm
{
    class DataAccess
    {
        public static SqlConnection getConnection()
        {
            string conn = @"server=localhost; database = Northwind; user = sa; password = 123456";
            return new SqlConnection(conn);
        }
        public static DataTable getDataBySql(string sql)
        {
            SqlCommand command = new SqlCommand(sql, getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }
        public static DataTable getAllCategory()
        {
            string sql = @"SELECT [CategoryID],[CategoryName],[Description] FROM [Categories]";
            return getDataBySql(sql);
        }
        public static DataTable getAllSupplier()
        {
            string sql = @"SELECT [SupplierID],[CompanyName],[ContactName],[ContactTitle] FROM [Suppliers]";
            return getDataBySql(sql);
        }
        public static DataTable getAllProduct()
        {
            string sql = @"SELECT [ProductID],[ProductName],[CompanyName],[CategoryName],[UnitPrice],[Discontinued]
                            FROM Products as p inner join Categories as c on p.CategoryID = c.CategoryID
                            inner join Suppliers as s on p.SupplierID = s.SupplierID";
            return getDataBySql(sql);
        }
        public static DataTable getAllOrder()
        {
            string sql = @"SELECT  [OrderID],[CustomerID],[ShipName],[ShipAddress],[ShipCity] FROM [Orders]";
            return getDataBySql(sql);
        }
        public static int ExcuteQuery(string sql)
        {
            SqlCommand command = new SqlCommand(sql, getConnection());
            command.Connection.Open();
            int k = command.ExecuteNonQuery();
            command.Connection.Close();
            return k;
        }
        public static int DeleteProductByID(int ProductID)
        {
            string sql = "delete from [Order Details] where ProductID = " + ProductID.ToString();
            ExcuteQuery(sql);
            sql = "delete from Products where ProductID = " + ProductID.ToString();
            return ExcuteQuery(sql);
        }
        public static DataRow GetProductByID(int ProductID)
        {
            string sql = @"SELECT [ProductID],[ProductName],[CompanyName],[CategoryName],[UnitPrice],[Discontinued]
                        FROM Products as p inner join Categories as c on p.CategoryID = c.CategoryID
                        inner join Suppliers as s on p.SupplierID = s.SupplierID where ProductID = " + ProductID.ToString();
            try
            {
                return getDataBySql(sql).Rows[0];
            }
            catch
            {
                return null;
            }
            
        }
        static public int EditProduct(int productid, string productname, int subID, int catID, double price, bool discontinue)
        {
            string sql = @"update Products set 
                ProductName = @name, 
                SupplierID = @subID,
                CategoryID = @catID,
                UnitPrice = @price,
                Discontinued = @dis    where ProductID = @id";
            SqlCommand command = new SqlCommand(sql, getConnection());
            command.Connection.Open();
            SqlParameter param1 = new SqlParameter("@name", SqlDbType.NVarChar);
            param1.Value = productname;
            command.Parameters.Add(param1);

            SqlParameter param2 = new SqlParameter("@subID", SqlDbType.Int);
            param2.Value = subID;
            command.Parameters.Add(param2);

            SqlParameter param3 = new SqlParameter("@catID", SqlDbType.Int);
            param3.Value = catID;
            command.Parameters.Add(param3);

            SqlParameter param4 = new SqlParameter("@price", SqlDbType.Money);
            param4.Value = price;
            command.Parameters.Add(param4);

            SqlParameter param5 = new SqlParameter("@dis", SqlDbType.Bit);
            param5.Value = discontinue;
            command.Parameters.Add(param5);

            SqlParameter param6 = new SqlParameter("@id", SqlDbType.Int);
            param6.Value = productid;
            command.Parameters.Add(param6);

            int k = command.ExecuteNonQuery();
            command.Connection.Close();
            return k;
        }
        static public int AddProduct(string productname, int subID, int catID, double price, bool discontinue)
        {
            string sql = @"INSERT INTO [Products]
                         ([ProductName]
                         ,[SupplierID]
                         ,[CategoryID]
                         ,[UnitPrice]
                         ,[Discontinued])
                         VALUES (@name, @subID, @catID, @price, @dis)";
            SqlCommand command = new SqlCommand(sql, getConnection());
            command.Connection.Open();
            SqlParameter param1 = new SqlParameter("@name", SqlDbType.NVarChar);
            param1.Value = productname;
            command.Parameters.Add(param1);

            SqlParameter param2 = new SqlParameter("@subID", SqlDbType.Int);
            param2.Value = subID;
            command.Parameters.Add(param2);

            SqlParameter param3 = new SqlParameter("@catID", SqlDbType.Int);
            param3.Value = catID;
            command.Parameters.Add(param3);

            SqlParameter param4 = new SqlParameter("@price", SqlDbType.Money);
            param4.Value = price;
            command.Parameters.Add(param4);

            SqlParameter param5 = new SqlParameter("@dis", SqlDbType.Bit);
            param5.Value = discontinue;
            command.Parameters.Add(param5);

            int k = command.ExecuteNonQuery();
            command.Connection.Close();
            return k;
        }
    }
}
