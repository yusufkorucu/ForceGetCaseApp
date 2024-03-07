using ForceGet.Context;
using ForceGet.Entity.Entites;

namespace ForceGet.Repository
{
    public class CurrencyRepository : RepositoryBase<Currency>, ICurrencyRepository
    {
        public CurrencyRepository(ForceGetContext context) : base(context)
        {
        }
    }
}
