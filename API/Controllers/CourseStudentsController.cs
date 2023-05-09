using Business.Abstracts;
using Business.Dtos.Requests;
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

        public async Task<IActionResult> Add([FromBody] CreateCourseStudentRequest createCourseStudentRequest)
        {
            await courseStudentService.Add(createCourseStudentRequest);
            return Ok();
        }
    }
}
