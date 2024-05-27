using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_BLL.DTO;
using UMS_BLL.Services.GenericSER;
using UMS_BLL.Services.MajorSER;
using UMS_DAL.Models;
using UMS_DAL.Repository._GenericRepository;
using UMS_DAL.Repository.Roles;

namespace UMS_BLL.Services.RoleSER
{
    using DTO = RoleDTO;
    using Entity = Role;
    public class RoleServices : _GenericService<DTO, Entity>, IRoleServices
    {
       public readonly IRoleRepository _roleRepository;
        public RoleServices(IRoleRepository genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}
