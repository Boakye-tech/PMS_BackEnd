// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Customers.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Dtos/SendNotificationRequestDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 29/05/2025 3:03 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Customers.Application.Dtos;

public record SendNotificationRequestDto(string RecipientContact, string DisplayName, string Subject, string Message, int NotificationType, string UserId);

