// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


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

