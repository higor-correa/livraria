using Livraria.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Livraria.Dal
{
    public class LivrariaDbContext : DbContext
    {
        public DbSet<LivroEntity> Livros { get; set; }

        public LivrariaDbContext(DbContextOptions<LivrariaDbContext> options) : base(options)
        {

        }
    }
}
