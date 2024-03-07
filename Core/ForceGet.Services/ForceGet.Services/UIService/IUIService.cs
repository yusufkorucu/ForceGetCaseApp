using ForceGet.Domain.Dtos.Base;

namespace ForceGet.Services
{
    public interface IUIService
    {
        Task<List<SelectDTO>> GetCountries();
        Task<List<SelectDTO>> GetCities();
        Task<List<SelectDTO>> GetCurrencies();
        Task<List<SelectDTO>> GetUnities1();
        Task<List<SelectDTO>> GetUnities2();
    }
}
