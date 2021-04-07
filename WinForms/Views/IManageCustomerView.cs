using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Views
{
    public interface IManageCustomerView : IView
    {
        string Phone { get; }
        string CusName { get; }
        string Email { get; }
        string Address { get; }
        string SearchPhone { get; }
    }
}
