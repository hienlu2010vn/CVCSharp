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
    public partial class FormViewOrder : Form, IManageOrderView
    {
        ManageOrderPresenter MOP;

        public FormViewOrder()
        {
            InitializeComponent();
            this.CenterToScreen();
            MOP = new ManageOrderPresenter(this);
        }

        public string OrderID => throw new NotImplementedException();

        public string UserID => throw new NotImplementedException();

        public string CusPhone => throw new NotImplementedException();

        public DateTime OrderDate => throw new NotImplementedException();

        public string Note => throw new NotImplementedException();

        public float TotalPrice => throw new NotImplementedException();

        public bool Status => throw new NotImplementedException();

        private void LoadData()
        {
            List<Order> orders = MOP.GetAllOrder();
            tblOrder.DataSource = orders;
        }

        private void FormViewOrder_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void tblOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tblOrder.Rows[e.RowIndex];
                int orderID = int.Parse(row.Cells[0].Value.ToString());
                FormViewDetail viewDetail = new FormViewDetail() { OrderIDDetail = orderID };
                viewDetail.Show();
            }
        }
    }
}
