namespace ForceGet.Domain.Dtos.Response
{
    public class ShippingInfoResponseDto
    {
        public string Country { get; set; }
        public string  City { get; set; }
        public string Currency { get; set; }
        public string Unit1 { get; set; }
        public string Unit2 { get; set; }
        public string PackageType { get; set; }
        public string Mode { get; set; }
        public string Incoterms { get; set; }
        public string MovementType { get; set; }
    }
}
