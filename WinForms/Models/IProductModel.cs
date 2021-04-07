using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Models
{
    public interface IProductModel
    {
        bool AddProduct(Product p);
        bool DeleteProduct(string id);
        bool UpdateProduct(Product p);
        List<Product> SearchProduct(string name);
        List<Product> SearchProductAD(string name);

        List<Product> SearchProductBySomeThing(string sup, string cate, string name);
        List<Category> GetCate();
        List<Supplier> GetSup();
        void UpdateQuantityProduct(Product p);
        void UpdateIncreaseQuantityProduct(Product p);
    }
}
