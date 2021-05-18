namespace OneTooX.DigitalPost.Model
{
    public class ContactsResult : Result
    {
        public Contact[] Contacts { get; set; }
    }

    public class OrganizationsResult : Result
    {
        public Organization[] Organisations { get; set; }
    }

    public abstract class Result
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int ElementsOnPage { get; set; }
        public int TotalElements { get; set; }
    }
}