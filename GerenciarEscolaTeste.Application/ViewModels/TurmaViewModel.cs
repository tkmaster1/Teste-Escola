using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace GerenciarEscolaTeste.Application.ViewModels
{
    public class TurmaViewModel
    {
        public TurmaViewModel()
        {
            this.Pessoa = new PessoaViewModel();
        }

        [Key]
        public int TurmaId { get; set; }

        [Required(ErrorMessage = @"Preencha o campo Número da Turma")]
        [MaxLength(15, ErrorMessage = "O campo Número da Turma permite o máximo de 15 caracteres.")]
        [MinLength(3, ErrorMessage = "O campo Número da Turma permite o mínimo de 3 caracteres.")]
        [DisplayName("Número da Turma:")]
        public string NumTurma { get; set; }

        [Required(ErrorMessage = @"Preencha o campo Número da Turma")]
        [MaxLength(15, ErrorMessage = "O campo Número da Turma permite o máximo de 15 caracteres.")]
        [MinLength(3, ErrorMessage = "O campo Número da Turma permite o mínimo de 3 caracteres.")]
        [DisplayName("Período:")]
        public string Periodo { get; set; }

        [DisplayName("Data Turma:")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataTurma { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataInclusao { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? DataAlteracao { get; set; }

        public int PessoaId { get; set; }
        public virtual PessoaViewModel Pessoa { get; set; }
        public virtual IEnumerable<SelectListItem> PessoaSelectList { get; set; }
    }
}
