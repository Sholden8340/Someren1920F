using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenLogic
{
    public class Teacher_Service
    {
        Teacher_DAO Teacher_db = new Teacher_DAO();

        public List<Teacher> GetTeachers()
        {
            try
            {
                List<Teacher> Teachers = Teacher_db.Db_Get_All_Teachers();
                return Teachers;
            }
            catch (Exception)
            {
                return new List<Teacher>
                {
                    new Teacher
                    {
                        Id = 50101,
                        TName = "Peter Stikker",
                        Person = 20101,
                        Subject = "Mathematics"
                    }
                };
            }

        }
    }
}
