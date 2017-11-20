using SteelGymDesktop.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SteelGymDesktop.Infrastructure.Config
{
    public class StudentConfiguration : EntityTypeConfiguration<Student>
    {
        public StudentConfiguration()
        {
            HasKey(p => p.StudentId);
            Property(p => p.Name).IsRequired().HasMaxLength(250);
        }
    }
}
