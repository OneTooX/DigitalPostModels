namespace OneTooX.DigitalPost.Model.ContactPoint
{
    public class ContactPoint
    {
        public string ContactPointId { get; set; }
        public string ContactPointGroup { get; set; }
        public string Label { get; set; }
        public ContactInfo ContactInfo1 { get; set; }
        public ContactInfo ContactInfo2 { get; set; }
    }
}