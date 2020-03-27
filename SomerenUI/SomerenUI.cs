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
            
            //maximize panels
            pnl_Cash_Register.Dock = DockStyle.Fill;
            pnl_Dashboard.Dock = DockStyle.Fill;
            pnl_Students.Dock = DockStyle.Fill;
            pnl_Teachers.Dock = DockStyle.Fill;
            pnl_Activities.Dock = DockStyle.Fill;


            showPanel("Dashboard");
        }

        private void showPanel(string panelName)
        {

            if (panelName == "Dashboard")
            {
                selectPanel(panelName);
            }
            else if (panelName == "Students")
            {
                selectPanel(panelName); //hide other panels and show relevant 

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

                selectPanel(panelName);

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

                    ListViewItem li = new ListViewItem(new String[] { t.Id.ToString(), t.TName, t.Subject });
                    listViewTeachers.Items.Add(li);
                }

                listViewTeachers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent); //Auto resize colums to fit data
                listViewTeachers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); // Make sure headers fit
            }
            else if (panelName == "Cash_Register")
            {
                selectPanel(panelName);

                SomerenLogic.Student_Service studService = new SomerenLogic.Student_Service();
                List<Student> studentList = studService.GetStudents();

                //SomerenLogic.Drink_Service drink_Service = new SomerenLogic.Drink_Service();
                //List<Drinks> drinkList = drink_Service.GetDrinks();

                List<Drinks> drinkList = new List<Drinks>();
                Drinks drink = new Drinks();
                {
                    drink.Drinkid = 1;
                    drink.DrinkName = "Test Drink";
                    drink.Stock = 10;
                    drink.DrinkType = "Alcohlic";
                    drink.Price = 2;
                    drink.TotalSales = 200;
                }

                drinkList.Add(drink);

                foreach (SomerenModel.Student s in studentList)
                {
                    ListViewItem li = new ListViewItem(new String[] { s.Number.ToString(), s.FName, s.LName, s.BirthDate.ToString() });
                    registerListStudents.Items.Add($"{s.Number} {s.FName} {s.LName}");
                }

                foreach (SomerenModel.Drinks d in drinkList)
                {
                    ListViewItem li = new ListViewItem(new String[] {d.DrinkName}, d.Price.ToString());
                    registerListDrinks.Items.Add($"{d.Drinkid} {d.DrinkName} - {d.Price} Tokens"); 
                }

            }
            else if(panelName == "Activities")
            {
                selectPanel(panelName);

                // fill the teachers listview within the teacher panel with a list of lecturers
                SomerenLogic.Activity_Service activityService = new SomerenLogic.Activity_Service();
                List<Activity> ActivityList = activityService.GetActivities();

                // clear the listview before filling it again
                listViewActivities.Clear();
                listViewActivities.View = View.Details;
                listViewActivities.Columns.Add("ID");
                listViewActivities.Columns.Add("Name");
                listViewActivities.Columns.Add("Description");
                listViewActivities.Columns.Add("No. of Students");
                listViewActivities.Columns.Add("No. of Teachers");

                foreach (SomerenModel.Activity a in ActivityList)
                {

                    ListViewItem li = new ListViewItem(new String[] { a.ID.ToString(), a.Name, a.Description, a.NumberOfStudents.ToString(), a.NumberOfSupervisors.ToString() });
                    listViewActivities.Items.Add(li);
                }

                listViewActivities.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent); //Auto resize colums to fit data
                listViewActivities.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); // Make sure headers fit
            }
        }

        private void selectPanel(string panel)
        {
            pnl_Dashboard.Hide();
            //img_Dashboard.Hide();
            pnl_Students.Hide();
            pnl_Teachers.Hide();
            pnl_Cash_Register.Hide();
            pnl_Activities.Hide();

            switch (panel)
            {
                case "Dashboard":
                    pnl_Dashboard.Show();
                    //img_Dashboard.Show();
                    break;

                case "Students":
                    pnl_Students.Show();
                    break;

                case "Teachers":
                    pnl_Teachers.Show();
                    break;

                case "Drinks":
                    //pnl_Drinks.Show();
                    break;

                case "Cash_Register":
                    pnl_Cash_Register.Show();
                    break;
                case "Activities":
                    pnl_Activities.Show();
                    break;
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cashRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Cash_Register");
        }

        private void pnl_Register_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void registerListStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            SomerenLogic.Register_Service register = new SomerenLogic.Register_Service();
            register.Checkout(registerListStudents.SelectedItem.ToString(), registerListDrinks.SelectedItem.ToString());
        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Activities");
        }

        private void buttonAddActivity_Click(object sender, EventArgs e)
        {
            groupBoxEdit.Text = "Add";
            groupBoxEdit.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEditActivity_Click(object sender, EventArgs e)
        {
            if(listViewActivities.SelectedItems.Count > 0)
            {
                groupBoxEdit.Text = "Edit";
                groupBoxEdit.Show();

                ListViewItem item = listViewActivities.SelectedItems[0];


                textBoxActivityName.Text = item.SubItems[1].Text;
                textBoxActivityDescription.Text = item.SubItems[2].Text;
                textBoxActivityStudents.Text = item.SubItems[3].Text;
                textBoxActivitySupervisors.Text= item.SubItems[4].Text;
            }
            else
            {
                MessageBox.Show("You must select an Activity to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteActivity_Click(object sender, EventArgs e)
        {
            groupBoxEdit.Hide();

            ListViewItem item = listViewActivities.SelectedItems[0];
            Activity_Service activitydb = new Activity_Service();

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this activity?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                activitydb.RemoveActivity(int.Parse(item.SubItems[0].Text));
            }

            showPanel("Activities");
        }

        private void buttonActivitySave_Click(object sender, EventArgs e)
        {
            
            if (textBoxActivityDescription.Text != null && textBoxActivityName.Text != null && textBoxActivityStudents.Text != null && textBoxActivitySupervisors.Text != null)
            {
                Activity_Service activitydb = new Activity_Service();
                if (groupBoxEdit.Text == "Add")
                {
                    Activity a = new Activity
                    {
                        ID = -1,
                        Name = textBoxActivityName.Text,
                        Description = textBoxActivityDescription.Text,
                        NumberOfStudents = int.Parse(textBoxActivityStudents.Text),
                        NumberOfSupervisors = int.Parse(textBoxActivitySupervisors.Text),
                    };
                    activitydb.AddActivity(a);
                }
                else if(groupBoxEdit.Text == "Edit")
                {
                    ListViewItem item = listViewActivities.SelectedItems[0];
                    Activity a = new Activity
                    {
                        ID = int.Parse(item.SubItems[0].Text),
                        Name = textBoxActivityName.Text,
                        Description = textBoxActivityDescription.Text,
                        NumberOfStudents = int.Parse(textBoxActivityStudents.Text),
                        NumberOfSupervisors = int.Parse(textBoxActivitySupervisors.Text),
                    };
                    activitydb.EditActivity(a);
                }

                showPanel("Activities");
            }
            else
            {
                MessageBox.Show("Fields cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listViewActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBoxEdit.Hide();
        }
    }
}
