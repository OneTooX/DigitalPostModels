﻿namespace OneTooX.DigitalPost.Model.Result
{
    using System;

    public class ContactPoint
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string[] Targets { get; set; }
        public int MemoSizeThresholdMB { get; set; }
        public int AllowedNumberOfAttachments { get; set; }
        public bool Active { get; set; }
        public bool Visible { get; set; }
        public Guid OrganisationId { get; set; }
        public string[] ContactPointCodes { get; set; }
        public Guid[] ContactGroups { get; set; }
        public string[] RecommendedAttributes { get; set; }
        public string[] SearchTems { get; set; }
    }
}