using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_BLL.DTO;
using UMS_BLL.Rapping;
using UMS_BLL.Services.GenericSER;

namespace UMS_BLL.Services.MajorSER
{
    using DTO = MajorDTO;
    public interface IMajorServices : _IGenericService<DTO>
    {
        ApiResponse<DTO> GetByName(String name);
        ApiResponse<IEnumerable<DTO>> GetMajorsByFacultyID(int facultyID);
    }
}
