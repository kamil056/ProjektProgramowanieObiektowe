using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjektSklep.Models
{
    public class Zamowienie
    {
        public int ZamowienieId { get; set; }
        [Required(ErrorMessage = "Wprowadz imie")]
        [StringLength(50)]
        public string Imie { get; set; }
        [Required(ErrorMessage = "Wprowadz Nazwisko")]
        [StringLength(50)]
        public string Nazwisko { get; set; }
        [Required(ErrorMessage = "Wprowadz Ulice")]
        [StringLength(50)]
        public string Ulica { get; set; }
        [Required(ErrorMessage = "Wprowadz Miasto")]
        [StringLength(50)]
        public string Miasto { get; set; }
        public string KodPocztowy { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Komentarz { get; set; }
        public DateTime DataZamowienia { get; set; }
        public StanZamowienia StanZamowienia { get; set; }
        public decimal WartoscZamowienia { get; set; }

        private List<PozycjaZamowienia> PozycjeZamowienia { get; set; }
    }

    public enum StanZamowienia
    {
        Nowe,
        Zrealizowane
    }
}