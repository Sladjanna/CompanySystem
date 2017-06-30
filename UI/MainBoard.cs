using Model;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using UI.Admin;

namespace UI
{
    public partial class MainBoard_frm : Form
    {
        #region Fields
        private User User { get; set; }
        #endregion Fields

        #region Constructor
        public MainBoard_frm(User user)
        {
            this.User = user;
            InitializeComponent();
            CheckTypeOfUser(user);
            name_lbl.Text = user.ToString();
            MaximizeBox = false;
        }
        #endregion Constructor

        #region Methods
        public void CheckTypeOfUser(User User)
        {
            currentUser_lbl.Text =  User.ToString();

         //     if (User.TypeOfUser.IsAdministrator == true)
      //      {
                currentTypeOfUser_lbl.Text = "Administrator";
                admins_lbl.Visible = true;
                projects_lbl.Visible = false;
                departments_lbl.Visible = true;
                tasks_lbl.Visible = false;
                projectsEmployee_lbl.Visible = false;
                tasksEmployee_lbl.Visible = false;
                add_btn.Visible = false;
                edit_btn.Visible = false;
                delete_btn.Visible = false;

                administrator_btn.Visible = true;
                department_btn.Visible = true;
                project_btn.Visible = false;
                projectEmployee_btn.Visible = false;
                taskEmployee_btn.Visible = false;
                task_btn.Visible = false;
                employeesManagers_lbl.Visible = false;
                manager_btn.Visible = false;
            //}

            //else if (User.TypeOfUser.IsManager == true)
            //{
            //    currentTypeOfUser_lbl.Text = "Manager";
            //    admins_lbl.Visible = false;
            //    managers_lbl.Visible = false;
            //    projects_lbl.Visible = true;
            //    departments_lbl.Visible = false;
            //    tasks_lbl.Visible = true;
            //    employeesManagers_lbl.Visible = false;
            //    projectsEmployee_lbl.Visible = false;
            //    tasksEmployee_lbl.Visible = false;

            //    administrator_btn.Visible = false;
            //    department_btn.Visible = false;
            //    project_btn.Visible = true;
            //    projectEmployee_btn.Visible = false;
            //    task_btn.Visible = true;
            //    taskEmployee_btn.Visible = false;
            //    manager_btn.Visible = false;
            //    add_btn.Visible = false;
            //    edit_btn.Visible = false;
            //    delete_btn.Visible = false;
            //}
            //else if (User.TypeOfUser.IsEmployee == true)
            //{
            //    currentTypeOfUser_lbl.Text = "Employee";
            //    admins_lbl.Visible = false;
            //    administrators_lbl.Visible = false;
            //    managers_lbl.Visible = false;
            //    projects_lbl.Visible = false;
            //    departments_lbl.Visible = false;
            //    tasks_lbl.Visible = false;
            //    employeesManagers_lbl.Visible = true;
            //    projectsEmployee_lbl.Visible = true;
            //    tasksEmployee_lbl.Visible = false;

            //    administrator_btn.Visible = false;
            //    department_btn.Visible = false;
            //    project_btn.Visible = false;
            //    projectEmployee_btn.Visible = true;
            //    taskEmployee_btn.Visible = false;
            //    task_btn.Visible = false;
            //    manager_btn.Visible = true;
            //    add_btn.Visible = false;
            //    edit_btn.Visible = false;
            //    delete_btn.Visible = false;
            //}
        }
        #endregion Methods

        #region Buttons
        private void logOut_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_frm loginBoard = new login_frm();
            loginBoard.ShowDialog();
            this.Close();
        }

        private void administrator_btn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //AdminBoard_frm userBoard = new AdminBoard_frm(this.User);
            //userBoard.ShowDialog();
            //this.Close();
        }

        private void department_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Departments_frm depBoard = new Departments_frm(this.User);
            depBoard.ShowDialog();
            this.Close();
        }

        private void task_btn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //TasksBoard_frm allTasks = new TasksBoard_frm(this.User);
            //allTasks.ShowDialog();
            //this.Close();
        }

        private void project_btn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //ManagerBoard_frm projectBoard = new ManagerBoard_frm(this.User);
            //projectBoard.ShowDialog();
            //this.Close();
        }

        private void projectEmployee_btn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //EmployeeBoard_frm tBoard = new EmployeeBoard_frm(this.User);
            //tBoard.project_btn.Enabled = false;
            //tBoard.ShowDialog();
            //this.Close();
        }

        private void taskEmployee_btn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //EmployeeBoard_frm tBoard = new EmployeeBoard_frm(this.User);
            //tBoard.ShowDialog();
            //this.Close();
        }
        
        private void manager_btn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //EmployeesManagers_frm allManagers = new EmployeesManagers_frm(this.User);
            //allManagers.ShowDialog();
            //this.Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do You Want To Save Your Data?", "Company System", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        #endregion Buttons
    }
}
