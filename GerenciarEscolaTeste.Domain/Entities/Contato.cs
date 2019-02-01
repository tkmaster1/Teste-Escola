using System;

namespace GerenciarEscolaTeste.Domain.Entities
{
    public class Contato
    {
        public int ContatoId { get; set; }

        public string Ddd { get; set; }
        public string Ddi { get; set; }
        public string TelFixo { get; set; }
        public string TelCelular { get; set; }
        public string Email { get; set; }

        public DateTime DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public DateTime? DataExclusao { get; set; }

        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
