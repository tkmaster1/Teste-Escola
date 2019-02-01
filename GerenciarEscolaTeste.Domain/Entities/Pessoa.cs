using System;
using System.Collections.Generic;

namespace GerenciarEscolaTeste.Domain.Entities
{
    public class Pessoa
    {
        public int PessoaId { get; set; }

        public string NomePessoa { get; set; }
        public string CPF { get; set; }

        public DateTime DataNascimento { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public DateTime? DataExclusao { get; set; }

        public int TipoPessoaId { get; set; }
        public virtual TipoPessoa TipoPessoa { get; set; }
        public virtual IEnumerable<Turma> Turmas { get; set; }
        public virtual IEnumerable<Contato> Contatos { get; set; }
    }
}
