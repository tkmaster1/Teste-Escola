using AutoMapper;
using GerenciarEscolaTeste.Application.ViewModels;
using GerenciarEscolaTeste.Domain.Entities;

namespace GerenciarEscolaTeste.Application.AutoMapper.CustomProfiles.ViewModelToDomainProfile
{
    public class PessoaVmToPessoaProfileConfig : Profile
    {
        public PessoaVmToPessoaProfileConfig()
        {
            CreateMap<Pessoa, PessoaViewModel>()
                .ForMember(src => src.PessoaId, opt => opt.MapFrom(x => x.PessoaId))
                .ForMember(src => src.NomePessoa, opt => opt.MapFrom(x => x.NomePessoa))
                .ForMember(src => src.CPF, opt => opt.MapFrom(x => x.CPF))
                .ForMember(src => src.DataNascimento, opt => opt.MapFrom(x => x.DataNascimento))
                .ForMember(src => src.DataInclusao, opt => opt.MapFrom(x => x.DataInclusao))
                .ForMember(src => src.DataAlteracao, opt => opt.MapFrom(x => x.DataAlteracao))
                .ForMember(src => src.DataExclusao, opt => opt.MapFrom(x => x.DataExclusao));
        }
    }
}
