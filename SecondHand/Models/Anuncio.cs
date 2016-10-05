using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SecondHand.Models
{
    public class Anuncio
    {
        #region "Construtores"

        public Anuncio() { }

        public Anuncio(int Id, Produto Produto, DateTime DataAnuncio, string Titulo)
        {
            this.Id = Id;
            this.Produto = Produto;
            this.DataAnuncio = DataAnuncio;
            this.Titulo = Titulo;
        }

        #endregion

        [Required(ErrorMessage = "Identificador obrigatório!")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Título do anúncio obrigatório!", AllowEmptyStrings = false)]
        [StringLength(100, ErrorMessage = "O título pode ter no máximo 100 caracteres.")]
        [Display(Name = "Título")]
        public string Titulo { get; set; }


        public Produto Produto { get; set; }

        [Display(Name = "Data do anúncio")]
        public DateTime DataAnuncio { get; set; }
    }
}