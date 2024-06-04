using Emprestimo.EmprestimoService.Models;

namespace Emprestimo.EmprestimoService.Service
{
    public interface IEmprestimoService
    {
        string BuscarEmprestimo(EmprestimoBusca emprestimoBusca);
        string ReturnBuscar(ReturnBusca returnBusca);
    }
}
