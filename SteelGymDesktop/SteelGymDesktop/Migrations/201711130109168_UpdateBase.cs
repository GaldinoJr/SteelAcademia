namespace SteelGymDesktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "CreateUserId", c => c.Int(nullable: false));
            AlterColumn("dbo.User", "Name", c => c.String(nullable: false, maxLength: 250, unicode: false));
            AlterColumn("dbo.User", "Number", c => c.Int());
            AlterColumn("dbo.User", "UpdateDate", c => c.DateTime());
            AlterColumn("dbo.User", "UpdateUserId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "UpdateUserId", c => c.Int(nullable: false));
            AlterColumn("dbo.User", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.User", "Number", c => c.Int(nullable: false));
            AlterColumn("dbo.User", "Name", c => c.String(maxLength: 255, unicode: false));
            DropColumn("dbo.User", "CreateUserId");
        }
    }
}
