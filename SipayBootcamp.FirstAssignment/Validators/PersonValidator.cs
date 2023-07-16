using FluentValidation;
using SipayBootcamp.FirstAssignment.Models;

namespace SipayBootcamp.FirstAssignment.Validators
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        { 
            RuleFor(p => p.Name).NotEmpty().WithMessage("Name is required.").Length(5, 100).WithMessage("The name must contain at least 5 and no more than 100 characters.");
            RuleFor(p => p.LastName).NotEmpty().WithMessage("Last name is required.").Length(5, 100).WithMessage("The last name must contain at least 5 and no more than 100 characters.");
            RuleFor(p => p.AccessLevel).NotEmpty().WithMessage("Access level is required.").InclusiveBetween(1, 5).WithMessage("Access level must be between 1 and 5.");
            RuleFor(p => p.Phone).NotNull().NotEmpty().WithMessage("Phone number is required.").Matches("/\\(?([0-9]{3})\\)?([ .-]?)([0-9]{3})\\2([0-9]{4})/").WithMessage("The phone number must be numerical.");
            RuleFor(p => p.Salary).NotNull().NotEmpty().WithMessage("Salary is required.").InclusiveBetween(5000, 50000).WithMessage("Salary must be between 5000 and 50000");

        }    
    }
}
