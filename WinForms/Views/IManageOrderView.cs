using System;

namespace WinForms.Views
{
    public interface IManageOrderView : IView
    {
        string OrderID { get; }
        string UserID { get; }
        string CusPhone { get; }
        DateTime OrderDate { get; }
        string Note { get; }
        float TotalPrice { get; }
        bool Status { get; }
    }
}