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
    public class Drink_DAO : Base
    {
        public List <Drinks> Db_Get_All_Drinks()
        {
           string query = "SELECT Drink_id, Drink_Name, Drink_Type, Stock, Price, COUNT(*) AS [Sold Drinks]" +
            "FROM Drink AS D JOIN[Order] AS O ON D.OrderNumber = O.Order_id" +
            "GROUP BY Drink_id, d.Drink_Name, Drink_Type, Stock, Price" +
            "HAVING D.Stock > 1";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List <Drinks> ReadTables(DataTable dataTable)
        {
            List<Drinks> drinks = new List<Drinks>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Drinks drink = new Drinks();
                {
                    drink.Drinkid = (int)(dr["Drink_id"]);
                    drink.DrinkName = (string)(dr["Drink_Name"].ToString());
                    drink.Stock = (int)(dr["Stock"]);
                    drink.DrinkType = (string)(dr["Drink_Type"]);
                    drink.Price = (float)(dr["Price"]);
                    drink.TotalSales = (int)(dr["Sold Drinks"]);
                }
                drinks.Add(drink);
            }
            return drinks;
        }
        public void update(int id, string UpName, int UpStock)
        {
            Console.WriteLine("yes");
            string query = "UPDATE Drinks SET Drink_Name = @UpName, Stock = @UpStock WHERE Drink_id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter();
            sqlParameters[1] = new SqlParameter();
            sqlParameters[2] = new SqlParameter();
            sqlParameters[0].ParameterName = "UpName";
            sqlParameters[0].Value = UpName;
            sqlParameters[1].ParameterName = "UpStock";
            sqlParameters[1].Value = UpStock;
            sqlParameters[2].ParameterName = "id";
            sqlParameters[2].Value = id;
            ExecuteEditQuery(query, sqlParameters);
        }

    }
}
