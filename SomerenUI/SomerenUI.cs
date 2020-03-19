using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void showPanel(string panelName)
        {

            if(panelName == "Dashboard")
            {

                // hide all other panels
                pnl_Students.Hide();
                pnl_Teachers.Hide();

                // show dashboard
                pnl_Dashboard.Show();
                img_Dashboard.Show();
            }
            else if(panelName == "Students")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Teachers.Hide();

                // show students
                pnl_Students.Show();

                

                // fill the students listview within the students panel with a list of students
                SomerenLogic.Student_Service studService = new SomerenLogic.Student_Service();
                List<Student> studentList = studService.GetStudents();

                // clear the listview before filling it again
                listViewStudents.Clear();
                listViewStudents.View = View.Details; // Enable rows
                listViewStudents.Columns.Add("Student ID"); // Add colums
                listViewStudents.Columns.Add("First Name");
                listViewStudents.Columns.Add("Last Name");
                listViewStudents.Columns.Add("Date Of Birth");

                foreach (SomerenModel.Student s in studentList)
                {
                    ListViewItem li = new ListViewItem(new String[] { s.Number.ToString(), s.FName, s.LName, s.BirthDate.ToString() });
                    listViewStudents.Items.Add(li); // Add each student to new listitem row
                }
                listViewStudents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent); //Auto resize colums to fit data
                listViewStudents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); // Make sure headers fit

            }
            else if (panelName == "Teachers")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Students.Hide();

                // show teachers
                pnl_Teachers.Show();



                // fill the teachers listview within the teacher panel with a list of lecturers
                SomerenLogic.Teacher_Service teacService = new SomerenLogic.Teacher_Service();
                List<Teacher> TeacherList = teacService.GetTeachers();

                // clear the listview before filling it again
                listViewTeachers.Clear();
                listViewTeachers.View = View.Details;
                listViewTeachers.Columns.Add("Teacher_ID");
                listViewTeachers.Columns.Add("First Name");
                listViewTeachers.Columns.Add("Subject");

                foreach (SomerenModel.Teacher t in TeacherList)
                {

                    ListViewItem li = new ListViewItem(new String[] { t.Id.ToString(), t.Name, t.Subject });
                    listViewTeachers.Items.Add(li);
                }
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void img_Dashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Students");
        }

        private void listViewStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Teachers");
        }

        private void listviewteachers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnl_Students_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_Teachers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_Students_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
