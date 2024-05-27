using AutoMapper;
using AutoMapper.Execution;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_BLL.DTO;
using UMS_BLL.Rapping;
using UMS_BLL.Services.GenericSER;
using UMS_DAL.Models;
using UMS_DAL.Repository._GenericRepository;
using UMS_DAL.Repository.Faculties;

namespace UMS_BLL.Services.FacultySER
{
    public class FacultyService : _GenericService<FacultyDTO, Faculty>, IFacultyService
    {
        public readonly IFacultyRepository _facultyRepository;
        public readonly IMapper _mapper;

        public FacultyService(IFacultyRepository genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
            _facultyRepository = genericRepository;
            _mapper = mapper;
        }

        public ApiResponse<FacultyDTO> GetFacultyByName(string name)
        {
            var result = _facultyRepository.GetFacultyByName(name);
            var Responce = new ApiResponse<FacultyDTO>();
            Responce.Data = _mapper.Map<FacultyDTO>(result);
            return Responce;
        }

    }
}
