using Business.Abstracts;
using Business.Dtos.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        

            private ICourseService _courseService;

            public CoursesController(ICourseService courseService)
            {
                _courseService = courseService;
            }

            [HttpPost]
            public async Task<IActionResult> Add([FromBody] CreateCourseRequest createdCourseRequest)
            {
                await _courseService.Add(createdCourseRequest);
                return Ok();
            }
        }
    }

