namespace OneTooX.DigitalPost.Model.AttentionData
{
    using OneTooX.DigitalPost.Model.Common;

    public class AttentionData
    {
        public GlobalLocationNumber GlobalLocationNumber { get; set; }

        public AttentionPerson AttentionPerson { get; set; }

        public ProductionUnit ProductionUnit { get; set; }

        public ContentResponsible ContentResponsible { get; set; }

        public GeneratingSystem GeneratingSystem { get; set; }

        public SorData SorData { get; set; }

        public Email Email { get; set; }

        public SeNumber SeNumber { get; set; }

        public Telephone Telephone { get; set; }

        public EId EId { get; set; }

        public Address Address { get; set; }

        public AddressPoint AddressPoint { get; set; }

        public UnstructuredAddress UnstructuredAddress { get; set; }
    }
}