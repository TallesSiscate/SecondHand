using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SecondHand.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "Identificador obrigatório!")]
        public int Id { get; set; }

        [Index(IsUnique=true)]
        [MinLength(5)]
        [Required(ErrorMessage = "O nome de login é obrigatório!", AllowEmptyStrings = false)]
        public string Login { get; set; }

        // criptografia
        [Required(ErrorMessage = "O nome de login é obrigatório!", AllowEmptyStrings = false)]
        [MinLength(4)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório!", AllowEmptyStrings = false)]
        [MinLength(4)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório!", AllowEmptyStrings = false)]
        [Display(Name = "E-mail")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "O e-mail fornecido é inválido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A cidade é obrigatória!", AllowEmptyStrings = false)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O bairro é obrigatório!", AllowEmptyStrings = false)]
        public string Bairro { get; set; }


        public ICollection<Produto> ProdutosAnunciados { get; set; }
        public ICollection<Produto> ProdutosComprados { get; set; }
        public ICollection<Questionamento> Questionamentos { get; set; }
    }
}