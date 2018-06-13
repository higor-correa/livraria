using Livraria.Dal.Interfaces;
using Livraria.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Livraria.Dal.Abstracts
{
    public abstract class CrudDalBase<TEntity> : ICrudDal<TEntity> where TEntity : class, IEntity
    {
        protected readonly LivrariaDbContext _dbContext;

        public CrudDalBase(LivrariaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Alterar(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            _dbContext.SaveChanges();
        }

        public void Inserir(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            _dbContext.SaveChanges();
        }

        public List<TEntity> Listar()
        {
            return _dbContext.Set<TEntity>().AsNoTracking().ToList();
        }

        public TEntity Obter(int id)
        {
            return _dbContext.Set<TEntity>().AsNoTracking().SingleOrDefault(l => l.Id == id);
        }

        public void Remover(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}
