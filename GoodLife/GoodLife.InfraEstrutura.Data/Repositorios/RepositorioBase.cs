

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using GoodLife.Domain.Interfaces;

namespace GoodLife.InfraEstrutura.Data.Repositorios
{
    public class RepositorioBase<TEntity> :IDisposable, IRepositorioBase<TEntity> where TEntity : class
    {
       protected Contexto.Contexto  Db = new Contexto.Contexto();
        public void salvar(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();

        }

        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }

      


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
