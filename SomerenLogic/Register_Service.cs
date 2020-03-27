using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenLogic
{
    public class Register_Service
    {

        public void Checkout(String s, String d)
        {
            MessageBox.Show($"{s} /n {d}", "Checkout Data", MessageBoxButtons.OK);

            SomerenLogic.Drink_Service drink_Service = new SomerenLogic.Drink_Service();
            List<Drinks> drinkList = drink_Service.GetDrinks();

            String[] student = s.Split(' ');
            String[] drink = d.Split(' ');


            Order o = new Order
            {
                DrinkID = int.Parse(student[0]),
                StudentID = int.Parse(student[0]),
                Total = drinkList[drinkList.FindIndex(item => item.Drinkid == int.Parse(drink[0]))].Price,
            };

            Order_DAO order_DB = new Order_DAO();
            order_DB.RecordOrder(o);
        }
    }
}
