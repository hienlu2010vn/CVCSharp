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
    public partial class FormViewProduct : Form, IManageCarView
    {
        private ManagerCarPresenter MCP;

        public string ProductID => throw new NotImplementedException();

        public string SearchName => txtSearchName.Text.Trim();

        public string ProductName1 => throw new NotImplementedException();

        public string CategoryID => throw new NotImplementedException();

        public string SupplierID => throw new NotImplementedException();

        public float Price => throw new NotImplementedException();

        public int Quantity => throw new NotImplementedException();

        public List<Product> listP => throw new NotImplementedException();

        public FormViewProduct()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void LoadData()
        {
            MCP = new ManagerCarPresenter(this);
            List<Product> list = MCP.SearchProduct();
            tblCar.DataSource = list;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void FormViewProduct_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
