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
        public string Login { get; set; }

        // criptografia
        public string Senha { get; set; }


        public ICollection<Produto> ProdutosAnunciados { get; set; }
        public ICollection<Produto> ProdutosComprados { get; set; }
        public ICollection<Questionamento> Questionamentos { get; set; }
    }
}