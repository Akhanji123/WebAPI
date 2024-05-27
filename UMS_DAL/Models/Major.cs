using System;
using System.Collections.Generic;

namespace UMS_DAL.Models;

public partial class Major
{
    public int MajorId { get; set; }

    public string MajorName { get; set; } = null!;

    public int FacultyId { get; set; }

    public virtual Faculty Faculty { get; set; } = null!;
}
