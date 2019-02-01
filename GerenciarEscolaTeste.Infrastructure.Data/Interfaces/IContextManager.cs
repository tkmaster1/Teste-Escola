using System.Data.Entity;

namespace GerenciarEscolaTeste.Infrastructure.Data.Interfaces
{
    public interface IContextManager
    {
        DbContext GetContext();
    }
}
