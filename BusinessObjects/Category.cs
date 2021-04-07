namespace BusinessObjects
{
    public class Category
    {
        public Category(string categoryID, string categoryName)
        {
            CategoryID = categoryID;
            CategoryName = categoryName;
        }

        public string CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}