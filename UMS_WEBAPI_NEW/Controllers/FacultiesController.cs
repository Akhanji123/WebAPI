using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UMS_BLL.DTO;
using UMS_BLL.Rapping;
using UMS_BLL.Services;
using UMS_BLL.Services.FacultySER;
using UMS_BLL.Services.GenericSER;
using UMS_WEBAPI_NEW.Controllers._Generic;


namespace UMS_WEBAPI_NEW.Controllers
{
    [Route("API/[Controller]")]
    [ApiController]
    public class FacultiesController : GenericController<FacultyDTO>
    {
        public readonly IFacultyService _facultyservice;
        public FacultiesController(IFacultyService iGenericBLL) : base(iGenericBLL)
        {
            _facultyservice = iGenericBLL;
        }

        [HttpGet("GetByName")]
        public ApiResponse<FacultyDTO> GetByName(string name)
        {
            return _facultyservice.GetFacultyByName(name);
        }
    }

}