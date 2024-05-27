using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_BLL.Rapping;

namespace UMS_BLL.Services.GenericSER
{
    public interface _IGenericService<DTO> where DTO : class
    {
        ApiResponse<IEnumerable<DTO>> GetAll();
        ApiResponse<DTO> GetById(int id);
        ApiResponse<DTO> Add(DTO dto);
        ApiResponse<DTO> Update(DTO dto);
        ApiResponse<int> Delete(DTO dto);
        ApiResponse<int> Delete(int id);
    }
}
