using ForceGet.Entity.Enums;

namespace ForceGet.Entity.Entites
{
    public class ShippingInfo
    {
        public int ShippingInfoId { get; set; }

        public int Unit1Size { get; set; }
        public int Unit2Size { get; set; }
        public int CountryId { get; set; }

        public IncotermsEnum Incoterms { get; set; }
        public ModeTypeEnum Mode { get; set; }
        public MovementTypeEnum MovementType { get; set; }
        public PackageTypeEnum PackageType { get; set; }
        public Country Country { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }

        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }

        public int Unit1Id { get; set; }
        public Unit1 Unit1 { get; set; }

        public int Unit2Id { get; set; }
        public Unit2 Unit2 { get; set; }
    }
}
