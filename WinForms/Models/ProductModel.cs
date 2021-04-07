using BusinessObjects;
using BusinessObjects.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Models
{
    public class ProductModel : IProductModel
    {
        ProductData product = new ProductData();
        SupplierData sup = new SupplierData();

        public bool AddProduct(Product p)
        {
            return product.AddProduct(p);
        }

        public bool DeleteProduct(string id)
        {
            return product.DeleteProduct(id);
        }

        public List<Category> GetCate()
        {
            return product.getCategory();
        }

        public List<Supplier> GetSup()
        {
            return sup.getSupplier();
        }

        public List<Product> SearchProduct(string name)
        {
            return product.SearchProduct(name);
        }

        public List<Product> SearchProductBySomeThing(string sup, string cate, string name)
        {
            return product.SearchProductBySomeThing(sup, cate, name);
        }

        public bool UpdateProduct(Product p)
        {
            return product.UpdateProduct(p);
        }

        public void UpdateQuantityProduct(Product p)
        {
            product.UpdateQuantityProduct(p);
        }

        public void UpdateIncreaseQuantityProduct(Product p)
        {
            product.UpdateIncreaseQuantityProduct(p);
        }

        public List<Product> SearchProductAD(string name)
        {
            return product.SearchProductAD(name);
        }
    }
}
