using BusinessObjects;
using System.Collections.Generic;
using WinForms.Views;

namespace WinForms.Presenters
{
    public class UserPresenter : Presenter<IUserView>
    {
        public UserPresenter(IUserView view) : base(view) { }
        public User Login()
        {
            string UserID = View.UserID;
            string Password = View.Password;
            return UserModel.Login(UserID, Password);
        }

        public bool InsertEmployee()
        {
            string UserID = View.UserID;
            string UserName = View.UserName;
            string Address = View.Address;
            string Phone = View.Phone;
            string RoleID = View.RoleID;
            string Password = View.Password;
            string Email = View.Email;
            bool Status = View.Status;
            User user = new User(UserID, UserName, Email, Address, Phone, RoleID, Password, Status);
            return UserModel.InsertEmployee(user);
        }
        public bool UpdateEmployee()
        {
            string UserID = View.UserID;
            string UserName = View.UserName;
            string Address = View.Address;
            string Phone = View.Phone;
            string RoleID = View.RoleID;
            string Password = View.Password;
            string Email = View.Email;
            bool Status = View.Status;
            User user = new User(UserID, UserName, Email, Address, Phone, RoleID, Password, Status);
            return UserModel.UpdateEmployee(user);
        }
        public bool DeleteEmployee()
        {
            string UserID = View.UserID;
            return UserModel.DeleteEmployee(UserID);
        }
        public List<User> GetAllEmployee()
        {
            string UserName = View.SearchName;
            return UserModel.GetEmployee(UserName);
        }
    }
}
