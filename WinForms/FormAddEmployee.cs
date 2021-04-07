using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Presenters;
using WinForms.Views;

namespace WinForms
{
    public partial class FormAddEmployee : Form, IUserView
    {
        UserPresenter userPresenter;
        Validate vl = new Validate();
        public FormAddEmployee()
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

        private void btnCreate_Click(object sender, EventArgs e)
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
                if (!vl.checkEmail(Email))
                {
                    err += "Wrong email format\n";
                }
                if (err.Equals(""))
                {
                    if (userPresenter.InsertEmployee())
                    {
                        this.Hide();
                        ManageEmployee manageEmployee = new ManageEmployee();
                        manageEmployee.Show();
                        MessageBox.Show("Add Employee Successful!");
                    }
                    else
                    {
                        MessageBox.Show("Add Employee Failed!");
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
