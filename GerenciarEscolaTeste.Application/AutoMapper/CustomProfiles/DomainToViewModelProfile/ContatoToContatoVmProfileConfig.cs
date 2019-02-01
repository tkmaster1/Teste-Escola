using AutoMapper;
using GerenciarEscolaTeste.Application.ViewModels;
using GerenciarEscolaTeste.Domain.Entities;

namespace GerenciarEscolaTeste.Application.AutoMapper.CustomProfiles.DomainToViewModelProfile
{
    public class ContatoToContatoVmProfileConfig : Profile
    {
        public ContatoToContatoVmProfileConfig()
        {
            CreateMap<ContatoViewModel, Contato>()
                .ForMember(src => src.ContatoId, opt => opt.MapFrom(x => x.ContatoId))
                .ForMember(src => src.Ddi, opt => opt.MapFrom(x => x.Ddi))
                .ForMember(src => src.Ddd, opt => opt.MapFrom(x => x.Ddd))
                .ForMember(src => src.Email, opt => opt.MapFrom(x => x.Email))
                .ForMember(src => src.TelFixo, opt => opt.MapFrom(x => x.TelFixo))
                .ForMember(src => src.TelCelular, opt => opt.MapFrom(x => x.TelCelular))
                .ForMember(src => src.DataInclusao, opt => opt.MapFrom(x => x.DataInclusao))
                .ForMember(src => src.DataAlteracao, opt => opt.MapFrom(x => x.DataAlteracao))
                .ForMember(src => src.DataExclusao, opt => opt.MapFrom(x => x.DataExclusao));
        }
    }
}
