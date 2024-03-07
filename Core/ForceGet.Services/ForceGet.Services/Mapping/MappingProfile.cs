using AutoMapper;
using ForceGet.Domain.Dtos.Request;
using ForceGet.Entity.Entites;

namespace ForceGet.Services.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ShippingInfo, ShippingInfoCreateRequestDto>()
                .ReverseMap();

        }
    }
}
