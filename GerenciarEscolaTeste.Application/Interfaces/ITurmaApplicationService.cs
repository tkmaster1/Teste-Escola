using GerenciarEscolaTeste.Application.ViewModels;
using System;
using System.Collections.Generic;

namespace GerenciarEscolaTeste.Application.Interfaces
{
    public interface ITurmaApplicationService : IDisposable
    {
        TurmaViewModel GetById(int id);
        IEnumerable<TurmaViewModel> GetAll();
        List<PessoaViewModel> GetPessoaPorTipoPessoa(int TipoPessoaId);
        IEnumerable<TurmaViewModel> PesquisarTurma(TurmaViewModel objTurma);
        void InserirTurma(TurmaViewModel obj);
        void AlterarTurma(TurmaViewModel obj);
        void ExcluirTurma(int id);
    }
}
