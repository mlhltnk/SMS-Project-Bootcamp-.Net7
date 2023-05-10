using Business.Dtos.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules;

public class CreateStudentRequestValidator : AbstractValidator<CreateStudentRequest>
{
    public CreateStudentRequestValidator()
        {
        RuleFor(c => c.Firstname).NotEmpty().NotNull().MinimumLength(2).MaximumLength(50);
        RuleFor(c => c.Lastname).NotEmpty().NotNull().MinimumLength(2).MaximumLength(50);
        RuleFor(c => c.NationalityId).Length(11).Must(BeNumeric);
        }
    private bool BeNumeric(string arg)
    {
        long nationalityId;
        if(long.TryParse(arg,out nationalityId))
        { return true; 
        }
        return false;
    }
}
