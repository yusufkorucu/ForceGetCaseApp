using ForceGet.Context;
using ForceGet.Repository.ShippingInfo;

namespace ForceGet.Repository
{
    public class ShippingInfoRepository : RepositoryBase<Entity.Entites.ShippingInfo>, IShippingInfoRepository
    {
        public ShippingInfoRepository(ForceGetContext context) : base(context)
        {
        }
    }
}
