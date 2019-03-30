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
        public IEnumerable<Movimentation> GetByFilter(DateTime? DataDeMovimentacao, DateTime? DataAteMovimentacao, bool fgEntrada, bool fgTodosStatus)
        {
            if (fgTodosStatus)
                return Db.Movimentations.ToList().Where(x => Convert.ToDateTime(x.DataMovimentacao) >= DataDeMovimentacao && Convert.ToDateTime(x.DataMovimentacao) <= DataAteMovimentacao);
            else
                return Db.Movimentations.ToList().Where(x => Convert.ToDateTime(x.DataMovimentacao) >= DataDeMovimentacao && Convert.ToDateTime(x.DataMovimentacao) <= DataAteMovimentacao && Convert.ToBoolean(x.FgEntrada) == fgEntrada);
        }
    }
}
