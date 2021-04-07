using DataObjescts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.DataAccess
{
    public class SupplierData
    {
        public List<Supplier> getSupplier()
        {
            List<Supplier> list = null;
            try
            {
                SqlDataReader rd = DataProvider.ExecuteQueryWithDataReader("GetAllSupplier");
                while (rd.Read())
                {
                    if (rd.HasRows)
                    {
                        Supplier sup = new Supplier(rd.GetString(0), rd.GetString(1), rd.GetString(2), true);
                        if (list == null)
                        {
                            list = new List<Supplier>();
                        }
                        list.Add(sup);
                    }
                }
            }
            catch (SqlException)
            {
                return null;
            }
            return list;
        }

        public bool InsertSupplier(Supplier supplier)
        {
            bool res = false;
            SqlParameter SupplierIDParam = new SqlParameter("@SupplierID", supplier.SupID);
            SqlParameter SupplierNameParam = new SqlParameter("@SupplierName", supplier.SupName);
            SqlParameter SupplierOriginParam = new SqlParameter("@Origin", supplier.Origin);
            SqlParameter SupplierStatusParam = new SqlParameter("@Status", supplier.Status);
            res = DataProvider.ExecuteNonQuery("InsertSupplier", SupplierIDParam, SupplierNameParam, SupplierOriginParam, SupplierStatusParam);
            return res;
        }
        public bool UpdateSupplier(Supplier supplier)
        {
            bool res = false;
            SqlParameter SupplierIDParam = new SqlParameter("@SupplierID", supplier.SupID);
            SqlParameter SupplierNameParam = new SqlParameter("@SupplierName", supplier.SupName);
            SqlParameter SupplierOriginParam = new SqlParameter("@Origin", supplier.Origin);
            res = DataProvider.ExecuteNonQuery("UpdateSupplier", SupplierIDParam, SupplierNameParam, SupplierOriginParam);
            return res;
        }
        public bool DeleteSupplier(Supplier supplier)
        {
            bool res = false;
            SqlParameter SupplierIDParam = new SqlParameter("@SupplierID", supplier.SupID);

            res = DataProvider.ExecuteNonQuery("DeleteSupplier", SupplierIDParam);

            return res;
        }

    }
}
