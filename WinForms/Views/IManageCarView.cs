using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Views
{
    public interface IManageCarView : IView
    {
        string ProductID { get; }
        string SearchName { get; }
        string ProductName1 { get; }
        string CategoryID { get; }
        string SupplierID { get; }
        float Price { get; }
        int Quantity { get; }
        List<Product> listP { get; }
    }
}
