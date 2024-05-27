using Microsoft.EntityFrameworkCore;
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
    public class MajorRepository : GenericRepository<Entity>, IMajorRepository
    {

        public MajorRepository(UniversityMsContext context) : base(context)
        {
        }

        public Entity GetByName(string name)
        {
            return _dbset.Where(x => x.MajorName == name).FirstOrDefault();
        }
        public IEnumerable<Entity> GetMajorsByFacultyID(int id)
        {
            return _dbset.Where(x => x.FacultyId == id).IgnoreAutoIncludes().ToList();
        }
    }
}
