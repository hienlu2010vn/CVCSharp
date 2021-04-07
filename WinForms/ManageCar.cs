using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinForms.Presenters;
using WinForms.Views;
using System.Text.RegularExpressions;

namespace WinForms
{
    public partial class ManageCar : Form, IManageCarView
    {
        private ManagerCarPresenter MCP;
        Validate vl = new Validate();
        public string ProductID => txtProductID.Text.Trim();

        public string ProductName1 => txtProductName.Text.Trim();

        public string CategoryID => cbCategory.SelectedValue.ToString();

        public string SupplierID => cbSupplier.SelectedValue.ToString();

        public float Price => float.Parse(txtPrice.Text.Trim());

        public int Quantity => Int32.Parse(txtQuantity.Text.Trim());

        public string SearchName => txtSearchName.Text.Trim();

        public List<Product> listP => throw new NotImplementedException();

        public ManageCar()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void ManageCar_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormAddProduct pop = new FormAddProduct();
            pop.ShowDialog();
            LoadData();
        }

        private void LoadData()
        {

            MCP = new ManagerCarPresenter(this);
            List<Product> list = MCP.SearchProductAD();
            tblCar.DataSource = list;
            List<Category> list1 = MCP.GetCate();
            cbCategory.DataSource = list1;
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";
            List<Supplier> listS = MCP.GetSup();
            cbSupplier.DataSource = listS;
            cbSupplier.DisplayMember = "SupName";
            cbSupplier.ValueMember = "SupID";
            txtProductID.Text = "";
            txtProductName.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            txtSearchName.Text = "";
            txtCreateDate.Text = "";
        }
        private void ManageCar_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string ProductName1 = txtProductName.Text.Trim();
            string Price = txtPrice.Text.Trim();
            string Quantity = txtQuantity.Text.Trim();
            if ( ProductName1.Equals("") || Price.Equals("") || Quantity.Equals(""))
            {
                MessageBox.Show("Please fill all blank");
            }
            else
            {
                string err = "";
                if (!vl.checkString(ProductName1 , 50))
                {
                    err += "Name length <= 50\n";
                }
                if (!vl.checkInt(Quantity))
                {
                    err += "Quantity is int number\n";
                }
                if (!vl.checkFloat(Price))
                {
                    err += "Price is number\n";
                }
                if (err.Equals(""))
                {

                    MCP = new ManagerCarPresenter(this);
                    if (MCP.UpdateProduct())
                    {
                        MessageBox.Show("OK");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Not OK");
                    }
                }
                else
                {
                    MessageBox.Show(err);
                }
            }
        }

        private void tblCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tblCar.Rows[e.RowIndex];
                txtProductID.Text = row.Cells[0].Value.ToString();
                txtProductName.Text = row.Cells[1].Value.ToString();
                cbCategory.SelectedValue = row.Cells[2].Value.ToString();
                cbSupplier.SelectedValue = row.Cells[3].Value.ToString();
                txtPrice.Text = row.Cells[4].Value.ToString();
                txtQuantity.Text = row.Cells[5].Value.ToString();
                txtCreateDate.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MCP = new ManagerCarPresenter(this);
            if (MCP.DeleteProduct())
            {
                MessageBox.Show("OK");
                LoadData();
            }
            else
            {
                MessageBox.Show("Not OK");
            }
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
