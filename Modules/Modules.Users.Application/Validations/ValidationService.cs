using System;
using FluentValidation.Results;
using Microsoft.Extensions.DependencyInjection;

namespace Modules.Users.Application.Validations
{
	public class ValidationService
	{
		private readonly IServiceProvider? _serviceProvider;

		public ValidationService()
		{
		}

		public ValidationService(IServiceProvider serviceProvider)
		{
			_serviceProvider = serviceProvider;

        }


		public virtual ValidationResult Validate<T>(T instance)
		{
			var validator = _serviceProvider!.GetService<IValidator<T>>();
			return validator!.Validate(instance);
		}



	}
}

