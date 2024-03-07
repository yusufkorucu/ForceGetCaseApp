using ForceGet.Domain.Dtos.Request;
using ForceGet.Services.ShippingInfoService;
using Microsoft.AspNetCore.Mvc;

namespace ForceGet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippingInfoController : ControllerBase
    {
        #region Field

        private readonly IShippingInfoService _shippingInfoService;

        #endregion

        #region Ctor

        public ShippingInfoController(IShippingInfoService shippingInfoService)
        {
            _shippingInfoService = shippingInfoService;
        }

        #endregion

        #region Methods

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _shippingInfoService.GetShippingList();

            if (response?.IsSuccess == true)
                return Ok(response);

            return BadRequest(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ShippingInfoCreateRequestDto shippingInfoCreateRequestDto)
        {
            var response = await _shippingInfoService.CreateShipping(shippingInfoCreateRequestDto);
            if (response?.IsSuccess == true)
                return Ok(response);

            return BadRequest(response);

        }

        #endregion
    }
}
