using Livraria.Dal.Abstracts;
using Livraria.Dal.Interfaces;
using Livraria.Domain.Entities;

namespace Livraria.Dal
{
    public class LivroDal : CrudDalBase<LivroEntity>, ILivroDal
    {
        public LivroDal(LivrariaDbContext dbContext) : base(dbContext)
        {
        }
    }
}
