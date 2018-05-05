namespace SteelGymDesktop.Migrations
{
    using SteelGymDesktop.Domain.Entities;
    using SteelGymDesktop.Infrastructure.DataAccess;
    using System.Data.Entity;
    using System.Data.Entity.Core.Common;
    using System.Data.Entity.Migrations;
    using System.Data.SQLite;
    using System.Data.SQLite.EF6;

    internal sealed class Configuration : DbConfiguration
    {
        public Configuration()
        {
            SetProviderFactory("System.Data.SQLite", SQLiteFactory.Instance);
            SetProviderFactory("System.Data.SQLite.EF6", SQLiteProviderFactory.Instance);
            SetProviderServices("System.Data.SQLite", (DbProviderServices)SQLiteProviderFactory.Instance.GetService(typeof(DbProviderServices)));
        }
    }
}
