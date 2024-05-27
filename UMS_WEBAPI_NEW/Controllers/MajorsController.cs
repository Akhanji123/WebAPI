using Microsoft.AspNetCore.Mvc;
using UMS_BLL.DTO;
using UMS_BLL.Rapping;
using UMS_BLL.Services.GenericSER;
using UMS_BLL.Services.MajorSER;
using UMS_WEBAPI_NEW.Controllers._Generic;

namespace UMS_WEBAPI_NEW.Controllers
{
    public class MajorsController : GenericController<MajorDTO>
    {
        public readonly IMajorServices _majorServices;
        public MajorsController(IMajorServices iGenericBLL) : base(iGenericBLL)
        {
            _majorServices = iGenericBLL;
        }

        [HttpGet("GetByFacultyID")]
        public ApiResponse<IEnumerable<MajorDTO>> GetMajorsByFacultyID(int facultyID)
        {
            return _majorServices.GetMajorsByFacultyID(facultyID);
        }
    }

}
