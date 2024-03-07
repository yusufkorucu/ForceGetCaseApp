using ForceGet.Context;
using ForceGet.Entity.Entites;

namespace ForceGet.Repository
{
    public class Unit1Repository : RepositoryBase<Unit1>, IUnit1Repository
    {
        public Unit1Repository(ForceGetContext context) : base(context)
        {
        }
    }
}
