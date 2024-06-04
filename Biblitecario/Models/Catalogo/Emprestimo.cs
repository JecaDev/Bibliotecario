using System.ComponentModel.DataAnnotations;

namespace Bibliotecario.Models.Catalogo
{
    public class Emprestimo
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public int LivroId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime? DataDevolucao { get; set; }
    }

    public class EmprestimoBusca
    {
        public int LivroId { get; set; }
        public int UsuarioId { get; set; }
    }

    public class ReturnBusca
    {
        public int LivroId { get; set; }
        public int UsuarioId { get; set; }
    }
}
