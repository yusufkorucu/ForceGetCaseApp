using ForceGet.Context;
using ForceGet.Entity.Entites;

namespace ForceGet.Repository
{
    public class CityRepository : RepositoryBase<City>, ICityRepository
    {
        public CityRepository(ForceGetContext context) : base(context)
        {
        }
    }
}
