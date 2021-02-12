using System;

namespace OneTooX.DigitalPost.Models.Action
{
    class Action
    {
        public string Label { get; set; }
        public string ActionCode { get; set; }
        public DateTimeOffset StartDateTime { get; set; }
        public DateTimeOffset EndDateTime { get; set; }
        public EntryPoint EntryPoint { get; set; }
        public Reservation Reservation { get; set; }
    }
}
