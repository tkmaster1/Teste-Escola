using GerenciarEscolaTeste.Domain.Interfaces.Repository.Base;
using GerenciarEscolaTeste.Domain.Interfaces.Services.Base;
using System;
using System.Collections.Generic;

namespace GerenciarEscolaTeste.Domain.Services.Base
{
    public class BaseService<TEntity> : IDisposable, IBaseService<TEntity> where TEntity : class
    {
        private readonly BaseRepository<TEntity> _repository;

        public BaseService(BaseRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
