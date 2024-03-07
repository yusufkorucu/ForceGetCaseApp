using ForceGet.Domain.Dtos.Base;
using ForceGet.Repository;
using ForceGet.Repository.County;
using Microsoft.EntityFrameworkCore;

namespace ForceGet.Services
{
    public class UIService : IUIService
    {
        private readonly ICityRepository _cityRepository;
        private readonly ICountryRepository _countryRepository;
        private readonly ICurrencyRepository _currencyRepository;
        private readonly IUnit1Repository _unit1Repository;
        private readonly IUnit2Repository _unit2Repository;

        public UIService(ICityRepository cityRepository, ICountryRepository countryRepository, ICurrencyRepository currencyRepository, IUnit1Repository unit1Repository, IUnit2Repository unit2Repository)
        {
            _cityRepository = cityRepository;
            _countryRepository = countryRepository;
            _currencyRepository = currencyRepository;
            _unit1Repository = unit1Repository;
            _unit2Repository = unit2Repository;
        }

        public async Task<List<SelectDTO>> GetCities()
        {
            var result = await _cityRepository.GetBy(x => true).Select(x => new SelectDTO
            {
                Id = x.CityId,
                Name = x.Name
            }).ToListAsync();

            return result;
        }

        public async Task<List<SelectDTO>> GetCountries()
        {
            var result = await _countryRepository.GetBy(x => true).Select(x => new SelectDTO
            {
                Id = x.CountryId,
                Name = x.Name
            }).ToListAsync();

            return result;
        }

        public async Task<List<SelectDTO>> GetCurrencies()
        {
            var result = await _currencyRepository.GetBy(x => true).Select(x => new SelectDTO
            {
                Id = x.CurrencyId,
                Name = x.Name
            }).ToListAsync();

            return result;
        }

        public async Task<List<SelectDTO>> GetUnities1()
        {
            var result = await _unit1Repository.GetBy(x => true).Select(x => new SelectDTO
            {
                Id = x.Unit1Id,
                Name = x.Name
            }).ToListAsync();

            return result;
        }

        public async Task<List<SelectDTO>> GetUnities2()
        {
            var result = await _unit2Repository.GetBy(x => true).Select(x => new SelectDTO
            {
                Id = x.Unit2Id,
                Name = x.Name
            }).ToListAsync();

            return result;
        }
    }
}
