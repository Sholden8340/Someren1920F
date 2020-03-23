using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenLogic
{
    public class Drink_Service
    {
        Drink_DAO Drink_db = new Drink_DAO();

        public List<Drinks> GetDrinks()
        {
            try
            {
                List<Drinks> Drinks = Drink_db.Db_Get_All_Drinks();
                return Drinks;
            }
            catch (Exception)
            {
                return new List<Drinks>
                {
                    new Drinks
                    {
                        Drinkid = 110001 ,
                        DrinkName = "Mojito",
                        DrinkType = "Alcholic",
                        Stock = 10,
                        Price = 8
                    }
                };
            }

        }
    }

}
