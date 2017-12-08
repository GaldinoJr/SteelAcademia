namespace SteelGymDesktop.Migrations
{
    using SteelGymDesktop.Domain.Entities;
    using SteelGymDesktop.Infrastructure.DataAccess;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DbConnection>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DbConnection context)
        {
            var _user = new User();

            _user.Name = "Administrador";
            _user.Number = 0;
            _user.UF = "SP";
            _user.Active = true;
            _user.IsAdmin = true;
            _user.CanAccessFinancial = true;
            _user.Password = "admin@@123";
            _user.FirstLogin = true;
            _user.UserName = "admin_admin";

            context.Users.Add(_user);
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
