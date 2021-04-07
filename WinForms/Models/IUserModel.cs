using BusinessObjects;
using System.Collections.Generic;

namespace WinForms.Models
{
    public interface IUserModel
    {
        User Login(string UserID, string Password);
        List<User> GetEmployee(string userName);
        bool InsertEmployee(User user);
        bool UpdateEmployee(User user);
        bool DeleteEmployee(string userID);
    }
}
