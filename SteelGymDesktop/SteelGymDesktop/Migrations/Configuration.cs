namespace SteelGymDesktop.Migrations
{
    using SteelGymDesktop.Domain.Entities;
    using SteelGymDesktop.Infrastructure.DataAccess;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DbConnection>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DbConnection context)
        {
            var _user = new User()
            {
                Name = "Administrador",
                Number = 0,
                UF = "SP",
                Active = true,
                IsAdmin = true,
                CanAccessFinancial = true,
                Password = "admin@@123",
                FirstLogin = true,
                UserName = "admin"
            };

            //context.Users.Add(_user);
            //context.SaveChanges();

            base.Seed(context);
        }
    }
}
