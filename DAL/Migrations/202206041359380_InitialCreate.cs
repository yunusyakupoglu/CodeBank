namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategoriler",
                c => new
                    {
                        BirincilAnahtar = c.Int(name: "Birincil Anahtar", nullable: false, identity: true),
                        KategoriAdı = c.String(name: "Kategori Adı", maxLength: 350),
                        Arşivlenmişmi = c.Boolean(name: "Arşivlenmiş mi?", nullable: false),
                    })
                .PrimaryKey(t => t.BirincilAnahtar);
            
            CreateTable(
                "dbo.SourceCodes",
                c => new
                    {
                        BirincilAnahtar = c.Int(name: "Birincil Anahtar", nullable: false, identity: true),
                        Başlık = c.String(maxLength: 500),
                        İçerik = c.String(maxLength: 4000),
                        KategoriNumarası = c.Int(name: "Kategori Numarası", nullable: false),
                        Arşivlenmişmi = c.Boolean(name: "Arşivlenmiş mi?", nullable: false),
                    })
                .PrimaryKey(t => t.BirincilAnahtar)
                .ForeignKey("dbo.Kategoriler", t => t.KategoriNumarası, cascadeDelete: true)
                .Index(t => t.KategoriNumarası);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SourceCodes", "Kategori Numarası", "dbo.Kategoriler");
            DropIndex("dbo.SourceCodes", new[] { "Kategori Numarası" });
            DropTable("dbo.SourceCodes");
            DropTable("dbo.Kategoriler");
        }
    }
}
