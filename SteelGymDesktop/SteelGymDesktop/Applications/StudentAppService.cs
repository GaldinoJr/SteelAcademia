using SteelGymDesktop.Applications.Interfaces;
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

        public IEnumerable<Student> GetByFilter(int active, string name, string rg, string cpf)
        {
            return _service.GetByFilter(active, name, rg, cpf);
        }

        public IEnumerable<Student> GetAllActive()
        {
            return _service.GetAllActive();
        }

        public int GetCount(int active)
        {
            return _service.GetCount(active);
        }

        public int GetCountLateAvaliations()
        {
            return _service.GetCountLateAvaliations();
        }

        public int GetCountLatePayments()
        {
            return _service.GetCountLatePayments();
        }

        public IEnumerable<Student> LoadLateAvaliations()
        {
            return _service.LoadLateAvaliations();
        }

        public IEnumerable<Student> LoadLatePayments()
        {
            return _service.LoadLatePayments();
        }

    }
}
