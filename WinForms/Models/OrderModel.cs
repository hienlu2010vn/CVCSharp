using BusinessObjects;
using BusinessObjects.DataAccess;
using System.Collections.Generic;

namespace WinForms.Models
{
    public class OrderModel : IOrderModel
    {
        private OrderData order = new OrderData();

        public int AddOrder(Order o)
        {
            return order.AddOrder(o);
        }

        public bool DeleteOrder(string id)
        {
            return order.DeleteOrder(id);
        }

        public List<Order> GetAllOrder()
        {
            return order.getAllOrder();
        }
    }
}