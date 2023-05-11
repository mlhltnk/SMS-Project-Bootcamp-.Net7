using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Response;
using Business.ValidationRules;
using Core.Aspects.Validation;
using Core.Paging;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class StudentManager : IStudentService
    {
        private IstudentDal studentdal;
        private IMapper mapper;

        public StudentManager(IstudentDal studentdal, IMapper mapper)
        {
            this.studentdal = studentdal;
            this.mapper = mapper;
        }

        [ValidationAspect(typeof(CreateStudentRequestValidator))]
        public async Task Add(CreateStudentRequest createStudentRequest)
        {

            Student student = mapper.Map<Student>(createStudentRequest);
                
                
            //todo : regex yapılacak
<<<<<<< HEAD
            
=======
            student.StudentNumber = "20231234567";
            student.Firstname = createStudentRequest.Firstname;
            student.Lastname = createStudentRequest.Lastname;
            student.BirthDate = createStudentRequest.BirthDate;
            student.NationalityId= createStudentRequest.NationalityId;
>>>>>>> 7d9f326c1951c01f3ffeed197666975fde626a29
            await studentdal.AddAsync(student);
        }

        public async Task<GetListResponse<StudentResponse>>GetAll(PageRequests pageRequest)
        {
            IPaginate<Student> result = await studentdal.GetListAsync(index:pageRequest.Index,size:pageRequest.Size);

           return mapper.Map<GetListResponse<StudentResponse>>(result);

        }
    }
}
