using System;
using System.Collections.Generic;
using SteelGymDesktop.Domain.Entities;
using SteelGymDesktop.Domain.Interfaces;
using System.Linq;

namespace SteelGymDesktop.Infrastructure.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public IEnumerable<User> GetByFilter(bool active, string name, string rg, string cpf)
        {
            IQueryable<User> query = Db.Users;

            name = name.ToLower();

            query.Where(x => Convert.ToBoolean(x.Active) == active);

            if (Util.ValidaString(name))
            {
                query = query.Where(
                    x => (
                        x.Name.ToLower().Contains(name) ||
                        x.LastName.ToLower().Contains(name)
                    )
                );
            }

            if (Util.ValidaRg(rg))
                query = query.Where(x => x.RG == rg);

            if (Util.ValidaCpf(cpf))
                query = query.Where(x => x.CPF == cpf);

            return query;
        }

        public User GetByUserName(string userName)
        {
            return Db.Users.FirstOrDefault(x => x.UserName == userName);
        }

        public User Login(string userName, string password)
        {
            return Db.Users.FirstOrDefault(x => x.UserName == userName && x.Password == password);
        }
    }
}
