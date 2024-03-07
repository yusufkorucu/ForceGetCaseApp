using ForceGet.Domain.Dtos.Request;
using ForceGet.Domain.Dtos.Response;

namespace ForceGet.Services.ShippingInfoService
{
    public interface IShippingInfoService
    {
        Task<ApiResponse<bool>> CreateShipping(ShippingInfoCreateRequestDto shippingInfoCreateRequest);
        Task<ApiResponse<List<ShippingInfoResponseDto>>> GetShippingList();
    }
}
