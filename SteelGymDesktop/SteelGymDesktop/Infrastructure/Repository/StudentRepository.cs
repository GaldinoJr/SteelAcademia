using SteelGymDesktop.Domain.Entities;
using SteelGymDesktop.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SteelGymDesktop.Infrastructure.Repository
{
    public class StudentRepository : RepositoryBase<Student>, IStudentRepository
    {
        public IEnumerable<Student> GetByFilter(bool active, string name, string rg, string cpf)
        {
            return Db.Students.Where(x => x.Active == active || x.Name == name || x.RG == rg || x.CPF == cpf);
        }
    }
}
