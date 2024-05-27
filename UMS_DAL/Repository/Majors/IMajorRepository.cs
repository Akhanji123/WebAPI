using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_DAL.Models;
using UMS_DAL.Repository._GenericRepository;

namespace UMS_DAL.Repository.Majors
{
    using Entity = Major;
    public interface IMajorRepository : IGenericRepository<Entity>
    {
        Entity GetByName(String name);
        IEnumerable<Entity> GetMajorsByFacultyID(int id);
    }
}
