using Bibliotecario.Models.Catalogo;
using Microsoft.EntityFrameworkCore;

namespace Bibliotecario.Data
{
    public class CatalogoContext : DbContext
    {
        public CatalogoContext(DbContextOptions<CatalogoContext> opts) : base(opts) 
        {

        }
        public DbSet<Livro> livros { get; set; }
    }
}
