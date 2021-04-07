using BusinessObjects;
using System;
using System.Windows.Forms;
using WinForms.Presenters;
using WinForms.Views;

namespace WinForms
{
    public partial class Login : Form, IUserView
    {
        private UserPresenter userPresenter;
        public Login()
        {
            InitializeComponent();
        }

        public string UserID => txtUserID.Text.Trim();

        public string UserName => throw new NotImplementedException();

        public string Address => throw new NotImplementedException();

        public string Phone => throw new NotImplementedException();

        public string RoleID => throw new NotImplementedException();

        public string Password => txtPassword.Text.Trim();

        public string Email => throw new NotImplementedException();

        public bool Status => throw new NotImplementedException();

        public string SearchName => throw new NotImplementedException();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            userPresenter = new UserPresenter(this);
            User user = userPresenter.Login();
            if(user != null)
            {
                if (user.RoleID.Contains("AD"))
                {
                    AdHome adHome = new AdHome(user.UserID);
                    this.Hide();
                    adHome.Show();
                }
                else
                {
                    EmpHome empHome = new EmpHome(user.UserID);
                    this.Hide();
                    empHome.Show();
                }
            }
            else
            {
                MessageBox.Show("User not exist");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void txtUserID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
