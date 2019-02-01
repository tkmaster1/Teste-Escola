using System.Collections.Generic;

namespace GerenciarEscolaTeste.Domain.Interfaces.Repository.Base
{
    public interface BaseRepository<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAllAsNoTracking();
    }
}
