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
        public AdditionalContentData AdditionalContentData1 { get; set; }
        public AdditionalContentData AdditionalContentData2 { get; set; }
        public AdditionalContentData AdditionalContentData3 { get; set; }
        public AdditionalContentData AdditionalContentData4 { get; set; }
        public AdditionalContentData AdditionalContentData5 { get; set; }
        public AdditionalContentData AdditionalContentData6 { get; set; }
        public AdditionalContentData AdditionalContentData7 { get; set; }
        public AdditionalContentData AdditionalContentData8 { get; set; }
        public AdditionalContentData AdditionalContentData9 { get; set; }
        public AdditionalContentData AdditionalContentData10 { get; set; }
        public KleData KleData { get; set; }
        public FormData FormData { get; set; }
        public ProductionUnit ProductionUnit { get; set; }
        public Education Education { get; set; }
        public Address Address { get; set; }
        public AddressPoint AddressPoint { get; set; }
        public UnstructuredAddress UnstructuredAddress { get; set; }
    }
}