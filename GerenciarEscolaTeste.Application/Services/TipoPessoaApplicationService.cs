using AutoMapper;
using GerenciarEscolaTeste.Application.Interfaces;
using GerenciarEscolaTeste.Application.ViewModels;
using GerenciarEscolaTeste.Domain.Entities;
using GerenciarEscolaTeste.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace GerenciarEscolaTeste.Application.Services
{
    public class TipoPessoaApplicationService : ITipoPessoaApplicationService
    {
        private readonly ITipoPessoaService _tipoPessoaService;

        public TipoPessoaApplicationService(ITipoPessoaService tipoPessoaService)
        {
            _tipoPessoaService = tipoPessoaService;
        }

        public TipoPessoaViewModel GetById(int id)
        {
            try
            {
                var TipoPessoa = _tipoPessoaService.GetById(id);
                return Mapper.Map<TipoPessoa, TipoPessoaViewModel>(TipoPessoa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TipoPessoaViewModel> GetAll()
        {
            try
            {
                return Mapper.Map<List<TipoPessoaViewModel>>(_tipoPessoaService.GetAll());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InserirTipoPessoa(TipoPessoaViewModel obj)
        {
            try
            {
                var tipoPessoaObj = Mapper.Map<TipoPessoa>(obj);
                _tipoPessoaService.Add(tipoPessoaObj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarTipoPessoa(TipoPessoaViewModel obj)
        {
            try
            {
                var tipoPessoaObj = Mapper.Map<TipoPessoa>(obj);
                _tipoPessoaService.Update(tipoPessoaObj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirTipoPessoa(int id)
        {
            try
            {
                var tipoPessoaObj = _tipoPessoaService.GetById(id);
                var result = Mapper.Map<TipoPessoa>(tipoPessoaObj);
                _tipoPessoaService.Remove(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            _tipoPessoaService.Dispose();
        }

        public IEnumerable<TipoPessoaViewModel> PesquisarTipoPessoa(TipoPessoaViewModel objTipoPessoa)
        {
            throw new System.NotImplementedException();
        }
    }
}
