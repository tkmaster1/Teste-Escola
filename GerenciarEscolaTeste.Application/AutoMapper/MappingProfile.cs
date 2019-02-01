using AutoMapper;
using GerenciarEscolaTeste.Application.ViewModels;
using GerenciarEscolaTeste.Domain.Entities;

namespace GerenciarEscolaTeste.Application.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //* DOMAIN TO VIEWMODEL *//
            CreateMap<TipoPessoa, TipoPessoaViewModel>();
            CreateMap<Pessoa, PessoaViewModel>();
            CreateMap<Contato, ContatoViewModel>();
            CreateMap<Turma, TurmaViewModel>();

            //* VIEWMODEL TO DOMAIN *//
            CreateMap<TipoPessoaViewModel, TipoPessoa>();
            CreateMap<PessoaViewModel, Pessoa>();
            CreateMap<ContatoViewModel, Contato>();
            CreateMap<TurmaViewModel, Turma>();
        }
    }
}
