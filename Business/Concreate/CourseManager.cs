<<<<<<< HEAD
﻿using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Response;
using Business.ValidationRules;
using Core.Aspects.Validation;
using Core.Paging;
using DataAccess.Abstract;
using DataAccess.Concrete;
=======
﻿using Business.Abstracts;
using Business.Dtos.Requests;
using DataAccess.Abstract;
>>>>>>> 7d9f326c1951c01f3ffeed197666975fde626a29
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate;

public class CourseManager : ICourseService
{
    private ICourseDal courseDal;
<<<<<<< HEAD
    private IMapper mapper;

    public CourseManager(ICourseDal courseDal, IMapper mapper)
    {
        this.courseDal = courseDal;
        this.mapper = mapper;
    }

    [ValidationAspect(typeof(CreateCourseRequestValidator))]
    public async Task Add(CreateCourseRequest createCourseRequest)
    {
        Course course = mapper.Map<Course>(createCourseRequest);

         await  courseDal.AddAsync(course);
    }

    public async Task<GetListResponse<CourseResponse>> GetAll(PageRequests pageRequests)
    {
        IPaginate<Course> result = await courseDal.GetListAsync(index: pageRequests.Index, size: pageRequests.Size);

        return mapper.Map<GetListResponse<CourseResponse>>(result);

    }
=======

    public CourseManager(ICourseDal courseDal)
    {
        this.courseDal = courseDal;
    }

    public async Task Add(CreateCourseRequest createCourseRequest)
    {
        Course course =new Course();

        course.Name = createCourseRequest.Name;
        course.Shortname = createCourseRequest.Shortname;
        course.Credit = createCourseRequest.Credit;

         await  courseDal.AddAsync(course);
    }
>>>>>>> 7d9f326c1951c01f3ffeed197666975fde626a29
}

