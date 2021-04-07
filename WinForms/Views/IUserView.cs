using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Views
{
    public interface IUserView : IView
    {
        string UserID { get; }
        string UserName { get; }
        string SearchName { get; }
        string Address { get; }
        string Phone { get; }
        string RoleID { get; }
        string Password { get; }
        string Email { get; }
        bool Status { get; }
    }
}
