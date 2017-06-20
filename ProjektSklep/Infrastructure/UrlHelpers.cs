using System.IO;
using System.Web.Mvc;

namespace ProjektSklep.Infrastructure
{
    public  static class UrlHelpers
    {
//        public static string IkonyKategoriiSciezka(this UrlHelper helper, string nazwaIkonyKategorii)
//        {
//            var IIkonyKategoriiFolder = AppConfig.obrazkiKategorii;
//            var Sciezka = Path.Combine(IIkonyKategoriiFolder, nazwaIkonyKategorii);
//            var sciezkaBezwgledna = helper.Content(Sciezka);
//
//            return sciezkaBezwgledna;
//        }

        public static string IkonyProduktowSciezka(this UrlHelper helper, string nazwaObrazka)
        {
            var ObrazkiFolder = AppConfig.obrazkiProdukty;
            var Sciezka = Path.Combine(ObrazkiFolder, nazwaObrazka);
            var sciezkaBezwgledna = helper.Content(Sciezka);

            return sciezkaBezwgledna;
        }
    }
}