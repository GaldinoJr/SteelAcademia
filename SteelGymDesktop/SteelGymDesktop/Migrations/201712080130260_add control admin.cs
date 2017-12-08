namespace SteelGymDesktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcontroladmin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "IsAdmin", c => c.Boolean(nullable: false));
            AddColumn("dbo.User", "CanAccessFinancial", c => c.Boolean(nullable: false));
            AddColumn("dbo.User", "FirstLogin", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "FirstLogin");
            DropColumn("dbo.User", "CanAccessFinancial");
            DropColumn("dbo.User", "IsAdmin");
        }
    }
}
