<<<<<<< HEAD
﻿using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Response;
using Business.ValidationRules;
using Core.Aspects.Validation;
using Core.Paging;
=======
﻿using Business.Abstracts;
using Business.Dtos.Requests;
>>>>>>> 7d9f326c1951c01f3ffeed197666975fde626a29
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
<<<<<<< HEAD
    private IMapper mapper;

    public CourseStudentManager(ICourseStudentDal courseStudentDal, IMapper mapper)
    {
        this.courseStudentDal = courseStudentDal;
        this.mapper = mapper;
    }
    [ValidationAspect(typeof(CreateCourseStudentRequestValidator))]
    public async Task Add(CreateCourseStudentRequest createCourseStudentRequest)
    {
        CourseStudent courseStudent = mapper.Map<CourseStudent>(createCourseStudentRequest);

        await courseStudentDal.AddAsync(courseStudent);
    }

    public async Task<GetListResponse<CourseStudentResponse>> GetAll(PageRequests pageRequests)
    {
        IPaginate<CourseStudent> result = await courseStudentDal.GetListAsync(index: pageRequests.Index, size: pageRequests.Size);

        return mapper.Map<GetListResponse<CourseStudentResponse>>(result);
    
            
   }

   


=======

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
>>>>>>> 7d9f326c1951c01f3ffeed197666975fde626a29
}
