using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelGymDesktop.Domain.Entities
{
    public class Movimentation
    {
        public int MovimentationId { get; set; }
        public int UsuarioInclusaoId { get; set; }
        public string Origin { get; set; }
        public bool FgEntrada{ get; set; }
        public string tipoPagamento { get; set; }
        public DateTime? DataMovimentacao { get; set; }
    }
}
