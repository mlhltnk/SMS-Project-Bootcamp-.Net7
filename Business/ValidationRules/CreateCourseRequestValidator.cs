using Business.Dtos.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class CreateCourseRequestValidator : AbstractValidator<CreateCourseRequest>
    {
        public CreateCourseRequestValidator()
        {
            RuleFor(c => c.Credit).GreaterThanOrEqualTo(0).LessThanOrEqualTo(5);
            RuleFor(c => c.Name).NotEmpty().NotNull().MinimumLength(2).MaximumLength(50);
            RuleFor(c => c.Shortname).NotEmpty().NotNull().MinimumLength(2).MaximumLength(50);
            

        }
       
        
    }
}
