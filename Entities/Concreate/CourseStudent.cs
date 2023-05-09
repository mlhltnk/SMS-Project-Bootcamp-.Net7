using Core.Persistens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreate;

public class CourseStudent:Entity<Guid>
{
    public Guid CourseId { get; set; }

    public Guid StudentId { get; set; }

    public virtual Student Student { get; set; }

    public virtual Course Course { get; set; }

    public CourseStudent()
    {
        
    }

    public CourseStudent(Guid id, Guid courseId, Guid studentId):base(id)
    {
        StudentId = courseId;
        CourseId = studentId;
    }
}
