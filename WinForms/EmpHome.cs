using System;
using System.Windows.Forms;

namespace WinForms
{
    public partial class EmpHome : Form
    {
        string UID;
        public EmpHome(string id)
        {
            InitializeComponent();
            this.UID = id;
            lbUID.Text = this.UID;
        }

        private void EmpHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();

            login.Show();
        }

        private void btnViewCar_Click(object sender, EventArgs e)
        {
            FormViewProduct product = new FormViewProduct();
            product.Show();
        }

        private void btnViewSup_Click(object sender, EventArgs e)
        {
            FormViewSup sup = new FormViewSup();
            sup.Show();
        }

        private void btnManageOrder_Click(object sender, EventArgs e)
        {
            ManageOrder order = new ManageOrder() { userID = UID};
            order.Show();
        }

        private void btnManageCustomer_Click(object sender, EventArgs e)
        {
            ManageCustomerInfo customerInfo = new ManageCustomerInfo();
            customerInfo.Show();
        }
    }
}
