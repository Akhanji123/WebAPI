using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_BLL.DTO;
using UMS_BLL.Rapping;
using UMS_DAL.Repository.Faculties;
using UMS_DAL.Repository.Users;

namespace UMS_BLL.Services.AuthSER
{
    public class AuthService : IAuthService
    {
        public readonly IUserRepository _userRepository;

        public AuthService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public ApiResponse<bool> Login(LoginDTO obj)
        {
            var response = new ApiResponse<bool>();
            var user = _userRepository.getUserByUserName(obj.Username);
            if (obj.Username == null || obj.Password == null)
            {
                throw new Exception();
            }
            if(user == null)
            {
                throw new Exception();
            }
            if (obj.Password != user.Password)
            {
                throw new Exception();
            }

            return response;
        }
    }

}
