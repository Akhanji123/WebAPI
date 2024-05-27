using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_DAL.Models;
using UMS_DAL.Repository._GenericRepository;


namespace UMS_DAL.Repository.Roles
{
    using Entity = Role;
    public class RoleRepository : GenericRepository<Entity>, IRoleRepository
    {
        public RoleRepository(UniversityMsContext context) : base(context)
        {
        }
    }
}
