using Business.Abstracts;
using Business.Concreate;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Business;

public static class BusinessServiceRegistration
{
    public static IServiceCollection AddBusinessService(this IServiceCollection services)
    {
        services.AddScoped<IStudentService, StudentManager>()
            .AddScoped<IInstructorService, InstructorManager>()
            .AddScoped<ICourseService, CourseManager>()
            .AddScoped<ICourseStudentService, CourseStudentManager>()
            ;
<<<<<<< HEAD

        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

=======
        
>>>>>>> 7d9f326c1951c01f3ffeed197666975fde626a29
        return services;
    }
}
