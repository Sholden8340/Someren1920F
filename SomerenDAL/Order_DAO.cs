using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class Order_DAO : Base
    {
      
        public List<Order> Db_Get_All_Orders()
        {
            string query = "SELECT * FROM Order";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    DrinkID = int.Parse( dr["Order_ID"].ToString()),
                    StudentID = int.Parse( dr["Student_ID"].ToString()),
                    Total = int.Parse( dr["Total"].ToString()),
                };
                orders.Add(order);
            }
            return orders;
        }

        public void RecordOrder(Order o)
        {
            string query = "INSERT INTO Orders(Drink, Total, Customer) " +
                $"VALUES ({o.DrinkID}, {o.Total}, {o.StudentID})";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteSelectQuery(query, sqlParameters);
        }

    }
}
