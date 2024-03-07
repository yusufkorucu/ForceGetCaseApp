using ForceGet.Domain.Dtos.Request;
using ForceGet.Domain.Dtos.Response;
using Newtonsoft.Json;
using RestSharp;

namespace ForceGet.WebApp.Integration
{
    public class IntegrationService : IIntegrationService
    {
        public async Task<ApiResponse<bool>> CreateShipping(ShippingInfoCreateRequestDto requestDto)
        {
            try
            {
                var client = new RestClient("http://localhost:5000");

                var request = new RestRequest("/api/ShippingInfo", Method.POST);

                var body=JsonConvert.SerializeObject(requestDto);

                request.AddJsonBody(body);

                IRestResponse response = client.Execute(request);

                if (response.IsSuccessful)
                {

                    var result = JsonConvert.DeserializeObject<ApiResponse<bool>>(response.Content);

                    return new ApiResponse<bool>() { IsSuccess = true, Result = result.Result };
                }

                return new ApiResponse<bool>() { IsSuccess = false, Result = true, ErrorMessage = response.ErrorMessage };
            }
            catch (Exception ex)
            {

                return new ApiResponse<bool>() { IsSuccess = false, Result = false, ErrorMessage = ex.Message };
            }
        }

        public async Task<ApiResponse<List<ShippingInfoResponseDto>>> GetPagingList(DataTableRequestDto requestDto)
        {
            try
            {
                var client = new RestClient("http://localhost:5000");

                var request = new RestRequest("/api/ShippingInfo", Method.GET);

                IRestResponse response = client.Execute(request);

                if (response.IsSuccessful)
                {

                    var result = JsonConvert.DeserializeObject<ApiResponse<List<ShippingInfoResponseDto>>>(response.Content);

                    return new ApiResponse<List<ShippingInfoResponseDto>>() { IsSuccess = true, Result = result.Result };
                }
                return new ApiResponse<List<ShippingInfoResponseDto>>() { IsSuccess = false, Result = null, ErrorMessage = response.ErrorMessage };
            }
            catch (Exception ex)
            {

                return new ApiResponse<List<ShippingInfoResponseDto>>() { IsSuccess = false, Result = null, ErrorMessage = ex.Message };
            }

        }
    }
}
