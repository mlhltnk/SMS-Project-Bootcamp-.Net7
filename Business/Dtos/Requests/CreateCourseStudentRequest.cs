using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests;

public class CreateCourseStudentRequest
{
    public Guid CourseId { get; set; }
    public Guid StudentId { get; set; }
}
