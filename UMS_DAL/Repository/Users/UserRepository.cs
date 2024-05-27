using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_DAL.Models;
using UMS_DAL.Repository._GenericRepository;
using UMS_DAL.Repository.Majors;

namespace UMS_DAL.Repository.Users
{
    using Entity = User;
    public class UserRepository : GenericRepository<Entity>, IUserRepository
    {
        public UserRepository(UniversityMsContext context) : base(context)
        {
        }

        public Entity getUserByUserName(string username)
        {
            return _dbset.Where(x => x.Username == username).FirstOrDefault();
        }
    }
}
