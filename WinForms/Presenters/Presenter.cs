using WinForms.Models;
using WinForms.Views;

namespace WinForms.Presenters
{
    public class Presenter<T> where T : IView
    {
        protected static IUserModel UserModel { get; private set; }
        protected static IProductModel ProductModel { get; private set; }
        protected static ISupplierModel SupplierModel { get; private set; }
        protected static IOrderModel OrderModel { get; private set; }
        protected static IDetailModel DetailModel { get; private set; }

        protected static ICustomerModel CustomerModel { get; private set; }
        static Presenter()
        {
            UserModel = new UserModel();
            ProductModel = new ProductModel();
            SupplierModel = new SupplierModel();
            OrderModel = new OrderModel();
            DetailModel = new DetailModel();
            CustomerModel = new CustomerModel();
        }

        protected T View { get; private set; }

        public Presenter(T view)
        {
            View = view;
        }
    }
}
