using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace treinamentoProgram.EntityFramework.Repositories
{
    public abstract class treinamentoProgramRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<treinamentoProgramDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected treinamentoProgramRepositoryBase(IDbContextProvider<treinamentoProgramDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class treinamentoProgramRepositoryBase<TEntity> : treinamentoProgramRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected treinamentoProgramRepositoryBase(IDbContextProvider<treinamentoProgramDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
