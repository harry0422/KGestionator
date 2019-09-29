using System.Linq;
using KGestionator.Domain.Commons;

namespace KGestionator.Infrastructure.Repositories.NHibernate.Commons
{
    public abstract class NhRepositoryBase<TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey> where TEntity : IAggregateRoot
    {
        public void Delete(TPrimaryKey id)
        {
            throw new System.NotImplementedException();
        }

        public TEntity Get(TPrimaryKey key)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<TEntity> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Insert(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}