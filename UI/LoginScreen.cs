using DAL.Services;
using Model;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class login_frm : Form
    {
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
            //Register_frm register = new CompanySystem.Register_frm();
            //this.Hide();
            //register.ShowDialog();
            //this.Close();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = tbUserName.Text;
            string password = tbPassword.Text;

            if (DAL.Services.Validation.ErrorProvider(tbUserName, errorProvider) && Validation.ErrorProvider(tbPassword, errorProvider))
            {
                User user = UserServices.GetUserByUsername(username, password);
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
