using SteelGymDesktop.Domain.Entities;
using System.Collections.Generic;

namespace SteelGymDesktop.Domain.Interfaces
{
    public interface IStudentRepository : IRepositoryBase<Student>
    {
        IEnumerable<Student> GetByFilter(int active, string name, string rg, string cpf, int? idAluno);
        IEnumerable<Student> GetAllActive();
        int GetCount(int active);
        IEnumerable<Student> LoadLatePayments();
        IEnumerable<Student> LoadLateAvaliations();
        int GetCountLatePayments();
        int CountLateAvaliations { get; }
    }
}