using System;
namespace Modules.Users.Application.Validations
{
	public class DepartmentUnitDtoValidator : AbstractValidator<DepartmentUnitCreateDto>
	{
		public DepartmentUnitDtoValidator()
		{
            RuleFor(x => x.DepartmentId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.UnitId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.UnitName).NotEmpty().Length(2, 30).WithMessage("The department unit name must not be empty, null or exceed thirty(30) characters");

        }
    }
}

