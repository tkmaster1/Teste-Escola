using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GerenciarEscolaTeste.Application.ViewModels
{
    public class ContatoViewModel
    {
        [Key]
        public int ContatoId { get; set; }

        [Display(Name = @"Nome")]
        [Required(ErrorMessage = @"Preencha o campo Ddd")]
        [MaxLength(3, ErrorMessage = "O campo Ddd permite o máximo de 3 caracteres.")]
        [MinLength(3, ErrorMessage = "O campo Ddd permite o mínimo de 3 caracteres.")]
        [DisplayName("DDD:")]
        public string Ddd { get; set; }

        [Display(Name = @"Nome")]
        [Required(ErrorMessage = @"Preencha o campo Ddi")]
        [MaxLength(3, ErrorMessage = "O campo Ddi permite o máximo de 3 caracteres.")]
        [MinLength(3, ErrorMessage = "O campo Ddi permite o mínimo de 3 caracteres.")]
        [DisplayName("DDI:")]
        public string Ddi { get; set; }

        [Display(Name = @"Nome")]
        [Required(ErrorMessage = @"Preencha o campo Telefone Fixo")]
        [MaxLength(10, ErrorMessage = "O campo Telefone Fixo permite o máximo de 10 caracteres.")]
        [MinLength(8, ErrorMessage = "O campo Telefone Fixo permite o mínimo de 8 caracteres.")]
        [DisplayName("Tel. Fixo:")]
        public string TelFixo { get; set; }

        [Display(Name = @"Nome")]
        [Required(ErrorMessage = @"Preencha o campo Telefone Celular")]
        [MaxLength(10, ErrorMessage = "O campo Telefone Celular permite o máximo de 10 caracteres.")]
        [MinLength(9, ErrorMessage = "O campo Telefone Celular permite o mínimo de 9 caracteres.")]
        [DisplayName("Tel. Celular:")]
        public string TelCelular { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        [DisplayName("E-mail:")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataInclusao { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? DataAlteracao { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? DataExclusao { get; set; }
    }
}
