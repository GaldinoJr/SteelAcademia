using SteelGymDesktop.Domain.Entities;
using System.Collections.Generic;

namespace SteelGymDesktop.Domain.Interfaces
{
    public interface IStudentRepository : IRepositoryBase<Student>
    {
        IEnumerable<Student> GetByFilter(bool active, string name, string rg, string cpf);
        int GetCount(bool active);
    }
}
