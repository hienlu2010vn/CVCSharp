using BusinessObjects;
using System;
using System.Collections.Generic;
using WinForms.Models;
using WinForms.Views;

namespace WinForms.Presenters
{
    public class ManagerCarPresenter : Presenter<IManageCarView>
    {
        public ManagerCarPresenter(IManageCarView view) : base(view) { }

        public void UpdateIncreaseQuantityProduct()
        {
            List<Product> list = View.listP;
            foreach (Product lp in list)
            {
                ProductModel.UpdateIncreaseQuantityProduct(lp);
            }
        }
        public void UpdateQuantityProduct()
        {
            List<Product> list = View.listP;
            foreach(Product lp in list)
            {
                ProductModel.UpdateQuantityProduct(lp);
            }
        }
        public bool AddProduct()
        {
            string ProductID = View.ProductID;
            string ProductName = View.ProductName1;
            string CategoryID = View.CategoryID;
            string SupplierID = View.SupplierID;
            float Price = View.Price;
            int Quantity = View.Quantity;
            DateTime CreateDate = DateTime.Now;
            Product p = new Product(ProductID, ProductName, CategoryID, SupplierID, Price, Quantity, CreateDate, true);
            return ProductModel.AddProduct(p);
        }

        public bool UpdateProduct()
        {
            string ProductID = View.ProductID;
            string ProductName = View.ProductName1;
            string CategoryID = View.CategoryID;
            string SupplierID = View.SupplierID;
            float Price = View.Price;
            int Quantity = View.Quantity;
            DateTime CreateDate = DateTime.Now;
            Product p = new Product(ProductID, ProductName, CategoryID, SupplierID, Price, Quantity, CreateDate, true);
            return ProductModel.UpdateProduct(p);
        }

        public bool DeleteProduct()
        {
            string ProductID = View.ProductID;
            return ProductModel.DeleteProduct(ProductID);
        }

        public List<Product> SearchProduct()
        {
            string ProductName = "%" + View.SearchName + "%";
            if (ProductName == null)
            {
                ProductName = "%%";
            }
            return ProductModel.SearchProduct(ProductName);
        }

        public List<Product> SearchProductAD()
        {
            string ProductName = "%" + View.SearchName + "%";
            if (ProductName == null)
            {
                ProductName = "%%";
            }
            return ProductModel.SearchProductAD(ProductName);
        }

        public List<Product> SearchProductBySomeThing()
        {
            string ProductName = "%" + View.SearchName + "%";
            string sup = "%" + View.SupplierID + "%";
            string cate = "%" + View.CategoryID + "%";

            if (ProductName == null)
            {
                ProductName = "%%";
            }
            return ProductModel.SearchProductBySomeThing(sup, cate, ProductName);
        }
        public List<Category> GetCate()
        {
            return ProductModel.GetCate();
        }
        public List<Supplier> GetSup()
        {
            return ProductModel.GetSup();
        }
    }
}
