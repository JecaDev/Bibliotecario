using Catalogo.CatalogService.Models;
using System.Collections.Generic;

namespace Catalogo.CatalogService.Services
{


    public class CatalogoService : ICatalogoService
    {
        private readonly List<Livro> _livros = new List<Livro>();
        public IEnumerable<Livro> GetAll()
        {
            return _livros;
        }

        public string Add(Livro livro)
        {
            _livros.Add(livro);
            return "Livro Adicionado com Sucesso";
        }

        public string Update(Livro livro)
        {
            var existe = _livros.FindIndex(l => l.Id == livro.Id);
            if (existe != -1)
            {
                _livros[existe] = livro;
                return "Livro atualizado com sucesso.";
            }
            return "Livro não encontrado.";
        }

        public string Delete(int id) 
        {
            var livro = _livros.FirstOrDefault(l => l.Id == id);
            if (livro != null)
            {
                _livros.Remove(livro);
                return "Livro deletado com sucesso.";
            }
            return "Não tem Livro para excluir";
        }
    }
}
