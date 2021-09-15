namespace RS181977_TB181979_desafío01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigracionInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombres = c.String(nullable: false, maxLength: 100),
                        primerApellido = c.String(nullable: false, maxLength: 100),
                        segundoApellido = c.String(nullable: false, maxLength: 100),
                        Telefono = c.String(nullable: false, maxLength: 8),
                        email = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TipoCuentaBancaria",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Tipo_Transaccion = c.String(nullable: false, maxLength: 150),
                        Activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TipoTransaccion",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Tipo_Transaccion = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TipoTransaccion");
            DropTable("dbo.TipoCuentaBancaria");
            DropTable("dbo.Cliente");
        }
    }
}
