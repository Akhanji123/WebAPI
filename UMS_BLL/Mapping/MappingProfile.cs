using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_BLL.DTO;
using UMS_DAL.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace UMS_BLL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<FacultyDTO, Faculty>().ReverseMap();
            CreateMap<MajorDTO, Major>().ReverseMap();
            CreateMap<UserDTO, User>().ReverseMap();
            CreateMap<RoleDTO, Role>().ReverseMap();    
            
        }
    }
}
