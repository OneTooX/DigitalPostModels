namespace OneTooX.DigitalPost.Model.Action
{
    using System;

    public class Action
    {
        public string Label { get; set; }
        public string ActionCode { get; set; }
        public DateTimeOffset StartDateTime { get; set; }
        public DateTimeOffset EndDateTime { get; set; }
        public EntryPoint EntryPoint { get; set; }
        public Reservation Reservation { get; set; }
    }
}
