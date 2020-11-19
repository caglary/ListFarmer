namespace Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ciftciler",
                c => new
                    {
                        CiftciID = c.Guid(name: "Ciftci ID", nullable: false),
                        TCNumarası = c.String(name: "TC Numarası", nullable: false, maxLength: 11),
                        Isim = c.String(nullable: false),
                        Soyisim = c.String(nullable: false),
                        Mahalle = c.String(nullable: false),
                        Telefon = c.String(),
                        Acıklama = c.String(storeType: "ntext"),
                        KayıtTarihi = c.DateTime(name: "Kayıt Tarihi", nullable: false),
                    })
                .PrimaryKey(t => t.CiftciID)
                .Index(t => t.TCNumarası, unique: true);
            
            CreateTable(
                "dbo.Dilekceler",
                c => new
                    {
                        DilekceID = c.Int(name: "Dilekce ID", nullable: false, identity: true),
                        DilekceNumarası = c.String(name: "Dilekce Numarası", nullable: false),
                        DilekceTarihi = c.String(name: "Dilekce Tarihi"),
                        ÜretimYılı = c.String(name: "Üretim Yılı", nullable: false, maxLength: 4),
                        DilekceKabulTarihi = c.String(name: "Dilekce Kabul Tarihi"),
                        İlAdı = c.String(name: "İl Adı", maxLength: 20),
                        İlçeAdı = c.String(name: "İlçe Adı", maxLength: 20),
                        Durum = c.String(maxLength: 10),
                        ÇiftciID = c.Guid(name: "Çiftci ID", nullable: false),
                    })
                .PrimaryKey(t => t.DilekceID)
                .ForeignKey("dbo.Ciftciler", t => t.ÇiftciID, cascadeDelete: true)
                .Index(t => t.ÇiftciID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dilekceler", "Çiftci ID", "dbo.Ciftciler");
            DropIndex("dbo.Dilekceler", new[] { "Çiftci ID" });
            DropIndex("dbo.Ciftciler", new[] { "TC Numarası" });
            DropTable("dbo.Dilekceler");
            DropTable("dbo.Ciftciler");
        }
    }
}
