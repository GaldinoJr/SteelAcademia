using System;
using System.Collections.Generic;
using SteelGymDesktop.Domain.Entities;
using SteelGymDesktop.Domain.Interfaces;
using System.Linq;

namespace SteelGymDesktop.Infrastructure.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public IEnumerable<User> GetByFilter(bool active, string userName, string rg, string cpf)
        {
            return Db.Users.Where(x => x.Active == active || x.UserName == userName || x.RG == rg || x.CPF == cpf);
        }
    }
}
