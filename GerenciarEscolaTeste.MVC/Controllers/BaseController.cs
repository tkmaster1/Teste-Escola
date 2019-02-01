using GerenciarEscolaTeste.Application.Validation;
using System.Text;
using System.Web.Mvc;

namespace GerenciarEscolaTeste.MVC.Controllers
{
    public class BaseController : Controller
    {
        public ActionResult CreateResponse(ValidationApplicationResult result, object viewModelOnFail, string viewToRedirectOnSuccess, object viewModelOnSuccess = null)
        {
            if (!result.IsValid)
            {
                return ReturnViewOnFail(result, viewModelOnFail);
            }

            return ReturnViewOnSuccess(viewToRedirectOnSuccess, viewModelOnSuccess);
        }

        private ActionResult ReturnViewOnFail(ValidationApplicationResult result, object viewModelOnFail)
        {
            foreach (var erro in result.Erros)
            {
                ModelState.AddModelError(string.Empty, erro);
            }
            return View(viewModelOnFail);
        }

        private ActionResult ReturnViewOnSuccess(string viewToRedirectOnSuccess, object viewModelOnSuccess)
        {
            if (viewModelOnSuccess == null)
            {
                return RedirectToAction(viewToRedirectOnSuccess);
            }
            else
            {
                return RedirectToAction(viewToRedirectOnSuccess, new { viewModel = viewModelOnSuccess });
            }
        }

        public JsonResult CreateJsonResponse(ValidationApplicationResult result)
        {
            StringBuilder errosStringBuilder = new StringBuilder();

            if (!result.IsValid)
            {
                foreach (var erro in result.Erros)
                {
                    errosStringBuilder.Append("<ul>").Append("<li>" + erro + "</li>").Append("</ul>");
                }
            }

            return Json(new { result.IsValid, Erro = errosStringBuilder.ToString() }, JsonRequestBehavior.AllowGet);
        }
    }
}