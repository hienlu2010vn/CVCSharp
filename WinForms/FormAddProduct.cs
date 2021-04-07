using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WinForms.Presenters;
using WinForms.Views;

namespace WinForms
{
    public partial class FormAddProduct : Form, IManageCarView
    {
        private ManagerCarPresenter MCP;
        Validate vl = new Validate();
        public FormAddProduct()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public string ProductID => txtProductID.Text;

        public string ProductName1 => txtProductName.Text;

        public string CategoryID => cbCategory.SelectedValue.ToString();

        public string SupplierID => cbSupplier.SelectedValue.ToString();

        public float Price => float.Parse(txtPrice.Text);

        public int Quantity => int.Parse(txtQuantity.Text);

        public string SearchName => null;

        public List<Product> listP => throw new NotImplementedException();

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string ProductID = txtProductID.Text.Trim();
            string ProductName1 = txtProductName.Text.Trim();
            string Price = txtPrice.Text.Trim();
            string Quantity = txtQuantity.Text.Trim();
            if (ProductID.Equals("") || ProductName1.Equals("") || Price.Equals("") || Quantity.Equals(""))
            {
                MessageBox.Show("Please fill all blank");
            }
            else
            {
                string err = "";
                if (!vl.checkID(ProductID))
                {
                    err += "Wrong ID format\n";
                }
                if (!vl.checkString(ProductName1, 50))
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
                    if (MCP.AddProduct())
                    {
                        MessageBox.Show("OK");
                        this.Hide();
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

        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            MCP = new ManagerCarPresenter(this);
            List<Category> list = MCP.GetCate();
            cbCategory.DataSource = list;
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";
            List<Supplier> listS = MCP.GetSup();
            cbSupplier.DataSource = listS;
            cbSupplier.DisplayMember = "SupName";
            cbSupplier.ValueMember = "SupID";

        }

    }
}
