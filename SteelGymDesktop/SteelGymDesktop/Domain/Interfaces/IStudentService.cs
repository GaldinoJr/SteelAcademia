using SteelGymDesktop.Domain.Entities;
using System.Collections.Generic;

namespace SteelGymDesktop.Domain.Interfaces
{
    public interface IStudentService : IServiceBase<Student>
    {
        IEnumerable<Student> GetByFilter(bool active, string name, string rg, string cpf);
        int GetCount(bool active);
        IEnumerable<Student> LoadLatePayments();
        IEnumerable<Student> LoadLateAvaliations();
        int GetCountLatePayments();
        int GetCountLateAvaliations();
    }
}