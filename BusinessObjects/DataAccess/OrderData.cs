using DataObjescts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BusinessObjects.DataAccess
{
    public class OrderData
    {
        public int AddOrder(Order o)
        {
            SqlParameter orderDate = new SqlParameter("@OrderDate", o.OrderDate);
            SqlParameter totalPrice = new SqlParameter("@TotalPrice", o.TotalPrice);
            SqlParameter note = new SqlParameter("@Note", o.Note);
            SqlParameter userID = new SqlParameter("@UserID", o.UserID);
            SqlParameter cusPhone = new SqlParameter("@CusPhone", o.CusPhone);
            SqlParameter status = new SqlParameter("@Status", o.Status);
            try
            {
                return DataProvider.ExecuteNonQueryLastInsertedId("InsertOrder", orderDate, totalPrice, note, userID, cusPhone, status);
            }
            catch (SqlException)
            {
                return 0;
            }
        }
        public bool DeleteOrder(string ID)
        {
            SqlParameter id = new SqlParameter("@OrderID", int.Parse(ID));
            try
            {
                return DataProvider.ExecuteNonQuery("DeleteOrder", id);
            }
            catch (SqlException)
            {
                return false;
            }
        }
        public List<Order> getAllOrder()
        {
            List<Order> list = null;
            try
            {
                SqlDataReader rd = DataProvider.ExecuteQueryWithDataReader("GetAllOrder");
                while (rd.Read())
                {
                    int id = rd.GetInt32(0);
                    DateTime date = rd.GetDateTime(1);
                    float totalPrice = Convert.ToSingle(rd.GetDouble(2));
                    string note = rd.GetString(3);
                    string userID = rd.GetString(4);
                    string cusPhone = rd.GetString(5);
                    Order o = new Order(id, date, totalPrice, note, userID, cusPhone, true);
                    if (list == null)
                    {
                        list = new List<Order>();
                    }
                    list.Add(o);
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
