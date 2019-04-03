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

        [Column(Name = "UsuarioInclusaoId", DbType = "VARCHAR")]
        public int UsuarioInclusaoId { get; set; }

        [Column(Name = "DataPagamento", DbType = "VARCHAR")]
        public string DataPagamento { get; set; }

        [Column(Name = "FgPago", DbType = "VARCHAR")]
        public int FgPago { get; set; }

        [Column(Name = "StudentId", DbType = "VARCHAR")]
        public int StudentId { get; set; }

        [Column(Name = "Value", DbType = "VARCHAR")]
        public decimal Value { get; set; }
    }
}
