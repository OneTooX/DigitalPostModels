namespace OneTooX.DigitalPost.Model
{
    using System;

    public class Contact
    {
        public const string REGISTRATION_STATUS_REGISTERED = "REGISTERED";
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string CprNumber { get; set; }
        public string CvrNumber { get; set; }
        public MailboxSubscription MailboxSubscription { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class MailboxSubscription
    {
        public Guid Id { get; set; }
        public string PublicRegistrationStatus { get; set; }
    }

}