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
    public class CoursesController : ControllerBase
    {

        private ICourseService courseService;

<<<<<<< HEAD

=======
>>>>>>> 7d9f326c1951c01f3ffeed197666975fde626a29
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
<<<<<<< HEAD

        [HttpGet]
        public Task<GetListResponse<CourseResponse>> GetAll([FromQuery] PageRequests pageRequests)
        {

            return courseService.GetAll(pageRequests);
        }
}
=======
    }
>>>>>>> 7d9f326c1951c01f3ffeed197666975fde626a29
}
