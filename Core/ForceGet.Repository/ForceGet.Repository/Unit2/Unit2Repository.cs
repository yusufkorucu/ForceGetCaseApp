using ForceGet.Context;
using ForceGet.Entity.Entites;

namespace ForceGet.Repository
{
    public class Unit2Repository : RepositoryBase<Unit2>, IUnit2Repository
    {
        public Unit2Repository(ForceGetContext context) : base(context)
        {
        }
    }
}
