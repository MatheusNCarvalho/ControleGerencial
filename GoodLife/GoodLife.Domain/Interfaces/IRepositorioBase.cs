

using System.Collections;
using System.Collections.Generic;

namespace GoodLife.Domain.Interfaces
{
    public interface IRepositorioBase<TEntity> where TEntity : class
    {
        void salvar(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();

    }
}
