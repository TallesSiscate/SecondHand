using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SecondHand.Models
{
    public class Produto
    {
        #region "Construtores"

        /// <summary>
        /// Construtor da classe Produto.
        /// </summary>
        /// <param name="Id">identificador único doproduto</param>
        /// <param name="Nome">Nome (descrição) do produto</param>
        /// <param name="DataCadastro">Data em que o item foi cadastrado</param>
        /// <param name="ItemDisponivel">indicador (lógico) se o item esta disponível no sistema ou não</param>
        public Produto(int Id,
                       string Nome,
                       DateTime DataCadastro,
                       bool ItemDisponivel)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.DataCadastro = DataCadastro;
            this.Disponivel = ItemDisponivel;
        }

        public Produto() { }

        #endregion
        
        // ADICIONAR CÓDIGO DA CATEGORIA


        [Required(ErrorMessage = "Identificador obrigatório!")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome do produto obrigatório!", AllowEmptyStrings = false)]
        [StringLength(100, ErrorMessage = "Nome pode ter no máximo 100 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Data de Cadastro")]
        public DateTime? DataCadastro { get; set; }

        [Required]
        [Display(Name = "Disponível")]
        public bool Disponivel { get; set; }

        [Display(Name = "Descrição Completa")]
        public string DescricaoCompleta
        {
            get { return this.Nome + this.Id.ToString(); }
        }

        [Required(ErrorMessage = "Código do anunciante obrigatório!", AllowEmptyStrings = false)]
        public int UsuarioId { get; set; }


        public virtual ICollection<Arquivo> Arquivos { get; set; }
        public ICollection<Questionamento> Questionamentos { get; set; }
        public ICollection<Categoria> Categorias { get; set; }

    }
}