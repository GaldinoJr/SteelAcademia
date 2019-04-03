using SteelGymDesktop.Domain.Entities;
using SteelGymDesktop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SteelGymDesktop.Infrastructure.Repository
{
    public class PaymentRepository : RepositoryBase<Payment>, IPaymentRepository
    {
        public IEnumerable<Payment> GetByFilter(
            DateTime? DataPagamento,
            DateTime? DataAtePagamento,
            int? studentId,
            bool fgPago,
            bool fgTodosStatus
        )
        {
            if (fgTodosStatus)
            {
                return Db.Payments.ToList().Where(x =>
                    Convert.ToDateTime(x.DataPagamento) >= DataPagamento &&
                    Convert.ToDateTime(x.DataPagamento) <= DataAtePagamento
                );
            }
            else
            {
                return Db.Payments.ToList().Where(x =>
                    Convert.ToDateTime(x.DataPagamento) >= DataPagamento &&
                    Convert.ToDateTime(x.DataPagamento) <= DataAtePagamento &&
                    Convert.ToBoolean(x.FgPago) == fgPago
                );
            }
        }
    }
}
