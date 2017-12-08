using SteelGymDesktop.Domain.Entities;
using System.Collections.Generic;

namespace SteelGymDesktop.Domain.Interfaces
{
    public interface IUserService : IServiceBase<User>
    {
        IEnumerable<User> GetByFilter(bool active, string userName, string rg, string cpf);
        User Login(string userName, string password);
    }
}
