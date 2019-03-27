using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;

namespace SteelGymDesktop.Domain.Entities
{
    [Table(Name = "Payment")]
    public class Payment
    {
        [Column(Name = "PaymentId", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int PaymentId { get; set; }
    }
}
