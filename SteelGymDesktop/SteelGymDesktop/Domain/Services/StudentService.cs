﻿using SteelGymDesktop.Domain.Entities;
using SteelGymDesktop.Domain.Interfaces;
using System.Collections.Generic;

namespace SteelGymDesktop.Domain.Services
{
    public class StudentService : ServiceBase<Student>, IStudentService
    {
        private readonly IStudentRepository _repository;

        public StudentService(IStudentRepository repository) 
            : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<Student> GetByFilter(bool active, string name, string rg, string cpf)
        {
            return _repository.GetByFilter(active, name, rg, cpf);
        }
    }
}
