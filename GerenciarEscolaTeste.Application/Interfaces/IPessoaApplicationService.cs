using GerenciarEscolaTeste.Application.ViewModels;
using System;
using System.Collections.Generic;

namespace GerenciarEscolaTeste.Application.Interfaces
{
    public interface IPessoaApplicationService : IDisposable
    {
        PessoaViewModel GetById(int id);
        IEnumerable<PessoaViewModel> GetAll();
        IEnumerable<PessoaViewModel> PesquisarPessoa(PessoaViewModel objTipoPessoa);
        void InserirPessoa(PessoaViewModel obj);
        void AlterarPessoa(PessoaViewModel obj);
        void ExcluirPessoa(int id);
    }
}
