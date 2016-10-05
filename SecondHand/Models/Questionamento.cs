using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SecondHand.Models
{
    public class Questionamento
    {
        #region "Construtores"

        public Questionamento() { }

        public Questionamento(int Id, string Comentario, int UsuarioId, int ProdutoId)
        {
            this.Id = Id;
            this.Comentario = Comentario;
            this.UsuarioId = UsuarioId;
            this.ProdutoId = ProdutoId;
        }

        #endregion

        #region "Propriedades"

        [Required(ErrorMessage = "Identificador obrigatório!")]
        public int Id { get; set; }

        public int? IdPai { get; set; }

        [Required(ErrorMessage = "Questionamento obrigatório!", AllowEmptyStrings = false)]
        [MinLength(5), MaxLength(500)]
        public string Comentario { get; set; }

        // MODIFICAR PARA DATETIME.NOW
        [Required(ErrorMessage = "Data do comentário é obrigatória!")]
        [Display(Name = "Data do Comentário")]
        public DateTime DataComentario { get; set; }

        // VERIFICAR COMO EXIBIR O NOME DO USUÁRIO NA VIEW
        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }

        public int ProdutoId { get; set; }
        [ForeignKey("ProdutoId")]
        public Produto Produto { get; set; }



        //public ICollection<Questionamento> Respostas { get; set; }

        #endregion
    }
}