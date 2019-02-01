using GerenciarEscolaTeste.Domain.Entities;
using GerenciarEscolaTeste.Domain.Interfaces.Repository;
using GerenciarEscolaTeste.Domain.Interfaces.Services;
using GerenciarEscolaTeste.Domain.Services.Base;

namespace GerenciarEscolaTeste.Domain.Services
{
    public class ContatoService : BaseService<Contato>, IContatoService
    {
        private readonly IContatoRepository _contatoRepository;

        public ContatoService(IContatoRepository contatoRepository)
            : base(contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }
    }
}
