using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS_BLL.Rapping
{
    public class ApiResponse<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        public string Meesage { get; set; }
        public string ErrorMessage { get; set; }

        public ApiResponse()
        {
            Success = true;
            Meesage = "200";
        }
       


    }
}
