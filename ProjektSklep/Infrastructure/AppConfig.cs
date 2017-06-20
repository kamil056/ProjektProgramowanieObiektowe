using System.Configuration;

namespace ProjektSklep.Infrastructure
{
    public class AppConfig
    {
     //   private static string _obrazkiKategorii = ConfigurationManager.AppSettings["IkonyKategorii"]; //Content/Kategorie
        private static string _obrazkiProdukty = ConfigurationManager.AppSettings["IkonyProdukty"]; //Content/Produkty


      //  public static string obrazkiKategorii=> _obrazkiKategorii;
       
        public static string obrazkiProdukty => _obrazkiProdukty;
    }
}