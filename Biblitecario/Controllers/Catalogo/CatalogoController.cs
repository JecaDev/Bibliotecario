using AutoMapper;
using Bibliotecario.Data;
using Bibliotecario.Data.Dto.Catalogo;
using Bibliotecario.Models.Catalogo;
using Microsoft.AspNetCore.Mvc;

namespace Biblitecario.Controllers.Catalogo
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogoController : ControllerBase
    {
        private CatalogoContext _context;
        private IMapper _mapper;

        public CatalogoController(IMapper mapper, CatalogoContext _context)
        {
            _mapper = mapper;
            _context = _context;
        }
        [HttpPost]
        public IActionResult AdicionarLivro([FromBody] LivroDto livroDto)
        {
            Livro livro = _mapper.Map<Livro>(livroDto);
            _context.livros.Add(livro);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperarLivroPorId), new { id = livro.Id }, livro);
        }

        [HttpGet("livro")]
        public IEnumerable<LivroDto> RecuperarLivro([FromBody] int skip = 0, [FromBody] int take = 50)
        {
            return _mapper.Map<List<LivroDto>>(_context.livros.Skip(skip).Take(take));
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarLivroPorId(int id)
        {
            var livro = _context.livros.FirstOrDefault(x => x.Id == id);
            if (livro == null)
            {
                return NotFound();
            }
            var livoDto = _mapper.Map<LivroDto>(livro);
            return Ok(livoDto);
        }

        [HttpPut("{if}")]
        public IActionResult AtualizaLivro(int id, [FromBody] LivroDto livroDto) 
        {
            var livro = _context.livros.Where(x => x.Id == id).FirstOrDefault();

            if(livro == null)
            {
                return NotFound();
            }

            _mapper.Map(livroDto, livro);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
