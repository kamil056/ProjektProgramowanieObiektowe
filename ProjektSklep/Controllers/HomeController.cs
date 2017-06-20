using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjektSklep.DAL;
using ProjektSklep.Models;
using ProjektSklep.ViewModels;

namespace ProjektSklep.Controllers
{
    public class HomeController : Controller
    {
        private ProduktyContext db = new ProduktyContext();
        // GET: Home
        public ActionResult Index()
        {
               var Kategorie = db.Kategorie.ToList();
              //  var cos = db.Produkty.ToList();
            
               var Nowosci = db.Produkty.Where(p => !p.Ukryty).OrderByDescending(p => p.DataDodania).Take(2).ToList();

                var Bestseller = db.Produkty.Where(p => !p.Ukryty && p.Bestseller).OrderBy(p => Guid.NewGuid()).Take(2).ToList(); //guid - unikalny identyfikator, za kazdym razem inny, stad losowosc
           
            
                var hvm = new HomeViewModel()
            {
                Kategorie = Kategorie,
                Nowosc = Nowosci,
                BestSeller = Bestseller
            };
            
            return View(hvm);
        }

        public ActionResult StaticPage(string page)
        {
            return View(page);
        }
    }
}