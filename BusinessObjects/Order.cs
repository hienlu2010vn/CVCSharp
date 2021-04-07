using System;
namespace BusinessObjects
{
    public class Order
    {
        public Order(int orderID, DateTime orderDate, float totalPrice, string note, string userID, string cusPhone, bool status)
        {
            OrderID = orderID;
            OrderDate = orderDate;
            TotalPrice = totalPrice;
            Note = note;
            UserID = userID;
            CusPhone = cusPhone;
            Status = status;
        }

        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public float TotalPrice { get; set; }
        public string Note { get; set; }
        public string UserID { get; set; }
        public string CusPhone { get; set; }
        public bool Status { get; set; }
    }
}