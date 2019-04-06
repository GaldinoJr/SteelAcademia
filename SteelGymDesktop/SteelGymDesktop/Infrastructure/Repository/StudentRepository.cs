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
        public IEnumerable<Student> GetByFilter(int active, string name, string rg, string cpf, int? idAluno)
        {
            name = name.ToLower();
            var query = Db.Students.Where(x => x.Active == active);
            if(Util.ValidaString(name))
            {
                query = query.Where(x => x.Name.ToLower().Contains(name));
            }
            if(Util.ValidaRg(rg))
            {
                query = query.Where(x => x.RG == rg);
            }
            if (Util.ValidaCpf(cpf))
            {
                query = query.Where(x => x.CPF == cpf);
            }

            if(idAluno != null && idAluno.HasValue)
            {
                query = query.Where(x => x.StudentId == idAluno.Value);
            }

            return query;
        }

        public IEnumerable<Student> GetAllActive()
        {
            return Db.Students.Where(x => x.Active == 1);
        }

        public int GetCount(int active)
        {
            return Db.Students.Where(x => (x.Active == active)).Count();
        }

        public int CountLateAvaliations => this.LoadLateAvaliations().Count();

        public static int diffDate(String date)
        {
            DateTime? currentDate = System.DateTime.Now;
            int? diff = DbFunctions.DiffDays(Convert.ToDateTime(date), currentDate);
            if(diff == null)
            {
                return 0;
            }
            return Convert.ToInt32(diff);
        }

        public static double ToDateString(DateTime Tick)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            TimeSpan a = new TimeSpan(Tick.Ticks);
            TimeSpan b = new TimeSpan(dtStart.Ticks);
            TimeSpan ts = a.Subtract(b).Duration();
            double dtResult = ts.TotalSeconds;
            return dtResult;
        }


        public int GetCountLatePayments()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Student> LoadLateAvaliations()
        {
            DateTime today = System.DateTime.Now;
            return Db.Students
                .ToList()
                .Where(
                    x => today.Subtract(Convert.ToDateTime(x.EvaliationDate)).Days >= x.EvaluationPeriodicity * 30
                    && x.Active == 1
                )
                .AsEnumerable();
        }

        public IEnumerable<Student> LoadLatePayments()
        {
            // TODO PRECISA DOS PAGAMENTOS PARA VERIFICAR
            throw new System.NotImplementedException();
        }
    }
}