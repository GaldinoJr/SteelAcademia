using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;

namespace SteelGymDesktop.Domain.Entities
{
    [Table(Name = "Movimentation")]
    public class Movimentation
    {
        [Column(Name = "MovimentationId", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int MovimentationId { get; set; }

        [Column(Name = "UsuarioInclusaoId", DbType = "VARCHAR")]
        public int UsuarioInclusaoId { get; set; }

        [Column(Name = "Origin", DbType = "VARCHAR")]
        public string Origin { get; set; }

        [Column(Name = "FgEntrada", DbType = "VARCHAR")]
        public int FgEntrada { get; set; }

        [Column(Name = "tipoPagamento", DbType = "VARCHAR")]
        public string tipoPagamento { get; set; }

        [Column(Name = "DataMovimentacao", DbType = "VARCHAR")]
        public string DataMovimentacao { get; set; }

        [Column(Name = "Value", DbType = "VARCHAR")]
        public decimal Value { get; set; }
    }
}
