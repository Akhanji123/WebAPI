using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_BLL.DTO;
using UMS_BLL.Rapping;
using UMS_BLL.Services.GenericSER;

namespace UMS_BLL.Services.FacultySER
{
    public interface IFacultyService : _IGenericService<FacultyDTO>
    {
        ApiResponse<FacultyDTO> GetFacultyByName(string name);
    }
}
