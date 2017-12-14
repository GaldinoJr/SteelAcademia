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
            IQueryable<Student> query = Db.Students;

            query.Where(x => x.Active == active);

            if (Util.ValidaString(name))
                query = query.Where(x => x.Name.Contains(name));

            if (Util.ValidaString(rg))
                query = query.Where(x => x.RG == rg);

            if (Util.ValidaString(cpf))
                query = query.Where(x => x.CPF == cpf);

            return query;
        }
    }
}
