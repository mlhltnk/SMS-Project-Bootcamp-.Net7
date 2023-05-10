using Core.Paging;
using Core.Persistens;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract;

public interface IInstructorDal : IAsyncRepository<Instructor, Guid>, IRepository<Instructor, Guid>

{
   
}
