using Core.Persistens;
using DataAccess.Abstract;
using DataAccess.Contexts;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete;

public class EfInstructorDal : EfRepositoryBase<Instructor, Guid, BaseDbContext>, IInstructorDal
{
    public EfInstructorDal(BaseDbContext context) : base(context)
    {
    }
}
