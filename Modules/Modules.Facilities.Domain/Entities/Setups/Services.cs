// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Domain/Entities/Setups/Services.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/06/2025 8:57 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Domain.Entities.Setups;

public class Services : AuditableEntity
{
	[Key]
	[Required]
	public int ServiceId { get; private set; }

	[Required]
	[StringLength(100)]
	public string? ServiceName { get; private set; }

	public Services()
	{
	}

	public Services(int serviceId, string? serviceName)
	{
		ServiceId = serviceId;
		ServiceName = serviceName;
	}

	public static Services Create(int serviceId, string serviceName)
	{
		Validate(serviceId, serviceName);
		return new Services(serviceId, serviceName);
	}

	public void Update(int serviceId, string serviceName)
	{
		Validate(serviceId, serviceName);

		ServiceId = serviceId;
		ServiceName = serviceName;
	}

	private static void Validate(int serviceId, string serviceName)
	{
		if (serviceId < 0 || string.IsNullOrWhiteSpace(serviceName))
		{
			throw new ArgumentException("Service data is invalid.");
		}

		if (serviceId < 0)
			throw new ArgumentException("Service ID must be greater than zero.");

		if (string.IsNullOrWhiteSpace(serviceName) || serviceName.Length > 100)
			throw new ArgumentException("Service Name cannot be empty or exceed 100 characters.");
	}
}

