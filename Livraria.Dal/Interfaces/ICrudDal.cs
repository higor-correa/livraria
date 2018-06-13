using Livraria.Domain.Interfaces;
using System.Collections.Generic;

namespace Livraria.Dal.Interfaces
{
    public interface ICrudDal<TEntity> where TEntity : class, IEntity
    {
        TEntity Obter(int id);
        List<TEntity> Listar();
        void Inserir(TEntity entity);
        void Alterar(TEntity entity);
        void Remover(TEntity entity);
    }
}
