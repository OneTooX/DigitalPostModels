namespace OneTooX.DigitalPost.Model.ContentData
{
    using OneTooX.DigitalPost.Model.Common;

    public class ContentData
    {
        public CprData CprData { get; set; }
        public CvrData CvrData { get; set; }
        public MotorVehicle MotorVehicle { get; set; }
        public string PropertyNumber { get; set; }
        public CaseId CaseId { get; set; }
        public AdditionalContentData AdditionalContentData { get; set; }
        public KleData KleData { get; set; }
        public FormData FormData { get; set; }
        public ProductionUnit ProductionUnit { get; set; }
        public Education Education { get; set; }
        public Address Address { get; set; }
        public AddressPoint AddressPoint { get; set; }
        public UnstructuredAddress UnstructuredAddress { get; set; }
    }
}