using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests;

public class CreateCourseRequest
{
    public string Name { get; set; }
    public string Shortname { get; set; }
    public int Credit { get; set; }
}
