namespace SteelGymDesktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teste1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250, unicode: false),
                        LastName = c.String(maxLength: 255, unicode: false),
                        RG = c.String(maxLength: 255, unicode: false),
                        CPF = c.String(maxLength: 255, unicode: false),
                        Email = c.String(maxLength: 255, unicode: false),
                        Address = c.String(maxLength: 255, unicode: false),
                        Number = c.Int(),
                        Complement = c.String(maxLength: 255, unicode: false),
                        Neighborhood = c.String(maxLength: 255, unicode: false),
                        Active = c.Boolean(nullable: false),
                        City = c.String(maxLength: 255, unicode: false),
                        UF = c.String(maxLength: 255, unicode: false),
                        CEP = c.String(maxLength: 255, unicode: false),
                        Phone1 = c.String(maxLength: 255, unicode: false),
                        Phone2 = c.String(maxLength: 255, unicode: false),
                        UserName = c.String(maxLength: 255, unicode: false),
                        Password = c.String(maxLength: 255, unicode: false),
                        UpdateDate = c.DateTime(),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateUserId = c.Int(),
                        CreateUserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.User");
        }
    }
}
