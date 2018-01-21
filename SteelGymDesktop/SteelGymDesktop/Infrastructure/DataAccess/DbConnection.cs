

using SteelGymDesktop.Domain.Entities;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace SteelGymDesktop.Infrastructure.DataAccess
{
    public class DbConnection : DbContext
    {
        public DbConnection() : base("Contexto")
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Movimentation> Movimentations { get; set; }
        public DbSet<TestTable> TestTable { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); 
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(255));

            modelBuilder.Properties<DateTime>()
                .Configure(c => c.HasColumnType("datetime"));

            modelBuilder.Configurations.Add(new Config.UserConfiguration());
            modelBuilder.Configurations.Add(new Config.StudentConfiguration());
            modelBuilder.Configurations.Add(new Config.TestTablerConfiguration());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("CreateDate") != null))
            {
                if (entry.State == EntityState.Added)
                    entry.Property("CreateDate").CurrentValue = DateTime.Now;

                if (entry.State == EntityState.Modified)
                    entry.Property("CreateDate").IsModified = false;
            }

            return base.SaveChanges();
        }
    }
}
