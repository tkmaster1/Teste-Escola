using AutoMapper;
using GerenciarEscolaTeste.Application.ViewModels;
using GerenciarEscolaTeste.Domain.Entities;

namespace GerenciarEscolaTeste.Application.AutoMapper.CustomProfiles.DomainToViewModelProfile
{
    public class TipoPessoaToTipoPessoaVmProfileConfig : Profile
    {
        public TipoPessoaToTipoPessoaVmProfileConfig()
        {
            CreateMap<TipoPessoaViewModel, TipoPessoa>()
                    .ForMember(src => src.TipoPessoaId, opt => opt.MapFrom(x => x.TipoPessoaId))
                    .ForMember(src => src.Descricao, opt => opt.MapFrom(x => x.Descricao))
                    .ForMember(src => src.DataInclusao, opt => opt.MapFrom(x => x.DataInclusao))
                    .ForMember(src => src.DataAlteracao, opt => opt.MapFrom(x => x.DataAlteracao))
                    .ForMember(src => src.DataExclusao, opt => opt.MapFrom(x => x.DataExclusao));
        }
    }
}
