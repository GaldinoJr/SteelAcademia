using SteelGymDesktop.Domain.Entities;
using SteelGymDesktop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SteelGymDesktop.Infrastructure.Repository
{
    public class PaymentRepository : RepositoryBase<Payment>, IPaymentRepository
    {
        public IEnumerable<Tuple<Payment, Student>> GetByFilter(
            DateTime? DataPagamento,
            DateTime? DataAtePagamento,
            int? studentId,
            bool fgPago,
            bool fgTodosStatus
        )
        {

            var query = Db.Payments
                .AsEnumerable()
                .Join(
                    Db.Students, 
                    payment => payment.StudentId, 
                    student => student.StudentId,
                    (payment, student) => Tuple.Create<Payment, Student>(payment, student)
                )
                .ToList().Where(x =>
                    Convert.ToDateTime(x.Item1.DataPagamento) >= DataPagamento &&
                    Convert.ToDateTime(x.Item1.DataPagamento) <= DataAtePagamento
                );
            if (!fgTodosStatus) {
                query = query.Where(x => Convert.ToBoolean(x.Item1.FgPago) == fgPago );
            }

            return query;
        }
    }
}
