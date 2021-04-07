using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Views;

namespace WinForms
{
    public partial class FormViewSup : Form, ISupplierView
    {

        ManageSupplierPresenter _presenter;
        public FormViewSup()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public string SupID => "";

        public string SupName =>"";

        public string Origin => "";

        public void loadData()
        {
            _presenter = new ManageSupplierPresenter(this);
            tblSup.DataSource = _presenter.GetSuppliers();
        }

        public void ShowMessage(string message)
        {
            throw new NotImplementedException();
        }

        private void FormViewSup_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
