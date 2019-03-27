using SteelGymDesktop.Domain.Entities;
using System.Collections.Generic;
namespace SteelGymDesktop.Applications.Interfaces
{
    public interface IPaymentAppService : IAppServiceBase<Payment>
    {
        IEnumerable<Payment> GetByFilter(int? mes, bool? pago, string rg, string cpf);
    }
}
