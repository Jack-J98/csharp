using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Lap2WinForm
{
    class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public Order(int OrderID, string CustomerID, string ShipName, string ShipAddress, string ShipCity)
        {
            this.OrderID = OrderID;
            this.CustomerID = CustomerID;
            this.ShipName = ShipName;
            this.ShipAddress = ShipAddress;
            this.ShipCity = ShipCity;        
        }
        public static List<Order> getAllOrder()
        {
            DataTable dt = new DataTable();
            List<Order> orderList = new List<Order>();
            dt = DataAccess.getAllOrder();
            foreach (DataRow dr in dt.Rows)
            {
                orderList.Add(new Order(
                    Convert.ToInt32(dr["OrderID"]),
                    dr["CustomerID"].ToString(),
                    dr["ShipName"].ToString(),
                    dr["ShipAddress"].ToString(),
                    dr["ShipCity"].ToString()));
            }
            return orderList;
        }

    }
}
