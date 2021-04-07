namespace BusinessObjects
{
    public class User
    {
        public User(string userID, string userName, string email, string address, string phone, string roleID, string password, bool status)
        {
            UserID = userID;
            UserName = userName;
            Email = email;
            Address = address;
            Phone = phone;
            RoleID = roleID;
            Password = password;
            Status = status;
        }

        public string UserID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string RoleID { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
    }
}