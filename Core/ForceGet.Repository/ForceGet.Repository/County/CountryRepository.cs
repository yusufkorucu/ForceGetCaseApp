using ForceGet.Context;
using ForceGet.Entity.Entites;
using ForceGet.Repository.County;

namespace ForceGet.Repository
{
    public class CountryRepository : RepositoryBase<Country>, ICountryRepository
    {
        public CountryRepository(ForceGetContext context) : base(context)
        {
        }
    }
}
