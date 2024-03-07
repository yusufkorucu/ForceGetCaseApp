using ForceGet.Entity.Enums;
using System.ComponentModel.DataAnnotations;

namespace ForceGet.Domain.Dtos.Request
{
    public class ShippingInfoCreateRequestDto
    {
        [Required]
        public ModeTypeEnum Mode { get; set; }

        [Required]
        public MovementTypeEnum MovementType { get; set; }

        [Required]
        public IncotermsEnum Incoterms { get; set; }

        [Required]
        public PackageTypeEnum PackageType { get; set; }

        [Required(ErrorMessage = "Unit1Id boş geçilemez")]
        [Range(1, int.MaxValue, ErrorMessage = "Unit1Id boş geçilemez")]
        public int Unit1Id { get; set; }

        [Required(ErrorMessage = "Unit1Size boş geçilemez")]
        [Range(1, int.MaxValue, ErrorMessage = "Unit1Size boş geçilemez")]
        public int Unit1Size { get; set; }

        [Required(ErrorMessage = "Unit2Id boş geçilemez")]
        [Range(1, int.MaxValue, ErrorMessage = "Unit2Id boş geçilemez")]
        public int Unit2Id { get; set; }

        [Required(ErrorMessage = "Unit2Size boş geçilemez")]
        [Range(1, int.MaxValue, ErrorMessage = "Unit2Size boş geçilemez")]
        public int Unit2Size { get; set; }

        [Required(ErrorMessage = "CurrencyId boş geçilemez")]
        [Range(1, int.MaxValue, ErrorMessage = "CurrencyId boş geçilemez")]
        public int CurrencyId { get; set; }

        [Required(ErrorMessage = "CountryId boş geçilemez")]
        [Range(1, int.MaxValue, ErrorMessage = "CountryId boş geçilemez")]
        public int CountryId { get; set; }

        [Required(ErrorMessage = "CityId boş geçilemez")]
        [Range(1, int.MaxValue, ErrorMessage = "CityId boş geçilemez")]
        public int CityId { get; set; }

    }
}
