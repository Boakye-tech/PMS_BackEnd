// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Setup/Paypoints.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Domain.Entities.Setup;

public class Paypoints : AuditableEntity
{
	[Key]
	[Required]
	public int PaypointId { get; private set; }

	[Required]
	[StringLength(30)]
	public string? Paypoint { get; private set; }

	public Paypoints(int paypointId, string paypoint)
	{
		PaypointId = paypointId;
		Paypoint = paypoint;
	}

	public static Paypoints Create(int paypointId, string paypoint)
	{
		Validate(paypointId, paypoint);
		return new Paypoints(paypointId, paypoint);
	}

	public void Update(int paypointId, string paypoint)
	{
		Validate(paypointId, paypoint);
		Paypoint = paypoint;
	}

	private static void Validate(int paypointId, string paypoint)
	{
		if (paypointId <= 0)
			throw new ArgumentException("The pay point id must be greater than zero.");

		if (string.IsNullOrWhiteSpace(paypoint) || paypoint.Length > 30)
			throw new ArgumentException("The pay point must not be null or exceed 30 characters.");
	}
}

