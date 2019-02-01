using AutoMapper;
using GerenciarEscolaTeste.Application.Interfaces;
using GerenciarEscolaTeste.Application.ViewModels;
using GerenciarEscolaTeste.Domain.Entities;
using GerenciarEscolaTeste.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace GerenciarEscolaTeste.Application.Services
{
    public class ContatoApplicationService : IContatoApplicationService
    {
        private readonly IContatoService _contatoService;

        public ContatoApplicationService(IContatoService contatoService)
        {
            _contatoService = contatoService;
        }

        public ContatoViewModel GetById(int id)
        {
            try
            {
                var pessoa = _contatoService.GetById(id);
                return Mapper.Map<Contato, ContatoViewModel>(pessoa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<ContatoViewModel> GetAll()
        {
            try
            {
                return Mapper.Map<List<ContatoViewModel>>(_contatoService.GetAll());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InserirContato(ContatoViewModel obj)
        {
            try
            {
                var contatoObj = Mapper.Map<Contato>(obj);
                _contatoService.Add(contatoObj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarContato(ContatoViewModel obj)
        {
            try
            {
                var contatoObj = Mapper.Map<Contato>(obj);
                _contatoService.Update(contatoObj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirContato(int id)
        {
            try
            {
                var contatoObj = _contatoService.GetById(id);
                var result = Mapper.Map<Contato>(contatoObj);
                _contatoService.Remove(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            _contatoService.Dispose();
        }

        public IEnumerable<ContatoViewModel> PesquisarContato(ContatoViewModel objContato)
        {
            throw new System.NotImplementedException();
        }
    }
}
