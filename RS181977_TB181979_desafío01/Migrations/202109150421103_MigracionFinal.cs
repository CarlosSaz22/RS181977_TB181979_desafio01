namespace RS181977_TB181979_desafío01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigracionFinal : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CuentaBancaria",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        idCliente = c.Int(),
                        Moneda = c.String(nullable: false, maxLength: 100),
                        Tipo = c.Int(),
                        Clientes_id = c.Int(),
                        TipoCuentaBancarias_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Cliente", t => t.Clientes_id)
                .ForeignKey("dbo.TipoCuentaBancaria", t => t.TipoCuentaBancarias_id)
                .Index(t => t.Clientes_id)
                .Index(t => t.TipoCuentaBancarias_id);
            
            CreateTable(
                "dbo.Transacciones",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        idCuentaBancaria = c.Int(),
                        TipoTransaccion = c.Int(),
                        Monto = c.Single(nullable: false),
                        Estado = c.String(nullable: false, maxLength: 100),
                        FechaTransaccion = c.DateTime(nullable: false),
                        FechaAplicación = c.DateTime(nullable: false),
                        GetCuentaBancarias_id = c.Int(),
                        TipoTransacciones_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.CuentaBancaria", t => t.GetCuentaBancarias_id)
                .ForeignKey("dbo.TipoTransaccion", t => t.TipoTransacciones_id)
                .Index(t => t.GetCuentaBancarias_id)
                .Index(t => t.TipoTransacciones_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transacciones", "TipoTransacciones_id", "dbo.TipoTransaccion");
            DropForeignKey("dbo.Transacciones", "GetCuentaBancarias_id", "dbo.CuentaBancaria");
            DropForeignKey("dbo.CuentaBancaria", "TipoCuentaBancarias_id", "dbo.TipoCuentaBancaria");
            DropForeignKey("dbo.CuentaBancaria", "Clientes_id", "dbo.Cliente");
            DropIndex("dbo.Transacciones", new[] { "TipoTransacciones_id" });
            DropIndex("dbo.Transacciones", new[] { "GetCuentaBancarias_id" });
            DropIndex("dbo.CuentaBancaria", new[] { "TipoCuentaBancarias_id" });
            DropIndex("dbo.CuentaBancaria", new[] { "Clientes_id" });
            DropTable("dbo.Transacciones");
            DropTable("dbo.CuentaBancaria");
        }
    }
}
