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
    public class Student_DAO : Base
    {
      
        public List<Student> Db_Get_All_Students()
        {
            string query = "SELECT Student_Id, student_Fname, student_Lname, Date_Of_Birth FROM Student";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    Number = int.Parse( dr["Student_id"].ToString()),
                    FName = (String)(dr["student_Fname"].ToString()),
                    LName = (String)(dr["student_Lname"].ToString()),
                    BirthDate = DateTime.Parse((dr["Date_Of_Birth"]).ToString())
                };
                students.Add(student);
            }
            return students;
        }

    }
}
