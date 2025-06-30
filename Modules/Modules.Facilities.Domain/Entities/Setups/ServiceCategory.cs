// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Domain/Entities/Setups/ServiceCategory.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/06/2025 8:57 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Domain.Entities.Setups;

public class ServiceCategory : AuditableEntity
{
	[Key]
	[Required]
	public int ServiceCategoryId { get; private set; }

    [Required]
    public int CategoryId { get; private set; }

    // Navigation property for Category
    public virtual Category? Category { get; private set; }

    [Required]
	public int ServiceId { get; private set; }

	// Navigation property for Services
	public virtual Services? Services { get; private set; }

	public ServiceCategory(int serviceCategoryId, int categoryId, int serviceId)
	{
		ServiceCategoryId = serviceCategoryId;
		CategoryId = categoryId;
        ServiceId = serviceId;
	}

	public static ServiceCategory Create(int serviceCategoryId, int categoryId, int serviceId)
	{
		Validate(serviceCategoryId, categoryId, serviceId);
		return new ServiceCategory(serviceCategoryId, categoryId, serviceId);
	}

	public void Update(int serviceCategoryId, int categoryId, int serviceId)
	{
		Validate(serviceCategoryId, categoryId, serviceId);

		ServiceCategoryId = serviceCategoryId;
		ServiceId = serviceId;
	}

	private static void Validate(int serviceCategoryId, int categoryId, int serviceId)
	{
		if (serviceCategoryId < 0 || serviceId < 0)
		{
			throw new ArgumentException("Service Category data is invalid.");
		}

		if (serviceCategoryId < 0)
			throw new ArgumentException("Service Category ID must be greater than zero.");

        if (categoryId < 0)
            throw new ArgumentException("Service Category ID must be greater than zero.");

        if (serviceId <= 0)
			throw new ArgumentException("Service ID must be greater than zero.");
	}
}

