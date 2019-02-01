using GerenciarEscolaTeste.Domain.Entities;
using GerenciarEscolaTeste.Domain.Interfaces.Repository;
using GerenciarEscolaTeste.Domain.Interfaces.Services;
using GerenciarEscolaTeste.Domain.Services.Base;
using System.Collections.Generic;
using System.Linq;

namespace GerenciarEscolaTeste.Domain.Services
{
    public class TurmaService : BaseService<Turma>, ITurmaService
    {
        private readonly ITurmaRepository _turmaRepository;
        private readonly IPessoaRepository _pessoaRepository;

        public TurmaService(ITurmaRepository turmaRepository, IPessoaRepository pessoaRepository)
            : base(turmaRepository)
        {
            _turmaRepository = turmaRepository;
            _pessoaRepository = pessoaRepository;
        }

        public IEnumerable<Pessoa> GetPessoaPorTipoPessoa(int TipoPessoaId)
        {
            var query = _pessoaRepository.GetAll();

            query = (TipoPessoaId > 0) ? query.Where(x => x.TipoPessoaId.Equals(TipoPessoaId)) : query;

            return query.ToList();
        }
    }
}
