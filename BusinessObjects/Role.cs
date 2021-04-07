namespace BusinessObjects
{
    public class Role
    {
        public Role(string roleID, string roleName)
        {
            RoleID = roleID;
            RoleName = roleName;
        }

        public string RoleID { get; set; }
        public string RoleName { get; set; }
    }
}