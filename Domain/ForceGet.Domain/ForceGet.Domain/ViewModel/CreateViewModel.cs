using ForceGet.Domain.Dtos.Base;
using ForceGet.Entity.Enums;
using System.Web.WebPages.Html;

namespace ForceGet.Domain.ViewModel
{
    public class CreateViewModel
    {
        public EnumViewModel<ModeTypeEnum> ModeTypeEnum { get; set; }
        public EnumViewModel<MovementTypeEnum> MovementTypeEnum { get; set; }
        public EnumViewModel<IncotermsEnum> IncotermsEnum { get; set; }
        public EnumViewModel<PackageTypeEnum> PackageTypeEnum { get; set; }
        public List<SelectDTO> Cities { get; set; }
        public List<SelectDTO> Countries { get; set; }
        public List<SelectDTO> Currencies { get; set; }
        public List<SelectDTO> Unities1 { get; set; }
        public List<SelectDTO> Unities2 { get; set; }

        public CreateViewModel()
        {
            ModeTypeEnum = new EnumViewModel<ModeTypeEnum>();
            MovementTypeEnum = new EnumViewModel<MovementTypeEnum>();
            IncotermsEnum = new EnumViewModel<IncotermsEnum>();
            PackageTypeEnum = new EnumViewModel<PackageTypeEnum>();
        }
    }
}
