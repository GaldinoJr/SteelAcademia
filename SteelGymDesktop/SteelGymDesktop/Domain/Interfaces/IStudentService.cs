using SteelGymDesktop.Domain.Entities;
using System.Collections.Generic;

namespace SteelGymDesktop.Domain.Interfaces
{
    public interface IStudentService : IServiceBase<Student>
    {
        IEnumerable<Student> GetByFilter(bool active, string name, string rg, string cpf);
    }
}
