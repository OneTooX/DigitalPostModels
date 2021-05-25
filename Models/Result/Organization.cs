namespace OneTooX.DigitalPost.Model.Result
{
    using System;

    public class Organization
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CvrNumber { get; set; }
        public string AuthorityType { get; set; }
        public bool LogoAvailable { get; set; }
    }
}