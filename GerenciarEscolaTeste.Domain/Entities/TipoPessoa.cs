using System;
using System.Collections.Generic;

namespace GerenciarEscolaTeste.Domain.Entities
{
    public class TipoPessoa
    {
        public int TipoPessoaId { get; set; }

        public string Descricao { get; set; }

        public DateTime DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public DateTime? DataExclusao { get; set; }

        public virtual IEnumerable<Pessoa> Pessoas { get; set; }
    }
}
