using System.Web.Mvc;

namespace treinamentoProgram.Web.Controllers
{
    public class HomeController : treinamentoProgramControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}