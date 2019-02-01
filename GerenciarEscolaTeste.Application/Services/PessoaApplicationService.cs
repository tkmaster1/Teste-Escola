using AutoMapper;
using GerenciarEscolaTeste.Application.Interfaces;
using GerenciarEscolaTeste.Application.ViewModels;
using GerenciarEscolaTeste.Domain.Entities;
using GerenciarEscolaTeste.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace GerenciarEscolaTeste.Application.Services
{
    public class PessoaApplicationService : IPessoaApplicationService
    {
        private readonly IPessoaService _pessoaService;

        public PessoaApplicationService(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        public PessoaViewModel GetById(int id)
        {
            try
            {
                var pessoa = _pessoaService.GetById(id);
                return Mapper.Map<Pessoa, PessoaViewModel>(pessoa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<PessoaViewModel> GetAll()
        {
            try
            {
                return Mapper.Map<List<PessoaViewModel>>(_pessoaService.GetAll());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InserirPessoa(PessoaViewModel obj)
        {
            try
            {
                var texto = obj.CPF;
                var pessoaObj = Mapper.Map<Pessoa>(obj);
                pessoaObj.TipoPessoa = null;
                pessoaObj.CPF = string.Empty;
                pessoaObj.CPF = texto.Replace(".", "").Replace("-", "");
                _pessoaService.Add(pessoaObj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarPessoa(PessoaViewModel obj)
        {
            try
            {
                var texto = obj.CPF;
                var pessoaObj = Mapper.Map<Pessoa>(obj);
                pessoaObj.TipoPessoa = null;
                pessoaObj.CPF = string.Empty;
                pessoaObj.CPF = texto.Replace(".", "").Replace("-", "");
                _pessoaService.Update(pessoaObj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirPessoa(int id)
        {
            try
            {
                var tipoPessoaObj = _pessoaService.GetById(id);
                var result = Mapper.Map<Pessoa>(tipoPessoaObj);
                _pessoaService.Remove(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            _pessoaService.Dispose();
        }

        public IEnumerable<PessoaViewModel> PesquisarPessoa(PessoaViewModel objPessoa)
        {
            throw new System.NotImplementedException();
        }
    }
}
