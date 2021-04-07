using DataObjescts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BusinessObjects.DataAccess
{
    public class DetailData
    {
        public bool AddDetail(OrderDetail d)
        {
            SqlParameter OrderID = new SqlParameter("@OrderID", d.OrderID);
            SqlParameter ProductID = new SqlParameter("@ProductID", d.ProductID);
            SqlParameter Quantity = new SqlParameter("@Quantity", d.Quantity);
            SqlParameter Price = new SqlParameter("@Price", d.Price);
            try
            {
                return DataProvider.ExecuteNonQuery("InsertOrderDetail", OrderID, ProductID, Quantity, Price);
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public List<OrderDetail> GetDetail(int ID)
        {
            SqlParameter OrderID = new SqlParameter("@OrderID", ID);
            List<OrderDetail> list = null;
            try
            {
                SqlDataReader rd = DataProvider.ExecuteQueryWithDataReader("GetOrderDetail", OrderID);
                while (rd.Read())
                {
                    int detailID = rd.GetInt32(0);
                    int orderID = rd.GetInt32(1);
                    string productID = rd.GetString(2);
                    int quant = rd.GetInt32(3);
                    float price = Convert.ToSingle(rd.GetDouble(4));
                    OrderDetail d = new OrderDetail(detailID, orderID, productID, quant, price);
                    if (list == null)
                    {
                        list = new List<OrderDetail>();
                    }
                    list.Add(d);
                }
            }
            catch (SqlException)
            {
                return null;
            }
            return list;
        }
    }
}