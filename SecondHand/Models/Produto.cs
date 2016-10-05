using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SecondHand.Models
{
    public enum Situacao
    {
        Indisponivel = 0,
        EmNegociacao = 1,
        Disponivel = 2       
    }

    public class Produto
    {
        #region "Construtores"

        /// <summary>
        /// Construtor da classe Produto.
        /// </summary>
        /// <param name="Id">identificador único doproduto</param>
        /// <param name="DataCadastro">Data em que o item foi cadastrado</param>
        /// <param name="Situacao">Indicador (lógico) da situação do item no sistema.</param>
        public Produto(int Id,
                       DateTime DataCadastro, Usuario Usuario)
        {
            this.Id = Id;
            this.DataCadastro = DataCadastro;
            this.Usuario = Usuario;
            this.Situacao = 2;
        }

        public Produto() { }

        #endregion
        
        // ADICIONAR CÓDIGO DA CATEGORIA


        [Required(ErrorMessage = "Identificador obrigatório!")]
        public int Id { get; set; }

        //[Required(ErrorMessage = "Nome do produto obrigatório!", AllowEmptyStrings = false)]
        //[StringLength(100, ErrorMessage = "Nome pode ter no máximo 100 caracteres")]
        //public string Nome { get; set; }

        [Required(ErrorMessage = "Preço do produto obrigatório!")]
        [Range(1.0, 100.0, ErrorMessage = "O preço deve ser entre R$ 1.00 e R$ 100.00!")]
        public double Preco { get; set; }

        [Display(Name = "Data de Cadastro")]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "Indique qual a situação do produto.")]
        [Display(Name = "Situação")]
        public int Situacao { get; set; }

        [Required(ErrorMessage = "Selecione uma categoria!")]
        public Categoria Categoria { get; set; }

        [Required(ErrorMessage = "Selecione um local!")]
        public string Local { get; set; }

        [Display(Name = "Descrição Completa")]
        public string DescricaoCompleta
        {
            get { return this.Nome + " " + this.Id.ToString(); }
        }

        [Required(ErrorMessage = "Código do anunciante obrigatório!", AllowEmptyStrings = false)]
        public Usuario Usuario { get; set; }


        public virtual ICollection<Arquivo> Arquivos { get; set; }
        public ICollection<Questionamento> Questionamentos { get; set; }
        //public ICollection<Categoria> Categorias { get; set; }

    }
}