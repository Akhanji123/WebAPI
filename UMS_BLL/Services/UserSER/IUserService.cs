using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_BLL.DTO;
using UMS_BLL.Rapping;
using UMS_BLL.Services.GenericSER;
using UMS_DAL.Models;

namespace UMS_BLL.Services.UserSER
{
    using DTO = UserDTO;
    public interface IUserService : _IGenericService<DTO>
    {
        ApiResponse<bool> Login(string username, string password);
        ApiResponse<bool> Login(LoginDTO loginRequest);
    }
}
