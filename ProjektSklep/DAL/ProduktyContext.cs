using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ProjektSklep.Models;

namespace ProjektSklep.DAL
{
    public class ProduktyContext : DbContext
    {
        public ProduktyContext() : base("ProduktyContext")
        {
            

        }

        static ProduktyContext()
        {
            Database.SetInitializer<ProduktyContext>(new ProduktyInitializer());
        }


        public DbSet<Produkt> Produkty { get; set; }
        public DbSet<Kategoria> Kategorie { get; set; }
        public DbSet<Zamowienie> Zamowienia { get; set; }
        public DbSet<PozycjaZamowienia> PozycjaZamowienia { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //usuwa automatyczna konwencje dodawania na koncu 's' do nazw tabel
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }
    }
}