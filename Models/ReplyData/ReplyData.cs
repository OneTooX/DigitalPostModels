using System;

namespace OneTooX.DigitalPost.Model.ReplyData
{
    public class ReplyData
    {
        public string MessageId { get; set; }
        public Guid? MessageUuid { get; set; }
        public Guid? ReplyUuid { get; set; }
        public string SenderId { get; set; }
        public string RecipientId { get; set; }
        public string CaseId { get; set; }
        public string ContactPointId { get; set; }
        public string GeneratingSystem { get; set; }
        public string Comment { get; set; }
        public AdditionalReplyData AdditionalReplyData1 { get; set; }
        public AdditionalReplyData AdditionalReplyData2 { get; set; }
        public AdditionalReplyData AdditionalReplyData3 { get; set; }
        public AdditionalReplyData AdditionalReplyData4 { get; set; }
    }
}