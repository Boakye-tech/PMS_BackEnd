// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Users.Application.Shared
{
    public abstract record LoginResponse
    {
        public required string UserId { get; set; }
        public bool IsFirstTime { get; set; }
        public required string BearerToken { get; set; }
        public required string RefreshToken { get; set; }
        public DateTime? ExpiresAt { get; set; }

    }
}

