using AutoMapper;
using GerenciarEscolaTeste.Application.ViewModels;
using GerenciarEscolaTeste.Domain.Entities;

namespace GerenciarEscolaTeste.Application.AutoMapper.CustomProfiles.DomainToViewModelProfile
{
    public class TurmaToTurmaVmProfileConfig : Profile
    {
        public TurmaToTurmaVmProfileConfig()
        {
            CreateMap<TurmaViewModel, Turma>()
                .ForMember(src => src.TurmaId, opt => opt.MapFrom(x => x.TurmaId))
                .ForMember(src => src.NumTurma, opt => opt.MapFrom(x => x.NumTurma))
                .ForMember(src => src.Periodo, opt => opt.MapFrom(x => x.Periodo))
                .ForMember(src => src.DataTurma, opt => opt.MapFrom(x => x.DataTurma))
                .ForMember(src => src.DataInclusao, opt => opt.MapFrom(x => x.DataInclusao))
                .ForMember(src => src.DataAlteracao, opt => opt.MapFrom(x => x.DataAlteracao))
                .ForMember(src => src.PessoaId, opt => opt.MapFrom(x => x.PessoaId));
        }
    }
}
