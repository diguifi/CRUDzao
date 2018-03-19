using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace CRUDzao.EntityFramework.Repositories
{
    public abstract class CRUDzaoRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<CRUDzaoDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected CRUDzaoRepositoryBase(IDbContextProvider<CRUDzaoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class CRUDzaoRepositoryBase<TEntity> : CRUDzaoRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected CRUDzaoRepositoryBase(IDbContextProvider<CRUDzaoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
