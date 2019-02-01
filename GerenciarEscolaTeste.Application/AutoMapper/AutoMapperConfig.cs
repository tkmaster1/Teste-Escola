using AutoMapper;
using GerenciarEscolaTeste.Application.AutoMapper.CustomProfiles.DomainToViewModelProfile;
using GerenciarEscolaTeste.Application.AutoMapper.CustomProfiles.ViewModelToDomainProfile;

namespace GerenciarEscolaTeste.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                #region DOMAIN TO VIEWMODEL

                #region CONFIGURAÇÃO SIMPLES

                x.AddProfile<MappingProfile>();

                #endregion

                x.AddProfile<TipoPessoaToTipoPessoaVmProfileConfig>();
                x.AddProfile<PessoaToPessoaVmProfileConfig>();
                x.AddProfile<ContatoToContatoVmProfileConfig>();
                x.AddProfile<TurmaToTurmaVmProfileConfig>();

                #endregion

                #region VIEWMODEL TO DOMAIN

                x.AddProfile<TipoPessoaVmToTipoPessoaProfileConfig>();
                x.AddProfile<PessoaVmToPessoaProfileConfig>();
                x.AddProfile<ContatoVmToContatoProfileConfig>();
                x.AddProfile<TurmaVmToTurmaProfileConfig>();

                #endregion
            });
        }
    }
}
