using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_BLL.DTO;
using UMS_BLL.Services.GenericSER;

namespace UMS_BLL.Services.RoleSER
{
    using DTO = RoleDTO;
    public interface IRoleServices : _IGenericService<DTO> 
    {
    }
}
