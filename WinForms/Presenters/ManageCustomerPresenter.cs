using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Views;

namespace WinForms.Presenters
{
    public class ManageCustomerPresenter : Presenter<IManageCustomerView>
    {
        public ManageCustomerPresenter(IManageCustomerView view) : base(view) { }
        public bool AddCustomer()
        {
            string Phone = View.Phone;
            string CusName = View.CusName;
            string Email = View.Email;
            string Address = View.Address;

            CustomerInfo ci = new CustomerInfo(Phone, CusName, Email, Address, true);
            return CustomerModel.AddCustomer(ci);
        }

        public bool UpdateCustomer()
        {
            string Phone = View.Phone;
            string CusName = View.CusName;
            string Email = View.Email;
            string Address = View.Address;

            CustomerInfo ci = new CustomerInfo(Phone, CusName, Email, Address, true);
            return CustomerModel.UpadteCustomer(ci);
        }

        public bool DeleteCustomer()
        {
            string Phone = View.Phone;
            return CustomerModel.DeleteCustomer(Phone);
        }

        public List<CustomerInfo> SearchCustomer()
        {
            string Phone = View.SearchPhone;
            return CustomerModel.SearchCustomerByPhone(Phone);
        }
        public List<CustomerInfo> GetAllCustomer()
        {
            return CustomerModel.GetAllCustomer();
        }
    }
}
