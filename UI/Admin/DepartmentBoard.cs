using Model;
using Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UI.Admin
{
    public partial class Departments_frm : Form
    {
        #region Fields
        private User User { get; set; }
        private DepartmentServices _departmentService = new DepartmentServices();
     //   private ProjectServices _projService = new ProjectServices();
    //    private EmployeeServices _employeeService = new EmployeeService();
       // private TaskServices _taskService = new TaskServices();
        #endregion Fields

        #region Constructors
        public Departments_frm()
        {
            InitializeComponent();
            TestApp.Program.Main();
            LoadAllDepartments();
        }
        public Departments_frm(User user)
        {
            InitializeComponent();
            CheckTypeOfUser(user);
            LoadAllDepartments();
            this.User = user;
            MaximizeBox = false;
            //this.dataGVDepartments.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGVDepartments_RowPrePaint);
        }
        #endregion Constructors

        #region Methods
        public void CheckTypeOfUser(User user)
        {
            currentUser_lbl.Text = user.ToString();
            currentTypeOfUser_lbl.Text = "Administrator";
            admins_lbl.Visible = true;
            dataGVDepartments.Visible = true;
            departments_lbl.Visible = true;
            departments_lbl.ForeColor = Color.Gray;
        }

        public void LoadAllDepartments()
        {
            List<Department> departmenstList = new List<Department>();

            departmenstList = _departmentService.GetAllDepartments();
            dataGVDepartments.DataSource = departmenstList;
        }

        void FormClosed(object sender, FormClosedEventArgs e)
        {
            this.LoadAllDepartments();
        }
        #endregion Methods

        #region Buttons
        private void NewDepartment_btn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //ChangeDepartmentData_frm insertDepartment_frm = new ChangeDepartmentData_frm(User);
            //insertDepartment_frm.FormClosed += new FormClosedEventHandler(FormClosed);
            //insertDepartment_frm.editDepartment_btn.Visible = false;
            //insertDepartment_frm.addDepartment_btn.Visible = true;

            //insertDepartment_frm.RefToDepartment_frm = this;
  
            //insertDepartment_frm.ShowDialog();
        }

        private void editDepartment_btn_Click(object sender, EventArgs e)
        {
            //Department selectedDepartment = new Department();
            //selectedDepartment = (Department)dataGVDepartments.CurrentRow.DataBoundItem;

            //if (selectedDepartment.NameOfDepartment != "Undefined")
            //{
            //    this.Hide();
            //    ChangeDepartmentData_frm updateDepartment = new ChangeDepartmentData_frm((Department)dataGVDepartments.CurrentRow.DataBoundItem);
            //    updateDepartment.FormClosed += new FormClosedEventHandler(FormClosed);
            //    updateDepartment.RefToDepartment_frm = this;
            //    updateDepartment.ShowDialog();

            //    updateDepartment.editDepartment_btn.Visible = true;
            //    updateDepartment.addDepartment_btn.Visible = false;
            //    updateDepartment.company_cbox.Enabled = false;
            //}
            //else
            //{
            //    MessageBox.Show("Undefined Department is read only.");
            //}
        }

        private void deleteDepartment_Click(object sender, EventArgs e)
        {
            //Department dep= new Department();
            //dep = (Department)dataGVDepartments.CurrentRow.DataBoundItem;
            //bool success = DepartmentServices.deleteDepartment(dep.Id);
            //if (success)
            //{
            //    MessageBox.Show("Department deleted");
            //    LoadAllDepartments();
            //}
            //else
            //{
            //    MessageBox.Show("Undefined Department is read only.");
            //}
        }

        private void dataGVDepartments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editDepartment_btn.Enabled = true;
            deleteDepartment.Enabled = true;
        }

        private void logOut_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_frm loginBoard = new login_frm();
            loginBoard.ShowDialog();
            this.Close();
        }
        
        private void administator_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminBoard_frm adminBoard = new AdminBoard_frm(User);
            adminBoard.FormClosed += new FormClosedEventHandler(FormClosed);
            adminBoard.RefToDepartment_frm = this;
            adminBoard.ShowDialog();
        }

        private void dataGVDepartments_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            foreach (DataGridViewRow row in dataGVDepartments.Rows)
                if ((bool)row.Cells[3].Value == false)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(222, 226, 232);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(90, 91, 91);
                }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("Do You Want To Save Your Data?", "Company System", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    this.Close();
            //}
            //else if (dialogResult == DialogResult.No)
            //{
            //    this.Close();
            //}
        }
        #endregion Buttons
    }
}
