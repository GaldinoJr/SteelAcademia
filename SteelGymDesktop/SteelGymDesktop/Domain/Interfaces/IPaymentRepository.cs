using SteelGymDesktop.Domain.Entities;
using System;
using System.Collections.Generic;
namespace SteelGymDesktop.Domain.Interfaces
{
    public interface IPaymentRepository : IRepositoryBase<Payment>
    {
        IEnumerable<Payment> GetByFilter(
            DateTime? DataPagamento,
            DateTime? DataAtePagamento,
            int? studentId,
            bool fgPago,
            bool fgTodosStatus
        );
    }
}
