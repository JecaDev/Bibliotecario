using Catalogo.CatalogService.Models;
using Catalogo.CatalogService.Services;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.CatalogoService.Cantrollers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogoController : ControllerBase
    {
        private readonly ICatalogoService _catalogoService;

        public CatalogoController(ICatalogoService catalogService)
        {
            _catalogoService = catalogService;
        }

        [HttpPost]
        public IActionResult Add([FromBody] Livro livro) 
        {
            _catalogoService.Add(livro);
            return Ok(livro);
        }

        [HttpGet]
        public IEnumerable<Livro> Get()
        {
            return _catalogoService.GetAll();
        }

        [HttpPut]
        public IActionResult Uodate([FromBody] Livro livro)
        {
            _catalogoService.Update(livro);
            return Ok(livro);
        }
    }
}
