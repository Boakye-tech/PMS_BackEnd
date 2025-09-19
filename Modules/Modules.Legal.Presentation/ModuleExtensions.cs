// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Legal.Presentation
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Legal.Presentation/ModuleExtensions.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/09/2025 5:11 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using FluentValidation;
using Modules.Legal.Application.Interfaces.Setups;
using Modules.Legal.Application.UseCases.Setups;
using Modules.Legal.Domain.Interfaces;
using Modules.Legal.Infrastructure.Extensions;
using Modules.Legal.Infrastructure.UnitOfWork;

namespace Modules.Legal.Presentation
{
    public static class ModuleExtensions
    {
        public static IServiceCollection AddLegalModule(this IServiceCollection services, IConfiguration configuration, IHostEnvironment environment)
        {
            services
                //.AddCatalogCore()
                .AddLegalInfrastructure(configuration, environment);

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<ICaseTypeService, CaseTypeService>();

            services.AddScoped<IConsentTypeService, ConsentTypeService>();
            services.AddScoped<ICourtService, CourtService>();
            services.AddScoped<ICourtDivisionService, CourtDivisionService>();
            services.AddScoped<IStatusTypeService, StatusTypeService>();
            services.AddScoped<ITransferTypeService, TransferTypeService>();



            return services;
        }
    }
}

