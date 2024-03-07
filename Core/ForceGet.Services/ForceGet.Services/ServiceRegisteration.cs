using ForceGet.Repository;
using ForceGet.Repository.County;
using ForceGet.Repository.ShippingInfo;
using ForceGet.Services.ShippingInfoService;
using Microsoft.Extensions.DependencyInjection;

namespace ForceGet.Services
{
    public static class ServiceRegisteration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {

            services.AddTransient<IShippingInfoService, ShippingInfoService.ShippingInfoService>();
            services.AddTransient<IShippingInfoRepository, ShippingInfoRepository>();

        }


        public static void AddUIServices(this IServiceCollection services)
        {
            services.AddTransient<IUnit1Repository, Unit1Repository>();
            services.AddTransient<IUnit2Repository, Unit2Repository>();
            services.AddTransient<ICityRepository, CityRepository>();
            services.AddTransient<ICurrencyRepository, CurrencyRepository>();
            services.AddTransient<ICountryRepository, CountryRepository>();
            services.AddTransient<IUIService, UIService>();


        }
    }
}
