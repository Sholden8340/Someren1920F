using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenDAL;
using SomerenModel;

namespace SomerenLogic
{
    public class Activity_Service
    {
        Activity_DAO Activity_db = new Activity_DAO();

        public List<Activity> GetActivities()
        {
            try
            {
                List<Activity> Activity = Activity_db.Db_Get_All_Activities();
                return Activity;
            }
            catch (Exception)
            {
                return new List<Activity>
                {
                    new Activity
                    {
                        ID = 110001 ,
                        Name = "test",
                        Description = "broken",
                        NumberOfStudents = 1000,
                        NumberOfSupervisors = 89
                    }
                };
            }

        }

        public void AddActivity(Activity Activity)
        {
            try
            {
                Activity_db.AddActvity(Activity);
            }
            catch (Exception e)
            {
                MessageBox.Show("There was an error adding to the Database \n" + e, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
        public void EditActivity(Activity Activity)
        {
            try
            {
                Activity_db.EditActvity(Activity);
            }
            catch (Exception e)
            {
                MessageBox.Show("There was an error adding to the Database \n" + e, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RemoveActivity(int id)
        {
            try
            {
                Activity_db.RemoveActvity(id);
            }
            catch (Exception e)
            {
               MessageBox.Show("There was an error adding to the Database \n" + e, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
