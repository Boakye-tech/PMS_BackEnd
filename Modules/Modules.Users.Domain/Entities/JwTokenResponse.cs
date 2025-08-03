// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Users.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Entities/JwTokenResponse.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Users.Domain.Entities
{
	public class JwTokenResponse
	{
		public string? Token { get; set; }
		public DateTime? ExpiresAt { get; set; }
	}
}

