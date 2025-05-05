// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


global using System;
global using System.ComponentModel.DataAnnotations;

global using Modules.Estates.Domain.Entities.Setup.Property;
global using Modules.Estates.Domain.Entities.Setup.Customer;
global using Modules.Estates.Domain.Entities.Registration;
global using Modules.Estates.Domain.Entities.Management;

global using Modules.Estates.Domain.Interfaces.Entities.Setup.Property;
global using Modules.Estates.Domain.Interfaces.Entities.Setup.Customer;
global using Modules.Estates.Domain.Interfaces.Management;
global using Modules.Estates.Domain.Interfaces.Registration;
global using Modules.Estates.Domain.Interfaces.DomainServices;

global using Modules.Estates.Domain.Enums;
global using Modules.Estates.Domain.Events;
global using Modules.Estates.Domain.Events.Customer;
global using Modules.Estates.Domain.Constants;


global using Modules.Estates.Domain.Events.Complaints;
