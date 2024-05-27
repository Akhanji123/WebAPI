using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_BLL.DTO;
using UMS_BLL.Rapping;
using UMS_BLL.Services.GenericSER;
using UMS_DAL.Models;
using UMS_DAL.Repository.Users;

namespace UMS_BLL.Services.UserSER
{
    using Entity = User;
    using dto = UserDTO;
    public class UserService : _GenericService<dto, Entity>, IUserService
    {
        public readonly IUserRepository _userRepository;
        public UserService(IUserRepository genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
            _userRepository = genericRepository;
        }

        public ApiResponse<bool> Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<bool> Login(LoginDTO loginRequest)
        {
            var response = new ApiResponse<bool>();
            var username = loginRequest.Username;
            var user = _userRepository.getUserByUserName(username);
            if (user == null)
            {
                response.Success = false;
                return response;
            }
            else if(user.Password == loginRequest.Password)
            {
                response.Success = true;
                return response;
            }
            else
            {
                response.Success = false;
                return response;
            }
        }
        public override ApiResponse<int> Delete (int id)
        {
            throw new Exception();
        }
        public override ApiResponse<int> Delete(UserDTO DTO)
        {
            throw new Exception();
        }


    }
}
