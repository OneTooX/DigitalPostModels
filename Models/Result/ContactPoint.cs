﻿namespace OneTooX.DigitalPost.Model.Result
{
    using System;

    public class ContactPoint
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string[] Targets { get; set; }
        public float MemoSizeThresholdMB { get; set; }
        public int AllowedNumberOfAttachments { get; set; }
        public bool Active { get; set; }
        public bool Visible { get; set; }
        public Guid OrganisationId { get; set; }
        public ContactPointCode[] ContactPointCodes { get; set; }
        public ContactGroup[] ContactGroups { get; set; }
        public RecommendedAttribute[] RecommendedAttributes { get; set; }
        public string[] SearchTems { get; set; }
    }
    public class ContactPointCode
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Code { get; set; }
        public string CodeVersion { get; set; }
        public string ContactPointCodeTypeName { get; set; }
    }
    public class RecommendedAttribute
    {
        public string Id { get; set; }
        public int Vesrsion { get; set; }
        public string Name { get; set; }
    }
    public enum ContactPointCodeType
    {
        FORM,
        KLE,
        GLN,
        SOR,
        CUSTOM
    }
    public class ContactGroup
    {
        public Guid Id { get; set; }
        public bool OrganisationalUnit { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid OrganisationId { get; set; }
        public ContactGroup Parent { get; set; }
    }
}