namespace BusinessObjects
{
    public class CustomerInfo
    {
        public CustomerInfo(string cusPhone, string name, string email, string address, bool status)
        {
            CusPhone = cusPhone;
            Name = name;
            Email = email;
            Address = address;
            Status = status;
        }

        public string CusPhone { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; }
    }
}
