// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Customers.Application.Dtos.Complaints
{
    public class ComplaintCreatedDto
    {
        public string ComplaintNumber { get; set; } = string.Empty;
        public string CreatedBy { get; set; } = string.Empty;
        public string PropertyNumber { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}