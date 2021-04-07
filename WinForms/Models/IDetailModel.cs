using BusinessObjects;
using System.Collections.Generic;

namespace WinForms.Models
{
    public interface IDetailModel
    {
        void AddDetail(OrderDetail d);

        List<OrderDetail> GetDetail(int ID);
    }
}