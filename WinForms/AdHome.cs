using System;
using System.Windows.Forms;

namespace WinForms
{
    public partial class AdHome : Form
    {

        string UID;
        public AdHome(string userID)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.UID = userID;
            lbUID.Text = UID;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnManagePro_Click(object sender, EventArgs e)
        {
            ManageCar car = new ManageCar();
            car.Show();
        }

        private void AdHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnManageEmployee_Click(object sender, EventArgs e)
        {
            ManageEmployee manageEmployee = new ManageEmployee();
            manageEmployee.Show();
        }

        private void ManageSupplier_Click(object sender, EventArgs e)
        {
            ManageSupllier supplier = new ManageSupllier();
            supplier.Show();
        }

        private void ViewOrder_Click(object sender, EventArgs e)
        {
            FormViewOrder order = new FormViewOrder();
            order.Show();
        }

        private void btnManageCus_Click(object sender, EventArgs e)
        {
            ManageCustomerInfo customerInfo = new ManageCustomerInfo();
            customerInfo.Show();
        }
    }
}
