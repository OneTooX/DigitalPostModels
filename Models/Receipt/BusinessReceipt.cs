namespace OneTooX.DigitalPost.Model.Receipt
{
    using System;

    public class BusinessReceipt
    {
        public Guid TransmissionId { get; set; }
        public Guid MessageUuid { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime Timestamp { get; set; }
        public string ReceiptStatus { get; set; }
        public override string ToString() =>
            $"{nameof(BusinessReceipt)}{{{nameof(TransmissionId)}:{TransmissionId}, {nameof(MessageUuid)}:{MessageUuid}, {nameof(ErrorCode)}:{ErrorCode}, {nameof(ErrorMessage)}:{ErrorMessage}, {nameof(Timestamp)}:{Timestamp}, {nameof(ReceiptStatus)}:{ReceiptStatus}}}";
    }
}