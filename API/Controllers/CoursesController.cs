﻿using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {

        private ICourseService courseService;


        public CoursesController(ICourseService courseService)
        {
            this.courseService = courseService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCourseRequest createCourseRequest)
        {
            await courseService.Add(createCourseRequest);
            return Ok();
        }

        [HttpGet]
        public Task<GetListResponse<CourseResponse>> GetAll([FromQuery] PageRequests pageRequests)
        {

            return courseService.GetAll(pageRequests);
        }
}
}
