using UMS_BLL.DTO;
using UMS_BLL.Services.GenericSER;
using UMS_BLL.Services.RoleSER;
using UMS_DAL.Models;
using UMS_WEBAPI_NEW.Controllers._Generic;

namespace UMS_WEBAPI_NEW.Controllers
{
    public class RolesController : GenericController<RoleDTO>
    {
        public readonly IRoleServices _roleServices;
        public RolesController(IRoleServices iGenericBLL) : base(iGenericBLL)
        {
        }
    }
}
