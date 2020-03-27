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
        }

        private void selectPanel(string panel)
        {
            pnl_Dashboard.Hide();
            //img_Dashboard.Hide();
            pnl_Students.Hide();
            pnl_Teachers.Hide();
            pnl_Cash_Register.Hide();

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
    }
}
