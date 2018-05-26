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
        public IEnumerable<Student> GetByFilter(int active, string name, string rg, string cpf)
        {
            return Db.Students.Where(x => x.Active == active || x.Name == name || x.RG == rg || x.CPF == cpf);
        }

        public int GetCount(int active)
        {
            return Db.Students.Where(x => (x.Active == active)).Count();
        }

        public int GetCountLateAvaliations()
        {
            // todo é preciso arrumar
            return 0;
            //return Db.Students.Where(x =>
            //    (x.EvaliationDate != null && diffDate(x.EvaliationDate) >= (x.EvaluationPeriodicity * 30)) &&
            //    x.Active == 1
            //).Count();
        }

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
            DateTime? currentDate = System.DateTime.Now;
            return Db.Students.Where(x =>
                DbFunctions.DiffDays(Convert.ToDateTime(x.EvaliationDate), currentDate) >= (x.EvaluationPeriodicity * 30) &&
                x.Active == 1
            );
        }

        public IEnumerable<Student> LoadLatePayments()
        {
            // TODO PRECISA DOS PAGAMENTOS PARA VERIFICAR
            throw new System.NotImplementedException();
        }
    }
}