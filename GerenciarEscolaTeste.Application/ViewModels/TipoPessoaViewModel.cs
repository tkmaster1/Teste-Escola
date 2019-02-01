using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GerenciarEscolaTeste.Application.ViewModels
{
    public class TipoPessoaViewModel
    {
        [Key]
        public int TipoPessoaId { get; set; }

        [Required(ErrorMessage = @"Preencha o campo Descrição")]
        [MaxLength(150, ErrorMessage = "O campo Descrição permite o máximo de 150 caracteres.")]
        [MinLength(4, ErrorMessage = "O campo Descrição permite o mínimo de 5 caracteres.")]
        [DisplayName("Descrição:")]
        public string Descricao { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataInclusao { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? DataAlteracao { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? DataExclusao { get; set; }

        public virtual IEnumerable<PessoaViewModel> Pessoas { get; set; }
    }
}
