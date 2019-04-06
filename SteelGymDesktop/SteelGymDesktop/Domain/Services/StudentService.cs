using SteelGymDesktop.Domain.Entities;
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

        public IEnumerable<Student> GetByFilter(int active, string name, string rg, string cpf, int? idAluno)
        {
            return _repository.GetByFilter(active, name, rg, cpf, idAluno);
        }

        public IEnumerable<Student> GetAllActive()
        {
            return _repository.GetAllActive();
        }

        public int GetCount(int active)
        {
            return _repository.GetCount(active);
        }

        public int GetCountLateAvaliations()
        {
            return _repository.GetCountLateAvaliations();
        }

        public int GetCountLatePayments()
        {
            return _repository.GetCountLatePayments();
        }

        public IEnumerable<Student> LoadLateAvaliations()
        {
            return _repository.LoadLateAvaliations();
        }

        public IEnumerable<Student> LoadLatePayments()
        {
            return _repository.LoadLatePayments();
        }
    }
}