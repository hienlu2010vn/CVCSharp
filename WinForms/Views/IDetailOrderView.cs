using BusinessObjects;
using System.Collections.Generic;

namespace WinForms.Views
{
    public interface IDetailOrderView : IView
    {
        int DetailID { get; }
        int OrderID { get; }
        
        List<Product> list { get; }
    }
}