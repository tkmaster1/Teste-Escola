using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace GerenciarEscolaTeste.Application.ViewModels
{
    public class PessoaViewModel
    {
        public PessoaViewModel()
        {
            this.TipoPessoa = new TipoPessoaViewModel();
            // this.ContatoList = new List<ContatoViewModel>();
        }

        [Key]
        public int PessoaId { get; set; }

        [Display(Name = @"Nome:")]
        [Required(ErrorMessage = @"Preencha o campo Nome da Pessoa")]
        [MaxLength(150, ErrorMessage = "O campo Nome da Pessoa permite o máximo de 150 caracteres.")]
        [MinLength(5, ErrorMessage = "O campo Nome da Pessoa permite o mínimo de 5 caracteres.")]
        public string NomePessoa { get; set; }

        [Required(ErrorMessage = @"Preencha o campo CPF")]
        [MaxLength(14, ErrorMessage = "O campo CPF permite o máximo de 11 caracteres.")]
        [MinLength(14, ErrorMessage = "O campo CPF permite o mínimo de 11 caracteres.")]
        [DisplayName("CPF:")]
        public string CPF { get; set; }

        [NotMapped]
        public string CpfFormatado
        {
            get
            {
                return FormatCPF(CPF);
            }
        }

        [DisplayName("Data de Nascimento:")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataInclusao { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? DataAlteracao { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? DataExclusao { get; set; }

        [DisplayName("Tipo de Pessoa:")]
        [Required(ErrorMessage = @"Preencha o campo tipo Pessoa")]
        public int TipoPessoaId { get; set; }
        public virtual TipoPessoaViewModel TipoPessoa { get; set; }
        public IEnumerable<SelectListItem> TipoPessoaSelectList { get; set; }
        public virtual IEnumerable<TurmaViewModel> Turmas { get; set; }
        // public IEnumerable<ContatoViewModel> ContatoList { get; set; }

        //000.000.000-00
        public string FormatCPF(string sender)
        {
            string response = sender.Trim();
            if (response.Length == 11)
            {
                response = response.Insert(9, "-");
                response = response.Insert(6, ".");
                response = response.Insert(3, ".");
            }
            return response;
        }
    }
}
