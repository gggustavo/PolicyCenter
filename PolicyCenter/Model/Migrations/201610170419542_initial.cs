namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Marca",
                c => new
                    {
                        IdMarca = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.IdMarca);
            
            CreateTable(
                "dbo.Modelo",
                c => new
                    {
                        IdModelo = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        IdMarca = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdModelo)
                .ForeignKey("dbo.Marca", t => t.IdMarca)
                .Index(t => t.IdMarca);
            
            CreateTable(
                "dbo.Version",
                c => new
                    {
                        IdVersion = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        IdModelo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdVersion)
                .ForeignKey("dbo.Modelo", t => t.IdModelo)
                .Index(t => t.IdModelo);
            
            CreateTable(
                "dbo.Localidad",
                c => new
                    {
                        IdLocalidad = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        CodPostal = c.String(),
                    })
                .PrimaryKey(t => t.IdLocalidad);
            
            CreateTable(
                "dbo.Vehiculo",
                c => new
                    {
                        IdVehiculo = c.Int(nullable: false, identity: true),
                        IdMarca = c.Int(nullable: false),
                        Anio = c.String(),
                        Patente = c.String(),
                        Color = c.String(),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.IdVehiculo)
                .ForeignKey("dbo.Marca", t => t.IdMarca)
                .Index(t => t.IdMarca);
            
            CreateTable(
                "dbo.Persona",
                c => new
                    {
                        IdPersona = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Dni = c.String(),
                        Cuit = c.String(),
                        Cuil = c.String(),
                        Edad = c.Int(nullable: false),
                        Email = c.String(),
                        Celular = c.String(),
                        IdDireccion = c.Int(nullable: false),
                        IdLocalidad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdPersona)
                .ForeignKey("dbo.Direccion", t => t.IdDireccion)
                .ForeignKey("dbo.Localidad", t => t.IdLocalidad)
                .Index(t => t.IdDireccion)
                .Index(t => t.IdLocalidad);
            
            CreateTable(
                "dbo.Direccion",
                c => new
                    {
                        IdDireccion = c.Int(nullable: false, identity: true),
                        Calle = c.String(),
                        Numero = c.Int(nullable: false),
                        Piso = c.Int(),
                        Departamento = c.String(),
                    })
                .PrimaryKey(t => t.IdDireccion);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Persona", "IdLocalidad", "dbo.Localidad");
            DropForeignKey("dbo.Persona", "IdDireccion", "dbo.Direccion");
            DropForeignKey("dbo.Vehiculo", "IdMarca", "dbo.Marca");
            DropForeignKey("dbo.Version", "IdModelo", "dbo.Modelo");
            DropForeignKey("dbo.Modelo", "IdMarca", "dbo.Marca");
            DropIndex("dbo.Persona", new[] { "IdLocalidad" });
            DropIndex("dbo.Persona", new[] { "IdDireccion" });
            DropIndex("dbo.Vehiculo", new[] { "IdMarca" });
            DropIndex("dbo.Version", new[] { "IdModelo" });
            DropIndex("dbo.Modelo", new[] { "IdMarca" });
            DropTable("dbo.Direccion");
            DropTable("dbo.Persona");
            DropTable("dbo.Vehiculo");
            DropTable("dbo.Localidad");
            DropTable("dbo.Version");
            DropTable("dbo.Modelo");
            DropTable("dbo.Marca");
        }
    }
}
