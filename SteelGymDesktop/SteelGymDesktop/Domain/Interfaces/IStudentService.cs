﻿using SteelGymDesktop.Domain.Entities;
using System.Collections.Generic;

namespace SteelGymDesktop.Domain.Interfaces
{
    public interface IStudentService : IServiceBase<Student>
    {
        IEnumerable<Student> GetByFilter(int active, string name, string rg, string cpf, int? idAluno);
        int GetCount(int active);
        IEnumerable<Student> GetAllActive();
        IEnumerable<Student> LoadLatePayments();
        IEnumerable<Student> LoadLateAvaliations();
        int GetCountLatePayments();
        int GetCountLateAvaliations();
    }
}