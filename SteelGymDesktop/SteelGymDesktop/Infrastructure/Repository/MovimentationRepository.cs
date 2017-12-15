using SteelGymDesktop.Domain.Entities;
using SteelGymDesktop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelGymDesktop.Infrastructure.Repository
{
    public class MovimentationRepository : RepositoryBase<Movimentation>, IMovimentationRepository
    {
        public IEnumerable<Movimentation> GetByFilter(DateTime? DataMovimentacao, bool fgEntrada, bool fgTodosStatus)
        {
            if (fgTodosStatus)
            {
                return Db.Movimentations.Where(x => x.DataMovimentacao == DataMovimentacao);
            }
            else
            {
                return Db.Movimentations.Where(x => x.DataMovimentacao == DataMovimentacao && x.FgEntrada == fgEntrada);
            }
        }
    }
}
