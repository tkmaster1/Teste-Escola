using GerenciarEscolaTeste.Domain.Entities;
using GerenciarEscolaTeste.Domain.Interfaces.Repository;
using GerenciarEscolaTeste.Infrastructure.Data.Repositories.Base;

namespace GerenciarEscolaTeste.Infrastructure.Data.Repositories
{
    public class TipoPessoaRepository : BaseRepository<TipoPessoa>, ITipoPessoaRepository
    {
    }
}
