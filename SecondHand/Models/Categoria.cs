using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SecondHand.Models
{
    public class Categoria
    {
        [Required(ErrorMessage = "Identificador obrigatório!")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome da categoria obrigatório!", AllowEmptyStrings = false)]
        [StringLength(100, ErrorMessage = "Nome pode ter no máximo 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Descrição obrigatória!", AllowEmptyStrings = false)]
        [MaxLength(200)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public ICollection<Produto> Produtos { get; set; }
    }
}