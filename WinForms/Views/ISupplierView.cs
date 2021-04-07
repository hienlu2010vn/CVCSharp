using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Views
{
    public interface ISupplierView : IView
    {
        string SupID { get; }
        string SupName { get; }
        string Origin { get; }

        void loadData();

        void ShowMessage(string message);
    }
}
