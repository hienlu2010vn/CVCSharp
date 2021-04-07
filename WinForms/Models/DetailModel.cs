using BusinessObjects;
using BusinessObjects.DataAccess;
using System.Collections.Generic;

namespace WinForms.Models
{
    public class DetailModel : IDetailModel
    {
        private DetailData detail = new DetailData();
        public void AddDetail(OrderDetail d)
        {
           detail.AddDetail(d);
        }
        public List<OrderDetail> GetDetail(int ID)
        {
            return detail.GetDetail(ID);
        }
    }
}