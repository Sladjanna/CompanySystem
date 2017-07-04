using Model;
using Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UI;

namespace CompanySystem
{
    public partial class Register_frm : Form
    {
        private UserServices _userService = new UserServices();
        private DepartmentServices _departmentService = new DepartmentServices();
        private Validation _validation = new Validation();

        #region Constructors
        public Register_frm()
        {
            InitializeComponent();
            LoadAllDepartments();
            LoadAllTypesOfUser();
            this.dateOfBirth_pck.Value = DateTime.Now;
            MaximizeBox = false;
        }
        #endregion Constructors

        #region Methods
        private void LoadAllDepartments()
        {
            List<Department> departmenstList = new List<Department>();
            departmenstList = _departmentService.GetAllDepartments();

            foreach (Department item in departmenstList)
            {
                department_cbox.Items.Add(item);
            }
            department_cbox.SelectedIndex = 0;
        }

        private void LoadAllTypesOfUser()
        {
            typeOfUser_cbox.Items.Add("Administrator");
            typeOfUser_cbox.Items.Add("Manager");
            typeOfUser_cbox.Items.Add("Employee");

            typeOfUser_cbox.SelectedIndex = 0;
        }

        public string ListOfGender()
        {
            if (male_rbtn.Checked)
                return "m";
            else
                return "f";
        }
        #endregion Methods

        #region Buttons
        private void save_btn_Click(object sender, EventArgs e)
        {
            if (_validation.ErrorProvider(username_txt, errorProvider) && _validation.ErrorProvider(password_txt, errorProvider) && _validation.ErrorProvider(firstName_lbl, errorProvider))
            {
                DateTime dateOfBirth = dateOfBirth_pck.Value;
                Department dep = department_cbox.SelectedItem as Department;
                string typeOfUser = typeOfUser_cbox.SelectedItem as string;

                User user = _userService.InsertUser(username_txt.Text, password_txt.Text, firstName_lbl.Text, lastName_txt.Text, ListOfGender(), dateOfBirth, typeOfUser, dep.Id);

                if (user != null)
                {
                    MessageBox.Show("Successfully created user");
                    this.Hide();
                    login_frm login = new login_frm();
                    login.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username already exist, try with another one");
                }
            }
        }
                
        private void lvDepartment_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                Department dep = e.Item.Tag as Department;
            }
        }

        //private void lvType_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        //{
        //    if (e.IsSelected)
        //    {
        //        TypeOfUser t = e.Item.Tag as TypeOfUser;
        //    }
        //}

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_frm login = new login_frm();
            login.ShowDialog();
            this.Close();
        }
        #endregion Buttons
    }
}
