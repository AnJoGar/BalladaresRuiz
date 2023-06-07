using Microsoft.EntityFrameworkCore;

namespace BalladaresRuiz.Models
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Genero> Generos { get; set; }
    }
}
