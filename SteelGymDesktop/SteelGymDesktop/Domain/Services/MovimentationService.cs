using SteelGymDesktop.Domain.Entities;
using SteelGymDesktop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelGymDesktop.Domain.Services
{
    public class MovimentationService : ServiceBase<Movimentation>, IMovimentationService
    {
        private readonly IMovimentationRepository _repository;
        public MovimentationService(IMovimentationRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<Movimentation> GetByFilter(DateTime? DataMovimentacao, DateTime? DataAteMovimentacao, bool fgEntrada, bool fgTodosStatus)
        {
            return _repository.GetByFilter(DataMovimentacao, DataAteMovimentacao, fgEntrada, fgTodosStatus);
        }
    }
}
