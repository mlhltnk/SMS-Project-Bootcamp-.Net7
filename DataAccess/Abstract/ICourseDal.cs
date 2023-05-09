using Core.Persistens;
using DataAccess.Contexts;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract;

public interface ICourseDal:IAsyncRepository<Course,Guid>,IRepository<Course,Guid>
{
}
