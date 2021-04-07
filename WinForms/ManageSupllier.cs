using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WinForms.Views;


namespace WinForms
{
    public partial class ManageSupllier : Form, ISupplierView
    {

        ManageSupplierPresenter _presenter;

        public ManageSupllier()
        {
            InitializeComponent();
            this.CenterToScreen();
            chkSupplierStatus.AutoCheck = false;
        }
        private bool checkString(string stri, int num)
        {
            bool check = true;
            if (stri.Trim().Length > num)
            {
                check = false;
            }
            return check;
        }

        private bool checkID(string stri)
        {
            bool check = true;
            if (!Regex.IsMatch(stri, "(?i)^(?=.*[a-z])[a-z0-9]{1,10}$"))
            {
                check = false;
            }
            return check;
        }
        public string SupID => txtSupplierID.Text.Trim();

        public string SupName => txtSupplierName.Text.Trim();

        public string Origin => txtSupplierOrigin.Text.Trim();

        public bool Status => chkSupplierStatus.Checked;

        public void loadData()
        {
            _presenter = new ManageSupplierPresenter(this);
            dgvSupplier.DataSource = _presenter.GetSuppliers();
        }

        private void ManageSupllier_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void ClearTextBox()
        {
            txtSupplierID.Clear();
            txtSupplierName.Clear();
            txtSupplierOrigin.Clear();
            chkSupplierStatus.Checked = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string ID = txtSupplierID.Text.Trim();
            string Name = txtSupplierName.Text.Trim();
            string Origin = txtSupplierOrigin.Text.Trim();
            if (ID.Equals("") || Name.Equals("") || Origin.Equals(""))
            {
                MessageBox.Show("Please fill all blank");
            }
            else
            {
                string err = "";
                if (!checkID(ID))
                {
                    err += "Wrong ID format\n";
                }
                if (!checkString(Name, 50))
                {
                    err += "Name length <= 50\n";
                }
                if (!checkString(Origin, 50))
                {
                    err += "Origin length <= 50\n";
                }
                if (err.Equals(""))
                {

                    _presenter = new ManageSupplierPresenter(this);
                    if (_presenter.InsertSupplier())
                    {
                        ShowMessage("Added Success");
                        loadData();
                    }
                    else
                    {
                        ShowMessage("Failed to Add");
                    }
                }
                else
                {
                    MessageBox.Show(err);
                }
            }



        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            string Name = txtSupplierName.Text.Trim();
            string Origin = txtSupplierOrigin.Text.Trim();
            if (Name.Equals("") || Origin.Equals(""))
            {
                MessageBox.Show("Please fill all blank");
            }
            else
            {
                string err = "";

                if (!checkString(Name, 50))
                {
                    err += "Name length <= 50\n";
                }
                if (!checkString(Origin, 50))
                {
                    err += "Origin length <= 50\n";
                }
                if (err.Equals(""))
                {

                    _presenter = new ManageSupplierPresenter(this);
                    if (_presenter.UpdateSupplier())
                    {
                        ShowMessage("Update Success");
                        loadData();
                    }
                    else
                    {
                        ShowMessage("Failed to Update");
                    }
                }
                else
                {
                    MessageBox.Show(err);
                }
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _presenter = new ManageSupplierPresenter(this);
            if (_presenter.DeleteSupplier())
            {
                ShowMessage("Delete Success");
                loadData();
            }
            else
            {
                ShowMessage("Failed to Delete");
            }
        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSupplier.Rows[e.RowIndex];
                txtSupplierID.Text = row.Cells[0].Value.ToString();
                txtSupplierName.Text = row.Cells[1].Value.ToString();
                txtSupplierOrigin.Text = row.Cells[2].Value.ToString();
                chkSupplierStatus.Checked = Boolean.Parse(row.Cells[3].Value.ToString());
            }
        }

        private void ManageSupllier_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
