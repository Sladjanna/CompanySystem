using Model;
using Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI.Admin
{
    public partial class AdminBoard_frm : Form
    {
        #region Fields
        private UserServices _userService = new UserServices();
        private DepartmentServices _departmentService = new DepartmentServices();
        private User User { get; set; }
        public Department dep = new Department();
        public Form RefToDepartment_frm { get; set; }
        public string selectedDepartment = "";
        #endregion Fields

        #region Constructors
        public AdminBoard_frm()
        {
            InitializeComponent();
         //   TestApp.Program.Main();
            LoadAllUsers();
        }
        public AdminBoard_frm(User user)
        {
            InitializeComponent();
            this.User = user;
            CheckTypeOfUser(user);
            LoadAllUsers();
            LoadAllDepartments();
            MaximizeBox = false;

            allUsers_rb.CheckedChanged += new EventHandler(allUsers_rb_CheckedChanged);
            administrators_rb.CheckedChanged += new EventHandler(administrators_rb_CheckedChanged);
            managers_rb.CheckedChanged += new EventHandler(managers_rb_CheckedChanged);
            employees_rb.CheckedChanged += new EventHandler(employees_rb_CheckedChanged);
            department_cmb.SelectedIndexChanged += new EventHandler(department_cmb_SelectedIndexChanged);
        }
#endregion Constructors

    #region Methods
    private void LoadAllDepartments()
        {
            List<Department> departmenstList = new List<Department>();
            departmenstList = _departmentService.GetAllDepartments();
            department_cmb.Items.Add("");

            foreach (Department item in departmenstList)
            {
                department_cmb.Items.Add(item.Name);
            }
            department_cmb.SelectedIndex = 0;
        }

        public void LoadAllUsers()
        {
            List<User> usersList = new List<User>();
            usersList = _userService.GetAllUsers();

            List<User> tempList = new List<User>();

            foreach (User item in usersList)
            {
                if (item.Department.Name == selectedDepartment)
                    tempList.Add(item);
                if (selectedDepartment == "")
                    tempList.Add(item);
            }
            dataGVUsers.DataSource = tempList;
        }

        public void LoadAdministrators()
        {
            List<User> administratorsList = new List<User>();
            administratorsList = _userService.GetAllAdministrators();

            List<User> tempList = new List<User>();

            foreach (User item in administratorsList)
            {
                if (item.Department.Name == selectedDepartment)
                    tempList.Add(item);
                if (selectedDepartment == "")
                    tempList.Add(item);
            }
            dataGVUsers.DataSource = tempList;
        }

        public void LoadManagers()
        {
            List<User> managersList = new List<User>();
            managersList = _userService.GetAllManagers();

            List<User> tempList = new List<User>();

            foreach (User item in managersList)
            {
                if (item.Department.Name == selectedDepartment)
                    tempList.Add(item);
                if (selectedDepartment == "")
                    tempList.Add(item);
            }
            dataGVUsers.DataSource = tempList;
        }

        public void LoadEmployees()
        {
            List<User> employeesList = new List<User>();
            employeesList = _userService.GetAllEmployees();

            List<User> tempList = new List<User>();

            foreach (User item in employeesList)
            {
                if (item.Department.Name == selectedDepartment)
                    tempList.Add(item);
                if (selectedDepartment == "")
                    tempList.Add(item);
            }
            dataGVUsers.DataSource = tempList;
        }

        public void CheckTypeOfUser(User user)
        {
            currentUser_lbl.Text = User.ToString();

            currentTypeOfUser_lbl.Text = "Administrator";
            admins_lbl.Visible = true;
            departments_lbl.Visible = true;
            add_btn.Visible = true;
            edit_btn.Visible = true;
        }

      //  void FormClosed(object sender, FormClosedEventArgs e)
    //    {
            //    LoadAllUsers();
            //    LoadAllDepartments();
   //     }
        #endregion Methods

        #region Buttons
        private void department_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pickedDepartment = department_cmb.SelectedItem.ToString();
            dep.Name = pickedDepartment;
            selectedDepartment = dep.Name.ToString();  // naziv departmana

            if (allUsers_rb.Checked)
                LoadAllUsers();
            if (administrators_rb.Checked)
                LoadAdministrators();
            if (managers_rb.Checked)
                LoadManagers();
            if (employees_rb.Checked)
                LoadEmployees();
        }

        private void allUsers_rb_CheckedChanged(object sender, EventArgs e)
        {
            LoadAllUsers();
        }

        private void administrators_rb_CheckedChanged(object sender, EventArgs e)
        {
            LoadAdministrators();
        }

        private void managers_rb_CheckedChanged(object sender, EventArgs e)
        {
            LoadManagers();
        }

        private void employees_rb_CheckedChanged(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void dataGVUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            edit_btn.Enabled = true;
            promoteToManager_btn.Enabled = true;
        }

        private void promoteToManager_Click(object sender, EventArgs e)
        {
            //    User userToPromote = new User();
            //    userToPromote = ((User)(dataGVUsers.CurrentRow.DataBoundItem));
            //    if (userToPromote.TypeOfUserID.IsEmployee == false)
            //    {
            //        MessageBox.Show("Promotion not allowed. Employee is already Administrator or Manager");
            //    }
            //    else if (userToPromote.DepartmentID.NameOfDepartment == "Undefined")
            //    {
            //        MessageBox.Show("Promotion not allowed. Employee has 'Undefined' department");
            //    }
            //     else if (UserServices.PromoteEmployeeToManager(userToPromote) )
            //    {
            //        MessageBox.Show("Employee promoted to Manager");
            //        LoadAllUsers();
            //    }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //ChangeUserData_frm insertUser_frm = new ChangeUserData_frm(User);
            //insertUser_frm.FormClosed += new FormClosedEventHandler(FormClosed);
            //insertUser_frm.RefToAdmin_frm = this;
            //insertUser_frm.edit_btn.Visible = false;
            //insertUser_frm.addAdmin_btn.Visible = true;
            //insertUser_frm.ShowDialog();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //User user = (User)dataGVUsers.CurrentRow.DataBoundItem;
            //ChangeUserData_frm UpdateUser_frm = new ChangeUserData_frm(user);
            //UpdateUser_frm.FormClosed += new FormClosedEventHandler(FormClosed);
            //UpdateUser_frm.username_txt.Enabled = false;
            //UpdateUser_frm.password_txt.Enabled = false;
            //UpdateUser_frm.addAdmin_btn.Visible = false;
            //UpdateUser_frm.edit_btn.Visible = true;
            //UpdateUser_frm.RefToAdmin_frm = this;

            //UpdateUser_frm.ShowDialog();
        }

        private void department_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Departments_frm depBoard = new Departments_frm(this.User);
            depBoard.ShowDialog();
            this.Close();
        }

        private void logOut_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_frm loginBoard = new login_frm();
            loginBoard.ShowDialog();
            this.Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //    DialogResult dialogResult = MessageBox.Show("Do You Want To Save Your Data?", "Company System", MessageBoxButtons.YesNo);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        this.Close();
            //    }
            //    else if (dialogResult == DialogResult.No)
            //    {
            //        this.Close();
            //    }
        }
        #endregion Buttons
    }
}
