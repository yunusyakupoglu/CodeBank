namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableColumnNamesChanged : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Kategoriler", name: "Birincil Anahtar", newName: "Id");
            RenameColumn(table: "dbo.Kategoriler", name: "Kategori Adı", newName: "CategoryName");
            RenameColumn(table: "dbo.Kategoriler", name: "Arşivlenmiş mi?", newName: "isArchived");
            RenameColumn(table: "dbo.SourceCodes", name: "Birincil Anahtar", newName: "Id");
            RenameColumn(table: "dbo.SourceCodes", name: "Başlık", newName: "Title");
            RenameColumn(table: "dbo.SourceCodes", name: "İçerik", newName: "Content");
            RenameColumn(table: "dbo.SourceCodes", name: "Kategori Numarası", newName: "CategoryId");
            RenameColumn(table: "dbo.SourceCodes", name: "Arşivlenmiş mi?", newName: "isArchived");
            RenameIndex(table: "dbo.SourceCodes", name: "IX_Kategori Numarası", newName: "IX_CategoryId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.SourceCodes", name: "IX_CategoryId", newName: "IX_Kategori Numarası");
            RenameColumn(table: "dbo.SourceCodes", name: "isArchived", newName: "Arşivlenmiş mi?");
            RenameColumn(table: "dbo.SourceCodes", name: "CategoryId", newName: "Kategori Numarası");
            RenameColumn(table: "dbo.SourceCodes", name: "Content", newName: "İçerik");
            RenameColumn(table: "dbo.SourceCodes", name: "Title", newName: "Başlık");
            RenameColumn(table: "dbo.SourceCodes", name: "Id", newName: "Birincil Anahtar");
            RenameColumn(table: "dbo.Kategoriler", name: "isArchived", newName: "Arşivlenmiş mi?");
            RenameColumn(table: "dbo.Kategoriler", name: "CategoryName", newName: "Kategori Adı");
            RenameColumn(table: "dbo.Kategoriler", name: "Id", newName: "Birincil Anahtar");
        }
    }
}
