using System;
using System.Collections.Generic;

namespace GerenciarEscolaTeste.Domain.Entities
{
    public class Turma
    {
        public int TurmaId { get; set; }
        public string NumTurma { get; set; }

        /// <summary>
        /// (manhã, tarde, noite)
        /// </summary>
        public string Periodo { get; set; }

        public DateTime DataTurma { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public TimeSpan HorarioTurma { get; set; }

        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual IEnumerable<Pessoa> Pessoas { get; set; }
    }
}
