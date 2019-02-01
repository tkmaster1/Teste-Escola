using AutoMapper;
using GerenciarEscolaTeste.Application.Interfaces;
using GerenciarEscolaTeste.Application.ViewModels;
using GerenciarEscolaTeste.Domain.Entities;
using GerenciarEscolaTeste.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace GerenciarEscolaTeste.Application.Services
{
    public class TurmaApplicationService : ITurmaApplicationService
    {
        private readonly ITurmaService _turmaService;

        public TurmaApplicationService(ITurmaService turmaService)
        {
            _turmaService = turmaService;
        }

        public TurmaViewModel GetById(int id)
        {
            try
            {
                var pessoa = _turmaService.GetById(id);
                return Mapper.Map<Turma, TurmaViewModel>(pessoa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TurmaViewModel> GetAll()
        {
            try
            {
                return Mapper.Map<List<TurmaViewModel>>(_turmaService.GetAll());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<PessoaViewModel> GetPessoaPorTipoPessoa(int TipoPessoaId)
        {
            try
            {
                var listaPessoa = _turmaService.GetPessoaPorTipoPessoa(TipoPessoaId);                
                return Mapper.Map<IEnumerable<Pessoa>, List<PessoaViewModel>>(listaPessoa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InserirTurma(TurmaViewModel obj)
        {
            try
            {
                var texto = string.Empty;
                //var pessoaObj = Mapper.Map<Pessoa>(obj);
                //pessoaObj.TipoPessoa = null;
                //pessoaObj.CPF = string.Empty;
                //pessoaObj.CPF = texto.Replace(".", "").Replace("-", "");
                //_pessoaService.Add(pessoaObj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarTurma(TurmaViewModel obj)
        {
            try
            {
                var texto = string.Empty;
                //var pessoaObj = Mapper.Map<Pessoa>(obj);
                //pessoaObj.TipoPessoa = null;
                //pessoaObj.CPF = string.Empty;
                //pessoaObj.CPF = texto.Replace(".", "").Replace("-", "");
                //_pessoaService.Update(pessoaObj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirTurma(int id)
        {
            try
            {
                var turmaObj = _turmaService.GetById(id);
                var result = Mapper.Map<Turma>(turmaObj);
                _turmaService.Remove(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            _turmaService.Dispose();
        }

        public IEnumerable<TurmaViewModel> PesquisarTurma(TurmaViewModel objTurma)
        {
            throw new System.NotImplementedException();
        }
    }
}
