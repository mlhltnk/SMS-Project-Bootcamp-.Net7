using Core.Persistens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreate;

public class Course:Entity<Guid> 
{
    public string Name { get; set; }
    public string Shortname { get; set; }
    public int Credit { get; set; }

    public ICollection<CourseStudent> CourseStudents { get; set; }

    public Course()
    {
        
    }

    public Course(Guid id, string name, string shortname, int credit):this()
    {
        Id = id;
        Name = name;
        Shortname = shortname;
        Credit = credit;
    }


}
