using System.ComponentModel.DataAnnotations;

namespace Catalogo.CatalogService.Models
{
    public class Livro
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Subtitulo { get; set; }
        public string Autor { get; set; }
        public string Tematica { get; set; }
        public string Editora { get; set; }
        public bool Disponivel { get; set; }
    }
}
