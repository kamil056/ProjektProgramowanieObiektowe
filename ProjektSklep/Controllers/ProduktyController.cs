using System.Linq;
using System.Web.Mvc;
using ProjektSklep.DAL;

namespace ProjektSklep.Controllers
{
   public class ProduktyController : Controller
    {
        private ProduktyContext db = new ProduktyContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Lista(string nazwakategori)
        {
            var kategoria = db.Kategorie.Include("Produkty")
                            .Where(k => k.NazwaKategorii.ToUpper() == nazwakategori.ToUpper()).Single();
            var produkty = kategoria.Produkty.ToList();

            return View(produkty);
        }

        public ActionResult Szczegoly(int produktId)
        {
            return View();
        }
        public ActionResult KategorieMenu()
        {
            var kategorie = db.Kategorie.ToList();

            return PartialView("_KategorieMenu", kategorie);
        }
    }
}