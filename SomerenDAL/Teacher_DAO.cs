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
    public class Teacher_DAO : Base
    {

        public List<Teacher> Db_Get_All_Teachers()
        {
            string query = "SELECT * FROM [Teacher]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> Teachers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher Teacher = new Teacher()
                {
                    Id = int.Parse(dr["Teacher_id"].ToString()),
                    TName = (dr["Teacher_name"].ToString()),
                    Subject = (dr["Subject_Name"].ToString()),
                    Person = int.Parse(dr["Person_id"].ToString()),
                };
                Teachers.Add(Teacher);
            }
            return Teachers;
        }

    }
}
