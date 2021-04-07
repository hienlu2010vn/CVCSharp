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
    public partial class FormViewDetail : Form, IDetailOrderView
    {
        ManagerDetailPresenter MDP;
        public FormViewDetail()
        {
            InitializeComponent();
            this.CenterToScreen();
            MDP = new ManagerDetailPresenter(this);
        }

        public int OrderIDDetail { get; set; }


        public int OrderID => OrderIDDetail;

        public int DetailID => throw new NotImplementedException();

        public List<Product> list => throw new NotImplementedException();

        private void LoadData()
        {
            List<OrderDetail> orderDetails = MDP.GetDetail();
            tblOrderDetail.DataSource = orderDetails;
            
        }
        private void FormViewDetail_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
