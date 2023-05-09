using Business.Abstracts;
using Business.Dtos.Requests;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class StudentManager : IStudentService
    {
        private IstudentDal studentdal;

        public StudentManager(IstudentDal studentdal)
        {
            this.studentdal = studentdal;
        }

        public async Task Add(CreateStudentRequest createStudentRequest)
        {
            Student student = new Student();
            //todo : regex yapılacak
            student.StudentNumber = "20231234567";
            student.Firstname = createStudentRequest.Firstname;
            student.Lastname = createStudentRequest.Lastname;
            student.BirthDate = createStudentRequest.BirthDate;
            student.NationalityId= createStudentRequest.NationalityId;
            await studentdal.AddAsync(student);
        }
    }
}
