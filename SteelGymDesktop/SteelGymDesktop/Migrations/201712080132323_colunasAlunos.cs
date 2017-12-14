namespace SteelGymDesktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class colunasAlunos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "EvaliationDate", c => c.DateTime());
            AddColumn("dbo.Student", "EvaluationPeriodicity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Student", "EvaluationPeriodicity");
            DropColumn("dbo.Student", "EvaliationDate");
        }
    }
}
