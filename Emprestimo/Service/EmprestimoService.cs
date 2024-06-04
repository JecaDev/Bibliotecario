using Emprestimo.EmprestimoService.Models;
using System.Collections.Generic;
using System.Linq;

namespace Emprestimo.EmprestimoService.Service
{
    public class EmprestimoService : IEmprestimoService
    {
        private readonly List<EmprestimoModel> _emprestimos = new List<EmprestimoModel>();

        public string BuscarEmprestimo(EmprestimoBusca emprestimoBusca)
        {
            var emprestimo = _emprestimos.FirstOrDefault(e => e.LivroId == emprestimoBusca.LivroId && e.UsuarioId == emprestimoBusca.UsuarioId);
            return emprestimo != null ? "Empréstimo encontrado" : "Empréstimo não encontrado";
        }

        public string ReturnBuscar(ReturnBusca returnBusca)
        {
            var emprestimo = _emprestimos.FirstOrDefault(e => e.LivroId == returnBusca.LivroId && e.UsuarioId == returnBusca.UsuarioId && e.DataDevolucao == null);
            if (emprestimo != null)
            {
                emprestimo.DataDevolucao = DateTime.Now;
                return "Empréstimo devolvido com sucesso";
            }
            return "Empréstimo não encontrado ou já devolvido";
        }
    }
}
