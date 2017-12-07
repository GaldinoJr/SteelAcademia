using SteelGymDesktop.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SteelGymDesktop.Infrastructure.Config
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasKey(p => p.UserId);
            Property(p => p.Name).IsRequired().HasMaxLength(250);
            HasIndex(p => p.UserName).IsUnique();
        }
    }
}
