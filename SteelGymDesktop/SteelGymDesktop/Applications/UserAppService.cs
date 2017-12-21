using System;
using System.Collections.Generic;
using SteelGymDesktop.Applications.Interfaces;
using SteelGymDesktop.Domain.Entities;
using SteelGymDesktop.Domain.Interfaces;

namespace SteelGymDesktop.Applications
{
    public class UserAppService : AppServiceBase<User>, IUserAppService
    {
        private readonly IUserService _service;

        public UserAppService(IUserService service)
            : base(service)
        {
            _service = service;
        }

        public IEnumerable<User> GetByFilter(bool active, string userName, string rg, string cpf)
        {
            return _service.GetByFilter(active, userName, rg, cpf);
        }

        public User GetByUserName(string userName)
        {
            return _service.GetByUserName(userName);
        }

        public User Login(string userName, string password)
        {
            return _service.Login(userName, password);
        }
    }
}
