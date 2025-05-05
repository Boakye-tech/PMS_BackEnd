// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Domain.Entities
{
	public class ApplicationModules
	{
        [Key]
		[StringLength(12)]
		public string? ModuleId { get; set; }

        [StringLength(20)]
        public string? ModuleName { get; set; }

        public ApplicationModules(string moduleId, string moduleName)
        {
            ModuleId = moduleId;
            ModuleName = moduleName;
        }

        public static ApplicationModules CreateUpdate(string moduleId, string moduleName)
        {
            if (string.IsNullOrWhiteSpace(moduleId) || string.IsNullOrWhiteSpace(moduleName))
            {
                throw new ArgumentException("Invalid application modules data.");
            }

            if (string.IsNullOrWhiteSpace(moduleId) || moduleId.Length > 12)
                throw new ArgumentException("The application module id must not be null or exceed 12 characters.");

            if (string.IsNullOrWhiteSpace(moduleName) || moduleName.Length > 20)
                throw new ArgumentException("The application module name must not be null or exceed 20 characters.");

            return new ApplicationModules(moduleId, moduleName);
        }
    }


}

