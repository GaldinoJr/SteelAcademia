using SteelGymDesktop.Domain.Entities;
using SteelGymDesktop.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace SteelGymDesktop.Domain.Services
{
    public class PaymentService : ServiceBase<Payment>, IPaymentService
    {
        private readonly IPaymentRepository _repository;
        public PaymentService(IPaymentRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<Tuple<Payment, Student>> GetByFilter(
            DateTime? DataPagamento,
            DateTime? DataAtePagamento,
            int? studentId,
            bool fgPago,
            bool fgTodosStatus
        )
        {
            return _repository.GetByFilter(DataPagamento, DataAtePagamento, studentId, fgPago, fgTodosStatus);
        }
    }
}
