using GerenciarEscolaTeste.Domain.Entities;
using GerenciarEscolaTeste.Domain.Interfaces.Repository;
using GerenciarEscolaTeste.Domain.Interfaces.Services;
using GerenciarEscolaTeste.Domain.Services.Base;

namespace GerenciarEscolaTeste.Domain.Services
{
    public class TipoPessoaService : BaseService<TipoPessoa>, ITipoPessoaService
    {
        private readonly ITipoPessoaRepository _tipoPessoaRepository;

        public TipoPessoaService(ITipoPessoaRepository tipoPessoaRepository)
            : base(tipoPessoaRepository)
        {
            _tipoPessoaRepository = tipoPessoaRepository;
        }
    }
}
