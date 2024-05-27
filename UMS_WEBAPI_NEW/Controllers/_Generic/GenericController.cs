using Microsoft.AspNetCore.Mvc;
using UMS_BLL.DTO;
using UMS_BLL.Rapping;
using UMS_BLL.Services.GenericSER;
using UMS_DAL.Repository._GenericRepository;

namespace UMS_WEBAPI_NEW.Controllers._Generic
{
    [Route("API/[Controller]")]
    [ApiController]
    public class GenericController<DTO> : Controller  where DTO : class
    {
        public readonly _IGenericService<DTO> _Service;

        public GenericController(_IGenericService<DTO> iGenericBLL)
        {
            _Service = iGenericBLL;
        }

        #region Get
        [HttpGet("GETAll")]
        public ApiResponse<IEnumerable<DTO>> GetAllFaculty()
        {
            return _Service.GetAll();
        }
   
        [HttpGet("GetByID")]
        public ApiResponse<DTO> GetByID(int id)
        {
            return _Service.GetById(id);
        }

        #endregion

        #region Add 
        [HttpPost("ADD")]
        public ApiResponse<DTO> Add(DTO dto)
        {
            return _Service.Add(dto);
        }
        #endregion

        #region Update
        [HttpPut("Update")]
        public ApiResponse<DTO> Update(DTO dto)
        {
            return _Service.Update(dto);
        }
        #endregion

        #region Delete
        [HttpDelete("Delete")]
        public ApiResponse<int> Delete(DTO dto)
        {
            return _Service.Delete(dto);
        }

        [HttpDelete("DeleteByID")]
        public ApiResponse<int> Delete(int id)
        {
            return _Service.Delete(id);
        }
        #endregion
    }
}
