using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_BLL.Rapping;
using UMS_DAL.Models;
using UMS_DAL.Repository._GenericRepository;
using UMS_DAL.Repository.Majors;

namespace UMS_BLL.Services.GenericSER
{
    public class _GenericService<DTO, T> : _IGenericService<DTO> where T : class where DTO : class
    {

        public readonly IGenericRepository<T> _genericRepository;
        public readonly IMapper _mapper;
        public _GenericService(IGenericRepository<T> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        #region Get
        public ApiResponse<IEnumerable<DTO>> GetAll()
        {
            var response = new ApiResponse<IEnumerable<DTO>>();
            var result = _genericRepository.GetAll();
            response.Data = _mapper.Map<IEnumerable<DTO>>(result);
            return response;
        }
        public ApiResponse<DTO> GetById(int id)
        {
            var response = new ApiResponse<DTO>();
            var result = _genericRepository.GetByID(id);
            response.Data = _mapper.Map<DTO>(result);
            return response;
        }

        #endregion

        #region Add
        public ApiResponse<DTO> Add(DTO dto)
        {
            var response = new ApiResponse<DTO>();
            try
            {
                if (null == dto)
                    throw new Exception("Null");

                var Entity = _mapper.Map<T>(dto);
                var request = _genericRepository.Add(Entity);
                response.Data = _mapper.Map<DTO>(request);
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessage = ex.Message;
                return response;
            }
        }
        #endregion

        #region update 
        public ApiResponse<DTO> Update(DTO dto)
        {
            var response = new ApiResponse<DTO>();

            try
            {
                var Entity = (_mapper.Map<T>(dto));
                var request = _genericRepository.Update(Entity);
                response.Data = _mapper.Map<DTO>(request);
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessage = ex.Message;
                return response;
            }
        }
        #endregion

        #region Delete
        public virtual ApiResponse<int> Delete(DTO dto)
        {
            var response = new ApiResponse<int>();
            response.Data = _genericRepository.Delete(_mapper.Map<T>(dto));
            return response;

        }

        public virtual ApiResponse<int> Delete(int id)
        {
            var response = new ApiResponse<int>();
            response.Data = _genericRepository.Delete(_mapper.Map<T>(id));
            return response;

        }

        #endregion


    }
}

