using BusinessObjects;
using BusinessObjects.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Models
{
    public class CustomerModel : ICustomerModel
    {
        CustomerData customer = new CustomerData();

        public bool AddCustomer(CustomerInfo ci)
        {
            return customer.AddCustomer(ci);
        }

        public bool DeleteCustomer(string phone)
        {
            return customer.DeleteCustomer(phone);
        }

        public List<CustomerInfo> GetAllCustomer()
        {
            return customer.GetAllCustomer();
        }

        public List<CustomerInfo> SearchCustomerByPhone(string phone)
        {
            return customer.SearchCustomerByPhone(phone);
        }

        public bool UpadteCustomer(CustomerInfo ci)
        {
            return customer.UpdateCustomer(ci);
        }
    }
}
