using Core.Persistens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities.Concreate;

public class Student: Entity<Guid>
{
    public string StundentNumber { get; set; }
    public string? NationalityId { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public DateTime BirthDate { get; set; }
    public bool Status { get; set; }

    public ICollection<CourseStudent> CourseStudents { get; set; }   //coursestudents:studentın kayıt olduğu dersler
    

    public Student()
    {
        CourseStudents= new HashSet<CourseStudent>();
    }

    public Student(Guid id, string studentNumber, string nationalityId,string firstName, 
        string lastName, DateTime BirtDate, bool status) : this()
    {
       Id = id;
        StundentNumber = studentNumber;
        NationalityId = nationalityId;
        Firstname = firstName;
        Lastname = lastName;
        BirthDate = BirtDate;
        Status = status;
    }

}
