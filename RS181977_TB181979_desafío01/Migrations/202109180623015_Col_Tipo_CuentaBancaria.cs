namespace RS181977_TB181979_desafío01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Col_Tipo_CuentaBancaria : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TipoCuentaBancaria", "Tipo_CuentaBancaria", c => c.String(nullable: false, maxLength: 150));
            DropColumn("dbo.TipoCuentaBancaria", "Tipo_Transaccion");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TipoCuentaBancaria", "Tipo_Transaccion", c => c.String(nullable: false, maxLength: 150));
            DropColumn("dbo.TipoCuentaBancaria", "Tipo_CuentaBancaria");
        }
    }
}
