namespace ProjektSklep.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategorias",
                c => new
                    {
                        KategoriaId = c.Int(nullable: false, identity: true),
                        NazwaKategorii = c.String(nullable: false, maxLength: 100),
                        OpisKategorii = c.String(),
                        NazwaPlikuObrazka = c.String(),
                    })
                .PrimaryKey(t => t.KategoriaId);
            
            CreateTable(
                "dbo.Produkts",
                c => new
                    {
                        ProduktId = c.Int(nullable: false, identity: true),
                        KategoriaId = c.Int(nullable: false),
                        NazwaProduktu = c.String(nullable: false, maxLength: 100),
                        DataDodania = c.DateTime(nullable: false),
                        NazwaPlikuObrazka = c.String(),
                        OpisProduktu = c.String(),
                        CenaProduktu = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Bestseller = c.Boolean(nullable: false),
                        Ukryty = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProduktId)
                .ForeignKey("dbo.Kategorias", t => t.KategoriaId, cascadeDelete: true)
                .Index(t => t.KategoriaId);
            
            CreateTable(
                "dbo.PozycjaZamowienias",
                c => new
                    {
                        PozycjaZamowieniaId = c.Int(nullable: false, identity: true),
                        ZamowienieId = c.Int(nullable: false),
                        ProduktId = c.Int(nullable: false),
                        Ilosc = c.Int(nullable: false),
                        CenaZakupu = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PozycjaZamowieniaId)
                .ForeignKey("dbo.Produkts", t => t.ProduktId, cascadeDelete: true)
                .ForeignKey("dbo.Zamowienies", t => t.ZamowienieId, cascadeDelete: true)
                .Index(t => t.ZamowienieId)
                .Index(t => t.ProduktId);
            
            CreateTable(
                "dbo.Zamowienies",
                c => new
                    {
                        ZamowienieId = c.Int(nullable: false, identity: true),
                        Imie = c.String(nullable: false, maxLength: 50),
                        Nazwisko = c.String(nullable: false, maxLength: 50),
                        Ulica = c.String(nullable: false, maxLength: 50),
                        Miasto = c.String(nullable: false, maxLength: 50),
                        KodPocztowy = c.String(),
                        Email = c.String(),
                        Telefon = c.String(),
                        Komentarz = c.String(),
                        DataZamowienia = c.DateTime(nullable: false),
                        StanZamowienia = c.Int(nullable: false),
                        WartoscZamowienia = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ZamowienieId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PozycjaZamowienias", "ZamowienieId", "dbo.Zamowienies");
            DropForeignKey("dbo.PozycjaZamowienias", "ProduktId", "dbo.Produkts");
            DropForeignKey("dbo.Produkts", "KategoriaId", "dbo.Kategorias");
            DropIndex("dbo.PozycjaZamowienias", new[] { "ProduktId" });
            DropIndex("dbo.PozycjaZamowienias", new[] { "ZamowienieId" });
            DropIndex("dbo.Produkts", new[] { "KategoriaId" });
            DropTable("dbo.Zamowienies");
            DropTable("dbo.PozycjaZamowienias");
            DropTable("dbo.Produkts");
            DropTable("dbo.Kategorias");
        }
    }
}
