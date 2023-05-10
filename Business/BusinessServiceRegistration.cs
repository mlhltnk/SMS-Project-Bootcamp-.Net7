using Business.Abstracts;
using Business.Concreate;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business;

public static class BusinessServiceRegistration
{
    public static IServiceCollection AddBusinessService(this IServiceCollection services)
    {
        services.AddScoped<IStudentService, StudentManager>()
            .AddScoped<IInstructorService, InstructorManager>()
            .AddScoped<ICourseDal, EfCourseDal>();
        
        
        return services;
    }
}
