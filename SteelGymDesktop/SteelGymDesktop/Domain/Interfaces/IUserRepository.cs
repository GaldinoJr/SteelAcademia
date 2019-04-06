using SteelGymDesktop.Domain.Entities;
using System.Collections.Generic;

namespace SteelGymDesktop.Domain.Interfaces
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        IEnumerable<User> GetByFilter(bool active, string userName, string rg, string cpf, int? userId, bool noAdmin);
        User Login(string userName, string password);
        User GetByUserName(string userName);
    }
}
