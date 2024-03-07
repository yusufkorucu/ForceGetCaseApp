using ForceGet.Domain.Dtos.Base;
using ForceGet.Domain.Dtos.Request;
using ForceGet.Domain.Dtos.Response;
using ForceGet.Domain.ViewModel;
using ForceGet.Entity.Enums;
using ForceGet.Services;
using ForceGet.WebApp.Integration;
using ForceGet.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace ForceGet.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IIntegrationService _integrationService;
        private readonly IUIService _uiService;

        public HomeController(ILogger<HomeController> logger, IIntegrationService integrationService, IUIService uiService)
        {
            _logger = logger;
            _integrationService = integrationService;
            _uiService = uiService;
        }
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        public async Task<IActionResult> CreateShipping()
        {
            var model = new CreateViewModel()
            {
                Currencies = await _uiService.GetCurrencies(),
                Countries = await _uiService.GetCountries(),
                Cities = await _uiService.GetCities(),
                Unities1 = await _uiService.GetUnities1(),
                Unities2 = await _uiService.GetUnities2()
            };

            return View(model);
        }


        [HttpPost]
        public async Task<JsonResult> CreateShipping(ShippingInfoCreateRequestDto model)
        {
            var result = new AddOrUpdateResponseDto();

            if (ModelState.IsValid)
            {

                var response = await _integrationService.CreateShipping(model);

                result.IsSuccess = response.IsSuccess;
                result.ErrorText = response.ErrorMessage;
            }
            else
            {
                result.ModelErrors.AddRange(ModelState.Where(x => x.Value.Errors.Any()).Select(x => new KeyValuePair<string, string>(x.Key, x.Value.Errors.FirstOrDefault().ErrorMessage)));
                result.IsSuccess = false;
            }

            return Json(result);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public async Task<JsonResult> GetShippingInfoListByPaging(DataTableRequestDto request)
        {
            var result = await _integrationService.GetPagingList(request);

            var response = new DataTableResponse<ShippingInfoResponseDto>()
            {
                data = result.Result,
                recordsTotal = result.Result.Count
            };


            return Json(response);
        }

    }
}
