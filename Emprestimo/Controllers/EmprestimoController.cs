using Emprestimo.EmprestimoService.Models;
using Emprestimo.EmprestimoService.Service;
using Microsoft.AspNetCore.Mvc;

namespace Emprestimo.EmprestimoService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmprestimoController : ControllerBase
    {
        private readonly IEmprestimoService _emprestimoService;

        public EmprestimoController(IEmprestimoService emprestimoService)
        {
            _emprestimoService = emprestimoService;
        }

        [HttpPost]
        public IActionResult BuscaEmprestimo([FromBody] EmprestimoBusca busca)
        {
            var resultado = _emprestimoService.BuscarEmprestimo(busca);
            return Ok(resultado);
        }

        [HttpGet]
        public IActionResult ReturnBuscar([FromBody] ReturnBusca returnBusca)
        {
            var resultado = _emprestimoService.ReturnBuscar(returnBusca);
            return Ok(resultado);
        }
    
    }
}
