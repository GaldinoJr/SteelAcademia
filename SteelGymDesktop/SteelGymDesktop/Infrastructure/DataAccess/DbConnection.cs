

using SteelGymDesktop.Domain.Entities;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using System.Linq;

namespace SteelGymDesktop.Infrastructure.DataAccess
{
    public class DbConnection : DbContext
    {
        public DbConnection() : base(new SQLiteConnection()
        {
            ConnectionString = new SQLiteConnectionStringBuilder() { DataSource = @"C:\SteelGym\DataBase\SteelGymDesktop.db", ForeignKeys = true }.ConnectionString
        }, true)
        {
            Database.SetInitializer<DbConnection>(null);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Movimentation> Movimentations { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); 
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("CreateDate") != null))
            {
                if (entry.State == EntityState.Added)
                    entry.Property("CreateDate").CurrentValue = DateTime.Now.ToString();

                if (entry.State == EntityState.Modified)
                    entry.Property("CreateDate").IsModified = false;
            }

            return base.SaveChanges();
        }
    }
}
