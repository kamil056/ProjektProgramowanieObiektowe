using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjektSklep.Models;

namespace ProjektSklep.ViewModels
{

    public class HomeViewModel
    {
        public IEnumerable<Kategoria> Kategorie { get; set; }
        public IEnumerable<Produkt> Nowosc { get; set; }
        public IEnumerable<Produkt> BestSeller { get; set; }

    }
}