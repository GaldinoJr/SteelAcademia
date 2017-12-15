using SteelGymDesktop.Applications.Interfaces;
using SteelGymDesktop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteelGymDesktop.Domain.Interfaces;

namespace SteelGymDesktop.Applications
{
    public class MovimentationAppService : AppServiceBase<Movimentation>, IMovimentationAppService
    {
        private readonly IMovimentationService _service;

        public MovimentationAppService(IMovimentationService servicebase) : base(servicebase)
        {
            _service = servicebase;
        }

        public IEnumerable<Movimentation> GetByFilter(DateTime? DataMovimentacao, bool fgEntrada, bool fgTodosStatus)
        {
            return _service.GetByFilter(DataMovimentacao, fgEntrada, fgTodosStatus);
        }
    }
}
