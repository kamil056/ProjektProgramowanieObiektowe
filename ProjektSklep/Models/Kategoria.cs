using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjektSklep.Models
{
    public class Kategoria
    {
        public int KategoriaId { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwe produktu")]
        [StringLength(100)]
        public string NazwaKategorii { get; set; }
        public string OpisKategorii { get; set; }
        public string NazwaPlikuObrazka { get; set; }

        public virtual ICollection<Produkt> Produkty { get; set; }
    }
}