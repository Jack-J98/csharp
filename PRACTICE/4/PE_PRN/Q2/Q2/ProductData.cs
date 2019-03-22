using System.Data;

namespace Q2
{
    class ProductData
    {
        public static DataTable GetAllsProducts()
        {
            string sql = "select * from Products";
            return DataAccess.GetTableBySql(sql);
        }
        public static int DeleteProductByID(int ProductId)
        {
            string sql1 = "delete from [Order Details] where ProductID = " + ProductId.ToString();
            DataAccess.ExecuteQuery(sql1);
            string sql = "delete from Products where ProductID = " + ProductId.ToString();
            return DataAccess.ExecuteQuery(sql);
        }
    }
}
