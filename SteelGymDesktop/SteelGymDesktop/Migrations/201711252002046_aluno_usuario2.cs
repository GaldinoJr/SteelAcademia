namespace SteelGymDesktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aluno_usuario2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250, unicode: false),
                        CivilStatus = c.String(maxLength: 255, unicode: false),
                        CPF = c.String(maxLength: 255, unicode: false),
                        BirthDate = c.DateTime(),
                        PayDay = c.DateTime(),
                        Email = c.String(maxLength: 255, unicode: false),
                        Sex = c.String(maxLength: 255, unicode: false),
                        IMC = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Profession = c.String(maxLength: 255, unicode: false),
                        RG = c.String(maxLength: 255, unicode: false),
                        Active = c.Boolean(nullable: false),
                        Address = c.String(maxLength: 255, unicode: false),
                        Number = c.Int(),
                        Neighborhood = c.String(maxLength: 255, unicode: false),
                        Complement = c.String(maxLength: 255, unicode: false),
                        City = c.String(maxLength: 255, unicode: false),
                        UF = c.String(maxLength: 255, unicode: false),
                        CEP = c.String(maxLength: 255, unicode: false),
                        Phone1 = c.String(maxLength: 255, unicode: false),
                        Phone2 = c.String(maxLength: 255, unicode: false),
                        RelativeName1 = c.String(maxLength: 255, unicode: false),
                        RelativeName2 = c.String(maxLength: 255, unicode: false),
                        RelativeName3 = c.String(maxLength: 255, unicode: false),
                        RelativeDegree1 = c.String(maxLength: 255, unicode: false),
                        RelativeDegree2 = c.String(maxLength: 255, unicode: false),
                        RelativeDegree3 = c.String(maxLength: 255, unicode: false),
                        ResponsibleName = c.String(maxLength: 255, unicode: false),
                        ResponsibleDegree = c.String(maxLength: 255, unicode: false),
                        ResponsibleAddress = c.String(maxLength: 255, unicode: false),
                        ResponsibleNeighborhood = c.String(maxLength: 255, unicode: false),
                        ResponsibleNumber = c.Int(),
                        ResponsibleComplement = c.String(maxLength: 255, unicode: false),
                        ResponsibleCity = c.String(maxLength: 255, unicode: false),
                        ResponsibleUF = c.String(maxLength: 255, unicode: false),
                        ResponsibleCEP = c.String(maxLength: 255, unicode: false),
                        ResponsiblePhone1 = c.String(maxLength: 255, unicode: false),
                        ResponsiblePhone2 = c.String(maxLength: 255, unicode: false),
                        UpdateDate = c.DateTime(),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateUserId = c.Int(),
                        CreateUserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Student");
        }
    }
}
