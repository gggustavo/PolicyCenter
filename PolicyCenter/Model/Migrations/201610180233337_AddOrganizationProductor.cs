namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrganizationProductor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Productor",
                c => new
                    {
                        IdProductor = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        IdOrganizador = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdProductor)
                .ForeignKey("dbo.Organizador", t => t.IdOrganizador)
                .Index(t => t.IdOrganizador);
            
            CreateTable(
                "dbo.Organizador",
                c => new
                    {
                        IdOrganizador = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        IdProductor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdOrganizador);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Productor", "IdOrganizador", "dbo.Organizador");
            DropIndex("dbo.Productor", new[] { "IdOrganizador" });
            DropTable("dbo.Organizador");
            DropTable("dbo.Productor");
        }
    }
}
