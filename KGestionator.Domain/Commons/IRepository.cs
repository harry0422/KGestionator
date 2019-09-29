using System.Linq;

namespace KGestionator.Domain.Commons
{
    public interface IRepository
    {

    }

    public interface IRepository<TEntity, TPrimaryKey> : IRepository where TEntity : IAggregateRoot
    {
        IQueryable<TEntity> GetAll();
        TEntity Get(TPrimaryKey key);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TPrimaryKey id);
    }
}
