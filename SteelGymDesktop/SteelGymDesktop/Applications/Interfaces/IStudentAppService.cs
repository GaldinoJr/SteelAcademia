using SteelGymDesktop.Domain.Entities;
using System.Collections.Generic;

namespace SteelGymDesktop.Applications.Interfaces
{
    public interface IStudentAppService : IAppServiceBase<Student>
    {
        IEnumerable<Student> GetByFilter(int active, string name, string rg, string cpf, int? idAluno);
        int GetCount(int active);
        IEnumerable<Student> GetAllActive();
        IEnumerable<Student> LoadLatePayments();
        int GetCountLatePayments();
        IEnumerable<Student> LoadLateAvaliations();
        int GetCountLateAvaliations();
    }
}
