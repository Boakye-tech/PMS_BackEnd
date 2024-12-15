using System;

namespace Modules.Users.Application.Validations
{
	public class DepartmentDtoValidator : AbstractValidator<Department>
    {
		public DepartmentDtoValidator()
		{
            RuleFor(x => x.DepartmentId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.DepartmentName).NotEmpty().Length(2, 50).WithMessage("The department name must not be empty, null or exceed fifty(50) characters");

        }
    }
}

