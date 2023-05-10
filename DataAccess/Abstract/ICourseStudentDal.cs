using Core.Persistens;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract;

public interface ICourseStudentDal : IAsyncRepository<CourseStudent, Guid>, IRepository<CourseStudent, Guid>
{

}
