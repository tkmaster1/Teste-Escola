using GerenciarEscolaTeste.Domain.Entities;
using GerenciarEscolaTeste.Domain.Interfaces.Repository;
using GerenciarEscolaTeste.Infrastructure.Data.Repositories.Base;

namespace GerenciarEscolaTeste.Infrastructure.Data.Repositories
{
    public class ContatoRepository : BaseRepository<Contato>, IContatoRepository
    {
    }
}
