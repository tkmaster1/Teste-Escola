using GerenciarEscolaTeste.Application.Interfaces;
using GerenciarEscolaTeste.Application.ViewModels;
using System;
using System.Linq;
using System.Web.Mvc;

namespace GerenciarEscolaTeste.MVC.Controllers
{
    public class PessoaController : BaseController
    {
        private readonly IPessoaApplicationService _pessoaApplicationService;
        private readonly ITipoPessoaApplicationService _tipoPessoaApplicationService;


        public PessoaController(IPessoaApplicationService pessoaApplicationService,
                                ITipoPessoaApplicationService tipoPessoaApplicationService)
        {
            _pessoaApplicationService = pessoaApplicationService;
            _tipoPessoaApplicationService = tipoPessoaApplicationService;
        }

        // GET: Pessoa
        public ActionResult Index(int? viewModel)
        {
            try
            {
                var pesquisarViewModel = _pessoaApplicationService.GetAll();
                return View(pesquisarViewModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET: Pessoa/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                var pessoaViewModel = _pessoaApplicationService.GetById(id);
                return View(pessoaViewModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET: Pessoa/Create
        public ActionResult Create()
        {
            var pesquisarPessoaVm = new PessoaViewModel
            {
                TipoPessoaSelectList = new SelectList(_tipoPessoaApplicationService.GetAll().OrderBy(x => x.Descricao),
                "TipoPessoaId", "Descricao")
            };
            return View(pesquisarPessoaVm);
        }

        // POST: Pessoa/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PessoaViewModel pessoa)
        {
            if (ModelState.IsValid)
            {
                _pessoaApplicationService.InserirPessoa(pessoa);
                return RedirectToAction("Index");
            }

            return View(pessoa);
        }

        // GET: Pessoa/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                var pessoaViewModel = _pessoaApplicationService.GetById(id);
                return View(pessoaViewModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // POST: Pessoa/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PessoaViewModel pessoa)
        {
            if (ModelState.IsValid)
            {
                _pessoaApplicationService.AlterarPessoa(pessoa);
                return RedirectToAction("Index");
            }

            return View(pessoa);
        }

        // GET: Pessoa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pessoa/Delete/5
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
