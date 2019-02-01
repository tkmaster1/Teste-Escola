using GerenciarEscolaTeste.Application.ViewModels;
using System;
using System.Collections.Generic;

namespace GerenciarEscolaTeste.Application.Interfaces
{
    public interface ITipoPessoaApplicationService : IDisposable
    {
        TipoPessoaViewModel GetById(int id);
        IEnumerable<TipoPessoaViewModel> GetAll();
        IEnumerable<TipoPessoaViewModel> PesquisarTipoPessoa(TipoPessoaViewModel objTipoPessoa);
        void InserirTipoPessoa(TipoPessoaViewModel obj);
        void AlterarTipoPessoa(TipoPessoaViewModel obj);
        void ExcluirTipoPessoa(int id);
    }
}
