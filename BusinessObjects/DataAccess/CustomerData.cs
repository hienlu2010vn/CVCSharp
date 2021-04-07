using DataObjescts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.DataAccess
{
    public class CustomerData
    {
        public bool AddCustomer(CustomerInfo ci)
        {
            SqlParameter phone = new SqlParameter("@Phone", ci.CusPhone);
            SqlParameter name = new SqlParameter("@CusName", ci.Name);
            SqlParameter email = new SqlParameter("@Email", ci.Email);
            SqlParameter address = new SqlParameter("@Address", ci.Address);
            SqlParameter status = new SqlParameter("@Status", ci.Status);

            try
            {
                return DataProvider.ExecuteNonQuery("InsertCustomer", phone, name, email, address, status);
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool UpdateCustomer(CustomerInfo ci)
        {
            SqlParameter phone = new SqlParameter("@Phone", ci.CusPhone);
            SqlParameter name = new SqlParameter("@CusName", ci.Name);
            SqlParameter email = new SqlParameter("@Email", ci.Email);
            SqlParameter address = new SqlParameter("@Address", ci.Address);

            try
            {
                return DataProvider.ExecuteNonQuery("UpdateCustomer", phone, name, email, address);
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool DeleteCustomer(string phoneNumber)
        {
            SqlParameter phone = new SqlParameter("@Phone", phoneNumber);
            try
            {
                return DataProvider.ExecuteNonQuery("DeleteCustomer", phone);
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public List<CustomerInfo> SearchCustomerByPhone(String searchPhone)
        {
            SqlParameter Phone = new SqlParameter("@Phone", searchPhone);
            List<CustomerInfo> list = null;
            try
            {
                SqlDataReader rd = DataProvider.ExecuteQueryWithDataReader("SearchCustomerByPhone", Phone);
                while (rd.Read())
                {
                    string phone = rd.GetString(0);
                    string nameCus = rd.GetString(1);
                    string email = rd.GetString(2);
                    string address = rd.GetString(3);
                    CustomerInfo p = new CustomerInfo(phone, nameCus, email, address, true);
                    if (list == null)
                    {
                        list = new List<CustomerInfo>();
                    }
                    list.Add(p);
                }
            }
            catch (SqlException)
            {
                return null;
            }
            return list;
        }

        public List<CustomerInfo> GetAllCustomer()
        {
            List<CustomerInfo> list = null;
            try
            {
                SqlDataReader rd = DataProvider.ExecuteQueryWithDataReader("GetAllCustomer");
                while (rd.Read())
                {
                    string phone = rd.GetString(0);
                    string nameCus = rd.GetString(1);
                    string email = rd.GetString(2);
                    string address = rd.GetString(3);
                    CustomerInfo p = new CustomerInfo(phone, nameCus, email, address, true);
                    if (list == null)
                    {
                        list = new List<CustomerInfo>();
                    }
                    list.Add(p);
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
