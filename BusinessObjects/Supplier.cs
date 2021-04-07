namespace BusinessObjects
{
    public class Supplier
    {
        public Supplier(string supID, string supName, string origin, bool status)
        {
            SupID = supID;
            SupName = supName;
            Origin = origin;
            Status = status;
        }

        public string SupID { get; set; }
        public string SupName { get; set; }
        public string Origin { get; set; }
        public bool Status { get; set; }
    }
}