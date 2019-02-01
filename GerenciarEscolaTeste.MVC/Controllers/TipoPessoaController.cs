using GerenciarEscolaTeste.Application.Interfaces;
using GerenciarEscolaTeste.Application.ViewModels;
using System;
using System.Web.Mvc;

namespace GerenciarEscolaTeste.MVC.Controllers
{
    public class TipoPessoaController : BaseController
    {
        private readonly ITipoPessoaApplicationService _tipoPessoaApplicationService;

        public TipoPessoaController(ITipoPessoaApplicationService tipoPessoaApplicationService)
        {
            _tipoPessoaApplicationService = tipoPessoaApplicationService;
        }

        // GET: TipoPessoa
        public ActionResult Index(int? viewModel)
        {
            try
            {
                var pesquisarViewModel = _tipoPessoaApplicationService.GetAll();
                return View(pesquisarViewModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET: TipoPessoa/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                var tipoPessoaViewModel = _tipoPessoaApplicationService.GetById(id);
                return View(tipoPessoaViewModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET: TipoPessoa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoPessoa/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TipoPessoaViewModel tipoPessoa)
        {
            if (ModelState.IsValid)
            {
                _tipoPessoaApplicationService.InserirTipoPessoa(tipoPessoa);
                return RedirectToAction("Index");
            }

            return View(tipoPessoa);
        }

        // GET: TipoPessoa/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                var tipoPessoaViewModel = _tipoPessoaApplicationService.GetById(id);
                return View(tipoPessoaViewModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // POST: TipoPessoa/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TipoPessoaViewModel tipoPessoa)
        {
            if (ModelState.IsValid)
            {
                _tipoPessoaApplicationService.AlterarTipoPessoa(tipoPessoa);
                return RedirectToAction("Index");
            }

            return View(tipoPessoa);
        }

        // GET: TipoPessoa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TipoPessoa/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
