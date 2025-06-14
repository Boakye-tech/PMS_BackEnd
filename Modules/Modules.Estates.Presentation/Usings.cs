// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


global using Modules.Estates.Domain;
global using Modules.Estates.Domain.Enums;
global using Modules.Estates.Domain.Interfaces.DomainServices;

global using Modules.Estates.Infrastructure;
global using Modules.Estates.Infrastructure.UnitOfWork;
global using Modules.Estates.Infrastructure.Extensions;

global using Modules.Estates.Application.Interfaces.Entities.Setup.Property;
global using Modules.Estates.Application.Interfaces.Entities.Setup.Customer;
global using Modules.Estates.Application.Interfaces.Management.Customer;
global using Modules.Estates.Application.Interfaces.Management.Property;
global using Modules.Estates.Application.Interfaces.Management.Complaints;

global using Modules.Estates.Application.UseCases.Setup.Property;
global using Modules.Estates.Application.UseCases.Setup.Customer;
global using Modules.Estates.Application.UseCases.Management.Customer;
global using Modules.Estates.Application.UseCases.Registration.Property;

global using Modules.Estates.Application.DTO.Management.Customer;
global using Modules.Estates.Application.DTO.Management.Complaints;
global using Modules.Estates.Application.DTO.Setup.Customer;
global using Modules.Estates.Application.DTO.Setup.Property;

global using Modules.Estates.Application.DomainServices;
global using Modules.Estates.Application.Validations.Setup.Customer;
global using Modules.Estates.Application.Enums;

global using Modules.Common.Infrastructure.Authentication;

global using Modules.Estates.Presentation.Constants;

global using Modules.Estates.Application.DTO;

global using Modules.Estates.Application.DTO.Registration.Property;


global using Modules.Estates.Application.Interfaces.ModuleServices;
global using Modules.Estates.Application.Services;
global using Modules.Estates.Application.UseCases.Management.Complaints;
global using Modules.Estates.Application.UseCases.ModuleServices;
global using Modules.Estates.Domain.Events;

global using Modules.Estates.Application.Interfaces.Entities.Setup;
global using Modules.Estates.Application.UseCases.Setup;
global using Modules.Estates.Application.DTO.Setup;

global using Modules.Estates.Application.Interfaces.ControllerServices;
