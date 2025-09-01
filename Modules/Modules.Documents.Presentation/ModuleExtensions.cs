// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Presentation
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Presentation/ModuleExtensions.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 29/08/2025 3:10 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Modules.Documents.Application.Interfaces;
using Modules.Documents.Application.UseCases;
using Modules.Documents.Domain.Interfaces;
using Modules.Documents.Infrastructure.Extensions;
using Modules.Documents.Infrastructure.UnitOfWork;

namespace Modules.Documents.Presentation
{
    public static class ModuleExtensions
    {
        public static IServiceCollection AddDocumentsModule(this IServiceCollection services, IConfiguration configuration, IHostEnvironment environment)
        {
            services
                .AddDocumentsInfrastructure(configuration, environment);

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IFormTemplateService, FormTemplateService>();
            services.AddScoped<IFormSubmissionService, FormSubmissionService>();
            services.AddScoped<IFieldTypeService, FieldTypeService>();

            return services;
        }
	}
}

