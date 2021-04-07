using BusinessObjects;
using System.Collections.Generic;

namespace WinForms.Models
{
    public interface ISupplierModel
    {
        
        bool InsertSupplier(Supplier supplier);

        bool UpdateSupplier(Supplier supplier);

        bool DeleteSupplier(Supplier supplier);

        List<Supplier> GetSuppliers();
    }
}
