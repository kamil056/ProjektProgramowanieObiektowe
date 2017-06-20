using System.Web.Mvc;

namespace ProjektSklep.Controllers
{
    public class KoszykController : Controller
    {
        public ActionResult DodajDoKoszyka(int produktId)
        {
            return View();
        }
    }
}