using ForceGet.Domain.Dtos.Request;
using ForceGet.Domain.Dtos.Response;

namespace ForceGet.WebApp.Integration
{
    public interface IIntegrationService
    {
        Task<ApiResponse<List<ShippingInfoResponseDto>>> GetPagingList(DataTableRequestDto requestDto);
        Task<ApiResponse<bool>> CreateShipping(ShippingInfoCreateRequestDto requestDto);
    }
}
