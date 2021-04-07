using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Models
{
    public interface ICustomerModel
    {
        bool AddCustomer(CustomerInfo ci);
        bool DeleteCustomer(string phone);
        bool UpadteCustomer(CustomerInfo ci);
        List<CustomerInfo> SearchCustomerByPhone(string phone);
        List<CustomerInfo> GetAllCustomer();
    }
}
