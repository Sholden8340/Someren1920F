using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;
using System.Windows.Forms;

namespace SomerenDAL
{
    public class Activity_DAO : Base
    {
      
        public List<Activity> Db_Get_All_Activities()
        {
            string query = "SELECT * FROM Activities";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> activities = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Activity activity = new Activity()
                {
                    ID = int.Parse( dr["Activity_ID"].ToString()),
                    Name = dr["Name"].ToString(),
                    Description = dr["Description"].ToString(),
                    NumberOfStudents = int.Parse( dr["number_of_Students"].ToString()),
                    NumberOfSupervisors = int.Parse( dr["number_of_Supervisors"].ToString()),
                };
                activities.Add(activity);
            }
            return activities;
        }

        public void AddActvity(Activity a)
        {
            string query = "INSERT INTO Activities([Name], [Description], [number_of_Students], [number_of_Supervisors]) " +
                $"VALUES ('{a.Name}', '{a.Description}', {a.NumberOfStudents}, {a.NumberOfSupervisors})";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteSelectQuery(query, sqlParameters);
        }        
        
        public void EditActvity(Activity a)
        {
            string query = "UPDATE Activities " +
                $"SET [Name] = '{a.Name}',  [Description] = '{a.Description}', [number_of_Students] = {a.NumberOfStudents}, [number_of_Supervisors] =  {a.NumberOfSupervisors} " +
                $"WHERE Activity_ID = {a.ID}";

            //MessageBox.Show(query);

            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteSelectQuery(query, sqlParameters);
        }

        public void RemoveActvity(int id)
        {
            string query = "DELETE FROM Activities " +
            $"WHERE Activity_ID = {id}";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteSelectQuery(query, sqlParameters);
        }
    }
}
