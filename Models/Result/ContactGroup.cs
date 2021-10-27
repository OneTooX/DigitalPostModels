namespace OneTooX.DigitalPost.Model.Result
{
    using System;

    public class ContactGroup
    {
        public Guid Id { get; set; }
        public bool OrganisationalUnit { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Organization Organisation { get; set; }
        public ContactGroup Parent { get; set; }
        public string[] Targets { get; set; }
        public int[] PostkasseIds { get; set; }
    }
}