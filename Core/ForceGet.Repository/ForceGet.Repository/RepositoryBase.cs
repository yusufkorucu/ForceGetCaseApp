using ForceGet.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ForceGet.Repository
{
    public class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class
    {

        protected readonly ForceGetContext Context;

        public RepositoryBase(ForceGetContext context)
            => this.Context = context;

        public async Task AddAsync(TEntity entity)
        {

            await Context.Set<TEntity>().AddAsync(entity);
            await Context.SaveChangesAsync();
        }

        public Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
             => Context.Set<TEntity>().FirstOrDefaultAsync(predicate);

        public IQueryable<TEntity> GetBy(Expression<Func<TEntity, bool>> predicate)
                => Context.Set<TEntity>().Where(predicate);

        public async Task<IEnumerable<TEntity>> GetAllAsync()
            => await Context.Set<TEntity>().ToListAsync();

        public async ValueTask<TEntity> GetByIdAsync(Guid id)
            => await Context.Set<TEntity>().FindAsync(id);

    }
}
