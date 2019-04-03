﻿using SteelGymDesktop.Domain.Entities;
using System;
using System.Collections.Generic;
namespace SteelGymDesktop.Applications.Interfaces
{
    public interface IPaymentAppService : IAppServiceBase<Payment>
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
