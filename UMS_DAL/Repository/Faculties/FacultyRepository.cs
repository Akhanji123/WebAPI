
using Azure.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_DAL.Models;
using UMS_DAL.Repository._GenericRepository;

namespace UMS_DAL.Repository.Faculties
{
    public class FacultyRepository : GenericRepository<Faculty>, IFacultyRepository
    {
        public FacultyRepository(UniversityMsContext context) : base(context)
        {
        }
        public Faculty GetFacultyByName(string name)
        {
            var result = _dbset.Where(x => x.FacultyName == name).FirstOrDefault();
            return result;
        }
    }
}
