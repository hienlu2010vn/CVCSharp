using System;
using System.Windows.Forms;
using WinForms.Presenters;
using WinForms.Views;

namespace WinForms
{
    public partial class Signup : Form, IUserView
    {
        UserPresenter userPresenter;
        Validate vl = new Validate();
        public Signup()
        {
            InitializeComponent();
            this.CenterToScreen();
            userPresenter = new UserPresenter(this);

        }
        public string UserID => txtUserID.Text.Trim();
        public string UserName => txtUserName.Text.Trim();
        public string Address => txtAddress.Text.Trim();
        public string Phone => txtPhone.Text.Trim();
        public string RoleID => "EMP";
        public string Password => txtPassword.Text.Trim();
        public string Email => txtEmail.Text.Trim();
        public bool Status => true;
        public string SearchName => throw new NotImplementedException();

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            if (UserID.Equals("") || UserName.Equals("") || Address.Equals("") || Phone.Equals("") || Password.Equals("") || Email.Equals(""))
            {
                MessageBox.Show("Please fill all blank");
            }
            else
            {
                string err = "";
                if (!vl.checkID(UserID))
                {
                    err += "Wrong ID format\n";
                }
                if (!vl.checkString(UserName, 50))
                {
                    err += "Name length <= 50\n";
                }
                if (!vl.checkString(Address, 200))
                {
                    err += "Address length <= 200\n";
                }
                if (!vl.CheckPhone(Phone))
                {
                    err += "Phone is a string has 10 number.\n";
                }
                if (!vl.checkString(Password, 50))
                {
                    err += "Password length <= 50\n";
                }
                if (!Password.Equals(txtRePassword.Text))
                {
                    err += "Re-Password not match\n";
                }
                if (!vl.checkEmail(Email))
                {
                    err += "Wrong email format\n";
                }
                if (err.Equals(""))
                {
                    if (userPresenter.InsertEmployee())
                    {
                        MessageBox.Show("Sign Up Successful!");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sign Up Fail!");
                    }
                }
                else
                {
                    MessageBox.Show(err);
                }
            }
        }
    }
}
