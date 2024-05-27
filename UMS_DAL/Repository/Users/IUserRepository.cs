using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_DAL.Models;
using UMS_DAL.Repository._GenericRepository;

namespace UMS_DAL.Repository.Users
{
    using Entity = User;
    public interface IUserRepository : IGenericRepository<Entity> 
    {
        Entity getUserByUserName(String username);
    }
}
