namespace PracticaE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Erika : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Almacens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Disponibles = c.Int(nullable: false),
                        Vendidos = c.Int(nullable: false),
                        producto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Productoes", t => t.producto_Id)
                .Index(t => t.producto_Id);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Proveedor = c.String(),
                        Dia = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Almacens", "producto_Id", "dbo.Productoes");
            DropIndex("dbo.Almacens", new[] { "producto_Id" });
            DropTable("dbo.Productoes");
            DropTable("dbo.Almacens");
        }
    }
}
