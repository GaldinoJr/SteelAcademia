using SteelGymDesktop.Domain.Entities;
using System.Collections.Generic;

namespace SteelGymDesktop.Applications.Interfaces
{
    public interface IStudentAppService : IAppServiceBase<Student>
    {
        IEnumerable<Student> GetByFilter(bool active, string name, string rg, string cpf);
        int GetCount(bool active);
    }
}
