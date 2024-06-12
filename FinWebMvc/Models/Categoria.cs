using FinWebMvc.Models.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FinWebMvc.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Descrição")]
        public string Descricao { get; set; } = null!;

        [Required]
        public ETipoCategoria Tipo { get; set; }
    }
}
