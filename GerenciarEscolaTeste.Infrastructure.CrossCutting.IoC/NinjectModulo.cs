using GerenciarEscolaTeste.Application.Interfaces;
using GerenciarEscolaTeste.Application.Services;
using GerenciarEscolaTeste.Domain.Interfaces.Repository;
using GerenciarEscolaTeste.Domain.Interfaces.Services;
using GerenciarEscolaTeste.Domain.Interfaces.Services.Base;
using GerenciarEscolaTeste.Domain.Services;
using GerenciarEscolaTeste.Domain.Services.Base;
using GerenciarEscolaTeste.Infrastructure.Data.Context;
using GerenciarEscolaTeste.Infrastructure.Data.Interfaces;
using GerenciarEscolaTeste.Infrastructure.Data.Repositories;
using GerenciarEscolaTeste.Infrastructure.Data.Repositories.Base;
using Ninject.Modules;

namespace GerenciarEscolaTeste.Infrastructure.CrossCutting.IoC
{
    public class NinjectModulo : NinjectModule
    {
        public override void Load()
        {
            #region Application

            Bind<ITipoPessoaApplicationService>().To<TipoPessoaApplicationService>();
            Bind<IPessoaApplicationService>().To<PessoaApplicationService>();
            Bind<IContatoApplicationService>().To<ContatoApplicationService>();
            Bind<ITurmaApplicationService>().To<TurmaApplicationService>();

            #endregion

            #region Domain Service

            Bind(typeof(IBaseService<>)).To(typeof(BaseService<>));
            Bind<ITipoPessoaService>().To<TipoPessoaService>();
            Bind<IPessoaService>().To<PessoaService>();
            Bind<IContatoService>().To<ContatoService>();
            Bind<ITurmaService>().To<TurmaService>();

            #endregion

            #region Repository

            Bind(typeof(BaseRepository<>)).To(typeof(BaseRepository<>));
            Bind<IContextManager>().To<ContextManager>();
            Bind<ITipoPessoaRepository>().To<TipoPessoaRepository>();
            Bind<IPessoaRepository>().To<PessoaRepository>();
            Bind<IContatoRepository>().To<ContatoRepository>();
            Bind<ITurmaRepository>().To<TurmaRepository>();

            #endregion
        }
    }
}
