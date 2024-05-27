using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_DAL.Models;

namespace UMS_BLL.DTO
{
    public class MajorDTO
    {
        public int MajorId { get; set; }

        public string MajorName { get; set; } = null!;

        public int FacultyId { get; set; }

        public MajorDTO()
        { }
        public MajorDTO(int MajorId, string MajorName, int FacultyId)
        {
            this.MajorId = MajorId;
            this.MajorName = MajorName;
            this.FacultyId = FacultyId;
        }
        public MajorDTO(int MajorId) : this(MajorId, null, 0)
        { }

        /* public MajorDTO(int FacultyId) : this(0, null, FacultyId)
         { }*/
        //my frist solution
        //  public MajorDTO(FacultyDTO facultydto) : this(0,null, facultydto.FacultyId) { }
        /* // my second solution 
         public MajorDTO(int id) :this (id,null,id) { }*/
        public MajorDTO(string MajorName) : this(0, MajorName, 0)
        { }


    }
}
