using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using UMS_BLL.DTO;
using UMS_BLL.Rapping;
using UMS_BLL.Services.UserSER;
using UMS_WEBAPI_NEW.Controllers._Generic;

namespace UMS_WEBAPI_NEW.Controllers
{
    public class UsersController : GenericController<UserDTO>
    {
        public readonly IUserService _userService;
        public UsersController(IUserService iGenericBLL) : base(iGenericBLL)
        {
            _userService = iGenericBLL;
        }
   /*     [HttpPost("Login")]
        public ApiResponse<bool> Login(LoginDTO loginRequest)
        {
            return _userService.Login(loginRequest);
        }*/

/*        [HttpGet("Login1")]
        public bool Login1(LoginRequest loginRequest)
        {
            return _userService.Login(loginRequest.Username, loginRequest.Password) ;
        }*/
    }
}
