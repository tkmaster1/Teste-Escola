using GerenciarEscolaTeste.Application.Interfaces;
using GerenciarEscolaTeste.Application.ViewModels;
using System;
using System.Linq;
using System.Web.Mvc;

namespace GerenciarEscolaTeste.MVC.Controllers
{
    public class TurmaController : BaseController
    {
        private readonly IPessoaApplicationService _pessoaApplicationService;
        private readonly ITipoPessoaApplicationService _tipoPessoaApplicationService;
        private readonly ITurmaApplicationService _turmaApplicationService;


        public TurmaController(IPessoaApplicationService pessoaApplicationService,
                                ITipoPessoaApplicationService tipoPessoaApplicationService,
                                ITurmaApplicationService turmaApplicationService)
        {
            _pessoaApplicationService = pessoaApplicationService;
            _tipoPessoaApplicationService = tipoPessoaApplicationService;
            _turmaApplicationService = turmaApplicationService;
        }

        // GET: Turma
        public ActionResult Index(int? viewModel)
        {
            try
            {

                //var pesquisarViewModel = new TurmaViewModel
                //{
                //    PessoaSelectList = new SelectList(_turmaApplicationService.GetPessoaPorTipoPessoa(1).OrderBy(x => x.NomePessoa),
                //"PessoaId", "NomePessoa")
                //};

                 var pesquisarViewModel = _turmaApplicationService.GetAll();
                return View(pesquisarViewModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET: Turma/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Turma/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Turma/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Turma/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Turma/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Turma/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Turma/Delete/5
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
