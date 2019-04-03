using SteelGymDesktop.Applications.Interfaces;
using SteelGymDesktop.Domain.Entities;
using System;
using System.Collections.Generic;
using SteelGymDesktop.Domain.Interfaces;

namespace SteelGymDesktop.Applications
{
    public class PaymentAppService : AppServiceBase<Payment>, IPaymentAppService
    {
        private readonly IPaymentService _service;

        public PaymentAppService(IPaymentService servicebase) : base(servicebase)
        {
            _service = servicebase;
        }

        public IEnumerable<Tuple<Payment, Student>> GetByFilter(
            DateTime? DataPagamento,
            DateTime? DataAtePagamento,
            int? studentId,
            bool fgPago,
            bool fgTodosStatus
        )
        {
            return _service.GetByFilter(DataPagamento, DataAtePagamento, studentId, fgPago, fgTodosStatus);
        }
    }
}
