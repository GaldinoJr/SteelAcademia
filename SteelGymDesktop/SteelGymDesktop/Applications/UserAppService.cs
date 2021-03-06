﻿using System;
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
    }
}
