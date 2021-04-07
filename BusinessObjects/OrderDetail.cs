namespace BusinessObjects
{
    public class OrderDetail
    {
        public OrderDetail(int detailID, int orderID, string productID, int quantity, float price)
        {
            DetailID = detailID;
            OrderID = orderID;
            ProductID = productID;
            Quantity = quantity;
            Price = price;
        }

        public int DetailID { get; set; }
        public int OrderID { get; set; }
        public string ProductID { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
    }
}