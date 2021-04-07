using BusinessObjects;
using BusinessObjects.DataAccess;
using System;
using System.Collections.Generic;

namespace WinForms.Models
{
    public class UserModel : IUserModel
    {
        UserData userData = new UserData();

        public bool DeleteEmployee(string userID)
        {
            return userData.DeleteEmployee(userID);
        }

        public List<User> GetEmployee(string userName)
        {
            return userData.GetAllEmployee(userName);
        }

        public bool InsertEmployee(User user)
        {
            return userData.InsertEmployee(user);
        }

        public User Login(string UserID, string Password)
        {
            return userData.CheckLogin(UserID, Password);
        }

        public bool UpdateEmployee(User user)
        {
            return userData.UpdateEmployee(user);
        }
    }
}
