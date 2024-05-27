using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_DAL.Models;

namespace UMS_BLL.DTO
{
    public class FacultyDTO
    {
        public int FacultyId { get; set; }

        public string FacultyName { get; set; }

        public string? FaultyDeanName { get; set; }

        public FacultyDTO()
        { }
        public FacultyDTO(int facultyId, string facultyName, string faultyDeanName)
        {
            FacultyId = facultyId;
            FacultyName = facultyName;
            FaultyDeanName = faultyDeanName;
        }
        public FacultyDTO(int facultyId) : this(facultyId, null, null)
        {

        }
        public FacultyDTO(string facultyName) : this(0, facultyName, null)
        { }
        

    }
}
