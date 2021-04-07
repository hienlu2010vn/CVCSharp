using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinForms.Presenters;
using WinForms.Views;

namespace WinForms
{
    public partial class ManageOrder : Form, IManageOrderView, IDetailOrderView, IManageCarView
    {
        ManageOrderPresenter orderPresenter;
        ManagerDetailPresenter MDP;
        ManagerCarPresenter MCP;
        List<Product> listPro;
        int orderID = -1;
        public string userID { get; set; }
        public string OrderID => orderID.ToString();

        public string UserID => throw new NotImplementedException();

        public string CusPhone => throw new NotImplementedException();

        public DateTime OrderDate => throw new NotImplementedException();

        public string Note => throw new NotImplementedException();

        public float TotalPrice => throw new NotImplementedException();

        public bool Status => throw new NotImplementedException();

        public int DetailID => throw new NotImplementedException();

        int IDetailOrderView.OrderID => orderID;

        public List<Product> list => throw new NotImplementedException();

        public string ProductID => throw new NotImplementedException();

        public string SearchName => throw new NotImplementedException();

        public string ProductName1 => throw new NotImplementedException();

        public string CategoryID => throw new NotImplementedException();

        public string SupplierID => throw new NotImplementedException();

        public float Price => throw new NotImplementedException();

        public int Quantity => throw new NotImplementedException();

        public List<Product> listP => listPro;

        public ManageOrder()
        {
            InitializeComponent();
            this.CenterToScreen();
            orderPresenter = new ManageOrderPresenter(this);
            MDP = new ManagerDetailPresenter(this);
            MCP = new ManagerCarPresenter(this);
            listPro = new List<Product>();
        }
        private void LoadOrder()
        {
            List<Order> list = orderPresenter.GetAllOrder();
            tblOrder.DataSource = list;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormOrderDetail detail = new FormOrderDetail() { UID = userID};
            detail.ShowDialog();
            LoadOrder();
        }


        private void ManageOrder_Load(object sender, EventArgs e)
        {
            LoadOrder();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(orderID >= 0)
            {
                List <OrderDetail> orderDetails = MDP.GetDetail();
                
                foreach(OrderDetail detail in orderDetails)
                {
                    Product product = new Product(detail.ProductID, "", detail.Quantity, 0);
                    listPro.Add(product);
                }
                MCP.UpdateIncreaseQuantityProduct();
                orderPresenter.DeleteOrder();
                LoadOrder();
                MessageBox.Show("Delete order success");
            }
            else
            {
                MessageBox.Show("Please choose an order to delete");
            }
        }

        private void tblOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tblOrder.Rows[e.RowIndex];
                orderID = int.Parse(row.Cells[0].Value.ToString());
            }
        }

        private void ManageOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if(orderID >= 0)
            {
                FormViewDetail viewDetail = new FormViewDetail() { OrderIDDetail = orderID };
                viewDetail.Show();
            }
            else
            {
                MessageBox.Show("Please choose an order to view");
            }
        }
    }
}
