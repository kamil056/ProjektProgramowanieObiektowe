using System;
using System.ComponentModel.DataAnnotations;

namespace ProjektSklep.Models
{
    public class Produkt
    {
        public int ProduktId { get; set; }
        public int KategoriaId { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwe produktu")]
        [StringLength(100)]
        public string NazwaProduktu { get; set; }
        public DateTime DataDodania { get; set; }
        public string NazwaPlikuObrazka { get; set; }
        public string OpisProduktu { get; set; }
        public decimal CenaProduktu { get; set; }
        public bool Bestseller { get; set; }
        public bool Ukryty { get; set; }

        public virtual Kategoria Kategoria { get; set; }


    }
}