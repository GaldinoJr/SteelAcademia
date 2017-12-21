using SteelGymDesktop.Domain.Entities;
using SteelGymDesktop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;

namespace SteelGymDesktop.Infrastructure.Repository
{
    public class StudentRepository : RepositoryBase<Student>, IStudentRepository
    {
        public IEnumerable<Student> GetByFilter(bool active, string name, string rg, string cpf)
        {
            return Db.Students.Where(x => x.Active == active || x.Name == name || x.RG == rg || x.CPF == cpf);
        }

        public int GetCount(bool active)
        {
            return Db.Students.Where(x => x.Active == active).Count();
        }

        public int GetCountLateAvaliations()
        {
            DateTime? currentDate = System.DateTime.Now;
            return Db.Students.Where(x =>
                DbFunctions.DiffDays(x.EvaliationDate, currentDate) >= (x.EvaluationPeriodicity * 30) &&
                x.Active == true
            ).Count();
        }

        public int GetCountLatePayments()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Student> LoadLateAvaliations()
        {
            DateTime? currentDate = System.DateTime.Now;
            return Db.Students.Where(x =>
                DbFunctions.DiffDays(x.EvaliationDate, currentDate) >= (x.EvaluationPeriodicity * 30) &&
                x.Active == true
            );
        }

        public IEnumerable<Student> LoadLatePayments()
        {
            // TODO PRECISA DOS PAGAMENTOS PARA VERIFICAR
            throw new System.NotImplementedException();
        }
    }
}