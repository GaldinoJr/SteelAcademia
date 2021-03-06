﻿using SteelGymDesktop.Applications.Interfaces;
using SteelGymDesktop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteelGymDesktop.Domain.Interfaces;

namespace SteelGymDesktop.Applications
{
    public class StudentAppService : AppServiceBase<Student>, IStudentAppService
    {
        private readonly IStudentService _service;

        public StudentAppService(IStudentService servicebase) : base(servicebase)
        {
            _service = servicebase;
        }

        public IEnumerable<Student> GetByFilter(bool active, string name, string rg, string cpf)
        {
            return _service.GetByFilter(active, name, rg, cpf);
        }
    }
}
