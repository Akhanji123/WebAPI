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
using UMS_DAL.Repository._GenericRepository;
using UMS_DAL.Repository.Majors;

namespace UMS_BLL.Services.MajorSER
{
    using DTO = MajorDTO;
    using Entity = Major;
    public class MajorServices : _GenericService<DTO, Entity>, IMajorServices
    {
        public readonly IMajorRepository _majorRepository;
        public readonly IMapper _mapper;

        public MajorServices(IMajorRepository genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
            _majorRepository = genericRepository;
            _mapper = mapper;
        }

        public ApiResponse<DTO> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IEnumerable<DTO>> GetMajorsByFacultyID(int id)
        {
           var result = _majorRepository.GetMajorsByFacultyID(id);
            var response = new ApiResponse<IEnumerable<DTO>>();
            response.Data = _mapper.Map<List<DTO>>(result);
            return response;
        }
    }
}
