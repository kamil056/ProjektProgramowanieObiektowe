using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjektSklep.Controllers;
using ProjektSklep.Models;
using ProjektSklep.ViewModels;

namespace ProjektSklep.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var kategoria1 = new Kategoria()
            {
                KategoriaId = 1,
                NazwaKategorii = "kategoria testowa",
                NazwaPlikuObrazka = "plik.png"
            };
            var produkt1 = new Produkt()
            {
                NazwaProduktu = "produkt testowy",
                CenaProduktu = 33.33m,
                Bestseller = true,
                Kategoria = kategoria1
            };

          Assert.AreEqual("produkt testowy", produkt1.NazwaProduktu);
          Assert.AreEqual(33.33m, produkt1.CenaProduktu);
          Assert.IsTrue(produkt1.Bestseller);  

          Assert.IsFalse(kategoria1.NazwaPlikuObrazka == null);
          StringAssert.Contains("kategoria testowa", kategoria1.NazwaKategorii);


        }
       
    }
}
