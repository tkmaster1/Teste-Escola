using GerenciarEscolaTeste.Domain.Entities;
using GerenciarEscolaTeste.Domain.Interfaces.Services.Base;
using System.Collections.Generic;

namespace GerenciarEscolaTeste.Domain.Interfaces.Services
{
    public interface ITurmaService : IBaseService<Turma>
    {
        IEnumerable<Pessoa> GetPessoaPorTipoPessoa(int TipoPessoaId);
    }
}
