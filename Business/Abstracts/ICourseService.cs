using Business.Dtos.Requests;
<<<<<<< HEAD
using Business.Dtos.Response;
=======
>>>>>>> 7d9f326c1951c01f3ffeed197666975fde626a29
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public interface ICourseService
{
    Task Add(CreateCourseRequest createCourseRequest);
<<<<<<< HEAD
    Task<GetListResponse<CourseResponse>> GetAll(PageRequests pageRequests);
=======
>>>>>>> 7d9f326c1951c01f3ffeed197666975fde626a29
}
