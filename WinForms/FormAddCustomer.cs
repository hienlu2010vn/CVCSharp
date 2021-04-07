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
    public partial class FormAddCustomer : Form, IManageCustomerView
    {
        private ManageCustomerPresenter MCP;
        Validate vl = new Validate();
     
        public FormAddCustomer()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public string Phone => txtPhone.Text.Trim();

        public string CusName => txtCusName.Text.Trim();

        public string Email => txtEmail.Text.Trim();

        public string Address => txtAddress.Text.Trim();

        public string SearchPhone => throw new NotImplementedException();



        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (Phone.Equals("") || CusName.Equals("") || Email.Equals("") || Address.Equals(""))
            {
                MessageBox.Show("Please fill all blank");
            }
            else
            {
                string err = "";
                if(!vl.CheckPhone(Phone))
                {
                    err += "Phone is a string has 10 number.\n";
                }
                if (!vl.checkString(CusName,50))
                {
                    err += "Customer name length <=50\n";
                }
                if (!vl.checkString(Address, 200))
                {
                    err += "Address length <= 200\n";
                }
                if (!vl.checkEmail(Email))
                {
                    err += "Wrong email format\n";
                }
                if (err.Equals(""))
                {
                    MCP = new ManageCustomerPresenter(this);
                    if (MCP.AddCustomer())
                    {
                        MessageBox.Show("Add success");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("This phone is exist");
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
