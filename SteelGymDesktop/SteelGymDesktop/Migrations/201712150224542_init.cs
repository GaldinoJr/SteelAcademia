namespace SteelGymDesktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movimentation",
                c => new
                    {
                        MovimentationId = c.Int(nullable: false, identity: true),
                        UsuarioInclusaoId = c.Int(nullable: false),
                        Origin = c.String(maxLength: 255, unicode: false),
                        FgEntrada = c.Boolean(nullable: false),
                        tipoPagamento = c.String(maxLength: 255, unicode: false),
                        DataMovimentacao = c.DateTime(),
                    })
                .PrimaryKey(t => t.MovimentationId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movimentation");
        }
    }
}
