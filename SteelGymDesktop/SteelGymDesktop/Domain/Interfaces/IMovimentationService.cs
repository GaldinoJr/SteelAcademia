using SteelGymDesktop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelGymDesktop.Domain.Interfaces
{
    public interface IMovimentationService : IServiceBase<Movimentation>
    {
        IEnumerable<Movimentation> GetByFilter(DateTime? DataMovimentacao, bool fgEntrada, bool fgTodosStatus);
    }
}
