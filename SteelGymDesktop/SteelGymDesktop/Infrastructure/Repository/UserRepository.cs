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
            IQueryable<User> query = Db.Users;

            query.Where(x => x.Active == active);

            if (Util.ValidaString(userName))
                query = query.Where(x => x.UserName.Contains(userName));

            if (Util.ValidaString(rg))
                query = query.Where(x => x.RG == rg);

            if (Util.ValidaString(cpf))
                query = query.Where(x => x.CPF == cpf);

            return query;
        }

        public User Login(string userName, string password)
        {
            return Db.Users.FirstOrDefault(x => x.UserName == userName && x.Password == password);
        }
    }
}
