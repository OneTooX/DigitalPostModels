namespace OneTooX.DigitalPost.Models.Action
{
    using System;

    public class Reservation
    {
        public string Description { get; set; }
        public Guid Uuid { get; set; }
        public string Abstract { get; set; }
        public string Location { get; set; }
        public DateTimeOffset StartDateTime { get; set; }
        public DateTimeOffset EndDateTime { get; set; }
        public string OrganizerMail { get; set; }
        public string OrganizerName { get; set; }
    }
}