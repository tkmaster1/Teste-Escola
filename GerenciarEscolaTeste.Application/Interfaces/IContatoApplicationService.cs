using GerenciarEscolaTeste.Application.ViewModels;
using System;
using System.Collections.Generic;

namespace GerenciarEscolaTeste.Application.Interfaces
{
    public interface IContatoApplicationService : IDisposable
    {
        ContatoViewModel GetById(int id);
        IEnumerable<ContatoViewModel> GetAll();
        IEnumerable<ContatoViewModel> PesquisarContato(ContatoViewModel objContato);
        void InserirContato(ContatoViewModel obj);
        void AlterarContato(ContatoViewModel obj);
        void ExcluirContato(int id);
    }
}
