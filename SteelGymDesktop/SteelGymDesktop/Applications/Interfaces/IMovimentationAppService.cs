using SteelGymDesktop.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SteelGymDesktop.Applications.Interfaces
{
    public interface IMovimentationAppService : IAppServiceBase<Movimentation>
    {
        IEnumerable<Movimentation> GetByFilter(DateTime? DataMovimentacao, DateTime? DataAteMovimentacao, bool fgEntrada, bool fgTodosStatus);
    }
}
