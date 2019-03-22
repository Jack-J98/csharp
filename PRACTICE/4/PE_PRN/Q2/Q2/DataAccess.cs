using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Q2
{
    public class DataAccess
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectString"].ToString();
            return new SqlConnection(connectionString);
        }
        public static DataTable GetTableBySql(string query)
        {
            SqlCommand command = new SqlCommand(query, GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet);

            return dataSet.Tables[0];
        }
        public static int ExecuteQuery(string sql)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            command.Connection.Open();
            return command.ExecuteNonQuery();
        }
    }
}
