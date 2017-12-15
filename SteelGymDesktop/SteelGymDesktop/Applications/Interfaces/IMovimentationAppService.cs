using SteelGymDesktop.Domain.Entities;
using SteelGymDesktop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelGymDesktop.Applications.Interfaces
{
    public interface IMovimentationAppService : IAppServiceBase<Movimentation>
    {
        IEnumerable<Movimentation> GetByFilter(DateTime? DataMovimentacao, bool fgEntrada, bool fgTodosStatus);
    }
}
