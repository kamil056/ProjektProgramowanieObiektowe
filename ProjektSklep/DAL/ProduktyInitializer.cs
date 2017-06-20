using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using ProjektSklep.Migrations;
using ProjektSklep.Models;

namespace ProjektSklep.DAL
{
    public class ProduktyInitializer :  MigrateDatabaseToLatestVersion<ProduktyContext, Configuration>
    {
        //        protected override void Seed(ProduktyContext context)
        //        {
      //  DropCreateDatabaseAlways<ProduktyContext>
        //            SeedProduktyData(context);
        //            base.Seed(context);
        //        }


        public static void SeedProduktyData(ProduktyContext context) //metoda wywolywana w Migration/Configuration
        {
            var kategorie = new List<Kategoria>
            {
                new Kategoria(){KategoriaId = 1, NazwaKategorii = "AMINOKWASY", OpisKategorii = "BCAA, Glutamina i inne", NazwaPlikuObrazka = "aminokwasy.png"},
                new Kategoria(){KategoriaId = 2, NazwaKategorii = "ODŻYWKI BIAŁKOWE", OpisKategorii = "WPC, WPI i inne", NazwaPlikuObrazka = "bialka.png"},
                new Kategoria(){KategoriaId = 3, NazwaKategorii = "KREATYNY", OpisKategorii = "Monohydrat, Jabłczan i inne", NazwaPlikuObrazka = "kreatyny.png"},
                new Kategoria(){KategoriaId = 4, NazwaKategorii = "GAINERY", OpisKategorii = "Odżywki na mase", NazwaPlikuObrazka = "gainery.png"},
                new Kategoria(){KategoriaId = 5, NazwaKategorii = "WITAMINY", OpisKategorii = "Multiwitaminy, omega 3 i inne", NazwaPlikuObrazka = "witaminkiy.png"},
            };
            kategorie.ForEach(k => context.Kategorie.AddOrUpdate(k));
            context.SaveChanges();
            var produkty = new List<Produkt>()
            {
                new Produkt(){ NazwaProduktu = "BCAA MAX SUPPORT", KategoriaId = 1, CenaProduktu = 49.99m, OpisProduktu = "jakis opis", NazwaPlikuObrazka = "bcaamaxsupport.png", Bestseller = true, DataDodania = DateTime.Now, Ukryty = false},
                new Produkt(){ NazwaProduktu = "BCAA XPLODE", KategoriaId = 1, CenaProduktu = 153.99m, OpisProduktu = "jakis opis2", NazwaPlikuObrazka = "BCAAXPLODE.png", Bestseller = true, DataDodania = DateTime.Now, Ukryty = false},
                new Produkt(){ NazwaProduktu = "BCAA POWDER", KategoriaId = 1, CenaProduktu = 54.99m, OpisProduktu = "jakis opis3", NazwaPlikuObrazka = "BCAA_Powder.png", Bestseller = true, DataDodania = DateTime.Now, Ukryty = false},
                new Produkt(){ NazwaProduktu = "GOLD STANDARD GAINER", KategoriaId = 4, CenaProduktu = 199.99m, OpisProduktu = "jakis opis13", NazwaPlikuObrazka = "Gold_Standard_Gainer.png", Bestseller = true, DataDodania = DateTime.Now, Ukryty = false},
                new Produkt(){ NazwaProduktu = "MUTANT MASS", KategoriaId = 4, CenaProduktu = 189.99m, OpisProduktu = "jakis opis23", NazwaPlikuObrazka = "MUTANTMASS.png", Bestseller = true, DataDodania = DateTime.Now, Ukryty = false},
                
             };
            produkty.ForEach(p => context.Produkty.AddOrUpdate(p));
            context.SaveChanges();
            
        }
    }
}