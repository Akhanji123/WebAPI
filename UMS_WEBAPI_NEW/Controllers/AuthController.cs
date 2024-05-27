using Microsoft.AspNetCore.Mvc;
using UMS_BLL.DTO;
using UMS_BLL.Rapping;
using UMS_BLL.Services.AuthSER;

namespace UMS_WEBAPI_NEW.Controllers
{
    [Route("API/[Controller]")]
    [ApiController]
    public class AuthController
    {
        public readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpPost]
        public ApiResponse<bool> Login(LoginDTO obj)
        {
            return _authService.Login(obj);
        }
    }
}
