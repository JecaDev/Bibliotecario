using Catalogo.CatalogService.Models;

namespace Catalogo.CatalogService.Services
{
    public interface ICatalogoService
    {
        IEnumerable<Livro> GetAll();
        string Add(Livro livro);
        string Update(Livro livro);
        string Delete(int id);
    }
}
