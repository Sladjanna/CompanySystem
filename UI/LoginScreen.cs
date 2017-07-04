using CompanySystem;
using Model;
using Services;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class login_frm : Form
    {
        private Validation _validation = new Validation();
        private UserServices _userService = new UserServices();
        #region Constructor
        public login_frm()
        {
            InitializeComponent();
            MaximizeBox = false;
        }
        #endregion Constructor

        #region Buttons
        private void register_lbl_Click(object sender, EventArgs e)
        {
            Register_frm register = new CompanySystem.Register_frm();
            this.Hide();
            register.ShowDialog();
            this.Close();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = tbUserName.Text;
            string password = tbPassword.Text;

            if (_validation.ErrorProvider(tbUserName, errorProvider) && _validation.ErrorProvider(tbPassword, errorProvider))
            {
                User user = _userService.GetUserByUsername(username, password);
                if (user == null)
                {
                    MessageBox.Show("User doesn't exist of data not correct");
                }
                else
                {
                    MainBoard_frm mainBoard = new MainBoard_frm(user);
                    this.Hide();
                    mainBoard.ShowDialog();
                    this.Close();
                }
            }
        }
        #endregion Buttons
    }
}
