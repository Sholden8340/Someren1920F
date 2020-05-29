namespace SomerenUI
{
    partial class SomerenUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Dashboard = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Dashboard = new System.Windows.Forms.Label();
            this.pnl_Students = new System.Windows.Forms.Panel();
            this.lbl_Students = new System.Windows.Forms.Label();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.studentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_Teachers = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewTeachers = new System.Windows.Forms.ListView();
            this.Lecturer_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lecturer_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_Cash_Register = new System.Windows.Forms.Panel();
            this.buttonCheckout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.registerListDrinks = new System.Windows.Forms.ListBox();
            this.registerListStudents = new System.Windows.Forms.ListBox();
            this.labelCashRegister = new System.Windows.Forms.Label();
            this.pnl_Activities = new System.Windows.Forms.Panel();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.textBoxActivitySupervisors = new System.Windows.Forms.NumericUpDown();
            this.textBoxActivityStudents = new System.Windows.Forms.NumericUpDown();
            this.buttonActivitySave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxActivityDescription = new System.Windows.Forms.TextBox();
            this.textBoxActivityName = new System.Windows.Forms.TextBox();
            this.buttonDeleteActivity = new System.Windows.Forms.Button();
            this.buttonAddActivity = new System.Windows.Forms.Button();
            this.buttonEditActivity = new System.Windows.Forms.Button();
            this.listViewActivities = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnl_Dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_Students.SuspendLayout();
            this.pnl_Teachers.SuspendLayout();
            this.pnl_Cash_Register.SuspendLayout();
            this.pnl_Activities.SuspendLayout();
            this.groupBoxEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxActivitySupervisors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxActivityStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.lecturersToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.roomsToolStripMenuItem,
            this.cashRegisterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem1,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.dashboardToolStripMenuItem.Text = "Application";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            this.dashboardToolStripMenuItem1.Click += new System.EventHandler(this.dashboardToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(128, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // lecturersToolStripMenuItem
            // 
            this.lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            this.lecturersToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.lecturersToolStripMenuItem.Text = "Lecturers";
            this.lecturersToolStripMenuItem.Click += new System.EventHandler(this.lecturersToolStripMenuItem_Click);
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.activitiesToolStripMenuItem.Text = "Activities";
            this.activitiesToolStripMenuItem.Click += new System.EventHandler(this.activitiesToolStripMenuItem_Click);
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.roomsToolStripMenuItem.Text = "Rooms";
            // 
            // cashRegisterToolStripMenuItem
            // 
            this.cashRegisterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drinksToolStripMenuItem});
            this.cashRegisterToolStripMenuItem.Name = "cashRegisterToolStripMenuItem";
            this.cashRegisterToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.cashRegisterToolStripMenuItem.Text = "Cash Register";
            this.cashRegisterToolStripMenuItem.Click += new System.EventHandler(this.cashRegisterToolStripMenuItem_Click);
            // 
            // drinksToolStripMenuItem
            // 
            this.drinksToolStripMenuItem.Name = "drinksToolStripMenuItem";
            this.drinksToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.drinksToolStripMenuItem.Text = "Drinks";
            this.drinksToolStripMenuItem.Click += new System.EventHandler(this.drinksToolStripMenuItem_Click);
            // 
            // pnl_Dashboard
            // 
            this.pnl_Dashboard.Controls.Add(this.pictureBox1);
            this.pnl_Dashboard.Controls.Add(this.lbl_Dashboard);
            this.pnl_Dashboard.Location = new System.Drawing.Point(25, 42);
            this.pnl_Dashboard.Name = "pnl_Dashboard";
            this.pnl_Dashboard.Size = new System.Drawing.Size(200, 100);
            this.pnl_Dashboard.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(809, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Dashboard
            // 
            this.lbl_Dashboard.AutoSize = true;
            this.lbl_Dashboard.Location = new System.Drawing.Point(12, 21);
            this.lbl_Dashboard.Name = "lbl_Dashboard";
            this.lbl_Dashboard.Size = new System.Drawing.Size(185, 13);
            this.lbl_Dashboard.TabIndex = 1;
            this.lbl_Dashboard.Text = "Welcome to the Someren Application!";
            this.lbl_Dashboard.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnl_Students
            // 
            this.pnl_Students.Controls.Add(this.lbl_Students);
            this.pnl_Students.Controls.Add(this.listViewStudents);
            this.pnl_Students.Location = new System.Drawing.Point(255, 45);
            this.pnl_Students.Name = "pnl_Students";
            this.pnl_Students.Size = new System.Drawing.Size(198, 100);
            this.pnl_Students.TabIndex = 4;
            this.pnl_Students.Visible = false;
            this.pnl_Students.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Students_Paint);
            // 
            // lbl_Students
            // 
            this.lbl_Students.AutoSize = true;
            this.lbl_Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Students.Location = new System.Drawing.Point(29, 16);
            this.lbl_Students.Name = "lbl_Students";
            this.lbl_Students.Size = new System.Drawing.Size(107, 29);
            this.lbl_Students.TabIndex = 3;
            this.lbl_Students.Text = "Students";
            this.lbl_Students.Click += new System.EventHandler(this.lbl_Students_Click);
            // 
            // listViewStudents
            // 
            this.listViewStudents.AllowColumnReorder = true;
            this.listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentID,
            this.studentName,
            this.studentDOB});
            this.listViewStudents.GridLines = true;
            this.listViewStudents.HideSelection = false;
            this.listViewStudents.LabelWrap = false;
            this.listViewStudents.Location = new System.Drawing.Point(34, 48);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(659, 222);
            this.listViewStudents.TabIndex = 5;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            this.listViewStudents.SelectedIndexChanged += new System.EventHandler(this.listViewStudents_SelectedIndexChanged);
            // 
            // studentID
            // 
            this.studentID.Text = "ID";
            // 
            // studentName
            // 
            this.studentName.Text = "Name";
            // 
            // studentDOB
            // 
            this.studentDOB.Text = "Date of Birth";
            // 
            // pnl_Teachers
            // 
            this.pnl_Teachers.Controls.Add(this.label1);
            this.pnl_Teachers.Controls.Add(this.listViewTeachers);
            this.pnl_Teachers.Location = new System.Drawing.Point(25, 199);
            this.pnl_Teachers.Name = "pnl_Teachers";
            this.pnl_Teachers.Size = new System.Drawing.Size(198, 97);
            this.pnl_Teachers.TabIndex = 6;
            this.pnl_Teachers.Visible = false;
            this.pnl_Teachers.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Teachers_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lecturers";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // listViewTeachers
            // 
            this.listViewTeachers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Lecturer_Id,
            this.Lecturer_Name,
            this.Subject});
            this.listViewTeachers.HideSelection = false;
            this.listViewTeachers.Location = new System.Drawing.Point(34, 64);
            this.listViewTeachers.Name = "listViewTeachers";
            this.listViewTeachers.Size = new System.Drawing.Size(279, 259);
            this.listViewTeachers.TabIndex = 0;
            this.listViewTeachers.UseCompatibleStateImageBehavior = false;
            this.listViewTeachers.View = System.Windows.Forms.View.Details;
            this.listViewTeachers.SelectedIndexChanged += new System.EventHandler(this.listviewteachers_SelectedIndexChanged);
            // 
            // Lecturer_Id
            // 
            this.Lecturer_Id.Text = "Lecturer Id";
            this.Lecturer_Id.Width = 67;
            // 
            // Lecturer_Name
            // 
            this.Lecturer_Name.Text = "Lecturer Name";
            this.Lecturer_Name.Width = 94;
            // 
            // Subject
            // 
            this.Subject.Text = "Subject Name";
            this.Subject.Width = 87;
            // 
            // pnl_Cash_Register
            // 
            this.pnl_Cash_Register.Controls.Add(this.buttonCheckout);
            this.pnl_Cash_Register.Controls.Add(this.label3);
            this.pnl_Cash_Register.Controls.Add(this.label2);
            this.pnl_Cash_Register.Controls.Add(this.registerListDrinks);
            this.pnl_Cash_Register.Controls.Add(this.registerListStudents);
            this.pnl_Cash_Register.Controls.Add(this.labelCashRegister);
            this.pnl_Cash_Register.Location = new System.Drawing.Point(255, 199);
            this.pnl_Cash_Register.Name = "pnl_Cash_Register";
            this.pnl_Cash_Register.Size = new System.Drawing.Size(198, 97);
            this.pnl_Cash_Register.TabIndex = 7;
            this.pnl_Cash_Register.Visible = false;
            this.pnl_Cash_Register.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Register_Paint);
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.Location = new System.Drawing.Point(544, 94);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(75, 23);
            this.buttonCheckout.TabIndex = 4;
            this.buttonCheckout.Text = "Checkout";
            this.buttonCheckout.UseVisualStyleBackColor = true;
            this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Drinks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Students";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // registerListDrinks
            // 
            this.registerListDrinks.FormattingEnabled = true;
            this.registerListDrinks.Location = new System.Drawing.Point(231, 105);
            this.registerListDrinks.Name = "registerListDrinks";
            this.registerListDrinks.Size = new System.Drawing.Size(185, 186);
            this.registerListDrinks.TabIndex = 1;
            // 
            // registerListStudents
            // 
            this.registerListStudents.FormattingEnabled = true;
            this.registerListStudents.Location = new System.Drawing.Point(12, 105);
            this.registerListStudents.Name = "registerListStudents";
            this.registerListStudents.Size = new System.Drawing.Size(185, 186);
            this.registerListStudents.TabIndex = 1;
            this.registerListStudents.SelectedIndexChanged += new System.EventHandler(this.registerListStudents_SelectedIndexChanged);
            // 
            // labelCashRegister
            // 
            this.labelCashRegister.AutoSize = true;
            this.labelCashRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCashRegister.Location = new System.Drawing.Point(12, 18);
            this.labelCashRegister.Name = "labelCashRegister";
            this.labelCashRegister.Size = new System.Drawing.Size(140, 24);
            this.labelCashRegister.TabIndex = 0;
            this.labelCashRegister.Text = "Cash Register";
            this.labelCashRegister.Click += new System.EventHandler(this.label2_Click);
            // 
            // pnl_Activities
            // 
            this.pnl_Activities.Controls.Add(this.groupBoxEdit);
            this.pnl_Activities.Controls.Add(this.buttonDeleteActivity);
            this.pnl_Activities.Controls.Add(this.buttonAddActivity);
            this.pnl_Activities.Controls.Add(this.buttonEditActivity);
            this.pnl_Activities.Controls.Add(this.listViewActivities);
            this.pnl_Activities.Controls.Add(this.label4);
            this.pnl_Activities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Activities.Location = new System.Drawing.Point(0, 24);
            this.pnl_Activities.Name = "pnl_Activities";
            this.pnl_Activities.Size = new System.Drawing.Size(962, 481);
            this.pnl_Activities.TabIndex = 8;
            this.pnl_Activities.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Activities_Paint);
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Controls.Add(this.textBoxActivitySupervisors);
            this.groupBoxEdit.Controls.Add(this.textBoxActivityStudents);
            this.groupBoxEdit.Controls.Add(this.buttonActivitySave);
            this.groupBoxEdit.Controls.Add(this.label8);
            this.groupBoxEdit.Controls.Add(this.label7);
            this.groupBoxEdit.Controls.Add(this.label6);
            this.groupBoxEdit.Controls.Add(this.label5);
            this.groupBoxEdit.Controls.Add(this.textBoxActivityDescription);
            this.groupBoxEdit.Controls.Add(this.textBoxActivityName);
            this.groupBoxEdit.Location = new System.Drawing.Point(289, 299);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(407, 153);
            this.groupBoxEdit.TabIndex = 3;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Edit";
            this.groupBoxEdit.Visible = false;
            // 
            // textBoxActivitySupervisors
            // 
            this.textBoxActivitySupervisors.Location = new System.Drawing.Point(142, 98);
            this.textBoxActivitySupervisors.Name = "textBoxActivitySupervisors";
            this.textBoxActivitySupervisors.Size = new System.Drawing.Size(259, 20);
            this.textBoxActivitySupervisors.TabIndex = 6;
            this.textBoxActivitySupervisors.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // textBoxActivityStudents
            // 
            this.textBoxActivityStudents.Location = new System.Drawing.Point(142, 72);
            this.textBoxActivityStudents.Name = "textBoxActivityStudents";
            this.textBoxActivityStudents.Size = new System.Drawing.Size(259, 20);
            this.textBoxActivityStudents.TabIndex = 6;
            this.textBoxActivityStudents.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // buttonActivitySave
            // 
            this.buttonActivitySave.Location = new System.Drawing.Point(326, 123);
            this.buttonActivitySave.Name = "buttonActivitySave";
            this.buttonActivitySave.Size = new System.Drawing.Size(75, 23);
            this.buttonActivitySave.TabIndex = 5;
            this.buttonActivitySave.Text = "Save";
            this.buttonActivitySave.UseVisualStyleBackColor = true;
            this.buttonActivitySave.Click += new System.EventHandler(this.buttonActivitySave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Number of Supervisors";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Number of Students";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Activity Name";
            // 
            // textBoxActivityDescription
            // 
            this.textBoxActivityDescription.Location = new System.Drawing.Point(142, 45);
            this.textBoxActivityDescription.Name = "textBoxActivityDescription";
            this.textBoxActivityDescription.Size = new System.Drawing.Size(259, 20);
            this.textBoxActivityDescription.TabIndex = 1;
            // 
            // textBoxActivityName
            // 
            this.textBoxActivityName.Location = new System.Drawing.Point(142, 19);
            this.textBoxActivityName.Name = "textBoxActivityName";
            this.textBoxActivityName.Size = new System.Drawing.Size(259, 20);
            this.textBoxActivityName.TabIndex = 0;
            this.textBoxActivityName.TextChanged += new System.EventHandler(this.textBoxActivityName_TextChanged);
            // 
            // buttonDeleteActivity
            // 
            this.buttonDeleteActivity.Location = new System.Drawing.Point(175, 299);
            this.buttonDeleteActivity.Name = "buttonDeleteActivity";
            this.buttonDeleteActivity.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteActivity.TabIndex = 2;
            this.buttonDeleteActivity.Text = "Delete";
            this.buttonDeleteActivity.UseVisualStyleBackColor = true;
            this.buttonDeleteActivity.Click += new System.EventHandler(this.buttonDeleteActivity_Click);
            // 
            // buttonAddActivity
            // 
            this.buttonAddActivity.Location = new System.Drawing.Point(94, 299);
            this.buttonAddActivity.Name = "buttonAddActivity";
            this.buttonAddActivity.Size = new System.Drawing.Size(75, 23);
            this.buttonAddActivity.TabIndex = 2;
            this.buttonAddActivity.Text = "Add";
            this.buttonAddActivity.UseVisualStyleBackColor = true;
            this.buttonAddActivity.Click += new System.EventHandler(this.buttonAddActivity_Click);
            // 
            // buttonEditActivity
            // 
            this.buttonEditActivity.Location = new System.Drawing.Point(13, 299);
            this.buttonEditActivity.Name = "buttonEditActivity";
            this.buttonEditActivity.Size = new System.Drawing.Size(75, 23);
            this.buttonEditActivity.TabIndex = 2;
            this.buttonEditActivity.Text = "Edit";
            this.buttonEditActivity.UseVisualStyleBackColor = true;
            this.buttonEditActivity.Click += new System.EventHandler(this.buttonEditActivity_Click);
            // 
            // listViewActivities
            // 
            this.listViewActivities.FullRowSelect = true;
            this.listViewActivities.GridLines = true;
            this.listViewActivities.HideSelection = false;
            this.listViewActivities.Location = new System.Drawing.Point(13, 32);
            this.listViewActivities.Name = "listViewActivities";
            this.listViewActivities.ShowItemToolTips = true;
            this.listViewActivities.Size = new System.Drawing.Size(935, 260);
            this.listViewActivities.TabIndex = 1;
            this.listViewActivities.UseCompatibleStateImageBehavior = false;
            this.listViewActivities.SelectedIndexChanged += new System.EventHandler(this.listViewActivities_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Activities";
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 505);
            this.Controls.Add(this.pnl_Activities);
            this.Controls.Add(this.pnl_Cash_Register);
            this.Controls.Add(this.pnl_Dashboard);
            this.Controls.Add(this.pnl_Students);
            this.Controls.Add(this.pnl_Teachers);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SomerenUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SomerenApp";
            this.Load += new System.EventHandler(this.SomerenUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_Dashboard.ResumeLayout(false);
            this.pnl_Dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_Students.ResumeLayout(false);
            this.pnl_Students.PerformLayout();
            this.pnl_Teachers.ResumeLayout(false);
            this.pnl_Teachers.PerformLayout();
            this.pnl_Cash_Register.ResumeLayout(false);
            this.pnl_Cash_Register.PerformLayout();
            this.pnl_Activities.ResumeLayout(false);
            this.pnl_Activities.PerformLayout();
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxActivitySupervisors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxActivityStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Dashboard;
        private System.Windows.Forms.Label lbl_Dashboard;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Students;
        private System.Windows.Forms.Label lbl_Students;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.ColumnHeader studentID;
        private System.Windows.Forms.ColumnHeader studentName;
        private System.Windows.Forms.ColumnHeader studentDOB;
        private System.Windows.Forms.Panel pnl_Teachers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewTeachers;
        private System.Windows.Forms.ColumnHeader Lecturer_Id;
        private System.Windows.Forms.ColumnHeader Lecturer_Name;
        private System.Windows.Forms.ColumnHeader Subject;
        private System.Windows.Forms.ToolStripMenuItem cashRegisterToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Cash_Register;
        private System.Windows.Forms.Label labelCashRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox registerListStudents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox registerListDrinks;
        private System.Windows.Forms.Button buttonCheckout;
        private System.Windows.Forms.Panel pnl_Activities;
        private System.Windows.Forms.ListView listViewActivities;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDeleteActivity;
        private System.Windows.Forms.Button buttonAddActivity;
        private System.Windows.Forms.Button buttonEditActivity;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxActivityDescription;
        private System.Windows.Forms.TextBox textBoxActivityName;
        private System.Windows.Forms.Button buttonActivitySave;
        private System.Windows.Forms.NumericUpDown textBoxActivityStudents;
        private System.Windows.Forms.NumericUpDown textBoxActivitySupervisors;
        private System.Windows.Forms.ToolStripMenuItem drinksToolStripMenuItem;
    }
}

