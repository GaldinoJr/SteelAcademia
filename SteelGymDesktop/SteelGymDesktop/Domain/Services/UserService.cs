﻿using SteelGymDesktop.Domain.Entities;
using SteelGymDesktop.Domain.Interfaces;
using System.Collections.Generic;

namespace SteelGymDesktop.Domain.Services
{
    public class UserService : ServiceBase<User>, IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
            : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<User> GetByFilter(bool active, string userName, string rg, string cpf)
        {
            return _repository.GetByFilter(active, userName, rg, cpf);
        }
    }
}
