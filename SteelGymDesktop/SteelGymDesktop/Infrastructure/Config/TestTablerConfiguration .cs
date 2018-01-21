using SteelGymDesktop.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SteelGymDesktop.Infrastructure.Config
{
    public class TestTablerConfiguration : EntityTypeConfiguration<TestTable>
    {
        public TestTablerConfiguration()
        {
            HasKey(p => p.Id);
            Property(p => p.Name).IsRequired().HasMaxLength(250);
        }
    }
}
