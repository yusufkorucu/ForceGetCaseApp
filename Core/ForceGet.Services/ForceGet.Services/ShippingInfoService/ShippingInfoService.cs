using AutoMapper;
using ForceGet.Domain.Dtos.Request;
using ForceGet.Domain.Dtos.Response;
using ForceGet.Domain.Helper;
using ForceGet.Entity.Entites;
using ForceGet.Repository.ShippingInfo;
using Microsoft.EntityFrameworkCore;

namespace ForceGet.Services.ShippingInfoService
{
    public class ShippingInfoService : IShippingInfoService
    {
        #region Field

        private readonly IShippingInfoRepository _shippingInfoRepository;
        private readonly IMapper _mapper;

        #endregion

        #region Ctor

        public ShippingInfoService(IShippingInfoRepository shippingInfoRepository, IMapper mapper)
        {
            _shippingInfoRepository = shippingInfoRepository;
            _mapper = mapper;
        }

        #endregion

        #region Methods

        public async Task<ApiResponse<bool>> CreateShipping(ShippingInfoCreateRequestDto shippingInfoCreateRequest)
        {
            try
            {
                var data = _mapper.Map<ShippingInfo>(shippingInfoCreateRequest);
                await _shippingInfoRepository.AddAsync(data);

                return new ApiResponse<bool>() { IsSuccess = true, Result = true };

            }
            catch (Exception ex)
            {

                return new ApiResponse<bool>() { IsSuccess = false, Result = false, ErrorMessage = ex.Message };

            }


        }

        public async Task<ApiResponse<List<ShippingInfoResponseDto>>> GetShippingList()
        {
            try
            {
                var result = _shippingInfoRepository.GetBy(x => true).Include(x => x.Unit1).Include(x => x.Unit2).Include(x => x.City).Include(x => x.Country).Include(x => x.Currency).Select(x => new ShippingInfoResponseDto
                {

                    City = x.City.Name,
                    Country = x.Country.Name,
                    Currency = x.Currency.Name,
                    Unit1 = x.Unit1Size + x.Unit1.Name,
                    Unit2 = x.Unit2Size + x.Unit2.Name,
                    PackageType = x.PackageType.GetEnumDescription(),
                    Incoterms = x.Incoterms.GetEnumDescription(),
                    Mode = x.Mode.GetEnumDescription(),
                    MovementType = x.MovementType.GetEnumDescription(),
                }).ToList();

                return new ApiResponse<List<ShippingInfoResponseDto>> { Result = result, IsSuccess = true };
            }
            catch (Exception ex)
            {
                return new ApiResponse<List<ShippingInfoResponseDto>> { Result = null, IsSuccess = false, ErrorMessage = ex.Message };
            }
        }

        #endregion
    }
}