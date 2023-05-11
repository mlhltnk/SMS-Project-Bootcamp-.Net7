using Business.Abstracts;
using Business.Dtos.Requests;
<<<<<<< HEAD
using Business.Dtos.Response;
=======
>>>>>>> 7d9f326c1951c01f3ffeed197666975fde626a29
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseStudentsController : ControllerBase
    {
        private ICourseStudentService courseStudentService;

        public CourseStudentsController(ICourseStudentService courseStudentService)
        {
            this.courseStudentService = courseStudentService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCourseStudentRequest createCourseStudentRequest)
        {
            await courseStudentService.Add(createCourseStudentRequest);
            return Ok();
        }
<<<<<<< HEAD

        [HttpGet]
        public Task<GetListResponse<CourseStudentResponse>> GetAll([FromQuery] PageRequests pageRequests)
        {
            return courseStudentService.GetAll(pageRequests);
        }
=======
>>>>>>> 7d9f326c1951c01f3ffeed197666975fde626a29
    }
}
