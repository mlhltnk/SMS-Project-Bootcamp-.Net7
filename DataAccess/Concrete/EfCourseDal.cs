using Core.Persistens;
using DataAccess.Abstract;
using DataAccess.Contexts;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfCourseDal:EfRepositoryBase<Course,Guid,BaseDbContext>,ICourseDal
    {
        public EfCourseDal(BaseDbContext context): base(context)
        {

        }
    }
}
