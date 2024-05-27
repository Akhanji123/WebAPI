using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_BLL.DTO;
using UMS_BLL.Rapping;

namespace UMS_BLL.Services.AuthSER
{
    public interface IAuthService
    {
        ApiResponse<bool> Login(LoginDTO obj);
    }
}
