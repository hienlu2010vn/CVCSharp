using BusinessObjects;
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
    public partial class FormOrderDetail : Form, IManageCarView, IManageCustomerView, IManageOrderView, IDetailOrderView
    {
        private ManagerCarPresenter MCP;
        private ManageCustomerPresenter MCusP;
        private ManageOrderPresenter MOP;
        private ManagerDetailPresenter MDP;

        List<Product> listCar;
        List<Product> products;
        Product p = null;
        string pCartID = null;
        int pCartPrice = 0;
        Validate vl = new Validate();
        float totalPrice = 0;
        int orderID = 0;
        
        public string ProductID => pCartID;

        public string SearchName => "";


        public string Phone => txtPhone.Text.Trim();

        public string CusName => "";

        public string Email => "";

        public string Address => "";

        public string UserID => UID;

        public string CusPhone => txtPhone.Text.Trim();

        public DateTime OrderDate => DateTime.Now;

        public string Note => txtNote.Text.Trim();

        public float TotalPrice => totalPrice;

        public bool Status => true;

        public string UID { get; set; }


        int IDetailOrderView.OrderID => this.orderID;

        public string ProductName1 => throw new NotImplementedException();

        public string CategoryID => throw new NotImplementedException();

        public string SupplierID => throw new NotImplementedException();

        public float Price => throw new NotImplementedException();

        public int Quantity => throw new NotImplementedException();

        public string SearchPhone => throw new NotImplementedException();

        public string OrderID => throw new NotImplementedException();

        public int DetailID => throw new NotImplementedException();

        public List<Product> list => products;

        public List<Product> listP => products;

        public FormOrderDetail()
        {
            InitializeComponent();
            MCP = new ManagerCarPresenter(this);
            MCusP = new ManageCustomerPresenter(this);
            MOP = new ManageOrderPresenter(this);
            MDP = new ManagerDetailPresenter(this);
            products = new List<Product>();
        }

        private void LoadCar()
        {
            listCar = MCP.SearchProduct();
            dataCarView.DataSource = listCar;
            dataCarView.Columns.Remove("Status");
            dataCarView.Columns.Remove("CreateDate");
        }
        private void LoadCart()
        {
            totalPrice = 0;
            dataCartView.DataSource = null;
            dataCartView.DataSource = products;
            
                foreach (Product lp in products)
                {
                    totalPrice += lp.Price;
                }
            
            lbTotal.Text = totalPrice.ToString();
            dataCartView.Columns.Remove("CategoryID");
            dataCartView.Columns.Remove("SupplierID");
            dataCartView.Columns.Remove("Status");
            dataCartView.Columns.Remove("CreateDate");
        }

        private void FormOrderDetail_Load(object sender, EventArgs e)
        {
            LoadCar();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool check = true;
            foreach (Product lp in products)
            {
                if (lp.ProductID.Equals(p.ProductID))
                {
                    MessageBox.Show("This product has exist!");
                    check = false;
                }
            }

            if (check)
            {
                if (p != null)
                {
                    products.Add(p);
                    LoadCart();
                }
                else
                {
                    MessageBox.Show("Please choose a product");
                }
            }

        }

        private void dataCarView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataCarView.Rows[e.RowIndex];
                string proID = row.Cells[0].Value.ToString();
                string name = row.Cells[1].Value.ToString();
                float price = float.Parse(row.Cells[4].Value.ToString());
                if (!proID.Equals(""))
                {
                    p = new Product(proID, name, 1, price);
                }
            }
        }

        private void FormOrderDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int check = -1;

            if (products.Count > 0)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].ProductID.Equals(pCartID))
                    {
                        check = i;
                    }
                }
                if (check >= 0)
                {
                    products.RemoveAt(check);
                    LoadCart();
                    MessageBox.Show("Delete success!");
                }
            }
            else
            {
                MessageBox.Show("No product in cart!");
            }
        }

        private void dataCartView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataCartView.Rows[e.RowIndex];
                string proID = row.Cells[0].Value.ToString();
                txtCarID.Text = proID;
                int price = int.Parse(row.Cells[2].Value.ToString());
                txtQuantity.Text = row.Cells[3].Value.ToString();
                if (!proID.Equals(""))
                {
                    pCartID = proID;
                    pCartPrice = price;
                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int check = -1;

            if (products.Count > 0)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].ProductID.Equals(pCartID))
                    {
                        check = i;
                    }
                }
                if (check >= 0)
                {
                    int quant = 0;
                    int maxQuant = 0;
                    for (int i = 0; i < listCar.Count; i++)
                    {
                        if (listCar[i].ProductID.Equals(pCartID))
                        {
                            maxQuant = listCar[i].Quantity;
                        }
                    }
                    bool flag = true;
                    try
                    {
                        quant = int.Parse(txtQuantity.Text.Trim());
                    }
                    catch
                    {
                        flag = false;
                        MessageBox.Show("Please input a number < " + maxQuant);
                    }
                    if (flag && quant <= maxQuant)
                    {
                        products[check].Price = quant * pCartPrice;
                        products[check].Quantity = quant;
                        LoadCart();
                        MessageBox.Show("Update success!" + quant);
                    }
                    else
                    {
                        MessageBox.Show("Please input a number < " + maxQuant);
                    }
                }
                else
                {
                    MessageBox.Show("Please choose a product to update");
                }
            }
            else
            {
                MessageBox.Show("No product in cart!");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (Phone.Equals(""))
            {
                MessageBox.Show("Please fill the phone");
            }
            else
            {
                string err = "";
                if (!vl.CheckPhone(Phone))
                {
                    err += "Phone is a string has 10 number.\n";
                }
                if (err.Equals(""))
                {
                    if(products.Count > 0)
                    {
                        MCusP.AddCustomer();
                        orderID = MOP.AddOrder();
                        MDP.AddDetail();
                        MCP.UpdateQuantityProduct();
                        MessageBox.Show("OK");
                        LoadCar();
                        products.Clear();
                        LoadCart();
                    } else
                    {
                        MessageBox.Show("No product added");
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
