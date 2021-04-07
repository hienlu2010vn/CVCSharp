using BusinessObjects;
using System;
using System.Collections.Generic;
using WinForms.Views;

namespace WinForms.Presenters
{
    public class ManageOrderPresenter : Presenter<IManageOrderView>
    {
        public ManageOrderPresenter(IManageOrderView view) : base(view)
        {
        }
        public int AddOrder()
        {
            string CusPhone = View.CusPhone;
            string Note = View.Note;
            string UserID = View.UserID;
            float TotalPrice = View.TotalPrice;
            DateTime OrderDate = DateTime.Now;
            Order o = new Order(1, OrderDate, TotalPrice, Note, UserID, CusPhone, true);
            return OrderModel.AddOrder(o);
        }

        public bool DeleteOrder()
        {
            string ID = View.OrderID;
            return OrderModel.DeleteOrder(ID);
        }

        public List<Order> GetAllOrder()
        {
            return OrderModel.GetAllOrder();
        }
    }
}