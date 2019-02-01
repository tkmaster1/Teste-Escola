using GerenciarEscolaTeste.Domain.Entities;
using GerenciarEscolaTeste.Domain.Interfaces.Repository;
using GerenciarEscolaTeste.Domain.Interfaces.Services;
using GerenciarEscolaTeste.Domain.Services.Base;

namespace GerenciarEscolaTeste.Domain.Services
{
    public class PessoaService : BaseService<Pessoa>, IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository)
            : base(pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }
    }
}
