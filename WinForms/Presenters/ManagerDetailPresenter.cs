using BusinessObjects;
using System.Collections.Generic;
using WinForms.Views;

namespace WinForms.Presenters
{
    public class ManagerDetailPresenter : Presenter<IDetailOrderView>
    {
        public ManagerDetailPresenter(IDetailOrderView view) : base(view)
        {
        }

        public void AddDetail()
        {
            int OrderID = View.OrderID;
            List<Product> list = View.list;
            foreach (Product lp in list) {
                OrderDetail d = new OrderDetail(1, OrderID, lp.ProductID, lp.Quantity, lp.Price);
                DetailModel.AddDetail(d);
            }
        }

        public List<OrderDetail> GetDetail()
        {
            int OrderID = View.OrderID;
            return DetailModel.GetDetail(OrderID);
        }
    }
}