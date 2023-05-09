using Business.Abstracts;
using Business.Dtos.Requests;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate;

public class CourseStudentManager : ICourseStudentService
{
    private ICourseStudentDal courseStudentDal;

    public CourseStudentManager(ICourseStudentDal courseStudentDal)
    {
        this.courseStudentDal = courseStudentDal;
    }
    public async Task Add(CreateCourseStudentRequest createCourseStudentRequest)
    {
        CourseStudent courseStudent = new CourseStudent();
        courseStudent.StudentId = createCourseStudentRequest.StudentId;
        courseStudent.CourseId = createCourseStudentRequest.CourseId;

        await courseStudentDal.AddAsync(courseStudent);
    }
}
